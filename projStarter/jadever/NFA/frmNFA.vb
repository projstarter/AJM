Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.IO.Ports
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmNFA

    Dim transactionpro_status As String = ""
    Dim pending_status As String = ""
    Dim completed_status As String = ""

    Private Sub btnpendingexport_Click(sender As Object, e As EventArgs) Handles btnpendingexport.Click
        ExportCSV(getPendingTransactionQuery, "Pending")
    End Sub
    Private Sub btncompletedexport_Click(sender As Object, e As EventArgs) Handles btncompletedexport.Click
        ExportCSV(getCompletedTransactionQuery, "Completed")
    End Sub

    Dim activeDtg As DataGridView

    Public Function getPendingTransactionQuery(Optional ByVal top_cnt As String = "") As String
        Return "SELECT 
        format(transaction_date,""yyyy-MM-dd"") AS `Date`,
        reference_no,
        driver_name,
        plate_no,
        cargo,
        nobags,
        supplier, 
        inbound, 
        format(inbound_datetime,""yyyy-MM-dd hh:mm AM/PM"") AS `inbound_datetime`,
        keyID 
        FROM tbltransaction
        WHERE archive=0 AND (
        reference_no like '%" & FixApostrophe(txtsearchpending.Text) & "%'
        OR cargo like '%" & FixApostrophe(txtsearchpending.Text) & "%'
        OR supplier like '%" & FixApostrophe(txtsearchpending.Text) & "%'
        OR plate_no like '%" & FixApostrophe(txtsearchpending.Text) & "%'
        ) 
        AND outbound <=0"
    End Function

    Public Function getCompletedTransactionQuery(Optional ByVal top_cnt As String = "") As String
        Dim date_condition As String = ""

        Select Case cbodisplayfilter.Text
            Case "All Transaction"
                date_condition = ""
            Case "Recent 30 Days"
                date_condition = " AND transaction_date > " & Format(DateAdd(DateInterval.Day, -30, Now), "#MM/dd/yyyy#")
            Case "Custom Date Range"
                date_condition = " AND (transaction_date >= " & Format(dtpfrom.Value, "#MM/dd/yyyy#") & " AND transaction_date <= " & Format(dtpto.Value, "#MM/dd/yyyy#") & ")"
        End Select

        Return "SELECT 
        format(transaction_date,""yyyy-MM-dd"") AS `Date`,
        reference_no,
        driver_name,
        plate_no,
        cargo,
        nobags,
        avebags,
        amount,
        supplier, 
        gross_weight, 
        tare_weight, 
        net_weight,  
        inbound, 
        format(inbound_datetime,""yyyy-MM-dd hh:mm AM/PM"") AS `inbound_datetime`,
        outbound, 
        format(outbound_datetime,""yyyy-MM-dd hhh:mm AM/PM"") AS `outbound_datetime`,
        keyID 
        FROM tbltransaction
        WHERE archive=0 AND (
        reference_no like '%" & FixApostrophe(txtsearchcompleted.Text) & "%'
        OR cargo like '%" & FixApostrophe(txtsearchcompleted.Text) & "%'
        OR supplier like '%" & FixApostrophe(txtsearchcompleted.Text) & "%'
        OR plate_no like '%" & FixApostrophe(txtsearchcompleted.Text) & "%'
        ) 
        AND (inbound >0 AND outbound >0)" & date_condition
    End Function

    Private Sub PopulatePendingTransactions()
        pending_status = "Populating record to the grid..."
        PopulateDataGridView(Me.dtgpendingtransaction,
                        getPendingTransactionQuery("TOP 100"), True)
        pending_status = String.Format("{0} pending transaction(s). Ready! ", dtgpendingtransaction.RowCount)
    End Sub
    Public Sub PopulateCompletedTransaction()

        completed_status = "Populating record to the grid..."
        PopulateDataGridView(Me.dtgcompletedtransaction,
                       getCompletedTransactionQuery("TOP 100"), True)
        completed_status = String.Format("{0} completed transaction(s) loaded in the list!", dtgcompletedtransaction.RowCount)
    End Sub
    Private Sub txtsearchpending_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearchpending.KeyDown
        If e.KeyCode = Keys.Enter Then
            PopulatePendingTransactions()
        End If
    End Sub
    Private Sub btnrefreshcompleted_Click(sender As Object, e As EventArgs) Handles btnrefreshcompleted.Click
        txtsearchcompleted.Text = ""
        PopulateCompletedTransaction()
    End Sub
    Private Sub btnrefreshpending_Click(sender As Object, e As EventArgs) Handles btnrefreshpending.Click
        txtsearchpending.Text = ""
        PopulatePendingTransactions()
    End Sub



    Private Sub Initialize()

        cbodisplayfilter.SelectedIndex = 1
        transactionpro_status = "Initializing components..."

        'PopulateComboBoxes()
        ClearEntry()
        UserRestrictions()

        ConnectToWeighScale()
        LoadPortInfo()

        transactionpro_status = "Ready. Standby mode"
        lblUserAccount.Text = String.Format("Login as:  {0} ({1})", thisUser.Lastname & ", " & thisUser.Firstname, thisUser.UserFunction)



    End Sub

    Public Sub UserRestrictions()

        ' special access
        txtgross.Enabled = (thisUser.IsSuperAdmin)
        txttare.Enabled = (thisUser.IsSuperAdmin)
        txtnet.Enabled = (thisUser.IsSuperAdmin)
        txtInBound.Enabled = (thisUser.IsSuperAdmin)
        txtOutBound.Enabled = (thisUser.IsSuperAdmin)

        ' user accounts
        ToolStripSeparator15.Visible = (thisUser.IsAdmin)
        menuitem_useraccounts.Visible = (thisUser.IsAdmin)

        ' deleting transactions
        btnDelete.Enabled = (thisUser.IsAdmin)
        menuitem_deletetransaction.Enabled = (thisUser.IsAdmin)

        ' waive transaction
        btnwaive.Enabled = ((thisUser.IsAdmin) Or (thisUser.IsSuperAdmin))

    End Sub
    Private Sub PopulateComboBoxes()
        PopulateCbo(cbodrivername, "tbltransaction", "driver_name")
        'PopulateCbo(cbocustomername, "tbltransaction", "customer_name")
        PopulateCbo(cbocargo, "tbltransaction", "cargo")
        PopulateCbo(cbosupplier, "tbltransaction", "supplier")
        'PopulateCbo(cboprodowner, "tbltransaction", "weigher")
        'PopulateCbo(cbomodeofpayment, "tbltransaction", "mode_of_payment")
    End Sub


    Private Sub frmNFA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        ' prepare the controls 
        Initialize()

        ' populate the lists
        PopulatePendingTransactions()
        PopulateCompletedTransaction()


    End Sub

    Private Sub ConnectToWeighScale()
        Try
            weighScale.Close()
        Catch ex As Exception

        End Try
        transactionpro_status = "Connecting to weighing scale..."
        Try
            With weighScale
                .PortName = My.Settings.portname
                .ReadTimeout = My.Settings.readtimeout
                .BaudRate = My.Settings.baudrate
                .DataBits = My.Settings.databits
                .StopBits = My.Settings.stopbits
                .Open()
            End With
            lblportError.Text = ""
            transactionpro_status = "Successfully connected to the weighing scale."
        Catch ex As Exception
            transactionpro_status = "Error connecting to the scale. Check your port configuration!"
            lblportError.Text = "Error connecting to the scale. Check your port configuration!"
            lbloutput.ForeColor = Color.Red
        End Try

        transactionpro_status = "Ready. Standby mode"
    End Sub

    Private Sub cbodisplayfilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodisplayfilter.SelectedIndexChanged
        Panel5.Visible = (cbodisplayfilter.SelectedIndex = 2)
    End Sub

    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click, menuitem_addtransaction.Click
        EditMode = False
        TabControl1.SelectedIndex = 1
        ClearEntry()
        transactionpro_status = "Entry mode, waiting for the New entries to be complete..."
    End Sub
    Private Sub menuitem_refreshall_Click(sender As Object, e As EventArgs) Handles menuitem_refreshall.Click
        PopulatePendingTransactions()
        PopulateCompletedTransaction()
        LoadPortInfo()
        ConnectToWeighScale()
    End Sub

    Sub LoadPortInfo()
        With My.Settings
            lblPort.Text = .portname
            lblreadtimeout.Text = .readtimeout
            lblbaudrate.Text = .baudrate
            lbldatabits.Text = .databits
            lblstopbits.Text = .stopbits
        End With
    End Sub

    Private Sub PortConfigurationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menuitem_portconfiguration.Click
        Dim frm As New frmPortConfiguration
        frm.ShowDialog()
        ConnectToWeighScale()
    End Sub
    Private Sub btnEditTransaction_Click(sender As Object, e As EventArgs) Handles btnEditTransaction.Click, dtgcompletedtransaction.DoubleClick, menuite_edittransaction.Click
        EditMode = (activeDtg.Name = "dtgpendingtransaction")
        Try
            LoadRecord(activeDtg.SelectedRows.Item(0).Cells(activeDtg.ColumnCount - 1).Value)
            TabControl1.SelectedIndex = 1
        Catch ex As Exception
            MessageBox.Show(Me, "Unable to perform Edit. Operation terminated!", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click, menuitem_deletetransaction.Click
        transactionpro_status = "Deleting item(s)..."
        btnDelete.Focus()
        CountCheckedRows()
        Dim rowSelected As Integer = CountCheckedRows()
        If (rowSelected > 0) Then
            If MessageBox.Show(Me, "Are you sure you want the selected record(s)", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Dim d As New clsDataManipulation
                d.Exec("UPDATE tbltransaction SET archive=1, archive_by='" & thisUser.FullName & "', archived_date='" & Format(Now(), "yyyy-MM-dd") & "'WHERE keyid in (" & checkedKeyids & ")")

                transactionpro_status = "Item(s) deleted"

            End If
        End If

        PopulateCompletedTransaction()
        PopulatePendingTransactions()
    End Sub

    Dim checkedKeyids As String = ""
    Function CountCheckedRows() As Integer
        If activeDtg Is Nothing Then Return 0
        Dim ctr As Integer = 0
        Dim row As DataGridViewRowCollection = activeDtg.Rows
        For i As Integer = 0 To row.Count - 1
            If (CType(row.Item(i).Cells(0).Value, Boolean) = True) Then
                ctr += 1
                checkedKeyids &= IIf(checkedKeyids <> "", row.Item(i).Cells(activeDtg.ColumnCount - 1).Value & ",", row.Item(i).Cells(activeDtg.ColumnCount - 1).Value)
            End If
        Next
        Return ctr
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel5.Visible = False
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Panel5.Visible = False
        PopulateCompletedTransaction()
    End Sub

    Private Sub ExportCSV(querySelection As String, ExportOn As String)

        Dim filename As String = ""

        If ExportOn = "Pending" Then
            pending_status = "Exporting pending transation, please wait..."
            filename = "WSTP_Pending_" & Format(Now(), "yyyyMMdd_hhmmss") & ".csv"
        Else
            completed_status = "Exporting completed transation, please wait..."
            filename = "WSTP_Completed_" & Format(Now(), "yyyyMMdd_hhmmss") & ".csv"
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.FileName = filename
        saveFileDialog.DefaultExt = ".csv"


        If (saveFileDialog.ShowDialog() = DialogResult.Cancel) Then
            Exit Sub
        End If

        Dim sWriter As New StreamWriter(saveFileDialog.FileName)

        Dim header As String = ""

        Dim d As New clsDataManipulation
        With d
            If (.Fetch(querySelection)) Then
                With .DataReader
                    For x As Integer = 0 To .FieldCount - 2
                        header &= IIf(header <> "", ",""" & .GetName(x) & """", """" & .GetName(x) & """")
                    Next
                    header = header.ToUpper()
                    sWriter.WriteLine(header)
                    Do While .Read
                        Dim content As String = ""
                        For x As Integer = 0 To .FieldCount - 2
                            content &= IIf(content <> "", ",""" & .Item(x).ToString() & """", """" & .Item(x).ToString() & """")
                        Next
                        sWriter.WriteLine(content)
                    Loop
                    .Close()
                End With
            End If
        End With
        sWriter.Close()

        MessageBox.Show(Me, "Export successfully finished!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        transactionpro_status = "System export complete!"

        If ExportOn = "Pending" Then
            pending_status = filename & " has been created! Standby Mode"
        Else
            completed_status = filename & " has been created! Standby Mode"
        End If

    End Sub

    Private Sub UserAccountsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menuitem_useraccounts.Click
        Dim frm As New frmUserAccounts
        frm.ShowDialog(Me)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub frmNFA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        weighScale.Close()
        End
    End Sub
    Function ReplaceAll(ByVal strText As String) As String
        Dim RegExp As Object
        RegExp = CreateObject("VBScript.RegExp")
        With RegExp
            .Pattern = "([^0-9 )])"
            .Global = True
            .IgnoreCase = False
            .MultiLine = True
            ReplaceAll = .Replace(strText, "").ToString.Trim ' " $1"    
        End With
    End Function

    Dim reading As String = ""
    Private Sub weighScale_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles weighScale.DataReceived
        Threading.Thread.Sleep(500)
        Dim IncomingFull As String = weighScale.ReadExisting()
        Dim xx As String() = Split(IncomingFull, "=")

        If (xx.Length > 1) Then
            IncomingFull = xx(xx.Length - 1)
        End If
        'If Not (IncomingFull.StartsWith("ST") And IncomingFull.Contains("GS") And IncomingFull.Contains("kg")) Then
        '    Exit Sub
        'End If
        'Dim letters() As String = Split("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z", ",")
        'For x As Integer = 0 To letters.Length - 1
        '    IncomingFull = Replace(IncomingFull, letters(x).ToUpper, "")
        '    IncomingFull = Replace(IncomingFull, letters(x).ToLower, "")
        '    IncomingFull = Replace(IncomingFull, " ", "")
        '    IncomingFull = Replace(IncomingFull, vbTab, "")
        '    IncomingFull = Replace(IncomingFull, ",", "")
        'Next

        'Dim arr() As String = IncomingFull.Split(vbLf)
        'lblreading.Text = ReplaceAll(IncomingFull)
        reading = ReverseString(IncomingFull)
        'MsgBox(IncomingFull)
        'lblreading.Text = Val(arr.Max.ToString.Trim)
    End Sub
    Private Shared Function ReverseString(ByVal input As String) As String
        Dim output As String = String.Empty
        Dim chars As Char() = input.ToCharArray()

        For i As Integer = chars.Length - 1 To 0 Step -1
            If (IsNumeric(chars(i))) Then
                output &= chars(i)
            End If
        Next

        Return Val(output)
    End Function
    Private Sub btnClearEntry_Click(sender As Object, e As EventArgs) Handles btnClearEntry.Click
        EditMode = False
        ClearEntry()
    End Sub
    Public Sub ClearEntry()

        txtreferenceno.Text = GetLatestTicketNo()
        cbodrivername.Text = ""
        cbocargo.Text = ""
        txtplateno.Text = ""
        cbosupplier.Text = ""
        'cboprodowner.Text = ""
        'cbomodeofpayment.Text = ""
        'txtamount.Text = ""
        cbodrivername.Text = ""

        txttransactiondate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")


        txtgross.Text = "0"
        txttare.Text = "0"
        txtnet.Text = "0"

        lblinbounddate.Text = ""
        lbloutbounddate.Text = ""
        txtOutBound.Text = 0
        txtInBound.Text = 0

        dtpfrom.Text = Now
        dtpto.Text = Now

        txtreferenceno.Focus()

        'chkGQ.Checked = True


        btnreprint.Visible = False
        btnSave.Visible = Not (btnreprint.Visible)
        btnsaveandprint.Visible = Not (btnreprint.Visible)

        panel_transaction.Enabled = True


        PopulateComboBoxes()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Record()
    End Sub
    Private Sub btnsaveandprint_Click(sender As Object, e As EventArgs) Handles btnsaveandprint.Click
        Record()
        Print(ticket_no)
    End Sub

    Dim EditMode As Boolean = False
    Dim RecSaveandPrint As Boolean = False
    Dim ticket_no As String = ""
    Private Sub Record()
        ticket_no = txtreferenceno.Text
        RecSaveandPrint = False

        Dim current_user As String = thisUser.FullName

        Dim d As New clsDataManipulation

        Dim cmdText As String = ""
        If Not (EditMode) Then
            transactionpro_status = "Saving transaction..."
            If MessageBox.Show(Me, "Are you sure you want to save this transaction?", "New Transaction", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    d.Insert("tbltransaction",
                        {
                            "s reference_no            => " & txtreferenceno.Text,
                            "d transaction_date        => " & txttransactiondate.Text,
                            "s driver_name                => " & cbodrivername.Text,
                            "s plate_no                => " & txtplateno.Text,
                            "s supplier             => " & cbosupplier.Text,
                            "s cargo           => " & cbocargo.Text,
                            "n nobags                 => " & txtnoofbags.Text,
                            "n avebags                 => " & txtave.Text,
                            "n inbound                 => " & txtInBound.Text,
                            "d inbound_datetime        => " & lblinbounddate.Text,
                            "n amount                => " & txtfee.Text,
                            "n outbound                => " & txtOutBound.Text,
                            "d outbound_datetime       => " & lbloutbounddate.Text,
                            "n gross_weight            => " & txtgross.Text,
                            "d gross_captured_date     => " & gross_datetime,
                            "n tare_weight             => " & txttare.Text,
                            "d tare_captured_date      => " & tare_datetime,
                            "n net_weight              => " & txtnet.Text,
                            "s transacted_by           => " & thisUser.FullName
                        }
                     )
                    transactionpro_status = "Transaction saved!"
                    RecSaveandPrint = True
                    TabControl1.SelectedIndex = 0
                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & vbNewLine & "Please contact your administrator immediately!", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Error")
                    transactionpro_status = "Saving transaction encountered error! Contact your admin!"
                End Try
            End If
        Else
            transactionpro_status = "Updating transaction..."
            If MessageBox.Show(Me, "Are you sure you want to update this transaction?", "Update Transaction", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    d.Update("tbltransaction",
                       {
                            "s reference_no            => " & txtreferenceno.Text,
                            "d transaction_date        => " & txttransactiondate.Text,
                           "s plate_no                => " & txtplateno.Text,
                            "s driver_name                => " & cbodrivername.Text,
                            "s supplier             => " & cbosupplier.Text,
                            "s cargo           => " & cbocargo.Text,
                            "n nobags                 => " & txtnoofbags.Text,
                            "n avebags                 => " & txtave.Text,
                            "n inbound                 => " & txtInBound.Text,
                            "d inbound_datetime        => " & lblinbounddate.Text,
                            "n amount                => " & txtfee.Text,
                            "n outbound                => " & txtOutBound.Text,
                            "d outbound_datetime       => " & lbloutbounddate.Text,
                            "n gross_weight            => " & txtgross.Text,
                            "d gross_captured_date     => " & gross_datetime,
                            "n tare_weight             => " & txttare.Text,
                            "d tare_captured_date      => " & tare_datetime,
                            "n net_weight              => " & txtnet.Text,
                            "s transacted_by           => " & thisUser.FullName
                        },
                        {"keyid IN (" & txttransactionid.Text & ")"}
                     )
                    transactionpro_status = "Transaction udpated!"
                    RecSaveandPrint = True
                    TabControl1.SelectedIndex = 0
                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & vbNewLine & "Please contact your administrator immediately!", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Error")
                    transactionpro_status = "Transaction update encountered error! Contact your admin!"
                End Try
            End If
        End If

        PopulatePendingTransactions()
        PopulateCompletedTransaction()
    End Sub

    Private Sub LoadRecord(transactionID As String)
        ClearEntry()

        EditMode = True
        transactionpro_status = "Updating transaction, waiting to apply changes..."
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT * FROM tbltransaction WHERE keyid IN (" & transactionID & ") And archive=0")) Then
                With .DataReader
                    Do While .Read

                        txttransactionid.Text = .Item("keyid").ToString()

                        txtreferenceno.Text = .Item("reference_no").ToString()
                        'cbocustomername.Text = .Item("customer_name").ToString()
                        cbodrivername.Text = .Item("driver_name").ToString()
                        txtplateno.Text = .Item("plate_no").ToString()
                        cbocargo.Text = .Item("cargo").ToString()
                        cbosupplier.Text = .Item("supplier").ToString

                        txttransactiondate.Text = Format(Date.Parse(.Item("transaction_date").ToString()), "yyyy-MM-dd")



                        txtfee.Text = .Item("amount").ToString()
                        txtnoofbags.Text = .Item("nobags").ToString()

                        txtgross.Text = .Item("gross_weight").ToString()
                        gross_datetime = .Item("gross_captured_date").ToString()
                        txttare.Text = .Item("tare_weight").ToString()
                        tare_datetime = .Item("tare_captured_date").ToString()
                        txtnet.Text = .Item("net_weight").ToString()

                        ' inbound
                        txtInBound.Text = .Item("inbound").ToString()
                        lblinbounddate.Text = .Item("inbound_datetime").ToString()

                        ' outbound
                        txtOutBound.Text = .Item("outbound").ToString()
                        lbloutbounddate.Text = .Item("outbound_datetime").ToString()

                        panel_transaction.Enabled = Not (activeDtg.Name = dtgcompletedtransaction.Name And Not (thisUser.IsAdmin Or thisUser.IsSuperAdmin))

                        btnreprint.Visible = (activeDtg.Name = dtgcompletedtransaction.Name)

                        btnSave.Visible = Not (activeDtg.Name = dtgcompletedtransaction.Name)
                        btnsaveandprint.Visible = Not (activeDtg.Name = dtgcompletedtransaction.Name)

                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Dim gross_datetime As String = ""
    Dim tare_datetime As String = ""
    Private Sub btnW2_Click(sender As Object, e As EventArgs) Handles btnW2.Click
        BeginCapture(txtOutBound)
    End Sub
    Private Sub btnW1_Click(sender As Object, e As EventArgs) Handles btnW1.Click
        BeginCapture(txtInBound)
    End Sub
    Private Sub BeginCapture(destinationTextbox As TextBox)
        transactionpro_status = "Capturing reading..."

        destinationTextbox.Text = Val(lbloutput.Text)

        If destinationTextbox.Name = "txtInBound" Then
            lblinbounddate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")
        Else
            lbloutbounddate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")
        End If

        If Val(txtInBound.Text) > Val(txtOutBound.Text) Then
            txtgross.Text = txtInBound.Text
            gross_datetime = lblinbounddate.Text
            txttare.Text = txtOutBound.Text
            tare_datetime = lbloutbounddate.Text
        Else
            txtgross.Text = txtOutBound.Text
            gross_datetime = lbloutbounddate.Text
            txttare.Text = txtInBound.Text
            tare_datetime = lblinbounddate.Text
        End If
        txtnet.Text = Val(Val(txtgross.Text) - Val(txttare.Text))
        transactionpro_status = "Reading captured!"

    End Sub

    Function printBuffer(str As String, l As Integer) As String
        printBuffer = str
        For i As Integer = Len(str) To l
            printBuffer &= vbFormFeed
        Next
        Return str
    End Function
    Public Sub PrepPrint(ticketno As String)
        thisTransanction = New Transaction
        Dim stock_condition As String = ""
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("select *,
                format(transaction_date,""yyyy-MM-dd hh:mm:ss  AM/PM"") AS `f_transaction_date`,
                format(gross_captured_date,""yyyy-MM-dd hh:mm:ss AM/PM"") AS `f_gross_captured_date`,
                format(tare_captured_date,""yyyy-MM-dd hh:mm:ss AM/PM"") AS `f_tare_captured_date`
                from tbltransaction where reference_no = '" & ticketno & "'")) Then
                With .DataReader
                    Do While .Read
                        'thisTransanction.TicketNo = .Item("ticket_no").ToString
                        thisTransanction.ReferenceNo = .Item("reference_no").ToString
                        thisTransanction.TransactionDate = .Item("f_transaction_date").ToString ' Format(CDate(.Item("transaction_date").ToString), "yyyy-MM-dd")
                        thisTransanction.CustomerName = .Item("customer_name").ToString
                        'thisTransanction.Weigher = .Item("weigher").ToString
                        'thisTransanction.Product = .Item("product").ToString
                        thisTransanction.Cargo = .Item("cargo").ToString
                        thisTransanction.Supplier = .Item("Supplier").ToString
                        thisTransanction.Amount = .Item("amount").ToString
                        'thisTransanction.ModeOfPayment = .Item("mode_of_payment").ToString
                        thisTransanction.DriverName = .Item("driver_name").ToString
                        thisTransanction.PlateNo = .Item("plate_no").ToString
                        thisTransanction.QtyBags = .Item("nobags").ToString
                        thisTransanction.AveBags = .Item("avebags").ToString
                        'thisTransanction.VarietyCode = .Item("variety_code").ToString
                        thisTransanction.Gross = .Item("gross_weight").ToString
                        thisTransanction.GrossCapturedDate = .Item("f_gross_captured_date")
                        thisTransanction.Tare = .Item("tare_weight").ToString
                        thisTransanction.TareCapturedDate = .Item("f_tare_captured_date")
                        thisTransanction.Net = .Item("net_weight").ToString
                        'thisTransanction.Warehouse = .Item("warehouse").ToString
                        'thisTransanction.DeductedNet = .Item("deducted_net").ToString
                        'thisTransanction.StockCondition = .Item("stock_condition").ToString
                    Loop
                    .Close()
                End With

            End If
        End With

    End Sub
    Private Sub Print(ticketno As String)

        PrepPrint(ticketno)

        Dim template As String = Environment.CurrentDirectory & "\_Print_Master.xlsx"
        Dim thisOne As String = ""
        thisOne = Environment.CurrentDirectory & "\_Print.xlsx"

        ' delete the file first
        Try
            Kill(thisOne)
        Catch ex As Exception

        End Try

        ' preparation of the transaction information
        Dim xlApp As Excel.Application = New Excel.Application
        xlApp.DisplayAlerts = False
        xlApp.Visible = False
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        xlWorkBook = xlApp.Workbooks.Open(template)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        With thisTransanction
            'xlWorkSheet.UsedRange.Replace("wstp_warehouse", .Warehouse)
            'xlWorkSheet.UsedRange.Replace("wstp_ticketno", .TicketNo)
            'xlWorkSheet.UsedRange.Replace("wstp_address", .Address)
            xlWorkSheet.UsedRange.Replace("wstp_cargo", .Cargo)
            xlWorkSheet.UsedRange.Replace("wstp_supplier", .Supplier)
            'xlWorkSheet.UsedRange.Replace("wstp_remarks", .Remarks)
            xlWorkSheet.UsedRange.Replace("wstp_transactiondate", .TransactionDate)
            xlWorkSheet.UsedRange.Replace("wstp_daterequest", .DateRequest)
            xlWorkSheet.UsedRange.Replace("wstp_reference_no", .ReferenceNo)
            xlWorkSheet.UsedRange.Replace("wstp_customer_name", .CustomerName)
            xlWorkSheet.UsedRange.Replace("wstp_reference_no", .ReferenceNo)
            xlWorkSheet.UsedRange.Replace("wstp_weigher", .Weigher)
            xlWorkSheet.UsedRange.Replace("wstp_product", .Product)
            xlWorkSheet.UsedRange.Replace("wstp_amount", .Amount)
            xlWorkSheet.UsedRange.Replace("wstp_mode_of_payment", .ModeOfPayment)
            xlWorkSheet.UsedRange.Replace("wstp_driver_name", .DriverName)

            'xlWorkSheet.UsedRange.Replace("wstp_vc", .VarietyCode)
            xlWorkSheet.UsedRange.Replace("wstp_bags", .QtyBags)
            xlWorkSheet.UsedRange.Replace("wstp_avebags", .AveBags)
            'xlWorkSheet.UsedRange.Replace("wstp_dnet", .DeductedNet)
            'xlWorkSheet.UsedRange.Replace("wstp_natureoftransaction", .NatureofTransaction)
            'xlWorkSheet.UsedRange.Replace("wtsp_gq", IIf(.StockCondition = "GQ", "X", ""))
            'xlWorkSheet.UsedRange.Replace("wtsp_trd", IIf(.StockCondition = "TRD", "X", ""))
            'xlWorkSheet.UsedRange.Replace("wstp_inf", IIf(.StockCondition = "INF", "X", ""))
            'xlWorkSheet.UsedRange.Replace("wstp_pd", IIf(.StockCondition = "PD", "X", ""))
            'xlWorkSheet.UsedRange.Replace("wstp_td", IIf(.StockCondition = "TD", "X", ""))
            'xlWorkSheet.UsedRange.Replace("wstp_dnet", .DeductedNet)
            xlWorkSheet.UsedRange.Replace("wstp_operator", thisUser.FullName)
            'xlWorkSheet.UsedRange.Replace("wstp_carrier", .Carrier)
            xlWorkSheet.UsedRange.Replace("wstp_plateno", .PlateNo)
            xlWorkSheet.UsedRange.Replace("wstp_grosscapturedate", .GrossCapturedDate)
            xlWorkSheet.UsedRange.Replace("wstp_tarecapturedate", .TareCapturedDate)
            xlWorkSheet.UsedRange.Replace("wstp_gross", .Gross)
            xlWorkSheet.UsedRange.Replace("wstp_tare", .Tare)
            xlWorkSheet.UsedRange.Replace("wstp_net", .Net)
        End With

        xlWorkBook.SaveAs(thisOne)

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        BeginPrint(thisOne)
    End Sub

    Private Sub BeginPrint(the_file As String)
        TabControl1.TabIndex = 0
        'Process.Start("cmd", "/c powershell -command ""start-process -filepath '" & the_file & "' -verb print""")
        'Threading.Thread.Sleep(2000)
        'Process.Start("cmd", "/c taskkill /IM ""excel.exe"" /F ")

        Dim monProcess As New Process()
        monProcess.StartInfo.FileName = the_file
        monProcess.StartInfo.Verb = "Print"
        monProcess.StartInfo.CreateNoWindow = True
        monProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        monProcess.Start()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub Calc()
        If Val(txtInBound.Text) > Val(txtOutBound.Text) Then
            txtgross.Text = txtInBound.Text
            gross_datetime = lblinbounddate.Text
            txttare.Text = txtOutBound.Text
            tare_datetime = lbloutbounddate.Text
        Else
            txtgross.Text = txtOutBound.Text
            gross_datetime = lbloutbounddate.Text
            txttare.Text = txtInBound.Text
            tare_datetime = lblinbounddate.Text
        End If
        txtnet.Text = Val(Val(txtgross.Text) - Val(txttare.Text))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbloutput.Text = reading
        btnwaive.Visible = (Val(txtOutBound.Text) > 0)

        lblstatus.Text = String.Format("State: {0}", transactionpro_status)
        lbleditstatus.Text = String.Format("Edit Mode: {0}", EditMode)
        lblportStatus.Text = String.Format("Port: {0} ({1})", My.Settings.portname, IIf((weighScale.IsOpen), "Open", "Closed"))

        LoadPortInfo()

        If Not (weighScale.IsOpen()) Then
            transactionpro_status = "Error connecting to the scale. Check your port configuration!"
            lblportError.Text = "Error connecting to the scale. Check your port configuration!"
            lbloutput.ForeColor = Color.Red
        Else
            lbloutput.ForeColor = Color.Lime
        End If

        ' capture button
        btnW1.Enabled = (Not (EditMode) And Val(lbloutput.Text) > 0)
        btnW2.Enabled = ((EditMode) And Val(lbloutput.Text) > 0)
        PictureBox5.Visible = btnW2.Enabled
        PictureBox4.Visible = btnW1.Enabled


        lblpendingstatus.Text = pending_status
        lblcompletedstatus.Text = completed_status

        btnpendingexport.Enabled = (dtgpendingtransaction.RowCount > 0)
        btncompletedexport.Enabled = (dtgcompletedtransaction.RowCount > 0)


        btnSave.Enabled = AllRequireFieldsHasInput()
        btnsaveandprint.Enabled = AllRequireFieldsHasInput()

        Try
            Calc()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncanceltransaction_Click(sender As Object, e As EventArgs) Handles btncanceltransaction.Click
        ClearEntry()
        TabControl1.SelectedIndex = 0
    End Sub

    Public Function IsPortActive() As Boolean
        IsPortActive = False
        For Each port As String In SerialPort.GetPortNames
            If My.Settings.portname = port Then
                IsPortActive = True
                Exit For
            End If
        Next
        Return IsPortActive
    End Function

    Private Sub txtplateno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplateno.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub
    Private Sub dtgpendingtransaction_DoubleClick(sender As Object, e As EventArgs) Handles dtgpendingtransaction.DoubleClick
        LoadRecord(dtgpendingtransaction.SelectedRows.Item(0).Cells(dtgpendingtransaction.ColumnCount - 1).Value)
        TabControl1.SelectedIndex = 1
    End Sub
    Private Sub txtInBound_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInBound.KeyPress, txtOutBound.KeyPress
        If (thisUser.IsAdmin) Then
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
                e.KeyChar = ""
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub dtgpendingtransaction_Click(sender As Object, e As EventArgs) Handles dtgpendingtransaction.Click
        activeDtg = dtgpendingtransaction
    End Sub

    Private Sub dtgcompletedtransaction_Click(sender As Object, e As EventArgs) Handles dtgcompletedtransaction.Click
        activeDtg = dtgcompletedtransaction
    End Sub
    Private Sub txtweigh_of_sack_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtsearchcompleted_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearchcompleted.KeyDown
        If e.KeyCode = Keys.Enter Then
            PopulateCompletedTransaction()
        End If
    End Sub

    Private Sub btnsearchpending_Click(sender As Object, e As EventArgs) Handles btnsearchpending.Click
        PopulatePendingTransactions()
    End Sub

    Private Sub btnsearchcompleted_Click(sender As Object, e As EventArgs) Handles btnsearchcompleted.Click
        PopulateCompletedTransaction()
    End Sub

    Private Function IsNotPending(plateNo As String) As Boolean
        IsNotPending = False

        Dim count As Integer = 0
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT COUNT(*) FROM tbltransaction WHERE archive=0 AND (
                plate_no = '" & FixApostrophe(plateNo) & "' AND outbound <=0)")) Then
                With .DataReader
                    Do While .Read
                        count = Val(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
        IsNotPending = (count <= 0)

        Return IsNotPending
    End Function

    Private Sub txtplateno_Leave(sender As Object, e As EventArgs) Handles txtplateno.Leave
        If Not (IsNotPending(txtplateno.Text)) And Not (EditMode) Then
            MessageBox.Show(Me, "Operation denied, PlateNo has a pending transaction!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtplateno.SelectionStart = 0
            txtplateno.SelectionLength = txtplateno.TextLength
            txtplateno.Select()
        End If
    End Sub

    Private Function AllRequireFieldsHasInput() As Boolean

        AllRequireFieldsHasInput = (FixSpaces(txtreferenceno.Text) <> "" And Val(txtInBound.Text) > 0)
        'FixSpaces(cbocustomername.Text) <> "" And
        'FixSpaces(txtplateno.Text) <> "" And
        'FixSpaces(cbocustomername.Text) <> "" And
        'FixSpaces(cbocargo.Text) <> "" And


        If (EditMode) Then
            AllRequireFieldsHasInput = (Val(txtOutBound.Text) > 0)
        End If

        Return AllRequireFieldsHasInput
    End Function

    Private Sub _GotFocusCbo(sender As Object, e As EventArgs)

        Dim txt As ComboBox = CType(sender, ComboBox)
        txt.SelectionStart = 0
        txt.SelectionLength = txt.Text.Length
        txt.Select()
    End Sub

    Private Sub _FormatDecimal(sender As Object, e As EventArgs)

        Dim txt As ComboBox = CType(sender, ComboBox)
        Dim valStr As Decimal = Val(txt.Text)
        txt.Text = valStr.ToString("n3")
    End Sub

    Private Sub btnreprint_Click(sender As Object, e As EventArgs) Handles btnreprint.Click
        Print(txtreferenceno.Text)
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtOutBound.Text = "5"
        lbloutbounddate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")

        'lblinbounddate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")


        'transactionpro_status = "Reading captured!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Record()
        txtInBound.Text = 10
        lblinbounddate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss tt")
        'Print(txtticketno.Text)
    End Sub
    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub

    'Private Sub txtamount_Leave(sender As Object, e As EventArgs)
    '    Dim amnt As Decimal = Val(txtamount.Text)
    '    txtamount.Text = amnt.ToString("n2")
    'End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If Not (EditMode) Then
            ClearEntry()
        End If
    End Sub

    Private Sub menuitem_exit_Click(sender As Object, e As EventArgs) Handles menuitem_exit.Click
        End
    End Sub

    Private Sub portMonitoring_Tick(sender As Object, e As EventArgs) Handles portMonitoring.Tick
        If Not (weighScale.IsOpen) Then
            ConnectToWeighScale()
        End If
    End Sub

    Private Sub btnwaive_Click(sender As Object, e As EventArgs) Handles btnwaive.Click
        txtOutBound.Text = 0

        If Val(txtInBound.Text) > Val(txtOutBound.Text) Then
            txtgross.Text = txtInBound.Text
            gross_datetime = lblinbounddate.Text
            txttare.Text = txtOutBound.Text
            tare_datetime = lbloutbounddate.Text
        Else
            txtgross.Text = txtOutBound.Text
            gross_datetime = lbloutbounddate.Text
            txttare.Text = txtInBound.Text
            tare_datetime = lblinbounddate.Text
        End If
        txtnet.Text = Val(Val(txtgross.Text) - Val(txttare.Text))

        Dim d As New clsDataManipulation
        d.Update("tbltransaction",
                       {
                         "n outbound                => " & txtOutBound.Text,
                         "d outbound_datetime       => " & lbloutbounddate.Text,
                         "n gross_weight            => " & txtgross.Text,
                         "d gross_captured_date     => " & gross_datetime,
                         "n tare_weight             => " & txttare.Text,
                         "d tare_captured_date      => " & tare_datetime,
                         "n net_weight              => " & txtnet.Text,
                         "s modified_by             => " & thisUser.FullName,
                         "d modified_date           => " & Format(Now, "yyyy-MM-dd")
                        },
                        {"keyid IN (" & txttransactionid.Text & ")"})

        TabControl1.SelectedIndex = 0

        PopulatePendingTransactions()
        PopulateCompletedTransaction()
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        EditMode = False
    End Sub

    Private Sub txtnoofbags_TextChanged(sender As Object, e As EventArgs) Handles txtnoofbags.TextChanged, txtnet.TextChanged
        If (Val(txtnet.Text) > 0) Then
            txtave.Text = (Val(txtnet.Text) / Val(txtnoofbags.Text)).ToString("N2")
        End If
    End Sub

    Private Sub txtnoofbags_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnoofbags.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Not (e.KeyChar = vbBack) Then
            e.KeyChar = ""
        End If
    End Sub

End Class
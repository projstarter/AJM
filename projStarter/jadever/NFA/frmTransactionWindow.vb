
Imports System.IO
Public Class frmTransactionWindow

    Public EditMode As Boolean
    Public TransactionID As String
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtqtyave.TextChanged

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, CancelToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmTransactionWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ClearEntry()
        If (EditMode) Then
            txtslipno.Enabled = Not (EditMode)
            Dim d As New clsDataManipulation
            With d
                If (.Fetch("SELECT * FROM tbltransaction WHERE keyid IN (" & TransactionID & ") AND archive=0")) Then
                    With .DataReader
                        Do While .Read
                            txtslipno.Text = .Item("slipno").ToString()
                            cboTransactionType.Text = .Item("transaction_type").ToString()
                            rbtnWSR.Checked = (.Item("printing_type").ToString() = "WSR")
                            rbtnWSI.Checked = (.Item("printing_type").ToString() = "WSI")
                            txttransactiondate.Text = Format(Date.Parse(.Item("transaction_date").ToString()), "yyyy-MM-dd")
                            cbotruckername.Text = .Item("trucker_name").ToString()
                            cbodrivername.Text = .Item("driver_name").ToString()
                            txtplateno.Text = .Item("plate_no").ToString()
                            txtqtyave.Text = .Item("qty_ave").ToString()
                            cbovarietycode.Text = .Item("variety_code").ToString()
                            txtgross.Text = .Item("gross_weight").ToString()
                            txttare.Text = .Item("tare_weight").ToString()
                            txtnet.Text = .Item("net_weight").ToString()
                            cbowarehouse.Text = .Item("warehouse").ToString()
                            txtInBound.Text = .Item("inbound").ToString()
                            txtInBound.Enabled = Not (Val(txtInBound.Text) > 0)
                            btnW1.Enabled = Not (Val(txtInBound.Text) > 0)
                            txtOutBound.Text = .Item("outbound").ToString()
                            lblinbounddate.Text = .Item("inbound_datetime").ToString()
                            lbloutbounddate.Text = .Item("outbound_datetime").ToString()
                        Loop
                        .Close()
                    End With

                End If
            End With
        Else

            txtOutBound.Enabled = (Val(txtInBound.Text) > 0)
            btnW2.Enabled = (Val(txtInBound.Text) > 0)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not (EditMode) Then txttransactiondate.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Record()
        Me.Close()
    End Sub

    Private Sub Record()

        Dim current_user As String = thisUser.FullName

        Dim d As New clsDataManipulation

        Dim cmdText As String = ""
        If Not (EditMode) Then
            If MessageBox.Show(Me, "Are you sure you want to save this transaction?", "New Transaction", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    d.Insert("tbltransaction",
                     {
                     "s slipno              => " & txtslipno.Text,
                     "d transaction_date    => " & txttransactiondate.Text,
                     "s printing_type       => " & IIf(rbtnWSR.Checked, "WSR", "WSI"),
                     "s trucker_name        => " & cbotruckername.Text,
                     "s driver_name         => " & cbodrivername.Text,
                     "s plate_no            => " & txtplateno.Text,
                     "n qty_ave             => " & txtqtyave.Text,
                     "s variety_code        => " & cbovarietycode.Text,
                     "s warehouse           => " & cbowarehouse.Text,
                     "n inbound             => " & txtInBound.Text,
                     "d inbound_datetime    => " & lblinbounddate.Text,
                     "n outbound            => " & txtOutBound.Text,
                     "d outbound_datetime   => " & lbloutbounddate.Text,
                     "n gross_weight        => " & txtgross.Text,
                     "d gross_captured_date => " & gross_datetime,
                     "n tare_weight         => " & txttare.Text,
                     "d tare_captured_date  => " & tare_datetime,
                     "n net_weight          => " & txtnet.Text,
                     "s transacted_by       => " & thisUser.FullName
                        }
                     )
                    If (chkPrintAfterSave.Checked) Then Print(txtslipno.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & vbNewLine & "Please contact your administrator immediately!", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Else
            If MessageBox.Show(Me, "Are you sure you want to update this transaction?", "Update Transaction", MsgBoxStyle.YesNo, MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    d.Update("tbltransaction",
                       {
                     "s transaction_type    => " & cboTransactionType.Text,
                     "s trucker_name        => " & cbotruckername.Text,
                     "s driver_name         => " & cbodrivername.Text,
                     "s plate_no            => " & txtplateno.Text,
                     "n qty_ave             => " & txtqtyave.Text,
                     "s variety_code        => " & cbovarietycode.Text,
                     "s warehouse           => " & cbowarehouse.Text,
                     "n inbound             => " & txtInBound.Text,
                     "d inbound_datetime    => " & lblinbounddate.Text,
                     "n outbound            => " & txtOutBound.Text,
                     "d outbound_datetime   => " & lbloutbounddate.Text,
                     "n gross_weight        => " & txtgross.Text,
                     "d gross_captured_date => " & gross_datetime,
                     "n tare_weight         => " & txttare.Text,
                     "d tare_captured_date  => " & tare_datetime,
                     "n net_weight          => " & txtnet.Text,
                     "s modified_by         => " & thisUser.FullName,
                     "d modified_date       => " & Format(Now, "yyyy-MM-dd")
                        },
                     {"keyid IN (" & TransactionID & ")"}
                     )
                    MsgBox("Record successfully Updated!", MsgBoxStyle.OkOnly & MsgBoxStyle.Information, "Alert")
                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & vbNewLine & "Please contact your administrator immediately!", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub btnClearEntry_Click(sender As Object, e As EventArgs) Handles btnClearEntry.Click
        ClearEntry()
    End Sub
    Public Sub ClearEntry()
        txtslipno.Text = ""
        txttransactiondate.Text = ""
        cbotruckername.Text = ""
        cbodrivername.Text = ""
        txtplateno.Text = ""
        txtqtyave.Text = "0"
        cbovarietycode.Text = ""

        txtgross.Text = "0"
        txttare.Text = "0"

        txtgross.Enabled = (thisUser.IsAdmin)
        txttare.Enabled = (thisUser.IsAdmin)

        lblinbounddate.Text = ""
        lbloutbounddate.Text = ""

        txtnet.Text = "0"
        cbowarehouse.Text = ""

        PopulateCbo(cboTransactionType, "SELECT DISTINCT transaction_type FROM tbltransaction WHERE LEN(transaction_type)>2 ORDER BY 1")
        PopulateCbo(cbotruckername, "SELECT DISTINCT trucker_name FROM tbltransaction WHERE LEN(trucker_name)>2 ORDER BY 1")
        PopulateCbo(cbodrivername, "SELECT DISTINCT driver_name FROM tbltransaction WHERE LEN(driver_name)>2 ORDER BY 1")
        PopulateCbo(cbovarietycode, "SELECT DISTINCT variety_code FROM tbltransaction WHERE LEN(variety_code)>0 ORDER BY 1")
        PopulateCbo(cbowarehouse, "SELECT DISTINCT warehouse FROM tbltransaction WHERE LEN(warehouse)>0 ORDER BY 1")

        txtslipno.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtqtyave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtyave.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub btnW1_Click(sender As Object, e As EventArgs) Handles btnW1.Click
        BeginCapture(txtInBound)
        'Dim ask As Object
        'If Val(txtInBound.Text) > 0 Then
        '    ask = MessageBox.Show(Me, "Recall previously captured reading?", "Recall Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        '    If ask = DialogResult.Yes Then
        '        BeginCapture(txtInBound)
        '    End If
        'Else
        '    BeginCapture(txtInBound)
        'End If
    End Sub

    Dim gross_datetime As String = ""
    Dim tare_datetime As String = ""
    Private Sub btnW2_Click(sender As Object, e As EventArgs) Handles btnW2.Click
        BeginCapture(txtOutBound)
    End Sub
    Private Sub BeginCapture(destinationTextbox As TextBox)
        Dim frm As New frmWeighingReading
        frm.ShowDialog()
        'destinationTextbox.Text = Val(WeighingScaleReading)

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
            tare_datetime = lblinbounddate.Text
        End If
        txtnet.Text = Val(Val(txtgross.Text) - Val(txttare.Text))

    End Sub
    Private Sub Print(slipno As String)
        'Dim fileLoc As String = ""

        'For i As Integer = 1 To 3
        '    fileLoc = Environment.CurrentDirectory & "\print" & i & ".txt"
        '    Try
        '        Kill(fileLoc)
        '        Exit For
        '    Catch ex As Exception

        '    End Try
        'Next

        'Dim str As String = "", ptype As String = ""
        'Dim d As New clsDataManipulation
        'thisTransanction = New Transaction
        'With d
        '    If (.Fetch("select * from tbltransaction where slipno = '" & slipno & "'")) Then
        '        With .DataReader
        '            Do While .Read
        '                thisTransanction.Slipno = .Item("slipno").ToString
        '                thisTransanction.TransactionDate = Format(CDate(.Item("transaction_date").ToString), "dd MM yy")
        '                thisTransanction.TransactionType = .Item("transaction_type").ToString
        '                thisTransanction.PrintType = .Item("printing_type").ToString
        '                thisTransanction.TruckerName = .Item("trucker_name").ToString
        '                thisTransanction.DriverName = .Item("driver_name").ToString
        '                thisTransanction.PlateNo = .Item("plate_no").ToString
        '                thisTransanction.QtyAve = .Item("qty_ave").ToString
        '                thisTransanction.VarietyCode = .Item("variety_code").ToString
        '                thisTransanction.Gross = .Item("gross_weight").ToString
        '                thisTransanction.GrossCapturedDate = .Item("gross_captured_date").ToString
        '                thisTransanction.Tare = .Item("tare_weight").ToString
        '                thisTransanction.TareCapturedDate = .Item("tare_captured_date").ToString
        '                thisTransanction.Net = .Item("net_weight").ToString
        '                thisTransanction.Warehouse = .Item("warehouse").ToString
        '            Loop
        '            .Close()
        '        End With

        '    End If
        'End With

        'If (thisTransanction.PrintType = "WSR") Then
        '    str =
        '    thisTransanction.DriverName & vbNewLine &
        '    thisTransanction.Slipno & vbNewLine & vbNewLine &
        '    thisTransanction.Warehouse & vbNewLine & vbNewLine &
        '    thisTransanction.TransactionType & vbTab & thisTransanction.Gross & vbTab & vbTab & thisTransanction.VarietyCode & vbNewLine &
        '    vbTab & "   " & thisTransanction.QtyAve & vbNewLine &
        '    thisTransanction.TransactionDate & vbTab & "   " & thisTransanction.Net & vbNewLine & vbNewLine & vbNewLine & vbNewLine &
        '    "Gross     :   " & thisTransanction.Gross & vbTab & vbTab & thisTransanction.GrossCapturedDate & vbNewLine & vbNewLine &
        '    "Tare      :   " & thisTransanction.Tare & vbTab & vbTab & thisTransanction.TareCapturedDate & vbNewLine & vbNewLine &
        '    "Net       :   " & thisTransanction.Net & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine &
        '   thisUser.FullName & vbNewLine &
        '   vbTab & vbTab & thisTransanction.TruckerName & vbTab & thisTransanction.PlateNo
        'Else
        '    str =
        '    thisTransanction.DriverName & vbNewLine &
        '    thisTransanction.Slipno & vbTab & vbTab & vbTab & thisTransanction.TransactionDate & vbNewLine &
        '    thisTransanction.Warehouse & vbTab & vbTab & thisTransanction.VarietyCode & vbNewLine & vbNewLine & vbNewLine &
        '    thisTransanction.QtyAve & vbTab & "   " & thisTransanction.Gross & vbTab & thisTransanction.Net & vbNewLine &
        '    thisTransanction.TransactionType & vbNewLine &
        '    vbNewLine & vbNewLine & vbNewLine &
        '    "Gross     :   " & thisTransanction.Gross & vbTab & vbTab & thisTransanction.GrossCapturedDate & vbNewLine & vbNewLine &
        '    "Tare      :   " & thisTransanction.Tare & vbTab & vbTab & thisTransanction.TareCapturedDate & vbNewLine & vbNewLine &
        '    "Net       :   " & thisTransanction.Net & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine &
        '   thisUser.FullName & vbTab & vbTab & thisTransanction.TruckerName & vbTab & vbTab & thisTransanction.PlateNo

        'End If

        'Try
        '    Kill(fileLoc)
        'Catch ex As Exception

        'End Try

        'Dim sWriter As StreamWriter = New StreamWriter(fileLoc)
        'sWriter.Write(str)
        'sWriter.Close()





        'Dim psi As New ProcessStartInfo

        'psi.UseShellExecute = True

        'psi.Verb = "print"

        'psi.WindowStyle = ProcessWindowStyle.Hidden

        'psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString() ' Here specify printer name

        'psi.FileName = fileLoc ' Here specify a document to be printed

        'Process.Start(psi)

    End Sub


End Class
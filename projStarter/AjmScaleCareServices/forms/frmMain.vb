Imports System.IO.Ports
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmMain

    Public IsEntryMode As Boolean = False
    Public IsEditting As Boolean = False
    Public _KeyId As Integer = 0

    Private Sub AddCreateTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCreateTransactionToolStripMenuItem.Click, btntransaction.Click
        IsEntryMode = True
        IsEditting = False
        ClearEntry()
        cbocustomername.Select()
        AppLog = "Adding new transaction..."
    End Sub

    Private Sub DiscardTransactionWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscardTransactionWindowToolStripMenuItem.Click, btnhidetransaction.Click, btndiscard.Click, btncanceltransaction.Click
        IsEntryMode = False
        AppLog = "Ready..."
    End Sub

    Private Sub EditUpdateTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUpdateTransactionToolStripMenuItem.Click, btnedit.Click, dtg.DoubleClick
        If (dtg.SelectedRows.Count > 0) Then
            IsEntryMode = True
            IsEditting = True
            LoadTransaction(dtg.SelectedRows.Item(0).Cells(dtg.ColumnCount - 1).Value)
            AppLog = "Updating transaction..."
        End If
    End Sub
    Dim WithEvents objSerialPort As New SerialPort
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStartUp()
    End Sub
    Private Sub OpenSerialPort()

        With objSerialPort
            .PortName = PortInformation.PortName
            .BaudRate = PortInformation.BaudRate
            .ReadTimeout = PortInformation.ReadTimeout
            .DataBits = PortInformation.DataBits
            .StopBits = PortInformation.StopBits
        End With

        Try
            objSerialPort.Open()
            Timer1.Enabled = (objSerialPort.IsOpen)
            serialStatus = objSerialPort.BreakState
        Catch ex As Exception
        End Try

    End Sub
    Private Sub CloseSerialPort()
        Timer1.Enabled = False
        Try
            objSerialPort.Close()
            serialStatus = objSerialPort.BreakState
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InitializeStartUp()
        dtpfrom.Value = Now.AddDays(-30)

        Try
            lblPortStatus.Text = String.Format("Port: {0} ({1})", PortInformation.PortName, serialStatus)
        Catch ex As Exception
            lblPortStatus.Text = String.Format("Port: {0} ({1})", PortInformation.PortName, ex.Message)
        End Try

        lblloginas.Text = String.Format("Login as: {0}", User.Username)

        Load_AppConfiguration()
        UpdateButtonCategory()
        PopulateList()
        OpenSerialPort()

        lblcompanyname.Text = CompanyInformation.CompanyName
        lblcompanyaddress.Text = CompanyInformation.CompanyAddress

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblstatus.Text = AppLog
        Try
            lblPortStatus.Text = String.Format("Port: {0} ({1})", PortInformation.PortName, serialStatus)
        Catch ex As Exception
            lblPortStatus.Text = String.Format("Port: {0} ({1})", PortInformation.PortName, ex.Message)
        End Try

        pnltransaction.Width = IIf(IsEntryMode, 400, 0)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, btnexit.Click
        Dim ask = MessageBox.Show("Are you sure you want to close this application?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (ask = DialogResult.Yes) Then
            Process.Start("cmd", "/c taskkill /IM ""AjmScaleCareServices.exe"" /F ")
        End If
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click, btntoexcel.Click

        Dim ask = New SaveFileDialog()
        ask.FileName = "ExtractedReport_" & Format(Now(), "yyyyMMdd_hhmmss")
        ask.Filter = " |*.xlsx"
        If (ask.ShowDialog = DialogResult.OK) Then
            ExportExcel(GetQuery(), ask.FileName)
            MessageBox.Show("Report successfully created!", "Report Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnredo1st_Click(sender As Object, e As EventArgs) Handles btnredo1st.Click
        Dim ask = MessageBox.Show("Are you sure you want to overwrite the previous data?", "Redo Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (ask = DialogResult.Yes) Then
            txt1stweighin.Text = ""
            txt1stweighin_capturedate.Text = ""
            txt1stweighin.Select()
        End If
    End Sub

    Private Sub btnredo2nd_Click(sender As Object, e As EventArgs) Handles btnredo2nd.Click
        Dim ask = MessageBox.Show("Are you sure you want to overwrite the previous data?", "Redo Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (ask = DialogResult.Yes) Then
            txt2ndweighin.Text = ""
            txt2ndweighin_capturedate.Text = ""
            txt2ndweighin.Select()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (IsEditting) Then
            UpdateTransaction()
        Else
            SaveTransaction()
        End If
    End Sub

    Public Sub SaveTransaction()
        Calc()
        Dim ask = MessageBox.Show("Are you sure you want save this transaction?", "Saving Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (ask = DialogResult.Yes) Then
            _Insert("tbltransaction",
                         {
                             "d key_date => " & txttrdate.Text,
                             "s ticketno => " & txtticketno.Text,
                             "s customer => " & cbocustomername.Text,
                             "s product => " & cboproduct.Text,
                             "s plateno => " & cboplateno.Text,
                             "s driver => " & cbodriver.Text,
                             "s operator => " & User.Fullname,
                             "n qty => " & txtqty.Text,
                             "r price => " & txtprice.Text,
                             "r tprice => " & txttotalprice.Text,
                             "r sprice => " & txtscaleprice.Text,
                             "s remarks => " & txtremarks.Text,
                             "r price => " & txtprice.Text,
                             "r tprice => " & txttotalprice.Text,
                             "r sprice => " & txtscaleprice.Text,
                             "s remarks => " & txtremarks.Text,
                             "s aveweight => " & txtaveweight.Text,
                             "n firstweight => " & txt1stweighin.Text,
                             "d firstweight_capturedate => " & txt1stweighin_capturedate.Text,
                             "n secondweight => " & txt2ndweighin.Text,
                             "d  secondweight_capturedate => " & txt2ndweighin_capturedate.Text,
                             "s  gross => " & txtgross.Text,
                             "s  tare => " & txttare.Text,
                             "s  net => " & txtnet.Text
                         }
                      )
            AppLog = "Record successfully saved!"
        End If
        RefreshToolStripMenuItem_Click(Nothing, Nothing)
        IsEntryMode = False
    End Sub

    Public Sub UpdateTransaction()
        Calc()
        Dim ask = MessageBox.Show("Are you sure you want update this transaction?", "Saving Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (ask = DialogResult.Yes) Then
            _Update("tbltransaction",
                         {
                             "d key_date => " & txttrdate.Text,
                             "s customer => " & cbocustomername.Text,
                             "s product => " & cboproduct.Text,
                             "s plateno => " & cboplateno.Text,
                             "s driver => " & cbodriver.Text,
                             "s operator => " & User.Fullname,
                             "n qty => " & txtqty.Text,
                             "r price => " & txtprice.Text,
                             "r tprice => " & txttotalprice.Text,
                             "r sprice => " & txtscaleprice.Text,
                             "s remarks => " & txtremarks.Text,
                             "s aveweight => " & txtaveweight.Text,
                             "n firstweight => " & txt1stweighin.Text,
                             "d firstweight_capturedate => " & txt1stweighin_capturedate.Text,
                             "n secondweight => " & txt2ndweighin.Text,
                             "d  secondweight_capturedate => " & txt2ndweighin_capturedate.Text,
                             "s  gross => " & txtgross.Text,
                             "s  tare => " & txttare.Text,
                             "s  net => " & txtnet.Text
                          },
                          {"keyid IN (" & _KeyId & ")"}
                       )
            AppLog = "Record successfully updated!"
        End If
        RefreshToolStripMenuItem_Click(Nothing, Nothing)
        IsEntryMode = False
    End Sub


    Private Sub LoadTransaction(keyid As String)
        ClearEntry()
        IsEditting = True
        IsEntryMode = True
        _KeyId = keyid
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT 
        format(firstweight_capturedate,""yyyy-MM-dd HH:mm"") AS `firstweight_capturedate1`,
        format(secondweight_capturedate,""yyyy-MM-dd HH:mm"") AS `secondweight_capturedate1`,
        *
        FROM tbltransaction WHERE keyid IN (" & keyid & ") And archive=0")) Then
                With .DataReader
                    Do While .Read
                        txttrdate.Text = Format(Date.Parse(.Item("key_date").ToString()), "yyyy-MM-dd HH:mm")
                        txtticketno.Text = .Item("ticketno").ToString()
                        cbocustomername.Text = .Item("customer").ToString()
                        cboproduct.Text = .Item("product").ToString()
                        cboplateno.Text = .Item("plateno").ToString()
                        cbodriver.Text = .Item("driver").ToString()
                        txtqty.Text = .Item("qty").ToString()
                        txtprice.Text = .Item("price").ToString()
                        txtscaleprice.Text = .Item("sprice").ToString()
                        txtremarks.Text = .Item("remarks").ToString()
                        txtgross.Text = .Item("gross").ToString()
                        txttare.Text = .Item("tare").ToString()
                        txtnet.Text = .Item("net").ToString()
                        txt1stweighin.Text = .Item("firstweight").ToString()
                        txt1stweighin_capturedate.Text = .Item("firstweight_capturedate1").ToString()
                        txt2ndweighin.Text = .Item("secondweight").ToString()
                        txt2ndweighin_capturedate.Text = .Item("secondweight_capturedate1").ToString()
                    Loop
                    .Close()
                End With
            End If
        End With
        Calc()
    End Sub

    Private Sub ClearEntry()
        txttrdate.Text = Format(Date.Now, "yyyy-MM-dd HH:mm")
        txtticketno.Text = GetLatestTicketNo()

        cbocustomername.Text = ""
        PopulateCbo(cbocustomername, "SELECT DISTINCT customer FROM tbltransaction ORDER BY 1 ASC ")

        cboproduct.Text = ""
        PopulateCbo(cboproduct, "SELECT DISTINCT product FROM tbltransaction ORDER BY 1 ASC ")

        cboplateno.Text = ""
        PopulateCbo(cboplateno, "SELECT DISTINCT plateno FROM tbltransaction ORDER BY 1 ASC ")

        cbodriver.Text = ""
        PopulateCbo(cbodriver, "SELECT DISTINCT driver FROM tbltransaction ORDER BY 1 ASC ")

        txtqty.Text = "0"
        txtprice.Text = "0"
        txtscaleprice.Text = "0"
        txtremarks.Text = ""

        txtaveweight.Text = "0kg"
        txtgross.Text = "0kg"
        txttare.Text = "0kg"
        txtnet.Text = "0kg"

        txt1stweighin.Text = "0"
        txt2ndweighin.Text = "0"

        txt1stweighin_capturedate.Text = ""
        txt2ndweighin_capturedate.Text = ""

    End Sub

    Private Sub PopulateList()
        PopulateDataGridView(Me.dtg,
                        GetQuery(), True)
        AppLog = String.Format("Found {0} transaction(s) on the list!", Me.dtg.Rows.Count)
    End Sub

    Public Function GetQuery(Optional ByVal limit As String = "") As String
        Dim statusSelection As String = ""

        statusSelection = IIf(GridDisplay = "ALL", "", IIf(GridDisplay = "COMPLETED", "AND (firstweight>0 AND secondweight>0)", "AND (firstweight>0 AND secondweight<=0)"))

        Return "SELECT
        key_date AS `Date`,
        --strftime('%Y-%m-%d %I:%M %p', key_date) AS `Date`,
        --format(key_date,""yyyy-MM-dd hh:mm tt"") AS `Date`,
        ticketno,
        customer,
        product,
        driver,
        plateno,
        qty,
        price,
        sprice,
        tprice,
        aveweight,
        gross, 
        tare, 
        net, 
        firstweight_capturedate AS `firstweight_capturedate`,
        secondweight_capturedate AS `secondweight_capturedate`,
        --strftime('%Y-%m-%d %I:%M %p', firstweight_capturedate) AS `firstweight_capturedate`,
        --strftime('%Y-%m-%d %I:%M %p', secondweight_capturedate) AS `secondweight_capturedate`,
        --format(firstweight_capturedate,""yyyy-MM-dd HH:mm"") AS `firstweight_capturedate`,
        --format(secondweight_capturedate,""yyyy-MM-dd HH:mm"") AS `secondweight_capturedate`,
        operator,
        remarks,
        keyID 
        FROM tbltransaction
        WHERE archive=0 
        AND (customer||product||driver||plateno like '%" & FixApostrophe(txtfind.Text) & "%') 
        " & statusSelection & "
        AND (key_date between '" & Format(dtpfrom.Value, "yyyy-MM-dd 00:00:00") & "' AND '" & Format(dtpto.Value, "yyyy-MM-dd 23:59:59") & "')
        ORDER BY  key_date DESC" & limit
    End Function
    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        CalculateTotalPrice()
    End Sub
    Private Sub txtprice_Leave(sender As Object, e As EventArgs) Handles txtprice.Leave
        txtprice.Text = Val(txtprice.Text).ToString("F2")
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress, txtqty.KeyPress
        ' Allow control keys (backspace, etc.)
        If Char.IsControl(e.KeyChar) Then
            Exit Sub
        End If

        ' Allow digits
        If Char.IsDigit(e.KeyChar) Then
            Exit Sub
        End If

        ' Allow one decimal point
        If e.KeyChar = "."c AndAlso Not TextBox1.Text.Contains(".") Then
            Exit Sub
        End If

        ' Block everything else
        e.Handled = True
    End Sub

    Private Sub txtnet_TextChanged(sender As Object, e As EventArgs) Handles txtnet.TextChanged
        CalculateTotalPrice()
    End Sub
    Private Sub CalculateTotalPrice()
        Dim price As Decimal = Val(txtprice.Text)
        Dim netwg As Decimal = Val(Num(txtnet.Text))
        Dim totalprice As Decimal = price * netwg
        txttotalprice.Text = totalprice.ToString("F2")
    End Sub
    Private Sub txt1stweighin_KeyDown(sender As Object, e As KeyEventArgs) Handles txt1stweighin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt1stweighin.Text = lblreading.Text
            txt1stweighin_capturedate.Text = IIf((Val(txt1stweighin.Text) <= 0), "", Format(Date.Now, "yyyy-MM-dd HH:mm"))
        End If
    End Sub

    Private Sub txt2ndweighin_KeyDown(sender As Object, e As KeyEventArgs) Handles txt2ndweighin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt2ndweighin.Text = lblreading.Text
            txt2ndweighin_capturedate.Text = IIf((Val(txt2ndweighin.Text) <= 0), "", Format(Date.Now, "yyyy-MM-dd HH:mm"))
        End If
    End Sub
    Private Sub txt1stweighin_TextChanged(sender As Object, e As EventArgs) Handles txt1stweighin.TextChanged
        txtgross.Text = Val(txt1stweighin.Text) & "kg"
    End Sub

    Private Sub txt2ndweighin_TextChanged(sender As Object, e As EventArgs) Handles txt2ndweighin.TextChanged
        txttare.Text = Val(txt2ndweighin.Text) & "kg"

        If (Val(txttare.Text) <= 0) Then txt2ndweighin_capturedate.Text = ""
        Calc()
    End Sub
    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        Calc()
    End Sub

    Private Sub Calc()
        If (Val(txt1stweighin.Text) < Val(txt2ndweighin.Text)) Then
            txtgross.Text = Val(txt2ndweighin.Text) & "kg"
            txttare.Text = Val(txt1stweighin.Text) & "kg"
        End If
        txtnet.Text = Val(Num(txtgross.Text) - Num(txttare.Text)) & "kg"
        txtaveweight.Text = Format(Val(Val(Num(txtnet.Text) / Val(txtqty.Text))), "##.##") & "kg"
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click, btnrefresh.Click, btnsearch.Click, txtfind.TextChanged
        PopulateList()
    End Sub

    Private Sub btnpending_Click(sender As Object, e As EventArgs) Handles btnpending.Click, btncompleted.Click, btnall.Click
        Dim btn As Button = sender
        UpdateSelection(btn.Text)
    End Sub
    Private Sub UpdateButtonCategory()
        Select Case GridDisplay
            Case "ALL"
                btnall.BackColor = Color.Orange
                btnall.Font = New Font(btnall.Font, FontStyle.Bold)
                btnpending.BackColor = Color.OldLace
                btnpending.Font = New Font(btnpending.Font, FontStyle.Regular)
                btncompleted.BackColor = Color.OldLace
                btncompleted.Font = New Font(btncompleted.Font, FontStyle.Regular)
            Case "COMPLETED"
                btncompleted.BackColor = Color.Orange
                btncompleted.Font = New Font(btncompleted.Font, FontStyle.Bold)
                btnall.BackColor = Color.OldLace
                btnall.Font = New Font(btnall.Font, FontStyle.Regular)
                btnpending.BackColor = Color.OldLace
                btnpending.Font = New Font(btnpending.Font, FontStyle.Regular)
            Case Else
                btnpending.BackColor = Color.Orange
                btnpending.Font = New Font(btnpending.Font, FontStyle.Bold)
                btnall.BackColor = Color.OldLace
                btnall.Font = New Font(btnall.Font, FontStyle.Regular)
                btncompleted.BackColor = Color.OldLace
                btncompleted.Font = New Font(btncompleted.Font, FontStyle.Regular)
        End Select
    End Sub

    Private Sub UpdateSelection(DisplayGroup As String)
        GridDisplay = DisplayGroup
        Update_AppConfiguration()
        UpdateButtonCategory()
        PopulateList()
    End Sub

    Private Sub btnfindcancel_Click(sender As Object, e As EventArgs) Handles btnfindcancel.Click
        txtfind.Text = ""
        PopulateList()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click, PortToolStripMenuItem.Click
        Dim frm As New frmSettings
        frm.TabControl1.SelectTab(1)
        frm.ShowDialog(Me)
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Dim frm As New frmSettings
        frm.TabControl1.SelectTab(0)
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnsaveandprint_Click(sender As Object, e As EventArgs) Handles btnsaveandprint.Click
        Dim ticketno As String = txtticketno.Text
        If (IsEditting) Then
            UpdateTransaction()
        Else
            SaveTransaction()
        End If
        BeginPrint(ticketno)
    End Sub


    Private Sub txt1stweighin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1stweighin.KeyPress, txt2ndweighin.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        e.KeyChar = ""
        'End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim ticketno As String = txtticketno.Text
        BeginPrint(ticketno)
    End Sub

    Private Sub DeleteTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteTransactionToolStripMenuItem.Click, btndelete.Click
        Dim itemsForDelete As List(Of Integer) = GetSelectedKeyIds(dtg)
        If (itemsForDelete.Count > 0) Then
            Dim ask = MessageBox.Show("Are you sure you want to delete the selected transactions?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (ask = DialogResult.Yes) Then
                Dim d As New clsDataManipulation
                d.Exec(String.Format("UPDATE tbltransaction SET archive=1 WHERE keyid IN ({0})", String.Join(",", itemsForDelete)))
            End If
            RefreshToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tmrReading_Tick(sender As Object, e As EventArgs) Handles tmrReading.Tick
        Try
            lblreading.Text = FormatReading(objSerialPort.ReadExisting)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick

    End Sub

    Private Sub txtscaleprice_Leave(sender As Object, e As EventArgs) Handles txtscaleprice.Leave
        txtscaleprice.Text = Val(txtscaleprice.Text).ToString("F2")
    End Sub
End Class

Imports System.IO

Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form3
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.PrinterSettings.Copies = 2


        PrintDocument1.Print()


    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Blue, 100, 100)


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

    Private Sub Print(printType As String)

        Dim template As String = Environment.CurrentDirectory & "\" & printType & "_Template.xlsx"
        Dim thisOne As String = ""
        thisOne = Environment.CurrentDirectory & "\" & printType & "_Print.xlsx"

        ' delete the file first
        Try
            Kill(thisOne)
        Catch ex As Exception

        End Try


        ' preparation of the transaction information
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        xlWorkBook = xlApp.Workbooks.Open(template)
        xlWorkSheet = xlWorkBook.Worksheets(printType & "_Template")

        With thisTransanction
            xlWorkSheet.UsedRange.Replace("wstp_warehouse", .Warehouse)
            xlWorkSheet.UsedRange.Replace("wstp_ticketno", .TicketNo)
            xlWorkSheet.UsedRange.Replace("wstp_address", .Address)
            xlWorkSheet.UsedRange.Replace("wstp_daterequest", .DateRequest)
            xlWorkSheet.UsedRange.Replace("wstp_vc", .VarietyCode)
            xlWorkSheet.UsedRange.Replace("wstp_bags", .QtyBags)
            xlWorkSheet.UsedRange.Replace("wstp_dnet", .DeductedNet)
            xlWorkSheet.UsedRange.Replace("wstp_natureoftransaction", .NatureofTransaction)
            xlWorkSheet.UsedRange.Replace("wtsp_gq", IIf(.StockCondition = "GQ", "X", ""))
            xlWorkSheet.UsedRange.Replace("wtsp_trd", IIf(.StockCondition = "TRD", "X", ""))
            xlWorkSheet.UsedRange.Replace("wstp_inf", IIf(.StockCondition = "INF", "X", ""))
            xlWorkSheet.UsedRange.Replace("wstp_pd", IIf(.StockCondition = "PD", "X", ""))
            xlWorkSheet.UsedRange.Replace("wstp_td", IIf(.StockCondition = "TD", "X", ""))
            xlWorkSheet.UsedRange.Replace("wstp_dnet", .DeductedNet)
            xlWorkSheet.UsedRange.Replace("wstp_operator", thisUser.FullName)
            xlWorkSheet.UsedRange.Replace("wstp_carrier", .Carrier)
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


        ' perform the actual print
        'Dim objProcess As New System.Diagnostics.ProcessStartInfo

        'With objProcess
        '    .FileName = thisOne
        '    .WindowStyle = ProcessWindowStyle.Hidden
        '    .Verb = "print"

        '    .CreateNoWindow = True
        '    .UseShellExecute = True
        'End With
        'Try
        '    System.Diagnostics.Process.Start(objProcess)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
    End Sub

    Public Sub PrepPrint(ticketno As String)
        thisTransanction = New Transaction
        Dim stock_condition As String = ""
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("select * from tbltransaction where ticket_no = '" & ticketno & "'")) Then
                With .DataReader
                    Do While .Read
                        thisTransanction.TicketNo = .Item("ticket_no").ToString
                        thisTransanction.DateRequest = Format(CDate(.Item("date_request").ToString), "dd MM yy")
                        thisTransanction.NatureofTransaction = .Item("nature_of_transaction").ToString
                        thisTransanction.PrintType = .Item("printing_type").ToString
                        thisTransanction.Carrier = .Item("carrier").ToString
                        thisTransanction.DriverName = .Item("driver_name").ToString
                        thisTransanction.Address = .Item("address").ToString
                        thisTransanction.PlateNo = .Item("plate_no").ToString
                        thisTransanction.QtyBags = .Item("qty_bags").ToString
                        thisTransanction.VarietyCode = .Item("variety_code").ToString
                        thisTransanction.Gross = .Item("gross_weight").ToString
                        thisTransanction.GrossCapturedDate = .Item("gross_captured_date").ToString
                        thisTransanction.Tare = .Item("tare_weight").ToString
                        thisTransanction.TareCapturedDate = .Item("tare_captured_date")
                        thisTransanction.Net = .Item("net_weight").ToString
                        thisTransanction.Warehouse = .Item("warehouse").ToString
                        thisTransanction.StockCondition = .Item("stock_condition").ToString
                        thisTransanction.DeductedNet = .Item("deducted_net").ToString
                        thisTransanction.StockCondition = .Item("stock_condition").ToString

                    Loop
                    .Close()
                End With

            End If
        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrepPrint(txtticketno.Text)
        If (rbtnWSI.Checked) Then Print("WSI")
        If (rbtnWSR.Checked) Then Print("WSR")

    End Sub
End Class
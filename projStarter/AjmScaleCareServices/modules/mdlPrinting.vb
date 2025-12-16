'Imports Iron
'Imports IronXL
Imports Excel = Microsoft.Office.Interop.Excel
Module mdlPrinting

    'Public Sub BeginPrint(ticketno As String)

    '    Dim template As String = Environment.CurrentDirectory & "\_Print_Template.xlsx"
    '    Dim output As String = Environment.CurrentDirectory & "\_Print_Output.xlsx"

    '    ' delete the file first
    '    Try
    '        Kill(output)
    '    Catch ex As Exception

    '    End Try

    '    Dim wb As WorkBook = WorkBook.Load(template)
    '    Dim ws As WorkSheet = wb.WorkSheets.First()

    '    Dim d As New clsDataManipulation
    '    If (d.Fetch("SELECT * FROM tbltransaction WHERE ticketno = '" & ticketno & "'")) Then
    '        Do While d.DataReader.Read
    '            For printout As Integer = 0 To PrintVar.Count - 1
    '                For dbcol As Integer = 0 To d.DataReader.FieldCount - 1
    '                    If (PrintVar.Item(printout).ToString().ToLower().Contains(d.DataReader.GetName(dbcol).ToString().ToLower())) Then
    '                        'replace!!!
    '                        ws.Replace(PrintVar.Item(printout).ToString().ToLower(), d.DataReader.Item(d.DataReader.GetName(dbcol).ToString()))
    '                    End If
    '                Next
    '            Next
    '        Loop
    '        d.DataReader.Close()
    '    End If

    '    wb.SaveAs(output)

    '    'Process.Start("cmd", "/c powershell -command ""start-process -filepath '" & the_file & "' -verb print""")
    '    'Threading.Thread.Sleep(2000)
    '    'Process.Start("cmd", "/c taskkill /IM ""excel.exe"" /F ")

    '    'Print!
    '    Dim monProcess As New Process()
    '    monProcess.StartInfo.FileName = output
    '    monProcess.StartInfo.Verb = "Print"
    '    monProcess.StartInfo.CreateNoWindow = True
    '    monProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '    monProcess.Start()

    'End Sub

    'Public Sub ExportExcel(selection As String, outputPath As String)

    '    Dim wb As WorkBook = WorkBook.Create(ExcelFileFormat.XLSX)
    '    Dim ws As WorkSheet = wb.CreateWorkSheet("Report")

    '    'Columns
    '    Dim xlRange As String = "ABCDEFGHIJKLMNOP"
    '    Dim ReportColumns As String() = ({"Date", "TicketNo", "Customer", "Product", "Drive", "PlateNo", "Gross", "Tare", "Net", "1st Weigh In", "2nd Weigh In", "Transacted By"})
    '    Dim DatabaseColumns As String() = ({"date", "ticketno", "customer", "product", "driver", "plateno", "gross", "tare", "net", "firstweight_capturedate", "secondweight_capturedate", "operator"})
    '    Dim CellRow As Integer = 1

    '    'Report Column
    '    For i As Integer = 0 To ReportColumns.Length - 1
    '        ws(xlRange.Substring(i, 1) & "1").Value = ReportColumns(i)
    '    Next
    '    CellRow += 1

    '    Dim d As New clsDataManipulation
    '    If (d.Fetch(selection)) Then
    '        Do While d.DataReader.Read
    '            For i As Integer = 0 To ReportColumns.Length - 1
    '                ws(xlRange.Substring(i, 1) & CellRow.ToString).Value = d.DataReader.Item(DatabaseColumns(i)).ToString
    '            Next
    '            CellRow += 1
    '        Loop
    '        d.DataReader.Close()
    '    End If

    '    wb.SaveAs(outputPath)

    'End Sub


    Public Sub ExportExcel(selection As String, outputPath As String)

        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWb As Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlSht As Excel.Worksheet = xlWb.Worksheets(1)

        'Columns
        Dim xlRange As String = "ABCDEFGHIJKLMNOP"
        Dim ReportColumns As String() = ({"Date", "TicketNo", "Customer", "Product", "Drive", "PlateNo", "Qty", "Price", "Scale Price", "Total Price", "Ave Weight", "Gross", "Tare", "Net", "1st Weigh In", "2nd Weigh In", "Transacted By", "Remarks"})
        Dim DatabaseColumns As String() = ({"date", "ticketno", "customer", "product", "driver", "plateno", "qty", "price", "tprice", "sprice", "aveweight", "gross", "tare", "net", "firstweight_capturedate", "secondweight_capturedate", "operator", "remarks"})
        Dim CellRow As Integer = 1

        'Report Column
        For i As Integer = 0 To ReportColumns.Length - 1
            xlSht.Cells.Range(xlRange.Substring(i, 1) & CellRow.ToString).Value = ReportColumns(i)
        Next
        CellRow += 1

        Dim d As New clsDataManipulation
        If (d.Fetch(selection)) Then
            Do While d.DataReader.Read
                For i As Integer = 0 To ReportColumns.Length - 1
                    Dim value As Object = d.DataReader.Item(DatabaseColumns(i))

                    ' Check if the column is a date column
                    If d.DataReader.GetName(i).ToLower().Contains("date") Or d.DataReader.GetName(i).ToLower().Contains("time") Then
                        Dim dt As DateTime
                        If DateTime.TryParse(value.ToString(), dt) Then
                            xlSht.Cells(CellRow, i + 1).Value = dt
                            xlSht.Cells(CellRow, i + 1).NumberFormat = "yyyy-mm-dd hh:mm AM/PM"
                            Continue For
                        End If
                    End If

                    ' Non-date columns
                    xlSht.Cells(CellRow, i + 1).Value = value

                Next


                CellRow += 1
            Loop
            d.DataReader.Close()
        End If

        xlWb.SaveAs(outputPath)

        xlWb.Close()
        xlApp.Quit()

    End Sub

    Public Sub BeginPrint(ticketno As String)

        Dim template As String = Environment.CurrentDirectory & "\_Print_Template.xlsx"
        Dim output As String = Environment.CurrentDirectory & "\_Print_Output.xlsx"

        ' delete the file first
        Try
            'Process.Start("cmd", "/c powershell -command ""start-process -filepath '" & output & "' -verb print""")
            'Threading.Thread.Sleep(2000)
            'Process.Start("cmd", "/c taskkill /IM ""excel.exe"" /F ")
            'Process.Start("cmd", String.Format("copy {0} {1}", template, output))
            Kill(output)
        Catch ex As Exception

        End Try

        Dim xlApp As Excel.Application = New Excel.Application
        xlApp.DisplayAlerts = False
        xlApp.Visible = False
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        xlWorkBook = xlApp.Workbooks.Open(template)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim d As New clsDataManipulation
        If (d.Fetch("SELECT  
        *,  
        format(firstweight_capturedate,""yyyy-MM-dd HH:mm"") AS `firstweight_capturedate_f`,
        format(secondweight_capturedate,""yyyy-MM-dd HH:mm"") AS `secondweight_capturedate_f`
         FROM tbltransaction WHERE ticketno = '" & ticketno & "'")) Then
            Do While d.DataReader.Read
                For printout As Integer = 0 To PrintVar.Count - 1
                    For dbcol As Integer = 0 To d.DataReader.FieldCount - 1
                        If (Replace(PrintVar.Item(printout).ToString(), "rpt_", "").ToLower() = d.DataReader.GetName(dbcol).ToString().ToLower()) Then
                            'replace!!!
                            xlWorkSheet.UsedRange.Replace(PrintVar.Item(printout).ToString().ToLower(), d.DataReader.Item(d.DataReader.GetName(dbcol).ToString()))
                        End If
                    Next
                Next
            Loop
            d.DataReader.Close()
        End If

        Try
            xlWorkBook.SaveAs(output)
        Catch ex As Exception

        End Try

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)


        'PRINT!!
        SendToPrint(output)

    End Sub

    Private Sub SendToPrint(the_file As String)
        Dim monProcess As New Process()
        monProcess.StartInfo.FileName = the_file
        monProcess.StartInfo.Verb = "Print"
        monProcess.StartInfo.CreateNoWindow = True
        monProcess.Start()

        Threading.Thread.Sleep(2000)
        Process.Start("cmd", "/c taskkill /IM ""excel.exe"" /F ")
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


End Module

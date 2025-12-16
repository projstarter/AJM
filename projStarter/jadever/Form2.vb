Imports System.IO.Ports
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            SerialPort1.PortName = ComboBox1.Text
            SerialPort1.BaudRate = Val("9600")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            SerialPort1.Open()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            com1 = My.Computer.Ports.OpenSerialPort("COM4")
            com1.ReadTimeout = 10000
            com1.BaudRate = 9600
            com1.DataBits = 8
            com1.StopBits = 1

            Do
                Dim IncomingSingle As String = com1.ReadLine()
                Dim Incoming() As String = Split(com1.ReadExisting(), vbCr)
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    Dim val As String = Incoming(Incoming.Count - 1)
                    If val <> "" Then
                        TextBox1.Text = val
                        Exit Do
                    End If
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

    End Sub


    Private Sub printdoc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False


        ComboBox1.Items.Clear()
        Dim ports() As String = SerialPort.GetPortNames()

        For Each port As String In ports
            ComboBox1.Items.Add(port)
        Next
    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Return value.Count(Function(c As Char) c = ch)
    End Function
    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived


        Dim str As String = SerialPort1.ReadExisting()
        ListBox1.Items.Add(str)
        'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        'Dim str2 As String = Replace(ReplaceAll(str), "  ", " ")
        'If str2.Length > 5 Then
        '    TextBox2.Text = str2
        '    Dim str3() As String = Split(str2, " ")

        '    Dim rIndex As Integer = 0
        '    For i As Integer = 0 To str3.Count - 1
        '        If Val(str3(i)) > 0 Then
        '            rIndex = i
        '            Exit For
        '        End If
        '    Next
        '    TextBox1.Text = Val(str3(rIndex))

        '    'TextBox1.Text = Val(str3(0)) & " " & Val(str3(1)) & " " & Val(str3(2))
        'End If


        ''Dim str() As String = Split(SerialPort1.ReadExisting(), vbCr)
        ''Dim validLine As String = str(str.Count - 1)
        'ListBox1.Items.Add(str)
        ''TextBox2.Text = validLine
        'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        'If validLine.Length > 5 Then
        '    'Dim dispVal As String = ReplaceAll(validLine)
        '    'Dim s As String = regex
        '    dispval = Replace(dispval, "?" & ChrW(2) & ":0    ", "")
        '    dispval = Replace(dispval, "?)0    ", "")
        '    dispval = Replace(dispval, ")0   ", "")
        '    TextBox1.Text = Val(ReplaceAll(validLine))
        'End If
    End Sub
    Function ReplaceAll(ByVal strText As String) As String
        Dim RegExp As Object
        RegExp = CreateObject("VBScript.RegExp")
        With RegExp
            .Pattern = "([^0-9 )])"
            .Global = True
            .IgnoreCase = False
            .MultiLine = True
            ReplaceAll = .Replace(strText, "") ' " $1"
        End With
    End Function
End Class
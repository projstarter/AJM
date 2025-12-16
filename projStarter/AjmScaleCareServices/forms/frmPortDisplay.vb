Imports System.IO.Ports
Imports System.Threading

Public Class frmPortDisplay
    Dim WithEvents objSerialPort As New SerialPort
    Private Sub frmPortDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        For Each port As String In SerialPort.GetPortNames
            ComboBox1.Items.Add(port)
        Next
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenSerialPort()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
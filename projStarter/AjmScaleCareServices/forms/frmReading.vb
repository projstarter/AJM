Imports System.IO
Imports System.IO.Ports

Public Class frmReading


    Public WithEvents objSerialPort As New SerialPort
    Private myReading As String
    Public Property Reading() As String
        Get
            Return myReading
        End Get
        Set(ByVal value As String)
            myReading = value
        End Set
    End Property

    Private Sub frmReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenSerialPort()
    End Sub

    Private Sub frmReading_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                myReading = txtreading.Text
                CloseSerialPort()
                Me.Hide()
            Case Keys.Escape
                CloseSerialPort()
                Me.Close()
        End Select
    End Sub

    Private Function FormatReading(reading As String) As Integer
        Dim r As String() = Split(StrReverse(reading), "=")
        Return IIf(r.Length >= 2, Val(r(1)), 0)
    End Function

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtreading.Text = FormatReading(objSerialPort.ReadExisting)
    End Sub

    Private Sub frmReading_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CloseSerialPort()
    End Sub
End Class
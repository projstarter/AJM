Imports System.IO.Ports
Public Class frmPortConfiguration
    Private Sub frmPortConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboport.Items.Clear()
        For Each port As String In SerialPort.GetPortNames
            cboport.Items.Add(port)
        Next
        LoadSettings()
    End Sub
    Public Sub LoadSettings()
        With My.Settings
            cboport.Text = .portname
            txtreadtimeout.Text = .readtimeout
            txtbaudrate.Text = .baudrate
            txtdatabits.Text = .databits
            txtstopbits.Text = .stopbits
        End With
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With My.Settings
            .portname = cboport.Text
            .readtimeout = txtreadtimeout.Text
            .baudrate = txtbaudrate.Text
            .databits = txtdatabits.Text
            .stopbits = txtstopbits.Text
            .Save()
        End With
        Me.Close()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.Close()
    End Sub

End Class
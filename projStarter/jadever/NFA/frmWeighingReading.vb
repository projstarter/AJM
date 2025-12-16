Imports System.ComponentModel
Imports System.IO.Ports

Public Class frmWeighingReading

    Private Sub frmWeighingReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()
        'WeighingScaleReading = 0
        'lblreading.Text = WeighingScaleReading
        btnCapture.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnCapture.Click
        Me.Close()
    End Sub
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do While 1 = 1
            'lblreading.Text = WeighingScaleReading
        Loop
    End Sub
End Class
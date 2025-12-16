Imports System.ComponentModel

Public Class frmDeveloperTools
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnSave.Click
        Me.Close()
    End Sub

    Private Sub frmDeveloperTools_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Use_Counter = txtmasterdirectory.Text
        My.Settings.Save()
    End Sub

    Private Sub frmDeveloperTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmasterdirectory.Text = My.Settings.Use_Counter
        ConnectDB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New clsDataManipulation
        d.Insert("tblapp", {
                     "s startdate         => " & Format(Now, "yyyy-MM-dd"),
                     "s enddate           => " & Format(DateAdd(DateInterval.Year, 1, Now), "yyyy-MM-dd"),
                     "s key1              => " & TextEncode(txtkey1.Text),
                     "s key2              => " & TextEncode(txtkey2.Text),
                     "s key3              => " & TextEncode(txtkey3.Text),
                     "s key4              => " & TextEncode(txtkey4.Text),
                     "s key5              => " & TextEncode(txtkey5.Text)
        })
    End Sub
End Class
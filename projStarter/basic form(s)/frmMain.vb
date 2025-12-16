Public Class frmTransaction
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateListView()
        lblStatusLoginAs.Text = String.Format("Login as {0} ({1})", thisUser.UserFunction, thisUser.Nickname)
    End Sub
    Private Sub PopulateListView()
        Dim lstItems As New ListViewItem("Test", imglstMenuItem.Images.IndexOfKey("useraccount.png"))
        ListView1.Items.Add(lstItems)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
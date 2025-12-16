Public Class frmLogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If (LoginMe(txtusername.Text, txtpassword.Text)) Then
            frmMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username/Password. Please try again!", "Login Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Select()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDB()
    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        txtpassword.SelectAll()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin_Click(Nothing, Nothing)
        End If
    End Sub
End Class
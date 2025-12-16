Public Class frmUserRegistration
    Private Sub frmUserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCbo(cboUserType, "select distinct type from tblusertype where type <> '' order by 1 asc")
    End Sub

    Private Sub CloseMe(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClearEntry_Click(sender As Object, e As EventArgs) Handles btnClearEntry.Click
        ClearEntry()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btnSave.Enabled = (txtFirstname.Text.Trim <> "" And
                            txtLastname.Text.Trim <> "" And
                            txtNickname.Text.Trim <> "" And
                            cboUserType.Text.Trim <> "" And
                            txtUsername.Text.Trim <> "" And
                            txtPassword.Text.Trim <> "" And
                            txtRetypePassword.Text.Trim <> "") And (txtPassword.Text.Trim = txtRetypePassword.Text.Trim)
        If (txtPassword.Text.Trim <> txtRetypePassword.Text.Trim) And (txtPassword.Text.Trim <> "" And txtRetypePassword.Text.Trim <> "") Then
            Label9.Text = "Password did not match!"
        Else
            Label9.Text = "* Required fields cannot be blank."
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRegistration()
        Me.Close()
    End Sub

    Private Sub ClearEntry()
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtNickname.Text = ""
        cboUserType.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRetypePassword.Text = ""
        txtFirstname.Focus()
    End Sub
    Private Sub SaveRegistration()
        Dim cmdText As String = "INSERT INTO tbluser (uname,pw,rpw,firstname,lastname,nickname,function) " &
            "values ('" & FixApostrophe(txtUsername.Text) & "','" & TextEncode(FixApostrophe(txtPassword.Text)) & "', " &
            "'" & TextEncode(FixApostrophe(txtRetypePassword.Text)) & "','" & FixApostrophe(txtFirstname.Text) & "', " &
            "'" & FixApostrophe(txtLastname.Text) & "','" & FixApostrophe(txtNickname.Text) & "', " &
            "'" & FixApostrophe(cboUserType.Text) & "')"

        Dim d As New clsDataManipulation
        d.Exec(cmdText)
        MessageBox.Show(Me, "Registration completed successfully!", "Registration Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtLastname.KeyPress, txtNickname.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
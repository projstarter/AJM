Public Class frmUserAccounts
    Private Sub frmUserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnrefresh.Click, txtSearch.TextChanged, btnsearch.Click
        PopulateList()
    End Sub

    Sub PopulateList()
        PopulateDataGridView(dtgList, "SELECT keyid," &
                             "lastname & ', ' & firstname," &
                             "uname," &
                             "pw," &
                             "function," &
                             "SWITCH (isactive=0,'Suspended',isactive<>0,'Active')," &
                             "SWITCH (isactive=0,'Activate',isactive<>0,'Suspend')," &
                             "activated_by," &
                             "format(activated_date,'yyyy-MM-dd')," &
                             "suspended_by," &
                             "format(suspended_date,'yyyy-MM-dd') " &
                            "FROM tbluser " &
                            "WHERE uname & lastname & firstname LIKE '%" & txtSearch.Text & "%'")
        lblstatus.Text = String.Format("{0} user(s) found in the system!", dtgList.RowCount)
    End Sub

    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick
        If e.ColumnIndex = 6 Then
            UpdateUserStatus(dtgList.Item(0, e.RowIndex).Value, (dtgList.Item(e.ColumnIndex, e.RowIndex).Value = "Activate"))
        End If
    End Sub

    Sub UpdateUserStatus(keyid As Integer, toActive As Boolean)
        Dim d As New clsDataManipulation
        Dim cmdText As String = ""
        If (toActive) Then
            cmdText = "UPDATE tbluser SET isactive=1,activated_by='" & thisUser.FullName & "',activated_date='" & Format(Now, "yyyy-MM-dd") & "',suspended_by=null,suspended_date=null WHERE keyid IN (" & keyid & ") "
        Else
            cmdText = "UPDATE tbluser SET isactive=0,suspended_by='" & thisUser.FullName & "',suspended_date='" & Format(Now, "yyyy-MM-dd") & "' WHERE keyid IN (" & keyid & ") "
        End If
        d.Exec(cmdText)
        PopulateList()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New frmUserRegistration
        frm.ShowDialog(Me)
        PopulateList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
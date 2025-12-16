Public Class frmLicenseEntry
    Private Sub frmLicenseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With My.Settings
                t1.Text = .key1
                t2.Text = .key2
                t3.Text = .key3
                t4.Text = .key4
                t5.Text = .key5
            End With

            Dim startdate As String, enddate As String
            Dim d As New clsDataManipulation
            With d
                If (.Fetch("SELECT * FROM tblapp WHERE archive=0 AND " &
                        "(key1 = '" & TextEncode(My.Settings.key1) & "' AND " &
                        "key2 = '" & TextEncode(My.Settings.key2) & "' AND " &
                        "key3 = '" & TextEncode(My.Settings.key3) & "' AND " &
                        "key4 = '" & TextEncode(My.Settings.key4) & "' AND " &
                        "key5 = '" & TextEncode(My.Settings.key5) & "')")) Then
                    With .DataReader
                        Do While .Read
                            startdate = .Item("startdate").ToString()
                            enddate = .Item("enddate").ToString()
                        Loop
                        .Close()
                    End With
                    lblstatus.Text = String.Format("Activation Date: {0} | Date End : {1} | Remaining : {2} day(s)", Format(CDate(startdate), "yyyy-MM-dd"), Format(CDate(enddate), "yyyy-MM-dd"), DateDiff(DateInterval.Day, CDate(startdate), CDate(enddate)))
                Else
                    lblstatus.Text = "No/Invalid license detected!"
                End If

            End With
        Catch ex As Exception
            lblstatus.Text = "No key found!"
        End Try



    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With My.Settings
            .key1 = t1.Text
            .key2 = t2.Text
            .key3 = t3.Text
            .key4 = t4.Text
            .key5 = t5.Text
            .Save()
        End With
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t1.Enabled = (t1.Text <> "" And t2.Text <> "" And t3.Text <> "" And t4.Text <> "" And t5.Text <> "")
        t2.Enabled = (t1.Text <> "" And t2.Text <> "" And t3.Text <> "" And t4.Text <> "" And t5.Text <> "")
        t3.Enabled = (t1.Text <> "" And t2.Text <> "" And t3.Text <> "" And t4.Text <> "" And t5.Text <> "")
        t4.Enabled = (t1.Text <> "" And t2.Text <> "" And t3.Text <> "" And t4.Text <> "" And t5.Text <> "")
        t5.Enabled = (t1.Text <> "" And t2.Text <> "" And t3.Text <> "" And t4.Text <> "" And t5.Text <> "")

    End Sub
End Class
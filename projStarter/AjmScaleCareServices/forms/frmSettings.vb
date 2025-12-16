Imports System.IO
Imports System.IO.Ports
Imports Newtonsoft.Json.Linq

Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboports.Items.Clear()
        For Each port As String In SerialPort.GetPortNames
            cboports.Items.Add(port)
        Next
        LoadUsers()
        LoadPortConfiguration()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (_editting) Then
            UpdateRegistration()
        Else
            SaveRegistration()
        End If
    End Sub

    Private Sub SaveRegistration()
        _Insert("tbluser",
                         {
                             "s username => " & FixApostrophe(txtusername.Text),
                             "s nickname => " & FixApostrophe(txtnickname.Text),
                             "s password => " & _TextEncode(FixApostrophe(txtpassword.Text)),
                             "s password2 => " & _TextEncode(FixApostrophe(txtpassword2.Text)),
                             "s firstname => " & FixApostrophe(txtfirstname.Text),
                             "s lastname => " & FixApostrophe(txtlastname.Text),
                             "s type => " & FixApostrophe(cbousertype.Text)
                         }
                      )

        MessageBox.Show(Me, "Registration completed successfully!", "Registration Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadUsers()
    End Sub
    Dim _id As Integer = 0
    Dim _editting As Boolean = False
    Private Sub UpdateRegistration()
        _Update("tbluser",
                         {
                             "s username => " & FixApostrophe(txtusername.Text),
                             "s nickname => " & FixApostrophe(txtnickname.Text),
                             "s password => " & _TextEncode(FixApostrophe(txtpassword.Text)),
                             "s password2 => " & _TextEncode(FixApostrophe(txtpassword2.Text)),
                             "s firstname => " & FixApostrophe(txtfirstname.Text),
                             "s lastname => " & FixApostrophe(txtlastname.Text),
                             "s type => " & FixApostrophe(cbousertype.Text)
                         },
                          {"id IN (" & _id & ")"}
                      )

        MessageBox.Show(Me, "Registration updated successfully!", "Registration Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        PopulateDataGridView(Me.dtg,
                        "SELECT id, lastname ||', '||firstname||'('||nickname||')', username, password, type, active  FROM tbluser", True)
    End Sub

    Private Sub dtg_DoubleClick(sender As Object, e As EventArgs) Handles dtg.DoubleClick
        LoadUser(dtg.SelectedRows.Item(0).Cells(1).Value)
        _editting = True
    End Sub

    Private Sub ClearEntry()
        _editting = False
        txtlastname.Text = ""
        txtfirstname.Text = ""
        txtnickname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtpassword2.Text = ""
        cbousertype.Text = ""
    End Sub

    Private Sub LoadUser(id As Integer)
        ClearEntry()
        _id = id
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT * FROM tbluser WHERE id IN (" & _id & ")")) Then
                With .DataReader
                    Do While .Read
                        txtlastname.Text = .Item("lastname").ToString()
                        txtfirstname.Text = .Item("firstname").ToString()
                        txtnickname.Text = .Item("nickname").ToString()
                        txtusername.Text = .Item("username").ToString()
                        'txtpassword.Text = _TextEncode(FixApostrophe(.Item("password").ToString()))
                        'txtpassword2.Text = _TextEncode(FixApostrophe(.Item("password2").ToString()))
                        cbousertype.Text = .Item("type").ToString()
                    Loop
                    .Close()
                End With
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        LoadUsers()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btnsave.Enabled = ((txtpassword.Text = txtpassword2.Text) And txtpassword.Text <> "" And txtusername.Text <> "" And txtlastname.Text <> "" And txtfirstname.Text <> "" And cbousertype.Text <> "")
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        ClearEntry()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim d As New clsDataManipulation
        For i As Integer = 0 To dtg.Rows.Count - 1
            If (dtg.Item(0, i).Value = True) Then
                d.Exec("DELETE FROM tbluser WHERE Id IN (" & dtg.Item(1, i).Value & ")")
            End If
        Next
        LoadUsers()
    End Sub

    Private Sub btndeactivate_Click(sender As Object, e As EventArgs) Handles btndeactivate.Click
        Dim d As New clsDataManipulation
        For i As Integer = 0 To dtg.Rows.Count - 1
            If (dtg.Item(0, i).Value = True) Then
                d.Exec("UPDATE tbluser SET active= NOT(active) WHERE Id IN (" & dtg.Item(1, i).Value & ")")
            End If
        Next
        LoadUsers()
    End Sub

    Private Sub btnokport_Click(sender As Object, e As EventArgs) Handles btnokport.Click
        With PortInformation
            .PortName = cboports.Text
            .BaudRate = Val(txtbaudrate.Text)
            .ReadTimeout = Val(txtreadtimeout.Text)
            .DataBits = Val(txtdatabits.Text)
            .StopBits = Val(txtstopbits.Text)
        End With
        Update_AppConfiguration()
        MessageBox.Show("Please restart the application to apply the new settings.", "Port Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Sub LoadPortConfiguration()
        With PortInformation
            cboports.Text = .PortName
            txtbaudrate.Text = .BaudRate
            txtreadtimeout.Text = .ReadTimeout
            txtdatabits.Text = .DataBits
            txtstopbits.Text = .StopBits
        End With
    End Sub

End Class
Imports System.Data.OleDb
Module mdlDataManipulation
    Public conn As OleDbConnection
    Public Sub ConnectDB()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "\wstp.mdb;Jet OLEDB:Database Password=pr0j5t4rt3r")
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Database connection failed!" & vbNewLine & vbNewLine & "ERROR: " & ex.Message,
                   MessageBoxIcon.Exclamation & MessageBoxButtons.OK, "ConnectDB()")
        End Try
    End Sub

    Function AppIsLicensed() As Boolean
        AppIsLicensed = False
        Dim d As New clsDataManipulation
        If (d.Fetch("SELECT * FROM tblapp WHERE archive=0 AND " &
                    "(key1 = '" & TextEncode(My.Settings.key1) & "' AND " &
                    "key2 = '" & TextEncode(My.Settings.key2) & "' AND " &
                    "key3 = '" & TextEncode(My.Settings.key3) & "' AND " &
                    "key4 = '" & TextEncode(My.Settings.key4) & "' AND " &
                    "key5 = '" & TextEncode(My.Settings.key5) & "') AND " &
                    "(startdate <= " & Format(Now, "#dd/MM/yyyy#") & " AND enddate >= " & Format(Now, "#dd/MM/yyyy#") & ")")) Then
            AppIsLicensed = True
        End If
        Return AppIsLicensed
    End Function


    Public Function LoginMe(uname As String, pw As String) As Boolean

        'If Not (AppIsLicensed()) Then
        '    MessageBox.Show("You have reach the allowed usage of this app. Contact your administrator for the activation of this application. Thank you!", "License Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End
        'End If

        'My.Settings.Use_Counter += 1
        My.Settings.Save()

        Dim found As Boolean = False
        If (FixSpaces(uname) = "" Or FixSpaces(pw) = "") Then Return False

        Dim unameConverted As String = FixApostrophe(uname)
        Dim pwConverted As String = TextEncode(FixApostrophe(pw))
        Dim strSelect As String = "SELECT * FROM tbluser WHERE (uname='" & unameConverted & "' AND pw='" & pwConverted & "') AND archive=0 AND isactive<>0"

        Dim d As New clsDataManipulation
        With d
            If (.Fetch(strSelect)) Then
                With .DataReader
                    Do While .Read
                        found = True
                        thisUser.Lastname = .Item("lastname").ToString()
                        thisUser.Firstname = .Item("firstname").ToString()
                        thisUser.Nickname = .Item("nickname").ToString()
                        thisUser.UserFunction = .Item("function").ToString()
                        thisUser.IsAdmin = (.Item("function").ToString() = "Administrator" Or .Item("function").ToString() = "Super Administrator")
                        thisUser.IsSuperAdmin = (.Item("function").ToString() = "Super Administrator")
                        thisUser.FullName = String.Format("{0}, {1}", .Item("lastname").ToString(), .Item("firstname").ToString())
                    Loop
                    .Close()
                End With
            End If
        End With

        Return found
    End Function

    Public Function GetLatestTicketNo() As String
        GetLatestTicketNo = 0
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("select max(keyid) from tbltransaction")) Then
                With .DataReader
                    Do While .Read
                        GetLatestTicketNo = Val(.Item(0).ToString)
                    Loop
                    .Close()
                End With
            Else
                GetLatestTicketNo = 0
            End If
        End With

        Return FormatTicketNo(GetLatestTicketNo)

    End Function


    Public Function FormatTicketNo(tval As String) As String
        tval = Val(tval) + 1
        FormatTicketNo = ""
        For i As Integer = Len(tval) + 1 To 6
            FormatTicketNo &= "0"
        Next
        FormatTicketNo = FormatTicketNo & tval
        Return FormatTicketNo
    End Function

End Module

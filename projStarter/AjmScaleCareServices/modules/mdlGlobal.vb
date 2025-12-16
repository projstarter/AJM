

Imports System.IO
Imports Newtonsoft.Json.Linq

Structure UserInfo
    Public Fullname As String
    Public Lastname As String
    Public Firstname As String
    Public Nickname As String
    Public Username As String
    Public UserType As String
End Structure

Module mdlGlobal
    Public AppLog As String
    Public User As New UserInfo

    Public Current_User

    Public Function Num(valwith_kg As String) As Integer
        Return Val(Replace(valwith_kg, "kg", ""))
    End Function

    Public serialStatus As String = ""
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
    Public Function LoginMe(uname As String, pw As String) As Boolean

        Dim found As Boolean = False
        If (FixSpaces(uname) = "" Or FixSpaces(pw) = "") Then Return False

        Dim unameConverted As String = FixApostrophe(uname)
        Dim pwConverted As String = _TextEncode(FixApostrophe(pw))
        Dim strSelect As String = "SELECT * FROM tbluser WHERE (username='" & unameConverted & "' AND password='" & pwConverted & "') and active=1"

        Dim d As New clsDataManipulation
        With d
            If (.Fetch(strSelect)) Then
                With .DataReader
                    Do While .Read
                        found = True
                        User.Lastname = .Item("lastname").ToString()
                        User.Firstname = .Item("firstname").ToString()
                        User.Nickname = .Item("nickname").ToString()
                        User.UserType = .Item("type").ToString()
                        User.Username = .Item("username").ToString()
                        User.Fullname = String.Format("{0}, {1}", .Item("lastname").ToString(), .Item("firstname").ToString())
                    Loop
                    .Close()
                End With
            End If
        End With

        Return found
    End Function

    Function GetSelectedKeyIds(dtg As DataGridView) As List(Of Integer)
        Dim items As List(Of Integer) = New List(Of Integer)
        For Each row As DataGridViewRow In dtg.Rows
            If (CType(row.Cells(0).Value, Boolean) = True) Then
                items.Add(row.Cells(dtg.ColumnCount - 1).Value)
            End If
        Next
        Return items
    End Function
    Public Function FormatReading(reading As String) As Integer
        Dim r As String() = Split(StrReverse(reading), "=")
        Try
            Return IIf(r.Length >= 2, Val(r(1)), 0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Module

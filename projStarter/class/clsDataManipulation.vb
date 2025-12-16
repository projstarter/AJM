
Imports System.Data.OleDb

Public Class clsDataManipulation


    Private myReader As OleDbDataReader
    Public Property DataReader() As OleDbDataReader
        Get
            Return myReader
        End Get
        Set(ByVal value As OleDbDataReader)
            myReader = value
        End Set
    End Property
    Sub New()
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("Unable to stablish database connection!", "ERROR: 'clsDataManipulation' Class")
        End If
    End Sub

    Public Sub Exec(cmdText As String)
        If Not (conn.State = ConnectionState.Open) Then Exit Sub
        Dim cmd As OleDbCommand = New OleDbCommand(cmdText, conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Command syntax error!" & vbNewLine & vbNewLine & "ERROR: " & ex.Message,
                   MessageBoxIcon.Exclamation & MessageBoxButtons.OK, "Exec()")
        End Try
    End Sub

    Public Function Fetch(cmdText As String) As Integer
        If Not (conn.State = ConnectionState.Open) Then Return False
        Dim cmd As OleDbCommand = New OleDbCommand(cmdText, conn)
        myReader = Nothing
        myReader = cmd.ExecuteReader
        Return myReader.HasRows()
    End Function

    Public Sub Insert(TableDestination As String, ByVal FieldAndValues() As String)

        Dim strFields As String = ""
        Dim strValues As String = ""
        For i As Integer = 0 To FieldAndValues.Count - 1
            Dim strLine As String = FixSpaces(FieldAndValues(i).ToString())
            Dim dataType As String = strLine.Substring(0, 1)
            strLine = FixSpaces(strLine.Substring(1, Len(strLine) - 1))

redo:
            Dim str() As String = Split(strLine, " => ")
            If (str.Count < 2) Then
                strLine &= " "
                GoTo redo
            End If
            strFields &= IIf(strFields <> "", "," & FixSpaces(str(0)), FixSpaces(str(0)))

            Select Case dataType
                Case "s"
                    strValues &= IIf(strValues <> "", ",'" & FixApostrophe(str(1)) & "'", "'" & FixApostrophe(str(1)) & "'")
                Case "n"
                    Dim n As String = Replace(str(1), ",", "")
                    strValues &= IIf(strValues <> "", "," & n, n)
                Case "d"
                    If FixApostrophe(str(1)) = "" Then
                        strValues &= IIf(strValues <> "", ",null", "null")
                    Else
                        strValues &= IIf(strValues <> "", ",'" & FixApostrophe(str(1)) & "'", "'" & FixApostrophe(str(1)) & "'")
                    End If
                Case Else
            End Select

        Next

        Dim d As New clsDataManipulation
        d.Exec(String.Format("INSERT INTO {0} ({1}) VALUES ({2})", TableDestination, strFields, strValues))

    End Sub

    Public Sub Update(TableSource As String, ByVal FieldAndValues() As String, WhereCriteria() As String)

        Dim strLine As String = "", dataType As String = "", strFieldAndValuesConverted As String = ""

        Dim strFieldAndValues As String = ""
        For i As Integer = 0 To FieldAndValues.Count - 1

            strLine = FixSpaces(FieldAndValues(i).ToString())
            dataType = strLine.Substring(0, 1)
            strLine = FixSpaces(strLine.Substring(1, Len(strLine) - 1))

redo:
            Dim str() As String = Split(strLine, " => ")
            If (str.Count < 2) Then
                strLine &= " "
                GoTo redo
            End If

            Select Case dataType
                Case "s"
                    strFieldAndValuesConverted = FixApostrophe(str(0)) & "='" & FixApostrophe(str(1)) & "'"
                    strFieldAndValues &= IIf(strFieldAndValues <> "", "," & strFieldAndValuesConverted, strFieldAndValuesConverted)
                Case "n"
                    strFieldAndValuesConverted = FixApostrophe(str(0)) & "=" & FixApostrophe(str(1))
                    strFieldAndValues &= IIf(strFieldAndValues <> "", "," & strFieldAndValuesConverted, strFieldAndValuesConverted)
                Case "d"
                    If FixApostrophe(str(1)) = "" Then
                        strFieldAndValuesConverted = FixApostrophe(str(0)) & "=null"
                        strFieldAndValues &= IIf(strFieldAndValues <> "", "," & strFieldAndValuesConverted, strFieldAndValuesConverted)
                    Else
                        strFieldAndValuesConverted = FixApostrophe(str(0)) & "='" & FixApostrophe(str(1)) & "'"
                        strFieldAndValues &= IIf(strFieldAndValues <> "", "," & strFieldAndValuesConverted, strFieldAndValuesConverted)
                    End If

                Case Else
            End Select
        Next

        Dim strWhereCriteria As String = ""
        For i As Integer = 0 To WhereCriteria.Count - 1
            strLine = FixSpaces(WhereCriteria(i).ToString())
            strWhereCriteria &= IIf(strWhereCriteria <> "", "(" & strLine & ") AND ", "(" & strLine & ")")
        Next


        Dim d As New clsDataManipulation
        d.Exec(String.Format("UPDATE {0} SET {1} WHERE {2}", TableSource, strFieldAndValues, strWhereCriteria))

    End Sub






End Class

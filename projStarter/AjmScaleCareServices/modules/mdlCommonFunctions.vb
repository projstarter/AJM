Imports System.Windows.Forms
Imports System.Security.Cryptography.RNGCryptoServiceProvider
Module mdlCommonFunctions

    Public Function FixApostrophe(str As String)
        Return Replace(FixSpaces(str), "'", "''")
    End Function
    Public Function FixSpaces(str As String)
        If str = "" Then Return ""
        Return Replace(str, "  ", " ").Trim
    End Function
    'Public Function TextEncode(str As String)
    '    Dim wrapper As New Simple3Des("dpcondes")
    '    Return wrapper.EncryptData(str)
    'End Function
    'Public Function TextDecode(str As String)
    '    Dim wrapper As New Simple3Des("dpcondes")
    '    Return wrapper.DecryptData(str)
    'End Function

    Public Function TruncateDecimal(ByVal val As Decimal, len As Integer) As String
        If (val.ToString().Contains(".")) Then
            Try
                Return val.ToString.Substring(0, val.ToString.IndexOf(".")) & val.ToString.Substring(val.ToString.IndexOf("."), len + 1)
            Catch ex As Exception
                Try
                    Return val.ToString.Substring(0, val.ToString.IndexOf(".")) & val.ToString.Substring(val.ToString.IndexOf("."), len)
                Catch e As Exception
                    Return val
                End Try
            End Try
        Else
            Return val
        End If
    End Function
    Public Sub PopulateCbo(cbo As ComboBox, cmdText As String)
        cbo.Items.Clear()
        Dim d As New clsDataManipulation
        With d
            If (.Fetch(cmdText)) Then
                With .DataReader
                    Do While .Read
                        cbo.Items.Add(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Public Sub PopulateCbo(cbo As ComboBox, srcTable As String, srcField As String)
        cbo.Items.Clear()
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT DISTINCT TRIM(" & srcField & ") FROM " & srcTable & " ORDER BY 1 ASC")) Then
                With .DataReader
                    Do While .Read
                        cbo.Items.Add(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Public Sub PopulateDataGridView(dtg As DataGridView, querySelection As String, Optional withCheckbox As Boolean = False)

        If dtg.ColumnCount > 0 Then

            'clear DataGridView
            dtg.Rows.Clear()

            Dim d As New clsDataManipulation
            With d
                If (.Fetch(querySelection)) Then
                    With .DataReader
                        Do While .Read
                            Dim newRow_Index As Integer = dtg.Rows.Add() ' get the index of the newly added row
                            Dim newRow As DataGridViewRow = dtg.Rows(newRow_Index) ' get the newly added row

                            ' this will determine what index the populating will start
                            Dim startIndex As Integer = 0
                            If (withCheckbox) Then
                                startIndex = 1
                                newRow.Cells(0).Value = 0
                            End If

                            'begin the population of the DataGridViewRow
                            For col As Integer = 0 To .FieldCount - 1
                                Dim value As Object = .Item(col)
                                ' Check if the column is a date column
                                If .GetName(col).ToLower().Contains("date") Or .GetName(col).ToLower().Contains("time") Then
                                    Dim dt As DateTime
                                    If DateTime.TryParse(value.ToString(), dt) Then
                                        ' Format as 12-hour with AM/PM
                                        value = dt.ToString("yyyy-MM-dd hh:mm tt")
                                    End If
                                End If

                                newRow.Cells(IIf((withCheckbox), col + 1, col)).Value = value
                            Next
                        Loop
                        .Close()
                    End With

                End If
            End With



        End If

    End Sub

    Public Sub _Insert(TableDestination As String, ByVal FieldAndValues() As String)

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
                    strValues &= IIf(strValues <> "", "," & Num(n), Num(n))
                Case "r"
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

    Public Sub _Update(TableSource As String, ByVal FieldAndValues() As String, WhereCriteria() As String)

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
                Case "n"
                    strFieldAndValuesConverted = FixApostrophe(str(0)) & "=" & Num(FixApostrophe(str(1)))
                Case "r"
                    strFieldAndValuesConverted = FixApostrophe(str(0)) & "=" & FixApostrophe(str(1))
                Case "d"
                    If FixApostrophe(str(1)) = "" Then
                        strFieldAndValuesConverted = FixApostrophe(str(0)) & "=null"
                    Else
                        strFieldAndValuesConverted = FixApostrophe(str(0)) & "='" & FixApostrophe(str(1)) & "'"
                    End If

                Case Else
            End Select
            strFieldAndValues &= IIf(strFieldAndValues <> "", "," & strFieldAndValuesConverted, strFieldAndValuesConverted)
        Next

        Dim strWhereCriteria As String = ""
        For i As Integer = 0 To WhereCriteria.Count - 1
            strLine = FixSpaces(WhereCriteria(i).ToString())
            strWhereCriteria &= IIf(strWhereCriteria <> "", "(" & strLine & ") AND ", "(" & strLine & ")")
        Next


        Dim d As New clsDataManipulation
        d.Exec(String.Format("UPDATE {0} SET {1} WHERE {2}", TableSource, strFieldAndValues, strWhereCriteria))
        frmMain._KeyId = 0
    End Sub

    Public Function _TextEncode(str As String)
        Dim wrapper As New Encryptor("dpcondes")
        Return wrapper.EncryptData(str)
    End Function
    Public Function _TextDecode(str As String)
        Dim wrapper As New Encryptor("dpcondes")
        Return wrapper.DecryptData(str)
    End Function

End Module

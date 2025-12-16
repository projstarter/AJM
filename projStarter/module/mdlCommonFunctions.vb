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
    Public Function TextEncode(str As String)
        Dim wrapper As New Simple3Des("dpcondes")
        Return wrapper.EncryptData(str)
    End Function
    Public Function TextDecode(str As String)
        Dim wrapper As New Simple3Des("dpcondes")
        Return wrapper.DecryptData(str)
    End Function

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
                                newRow.Cells(IIf((withCheckbox), col + 1, col)).Value = .Item(col).ToString
                            Next
                        Loop
                        .Close()
                    End With

                End If
            End With



        End If

    End Sub



End Module

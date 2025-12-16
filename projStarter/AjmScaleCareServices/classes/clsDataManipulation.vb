Imports System.Data.SQLite
Public Class clsDataManipulation

    Public Sub Exec(query As String)
        If Not (conn.State = ConnectionState.Open) Then Exit Sub
        Dim cmd As SqliteCommand = New SqliteCommand(query, conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Command syntax error!" & vbNewLine & vbNewLine & "ERROR: " & ex.Message,
                   MessageBoxIcon.Exclamation & MessageBoxButtons.OK, "Exec()")
        End Try
    End Sub

    Public Function Fetch(query As String) As Integer
        If Not (conn.State = ConnectionState.Open) Then Return False
        Dim cmd As SqliteCommand = New SqliteCommand(query, conn)
        myReader = Nothing
        myReader = cmd.ExecuteReader
        Return myReader.HasRows()
    End Function

    Private myReader As SqliteDataReader
    Public Property DataReader() As SqliteDataReader
        Get
            Return myReader
        End Get
        Set(ByVal value As SqliteDataReader)
            myReader = value
        End Set
    End Property

    Sub New()
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("Unable to stablish database connection!", "ERROR: 'clsDataManipulation' Class")
        End If
    End Sub

End Class

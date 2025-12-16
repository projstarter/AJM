Imports System.IO.Ports
Module mdlJADEVERFunction
    Public Sub DeleteTransaction(TransactionID As Integer)
        Dim d As New clsDataManipulation
        d.Exec("UPDATE tbltransaction SET archive=1 WHERE keyid IN (" & TransactionID & ")")
    End Sub
    Public Function IsPortConnected() As Boolean
        IsPortConnected = False
        For Each port As String In SerialPort.GetPortNames
            If port = My.Settings.portname Then
                IsPortConnected = True
                Exit For
            End If
        Next
        Return IsPortConnected
    End Function
End Module

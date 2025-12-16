Imports System.Windows.Forms
Module mdlVariables
    Public thisUser As New CurrentUser
    Public thisTransanction As Transaction
    Public Enum MessageBoxType
        _Error = MessageBoxIcon.Error
        _Info = MessageBoxIcon.Information
    End Enum
    Public Structure CurrentUser
        Public FullName
        Public Username
        Public Firstname
        Public Lastname
        Public Nickname
        Public UserFunction
        Public IsAdmin As Boolean
        Public IsSuperAdmin As Boolean
    End Structure

    Public Structure Transaction
        Public TicketNo
        Public Carrier
        Public NatureofTransaction
        Public PrintType
        Public DriverName
        Public Address
        Public Warehouse
        Public PlateNo
        Public Gross
        Public QtyBags
        Public AveBags
        Public Tare
        Public Net
        Public GrossCapturedDate
        Public TareCapturedDate
        Public VarietyCode
        Public DateRequest
        Public Age
        Public MC
        Public Purity
        Public StockCondition
        Public DeductedNet

        'JLIM
        Public ReferenceNo
        Public CustomerName
        Public Product
        Public Weigher
        Public Amount
        Public ModeOfPayment
        Public TransactionDate

        'RSB
        Public Remarks
        Public Cargo
        Public Supplier



    End Structure

    Public Structure InsertParameters
        Public FieldName
        Public Value
    End Structure

End Module

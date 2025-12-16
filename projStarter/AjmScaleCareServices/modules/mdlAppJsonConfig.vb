Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Structure objPortInformation
    Public PortName As String
    Public BaudRate As Integer
    Public ReadTimeout As Integer
    Public DataBits As Integer
    Public StopBits As Integer
End Structure

Structure objCompanyInformation
    Public CompanyName As String
    Public CompanyAddress As String
End Structure

Module mdlAppJsonConfig

    Public PortInformation As objPortInformation
    Public CompanyInformation As objCompanyInformation
    Public GridDisplay As String
    Public PrintVar As JArray

    Private _jsonFile As String = Path.GetDirectoryName(Application.ExecutablePath) & "\app.json"

    Public Sub Update_AppConfiguration()
        Dim json As String = File.ReadAllText(_jsonFile)

        Dim jobject As JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(json)

        With jobject

            'CompanyInformation
            .SelectToken("CompanyInformation[0].name").Replace(CompanyInformation.CompanyName)
            .SelectToken("CompanyInformation[0].address").Replace(CompanyInformation.CompanyAddress)

            'Port Configuration
            .SelectToken("PortInformation[0].portname").Replace(PortInformation.PortName)
            .SelectToken("PortInformation[0].baudrate").Replace(PortInformation.BaudRate)
            .SelectToken("PortInformation[0].readtimeout").Replace(PortInformation.ReadTimeout)
            .SelectToken("PortInformation[0].databits").Replace(PortInformation.DataBits)
            .SelectToken("PortInformation[0].stopbits").Replace(PortInformation.StopBits)

            'GridDisplay
            .SelectToken("GridDisp").Replace(GridDisplay)

        End With

        File.WriteAllText(_jsonFile, jobject.ToString)

    End Sub

    Public Sub Load_AppConfiguration()
        Dim json As String = File.ReadAllText(_jsonFile)

        Dim jobject As JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(json)

        'CompanyInformation
        With CompanyInformation
            .CompanyName = jobject.SelectToken("CompanyInformation[0].name").ToString()
            .CompanyAddress = jobject.SelectToken("CompanyInformation[0].address").ToString()
        End With

        'Port Configuration
        With PortInformation
            .PortName = jobject.SelectToken("PortInformation[0].portname").ToString()
            .BaudRate = Val(jobject.SelectToken("PortInformation[0].baudrate").ToString())
            .ReadTimeout = Val(jobject.SelectToken("PortInformation[0].readtimeout").ToString())
            .DataBits = Val(jobject.SelectToken("PortInformation[0].databits").ToString())
            .StopBits = Val(jobject.SelectToken("PortInformation[0].stopbits").ToString())
        End With

        'GridDisplay
        GridDisplay = jobject.SelectToken("GridDisp").ToString()

        'Print
        PrintVar = JsonConvert.DeserializeObject(jobject.SelectToken("Print").ToString())

    End Sub
End Module

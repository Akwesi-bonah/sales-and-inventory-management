Imports System.IO
Imports System.Xml.Linq
Imports project_Demo.dbconnect

Module ConnectionSetting
    Public Sub SaveConnectionSettings()
        Dim settingsXml As New XElement("ConnectionSettings",
            New XElement("Server", dbconnect.server),
            New XElement("Username", dbconnect.username),
            New XElement("Password", dbconnect.password),
            New XElement("Database", dbconnect.database))

        settingsXml.Save("ConnectionSettings.xml")
    End Sub

    Public Sub LoadConnectionSettings()
        If File.Exists("ConnectionSettings.xml") Then
            Dim settingsXml As XElement = XElement.Load("ConnectionSettings.xml")

            dbconnect.server = settingsXml.Element("Server").Value
            dbconnect.username = settingsXml.Element("Username").Value
            dbconnect.password = settingsXml.Element("Password").Value
            dbconnect.database = settingsXml.Element("Database").Value
        End If
    End Sub
End Module

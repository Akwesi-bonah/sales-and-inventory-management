Imports MySql.Data.MySqlClient
Module dbconnect
    Public loginUser As String
    Public connect As New MySqlConnection
    Public cmd As MySqlCommand

    Public server = "localhost"
    Public username = "Admin"
    Public password = "1122"
    Public database = "project_demo"



    Public Function connector()
        Dim connect As New MySqlConnection
        connect.ConnectionString = $"server={server}; username={username}; password={password};  database={database}"
        Return connect
    End Function
End Module

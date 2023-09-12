Imports MySql.Data.MySqlClient

Public Class frmLogin


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()


    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


    Private Sub Login()
        Dim name As String = TxtUname.Text
        Dim pwd As String = TxtPwd.Text

        If name = "" Or pwd = "" Then
            MsgBox("Both Username and Password required", MsgBoxStyle.Critical)
            Return
        End If

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()
                Dim sql As String = "SELECT ROLE FROM login WHERE username = @username AND password = @password"
                Dim cmd As New MySqlCommand(sql, connect)
                cmd.Parameters.AddWithValue("@username", name)
                cmd.Parameters.AddWithValue("@password", pwd)
                Dim dr = cmd.ExecuteReader()
                Dim roles = ""

                If dr.Read Then
                    roles = dr("ROLE").ToString().ToLower()

                    Select Case roles
                        Case "admin", "manager"
                            AdminHome.Show()
                            Me.Hide()
                        Case "user"
                            UseHome.Show()
                            Me.Hide()
                        Case Else
                            MessageBox.Show("Invalid username or password.")
                            clear()
                    End Select
                Else
                    MessageBox.Show("Invalid username or password.")
                    clear()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Can not connect to Database")
        Finally
            connect.Close()

        End Try


        If name = "sudo su" And pwd = "root" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to access the Super User Mode?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim connectionSettingsForm As New connectionSettings()

                If connectionSettingsForm.ShowDialog() = DialogResult.OK Then

                    dbconnect.server = connectionSettings.txtServer.Text
                    dbconnect.username = connectionSettings.txtUsername.Text
                    dbconnect.password = connectionSettings.txtPassword.Text
                    dbconnect.database = connectionSettings.txtDatabase.Text
                End If
            End If
        End If
    End Sub

    Sub clear()
        TxtPwd.Clear()
        TxtUname.Clear()
    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionSetting.LoadConnectionSettings()
        AcceptButton = BtnLogin


    End Sub


End Class
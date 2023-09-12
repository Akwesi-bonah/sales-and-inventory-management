Imports MySql.Data.MySqlClient

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect = connector()
        Try
            connect.Open()
            If connect.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not connected")
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class

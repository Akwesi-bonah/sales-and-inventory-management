Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmChangePwd
    Dim pascode



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmChangePwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()

                Using cmd As New MySqlCommand()
                    cmd.Connection = connect
                    cmd.CommandText = "SELECT password FROM login WHERE username = @name"
                    cmd.Parameters.AddWithValue("@name", frmLogin.TxtUname.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            pascode = reader.GetString(0)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If pascode = TxtCpass.Text Then
            If Txtnewpass.Text = TxtconPass.Text Then
                Try
                    Using connect As MySqlConnection = connector()
                        connect.Open()

                        Using cmd As New MySqlCommand()
                            cmd.Connection = connect
                            cmd.CommandText = "UPDATE login SET password = @newpass WHERE username = @name"
                            cmd.Parameters.AddWithValue("@newpass", Txtnewpass.Text)
                            cmd.Parameters.AddWithValue("@name", frmLogin.TxtUname.Text)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Password updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

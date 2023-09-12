Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class frmRegister



    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If Not ValidateForm() Then
            MsgBox("Validate all field")
            Return
        End If
        Try
            connect = connector()
            Using connect
                connect.Open()
                Using cmd As New MySqlCommand
                    cmd.Connection = connect
                    cmd.CommandText = "INSERT INTO employees(first_name, last_name, email, phone_number, Gender, hire_date )" &
                        "VALUES(@fname, @lname, @email, @phone, @gender, @date)"

                    cmd.Parameters.AddWithValue("@fname", txtRfname.Text)
                    cmd.Parameters.AddWithValue("@lname", txtRlname.Text)
                    cmd.Parameters.AddWithValue("@email", txtRemail.Text)
                    cmd.Parameters.AddWithValue("@phone", txtRphone.Text)
                    cmd.Parameters.AddWithValue("@gender", cmbgender.SelectedItem)
                    cmd.Parameters.AddWithValue("@date", Date.Now)
                    cmd.ExecuteNonQuery()

                    ' Get the last inserted employee ID
                    cmd.CommandText = "SELECT LAST_INSERT_ID()"
                    Dim employee_ID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Clear the parameters for the next query
                    cmd.Parameters.Clear()

                    ' Insert into login table
                    cmd.CommandText = "INSERT INTO login(USERNAME, employee_id, PASSWORD, ROLE)" &
                        "VALUES(@uname, @id, @password, @role)"
                    cmd.Parameters.AddWithValue("@uname", txtRuname.Text)
                    cmd.Parameters.AddWithValue("@id", employee_ID)
                    cmd.Parameters.AddWithValue("@password", txtRpass.Text)
                    cmd.Parameters.AddWithValue("@role", cmbRrole.SelectedItem)
                    cmd.ExecuteNonQuery()

                    MsgBox("Record saved", MsgBoxStyle.Information)
                    Me.DialogResult = DialogResult.OK
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private errorRegister As New ErrorProvider()
    Private Sub txtPPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRphone.KeyPress
        Dim proError As New ErrorProvider()
        '
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True


            proError.SetError(txtRphone, "Only digits allowed")
        Else

            proError.clear()
        End If
    End Sub


    Private Function ValidateForm() As Boolean
        Dim valid As Boolean = True
        errorRegister.Clear()

        ' Validate first name
        If String.IsNullOrWhiteSpace(txtRfname.Text) Then
            errorRegister.SetError(txtRfname, "First name is required.")
            valid = False
        End If

        ' Validate last name
        If String.IsNullOrWhiteSpace(txtRlname.Text) Then
            errorRegister.SetError(txtRlname, "Last name is required.")
            valid = False
        End If

        ' Validate email
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        If Not Regex.IsMatch(txtRemail.Text, emailPattern) Then
            errorRegister.SetError(txtRemail, "Invalid email format.")
            valid = False
            MessageBox.Show("Invalid email address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Validate phone number (assuming numeric input)
        If String.IsNullOrWhiteSpace(txtRphone.Text) OrElse Not IsNumeric(txtRphone.Text) Then
            errorRegister.SetError(txtRphone, "Valid numeric phone number is required.")
            valid = False
        End If

        ' Validate gender
        If cmbgender.SelectedIndex = -1 Then
            errorRegister.SetError(cmbgender, "Gender selection is required.")
            valid = False
        End If

        ' Validate username
        If String.IsNullOrWhiteSpace(txtRuname.Text) Then
            errorRegister.SetError(txtRuname, "Username is required.")
            valid = False
        End If

        ' Validate password
        If String.IsNullOrWhiteSpace(txtRpass.Text) Then
            errorRegister.SetError(txtRpass, "Password is required.")
            valid = False
        End If

        ' Validate role
        If cmbRrole.SelectedIndex = -1 Then
            errorRegister.SetError(cmbRrole, "Role selection is required.")
            valid = False
        End If

        Return valid
    End Function


End Class
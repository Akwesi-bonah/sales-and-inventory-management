Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class update

    Private ReadOnly employeeId As Integer

    Public Sub New(selectedEmployeeId As Integer)
        InitializeComponent()

        ' Store the selected employee ID
        employeeId = selectedEmployeeId

        ' Fetch employee details based on the ID and populate the form fields
        Dim employeeDetails As Employee = FetchEmployeeDetails(employeeId)
        If employeeDetails IsNot Nothing Then
            txtUfname.Text = employeeDetails.FirstName
            txtUlname.Text = employeeDetails.LastName
            txtUemail.Text = employeeDetails.Email
            txtUphone.Text = employeeDetails.PhoneNumber

        Else
            MessageBox.Show("Failed to fetch employee details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnURegister_Click(sender As Object, e As EventArgs) Handles BtnURegister.Click

        If Not IsValidEmail(txtUemail.Text) Then
            MessageBox.Show("Invalid email address format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        connect = connector()
        Try
            Using connect
                connect.Open()

                Dim query As String = "UPDATE employees SET first_name = @fname, last_name = @lname, " &
                      "email = @email, phone_number = @phone " &
                      "WHERE employee_id = @employeeId"


                Using cmd As New MySqlCommand(query, connect)
                    cmd.Parameters.AddWithValue("@fname", txtUfname.Text)
                    cmd.Parameters.AddWithValue("@lname", txtUlname.Text)
                    cmd.Parameters.AddWithValue("@email", txtUemail.Text)

                    ' Handle NULL value for phone_number
                    If String.IsNullOrEmpty(txtUphone.Text) Then
                        cmd.Parameters.AddWithValue("@phone", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@phone", txtUphone.Text)
                    End If


                    cmd.Parameters.AddWithValue("@employeeId", employeeId)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function FetchEmployeeDetails(employeeId As Integer) As Employee
        Dim employee As Employee = Nothing

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()

                Dim query As String = "SELECT first_name, last_name, email, phone_number  FROM employees WHERE employee_id = @employeeId"
                Using cmd As New MySqlCommand(query, connect)
                    cmd.Parameters.AddWithValue("@employeeId", employeeId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            employee = New Employee()
                            employee.FirstName = reader("first_name").ToString()
                            employee.LastName = reader("last_name").ToString()
                            employee.Email = reader("email").ToString()
                            employee.PhoneNumber = reader("phone_number").ToString()

                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return employee
    End Function


    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUphone.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True


            ErrorUpdate.SetError(txtUphone, "Only digits allowed")
        Else

            ErrorUpdate.Clear()
        End If
    End Sub

    Private Sub BtnUBack_Click(sender As Object, e As EventArgs) Handles BtnUBack.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Function IsValidEmail(email As String) As Boolean

        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"

        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function


End Class

Public Class Employee
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property Gender As String
End Class

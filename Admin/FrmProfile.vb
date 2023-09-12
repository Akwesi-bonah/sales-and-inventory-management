Imports MySql.Data.MySqlClient
Public Class FrmProfile
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim regForm As New frmRegister()
        Dim result As DialogResult = regForm.ShowDialog()

    End Sub


    Private Sub LoadEmployeeInfo()
        Dim query As String = "SELECT e.employee_id as 'Employee ID', CONCAT_WS(' ', e.first_name, e.last_name) as Name, e.email as Email, e.phone_number as Phone, e.hire_date, l.USERNAME, l.ROLE FROM employees e LEFT JOIN login l ON e.employee_id = l.employee_id"

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()

                Using cmd As New MySqlCommand(query, connect)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim employeeTable As New DataTable()
                    adapter.Fill(employeeTable)
                    dgvprofile.DataSource = employeeTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeInfo()
    End Sub



    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        If dgvprofile.SelectedRows.Count > 0 Then
            Dim employeeId As Integer = Convert.ToInt32(dgvprofile.SelectedRows(0).Cells("Employee ID").Value)

            ' Confirm the deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Using connect As MySqlConnection = connector()
                        connect.Open()

                        Using cmd As New MySqlCommand("DELETE FROM employees WHERE employee_id = @employeeId", connect)
                            cmd.Parameters.AddWithValue("@employeeId", employeeId)
                            cmd.ExecuteNonQuery()
                        End Using


                        Using cmd As New MySqlCommand("DELETE FROM login WHERE employee_id = @employeeId", connect)
                            cmd.Parameters.AddWithValue("@employeeId", employeeId)
                            cmd.ExecuteNonQuery()
                        End Using


                        LoadEmployeeInfo()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("This User has sales records and can not be removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select an employee to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If dgvprofile.SelectedRows.Count > 0 Then

            Dim employeeId As Integer = Convert.ToInt32(dgvprofile.SelectedRows(0).Cells("Employee ID").Value)

            '
            Dim updateEmployeeForm As New update(employeeId)

            ' Show the form as a dialog
            If updateEmployeeForm.ShowDialog() = DialogResult.OK Then
                ' Reload employee information after the form is closed
                LoadEmployeeInfo()
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class ordit
    Private Sub ordit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduct()
    End Sub

    ' Load all product names into the DataGridView
    Private Sub LoadProduct()
        Try
            Dim query As String = "SELECT ID, PRODUCT_NAME FROM product_catalog"
            Dim productNames As New List(Of String)()
            Dim productID As New List(Of String)()

            connect = connector()
            Using connect
                connect.Open()

                Using command As MySqlCommand = New MySqlCommand(query, connect)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            productNames.Add(reader("PRODUCT_NAME").ToString())
                            productID.Add(reader("ID").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Create a DataTable to hold the data
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(String))
            table.Columns.Add("Product Name", GetType(String))
            table.Columns.Add("Total Count", GetType(Integer))

            ' Populate the DataTable with the retrieved data
            For i As Integer = 0 To productNames.Count - 1
                table.Rows.Add(productID(i), productNames(i), 0)
            Next

            ' Set the DataGridView's DataSource to the DataTable
            dgvProducts.DataSource = table
            dgvProducts.Columns("ID").ReadOnly = True
            dgvProducts.Columns("Product Name").ReadOnly = True
            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvProducts_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvProducts.CellValidating
        ' Check if the validating cell is in the "Total Count" column
        If e.ColumnIndex = dgvProducts.Columns("Total Count").Index Then
            Dim value As String = e.FormattedValue.ToString()

            ' Check if the entered value is not numeric
            If Not IsNumeric(value) Then
                e.Cancel = True ' Cancel the cell validation
                AuditError.SetError(dgvProducts, "Please enter a valid numeric value.")
            Else
                AuditError.Clear()
            End If
        End If
    End Sub


    ' Access the entered total counts when needed
    Private Sub GetEnteredCounts()
        For Each row As DataGridViewRow In dgvProducts.Rows
            Dim productName As String = row.Cells(0).Value.ToString()
            Dim totalCount As Integer = 0

            If Integer.TryParse(row.Cells("TotalCount").Value.ToString(), totalCount) Then
                ' Here, you can use the productName and totalCount values as needed
                ' For example, you can save them to your database.
            End If
        Next
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to upload the Data'?",
                                                     "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return

        End If

        connect = connector()

        Try
            Using connect
                connect.Open()

                For Each row As DataGridViewRow In dgvProducts.Rows
                    If row IsNot Nothing AndAlso Not row.IsNewRow Then
                        Dim productNameCell As DataGridViewCell = row.Cells("Product Name")
                        Dim totalCountCell As DataGridViewCell = row.Cells("Total Count")

                        If productNameCell IsNot Nothing AndAlso totalCountCell IsNot Nothing AndAlso
                       Not String.IsNullOrEmpty(productNameCell.Value?.ToString()) Then

                            Dim productName As String = productNameCell.Value.ToString()
                            Dim totalCount As Integer = 0

                            If Integer.TryParse(totalCountCell.Value?.ToString(), totalCount) Then
                                Dim productId As Integer = GetProductIdFromName(productName, connect)
                                UpdateNotSoldCount(productId, totalCount, connect)
                            End If
                        End If
                    End If
                Next
            End Using

            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub UpdateNotSoldCount(productId As Integer, totalCount As Integer, connection As MySqlConnection)
        ' Query to update NOT_SOLD count in product_catalog
        Dim updateQuery As String = "UPDATE product_catalog SET NOT_SOLD = @totalCount WHERE ID = @productId"

        Using command As MySqlCommand = New MySqlCommand(updateQuery, connection)
            command.Parameters.AddWithValue("@productId", productId)
            command.Parameters.AddWithValue("@totalCount", totalCount)

            command.ExecuteNonQuery()
        End Using

    End Sub




    Private Function GetProductIdFromName(productName As String, connection As MySqlConnection) As Integer
        ' Query to get the ProductID based on productName
        Dim query As String = "SELECT ID FROM product_catalog WHERE PRODUCT_NAME = @productName"

        Using command As MySqlCommand = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@productName", productName)
            Return CInt(command.ExecuteScalar())
        End Using
    End Function

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class
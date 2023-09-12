Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Interop.Word
Imports System.Data
Public Class orders
    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OProduct()
    End Sub


    Private Sub OProduct()
        Dim query As String = "SELECT PRODUCT_NAME FROM product_catalog"

        Try
            connect = connector()
            connect.Open()
            Dim sqlcmd As New MySqlCommand(query, connect)
            Dim sqlRd As MySqlDataReader = sqlcmd.ExecuteReader()


            cmdOPName.Items.Clear()


            While sqlRd.Read()
                cmdOPName.Items.Add(sqlRd("PRODUCT_NAME").ToString())
            End While

            sqlRd.Close()
            connect.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub


    Private Sub BtnOAdd_Click(sender As Object, e As EventArgs) Handles BtnOAdd.Click

        If cmdOPName.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtOqantity.Text) Then
            Dim selectedProductName As String = cmdOPName.SelectedItem.ToString()


            Dim description As String = String.Empty
            Dim brand As String = String.Empty
            Dim category As String = String.Empty


            Try
                Dim query As String = "SELECT pc.ID, pc.DESCRIPTION, pb.BRAND_NAME, pcg.CATEGORY_NAME " &
                                 "FROM product_catalog pc " &
                                 "LEFT JOIN PRODUCT_BRAND pb ON pc.BRAND_ID = pb.BRAND_ID " &
                                 "LEFT JOIN Product_category pcg ON pc.CATEGORY_ID = pcg.CATEGORY_ID " &
                                 "WHERE pc.PRODUCT_NAME = @productName"

                Using connect As MySqlConnection = connector()
                    connect.Open()
                    Using cmd As New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@productName", selectedProductName)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                description = reader("DESCRIPTION").ToString()
                                category = reader("CATEGORY_NAME").ToString()
                                brand = reader("BRAND_NAME").ToString()
                            End If
                        End Using
                    End Using
                    connect.Close()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while fetching product details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try


            Dim quantity As Integer
            If Not Integer.TryParse(txtOqantity.Value, quantity) Then
                MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            If quantity <= 0 Then
                MessageBox.Show("Quantity must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim rowIndex As Integer = -1


            For i As Integer = 0 To DgvOrders.Rows.Count - 1

                If DgvOrders.Rows(i).Cells(0).Value IsNot Nothing AndAlso DgvOrders.Rows(i).Cells(0).Value.ToString() = selectedProductName Then
                    rowIndex = i
                    Exit For
                End If
            Next


            If rowIndex <> -1 Then
                Dim existingQuantity As Integer = Convert.ToInt32(DgvOrders.Rows(rowIndex).Cells(4).Value)
                quantity += existingQuantity

                DgvOrders.Rows(rowIndex).Cells(4).Value = quantity
            Else

                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DgvOrders)

                newRow.Cells(0).Value = selectedProductName
                newRow.Cells(1).Value = description
                newRow.Cells(2).Value = brand
                newRow.Cells(3).Value = category
                newRow.Cells(4).Value = quantity

                DgvOrders.Rows.Add(newRow)
            End If

            cmdOPName.SelectedItem = Nothing
            txtOqantity.Text = ""
            txtRPcode.Text = ""
        Else
            MsgBox("Please select an item and enter the quantity.", MsgBoxStyle.Critical)
        End If
        txtOqantity.Text = ""

        OProduct()
    End Sub

    Private Sub cmdOPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdOPName.SelectedIndexChanged

        If cmdOPName.SelectedItem IsNot Nothing Then

            Dim selectedProductName As String = cmdOPName.SelectedItem.ToString()

            Dim productId As Integer = 0

            Try
                Dim query As String = "SELECT ID FROM product_catalog WHERE PRODUCT_NAME = @productName"

                Using connect As MySqlConnection = connector()
                    connect.Open()
                    Using cmd As New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@productName", selectedProductName)
                        productId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                    connect.Close()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while retrieving the product ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            txtRPcode.Text = productId.ToString()
        End If
    End Sub


    Private Sub BntOSearch_Click(sender As Object, e As EventArgs) Handles BntOSearch.Click

        Dim productId As Integer = 0

        If Integer.TryParse(txtRPcode.Text, productId) Then

            Dim productName As String = String.Empty

            Try
                Dim query As String = "SELECT PRODUCT_NAME FROM product_catalog WHERE ID = @productId"

                Using connect As MySqlConnection = connector()
                    connect.Open()
                    Using cmd As New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@productId", productId)
                        productName = Convert.ToString(cmd.ExecuteScalar())
                    End Using
                End Using


                If String.IsNullOrEmpty(productName) Then
                    MessageBox.Show("Product not found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If


                cmdOPName.Items.Clear()
                cmdOPName.Items.Add(productName)
                cmdOPName.SelectedItem = productName

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while retrieving the product name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else

            MessageBox.Show("Invalid product ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            OProduct()
        End If
    End Sub




    Private Sub txtRPcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPcode.KeyDown

        If Not (Char.IsDigit(ChrW(e.KeyCode)) OrElse e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse
                e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down) Then

            e.SuppressKeyPress = True


            ErrorOder.SetError(txtRPcode, "Please enter only numbers.")
        Else

            ErrorOder.Clear()
        End If
    End Sub

    Private Sub txtOqantity_KeyDown(sender As Object, e As KeyEventArgs)
        If Not (Char.IsDigit(ChrW(e.KeyCode)) OrElse e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse
                e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down) Then

            e.SuppressKeyPress = True
            ErrorOder.SetError(txtRPcode, "Please enter only numbers.")
        Else

            ErrorOder.Clear()
        End If
    End Sub

    Private Sub BtnOremove_Click(sender As Object, e As EventArgs) Handles BtnOremove.Click

        If DgvOrders.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgvOrders.SelectedRows(0).Index


            DgvOrders.Rows.RemoveAt(selectedRowIndex)

        Else
            MessageBox.Show("Please select a row to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

        If DgvOrders.Rows.Count = 0 Then
            MessageBox.Show("There is no data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
        saveFileDialog.FileName = "YourFileName.xlsx"

        ' Show the SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file name and location
            Dim filePath As String = saveFileDialog.FileName

            Dim excelApp As New Application()
            Dim workbook As Workbook = excelApp.Workbooks.Add(Type.Missing)
            Dim worksheet As Worksheet = workbook.Sheets(1)

            ' Add a header title
            Dim headerTitle As String = "Group 5 sub 11 small management system" & vbCrLf & "New Orders"
            worksheet.Cells(1, 1).Value = headerTitle
            Dim headerRange As Range = worksheet.Range(worksheet.Cells(1, 1), worksheet.Cells(1, DgvOrders.Columns.Count))
            headerRange.Merge()
            headerRange.HorizontalAlignment = XlHAlign.xlHAlignCenter

            ' Add column headers
            For i As Integer = 0 To DgvOrders.Columns.Count - 1
                worksheet.Cells(2, i + 1) = DgvOrders.Columns(i).HeaderText
            Next

            ' Add data rows
            For i As Integer = 0 To DgvOrders.Rows.Count - 1
                For j As Integer = 0 To DgvOrders.Columns.Count - 1
                    Dim cellValue As Object = DgvOrders.Rows(i).Cells(j).Value
                    If cellValue IsNot Nothing Then
                        worksheet.Cells(i + 3, j + 1) = cellValue.ToString()
                    End If
                Next
            Next

            ' Save and close Excel
            workbook.SaveAs(filePath)
            excelApp.Quit()

            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)

            MessageBox.Show("Data exported to Excel successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    ' Helper method to release COM objects
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


End Class
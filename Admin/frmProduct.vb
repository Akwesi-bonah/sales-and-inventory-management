Imports MySql.Data.MySqlClient

Public Class frmProduct
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader


    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_brand()
        load_category()
        load_product()
        brand()
        category()
    End Sub

    Private Sub btnBAdd_Click(sender As Object, e As EventArgs) Handles btnBAdd.Click

        If String.IsNullOrEmpty(txtBname.Text) Then
            MsgBox("Brand Name cannot be empty", MsgBoxStyle.Critical, MsgBoxResult.Abort)
            TxtPdinfo.Focus()
            Return
        End If
        Try
            con = connector()
            con.Open()

            Dim query As String = "SELECT * FROM product_brand WHERE BRAND_NAME=@name"
            Dim cmd1 As New MySqlCommand(query, con)
            cmd1.Parameters.AddWithValue("@name", txtBname.Text)

            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Brand NAME ALREADY EXISTS")
                Else
                    reader.Close()
                    Dim str_carSql As String = "INSERT INTO product_brand (BRAND_NAME) VALUES (@name)"
                    Using sqlCommand As New MySqlCommand(str_carSql, con)
                        sqlCommand.Parameters.AddWithValue("@name", txtBname.Text)

                        Dim rows1 As Integer = sqlCommand.ExecuteNonQuery()

                        If rows1 > 0 Then
                            MsgBox("Inserted record")
                            load_brand()
                        Else
                            MsgBox("Error occurred: Could not insert record")
                        End If
                    End Using
                End If
            End Using
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



        txtBname.Clear()

    End Sub


    'Private Sub txtPPriceKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPPrice.KeyPress
    '    ' Check if the pressed key is a digit, a control key (e.g., Backspace), or a valid special character
    '    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "." Then
    '        ' Cancel the key press event to prevent the character from being entered
    '        e.Handled = True

    '        ' Display an error message using the ErrorProvider
    '        ErrorProvider1.SetError(TxtPPrice, "Only digits, '-' and '.' allowed")
    '    Else
    '        ' Clear the error message when valid input is entered
    '        ErrorProvider1.SetError(TxtPPrice, "")
    '    End If
    'End Sub



    'Load data into brand
    Private Sub load_brand()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "select * from product_brand"

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            connect.Close()
            sqlRd.Close()
            DgBrand.DataSource = sqltable
        Catch ex As Exception

        End Try
    End Sub

    ' loading category
    Private Sub load_category()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "select * from Product_category"

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            connect.Close()
            sqlRd.Close()
            DgvCate.DataSource = sqltable
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    'load product
    Public Sub load_product()

        Dim query As String = "SELECT ID, PRODUCT_NAME, DESCRIPTION FROM product_catalog"

        Try
            connect = connector()

            Using connect
                connect.Open()
                Using adapter As New MySqlDataAdapter(query, connect)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DgvProduct.DataSource = dataTable
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub btnPadd_Click(sender As Object, e As EventArgs) Handles btnPadd.Click

        If String.IsNullOrEmpty(TxtPdinfo.Text) Then
            MsgBox("Description cannot be empty")
            TxtPdinfo.Focus()
            Return

        ElseIf String.IsNullOrEmpty(TxtPPrice.Text) Then
            MsgBox("Price cannot be empty")
            TxtPPrice.Focus()
            Return
        End If




        Dim prodID As String = ""
        Dim catID As String = ""

        Try
            con = connector()
            con.Open()

            ' Retrieve the PRODUCT_ID (brand ID) based on the selected brand name
            Dim query1 As String = "SELECT BRAND_ID  FROM product_brand WHERE BRAND_NAME = @brandName"
            Using cmd As New MySqlCommand(query1, con)
                cmd.Parameters.AddWithValue("@brandName", cmbBrand.SelectedItem.ToString())
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    prodID = result.ToString()
                End If
            End Using

            ' Retrieve the CATEGORY_ID based on the selected category name
            Dim query2 As String = "SELECT CATEGORY_ID FROM Product_category WHERE CATEGORY_NAME = @categoryName"
            Using cmd2 As New MySqlCommand(query2, con)
                cmd2.Parameters.AddWithValue("@categoryName", cmbPcate.SelectedItem.ToString())
                Dim result2 As Object = cmd2.ExecuteScalar()
                If result2 IsNot Nothing Then
                    catID = result2.ToString()
                End If
            End Using

            con.Close()

        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Error occurred1", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error occurred2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Try
            con = connector()
            con.Open()
            Dim str_carSql As String
            str_carSql = "INSERT INTO product_catalog (PRODUCT_NAME, DESCRIPTION,  PRICE, stock_count ,  MANUFACTURE_DATE ,  EXPIRY_DATE,  BRAND_ID, CATEGORY_ID) " &
                                   "VALUES (@name, @description, @price, @stock,@made, @end, @brandID, @categoryID)"
            Using sqlCommand As New MySqlCommand(str_carSql, con)

                sqlCommand.Parameters.AddWithValue("@name", TxtPname.Text)
                sqlCommand.Parameters.AddWithValue("@description", TxtPdinfo.Text)
                sqlCommand.Parameters.AddWithValue("@price", TxtPPrice.Text)
                sqlCommand.Parameters.AddWithValue("@stock", numStock.Value)
                sqlCommand.Parameters.AddWithValue("@made", dtmade.Value)
                sqlCommand.Parameters.AddWithValue("@end", dtend.Value)
                sqlCommand.Parameters.AddWithValue("@brandId", prodID)
                sqlCommand.Parameters.AddWithValue("@categoryId", catID)
                Dim rows1 As Integer = sqlCommand.ExecuteNonQuery()
                If rows1 > 0 Then
                    MsgBox("Inserted record")
                    load_product()
                    TxtPname.Clear()
                    numStock.Value = 0
                    TxtPdinfo.Clear()
                    TxtPPrice.Clear()
                    cmbBrand.SelectedIndex = -1
                    cmbPcate.SelectedIndex = -1
                    dtmade.Value = Date.Now
                    dtend.Value = Date.Now
                Else
                    MsgBox("Error occurred: Could not insert record")
                End If
            End Using
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Error occurred1", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error occurred2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub btnCAdd_Click(sender As Object, e As EventArgs) Handles btnCAdd.Click
        If String.IsNullOrEmpty(txtCateName.Text) Then
            MsgBox("Category Name cannot be empty")
            TxtPdinfo.Focus()
            Return
        End If

        Try
            con = connector()
            con.Open()

            Dim query As String = "SELECT * FROM Product_category WHERE CATEGORY_NAME=@name"
            Dim cmd1 As New MySqlCommand(query, con)
            cmd1.Parameters.AddWithValue("@name", txtCateName.Text)

            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Category name already Exit")
                Else
                    reader.Close()
                    Dim str_carSql As String = "INSERT INTO Product_category ( CATEGORY_NAME) VALUES ( @name)"
                    Using sqlCommand As New MySqlCommand(str_carSql, con)
                        sqlCommand.Parameters.AddWithValue("@name", txtCateName.Text)
                        Dim rows1 As Integer = sqlCommand.ExecuteNonQuery()
                        If rows1 > 0 Then

                            MessageBox.Show("Product category added successfully.", "Inserted record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            load_category()
                        Else
                            MsgBox("Error occurred: Could not insert record")
                        End If
                    End Using
                End If
            End Using
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        txtCateName.Clear()
    End Sub



    Private Sub brand()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "SELECT BRAND_NAME FROM product_brand"

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            sqlRd.Close()
            connect.Close()

            ' Clear existing items (optional, in case you want to refresh the data)
            cmbBrand.Items.Clear()

            ' Loop through the DataTable and add items to the ComboBox
            For Each row As DataRow In sqltable.Rows
                cmbBrand.Items.Add(row("BRAND_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub category()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "SELECT CATEGORY_NAME FROM Product_category"

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            sqlRd.Close()
            connect.Close()

            cmbPcate.Items.Clear()

            For Each row As DataRow In sqltable.Rows
                cmbPcate.Items.Add(row("CATEGORY_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txtPPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPPrice.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

            e.Handled = True


            productErrors.SetError(TxtPPrice, "Only digits allowed")
        Else

            productErrors.Clear()
        End If
    End Sub




    'Private Sub TxtPdinfo_Leave(sender As Object, e As EventArgs) Handles TxtPdinfo.Leave
    '    If String.IsNullOrEmpty(TxtPdinfo.Text) Then
    '        productErrors.SetError(TxtPdinfo, "Description cannot be empty")
    '    ElseIf TxtPdinfo.Text.Length < 5 Then
    '        productErrors.SetError(TxtPdinfo, "Description too short")
    '    Else
    '        productErrors.Clear()
    '    End If
    'End Sub



    'Private Sub TxtPPrice_Leave(sender As Object, e As EventArgs) Handles TxtPPrice.Leave
    '    If Not IsNumeric(TxtPPrice.Text) Then
    '        productErrors.SetError(TxtPPrice, "The value must be numeric")
    '    Else
    '        productErrors.Clear()
    '    End If
    'End Sub

    'Private Sub TxtPname_Leave(sender As Object, e As EventArgs) Handles TxtPname.Leave
    '    If Not IsNothing(TxtPname.Text) Then
    '        productErrors.SetError(TxtPname, "Field cannot be empty")
    '    Else
    '        productErrors.Clear()
    '    End If
    'End Sub


    'Private Sub txtBname_Leave(sender As Object, e As EventArgs) Handles txtBname.Leave
    '    If IsNothing(txtBname.Text) Then
    '        productErrors.SetError(txtBname, "Field cannot be empty")
    '    Else
    '        productErrors.Clear()
    '    End If
    'End Sub

    'Private Sub txtCateName_Leave(sender As Object, e As EventArgs) Handles txtCateName.Leave
    '    If IsNothing(txtCateName.Text) Then
    '        productErrors.SetError(txtCateName, "Field cannot be empty")
    '    Else
    '        productErrors.Clear()
    '    End If
    'End Sub


    ''Deleting form Brand
    Private Sub btnBdelete_Click(sender As Object, e As EventArgs) Handles btnBdelete.Click
        If DgBrand.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgBrand.SelectedRows(0).Index
            Dim brandName As String = DgBrand.SelectedRows(0).Cells("BRAND_NAME").Value.ToString()

            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the brand '{brandName}'?",
                                                     "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Perform the deletion operation
                Dim brandId As Integer = Integer.Parse(DgBrand.SelectedRows(0).Cells("BRAND_ID").Value.ToString())
                Try
                    Dim query As String = "DELETE FROM product_brand WHERE BRAND_ID = @brandId"
                    con = connector()
                    Using con
                        con.Open()
                        Using cmd As New MySqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@brandId", brandId)
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Brand deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Brand not found or deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                        con.Close()
                    End Using

                Catch ex As MySqlException
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                ' Reload the data to refresh the DataGridView
                load_brand()
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnCdelete_Click(sender As Object, e As EventArgs) Handles btnCdelete.Click
        If DgvCate.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgvCate.SelectedRows(0).Index
            Dim categoryName As String = DgvCate.SelectedRows(0).Cells("CATEGORY_NAME").Value.ToString()

            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the category '{categoryName}'?",
                                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Perform the deletion operation
                Dim categoryId As Integer = Integer.Parse(DgvCate.SelectedRows(0).Cells("CATEGORY_ID").Value.ToString())
                Try
                    Dim query As String = "DELETE FROM product_category WHERE CATEGORY_ID = @categoryId"
                    con = connector()
                    Using con
                        con.Open()
                        Using cmd As New MySqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@categoryId", categoryId)
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Category deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Category not found or deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                        con.Close()
                    End Using

                Catch ex As MySqlException
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                ' Reload the data to refresh the DataGridView
                load_category()
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnPUpdate_Click(sender As Object, e As EventArgs) Handles BtnPupdat.Click
        If DgvProduct.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgvProduct.SelectedRows(0).Index
            Dim productId As Integer = Integer.Parse(DgvProduct.SelectedRows(0).Cells("ID").Value.ToString())
            Dim productName As String = DgvProduct.SelectedRows(0).Cells("PRODUCT_NAME").Value.ToString()
            Dim description As String = DgvProduct.SelectedRows(0).Cells("DESCRIPTION").Value.ToString()

            ' Create and display the update dialog form
            Using updateForm As New updateproduct()
                updateForm.txtNewName.Text = productName
                updateForm.txtnewInfo.Text = description

                Dim result As DialogResult = updateForm.ShowDialog()

                If result = DialogResult.OK Then
                    ' User clicked the Update button in the dialog form, proceed with the update
                    Dim updatedProductName As String = updateForm.txtNewName.Text
                    Dim updatedDescription As String = updateForm.txtnewInfo.Text

                    Try
                        ' Perform the update operation
                        Dim query As String = "UPDATE product_catalog SET PRODUCT_NAME = @productName, DESCRIPTION = @description WHERE ID = @productId"
                        con = connector()
                        Using con
                            con.Open()
                            Using cmd As New MySqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@productName", updatedProductName)
                                cmd.Parameters.AddWithValue("@description", updatedDescription)
                                cmd.Parameters.AddWithValue("@productId", productId)

                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Product updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ' Reload the data to refresh the DataGridView
                                    load_product()
                                Else
                                    MessageBox.Show("Product not found or update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End Using
                            con.Close()
                        End Using

                    Catch ex As MySqlException
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        Else
            MessageBox.Show("Please select a row to update.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdateBrand_Click(sender As Object, e As EventArgs) Handles btnBupdate.Click
        If DgBrand.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgBrand.SelectedRows(0).Index
            Dim brandId As Integer = Integer.Parse(DgBrand.SelectedRows(0).Cells("BRAND_ID").Value.ToString())
            Dim brandName As String = DgBrand.SelectedRows(0).Cells("BRAND_NAME").Value.ToString()

            ' Create and display the update dialog form
            Using updateForm As New UpdateName()
                updateForm.txtNewName.Text = brandName

                Dim result As DialogResult = updateForm.ShowDialog()

                If result = DialogResult.OK Then
                    ' User clicked the Update button in the dialog form, proceed with the update
                    Dim updatedBrandName As String = updateForm.txtNewName.Text

                    Try
                        ' Perform the update operation
                        Dim query As String = "UPDATE product_brand SET BRAND_NAME = @brandName WHERE BRAND_ID = @brandId"
                        con = connector()
                        Using con
                            con.Open()
                            Using cmd As New MySqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@brandName", updatedBrandName)
                                cmd.Parameters.AddWithValue("@brandId", brandId)

                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Brand updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    load_brand()
                                Else
                                    MessageBox.Show("Brand not found or update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End Using
                            con.Close()
                        End Using

                    Catch ex As MySqlException
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        Else
            MessageBox.Show("Please select a row to update.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdatecategory_Click(sender As Object, e As EventArgs) Handles btnCupdate.Click
        If DgvCate.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgvCate.SelectedRows(0).Index
            Dim cateId As Integer = Integer.Parse(DgvCate.SelectedRows(0).Cells("CATEGORY_ID").Value.ToString())
            Dim cateName As String = DgvCate.SelectedRows(0).Cells("CATEGORY_NAME").Value.ToString()

            ' Create and display the update dialog form
            Using updateForm As New UpdateName
                updateForm.txtNewName.Text = cateName

                Dim result As DialogResult = updateForm.ShowDialog()

                If result = DialogResult.OK Then

                    Dim updatedBrandName As String = updateForm.txtNewName.Text

                    Try

                        Dim query As String = "UPDATE product_category SET CATEGORY_NAME = @cateName WHERE CATEGORY_ID = @catId"
                        con = connector()
                        Using con
                            con.Open()
                            Using cmd As New MySqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@cateName", updatedBrandName)
                                cmd.Parameters.AddWithValue("@catId", cateId)

                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Category updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    load_category()
                                Else
                                    MessageBox.Show("Category not found or update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End Using
                            con.Close()
                        End Using

                    Catch ex As MySqlException
                        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        Else
            MessageBox.Show("Please select a row to update.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnPdelete_Click(sender As Object, e As EventArgs) Handles BtnPdelete.Click
        If DgvProduct.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgvProduct.SelectedRows(0).Index
            Dim productId As Integer = Integer.Parse(DgvProduct.SelectedRows(0).Cells("ID").Value.ToString())
            Dim productName As String = DgvProduct.SelectedRows(0).Cells("PRODUCT_NAME").Value.ToString()


            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the product '{productName}'?",
                                                     "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                Try
                    Dim query As String = "DELETE FROM product_catalog WHERE ID = @productId"
                    connect = connector()
                    Using connect
                        connect.Open()
                        Using cmd As New MySqlCommand(query, connect)
                            cmd.Parameters.AddWithValue("@productId", productId)
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Product deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                load_product()
                            Else
                                MessageBox.Show("Product not found or deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End Using

                Catch ex As MySqlException
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub


    Private Sub btnPclear_Click(sender As Object, e As EventArgs) Handles btnPclear.Click
        TxtPdinfo.Clear()
        TxtPname.Clear()
        TxtPPrice.Clear()
        cmbBrand.SelectedIndex = -1
        cmbPcate.SelectedIndex = -1
    End Sub


End Class
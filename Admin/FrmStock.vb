Imports MySql.Data.MySqlClient
Public Class FrmStock
    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_stock()
        F_brand()
        F_Cate()
    End Sub
    Private Sub load_stock()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "SELECT PRODUCT_NAME, DESCRIPTION, PRICE, STOCK_COUNT, SOLD_OUT, NOT_SOLD FROM product_catalog  "

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            connect.Close()
            sqlRd.Close()
            Dgvstocts.DataSource = sqltable
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub F_brand()
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

            CmbFBrand.Items.Clear()
            For Each row As DataRow In sqltable.Rows
                CmbFBrand.Items.Add(row("BRAND_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub F_Cate()
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

            CmbFCate.Items.Clear()

            For Each row As DataRow In sqltable.Rows
                CmbFCate.Items.Add(row("CATEGORY_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub

    Private Sub FetchDataBasedOnFilters()
        Dim brandFilter As String = If(CmbFBrand.SelectedItem IsNot Nothing, "BRAND_NAME = @brandName", "")
        Dim cateFilter As String = If(CmbFCate.SelectedItem IsNot Nothing, "AND CATEGORY_NAME = @cateName", "")

        Dim query As String

        If CmbType.SelectedItem.ToString() = "All" Then
            query = $"SELECT pc.PRODUCT_NAME, pc.DESCRIPTION, pc.PRICE, pc.STOCK_COUNT, pc.SOLD_OUT, pc.NOT_SOLD 
                  FROM Product_catalog pc
                  INNER JOIN product_brand pb ON pc.BRAND_ID = pb.BRAND_ID
                  WHERE (pc.STOCK_IN = 1 OR pc.OUT_OF_STOCK = 1)"
        ElseIf CmbType.SelectedItem.ToString() = "Stock In" Then
            query = $"SELECT pc.PRODUCT_NAME, pc.DESCRIPTION, pc.PRICE, pc.STOCK_COUNT, pc.SOLD_OUT, pc.NOT_SOLD 
                  FROM Product_catalog pc
                  INNER JOIN product_brand pb ON pc.BRAND_ID = pb.BRAND_ID
                  WHERE   pc.STOCK_IN = 1"

        Else
            query = $"SELECT pc.PRODUCT_NAME, pc.DESCRIPTION, pc.PRICE, pc.STOCK_COUNT, pc.SOLD_OUT, pc.NOT_SOLD 
                  FROM Product_catalog pc
                  INNER JOIN product_brand pb ON pc.BRAND_ID = pb.BRAND_ID
                  WHERE pc.OUT_OF_STOCK = 1"

        End If

        Try
            connect = connector()
            connect.Open()

            Using sqlcmd As New MySqlCommand(query, connect)
                If CmbFBrand.SelectedItem IsNot Nothing Then
                    sqlcmd.Parameters.AddWithValue("@brandName", CmbFBrand.SelectedItem.ToString())
                End If

                If CmbFCate.SelectedItem IsNot Nothing Then
                    sqlcmd.Parameters.AddWithValue("@cateName", CmbFCate.SelectedItem.ToString())
                End If

                Dim sqlRd As MySqlDataReader = sqlcmd.ExecuteReader()
                Dim sqltable As New DataTable
                sqltable.Load(sqlRd)
                sqlRd.Close()
                Dgvstocts.DataSource.clear()

                Dgvstocts.DataSource = sqltable
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
        End Try
    End Sub

    Private Sub CmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbType.SelectedIndexChanged
        FetchDataBasedOnFilters()
    End Sub

    Private Sub btnUpstock_Click(sender As Object, e As EventArgs) Handles btnUpstock.Click
        Dim newStockCount As Integer
        If Dgvstocts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row in the DataGridView.")
            Return
        End If
        Dim selectedRow As DataGridViewRow = Dgvstocts.SelectedRows(0)
        Dim productName As String = selectedRow.Cells("PRODUCT_NAME").Value.ToString()

        Dim newStockCountStr As String = InputBox("Enter the amount to add to the stock count for " & productName & ":")

        If Not Integer.TryParse(newStockCountStr, newStockCount) Then
            MessageBox.Show("Invalid stock count. Please enter a valid integer.")
            Return
        End If

        Try



            connect = connector()

            Using connect
                connect.Open()

                Dim command As New MySqlCommand("UpdateStockLevel", connect)
                command.CommandType = CommandType.StoredProcedure

                command.Parameters.AddWithValue("@productName", productName)
                command.Parameters.AddWithValue("@newStockCount", newStockCount)

                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Stock count updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_stock()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub btnUprice_Click(sender As Object, e As EventArgs) Handles btnUprice.Click
        Dim NewStockprice As Decimal
        If Dgvstocts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row in the DataGridView.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = Dgvstocts.SelectedRows(0)
        Dim productName As String = selectedRow.Cells("PRODUCT_NAME").Value.ToString()


        Dim newStockCountStr As String = InputBox("Enter the new price for " & productName & ":")

        If Not Decimal.TryParse(newStockCountStr, NewStockprice) Then
            MessageBox.Show("Invalid stock count. Please enter a valid integer.")
            Return
        End If

        connect = connector()
        Try
            Using connect
                connect.Open()

                Dim updateQuery As String = "UPDATE product_catalog SET price = @newprice WHERE PRODUCT_NAME = @productName"

                Using cmd As New MySqlCommand(updateQuery, connect)
                    cmd.Parameters.AddWithValue("@newprice", NewStockprice)
                    cmd.Parameters.AddWithValue("@productName", productName)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Stock price updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                load_stock()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
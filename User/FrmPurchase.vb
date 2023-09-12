Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class FrmPurchase
    Public totalAmount As Decimal
    Dim invoice As String

    Private Sub FrmPurchase_Load(sender As Object, e As EventArgs) Handles Me.Load

        Scategory()
        SProduct()
    End Sub

    ' load product 
    Private Sub SProduct()
        Dim sqlRd As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim sqltable As New DataTable
        Dim query As String = "SELECT PRODUCT_NAME FROM product_catalog WHERE stock_count - stock_level > 0"

        Try
            connect = connector()
            connect.Open()
            sqlcmd.Connection = connect
            sqlcmd.CommandText = query
            sqlRd = sqlcmd.ExecuteReader
            sqltable.Load(sqlRd)
            sqlRd.Close()



            cmbSPname.Items.Clear()


            For Each row As DataRow In sqltable.Rows
                cmbSPname.Items.Add(row("PRODUCT_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub


    ' load category
    Private Sub Scategory()
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

            cmbSCate.Items.Clear()
            For Each row As DataRow In sqltable.Rows
                cmbSCate.Items.Add(row("CATEGORY_NAME").ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbSPname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSPname.SelectedIndexChanged
        ' Check if there is a selected item in cmbSPname
        If cmbSPname.SelectedItem IsNot Nothing Then
            ' Get the selected product name from cmbSPname
            Dim selectedProductName As String = cmbSPname.SelectedItem.ToString()

            Try
                ' Fetch the brand and category IDs based on the selected product name from the database
                Dim query As String = "SELECT ID, PRICE, CATEGORY_ID FROM product_catalog " &
                              "WHERE PRODUCT_NAME = @productName"
                ' create connection
                connect = connector()
                Using connect
                    connect.Open()
                    Using cmd As New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@productName", selectedProductName)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then

                                Dim productId As Integer = Convert.ToInt32(reader("ID"))
                                txtPcode.Text = productId
                                ' Get  brand ID and set the selection in CmbSBrand
                                Dim S_price As Double = Convert.ToDouble(reader("PRICE"))
                                txtPrice.Text = S_price


                                ' Get the corresponding category ID and set the selection in cmbSCate
                                Dim categoryId As Integer = Convert.ToInt32(reader("CATEGORY_ID"))
                                SetCategorySelection(categoryId)
                            Else

                                ' clear the selections in CmbSBrand and cmbSCate

                                cmbSCate.SelectedItem = Nothing
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                ' close connection
                connect.Close()
            End Try
        End If
    End Sub



    Private Sub SetCategorySelection(categoryId As Integer)

        For Each item As Object In cmbSCate.Items
            Dim categoryName As String = item.ToString()
            Dim currentCategoryId As Integer = GetCategoryId(categoryName)
            If currentCategoryId = categoryId Then
                cmbSCate.SelectedItem = item
                Exit Sub
            End If
        Next

        cmbSCate.SelectedItem = Nothing
    End Sub


    ' get category id
    Private Function GetCategoryId(categoryName As String) As Integer
        Dim categoryId As Integer = -1
        Dim query As String = "SELECT CATEGORY_ID FROM product_category WHERE CATEGORY_NAME = @categoryName"

        Try
            connect = connector()
            Using connect
                connect.Open()
                Using cmd As New MySqlCommand(query, connect)
                    cmd.Parameters.AddWithValue("@categoryName", categoryName)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        categoryId = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while fetching the category ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return categoryId
    End Function

    ' add selected it to cart
    Private Sub BtnAddCart_Click(sender As Object, e As EventArgs) Handles BtnAddCart.Click

        If cmbSPname.SelectedItem IsNot Nothing Then


            Dim selectedProductName As String = cmbSPname.SelectedItem.ToString()


            Dim description As String = String.Empty
            Dim price As Decimal = 0
            Try
                Dim query As String = "SELECT DESCRIPTION, PRICE FROM product_catalog WHERE PRODUCT_NAME = @productName"
                connect = connector()
                Using connect
                    connect.Open()
                    Using cmd As New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@productName", selectedProductName)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                description = reader("DESCRIPTION").ToString()
                                price = Convert.ToDecimal(reader("PRICE"))
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while fetching product details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Finally
                connect.Close()
            End Try

            Dim selectedCategory As String = cmbSCate.SelectedItem.ToString()

            ' Get the quantity (units) from cmbUnit
            Dim quantity As Integer
            If Not Integer.TryParse(cmbUnit.Text, quantity) Then
                MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Calculate the subtotal
            Dim subtotal As Decimal = price * quantity

            ' Check if the product name already exists in the DataGridView
            Dim rowIndex As Integer = -1
            For i As Integer = 0 To DgCart.Rows.Count - 1
                If DgCart.Rows(i).Cells(0).Value.ToString() = selectedProductName Then
                    rowIndex = i
                    Exit For
                End If
            Next

            ' If the product name exists in the DataGridView, increase the quantity (units)
            If rowIndex <> -1 Then
                Dim existingQuantity As Integer = Convert.ToInt32(DgCart.Rows(rowIndex).Cells(2).Value)
                quantity += existingQuantity
                subtotal = price * quantity
                DgCart.Rows(rowIndex).Cells(2).Value = quantity
                DgCart.Rows(rowIndex).Cells(4).Value = subtotal
            Else
                ' If the product name is not found in the DataGridView, add a new row
                DgCart.Rows.Add(selectedProductName, description, quantity, price, subtotal)
            End If

            ' Clear the selection in cmbSPname, and cmbUnit for the next entry
            cmbSPname.SelectedIndex = -1
            cmbSCate.SelectedIndex = -1
            cmbUnit.Value = 1
            txtPcode.Clear()

            txtPrice.Clear()
        Else
            MsgBox("No Item select", MsgBoxStyle.Critical)
        End If
        UpdateTotalAmount()
    End Sub



    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click

        If DgCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items to the cart before processing the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim paymentForm As New payment()
        paymentForm.txtDue.Text = totalAmount
        If paymentForm.ShowDialog() = DialogResult.OK Then

            Dim paymentAmount As Decimal = Decimal.Parse(paymentForm.txtpayment.Text)


            ProcessTransaction("Cash", paymentAmount)
            TxtTotal.Text = "0.00"

        End If

        PrintTest.Document = PrintCash
        PrintTest.ShowDialog()

    End Sub


    ' upating total amount
    Private Sub UpdateTotalAmount()
        totalAmount = 0

        For Each row As DataGridViewRow In DgCart.Rows
            Dim subtotal As Decimal
            If Decimal.TryParse(row.Cells("Subtotal").Value.ToString(), subtotal) Then
                totalAmount += subtotal
            End If
        Next

        ' Update the total amount in a label or display it as needed
        TxtTotal.Text = totalAmount.ToString("C")
    End Sub


    ' find casheir id
    Private Function GetCashierIDByUsername(username As String) As Integer

        Dim cashierID As Integer = 0
        Dim query As String = "SELECT employee_id FROM login WHERE username = @username"
        Using connect
            connect.Open()
            Using cmd As New MySqlCommand(query, connect)
                cmd.Parameters.AddWithValue("@username", username)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    cashierID = Convert.ToInt32(result)
                End If
                connect.Close()
            End Using
        End Using
        Return cashierID
    End Function



    ' process Transcation
    Private Sub ProcessTransaction(paymentMethod As String, paymentAmount As Decimal)
        Dim cashierID As Integer = GetCashierIDByUsername(UseHome.LblProfile.Text)
        invoice = GenerateInvoiceNumber()

        If cashierID <> -1 Then

            Dim salesID As Integer
            connect = connector()


            Dim insertSalesQuery As String = "INSERT INTO Sales (employee_id, invoice, SaleDate, Amount, PaymentMethod) " &
                         "VALUES (@EmployeeID, @Invoice, @SaleDate, @Amount, @PaymentMethod)"


            Using connect
                connect.Open()
                Using cmd As New MySqlCommand(insertSalesQuery, connect)

                    cmd.Parameters.AddWithValue("@EmployeeID", cashierID)
                    cmd.Parameters.AddWithValue("@invoice", invoice)
                    cmd.Parameters.AddWithValue("@SaleDate", Date.Now)
                    cmd.Parameters.AddWithValue("@amount", totalAmount)
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod)

                    ' Execute the query and get the generated sales ID
                    cmd.ExecuteNonQuery()
                    salesID = CInt(cmd.LastInsertedId)
                End Using
            End Using

            If salesID > 0 Then ' Check if a valid sales ID was generated
                ' Step 2: Insert each item in the cart with the generated sales ID
                For Each row As DataGridViewRow In DgCart.Rows
                    Dim productName As String = row.Cells("Pnames").Value.ToString()
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("pquantity").Value)
                    Dim price As Decimal = GetPrice(productName) ' Modify this based on your logic
                    Dim subtotal As Decimal = GetSubtotal(productName)
                    ' Insert the item into the SalesItems table with the generated sales ID
                    Dim insertItemQuery As String = "INSERT INTO SalesItems (SaleID, ProductName, Quantity, Price, Subtotal) " &
                            "VALUES (@SaleID, @ProductName, @Quantity, @Price, @Subtotal)"

                    Using connect
                        connect.Open()
                        Using cmd As New MySqlCommand(insertItemQuery, connect)
                            ' Add parameters and their values for the item in the cart
                            cmd.Parameters.AddWithValue("@SaleID", salesID)
                            cmd.Parameters.AddWithValue("@ProductName", productName)
                            cmd.Parameters.AddWithValue("@Quantity", quantity)
                            cmd.Parameters.AddWithValue("@Price", price)
                            cmd.Parameters.AddWithValue("@Subtotal", subtotal)

                            ' Execute the query to insert the item
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                Next

                ' Get the list of products and their quantities from the DataGridView (DgCart)
                Dim productsToUpdate As New List(Of KeyValuePair(Of String, Integer))
                For Each row As DataGridViewRow In DgCart.Rows
                    Dim productName As String = row.Cells("Pnames").Value.ToString()
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("pquantity").Value)
                    productsToUpdate.Add(New KeyValuePair(Of String, Integer)(productName, quantity))
                Next

                ' Update the stock level and check for availability
                Dim stockUpdateResult As Boolean = UpdateStockLevel(productsToUpdate)
                If Not stockUpdateResult Then
                    ' Stock update was not successful, so cancel the sale
                    MessageBox.Show("Transaction canceled due to insufficient stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Optionally, you can display a message to indicate the records have been saved
                MessageBox.Show("Sale records saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Optionally, you can clear the form or reset relevant controls for the next sale
                cmbSPname.SelectedIndex = -1

                cmbSCate.SelectedIndex = -1
                cmbUnit.Text = String.Empty

                ' Clear the DataGridView (DgCart) for the next sale
                DgCart.Rows.Clear()
            Else
                ' The sales ID was not valid, show an error message or take appropriate action
                MessageBox.Show("Error generating sales ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Cashier ID not found, show an error message or take appropriate action
            MessageBox.Show("Cashier ID not found. Transaction canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' get product price
    Private Function GetPrice(productName As String) As Decimal
        Dim price As Decimal = 0

        For Each row As DataGridViewRow In DgCart.Rows
            Dim productNameInRow As String = row.Cells("Pnames").Value.ToString()
            If productNameInRow = productName Then

                price = Convert.ToDecimal(row.Cells("pquantity").Value)
                Exit For
            End If
        Next

        Return price
    End Function


    ' 
    Private Function GetSubtotal(productName As String) As Decimal
        Dim subtotal As Decimal = 0

        For Each row As DataGridViewRow In DgCart.Rows
            Dim productNameInRow As String = row.Cells("Pnames").Value.ToString()
            If productNameInRow = productName Then

                subtotal = Convert.ToDecimal(row.Cells("pquantity").Value)
                Exit For
            End If
        Next

        Return subtotal
    End Function

    Private Function UpdateStockLevel(productsToUpdate As List(Of KeyValuePair(Of String, Integer))) As Boolean
        Try
            Using connect As MySqlConnection = connector()
                connect.Open()
                For Each product In productsToUpdate
                    Dim productName As String = product.Key
                    Dim quantitySold As Integer = product.Value

                    ' get total item sold
                    Dim soldOut As Integer
                    Dim getStockQuery As String = "SELECT  SOLD_OUT FROM product_catalog WHERE PRODUCT_NAME = @productName"
                    Using cmd As New MySqlCommand(getStockQuery, connect)
                        cmd.Parameters.AddWithValue("@productName", productName)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then

                                soldOut = Convert.ToInt32(reader("SOLD_OUT"))
                            End If
                        End Using
                    End Using



                    ' Calculate the new stock level after deducting the sold quantity
                    Dim newStockLevel As Integer = soldOut + quantitySold

                    ' Update the stock level and sold out status in the database
                    Dim updateStockQuery As String = "UPDATE product_catalog SET SOLD_OUT = @Sold WHERE PRODUCT_NAME = @productName"
                    Using cmd As New MySqlCommand(updateStockQuery, connect)
                        cmd.Parameters.AddWithValue("@Sold", newStockLevel)

                        cmd.Parameters.AddWithValue("@productName", productName)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            Return True
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating the stock level: " & ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            connect.Close()

        End Try
    End Function


    Private Sub PrintVoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintVoch.PrintPage
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)


        Dim xPos As Single = 10
        Dim yPos As Single = 10

        ' Load the logo image
        Dim logoImage As Image = My.Resources.icon_128px


        If logoImage IsNot Nothing Then
            e.Graphics.DrawImage(logoImage, xPos, yPos, logoImage.Width, logoImage.Height)
        Else
            MessageBox.Show("Logo image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.HasMorePages = False
            Exit Sub
        End If


        yPos += logoImage.Height


        Dim headerText As String = "Group Three Sub 11 Project"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, fontHeader)
        Dim headerXPos As Single = (e.PageBounds.Width - headerSize.Width) / 2
        e.Graphics.DrawString(headerText, fontHeader, brush, headerXPos, yPos)
        yPos += headerSize.Height


        Dim subHeaderText As String = "Sales and Inventory Management System Project"
        Dim subHeaderSize As SizeF = e.Graphics.MeasureString(subHeaderText, fontSubHeader)
        Dim subHeaderXPos As Single = (e.PageBounds.Width - subHeaderSize.Width) / 2
        e.Graphics.DrawString(subHeaderText, fontSubHeader, brush, subHeaderXPos, yPos)
        yPos += subHeaderSize.Height + 10


        Dim address As String = "Address: UEW South Campus"
        Dim email As String = "Email: candoitspirt@wolf.com"
        Dim phone As String = "Phone: 050-00-000-00"

        e.Graphics.DrawString(address, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(email, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(phone, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10

        ' Draw invoice details
        Dim invoiceNumber As String = "Invoice Number: " & GenerateInvoiceNumber().ToString()
        Dim timeStamp As String = "Timestamp: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim cashierID As String = "Cashier ID: " & GetCashierIDByUsername(frmLogin.TxtUname.Text).ToString()

        e.Graphics.DrawString(invoiceNumber, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(timeStamp, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(cashierID, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        For Each cartRow As DataGridViewRow In DgCart.Rows
            Dim productName As String = cartRow.Cells("Pnames").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(cartRow.Cells("pquantity").Value)
            Dim price As Decimal = GetPrice(productName)
            Dim subtotal As Decimal = GetSubtotal(productName)


            Dim cartRowText As String = $"{productName} x {quantity} - Price: {price:C} - Subtotal: {subtotal:C}"
            e.Graphics.DrawString(cartRowText, fontContent, brush, xPos, yPos)


            yPos += fontContent.Height
        Next


        yPos += 10
        e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        yPos += 10


        Dim totalAmount As Decimal = DgCart.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells("Subtotal").Value))
        Dim amountPaid As Decimal = Decimal.Parse(payment.paymentAmount)
        Dim paymentMethod As String = "Payment Method: " & btnVocher.Text

        e.Graphics.DrawString("Total: " & totalAmount.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString("Amount Paid: " & amountPaid.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(paymentMethod, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        e.HasMorePages = False
    End Sub

    Private Sub PrintMomo_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintMoMo.PrintPage
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)


        Dim xPos As Single = 10
        Dim yPos As Single = 10

        ' Load the logo image
        Dim logoImage As Image = My.Resources.icon_128px


        If logoImage IsNot Nothing Then
            e.Graphics.DrawImage(logoImage, xPos, yPos, logoImage.Width, logoImage.Height)
        Else
            MessageBox.Show("Logo image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.HasMorePages = False
            Exit Sub
        End If


        yPos += logoImage.Height


        Dim headerText As String = "Group Three Sub 11 Project"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, fontHeader)
        Dim headerXPos As Single = (e.PageBounds.Width - headerSize.Width) / 2
        e.Graphics.DrawString(headerText, fontHeader, brush, headerXPos, yPos)
        yPos += headerSize.Height


        Dim subHeaderText As String = "Sales and Inventory Management System Project"
        Dim subHeaderSize As SizeF = e.Graphics.MeasureString(subHeaderText, fontSubHeader)
        Dim subHeaderXPos As Single = (e.PageBounds.Width - subHeaderSize.Width) / 2
        e.Graphics.DrawString(subHeaderText, fontSubHeader, brush, subHeaderXPos, yPos)
        yPos += subHeaderSize.Height + 10


        Dim address As String = "Address: UEW South Campus"
        Dim email As String = "Email: candoitspirt@wolf.com"
        Dim phone As String = "Phone: 050-00-000-00"

        e.Graphics.DrawString(address, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(email, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(phone, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10

        ' Draw invoice details
        Dim invoiceNumber As String = "Invoice Number: " & GenerateInvoiceNumber().ToString()
        Dim timeStamp As String = "Timestamp: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim cashierID As String = "Cashier ID: " & GetCashierIDByUsername(frmLogin.TxtUname.Text).ToString()

        e.Graphics.DrawString(invoiceNumber, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(timeStamp, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(cashierID, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        For Each cartRow As DataGridViewRow In DgCart.Rows
            Dim productName As String = cartRow.Cells("Pnames").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(cartRow.Cells("pquantity").Value)
            Dim price As Decimal = GetPrice(productName)
            Dim subtotal As Decimal = GetSubtotal(productName)


            Dim cartRowText As String = $"{productName} x {quantity} - Price: {price:C} - Subtotal: {subtotal:C}"
            e.Graphics.DrawString(cartRowText, fontContent, brush, xPos, yPos)


            yPos += fontContent.Height
        Next


        yPos += 10
        e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        yPos += 10


        Dim totalAmount As Decimal = DgCart.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells("Subtotal").Value))
        Dim amountPaid As Decimal = Decimal.Parse(payment.paymentAmount)
        Dim paymentMethod As String = "Payment Method: " & btnMomo.Text

        e.Graphics.DrawString("Total: " & totalAmount.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString("Amount Paid: " & amountPaid.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(paymentMethod, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        e.HasMorePages = False
    End Sub

    Private Sub PrintCard_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCard.PrintPage
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)


        Dim xPos As Single = 10
        Dim yPos As Single = 10

        ' Load the logo image
        Dim logoImage As Image = My.Resources.icon_128px


        If logoImage IsNot Nothing Then
            e.Graphics.DrawImage(logoImage, xPos, yPos, logoImage.Width, logoImage.Height)
        Else
            MessageBox.Show("Logo image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.HasMorePages = False
            Exit Sub
        End If


        yPos += logoImage.Height


        Dim headerText As String = "Group Three Sub 11 Project"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, fontHeader)
        Dim headerXPos As Single = (e.PageBounds.Width - headerSize.Width) / 2
        e.Graphics.DrawString(headerText, fontHeader, brush, headerXPos, yPos)
        yPos += headerSize.Height


        Dim subHeaderText As String = "Sales and Inventory Management System Project"
        Dim subHeaderSize As SizeF = e.Graphics.MeasureString(subHeaderText, fontSubHeader)
        Dim subHeaderXPos As Single = (e.PageBounds.Width - subHeaderSize.Width) / 2
        e.Graphics.DrawString(subHeaderText, fontSubHeader, brush, subHeaderXPos, yPos)
        yPos += subHeaderSize.Height + 10


        Dim address As String = "Address: UEW South Campus"
        Dim email As String = "Email: candoitspirt@wolf.com"
        Dim phone As String = "Phone: 050-00-000-00"

        e.Graphics.DrawString(address, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(email, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(phone, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10

        ' Draw invoice details
        Dim invoiceNumber As String = "Invoice Number: " & GenerateInvoiceNumber().ToString()
        Dim timeStamp As String = "Timestamp: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim cashierID As String = "Cashier ID: " & GetCashierIDByUsername(frmLogin.TxtUname.Text).ToString()

        e.Graphics.DrawString(invoiceNumber, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(timeStamp, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(cashierID, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        For Each cartRow As DataGridViewRow In DgCart.Rows
            Dim productName As String = cartRow.Cells("Pnames").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(cartRow.Cells("pquantity").Value)
            Dim price As Decimal = GetPrice(productName)
            Dim subtotal As Decimal = GetSubtotal(productName)


            Dim cartRowText As String = $"{productName} x {quantity} - Price: {price:C} - Subtotal: {subtotal:C}"
            e.Graphics.DrawString(cartRowText, fontContent, brush, xPos, yPos)


            yPos += fontContent.Height
        Next


        yPos += 10
        e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        yPos += 10


        Dim totalAmount As Decimal = DgCart.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells("Subtotal").Value))
        Dim amountPaid As Decimal = Decimal.Parse(payment.paymentAmount)
        Dim paymentMethod As String = "Payment Method: " & btnCard.Text

        e.Graphics.DrawString("Total: " & totalAmount.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString("Amount Paid: " & amountPaid.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(paymentMethod, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        e.HasMorePages = False
    End Sub

    Private Sub PrintReciept_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCash.PrintPage
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)


        Dim xPos As Single = 10
        Dim yPos As Single = 10

        ' Load the logo image
        Dim logoImage As Image = My.Resources.icon_128px


        If logoImage IsNot Nothing Then
            e.Graphics.DrawImage(logoImage, xPos, yPos, logoImage.Width, logoImage.Height)
        Else
            MessageBox.Show("Logo image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.HasMorePages = False
            Exit Sub
        End If


        yPos += logoImage.Height


        Dim headerText As String = "Group Three Sub 11 Project"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, fontHeader)
        Dim headerXPos As Single = (e.PageBounds.Width - headerSize.Width) / 2
        e.Graphics.DrawString(headerText, fontHeader, brush, headerXPos, yPos)
        yPos += headerSize.Height


        Dim subHeaderText As String = "Sales and Inventory Management System Project"
        Dim subHeaderSize As SizeF = e.Graphics.MeasureString(subHeaderText, fontSubHeader)
        Dim subHeaderXPos As Single = (e.PageBounds.Width - subHeaderSize.Width) / 2
        e.Graphics.DrawString(subHeaderText, fontSubHeader, brush, subHeaderXPos, yPos)
        yPos += subHeaderSize.Height + 10


        Dim address As String = "Address: UEW South Campus"
        Dim email As String = "Email: candoitspirt@wolf.com"
        Dim phone As String = "Phone: 050-00-000-00"

        e.Graphics.DrawString(address, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(email, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(phone, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10

        ' Draw invoice details
        Dim invoiceNumber As String = "Invoice Number: " & GenerateInvoiceNumber().ToString()
        Dim timeStamp As String = "Timestamp: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim cashierID As String = "Cashier ID: " & GetCashierIDByUsername(frmLogin.TxtUname.Text).ToString()

        e.Graphics.DrawString(invoiceNumber, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(timeStamp, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(cashierID, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        For Each cartRow As DataGridViewRow In DgCart.Rows
            Dim productName As String = cartRow.Cells("Pnames").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(cartRow.Cells("pquantity").Value)
            Dim price As Decimal = GetPrice(productName)
            Dim subtotal As Decimal = GetSubtotal(productName)


            Dim cartRowText As String = $"{productName} x {quantity} - Price: {price:C} - Subtotal: {subtotal:C}"
            e.Graphics.DrawString(cartRowText, fontContent, brush, xPos, yPos)


            yPos += fontContent.Height
        Next


        yPos += 10
        e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        yPos += 10


        Dim totalAmount As Decimal = DgCart.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells("Subtotal").Value))
        Dim amountPaid As Decimal = Decimal.Parse(payment.paymentAmount)
        Dim paymentMethod As String = "Payment Method: " & btnCash.Text

        e.Graphics.DrawString("Total: " & totalAmount.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString("Amount Paid: " & amountPaid.ToString("C"), fontContent, brush, xPos, yPos)
        yPos += fontContent.Height

        e.Graphics.DrawString(paymentMethod, fontContent, brush, xPos, yPos)
        yPos += fontContent.Height + 10


        e.HasMorePages = False
    End Sub





    Private Shared ReadOnly rand As New Random()

    Public Shared Function GenerateInvoiceNumber() As String
        Dim now As DateTime = DateTime.Now
        Dim randomPart As Integer = rand.Next(1000, 10000)

        Dim uniqueCode As String = $"{now:yyyyHHmmss}-{randomPart}"

        Return uniqueCode
    End Function


    Private Sub btnMomo_Click(sender As Object, e As EventArgs) Handles btnMomo.Click
        If DgCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items to the cart before processing the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        '
        ProcessTransaction("MoMo", totalAmount)
        TxtTotal.Text = "0.00"
        PrintTest.Document = PrintMoMo
        PrintTest.ShowDialog()

    End Sub

    Private Sub btnVocher_Click(sender As Object, e As EventArgs) Handles btnVocher.Click
        If DgCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items to the cart before processing the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If





        ProcessTransaction("voucher", totalAmount)
        TxtTotal.Text = "0.00"
        PrintTest.Document = PrintCash
        PrintTest.ShowDialog()

    End Sub


    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        If DgCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is empty. Please add items to the cart before processing the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If





        ProcessTransaction("Card", totalAmount)
        TxtTotal.Text = "0.00"
        PrintTest.Document = PrintCard
        PrintTest.ShowDialog()


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        If MessageBox.Show("Are you sure you want to clear the cart?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DgCart.Rows.Clear()
            TxtTotal.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DgCart.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DgCart.SelectedRows(0).Index

            Dim subtotalToRemove As Decimal
            If Decimal.TryParse(DgCart.Rows(selectedRowIndex).Cells("Subtotal").Value.ToString(), subtotalToRemove) Then
                totalAmount -= subtotalToRemove
            End If

            DgCart.Rows.RemoveAt(selectedRowIndex)
            UpdateTotalAmount()
        Else
            MessageBox.Show("Please select a row to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub BtnPClear_Click(sender As Object, e As EventArgs) Handles BtnPClear.Click
        cmbSPname.SelectedIndex = -1
        cmbSCate.SelectedIndex = -1
        cmbUnit.Value = 1
        txtPcode.Clear()

        txtPrice.Clear()
    End Sub


End Class
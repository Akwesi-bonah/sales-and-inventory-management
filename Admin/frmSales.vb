Imports MySql.Data.MySqlClient
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_cashier()
    End Sub



    Private Sub Load_cashier()
        Dim query As String = "SELECT employee_id FROM employees"

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()
                Using sqlcmd As New MySqlCommand(query, connect)
                    Using sqlRd As MySqlDataReader = sqlcmd.ExecuteReader()
                        Dim sqltable As New DataTable
                        sqltable.Load(sqlRd)

                        CmbTeller.Items.Clear()
                        For Each row As DataRow In sqltable.Rows
                            CmbTeller.Items.Add(row("employee_id").ToString())
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        txtsales.Clear()

        If IsNothing(CmbTeller.SelectedItem) Then
            MsgBox("Select Teller ID", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim selectedCashier As String = CmbTeller.SelectedItem.ToString()
        Dim startDate As String = DtpStart.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = DtpEnd.Value.ToString("yyyy-MM-dd")

        Dim totalSalesQuery As String = $"SELECT SUM(Amount) AS total_sales FROM sales WHERE employee_id = '{selectedCashier}' AND SaleDate BETWEEN '{startDate}' AND '{endDate}'"
        Dim salesListQuery As String = $"SELECT SaleID as 'Sales ID', employee_id as 'Teller ID',
                Amount, PaymentMethod as 'Payment Mode' FROM Sales WHERE employee_id = '{selectedCashier}' AND SaleDate >= '{startDate}' AND SaleDate < '{endDate}'"

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()

                ' Query for total sales
                Using totalSalesCmd As New MySqlCommand(totalSalesQuery, connect)
                    Dim totalSales As Object = totalSalesCmd.ExecuteScalar()
                    If totalSales IsNot DBNull.Value Then
                        Dim salesTotal As Decimal = Convert.ToDecimal(totalSales)
                        TxtTotal.Text = salesTotal.ToString("C")
                    Else
                        MsgBox("Sales record not found", MsgBoxStyle.Information)
                    End If
                End Using

                ' Clear the DataGridView
                dgvSales.DataSource = Nothing
                dgvSales.Rows.Clear()

                ' Query for sales transactions list
                Using salesListCmd As New MySqlCommand(salesListQuery, connect)
                    Dim salesAdapter As New MySqlDataAdapter(salesListCmd)
                    Dim salesTable As New DataTable()
                    salesAdapter.Fill(salesTable)
                    dgvSales.DataSource = salesTable

                    Dim headerStyle As New DataGridViewCellStyle()
                    headerStyle.Font = New Font("Arial", 10, FontStyle.Bold)
                    dgvSales.ColumnHeadersDefaultCellStyle = headerStyle
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        TxtTotal.Clear()

        If IsNothing(CmbTeller.SelectedItem) Then
            MsgBox("Select Teller ID", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim selectedCashier As String = CmbTeller.SelectedItem.ToString()
        Dim selectedDate As DateTime = mcDate.SelectionStart

        Dim startDate As String = selectedDate.ToString("yyyy-MM-dd")
        Dim endDate As String = selectedDate.AddDays(1).ToString("yyyy-MM-dd")

        Dim totalSalesQuery As String = $"SELECT SUM(Amount) AS total_sales FROM Sales WHERE employee_id = '{selectedCashier}' AND SaleDate >= '{startDate}' AND SaleDate < '{endDate}'"
        Dim salesListQuery As String = $"SELECT SaleID, SaleDate, Amount, PaymentMethod FROM Sales WHERE employee_id = '{selectedCashier}' AND SaleDate >= '{startDate}' AND SaleDate <= '{endDate}'"

        Try
            Using connect As MySqlConnection = connector()
                connect.Open()

                ' Query for total sales
                Using totalSalesCmd As New MySqlCommand(totalSalesQuery, connect)
                    Dim totalSales As Object = totalSalesCmd.ExecuteScalar()
                    If totalSales IsNot DBNull.Value Then
                        Dim salesTotal As Decimal = Convert.ToDecimal(totalSales)
                        txtsales.Text = salesTotal.ToString("C")
                    Else
                        txtsales.Text = "$0.00"
                    End If
                End Using

                ' Clear the DataGridView
                dgvSales.DataSource = Nothing
                dgvSales.Rows.Clear()

                ' Query for sales transactions list
                Using salesListCmd As New MySqlCommand(salesListQuery, connect)
                    Dim salesAdapter As New MySqlDataAdapter(salesListCmd)
                    Dim salesTable As New DataTable()
                    salesAdapter.Fill(salesTable)
                    dgvSales.DataSource = salesTable

                    Dim headerStyle As New DataGridViewCellStyle()
                    headerStyle.Font = New Font("Arial", 10, FontStyle.Bold)
                    dgvSales.ColumnHeadersDefaultCellStyle = headerStyle
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class
Imports System.Windows.Forms

Public Class payment
    Public Shared paymentAmount As Decimal
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim balanceAmount As Decimal
        If Decimal.TryParse(txtbalance.Text, balanceAmount) Then
            If balanceAmount >= 0 Then

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                '
                MessageBox.Show("The payment amount is less than the due amount. Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            MessageBox.Show("Invalid balance amount. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtpayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayment.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True

            pError.SetError(txtpayment, "Please enter only numbers and the dot (.)")
        Else

            pError.Clear()
        End If

    End Sub

    Private Sub txtpayment_KeyUp(sender As Object, e As KeyEventArgs) Handles txtpayment.KeyUp



        If Decimal.TryParse(txtpayment.Text, paymentAmount) Then

            Dim dueAmount As Decimal = Decimal.Parse(txtDue.Text)
            Dim balanceAmount As Decimal = paymentAmount - dueAmount


            txtbalance.Text = balanceAmount.ToString("N2")
        Else

            txtbalance.Text = String.Empty
        End If
    End Sub

    Private Sub txtDue_TextChanged(sender As Object, e As EventArgs) Handles txtDue.TextChanged

    End Sub
End Class

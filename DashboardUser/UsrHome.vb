Public Class UsrHome
    Private Sub UsrHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addForm(frm As Form)
        PnlContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PnlContainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(Menu As String)
        Select Case Menu
            Case "Sales"
                addForm(Sales)
            Case "Stocks"
                addForm(Stock)
            Case "Items"
                addForm(Items)
            Case "SignOut"
        End Select
    End Sub

    Private Sub PtInvoice_Click(sender As Object, e As EventArgs) Handles PtInvoice.Click
        change_menu("Sales")
    End Sub

    Private Sub PtItems_Click(sender As Object, e As EventArgs) Handles PtItems.Click
        change_menu("Stocks")
    End Sub

    Private Sub PtSignOut_Click(sender As Object, e As EventArgs) Handles PtSignOut.Click
        change_menu("SignOut")
    End Sub

    Private Sub PtExit_Click(sender As Object, e As EventArgs) Handles PtExit.Click
        Dim result As MsgBoxResult = MsgBox("Do You Want to Exit", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Exit Confirmation")
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
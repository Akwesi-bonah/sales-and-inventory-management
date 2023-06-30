Public Class frmRegister
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub
End Class
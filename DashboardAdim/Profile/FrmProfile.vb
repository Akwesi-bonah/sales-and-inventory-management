Public Class frmProfile
    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCreateU_Click(sender As Object, e As EventArgs) Handles BtnCreateU.Click
        Me.Hide()
        Dim frmRegister As New frmRegister()
        Dim dialogResult As DialogResult = frmRegister.ShowDialog()
        If dialogResult = DialogResult.OK Then
            ' Registration successful
            MsgBox("New user created")

        End If
        Me.Show()
    End Sub
End Class
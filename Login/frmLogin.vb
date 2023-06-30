Public Class frmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUname.Text = "Admin" And TxtPaswd.Text = "Admin" Then
            Me.Hide()
            frmHome.Show()
        Else
            MsgBox("Incorrect details")
        End If
    End Sub

End Class
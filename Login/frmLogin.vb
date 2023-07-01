Imports System.Data.OleDb
Imports System.Data
Public Class frmLogin
    Dim connection As New OleDbConnection()
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUname.Text = Nothing Or TxtPaswd.Text Is Nothing Then
            MsgBox("Enter Credentials", MsgBoxStyle.Exclamation)
        End If
        If TxtUname.Text = "Admin" And TxtPaswd.Text = "Admin" Then
            Me.Hide()
            frmHome.Show()
        ElseIf TxtUname.Text = "user" And TxtPaswd.Text = "user" Then
            Me.Hide()
            UsrHome.Show()

        Else
            MsgBox("Incorrect details")
        End If
    End Sub

    Private Sub PnlDetails_Paint(sender As Object, e As PaintEventArgs) Handles PnlDetails.Paint

    End Sub
End Class
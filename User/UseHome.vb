Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class UseHome
    Inherits Form

    Private Shared _lightBackgroundColor As Color = Color.WhiteSmoke
    Private Shared _darkBackgroundColor As Color = Color.Gray
    Private Shared _currentTheme As Theme = Theme.Light

    Enum Theme
        Light
        Dark
    End Enum

    Private Sub SwitchTheme(newTheme As Theme)
        _currentTheme = newTheme
        Dim backgroundColor As Color = If(_currentTheme = Theme.Light, _lightBackgroundColor, _darkBackgroundColor)

        ApplyBackgroundColorToChildForms(backgroundColor)
    End Sub
    Private Sub ApplyBackgroundColorToForm(form As Form)
        form.BackColor = If(_currentTheme = Theme.Light, _lightBackgroundColor, _darkBackgroundColor)
    End Sub

    Private Sub ApplyBackgroundColorToChildForms(color As Color)
        For Each form As Form In Me.MdiChildren
            form.BackColor = color

        Next
    End Sub

    Private Sub msPurchase_Click(sender As Object, e As EventArgs) Handles msPurchase.Click
        Dim change As New FrmPurchase()
        ApplyBackgroundColorToForm(change)
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()

    End Sub

    Private Sub UseHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim change As New FrmPurchase()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
        LblProfile.Text = frmLogin.TxtUname.Text
    End Sub

    Private Sub msStock_Click(sender As Object, e As EventArgs)
        Dim change As New FrmStock()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    Private Sub msProducts_Click(sender As Object, e As EventArgs)
        Dim change As New frmProduct()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    Private Sub msSales_Click(sender As Object, e As EventArgs)
        Dim change As New frmSales()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim dialogLogout As New logout()
        dialogLogout.ShowDialog()


        If dialogLogout.DialogResult = DialogResult.OK Then
            Me.Hide()
            frmLogin.TxtPwd.Clear()
            frmLogin.TxtUname.Clear()
            frmLogin.Show()
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim changPwd As New frmChangePwd()
        changPwd.ShowDialog()
    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        SwitchTheme(Theme.Light)
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        SwitchTheme(Theme.Dark)
    End Sub


End Class

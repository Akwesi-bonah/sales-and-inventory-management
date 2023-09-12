Imports System.Windows.Forms

Public Class AdminHome
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
            If color = Color.FromArgb(&H4, &H7, &H20) Then

            End If
        Next
    End Sub

    Private Sub btnLightTheme_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        SwitchTheme(Theme.Light)
    End Sub


    Private Sub btnDarkTheme_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        SwitchTheme(Theme.Dark)
    End Sub


    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim change As New frmProduct()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
        LblProfile.Text = frmLogin.TxtUname.Text
    End Sub

    Private Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click
        Dim change As New FrmStock()
        change.MdiParent = Me
        ApplyBackgroundColorToForm(change)
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub


    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim change As New frmProduct()
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        ApplyBackgroundColorToForm(change)
        change.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim change As New frmSales()
        change.MdiParent = Me
        ApplyBackgroundColorToForm(change)
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


    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Dim regForm As New frmRegister()
        Dim result As DialogResult = regForm.ShowDialog()

    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        Dim change As New FrmProfile()
        change.MdiParent = Me
        ApplyBackgroundColorToForm(change)
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    Private Sub PlaceOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceOrderToolStripMenuItem.Click
        Dim change As New orders()
        change.MdiParent = Me
        ApplyBackgroundColorToForm(change)
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub


    ' Inventory menu item click event
    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim change As New variance()
        ApplyBackgroundColorToForm(change)
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    ' Audit menu item click event
    Private Sub AuditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditToolStripMenuItem.Click
        Dim change As New ordit()
        ApplyBackgroundColorToForm(change)
        change.MdiParent = Me
        change.Dock = DockStyle.Fill
        change.Show()
    End Sub

    Private Sub EditConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditConnectionToolStripMenuItem.Click
        Dim connectionSettingsForm As New connectionSettings()

        If connectionSettingsForm.ShowDialog() = DialogResult.OK Then
            ' Access the controls through the instance of the connectionSettingsForm
            dbconnect.server = connectionSettingsForm.txtServer.Text
            dbconnect.username = connectionSettingsForm.txtUsername.Text
            dbconnect.password = connectionSettingsForm.txtPassword.Text
            dbconnect.database = connectionSettingsForm.txtDatabase.Text


            MessageBox.Show("Connection settings updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("Connection not updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SudoSuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Profile = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblProfile = New System.Windows.Forms.Label()
        Me.out_of_sock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PctProfile2 = New System.Windows.Forms.PictureBox()
        Me.MsMenu.SuspendLayout()
        CType(Me.PctProfile2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'MsMenu
        '
        Me.MsMenu.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.StocksToolStripMenuItem, Me.SalesToolStripMenuItem, Me.AuditToolStripMenuItem, Me.PlaceOrderToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AccountsToolStripMenuItem})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Size = New System.Drawing.Size(1278, 29)
        Me.MsMenu.TabIndex = 10
        Me.MsMenu.Text = "MenuStrip1"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.prod
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.stock
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.StocksToolStripMenuItem.Text = "Stoc&ks"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.sale
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(79, 25)
        Me.SalesToolStripMenuItem.Text = "&Sales"
        '
        'AuditToolStripMenuItem
        '
        Me.AuditToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.icons8_audit_96
        Me.AuditToolStripMenuItem.Name = "AuditToolStripMenuItem"
        Me.AuditToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.AuditToolStripMenuItem.Text = "Audit"
        '
        'PlaceOrderToolStripMenuItem
        '
        Me.PlaceOrderToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.icons8_report_50
        Me.PlaceOrderToolStripMenuItem.Name = "PlaceOrderToolStripMenuItem"
        Me.PlaceOrderToolStripMenuItem.Size = New System.Drawing.Size(130, 25)
        Me.PlaceOrderToolStripMenuItem.Text = "Place Order"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.report
        Me.InventoryToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.InventoryToolStripMenuItem.Text = "Report"
        Me.InventoryToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem, Me.SudoSuToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.setin
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.SettingsToolStripMenuItem.Text = "Se&ttings"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.theme
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ThemeToolStripMenuItem.Text = "theme"
        '
        'LightToolStripMenuItem
        '
        Me.LightToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.day1
        Me.LightToolStripMenuItem.Name = "LightToolStripMenuItem"
        Me.LightToolStripMenuItem.Size = New System.Drawing.Size(119, 26)
        Me.LightToolStripMenuItem.Text = "light"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.nig
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(119, 26)
        Me.DarkToolStripMenuItem.Text = "Dark"
        '
        'SudoSuToolStripMenuItem
        '
        Me.SudoSuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditConnectionToolStripMenuItem})
        Me.SudoSuToolStripMenuItem.Name = "SudoSuToolStripMenuItem"
        Me.SudoSuToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SudoSuToolStripMenuItem.Text = "Sudo Su"
        '
        'EditConnectionToolStripMenuItem
        '
        Me.EditConnectionToolStripMenuItem.Name = "EditConnectionToolStripMenuItem"
        Me.EditConnectionToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.EditConnectionToolStripMenuItem.Text = "Edit Connection"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.AddNewUserToolStripMenuItem, Me.Profile})
        Me.AccountsToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.accout
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(111, 25)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        Me.AccountsToolStripMenuItem.ToolTipText = "logut" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.lug
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.pwd
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.accounts
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.AddNewUserToolStripMenuItem.Text = "Add new User"
        '
        'Profile
        '
        Me.Profile.Image = Global.project_Demo.My.Resources.Resources.accout
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(221, 26)
        Me.Profile.Text = "Profile"
        Me.Profile.ToolTipText = "view users"
        '
        'LblProfile
        '
        Me.LblProfile.AutoSize = True
        Me.LblProfile.BackColor = System.Drawing.Color.White
        Me.LblProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfile.Location = New System.Drawing.Point(1164, 3)
        Me.LblProfile.Name = "LblProfile"
        Me.LblProfile.Size = New System.Drawing.Size(71, 26)
        Me.LblProfile.TabIndex = 16
        Me.LblProfile.Text = "profile"
        '
        'out_of_sock
        '
        Me.out_of_sock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.out_of_sock.Icon = CType(resources.GetObject("out_of_sock.Icon"), System.Drawing.Icon)
        Me.out_of_sock.Visible = True
        '
        'PctProfile2
        '
        Me.PctProfile2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PctProfile2.Image = Global.project_Demo.My.Resources.Resources.accout
        Me.PctProfile2.Location = New System.Drawing.Point(1087, 0)
        Me.PctProfile2.Name = "PctProfile2"
        Me.PctProfile2.Size = New System.Drawing.Size(57, 29)
        Me.PctProfile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctProfile2.TabIndex = 15
        Me.PctProfile2.TabStop = False
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 691)
        Me.Controls.Add(Me.LblProfile)
        Me.Controls.Add(Me.PctProfile2)
        Me.Controls.Add(Me.MsMenu)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MsMenu
        Me.Name = "AdminHome"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Sales and Inventory System"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        CType(Me.PctProfile2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Profile As ToolStripMenuItem
    Friend WithEvents PctProfile2 As PictureBox
    Friend WithEvents LblProfile As Label
    Friend WithEvents PlaceOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SudoSuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents out_of_sock As NotifyIcon
End Class

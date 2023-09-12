<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UseHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UseHome))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PctProfile = New System.Windows.Forms.PictureBox()
        Me.LblProfile = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PctProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msPurchase, Me.msSettings, Me.msAccount})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1258, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msPurchase
        '
        Me.msPurchase.Image = Global.project_Demo.My.Resources.Resources.pur
        Me.msPurchase.Name = "msPurchase"
        Me.msPurchase.Size = New System.Drawing.Size(111, 25)
        Me.msPurchase.Text = "&Purchase"
        '
        'msSettings
        '
        Me.msSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem})
        Me.msSettings.Image = Global.project_Demo.My.Resources.Resources.setin
        Me.msSettings.Name = "msSettings"
        Me.msSettings.Size = New System.Drawing.Size(103, 25)
        Me.msSettings.Text = "&Settings"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Image = Global.project_Demo.My.Resources.Resources.theme
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.ThemeToolStripMenuItem.Text = "Theme"
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
        'msAccount
        '
        Me.msAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.msAccount.Image = Global.project_Demo.My.Resources.Resources.accout
        Me.msAccount.Name = "msAccount"
        Me.msAccount.Size = New System.Drawing.Size(111, 25)
        Me.msAccount.Text = "&Accounts"
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
        'PctProfile
        '
        Me.PctProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PctProfile.Image = Global.project_Demo.My.Resources.Resources.accout
        Me.PctProfile.Location = New System.Drawing.Point(1113, 0)
        Me.PctProfile.Name = "PctProfile"
        Me.PctProfile.Size = New System.Drawing.Size(56, 29)
        Me.PctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctProfile.TabIndex = 12
        Me.PctProfile.TabStop = False
        '
        'LblProfile
        '
        Me.LblProfile.AutoSize = True
        Me.LblProfile.BackColor = System.Drawing.Color.White
        Me.LblProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfile.Location = New System.Drawing.Point(1175, 0)
        Me.LblProfile.Name = "LblProfile"
        Me.LblProfile.Size = New System.Drawing.Size(71, 26)
        Me.LblProfile.TabIndex = 14
        Me.LblProfile.Text = "profile"
        '
        'UseHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 678)
        Me.Controls.Add(Me.LblProfile)
        Me.Controls.Add(Me.PctProfile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "UseHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sales and Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PctProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents msPurchase As ToolStripMenuItem
    Friend WithEvents msSettings As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msAccount As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PctProfile As PictureBox
    Friend WithEvents LblProfile As Label
End Class

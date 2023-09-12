<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connectionSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtServer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblServer = New System.Windows.Forms.Label()
        Me.txtDatabase = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblDB = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblUname = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTop = New Guna.UI.WinForms.GunaPanel()
        Me.LblCo = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServer.DefaultText = ""
        Me.txtServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServer.DisabledState.Parent = Me.txtServer
        Me.txtServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServer.FocusedState.Parent = Me.txtServer
        Me.txtServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServer.HoverState.Parent = Me.txtServer
        Me.txtServer.Location = New System.Drawing.Point(12, 105)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServer.PlaceholderText = ""
        Me.txtServer.SelectedText = ""
        Me.txtServer.ShadowDecoration.Parent = Me.txtServer
        Me.txtServer.Size = New System.Drawing.Size(200, 36)
        Me.txtServer.TabIndex = 0
        '
        'LblServer
        '
        Me.LblServer.AutoSize = True
        Me.LblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServer.Location = New System.Drawing.Point(18, 79)
        Me.LblServer.Name = "LblServer"
        Me.LblServer.Size = New System.Drawing.Size(74, 20)
        Me.LblServer.TabIndex = 1
        Me.LblServer.Text = "Server IP"
        '
        'txtDatabase
        '
        Me.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDatabase.DefaultText = ""
        Me.txtDatabase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDatabase.DisabledState.Parent = Me.txtDatabase
        Me.txtDatabase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDatabase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDatabase.FocusedState.Parent = Me.txtDatabase
        Me.txtDatabase.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDatabase.HoverState.Parent = Me.txtDatabase
        Me.txtDatabase.Location = New System.Drawing.Point(235, 105)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabase.PlaceholderText = ""
        Me.txtDatabase.SelectedText = ""
        Me.txtDatabase.ShadowDecoration.Parent = Me.txtDatabase
        Me.txtDatabase.Size = New System.Drawing.Size(200, 36)
        Me.txtDatabase.TabIndex = 0
        '
        'LblDB
        '
        Me.LblDB.AutoSize = True
        Me.LblDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDB.Location = New System.Drawing.Point(283, 82)
        Me.LblDB.Name = "LblDB"
        Me.LblDB.Size = New System.Drawing.Size(85, 20)
        Me.LblDB.TabIndex = 1
        Me.LblDB.Text = "Data Base"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(13, 194)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(200, 36)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(235, 194)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'LblUname
        '
        Me.LblUname.AutoSize = True
        Me.LblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUname.Location = New System.Drawing.Point(9, 168)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(89, 20)
        Me.LblUname.TabIndex = 1
        Me.LblUname.Text = "User Name"
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.Location = New System.Drawing.Point(231, 168)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(78, 20)
        Me.Lblpassword.TabIndex = 1
        Me.Lblpassword.Text = "Password"
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(235, 271)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(13, 271)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.LblCo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(455, 64)
        Me.pnlTop.TabIndex = 3
        '
        'LblCo
        '
        Me.LblCo.AutoSize = True
        Me.LblCo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCo.Location = New System.Drawing.Point(90, 19)
        Me.LblCo.Name = "LblCo"
        Me.LblCo.Size = New System.Drawing.Size(262, 31)
        Me.LblCo.TabIndex = 1
        Me.LblCo.Text = "Connection Setting"
        '
        'connectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 357)
        Me.Controls.Add(Me.LblDB)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Lblpassword)
        Me.Controls.Add(Me.LblUname)
        Me.Controls.Add(Me.LblServer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtServer)
        Me.Name = "connectionSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "connectionSettings"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblServer As Label
    Friend WithEvents txtDatabase As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblDB As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblUname As Label
    Friend WithEvents Lblpassword As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTop As Guna.UI.WinForms.GunaPanel
    Friend WithEvents LblCo As Label
End Class

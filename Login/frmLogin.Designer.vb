<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.LblUname = New System.Windows.Forms.Label()
        Me.Lblpwd = New System.Windows.Forms.Label()
        Me.pboSigin = New System.Windows.Forms.PictureBox()
        Me.Pctshop = New System.Windows.Forms.PictureBox()
        Me.loginError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtUname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtPwd = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.pboSigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pctshop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.ForeColor = System.Drawing.Color.White
        Me.LblLogin.Location = New System.Drawing.Point(394, 28)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(160, 63)
        Me.LblLogin.TabIndex = 1
        Me.LblLogin.Text = "Login"
        '
        'LblUname
        '
        Me.LblUname.AutoSize = True
        Me.LblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LblUname.Location = New System.Drawing.Point(355, 183)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(89, 20)
        Me.LblUname.TabIndex = 1
        Me.LblUname.Text = "User Name"
        '
        'Lblpwd
        '
        Me.Lblpwd.AutoSize = True
        Me.Lblpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Lblpwd.Location = New System.Drawing.Point(355, 282)
        Me.Lblpwd.Name = "Lblpwd"
        Me.Lblpwd.Size = New System.Drawing.Size(78, 20)
        Me.Lblpwd.TabIndex = 1
        Me.Lblpwd.Text = "Password"
        '
        'pboSigin
        '
        Me.pboSigin.Image = Global.project_Demo.My.Resources.Resources.si
        Me.pboSigin.Location = New System.Drawing.Point(359, 12)
        Me.pboSigin.Name = "pboSigin"
        Me.pboSigin.Size = New System.Drawing.Size(296, 157)
        Me.pboSigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboSigin.TabIndex = 5
        Me.pboSigin.TabStop = False
        '
        'Pctshop
        '
        Me.Pctshop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pctshop.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pctshop.Image = Global.project_Demo.My.Resources.Resources.trolley
        Me.Pctshop.Location = New System.Drawing.Point(0, 0)
        Me.Pctshop.Name = "Pctshop"
        Me.Pctshop.Size = New System.Drawing.Size(349, 438)
        Me.Pctshop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctshop.TabIndex = 0
        Me.Pctshop.TabStop = False
        '
        'loginError
        '
        Me.loginError.ContainerControl = Me
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLogin.CheckedState.Parent = Me.BtnLogin
        Me.BtnLogin.CustomImages.Parent = Me.BtnLogin
        Me.BtnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.HoverState.CustomBorderColor = System.Drawing.Color.Yellow
        Me.BtnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLogin.HoverState.Parent = Me.BtnLogin
        Me.BtnLogin.Location = New System.Drawing.Point(359, 381)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.ShadowDecoration.Parent = Me.BtnLogin
        Me.BtnLogin.Size = New System.Drawing.Size(123, 45)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        '
        'TxtUname
        '
        Me.TxtUname.BorderRadius = 5
        Me.TxtUname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUname.DefaultText = ""
        Me.TxtUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUname.DisabledState.Parent = Me.TxtUname
        Me.TxtUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUname.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUname.FocusedState.Parent = Me.TxtUname
        Me.TxtUname.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TxtUname.ForeColor = System.Drawing.Color.White
        Me.TxtUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUname.HoverState.Parent = Me.TxtUname
        Me.TxtUname.Location = New System.Drawing.Point(359, 206)
        Me.TxtUname.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUname.PlaceholderForeColor = System.Drawing.Color.White
        Me.TxtUname.PlaceholderText = ""
        Me.TxtUname.SelectedText = ""
        Me.TxtUname.ShadowDecoration.Parent = Me.TxtUname
        Me.TxtUname.Size = New System.Drawing.Size(279, 51)
        Me.TxtUname.TabIndex = 8
        Me.TxtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.CustomImages.Parent = Me.btnExit
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Location = New System.Drawing.Point(515, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ShadowDecoration.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(123, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        '
        'TxtPwd
        '
        Me.TxtPwd.BorderRadius = 5
        Me.TxtPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPwd.DefaultText = ""
        Me.TxtPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPwd.DisabledState.Parent = Me.TxtPwd
        Me.TxtPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPwd.FocusedState.Parent = Me.TxtPwd
        Me.TxtPwd.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TxtPwd.ForeColor = System.Drawing.Color.White
        Me.TxtPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPwd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPwd.HoverState.Parent = Me.TxtPwd
        Me.TxtPwd.Location = New System.Drawing.Point(359, 305)
        Me.TxtPwd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPwd.PlaceholderText = ""
        Me.TxtPwd.SelectedText = ""
        Me.TxtPwd.ShadowDecoration.Parent = Me.TxtPwd
        Me.TxtPwd.Size = New System.Drawing.Size(279, 51)
        Me.TxtPwd.TabIndex = 9
        Me.TxtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPwd.UseSystemPasswordChar = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 438)
        Me.Controls.Add(Me.TxtPwd)
        Me.Controls.Add(Me.TxtUname)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.pboSigin)
        Me.Controls.Add(Me.Lblpwd)
        Me.Controls.Add(Me.LblUname)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.Pctshop)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pboSigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pctshop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pctshop As PictureBox
    Friend WithEvents LblLogin As Label
    Friend WithEvents LblUname As Label
    Friend WithEvents Lblpwd As Label
    Friend WithEvents pboSigin As PictureBox
    Friend WithEvents loginError As ErrorProvider
    Friend WithEvents TxtUname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPwd As Guna.UI2.WinForms.Guna2TextBox
End Class

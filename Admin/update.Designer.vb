<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnUBack = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnURegister = New Guna.UI2.WinForms.Guna2Button()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblUFname = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblLName = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.topP = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.ErrorUpdate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.topP.SuspendLayout()
        CType(Me.ErrorUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUphone
        '
        Me.txtUphone.BackColor = System.Drawing.Color.White
        Me.txtUphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUphone.DefaultText = ""
        Me.txtUphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUphone.DisabledState.Parent = Me.txtUphone
        Me.txtUphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUphone.FocusedState.Parent = Me.txtUphone
        Me.txtUphone.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUphone.HoverState.Parent = Me.txtUphone
        Me.txtUphone.Location = New System.Drawing.Point(250, 229)
        Me.txtUphone.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtUphone.MaxLength = 10
        Me.txtUphone.Name = "txtUphone"
        Me.txtUphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUphone.PlaceholderText = ""
        Me.txtUphone.SelectedText = ""
        Me.txtUphone.ShadowDecoration.Parent = Me.txtUphone
        Me.txtUphone.Size = New System.Drawing.Size(226, 36)
        Me.txtUphone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUphone.TabIndex = 9
        Me.txtUphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUemail
        '
        Me.txtUemail.BackColor = System.Drawing.Color.White
        Me.txtUemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUemail.DefaultText = ""
        Me.txtUemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUemail.DisabledState.Parent = Me.txtUemail
        Me.txtUemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUemail.FocusedState.Parent = Me.txtUemail
        Me.txtUemail.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUemail.HoverState.Parent = Me.txtUemail
        Me.txtUemail.Location = New System.Drawing.Point(22, 228)
        Me.txtUemail.Margin = New System.Windows.Forms.Padding(15, 13, 15, 13)
        Me.txtUemail.Name = "txtUemail"
        Me.txtUemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUemail.PlaceholderText = ""
        Me.txtUemail.SelectedText = ""
        Me.txtUemail.ShadowDecoration.Parent = Me.txtUemail
        Me.txtUemail.Size = New System.Drawing.Size(214, 37)
        Me.txtUemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUemail.TabIndex = 8
        Me.txtUemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUfname
        '
        Me.txtUfname.BackColor = System.Drawing.Color.White
        Me.txtUfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUfname.DefaultText = ""
        Me.txtUfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUfname.DisabledState.Parent = Me.txtUfname
        Me.txtUfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUfname.FocusedState.Parent = Me.txtUfname
        Me.txtUfname.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUfname.HoverState.Parent = Me.txtUfname
        Me.txtUfname.Location = New System.Drawing.Point(22, 139)
        Me.txtUfname.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtUfname.Name = "txtUfname"
        Me.txtUfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUfname.PlaceholderText = ""
        Me.txtUfname.SelectedText = ""
        Me.txtUfname.ShadowDecoration.Parent = Me.txtUfname
        Me.txtUfname.Size = New System.Drawing.Size(214, 37)
        Me.txtUfname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUfname.TabIndex = 7
        Me.txtUfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUlname
        '
        Me.txtUlname.BackColor = System.Drawing.Color.White
        Me.txtUlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUlname.DefaultText = ""
        Me.txtUlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUlname.DisabledState.Parent = Me.txtUlname
        Me.txtUlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUlname.FocusedState.Parent = Me.txtUlname
        Me.txtUlname.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUlname.HoverState.Parent = Me.txtUlname
        Me.txtUlname.Location = New System.Drawing.Point(250, 139)
        Me.txtUlname.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtUlname.Name = "txtUlname"
        Me.txtUlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUlname.PlaceholderText = ""
        Me.txtUlname.SelectedText = ""
        Me.txtUlname.ShadowDecoration.Parent = Me.txtUlname
        Me.txtUlname.Size = New System.Drawing.Size(226, 37)
        Me.txtUlname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUlname.TabIndex = 7
        Me.txtUlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnUBack
        '
        Me.BtnUBack.BorderColor = System.Drawing.Color.White
        Me.BtnUBack.BorderRadius = 10
        Me.BtnUBack.BorderThickness = 1
        Me.BtnUBack.CheckedState.Parent = Me.BtnUBack
        Me.BtnUBack.CustomImages.Parent = Me.BtnUBack
        Me.BtnUBack.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnUBack.FillColor = System.Drawing.Color.Teal
        Me.BtnUBack.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUBack.ForeColor = System.Drawing.Color.White
        Me.BtnUBack.HoverState.Parent = Me.BtnUBack
        Me.BtnUBack.Location = New System.Drawing.Point(250, 306)
        Me.BtnUBack.Name = "BtnUBack"
        Me.BtnUBack.ShadowDecoration.Parent = Me.BtnUBack
        Me.BtnUBack.Size = New System.Drawing.Size(176, 35)
        Me.BtnUBack.TabIndex = 6
        Me.BtnUBack.Text = "Back"
        '
        'BtnURegister
        '
        Me.BtnURegister.BorderColor = System.Drawing.Color.White
        Me.BtnURegister.BorderRadius = 10
        Me.BtnURegister.BorderThickness = 1
        Me.BtnURegister.CheckedState.Parent = Me.BtnURegister
        Me.BtnURegister.CustomImages.Parent = Me.BtnURegister
        Me.BtnURegister.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnURegister.FillColor = System.Drawing.Color.Teal
        Me.BtnURegister.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnURegister.ForeColor = System.Drawing.Color.White
        Me.BtnURegister.HoverState.Parent = Me.BtnURegister
        Me.BtnURegister.Location = New System.Drawing.Point(72, 306)
        Me.BtnURegister.Name = "BtnURegister"
        Me.BtnURegister.ShadowDecoration.Parent = Me.BtnURegister
        Me.BtnURegister.Size = New System.Drawing.Size(164, 35)
        Me.BtnURegister.TabIndex = 6
        Me.BtnURegister.Text = "Save"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.ForeColor = System.Drawing.Color.White
        Me.LblPhone.Location = New System.Drawing.Point(253, 194)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(79, 25)
        Me.LblPhone.TabIndex = 7
        Me.LblPhone.Text = "Phone"
        '
        'LblUFname
        '
        Me.LblUFname.AutoSize = True
        Me.LblUFname.BackColor = System.Drawing.Color.Transparent
        Me.LblUFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUFname.ForeColor = System.Drawing.Color.White
        Me.LblUFname.Location = New System.Drawing.Point(19, 105)
        Me.LblUFname.Name = "LblUFname"
        Me.LblUFname.Size = New System.Drawing.Size(126, 25)
        Me.LblUFname.TabIndex = 1
        Me.LblUFname.Text = "First Name"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(19, 194)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(70, 25)
        Me.LblEmail.TabIndex = 1
        Me.LblEmail.Text = "Email"
        '
        'LblLName
        '
        Me.LblLName.AutoSize = True
        Me.LblLName.BackColor = System.Drawing.Color.Transparent
        Me.LblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLName.ForeColor = System.Drawing.Color.White
        Me.LblLName.Location = New System.Drawing.Point(245, 105)
        Me.LblLName.Name = "LblLName"
        Me.LblLName.Size = New System.Drawing.Size(124, 25)
        Me.LblLName.TabIndex = 1
        Me.LblLName.Text = "Last Name"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Panel1)
        Me.Guna2Panel2.Controls.Add(Me.topP)
        Me.Guna2Panel2.Controls.Add(Me.LblPhone)
        Me.Guna2Panel2.Controls.Add(Me.txtUphone)
        Me.Guna2Panel2.Controls.Add(Me.txtUemail)
        Me.Guna2Panel2.Controls.Add(Me.txtUfname)
        Me.Guna2Panel2.Controls.Add(Me.txtUlname)
        Me.Guna2Panel2.Controls.Add(Me.BtnUBack)
        Me.Guna2Panel2.Controls.Add(Me.BtnURegister)
        Me.Guna2Panel2.Controls.Add(Me.LblUFname)
        Me.Guna2Panel2.Controls.Add(Me.LblLName)
        Me.Guna2Panel2.Controls.Add(Me.LblEmail)
        Me.Guna2Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(487, 394)
        Me.Guna2Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-22, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 17)
        Me.Panel1.TabIndex = 11
        '
        'topP
        '
        Me.topP.BackColor = System.Drawing.Color.Teal
        Me.topP.Controls.Add(Me.LblInfo)
        Me.topP.CustomBorderColor = System.Drawing.Color.White
        Me.topP.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.topP.Dock = System.Windows.Forms.DockStyle.Top
        Me.topP.ForeColor = System.Drawing.Color.White
        Me.topP.Location = New System.Drawing.Point(0, 0)
        Me.topP.Name = "topP"
        Me.topP.ShadowDecoration.Parent = Me.topP
        Me.topP.Size = New System.Drawing.Size(487, 71)
        Me.topP.TabIndex = 10
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.White
        Me.LblInfo.Location = New System.Drawing.Point(143, -5)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(295, 55)
        Me.LblInfo.TabIndex = 0
        Me.LblInfo.Text = "Update User"
        '
        'ErrorUpdate
        '
        Me.ErrorUpdate.ContainerControl = Me
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 394)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "update"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "update"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.topP.ResumeLayout(False)
        Me.topP.PerformLayout()
        CType(Me.ErrorUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnUBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnURegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblUFname As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblLName As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents topP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblInfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorUpdate As ErrorProvider
End Class

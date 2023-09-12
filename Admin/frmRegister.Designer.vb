<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.LblFname = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblUname = New System.Windows.Forms.Label()
        Me.cmbRrole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LblRole = New System.Windows.Forms.Label()
        Me.pnlRtop = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtRuname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.txtRphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbgender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlRtop.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.BackColor = System.Drawing.Color.Transparent
        Me.LblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.ForeColor = System.Drawing.Color.White
        Me.LblPass.Location = New System.Drawing.Point(300, 206)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(114, 25)
        Me.LblPass.TabIndex = 1
        Me.LblPass.Text = "Password"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(300, 32)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(124, 25)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Last Name"
        '
        'LblRegister
        '
        Me.LblRegister.AutoSize = True
        Me.LblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegister.ForeColor = System.Drawing.Color.White
        Me.LblRegister.Location = New System.Drawing.Point(105, 0)
        Me.LblRegister.Name = "LblRegister"
        Me.LblRegister.Size = New System.Drawing.Size(388, 76)
        Me.LblRegister.TabIndex = 1
        Me.LblRegister.Text = "Registration"
        '
        'LblFname
        '
        Me.LblFname.AutoSize = True
        Me.LblFname.BackColor = System.Drawing.Color.Transparent
        Me.LblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFname.ForeColor = System.Drawing.Color.White
        Me.LblFname.Location = New System.Drawing.Point(19, 32)
        Me.LblFname.Name = "LblFname"
        Me.LblFname.Size = New System.Drawing.Size(126, 25)
        Me.LblFname.TabIndex = 1
        Me.LblFname.Text = "First Name"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(17, 114)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(70, 25)
        Me.LblEmail.TabIndex = 1
        Me.LblEmail.Text = "Email"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.ForeColor = System.Drawing.Color.White
        Me.LblPhone.Location = New System.Drawing.Point(300, 115)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(79, 25)
        Me.LblPhone.TabIndex = 1
        Me.LblPhone.Text = "Phone"
        '
        'LblUname
        '
        Me.LblUname.AutoSize = True
        Me.LblUname.BackColor = System.Drawing.Color.Transparent
        Me.LblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUname.ForeColor = System.Drawing.Color.White
        Me.LblUname.Location = New System.Drawing.Point(19, 206)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(128, 25)
        Me.LblUname.TabIndex = 1
        Me.LblUname.Text = "User Name"
        '
        'cmbRrole
        '
        Me.cmbRrole.BackColor = System.Drawing.Color.Transparent
        Me.cmbRrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRrole.FocusedColor = System.Drawing.Color.Empty
        Me.cmbRrole.FocusedState.Parent = Me.cmbRrole
        Me.cmbRrole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbRrole.FormattingEnabled = True
        Me.cmbRrole.HoverState.Parent = Me.cmbRrole
        Me.cmbRrole.ItemHeight = 30
        Me.cmbRrole.Items.AddRange(New Object() {"Admin", "user", "Manger"})
        Me.cmbRrole.ItemsAppearance.Parent = Me.cmbRrole
        Me.cmbRrole.Location = New System.Drawing.Point(305, 324)
        Me.cmbRrole.Name = "cmbRrole"
        Me.cmbRrole.ShadowDecoration.Parent = Me.cmbRrole
        Me.cmbRrole.Size = New System.Drawing.Size(226, 36)
        Me.cmbRrole.TabIndex = 5
        '
        'LblRole
        '
        Me.LblRole.AutoSize = True
        Me.LblRole.BackColor = System.Drawing.Color.Transparent
        Me.LblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRole.ForeColor = System.Drawing.Color.White
        Me.LblRole.Location = New System.Drawing.Point(300, 290)
        Me.LblRole.Name = "LblRole"
        Me.LblRole.Size = New System.Drawing.Size(60, 25)
        Me.LblRole.TabIndex = 1
        Me.LblRole.Text = "Role"
        '
        'pnlRtop
        '
        Me.pnlRtop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlRtop.Controls.Add(Me.LblRegister)
        Me.pnlRtop.CustomBorderColor = System.Drawing.Color.White
        Me.pnlRtop.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.pnlRtop.Location = New System.Drawing.Point(0, 0)
        Me.pnlRtop.Name = "pnlRtop"
        Me.pnlRtop.ShadowDecoration.Parent = Me.pnlRtop
        Me.pnlRtop.Size = New System.Drawing.Size(514, 100)
        Me.pnlRtop.TabIndex = 6
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.txtRuname)
        Me.pnlBody.Controls.Add(Me.LblPhone)
        Me.pnlBody.Controls.Add(Me.txtRpass)
        Me.pnlBody.Controls.Add(Me.LblGender)
        Me.pnlBody.Controls.Add(Me.LblRole)
        Me.pnlBody.Controls.Add(Me.txtRphone)
        Me.pnlBody.Controls.Add(Me.LblPass)
        Me.pnlBody.Controls.Add(Me.txtRemail)
        Me.pnlBody.Controls.Add(Me.txtRfname)
        Me.pnlBody.Controls.Add(Me.txtRlname)
        Me.pnlBody.Controls.Add(Me.BtnBack)
        Me.pnlBody.Controls.Add(Me.BtnRegister)
        Me.pnlBody.Controls.Add(Me.LblFname)
        Me.pnlBody.Controls.Add(Me.cmbgender)
        Me.pnlBody.Controls.Add(Me.cmbRrole)
        Me.pnlBody.Controls.Add(Me.LblName)
        Me.pnlBody.Controls.Add(Me.LblEmail)
        Me.pnlBody.Controls.Add(Me.LblUname)
        Me.pnlBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBody.Location = New System.Drawing.Point(0, 88)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.ShadowDecoration.Parent = Me.pnlBody
        Me.pnlBody.Size = New System.Drawing.Size(569, 477)
        Me.pnlBody.TabIndex = 2
        '
        'txtRuname
        '
        Me.txtRuname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRuname.DefaultText = ""
        Me.txtRuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRuname.DisabledState.Parent = Me.txtRuname
        Me.txtRuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRuname.FocusedState.Parent = Me.txtRuname
        Me.txtRuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRuname.HoverState.Parent = Me.txtRuname
        Me.txtRuname.Location = New System.Drawing.Point(22, 240)
        Me.txtRuname.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRuname.Name = "txtRuname"
        Me.txtRuname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRuname.PlaceholderText = ""
        Me.txtRuname.SelectedText = ""
        Me.txtRuname.ShadowDecoration.Parent = Me.txtRuname
        Me.txtRuname.Size = New System.Drawing.Size(215, 37)
        Me.txtRuname.TabIndex = 10
        '
        'txtRpass
        '
        Me.txtRpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRpass.DefaultText = ""
        Me.txtRpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRpass.DisabledState.Parent = Me.txtRpass
        Me.txtRpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRpass.FocusedState.Parent = Me.txtRpass
        Me.txtRpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRpass.HoverState.Parent = Me.txtRpass
        Me.txtRpass.Location = New System.Drawing.Point(306, 238)
        Me.txtRpass.Margin = New System.Windows.Forms.Padding(15, 13, 15, 13)
        Me.txtRpass.Name = "txtRpass"
        Me.txtRpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRpass.PlaceholderText = ""
        Me.txtRpass.SelectedText = ""
        Me.txtRpass.ShadowDecoration.Parent = Me.txtRpass
        Me.txtRpass.Size = New System.Drawing.Size(225, 37)
        Me.txtRpass.TabIndex = 9
        Me.txtRpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.BackColor = System.Drawing.Color.Transparent
        Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGender.ForeColor = System.Drawing.Color.White
        Me.LblGender.Location = New System.Drawing.Point(19, 290)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(89, 25)
        Me.LblGender.TabIndex = 1
        Me.LblGender.Text = "Gender"
        '
        'txtRphone
        '
        Me.txtRphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRphone.DefaultText = ""
        Me.txtRphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRphone.DisabledState.Parent = Me.txtRphone
        Me.txtRphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRphone.FocusedState.Parent = Me.txtRphone
        Me.txtRphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRphone.HoverState.Parent = Me.txtRphone
        Me.txtRphone.Location = New System.Drawing.Point(306, 148)
        Me.txtRphone.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRphone.MaxLength = 10
        Me.txtRphone.Name = "txtRphone"
        Me.txtRphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRphone.PlaceholderText = ""
        Me.txtRphone.SelectedText = ""
        Me.txtRphone.ShadowDecoration.Parent = Me.txtRphone
        Me.txtRphone.Size = New System.Drawing.Size(225, 37)
        Me.txtRphone.TabIndex = 9
        '
        'txtRemail
        '
        Me.txtRemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRemail.DefaultText = ""
        Me.txtRemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemail.DisabledState.Parent = Me.txtRemail
        Me.txtRemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemail.FocusedState.Parent = Me.txtRemail
        Me.txtRemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemail.HoverState.Parent = Me.txtRemail
        Me.txtRemail.Location = New System.Drawing.Point(22, 148)
        Me.txtRemail.Margin = New System.Windows.Forms.Padding(15, 13, 15, 13)
        Me.txtRemail.Name = "txtRemail"
        Me.txtRemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemail.PlaceholderText = ""
        Me.txtRemail.SelectedText = ""
        Me.txtRemail.ShadowDecoration.Parent = Me.txtRemail
        Me.txtRemail.Size = New System.Drawing.Size(215, 37)
        Me.txtRemail.TabIndex = 8
        '
        'txtRfname
        '
        Me.txtRfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRfname.DefaultText = ""
        Me.txtRfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRfname.DisabledState.Parent = Me.txtRfname
        Me.txtRfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRfname.FocusedState.Parent = Me.txtRfname
        Me.txtRfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRfname.HoverState.Parent = Me.txtRfname
        Me.txtRfname.Location = New System.Drawing.Point(22, 65)
        Me.txtRfname.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRfname.Name = "txtRfname"
        Me.txtRfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRfname.PlaceholderText = ""
        Me.txtRfname.SelectedText = ""
        Me.txtRfname.ShadowDecoration.Parent = Me.txtRfname
        Me.txtRfname.Size = New System.Drawing.Size(215, 37)
        Me.txtRfname.TabIndex = 7
        '
        'txtRlname
        '
        Me.txtRlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRlname.DefaultText = ""
        Me.txtRlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRlname.DisabledState.Parent = Me.txtRlname
        Me.txtRlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRlname.FocusedState.Parent = Me.txtRlname
        Me.txtRlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRlname.HoverState.Parent = Me.txtRlname
        Me.txtRlname.Location = New System.Drawing.Point(306, 71)
        Me.txtRlname.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRlname.Name = "txtRlname"
        Me.txtRlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRlname.PlaceholderText = ""
        Me.txtRlname.SelectedText = ""
        Me.txtRlname.ShadowDecoration.Parent = Me.txtRlname
        Me.txtRlname.Size = New System.Drawing.Size(225, 37)
        Me.txtRlname.TabIndex = 7
        '
        'BtnBack
        '
        Me.BtnBack.CheckedState.Parent = Me.BtnBack
        Me.BtnBack.CustomImages.Parent = Me.BtnBack
        Me.BtnBack.FillColor = System.Drawing.Color.Teal
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.HoverState.Parent = Me.BtnBack
        Me.BtnBack.Location = New System.Drawing.Point(322, 399)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.ShadowDecoration.Parent = Me.BtnBack
        Me.BtnBack.Size = New System.Drawing.Size(209, 41)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        '
        'BtnRegister
        '
        Me.BtnRegister.CheckedState.Parent = Me.BtnRegister
        Me.BtnRegister.CustomImages.Parent = Me.BtnRegister
        Me.BtnRegister.FillColor = System.Drawing.Color.Teal
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.HoverState.Parent = Me.BtnRegister
        Me.BtnRegister.Location = New System.Drawing.Point(22, 399)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.ShadowDecoration.Parent = Me.BtnRegister
        Me.BtnRegister.Size = New System.Drawing.Size(214, 41)
        Me.BtnRegister.TabIndex = 6
        Me.BtnRegister.Text = "Save"
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.Color.Transparent
        Me.cmbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbgender.FocusedState.Parent = Me.cmbgender
        Me.cmbgender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.HoverState.Parent = Me.cmbgender
        Me.cmbgender.ItemHeight = 30
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.ItemsAppearance.Parent = Me.cmbgender
        Me.cmbgender.Location = New System.Drawing.Point(22, 321)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.ShadowDecoration.Parent = Me.cmbgender
        Me.cmbgender.Size = New System.Drawing.Size(214, 36)
        Me.cmbgender.TabIndex = 5
        Me.cmbgender.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 550)
        Me.Controls.Add(Me.pnlRtop)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegister"
        Me.pnlRtop.ResumeLayout(False)
        Me.pnlRtop.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblPass As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblRegister As Label
    Friend WithEvents LblFname As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblUname As Label
    Friend WithEvents cmbRrole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LblRole As Label
    Friend WithEvents pnlRtop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtRlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRuname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblGender As Label
    Friend WithEvents cmbgender As Guna.UI2.WinForms.Guna2ComboBox
End Class

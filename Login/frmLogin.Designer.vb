<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.PnLBack = New System.Windows.Forms.Panel()
        Me.PnlDetails = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPaswd = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.TxtPaswd = New System.Windows.Forms.TextBox()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.Lblventures = New System.Windows.Forms.Label()
        Me.LblCk = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PnLBack.SuspendLayout()
        Me.PnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnLBack
        '
        Me.PnLBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnLBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PnLBack.BackColor = System.Drawing.Color.Aquamarine
        Me.PnLBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnLBack.Controls.Add(Me.PnlDetails)
        Me.PnLBack.Controls.Add(Me.Lblventures)
        Me.PnLBack.Controls.Add(Me.LblCk)
        Me.PnLBack.Location = New System.Drawing.Point(6, 3)
        Me.PnLBack.Name = "PnLBack"
        Me.PnLBack.Size = New System.Drawing.Size(726, 501)
        Me.PnLBack.TabIndex = 0
        '
        'PnlDetails
        '
        Me.PnlDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PnlDetails.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PnlDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlDetails.Controls.Add(Me.BtnExit)
        Me.PnlDetails.Controls.Add(Me.BtnLogin)
        Me.PnlDetails.Controls.Add(Me.LblPaswd)
        Me.PnlDetails.Controls.Add(Me.LblUserName)
        Me.PnlDetails.Controls.Add(Me.LblLogin)
        Me.PnlDetails.Controls.Add(Me.TxtPaswd)
        Me.PnlDetails.Controls.Add(Me.TxtUname)
        Me.PnlDetails.Location = New System.Drawing.Point(335, -2)
        Me.PnlDetails.Name = "PnlDetails"
        Me.PnlDetails.Size = New System.Drawing.Size(389, 498)
        Me.PnlDetails.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Location = New System.Drawing.Point(215, 346)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 40)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseCompatibleTextRendering = True
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLogin.Location = New System.Drawing.Point(65, 346)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(83, 40)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseCompatibleTextRendering = True
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LblPaswd
        '
        Me.LblPaswd.AutoSize = True
        Me.LblPaswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaswd.Location = New System.Drawing.Point(76, 254)
        Me.LblPaswd.Name = "LblPaswd"
        Me.LblPaswd.Size = New System.Drawing.Size(98, 25)
        Me.LblPaswd.TabIndex = 2
        Me.LblPaswd.Text = "Password"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(76, 162)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(102, 25)
        Me.LblUserName.TabIndex = 2
        Me.LblUserName.Text = "Username"
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Elephant", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.Location = New System.Drawing.Point(60, 41)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(238, 87)
        Me.LblLogin.TabIndex = 1
        Me.LblLogin.Text = "Login"
        '
        'TxtPaswd
        '
        Me.TxtPaswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaswd.Location = New System.Drawing.Point(65, 282)
        Me.TxtPaswd.Name = "TxtPaswd"
        Me.TxtPaswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPaswd.Size = New System.Drawing.Size(233, 32)
        Me.TxtPaswd.TabIndex = 0
        Me.TxtPaswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPaswd.UseSystemPasswordChar = True
        '
        'TxtUname
        '
        Me.TxtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUname.Location = New System.Drawing.Point(65, 190)
        Me.TxtUname.Name = "TxtUname"
        Me.TxtUname.Size = New System.Drawing.Size(233, 32)
        Me.TxtUname.TabIndex = 0
        Me.TxtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lblventures
        '
        Me.Lblventures.AutoSize = True
        Me.Lblventures.Font = New System.Drawing.Font("Elephant", 47.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblventures.Location = New System.Drawing.Point(6, 233)
        Me.Lblventures.Name = "Lblventures"
        Me.Lblventures.Size = New System.Drawing.Size(325, 81)
        Me.Lblventures.TabIndex = 2
        Me.Lblventures.Text = "Ventures"
        '
        'LblCk
        '
        Me.LblCk.AutoSize = True
        Me.LblCk.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCk.Location = New System.Drawing.Point(21, 49)
        Me.LblCk.Name = "LblCk"
        Me.LblCk.Size = New System.Drawing.Size(308, 185)
        Me.LblCk.TabIndex = 2
        Me.LblCk.Text = "CK"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.MintCream
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(352, 498)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(735, 504)
        Me.Controls.Add(Me.PnLBack)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnLBack.ResumeLayout(False)
        Me.PnLBack.PerformLayout()
        Me.PnlDetails.ResumeLayout(False)
        Me.PnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnLBack As Panel
    Friend WithEvents PnlDetails As Panel
    Friend WithEvents TxtPaswd As TextBox
    Friend WithEvents TxtUname As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LblPaswd As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblLogin As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Lblventures As Label
    Friend WithEvents LblCk As Label
End Class

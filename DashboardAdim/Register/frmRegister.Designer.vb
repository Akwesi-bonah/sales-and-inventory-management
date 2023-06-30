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
        Me.PnlBack = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlFront = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.PnlBack.SuspendLayout()
        Me.PnlFront.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBack
        '
        Me.PnlBack.BackColor = System.Drawing.Color.White
        Me.PnlBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBack.Controls.Add(Me.BtnBack)
        Me.PnlBack.Controls.Add(Me.Label2)
        Me.PnlBack.Controls.Add(Me.PnlFront)
        Me.PnlBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlBack.Location = New System.Drawing.Point(0, 0)
        Me.PnlBack.Name = "PnlBack"
        Me.PnlBack.Size = New System.Drawing.Size(521, 450)
        Me.PnlBack.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Silver
        Me.BtnBack.Location = New System.Drawing.Point(51, 411)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(398, 37)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(61, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration"
        '
        'PnlFront
        '
        Me.PnlFront.BackColor = System.Drawing.Color.Snow
        Me.PnlFront.Controls.Add(Me.Label1)
        Me.PnlFront.Controls.Add(Me.CmbRole)
        Me.PnlFront.Controls.Add(Me.Label3)
        Me.PnlFront.Controls.Add(Me.LblName)
        Me.PnlFront.Controls.Add(Me.BtnRegister)
        Me.PnlFront.Controls.Add(Me.TxtPwd)
        Me.PnlFront.Controls.Add(Me.TxtName)
        Me.PnlFront.Location = New System.Drawing.Point(51, 77)
        Me.PnlFront.Name = "PnlFront"
        Me.PnlFront.Size = New System.Drawing.Size(398, 313)
        Me.PnlFront.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Role"
        '
        'CmbRole
        '
        Me.CmbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRole.FormattingEnabled = True
        Me.CmbRole.Items.AddRange(New Object() {"Manager", "User"})
        Me.CmbRole.Location = New System.Drawing.Point(73, 208)
        Me.CmbRole.Name = "CmbRole"
        Me.CmbRole.Size = New System.Drawing.Size(252, 28)
        Me.CmbRole.Sorted = True
        Me.CmbRole.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(82, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblName.Location = New System.Drawing.Point(82, 31)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(100, 22)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "User Name"
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnRegister.Location = New System.Drawing.Point(0, 275)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(398, 38)
        Me.BtnRegister.TabIndex = 1
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'TxtPwd
        '
        Me.TxtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwd.Location = New System.Drawing.Point(73, 117)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.Size = New System.Drawing.Size(252, 27)
        Me.TxtPwd.TabIndex = 0
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(73, 56)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(252, 27)
        Me.TxtName.TabIndex = 0
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 450)
        Me.Controls.Add(Me.PnlBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegister"
        Me.PnlBack.ResumeLayout(False)
        Me.PnlBack.PerformLayout()
        Me.PnlFront.ResumeLayout(False)
        Me.PnlFront.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBack As Panel
    Friend WithEvents LblName As Label
    Friend WithEvents PnlFront As Panel
    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPwd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbRole As ComboBox
    Friend WithEvents BtnBack As Button
End Class

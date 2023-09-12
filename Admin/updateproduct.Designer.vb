<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateproduct
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtNewName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblInfor = New System.Windows.Forms.Label()
        Me.txtnewInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Teal
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.OK_Button.Location = New System.Drawing.Point(63, 214)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(94, 34)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Cancel_Button.Location = New System.Drawing.Point(169, 214)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(104, 34)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(28, 49)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Product Name"
        '
        'txtNewName
        '
        Me.txtNewName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewName.DefaultText = ""
        Me.txtNewName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewName.DisabledState.Parent = Me.txtNewName
        Me.txtNewName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewName.FocusedState.Parent = Me.txtNewName
        Me.txtNewName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewName.HoverState.Parent = Me.txtNewName
        Me.txtNewName.Location = New System.Drawing.Point(28, 82)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewName.PlaceholderText = "New  Name"
        Me.txtNewName.SelectedText = ""
        Me.txtNewName.ShadowDecoration.Parent = Me.txtNewName
        Me.txtNewName.Size = New System.Drawing.Size(256, 35)
        Me.txtNewName.TabIndex = 4
        '
        'LblInfor
        '
        Me.LblInfor.AutoSize = True
        Me.LblInfor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfor.ForeColor = System.Drawing.Color.White
        Me.LblInfor.Location = New System.Drawing.Point(28, 126)
        Me.LblInfor.Name = "LblInfor"
        Me.LblInfor.Size = New System.Drawing.Size(104, 24)
        Me.LblInfor.TabIndex = 3
        Me.LblInfor.Text = "Description"
        '
        'txtnewInfo
        '
        Me.txtnewInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewInfo.DefaultText = ""
        Me.txtnewInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnewInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnewInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewInfo.DisabledState.Parent = Me.txtnewInfo
        Me.txtnewInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewInfo.FocusedState.Parent = Me.txtnewInfo
        Me.txtnewInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewInfo.HoverState.Parent = Me.txtnewInfo
        Me.txtnewInfo.Location = New System.Drawing.Point(27, 155)
        Me.txtnewInfo.Name = "txtnewInfo"
        Me.txtnewInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnewInfo.PlaceholderText = "Information about Product"
        Me.txtnewInfo.SelectedText = ""
        Me.txtnewInfo.ShadowDecoration.Parent = Me.txtnewInfo
        Me.txtnewInfo.Size = New System.Drawing.Size(256, 35)
        Me.txtnewInfo.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-2, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 169)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(-9, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 31)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(8, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 31)
        Me.Panel3.TabIndex = 7
        '
        'updateproduct
        '
        Me.AcceptButton = Me.OK_Button
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(328, 311)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtnewInfo)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.LblInfor)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "updateproduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtNewName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblInfor As Label
    Friend WithEvents txtnewInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class

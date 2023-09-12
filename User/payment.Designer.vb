<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Lbldue = New System.Windows.Forms.Label()
        Me.txtpayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblDent = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.txtDue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Teal
        Me.OK_Button.Location = New System.Drawing.Point(18, 192)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(79, 44)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(130, 192)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(90, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Lbldue
        '
        Me.Lbldue.AutoSize = True
        Me.Lbldue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldue.ForeColor = System.Drawing.Color.White
        Me.Lbldue.Location = New System.Drawing.Point(12, 18)
        Me.Lbldue.Name = "Lbldue"
        Me.Lbldue.Size = New System.Drawing.Size(109, 22)
        Me.Lbldue.TabIndex = 3
        Me.Lbldue.Text = "Due Amount"
        '
        'txtpayment
        '
        Me.txtpayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayment.DefaultText = ""
        Me.txtpayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpayment.DisabledState.Parent = Me.txtpayment
        Me.txtpayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpayment.FocusedState.Parent = Me.txtpayment
        Me.txtpayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpayment.HoverState.Parent = Me.txtpayment
        Me.txtpayment.Location = New System.Drawing.Point(18, 83)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpayment.PlaceholderText = ""
        Me.txtpayment.SelectedText = ""
        Me.txtpayment.ShadowDecoration.Parent = Me.txtpayment
        Me.txtpayment.Size = New System.Drawing.Size(202, 31)
        Me.txtpayment.TabIndex = 2
        '
        'LblDent
        '
        Me.LblDent.AutoSize = True
        Me.LblDent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDent.ForeColor = System.Drawing.Color.White
        Me.LblDent.Location = New System.Drawing.Point(14, 58)
        Me.LblDent.Name = "LblDent"
        Me.LblDent.Size = New System.Drawing.Size(71, 22)
        Me.LblDent.TabIndex = 3
        Me.LblDent.Text = "Amount"
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.ForeColor = System.Drawing.Color.White
        Me.LblBalance.Location = New System.Drawing.Point(14, 143)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(85, 22)
        Me.LblBalance.TabIndex = 3
        Me.LblBalance.Text = "Balance :"
        '
        'txtDue
        '
        Me.txtDue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDue.DefaultText = ""
        Me.txtDue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDue.DisabledState.Parent = Me.txtDue
        Me.txtDue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDue.FocusedState.Parent = Me.txtDue
        Me.txtDue.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDue.HoverState.Parent = Me.txtDue
        Me.txtDue.Location = New System.Drawing.Point(130, 18)
        Me.txtDue.Name = "txtDue"
        Me.txtDue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDue.PlaceholderText = ""
        Me.txtDue.ReadOnly = True
        Me.txtDue.SelectedText = ""
        Me.txtDue.ShadowDecoration.Parent = Me.txtDue
        Me.txtDue.Size = New System.Drawing.Size(90, 31)
        Me.txtDue.TabIndex = 2
        '
        'txtbalance
        '
        Me.txtbalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbalance.DefaultText = ""
        Me.txtbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbalance.DisabledState.Parent = Me.txtbalance
        Me.txtbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbalance.FocusedState.Parent = Me.txtbalance
        Me.txtbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbalance.HoverState.Parent = Me.txtbalance
        Me.txtbalance.Location = New System.Drawing.Point(130, 134)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbalance.PlaceholderText = ""
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.SelectedText = ""
        Me.txtbalance.ShadowDecoration.Parent = Me.txtbalance
        Me.txtbalance.Size = New System.Drawing.Size(90, 31)
        Me.txtbalance.TabIndex = 2
        '
        'pError
        '
        Me.pError.ContainerControl = Me
        '
        'payment
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(252, 248)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.LblDent)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txtDue)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.Lbldue)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "payment"
        CType(Me.pError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Lbldue As Label
    Friend WithEvents txtpayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblDent As Label
    Friend WithEvents LblBalance As Label
    Friend WithEvents txtDue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pError As ErrorProvider
End Class

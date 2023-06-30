<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.btnSales = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.BtnSocks = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.topBar = New System.Windows.Forms.Panel()
        Me.PnlScreen = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNmode = New System.Windows.Forms.Button()
        Me.BntDmode = New System.Windows.Forms.Button()
        Me.sidePanel.SuspendLayout()
        Me.topBar.SuspendLayout()
        Me.PnlScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(-1, 48)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(146, 49)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.Button1)
        Me.sidePanel.Controls.Add(Me.btnHome)
        Me.sidePanel.Controls.Add(Me.btnSales)
        Me.sidePanel.Controls.Add(Me.BtnSocks)
        Me.sidePanel.Controls.Add(Me.btnAdmin)
        Me.sidePanel.Controls.Add(Me.btnReport)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 24)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(147, 548)
        Me.sidePanel.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back to Dashboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(-1, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(146, 49)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'BtnSocks
        '
        Me.BtnSocks.FlatAppearance.BorderSize = 0
        Me.BtnSocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocks.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.BtnSocks.ForeColor = System.Drawing.Color.White
        Me.BtnSocks.Location = New System.Drawing.Point(-1, 102)
        Me.BtnSocks.Name = "BtnSocks"
        Me.BtnSocks.Size = New System.Drawing.Size(146, 49)
        Me.BtnSocks.TabIndex = 2
        Me.BtnSocks.Text = "Iventory"
        Me.BtnSocks.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(-1, 211)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(146, 49)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Profile"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(3, 157)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(146, 49)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'topBar
        '
        Me.topBar.BackColor = System.Drawing.Color.Red
        Me.topBar.Controls.Add(Me.BntDmode)
        Me.topBar.Controls.Add(Me.BtnNmode)
        Me.topBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBar.Location = New System.Drawing.Point(0, 0)
        Me.topBar.Name = "topBar"
        Me.topBar.Size = New System.Drawing.Size(984, 24)
        Me.topBar.TabIndex = 3
        '
        'PnlScreen
        '
        Me.PnlScreen.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlScreen.Controls.Add(Me.Label1)
        Me.PnlScreen.Location = New System.Drawing.Point(151, 30)
        Me.PnlScreen.Name = "PnlScreen"
        Me.PnlScreen.Size = New System.Drawing.Size(785, 542)
        Me.PnlScreen.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(254, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dash board"
        '
        'BtnNmode
        '
        Me.BtnNmode.Location = New System.Drawing.Point(841, 3)
        Me.BtnNmode.Name = "BtnNmode"
        Me.BtnNmode.Size = New System.Drawing.Size(67, 21)
        Me.BtnNmode.TabIndex = 0
        Me.BtnNmode.Text = "Night"
        Me.BtnNmode.UseVisualStyleBackColor = True
        '
        'BntDmode
        '
        Me.BntDmode.Location = New System.Drawing.Point(914, 3)
        Me.BntDmode.Name = "BntDmode"
        Me.BntDmode.Size = New System.Drawing.Size(67, 21)
        Me.BntDmode.TabIndex = 0
        Me.BntDmode.Text = "Day"
        Me.BntDmode.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 572)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topBar)
        Me.Controls.Add(Me.PnlScreen)
        Me.Name = "frmHome"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.sidePanel.ResumeLayout(False)
        Me.topBar.ResumeLayout(False)
        Me.PnlScreen.ResumeLayout(False)
        Me.PnlScreen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSales As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents BtnSocks As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents topBar As Panel
    Friend WithEvents PnlScreen As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BntDmode As Button
    Friend WithEvents BtnNmode As Button
End Class

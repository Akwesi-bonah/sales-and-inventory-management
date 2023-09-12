<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class variance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvvar = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tps = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.tnPdf = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvvar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tps.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvvar
        '
        Me.dgvvar.AllowUserToAddRows = False
        Me.dgvvar.AllowUserToDeleteRows = False
        Me.dgvvar.AllowUserToResizeColumns = False
        Me.dgvvar.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvvar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvvar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvvar.BackgroundColor = System.Drawing.Color.White
        Me.dgvvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvvar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvvar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvvar.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvvar.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvvar.EnableHeadersVisualStyles = False
        Me.dgvvar.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvvar.Location = New System.Drawing.Point(28, 151)
        Me.dgvvar.Name = "dgvvar"
        Me.dgvvar.ReadOnly = True
        Me.dgvvar.RowHeadersVisible = False
        Me.dgvvar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvvar.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvvar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvar.Size = New System.Drawing.Size(1157, 473)
        Me.dgvvar.TabIndex = 0
        Me.dgvvar.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvvar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvvar.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvvar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvvar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvvar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvvar.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvvar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvvar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvvar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvvar.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvvar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvvar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvvar.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvvar.ThemeStyle.ReadOnly = True
        Me.dgvvar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvvar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvvar.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvvar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvvar.ThemeStyle.RowsStyle.Height = 22
        Me.dgvvar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvvar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tps
        '
        Me.tps.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tps.Controls.Add(Me.LblHeader)
        Me.tps.CustomBorderColor = System.Drawing.Color.White
        Me.tps.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.tps.Dock = System.Windows.Forms.DockStyle.Top
        Me.tps.Location = New System.Drawing.Point(0, 0)
        Me.tps.Name = "tps"
        Me.tps.ShadowDecoration.Parent = Me.tps
        Me.tps.Size = New System.Drawing.Size(1213, 86)
        Me.tps.TabIndex = 1
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Rockwell Extra Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(116, 9)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(906, 56)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Inventory and Report Variance"
        '
        'tnPdf
        '
        Me.tnPdf.CheckedState.Parent = Me.tnPdf
        Me.tnPdf.CustomImages.Parent = Me.tnPdf
        Me.tnPdf.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tnPdf.ForeColor = System.Drawing.Color.White
        Me.tnPdf.HoverState.Parent = Me.tnPdf
        Me.tnPdf.Location = New System.Drawing.Point(744, 100)
        Me.tnPdf.Name = "tnPdf"
        Me.tnPdf.ShadowDecoration.Parent = Me.tnPdf
        Me.tnPdf.Size = New System.Drawing.Size(180, 45)
        Me.tnPdf.TabIndex = 2
        Me.tnPdf.Text = "PDF"
        '
        'variance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1213, 636)
        Me.Controls.Add(Me.tnPdf)
        Me.Controls.Add(Me.tps)
        Me.Controls.Add(Me.dgvvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "variance"
        Me.Text = "variance"
        CType(Me.dgvvar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tps.ResumeLayout(False)
        Me.tps.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvvar As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tps As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblHeader As Label
    Friend WithEvents tnPdf As Guna.UI2.WinForms.Guna2Button
End Class

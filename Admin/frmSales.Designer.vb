<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblSales = New System.Windows.Forms.Label()
        Me.LblMth = New System.Windows.Forms.Label()
        Me.LblsA = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtsales = New System.Windows.Forms.TextBox()
        Me.DtpEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DtpStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblend = New System.Windows.Forms.Label()
        Me.CmbTeller = New System.Windows.Forms.ComboBox()
        Me.LblTeller = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.LblSS = New System.Windows.Forms.Label()
        Me.dgvSales = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mcDate = New System.Windows.Forms.MonthCalendar()
        Me.pnlas = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlas.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSales
        '
        Me.LblSales.AutoSize = True
        Me.LblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSales.Location = New System.Drawing.Point(163, 5)
        Me.LblSales.Name = "LblSales"
        Me.LblSales.Size = New System.Drawing.Size(118, 25)
        Me.LblSales.TabIndex = 1
        Me.LblSales.Text = "View Sales"
        '
        'LblMth
        '
        Me.LblMth.AutoSize = True
        Me.LblMth.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMth.ForeColor = System.Drawing.Color.White
        Me.LblMth.Location = New System.Drawing.Point(15, 9)
        Me.LblMth.Name = "LblMth"
        Me.LblMth.Size = New System.Drawing.Size(55, 24)
        Me.LblMth.TabIndex = 0
        Me.LblMth.Text = "From"
        '
        'LblsA
        '
        Me.LblsA.AutoSize = True
        Me.LblsA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblsA.ForeColor = System.Drawing.Color.White
        Me.LblsA.Location = New System.Drawing.Point(15, 177)
        Me.LblsA.Name = "LblsA"
        Me.LblsA.Size = New System.Drawing.Size(127, 24)
        Me.LblsA.TabIndex = 1
        Me.LblsA.Text = "Sales Amount"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Teal
        Me.btnCheck.Location = New System.Drawing.Point(19, 222)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(219, 39)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'txtsales
        '
        Me.txtsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsales.Location = New System.Drawing.Point(751, 192)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.ReadOnly = True
        Me.txtsales.Size = New System.Drawing.Size(90, 30)
        Me.txtsales.TabIndex = 9
        Me.txtsales.Text = "0.00"
        Me.txtsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtpEnd
        '
        Me.DtpEnd.CheckedState.Parent = Me.DtpEnd
        Me.DtpEnd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DtpEnd.HoverState.Parent = Me.DtpEnd
        Me.DtpEnd.Location = New System.Drawing.Point(19, 112)
        Me.DtpEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DtpEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DtpEnd.Name = "DtpEnd"
        Me.DtpEnd.ShadowDecoration.Parent = Me.DtpEnd
        Me.DtpEnd.Size = New System.Drawing.Size(219, 36)
        Me.DtpEnd.TabIndex = 8
        Me.DtpEnd.Value = New Date(2023, 8, 13, 13, 4, 14, 508)
        '
        'DtpStart
        '
        Me.DtpStart.CheckedState.Parent = Me.DtpStart
        Me.DtpStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DtpStart.HoverState.Parent = Me.DtpStart
        Me.DtpStart.Location = New System.Drawing.Point(19, 35)
        Me.DtpStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DtpStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DtpStart.Name = "DtpStart"
        Me.DtpStart.ShadowDecoration.Parent = Me.DtpStart
        Me.DtpStart.Size = New System.Drawing.Size(219, 36)
        Me.DtpStart.TabIndex = 8
        Me.DtpStart.Value = New Date(2023, 8, 13, 13, 4, 14, 508)
        '
        'lblend
        '
        Me.lblend.AutoSize = True
        Me.lblend.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblend.ForeColor = System.Drawing.Color.White
        Me.lblend.Location = New System.Drawing.Point(15, 74)
        Me.lblend.Name = "lblend"
        Me.lblend.Size = New System.Drawing.Size(33, 24)
        Me.lblend.TabIndex = 0
        Me.lblend.Text = "To"
        '
        'CmbTeller
        '
        Me.CmbTeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTeller.FormattingEnabled = True
        Me.CmbTeller.Location = New System.Drawing.Point(311, 46)
        Me.CmbTeller.Name = "CmbTeller"
        Me.CmbTeller.Size = New System.Drawing.Size(151, 33)
        Me.CmbTeller.TabIndex = 6
        '
        'LblTeller
        '
        Me.LblTeller.AutoSize = True
        Me.LblTeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTeller.ForeColor = System.Drawing.Color.White
        Me.LblTeller.Location = New System.Drawing.Point(345, 8)
        Me.LblTeller.Name = "LblTeller"
        Me.LblTeller.Size = New System.Drawing.Size(58, 24)
        Me.LblTeller.TabIndex = 5
        Me.LblTeller.Text = "Teller"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(148, 177)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(90, 30)
        Me.TxtTotal.TabIndex = 4
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Teal
        Me.btnLoad.Location = New System.Drawing.Point(605, 241)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(240, 39)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'LblSS
        '
        Me.LblSS.AutoSize = True
        Me.LblSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSS.ForeColor = System.Drawing.Color.White
        Me.LblSS.Location = New System.Drawing.Point(601, 196)
        Me.LblSS.Name = "LblSS"
        Me.LblSS.Size = New System.Drawing.Size(127, 24)
        Me.LblSS.TabIndex = 1
        Me.LblSS.Text = "Sales Amount"
        '
        'dgvSales
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSales.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSales.EnableHeadersVisualStyles = False
        Me.dgvSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSales.Location = New System.Drawing.Point(31, 339)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.RowHeadersVisible = False
        Me.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSales.Size = New System.Drawing.Size(1168, 289)
        Me.dgvSales.TabIndex = 6
        Me.dgvSales.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgvSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSales.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSales.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvSales.ThemeStyle.ReadOnly = False
        Me.dgvSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSales.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 58)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 663)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1259, 32)
        Me.Panel2.TabIndex = 12
        '
        'mcDate
        '
        Me.mcDate.Location = New System.Drawing.Point(614, 9)
        Me.mcDate.Name = "mcDate"
        Me.mcDate.TabIndex = 13
        '
        'pnlas
        '
        Me.pnlas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlas.Controls.Add(Me.lblend)
        Me.pnlas.Controls.Add(Me.btnLoad)
        Me.pnlas.Controls.Add(Me.mcDate)
        Me.pnlas.Controls.Add(Me.txtsales)
        Me.pnlas.Controls.Add(Me.LblSS)
        Me.pnlas.Controls.Add(Me.DtpStart)
        Me.pnlas.Controls.Add(Me.LblTeller)
        Me.pnlas.Controls.Add(Me.btnCheck)
        Me.pnlas.Controls.Add(Me.LblsA)
        Me.pnlas.Controls.Add(Me.DtpEnd)
        Me.pnlas.Controls.Add(Me.CmbTeller)
        Me.pnlas.Controls.Add(Me.TxtTotal)
        Me.pnlas.Controls.Add(Me.LblMth)
        Me.pnlas.Location = New System.Drawing.Point(152, 33)
        Me.pnlas.Name = "pnlas"
        Me.pnlas.ShadowDecoration.Parent = Me.pnlas
        Me.pnlas.Size = New System.Drawing.Size(1016, 283)
        Me.pnlas.TabIndex = 13
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 678)
        Me.Controls.Add(Me.pnlas)
        Me.Controls.Add(Me.LblSales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvSales)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.Text = "frmSales"
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlas.ResumeLayout(False)
        Me.pnlas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSales As Label
    Friend WithEvents LblMth As Label
    Friend WithEvents LblsA As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents CmbTeller As ComboBox
    Friend WithEvents LblTeller As Label
    Friend WithEvents DtpEnd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DtpStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblend As Label
    Friend WithEvents dgvSales As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtsales As TextBox
    Friend WithEvents LblSS As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mcDate As MonthCalendar
    Friend WithEvents pnlas As Guna.UI2.WinForms.Guna2Panel
End Class

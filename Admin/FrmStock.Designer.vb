<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.LblBrand = New System.Windows.Forms.Label()
        Me.LblCate = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.Pnlho = New System.Windows.Forms.Panel()
        Me.CmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbFCate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbFBrand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Dgvstocts = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnUpstock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUprice = New Guna.UI2.WinForms.Guna2Button()
        Me.Pnlho.SuspendLayout()
        CType(Me.Dgvstocts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFilter.ForeColor = System.Drawing.Color.Black
        Me.LblFilter.Location = New System.Drawing.Point(119, 20)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(163, 31)
        Me.LblFilter.TabIndex = 1
        Me.LblFilter.Text = "Filter Stock"
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBrand.ForeColor = System.Drawing.Color.White
        Me.LblBrand.Location = New System.Drawing.Point(39, 19)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(57, 20)
        Me.LblBrand.TabIndex = 3
        Me.LblBrand.Text = "Brand"
        '
        'LblCate
        '
        Me.LblCate.AutoSize = True
        Me.LblCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCate.ForeColor = System.Drawing.Color.White
        Me.LblCate.Location = New System.Drawing.Point(329, 19)
        Me.LblCate.Name = "LblCate"
        Me.LblCate.Size = New System.Drawing.Size(81, 20)
        Me.LblCate.TabIndex = 3
        Me.LblCate.Text = "Category"
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.ForeColor = System.Drawing.Color.White
        Me.LblType.Location = New System.Drawing.Point(624, 19)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(47, 20)
        Me.LblType.TabIndex = 3
        Me.LblType.Text = "Type"
        '
        'Pnlho
        '
        Me.Pnlho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pnlho.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnlho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnlho.Controls.Add(Me.CmbType)
        Me.Pnlho.Controls.Add(Me.CmbFCate)
        Me.Pnlho.Controls.Add(Me.CmbFBrand)
        Me.Pnlho.Controls.Add(Me.LblCate)
        Me.Pnlho.Controls.Add(Me.LblType)
        Me.Pnlho.Controls.Add(Me.LblBrand)
        Me.Pnlho.Location = New System.Drawing.Point(104, 35)
        Me.Pnlho.Name = "Pnlho"
        Me.Pnlho.Size = New System.Drawing.Size(847, 117)
        Me.Pnlho.TabIndex = 4
        '
        'CmbType
        '
        Me.CmbType.BackColor = System.Drawing.Color.Transparent
        Me.CmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.FocusedColor = System.Drawing.Color.Empty
        Me.CmbType.FocusedState.Parent = Me.CmbType
        Me.CmbType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.HoverState.Parent = Me.CmbType
        Me.CmbType.ItemHeight = 30
        Me.CmbType.Items.AddRange(New Object() {"All", "Out Of stock", "Stock In"})
        Me.CmbType.ItemsAppearance.Parent = Me.CmbType
        Me.CmbType.Location = New System.Drawing.Point(595, 42)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.ShadowDecoration.Parent = Me.CmbType
        Me.CmbType.Size = New System.Drawing.Size(209, 36)
        Me.CmbType.TabIndex = 4
        '
        'CmbFCate
        '
        Me.CmbFCate.BackColor = System.Drawing.Color.Transparent
        Me.CmbFCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbFCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFCate.FocusedColor = System.Drawing.Color.Empty
        Me.CmbFCate.FocusedState.Parent = Me.CmbFCate
        Me.CmbFCate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbFCate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbFCate.FormattingEnabled = True
        Me.CmbFCate.HoverState.Parent = Me.CmbFCate
        Me.CmbFCate.ItemHeight = 30
        Me.CmbFCate.ItemsAppearance.Parent = Me.CmbFCate
        Me.CmbFCate.Location = New System.Drawing.Point(333, 42)
        Me.CmbFCate.Name = "CmbFCate"
        Me.CmbFCate.ShadowDecoration.Parent = Me.CmbFCate
        Me.CmbFCate.Size = New System.Drawing.Size(200, 36)
        Me.CmbFCate.TabIndex = 4
        '
        'CmbFBrand
        '
        Me.CmbFBrand.BackColor = System.Drawing.Color.Transparent
        Me.CmbFBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbFBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFBrand.FocusedColor = System.Drawing.Color.Empty
        Me.CmbFBrand.FocusedState.Parent = Me.CmbFBrand
        Me.CmbFBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbFBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbFBrand.FormattingEnabled = True
        Me.CmbFBrand.HoverState.Parent = Me.CmbFBrand
        Me.CmbFBrand.ItemHeight = 30
        Me.CmbFBrand.ItemsAppearance.Parent = Me.CmbFBrand
        Me.CmbFBrand.Location = New System.Drawing.Point(43, 42)
        Me.CmbFBrand.Name = "CmbFBrand"
        Me.CmbFBrand.ShadowDecoration.Parent = Me.CmbFBrand
        Me.CmbFBrand.Size = New System.Drawing.Size(207, 36)
        Me.CmbFBrand.TabIndex = 4
        '
        'Dgvstocts
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Dgvstocts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvstocts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgvstocts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgvstocts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgvstocts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgvstocts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.Dgvstocts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvstocts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgvstocts.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvstocts.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvstocts.EnableHeadersVisualStyles = False
        Me.Dgvstocts.GridColor = System.Drawing.Color.White
        Me.Dgvstocts.Location = New System.Drawing.Point(31, 180)
        Me.Dgvstocts.Name = "Dgvstocts"
        Me.Dgvstocts.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Dgvstocts.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvstocts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvstocts.Size = New System.Drawing.Size(1202, 406)
        Me.Dgvstocts.TabIndex = 4
        Me.Dgvstocts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Dgvstocts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgvstocts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Dgvstocts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Dgvstocts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Dgvstocts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Dgvstocts.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgvstocts.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.Dgvstocts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgvstocts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgvstocts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Dgvstocts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Dgvstocts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Dgvstocts.ThemeStyle.HeaderStyle.Height = 25
        Me.Dgvstocts.ThemeStyle.ReadOnly = False
        Me.Dgvstocts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgvstocts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgvstocts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Dgvstocts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.Dgvstocts.ThemeStyle.RowsStyle.Height = 22
        Me.Dgvstocts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgvstocts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnUpstock
        '
        Me.btnUpstock.CheckedState.Parent = Me.btnUpstock
        Me.btnUpstock.CustomImages.Parent = Me.btnUpstock
        Me.btnUpstock.FillColor = System.Drawing.Color.Teal
        Me.btnUpstock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpstock.ForeColor = System.Drawing.Color.White
        Me.btnUpstock.HoverState.Parent = Me.btnUpstock
        Me.btnUpstock.Location = New System.Drawing.Point(973, 107)
        Me.btnUpstock.Name = "btnUpstock"
        Me.btnUpstock.ShadowDecoration.Parent = Me.btnUpstock
        Me.btnUpstock.Size = New System.Drawing.Size(125, 45)
        Me.btnUpstock.TabIndex = 5
        Me.btnUpstock.Text = "Update Stock"
        '
        'btnUprice
        '
        Me.btnUprice.CheckedState.Parent = Me.btnUprice
        Me.btnUprice.CustomImages.Parent = Me.btnUprice
        Me.btnUprice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUprice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUprice.ForeColor = System.Drawing.Color.White
        Me.btnUprice.HoverState.Parent = Me.btnUprice
        Me.btnUprice.Location = New System.Drawing.Point(1121, 107)
        Me.btnUprice.Name = "btnUprice"
        Me.btnUprice.ShadowDecoration.Parent = Me.btnUprice
        Me.btnUprice.Size = New System.Drawing.Size(110, 45)
        Me.btnUprice.TabIndex = 5
        Me.btnUprice.Text = "Update Price"
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 678)
        Me.Controls.Add(Me.btnUprice)
        Me.Controls.Add(Me.btnUpstock)
        Me.Controls.Add(Me.Dgvstocts)
        Me.Controls.Add(Me.LblFilter)
        Me.Controls.Add(Me.Pnlho)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStock"
        Me.Text = "FrmStock"
        Me.Pnlho.ResumeLayout(False)
        Me.Pnlho.PerformLayout()
        CType(Me.Dgvstocts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFilter As Label
    Friend WithEvents LblBrand As Label
    Friend WithEvents LblCate As Label
    Friend WithEvents LblType As Label
    Friend WithEvents Pnlho As Panel
    Friend WithEvents Dgvstocts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CmbFBrand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnUpstock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUprice As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbFCate As Guna.UI2.WinForms.Guna2ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pcode = New System.Windows.Forms.Label()
        Me.txtRPcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdOPName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DgvOrders = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.OPname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPinfor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPbrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPcate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orquantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOAdd = New System.Windows.Forms.Button()
        Me.BtnOremove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BntOSearch = New System.Windows.Forms.Button()
        Me.ErrorOder = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pblOr = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtOqantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.DgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorOder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pblOr.SuspendLayout()
        CType(Me.txtOqantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(655, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name"
        '
        'Pcode
        '
        Me.Pcode.AutoSize = True
        Me.Pcode.BackColor = System.Drawing.Color.Transparent
        Me.Pcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pcode.Location = New System.Drawing.Point(98, 32)
        Me.Pcode.Name = "Pcode"
        Me.Pcode.Size = New System.Drawing.Size(132, 25)
        Me.Pcode.TabIndex = 2
        Me.Pcode.Text = "Product Code"
        '
        'txtRPcode
        '
        Me.txtRPcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRPcode.DefaultText = ""
        Me.txtRPcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRPcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRPcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRPcode.DisabledState.Parent = Me.txtRPcode
        Me.txtRPcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRPcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRPcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRPcode.FocusedState.Parent = Me.txtRPcode
        Me.txtRPcode.ForeColor = System.Drawing.Color.White
        Me.txtRPcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRPcode.HoverState.Parent = Me.txtRPcode
        Me.txtRPcode.Location = New System.Drawing.Point(103, 73)
        Me.txtRPcode.Name = "txtRPcode"
        Me.txtRPcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRPcode.PlaceholderText = ""
        Me.txtRPcode.SelectedText = ""
        Me.txtRPcode.ShadowDecoration.Parent = Me.txtRPcode
        Me.txtRPcode.Size = New System.Drawing.Size(174, 36)
        Me.txtRPcode.TabIndex = 1
        '
        'cmdOPName
        '
        Me.cmdOPName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOPName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmdOPName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdOPName.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOPName.FocusedColor = System.Drawing.Color.Empty
        Me.cmdOPName.FocusedState.Parent = Me.cmdOPName
        Me.cmdOPName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdOPName.ForeColor = System.Drawing.Color.White
        Me.cmdOPName.FormattingEnabled = True
        Me.cmdOPName.HoverState.Parent = Me.cmdOPName
        Me.cmdOPName.ItemHeight = 30
        Me.cmdOPName.ItemsAppearance.Parent = Me.cmdOPName
        Me.cmdOPName.Location = New System.Drawing.Point(380, 73)
        Me.cmdOPName.Name = "cmdOPName"
        Me.cmdOPName.ShadowDecoration.Parent = Me.cmdOPName
        Me.cmdOPName.Size = New System.Drawing.Size(184, 36)
        Me.cmdOPName.TabIndex = 0
        '
        'DgvOrders
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvOrders.ColumnHeadersHeight = 30
        Me.DgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OPname, Me.OPinfor, Me.OPbrand, Me.OPcate, Me.Orquantity})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvOrders.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvOrders.EnableHeadersVisualStyles = False
        Me.DgvOrders.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvOrders.Location = New System.Drawing.Point(49, 339)
        Me.DgvOrders.Name = "DgvOrders"
        Me.DgvOrders.RowHeadersVisible = False
        Me.DgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOrders.Size = New System.Drawing.Size(1121, 272)
        Me.DgvOrders.TabIndex = 1
        Me.DgvOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvOrders.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvOrders.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvOrders.ThemeStyle.HeaderStyle.Height = 30
        Me.DgvOrders.ThemeStyle.ReadOnly = False
        Me.DgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvOrders.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvOrders.ThemeStyle.RowsStyle.Height = 22
        Me.DgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'OPname
        '
        Me.OPname.HeaderText = "Product Name"
        Me.OPname.Name = "OPname"
        Me.OPname.ReadOnly = True
        '
        'OPinfor
        '
        Me.OPinfor.HeaderText = "Description"
        Me.OPinfor.Name = "OPinfor"
        Me.OPinfor.ReadOnly = True
        '
        'OPbrand
        '
        Me.OPbrand.HeaderText = "Brand"
        Me.OPbrand.Name = "OPbrand"
        Me.OPbrand.ReadOnly = True
        '
        'OPcate
        '
        Me.OPcate.HeaderText = "Category"
        Me.OPcate.Name = "OPcate"
        Me.OPcate.ReadOnly = True
        '
        'Orquantity
        '
        Me.Orquantity.HeaderText = "Quantity"
        Me.Orquantity.Name = "Orquantity"
        Me.Orquantity.ReadOnly = True
        '
        'BtnOAdd
        '
        Me.BtnOAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnOAdd.Location = New System.Drawing.Point(294, 143)
        Me.BtnOAdd.Name = "BtnOAdd"
        Me.BtnOAdd.Size = New System.Drawing.Size(166, 31)
        Me.BtnOAdd.TabIndex = 3
        Me.BtnOAdd.Text = "Add"
        Me.BtnOAdd.UseVisualStyleBackColor = False
        '
        'BtnOremove
        '
        Me.BtnOremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOremove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnOremove.Location = New System.Drawing.Point(466, 143)
        Me.BtnOremove.Name = "BtnOremove"
        Me.BtnOremove.Size = New System.Drawing.Size(166, 31)
        Me.BtnOremove.TabIndex = 3
        Me.BtnOremove.Text = "Remove"
        Me.BtnOremove.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(458, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Order Product"
        '
        'BtnExport
        '
        Me.BtnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExport.Location = New System.Drawing.Point(640, 143)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(166, 31)
        Me.BtnExport.TabIndex = 3
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = False
        '
        'BntOSearch
        '
        Me.BntOSearch.BackColor = System.Drawing.Color.Navy
        Me.BntOSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BntOSearch.Location = New System.Drawing.Point(122, 143)
        Me.BntOSearch.Name = "BntOSearch"
        Me.BntOSearch.Size = New System.Drawing.Size(166, 31)
        Me.BntOSearch.TabIndex = 3
        Me.BntOSearch.Text = "Search"
        Me.BntOSearch.UseVisualStyleBackColor = False
        '
        'ErrorOder
        '
        Me.ErrorOder.ContainerControl = Me
        '
        'pblOr
        '
        Me.pblOr.BackColor = System.Drawing.Color.Teal
        Me.pblOr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pblOr.BorderRadius = 50
        Me.pblOr.BorderThickness = 1
        Me.pblOr.Controls.Add(Me.txtOqantity)
        Me.pblOr.Controls.Add(Me.Label2)
        Me.pblOr.Controls.Add(Me.BtnExport)
        Me.pblOr.Controls.Add(Me.BntOSearch)
        Me.pblOr.Controls.Add(Me.BtnOremove)
        Me.pblOr.Controls.Add(Me.Label1)
        Me.pblOr.Controls.Add(Me.BtnOAdd)
        Me.pblOr.Controls.Add(Me.cmdOPName)
        Me.pblOr.Controls.Add(Me.Pcode)
        Me.pblOr.Controls.Add(Me.txtRPcode)
        Me.pblOr.Location = New System.Drawing.Point(111, 94)
        Me.pblOr.Name = "pblOr"
        Me.pblOr.ShadowDecoration.Parent = Me.pblOr
        Me.pblOr.Size = New System.Drawing.Size(977, 217)
        Me.pblOr.TabIndex = 4
        '
        'txtOqantity
        '
        Me.txtOqantity.BackColor = System.Drawing.Color.Transparent
        Me.txtOqantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOqantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOqantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOqantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOqantity.DisabledState.Parent = Me.txtOqantity
        Me.txtOqantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtOqantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.txtOqantity.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOqantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOqantity.FocusedState.Parent = Me.txtOqantity
        Me.txtOqantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOqantity.ForeColor = System.Drawing.Color.White
        Me.txtOqantity.Location = New System.Drawing.Point(660, 73)
        Me.txtOqantity.Name = "txtOqantity"
        Me.txtOqantity.ShadowDecoration.Parent = Me.txtOqantity
        Me.txtOqantity.Size = New System.Drawing.Size(169, 36)
        Me.txtOqantity.TabIndex = 4
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1249, 55)
        Me.Guna2Panel1.TabIndex = 5
        '
        'orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1249, 614)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DgvOrders)
        Me.Controls.Add(Me.pblOr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "orders"
        Me.Text = "orders"
        CType(Me.DgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorOder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pblOr.ResumeLayout(False)
        Me.pblOr.PerformLayout()
        CType(Me.txtOqantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pcode As Label
    Friend WithEvents txtRPcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdOPName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DgvOrders As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnOAdd As Button
    Friend WithEvents BtnOremove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnExport As Button
    Friend WithEvents BntOSearch As Button
    Friend WithEvents OPname As DataGridViewTextBoxColumn
    Friend WithEvents OPinfor As DataGridViewTextBoxColumn
    Friend WithEvents OPbrand As DataGridViewTextBoxColumn
    Friend WithEvents OPcate As DataGridViewTextBoxColumn
    Friend WithEvents Orquantity As DataGridViewTextBoxColumn
    Friend WithEvents ErrorOder As ErrorProvider
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pblOr As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtOqantity As Guna.UI2.WinForms.Guna2NumericUpDown
End Class

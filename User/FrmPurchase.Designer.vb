<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchase))
        Me.LblPcode = New System.Windows.Forms.Label()
        Me.LblPname = New System.Windows.Forms.Label()
        Me.LblCate = New System.Windows.Forms.Label()
        Me.LblBrand = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblProduct = New System.Windows.Forms.Label()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSPname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSCate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblCart = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblCost = New System.Windows.Forms.Label()
        Me.DgCart = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Pnames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pinfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pquantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintCash = New System.Drawing.Printing.PrintDocument()
        Me.TxtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnPClear = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAddCart = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbUnit = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnVocher = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMomo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCash = New Guna.UI2.WinForms.Guna2Button()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintTest = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintCard = New System.Drawing.Printing.PrintDocument()
        Me.PrintMoMo = New System.Drawing.Printing.PrintDocument()
        Me.PrintVoch = New System.Drawing.Printing.PrintDocument()
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPcode
        '
        Me.LblPcode.AutoSize = True
        Me.LblPcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPcode.Location = New System.Drawing.Point(34, 28)
        Me.LblPcode.Name = "LblPcode"
        Me.LblPcode.Size = New System.Drawing.Size(118, 20)
        Me.LblPcode.TabIndex = 2
        Me.LblPcode.Text = "Product Code"
        '
        'LblPname
        '
        Me.LblPname.AutoSize = True
        Me.LblPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPname.Location = New System.Drawing.Point(195, 28)
        Me.LblPname.Name = "LblPname"
        Me.LblPname.Size = New System.Drawing.Size(122, 20)
        Me.LblPname.TabIndex = 2
        Me.LblPname.Text = "Product Name"
        '
        'LblCate
        '
        Me.LblCate.AutoSize = True
        Me.LblCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCate.Location = New System.Drawing.Point(495, 28)
        Me.LblCate.Name = "LblCate"
        Me.LblCate.Size = New System.Drawing.Size(81, 20)
        Me.LblCate.TabIndex = 2
        Me.LblCate.Text = "Category"
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblBrand.Location = New System.Drawing.Point(757, 28)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(49, 20)
        Me.LblBrand.TabIndex = 2
        Me.LblBrand.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1007, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Units"
        '
        'LblProduct
        '
        Me.LblProduct.AutoSize = True
        Me.LblProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProduct.ForeColor = System.Drawing.Color.Cyan
        Me.LblProduct.Location = New System.Drawing.Point(60, 9)
        Me.LblProduct.Name = "LblProduct"
        Me.LblProduct.Size = New System.Drawing.Size(168, 26)
        Me.LblProduct.TabIndex = 2
        Me.LblProduct.Text = "Select Product"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrice.BorderRadius = 10
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.txtPrice.ForeColor = System.Drawing.Color.White
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(761, 67)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = "0.00"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(200, 36)
        Me.txtPrice.TabIndex = 8
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSPname
        '
        Me.cmbSPname.BackColor = System.Drawing.Color.Transparent
        Me.cmbSPname.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbSPname.BorderRadius = 10
        Me.cmbSPname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSPname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSPname.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbSPname.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSPname.FocusedState.Parent = Me.cmbSPname
        Me.cmbSPname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSPname.ForeColor = System.Drawing.Color.White
        Me.cmbSPname.FormattingEnabled = True
        Me.cmbSPname.HoverState.Parent = Me.cmbSPname
        Me.cmbSPname.ItemHeight = 30
        Me.cmbSPname.ItemsAppearance.Parent = Me.cmbSPname
        Me.cmbSPname.Location = New System.Drawing.Point(199, 67)
        Me.cmbSPname.Name = "cmbSPname"
        Me.cmbSPname.ShadowDecoration.Parent = Me.cmbSPname
        Me.cmbSPname.Size = New System.Drawing.Size(233, 36)
        Me.cmbSPname.TabIndex = 7
        '
        'cmbSCate
        '
        Me.cmbSCate.BackColor = System.Drawing.Color.White
        Me.cmbSCate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbSCate.BorderRadius = 10
        Me.cmbSCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSCate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbSCate.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSCate.FocusedState.Parent = Me.cmbSCate
        Me.cmbSCate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSCate.ForeColor = System.Drawing.Color.White
        Me.cmbSCate.FormattingEnabled = True
        Me.cmbSCate.HoverState.Parent = Me.cmbSCate
        Me.cmbSCate.ItemHeight = 30
        Me.cmbSCate.ItemsAppearance.Parent = Me.cmbSCate
        Me.cmbSCate.Location = New System.Drawing.Point(490, 67)
        Me.cmbSCate.Name = "cmbSCate"
        Me.cmbSCate.ShadowDecoration.Parent = Me.cmbSCate
        Me.cmbSCate.Size = New System.Drawing.Size(233, 36)
        Me.cmbSCate.TabIndex = 7
        '
        'txtPcode
        '
        Me.txtPcode.BackColor = System.Drawing.Color.Transparent
        Me.txtPcode.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPcode.BorderRadius = 10
        Me.txtPcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPcode.DefaultText = ""
        Me.txtPcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPcode.DisabledState.Parent = Me.txtPcode
        Me.txtPcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPcode.FocusedState.Parent = Me.txtPcode
        Me.txtPcode.ForeColor = System.Drawing.Color.White
        Me.txtPcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPcode.HoverState.Parent = Me.txtPcode
        Me.txtPcode.Location = New System.Drawing.Point(23, 67)
        Me.txtPcode.Name = "txtPcode"
        Me.txtPcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPcode.PlaceholderText = ""
        Me.txtPcode.SelectedText = ""
        Me.txtPcode.ShadowDecoration.Parent = Me.txtPcode
        Me.txtPcode.Size = New System.Drawing.Size(152, 36)
        Me.txtPcode.TabIndex = 6
        '
        'LblCart
        '
        Me.LblCart.AutoSize = True
        Me.LblCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCart.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCart.ForeColor = System.Drawing.Color.Cyan
        Me.LblCart.Location = New System.Drawing.Point(60, 260)
        Me.LblCart.Name = "LblCart"
        Me.LblCart.Size = New System.Drawing.Size(96, 26)
        Me.LblCart.TabIndex = 2
        Me.LblCart.Text = "Cart"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, -204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cart"
        '
        'LblCost
        '
        Me.LblCost.AutoSize = True
        Me.LblCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCost.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCost.ForeColor = System.Drawing.Color.Black
        Me.LblCost.Location = New System.Drawing.Point(30, 600)
        Me.LblCost.Name = "LblCost"
        Me.LblCost.Size = New System.Drawing.Size(200, 26)
        Me.LblCost.TabIndex = 2
        Me.LblCost.Text = "Total Cost"
        '
        'DgCart
        '
        Me.DgCart.AllowUserToAddRows = False
        Me.DgCart.AllowUserToDeleteRows = False
        Me.DgCart.AllowUserToOrderColumns = True
        Me.DgCart.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DgCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgCart.BackgroundColor = System.Drawing.Color.White
        Me.DgCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgCart.ColumnHeadersHeight = 30
        Me.DgCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pnames, Me.pinfo, Me.pquantity, Me.pprice, Me.Subtotal})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgCart.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgCart.EnableHeadersVisualStyles = False
        Me.DgCart.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DgCart.Location = New System.Drawing.Point(55, 294)
        Me.DgCart.Name = "DgCart"
        Me.DgCart.RowHeadersVisible = False
        Me.DgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgCart.Size = New System.Drawing.Size(932, 287)
        Me.DgCart.TabIndex = 10
        Me.DgCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.DgCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DgCart.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgCart.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DgCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgCart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgCart.ThemeStyle.HeaderStyle.Height = 30
        Me.DgCart.ThemeStyle.ReadOnly = False
        Me.DgCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.DgCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgCart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DgCart.ThemeStyle.RowsStyle.Height = 22
        Me.DgCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DgCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Pnames
        '
        Me.Pnames.DataPropertyName = "SPName"
        Me.Pnames.HeaderText = "Product Name"
        Me.Pnames.Name = "Pnames"
        '
        'pinfo
        '
        Me.pinfo.HeaderText = "Description"
        Me.pinfo.Name = "pinfo"
        '
        'pquantity
        '
        Me.pquantity.DataPropertyName = "Units"
        Me.pquantity.HeaderText = "Unit"
        Me.pquantity.Name = "pquantity"
        '
        'pprice
        '
        Me.pprice.HeaderText = "Price"
        Me.pprice.Name = "pprice"
        '
        'Subtotal
        '
        Me.Subtotal.DataPropertyName = "Subtotal"
        Me.Subtotal.HeaderText = "Sub total"
        Me.Subtotal.Name = "Subtotal"
        '
        'PrintCash
        '
        Me.PrintCash.DocumentName = "Sales Reciept"
        '
        'TxtTotal
        '
        Me.TxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotal.DefaultText = ""
        Me.TxtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotal.DisabledState.Parent = Me.TxtTotal
        Me.TxtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotal.FocusedState.Parent = Me.TxtTotal
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TxtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotal.HoverState.Parent = Me.TxtTotal
        Me.TxtTotal.Location = New System.Drawing.Point(236, 590)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotal.PlaceholderText = "0.00"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.SelectedText = ""
        Me.TxtTotal.ShadowDecoration.Parent = Me.TxtTotal
        Me.TxtTotal.Size = New System.Drawing.Size(117, 36)
        Me.TxtTotal.TabIndex = 11
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.BtnPClear)
        Me.Guna2Panel1.Controls.Add(Me.BtnAddCart)
        Me.Guna2Panel1.Controls.Add(Me.cmbUnit)
        Me.Guna2Panel1.Controls.Add(Me.txtPrice)
        Me.Guna2Panel1.Controls.Add(Me.LblPcode)
        Me.Guna2Panel1.Controls.Add(Me.txtPcode)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.cmbSPname)
        Me.Guna2Panel1.Controls.Add(Me.cmbSCate)
        Me.Guna2Panel1.Controls.Add(Me.LblBrand)
        Me.Guna2Panel1.Controls.Add(Me.LblPname)
        Me.Guna2Panel1.Controls.Add(Me.LblCate)
        Me.Guna2Panel1.Location = New System.Drawing.Point(55, 44)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1206, 207)
        Me.Guna2Panel1.TabIndex = 9
        '
        'BtnPClear
        '
        Me.BtnPClear.BorderRadius = 10
        Me.BtnPClear.BorderThickness = 1
        Me.BtnPClear.CheckedState.Parent = Me.BtnPClear
        Me.BtnPClear.CustomImages.Parent = Me.BtnPClear
        Me.BtnPClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPClear.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.BtnPClear.ForeColor = System.Drawing.Color.White
        Me.BtnPClear.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnPClear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPClear.HoverState.Parent = Me.BtnPClear
        Me.BtnPClear.Location = New System.Drawing.Point(1031, 150)
        Me.BtnPClear.Name = "BtnPClear"
        Me.BtnPClear.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPClear.ShadowDecoration.Parent = Me.BtnPClear
        Me.BtnPClear.Size = New System.Drawing.Size(98, 44)
        Me.BtnPClear.TabIndex = 13
        Me.BtnPClear.Text = "Clear"
        '
        'BtnAddCart
        '
        Me.BtnAddCart.BorderRadius = 10
        Me.BtnAddCart.BorderThickness = 1
        Me.BtnAddCart.CheckedState.Parent = Me.BtnAddCart
        Me.BtnAddCart.CustomImages.Parent = Me.BtnAddCart
        Me.BtnAddCart.FillColor = System.Drawing.Color.Teal
        Me.BtnAddCart.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.BtnAddCart.ForeColor = System.Drawing.Color.White
        Me.BtnAddCart.HoverState.BorderColor = System.Drawing.Color.Red
        Me.BtnAddCart.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddCart.HoverState.Parent = Me.BtnAddCart
        Me.BtnAddCart.Location = New System.Drawing.Point(922, 150)
        Me.BtnAddCart.Name = "BtnAddCart"
        Me.BtnAddCart.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddCart.ShadowDecoration.Parent = Me.BtnAddCart
        Me.BtnAddCart.Size = New System.Drawing.Size(101, 44)
        Me.BtnAddCart.TabIndex = 13
        Me.BtnAddCart.Text = "Add to Cart"
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.Transparent
        Me.cmbUnit.BorderRadius = 10
        Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmbUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbUnit.DisabledState.Parent = Me.cmbUnit
        Me.cmbUnit.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmbUnit.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.cmbUnit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbUnit.FocusedState.Parent = Me.cmbUnit
        Me.cmbUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.ForeColor = System.Drawing.Color.White
        Me.cmbUnit.Location = New System.Drawing.Point(1011, 67)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.ShadowDecoration.Parent = Me.cmbUnit
        Me.cmbUnit.Size = New System.Drawing.Size(118, 36)
        Me.cmbUnit.TabIndex = 9
        Me.cmbUnit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.btnVocher)
        Me.Guna2Panel2.Controls.Add(Me.btnCard)
        Me.Guna2Panel2.Controls.Add(Me.btnMomo)
        Me.Guna2Panel2.Controls.Add(Me.btnCash)
        Me.Guna2Panel2.Location = New System.Drawing.Point(1002, 260)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(260, 357)
        Me.Guna2Panel2.TabIndex = 12
        '
        'btnVocher
        '
        Me.btnVocher.BorderRadius = 10
        Me.btnVocher.BorderThickness = 1
        Me.btnVocher.CheckedState.Parent = Me.btnVocher
        Me.btnVocher.CustomImages.Parent = Me.btnVocher
        Me.btnVocher.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnVocher.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnVocher.ForeColor = System.Drawing.Color.Black
        Me.btnVocher.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnVocher.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVocher.HoverState.Parent = Me.btnVocher
        Me.btnVocher.Location = New System.Drawing.Point(29, 17)
        Me.btnVocher.Name = "btnVocher"
        Me.btnVocher.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVocher.ShadowDecoration.Parent = Me.btnVocher
        Me.btnVocher.Size = New System.Drawing.Size(202, 60)
        Me.btnVocher.TabIndex = 13
        Me.btnVocher.Text = "Vocher"
        '
        'btnCard
        '
        Me.btnCard.BorderRadius = 10
        Me.btnCard.BorderThickness = 1
        Me.btnCard.CheckedState.Parent = Me.btnCard
        Me.btnCard.CustomImages.Parent = Me.btnCard
        Me.btnCard.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCard.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnCard.ForeColor = System.Drawing.Color.Black
        Me.btnCard.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnCard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCard.HoverState.Parent = Me.btnCard
        Me.btnCard.Location = New System.Drawing.Point(29, 101)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCard.ShadowDecoration.Parent = Me.btnCard
        Me.btnCard.Size = New System.Drawing.Size(202, 60)
        Me.btnCard.TabIndex = 13
        Me.btnCard.Text = "Card"
        '
        'btnMomo
        '
        Me.btnMomo.BorderRadius = 10
        Me.btnMomo.BorderThickness = 1
        Me.btnMomo.CheckedState.Parent = Me.btnMomo
        Me.btnMomo.CustomImages.Parent = Me.btnMomo
        Me.btnMomo.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnMomo.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnMomo.ForeColor = System.Drawing.Color.Black
        Me.btnMomo.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnMomo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMomo.HoverState.Parent = Me.btnMomo
        Me.btnMomo.Location = New System.Drawing.Point(29, 189)
        Me.btnMomo.Name = "btnMomo"
        Me.btnMomo.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMomo.ShadowDecoration.Parent = Me.btnMomo
        Me.btnMomo.Size = New System.Drawing.Size(202, 60)
        Me.btnMomo.TabIndex = 13
        Me.btnMomo.Text = "MoMo"
        '
        'btnCash
        '
        Me.btnCash.BorderRadius = 10
        Me.btnCash.BorderThickness = 1
        Me.btnCash.CheckedState.Parent = Me.btnCash
        Me.btnCash.CustomImages.Parent = Me.btnCash
        Me.btnCash.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCash.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnCash.ForeColor = System.Drawing.Color.Black
        Me.btnCash.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnCash.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCash.HoverState.Parent = Me.btnCash
        Me.btnCash.Location = New System.Drawing.Point(29, 272)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCash.ShadowDecoration.Parent = Me.btnCash
        Me.btnCash.Size = New System.Drawing.Size(202, 59)
        Me.btnCash.TabIndex = 13
        Me.btnCash.Text = "Cash"
        '
        'btnclear
        '
        Me.btnclear.BorderRadius = 10
        Me.btnclear.BorderThickness = 1
        Me.btnclear.CheckedState.Parent = Me.btnclear
        Me.btnclear.CustomImages.Parent = Me.btnclear
        Me.btnclear.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnclear.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnclear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclear.HoverState.Parent = Me.btnclear
        Me.btnclear.Location = New System.Drawing.Point(614, 600)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclear.ShadowDecoration.Parent = Me.btnclear
        Me.btnclear.Size = New System.Drawing.Size(180, 45)
        Me.btnclear.TabIndex = 13
        Me.btnclear.Text = "Clear"
        '
        'btnRemove
        '
        Me.btnRemove.BorderRadius = 10
        Me.btnRemove.BorderThickness = 1
        Me.btnRemove.CheckedState.Parent = Me.btnRemove
        Me.btnRemove.CustomImages.Parent = Me.btnRemove
        Me.btnRemove.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRemove.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRemove.HoverState.Parent = Me.btnRemove
        Me.btnRemove.Location = New System.Drawing.Point(816, 600)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.PressedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRemove.ShadowDecoration.Parent = Me.btnRemove
        Me.btnRemove.Size = New System.Drawing.Size(180, 45)
        Me.btnRemove.TabIndex = 13
        Me.btnRemove.Text = "Remove"
        '
        'PrintTest
        '
        Me.PrintTest.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintTest.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintTest.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintTest.Enabled = True
        Me.PrintTest.Icon = CType(resources.GetObject("PrintTest.Icon"), System.Drawing.Icon)
        Me.PrintTest.Name = "PrintTest"
        Me.PrintTest.Visible = False
        '
        'FrmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1318, 686)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.LblProduct)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.DgCart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblCost)
        Me.Controls.Add(Me.LblCart)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchase"
        Me.Text = "Uhome"
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPcode As Label
    Friend WithEvents LblPname As Label
    Friend WithEvents LblCate As Label
    Friend WithEvents LblBrand As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblProduct As Label
    Friend WithEvents LblCart As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblCost As Label
    Friend WithEvents cmbSCate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSPname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DgCart As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Pnames As DataGridViewTextBoxColumn
    Friend WithEvents pinfo As DataGridViewTextBoxColumn
    Friend WithEvents pquantity As DataGridViewTextBoxColumn
    Friend WithEvents pprice As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents PrintCash As Printing.PrintDocument
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbUnit As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents BtnPClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAddCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVocher As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMomo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintTest As PrintPreviewDialog
    Friend WithEvents PrintCard As Printing.PrintDocument
    Friend WithEvents PrintMoMo As Printing.PrintDocument
    Friend WithEvents PrintVoch As Printing.PrintDocument
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblPadd = New System.Windows.Forms.Label()
        Me.numStock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.dtend = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtmade = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.TxtPPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbBrand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbPcate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtPdinfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblPcate = New System.Windows.Forms.Label()
        Me.LblPBrand = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblPdes = New System.Windows.Forms.Label()
        Me.LblPstock = New System.Windows.Forms.Label()
        Me.LblExpiry = New System.Windows.Forms.Label()
        Me.lblmade = New System.Windows.Forms.Label()
        Me.LbPname = New System.Windows.Forms.Label()
        Me.DgBrand = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblBrand = New System.Windows.Forms.Label()
        Me.LblBname = New System.Windows.Forms.Label()
        Me.txtBname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DgvCate = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblNewCate = New System.Windows.Forms.Label()
        Me.txtCateName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblCataName = New System.Windows.Forms.Label()
        Me.productErrors = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnPclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPadd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPupdat = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlBrand = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnBAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlCate = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.divPa = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvProduct = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productErrors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBrand.SuspendLayout()
        Me.PnlCate.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.divPa.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPadd
        '
        Me.LblPadd.AutoSize = True
        Me.LblPadd.BackColor = System.Drawing.Color.Transparent
        Me.LblPadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPadd.Location = New System.Drawing.Point(624, 4)
        Me.LblPadd.Name = "LblPadd"
        Me.LblPadd.Size = New System.Drawing.Size(164, 25)
        Me.LblPadd.TabIndex = 0
        Me.LblPadd.Text = "Add New Product"
        '
        'numStock
        '
        Me.numStock.BackColor = System.Drawing.Color.Transparent
        Me.numStock.BorderColor = System.Drawing.Color.White
        Me.numStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numStock.DisabledState.Parent = Me.numStock
        Me.numStock.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numStock.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numStock.FocusedState.Parent = Me.numStock
        Me.numStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numStock.Location = New System.Drawing.Point(474, 91)
        Me.numStock.Name = "numStock"
        Me.numStock.ShadowDecoration.Parent = Me.numStock
        Me.numStock.Size = New System.Drawing.Size(169, 36)
        Me.numStock.TabIndex = 10
        '
        'dtend
        '
        Me.dtend.BaseColor = System.Drawing.Color.White
        Me.dtend.BorderColor = System.Drawing.Color.White
        Me.dtend.CustomFormat = Nothing
        Me.dtend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtend.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtend.ForeColor = System.Drawing.Color.Black
        Me.dtend.Location = New System.Drawing.Point(474, 30)
        Me.dtend.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtend.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtend.Name = "dtend"
        Me.dtend.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtend.OnPressedColor = System.Drawing.Color.Black
        Me.dtend.Size = New System.Drawing.Size(173, 30)
        Me.dtend.TabIndex = 9
        Me.dtend.Text = "19 August 2023"
        Me.dtend.Value = New Date(2023, 8, 19, 8, 51, 6, 299)
        '
        'dtmade
        '
        Me.dtmade.BaseColor = System.Drawing.Color.White
        Me.dtmade.BorderColor = System.Drawing.Color.White
        Me.dtmade.CustomFormat = Nothing
        Me.dtmade.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtmade.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtmade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtmade.ForeColor = System.Drawing.Color.Black
        Me.dtmade.Location = New System.Drawing.Point(240, 30)
        Me.dtmade.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtmade.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtmade.Name = "dtmade"
        Me.dtmade.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtmade.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtmade.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtmade.OnPressedColor = System.Drawing.Color.Black
        Me.dtmade.Size = New System.Drawing.Size(197, 30)
        Me.dtmade.TabIndex = 8
        Me.dtmade.Text = "19 August 2023"
        Me.dtmade.Value = New Date(2023, 8, 19, 8, 51, 6, 299)
        '
        'TxtPPrice
        '
        Me.TxtPPrice.BorderColor = System.Drawing.Color.White
        Me.TxtPPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPPrice.DefaultText = ""
        Me.TxtPPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPPrice.DisabledState.Parent = Me.TxtPPrice
        Me.TxtPPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPPrice.FocusedState.Parent = Me.TxtPPrice
        Me.TxtPPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPPrice.HoverState.Parent = Me.TxtPPrice
        Me.TxtPPrice.Location = New System.Drawing.Point(474, 152)
        Me.TxtPPrice.Name = "TxtPPrice"
        Me.TxtPPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPPrice.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TxtPPrice.PlaceholderText = "0.00"
        Me.TxtPPrice.SelectedText = ""
        Me.TxtPPrice.ShadowDecoration.Parent = Me.TxtPPrice
        Me.TxtPPrice.Size = New System.Drawing.Size(173, 35)
        Me.TxtPPrice.TabIndex = 7
        Me.TxtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPname
        '
        Me.TxtPname.BorderColor = System.Drawing.Color.White
        Me.TxtPname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPname.DefaultText = ""
        Me.TxtPname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPname.DisabledState.Parent = Me.TxtPname
        Me.TxtPname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPname.FocusedState.Parent = Me.TxtPname
        Me.TxtPname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPname.HoverState.Parent = Me.TxtPname
        Me.TxtPname.Location = New System.Drawing.Point(7, 30)
        Me.TxtPname.Name = "TxtPname"
        Me.TxtPname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TxtPname.PlaceholderText = "0"
        Me.TxtPname.SelectedText = ""
        Me.TxtPname.ShadowDecoration.Parent = Me.TxtPname
        Me.TxtPname.Size = New System.Drawing.Size(198, 30)
        Me.TxtPname.TabIndex = 7
        Me.TxtPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbBrand
        '
        Me.cmbBrand.BackColor = System.Drawing.Color.Transparent
        Me.cmbBrand.BorderColor = System.Drawing.Color.White
        Me.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrand.FocusedColor = System.Drawing.Color.Empty
        Me.cmbBrand.FocusedState.Parent = Me.cmbBrand
        Me.cmbBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBrand.HoverState.FillColor = System.Drawing.Color.Cyan
        Me.cmbBrand.HoverState.Parent = Me.cmbBrand
        Me.cmbBrand.ItemHeight = 30
        Me.cmbBrand.ItemsAppearance.Parent = Me.cmbBrand
        Me.cmbBrand.Location = New System.Drawing.Point(7, 91)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.ShadowDecoration.Parent = Me.cmbBrand
        Me.cmbBrand.Size = New System.Drawing.Size(198, 36)
        Me.cmbBrand.TabIndex = 6
        '
        'cmbPcate
        '
        Me.cmbPcate.BackColor = System.Drawing.Color.Transparent
        Me.cmbPcate.BorderColor = System.Drawing.Color.White
        Me.cmbPcate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPcate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPcate.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPcate.FocusedState.Parent = Me.cmbPcate
        Me.cmbPcate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPcate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPcate.FormattingEnabled = True
        Me.cmbPcate.HoverState.Parent = Me.cmbPcate
        Me.cmbPcate.ItemHeight = 30
        Me.cmbPcate.ItemsAppearance.Parent = Me.cmbPcate
        Me.cmbPcate.Location = New System.Drawing.Point(7, 161)
        Me.cmbPcate.Name = "cmbPcate"
        Me.cmbPcate.ShadowDecoration.Parent = Me.cmbPcate
        Me.cmbPcate.Size = New System.Drawing.Size(198, 36)
        Me.cmbPcate.TabIndex = 6
        '
        'TxtPdinfo
        '
        Me.TxtPdinfo.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.TxtPdinfo.BorderColor = System.Drawing.Color.White
        Me.TxtPdinfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPdinfo.DefaultText = ""
        Me.TxtPdinfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPdinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPdinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPdinfo.DisabledState.Parent = Me.TxtPdinfo
        Me.TxtPdinfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPdinfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPdinfo.FocusedState.Parent = Me.TxtPdinfo
        Me.TxtPdinfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPdinfo.HoverState.Parent = Me.TxtPdinfo
        Me.TxtPdinfo.Location = New System.Drawing.Point(235, 91)
        Me.TxtPdinfo.Multiline = True
        Me.TxtPdinfo.Name = "TxtPdinfo"
        Me.TxtPdinfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPdinfo.PlaceholderText = "Product Description"
        Me.TxtPdinfo.SelectedText = ""
        Me.TxtPdinfo.ShadowDecoration.Parent = Me.TxtPdinfo
        Me.TxtPdinfo.Size = New System.Drawing.Size(197, 106)
        Me.TxtPdinfo.TabIndex = 5
        '
        'LblPcate
        '
        Me.LblPcate.AutoSize = True
        Me.LblPcate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPcate.ForeColor = System.Drawing.Color.White
        Me.LblPcate.Location = New System.Drawing.Point(3, 138)
        Me.LblPcate.Name = "LblPcate"
        Me.LblPcate.Size = New System.Drawing.Size(81, 20)
        Me.LblPcate.TabIndex = 2
        Me.LblPcate.Text = "Category"
        '
        'LblPBrand
        '
        Me.LblPBrand.AutoSize = True
        Me.LblPBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPBrand.ForeColor = System.Drawing.Color.White
        Me.LblPBrand.Location = New System.Drawing.Point(8, 68)
        Me.LblPBrand.Name = "LblPBrand"
        Me.LblPBrand.Size = New System.Drawing.Size(57, 20)
        Me.LblPBrand.TabIndex = 2
        Me.LblPBrand.Text = "Brand"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.White
        Me.LblPrice.Location = New System.Drawing.Point(479, 130)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(49, 20)
        Me.LblPrice.TabIndex = 2
        Me.LblPrice.Text = "Price"
        '
        'LblPdes
        '
        Me.LblPdes.AutoSize = True
        Me.LblPdes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPdes.ForeColor = System.Drawing.Color.White
        Me.LblPdes.Location = New System.Drawing.Point(231, 68)
        Me.LblPdes.Name = "LblPdes"
        Me.LblPdes.Size = New System.Drawing.Size(100, 20)
        Me.LblPdes.TabIndex = 2
        Me.LblPdes.Text = "Description"
        '
        'LblPstock
        '
        Me.LblPstock.AutoSize = True
        Me.LblPstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPstock.ForeColor = System.Drawing.Color.White
        Me.LblPstock.Location = New System.Drawing.Point(470, 68)
        Me.LblPstock.Name = "LblPstock"
        Me.LblPstock.Size = New System.Drawing.Size(117, 20)
        Me.LblPstock.TabIndex = 2
        Me.LblPstock.Text = "Current stock"
        '
        'LblExpiry
        '
        Me.LblExpiry.AutoSize = True
        Me.LblExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpiry.ForeColor = System.Drawing.Color.White
        Me.LblExpiry.Location = New System.Drawing.Point(481, 7)
        Me.LblExpiry.Name = "LblExpiry"
        Me.LblExpiry.Size = New System.Drawing.Size(101, 20)
        Me.LblExpiry.TabIndex = 2
        Me.LblExpiry.Text = "Expiry Date"
        '
        'lblmade
        '
        Me.lblmade.AutoSize = True
        Me.lblmade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmade.ForeColor = System.Drawing.Color.White
        Me.lblmade.Location = New System.Drawing.Point(235, 7)
        Me.lblmade.Name = "lblmade"
        Me.lblmade.Size = New System.Drawing.Size(154, 20)
        Me.lblmade.TabIndex = 2
        Me.lblmade.Text = "Manufacture Date"
        '
        'LbPname
        '
        Me.LbPname.AutoSize = True
        Me.LbPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPname.ForeColor = System.Drawing.Color.White
        Me.LbPname.Location = New System.Drawing.Point(8, 7)
        Me.LbPname.Name = "LbPname"
        Me.LbPname.Size = New System.Drawing.Size(122, 20)
        Me.LbPname.TabIndex = 2
        Me.LbPname.Text = "Product Name"
        '
        'DgBrand
        '
        Me.DgBrand.AllowUserToAddRows = False
        Me.DgBrand.AllowUserToResizeColumns = False
        Me.DgBrand.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgBrand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBrand.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgBrand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgBrand.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgBrand.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgBrand.EnableHeadersVisualStyles = False
        Me.DgBrand.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgBrand.Location = New System.Drawing.Point(37, 18)
        Me.DgBrand.Name = "DgBrand"
        Me.DgBrand.ReadOnly = True
        Me.DgBrand.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgBrand.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgBrand.Size = New System.Drawing.Size(288, 264)
        Me.DgBrand.TabIndex = 5
        Me.DgBrand.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgBrand.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgBrand.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgBrand.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgBrand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgBrand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgBrand.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgBrand.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgBrand.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgBrand.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgBrand.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgBrand.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgBrand.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgBrand.ThemeStyle.HeaderStyle.Height = 30
        Me.DgBrand.ThemeStyle.ReadOnly = True
        Me.DgBrand.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgBrand.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgBrand.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgBrand.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgBrand.ThemeStyle.RowsStyle.Height = 22
        Me.DgBrand.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgBrand.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBrand.Location = New System.Drawing.Point(359, 9)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(149, 25)
        Me.LblBrand.TabIndex = 0
        Me.LblBrand.Text = "Add New Brand"
        '
        'LblBname
        '
        Me.LblBname.AutoSize = True
        Me.LblBname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBname.ForeColor = System.Drawing.Color.Transparent
        Me.LblBname.Location = New System.Drawing.Point(19, 24)
        Me.LblBname.Name = "LblBname"
        Me.LblBname.Size = New System.Drawing.Size(98, 20)
        Me.LblBname.TabIndex = 3
        Me.LblBname.Text = "Brand Name"
        '
        'txtBname
        '
        Me.txtBname.BorderColor = System.Drawing.Color.White
        Me.txtBname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBname.DefaultText = ""
        Me.txtBname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBname.DisabledState.Parent = Me.txtBname
        Me.txtBname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBname.FocusedState.Parent = Me.txtBname
        Me.txtBname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBname.HoverState.Parent = Me.txtBname
        Me.txtBname.Location = New System.Drawing.Point(23, 47)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBname.PlaceholderText = ""
        Me.txtBname.SelectedText = ""
        Me.txtBname.ShadowDecoration.Parent = Me.txtBname
        Me.txtBname.Size = New System.Drawing.Size(222, 36)
        Me.txtBname.TabIndex = 6
        '
        'DgvCate
        '
        Me.DgvCate.AllowUserToAddRows = False
        Me.DgvCate.AllowUserToResizeColumns = False
        Me.DgvCate.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DgvCate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvCate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvCate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvCate.ColumnHeadersHeight = 30
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCate.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvCate.EnableHeadersVisualStyles = False
        Me.DgvCate.GridColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCate.Location = New System.Drawing.Point(28, 18)
        Me.DgvCate.Name = "DgvCate"
        Me.DgvCate.ReadOnly = True
        Me.DgvCate.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCate.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCate.Size = New System.Drawing.Size(288, 264)
        Me.DgvCate.TabIndex = 4
        Me.DgvCate.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvCate.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvCate.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvCate.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvCate.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvCate.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvCate.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvCate.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCate.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Cyan
        Me.DgvCate.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgvCate.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvCate.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvCate.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvCate.ThemeStyle.HeaderStyle.Height = 30
        Me.DgvCate.ThemeStyle.ReadOnly = True
        Me.DgvCate.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvCate.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvCate.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvCate.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvCate.ThemeStyle.RowsStyle.Height = 22
        Me.DgvCate.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvCate.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'LblNewCate
        '
        Me.LblNewCate.AutoSize = True
        Me.LblNewCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewCate.Location = New System.Drawing.Point(370, 16)
        Me.LblNewCate.Name = "LblNewCate"
        Me.LblNewCate.Size = New System.Drawing.Size(191, 25)
        Me.LblNewCate.TabIndex = 0
        Me.LblNewCate.Text = "Add New Category"
        '
        'txtCateName
        '
        Me.txtCateName.BorderColor = System.Drawing.Color.White
        Me.txtCateName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCateName.DefaultText = ""
        Me.txtCateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCateName.DisabledState.Parent = Me.txtCateName
        Me.txtCateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCateName.FocusedState.Parent = Me.txtCateName
        Me.txtCateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCateName.HoverState.Parent = Me.txtCateName
        Me.txtCateName.Location = New System.Drawing.Point(18, 53)
        Me.txtCateName.Name = "txtCateName"
        Me.txtCateName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCateName.PlaceholderText = ""
        Me.txtCateName.SelectedText = ""
        Me.txtCateName.ShadowDecoration.Parent = Me.txtCateName
        Me.txtCateName.Size = New System.Drawing.Size(222, 36)
        Me.txtCateName.TabIndex = 7
        '
        'LblCataName
        '
        Me.LblCataName.AutoSize = True
        Me.LblCataName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCataName.ForeColor = System.Drawing.Color.White
        Me.LblCataName.Location = New System.Drawing.Point(14, 27)
        Me.LblCataName.Name = "LblCataName"
        Me.LblCataName.Size = New System.Drawing.Size(141, 24)
        Me.LblCataName.TabIndex = 3
        Me.LblCataName.Text = "Category Name"
        '
        'productErrors
        '
        Me.productErrors.ContainerControl = Me
        '
        'btnPclear
        '
        Me.btnPclear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPclear.BorderRadius = 12
        Me.btnPclear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnPclear.BorderThickness = 2
        Me.btnPclear.CheckedState.Parent = Me.btnPclear
        Me.btnPclear.CustomImages.Parent = Me.btnPclear
        Me.btnPclear.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPclear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPclear.ForeColor = System.Drawing.Color.White
        Me.btnPclear.HoverState.Parent = Me.btnPclear
        Me.btnPclear.Location = New System.Drawing.Point(932, 247)
        Me.btnPclear.Name = "btnPclear"
        Me.btnPclear.ShadowDecoration.Parent = Me.btnPclear
        Me.btnPclear.Size = New System.Drawing.Size(82, 45)
        Me.btnPclear.TabIndex = 4
        Me.btnPclear.Text = "Clear"
        '
        'btnPadd
        '
        Me.btnPadd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPadd.BorderRadius = 12
        Me.btnPadd.BorderThickness = 2
        Me.btnPadd.CheckedState.Parent = Me.btnPadd
        Me.btnPadd.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPadd.CustomImages.Parent = Me.btnPadd
        Me.btnPadd.FillColor = System.Drawing.Color.Teal
        Me.btnPadd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPadd.ForeColor = System.Drawing.Color.White
        Me.btnPadd.HoverState.Parent = Me.btnPadd
        Me.btnPadd.Location = New System.Drawing.Point(838, 247)
        Me.btnPadd.Name = "btnPadd"
        Me.btnPadd.ShadowDecoration.Parent = Me.btnPadd
        Me.btnPadd.Size = New System.Drawing.Size(88, 45)
        Me.btnPadd.TabIndex = 4
        Me.btnPadd.Text = "Add"
        '
        'BtnPupdat
        '
        Me.BtnPupdat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPupdat.BorderRadius = 12
        Me.BtnPupdat.BorderThickness = 2
        Me.BtnPupdat.CheckedState.Parent = Me.BtnPupdat
        Me.BtnPupdat.CustomBorderColor = System.Drawing.Color.Blue
        Me.BtnPupdat.CustomImages.Parent = Me.BtnPupdat
        Me.BtnPupdat.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPupdat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPupdat.ForeColor = System.Drawing.Color.White
        Me.BtnPupdat.HoverState.Parent = Me.BtnPupdat
        Me.BtnPupdat.Location = New System.Drawing.Point(332, 252)
        Me.BtnPupdat.Name = "BtnPupdat"
        Me.BtnPupdat.ShadowDecoration.Parent = Me.BtnPupdat
        Me.BtnPupdat.Size = New System.Drawing.Size(114, 40)
        Me.BtnPupdat.TabIndex = 4
        Me.BtnPupdat.Text = "Update"
        '
        'BtnPdelete
        '
        Me.BtnPdelete.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPdelete.BorderRadius = 12
        Me.BtnPdelete.BorderThickness = 2
        Me.BtnPdelete.CheckedState.Parent = Me.BtnPdelete
        Me.BtnPdelete.CustomBorderColor = System.Drawing.Color.Blue
        Me.BtnPdelete.CustomImages.Parent = Me.BtnPdelete
        Me.BtnPdelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPdelete.ForeColor = System.Drawing.Color.White
        Me.BtnPdelete.HoverState.Parent = Me.BtnPdelete
        Me.BtnPdelete.Location = New System.Drawing.Point(452, 252)
        Me.BtnPdelete.Name = "BtnPdelete"
        Me.BtnPdelete.ShadowDecoration.Parent = Me.BtnPdelete
        Me.BtnPdelete.Size = New System.Drawing.Size(107, 40)
        Me.BtnPdelete.TabIndex = 4
        Me.BtnPdelete.Text = "Delete"
        '
        'btnBupdate
        '
        Me.btnBupdate.BorderColor = System.Drawing.Color.Navy
        Me.btnBupdate.BorderRadius = 12
        Me.btnBupdate.BorderThickness = 2
        Me.btnBupdate.CheckedState.Parent = Me.btnBupdate
        Me.btnBupdate.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnBupdate.CustomImages.Parent = Me.btnBupdate
        Me.btnBupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBupdate.ForeColor = System.Drawing.Color.White
        Me.btnBupdate.HoverState.Parent = Me.btnBupdate
        Me.btnBupdate.Location = New System.Drawing.Point(211, 298)
        Me.btnBupdate.Name = "btnBupdate"
        Me.btnBupdate.ShadowDecoration.Parent = Me.btnBupdate
        Me.btnBupdate.Size = New System.Drawing.Size(114, 33)
        Me.btnBupdate.TabIndex = 4
        Me.btnBupdate.Text = "Update"
        '
        'btnBdelete
        '
        Me.btnBdelete.BorderColor = System.Drawing.Color.Navy
        Me.btnBdelete.BorderRadius = 12
        Me.btnBdelete.BorderThickness = 2
        Me.btnBdelete.CheckedState.Parent = Me.btnBdelete
        Me.btnBdelete.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnBdelete.CustomImages.Parent = Me.btnBdelete
        Me.btnBdelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBdelete.ForeColor = System.Drawing.Color.White
        Me.btnBdelete.HoverState.Parent = Me.btnBdelete
        Me.btnBdelete.Location = New System.Drawing.Point(37, 298)
        Me.btnBdelete.Name = "btnBdelete"
        Me.btnBdelete.ShadowDecoration.Parent = Me.btnBdelete
        Me.btnBdelete.Size = New System.Drawing.Size(123, 33)
        Me.btnBdelete.TabIndex = 4
        Me.btnBdelete.Text = "Delete"
        '
        'btnCupdate
        '
        Me.btnCupdate.BorderColor = System.Drawing.Color.Navy
        Me.btnCupdate.BorderRadius = 12
        Me.btnCupdate.BorderThickness = 2
        Me.btnCupdate.CheckedState.Parent = Me.btnCupdate
        Me.btnCupdate.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnCupdate.CustomImages.Parent = Me.btnCupdate
        Me.btnCupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCupdate.ForeColor = System.Drawing.Color.White
        Me.btnCupdate.HoverState.Parent = Me.btnCupdate
        Me.btnCupdate.Location = New System.Drawing.Point(202, 298)
        Me.btnCupdate.Name = "btnCupdate"
        Me.btnCupdate.ShadowDecoration.Parent = Me.btnCupdate
        Me.btnCupdate.Size = New System.Drawing.Size(114, 33)
        Me.btnCupdate.TabIndex = 4
        Me.btnCupdate.Text = "Update"
        '
        'btnCdelete
        '
        Me.btnCdelete.BorderColor = System.Drawing.Color.Navy
        Me.btnCdelete.BorderRadius = 12
        Me.btnCdelete.BorderThickness = 2
        Me.btnCdelete.CheckedState.Parent = Me.btnCdelete
        Me.btnCdelete.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnCdelete.CustomImages.Parent = Me.btnCdelete
        Me.btnCdelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCdelete.ForeColor = System.Drawing.Color.White
        Me.btnCdelete.HoverState.Parent = Me.btnCdelete
        Me.btnCdelete.Location = New System.Drawing.Point(28, 298)
        Me.btnCdelete.Name = "btnCdelete"
        Me.btnCdelete.ShadowDecoration.Parent = Me.btnCdelete
        Me.btnCdelete.Size = New System.Drawing.Size(123, 33)
        Me.btnCdelete.TabIndex = 4
        Me.btnCdelete.Text = "Delete"
        '
        'pnlBrand
        '
        Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlBrand.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlBrand.BorderRadius = 10
        Me.pnlBrand.BorderThickness = 1
        Me.pnlBrand.Controls.Add(Me.btnBAdd)
        Me.pnlBrand.Controls.Add(Me.txtBname)
        Me.pnlBrand.Controls.Add(Me.LblBname)
        Me.pnlBrand.Location = New System.Drawing.Point(335, 28)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.ShadowDecoration.Parent = Me.pnlBrand
        Me.pnlBrand.Size = New System.Drawing.Size(264, 171)
        Me.pnlBrand.TabIndex = 7
        '
        'btnBAdd
        '
        Me.btnBAdd.BorderColor = System.Drawing.Color.White
        Me.btnBAdd.BorderRadius = 12
        Me.btnBAdd.BorderThickness = 2
        Me.btnBAdd.CheckedState.Parent = Me.btnBAdd
        Me.btnBAdd.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnBAdd.CustomImages.Parent = Me.btnBAdd
        Me.btnBAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBAdd.ForeColor = System.Drawing.Color.White
        Me.btnBAdd.HoverState.Parent = Me.btnBAdd
        Me.btnBAdd.Location = New System.Drawing.Point(57, 113)
        Me.btnBAdd.Name = "btnBAdd"
        Me.btnBAdd.ShadowDecoration.Parent = Me.btnBAdd
        Me.btnBAdd.Size = New System.Drawing.Size(137, 45)
        Me.btnBAdd.TabIndex = 4
        Me.btnBAdd.Text = "Add"
        '
        'PnlCate
        '
        Me.PnlCate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCate.BorderColor = System.Drawing.Color.Black
        Me.PnlCate.BorderRadius = 10
        Me.PnlCate.BorderThickness = 1
        Me.PnlCate.Controls.Add(Me.btnCAdd)
        Me.PnlCate.Controls.Add(Me.txtCateName)
        Me.PnlCate.Controls.Add(Me.LblCataName)
        Me.PnlCate.Location = New System.Drawing.Point(347, 28)
        Me.PnlCate.Name = "PnlCate"
        Me.PnlCate.ShadowDecoration.Parent = Me.PnlCate
        Me.PnlCate.Size = New System.Drawing.Size(274, 177)
        Me.PnlCate.TabIndex = 8
        '
        'btnCAdd
        '
        Me.btnCAdd.BorderColor = System.Drawing.Color.White
        Me.btnCAdd.BorderRadius = 12
        Me.btnCAdd.BorderThickness = 2
        Me.btnCAdd.CheckedState.Parent = Me.btnCAdd
        Me.btnCAdd.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnCAdd.CustomImages.Parent = Me.btnCAdd
        Me.btnCAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCAdd.ForeColor = System.Drawing.Color.White
        Me.btnCAdd.HoverState.Parent = Me.btnCAdd
        Me.btnCAdd.Location = New System.Drawing.Point(66, 113)
        Me.btnCAdd.Name = "btnCAdd"
        Me.btnCAdd.ShadowDecoration.Parent = Me.btnCAdd
        Me.btnCAdd.Size = New System.Drawing.Size(137, 45)
        Me.btnCAdd.TabIndex = 4
        Me.btnCAdd.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.numStock)
        Me.Guna2Panel1.Controls.Add(Me.LbPname)
        Me.Guna2Panel1.Controls.Add(Me.dtmade)
        Me.Guna2Panel1.Controls.Add(Me.dtend)
        Me.Guna2Panel1.Controls.Add(Me.lblmade)
        Me.Guna2Panel1.Controls.Add(Me.LblExpiry)
        Me.Guna2Panel1.Controls.Add(Me.TxtPPrice)
        Me.Guna2Panel1.Controls.Add(Me.LblPstock)
        Me.Guna2Panel1.Controls.Add(Me.TxtPname)
        Me.Guna2Panel1.Controls.Add(Me.LblPdes)
        Me.Guna2Panel1.Controls.Add(Me.LblPrice)
        Me.Guna2Panel1.Controls.Add(Me.cmbBrand)
        Me.Guna2Panel1.Controls.Add(Me.LblPBrand)
        Me.Guna2Panel1.Controls.Add(Me.cmbPcate)
        Me.Guna2Panel1.Controls.Add(Me.LblPcate)
        Me.Guna2Panel1.Controls.Add(Me.TxtPdinfo)
        Me.Guna2Panel1.Location = New System.Drawing.Point(610, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(680, 211)
        Me.Guna2Panel1.TabIndex = 9
        '
        'divPa
        '
        Me.divPa.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.divPa.BorderThickness = 1
        Me.divPa.Controls.Add(Me.LblNewCate)
        Me.divPa.Controls.Add(Me.PnlCate)
        Me.divPa.Controls.Add(Me.DgvCate)
        Me.divPa.Controls.Add(Me.btnCupdate)
        Me.divPa.Controls.Add(Me.btnCdelete)
        Me.divPa.Location = New System.Drawing.Point(610, 303)
        Me.divPa.Name = "divPa"
        Me.divPa.ShadowDecoration.Parent = Me.divPa
        Me.divPa.Size = New System.Drawing.Size(747, 377)
        Me.divPa.TabIndex = 10
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.btnBdelete)
        Me.Guna2Panel2.Controls.Add(Me.LblBrand)
        Me.Guna2Panel2.Controls.Add(Me.btnBupdate)
        Me.Guna2Panel2.Controls.Add(Me.pnlBrand)
        Me.Guna2Panel2.Controls.Add(Me.DgBrand)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-25, 303)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(641, 377)
        Me.Guna2Panel2.TabIndex = 11
        '
        'DgvProduct
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.DgvProduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvProduct.ColumnHeadersHeight = 30
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvProduct.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgvProduct.EnableHeadersVisualStyles = False
        Me.DgvProduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProduct.Location = New System.Drawing.Point(23, 25)
        Me.DgvProduct.Name = "DgvProduct"
        Me.DgvProduct.RowHeadersVisible = False
        Me.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProduct.Size = New System.Drawing.Size(562, 221)
        Me.DgvProduct.TabIndex = 12
        Me.DgvProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvProduct.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvProduct.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgvProduct.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvProduct.ThemeStyle.HeaderStyle.Height = 30
        Me.DgvProduct.ThemeStyle.ReadOnly = False
        Me.DgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvProduct.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvProduct.ThemeStyle.RowsStyle.Height = 22
        Me.DgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1321, 681)
        Me.Controls.Add(Me.DgvProduct)
        Me.Controls.Add(Me.LblPadd)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnPclear)
        Me.Controls.Add(Me.BtnPdelete)
        Me.Controls.Add(Me.BtnPupdat)
        Me.Controls.Add(Me.btnPadd)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.divPa)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.Text = "frmProduct"
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productErrors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.PnlCate.ResumeLayout(False)
        Me.PnlCate.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.divPa.ResumeLayout(False)
        Me.divPa.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.DgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPadd As Label
    Friend WithEvents LblPcate As Label
    Friend WithEvents LblPBrand As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents LblPstock As Label
    Friend WithEvents LbPname As Label
    Friend WithEvents LblBrand As Label
    Friend WithEvents LblBname As Label
    Friend WithEvents LblNewCate As Label
    Friend WithEvents LblCataName As Label
    Friend WithEvents TxtPdinfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblPdes As Label
    Friend WithEvents cmbBrand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbPcate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtPPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents productErrors As ErrorProvider
    Friend WithEvents DgBrand As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DgvCate As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtBname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCateName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtend As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtmade As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents LblExpiry As Label
    Friend WithEvents lblmade As Label
    Friend WithEvents btnPadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlCate As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlBrand As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPupdat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents numStock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents divPa As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvProduct As Guna.UI2.WinForms.Guna2DataGridView
End Class

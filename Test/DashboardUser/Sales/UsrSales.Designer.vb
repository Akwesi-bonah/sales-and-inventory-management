<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrSales
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
        Me.CmbSearch = New System.Windows.Forms.ComboBox()
        Me.LbQnty = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TxtQnty = New System.Windows.Forms.TextBox()
        Me.BtnCash = New System.Windows.Forms.Button()
        Me.BtnCard = New System.Windows.Forms.Button()
        Me.BtnMoMo = New System.Windows.Forms.Button()
        Me.BtnVoid = New System.Windows.Forms.Button()
        Me.BtnAddCart = New System.Windows.Forms.Button()
        Me.BtnVoucher = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LbPname = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LbPprice = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LbCat = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LbPid = New System.Windows.Forms.Label()
        Me.DgCart = New System.Windows.Forms.DataGridView()
        Me.TranscationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Location = New System.Drawing.Point(469, 302)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(214, 33)
        Me.CmbSearch.TabIndex = 33
        '
        'LbQnty
        '
        Me.LbQnty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbQnty.AutoSize = True
        Me.LbQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbQnty.Location = New System.Drawing.Point(755, 262)
        Me.LbQnty.Name = "LbQnty"
        Me.LbQnty.Size = New System.Drawing.Size(78, 24)
        Me.LbQnty.TabIndex = 32
        Me.LbQnty.Text = "Quantity"
        '
        'LblSearch
        '
        Me.LblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(479, 275)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(70, 24)
        Me.LblSearch.TabIndex = 31
        Me.LblSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Amount Due"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(655, 478)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(196, 29)
        Me.TextBox6.TabIndex = 29
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtQnty
        '
        Me.TxtQnty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQnty.Location = New System.Drawing.Point(710, 300)
        Me.TxtQnty.Name = "TxtQnty"
        Me.TxtQnty.Size = New System.Drawing.Size(140, 29)
        Me.TxtQnty.TabIndex = 28
        Me.TxtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCash
        '
        Me.BtnCash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCash.Location = New System.Drawing.Point(469, 400)
        Me.BtnCash.Name = "BtnCash"
        Me.BtnCash.Size = New System.Drawing.Size(214, 64)
        Me.BtnCash.TabIndex = 26
        Me.BtnCash.Text = "Cash"
        Me.BtnCash.UseVisualStyleBackColor = True
        '
        'BtnCard
        '
        Me.BtnCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCard.Location = New System.Drawing.Point(710, 430)
        Me.BtnCard.Name = "BtnCard"
        Me.BtnCard.Size = New System.Drawing.Size(140, 34)
        Me.BtnCard.TabIndex = 25
        Me.BtnCard.Text = "Card"
        Me.BtnCard.UseVisualStyleBackColor = True
        '
        'BtnMoMo
        '
        Me.BtnMoMo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMoMo.Location = New System.Drawing.Point(710, 390)
        Me.BtnMoMo.Name = "BtnMoMo"
        Me.BtnMoMo.Size = New System.Drawing.Size(140, 34)
        Me.BtnMoMo.TabIndex = 24
        Me.BtnMoMo.Text = "Mobile money"
        Me.BtnMoMo.UseVisualStyleBackColor = True
        '
        'BtnVoid
        '
        Me.BtnVoid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVoid.Location = New System.Drawing.Point(589, 347)
        Me.BtnVoid.Name = "BtnVoid"
        Me.BtnVoid.Size = New System.Drawing.Size(94, 48)
        Me.BtnVoid.TabIndex = 27
        Me.BtnVoid.Text = "Void"
        Me.BtnVoid.UseVisualStyleBackColor = True
        '
        'BtnAddCart
        '
        Me.BtnAddCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAddCart.Location = New System.Drawing.Point(469, 347)
        Me.BtnAddCart.Name = "BtnAddCart"
        Me.BtnAddCart.Size = New System.Drawing.Size(100, 48)
        Me.BtnAddCart.TabIndex = 23
        Me.BtnAddCart.Text = "Add Cart"
        Me.BtnAddCart.UseVisualStyleBackColor = True
        '
        'BtnVoucher
        '
        Me.BtnVoucher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVoucher.Location = New System.Drawing.Point(710, 341)
        Me.BtnVoucher.Name = "BtnVoucher"
        Me.BtnVoucher.Size = New System.Drawing.Size(141, 42)
        Me.BtnVoucher.TabIndex = 22
        Me.BtnVoucher.Text = "Voucher"
        Me.BtnVoucher.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(137, 332)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(217, 29)
        Me.TextBox3.TabIndex = 21
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbPname
        '
        Me.LbPname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPname.AutoSize = True
        Me.LbPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPname.Location = New System.Drawing.Point(25, 337)
        Me.LbPname.Name = "LbPname"
        Me.LbPname.Size = New System.Drawing.Size(61, 24)
        Me.LbPname.TabIndex = 16
        Me.LbPname.Text = "Name"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(137, 445)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(217, 29)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbPprice
        '
        Me.LbPprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPprice.AutoSize = True
        Me.LbPprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPprice.Location = New System.Drawing.Point(25, 445)
        Me.LbPprice.Name = "LbPprice"
        Me.LbPprice.Size = New System.Drawing.Size(53, 24)
        Me.LbPprice.TabIndex = 15
        Me.LbPprice.Text = "Price"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(137, 390)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(217, 29)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbCat
        '
        Me.LbCat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbCat.AutoSize = True
        Me.LbCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCat.Location = New System.Drawing.Point(25, 390)
        Me.LbCat.Name = "LbCat"
        Me.LbCat.Size = New System.Drawing.Size(85, 24)
        Me.LbCat.TabIndex = 14
        Me.LbCat.Text = "Category"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(137, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(217, 29)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbPid
        '
        Me.LbPid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPid.AutoSize = True
        Me.LbPid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPid.Location = New System.Drawing.Point(25, 281)
        Me.LbPid.Name = "LbPid"
        Me.LbPid.Size = New System.Drawing.Size(97, 24)
        Me.LbPid.TabIndex = 17
        Me.LbPid.Text = "Product ID"
        '
        'DgCart
        '
        Me.DgCart.AllowUserToAddRows = False
        Me.DgCart.AllowUserToDeleteRows = False
        Me.DgCart.AllowUserToResizeColumns = False
        Me.DgCart.AllowUserToResizeRows = False
        Me.DgCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TranscationID, Me.ProductID, Me.ProductName, Me.Quantity, Me.Price})
        Me.DgCart.Location = New System.Drawing.Point(23, 34)
        Me.DgCart.Name = "DgCart"
        Me.DgCart.ReadOnly = True
        Me.DgCart.Size = New System.Drawing.Size(827, 203)
        Me.DgCart.TabIndex = 13
        '
        'TranscationID
        '
        Me.TranscationID.HeaderText = "TranscationID"
        Me.TranscationID.Name = "TranscationID"
        Me.TranscationID.ReadOnly = True
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'UsrSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 540)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.LbQnty)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TxtQnty)
        Me.Controls.Add(Me.BtnCash)
        Me.Controls.Add(Me.BtnCard)
        Me.Controls.Add(Me.BtnMoMo)
        Me.Controls.Add(Me.BtnVoid)
        Me.Controls.Add(Me.BtnAddCart)
        Me.Controls.Add(Me.BtnVoucher)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LbPname)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.LbPprice)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LbCat)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LbPid)
        Me.Controls.Add(Me.DgCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsrSales"
        Me.Text = "UsrSales"
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSearch As ComboBox
    Friend WithEvents LbQnty As Label
    Friend WithEvents LblSearch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TxtQnty As TextBox
    Friend WithEvents BtnCash As Button
    Friend WithEvents BtnCard As Button
    Friend WithEvents BtnMoMo As Button
    Friend WithEvents BtnVoid As Button
    Friend WithEvents BtnAddCart As Button
    Friend WithEvents BtnVoucher As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LbPname As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LbPprice As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LbCat As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LbPid As Label
    Friend WithEvents DgCart As DataGridView
    Friend WithEvents TranscationID As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Me.DgCart = New System.Windows.Forms.DataGridView()
        Me.LbPid = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnVoucher = New System.Windows.Forms.Button()
        Me.LbCat = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LbPname = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnMoMo = New System.Windows.Forms.Button()
        Me.BtnCard = New System.Windows.Forms.Button()
        Me.BtnCash = New System.Windows.Forms.Button()
        Me.BtnAddCart = New System.Windows.Forms.Button()
        Me.BtnVoid = New System.Windows.Forms.Button()
        Me.TxtQnty = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.LbQnty = New System.Windows.Forms.Label()
        Me.CmbSearch = New System.Windows.Forms.ComboBox()
        Me.TranscationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbPprice = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DgCart.Location = New System.Drawing.Point(27, 59)
        Me.DgCart.Name = "DgCart"
        Me.DgCart.ReadOnly = True
        Me.DgCart.Size = New System.Drawing.Size(827, 203)
        Me.DgCart.TabIndex = 3
        '
        'LbPid
        '
        Me.LbPid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPid.AutoSize = True
        Me.LbPid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPid.Location = New System.Drawing.Point(29, 306)
        Me.LbPid.Name = "LbPid"
        Me.LbPid.Size = New System.Drawing.Size(97, 24)
        Me.LbPid.TabIndex = 4
        Me.LbPid.Text = "Product ID"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(141, 306)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(217, 29)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnVoucher
        '
        Me.BtnVoucher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVoucher.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnVoucher.Location = New System.Drawing.Point(714, 366)
        Me.BtnVoucher.Name = "BtnVoucher"
        Me.BtnVoucher.Size = New System.Drawing.Size(141, 42)
        Me.BtnVoucher.TabIndex = 6
        Me.BtnVoucher.Text = "Voucher"
        Me.BtnVoucher.UseVisualStyleBackColor = False
        '
        'LbCat
        '
        Me.LbCat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbCat.AutoSize = True
        Me.LbCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCat.Location = New System.Drawing.Point(29, 415)
        Me.LbCat.Name = "LbCat"
        Me.LbCat.Size = New System.Drawing.Size(85, 24)
        Me.LbCat.TabIndex = 4
        Me.LbCat.Text = "Category"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(141, 415)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(217, 29)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbPname
        '
        Me.LbPname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPname.AutoSize = True
        Me.LbPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPname.Location = New System.Drawing.Point(29, 362)
        Me.LbPname.Name = "LbPname"
        Me.LbPname.Size = New System.Drawing.Size(61, 24)
        Me.LbPname.TabIndex = 4
        Me.LbPname.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(141, 357)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(217, 29)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnMoMo
        '
        Me.BtnMoMo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMoMo.BackColor = System.Drawing.Color.Cyan
        Me.BtnMoMo.Location = New System.Drawing.Point(714, 415)
        Me.BtnMoMo.Name = "BtnMoMo"
        Me.BtnMoMo.Size = New System.Drawing.Size(140, 34)
        Me.BtnMoMo.TabIndex = 6
        Me.BtnMoMo.Text = "Mobile money"
        Me.BtnMoMo.UseVisualStyleBackColor = False
        '
        'BtnCard
        '
        Me.BtnCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCard.BackColor = System.Drawing.Color.Cyan
        Me.BtnCard.Location = New System.Drawing.Point(714, 455)
        Me.BtnCard.Name = "BtnCard"
        Me.BtnCard.Size = New System.Drawing.Size(140, 34)
        Me.BtnCard.TabIndex = 6
        Me.BtnCard.Text = "Card"
        Me.BtnCard.UseVisualStyleBackColor = False
        '
        'BtnCash
        '
        Me.BtnCash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCash.BackColor = System.Drawing.Color.Cyan
        Me.BtnCash.Location = New System.Drawing.Point(473, 425)
        Me.BtnCash.Name = "BtnCash"
        Me.BtnCash.Size = New System.Drawing.Size(214, 64)
        Me.BtnCash.TabIndex = 6
        Me.BtnCash.Text = "Cash"
        Me.BtnCash.UseVisualStyleBackColor = False
        '
        'BtnAddCart
        '
        Me.BtnAddCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAddCart.BackColor = System.Drawing.Color.Cyan
        Me.BtnAddCart.Location = New System.Drawing.Point(473, 372)
        Me.BtnAddCart.Name = "BtnAddCart"
        Me.BtnAddCart.Size = New System.Drawing.Size(100, 48)
        Me.BtnAddCart.TabIndex = 6
        Me.BtnAddCart.Text = "Add Cart"
        Me.BtnAddCart.UseVisualStyleBackColor = False
        '
        'BtnVoid
        '
        Me.BtnVoid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVoid.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnVoid.Location = New System.Drawing.Point(593, 372)
        Me.BtnVoid.Name = "BtnVoid"
        Me.BtnVoid.Size = New System.Drawing.Size(94, 48)
        Me.BtnVoid.TabIndex = 6
        Me.BtnVoid.Text = "Void"
        Me.BtnVoid.UseVisualStyleBackColor = False
        '
        'TxtQnty
        '
        Me.TxtQnty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQnty.Location = New System.Drawing.Point(714, 325)
        Me.TxtQnty.Name = "TxtQnty"
        Me.TxtQnty.Size = New System.Drawing.Size(140, 29)
        Me.TxtQnty.TabIndex = 7
        Me.TxtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(659, 503)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(196, 29)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 506)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Amount Due"
        '
        'LblSearch
        '
        Me.LblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LblSearch.Location = New System.Drawing.Point(483, 300)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(70, 24)
        Me.LblSearch.TabIndex = 10
        Me.LblSearch.Text = "Search"
        '
        'LbQnty
        '
        Me.LbQnty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbQnty.AutoSize = True
        Me.LbQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbQnty.Location = New System.Drawing.Point(759, 287)
        Me.LbQnty.Name = "LbQnty"
        Me.LbQnty.Size = New System.Drawing.Size(78, 24)
        Me.LbQnty.TabIndex = 11
        Me.LbQnty.Text = "Quantity"
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Location = New System.Drawing.Point(473, 327)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(214, 33)
        Me.CmbSearch.TabIndex = 12
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
        'LbPprice
        '
        Me.LbPprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbPprice.AutoSize = True
        Me.LbPprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPprice.Location = New System.Drawing.Point(29, 470)
        Me.LbPprice.Name = "LbPprice"
        Me.LbPprice.Size = New System.Drawing.Size(53, 24)
        Me.LbPprice.TabIndex = 4
        Me.LbPprice.Text = "Price"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(141, 470)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(217, 29)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 579)
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
        Me.Name = "Sales"
        Me.ShowIcon = False
        Me.Text = "Sales"
        CType(Me.DgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgCart As DataGridView
    Friend WithEvents LbPid As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnVoucher As Button
    Friend WithEvents LbCat As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LbPname As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnMoMo As Button
    Friend WithEvents BtnCard As Button
    Friend WithEvents BtnCash As Button
    Friend WithEvents BtnAddCart As Button
    Friend WithEvents BtnVoid As Button
    Friend WithEvents TxtQnty As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSearch As Label
    Friend WithEvents LbQnty As Label
    Friend WithEvents CmbSearch As ComboBox
    Friend WithEvents TranscationID As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents LbPprice As Label
    Friend WithEvents TextBox4 As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrHome
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
        Me.PnlContainer = New System.Windows.Forms.Panel()
        Me.PlControls = New System.Windows.Forms.Panel()
        Me.LbSignOut = New System.Windows.Forms.Label()
        Me.LbExit = New System.Windows.Forms.Label()
        Me.LbItems = New System.Windows.Forms.Label()
        Me.LblInvoice = New System.Windows.Forms.Label()
        Me.PtInvoice = New System.Windows.Forms.PictureBox()
        Me.PtExit = New System.Windows.Forms.PictureBox()
        Me.PtSignOut = New System.Windows.Forms.PictureBox()
        Me.PtItems = New System.Windows.Forms.PictureBox()
        Me.lblSales_and_Inventory_System = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlTop = New System.Windows.Forms.Panel()
        Me.PlControls.SuspendLayout()
        CType(Me.PtInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlContainer
        '
        Me.PnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlContainer.Location = New System.Drawing.Point(0, 209)
        Me.PnlContainer.Name = "PnlContainer"
        Me.PnlContainer.Size = New System.Drawing.Size(1035, 518)
        Me.PnlContainer.TabIndex = 6
        '
        'PlControls
        '
        Me.PlControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlControls.Controls.Add(Me.LbSignOut)
        Me.PlControls.Controls.Add(Me.LbExit)
        Me.PlControls.Controls.Add(Me.LbItems)
        Me.PlControls.Controls.Add(Me.LblInvoice)
        Me.PlControls.Controls.Add(Me.PtInvoice)
        Me.PlControls.Controls.Add(Me.PtExit)
        Me.PlControls.Controls.Add(Me.PtSignOut)
        Me.PlControls.Controls.Add(Me.PtItems)
        Me.PlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlControls.Location = New System.Drawing.Point(0, 40)
        Me.PlControls.Name = "PlControls"
        Me.PlControls.Size = New System.Drawing.Size(1093, 141)
        Me.PlControls.TabIndex = 5
        '
        'LbSignOut
        '
        Me.LbSignOut.AutoSize = True
        Me.LbSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSignOut.Location = New System.Drawing.Point(617, 102)
        Me.LbSignOut.Name = "LbSignOut"
        Me.LbSignOut.Size = New System.Drawing.Size(89, 25)
        Me.LbSignOut.TabIndex = 5
        Me.LbSignOut.Text = "Sign Out"
        '
        'LbExit
        '
        Me.LbExit.AutoSize = True
        Me.LbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbExit.Location = New System.Drawing.Point(838, 102)
        Me.LbExit.Name = "LbExit"
        Me.LbExit.Size = New System.Drawing.Size(44, 25)
        Me.LbExit.TabIndex = 5
        Me.LbExit.Text = "Exit"
        '
        'LbItems
        '
        Me.LbItems.AutoSize = True
        Me.LbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbItems.Location = New System.Drawing.Point(414, 91)
        Me.LbItems.Name = "LbItems"
        Me.LbItems.Size = New System.Drawing.Size(59, 25)
        Me.LbItems.TabIndex = 5
        Me.LbItems.Text = "Items"
        '
        'LblInvoice
        '
        Me.LblInvoice.AutoSize = True
        Me.LblInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoice.Location = New System.Drawing.Point(186, 102)
        Me.LblInvoice.Name = "LblInvoice"
        Me.LblInvoice.Size = New System.Drawing.Size(74, 25)
        Me.LblInvoice.TabIndex = 5
        Me.LblInvoice.Text = "Invoice"
        '
        'PtInvoice
        '
        Me.PtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtInvoice.Image = Global.project_Demo.My.Resources.Resources.Invoice2
        Me.PtInvoice.InitialImage = Global.project_Demo.My.Resources.Resources.Invoice2
        Me.PtInvoice.Location = New System.Drawing.Point(171, -32)
        Me.PtInvoice.Name = "PtInvoice"
        Me.PtInvoice.Size = New System.Drawing.Size(102, 171)
        Me.PtInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtInvoice.TabIndex = 1
        Me.PtInvoice.TabStop = False
        '
        'PtExit
        '
        Me.PtExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtExit.Image = Global.project_Demo.My.Resources.Resources.Door_Out_512
        Me.PtExit.Location = New System.Drawing.Point(812, -16)
        Me.PtExit.Name = "PtExit"
        Me.PtExit.Size = New System.Drawing.Size(101, 143)
        Me.PtExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtExit.TabIndex = 2
        Me.PtExit.TabStop = False
        '
        'PtSignOut
        '
        Me.PtSignOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtSignOut.Image = Global.project_Demo.My.Resources.Resources.user_change_512
        Me.PtSignOut.Location = New System.Drawing.Point(603, -36)
        Me.PtSignOut.Name = "PtSignOut"
        Me.PtSignOut.Size = New System.Drawing.Size(114, 175)
        Me.PtSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtSignOut.TabIndex = 3
        Me.PtSignOut.TabStop = False
        '
        'PtItems
        '
        Me.PtItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtItems.Image = Global.project_Demo.My.Resources.Resources.items
        Me.PtItems.Location = New System.Drawing.Point(388, 0)
        Me.PtItems.Name = "PtItems"
        Me.PtItems.Size = New System.Drawing.Size(101, 143)
        Me.PtItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtItems.TabIndex = 4
        Me.PtItems.TabStop = False
        '
        'lblSales_and_Inventory_System
        '
        Me.lblSales_and_Inventory_System.AutoSize = True
        Me.lblSales_and_Inventory_System.BackColor = System.Drawing.Color.Cyan
        Me.lblSales_and_Inventory_System.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales_and_Inventory_System.Location = New System.Drawing.Point(213, -10)
        Me.lblSales_and_Inventory_System.Name = "lblSales_and_Inventory_System"
        Me.lblSales_and_Inventory_System.Size = New System.Drawing.Size(83, 54)
        Me.lblSales_and_Inventory_System.TabIndex = 10
        Me.lblSales_and_Inventory_System.Text = "CK "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventures"
        '
        'PlTop
        '
        Me.PlTop.BackColor = System.Drawing.Color.Cyan
        Me.PlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlTop.Controls.Add(Me.Label1)
        Me.PlTop.Controls.Add(Me.lblSales_and_Inventory_System)
        Me.PlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlTop.Location = New System.Drawing.Point(0, 0)
        Me.PlTop.Name = "PlTop"
        Me.PlTop.Size = New System.Drawing.Size(1093, 40)
        Me.PlTop.TabIndex = 0
        '
        'UsrHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 774)
        Me.Controls.Add(Me.PnlContainer)
        Me.Controls.Add(Me.PlControls)
        Me.Controls.Add(Me.PlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsrHome"
        Me.Text = "UsrHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PlControls.ResumeLayout(False)
        Me.PlControls.PerformLayout()
        CType(Me.PtInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlTop.ResumeLayout(False)
        Me.PlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlContainer As Panel
    Friend WithEvents PtItems As PictureBox
    Friend WithEvents PtSignOut As PictureBox
    Friend WithEvents PtExit As PictureBox
    Friend WithEvents PtInvoice As PictureBox
    Friend WithEvents PlControls As Panel
    Friend WithEvents LbSignOut As Label
    Friend WithEvents LbExit As Label
    Friend WithEvents LbItems As Label
    Friend WithEvents LblInvoice As Label
    Friend WithEvents lblSales_and_Inventory_System As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlTop As Panel
End Class

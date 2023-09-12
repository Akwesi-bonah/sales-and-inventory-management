<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pboStocks = New System.Windows.Forms.PictureBox()
        Me.pboSales = New System.Windows.Forms.PictureBox()
        Me.pboTransaction = New System.Windows.Forms.PictureBox()
        Me.LblSales = New System.Windows.Forms.Label()
        Me.lblSystems = New System.Windows.Forms.Label()
        Me.Pbbar = New System.Windows.Forms.ProgressBar()
        Me.lblVlue = New System.Windows.Forms.Label()
        Me.timecount = New System.Windows.Forms.Timer(Me.components)
        Me.LblLoading = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pboStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pboStocks)
        Me.Panel1.Controls.Add(Me.pboSales)
        Me.Panel1.Controls.Add(Me.pboTransaction)
        Me.Panel1.Location = New System.Drawing.Point(12, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 170)
        Me.Panel1.TabIndex = 0
        '
        'pboStocks
        '
        Me.pboStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboStocks.Image = Global.project_Demo.My.Resources.Resources.icon_round_80px
        Me.pboStocks.Location = New System.Drawing.Point(358, 27)
        Me.pboStocks.Name = "pboStocks"
        Me.pboStocks.Size = New System.Drawing.Size(138, 119)
        Me.pboStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboStocks.TabIndex = 0
        Me.pboStocks.TabStop = False
        '
        'pboSales
        '
        Me.pboSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboSales.Image = Global.project_Demo.My.Resources.Resources.sto
        Me.pboSales.Location = New System.Drawing.Point(191, 27)
        Me.pboSales.Name = "pboSales"
        Me.pboSales.Size = New System.Drawing.Size(138, 119)
        Me.pboSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboSales.TabIndex = 0
        Me.pboSales.TabStop = False
        '
        'pboTransaction
        '
        Me.pboTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboTransaction.Image = Global.project_Demo.My.Resources.Resources.sales3
        Me.pboTransaction.Location = New System.Drawing.Point(33, 27)
        Me.pboTransaction.Name = "pboTransaction"
        Me.pboTransaction.Size = New System.Drawing.Size(138, 119)
        Me.pboTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboTransaction.TabIndex = 0
        Me.pboTransaction.TabStop = False
        '
        'LblSales
        '
        Me.LblSales.AutoSize = True
        Me.LblSales.Font = New System.Drawing.Font("Brilliant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSales.ForeColor = System.Drawing.Color.White
        Me.LblSales.Location = New System.Drawing.Point(25, 22)
        Me.LblSales.Name = "LblSales"
        Me.LblSales.Size = New System.Drawing.Size(399, 84)
        Me.LblSales.TabIndex = 0
        Me.LblSales.Text = "Sales And Inventory"
        '
        'lblSystems
        '
        Me.lblSystems.AutoSize = True
        Me.lblSystems.Font = New System.Drawing.Font("Gobold Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystems.ForeColor = System.Drawing.Color.White
        Me.lblSystems.Location = New System.Drawing.Point(410, 47)
        Me.lblSystems.Name = "lblSystems"
        Me.lblSystems.Size = New System.Drawing.Size(155, 52)
        Me.lblSystems.TabIndex = 0
        Me.lblSystems.Text = "System"
        '
        'Pbbar
        '
        Me.Pbbar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pbbar.BackColor = System.Drawing.Color.Lime
        Me.Pbbar.Location = New System.Drawing.Point(-3, 389)
        Me.Pbbar.Name = "Pbbar"
        Me.Pbbar.Size = New System.Drawing.Size(555, 14)
        Me.Pbbar.TabIndex = 1
        Me.Pbbar.UseWaitCursor = True
        '
        'lblVlue
        '
        Me.lblVlue.AutoSize = True
        Me.lblVlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlue.Location = New System.Drawing.Point(493, 368)
        Me.lblVlue.Name = "lblVlue"
        Me.lblVlue.Size = New System.Drawing.Size(17, 18)
        Me.lblVlue.TabIndex = 3
        Me.lblVlue.Text = "0"
        '
        'timecount
        '
        '
        'LblLoading
        '
        Me.LblLoading.AutoSize = True
        Me.LblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoading.Location = New System.Drawing.Point(387, 367)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(89, 22)
        Me.LblLoading.TabIndex = 4
        Me.LblLoading.Text = "Loading..."
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.lblSystems)
        Me.Guna2Panel1.Controls.Add(Me.LblSales)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-13, -3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(577, 135)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LblLoading)
        Me.Controls.Add(Me.lblVlue)
        Me.Controls.Add(Me.Pbbar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.pboStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pboTransaction As PictureBox
    Friend WithEvents LblSales As Label
    Friend WithEvents lblSystems As Label
    Friend WithEvents pboStocks As PictureBox
    Friend WithEvents pboSales As PictureBox
    Friend WithEvents Pbbar As ProgressBar
    Friend WithEvents lblVlue As Label
    Friend WithEvents timecount As Timer
    Friend WithEvents LblLoading As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class

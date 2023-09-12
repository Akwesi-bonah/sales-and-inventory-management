<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnSales = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.BtnSocks = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.topBar = New System.Windows.Forms.Panel()
        Me.LbTime = New System.Windows.Forms.Label()
        Me.BntDmode = New System.Windows.Forms.Button()
        Me.BtnNmode = New System.Windows.Forms.Button()
        Me.PnlScreen = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TimeDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.sidePanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topBar.SuspendLayout()
        Me.PnlScreen.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSales
        '
        resources.ApplyResources(Me.btnSales, "btnSales")
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Name = "btnSales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sidePanel.Controls.Add(Me.PictureBox4)
        Me.sidePanel.Controls.Add(Me.PictureBox1)
        Me.sidePanel.Controls.Add(Me.btnReport)
        Me.sidePanel.Controls.Add(Me.PictureBox3)
        Me.sidePanel.Controls.Add(Me.PictureBox2)
        Me.sidePanel.Controls.Add(Me.Button1)
        Me.sidePanel.Controls.Add(Me.btnHome)
        Me.sidePanel.Controls.Add(Me.btnSales)
        Me.sidePanel.Controls.Add(Me.BtnSocks)
        Me.sidePanel.Controls.Add(Me.btnAdmin)
        resources.ApplyResources(Me.sidePanel, "sidePanel")
        Me.sidePanel.Name = "sidePanel"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.project_Demo.My.Resources.Resources.accounts
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.project_Demo.My.Resources.Resources.home1
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnReport
        '
        resources.ApplyResources(Me.btnReport, "btnReport")
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Name = "btnReport"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.project_Demo.My.Resources.Resources.inventory
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.project_Demo.My.Resources.Resources.sales
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        resources.ApplyResources(Me.btnHome, "btnHome")
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Name = "btnHome"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'BtnSocks
        '
        resources.ApplyResources(Me.BtnSocks, "BtnSocks")
        Me.BtnSocks.FlatAppearance.BorderSize = 0
        Me.BtnSocks.ForeColor = System.Drawing.Color.White
        Me.BtnSocks.Name = "BtnSocks"
        Me.BtnSocks.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        resources.ApplyResources(Me.btnAdmin, "btnAdmin")
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'topBar
        '
        Me.topBar.BackColor = System.Drawing.Color.Red
        Me.topBar.Controls.Add(Me.LbTime)
        Me.topBar.Controls.Add(Me.BntDmode)
        Me.topBar.Controls.Add(Me.BtnNmode)
        resources.ApplyResources(Me.topBar, "topBar")
        Me.topBar.Name = "topBar"
        '
        'LbTime
        '
        resources.ApplyResources(Me.LbTime, "LbTime")
        Me.LbTime.Name = "LbTime"
        '
        'BntDmode
        '
        resources.ApplyResources(Me.BntDmode, "BntDmode")
        Me.BntDmode.Name = "BntDmode"
        Me.BntDmode.UseVisualStyleBackColor = True
        '
        'BtnNmode
        '
        resources.ApplyResources(Me.BtnNmode, "BtnNmode")
        Me.BtnNmode.Name = "BtnNmode"
        Me.BtnNmode.UseVisualStyleBackColor = True
        '
        'PnlScreen
        '
        Me.PnlScreen.BackColor = System.Drawing.SystemColors.ActiveBorder
        resources.ApplyResources(Me.PnlScreen, "PnlScreen")
        Me.PnlScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlScreen.Controls.Add(Me.PictureBox6)
        Me.PnlScreen.Controls.Add(Me.Label1)
        Me.PnlScreen.Controls.Add(Me.PictureBox5)
        Me.PnlScreen.Name = "PnlScreen"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.project_Demo.My.Resources.Resources.report
        resources.ApplyResources(Me.PictureBox6, "PictureBox6")
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.project_Demo.My.Resources.Resources.invoice
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        '
        'TimeDisplay
        '
        Me.TimeDisplay.Interval = 1000
        '
        'frmHome
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlScreen)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topBar)
        Me.Name = "frmHome"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sidePanel.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topBar.ResumeLayout(False)
        Me.topBar.PerformLayout()
        Me.PnlScreen.ResumeLayout(False)
        Me.PnlScreen.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSales As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents BtnSocks As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents topBar As Panel
    Friend WithEvents PnlScreen As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BntDmode As Button
    Friend WithEvents BtnNmode As Button
    Friend WithEvents LbTime As Label
    Friend WithEvents TimeDisplay As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class

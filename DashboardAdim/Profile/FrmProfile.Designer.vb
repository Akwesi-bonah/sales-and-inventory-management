<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfile))
        Me.LbID = New System.Windows.Forms.Label()
        Me.BntUpdate = New System.Windows.Forms.Button()
        Me.DGprofile = New System.Windows.Forms.DataGridView()
        Me.LbUname = New System.Windows.Forms.Label()
        Me.Lblpwd = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCreateU = New System.Windows.Forms.Button()
        Me.CbRole = New System.Windows.Forms.ComboBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtUname = New System.Windows.Forms.TextBox()
        Me.Txtpwd = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbID
        '
        resources.ApplyResources(Me.LbID, "LbID")
        Me.LbID.Name = "LbID"
        '
        'BntUpdate
        '
        resources.ApplyResources(Me.BntUpdate, "BntUpdate")
        Me.BntUpdate.Name = "BntUpdate"
        Me.BntUpdate.UseVisualStyleBackColor = True
        '
        'DGprofile
        '
        resources.ApplyResources(Me.DGprofile, "DGprofile")
        Me.DGprofile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGprofile.Name = "DGprofile"
        '
        'LbUname
        '
        resources.ApplyResources(Me.LbUname, "LbUname")
        Me.LbUname.Name = "LbUname"
        '
        'Lblpwd
        '
        resources.ApplyResources(Me.Lblpwd, "Lblpwd")
        Me.Lblpwd.Name = "Lblpwd"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'BtnCreateU
        '
        resources.ApplyResources(Me.BtnCreateU, "BtnCreateU")
        Me.BtnCreateU.Name = "BtnCreateU"
        Me.BtnCreateU.UseVisualStyleBackColor = True
        '
        'CbRole
        '
        resources.ApplyResources(Me.CbRole, "CbRole")
        Me.CbRole.FormattingEnabled = True
        Me.CbRole.Name = "CbRole"
        '
        'TxtID
        '
        resources.ApplyResources(Me.TxtID, "TxtID")
        Me.TxtID.Name = "TxtID"
        '
        'TxtUname
        '
        resources.ApplyResources(Me.TxtUname, "TxtUname")
        Me.TxtUname.Name = "TxtUname"
        '
        'Txtpwd
        '
        resources.ApplyResources(Me.Txtpwd, "Txtpwd")
        Me.Txtpwd.Name = "Txtpwd"
        '
        'BtnSearch
        '
        resources.ApplyResources(Me.BtnSearch, "BtnSearch")
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        resources.ApplyResources(Me.TxtSearch, "TxtSearch")
        Me.TxtSearch.Name = "TxtSearch"
        '
        'BtnReset
        '
        resources.ApplyResources(Me.BtnReset, "BtnReset")
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        resources.ApplyResources(Me.BtnRemove, "BtnRemove")
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'frmProfile
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtpwd)
        Me.Controls.Add(Me.TxtUname)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.CbRole)
        Me.Controls.Add(Me.DGprofile)
        Me.Controls.Add(Me.BtnCreateU)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BntUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lblpwd)
        Me.Controls.Add(Me.LbUname)
        Me.Controls.Add(Me.LbID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfile"
        CType(Me.DGprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbID As Label
    Friend WithEvents BntUpdate As Button
    Friend WithEvents DGprofile As DataGridView
    Friend WithEvents LbUname As Label
    Friend WithEvents Lblpwd As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCreateU As Button
    Friend WithEvents CbRole As ComboBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtUname As TextBox
    Friend WithEvents Txtpwd As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents Panel1 As Panel
End Class

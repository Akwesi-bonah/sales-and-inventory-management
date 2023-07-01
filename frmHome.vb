Public Class frmHome
    Private currentBtn As Button
    Private leftBoraderBtn As Panel

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("Home")
        TimeDisplay.Start()
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBoraderBtn = New Panel
        leftBoraderBtn.Size = New Size(7, 49)
        sidePanel.Controls.Add(leftBoraderBtn)
    End Sub

    ' Method to activate button
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(44, 62, 80)
            currentBtn.ForeColor = Color.White


            leftBoraderBtn.BackColor = customColor
            leftBoraderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBoraderBtn.Visible = True
            leftBoraderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(41, 39, 40)
            currentBtn.ForeColor = Color.White
        End If
    End Sub

    ' Method to change 
    Private Sub change_menu(Menu As String)
        Select Case Menu
            Case "Home"
                addForm(Home)
            Case "Sales"
                addForm(Sales)
            Case "Report"
                addForm(Report)
            Case "Stocks"
                addForm(Stock)
            Case "Admin"
                addForm(frmProfile)

        End Select
    End Sub

    ' Method to add forms 
    Private Sub addForm(frm As Form)
        PnlScreen.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PnlScreen.Controls.Add(frm)
        frm.Show()
    End Sub




    Private Sub frmHome_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Maximized Then
            PnlScreen.Size = New Size(ClientSize.Width - PnlScreen.Left - 10, ClientSize.Height - PnlScreen.Top - 10)
        End If


    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnSales.Click, btnHome.Click
        ActiveButton(sender, colors.Red)
        change_menu("Home")
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click, btnHome.Click
        ActiveButton(sender, colors.Red)
        change_menu("Sales")
    End Sub

    Private Sub BtnSocks_Click(sender As Object, e As EventArgs) Handles BtnSocks.Click
        ActiveButton(sender, colors.Red)
        change_menu("Stocks")
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ActiveButton(sender, colors.Red)
        change_menu("Report")
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ActiveButton(sender, colors.Red)
        change_menu("Admin")
    End Sub

    Private Sub BtnNmode_Click(sender As Object, e As EventArgs) Handles BtnNmode.Click
        PnlScreen.BackColor = Color.Gray
        For Each frm As Form In PnlScreen.Controls.OfType(Of Form)()
            frm.BackColor = PnlScreen.BackColor
        Next
    End Sub

    Private Sub BntDmode_Click(sender As Object, e As EventArgs) Handles BntDmode.Click
        PnlScreen.BackColor = Color.White
        For Each frm As Form In PnlScreen.Controls.OfType(Of Form)()
            frm.BackColor = PnlScreen.BackColor
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addForm(Home)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimeDisplay.Tick

    End Sub
End Class
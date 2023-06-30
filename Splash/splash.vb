Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (PgBLoad.Value = PgBLoad.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            frmLogin.Show()
        Else
            PgBLoad.PerformStep()
            LblPercent.Text = PgBLoad.Value & ("%")

        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
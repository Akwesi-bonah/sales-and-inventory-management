Public NotInheritable Class Splash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        timecount.Start()
        timecount.Enabled = True

    End Sub




    Private Sub timecount_Tick(sender As Object, e As EventArgs) Handles timecount.Tick
        Pbbar.Value += 10
        LblLoading.Text = "Loading ...."
        lblVlue.Text = Pbbar.Value & "%"
        If (Pbbar.Value = Pbbar.Maximum) Then
            timecount.Enabled = False


        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub
End Class

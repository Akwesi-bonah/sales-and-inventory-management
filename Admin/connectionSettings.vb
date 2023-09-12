Public Class connectionSettings
    Private Sub connectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = dbconnect.server
        txtUsername.Text = dbconnect.username
        TxtPassword.Text = dbconnect.password
        txtDatabase.Text = dbconnect.database
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dbconnect.server = txtServer.Text
        dbconnect.username = txtUsername.Text
        dbconnect.password = txtPassword.Text
        dbconnect.database = txtDatabase.Text
        ConnectionSetting.SaveConnectionSettings()

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class
Public Class FrmProfile
    Private Sub BtnCreateUser_Click(sender As Object, e As EventArgs) Handles BtnCreateUser.Click
        Me.Hide()
        Dim frmRegister As New frmRegister()
        Dim dialogResult As DialogResult = frmRegister.ShowDialog()
        If dialogResult = DialogResult.OK Then
            ' Registration successful
            MsgBox("New user created")

        End If
        Me.Show()
    End Sub



    Private Sub UserProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ck_ventutres)

    End Sub

    Private Sub FrmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ck_ventutres.UserProfile' table. You can move, or remove it, as needed.
        Me.UserProfileTableAdapter.Fill(Me.Ck_ventutres.UserProfile)

    End Sub



    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

    Private Sub BntRemove_Click(sender As Object, e As EventArgs) Handles BntRemove.Click

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

End Class
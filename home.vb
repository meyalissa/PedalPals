Public Class home
    Private Sub btnSignup1_Click(sender As Object, e As EventArgs) Handles btnSignup1.Click 'Button SignUp
        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        signup.Show()
    End Sub
    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click 'Button Login
        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        login.Show()
    End Sub
    Private Sub btnAdmin1_Click(sender As Object, e As EventArgs) Handles btnAdmin1.Click 'Button LoginAdmin
        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        login_admin.Show()
    End Sub
End Class
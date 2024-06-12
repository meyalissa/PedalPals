Public Class home

    Private Sub btnSignup1_Click(sender As Object, e As EventArgs) Handles btnSignup1.Click 'Button SignUp

        ' Create a new instance of the signup.vb form
        Dim signupForm As New signup()

        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        signupForm.Show()
    End Sub

    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click 'Button Login
        ' Create a new instance of the login.vb form
        Dim loginForm As New login()

        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        loginForm.Show()
    End Sub

    Private Sub btnAdmin1_Click(sender As Object, e As EventArgs) Handles btnAdmin1.Click 'Button LoginAdmin
        ' Create a new instance of the login.vb form
        Dim loginAdminForm As New login_admin()

        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        loginAdminForm.Show()
    End Sub


End Class
Public Class signup
    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnSignup2_Click(sender As Object, e As EventArgs) Handles btnSignup2.Click
        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the login.vb form
        login.Show()
    End Sub
End Class
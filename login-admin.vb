Public Class login_admin
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click 'Button Back3
        ' Hide the current login-admin.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnLogin3_Click(sender As Object, e As EventArgs) Handles btnLogin3.Click
        ' Hide the current login-admin.vb form
        Me.Hide()

        ' Show the Dashboard-admin.vb form
        sidebar_admin.Show()
    End Sub
End Class
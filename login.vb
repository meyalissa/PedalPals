Public Class login
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click 'Button Back1
        ' Hide the current login.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        ' Hide the current login.vb form
        Me.Hide()

        ' Show the dashboard-cust.vb form
        sidebar_cust.Show()
    End Sub


End Class
Public Class login
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click 'Button Back1
        ' Create a new instance of the home.vb form
        Dim homeForm As New home()

        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        homeForm.Show()
    End Sub

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        ' Create a new instance of the login.vb form
        Dim dashCustomerForm As New dashboard_cust()

        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        dashCustomerForm.Show()
    End Sub

End Class
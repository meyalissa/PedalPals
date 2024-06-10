Public Class dashboard_cust
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Create a new instance of the home.vb form
        Dim homeForm As New home()

        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        homeForm.Show()
    End Sub

    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        ' Create a new instance of the login.vb form
        Dim bookingForm As New booking()

        ' Hide the current home.vb form
        Me.Hide()

        ' Show the signup.vb form
        bookingForm.Show()
    End Sub
End Class
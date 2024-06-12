Public Class login_admin
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click 'Button Back3
        ' Create a new instance of the home.vb form
        Dim homeForm As New home()

        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        homeForm.Show()
    End Sub

End Class
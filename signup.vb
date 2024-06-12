Public Class signup
    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        ' Create a new instance of the home.vb form
        Dim homeForm As New home()

        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        homeForm.Show()
    End Sub

End Class
Public Class sidebar_cust


    Private Sub sidebar_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the dashboard_cust form on startup
        SharedFunctions.switchPanel(dashboard_cust, Panel2)
    End Sub

    Private Sub btnDashboard1_Click(sender As Object, e As EventArgs) Handles btnDashboard1.Click
        SharedFunctions.switchPanel(dashboard_cust, Panel2)
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        SharedFunctions.switchPanel(booking, Panel2)
    End Sub

    Private Sub btnMyrental_Click(sender As Object, e As EventArgs) Handles btnMyrental.Click
        SharedFunctions.switchPanel(myrent_cust, Panel2)
    End Sub

    Private Sub btnProfile1_Click(sender As Object, e As EventArgs) Handles btnProfile1.Click
        SharedFunctions.switchPanel(profile_cust, Panel2)
    End Sub

    Private Sub btnSignou1_Click(sender As Object, e As EventArgs) Handles btnSignout1.Click
        ' Hide the current form
        Me.Hide()

        ' Show the home/login form
        home.Show()
    End Sub


End Class
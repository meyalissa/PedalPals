Public Class sidebar_admin

    Private Sub sidebar_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the dashboard_admin form on startup
        SharedFunctions.switchPanel(Dashboard_admin, Panel3)
    End Sub

    Private Sub btnDashboard2_Click(sender As Object, e As EventArgs) Handles btnDashboard2.Click
        SharedFunctions.switchPanel(Dashboard_admin, Panel3)
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        SharedFunctions.switchPanel(members, Panel3)
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        SharedFunctions.switchPanel(record, Panel3)
    End Sub

    Private Sub btnProfile2_Click(sender As Object, e As EventArgs) Handles btnProfile2.Click
        SharedFunctions.switchPanel(profile_cust, Panel3)
    End Sub

    Private Sub btnSignout2_Click(sender As Object, e As EventArgs) Handles btnSignout2.Click
        ' Hide the current form
        Me.Hide()

        ' Show the home/login form
        home.Show()
    End Sub


End Class
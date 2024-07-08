Imports System.Data.OleDb

Public Class signup
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnSignup2_Click(sender As Object, e As EventArgs) Handles btnSignup2.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim email As String = txtEmail.Text

        ' Validate user input
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            connection.Open()


            Dim cmd As New OleDbCommand("INSERT INTO member (mem_username, mem_password, mem_first_name, mem_last_name, mem_phone_no, mem_email, mem_address) VALUES (?, ?, '- ', '-', '-', ?,'-')", connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@email", email)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Sign up successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtUsername.Clear()
            txtPassword.Clear()
            txtEmail.Clear()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            connection.Close()
        End Try
        ' Hide the current signup.vb form
        Me.Hide()

        ' Show the login.vb form
        login.Show()
    End Sub
End Class
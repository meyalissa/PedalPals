Imports System.Data.OleDb

Public Class login
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Public Shared logInuserID As Integer

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        If txtUsername.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Fill all the required fields", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("SELECT mem_id FROM member WHERE mem_username=? AND mem_password=?", connection)
            cmd.Parameters.AddWithValue("@1", txtUsername.Text)
            cmd.Parameters.AddWithValue("@2", txtPass.Text)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim memberId As Integer = reader("mem_id")
                MsgBox("Login succeed", MsgBoxStyle.Information)

                ' Store the logged-in username and user ID

                logInuserID = memberId.ToString()

                sidebar_cust.Show()
            Else
                MsgBox("Invalid username/password", MsgBoxStyle.Information)
            End If

            reader.Close()
        End If
        Me.Hide() ' Hide the login form
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click 'Button Back3
        ' Hide the current login-admin.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub


End Class

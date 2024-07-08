Imports System.Data.OleDb

Public Class login_admin
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Public Shared logInuserID As Integer

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click 'Button Back3
        ' Hide the current login-admin.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnLogin3_Click(sender As Object, e As EventArgs) Handles btnLogin3.Click
        If txtusername.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Fill all the required fields", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("SELECT adm_id FROM admin WHERE adm_username = ? AND adm_password = ?", connection)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtPass.Text)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                logInuserID = reader("adm_id")
                MsgBox("You have successfully logged in", MsgBoxStyle.Information)

                ' Show the sidebar or main form
                sidebar_admin.Show()
            Else
                MsgBox("Invalid username/password", MsgBoxStyle.Information)
            End If
            reader.Close()
            connection.Close()
        End If

        ' Hide the current login-admin.vb form
        Me.Hide()
    End Sub


End Class

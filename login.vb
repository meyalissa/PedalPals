Imports System.Data.OleDb

Public Class login
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)
    Public Shared LoggedInUsername As String ' Public variable to store the logged-in username

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        If txtUsername.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Fill all the required fields", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("SELECT count(*) FROM member WHERE mem_username=? AND mem_password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPass.Text

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim memberId As Integer = Convert.ToInt32(result)
                MsgBox("Login succeed", MsgBoxStyle.Information)
                Dim myRentForm As New myrent_cust()
                ' Store the logged-in username
                LoggedInUsername = txtUsername.Text

                sidebar_cust.Show()



            Else
                MsgBox("Invalid username/password", MsgBoxStyle.Information)
            End If
        End If
        Me.Hide() ' Hide the login form
    End Sub

End Class
Imports System.Data.OleDb
Imports System.Data
Public Class login_admin
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click 'Button Back3
        ' Hide the current login-admin.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnLogin3_Click(sender As Object, e As EventArgs) Handles btnLogin3.Click
        If txtusername.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Fill all the required fills", MsgBoxStyle.Exclamation)
        Else

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("Select count(*) From admin where adm_username=? And adm_password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtusername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPass.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login succeed", MsgBoxStyle.Information)
                ' Show the Dashboard-admin.vb form
                sidebar_admin.Show()

            Else
                MsgBox("Invalid username/password", MsgBoxStyle.Information)

            End If
        End If


        ' Hide the current login-admin.vb form
        Me.Hide()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class
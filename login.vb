Imports System.Data.OleDb
Imports System.Data

Public Class login
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)


    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click 'Button Back1
        ' Hide the current login.vb form
        Me.Hide()

        ' Show the home.vb form
        home.Show()
    End Sub

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        If txtUsername.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Fill all the required fills", MsgBoxStyle.Exclamation)
        Else

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("Select count(*) From member where mem_username=? And mem_password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPass.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login succeed", MsgBoxStyle.Information)
                sidebar_cust.Show()

            Else
                MsgBox("Invalid username/password", MsgBoxStyle.Information)

            End If
        End If

            ' Hide the current login.vb form
            Me.Hide()



    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
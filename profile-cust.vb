Imports System.Data.OleDb

Public Class profile_cust
    Private Sub profile_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve and display the logged-in user's profile data
        LoadUserProfile(login.logInuserID)
    End Sub

    Private Sub LoadUserProfile(userId As Integer)
        ' Adjust the connection string to match your settings
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            connection.Open()
            Dim query As String = "SELECT mem_username, mem_first_name, mem_last_name, mem_address, mem_phone_no, mem_email FROM member WHERE mem_id = ?"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", userId)

                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtusername.Text = reader("mem_username").ToString()
                        txtFirstName.Text = reader("mem_first_name").ToString()
                        txtLastName.Text = reader("mem_last_name").ToString()
                        txtAddress.Text = reader("mem_address").ToString()
                        txtcontact.Text = reader("mem_phone_no").ToString()
                        txtEmail.Text = reader("mem_email").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Update the user's profile information in the database
        UpdateUserProfile(login.logInuserID)
    End Sub

    Private Sub UpdateUserProfile(userId As Integer)
        ' Adjust the connection string to match your settings
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            connection.Open()
            Dim query As String = "UPDATE member SET mem_username = ?, mem_first_name = ?, mem_last_name = ?, mem_address = ?, mem_phone_no = ?, mem_email = ? WHERE mem_id = ?"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", txtusername.Text)
                command.Parameters.AddWithValue("?", txtFirstName.Text)
                command.Parameters.AddWithValue("?", txtLastName.Text)
                command.Parameters.AddWithValue("?", txtAddress.Text)
                command.Parameters.AddWithValue("?", txtcontact.Text)
                command.Parameters.AddWithValue("?", txtEmail.Text)
                command.Parameters.AddWithValue("?", userId)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Profile updated successfully.", MsgBoxStyle.Information)
                Else
                    MsgBox("Profile update failed.", MsgBoxStyle.Exclamation)
                End If
            End Using
        End Using
    End Sub
End Class

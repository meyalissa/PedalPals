Imports System.Data.OleDb

Public Class profile_admin
    Private Sub profile_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve and display the logged-in user's profile data
        LoadUserProfile(login_admin.logInuserID)
        ''lblTesting.Text = login_admin.logInuserID
    End Sub

    Private Sub LoadUserProfile(userId As Integer)
        ' Adjust the connection string to match your settings
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT adm_username, adm_first_name, adm_last_name, adm_phone_no, adm_email FROM admin WHERE adm_id = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@userId", userId)

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtusername.Text = reader("adm_username").ToString()
                            txtFirstName.Text = reader("adm_first_name").ToString()
                            txtLastName.Text = reader("adm_last_name").ToString()
                            txtcontact.Text = reader("adm_phone_no").ToString()
                            txtEmail.Text = reader("adm_email").ToString()
                        Else
                            MsgBox("No data found for the specified user ID.", MsgBoxStyle.Exclamation)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Update the user's profile information in the database
        UpdateUserProfile(login_admin.logInuserID)
    End Sub

    Private Sub UpdateUserProfile(userId As Integer)
        ' Adjust the connection string to match your settings
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE admin SET adm_username = ?, adm_first_name = ?, adm_last_name = ?, adm_phone_no = ?, adm_email = ? WHERE adm_id = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@username", txtusername.Text)
                    command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                    command.Parameters.AddWithValue("@lastName", txtLastName.Text)
                    command.Parameters.AddWithValue("@phoneNo", txtcontact.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@userId", userId)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Profile updated successfully.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Profile update failed.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub
End Class

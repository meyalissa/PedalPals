
Imports System.Data.OleDb
Public Class profile_admin
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Private Sub profile_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim cmd As New OleDbCommand("SELECT adm_username, adm_first_name, adm_last_name, adm_phone, adm_email FROM admin WHERE adm_username = @username", connection)


        Using reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtusername.Text = reader("adm_username").ToString()
                    txtfname.Text = reader("adm_first_name").ToString()
                    txtlname.Text = reader("adm_last_name").ToString()
                    txtcontact.Text = reader("adm_phone").ToString()
                    txtadminemail.Text = reader("adm_email").ToString()
                End While
            Else
                MessageBox.Show("No records found in the admin table.")
            End If
        End Using
    End Sub


End Class
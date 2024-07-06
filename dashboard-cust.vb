Imports System.Data.OleDb

Public Class dashboard_cust
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Private Sub dashboard_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltest.Text = login.LoggedInUsername
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim cmd As New OleDbCommand("SELECT type_name, hourly_price FROM bike", connection)

        Using reader As OleDbDataReader = cmd.ExecuteReader()
            Dim index As Integer = 1
            While reader.Read()
                Dim lblType As Label = CType(Me.Controls("lblB" & index), Label)
                Dim lblPrice As Label = CType(Me.Controls("lblP" & index), Label)

                If lblType IsNot Nothing AndAlso lblPrice IsNot Nothing Then
                    lblType.Text = reader("type_name").ToString()
                    lblType.TextAlign = ContentAlignment.MiddleCenter
                    lblPrice.Text = "Price Per Hour: RM" & reader("hourly_price").ToString()

                End If

                index += 1
            End While
        End Using

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub lbltest_Click(sender As Object, e As EventArgs) Handles lbltest.Click

    End Sub
End Class
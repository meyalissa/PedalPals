Imports System.Data.OleDb

Public Class myrent_cust
    Private Sub myrent_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltest.Text = login.LoggedInUsername
        ' Load data into DataGridView from database
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim connection As New OleDbConnection(My.Settings.dataConnectionString)
        Dim cmd As New OleDbCommand("SELECT r.Place, r.Type, r.Date_Booking, r.Hour 
                                    FROM Rental2 r 
                                    JOIN member m ON m.mem_id = r.mem_id 
                                    WHERE m.mem_username = lbltest.Text", connection)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(dataTable)

            ' Bind the DataTable to DataGridView
            DataGridViewRental.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
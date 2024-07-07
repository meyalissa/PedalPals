Imports System.Data.OleDb

Public Class myrent_cust
    Private Sub myrent_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet1.myRental' table. You can move, or remove it, as needed.
        Me.MyRentalTableAdapter.Fill(Me.PedalPalsDBDataSet1.myRental)

        Dim userId As Integer = login.logInuserID

        ' Load data into DataGridView based on the logged-in user's ID
        LoadDataGridView(userId)
    End Sub


    Private Sub LoadDataGridView(userId As Integer)
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM myRental WHERE mem_ID = ?"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", userId)
                Using adapter As New OleDbDataAdapter(command)
                    Dim rentalData As New DataTable()
                    adapter.Fill(rentalData)
                    MyRentalDataGridView.DataSource = rentalData
                End Using
            End Using
        End Using
    End Sub

    Private Sub MyRentalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyRentalDataGridView.CellContentClick

    End Sub
End Class

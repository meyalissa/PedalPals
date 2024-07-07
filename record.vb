Imports System.Data.OleDb

Public Class Record
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\myData\PedalPalsDB.accdb"
    Private connection As OleDbConnection

    Private Sub RentalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RentalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PedalPalsDBDataSet1)
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet1.rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.PedalPalsDBDataSet1.rental)
        connection = New OleDbConnection(connectionString)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim bookID As String = txtBookID.Text
        Dim status As String = ddStatus.SelectedItem.ToString()

        If String.IsNullOrEmpty(bookID) OrElse String.IsNullOrEmpty(status) Then
            MessageBox.Show("Please enter a valid Book ID and select a status.")
            Return
        End If

        Dim query As String = "UPDATE rental SET status = @Status WHERE rent_id = @BookID"

        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@Status", status)
            command.Parameters.AddWithValue("@BookID", bookID)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Status updated successfully!")
                ' Refresh the data grid view to reflect changes
                Me.RentalTableAdapter.Fill(Me.PedalPalsDBDataSet1.rental)
            Else
                MessageBox.Show("Book ID not found.")
            End If
        End Using
    End Sub
End Class

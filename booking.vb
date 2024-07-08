Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class booking
    Public Event AddRowRequested(place As String, bikeType As String, bookingDate As Date, bookingHour As Integer)
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)
    Dim userID As Integer = login.logInuserID

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateBooking.Format = DateTimePickerFormat.Custom
        dateBooking.CustomFormat = "dd-MM-yyyy"

        connection.Open()

        Dim cmdType As New OleDbCommand("SELECT type_name FROM bike", connection)
        Using readerType As OleDbDataReader = cmdType.ExecuteReader()
            While readerType.Read()
                typeBooking.Items.Add(readerType("type_name").ToString())
            End While
        End Using

        Dim cmdAdd As New OleDbCommand("SELECT address FROM location", connection)
        Using readerAdd As OleDbDataReader = cmdAdd.ExecuteReader()
            While readerAdd.Read()
                placeBooking.Items.Add(readerAdd("address").ToString())
            End While
        End Using

        connection.Close()
    End Sub

    'Continue Button to Payment Page
    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        If placeBooking.SelectedItem Is Nothing OrElse typeBooking.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a place and a bicycle type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        connection.Open()

        ' Retrieve selected place and type
        Dim selectedPlace As String = placeBooking.SelectedItem.ToString()
        Dim selectedType As String = typeBooking.SelectedItem.ToString()

        ' Retrieve IDs from database based on selected values
        Dim placeID As Integer
        Dim bikeID As Integer

        Dim cmdPlaceID As New OleDbCommand("SELECT location_id FROM location WHERE address = ?", connection)
        cmdPlaceID.Parameters.AddWithValue("?", selectedPlace)
        placeID = Convert.ToInt32(cmdPlaceID.ExecuteScalar())

        Dim cmdBikeID As New OleDbCommand("SELECT bike_id FROM bike WHERE type_name = ?", connection)
        cmdBikeID.Parameters.AddWithValue("?", selectedType)
        bikeID = Convert.ToInt32(cmdBikeID.ExecuteScalar())

        ' Retrieve values from controls
        Dim bookingDate As Date = dateBooking.Value.Date ' Get the date value
        Dim bookingHour As Integer = CInt(hourBooking.Value) ' Get the integer value
        Dim rentTimeStart As DateTime = bookingDate.AddHours(Now.Hour) ' Assuming booking starts at the current hour
        Dim rentTimeEnd As DateTime = rentTimeStart.AddHours(bookingHour)

        ' Prepare the SQL query with parameterized values to prevent SQL injection
        Dim cmd As New OleDbCommand("INSERT INTO Rental (mem_id, location_id, bike_id, rent_date, rent_hour, rent_status, rent_time_start, rent_time_end) VALUES (?, ?, ?, ?, ?, 'Booked', ?, ?)", connection)
        cmd.Parameters.AddWithValue("@userid", userID)
        cmd.Parameters.AddWithValue("@place", placeID)
        cmd.Parameters.AddWithValue("@type", bikeID)
        cmd.Parameters.AddWithValue("@date", bookingDate)
        cmd.Parameters.AddWithValue("@hour", bookingHour)
        cmd.Parameters.AddWithValue("@start", rentTimeStart)
        cmd.Parameters.AddWithValue("@end", rentTimeEnd)

        ' Execute the query
        cmd.ExecuteNonQuery()

        connection.Close()

        MessageBox.Show("You have made a bicycle booking", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Raise the event to add a row to the DataGridView in FormWithDataGridView if it is subscribed
        RaiseEvent AddRowRequested(selectedPlace, selectedType, bookingDate, bookingHour)

        ' Show the payment form
        payment.Show()
    End Sub


    'Calculate Total Price
    Private Sub btnCalcPrice_Click(sender As Object, e As EventArgs) Handles btnCalcPrice.Click
        If typeBooking.SelectedItem IsNot Nothing AndAlso hourBooking.Text.Trim() <> "" Then
            connection.Open()

            ' Get the selected bicycle type from the ComboBox
            Dim selectedTypeName As String = typeBooking.SelectedItem.ToString()

            ' Get the number of hours from the NumericUpDown control
            Dim hours As Integer = CInt(hourBooking.Value)

            ' Prepare the SQL command to fetch the price for the given bicycle type
            Dim cmdPrice As New OleDbCommand("SELECT hourly_price FROM bike WHERE type_name = ?", connection)
            cmdPrice.Parameters.AddWithValue("?", selectedTypeName)

            Try
                ' Execute the command and read the result
                Using readerPrice As OleDbDataReader = cmdPrice.ExecuteReader()
                    If readerPrice.HasRows Then
                        readerPrice.Read()
                        Dim pricePerHour As Decimal = readerPrice.GetDecimal(0) ' Get the hourly_price

                        ' Calculate the total price
                        Dim totalPrice As Decimal = pricePerHour * hours

                        ' Display the total price
                        lblPriceBooking.Text = "RM " & totalPrice.ToString("F2")
                    Else
                        MessageBox.Show("Bicycle type not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please select a bicycle type and enter hours to calculate the price.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

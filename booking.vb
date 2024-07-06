Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class booking
    Public Event AddRowRequested(place As String, bikeType As String, bookingDate As Date, bookingHour As Integer)
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateBooking.Format = DateTimePickerFormat.Custom
        dateBooking.CustomFormat = "dd-MM-yyyy"

        connection.Open()


        Dim cmdType As New OleDbCommand("SELECT type_name FROM bike", connection)
        Dim cmdAdd As New OleDbCommand("SELECT address FROM location", connection)


        ' Execute the command and read the results
        Using readerType As OleDbDataReader = cmdType.ExecuteReader()
            While readerType.Read()
                ' Add each bicycle type to the ComboBox
                typeBooking.Items.Add(readerType("type_name").ToString())


            End While
        End Using

        Using readerAdd As OleDbDataReader = cmdAdd.ExecuteReader()
            While readerAdd.Read()
                placeBooking.Items.Add(readerAdd("address").ToString())

            End While
        End Using
        connection.Close()
    End Sub

    'Continue Button to Payment Page
    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        connection.Open()
        Dim cmd As OleDbCommand = connection.CreateCommand()
        cmd.CommandType = CommandType.Text

        ' Retrieve values from controls
        Dim place As String = placeBooking.SelectedItem.ToString()
        Dim bikeType As String = typeBooking.SelectedItem.ToString()
        Dim bookingDate As Date = dateBooking.Value.Date ' Get the date value
        Dim bookingHour As Integer = CInt(hourBooking.Value) ' Get the integer value

        ' Prepare the SQL query with parameterized values to prevent SQL injection
        cmd.CommandText = "INSERT INTO Rental2 ([Place], [Type], [Date_Booking], [Hour]) VALUES (?, ?, ?, ?)"
        cmd.Parameters.AddWithValue("@place", place)
        cmd.Parameters.AddWithValue("@type", bikeType)
        cmd.Parameters.AddWithValue("@date", bookingDate)
        cmd.Parameters.AddWithValue("@hour", bookingHour)

        ' Execute the query
        cmd.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Record has been recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        payment.Show()

        ' Raise the event to add a row to the DataGridView in FormWithDataGridView if it is subscribed
        RaiseEvent AddRowRequested(place, bikeType, bookingDate, bookingHour)
    End Sub

    'Calculate Total Price
    Private Sub btnCalcPrice_Click(sender As Object, e As EventArgs) Handles btnCalcPrice.Click


        connection.Open()


        ' Get the selected bicycle type from the ComboBox
        Dim bicycleType As String = typeBooking.SelectedItem.ToString()

        ' Get the number of hours from the TextBox
        Dim hours As Integer = Integer.Parse(hourBooking.Text)


        ' Prepare the SQL command to fetch the price for the given bicycle type
        Dim cmdPrice As New OleDbCommand("SELECT hourly_price FROM bike WHERE type_name = ?", connection)
        cmdPrice.Parameters.AddWithValue("?", bicycleType)

        ' Execute the command and read the result
        Using readerPrice As OleDbDataReader = cmdPrice.ExecuteReader()
            If readerPrice.HasRows Then
                readerPrice.Read()
                Dim pricePerHour As Decimal = readerPrice("hourly_price")

                ' Calculate the total price
                Dim totalPrice As Decimal = pricePerHour * hours

                ' Display the total price
                lblPriceBooking.Text = "RM " & totalPrice.ToString("F2")
            Else
                MessageBox.Show("Bicycle type not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
        connection.Close()
    End Sub




End Class
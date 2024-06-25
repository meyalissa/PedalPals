Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Public Class booking
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

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

    End Sub

    'Continue Button to Payment Page
    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        payment.Show()
    End Sub

    'Calculate Total Price
    Private Sub btnCalcPrice_Click(sender As Object, e As EventArgs) Handles btnCalcPrice.Click

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        ' Get the selected bicycle type from the ComboBox
        Dim bicycleType As String = typeBooking.SelectedItem.ToString()

        ' Get the number of hours from the TextBox
        Dim hours As Integer = Integer.Parse(hourBooking.Text)


        ' Prepare the SQL command to fetch the price for the given bicycle type
        Dim cmdPrice As New OleDbCommand("SELECT hourly_price FROM bike WHERE type = ?", connection)
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

    End Sub




End Class
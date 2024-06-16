Public Class booking

    'Continue Button to Payment Page
    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        payment.Show()
    End Sub

    'Calculate Total Price
    Private Sub btnCalcPrice_Click(sender As Object, e As EventArgs) Handles btnCalcPrice.Click

        ' Get the number of hours from the txtHour textbox
        Dim hours As Integer = Integer.Parse(hourBooking.Text)

        ' Get the type of bicycle from the txtType textbox
        Dim bicycleType As String = typeBooking.Text

        ' Define the prices for each type of bicycle
        Dim pricePerHour As Decimal
        Select Case bicycleType.ToLower()
            Case "trialthon"
                pricePerHour = 20D
            Case "road bike"
                pricePerHour = 10D
            Case "bmx"
                pricePerHour = 15D
            Case "mountain bike"
                pricePerHour = 25D
            Case "electrical bike"
                pricePerHour = 30D
            Case "city bike"
                pricePerHour = 10D
        End Select

        ' Calculate the total price
        Dim totalPrice As Decimal = hours * pricePerHour

        ' Display the total price in the lblTot label
        lblPriceBooking.Text = totalPrice.ToString("C")

    End Sub

    'Add booking into list
    Private Sub addBooking_Click(sender As Object, e As EventArgs) Handles addBooking.Click
        DataGridView1.Rows.Add(placeBooking.Text, dateBooking.Text, typeBooking.Text, hourBooking.Text, lblPriceBooking.Text)
        'Clear txtbox after add
        placeBooking.Text = ""
        dateBooking.Text = ""
        typeBooking.Text = ""
        hourBooking.Text = ""
        lblPriceBooking.Text = ""
    End Sub

    'Delete booking
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the clicked column is the "Delete" column
        If DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
            ' Check if there is a selected row
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Confirm the deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Remove the selected row
                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
                End If
            End If
        End If
    End Sub
    '

End Class
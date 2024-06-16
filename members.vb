Public Class members

    'Add member into list
    Private Sub btnAddmem_Click(sender As Object, e As EventArgs) Handles btnAddmem.Click
        DataGridView2.Rows.Add(txtmemID.Text, txtusername.Text, txtemail.Text, txtcontact.Text)
        'Clear txtbox after add
        txtmemID.Text = ""
        txtusername.Text = ""
        txtemail.Text = ""
        txtcontact.Text = ""
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        'Edit button
        If DataGridView2.Columns(e.ColumnIndex).Name = "Edit" Then
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            txtmemID.Text = dr.Cells(0).Value.ToString()
            txtusername.Text = dr.Cells(1).Value.ToString()
            txtcontact.Text = dr.Cells(2).Value.ToString()
            txtemail.Text = dr.Cells(3).Value.ToString()

            'Update button
        ElseIf DataGridView2.Columns(e.ColumnIndex).Name = "Update" Then
            Dim update As DataGridViewRow = DataGridView2.SelectedRows(0)
            update.Cells(0).Value = txtmemID.Text
            update.Cells(1).Value = txtusername.Text
            update.Cells(2).Value = txtcontact.Text
            update.Cells(3).Value = txtemail.Text


            'Delete button
        ElseIf DataGridView2.Columns(e.ColumnIndex).Name = "Delete" Then
            DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)

        End If
    End Sub
End Class
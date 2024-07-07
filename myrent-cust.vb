Imports System.Data.OleDb

Public Class myrent_cust
    Private Sub myrent_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet1.member_Query' table. You can move, or remove it, as needed.
        Me.Member_QueryTableAdapter1.Fill(Me.PedalPalsDBDataSet1.member_Query)
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet.member_Query' table. You can move, or remove it, as needed.
        Me.Member_QueryTableAdapter.Fill(Me.PedalPalsDBDataSet.member_Query)
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet.myRental' table. You can move, or remove it, as needed.
        Me.MyRentalTableAdapter.Fill(Me.PedalPalsDBDataSet.myRental)
        'TODO: This line of code loads data into the 'PedalPalsDBDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.PedalPalsDBDataSet.member)
        lbltest.Text = login.LoggedInUsername
        ' Load data into DataGridView from database
        ''LoadDataGridView()
    End Sub

    Private Sub MyRentalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
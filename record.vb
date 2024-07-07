﻿Imports System.Data.OleDb

Public Class Record
    Private Sub RentalStatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RentalStatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PedalPalsDBDataSet1)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rentID As Integer = Integer.Parse(txtBookID.Text)
        Dim status As String = ddStatus.SelectedItem.ToString()

        UpdateRentStatus(rentID, status)
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView on form load
        LoadRentalData()
    End Sub

    Private Sub UpdateRentStatus(rentID As Integer, status As String)
        ' Adjust the connection string to match your settings
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            connection.Open()
            Dim query As String = "UPDATE RentalStat SET rent_status = ? WHERE rent_ID = ?"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("?", status)
                command.Parameters.AddWithValue("?", rentID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Rent status updated successfully.", MsgBoxStyle.Information)
                    ' Refresh the DataGridView to reflect the update
                    LoadRentalData()
                Else
                    MsgBox("Failed to update rent status.", MsgBoxStyle.Exclamation)
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadRentalData()
        ' Load data into the DataGridView
        Using connection As New OleDbConnection(My.Settings.dataConnectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM RentalStat"
            Using command As New OleDbCommand(query, connection)
                Using adapter As New OleDbDataAdapter(command)
                    Dim rentalData As New DataTable()
                    adapter.Fill(rentalData)
                    RentalStatDataGridView.DataSource = rentalData
                End Using
            End Using
        End Using
    End Sub
End Class

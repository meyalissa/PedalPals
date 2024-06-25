Imports System.Data.OleDb
Imports System.IO


Public Class payment
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        Dim fileUpload As DialogResult = OpenFileDialog.ShowDialog()

        If fileUpload = DialogResult.OK Then
            Dim filePath As String = OpenFileDialog.FileName
            Dim fileName As String = Path.GetFileName(filePath)

            lblFile.Text = fileName


        End If

    End Sub

    Private Sub btnBook1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click

    End Sub
End Class
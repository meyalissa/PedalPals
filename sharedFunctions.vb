Module SharedFunctions
    Private currentPanel As Form = Nothing

    Sub switchPanel(ByVal panel As Form, ByVal parentPanel As Panel)
        ' Check if the same panel is already displayed
        If currentPanel IsNot Nothing AndAlso currentPanel.Equals(panel) Then
            Return
        End If

        ' Clear the previously displayed panel
        If currentPanel IsNot Nothing Then
            currentPanel.Hide()
            parentPanel.Controls.Remove(currentPanel)
        End If

        ' Display the new panel
        parentPanel.Controls.Clear()
        panel.TopLevel = False
        parentPanel.Controls.Add(panel)
        panel.Show()

        ' Store the current panel
        currentPanel = panel
    End Sub
End Module
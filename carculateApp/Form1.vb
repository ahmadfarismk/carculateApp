Public Class AboutUs
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub MainPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPageToolStripMenuItem.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        history.Show()
        Me.Close()
    End Sub
End Class
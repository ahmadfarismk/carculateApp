Public Class history
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarculatedbDataSet1.history' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.CarculatedbDataSet1.history)
        'TODO: This line of code loads data into the 'CarculatedbDataSet.history' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.CarculatedbDataSet.history)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
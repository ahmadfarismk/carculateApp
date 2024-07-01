Public Class output
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_carculatedb_1__1_DataSet1.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me._carculatedb_1__1_DataSet1.car)

    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click

    End Sub
End Class
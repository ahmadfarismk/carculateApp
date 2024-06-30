Public Class login
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        register.ShowDialog()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_carculatedb_1__1_DataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._carculatedb_1__1_DataSet.customer)

    End Sub
End Class
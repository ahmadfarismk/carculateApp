Imports System.Data.OleDb

Public Class history
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=carculatedb.accdb"

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As Integer = moduleProcesses.CurrentUserID
        'TODO: This line of code loads data into the 'CarculatedbDataSet1.history' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.CarculatedbDataSet1.history)
        'TODO: This line of code loads data into the 'CarculatedbDataSet.history' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.CarculatedbDataSet.history)
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT history_id,car_ID, car_model, car_price, downpayment, yearly_instalment, yearly_expenses, yearly_payment, monthly_payment, min_salary_own, cust_id FROM history where cust_id = @id"
                Dim command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Assuming you have a DataGridView named dgvHistory
                DataGridView1.DataSource = table

                ' If you want to set the CurrentUserID from the first row of the table
                If table.Rows.Count > 0 Then
                    Dim row As DataRow = table.Rows(0)
                    moduleProcesses.CurrentUserID = Convert.ToInt32(row("cust_id"))
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to load data from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub MainPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPageToolStripMenuItem.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
        Me.Close()
    End Sub

End Class
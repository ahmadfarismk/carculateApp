Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class carSelect
    Public Property choose As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim percentSal As String = txtPercent.Text
        Dim pay As String = txtYear.Text


        If radBut10.Checked Then
            output.percentDown = 0.1
        ElseIf radBut20.Checked Then
            output.percentDown = 0.2
        ElseIf radBut30.Checked Then
            output.percentDown = 0.3
        Else
        End If



        If (percentSal = "" And pay = "") Then
            MessageBox.Show("Please Enter all detail ", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            carName.Text = ""
            lblPrice.Text = ""
            lblYear.Text = ""
            lblCC.Text = ""
            lblCost.Text = ""
            Me.Close()
            output.ShowDialog()


        End If




    End Sub

    Private Sub carSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbconn As New System.Data.OleDb.OleDbConnection()
        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=carculatedb.accdb"
        Dim Searchquery As String = "Select * from car where car_id=@id"

        Dim cmd As New OleDbCommand(Searchquery, dbconn)
        cmd.Parameters.AddWithValue("@id", choose)
        Dim sql As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        sql.Fill(table)

        If table.Rows.Count > 0 Then
            carName.Text = table.Rows(0)(1).ToString
            lblPrice.Text = table.Rows(0)(3).ToString
            lblYear.Text = table.Rows(0)(5).ToString
            lblCC.Text = table.Rows(0)(2).ToString
            lblCost.Text = table.Rows(0)(4).ToString


        Else
            Me.Close()
            dbconn.Close()
        End If

    End Sub
End Class
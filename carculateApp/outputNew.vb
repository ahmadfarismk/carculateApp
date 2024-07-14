Imports System.Data.OleDb

Public Class outputNew

    Public Property percentDown As Double
    Public Property choose As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub outputNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Database Connection
        Dim dbconn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\carculateApp3\carculateApp\carculatedb.accdb")
        Dim Searchquery As String = "SELECT * FROM car WHERE car_ID = @id"
        Dim cmd As New OleDbCommand(Searchquery, dbconn)
        cmd.Parameters.AddWithValue("@id", choose)

        Dim sql As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        sql.Fill(table)

        ' Variable declaration
        Dim percentSal As Double = Val(InputCar.txtCarPercentage.Text) / 100
        Dim year As Integer = Val(InputCar.txtYear.Text)

        If table.Rows.Count > 0 Then
            Dim row As DataRow = table.Rows(0)
            Dim cc As Integer = Convert.ToInt32(row("car_cc").ToString())
            Dim price As Double = Convert.ToDouble(row("car_price").ToString())
            Dim insurance As Double = Convert.ToDouble(row("insurance").ToString())

            ' CC and roadtax calculation
            Dim roadtax As Double
            If (cc <= 1600) Then
                roadtax = 200.0
            ElseIf (cc <= 1800) Then
                roadtax = 200.0 + (cc - 1600) * 0.4
            ElseIf (cc <= 2000) Then
                roadtax = 280.0 + (cc - 1800) * 0.5
            ElseIf (cc <= 2500) Then
                roadtax = 380.0 + (cc - 2000) * 1.0
            ElseIf (cc <= 3000) Then
                roadtax = 880.0 + (cc - 2500) * 2.5
            Else
                roadtax = 2130.0 + (cc - 3000) * 4.5
            End If

            lblCarName.Text = row("car_model").ToString()

            Dim downPayment = calcDownpayment(percentDown, price)
            Dim yearExpenses = calcYearExpenses(price, roadtax, insurance)
            Dim yearInstall = calcYearInstall(price, downPayment, year)
            Dim totYear = calcTotYear(yearInstall, yearExpenses)
            Dim monthPay = calcMonthPay(totYear)
            Dim minSal = calcMinSal(monthPay, percentSal)

            lblDown.Text = downPayment.ToString("F2")
            lblInstallment.Text = yearInstall.ToString("F2")
            lblYearExp.Text = yearExpenses.ToString("F2")
            lblTotYear.Text = totYear.ToString("F2")
            lblMonthPay.Text = monthPay.ToString("F2")
            lblSalary.Text = minSal.ToString("F2")
        Else
            MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        lblDown.Text = ""
        lblInstallment.Text = ""
        lblYearExp.Text = ""
        lblTotYear.Text = ""
        lblMonthPay.Text = ""
        lblSalary.Text = ""
        Me.Close()
    End Sub
End Class

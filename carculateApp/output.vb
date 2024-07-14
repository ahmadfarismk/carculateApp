Imports System.Data.OleDb

Public Class output

    Public Property percentDown As Double
    Public Property choose As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub



    Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Database Connection
        Dim dbconn As New System.Data.OleDb.OleDbConnection()
        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=carculatedb.accdb"
        Dim Searchquery As String = "Select * from car where id=@id"
        Dim cmd As New OleDbCommand(Searchquery, dbconn)
        cmd.Parameters.AddWithValue("@id", choose)
        Dim sql As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        sql.Fill(table)

        'Variable declaration
        Dim percentSal As Double = Val(carSelect.txtPercent.Text) / 100

        Dim year As Integer = Val(carSelect.txtYear.Text)

        Dim cc As Integer = Convert.ToInt32(table.Rows(choose)(2).ToString)
        Dim price As Double = Convert.ToDouble(table.Rows(choose)(3).ToString)
        Dim insurance As Double = Convert.ToDouble(table.Rows(choose)(4).ToString)
        Dim roadtax As Double





        'CC and roadtax calculation
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

        lblCarName.Text = choose

        Dim downPayment = calcDownpayment(percentDown, price)
        Dim yearExpenses = calcYearExpenses(price, roadtax, insurance)
        Dim yearInstall = calcYearInstall(price, downPayment, year)
        Dim totYear = calcTotYear(yearInstall, yearExpenses)
        Dim monthPay = calcMonthPay(totYear)
        Dim minSal = calcMinSal(monthPay, percentSal)

        If table.Rows.Count > 0 Then
            lblDown.Text = downPayment
            lblInstallment.Text = yearInstall
            lblYearExp.Text = yearExpenses
            lblTotYear.Text = totYear
            lblMonthPay.Text = monthPay.ToString("F2")
            lblSalary.Text = minSal.ToString("F2")

        Else
            MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click

    End Sub

    'Private Sub output_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    lblDown.Text = ""
    '    lblInstallment.Text = ""
    '    lblYearExp.Text = ""
    '    lblTotYear.Text = ""
    '    lblMonthPay.Text = ""
    '    lblSalary.Text = ""
    'End Sub

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
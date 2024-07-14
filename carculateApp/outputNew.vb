Imports System.Data.OleDb

Public Class outputNew
    Public Property percentDown As Double
    Public Property choose As Integer

    Private Sub outputNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve information from the UI
        Dim percentSal As Double = Val(InputCar.txtCarPercentage.Text) / 100
        Dim year As Integer = Val(InputCar.txtYear.Text)

        ' Database Connection
        Dim dbconn As New OleDbConnection()
        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\carculateApp3\carculateApp\carculatedb.accdb"

        Try
            ' Open the database connection
            dbconn.Open()

            ' Prepare the SQL select statement to fetch car details
            Dim Searchquery As String = "SELECT * FROM car WHERE car_ID=@id"
            Dim cmd As New OleDbCommand(Searchquery, dbconn)
            cmd.Parameters.AddWithValue("@id", choose)
            Dim sql As New OleDbDataAdapter(cmd)
            Dim table As New DataTable
            sql.Fill(table)

            If table.Rows.Count > 0 Then
                Dim row As DataRow = table.Rows(0)
                Dim cc As Integer = Convert.ToInt32(row("car_cc").ToString())
                Dim price As Double = Convert.ToDouble(row("car_price").ToString())
                Dim insurance As Double = Convert.ToDouble(row("insurance").ToString())

                ' CC and roadtax calculation
                Dim roadtax As Double
                If cc <= 1600 Then
                    roadtax = 200.0
                ElseIf cc <= 1800 Then
                    roadtax = 200.0 + (cc - 1600) * 0.4
                ElseIf cc <= 2000 Then
                    roadtax = 280.0 + (cc - 1800) * 0.5
                ElseIf cc <= 2500 Then
                    roadtax = 380.0 + (cc - 2000) * 1.0
                ElseIf cc <= 3000 Then
                    roadtax = 880.0 + (cc - 2500) * 2.5
                Else
                    roadtax = 2130.0 + (cc - 3000) * 4.5
                End If

                lblCarName.Text = row("car_model").ToString()

                ' Calculate financial details
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

                ' Insert the calculated data into the history table
                Dim insertQuery As String = "INSERT INTO history (car_ID, car_model, car_price, downpayment, yearly_instalment, yearly_expenses, yearly_payment, monthly_payment, min_salary_own, cust_id) VALUES (@carID, @carModel, @carPrice, @downPayment, @yearInstall, @yearExpenses, @totYear, @monthPay, @minSal, @custID)"
                Dim insertCmd As New OleDbCommand(insertQuery, dbconn)
                insertCmd.Parameters.AddWithValue("@carID", choose)
                insertCmd.Parameters.AddWithValue("@carModel", row("car_model").ToString())
                insertCmd.Parameters.AddWithValue("@carPrice", price)
                insertCmd.Parameters.AddWithValue("@downPayment", downPayment)
                insertCmd.Parameters.AddWithValue("@yearInstall", yearInstall)
                insertCmd.Parameters.AddWithValue("@yearExpenses", yearExpenses)
                insertCmd.Parameters.AddWithValue("@totYear", totYear)
                insertCmd.Parameters.AddWithValue("@monthPay", monthPay)
                insertCmd.Parameters.AddWithValue("@minSal", minSal)
                insertCmd.Parameters.AddWithValue("@custID", moduleProcesses.CurrentUserID) ' Ensure this is a valid cust_id from the customer table

                ' Execute the insert command
                Dim result As Integer = insertCmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Calculation results have been saved to history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to save to history.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            If dbconn.State = ConnectionState.Open Then dbconn.Close()
        End Try
    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click
        ' Handle label click event if needed
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Clear labels and close the form
        lblDown.Text = ""
        lblInstallment.Text = ""
        lblYearExp.Text = ""
        lblTotYear.Text = ""
        lblMonthPay.Text = ""
        lblSalary.Text = ""
        Me.Close()
    End Sub
End Class

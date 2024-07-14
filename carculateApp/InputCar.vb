Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class InputCar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Handle label click event if needed
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCarName.TextChanged
        ' Handle text change event if needed
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Read inputs from text boxes
        Dim carName As String = txtCarName.Text
        Dim carPrice As Double = Val(txtCarPrice.Text)
        Dim carCC As Integer = Val(txtCarCC.Text)
        Dim carInsurance As Integer = Val(txtInsurance.Text)
        Dim carYear As Integer = Val(txtCarYear.Text)
        Dim percentageSal As Double = Val(txtCarPercentage.Text)
        Dim carYearPay As Integer = Val(txtYear.Text)
        Dim percentageDown As Double

        ' Validate inputs
        If carName = "" OrElse carPrice = 0 OrElse carCC = 0 OrElse percentageSal = 0 OrElse carYear = 0 OrElse carInsurance = 0 OrElse carYearPay = 0 Then
            MessageBox.Show("Please enter all details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Determine down payment percentage
        If radBut10.Checked Then
            percentageDown = 0.1
            output.percentDown = 0.1
            outputNew.percentDown = 0.1
        ElseIf radBut20.Checked Then
            percentageDown = 0.2
            output.percentDown = 0.2
            outputNew.percentDown = 0.2
        ElseIf radBut30.Checked Then
            percentageDown = 0.3
            output.percentDown = 0.3
            outputNew.percentDown = 0.3
        Else
            MessageBox.Show("Please select a down payment percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Set up database connection
        Dim dbconn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=carculatedb.accdb")

        Try
            ' Prepare the SQL insert statement
            Dim sql As String = "INSERT INTO car (car_model, car_cc, car_price, insurance, [year]) VALUES (@carName, @carCC, @carPrice, @carInsurance, @carYear)"
            Dim sqlCom As New OleDbCommand(sql, dbconn)

            ' Add parameters to the command
            sqlCom.Parameters.AddWithValue("@carName", carName)
            sqlCom.Parameters.AddWithValue("@carCC", carCC)
            sqlCom.Parameters.AddWithValue("@carPrice", carPrice)
            sqlCom.Parameters.AddWithValue("@carInsurance", carInsurance)
            sqlCom.Parameters.AddWithValue("@carYear", carYear)

            ' Open the database connection
            dbconn.Open()

            ' Execute the insert command
            Dim result As Integer = sqlCom.ExecuteNonQuery()
            If result > 0 Then
                ' Get the ID of the newly inserted car
                Dim getIdCmd As New OleDbCommand("SELECT @@IDENTITY", dbconn)
                Dim newCarID As Integer = Convert.ToInt32(getIdCmd.ExecuteScalar())

                MessageBox.Show("Car has been added, you may calculate now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Set the 'choose' property of the output form to the new car ID
                Dim outputNew As New outputNew()
                outputNew.choose = newCarID
                outputNew.percentDown = percentageDown ' Pass the percentageDown to the output form

                ' Show the output form
                outputNew.Show()
                Me.Hide()
            Else
                MessageBox.Show("Car adding failed.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Close the database connection
            dbconn.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ' Handle label click event if needed
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        ' Handle text change event if needed
    End Sub

    Private Sub MainPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPageToolStripMenuItem.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub AbousUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbousUsToolStripMenuItem.Click
        AboutUs.Show()
        Me.Close()
    End Sub

    Private Sub YourHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YourHistoryToolStripMenuItem.Click
        history.Show()
        Me.Close()
    End Sub
End Class

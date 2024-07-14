Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class InputCar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCarName.TextChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim carName As String = txtCarName.Text
        Dim carPrice As Double = Val(txtCarPrice.Text)
        Dim carCC As Integer = Val(txtCarCC.Text)
        Dim carInsurance As Integer = Val(txtInsurance.Text)
        Dim carYear As Integer = Val(txtCarYear.Text)



        Dim percentageSal As Double = Val(txtCarPercentage.Text)
        Dim carYearPay As Integer = Val(txtYear.Text)
        Dim percentageDown As Double

        If carName = "" Or carPrice = 0 Or carCC = 0 Or percentageSal = 0 Or carYear = 0 Or carInsurance = 0 Or carYearPay = 0 Then
            MessageBox.Show("Please Enter all details", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If radBut10.Checked Then
            percentageDown = 0.1
            output.percentDown = 0.1
        ElseIf radBut20.Checked Then
            percentageDown = 0.2
            output.percentDown = 0.2
        ElseIf radBut30.Checked Then
            percentageDown = 0.3
            output.percentDown = 0.3
        Else
        End If

        If (carName <> "" And carPrice <> 0 And carCC <> 0 And carInsurance <> 0 And carYear <> 0 And percentageSal <> 0 And carYearPay <> 0) Then
            'setting up db connection
            Dim dbconn As New System.Data.OleDb.OleDbConnection()
            dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=carculatedb.accdb"
            Try
                ' Prepare the SQL insert statement
                Dim sql As String = "INSERT INTO car(car_model, car_cc, car_price, insurance, year) VALUES(@carName, @carCC, @carPrice, @carInsurance, @carYear)"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql, dbconn)
                ' Add parameters to the command
                sqlCom.Parameters.AddWithValue("@carName", carName)
                sqlCom.Parameters.AddWithValue("@carPrice", carPrice)
                sqlCom.Parameters.AddWithValue("@carCC", carCC)
                sqlCom.Parameters.AddWithValue("@carInsurance", carInsurance)
                sqlCom.Parameters.AddWithValue("@carYear", carYear)




                ' Open the database connection
                dbconn.Open()

                ' Execute the insert command
                Dim result As Integer = sqlCom.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Car has been added , you may calculate now.", "Success adding car", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    output.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Car adding failed.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                ' Close the database connection
                dbconn.Close()
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged

    End Sub
End Class
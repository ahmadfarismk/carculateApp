Public Class register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'retrieving information from register form
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim fullname As String = txtFullname.Text
        Dim email As String = txtEmail.Text
        If (username = "") Then
            MessageBox.Show("Username is blank", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf (password = "") Then
            MessageBox.Show("Password is blank", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf (fullname = "") Then
            MessageBox.Show("Fullname is blank", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf (email = "") Then
            MessageBox.Show("Email is blank", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (username <> "" And password <> "" And fullname <> "" And email <> "") Then
            'setting up db connection
            Dim dbconn As New System.Data.OleDb.OleDbConnection()
            dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\Downloads\carculatedb.accdb"
            Try
                ' Prepare the SQL insert statement
                Dim sql As String = "INSERT INTO customer(cust_username, cust_pass, cust_email, cust_fullname) VALUES(@cust_username, @cust_pass, @cust_email, @cust_fullname)"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql, dbconn)
                ' Add parameters to the command
                sqlCom.Parameters.AddWithValue("@cust_username", username)
                sqlCom.Parameters.AddWithValue("@cust_pass", password)
                sqlCom.Parameters.AddWithValue("@cust_email", email)
                sqlCom.Parameters.AddWithValue("@cust_fullname", fullname)

                ' Open the database connection
                dbconn.Open()

                ' Execute the insert command
                Dim result As Integer = sqlCom.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Registration successful, you may login now.", "Success registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    login.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Registration failed.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                ' Close the database connection
                dbconn.Close()
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class

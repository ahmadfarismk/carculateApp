Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        register.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If (username = "" And password = "") Then
            MessageBox.Show("Username and password are blank", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim dbconn As New System.Data.OleDb.OleDbConnection()
        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\ACCESS DB\carculatedbLatest.accdb"
        Try
            Dim sql As String = "SELECT * FROM customer WHERE cust_username = '" & username & "' AND cust_pass = '" & password & "'"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            'Open Database Connection
            sqlCom.Connection = dbconn
            sqlCom.Parameters.AddWithValue("@cust_username", username)
            sqlCom.Parameters.AddWithValue("@cust_pass", password)
            dbconn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()


            If sqlRead.Read() Then
                carSelect.Show()
                Me.Hide()
            Else

                ' If user enter wrong username and password combination
                ' Throw an error message
                MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'Clear all fields
                txtUsername.Text = ""
                txtPassword.Text = ""

                'Focus on Username field
                txtUsername.Focus()
            End If
            sqlRead.Close()
            dbconn.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
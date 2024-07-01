Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class carSelect
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim percent As String = lblPercent.Text
        Dim pay As String = lblCompPay.Text

        If (percent = "" And pay = "") Then
            MessageBox.Show("Please Enter all detail ", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
﻿Public Class mainPage
    Private Sub mainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLFA_Click(sender As Object, e As EventArgs) Handles btnLFA.Click
        carSelect.ShowDialog()
        carSelect.choose = 2
        output.choose = 2
    End Sub

    Private Sub btnCGT_Click(sender As Object, e As EventArgs) Handles btnCGT.Click
        carSelect.ShowDialog()
        carSelect.choose = 1
        output.choose = 1



    End Sub

    Private Sub btnMf1_Click(sender As Object, e As EventArgs) Handles btnMf1.Click
        carSelect.ShowDialog()
        carSelect.choose = 4
        output.choose = 4
    End Sub

    Private Sub btnFgt_Click(sender As Object, e As EventArgs) Handles btnFgt.Click
        carSelect.ShowDialog()
        carSelect.choose = 3
        output.choose = 3
    End Sub
End Class
﻿Imports System.Data.OleDb

Public Class output
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Database Connection
        Dim dbconn As New System.Data.OleDb.OleDbConnection()
        dbconn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\Downloads\carculatedb[1].accdb"
        Dim Searchquery As String = "Select * from car where id=@id"
        Dim cmd As New OleDbCommand(Searchquery, dbconn)
        cmd.Parameters.AddWithValue("@id", 1)
        Dim sql As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        sql.Fill(table)

        'Variable declaration
        Dim cc As Integer
        Dim roadtax As Double = 0.00


        cc = Convert.ToInt32(table.Rows(0)(2).ToString)

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


        If table.Rows.Count > 0 Then
            lblDown.Text = table.Rows(0)(1).ToString
            'lblInstallment.Text = 
        Else
            MessageBox.Show("Username and Password do not match.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_carculatedb_1__1_DataSet1.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me._carculatedb_1__1_DataSet1.car)

    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click

    End Sub
End Class
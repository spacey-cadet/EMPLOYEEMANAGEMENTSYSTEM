Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Salary
    Dim Conn As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim Host As String = "localhost"
    Dim Username As String = "root"
    Dim Password As String = "lost1234"
    Dim DB As String = "employee_db"

    Private Sub FetchEmployeeData()
        If EmpId.Text = "" Then
            MsgBox("Enter employee id to search for")
        Else
            Conn = New MySqlConnection With {
               .ConnectionString = "server=" + Host + ";" + "userid=" + Username + ";" + "password=" + Password + ";" + "database=" + DB + ";"
                }
            Conn.Open()
            Dim query = "SELECT name, pos, education, sal FROM employee WHERE id='" & EmpId.Text & "'"
            COMMAND = New MySqlCommand(query, Conn)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As MySqlDataAdapter
            sda = New MySqlDataAdapter(COMMAND)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                NameTb.Text = dr(1).ToString()
                PosTb.Text = dr(2).ToString()
                EdlevTb.Text = dr(3).ToString()
                SalTb.Text = dr(4).ToString()


                NameTb.Visible = True
                PosTb.Visible = True
                EdlevTb.Visible = True
                SalTb.Visible = True

            Next
            Conn.Close()
        End If
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Me.Hide()
        Dim main = New MainForm
        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NameTb.Text = "" Then
            MsgBox("Select an Employee")
        Else
            SalView.Text = "Employee Id: " + EmpId.Text + vbCrLf + "Employee Name : " + NameTb.Text + vbCrLf + "Education Level: " + EdlevTb.Text + vbCrLf + "Salary: " + SalTb.Text + vbCrLf

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("******PAYSLIP********", New Font("Arial", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(SalView.Text, New Font("century Gothic", 20), Brushes.Black, 150, 190)

        e.Graphics.DrawString("==========Thank You For Your Service=======", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 150)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()
    End Sub

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
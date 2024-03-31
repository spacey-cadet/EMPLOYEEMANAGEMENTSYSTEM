Imports MySql.Data.MySqlClient

Public Class Employee
    Dim Conn As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Function CalculateSalary(position As String, education As String) As Decimal
        Dim baseSal As Decimal = 0
        Select Case position
            Case "Manager"
                Select Case education
                    Case "Diploma"
                        baseSal = 20000
                    Case "UnderGraduate"
                        baseSal = 40000
                    Case "Masters"
                        baseSal = 60000
                    Case "PhD"
                        baseSal = 100000
                    Case Else
                        baseSal = 10000
                End Select
            Case "Accountant"
                Select Case education
                    Case "Diploma"
                        baseSal = 10000
                    Case "UnderGraduate"
                        baseSal = 20000
                    Case "Masters"
                        baseSal = 30000
                    Case "PhD"
                        baseSal = 40000
                    Case Else
                        baseSal = 5000
                End Select
            Case "IT Guy"
                Select Case education
                    Case "Diploma"
                        baseSal = 15000
                    Case "UnderGraduate"
                        baseSal = 40000
                    Case "Masters"
                        baseSal = 70000
                    Case "PhD"
                        baseSal = 90000
                    Case Else
                        baseSal = 10000
                End Select
            Case "Security"
                Select Case education
                    Case "Diploma"
                        baseSal = 10000
                    Case "UnderGraduate"
                        baseSal = 20000
                    Case "Masters"
                        baseSal = 30000
                    Case "PhD"
                        baseSal = 40000
                    Case Else
                        baseSal = 5000
                End Select
            Case "Cleaner"
                Select Case education
                    Case "Diploma"
                        baseSal = 10000
                    Case "UnderGraduate"
                        baseSal = 20000
                    Case "Masters"
                        baseSal = 30000
                    Case "PhD"
                        baseSal = 40000
                    Case Else
                        baseSal = 5000
                End Select
            Case "Delivery"
                Select Case education
                    Case "Diploma"
                        baseSal = 10000
                    Case "UnderGraduate"
                        baseSal = 20000
                    Case "Masters"
                        baseSal = 30000
                    Case "PhD"
                        baseSal = 40000
                    Case Else
                        baseSal = 5000
                End Select
            Case "Intern"
                Select Case education
                    Case "Diploma"
                        baseSal = 5000
                    Case "UnderGraduate"
                        baseSal = 15000
                    Case "Masters"
                        baseSal = 20000
                    Case "PhD"
                        baseSal = 40000
                    Case Else
                        baseSal = 0
                End Select
        End Select
        Return baseSal
    End Function
    Private Sub Populate()
        Conn = New MySqlConnection With {
            .ConnectionString = "server=localhost; userid=root; password=lost1234; database=employee_db"
        }
        Conn.Open()
        Dim sql = "SELECT * FROM employee"
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(sql, Conn)
        Dim builder As MySqlCommandBuilder
        builder = New MySqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDataGridView.DataSource = ds.Tables(0)
        Conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conn = New MySqlConnection With {
            .ConnectionString = "server=localhost; userid=root; password=lost1234; database=employee_db"
        }
        Dim Sal As Decimal = CalculateSalary(ComboBoxPosition.SelectedItem.ToString(), ComboBoxEducation.SelectedItem.ToString())
        Try
            Conn.Open()
            Dim Query As String
            Query = "INSERT INTO employee(name,address, phone, sex, pos,education, dob, sal) VALUES ('" & NameTextBox.Text & "','" & AddressTextBox.Text & "', '" & PhoneTextBox.Text & "', '" & ComboBoxGender.SelectedItem.ToString() & "', '" & ComboBoxPosition.SelectedItem.ToString() & "',  '" & ComboBoxEducation.SelectedItem.ToString() & "', '" & EmpDOB.Value & "', '" & Sal & "')"
            COMMAND = New MySqlCommand(Query, Conn)
            COMMAND.ExecuteNonQuery()
            MsgBox("Employee added")
            Conn.Close()
            Populate()
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim key = 0

    Private Sub Clear()
        key = 0
        NameTextBox.Clear()
        AddressTextBox.Text = ""
        PhoneTextBox.Text = ""
        ComboBoxGender.Text = ""
        ComboBoxPosition.Text = ""
        ComboBoxEducation.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("select the empoyee you want to remove")

        Else
            Try
                Conn = New MySqlConnection With {
                    .ConnectionString = "server=localhost; userid=root; password=lost1234; database=employee_db"
        }
                Conn.Open()
                Dim query As String
                query = "DELETE FROM employee WHERE id = " & key & ""
                COMMAND = New MySqlCommand(query, Conn)
                COMMAND.ExecuteNonQuery()
                MsgBox("Employee Removed")
                Conn.Close()
                Populate()
                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub EmployeeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellContentClick
        Dim row As DataGridViewRow = EmployeeDataGridView.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        NameTextBox.Text = row.Cells(1).Value.ToString()
        AddressTextBox.Text = row.Cells(2).Value.ToString()
        PhoneTextBox.Text = row.Cells(3).Value.ToString()
        ComboBoxGender.SelectedItem = row.Cells(4).Value.ToString()
        ComboBoxPosition.SelectedItem = row.Cells(5).Value.ToString()
        ComboBoxEducation.SelectedItem = row.Cells(6).Value.ToString()
        EmpDOB.Value = row.Cells(7).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NameTextBox.Text = "" Or AddressTextBox.Text = "" Then
            MsgBox("Nothing to Edit")
        Else
            Conn = New MySqlConnection With {
                .ConnectionString = "server=localhost , userid=root, password='lost1234', database=employee_db"
        }
            Conn.Open()
            Dim query As String
            Dim Sal As Decimal = CalculateSalary(ComboBoxPosition.SelectedItem.ToString(), ComboBoxEducation.SelectedItem.ToString())
            query = " UPDATE employee SET name='" & NameTextBox.Text & "' , address= '" & AddressTextBox.Text & "', phone = '" & PhoneTextBox.Text & "', sex= '" & ComboBoxGender.SelectedItem.ToString() & ",  pos='" & ComboBoxPosition.SelectedItem.ToString() & "',education= '" & ComboBoxEducation.SelectedItem.ToString() & "', dob= '" & EmpDOB.Value & "', sal= '" & Sal & "' WHERE id=" & key & ""
            COMMAND = New MySqlCommand(query, Conn)
            COMMAND.ExecuteNonQuery()
            MsgBox("Employee updated")
            Conn.Close()
            Populate()
            Clear()

        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class
Public Class MainForm
    Private Sub DetailsLb_Click(sender As Object, e As EventArgs) Handles DetailsLb.Click
        Me.Hide()
        Dim EmpDetails = New EmployeeDetails
        EmpDetails.Show()
    End Sub

    Private Sub EmployeeLb_Click(sender As Object, e As EventArgs) Handles EmployeeLb.Click
        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()
    End Sub

    Private Sub SalaryLb_Click(sender As Object, e As EventArgs) Handles SalaryLb.Click
        Me.Hide()
        Dim EmpSal = New Salary
        EmpSal.Show()

    End Sub

    Private Sub LogoutLb_Click(sender As Object, e As EventArgs) Handles LogoutLb.Click
        Me.Hide()
        Dim log = New Login
        log.Show()

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        SalaryLb = New Label()
        DetailsLb = New Label()
        EmployeeLb = New Label()
        LogoutLb = New Label()
        DashBoardLb = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(SalaryLb)
        Panel1.Controls.Add(DetailsLb)
        Panel1.Controls.Add(EmployeeLb)
        Panel1.Location = New Point(-4, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(805, 156)
        Panel1.TabIndex = 0
        ' 
        ' SalaryLb
        ' 
        SalaryLb.AutoSize = True
        SalaryLb.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SalaryLb.Location = New Point(39, 64)
        SalaryLb.Name = "SalaryLb"
        SalaryLb.Size = New Size(57, 18)
        SalaryLb.TabIndex = 6
        SalaryLb.Text = "Salary"
        ' 
        ' DetailsLb
        ' 
        DetailsLb.AutoSize = True
        DetailsLb.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DetailsLb.Location = New Point(39, 101)
        DetailsLb.Name = "DetailsLb"
        DetailsLb.Size = New Size(61, 18)
        DetailsLb.TabIndex = 5
        DetailsLb.Text = "Details"
        ' 
        ' EmployeeLb
        ' 
        EmployeeLb.AutoSize = True
        EmployeeLb.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmployeeLb.Location = New Point(39, 29)
        EmployeeLb.Name = "EmployeeLb"
        EmployeeLb.Size = New Size(80, 18)
        EmployeeLb.TabIndex = 4
        EmployeeLb.Text = "Employee"
        ' 
        ' LogoutLb
        ' 
        LogoutLb.AutoSize = True
        LogoutLb.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutLb.Location = New Point(668, 27)
        LogoutLb.Name = "LogoutLb"
        LogoutLb.Size = New Size(59, 18)
        LogoutLb.TabIndex = 3
        LogoutLb.Text = "Logout"
        ' 
        ' DashBoardLb
        ' 
        DashBoardLb.AutoSize = True
        DashBoardLb.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashBoardLb.Location = New Point(36, 27)
        DashBoardLb.Name = "DashBoardLb"
        DashBoardLb.Size = New Size(50, 18)
        DashBoardLb.TabIndex = 4
        DashBoardLb.Text = "Home"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(798, 265)
        Controls.Add(DashBoardLb)
        Controls.Add(LogoutLb)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        Text = "MainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SalaryLb As Label
    Friend WithEvents DetailsLb As Label
    Friend WithEvents EmployeeLb As Label
    Friend WithEvents LogoutLb As Label
    Friend WithEvents DashBoardLb As Label
End Class

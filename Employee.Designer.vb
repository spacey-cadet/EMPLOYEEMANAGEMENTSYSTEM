<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Label1 = New Label()
        Panel1 = New Panel()
        EmployeeDataGridView = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        EmpDOB = New DateTimePicker()
        PhoneTextBox = New TextBox()
        ComboBoxEducation = New ComboBox()
        ComboBoxPosition = New ComboBox()
        ComboBoxGender = New ComboBox()
        AddressTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(EmployeeDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(71, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 18)
        Label1.TabIndex = 5
        Label1.Text = "Employee Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(EmployeeDataGridView)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(EmpDOB)
        Panel1.Controls.Add(PhoneTextBox)
        Panel1.Controls.Add(ComboBoxEducation)
        Panel1.Controls.Add(ComboBoxPosition)
        Panel1.Controls.Add(ComboBoxGender)
        Panel1.Controls.Add(AddressTextBox)
        Panel1.Controls.Add(NameTextBox)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(42, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(872, 441)
        Panel1.TabIndex = 6
        ' 
        ' EmployeeDataGridView
        ' 
        EmployeeDataGridView.BackgroundColor = SystemColors.Control
        EmployeeDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
        EmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        EmployeeDataGridView.Location = New Point(428, 3)
        EmployeeDataGridView.Name = "EmployeeDataGridView"
        EmployeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        EmployeeDataGridView.Size = New Size(441, 408)
        EmployeeDataGridView.TabIndex = 23
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(45, 277)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 22
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(336, 277)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 21
        Button3.Text = "Remove"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(134, 277)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 19
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' EmpDOB
        ' 
        EmpDOB.Location = New Point(191, 232)
        EmpDOB.Name = "EmpDOB"
        EmpDOB.Size = New Size(220, 23)
        EmpDOB.TabIndex = 18
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(191, 90)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(220, 23)
        PhoneTextBox.TabIndex = 17
        ' 
        ' ComboBoxEducation
        ' 
        ComboBoxEducation.FormattingEnabled = True
        ComboBoxEducation.Items.AddRange(New Object() {"Diploma", "UnderGraduate", "Masters", "PhD"})
        ComboBoxEducation.Location = New Point(191, 196)
        ComboBoxEducation.Name = "ComboBoxEducation"
        ComboBoxEducation.Size = New Size(220, 23)
        ComboBoxEducation.TabIndex = 16
        ' 
        ' ComboBoxPosition
        ' 
        ComboBoxPosition.FormattingEnabled = True
        ComboBoxPosition.Items.AddRange(New Object() {"Manager", "Cleaner", "Accountant", "IT Guy", "Security", "Delivery", "Intern"})
        ComboBoxPosition.Location = New Point(191, 159)
        ComboBoxPosition.Name = "ComboBoxPosition"
        ComboBoxPosition.Size = New Size(220, 23)
        ComboBoxPosition.TabIndex = 15
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Items.AddRange(New Object() {"M", "F"})
        ComboBoxGender.Location = New Point(191, 123)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(220, 23)
        ComboBoxGender.TabIndex = 14
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(191, 63)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(220, 23)
        AddressTextBox.TabIndex = 13
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(191, 30)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(220, 23)
        NameTextBox.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(112, 232)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 18)
        Label8.TabIndex = 11
        Label8.Text = "DOB"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(29, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 18)
        Label7.TabIndex = 10
        Label7.Text = "Education Level"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(86, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 18)
        Label6.TabIndex = 9
        Label6.Text = "Position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(93, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 18)
        Label5.TabIndex = 8
        Label5.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(99, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 18)
        Label4.TabIndex = 7
        Label4.Text = "Phone"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(87, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 18)
        Label3.TabIndex = 6
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(102, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(230, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 20
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(896, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(18, 18)
        Label9.TabIndex = 7
        Label9.Text = "X"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(941, 539)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        Text = "Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(EmployeeDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpDOB As DateTimePicker
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents ComboBoxEducation As ComboBox
    Friend WithEvents ComboBoxPosition As ComboBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EmployeeDataGridView As DataGridView
    Friend WithEvents Label9 As Label
End Class

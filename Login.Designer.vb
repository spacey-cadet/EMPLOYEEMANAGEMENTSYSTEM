<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(316, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 18)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(142, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(387, 29)
        Label2.TabIndex = 1
        Label2.Text = "Employee Management System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(123, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 18)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(123, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 18)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(257, 159)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(222, 23)
        UsernameTextBox.TabIndex = 4
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(257, 206)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(222, 23)
        PasswordTextBox.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(316, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(370, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(770, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(18, 18)
        Label6.TabIndex = 8
        Label6.Text = "X"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(709, 388)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

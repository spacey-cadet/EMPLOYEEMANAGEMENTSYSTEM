<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetails))
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        EmpId = New TextBox()
        Label9 = New Label()
        Button3 = New Button()
        Panel1 = New Panel()
        Label10 = New Label()
        NameTb = New TextBox()
        AddressTb = New TextBox()
        PhoneTb = New TextBox()
        GenderTb = New TextBox()
        PosTb = New TextBox()
        EdlevTb = New TextBox()
        DOBTb = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 6
        Label1.Text = "Employee Details"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(282, 365)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 21
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(495, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 22
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(259, 300)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 18)
        Label8.TabIndex = 29
        Label8.Text = "DOB"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(176, 264)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 18)
        Label7.TabIndex = 28
        Label7.Text = "Education Level"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(233, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 18)
        Label6.TabIndex = 27
        Label6.Text = "Position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(240, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 18)
        Label5.TabIndex = 26
        Label5.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(246, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 18)
        Label4.TabIndex = 25
        Label4.Text = "Phone"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(234, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 18)
        Label3.TabIndex = 24
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 23
        Label2.Text = "Name"
        ' 
        ' EmpId
        ' 
        EmpId.Location = New Point(312, 63)
        EmpId.Name = "EmpId"
        EmpId.Size = New Size(222, 23)
        EmpId.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(200, 68)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 18)
        Label9.TabIndex = 30
        Label9.Text = "Employee ID"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(540, 63)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 32
        Button3.Text = "See Details"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-4, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(805, 60)
        Panel1.TabIndex = 33
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(774, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 18)
        Label10.TabIndex = 7
        Label10.Text = "X"
        ' 
        ' NameTb
        ' 
        NameTb.ForeColor = SystemColors.ControlText
        NameTb.Location = New Point(312, 98)
        NameTb.Name = "NameTb"
        NameTb.Size = New Size(222, 23)
        NameTb.TabIndex = 34
        NameTb.Visible = False
        ' 
        ' AddressTb
        ' 
        AddressTb.ForeColor = SystemColors.ControlText
        AddressTb.Location = New Point(312, 131)
        AddressTb.Name = "AddressTb"
        AddressTb.Size = New Size(222, 23)
        AddressTb.TabIndex = 35
        AddressTb.Visible = False
        ' 
        ' PhoneTb
        ' 
        PhoneTb.ForeColor = SystemColors.ControlText
        PhoneTb.Location = New Point(312, 163)
        PhoneTb.Name = "PhoneTb"
        PhoneTb.Size = New Size(222, 23)
        PhoneTb.TabIndex = 36
        PhoneTb.Visible = False
        ' 
        ' GenderTb
        ' 
        GenderTb.ForeColor = SystemColors.ControlText
        GenderTb.Location = New Point(308, 196)
        GenderTb.Name = "GenderTb"
        GenderTb.Size = New Size(222, 23)
        GenderTb.TabIndex = 37
        GenderTb.Visible = False
        ' 
        ' PosTb
        ' 
        PosTb.ForeColor = SystemColors.ControlText
        PosTb.Location = New Point(312, 232)
        PosTb.Name = "PosTb"
        PosTb.Size = New Size(222, 23)
        PosTb.TabIndex = 38
        PosTb.Visible = False
        ' 
        ' EdlevTb
        ' 
        EdlevTb.ForeColor = SystemColors.ControlText
        EdlevTb.Location = New Point(312, 264)
        EdlevTb.Name = "EdlevTb"
        EdlevTb.Size = New Size(222, 23)
        EdlevTb.TabIndex = 39
        EdlevTb.Visible = False
        ' 
        ' DOBTb
        ' 
        DOBTb.ForeColor = SystemColors.ControlText
        DOBTb.Location = New Point(312, 295)
        DOBTb.Name = "DOBTb"
        DOBTb.Size = New Size(222, 23)
        DOBTb.TabIndex = 40
        DOBTb.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' EmployeeDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DOBTb)
        Controls.Add(EdlevTb)
        Controls.Add(PosTb)
        Controls.Add(GenderTb)
        Controls.Add(PhoneTb)
        Controls.Add(AddressTb)
        Controls.Add(NameTb)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(EmpId)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Button2)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeDetails"
        Text = "EmployeeDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NameTb As TextBox
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents GenderTb As TextBox
    Friend WithEvents PosTb As TextBox
    Friend WithEvents EdlevTb As TextBox
    Friend WithEvents DOBTb As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label10 As Label
End Class

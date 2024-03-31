<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        Panel1 = New Panel()
        Label11 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        EmpId = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        Home = New Button()
        Button4 = New Button()
        NameTb = New TextBox()
        PosTb = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        EdlevTb = New TextBox()
        Label10 = New Label()
        SalTb = New TextBox()
        SalView = New RichTextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 75)
        Panel1.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(770, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(18, 18)
        Label11.TabIndex = 7
        Label11.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 18)
        Label1.TabIndex = 6
        Label1.Text = "Salary"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(175, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 18)
        Label7.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(241, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(247, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 18)
        Label4.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(235, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 18)
        Label3.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(87, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 12
        Label2.Text = "Name"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(424, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 35
        Button3.Text = "FetchSalary"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' EmpId
        ' 
        EmpId.Location = New Point(164, 97)
        EmpId.Name = "EmpId"
        EmpId.Size = New Size(222, 23)
        EmpId.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(36, 97)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 18)
        Label9.TabIndex = 33
        Label9.Text = "Employee ID"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(311, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 37
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        Home.Location = New Point(160, 321)
        Home.Name = "Home"
        Home.Size = New Size(75, 23)
        Home.TabIndex = 36
        Home.Text = "Home"
        Home.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(682, 415)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 38
        Button4.Text = "Print"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' NameTb
        ' 
        NameTb.Location = New Point(164, 150)
        NameTb.Name = "NameTb"
        NameTb.Size = New Size(222, 23)
        NameTb.TabIndex = 40
        NameTb.Visible = False
        ' 
        ' PosTb
        ' 
        PosTb.Location = New Point(164, 188)
        PosTb.Name = "PosTb"
        PosTb.Size = New Size(222, 23)
        PosTb.TabIndex = 41
        PosTb.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(69, 188)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 18)
        Label6.TabIndex = 16
        Label6.Text = "Position"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 225)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 18)
        Label8.TabIndex = 42
        Label8.Text = "Education Level"
        ' 
        ' EdlevTb
        ' 
        EdlevTb.Location = New Point(164, 225)
        EdlevTb.Name = "EdlevTb"
        EdlevTb.Size = New Size(222, 23)
        EdlevTb.TabIndex = 43
        EdlevTb.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(69, 267)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 18)
        Label10.TabIndex = 44
        Label10.Text = "Salary"
        ' 
        ' SalTb
        ' 
        SalTb.Location = New Point(164, 262)
        SalTb.Name = "SalTb"
        SalTb.Size = New Size(222, 23)
        SalTb.TabIndex = 45
        SalTb.Visible = False
        ' 
        ' SalView
        ' 
        SalView.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SalView.Location = New Point(521, 99)
        SalView.Name = "SalView"
        SalView.Size = New Size(236, 310)
        SalView.TabIndex = 46
        SalView.Text = ""
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
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SalView)
        Controls.Add(SalTb)
        Controls.Add(Label10)
        Controls.Add(EdlevTb)
        Controls.Add(Label8)
        Controls.Add(PosTb)
        Controls.Add(NameTb)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(Home)
        Controls.Add(Button3)
        Controls.Add(EmpId)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        Text = "Salary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents EmpId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Home As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NameTb As TextBox
    Friend WithEvents PosTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EdlevTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SalTb As TextBox
    Friend WithEvents SalView As RichTextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label11 As Label
End Class

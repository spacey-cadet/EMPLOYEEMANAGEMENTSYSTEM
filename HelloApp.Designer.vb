<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelloApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        ProgressBarStart = New ProgressBar()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(193, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 46)
        Label1.TabIndex = 0
        Label1.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        ' 
        ' ProgressBarStart
        ' 
        ProgressBarStart.ForeColor = SystemColors.ControlDarkDark
        ProgressBarStart.Location = New Point(314, 232)
        ProgressBarStart.Name = "ProgressBarStart"
        ProgressBarStart.Size = New Size(156, 16)
        ProgressBarStart.TabIndex = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' HelloApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBarStart)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "HelloApp"
        Text = "Timer"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBarStart As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class

Public Class HelloApp
    Private Sub Timer_1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBarStart.Increment(2)
        Try
            If ProgressBarStart.Value = 100 Then
                Me.Hide()
                Dim log = New Login
                log.Show()
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub HalloApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class

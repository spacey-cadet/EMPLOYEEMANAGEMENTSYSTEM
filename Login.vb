Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Credentials mising")
        Else
            If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "pass" Then
                Me.Hide()
                Dim Main = New MainForm
                Main.Show()

            Else
                MsgBox("Invalid credentials")
            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
End Class
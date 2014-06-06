Public Class loadingform

    Private Sub loadingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ProgressBar1.Value < 1 Then
            Timer1.Enabled = True
            Me.Focus()
            Game2.Show()
            Me.Focus()

        End If
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 99 Then
            Timer1.Enabled = False

            Me.Hide()
            Game2.StartPosition = FormStartPosition.CenterParent
            Game2.StartPosition = FormStartPosition.CenterScreen
            Game2.Focus()
            Game2.StartPosition = FormStartPosition.CenterParent
            Game2.StartPosition = FormStartPosition.CenterScreen


        End If
        ProgressBar1.Value = ProgressBar1.Value + 1
    End Sub
End Class
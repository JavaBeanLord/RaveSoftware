Public Class Game2

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.reels, AudioPlayMode.BackgroundLoop)
        Timer1.Enabled = True
    End Sub
    Private Sub Game2_CLose(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox1_Mouse_Hover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.btn_start_down
    End Sub
    Private Sub PictureBox1_Mouse_Leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.btn_start_default
    End Sub


End Class
Public Class Game2

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.reels, AudioPlayMode.BackgroundLoop)

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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Slot Cluster One
        PictureBox2.Image = My.Resources.symbol_7
        PictureBox3.Image = My.Resources.symbol_bell
        PictureBox4.Image = My.Resources.symbol_cherry
        PictureBox1.Enabled = False

        'timer clust
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Image = My.Resources.symbol_melon
        PictureBox3.Image = My.Resources.symbol_7
        PictureBox4.Image = My.Resources.symbol_bell

        'timer cluster
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox2.Image = My.Resources.symbol_bell
        PictureBox3.Image = My.Resources.symbol_cherry
        PictureBox4.Image = My.Resources.symbol_melon

        'timer cluster
        Timer3.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = True
    End Sub

  

End Class
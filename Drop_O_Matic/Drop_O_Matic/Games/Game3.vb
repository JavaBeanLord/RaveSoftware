Public Class Game3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Image = My.Resources._13SmallR2D2
        PictureBox3.Image = My.Resources._8MediumVader
        PictureBox4.Image = My.Resources._5LargeDeathStar


        PictureBox7.Image = My.Resources.SmallVader
        PictureBox6.Image = My.Resources._14MediumR2D2
        PictureBox5.Image = My.Resources._12BigStormTrooper

        PictureBox10.Image = My.Resources.SmallDeathStar
        PictureBox9.Image = My.Resources._11MediumStormTrooper
        PictureBox8.Image = My.Resources._15BigR2D2

        PictureBox13.Image = My.Resources._10SmallStormTrooper
        PictureBox12.Image = My.Resources._8MediumVader
        PictureBox11.Image = My.Resources._5LargeDeathStar

        'timer clust
        Timer1.Enabled = False
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Image = My.Resources.SmallDeathStar
        PictureBox3.Image = My.Resources._14MediumR2D2
        PictureBox4.Image = My.Resources._9BigVader

        PictureBox7.Image = My.Resources._10SmallStormTrooper
        PictureBox6.Image = My.Resources._8MediumVader
        PictureBox5.Image = My.Resources._15BigR2D2

        PictureBox10.Image = My.Resources._13SmallR2D2
        PictureBox9.Image = My.Resources._4MediumDeathStar
        PictureBox8.Image = My.Resources._12BigStormTrooper

        PictureBox13.Image = My.Resources.SmallDeathStar
        PictureBox12.Image = My.Resources._11MediumStormTrooper
        PictureBox11.Image = My.Resources._9BigVader

        'timer cluster
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox2.Image = My.Resources.SmallVader
        PictureBox3.Image = My.Resources._4MediumDeathStar
        PictureBox4.Image = My.Resources._15BigR2D2

        PictureBox7.Image = My.Resources._13SmallR2D2
        PictureBox6.Image = My.Resources._11MediumStormTrooper
        PictureBox5.Image = My.Resources._9BigVader

        PictureBox10.Image = My.Resources._10SmallStormTrooper
        PictureBox9.Image = My.Resources._14MediumR2D2
        PictureBox8.Image = My.Resources._5LargeDeathStar

        PictureBox13.Image = My.Resources.SmallVader
        PictureBox12.Image = My.Resources._4MediumDeathStar
        PictureBox11.Image = My.Resources._12BigStormTrooper

        'timer cluster
        Timer3.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Game3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        GameLoginScreen.Load_User_Amount()
        GameLoginScreen.TextBox1.Text = ("")
        ' GameLoginScreen.Show()
        Games.Show()
    End Sub
End Class
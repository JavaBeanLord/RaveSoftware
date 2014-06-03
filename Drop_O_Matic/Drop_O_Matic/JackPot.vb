Public Class JackPot

    Private Sub JackPot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rnd1 = New Random()
        Dim BigPot = rnd1.Next(99999)
        Dim rnd2 = New Random()
        Dim MidPot = rnd2.Next(9999)
        Dim rnd3 = New Random()
        Dim SmallPot = rnd3.Next(999)

        TextBox1.Text = BigPot
        TextBox2.Text = MidPot
        TextBox3.Text = SmallPot






    End Sub
End Class
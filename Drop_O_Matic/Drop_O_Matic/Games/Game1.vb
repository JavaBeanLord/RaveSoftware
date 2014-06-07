Public Class Game1

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = ("")
        Label1.Text = ("")

        ''JackPot Round
        Dim Jrnd = New Random()
        Dim SmallJackPot = Jrnd.Next(999)
        ''First Slot Round
        Dim rnd1 = New Random()
        Dim WOne = rnd1.Next(7)
        ''2nd Slot Round
        Dim rnd2 = New Random()
        Dim WTwo = rnd2.Next(13)
        ''3rd Slot Round
        Dim rnd3 = New Random()
        Dim WThree = rnd3.Next(19)
        ''Turn Timer1 One
        Timer1.Enabled = True

        TextBox1.Text = (WOne).ToString
        TextBox2.Text = (WTwo).ToString
        TextBox3.Text = (WThree).ToString
        TextBox8.Text = (SmallJackPot).ToString


        ' PictureBox1.Location = New Point(12, 189)

        TextBox5.Text = 0.5
        TextBox7.Text = TextBox7.Text - TextBox5.Text

        PlaySpinFile()
        If TextBox8.Text = JackPot.TextBox3.Text Then
            MessageBox.Show("You Hit $25.00 JackPot")

            Dim SmallPostChange = New Random()
            Dim SmallPot = SmallPostChange.Next(9)

            JackPot.TextBox3.Text = SmallPot.ToString
        Else

        End If




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If PictureBox1.Location.Y < 101 Then
            PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X, (PictureBox1.Location.Y + 75))
        Else
            PictureBox1.Location = New Point(12, -100)
        End If

        If PictureBox2.Location.Y < 101 Then
            PictureBox2.Location = New System.Drawing.Point(PictureBox2.Location.X, (PictureBox2.Location.Y + 75))
        Else
            PictureBox2.Location = New Point(206, -100)
        End If

        If PictureBox3.Location.Y < 101 Then
            PictureBox3.Location = New System.Drawing.Point(PictureBox3.Location.X, (PictureBox3.Location.Y + 75))
        Else
            PictureBox3.Location = New Point(391, -100)
        End If

        Button1.Enabled = False
        Timer2.Enabled = True


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False

        If TextBox1.Text = 0 Then
            PictureBox1.Location = New Point(12, -100)
        ElseIf TextBox1.Text = 6 Then
            PictureBox1.Location = New Point(12, 100)
        Else

            PictureBox1.Location = New Point(12, 0)
        End If

        If TextBox2.Text = 0 Then
            PictureBox2.Location = New Point(206, 0)
        ElseIf TextBox2.Text = 12 Then
            PictureBox2.Location = New Point(206, 100)
        Else
            PictureBox2.Location = New Point(206, -100)
        End If

        If TextBox3.Text = 0 Then
            PictureBox3.Location = New Point(391, 100)
        ElseIf TextBox3.Text = 18 Then
            PictureBox3.Location = New Point(391, 0)
        Else
            PictureBox3.Location = New Point(391, -100)
        End If

        TextBox4.Text = TextBox1.Text & TextBox2.Text & TextBox3.Text
        If TextBox4.Text = ("000") Then
            Label1.Text = "WINNER"
            TextBox6.Text = TextBox6.Text + 30 * TextBox5.Text
        Else
            Label1.Text = "BUST"


        End If

        Button1.Enabled = True
        Timer2.Enabled = False



    End Sub

    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = (0).ToString
        TextBox7.Text = (100).ToString
        Label1.Visible = False

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Sub PlaySpinFile()
        My.Computer.Audio.Play(My.Resources.spin, AudioPlayMode.Background)
    End Sub


    Public Sub slotplaysound()
        Dim audio2 As New AudioFile("C:\Users\Admin1\Desktop\Sounds\GameOver.mp3")
        audio2.Play()
    End Sub
End Class
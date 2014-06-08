Imports System.Data.OleDb
Public Class Game2

#Region "CONNECT"
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Private Builder As New OleDb.OleDbConnectionStringBuilder With _
    { _
        .Provider = "Microsoft.ACE.OLEDB.12.0", _
        .DataSource = IO.Path.Combine(My.Settings.DataBasePath) _
    }
#End Region


    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(My.Resources.reels, AudioPlayMode.BackgroundLoop)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen

        MainShow.ControlBox = False
        MainShow.MainMenuStrip.Visible = False
        MainShow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        TextBox2.Text = My.Settings.UserAmount.ToString

        GameLoginScreen.Load_User_Amount()



        My.Settings.BetAmount = (50)
        TextBox3.Text = My.Settings.BetAmount.ToString





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
        PictureBox2.Image = My.Resources.symbol_melon
        PictureBox3.Image = My.Resources.symbol_bell
        PictureBox4.Image = My.Resources.symbol_cherry
        PictureBox1.Enabled = False

        PictureBox7.Image = My.Resources.symbol_cherry
        PictureBox6.Image = My.Resources.symbol_melon
        PictureBox5.Image = My.Resources.symbol_bell

        PictureBox10.Image = My.Resources.symbol_bell
        PictureBox9.Image = My.Resources.symbol_cherry
        PictureBox8.Image = My.Resources.symbol_melon

        PictureBox13.Image = My.Resources.symbol_melon
        PictureBox12.Image = My.Resources.symbol_bell
        PictureBox11.Image = My.Resources.symbol_cherry

        PictureBox16.Image = My.Resources.symbol_cherry
        PictureBox15.Image = My.Resources.symbol_melon
        PictureBox14.Image = My.Resources.symbol_bell

        'timer clust
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Image = My.Resources.symbol_cherry
        PictureBox3.Image = My.Resources.symbol_melon
        PictureBox4.Image = My.Resources.symbol_bell

        PictureBox7.Image = My.Resources.symbol_bell
        PictureBox6.Image = My.Resources.symbol_cherry
        PictureBox5.Image = My.Resources.symbol_melon

        PictureBox10.Image = My.Resources.symbol_melon
        PictureBox9.Image = My.Resources.symbol_bell
        PictureBox8.Image = My.Resources.symbol_cherry

        PictureBox13.Image = My.Resources.symbol_cherry
        PictureBox12.Image = My.Resources.symbol_melon
        PictureBox11.Image = My.Resources.symbol_bell

        PictureBox16.Image = My.Resources.symbol_bell
        PictureBox15.Image = My.Resources.symbol_cherry
        PictureBox14.Image = My.Resources.symbol_melon

        'timer cluster
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox2.Image = My.Resources.symbol_bell
        PictureBox3.Image = My.Resources.symbol_cherry
        PictureBox4.Image = My.Resources.symbol_melon

        PictureBox7.Image = My.Resources.symbol_melon
        PictureBox6.Image = My.Resources.symbol_bell
        PictureBox5.Image = My.Resources.symbol_cherry

        PictureBox10.Image = My.Resources.symbol_cherry
        PictureBox9.Image = My.Resources.symbol_melon
        PictureBox8.Image = My.Resources.symbol_bell

        PictureBox13.Image = My.Resources.symbol_bell
        PictureBox12.Image = My.Resources.symbol_cherry
        PictureBox11.Image = My.Resources.symbol_melon

        PictureBox16.Image = My.Resources.symbol_melon
        PictureBox15.Image = My.Resources.symbol_bell
        PictureBox14.Image = My.Resources.symbol_cherry

        'timer cluster
        Timer3.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



        If My.Settings.UserAmount = 0 Then

            MessageBox.Show("You Broke!")
            TextBox2.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
        Else
            My.Computer.Audio.Play(My.Resources.reel, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.reels, AudioPlayMode.BackgroundLoop)
            Timer1.Enabled = True
            Timer4.Enabled = True
            Timer5.Enabled = False
            Timer6.Enabled = False

            PictureBox3.Visible = True
            PictureBox6.Visible = True
            PictureBox9.Visible = True
            My.Settings.UserAmount = My.Settings.UserAmount - My.Settings.BetAmount
            TextBox2.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
        End If



        TextBox3.Enabled = False


    End Sub

    Private Sub VALUE_Timer()
        Dim ServerConnect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
        Dim ServerCommand As New OleDb.OleDbCommand()
        Dim ServerUpdate As String
        ServerConnect.Open()
        ServerUpdate = "UPDATE Table1 SET [CAmount] = '" & My.Settings.UserAmount & "' WHERE ID = " & My.Settings.UserIDNumber & ";"
        ServerCommand = New OleDbCommand(ServerUpdate, ServerConnect)
        Try

            ServerCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Could not perform this task because " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

        ServerCommand = Nothing
        ServerConnect.Close()
    End Sub



    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ''First Slot Round
        Dim rnd1 = New Random()
        Dim WOne = rnd1.Next(My.Settings.WOnePayOut)
        ''2nd Slot Round
        Dim rnd2 = New Random()
        Dim WTwo = rnd2.Next(My.Settings.WTwoPayOut)
        ''3rd Slot Round
        Dim rnd3 = New Random()
        Dim WThree = rnd3.Next(My.Settings.WThreePayOut)



        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        My.Computer.Audio.Stop()

        If WOne.ToString + WTwo.ToString + WThree.ToString = ("000") Then
            Timer4.Enabled = False
            PictureBox3.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox9.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer5.Enabled = True
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (100) * My.Settings.BetAmount
            TextBox2.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        If WOne.ToString + WTwo.ToString + WThree.ToString = ("034") Then
            Timer4.Enabled = False
            PictureBox4.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox8.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (100) * My.Settings.BetAmount
            TextBox2.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        If WOne.ToString + WTwo.ToString + WThree.ToString = ("123") Then
            Timer4.Enabled = False
            PictureBox2.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox10.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (100) * My.Settings.BetAmount
            TextBox2.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        Jack_Pot()
        Timer4.Enabled = False

        PictureBox1.Enabled = True

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox3.Visible = False
        PictureBox6.Visible = False
        PictureBox9.Visible = False
        Timer5.Enabled = False
        Timer6.Enabled = True
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        PictureBox3.Visible = True
        PictureBox6.Visible = True
        PictureBox9.Visible = True
        Timer6.Enabled = False
        Timer5.Enabled = True
    End Sub

    Private Sub Jack_Pot()
        Try
            ''SmallJackPot PayOut
            Dim SmallJackRandom = New Random()
            Dim SmallJackPotNumber = SmallJackRandom.Next(My.Settings.SmallJackPot)

            Using cn As New OleDbConnection(Builder.ConnectionString)
                Using cmd As New OleDbCommand("SELECT SmallJackPot FROM JackPot WHERE SmallJackPot = ? AND ID = 1 ", cn)
                    cmd.Parameters.AddWithValue("SmallJackPot", SmallJackPotNumber)
                    Try
                        cn.Open()
                        Dim reader As OleDbDataReader = cmd.ExecuteReader
                        If Not reader.HasRows Then
                            ''false you lose jackPot
                        Else
                            MessageBox.Show(SmallJackPotNumber.ToString & "Winner!")
                            JackPot.Timer1.Enabled = True
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString & "DataBase Connect " & " Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Big Big Error!!")
        End Try

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

        If My.Settings.BetAmount < (500) Then
            My.Settings.BetAmount = (My.Settings.BetAmount + (50))



        ElseIf My.Settings.BetAmount = (500) Then
            My.Settings.BetAmount = (0)
        End If
        TextBox3.Text = My.Settings.BetAmount.ToString
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Me.Close()
        GameLoginScreen.Load_User_Amount()
        GameLoginScreen.TextBox1.Text = ("")
        GameLoginScreen.Show()

    End Sub
End Class
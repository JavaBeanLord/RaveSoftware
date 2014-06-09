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
        Label4.Text = My.Settings.UserAmount.ToString

        GameLoginScreen.Load_User_Amount()



        My.Settings.BetAmount = (100)
        Label2.Text = My.Settings.BetAmount.ToString
        Label1.Text = My.Settings.LineAmount.ToString
        PictureBox20.Visible = True




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

#Region "Sipin Reel"
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
#End Region


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



        If My.Settings.UserAmount = 0 Then
            VALUE_Timer()
            Label4.Text = ("Please Buy More Entries!")
            PictureBox19.Visible = False
            Label1.Visible = False


        ElseIf My.Settings.BetAmount * My.Settings.LineAmount > My.Settings.UserAmount Then
            My.Settings.LineAmount = (1)
            Me.Label1.Text = (My.Settings.LineAmount).ToString
            My.Settings.BetAmount = (100)
            Me.Label2.Text = (My.Settings.BetAmount).ToString
            Label4.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
            ClearLineIMage()
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
            My.Settings.UserAmount = My.Settings.UserAmount - My.Settings.BetAmount * My.Settings.LineAmount
            Label4.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
            Label4.Text = ("Good Luck!")
            ClearLineIMage()
        End If






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

        Dim LineCount As String
        LineCount = Label1.Text
        Dim WinRow1 As String
        WinRow1 = WOne.ToString + WTwo.ToString + WThree.ToString
        Dim W1 As String
        W1 = ("000")
        ''Win Line 1
        If WinRow1 = W1 And LineCount = 1.ToString Or _
           WinRow1 = W1 And LineCount = 2.ToString Or _
           WinRow1 = W1 And LineCount = 3.ToString Or _
           WinRow1 = W1 And LineCount = 4.ToString Or _
           WinRow1 = W1 And LineCount = 5.ToString Or _
           WinRow1 = W1 And LineCount = 6.ToString Then

            Timer4.Enabled = False
            PictureBox3.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox9.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer5.Enabled = True
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (2) * My.Settings.BetAmount
            Label4.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
            PictureBox20.Visible = True
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        ''Win Line 2
        Dim WinRow2 As String
        WinRow2 = (WOne + WTwo + WThree).ToString
        Dim W2 As String
        W2 = ("369")
        If WinRow2 = W2 And LineCount = 2.ToString Or _
           WinRow2 = W2 And LineCount = 3.ToString Or _
           WinRow2 = W2 And LineCount = 4.ToString Or _
           WinRow2 = W2 And LineCount = 5.ToString Or _
           WinRow2 = W2 And LineCount = 6.ToString Then

            Timer4.Enabled = False
            PictureBox4.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox8.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (2) * My.Settings.BetAmount
            Label4.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
            PictureBox21.Visible = True
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        ''Win Line 3
        Dim WinRow3 As String
        WinRow3 = WOne.ToString + WTwo.ToString + WThree.ToString
        Dim W3 As String
        W3 = ("123")
        If WinRow3 = W3 And LineCount = 3.ToString Or _
           WinRow3 = W3 And LineCount = 4.ToString Or _
           WinRow3 = W3 And LineCount = 5.ToString Or _
           WinRow3 = W3 And LineCount = 6.ToString Then

            Timer4.Enabled = False
            PictureBox2.Image = My.Resources.symbol_7
            PictureBox6.Image = My.Resources.symbol_7
            PictureBox10.Image = My.Resources.symbol_7
            TextBox1.Text = ("GameWin Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
            My.Settings.UserAmount = My.Settings.UserAmount + (2) * My.Settings.BetAmount
            Label4.Text = My.Settings.UserAmount.ToString
            VALUE_Timer()
            PictureBox22.Visible = True
        Else
            'Timer4.Enabled = False
            TextBox1.Text = ("GameOver Numbers: " & WOne.ToString & WTwo.ToString & WThree.ToString)
            Timer4.Enabled = False
        End If

        Jack_Pot()
        Timer4.Enabled = False
        Label4.Text = My.Settings.UserAmount.ToString
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

#Region "JACKPOT"
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
#End Region

#Region "BETBUTTON"

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

        If My.Settings.BetAmount < (500) Then
            My.Settings.BetAmount = (My.Settings.BetAmount + (100))

        ElseIf My.Settings.BetAmount > (400) Then
            My.Settings.BetAmount = (100)
        End If
        Label2.Text = My.Settings.BetAmount.ToString
    End Sub
    Private Sub PictureBox17_H(sender As Object, e As EventArgs) Handles PictureBox17.MouseHover
        PictureBox17.Image = My.Resources.btn_bet_down
    End Sub
    Private Sub PictureBox17_L(sender As Object, e As EventArgs) Handles PictureBox17.MouseLeave
        PictureBox17.Image = My.Resources.btn_bet_default
    End Sub
#End Region


#Region "CLOSEBUTTON"
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Me.Close()
        GameLoginScreen.Load_User_Amount()
        GameLoginScreen.TextBox1.Text = ("")
        GameLoginScreen.Show()

    End Sub
#End Region

#Region "LineButton"
    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If My.Settings.LineAmount < (6) Then
            My.Settings.LineAmount = (My.Settings.LineAmount + (1))

        ElseIf My.Settings.LineAmount = (6) Then
            My.Settings.LineAmount = (1)
        End If
        Label1.Text = My.Settings.LineAmount.ToString
    End Sub



    Private Sub PIC19_H(sender As Object, e As EventArgs) Handles PictureBox19.MouseHover
        PictureBox19.Image = My.Resources.btn_lines_down
    End Sub
    Private Sub PIC19_L(sender As Object, e As EventArgs) Handles PictureBox19.MouseLeave
        PictureBox19.Image = My.Resources.btn_lines_default
    End Sub
#End Region



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If Me.Label1.Text = (1).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
        ElseIf Me.Label1.Text = (2).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
        ElseIf Me.Label1.Text = (3).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = False
            PictureBox24.Visible = False
            PictureBox25.Visible = False
        ElseIf Me.Label1.Text = (4).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = False
            PictureBox25.Visible = False
        ElseIf Me.Label1.Text = (5).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            PictureBox25.Visible = False
        ElseIf Me.Label1.Text = (6).ToString Then
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            PictureBox25.Visible = True
        End If
    End Sub

    Private Sub ClearLineIMage()
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        PictureBox25.Visible = False
    End Sub
End Class
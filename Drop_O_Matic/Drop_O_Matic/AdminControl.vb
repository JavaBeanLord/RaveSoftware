Public Class AdminControl

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent

        TextBox1.Text = My.Settings.HurryLogin.ToString
        TextBox2.Text = My.Settings.UserPassword.ToString
        AdminControl()
        TextBox3.Enabled = False
        TextBox3.Text = My.Settings.DataBasePath

        ' TabControl2.Enabled = False

        TrackBar1.Maximum = 7
        TextBox4.Text = My.Settings.WOnePayOut.ToString
        TrackBar1.Value = My.Settings.WOnePayOut
        TrackBar2.Maximum = 13
        TextBox5.Text = My.Settings.WTwoPayOut.ToString
        TrackBar2.Value = My.Settings.WTwoPayOut
        TrackBar3.Maximum = 19
        TextBox6.Text = My.Settings.WThreePayOut.ToString
        TrackBar3.Value = My.Settings.WThreePayOut
        TrackBar4.Maximum = 25
        TextBox7.Text = My.Settings.WFourPayOut.ToString
        TrackBar4.Value = My.Settings.WFourPayOut
        TrackBar5.Maximum = 31
        TextBox8.Text = My.Settings.WFivePayOut.ToString
        TrackBar5.Value = My.Settings.WFivePayOut

        SmallJackPotTrack.Maximum = 999
        SmallJackPotTrack.Value = My.Settings.SmallJackPot
        SmallJackPotChance.Text = My.Settings.SmallJackPot.ToString


        ToolTip1.SetToolTip(Me.PictureBox1, "Refreash DataBase " & vbNewLine & " File Path!")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        If My.Settings.HurryLogin.ToString = TextBox1.Text Then
            MessageBox.Show("Your Login Time Is Already Set To: " & My.Settings.HurryLogin.ToString & vbNewLine & " Please Modify The Time To Save")
        Else
            My.Settings.HurryLogin = TextBox1.Text
            TextBox1.Text = My.Settings.HurryLogin.ToString
            Login.LoginNow.Interval = TextBox1.Text
            MessageBox.Show("Saved Setting..." & vbNewLine & "Login Time Now " & TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You Can Only Insert Numbers!")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Turn Login Timer Off"
            My.Settings.HurryLoginTimer = True
        Else
            CheckBox1.Text = "Turn Login Timer On"
            My.Settings.HurryLoginTimer = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = My.Settings.UserPassword Then
            MessageBox.Show("Your Login Password is Already Set To: " & My.Settings.UserPassword & vbNewLine & " Please Modify Password To Save Changes")
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Please Type A Password")
        Else
            My.Settings.UserPassword = TextBox2.Text
            MessageBox.Show("Your New Password is:" & TextBox2.Text)
        End If
    End Sub

    Private Sub Form3_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainShow.Focus()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Settings.SavePassword = True

        Else
            My.Settings.SavePassword = False

        End If
    End Sub

    Public Sub AdminControl()
        If My.Settings.SavePassword = True Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        If My.Settings.HurryLoginTimer = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False

        End If


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox3.Text = My.Settings.DataBasePath

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBox4.Text = (TrackBar1.Value.ToString)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.WOnePayOut = TrackBar1.Value
        My.Settings.WTwoPayOut = TrackBar2.Value
        My.Settings.WThreePayOut = TrackBar3.Value

        TrackBar1.Maximum = 7
        TextBox4.Text = My.Settings.WOnePayOut.ToString
        TrackBar1.Value = My.Settings.WOnePayOut
        TrackBar2.Maximum = 13
        TextBox5.Text = My.Settings.WTwoPayOut.ToString
        TrackBar2.Value = My.Settings.WTwoPayOut
        TrackBar3.Maximum = 19
        TextBox6.Text = My.Settings.WThreePayOut.ToString
        TrackBar3.Value = My.Settings.WThreePayOut
        TrackBar4.Maximum = 25
        TextBox7.Text = My.Settings.WFourPayOut.ToString
        TrackBar4.Value = My.Settings.WFourPayOut
        TrackBar5.Maximum = 31
        TextBox8.Text = My.Settings.WFivePayOut.ToString
        TrackBar5.Value = My.Settings.WFivePayOut

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        TextBox5.Text = TrackBar2.Value.ToString
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        TextBox6.Text = TrackBar3.Value.ToString
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        TrackBar1.Value = My.Settings.WOnePayOut
        TrackBar2.Value = My.Settings.WTwoPayOut
        TrackBar3.Value = My.Settings.WThreePayOut

        TextBox4.Text = (My.Settings.WOnePayOut.ToString)
        TextBox5.Text = (My.Settings.WTwoPayOut.ToString)
        TextBox6.Text = (My.Settings.WThreePayOut.ToString)

        MessageBox.Show("Settings Cleared & Not Saved" & vbNewLine & "Thank You!")
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        TextBox7.Text = TrackBar4.Value.ToString

    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        TextBox8.Text = TrackBar5.Value.ToString

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.SmallJackPot = SmallJackPotTrack.Value
        MessageBox.Show("Small JackPot Chance Now: " & SmallJackPotTrack.Value.ToString)
    End Sub

    Private Sub SmallJackPotTrack_Scroll(sender As Object, e As EventArgs) Handles SmallJackPotTrack.Scroll
        SmallJackPotChance.Text = SmallJackPotTrack.Value.ToString

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Load_Small_JackPot_Numbers()
    End Sub

    Private Sub Load_Small_JackPot_Numbers()
        Dim Builder As New OleDb.OleDbConnectionStringBuilder With
           {
               .Provider = "Microsoft.ACE.OLEDB.12.0",
               .DataSource = IO.Path.Combine(My.Settings.DataBasePath)
           }

        Dim Names As New List(Of String)

        Using cn As New OleDb.OleDbConnection With
                {
                    .ConnectionString = Builder.ConnectionString
                }

            Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT SmallJackPot FROM JackPot WHERE ID = 1"


                cn.Open()

                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader

                If Reader.HasRows Then
                    While Reader.Read
                        Try
                            'Names.Add(Reader.GetString(0))
                            TextBox9.Text = (Reader.GetInt32(0).ToString)
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                        End Try
                    End While
                End If

                Reader.Close()

                Return

            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SmallJackPotTrack.Value = 999
        SmallJackPotChance.Text = SmallJackPotTrack.Value.ToString
        My.Settings.SmallJackPot = (999)
        MessageBox.Show("All Settings Have Been Reset!" & vbNewLine & " Thanks for Playing Fair!")
    End Sub
End Class
Public Class AdminLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = ("Games") Then
            If TextBox1.Text = Nothing Then
                MessageBox.Show("Please Type A Password")

            ElseIf TextBox1.Text = My.Settings.FullControlAdmin Then
                Games.Show()
                TextBox1.Text = ("")
                Me.Hide()
            Else
                MessageBox.Show("Seems Your Password is Wrong!")
            End If

        End If

        If ComboBox1.Text = ("POS") Then
            If TextBox1.Text = Nothing Then
                MessageBox.Show("Please Type A Password")

            ElseIf TextBox1.Text = My.Settings.FullControlAdmin Then
                POS.Show()
                POS.MdiParent = MainShow

                TextBox1.Text = ("")
                Me.Hide()
            Else
                MessageBox.Show("Seems Your Password is Wrong!")
            End If
        End If

        If ComboBox1.Text = ("JackPot") Then
            If TextBox1.Text = Nothing Then
                MessageBox.Show("Please Type A Password")

            ElseIf TextBox1.Text = My.Settings.FullControlAdmin Then
                JackPot.Show()
                TextBox1.Text = ("")
                Me.Hide()
            Else
                MessageBox.Show("Seems Your Password is Wrong!")
            End If
        End If

        If ComboBox1.Text = ("DataBase") Then
            If TextBox1.Text = Nothing Then
                MessageBox.Show("Please Type A Password")

            ElseIf TextBox1.Text = My.Settings.FullControlAdmin Then

                TextBox1.Text = ("")
                Me.Hide()
                MainShow.OpenFileDialog1.Title = ("DataBase Loader")
                MainShow.OpenFileDialog1.FileName = ("")
                MainShow.OpenFileDialog1.Filter = "DataBase Files (*.mdb)|*.mdb"
                MainShow.OpenFileDialog1.ShowDialog()
                'Just a Test
                ' MainShow.TextBox1.Text = (MainShow.OpenFileDialog1.FileName)
                My.Settings.DataBasePath = MainShow.OpenFileDialog1.FileName
                AdminControl.TextBox3.Text = MainShow.OpenFileDialog1.FileName



            Else
                MessageBox.Show("Seems Your Password is Wrong!")
            End If
        End If





       

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = ("Games")

        ComboBox1.Items.Add("Games")
        ComboBox1.Items.Add("POS")
        ComboBox1.Items.Add("JackPot")

    End Sub
End Class
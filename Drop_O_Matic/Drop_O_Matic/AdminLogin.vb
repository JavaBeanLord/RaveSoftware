Public Class AdminLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = ("Games") Then
            If TextBox1.Text = Nothing Then
                MessageBox.Show("Please Type A Password")

            ElseIf TextBox1.Text = My.Settings.FullControlAdmin Then
                Beta.Show()
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
                TextBox1.Text = ("")
                Me.Hide()
            Else
                MessageBox.Show("Seems Your Password is Wrong!")
            End If
        End If






       

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = ("Games")

        ComboBox1.Items.Add("Games")
        ComboBox1.Items.Add("POS")

    End Sub
End Class
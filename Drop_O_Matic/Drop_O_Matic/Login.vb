Public Class Login



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ("Admin User")
        TextBox1.Enabled = False
        ProgressBar1.Value = 100
        LoginNow.Interval = My.Settings.HurryLogin
        LoginNow.Enabled = True
        AdminControlNow()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' Shortcut for testing DELETE
        ''Delete
        TextBox2.Text = ("password")
        AdminLogin.Show()
        AdminLogin.ComboBox1.Text = ("DataBase")
        AdminLogin.ComboBox1.Items.Add("DataBase")
        AdminLogin.TextBox1.Text = ("zonecomputers")
        AdminLogin.Button1.PerformClick()
        ''Delete
        If TextBox2.Text = Nothing Then
            MessageBox.Show("Please Type A PassWord!")
        ElseIf TextBox2.Text = (My.Settings.UserPassword) Then
            MainShow.Show()
            TextBox2.Text = ("")
            Me.Hide()
            LoginNow.Enabled = False

        Else
            MessageBox.Show("Seems Your PassWord Or UserName is Wrong!" & vbNewLine & " Please Try Again...")
            TextBox2.Text = ("")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles LoginNow.Tick
        If ProgressBar1.Value < 1 Then
            LoginNow.Enabled = False
            MessageBox.Show("Seems you waited to long to Login..." & vbNewLine & " Please restart the app & Login.")
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value - 1
        End If
    End Sub


    Public Sub AdminControlNow()
        If My.Settings.SavePassword = True Then
            TextBox2.Text = My.Settings.UserPassword
        End If

        If My.Settings.SavePassword = True Then
            AdminControl.CheckBox2.Checked = True
        Else
            AdminControl.CheckBox2.Checked = False
        End If

        If My.Settings.HurryLoginTimer = False Then
            ProgressBar1.Visible = False
            LoginNow.Enabled = False
        End If

        If My.Settings.HurryLoginTimer = True Then
            AdminControl.CheckBox1.Checked = True
        Else
            AdminControl.CheckBox1.Checked = False
        End If



    End Sub

End Class

Public Class Login


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ModToPlay()
        Me.Hide()
        MainShow.Show()

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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.PerformClick()
        Me.Hide()
    End Sub



End Class

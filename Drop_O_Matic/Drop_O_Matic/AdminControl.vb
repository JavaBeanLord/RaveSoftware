Public Class AdminControl

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.HurryLogin.ToString
        TextBox2.Text = My.Settings.UserPassword.ToString
        AdminControl()
        TextBox3.Enabled = False
        TextBox3.Text = My.Settings.DataBasePath


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.HurryLogin = TextBox1.Text Then
            MessageBox.Show("Your Login Time Is Already Set To: " & My.Settings.HurryLogin.ToString & vbNewLine & " Please Modify The Time To Save")
        Else
            My.Settings.HurryLogin = TextBox1.Text
            TextBox1.Text = My.Settings.HurryLogin
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
End Class
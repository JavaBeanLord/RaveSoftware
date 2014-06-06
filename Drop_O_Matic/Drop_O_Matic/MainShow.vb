Public Class MainShow

    Private Sub AdminControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminControlToolStripMenuItem.Click
        AdminControl.Show()
        AdminControl.MdiParent = Me






    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ProgressBar1.Value = 100
        NEWS()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None



    End Sub

    Private Sub Form2_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        ReloadForm1()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Public Sub ReloadForm1()
        Login.Show()
        Login.LoginNow.Enabled = True
        Login.TextBox1.Text = ("Admin User")
        Login.TextBox1.Enabled = False
        Login.ProgressBar1.Value = 100
        Login.LoginNow.Interval = My.Settings.HurryLogin
        Login.LoginNow.Enabled = True
        Login.ProgressBar1.Visible = True
        Login.AdminControlNow()
    End Sub

    Private Sub BetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BetaToolStripMenuItem.Click
        AdminLogin.Show()
        AdminLogin.ComboBox1.Text = ("Games")
        ' Game2.Show()
        ' Game2.MdiParent = Me

        GameLoginScreen.Show()
        GameLoginScreen.MdiParent = Me

    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        AdminLogin.Show()
        AdminLogin.MdiParent = Me
        AdminLogin.ComboBox1.Text = ("POS")
        AdminLogin.TextBox1.Text = ("zonecomputers")
        AdminLogin.Button1.PerformClick()


    End Sub

    Private Sub RemoteSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteSupportToolStripMenuItem.Click
        Process.Start("chrome.exe", "zonecomputers.bomgar.com")
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        AboutMe.Show()

    End Sub

    Private Sub JackPotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JackPotToolStripMenuItem.Click
        AdminLogin.Show()
        AdminLogin.ComboBox1.Text = ("JackPot")

    End Sub

    Private Sub TestSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestSoftwareToolStripMenuItem.Click
        TestForm.Show()

    End Sub

    Private Sub DataBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBaseToolStripMenuItem.Click
        AdminLogin.Show()
        AdminLogin.ComboBox1.Text = ("DataBase")
        AdminLogin.ComboBox1.Items.Add("DataBase")
        AdminLogin.TextBox1.Text = ("zonecomputers")
        AdminLogin.Button1.PerformClick()
    End Sub

    Private Sub NEWS()
        Try
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
                    cmd.CommandText = "SELECT News FROM News_Tb WHERE ID = 1"

                    cn.Open()

                    Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                    If Reader.HasRows Then
                        While Reader.Read
                            Try

                                TestForm.TextBox1.Text = (Reader.GetString(0).ToString)
                            Catch ex As Exception
                                TestForm.TextBox1.Text = (ex.ToString)
                            End Try
                        End While
                    End If

                    Reader.Close()

                    Return

                End Using
            End Using
        Catch ex As Exception
            TestForm.TextBox1.Text = ("Big DataBase Problem!")
        End Try

    End Sub


    Private Sub WebOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebOnlyToolStripMenuItem.Click
        WebOnly.Show()
        WebOnly.MdiParent = Me
    End Sub
End Class
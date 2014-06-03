﻿Public Class MainShow

    Private Sub AdminControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminControlToolStripMenuItem.Click
        AdminControl.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ProgressBar1.Value = 100
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


    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        AdminLogin.Show()

    End Sub

    Private Sub RemoteSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteSupportToolStripMenuItem.Click
        Process.Start("chrome.exe", "zonecomputers.bomgar.com")
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        AboutMe.Show()

    End Sub
End Class
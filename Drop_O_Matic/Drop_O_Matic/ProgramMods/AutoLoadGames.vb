Module AutoLoadGames
    Public Sub ModToPlay()
        MainShow.Show()
        GameLoginScreen.MdiParent = MainShow
        GameLoginScreen.StartPosition = FormStartPosition.CenterParent
        GameLoginScreen.StartPosition = FormStartPosition.CenterScreen
        GameLoginScreen.Show()
        GameLoginScreen.Focus()
    End Sub

End Module

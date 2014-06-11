Public Class Games


    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolTip1.SetToolTip(Me.PictureBox1, "The Best Game in The Wild West!")




        ToolTip1.SetToolTip(Me.PictureBox8, "Next Page")
        ToolTip1.SetToolTip(Me.PictureBox7, "Back Page")
        Me.MdiParent = MainShow
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
    Private Sub Games_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainShow.Show()
        GameLoginScreen.Show()
        GameLoginScreen.TextBox1.Text = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
  
        Game2.MdiParent = MainShow
        Game2.StartPosition = FormStartPosition.CenterParent
        Game2.StartPosition = FormStartPosition.CenterScreen
        Game2.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Game3.MdiParent = MainShow
        Game3.StartPosition = FormStartPosition.CenterParent
        Game3.StartPosition = FormStartPosition.CenterScreen
        Game3.Show()

    End Sub
End Class
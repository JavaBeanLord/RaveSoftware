﻿Public Class Games


    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainShow.Hide()
        ToolTip1.SetToolTip(Me.PictureBox1, "The Best Game in The Wild West!")




        ToolTip1.SetToolTip(Me.PictureBox8, "Next Page")
        ToolTip1.SetToolTip(Me.PictureBox7, "Back Page")
    End Sub
    Private Sub Games_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainShow.Show()
    End Sub

End Class
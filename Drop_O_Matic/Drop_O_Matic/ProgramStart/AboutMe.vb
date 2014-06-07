Public Class AboutMe

    Private Sub AboutMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = ("I am Fast @ Solving Problems For The Human" & vbNewLine & " & Love to show off my ultra problem solving" &
                             vbNewLine & "Skillz That You Could Only Dream of doing.")
    End Sub


    Private Sub AboutMe_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainShow.Focus()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
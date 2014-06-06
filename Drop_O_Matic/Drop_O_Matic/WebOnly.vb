Public Class WebOnly

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = (WebBrowser1.Url.ToString)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.MouseClick
        TextBox1.SelectAll()

    End Sub

    Private Sub WebOnly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ("Google.com")
        WebBrowser1.Navigate("google.com")
    End Sub
End Class
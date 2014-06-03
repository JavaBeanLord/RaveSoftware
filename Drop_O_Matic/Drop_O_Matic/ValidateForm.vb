Public Class ValidateForm

    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub ValidateYes_Click(sender As Object, e As EventArgs) Handles ValidateYes.Click
        Me.Hide()
        MessageBox.Show("Accepted")
        POS.AddAmount.Text = ("")
        POS.CustomerName.Text = ("")
        POS.CustomerNumber.Text = ("")
        Me.Close()

    End Sub

    Private Sub ValidateNo_Click(sender As Object, e As EventArgs) Handles ValidateNo.Click
        Me.Hide()
        POS.Show()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
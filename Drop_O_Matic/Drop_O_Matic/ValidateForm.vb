Public Class ValidateForm

    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Enabled = False
        TextBox4.ReadOnly = True
        TextBox4.Text = (POS.EmployeeName.Text & " Are you sure you want to " &
                             vbNewLine & "apply credit to")
        TextBox1.Text = POS.CustomerName.Text()
        TextBox2.Text = POS.CustomerNumber.Text()
        TextBox3.Text = POS.AddAmount.Text()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Enabled = False
        TextBox2.ReadOnly = True

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Enabled = False
        TextBox3.ReadOnly = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Enabled=false
        TextBox1.ReadOnly = True

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
End Class
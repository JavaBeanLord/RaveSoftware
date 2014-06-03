Public Class ValidateForm

    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = (POS.EmployeeName.Text & " Are you sure you want to " &
                             vbNewLine & "apply credit to")
        TextBox1.Text = POS.CustomerName.Text()
        TextBox2.Text = POS.CustomerNumber.Text()
        TextBox3.Text = POS.AddAmount.Text()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.ReadOnly = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
Public Class POS

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OneDollar As Double = (1.0)
        Dim DollarString As String
        DollarString = FormatCurrency(OneDollar, , )
        AddAmount.Text = DollarString



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FiveDollar As Double = (5.0)
        Dim FiveDollarString As String
        FiveDollarString = FormatCurrency(FiveDollar, , )
        AddAmount.Text = FiveDollarString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TenDollar As Double = (10.0)
        Dim TenDollarString As String
        TenDollarString = FormatCurrency(TenDollar, , )
        AddAmount.Text = TenDollarString


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TwentyDollar As Double = (20.0)
        Dim TwentyDollarString As String
        TwentyDollarString = FormatCurrency(TwentyDollar, , )
        AddAmount.Text = TwentyDollarString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FiftyDollar As Double = (50.0)
        Dim FiftyDollarString As String
        FiftyDollarString = FormatCurrency(FiftyDollar, , )
        AddAmount.Text = FiftyDollarString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim HundredDollar As Double = (100.0)
        Dim HundredDollarString As String
        HundredDollarString = FormatCurrency(HundredDollar, , )
        AddAmount.Text = HundredDollarString
    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddAmount.Enabled = False
        AddAmount.ReadOnly = True
        ''EmployeeName
        EmployeeName.Text = ("Dom")
        ''Test CustomerName
        CustomerName.Text = ("Justin")
        ''Test Customer Id
        CustomerNumber.Text = ("123456789")

        ''Hide MainForm 
        MainShow.Hide()
        Me.Focus()

    End Sub

    Public Sub POS_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainShow.Show()
        MainShow.Focus()

        'It will Hide The POS Form
        Me.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles CustomerNumber.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerName.TextChanged


    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If AddAmount.Text = Nothing Then
            MessageBox.Show("Please Apply Credit")
        Else
            ValidateForm.Show()
        End If





    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ClearAddAmount_Click(sender As Object, e As EventArgs) Handles ClearAddAmount.Click
        AddAmount.Text = ("")
    End Sub

    Private Sub EmployeeName_TextChanged(sender As Object, e As EventArgs) Handles EmployeeName.TextChanged
        EmployeeName.Text = Login.TextBox1.Text()

    End Sub
End Class
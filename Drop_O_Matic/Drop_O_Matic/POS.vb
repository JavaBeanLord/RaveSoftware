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
        Entry.Text = ("100")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FiveDollar As Double = (5.0)
        Dim FiveDollarString As String
        FiveDollarString = FormatCurrency(FiveDollar, , )
        AddAmount.Text = FiveDollarString
        Entry.Text = ("500")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TenDollar As Double = (10.0)
        Dim TenDollarString As String
        TenDollarString = FormatCurrency(TenDollar, , )
        AddAmount.Text = TenDollarString
        Entry.Text = ("1000")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TwentyDollar As Double = (20.0)
        Dim TwentyDollarString As String
        TwentyDollarString = FormatCurrency(TwentyDollar, , )
        AddAmount.Text = TwentyDollarString
        Entry.Text = ("2000")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FiftyDollar As Double = (50.0)
        Dim FiftyDollarString As String
        FiftyDollarString = FormatCurrency(FiftyDollar, , )
        AddAmount.Text = FiftyDollarString
        Entry.Text = ("5000")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim HundredDollar As Double = (100.0)
        Dim HundredDollarString As String
        HundredDollarString = FormatCurrency(HundredDollar, , )
        AddAmount.Text = HundredDollarString
        Entry.Text = ("10000")
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
        ValidateForm.Label5.Text = ("Entries:" & Me.Entry.Text())
        ValidateForm.Label1.Text = (Me.EmployeeName.Text() & ",")
        ValidateForm.Label2.Text = ("Apply Credits to ")
        ValidateForm.Label3.Text = (Me.CustomerName.Text()) & "                   " & Me.AddAmount.Text.ToString
        ValidateForm.Label4.Text = ("ID:" & Me.CustomerNumber.Text())
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
        '' EmployeeName.Text = Login.TextBox1.Text()
        EmployeeName.Text = ("Dom")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles CashOut.Click
        If Me.CustomerNumber.Text = Nothing Then
            MessageBox.Show("Please Insert Customer Number")
        Else
            ''Search data base for number & retrieve data to display on "Cash Out" Form
            CashOutForm.Show()
            CashOutForm.Label1.Text = (EmployeeName.Text())
            CashOutForm.Label2.Text = (CustomerName.Text())
            CashOutForm.Label3.Text = ("ID: " & CustomerNumber.Text())

            CashOutForm.Label4.Text = ("Remaining Entries: ")
            '' CashOutForm.Label5.Text=()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Entry_TextChanged(sender As Object, e As EventArgs) Handles Entry.TextChanged
        Entry.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class
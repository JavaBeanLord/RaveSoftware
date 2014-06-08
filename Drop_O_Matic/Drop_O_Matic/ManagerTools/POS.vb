Public Class POS
    Dim ServerConnect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Dim ServerCommand As New OleDb.OleDbCommand()
#Region "SERVERCONNECT"
    Dim Builder As New OleDb.OleDbConnectionStringBuilder With
       {
           .Provider = "Microsoft.ACE.OLEDB.12.0",
           .DataSource = IO.Path.Combine(My.Settings.DataBasePath)
       }
    Dim Names As New List(Of String)
#End Region

    Private Sub CusNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CustomerNumber.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You Can Only Insert Numbers!")
        End If

    End Sub

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
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen

        CashOut.Text = ("Cash" & vbNewLine & "Out")
        CashOut.TextAlign = ContentAlignment.MiddleCenter

        AddAmount.Enabled = False
        AddAmount.ReadOnly = True
        ''EmployeeName
        EmployeeName.Text = ("Dom")
        ''Test CustomerName

        ''Test Customer Id


        ''Hide MainForm 
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
        If CustomerName.Text = Nothing Then
            MessageBox.Show("Please Input Customer Name")
        ElseIf CustomerNumber.Text = Nothing Then
            MessageBox.Show("Please Input Customer ID Number")
        ElseIf AddAmount.Text = Nothing Then
            MessageBox.Show("Please Apply Customer Credit")
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
            TESTCASHOUT()
        End If
    End Sub

    Public Sub TESTCASHOUT()
        Using cn As New OleDb.OleDbConnection With
               {
                   .ConnectionString = Builder.ConnectionString
               }
            Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT CAmount FROM Table1 WHERE ID = " & CustomerNumber.Text & ";"
                cn.Open()
                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                If Reader.HasRows Then
                    CashOurCommand()
                    CashOutForm.Show()
                    CashOutForm.Label1.Text = (EmployeeName.Text())
                    CashOutForm.Label2.Text = ("Cash Out For: " & CustomerName.Text())
                    CashOutForm.Label3.Text = ("ID: " & CustomerNumber.Text())
                    '' CashOutForm.Label5.Text=()
                Else
                    MessageBox.Show("Seems Party ID Is not Correct! " & vbNewLine & " Please Correct ID & Try Again!")
                End If
                Reader.Close()
            End Using
        End Using
    End Sub

    Public Sub CashOurCommand()
        Using cn As New OleDb.OleDbConnection With
                {
                    .ConnectionString = Builder.ConnectionString
                }
            Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT CAmount FROM Table1 WHERE ID = " & CustomerNumber.Text & ";"
                cn.Open()
                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                If Reader.HasRows Then
                    While Reader.Read
                        Try
                            'Names.Add(Reader.GetString(0))
                            Dim makers As Double
                            Dim mark As Integer
                            Dim COutNow As Double
                            Dim MilkCow As String
                            makers = 0.01
                            mark = (Reader.GetInt32(0))
                            CashTrash = (Reader.GetInt32(0))
                            COutNow = mark * makers
                            MilkCow = FormatCurrency(COutNow, , )
                            CashOutForm.Label4.Text = ("Cash Out Amount: " & MilkCow & " Dollars")
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                        End Try
                    End While
                End If
                Reader.Close()
                Return
            End Using
        End Using
    End Sub

    Public CashTrash As Integer


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Entry_TextChanged(sender As Object, e As EventArgs) Handles Entry.TextChanged
        Entry.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If CustomerNumber.Text = Nothing Then
            MessageBox.Show("Please Input Customer Number!")
            CustomerName.Text = Nothing

        Else
            CustomerName.Text = Nothing

            FindParty()
        End If



    End Sub

    Public Sub FindParty()
        CashOurCommand()

        Dim convertmonies As Double
        convertmonies = 0.01
        Dim CutMonies As Double
        CutMonies = CashTrash * convertmonies
        Dim StringMonies As String
        StringMonies = FormatCurrency(CutMonies, , )

        Dim Builder As New OleDb.OleDbConnectionStringBuilder With
           {
               .Provider = "Microsoft.ACE.OLEDB.12.0",
               .DataSource = IO.Path.Combine(My.Settings.DataBasePath)
           }
        Dim Names As New List(Of String)

        Using cn As New OleDb.OleDbConnection With
                {
                    .ConnectionString = Builder.ConnectionString
                }
            Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT CName FROM Table1 WHERE ID = " & CustomerNumber.Text & ";"
                cn.Open()
                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                If Reader.HasRows Then
                    While Reader.Read
                        Try
                            'Names.Add(Reader.GetString(0))
                            CustomerName.Text = (Reader.GetString(0))
                            MessageBox.Show("The Party Has: " & StringMonies & " On Account")
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                        End Try
                    End While
                Else
                    MessageBox.Show("The Party Does Not Have An Account" & vbNewLine & "Please Register Party")
                End If
                Reader.Close()
                Return
            End Using
        End Using
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Clear_POS()

    End Sub
End Class
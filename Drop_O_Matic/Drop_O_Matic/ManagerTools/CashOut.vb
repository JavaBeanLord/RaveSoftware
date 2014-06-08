Imports System.Data.OleDb
Public Class CashOutForm
    Dim ServerConnect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Dim ServerCommand As New OleDb.OleDbCommand()
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Print Reciept

        ''Deduct amount from database
        TrueCashOut()
        ''Enable POS
        POS.Enabled = True
        ''CLose CashOut FOrm
        Clear_POS()

        Me.Close()

    End Sub

    Private Sub TrueCashOut()
        ServerConnect.Close()
        ServerConnect.Open()
        Dim ServerUpdate As String
        ServerUpdate = ("UPDATE Table1 SET [CAmount] = '" & POS.CashTrash - POS.CashTrash & "' WHERE ID = " & POS.CustomerNumber.Text & ";")
        ServerCommand = New OleDbCommand(ServerUpdate, ServerConnect)
        Try
            ServerCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        ServerConnect.Close()
    End Sub

    Private Sub CashOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = (MainShow)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen
        POS.Enabled = False

    End Sub

    Private Sub CashOutForm_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        POS.Enabled = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ServerConnect.Close()

        Me.Close()
    End Sub
End Class
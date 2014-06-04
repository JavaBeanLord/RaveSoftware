Imports System.Data.OleDb
Public Class ValidateForm

    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ValidateYes_Click(sender As Object, e As EventArgs) Handles ValidateYes.Click

        Try
            'Dim ServerConnet As DataBase Connect
            Dim ServerConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)

            'Dim ServerCommant As DataBase Connect
            Dim ServerCommand As New OleDbCommand

            'Open DataBase
            ServerConnect.Open()
            ServerCommand.Connection = ServerConnect

            'Insert Data in DataBase
            ServerCommand.CommandText = "INSERT INTO Table1(ID, CName, CAmount) " & _
            " VALUES(" & POS.CustomerNumber.Text & ",'" & POS.CustomerName.Text & "','" & _
             POS.Entry.Text & "')"
            ''End of Insert Data in DataBase

            ServerCommand.ExecuteNonQuery()
            ServerConnect.Close()
            'Show MessageBox
            MessageBox.Show("Accepted")
        Catch ex As Exception
            ''Show DataBase Error in MessageBox
            MessageBox.Show(ex.Message)
        End Try

        'Hide ValidateForm
        Me.Hide()
        'Clear POS Cluster
        POS.Entry.Text = ("")
        POS.AddAmount.Text = ("")
        POS.CustomerName.Text = ("")
        POS.CustomerNumber.Text = ("")
        'Close Validate Form
        Me.Close()
    End Sub

    Private Sub ValidateNo_Click(sender As Object, e As EventArgs) Handles ValidateNo.Click
        Me.Hide()
        POS.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
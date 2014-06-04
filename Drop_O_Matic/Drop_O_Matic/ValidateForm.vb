Imports System.Data.OleDb
Public Class ValidateForm

    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub ValidateYes_Click(sender As Object, e As EventArgs) Handles ValidateYes.Click
     
        'Dim ServerConnet As DataBase Connect
        Dim ServerConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
        'Dim ServerCommant As DataBase Connect
        Dim ServerCommand As New OleDbCommand





        'Hide ValidateForm
        Me.Hide()
        'Show MessageBox
        MessageBox.Show("Accepted")

        'Clear POS Cluster
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
End Class
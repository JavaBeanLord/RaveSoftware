Imports System.Data.OleDb
Public Class TestForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin1\Documents\GitHub\RaveSoftware\Drop_O_Matic\Drop_O_Matic\DataBase\DB.mdb;")
    Dim cmd As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            con.Open()
            MessageBox.Show("DataBase Found & Open")
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Close()
            MessageBox.Show("DataBase Found & Closed")
        Catch ex As Exception
            MessageBox.Show("No DataBase Found!")

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Table1_ As String = "Table1"
        Dim query As String = "SELECT * FROM " & Table1_
        Dim MDBConnString_ As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\WIN-ISS7E12NGDJ\Users\Administrator.WIN-ISS7E12NGDJ\Documents\Game\DataBase\DB.mdb;")
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
        cnn.Open()
        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table1_)
        cnn.Close()
        Dim t1 As DataTable = ds.Tables(Table1_)
        Dim row As DataRow
        Dim Item(2) As String
        For Each row In t1.Rows
            Item(0) = row(0)
            Item(0) = row(1)
            Dim NextListItem As New ListViewItem(Item)
            TextBox2.Text = (NextListItem).ToString
        Next
    End Sub
End Class
Imports System.Data.OleDb
Public Class TestForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\WIN-ISS7E12NGDJ\Users\Administrator.WIN-ISS7E12NGDJ\Documents\Game\DataBase\DB.mdb;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            con.Open()
            MessageBox.Show("DataBase Found & Open")
        Catch ex As Exception
            MessageBox.Show("No DataBase Found!")

        End Try

    End Sub
End Class
Imports System.Data.OleDb
Public Class JackPot
    Dim ServerConnect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Dim ServerCommand As New OleDb.OleDbCommand()

    Private Sub JackPot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim RandomSmall = New Random()
        Dim SmallJackPot = RandomSmall.Next(999)

        TextBox3.Text = SmallJackPot.ToString

        Dim IDNumber As String
        IDNumber = ("1")
        ServerConnect.Close()
        ServerConnect.Open()

        Dim ServerUpdate As String
        ServerUpdate = "UPDATE JackPot SET [SmallJackPot] = '" & SmallJackPot & "' WHERE ID = " & IDNumber & ";"
        ServerCommand = New OleDbCommand(ServerUpdate, ServerConnect)
        Try

            ServerCommand.ExecuteNonQuery()
            Timer1.Enabled = False

        Catch ex As Exception
            MsgBox("Could not perform this task because " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

        ServerCommand = Nothing
        ServerConnect.Close()

    End Sub

   

End Class
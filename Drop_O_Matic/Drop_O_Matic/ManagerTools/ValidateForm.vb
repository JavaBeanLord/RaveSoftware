Imports System.Data.OleDb
Public Class ValidateForm
#Region "SERVERCONNECTOVERLOAD"
    Dim ServerConnect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Dim ServerCommand As New OleDb.OleDbCommand()
#End Region
#Region "SERVER CONNECT"
    Dim Builder As New OleDb.OleDbConnectionStringBuilder With
   {
       .Provider = "Microsoft.ACE.OLEDB.12.0",
       .DataSource = IO.Path.Combine(My.Settings.DataBasePath)
   }
    Dim Names As New List(Of String)
#End Region


    Private Sub ValidateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainShow
        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen
        POS.Enabled = False
    End Sub
    Private Sub Val_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        POS.Enabled = True
    End Sub

    Private Sub ValidateNo_Click(sender As Object, e As EventArgs) Handles ValidateNo.Click
        Me.Close()
        Clear_POS()
    End Sub

    Private Sub ValidateYes_Click(sender As Object, e As EventArgs) Handles ValidateYes.Click
        POS.CashOurCommand()
        CASH_DATA()
    End Sub

    Public Sub CASH_DATA()
        Dim whawah As Double
        whawah = POS.Entry.Text

        Dim ServerUpdate As String
        ServerUpdate = "UPDATE Table1 SET [CAmount] = '" & POS.Entry.Text & "' WHERE ID = " & POS.CustomerNumber.Text & ";"
        Using cn As New OleDb.OleDbConnection With
               {
                   .ConnectionString = Builder.ConnectionString
               }
            Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT CAmount FROM Table1 WHERE ID = " & POS.CustomerNumber.Text & ";"
                cn.Open()
                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                If Reader.HasRows Then

                    Try
                        Dim result1 = MessageBox.Show("Are You Sure You Wish To Add " & POS.AddAmount.Text, "Raven Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If (result1 = Windows.Forms.DialogResult.Cancel) Then
                            Me.Close()
                        Else
                            Reader.Close()
                            cmd.CommandText = ("UPDATE Table1 SET [CAmount] = '" & whawah + POS.CashTrash & "' WHERE ID = " & POS.CustomerNumber.Text & ";")
                            cmd.ExecuteNonQuery()
                            Clear_POS()
                            Me.Close()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                Else
                    Dim result = MessageBox.Show("Building New Account" & vbNewLine & "Do We Have The Information Correct?" & vbNewLine & "Name: " & _
                    POS.CustomerName.Text & vbNewLine & "Add Amount: " & POS.AddAmount.Text & vbNewLine & "Customer ID: " & _
                    POS.CustomerNumber.Text, "Raven DataBuilder", MessageBoxButtons.YesNo)
                    If (result = DialogResult.No) Then
                        Me.Close()
                    Else
                        'news here
                        Build_Account_Data()
                        Me.Close()
                        Clear_POS()
                        MessageBox.Show("Account Build Complet")
                    End If

                    Reader.Close()
                End If
                Return
            End Using
        End Using
    End Sub

    Private Sub Build_Account_Data()
        Dim BuildAccount As String
        BuildAccount = "INSERT INTO Table1(ID, CName, CAmount) " & _
            " VALUES(" & POS.CustomerNumber.Text & ",'" & POS.CustomerName.Text & "','" & _
             POS.Entry.Text & "')"

        ServerConnect.Close()
        ServerConnect.Open()
        ServerCommand.Connection = ServerConnect
        ServerCommand.CommandText = (BuildAccount)
        ServerCommand.ExecuteNonQuery()
        ServerConnect.Close()



    End Sub

End Class
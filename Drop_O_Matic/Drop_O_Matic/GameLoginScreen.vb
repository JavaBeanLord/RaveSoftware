Imports System.Data.OleDb
Public Class GameLoginScreen
#Region "Connect String"
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
    Private Builder As New OleDb.OleDbConnectionStringBuilder With _
    { _
        .Provider = "Microsoft.ACE.OLEDB.12.0", _
        .DataSource = IO.Path.Combine(My.Settings.DataBasePath) _
    }
#End Region

    Private Sub Game_Login(serder As Object, e As EventArgs) Handles MyBase.Load
        MainShow.ControlBox = False
        MainShow.MainMenuStrip.Visible = False
        MainShow.FormBorderStyle = Windows.Forms.FormBorderStyle.None


        Me.StartPosition = FormStartPosition.CenterParent
        Me.StartPosition = FormStartPosition.CenterScreen


        TextBox1.Focus()



    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover


    End Sub
    Private Sub PictureBox1_Mouse_Leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ID_Login()

    End Sub


    Private Sub Sandy_Click()

        Dim Sandy As New Button

    End Sub

    Private Sub ID_Login()


        Try
            ''SmallJackPot PayOut
            Dim USER_ID_NUMBER As String
            USER_ID_NUMBER = TextBox1.Text

            Using cn As New OleDbConnection(Builder.ConnectionString)
                Using cmd As New OleDbCommand("SELECT CAmount FROM Table1 WHERE ID = ? ", cn)
                    cmd.Parameters.AddWithValue("ID", USER_ID_NUMBER)
                    Try
                        cn.Open()
                        Dim reader As OleDbDataReader = cmd.ExecuteReader
                        If Not reader.HasRows Then
                            ''false you lose jackPot
                            MessageBox.Show("Wrong!")
                        Else
                            Load_User_Amount()
                            Game2.Show()
                            Game2.MdiParent = MainShow

                            Me.Hide()

                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString & "DataBase Connect " & " Error")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Big Big Error!!")
        End Try
    End Sub

    Public Sub Load_User_Amount()
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
                cmd.CommandText = "SELECT CAmount FROM Table1 WHERE ID = " & TextBox1.Text & ";"


                cn.Open()

                Dim Reader As OleDb.OleDbDataReader = cmd.ExecuteReader

                If Reader.HasRows Then
                    While Reader.Read
                        Try
                            'Names.Add(Reader.GetString(0))
                            My.Settings.UserAmount = (Reader.GetInt32(0))
                            My.Settings.UserIDNumber = (TextBox1.Text)
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


End Class
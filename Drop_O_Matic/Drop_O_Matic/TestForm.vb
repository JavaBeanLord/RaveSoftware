Imports System.Data.OleDb
Public Class TestForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
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

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Table1_ As String = "Table1"
        Dim query As String = "SELECT * FROM " & Table1_
        Dim MDBConnString_ As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
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

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DataBasePath.ToString)
        Dim sqlCmd As New OleDb.OleDbCommand()

        con.Open()
        Dim sqlUpdate As String
        Dim sqlUpdatePass As DialogResult
        sqlUpdate = "UPDATE JackPot SET [SmallJackPot] = '" & TextBox3.Text & "' WHERE ID = " & TextBox4.Text & ";"
        sqlCmd = New OleDbCommand(sqlUpdate, con)
        Try
            sqlUpdatePass = MessageBox.Show("Are you sure to save this changes?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If sqlUpdatePass = vbYes Then
                sqlCmd.ExecuteNonQuery()
                MsgBox("Changes are now saved", MsgBoxStyle.Information, "New password has been set.")
                Me.Hide()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Could not perform this task because " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        sqlCmd = Nothing
        con.Close()
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        con.Open()

        Dim da As New OleDb.OleDbDataAdapter("SELECT ID as [ID], " & _
                                             "SmallJackPot as [Small JackPot],MidJackPot as [Mid JackPot],LargeJackPot as [Large JackPot]" & _
                                             "FROM JackPot ORDER BY ID", con)
                                           

        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.dgvData.DataSource = dt

        'close connection
        con.Close()

        Dim info As String







    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Try



            con.Open()

            cmd = New OleDbCommand("SELECT SmallJackPot FROM JackPot WHERE compname = '" & TextBox5.Text & "'", con)

            Dim oReader As OleDbDataReader
            oReader = cmd.ExecuteReader()

            If oReader.HasRows Then



                Do While oReader.Read
                    TextBox5.Text = oReader(1).ToString

                Loop





            Else

                MsgBox("add new contact.")

            End If


        Catch myException As Exception



            MsgBox("No Record Inserted" + myException.ToString())




        Finally

            con.Close()

        End Try


    End Sub
End Class
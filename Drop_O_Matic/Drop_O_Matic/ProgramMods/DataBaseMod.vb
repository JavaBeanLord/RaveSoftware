Module DataBaseMod

    Public Sub ServerConnect_Command()
        Dim Builder As New OleDb.OleDbConnectionStringBuilder With
     {
         .Provider = "Microsoft.ACE.OLEDB.12.0",
        .DataSource = IO.Path.Combine(My.Settings.DataBasePath)
     }
    End Sub


End Module

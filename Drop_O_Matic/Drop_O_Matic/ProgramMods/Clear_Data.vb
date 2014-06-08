Module Clear_Data

#Region "Clear POS FOrm"
    Public Sub Clear_POS()
        POS.CustomerNumber.Clear()
        POS.CustomerName.Clear()
        POS.AddAmount.Clear()
        POS.Entry.Clear()
    End Sub
#End Region

End Module

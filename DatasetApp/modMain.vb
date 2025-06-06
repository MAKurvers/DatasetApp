Module modMain
    Public ds As DataSet
    Const DUUR = 2000
    Sub Main()
        Dim splash As New SplashInfo

        splash.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(DUUR)
        splash.Close()

        ds = New DataSet
        Application.Run(New frmMain)
        ds = Nothing
    End Sub

    Sub AddColumn(ByRef myTable As DataTable, columnText As String, myType As String)
        Dim dc As New DataColumn(columnText)
        'colString.DataType = System.Type.GetType("System.String")
        dc.DataType = System.Type.GetType(myType)
        myTable.Columns.Add(dc)
    End Sub
End Module

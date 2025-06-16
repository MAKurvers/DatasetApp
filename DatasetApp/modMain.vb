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
    Sub AddRow(ByRef myTable As DataTable, numID As Long, ParamArray velden() As String)
        Dim myRow As DataRow
        Dim veldstrings() As String =
            {
                "Voornaam",
                "Tussenvoegsels",
                "Achternaam",
                "Adres",
                "Postcode",
                "Woonplaats",
                "Telefoon",
                "Email"
            }
        myRow = myTable.NewRow()
        myRow("ID") = numID
        For i = 0 To veldstrings.Length - 1
            myRow(veldstrings(i)) = velden(i)
        Next
        myTable.Rows.Add(myRow)
    End Sub
End Module

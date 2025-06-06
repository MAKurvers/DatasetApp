Public Class frmMain
    Const STRINGTYPE = "System.String"
    Const INT64TYPE = "System.Int64"
    Private ID As Long
    Private curRow As Long

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim myTable As DataTable
        Dim myRow As DataRow

        myTable = New DataTable("NAW")
        modMain.AddColumn(myTable, "ID", INT64TYPE)
        modMain.AddColumn(myTable, "Naam", STRINGTYPE)
        modMain.AddColumn(myTable, "Adres", STRINGTYPE)
        modMain.AddColumn(myTable, "Woonplaats", STRINGTYPE)

        myRow = myTable.NewRow()
        myRow("ID") = 1
        myRow("Naam") = "Janneman"
        myRow("Adres") = "Populierstraat 12"
        myRow("Woonplaats") = "Kanten"

        myTable.Rows.Add(myRow)

        myRow = myTable.NewRow()
        myRow("ID") = 2
        myRow("Naam") = "Kees Polleman"
        myRow("Adres") = "Nemingsstraat 122"
        myRow("Woonplaats") = "Limmen"

        myTable.Rows.Add(myRow)
        ds.Tables.Add(myTable)

        ID = 2
        curRow = 2
        tslblCount.Text = ds.Tables("NAW").Rows.Count
        tstxtRow.Text = curRow.ToString
        dgData.DataSource = ds.Tables("NAW")
        dgData.Refresh()
        EnableNav(True)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableNav(False)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub tsbtnFirst_Click(sender As Object, e As EventArgs) Handles tsbtnFirst.Click
        dgData.Rows(0).Selected = True
        curRow = 0
        tstxtRow.Text = (curRow + 1).ToString
    End Sub

    Private Sub tsbtnPrev_Click(sender As Object, e As EventArgs) Handles tsbtnPrev.Click
        curRow -= 1
        If curRow < 0 Then curRow = 0
        dgData.Rows(curRow).Selected = True
    End Sub

    Private Sub tsbtnNext_Click(sender As Object, e As EventArgs) Handles tsbtnNext.Click
        curRow += 1
        If curRow > dgData.Rows.Count - 2 Then curRow = dgData.Rows.Count - 2
        dgData.Rows(curRow).Selected = True
    End Sub

    Private Sub tsbtnLast_Click(sender As Object, e As EventArgs) Handles tsbtnLast.Click
        curRow = dgData.Rows.Count - 2
        dgData.Rows(curRow).Selected = True
    End Sub

    Private Sub EnableNav(enabled As Boolean)
        tsbtnFirst.Enabled = enabled
        tsbtnPrev.Enabled = enabled
        tsbtnNext.Enabled = enabled
        tsbtnLast.Enabled = enabled
        tstxtRow.Enabled = enabled
        tslblCount.Enabled = enabled
        tsbtnAdd.Enabled = enabled
        tsbtnEdit.Enabled = enabled
        tsbtnRemove.Enabled = enabled
    End Sub
End Class

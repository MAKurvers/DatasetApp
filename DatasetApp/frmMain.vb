Public Class frmMain
    Const STRINGTYPE = "System.String"
    Const INT64TYPE = "System.Int64"
    Private ID As Long  'Uniek
    'Private curID As Long 'ID van huidige rij
    Private curRow As Long  'Rij die geselecteerd is
    Private dtNAW As DataTable
    Private filename As String

    Private Sub btnTest_Click(sender As Object, e As EventArgs)

        'Dim myTable As DataTable
        'Dim myRow As DataRow

        'myTable = New DataTable("NAW")
        'modMain.AddColumn(myTable, "ID", INT64TYPE)
        'modMain.AddColumn(myTable, "Naam", STRINGTYPE)
        'modMain.AddColumn(myTable, "Adres", STRINGTYPE)
        'modMain.AddColumn(myTable, "Woonplaats", STRINGTYPE)

        'myRow = myTable.NewRow()
        'myRow("ID") = 1
        'myRow("Naam") = "Janneman"
        'myRow("Adres") = "Populierstraat 12"
        'myRow("Woonplaats") = "Kanten"

        'myTable.Rows.Add(myRow)

        'myRow = myTable.NewRow()
        'myRow("ID") = 2
        'myRow("Naam") = "Kees Polleman"
        'myRow("Adres") = "Nemingsstraat 122"
        'myRow("Woonplaats") = "Limmen"

        'myTable.Rows.Add(myRow)
        'ds.Tables.Add(myTable)

        'ID = 2
        'curRow = 2
        'tslblCount.Text = ds.Tables("NAW").Rows.Count
        'tstxtRow.Text = curRow.ToString
        'dgData.DataSource = ds.Tables("NAW")
        'dgData.Refresh()
        'EnableNav(True)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableNav(False)
        dtNAW = New DataTable("NAW")
        modMain.AddColumn(dtNAW, "ID", INT64TYPE)
        modMain.AddColumn(dtNAW, "Voornaam", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Tussenvoegsels", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Achternaam", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Adres", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Postcode", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Woonplaats", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Telefoon", STRINGTYPE)
        modMain.AddColumn(dtNAW, "Email", STRINGTYPE)
        dtNAW.Columns("ID").ReadOnly = True
        ds.Tables.Add(dtNAW)
        ID = 0
        curRow = -1

        EnableNav(True)
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
        tstxtRow.Text = curRow
    End Sub

    Private Sub tsbtnNext_Click(sender As Object, e As EventArgs) Handles tsbtnNext.Click
        curRow += 1
        If curRow > dgData.Rows.Count - 2 Then curRow = dgData.Rows.Count - 2
        dgData.Rows(curRow).Selected = True
        tstxtRow.Text = curRow
    End Sub

    Private Sub tsbtnLast_Click(sender As Object, e As EventArgs) Handles tsbtnLast.Click
        curRow = dgData.Rows.Count - 2
        dgData.Rows(curRow).Selected = True
        tstxtRow.Text = curRow
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

    Sub RefreshData()
        tslblCount.Text = ds.Tables("NAW").Rows.Count
        tstxtRow.Text = curRow.ToString
        dgData.DataSource = ds.Tables("NAW")
        dgData.Refresh()
    End Sub
    Sub ToonGegevens(row As Integer)
        Dim myRow As DataRow

        myRow = dtNAW.Rows(row)
        txtID.Text = myRow("ID").ToString
        txtVoornaam.Text = myRow("Voornaam")
        txtTVS.Text = myRow("Tussenvoegsels")
        txtAchternaam.Text = myRow("Achternaam")
        txtAdres.Text = myRow("Adres")
        txtPostcode.Text = myRow("Postcode")
        txtWPlaats.Text = myRow("Woonplaats")
        txtTel.Text = myRow("Telefoon")
        txtEmail.Text = myRow("Email")
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub gbData_Enter(sender As Object, e As EventArgs) Handles gbData.Enter

    End Sub

    Private Sub tsbtnAdd_Click(sender As Object, e As EventArgs) Handles tsbtnAdd.Click
        Dim gegevens() As String =
            {
                txtVoornaam.Text,
                txtTVS.Text,
                txtAchternaam.Text,
                txtAdres.Text,
                txtPostcode.Text,
                txtWPlaats.Text,
                txtTel.Text,
                txtEmail.Text
            }
        ID += 1
        curRow = dtNAW.Rows.Count - 1
        txtID.Text = ID.ToString
        modMain.AddRow(dtNAW, ID, gegevens)
        RefreshData()
    End Sub

    Private Sub dgData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellClick
        Dim row As Integer = e.RowIndex

        If Not dgData.Rows(e.RowIndex).IsNewRow Then
            ToonGegevens(row)
            curRow = row
            tstxtRow.Text = curRow
        End If
    End Sub

    Private Sub btnOpslaan_Click(sender As Object, e As EventArgs) Handles btnOpslaan.Click
        If SaveFile.ShowDialog() = DialogResult.OK Then
            modMain.ds.WriteXml(SaveFile.FileName)
            MessageBox.Show($"Bestand {SaveFile.FileName} is opgeslagen.", "Vordering")
            filename = SaveFile.FileName
        End If
    End Sub

    Private Sub btnOpenen_Click(sender As Object, e As EventArgs) Handles btnOpenen.Click
        If OpenFile.ShowDialog() = DialogResult.OK Then
            modMain.ds.ReadXml(OpenFile.FileName)
            curRow = 0
            'ID = dtNAW.Rows(dtNAW.Rows.Count - 1).Field(Of Long)("ID")
            'ID = dtNAW.Rows(tslblCount.Text)
            RefreshData()
            ID = dtNAW.Rows(Val(tslblCount.Text) - 1).Item("ID")
            ToonGegevens(0)
        End If
    End Sub
End Class

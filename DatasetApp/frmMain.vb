Public Class frmMain
    Const STRINGTYPE = "System.String"
    Const INT64TYPE = "System.Int64"
    Private ID As Long  'Uniek
    'Private curID As Long 'ID van huidige rij
    Private curRow As Long  'Rij die geselecteerd is
    Private dtNAW As DataTable
    Private filename As String
    Private isGewijzigd As Boolean
    'My.Computer.FileSystem.SpecialDirectories.Temp

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
        'isGewijzigd = False
        'EnableNav(True)
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
    Sub VeldenLegen(metID As Boolean)
        If metID Then txtID.Clear()
        txtVoornaam.Clear()
        txtTVS.Clear()
        txtAchternaam.Clear()
        txtAdres.Clear()
        txtPostcode.Clear()
        txtWPlaats.Clear()
        txtTel.Clear()
        txtEmail.Clear()
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
        modMain.ds.WriteXml(filename)
        EnableNav(True)
    End Sub

    Private Sub btnOpslaan_Click(sender As Object, e As EventArgs) Handles btnOpslaan.Click
        SaveFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If SaveFile.ShowDialog() = DialogResult.OK Then
            'isGewijzigd = False
            modMain.ds.WriteXml(SaveFile.FileName)
            MessageBox.Show($"Bestand {SaveFile.FileName} is opgeslagen.", "Vordering")
            'filename = SaveFile.FileName
        End If
    End Sub

    Private Sub btnOpenen_Click(sender As Object, e As EventArgs) Handles btnOpenen.Click
        If isGewijzigd Then
            MessageBox.Show("Er zijn nog niet opgeslagen gegevens.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        OpenFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If OpenFile.ShowDialog() = DialogResult.OK Then
            modMain.ds.Clear()
            modMain.ds.ReadXml(OpenFile.FileName)
            filename = OpenFile.FileName
            curRow = 0
            'ID = dtNAW.Rows(dtNAW.Rows.Count - 1).Field(Of Long)("ID")
            'ID = dtNAW.Rows(tslblCount.Text)
            'dgData.Rows.Clear()
            RefreshData()
            ID = dtNAW.Rows(Val(tslblCount.Text) - 1).Item("ID")
            ToonGegevens(0)
            EnableNav(True)
            dgData.Rows(0).Selected = True
        End If
    End Sub

    Private Sub dgData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellEnter
        Dim row As Integer = e.RowIndex

        If Not dgData.Rows(e.RowIndex).IsNewRow Then
            ToonGegevens(row)
            curRow = row
            tstxtRow.Text = curRow
        End If
    End Sub

    Private Sub tsbtnEdit_Click(sender As Object, e As EventArgs) Handles tsbtnEdit.Click
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
        For i = 0 To gegevens.Length - 1
            dtNAW.Rows(curRow).Item(i + 1) = gegevens(i)
        Next
        RefreshData()
        modMain.ds.WriteXml(filename)
    End Sub

    Private Sub btnVeldenLegen_Click(sender As Object, e As EventArgs) Handles btnVeldenLegen.Click
        VeldenLegen(metID:=False)
    End Sub

    Private Sub tsbtnRemove_Click(sender As Object, e As EventArgs) Handles tsbtnRemove.Click
        If txtID.Text.Length > 0 Then
            dtNAW.Rows.RemoveAt(curRow)
            If dtNAW.Rows.Count > 0 Then
                ToonGegevens(curRow)
                RefreshData()
                modMain.ds.WriteXml(filename)
            Else
                curRow = 0
                VeldenLegen(metID:=True)
                tslblCount.Text = "0"
                tstxtRow.Text = "0"
                EnableNav(False)
            End If
        End If
    End Sub

    Private Sub tsbtnSearch_Click(sender As Object, e As EventArgs) Handles tsbtnSearch.Click
        Dim objSearch As New dlgSearch
        'Dim dsQuery As New DataSet
        'dsQuery.Tables.Add("Query")

        'Dim columns() As String

        'dtNAW.Columns.CopyTo(columns(), 0)
        'For Each column As DataGridViewColumn In dtNAW.Columns
        For i As Integer = 0 To dtNAW.Columns.Count - 1
            'dsQuery.Tables("Query").Columns.Add(dtNAW.Columns(i).ColumnName)
            Dim column As New DataGridViewColumn
            column.Name = dtNAW.Columns(i).ColumnName
            objSearch.dgSearch.Columns.Add(column)
        Next
        'Dim myRow As DataRow
        'myRow = dsQuery.Tables("Query").NewRow

        'dsQuery.Tables("Query").Rows.Add(myRow)
        'objSearch.dgSearch.DataSource = dsQuery
        'For i As Integer = 0 To 
        objSearch.dgSearch.Refresh()

        If objSearch.ShowDialog(Me) = DialogResult.OK Then
            MessageBox.Show("OK knop geklikt")
        Else
            MessageBox.Show("Annuleren knop geklikt")
        End If
        'dsQuery = Nothing
    End Sub
End Class

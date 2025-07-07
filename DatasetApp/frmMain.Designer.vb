<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.btnOpslaan = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWPlaats = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAchternaam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTVS = New System.Windows.Forms.TextBox()
        Me.txtVoornaam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsNAW = New System.Windows.Forms.ToolStrip()
        Me.tsbtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnPrev = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstxtRow = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnRemove = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscmbColumns = New System.Windows.Forms.ToolStripComboBox()
        Me.tstxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnVeldenLegen = New System.Windows.Forms.Button()
        Me.btnOpenen = New System.Windows.Forms.Button()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        Me.tsNAW.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgData.Location = New System.Drawing.Point(0, 338)
        Me.dgData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgData.MultiSelect = False
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.ShowEditingIcon = False
        Me.dgData.Size = New System.Drawing.Size(1280, 291)
        Me.dgData.TabIndex = 0
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(1107, 162)
        Me.btnOpslaan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(160, 35)
        Me.btnOpslaan.TabIndex = 1
        Me.btnOpslaan.Tag = ""
        Me.btnOpslaan.Text = "Kopie Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(1107, 28)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(160, 35)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.txtID)
        Me.gbData.Controls.Add(Me.Label9)
        Me.gbData.Controls.Add(Me.txtEmail)
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.txtTel)
        Me.gbData.Controls.Add(Me.Label7)
        Me.gbData.Controls.Add(Me.txtWPlaats)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.txtPostcode)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.txtAdres)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.txtAchternaam)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Controls.Add(Me.txtTVS)
        Me.gbData.Controls.Add(Me.txtVoornaam)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Location = New System.Drawing.Point(13, 28)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(1080, 302)
        Me.gbData.TabIndex = 3
        Me.gbData.TabStop = False
        Me.gbData.Text = "Gegevens"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(122, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(98, 26)
        Me.txtID.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ID"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 258)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(485, 26)
        Me.txtEmail.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(122, 220)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(229, 26)
        Me.txtTel.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Telefoon"
        '
        'txtWPlaats
        '
        Me.txtWPlaats.Location = New System.Drawing.Point(122, 182)
        Me.txtWPlaats.Name = "txtWPlaats"
        Me.txtWPlaats.Size = New System.Drawing.Size(229, 26)
        Me.txtWPlaats.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Woonplaats"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(122, 146)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(117, 26)
        Me.txtPostcode.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(122, 108)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(229, 26)
        Me.txtAdres.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Adres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(642, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Achternaam"
        '
        'txtAchternaam
        '
        Me.txtAchternaam.Location = New System.Drawing.Point(756, 71)
        Me.txtAchternaam.Name = "txtAchternaam"
        Me.txtAchternaam.Size = New System.Drawing.Size(229, 26)
        Me.txtAchternaam.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tussenvoegsels"
        '
        'txtTVS
        '
        Me.txtTVS.Location = New System.Drawing.Point(509, 71)
        Me.txtTVS.Name = "txtTVS"
        Me.txtTVS.Size = New System.Drawing.Size(98, 26)
        Me.txtTVS.TabIndex = 2
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Location = New System.Drawing.Point(122, 71)
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(229, 26)
        Me.txtVoornaam.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Voornaam"
        '
        'tsNAW
        '
        Me.tsNAW.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnFirst, Me.tsbtnPrev, Me.ToolStripSeparator1, Me.tstxtRow, Me.ToolStripSeparator2, Me.tslblCount, Me.ToolStripSeparator3, Me.tsbtnNext, Me.tsbtnLast, Me.ToolStripSeparator4, Me.tsbtnAdd, Me.tsbtnEdit, Me.tsbtnRemove, Me.ToolStripSeparator5, Me.tscmbColumns, Me.tstxtSearch, Me.tsbtnSearch})
        Me.tsNAW.Location = New System.Drawing.Point(0, 0)
        Me.tsNAW.Name = "tsNAW"
        Me.tsNAW.Size = New System.Drawing.Size(1280, 25)
        Me.tsNAW.TabIndex = 4
        Me.tsNAW.Text = "ToolStrip1"
        '
        'tsbtnFirst
        '
        Me.tsbtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFirst.Image = CType(resources.GetObject("tsbtnFirst.Image"), System.Drawing.Image)
        Me.tsbtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFirst.Name = "tsbtnFirst"
        Me.tsbtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnFirst.ToolTipText = "Eerste rij"
        '
        'tsbtnPrev
        '
        Me.tsbtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnPrev.Image = Global.DatasetApp.My.Resources.Resources.resultset_previous
        Me.tsbtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrev.Name = "tsbtnPrev"
        Me.tsbtnPrev.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnPrev.ToolTipText = "Vorige rij"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstxtRow
        '
        Me.tstxtRow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstxtRow.Name = "tstxtRow"
        Me.tstxtRow.Size = New System.Drawing.Size(100, 25)
        Me.tstxtRow.ToolTipText = "Naar rij"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tslblCount
        '
        Me.tslblCount.Name = "tslblCount"
        Me.tslblCount.Size = New System.Drawing.Size(13, 22)
        Me.tslblCount.Text = "0"
        Me.tslblCount.ToolTipText = "Aantal rijen"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnNext
        '
        Me.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNext.Image = Global.DatasetApp.My.Resources.Resources.resultset_next
        Me.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNext.Name = "tsbtnNext"
        Me.tsbtnNext.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnNext.ToolTipText = "Volgende rij"
        '
        'tsbtnLast
        '
        Me.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnLast.Image = Global.DatasetApp.My.Resources.Resources.resultset_last
        Me.tsbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnLast.Name = "tsbtnLast"
        Me.tsbtnLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnLast.ToolTipText = "Laatste rij"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnAdd
        '
        Me.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAdd.Image = Global.DatasetApp.My.Resources.Resources.add
        Me.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAdd.Name = "tsbtnAdd"
        Me.tsbtnAdd.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAdd.ToolTipText = "Gegevens toevoegen"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEdit.Image = Global.DatasetApp.My.Resources.Resources.Edit
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnEdit.ToolTipText = "Gegevens wijzigen"
        '
        'tsbtnRemove
        '
        Me.tsbtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnRemove.Image = Global.DatasetApp.My.Resources.Resources.cross
        Me.tsbtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRemove.Name = "tsbtnRemove"
        Me.tsbtnRemove.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnRemove.ToolTipText = "Gegevens verwijderen"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tscmbColumns
        '
        Me.tscmbColumns.Items.AddRange(New Object() {"ID", "Achternaam", "Adres", "Postcode", "Woonplaats"})
        Me.tscmbColumns.Name = "tscmbColumns"
        Me.tscmbColumns.Size = New System.Drawing.Size(200, 25)
        Me.tscmbColumns.Text = "ID"
        '
        'tstxtSearch
        '
        Me.tstxtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstxtSearch.Name = "tstxtSearch"
        Me.tstxtSearch.Size = New System.Drawing.Size(300, 25)
        '
        'tsbtnSearch
        '
        Me.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSearch.Image = Global.DatasetApp.My.Resources.Resources.application_search_result
        Me.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSearch.Name = "tsbtnSearch"
        Me.tsbtnSearch.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnSearch.Text = "ToolStripButton1"
        '
        'btnVeldenLegen
        '
        Me.btnVeldenLegen.Location = New System.Drawing.Point(1107, 264)
        Me.btnVeldenLegen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVeldenLegen.Name = "btnVeldenLegen"
        Me.btnVeldenLegen.Size = New System.Drawing.Size(160, 35)
        Me.btnVeldenLegen.TabIndex = 5
        Me.btnVeldenLegen.Text = "Velden leegmaken"
        Me.btnVeldenLegen.UseVisualStyleBackColor = True
        '
        'btnOpenen
        '
        Me.btnOpenen.Location = New System.Drawing.Point(1107, 95)
        Me.btnOpenen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenen.Name = "btnOpenen"
        Me.btnOpenen.Size = New System.Drawing.Size(160, 35)
        Me.btnOpenen.TabIndex = 6
        Me.btnOpenen.Text = "Openen"
        Me.btnOpenen.UseVisualStyleBackColor = True
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "Dataset bestanden|*.xml"
        Me.OpenFile.InitialDirectory = "D:\Documenten\Projecten\Visual Basic\Dataset bestanden"
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "Dataset bestanden|*.xml"
        Me.SaveFile.InitialDirectory = "D:\Documenten\Projecten\Visual Basic\Dataset bestanden"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 629)
        Me.Controls.Add(Me.btnOpenen)
        Me.Controls.Add(Me.btnVeldenLegen)
        Me.Controls.Add(Me.tsNAW)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.dgData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.tsNAW.ResumeLayout(False)
        Me.tsNAW.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgData As DataGridView
    Friend WithEvents btnOpslaan As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents gbData As GroupBox
    Friend WithEvents tsNAW As ToolStrip
    Friend WithEvents tsbtnFirst As ToolStripButton
    Friend WithEvents tsbtnPrev As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tstxtRow As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tslblCount As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbtnNext As ToolStripButton
    Friend WithEvents tsbtnLast As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbtnAdd As ToolStripButton
    Friend WithEvents tsbtnEdit As ToolStripButton
    Friend WithEvents tsbtnRemove As ToolStripButton
    Friend WithEvents btnVeldenLegen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAchternaam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTVS As TextBox
    Friend WithEvents txtVoornaam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWPlaats As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnOpenen As Button
    Friend WithEvents OpenFile As OpenFileDialog
    Friend WithEvents SaveFile As SaveFileDialog
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tscmbColumns As ToolStripComboBox
    Friend WithEvents tstxtSearch As ToolStripTextBox
    Friend WithEvents tsbtnSearch As ToolStripButton
End Class

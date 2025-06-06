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
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.gbData = New System.Windows.Forms.GroupBox()
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
        Me.btnVeldenLegen = New System.Windows.Forms.Button()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsNAW.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgData
        '
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgData.Location = New System.Drawing.Point(0, 274)
        Me.dgData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgData.MultiSelect = False
        Me.dgData.Name = "dgData"
        Me.dgData.Size = New System.Drawing.Size(1061, 291)
        Me.dgData.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(912, 162)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(112, 35)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(936, 28)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(112, 35)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'gbData
        '
        Me.gbData.Location = New System.Drawing.Point(13, 28)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(844, 238)
        Me.gbData.TabIndex = 3
        Me.gbData.TabStop = False
        Me.gbData.Text = "Gegevens"
        '
        'tsNAW
        '
        Me.tsNAW.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnFirst, Me.tsbtnPrev, Me.ToolStripSeparator1, Me.tstxtRow, Me.ToolStripSeparator2, Me.tslblCount, Me.ToolStripSeparator3, Me.tsbtnNext, Me.tsbtnLast, Me.ToolStripSeparator4, Me.tsbtnAdd, Me.tsbtnEdit, Me.tsbtnRemove})
        Me.tsNAW.Location = New System.Drawing.Point(0, 0)
        Me.tsNAW.Name = "tsNAW"
        Me.tsNAW.Size = New System.Drawing.Size(1061, 25)
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
        'btnVeldenLegen
        '
        Me.btnVeldenLegen.Location = New System.Drawing.Point(888, 229)
        Me.btnVeldenLegen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVeldenLegen.Name = "btnVeldenLegen"
        Me.btnVeldenLegen.Size = New System.Drawing.Size(160, 35)
        Me.btnVeldenLegen.TabIndex = 5
        Me.btnVeldenLegen.Text = "Velden leegmaken"
        Me.btnVeldenLegen.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 565)
        Me.Controls.Add(Me.btnVeldenLegen)
        Me.Controls.Add(Me.tsNAW)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.dgData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsNAW.ResumeLayout(False)
        Me.tsNAW.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgData As DataGridView
    Friend WithEvents btnTest As Button
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
End Class

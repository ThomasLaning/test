<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoAndTellMissions
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
        Me.dgvDisplay = New System.Windows.Forms.DataGridView()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAscending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDescending = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEurope = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMiddleEast = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSouthAmerica = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnitedStates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDisplay
        '
        Me.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(12, 47)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(503, 367)
        Me.dgvDisplay.TabIndex = 0
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeyDisplayString = "Crtl+X"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(133, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuSort
        '
        Me.mnuSort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAscending, Me.mnuDescending})
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(40, 20)
        Me.mnuSort.Text = "Sort"
        '
        'mnuAscending
        '
        Me.mnuAscending.Name = "mnuAscending"
        Me.mnuAscending.ShortcutKeyDisplayString = "Crtl+A"
        Me.mnuAscending.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAscending.Size = New System.Drawing.Size(178, 22)
        Me.mnuAscending.Text = "Ascending"
        '
        'mnuDescending
        '
        Me.mnuDescending.Name = "mnuDescending"
        Me.mnuDescending.ShortcutKeyDisplayString = "Crtl+D"
        Me.mnuDescending.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDescending.Size = New System.Drawing.Size(178, 22)
        Me.mnuDescending.Text = "Descending"
        '
        'mnuFilter
        '
        Me.mnuFilter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAll, Me.mnuEurope, Me.mnuMiddleEast, Me.mnuSouthAmerica, Me.mnuUnitedStates})
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(45, 20)
        Me.mnuFilter.Text = "Filter"
        '
        'mnuAll
        '
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(192, 22)
        Me.mnuAll.Text = "All"
        '
        'mnuEurope
        '
        Me.mnuEurope.Name = "mnuEurope"
        Me.mnuEurope.ShortcutKeyDisplayString = "Ctrl+N"
        Me.mnuEurope.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuEurope.Size = New System.Drawing.Size(192, 22)
        Me.mnuEurope.Text = "Europe"
        '
        'mnuMiddleEast
        '
        Me.mnuMiddleEast.Name = "mnuMiddleEast"
        Me.mnuMiddleEast.ShortcutKeyDisplayString = "Ctrl+M"
        Me.mnuMiddleEast.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuMiddleEast.Size = New System.Drawing.Size(192, 22)
        Me.mnuMiddleEast.Text = "Middle East"
        '
        'mnuSouthAmerica
        '
        Me.mnuSouthAmerica.Name = "mnuSouthAmerica"
        Me.mnuSouthAmerica.ShortcutKeyDisplayString = "Ctrl+S"
        Me.mnuSouthAmerica.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSouthAmerica.Size = New System.Drawing.Size(192, 22)
        Me.mnuSouthAmerica.Text = "South America"
        '
        'mnuUnitedStates
        '
        Me.mnuUnitedStates.Name = "mnuUnitedStates"
        Me.mnuUnitedStates.ShortcutKeyDisplayString = "Ctrl+F"
        Me.mnuUnitedStates.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuUnitedStates.Size = New System.Drawing.Size(192, 22)
        Me.mnuUnitedStates.Text = "United States"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(54, 20)
        Me.mnuSearch.Text = "Search"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSort, Me.mnuFilter, Me.mnuSearch})
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(527, 24)
        Me.MenuStrip4.TabIndex = 4
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'frmGoAndTellMissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 426)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Name = "frmGoAndTellMissions"
        Me.Text = "Form1"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAscending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDescending As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEurope As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddleEast As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSouthAmerica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUnitedStates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip

End Class

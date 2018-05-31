<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelGenerik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.viewTabel = New System.Windows.Forms.DataGridView()
        Me.tabelSeparator001 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabelBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tabelSeparator002 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabelBtnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.sourceTabel = New System.Windows.Forms.BindingSource(Me.components)
        Me.tab1Cari = New System.Windows.Forms.TabPage()
        Me.tabletTabel = New System.Windows.Forms.TabControl()
        Me.tab2Tambah = New System.Windows.Forms.TabPage()
        CType(Me.viewTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabletTabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewTabel
        '
        Me.viewTabel.AllowUserToAddRows = False
        Me.viewTabel.AllowUserToDeleteRows = False
        Me.viewTabel.AutoGenerateColumns = False
        Me.viewTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewTabel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tabelSeparator001, Me.tabelBtnEdit, Me.tabelSeparator002, Me.tabelBtnHapus})
        Me.viewTabel.DataSource = Me.sourceTabel
        Me.viewTabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewTabel.Location = New System.Drawing.Point(0, 0)
        Me.viewTabel.Name = "viewTabel"
        Me.viewTabel.ReadOnly = True
        Me.viewTabel.Size = New System.Drawing.Size(784, 256)
        Me.viewTabel.TabIndex = 2
        '
        'tabelSeparator001
        '
        Me.tabelSeparator001.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tabelSeparator001.DividerWidth = 30
        Me.tabelSeparator001.HeaderText = ""
        Me.tabelSeparator001.Name = "tabelSeparator001"
        Me.tabelSeparator001.ReadOnly = True
        Me.tabelSeparator001.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelSeparator001.Width = 33
        '
        'tabelBtnEdit
        '
        Me.tabelBtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tabelBtnEdit.HeaderText = "Edit ?"
        Me.tabelBtnEdit.Name = "tabelBtnEdit"
        Me.tabelBtnEdit.ReadOnly = True
        Me.tabelBtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelBtnEdit.Text = "Edit Me"
        Me.tabelBtnEdit.UseColumnTextForButtonValue = True
        Me.tabelBtnEdit.Width = 40
        '
        'tabelSeparator002
        '
        Me.tabelSeparator002.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tabelSeparator002.DividerWidth = 30
        Me.tabelSeparator002.HeaderText = ""
        Me.tabelSeparator002.Name = "tabelSeparator002"
        Me.tabelSeparator002.ReadOnly = True
        Me.tabelSeparator002.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelSeparator002.Width = 33
        '
        'tabelBtnHapus
        '
        Me.tabelBtnHapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tabelBtnHapus.HeaderText = "Hapus ?"
        Me.tabelBtnHapus.Name = "tabelBtnHapus"
        Me.tabelBtnHapus.ReadOnly = True
        Me.tabelBtnHapus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelBtnHapus.Text = "Delete Me"
        Me.tabelBtnHapus.UseColumnTextForButtonValue = True
        Me.tabelBtnHapus.Width = 53
        '
        'tab1Cari
        '
        Me.tab1Cari.AutoScroll = True
        Me.tab1Cari.Location = New System.Drawing.Point(4, 22)
        Me.tab1Cari.Name = "tab1Cari"
        Me.tab1Cari.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1Cari.Size = New System.Drawing.Size(776, 159)
        Me.tab1Cari.TabIndex = 0
        Me.tab1Cari.Text = "Cari"
        Me.tab1Cari.UseVisualStyleBackColor = True
        '
        'tabletTabel
        '
        Me.tabletTabel.Controls.Add(Me.tab1Cari)
        Me.tabletTabel.Controls.Add(Me.tab2Tambah)
        Me.tabletTabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabletTabel.Location = New System.Drawing.Point(0, 256)
        Me.tabletTabel.Name = "tabletTabel"
        Me.tabletTabel.SelectedIndex = 0
        Me.tabletTabel.Size = New System.Drawing.Size(784, 185)
        Me.tabletTabel.TabIndex = 1
        '
        'tab2Tambah
        '
        Me.tab2Tambah.AutoScroll = True
        Me.tab2Tambah.Location = New System.Drawing.Point(4, 22)
        Me.tab2Tambah.Name = "tab2Tambah"
        Me.tab2Tambah.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2Tambah.Size = New System.Drawing.Size(776, 159)
        Me.tab2Tambah.TabIndex = 1
        Me.tab2Tambah.Text = "Tambah Data"
        Me.tab2Tambah.UseVisualStyleBackColor = True
        '
        'FormTabelGenerik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.viewTabel)
        Me.Controls.Add(Me.tabletTabel)
        Me.Name = "FormTabelGenerik"
        Me.Text = "TabelGenerik"
        CType(Me.viewTabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabletTabel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Protected WithEvents tab2Tambah As Windows.Forms.TabPage
    Protected WithEvents viewTabel As Windows.Forms.DataGridView
    Protected WithEvents tabletTabel As Windows.Forms.TabControl
    Protected WithEvents sourceTabel As Windows.Forms.BindingSource
    Friend WithEvents tabelSeparator001 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tabelBtnEdit As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents tabelSeparator002 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tabelBtnHapus As Windows.Forms.DataGridViewButtonColumn
    Protected WithEvents tab1Cari As Windows.Forms.TabPage
End Class

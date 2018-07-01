<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTabelKendaraan
    Inherits FP_BENGKEL_MOTOR.FormTabelGenerik

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.KENDARAANTableAdapter()
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputTBNoPol = New System.Windows.Forms.TextBox()
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputNumTahun = New System.Windows.Forms.NumericUpDown()
        Me.inputTBstnk = New System.Windows.Forms.TextBox()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabletTabel.SuspendLayout()
        Me.tab1Search.SuspendLayout()
        Me.inputGB.SuspendLayout()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSearch.SuspendLayout()
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scManipulasi.Panel1.SuspendLayout()
        Me.scManipulasi.Panel2.SuspendLayout()
        Me.scManipulasi.SuspendLayout()
        Me.inputTLP.SuspendLayout()
        CType(Me.inputNumTahun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "KENDARAAN"
        Me.sourceTabel.Position = -1
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.inputTLP)
        Me.inputGB.Size = New System.Drawing.Size(566, 187)
        Me.inputGB.Text = "Mode Tambah\Insert Data"
        Me.inputGB.Controls.SetChildIndex(Me.inputTLP, 0)
        '
        'scManipulasi
        '
        Me.scManipulasi.Panel1Collapsed = True
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(147, 80)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(11, 15)
        Label5.TabIndex = 23
        Label5.Text = ":"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(3, 27)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(3, 54)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(138, 15)
        Label8.TabIndex = 26
        Label8.Text = "Tahun Pembuatan"
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(3, 80)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(71, 23)
        Label9.TabIndex = 27
        Label9.Text = "No. STNK"
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(147, 54)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(11, 15)
        Label11.TabIndex = 34
        Label11.Text = ":"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(147, 27)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(11, 15)
        Label12.TabIndex = 35
        Label12.Text = ":"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(3, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(121, 15)
        Label13.TabIndex = 36
        Label13.Text = "TNKB (No. Polisi)"
        '
        'Label14
        '
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(147, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(11, 15)
        Label14.TabIndex = 37
        Label14.Text = ":"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(164, 80)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(107, 23)
        Label1.TabIndex = 46
        Label1.Text = "(Boleh di kosongkan)"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label1, 2, 3)
        Me.inputTLP.Controls.Add(Label5, 1, 3)
        Me.inputTLP.Controls.Add(Label7, 0, 1)
        Me.inputTLP.Controls.Add(Label8, 0, 2)
        Me.inputTLP.Controls.Add(Label9, 0, 3)
        Me.inputTLP.Controls.Add(Label11, 1, 2)
        Me.inputTLP.Controls.Add(Label12, 1, 1)
        Me.inputTLP.Controls.Add(Label13, 0, 0)
        Me.inputTLP.Controls.Add(Label14, 1, 0)
        Me.inputTLP.Controls.Add(Me.inputTBNoPol, 3, 0)
        Me.inputTLP.Controls.Add(Me.inputTBNama, 3, 1)
        Me.inputTLP.Controls.Add(Me.inputNumTahun, 3, 2)
        Me.inputTLP.Controls.Add(Me.inputTBstnk, 3, 3)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 4
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 139)
        Me.inputTLP.TabIndex = 0
        '
        'inputTBNoPol
        '
        Me.inputTBNoPol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.inputTBNoPol.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNoPol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNoPol.Location = New System.Drawing.Point(323, 3)
        Me.inputTBNoPol.MaxLength = 12
        Me.inputTBNoPol.Name = "inputTBNoPol"
        Me.inputTBNoPol.Size = New System.Drawing.Size(234, 21)
        Me.inputTBNoPol.TabIndex = 0
        Me.inputTBNoPol.Text = "XX YYYY ZZZ"
        Me.inputTBNoPol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNama
        '
        Me.inputTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNama.Location = New System.Drawing.Point(323, 30)
        Me.inputTBNama.MaxLength = 64
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(234, 21)
        Me.inputTBNama.TabIndex = 1
        Me.inputTBNama.Text = "KENDARAAN"
        Me.inputTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputNumTahun
        '
        Me.inputNumTahun.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputNumTahun.Location = New System.Drawing.Point(323, 57)
        Me.inputNumTahun.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.inputNumTahun.Minimum = New Decimal(New Integer() {1600, 0, 0, 0})
        Me.inputNumTahun.Name = "inputNumTahun"
        Me.inputNumTahun.Size = New System.Drawing.Size(234, 20)
        Me.inputNumTahun.TabIndex = 2
        Me.inputNumTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inputNumTahun.Value = New Decimal(New Integer() {1600, 0, 0, 0})
        '
        'inputTBstnk
        '
        Me.inputTBstnk.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBstnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBstnk.Location = New System.Drawing.Point(323, 83)
        Me.inputTBstnk.MaxLength = 13
        Me.inputTBstnk.Name = "inputTBstnk"
        Me.inputTBstnk.Size = New System.Drawing.Size(234, 21)
        Me.inputTBstnk.TabIndex = 3
        Me.inputTBstnk.Text = "No. STNK"
        Me.inputTBstnk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormTabelKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER, FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_KASIR}
        Me.Name = "FormTabelKendaraan"
        Me.Text = "Daftar Kendaraan Pelanggan"
        Me.TipeVerifikasiIzin = FP_BENGKEL_MOTOR.TipeVerifikasiPeranUser.ROLE_VERIFY_AT_LEAST_ONE
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabletTabel.ResumeLayout(False)
        Me.tab1Search.ResumeLayout(False)
        Me.inputGB.ResumeLayout(False)
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSearch.ResumeLayout(False)
        Me.scManipulasi.Panel1.ResumeLayout(False)
        Me.scManipulasi.Panel1.PerformLayout()
        Me.scManipulasi.Panel2.ResumeLayout(False)
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scManipulasi.ResumeLayout(False)
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        CType(Me.inputNumTahun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.KENDARAANTableAdapter
    Private WithEvents inputTLP As TableLayoutPanel
    Friend WithEvents inputTBNoPol As TextBox
    Friend WithEvents inputTBNama As TextBox
    Friend WithEvents inputTBstnk As TextBox
    Friend WithEvents inputNumTahun As NumericUpDown
End Class

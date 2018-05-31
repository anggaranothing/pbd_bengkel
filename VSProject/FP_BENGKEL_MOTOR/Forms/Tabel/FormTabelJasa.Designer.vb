<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTabelJasa
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Dim Label1 As System.Windows.Forms.Label
        Dim TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.inputNumHarga = New System.Windows.Forms.NumericUpDown()
        Me.inputNumWaktu = New System.Windows.Forms.NumericUpDown()
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputTBKode = New System.Windows.Forms.TextBox()
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputBtnResetKode = New System.Windows.Forms.Button()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.JASATableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Label1 = New System.Windows.Forms.Label()
        TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabletTabel.SuspendLayout()
        Me.tab1Search.SuspendLayout()
        Me.inputGB.SuspendLayout()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSearch.SuspendLayout()
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scManipulasi.Panel2.SuspendLayout()
        Me.scManipulasi.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(Me.inputNumHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(Me.inputNumWaktu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inputTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "JASA"
        Me.sourceTabel.Position = -1
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.inputTLP)
        Me.inputGB.Size = New System.Drawing.Size(566, 187)
        Me.inputGB.Text = "Mode Tambah"
        Me.inputGB.Controls.SetChildIndex(Me.inputTLP, 0)
        '
        'scManipulasi
        '
        Me.scManipulasi.Panel1Collapsed = True
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(91, 88)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(11, 15)
        Label5.TabIndex = 23
        Label5.Text = ":"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(3, 29)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(3, 88)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(82, 15)
        Label9.TabIndex = 27
        Label9.Text = "Per X menit"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(3, 56)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(51, 15)
        Label8.TabIndex = 26
        Label8.Text = "Harga"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(91, 56)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(11, 15)
        Label11.TabIndex = 34
        Label11.Text = ":"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(91, 29)
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
        Label13.Size = New System.Drawing.Size(40, 15)
        Label13.TabIndex = 36
        Label13.Text = "Kode"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(91, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(11, 15)
        Label14.TabIndex = 37
        Label14.Text = ":"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.Controls.Add(Me.inputNumHarga, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel1.Location = New System.Drawing.Point(290, 59)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(267, 26)
        TableLayoutPanel1.TabIndex = 39
        '
        'inputNumHarga
        '
        Me.inputNumHarga.DecimalPlaces = 2
        Me.inputNumHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputNumHarga.Location = New System.Drawing.Point(33, 3)
        Me.inputNumHarga.Maximum = New Decimal(New Integer() {2061584302, 21474836, 0, 131072})
        Me.inputNumHarga.Name = "inputNumHarga"
        Me.inputNumHarga.Size = New System.Drawing.Size(231, 20)
        Me.inputNumHarga.TabIndex = 38
        Me.inputNumHarga.ThousandsSeparator = True
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(24, 13)
        Label1.TabIndex = 39
        Label1.Text = "Rp."
        '
        'TableLayoutPanel2
        '
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        TableLayoutPanel2.Controls.Add(Me.inputNumWaktu, 0, 0)
        TableLayoutPanel2.Controls.Add(Label2, 1, 0)
        TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel2.Location = New System.Drawing.Point(290, 91)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.Size = New System.Drawing.Size(267, 26)
        TableLayoutPanel2.TabIndex = 40
        '
        'inputNumWaktu
        '
        Me.inputNumWaktu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputNumWaktu.Location = New System.Drawing.Point(3, 3)
        Me.inputNumWaktu.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.inputNumWaktu.Name = "inputNumWaktu"
        Me.inputNumWaktu.Size = New System.Drawing.Size(221, 20)
        Me.inputNumWaktu.TabIndex = 38
        Me.inputNumWaktu.ThousandsSeparator = True
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(230, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(33, 13)
        Label2.TabIndex = 39
        Label2.Text = "Menit"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(108, 88)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(175, 52)
        Label3.TabIndex = 41
        Label3.Text = "( Akumulasi tagihan pelanggan berupa harga per menit. Jika di beri nilai kosong (" &
    "0), maka tidak ada penambahan tagihan. )"
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label5, 1, 3)
        Me.inputTLP.Controls.Add(Label7, 0, 1)
        Me.inputTLP.Controls.Add(Label9, 0, 3)
        Me.inputTLP.Controls.Add(Label8, 0, 2)
        Me.inputTLP.Controls.Add(Label11, 1, 2)
        Me.inputTLP.Controls.Add(Label12, 1, 1)
        Me.inputTLP.Controls.Add(Label13, 0, 0)
        Me.inputTLP.Controls.Add(Label14, 1, 0)
        Me.inputTLP.Controls.Add(Me.inputTBKode, 3, 0)
        Me.inputTLP.Controls.Add(Me.inputTBNama, 3, 1)
        Me.inputTLP.Controls.Add(TableLayoutPanel1, 3, 2)
        Me.inputTLP.Controls.Add(TableLayoutPanel2, 3, 3)
        Me.inputTLP.Controls.Add(Label3, 2, 3)
        Me.inputTLP.Controls.Add(Me.inputBtnResetKode, 2, 0)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 4
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 139)
        Me.inputTLP.TabIndex = 5
        '
        'inputTBKode
        '
        Me.inputTBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.inputTBKode.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBKode.Location = New System.Drawing.Point(290, 3)
        Me.inputTBKode.Name = "inputTBKode"
        Me.inputTBKode.ReadOnly = True
        Me.inputTBKode.Size = New System.Drawing.Size(267, 21)
        Me.inputTBKode.TabIndex = 19
        Me.inputTBKode.Text = "XX-YYYYY"
        Me.inputTBKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNama
        '
        Me.inputTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNama.Location = New System.Drawing.Point(290, 32)
        Me.inputTBNama.MaxLength = 128
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(267, 21)
        Me.inputTBNama.TabIndex = 29
        Me.inputTBNama.Text = "NAMA JASA"
        Me.inputTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputBtnResetKode
        '
        Me.inputBtnResetKode.AutoSize = True
        Me.inputBtnResetKode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inputBtnResetKode.Dock = System.Windows.Forms.DockStyle.Right
        Me.inputBtnResetKode.Location = New System.Drawing.Point(239, 3)
        Me.inputBtnResetKode.Name = "inputBtnResetKode"
        Me.inputBtnResetKode.Size = New System.Drawing.Size(45, 23)
        Me.inputBtnResetKode.TabIndex = 42
        Me.inputBtnResetKode.Text = "Reset"
        Me.inputBtnResetKode.UseVisualStyleBackColor = True
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'FormTabelJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER}
        Me.Name = "FormTabelJasa"
        Me.Text = "Daftar Layanan Jasa"
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabletTabel.ResumeLayout(False)
        Me.tab1Search.ResumeLayout(False)
        Me.inputGB.ResumeLayout(False)
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSearch.ResumeLayout(False)
        Me.scManipulasi.Panel2.ResumeLayout(False)
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scManipulasi.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(Me.inputNumHarga, System.ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        CType(Me.inputNumWaktu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents inputTLP As TableLayoutPanel
    Friend WithEvents inputTBKode As TextBox
    Friend WithEvents inputTBNama As TextBox
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.JASATableAdapter
    Friend WithEvents inputNumHarga As NumericUpDown
    Friend WithEvents inputNumWaktu As NumericUpDown
    Friend WithEvents inputBtnResetKode As Button
End Class

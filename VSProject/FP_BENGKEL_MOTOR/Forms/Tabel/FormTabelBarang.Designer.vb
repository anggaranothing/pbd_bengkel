<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelBarang
    Inherits FP_BENGKEL_MOTOR.FormTabelGenerik

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.inputNumHarga = New System.Windows.Forms.NumericUpDown()
        Me.inputNumStok = New System.Windows.Forms.NumericUpDown()
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputTBKode = New System.Windows.Forms.TextBox()
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputBtnResetKode = New System.Windows.Forms.Button()
        Me.inputTBBarcode = New System.Windows.Forms.TextBox()
        Me.inputPanelRTBKet = New System.Windows.Forms.Panel()
        Me.inputRTBKet = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEx1 = New RichTextBoxEx.RichTextBoxEx()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.BARANGTableAdapter()
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
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
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
        TableLayoutPanel1.SuspendLayout()
        CType(Me.inputNumHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(Me.inputNumStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inputTLP.SuspendLayout()
        Me.inputPanelRTBKet.SuspendLayout()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "BARANG"
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
        Label9.Size = New System.Drawing.Size(82, 36)
        Label9.TabIndex = 27
        Label9.Text = "Stok Persediaan"
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
        TableLayoutPanel1.Location = New System.Drawing.Point(283, 59)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(257, 26)
        TableLayoutPanel1.TabIndex = 39
        '
        'inputNumHarga
        '
        Me.inputNumHarga.DecimalPlaces = 2
        Me.inputNumHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputNumHarga.Location = New System.Drawing.Point(33, 3)
        Me.inputNumHarga.Maximum = New Decimal(New Integer() {2061584302, 21474836, 0, 131072})
        Me.inputNumHarga.Name = "inputNumHarga"
        Me.inputNumHarga.Size = New System.Drawing.Size(221, 20)
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
        TableLayoutPanel2.Controls.Add(Me.inputNumStok, 0, 0)
        TableLayoutPanel2.Controls.Add(Label2, 1, 0)
        TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel2.Location = New System.Drawing.Point(283, 91)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.Size = New System.Drawing.Size(257, 26)
        TableLayoutPanel2.TabIndex = 40
        '
        'inputNumStok
        '
        Me.inputNumStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputNumStok.Location = New System.Drawing.Point(3, 3)
        Me.inputNumStok.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.inputNumStok.Name = "inputNumStok"
        Me.inputNumStok.Size = New System.Drawing.Size(211, 20)
        Me.inputNumStok.TabIndex = 38
        Me.inputNumStok.ThousandsSeparator = True
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(220, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(33, 13)
        Label2.TabIndex = 39
        Label2.Text = "Unit"
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(3, 124)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(82, 30)
        Label3.TabIndex = 43
        Label3.Text = "Nomor Barcode"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(91, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(11, 15)
        Label4.TabIndex = 44
        Label4.Text = ":"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(3, 154)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(82, 30)
        Label6.TabIndex = 46
        Label6.Text = "Keterangan Produk"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(91, 154)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(11, 15)
        Label10.TabIndex = 47
        Label10.Text = ":"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.inputTLP.Controls.Add(Me.inputBtnResetKode, 2, 0)
        Me.inputTLP.Controls.Add(Label4, 1, 4)
        Me.inputTLP.Controls.Add(Label3, 0, 4)
        Me.inputTLP.Controls.Add(Me.inputTBBarcode, 3, 4)
        Me.inputTLP.Controls.Add(Label10, 1, 5)
        Me.inputTLP.Controls.Add(Label6, 0, 5)
        Me.inputTLP.Controls.Add(Me.inputPanelRTBKet, 2, 5)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 6
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 139)
        Me.inputTLP.TabIndex = 6
        '
        'inputTBKode
        '
        Me.inputTBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.inputTBKode.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBKode.Location = New System.Drawing.Point(283, 3)
        Me.inputTBKode.Name = "inputTBKode"
        Me.inputTBKode.ReadOnly = True
        Me.inputTBKode.Size = New System.Drawing.Size(257, 21)
        Me.inputTBKode.TabIndex = 19
        Me.inputTBKode.Text = "XX-YYYYY"
        Me.inputTBKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNama
        '
        Me.inputTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNama.Location = New System.Drawing.Point(283, 32)
        Me.inputTBNama.MaxLength = 128
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(257, 21)
        Me.inputTBNama.TabIndex = 29
        Me.inputTBNama.Text = "NAMA PRODUK"
        Me.inputTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputBtnResetKode
        '
        Me.inputBtnResetKode.AutoSize = True
        Me.inputBtnResetKode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inputBtnResetKode.Dock = System.Windows.Forms.DockStyle.Right
        Me.inputBtnResetKode.Location = New System.Drawing.Point(232, 3)
        Me.inputBtnResetKode.Name = "inputBtnResetKode"
        Me.inputBtnResetKode.Size = New System.Drawing.Size(45, 23)
        Me.inputBtnResetKode.TabIndex = 42
        Me.inputBtnResetKode.Text = "Reset"
        Me.inputBtnResetKode.UseVisualStyleBackColor = True
        '
        'inputTBBarcode
        '
        Me.inputTBBarcode.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBBarcode.Location = New System.Drawing.Point(283, 127)
        Me.inputTBBarcode.MaxLength = 13
        Me.inputTBBarcode.Name = "inputTBBarcode"
        Me.inputTBBarcode.Size = New System.Drawing.Size(257, 21)
        Me.inputTBBarcode.TabIndex = 45
        Me.inputTBBarcode.Text = "BarCode"
        Me.inputTBBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputPanelRTBKet
        '
        Me.inputTLP.SetColumnSpan(Me.inputPanelRTBKet, 2)
        Me.inputPanelRTBKet.Controls.Add(Me.inputRTBKet)
        Me.inputPanelRTBKet.Controls.Add(Me.RichTextBoxEx1)
        Me.inputPanelRTBKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputPanelRTBKet.Location = New System.Drawing.Point(108, 157)
        Me.inputPanelRTBKet.Name = "inputPanelRTBKet"
        Me.inputPanelRTBKet.Size = New System.Drawing.Size(432, 239)
        Me.inputPanelRTBKet.TabIndex = 49
        '
        'inputRTBKet
        '
        Me.inputRTBKet.AcceptsTab = True
        Me.inputRTBKet.EnableAutoDragDrop = True
        Me.inputRTBKet.Location = New System.Drawing.Point(0, 25)
        Me.inputRTBKet.Name = "inputRTBKet"
        Me.inputRTBKet.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.inputRTBKet.ShowSelectionMargin = True
        Me.inputRTBKet.Size = New System.Drawing.Size(432, 214)
        Me.inputRTBKet.TabIndex = 3
        Me.inputRTBKet.Text = ""
        '
        'RichTextBoxEx1
        '
        Me.RichTextBoxEx1.AllowBullets = True
        Me.RichTextBoxEx1.AllowDefaultInsertText = True
        Me.RichTextBoxEx1.AllowDefaultSmartText = True
        Me.RichTextBoxEx1.AllowHyphenation = True
        Me.RichTextBoxEx1.AllowPictures = True
        Me.RichTextBoxEx1.AllowSpellCheck = True
        Me.RichTextBoxEx1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.RichTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxEx1.FilePath = ""
        Me.RichTextBoxEx1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxEx1.Name = "RichTextBoxEx1"
        Me.RichTextBoxEx1.rtb = Me.inputRTBKet
        Me.RichTextBoxEx1.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBoxEx1.SetColorWithFont = True
        Me.RichTextBoxEx1.ShowToolStrip = True
        Me.RichTextBoxEx1.Size = New System.Drawing.Size(432, 239)
        Me.RichTextBoxEx1.TabIndex = 2
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'FormTabelBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER}
        Me.Name = "FormTabelBarang"
        Me.Text = "Daftar Persediaan Barang"
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
        TableLayoutPanel1.ResumeLayout(False)
        CType(Me.inputNumHarga, System.ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        CType(Me.inputNumStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.inputPanelRTBKet.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents inputTLP As TableLayoutPanel
    Friend WithEvents inputTBKode As TextBox
    Friend WithEvents inputTBNama As TextBox
    Friend WithEvents inputNumHarga As NumericUpDown
    Friend WithEvents inputNumStok As NumericUpDown
    Friend WithEvents inputBtnResetKode As Button
    Friend WithEvents inputTBBarcode As TextBox
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.BARANGTableAdapter
    Private WithEvents inputPanelRTBKet As Panel
    Friend WithEvents RichTextBoxEx1 As RichTextBoxEx.RichTextBoxEx
    Friend WithEvents inputRTBKet As RichTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTabelTransaksi
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.tbNoNota = New System.Windows.Forms.TextBox()
        Me.tbPelanggan = New System.Windows.Forms.TextBox()
        Me.inputPanelRTBKet = New System.Windows.Forms.Panel()
        Me.inputRTBKet = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxEx1 = New RichTextBoxEx.RichTextBoxEx()
        Me.numBayar = New System.Windows.Forms.NumericUpDown()
        Me.dtpLunas = New System.Windows.Forms.DateTimePicker()
        Me.lblBayarSymbol = New System.Windows.Forms.Label()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.TRANSAKSITableAdapter()
        Me.btnViewDetail = New System.Windows.Forms.ToolStripButton()
        Me.btnNewReturn = New System.Windows.Forms.ToolStripButton()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.toolStripManipulasiData.SuspendLayout()
        Me.inputTLP.SuspendLayout()
        Me.inputPanelRTBKet.SuspendLayout()
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "TRANSAKSI"
        Me.sourceTabel.Position = -1
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.inputTLP)
        Me.inputGB.Size = New System.Drawing.Size(566, 173)
        Me.inputGB.Text = "Mode Tambah Data"
        Me.inputGB.Controls.SetChildIndex(Me.inputTLP, 0)
        '
        'scManipulasi
        '
        Me.scManipulasi.Panel1Collapsed = True
        '
        'toolStripManipulasiData
        '
        Me.toolStripManipulasiData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripSeparator1, Me.btnViewDetail, ToolStripSeparator2, Me.btnNewReturn})
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(3, 80)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(82, 40)
        Label3.TabIndex = 43
        Label3.Text = "Piutang"
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(91, 80)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(11, 15)
        Label4.TabIndex = 44
        Label4.Text = ":"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(3, 160)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(82, 60)
        Label6.TabIndex = 46
        Label6.Text = "Keterangan Nota" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Boleh di kosongkan)"
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(3, 40)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(82, 40)
        Label7.TabIndex = 25
        Label7.Text = "Pelanggan"
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(91, 160)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(11, 15)
        Label10.TabIndex = 47
        Label10.Text = ":"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(91, 40)
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
        Label13.Size = New System.Drawing.Size(82, 40)
        Label13.TabIndex = 36
        Label13.Text = "No. Nota"
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
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(91, 120)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(11, 15)
        Label2.TabIndex = 49
        Label2.Text = ":"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(3, 120)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(82, 40)
        Label15.TabIndex = 50
        Label15.Text = "Tgl. Pelunasan"
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label15, 0, 3)
        Me.inputTLP.Controls.Add(Label3, 0, 2)
        Me.inputTLP.Controls.Add(Label4, 1, 2)
        Me.inputTLP.Controls.Add(Label6, 0, 4)
        Me.inputTLP.Controls.Add(Label7, 0, 1)
        Me.inputTLP.Controls.Add(Label10, 1, 4)
        Me.inputTLP.Controls.Add(Label12, 1, 1)
        Me.inputTLP.Controls.Add(Label13, 0, 0)
        Me.inputTLP.Controls.Add(Label14, 1, 0)
        Me.inputTLP.Controls.Add(Me.tbNoNota, 3, 0)
        Me.inputTLP.Controls.Add(Me.tbPelanggan, 3, 1)
        Me.inputTLP.Controls.Add(Me.inputPanelRTBKet, 2, 4)
        Me.inputTLP.Controls.Add(Me.numBayar, 3, 2)
        Me.inputTLP.Controls.Add(Label2, 1, 3)
        Me.inputTLP.Controls.Add(Me.dtpLunas, 3, 3)
        Me.inputTLP.Controls.Add(Me.lblBayarSymbol, 2, 2)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 5
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 125)
        Me.inputTLP.TabIndex = 1000
        '
        'tbNoNota
        '
        Me.tbNoNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNoNota.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbNoNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.tbNoNota.Location = New System.Drawing.Point(283, 3)
        Me.tbNoNota.Name = "tbNoNota"
        Me.tbNoNota.ReadOnly = True
        Me.tbNoNota.Size = New System.Drawing.Size(257, 21)
        Me.tbNoNota.TabIndex = 1
        Me.tbNoNota.TabStop = False
        Me.tbNoNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPelanggan
        '
        Me.tbPelanggan.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.tbPelanggan.Location = New System.Drawing.Point(283, 43)
        Me.tbPelanggan.MaxLength = 64
        Me.tbPelanggan.Name = "tbPelanggan"
        Me.tbPelanggan.ReadOnly = True
        Me.tbPelanggan.Size = New System.Drawing.Size(257, 21)
        Me.tbPelanggan.TabIndex = 2
        Me.tbPelanggan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputPanelRTBKet
        '
        Me.inputTLP.SetColumnSpan(Me.inputPanelRTBKet, 2)
        Me.inputPanelRTBKet.Controls.Add(Me.inputRTBKet)
        Me.inputPanelRTBKet.Controls.Add(Me.RichTextBoxEx1)
        Me.inputPanelRTBKet.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputPanelRTBKet.Location = New System.Drawing.Point(108, 163)
        Me.inputPanelRTBKet.Name = "inputPanelRTBKet"
        Me.inputPanelRTBKet.Size = New System.Drawing.Size(432, 239)
        Me.inputPanelRTBKet.TabIndex = 6
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
        Me.inputRTBKet.TabIndex = 6
        Me.inputRTBKet.Text = ""
        '
        'RichTextBoxEx1
        '
        Me.RichTextBoxEx1.AllowBullets = True
        Me.RichTextBoxEx1.AllowDefaultInsertText = True
        Me.RichTextBoxEx1.AllowDefaultSmartText = True
        Me.RichTextBoxEx1.AllowDrop = True
        Me.RichTextBoxEx1.AllowHyphenation = True
        Me.RichTextBoxEx1.AllowPictures = True
        Me.RichTextBoxEx1.AllowSpellCheck = False
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
        Me.RichTextBoxEx1.TabIndex = 6
        '
        'numBayar
        '
        Me.numBayar.Dock = System.Windows.Forms.DockStyle.Top
        Me.numBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.numBayar.Location = New System.Drawing.Point(283, 83)
        Me.numBayar.Maximum = New Decimal(New Integer() {-1, 2147483647, 0, 262144})
        Me.numBayar.Name = "numBayar"
        Me.numBayar.Size = New System.Drawing.Size(257, 21)
        Me.numBayar.TabIndex = 5
        Me.numBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numBayar.ThousandsSeparator = True
        '
        'dtpLunas
        '
        Me.dtpLunas.Checked = False
        Me.dtpLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtpLunas.Enabled = False
        Me.dtpLunas.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLunas.Location = New System.Drawing.Point(283, 123)
        Me.dtpLunas.Name = "dtpLunas"
        Me.dtpLunas.ShowCheckBox = True
        Me.dtpLunas.Size = New System.Drawing.Size(257, 20)
        Me.dtpLunas.TabIndex = 51
        '
        'lblBayarSymbol
        '
        Me.lblBayarSymbol.AutoSize = True
        Me.lblBayarSymbol.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblBayarSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBayarSymbol.Location = New System.Drawing.Point(252, 80)
        Me.lblBayarSymbol.Name = "lblBayarSymbol"
        Me.lblBayarSymbol.Size = New System.Drawing.Size(25, 40)
        Me.lblBayarSymbol.TabIndex = 52
        Me.lblBayarSymbol.Text = "Rp"
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'btnViewDetail
        '
        Me.btnViewDetail.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_note
        Me.btnViewDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewDetail.Name = "btnViewDetail"
        Me.btnViewDetail.Size = New System.Drawing.Size(86, 22)
        Me.btnViewDetail.Text = "Lihat &Detail"
        '
        'btnNewReturn
        '
        Me.btnNewReturn.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_roundabout
        Me.btnNewReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewReturn.Name = "btnNewReturn"
        Me.btnNewReturn.Size = New System.Drawing.Size(102, 22)
        Me.btnNewReturn.Text = "Return &Barang"
        '
        'FormTabelTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER, FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_KASIR}
        Me.Name = "FormTabelTransaksi"
        Me.Text = "Daftar Riwayat Transaksi"
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
        Me.toolStripManipulasiData.ResumeLayout(False)
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.inputPanelRTBKet.ResumeLayout(False)
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.TRANSAKSITableAdapter
    Private WithEvents inputTLP As TableLayoutPanel
    Private WithEvents inputPanelRTBKet As Panel
    Private WithEvents tbNoNota As TextBox
    Private WithEvents tbPelanggan As TextBox
    Private WithEvents inputRTBKet As RichTextBox
    Private WithEvents RichTextBoxEx1 As RichTextBoxEx.RichTextBoxEx
    Private WithEvents numBayar As NumericUpDown
    Private WithEvents dtpLunas As DateTimePicker
    Friend WithEvents lblBayarSymbol As Label
    Friend WithEvents btnViewDetail As ToolStripButton
    Friend WithEvents btnNewReturn As ToolStripButton
End Class

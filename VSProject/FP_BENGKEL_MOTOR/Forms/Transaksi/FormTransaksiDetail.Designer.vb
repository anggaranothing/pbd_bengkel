<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksiDetail
    Inherits FP_BENGKEL_MOTOR.FormGenerik

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
        Dim Label1 As System.Windows.Forms.Label
        Dim bnTabel As System.Windows.Forms.BindingNavigator
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksiDetail))
        Dim BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
        Dim BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Dim TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Dim TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Dim Label9 As System.Windows.Forms.Label
        Dim TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bsTabel = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBelanja = New FP_BENGKEL_MOTOR.DataSetBelanja()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btnTambahBarang = New System.Windows.Forms.ToolStripButton()
        Me.btnTambahJasa = New System.Windows.Forms.ToolStripButton()
        Me.btnTambahDiskon = New System.Windows.Forms.ToolStripButton()
        Me.btnAddReturnItem = New System.Windows.Forms.ToolStripButton()
        Me.btnEditItem = New System.Windows.Forms.ToolStripButton()
        Me.btnHapusItem = New System.Windows.Forms.ToolStripButton()
        Me.tbPelanggan = New System.Windows.Forms.TextBox()
        Me.btnPelangganBrowse = New System.Windows.Forms.Button()
        Me.btnHapusMekanik = New System.Windows.Forms.Button()
        Me.tbMekanik = New System.Windows.Forms.TextBox()
        Me.btnMekanikBrowse = New System.Windows.Forms.Button()
        Me.btnHapusKendaraan = New System.Windows.Forms.Button()
        Me.tbKendaraan = New System.Windows.Forms.TextBox()
        Me.btnKendaraanBrowse = New System.Windows.Forms.Button()
        Me.tbNoNota = New System.Windows.Forms.TextBox()
        Me.btnNotaReset = New System.Windows.Forms.Button()
        Me.lblJmlByrSymbol = New System.Windows.Forms.Label()
        Me.dgvTabel = New System.Windows.Forms.DataGridView()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisSatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KuantitasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDiskonItem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataJSON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpHeader1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.panelJmlByr = New System.Windows.Forms.Panel()
        Me.numBayar = New System.Windows.Forms.NumericUpDown()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnKeterangan = New System.Windows.Forms.Button()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.tplFooter1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbLunas = New System.Windows.Forms.TextBox()
        Me.cbLunas = New System.Windows.Forms.CheckBox()
        Me.tbTglBuat = New System.Windows.Forms.TextBox()
        Me.timerRefreshTgl = New System.Windows.Forms.Timer(Me.components)
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.panelFooter2 = New System.Windows.Forms.Panel()
        Me.flpShortcutsList = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.tableAdapterTrans = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.TRANSAKSITableAdapter()
        Me.tableAdapterPelanggan = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.PELANGGANTableAdapter()
        Me.tableAdapterMekanik = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.MONTIRTableAdapter()
        Me.tableAdapterKendaraan = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.KENDARAANTableAdapter()
        Me.tableAdapterTransDetailBarang = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.TRANSAKSI_DETAIL_BARANGTableAdapter()
        Me.tableAdapterTransDetailJasa = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.TRANSAKSI_DETAIL_JASATableAdapter()
        Label1 = New System.Windows.Forms.Label()
        bnTabel = New System.Windows.Forms.BindingNavigator(Me.components)
        BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Label9 = New System.Windows.Forms.Label()
        TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        CType(bnTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        bnTabel.SuspendLayout()
        CType(Me.bsTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpHeader1.SuspendLayout()
        Me.panelJmlByr.SuspendLayout()
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplFooter1.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.panelFooter2.SuspendLayout()
        Me.flpShortcutsList.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label1.Location = New System.Drawing.Point(308, 2)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 30)
        Label1.TabIndex = 0
        Label1.Text = "No. Nota"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnTabel
        '
        bnTabel.AddNewItem = Nothing
        bnTabel.BindingSource = Me.bsTabel
        bnTabel.CountItem = Me.BindingNavigatorCountItem
        bnTabel.CountItemFormat = "dari {0} item"
        bnTabel.DeleteItem = Nothing
        bnTabel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, Me.btnTambahBarang, Me.btnTambahJasa, Me.btnTambahDiskon, Me.btnAddReturnItem, ToolStripSeparator1, Me.btnEditItem, ToolStripSeparator2, Me.btnHapusItem})
        bnTabel.Location = New System.Drawing.Point(0, 0)
        bnTabel.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        bnTabel.MoveLastItem = Me.BindingNavigatorMoveLastItem
        bnTabel.MoveNextItem = Me.BindingNavigatorMoveNextItem
        bnTabel.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        bnTabel.Name = "bnTabel"
        bnTabel.PositionItem = Me.BindingNavigatorPositionItem
        bnTabel.Size = New System.Drawing.Size(584, 25)
        bnTabel.TabIndex = 0
        '
        'bsTabel
        '
        Me.bsTabel.DataMember = "KeranjangBelanja"
        Me.bsTabel.DataSource = Me.DataSetBelanja
        Me.bsTabel.Sort = "IsDiskonItem ASC, JenisSatuan ASC"
        '
        'DataSetBelanja
        '
        Me.DataSetBelanja.DataSetName = "DataSetBelanja"
        Me.DataSetBelanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(71, 22)
        Me.BindingNavigatorCountItem.Text = "dari {0} item"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTambahBarang.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_cargo
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.RightToLeftAutoMirrorImage = True
        Me.btnTambahBarang.Size = New System.Drawing.Size(23, 22)
        Me.btnTambahBarang.Text = "Tambah Item Barang"
        Me.btnTambahBarang.ToolTipText = "Tambah Item Barang (Ctrl+A)"
        '
        'btnTambahJasa
        '
        Me.btnTambahJasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTambahJasa.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_magicwand
        Me.btnTambahJasa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTambahJasa.Name = "btnTambahJasa"
        Me.btnTambahJasa.Size = New System.Drawing.Size(23, 22)
        Me.btnTambahJasa.Text = "Tambah Item Jasa"
        Me.btnTambahJasa.ToolTipText = "Tambah Item Jasa (Ctrl+Shift+A)"
        '
        'btnTambahDiskon
        '
        Me.btnTambahDiskon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTambahDiskon.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_scissors_alt
        Me.btnTambahDiskon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTambahDiskon.Name = "btnTambahDiskon"
        Me.btnTambahDiskon.Size = New System.Drawing.Size(23, 22)
        Me.btnTambahDiskon.Text = "Tambah Diskon"
        Me.btnTambahDiskon.ToolTipText = "Tambah Diskon (Ctrl+Shift+D)"
        '
        'btnAddReturnItem
        '
        Me.btnAddReturnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddReturnItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_roundabout
        Me.btnAddReturnItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddReturnItem.Name = "btnAddReturnItem"
        Me.btnAddReturnItem.Size = New System.Drawing.Size(23, 22)
        Me.btnAddReturnItem.Text = "Tambah Item Return"
        Me.btnAddReturnItem.ToolTipText = "Tambah Item Return (Ctrl+A)"
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEditItem
        '
        Me.btnEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditItem.Enabled = False
        Me.btnEditItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_edit
        Me.btnEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(23, 22)
        Me.btnEditItem.Text = "Edit Item"
        Me.btnEditItem.ToolTipText = "Edit Item (Ctrl+E)"
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnHapusItem
        '
        Me.btnHapusItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHapusItem.Enabled = False
        Me.btnHapusItem.Image = CType(resources.GetObject("btnHapusItem.Image"), System.Drawing.Image)
        Me.btnHapusItem.Name = "btnHapusItem"
        Me.btnHapusItem.RightToLeftAutoMirrorImage = True
        Me.btnHapusItem.Size = New System.Drawing.Size(23, 22)
        Me.btnHapusItem.Text = "Hapus Item"
        Me.btnHapusItem.ToolTipText = "Hapus Item (Ctrl+D or Del)"
        '
        'Label6
        '
        Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label6.Location = New System.Drawing.Point(4, 1)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(129, 31)
        Label6.TabIndex = 0
        Label6.Text = "SUB TOTAL"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label7.Location = New System.Drawing.Point(4, 33)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(129, 31)
        Label7.TabIndex = 1
        Label7.Text = "BAYAR"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label8.Location = New System.Drawing.Point(4, 65)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(129, 33)
        Label8.TabIndex = 2
        Label8.Text = "KEMBALI / SISA"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label2.Location = New System.Drawing.Point(308, 39)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(80, 30)
        Label2.TabIndex = 2
        Label2.Text = "Tanggal Pembuatan"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label3.Location = New System.Drawing.Point(5, 2)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 30)
        Label3.TabIndex = 4
        Label3.Text = "Pelanggan"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label4.Location = New System.Drawing.Point(5, 39)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(60, 30)
        Label4.TabIndex = 5
        Label4.Text = "Mekanik"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Label5.Location = New System.Drawing.Point(5, 76)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(60, 30)
        Label5.TabIndex = 6
        Label5.Text = "Kendaraan"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel1.Controls.Add(Me.tbPelanggan, 0, 0)
        TableLayoutPanel1.Controls.Add(Me.btnPelangganBrowse, 1, 0)
        TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel1.Location = New System.Drawing.Point(73, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(183, 29)
        TableLayoutPanel1.TabIndex = 7
        '
        'tbPelanggan
        '
        Me.tbPelanggan.BackColor = System.Drawing.Color.Yellow
        Me.tbPelanggan.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbPelanggan.Location = New System.Drawing.Point(3, 3)
        Me.tbPelanggan.Name = "tbPelanggan"
        Me.tbPelanggan.ReadOnly = True
        Me.tbPelanggan.Size = New System.Drawing.Size(145, 20)
        Me.tbPelanggan.TabIndex = 0
        Me.tbPelanggan.TabStop = False
        '
        'btnPelangganBrowse
        '
        Me.btnPelangganBrowse.AutoSize = True
        Me.btnPelangganBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPelangganBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPelangganBrowse.Location = New System.Drawing.Point(154, 3)
        Me.btnPelangganBrowse.Name = "btnPelangganBrowse"
        Me.btnPelangganBrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnPelangganBrowse.TabIndex = 1
        Me.btnPelangganBrowse.Text = "..."
        Me.btnPelangganBrowse.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel2.Controls.Add(Me.btnHapusMekanik, 0, 0)
        TableLayoutPanel2.Controls.Add(Me.tbMekanik, 0, 0)
        TableLayoutPanel2.Controls.Add(Me.btnMekanikBrowse, 2, 0)
        TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel2.Location = New System.Drawing.Point(73, 42)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.Size = New System.Drawing.Size(183, 29)
        TableLayoutPanel2.TabIndex = 8
        '
        'btnHapusMekanik
        '
        Me.btnHapusMekanik.ForeColor = System.Drawing.Color.Red
        Me.btnHapusMekanik.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHapusMekanik.Location = New System.Drawing.Point(122, 3)
        Me.btnHapusMekanik.Name = "btnHapusMekanik"
        Me.btnHapusMekanik.Size = New System.Drawing.Size(26, 23)
        Me.btnHapusMekanik.TabIndex = 2
        Me.btnHapusMekanik.Text = "X"
        Me.btnHapusMekanik.UseVisualStyleBackColor = True
        '
        'tbMekanik
        '
        Me.tbMekanik.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbMekanik.Location = New System.Drawing.Point(3, 3)
        Me.tbMekanik.Name = "tbMekanik"
        Me.tbMekanik.ReadOnly = True
        Me.tbMekanik.Size = New System.Drawing.Size(113, 20)
        Me.tbMekanik.TabIndex = 0
        Me.tbMekanik.TabStop = False
        '
        'btnMekanikBrowse
        '
        Me.btnMekanikBrowse.AutoSize = True
        Me.btnMekanikBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMekanikBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMekanikBrowse.Location = New System.Drawing.Point(154, 3)
        Me.btnMekanikBrowse.Name = "btnMekanikBrowse"
        Me.btnMekanikBrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnMekanikBrowse.TabIndex = 1
        Me.btnMekanikBrowse.Text = "..."
        Me.btnMekanikBrowse.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel3.Controls.Add(Me.btnHapusKendaraan, 0, 0)
        TableLayoutPanel3.Controls.Add(Me.tbKendaraan, 0, 0)
        TableLayoutPanel3.Controls.Add(Me.btnKendaraanBrowse, 2, 0)
        TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel3.Location = New System.Drawing.Point(73, 79)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel3.Size = New System.Drawing.Size(183, 29)
        TableLayoutPanel3.TabIndex = 9
        '
        'btnHapusKendaraan
        '
        Me.btnHapusKendaraan.ForeColor = System.Drawing.Color.Red
        Me.btnHapusKendaraan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHapusKendaraan.Location = New System.Drawing.Point(122, 3)
        Me.btnHapusKendaraan.Name = "btnHapusKendaraan"
        Me.btnHapusKendaraan.Size = New System.Drawing.Size(26, 23)
        Me.btnHapusKendaraan.TabIndex = 2
        Me.btnHapusKendaraan.Text = "X"
        Me.btnHapusKendaraan.UseVisualStyleBackColor = True
        '
        'tbKendaraan
        '
        Me.tbKendaraan.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbKendaraan.Location = New System.Drawing.Point(3, 3)
        Me.tbKendaraan.Name = "tbKendaraan"
        Me.tbKendaraan.ReadOnly = True
        Me.tbKendaraan.Size = New System.Drawing.Size(113, 20)
        Me.tbKendaraan.TabIndex = 0
        Me.tbKendaraan.TabStop = False
        '
        'btnKendaraanBrowse
        '
        Me.btnKendaraanBrowse.AutoSize = True
        Me.btnKendaraanBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnKendaraanBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnKendaraanBrowse.Location = New System.Drawing.Point(154, 3)
        Me.btnKendaraanBrowse.Name = "btnKendaraanBrowse"
        Me.btnKendaraanBrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnKendaraanBrowse.TabIndex = 1
        Me.btnKendaraanBrowse.Text = "..."
        Me.btnKendaraanBrowse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 3)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(66, 13)
        Label9.TabIndex = 0
        Label9.Text = "F9 = Simpan"
        '
        'TableLayoutPanel5
        '
        TableLayoutPanel5.AutoSize = True
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel5.Controls.Add(Me.tbNoNota, 0, 0)
        TableLayoutPanel5.Controls.Add(Me.btnNotaReset, 1, 0)
        TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel5.Location = New System.Drawing.Point(396, 5)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel5.Size = New System.Drawing.Size(183, 29)
        TableLayoutPanel5.TabIndex = 8
        '
        'tbNoNota
        '
        Me.tbNoNota.BackColor = System.Drawing.Color.Yellow
        Me.tbNoNota.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbNoNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbNoNota.Location = New System.Drawing.Point(3, 3)
        Me.tbNoNota.Name = "tbNoNota"
        Me.tbNoNota.ReadOnly = True
        Me.tbNoNota.Size = New System.Drawing.Size(126, 20)
        Me.tbNoNota.TabIndex = 0
        Me.tbNoNota.TabStop = False
        '
        'btnNotaReset
        '
        Me.btnNotaReset.AutoSize = True
        Me.btnNotaReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNotaReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNotaReset.Location = New System.Drawing.Point(135, 3)
        Me.btnNotaReset.Name = "btnNotaReset"
        Me.btnNotaReset.Size = New System.Drawing.Size(45, 23)
        Me.btnNotaReset.TabIndex = 1
        Me.btnNotaReset.Text = "Reset"
        Me.btnNotaReset.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(6, 16)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(69, 13)
        Label10.TabIndex = 1
        Label10.Text = "END = Bayar"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(6, 29)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(78, 13)
        Label11.TabIndex = 2
        Label11.Text = "Ctrl+Q = Keluar"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(90, 16)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(138, 13)
        Label12.TabIndex = 3
        Label12.Text = "Ctrl+Shift+A = Tambah Jasa"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(90, 3)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(160, 13)
        Label13.TabIndex = 4
        Label13.Text = "Ctrl+A = Tambah Barang\Return"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(90, 29)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(150, 13)
        Label14.TabIndex = 5
        Label14.Text = "Ctrl+Shift+D = Tambah Diskon"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(256, 3)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(88, 13)
        Label15.TabIndex = 6
        Label15.Text = "Ctrl+E = Edit Item"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(256, 16)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(89, 13)
        Label16.TabIndex = 7
        Label16.Text = "Del = Hapus Item"
        '
        'lblJmlByrSymbol
        '
        Me.lblJmlByrSymbol.AutoSize = True
        Me.lblJmlByrSymbol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJmlByrSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJmlByrSymbol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJmlByrSymbol.Location = New System.Drawing.Point(140, 33)
        Me.lblJmlByrSymbol.Name = "lblJmlByrSymbol"
        Me.lblJmlByrSymbol.Size = New System.Drawing.Size(37, 31)
        Me.lblJmlByrSymbol.TabIndex = 6
        Me.lblJmlByrSymbol.Text = "Rp."
        Me.lblJmlByrSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTabel
        '
        Me.dgvTabel.AllowUserToAddRows = False
        Me.dgvTabel.AllowUserToDeleteRows = False
        Me.dgvTabel.AutoGenerateColumns = False
        Me.dgvTabel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaDataGridViewTextBoxColumn, Me.JenisSatuanDataGridViewTextBoxColumn, Me.KuantitasDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.TotalHarga, Me.IsDiskonItem, Me.Kode, Me.DataJSON})
        Me.dgvTabel.DataSource = Me.bsTabel
        Me.dgvTabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabel.Location = New System.Drawing.Point(0, 25)
        Me.dgvTabel.MultiSelect = False
        Me.dgvTabel.Name = "dgvTabel"
        Me.dgvTabel.ReadOnly = True
        Me.dgvTabel.RowHeadersVisible = False
        Me.dgvTabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabel.Size = New System.Drawing.Size(584, 119)
        Me.dgvTabel.TabIndex = 4
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama Item"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JenisSatuanDataGridViewTextBoxColumn
        '
        Me.JenisSatuanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.JenisSatuanDataGridViewTextBoxColumn.DataPropertyName = "JenisSatuan"
        Me.JenisSatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.JenisSatuanDataGridViewTextBoxColumn.Name = "JenisSatuanDataGridViewTextBoxColumn"
        Me.JenisSatuanDataGridViewTextBoxColumn.ReadOnly = True
        Me.JenisSatuanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.JenisSatuanDataGridViewTextBoxColumn.Width = 47
        '
        'KuantitasDataGridViewTextBoxColumn
        '
        Me.KuantitasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KuantitasDataGridViewTextBoxColumn.DataPropertyName = "Kuantitas"
        DataGridViewCellStyle1.Format = "N2"
        Me.KuantitasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.KuantitasDataGridViewTextBoxColumn.HeaderText = "Qty."
        Me.KuantitasDataGridViewTextBoxColumn.Name = "KuantitasDataGridViewTextBoxColumn"
        Me.KuantitasDataGridViewTextBoxColumn.ReadOnly = True
        Me.KuantitasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.KuantitasDataGridViewTextBoxColumn.Width = 32
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
        DataGridViewCellStyle2.Format = "C"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.HargaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HargaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HargaDataGridViewTextBoxColumn.Width = 42
        '
        'TotalHarga
        '
        Me.TotalHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TotalHarga.DataPropertyName = "TotalHarga"
        DataGridViewCellStyle3.Format = "C"
        Me.TotalHarga.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalHarga.HeaderText = "TOTAL"
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.ReadOnly = True
        Me.TotalHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TotalHarga.Width = 48
        '
        'IsDiskonItem
        '
        Me.IsDiskonItem.DataPropertyName = "IsDiskonItem"
        Me.IsDiskonItem.HeaderText = "IsDiskonItem"
        Me.IsDiskonItem.Name = "IsDiskonItem"
        Me.IsDiskonItem.ReadOnly = True
        Me.IsDiskonItem.Visible = False
        '
        'Kode
        '
        Me.Kode.DataPropertyName = "Kode"
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        Me.Kode.ReadOnly = True
        Me.Kode.Visible = False
        '
        'DataJSON
        '
        Me.DataJSON.DataPropertyName = "DataJSON"
        Me.DataJSON.HeaderText = "DataJSON"
        Me.DataJSON.Name = "DataJSON"
        Me.DataJSON.ReadOnly = True
        Me.DataJSON.Visible = False
        '
        'tlpHeader1
        '
        Me.tlpHeader1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpHeader1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpHeader1.ColumnCount = 3
        Me.tlpHeader1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHeader1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHeader1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHeader1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHeader1.Controls.Add(Label6, 0, 0)
        Me.tlpHeader1.Controls.Add(Label7, 0, 1)
        Me.tlpHeader1.Controls.Add(Label8, 0, 2)
        Me.tlpHeader1.Controls.Add(Me.lblKembalian, 2, 2)
        Me.tlpHeader1.Controls.Add(Me.lblTotalBayar, 2, 0)
        Me.tlpHeader1.Controls.Add(Me.lblJmlByrSymbol, 1, 1)
        Me.tlpHeader1.Controls.Add(Me.panelJmlByr, 2, 1)
        Me.tlpHeader1.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeader1.Name = "tlpHeader1"
        Me.tlpHeader1.RowCount = 3
        Me.tlpHeader1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpHeader1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpHeader1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpHeader1.Size = New System.Drawing.Size(584, 99)
        Me.tlpHeader1.TabIndex = 10
        '
        'lblKembalian
        '
        Me.lblKembalian.BackColor = System.Drawing.SystemColors.Window
        Me.lblKembalian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKembalian.Location = New System.Drawing.Point(184, 65)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(396, 33)
        Me.lblKembalian.TabIndex = 9
        Me.lblKembalian.Text = "0"
        Me.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalBayar
        '
        Me.lblTotalBayar.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalBayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBayar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalBayar.Location = New System.Drawing.Point(184, 1)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Size = New System.Drawing.Size(396, 31)
        Me.lblTotalBayar.TabIndex = 5
        Me.lblTotalBayar.Text = "0"
        Me.lblTotalBayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelJmlByr
        '
        Me.panelJmlByr.Controls.Add(Me.numBayar)
        Me.panelJmlByr.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelJmlByr.Location = New System.Drawing.Point(184, 36)
        Me.panelJmlByr.Name = "panelJmlByr"
        Me.panelJmlByr.Size = New System.Drawing.Size(396, 25)
        Me.panelJmlByr.TabIndex = 0
        '
        'numBayar
        '
        Me.numBayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numBayar.Location = New System.Drawing.Point(0, 1)
        Me.numBayar.Maximum = New Decimal(New Integer() {-1, 2147483647, 0, 262144})
        Me.numBayar.Name = "numBayar"
        Me.numBayar.Size = New System.Drawing.Size(393, 26)
        Me.numBayar.TabIndex = 1
        Me.numBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBayar.ThousandsSeparator = True
        Me.numBayar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_calculator
        Me.btnProses.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProses.Location = New System.Drawing.Point(481, 4)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(100, 50)
        Me.btnProses.TabIndex = 99999
        Me.btnProses.Text = "&SIMPAN"
        Me.btnProses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnKeterangan
        '
        Me.btnKeterangan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKeterangan.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_note
        Me.btnKeterangan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnKeterangan.Location = New System.Drawing.Point(375, 4)
        Me.btnKeterangan.Name = "btnKeterangan"
        Me.btnKeterangan.Size = New System.Drawing.Size(100, 50)
        Me.btnKeterangan.TabIndex = 99998
        Me.btnKeterangan.Text = "Ke&terangan Transaksi"
        Me.btnKeterangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKeterangan.UseVisualStyleBackColor = True
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(584, 386)
        '
        'tplFooter1
        '
        Me.tplFooter1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tplFooter1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.tplFooter1.ColumnCount = 5
        Me.tplFooter1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tplFooter1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tplFooter1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tplFooter1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tplFooter1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tplFooter1.Controls.Add(Label3, 0, 0)
        Me.tplFooter1.Controls.Add(TableLayoutPanel1, 1, 0)
        Me.tplFooter1.Controls.Add(Label4, 0, 1)
        Me.tplFooter1.Controls.Add(TableLayoutPanel2, 1, 1)
        Me.tplFooter1.Controls.Add(Label5, 0, 2)
        Me.tplFooter1.Controls.Add(TableLayoutPanel3, 1, 2)
        Me.tplFooter1.Controls.Add(Me.tbLunas, 4, 2)
        Me.tplFooter1.Controls.Add(Me.cbLunas, 3, 2)
        Me.tplFooter1.Controls.Add(Label2, 3, 1)
        Me.tplFooter1.Controls.Add(TableLayoutPanel5, 4, 0)
        Me.tplFooter1.Controls.Add(Me.tbTglBuat, 4, 1)
        Me.tplFooter1.Controls.Add(Label1, 3, 0)
        Me.tplFooter1.Location = New System.Drawing.Point(0, 0)
        Me.tplFooter1.Name = "tplFooter1"
        Me.tplFooter1.RowCount = 3
        Me.tplFooter1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplFooter1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplFooter1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplFooter1.Size = New System.Drawing.Size(584, 108)
        Me.tplFooter1.TabIndex = 1
        '
        'tbLunas
        '
        Me.tbLunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbLunas.Location = New System.Drawing.Point(396, 79)
        Me.tbLunas.Name = "tbLunas"
        Me.tbLunas.ReadOnly = True
        Me.tbLunas.Size = New System.Drawing.Size(183, 20)
        Me.tbLunas.TabIndex = 0
        Me.tbLunas.TabStop = False
        Me.tbLunas.Text = "DD/MM/YYYY"
        '
        'cbLunas
        '
        Me.cbLunas.AutoCheck = False
        Me.cbLunas.AutoSize = True
        Me.cbLunas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbLunas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbLunas.Location = New System.Drawing.Point(308, 79)
        Me.cbLunas.Name = "cbLunas"
        Me.cbLunas.Size = New System.Drawing.Size(80, 29)
        Me.cbLunas.TabIndex = 0
        Me.cbLunas.TabStop = False
        Me.cbLunas.Text = "Lunas ?"
        Me.cbLunas.UseVisualStyleBackColor = True
        '
        'tbTglBuat
        '
        Me.tbTglBuat.BackColor = System.Drawing.Color.Yellow
        Me.tbTglBuat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTglBuat.Location = New System.Drawing.Point(396, 42)
        Me.tbTglBuat.Name = "tbTglBuat"
        Me.tbTglBuat.ReadOnly = True
        Me.tbTglBuat.Size = New System.Drawing.Size(183, 20)
        Me.tbTglBuat.TabIndex = 0
        Me.tbTglBuat.TabStop = False
        '
        'timerRefreshTgl
        '
        Me.timerRefreshTgl.Interval = 30000
        '
        'panelHeader
        '
        Me.panelHeader.AutoSize = True
        Me.panelHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelHeader.Controls.Add(Me.tlpHeader1)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 25)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(584, 102)
        Me.panelHeader.TabIndex = 2
        '
        'panelFooter
        '
        Me.panelFooter.Controls.Add(Me.tplFooter1)
        Me.panelFooter.Controls.Add(Me.panelFooter2)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 271)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(584, 167)
        Me.panelFooter.TabIndex = 3
        '
        'panelFooter2
        '
        Me.panelFooter2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelFooter2.Controls.Add(Me.btnProses)
        Me.panelFooter2.Controls.Add(Me.btnKeterangan)
        Me.panelFooter2.Controls.Add(Me.flpShortcutsList)
        Me.panelFooter2.Location = New System.Drawing.Point(0, 109)
        Me.panelFooter2.Name = "panelFooter2"
        Me.panelFooter2.Size = New System.Drawing.Size(584, 57)
        Me.panelFooter2.TabIndex = 100000
        '
        'flpShortcutsList
        '
        Me.flpShortcutsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpShortcutsList.BackColor = System.Drawing.Color.Teal
        Me.flpShortcutsList.Controls.Add(Label9)
        Me.flpShortcutsList.Controls.Add(Label10)
        Me.flpShortcutsList.Controls.Add(Label11)
        Me.flpShortcutsList.Controls.Add(Label13)
        Me.flpShortcutsList.Controls.Add(Label12)
        Me.flpShortcutsList.Controls.Add(Label14)
        Me.flpShortcutsList.Controls.Add(Label15)
        Me.flpShortcutsList.Controls.Add(Label16)
        Me.flpShortcutsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpShortcutsList.ForeColor = System.Drawing.Color.White
        Me.flpShortcutsList.Location = New System.Drawing.Point(0, 0)
        Me.flpShortcutsList.Name = "flpShortcutsList"
        Me.flpShortcutsList.Padding = New System.Windows.Forms.Padding(3)
        Me.flpShortcutsList.Size = New System.Drawing.Size(369, 57)
        Me.flpShortcutsList.TabIndex = 0
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.dgvTabel)
        Me.panelContent.Controls.Add(bnTabel)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 127)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(584, 144)
        Me.panelContent.TabIndex = 1
        '
        'tableAdapterTrans
        '
        Me.tableAdapterTrans.ClearBeforeFill = True
        '
        'tableAdapterPelanggan
        '
        Me.tableAdapterPelanggan.ClearBeforeFill = True
        '
        'tableAdapterMekanik
        '
        Me.tableAdapterMekanik.ClearBeforeFill = True
        '
        'tableAdapterKendaraan
        '
        Me.tableAdapterKendaraan.ClearBeforeFill = True
        '
        'tableAdapterTransDetailBarang
        '
        Me.tableAdapterTransDetailBarang.ClearBeforeFill = True
        '
        'tableAdapterTransDetailJasa
        '
        Me.tableAdapterTransDetailJasa.ClearBeforeFill = True
        '
        'FormTransaksiDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 438)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelFooter)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER, FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_KASIR}
        Me.KeyPreview = True
        Me.Name = "FormTransaksiDetail"
        Me.Text = "Form Title"
        Me.TipeVerifikasiIzin = FP_BENGKEL_MOTOR.TipeVerifikasiPeranUser.ROLE_VERIFY_AT_LEAST_ONE
        Me.Controls.SetChildIndex(Me.panelFooter, 0)
        Me.Controls.SetChildIndex(Me.panelHeader, 0)
        Me.Controls.SetChildIndex(Me.panelContent, 0)
        CType(bnTabel, System.ComponentModel.ISupportInitialize).EndInit()
        bnTabel.ResumeLayout(False)
        bnTabel.PerformLayout()
        CType(Me.bsTabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpHeader1.ResumeLayout(False)
        Me.tlpHeader1.PerformLayout()
        Me.panelJmlByr.ResumeLayout(False)
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplFooter1.ResumeLayout(False)
        Me.tplFooter1.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter2.ResumeLayout(False)
        Me.flpShortcutsList.ResumeLayout(False)
        Me.flpShortcutsList.PerformLayout()
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents tbNoNota As TextBox
    Friend WithEvents tbTglBuat As TextBox
    Private WithEvents tableAdapterTrans As DataSetBengkelTableAdapters.TRANSAKSITableAdapter
    Friend WithEvents tbPelanggan As TextBox
    Friend WithEvents tbMekanik As TextBox
    Friend WithEvents tbKendaraan As TextBox
    Friend WithEvents numBayar As NumericUpDown
    Friend WithEvents cbLunas As CheckBox
    Friend WithEvents tbLunas As TextBox
    Private WithEvents bsTabel As BindingSource
    Private WithEvents timerRefreshTgl As System.Windows.Forms.Timer
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents DataSetBelanja As DataSetBelanja
    Private WithEvents tableAdapterMekanik As DataSetBengkelTableAdapters.MONTIRTableAdapter
    Private WithEvents tableAdapterKendaraan As DataSetBengkelTableAdapters.KENDARAANTableAdapter
    Private WithEvents tableAdapterPelanggan As DataSetBengkelTableAdapters.PELANGGANTableAdapter
    Private WithEvents lblKembalian As Label
    Private WithEvents lblTotalBayar As Label
    Private WithEvents btnHapusItem As ToolStripButton
    Private WithEvents btnEditItem As ToolStripButton
    Private WithEvents btnTambahBarang As ToolStripButton
    Private WithEvents btnPelangganBrowse As Button
    Private WithEvents btnMekanikBrowse As Button
    Private WithEvents btnKendaraanBrowse As Button
    Private WithEvents btnTambahJasa As ToolStripButton
    Private WithEvents btnHapusMekanik As Button
    Private WithEvents btnHapusKendaraan As Button
    Private WithEvents btnAddReturnItem As ToolStripButton
    Private WithEvents btnTambahDiskon As ToolStripButton
    Private WithEvents lblJmlByrSymbol As Label
    Private WithEvents panelJmlByr As Panel
    Private WithEvents tlpHeader1 As TableLayoutPanel
    Private WithEvents panelHeader As Panel
    Private WithEvents panelFooter As Panel
    Private WithEvents panelContent As Panel
    Private WithEvents flpShortcutsList As FlowLayoutPanel
    Private WithEvents dgvTabel As DataGridView
    Private WithEvents tplFooter1 As TableLayoutPanel
    Private WithEvents btnProses As Button
    Private WithEvents btnKeterangan As Button
    Private WithEvents btnNotaReset As Button
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Private WithEvents tableAdapterTransDetailBarang As DataSetBengkelTableAdapters.TRANSAKSI_DETAIL_BARANGTableAdapter
    Private WithEvents tableAdapterTransDetailJasa As DataSetBengkelTableAdapters.TRANSAKSI_DETAIL_JASATableAdapter
    Private WithEvents panelFooter2 As Panel
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisSatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KuantitasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalHarga As DataGridViewTextBoxColumn
    Friend WithEvents IsDiskonItem As DataGridViewCheckBoxColumn
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents DataJSON As DataGridViewTextBoxColumn
End Class

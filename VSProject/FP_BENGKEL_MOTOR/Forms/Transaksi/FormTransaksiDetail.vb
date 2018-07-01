Public Enum TransaksiDetailMode
    MODE_INSERT = 1
    MODE_INSERT_RETURN
    MODE_EDIT
    MODE_VIEW
End Enum

Public NotInheritable Class FormTransaksiDetail
    <System.ComponentModel.Description("Bernilai TRUE jika form transaksi berada dalam mode insert/tambah data.")>
    Public ReadOnly Property ModeTrans As TransaksiDetailMode = TransaksiDetailMode.MODE_INSERT

    <System.ComponentModel.Description("Pelanggan yang terdapat dalam transaksi ini.")>
    Public ReadOnly Property Pelanggan As New DataSetBengkel.PELANGGANDataTable()
    Private Sub DataPelangganBerubah()
        '-- Update textbox pelanggan
        If _Pelanggan Is Nothing OrElse _Pelanggan.Rows.Count <= 0 Then
            tbPelanggan.Text = "(KOSONG)"
        Else
            tbPelanggan.Text = _Pelanggan.Rows(0).Item(_Pelanggan.namaColumn) & " [" & _Pelanggan.Rows(0).Item(_Pelanggan.kodeColumn) & "]"
        End If
    End Sub

    <System.ComponentModel.Description("Mekanik yang terdapat dalam transaksi ini.")>
    Public ReadOnly Property Mekanik As DataSetBengkel.MONTIRDataTable = Nothing
    Private Sub DataMekanikBerubah()
        '-- Update teksboks mekanik/montir
        If _Mekanik Is Nothing OrElse _Mekanik.Rows.Count <= 0 Then
            tbMekanik.Text = "(KOSONG)"
        Else
            tbMekanik.Text = _Mekanik.Rows(0).Item(_Mekanik.namaColumn) & " [" & _Mekanik.Rows(0).Item(_Mekanik.kodeColumn) & "]"
        End If
    End Sub

    <System.ComponentModel.Description("Kendaraan Pelanggan yang terdapat dalam transaksi ini.")>
    Public ReadOnly Property Kendaraan As DataSetBengkel.KENDARAANDataTable = Nothing
    Private Sub DataKendaraanBerubah()
        '-- Update teksboks mekanik/montir
        If _Kendaraan Is Nothing OrElse _Kendaraan.Rows.Count <= 0 Then
            tbKendaraan.Text = "(KOSONG)"
        Else
            tbKendaraan.Text = _Kendaraan.Rows(0).Item(_Kendaraan.nopolColumn) & " - " & _Kendaraan.Rows(0).Item(_Kendaraan.namaColumn)
        End If
    End Sub

    <System.ComponentModel.Description("Total tagihan transaksi.")>
    Public ReadOnly Property TotalTagihan As Decimal

    <System.ComponentModel.Description("Total kembalian transaksi.")>
    Public ReadOnly Property TotalKembalian As Decimal

    <System.ComponentModel.Description("Keterangan transaksi.")>
    Public Property Keterangan As String = String.Empty

    <System.ComponentModel.Description("Nomor faktur transaksi asal untuk referensi faktur return.")>
    Public Property RefFakturReturn As String = String.Empty

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Sub New(noNota As String, Optional mode As TransaksiDetailMode = TransaksiDetailMode.MODE_EDIT)
        MyBase.New()
        InitializeComponent()
        ModeTrans = mode

        If mode = TransaksiDetailMode.MODE_INSERT_RETURN Then
            RefFakturReturn = noNota
        Else
            tbNoNota.Text = noNota
        End If
    End Sub

    Private Sub SetAvailableInsertComponents(switch As Boolean)
        btnNotaReset.Visible = switch
        btnPelangganBrowse.Visible = switch
        btnMekanikBrowse.Visible = switch
        btnKendaraanBrowse.Visible = switch
        btnHapusMekanik.Visible = switch
        btnHapusKendaraan.Visible = switch

        tplHeader.Enabled = switch
    End Sub

    Private Sub SetAvailableShopCartComponents(switch As Boolean)
        btnTambahBarang.Enabled = switch
        btnTambahJasa.Enabled = switch
        btnTambahDiskon.Enabled = switch
        btnHapusItem.Enabled = switch

        btnTambahBarang.Visible = switch
        btnTambahJasa.Visible = switch
        btnTambahDiskon.Visible = switch
        btnHapusItem.Visible = switch

        'DataGridView1.ReadOnly = Not switch
    End Sub

    Private Sub SetAvailableReturnComponents(switch As Boolean)
        btnAddReturnItem.Enabled = switch
        btnAddReturnItem.Visible = switch
    End Sub

    Private Sub SetAvailableSubmitComponents(switch As Boolean)
        panelContent.Enabled = switch
        btnProses.Enabled = switch
    End Sub

    Friend Sub SelectBaris(ByVal indeks As Integer)
        If DataGridView1.Rows.Count <= 0 Then
            Exit Sub
        End If

        If indeks >= DataGridView1.Rows.Count Then
            indeks = DataGridView1.Rows.Count - 1
        End If

        With DataGridView1
            .ClearSelection()

            Dim objekBaris As DataGridViewRow = .Rows(indeks)
            objekBaris.Selected = True
            .CurrentCell = objekBaris.Cells(0)

            .FirstDisplayedScrollingRowIndex = indeks
            .FirstDisplayedScrollingColumnIndex = 0
        End With
    End Sub

    Private Sub GenerateTransID()
        tbNoNota.Text = tableAdapterTrans.GetKodeBaru()
    End Sub

    Private Function BuatDialogItemDiskon() As DialogTransaksiItemBelanjaDiskon
        Dim objDlg As New DialogTransaksiItemBelanjaDiskon()
        objDlg.SourceTable = Me.DataSetBelanja.KeranjangBelanja
        objDlg.TableSort = Me.bsTabel.Sort

        Return objDlg
    End Function

    Private Sub MunculkanDialogTambahItemBelanja(objDialog As DialogTransaksiItemBelanja)
        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            Try
                GabungDataTabel(objDialog.Output)

                SelectBaris(Integer.MaxValue)
                DataGridView1.ClearSelection()
            Catch ex As DataException
                ShowErrorMessageBox(Nothing, "GAGAL menambahkan item !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            '-- update diskon
            If TryCast(objDialog, DialogTransaksiItemBelanjaDiskon) Is Nothing Then
                UpdateItemDiskon()
                DataGridView1.ClearSelection()
            End If
        End If
    End Sub

    Private Sub MunculkanDialogEditItemBelanja(objDialog As DialogTransaksiItemBelanja, row As DataGridViewRow)
        objDialog.EditThis(CType(row.DataBoundItem, DataRowView).Row)
        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            Try
                GabungDataTabel(objDialog.Output)
            Catch ex As DataException
                ShowErrorMessageBox(Nothing, "GAGAL mengubah item !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            '-- update diskon
            If TryCast(objDialog, DialogTransaksiItemBelanjaDiskon) Is Nothing Then
                UpdateItemDiskon()
            End If
        End If
    End Sub

    Private Sub GabungDataTabel(table As DataTable)
        Try
            DataSetBelanja.KeranjangBelanja.Merge(table, False, MissingSchemaAction.Error)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub UpdateItemDiskon()
        '-- Update dulu tabel keranjang belanja
        DataSetBelanja.KeranjangBelanja.AcceptChanges()

        '-- Catat posisi baris terakhir yg terselect di datagridview 
        Dim lastSelectedIndex As Integer = -1
        If DataGridView1.SelectedRows.Count > 0 Then
            lastSelectedIndex = DataGridView1.SelectedRows(0).Index
        End If

        '-- Ambil smua baris item diskon
        Dim rowsDiskon As New ArrayList(DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = TRUE", "Kode ASC"))
        For Each row As DataSetBelanja.KeranjangBelanjaRow In rowsDiskon
            With row
                '-- cari item diskon yg rusak
                Dim kodePJRef As String = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataSetBelanja.DetailItemDiskonDataTable)(.DataJSON).Rows(0).Item("Kode")
                If DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = FALSE AND " & String.Format("Kode = '{0}'", kodePJRef)).Length <= 0 Then
                    '-- hapus item diskon ini
                    DataSetBelanja.KeranjangBelanja.RemoveKeranjangBelanjaRow(row)
                    '-- lanjut ke item selanjutnya
                    Continue For
                End If

                '-- update total diskon
                Using obDlgDisc As DialogTransaksiItemBelanjaDiskon = BuatDialogItemDiskon()
                    '-- update pakai dialog itemdiskon dan apply secara otomatis
                    obDlgDisc.EditThis(row)
                    obDlgDisc.WindowState = FormWindowState.Minimized
                    obDlgDisc.SuspendLayout()
                    obDlgDisc.Size = New Size(0, 0)
                    obDlgDisc.Show()
                    obDlgDisc.OK_Button.PerformClick()
                    Try
                        GabungDataTabel(obDlgDisc.Output)
                    Catch ex As Exception
                        ProsesException(ex)
                        '-- hapus item diskon ini karena bermasalah
                        DataSetBelanja.KeranjangBelanja.RemoveKeranjangBelanjaRow(row)
                        '-- lanjut ke item selanjutnya
                        Continue For
                    End Try
                End Using
            End With
        Next

        '-- Update lagi tabel keranjang belanja
        DataSetBelanja.KeranjangBelanja.AcceptChanges()

        '-- Kembalikan posisi baris terpilih di datagridview
        If lastSelectedIndex >= 0 Then
            SelectBaris(lastSelectedIndex)
        End If
    End Sub

    Private Sub HitungTotalTagihan()
        Dim hasil As Object = DataSetBelanja.KeranjangBelanja.Compute("SUM(TotalHarga)", "")
        If IsNumeric(hasil) Then
            _TotalTagihan = hasil
        Else
            _TotalTagihan = 0
        End If

        lblTotalBayar.Text = String.Format("{0:C}", _TotalTagihan)

        HitungKembalian()
    End Sub

    Private Sub HitungKembalian()
        _TotalKembalian = numBayar.Value - _TotalTagihan

        lblKembalian.Text = String.Format("{0:C}", _TotalKembalian)

        CekKelunasan()
    End Sub

    Private Sub CekKelunasan()
        If ModeTrans = TransaksiDetailMode.MODE_VIEW Then
            Exit Sub
        End If

        If _TotalKembalian < 0 Then
            cbLunas.Checked = False
            tbLunas.Text = "(BELUM LUNAS)"
        Else
            cbLunas.Checked = True
            Dim tgl As Date = System.DateTime.Now
            tbLunas.Text = tgl.ToShortDateString & " " & tgl.ToShortTimeString
        End If
    End Sub

    Private Sub TambahTransaksiBaru()
        SetAvailableSubmitComponents(False)

        Dim noNota = tbNoNota.Text, kodePlg = String.Empty, kodeMk, noPol
        Dim dateBuat, dateLunas As Object
        Dim bayarKurang, persenDiskon As Decimal

        If _TotalKembalian < 0 Then
            bayarKurang = Math.Abs(_TotalKembalian)
        End If

        Dim hasil As Integer
        Try
            If _Pelanggan Is Nothing OrElse _Pelanggan.Rows.Count <= 0 Then
                Throw New ArgumentException("Data pelanggan kosong atau tidak valid.", "_Pelanggan")
            End If
            kodePlg = _Pelanggan.Rows(0).Item("kode")

            If _Mekanik IsNot Nothing AndAlso _Mekanik.Rows.Count > 0 Then
                kodeMk = _Mekanik.Rows(0).Item("kode")
            End If

            If _Kendaraan IsNot Nothing AndAlso _Kendaraan.Rows.Count > 0 Then
                noPol = _Kendaraan.Rows(0).Item("nopol")
            End If

            If DateTime.TryParse(tbTglBuat.Text, dateBuat) = False Then
                Throw New FormatException("Gagal parsing tanggal pembuatan transaksi.")
            End If
            If DateTime.TryParse(tbLunas.Text, dateLunas) = False Then
                dateLunas = Nothing
            End If

            '-- Buat transaksi induk
            hasil = tableAdapterTrans.RowInsert(noNota,
                                                kodePlg,
                                                kodeMk,
                                                noPol,
                                                dateBuat,
                                                dateLunas,
                                                bayarKurang,
                                                Keterangan)
            If hasil <= 0 Then
                Throw New DataException("Gagal membuat data transaksi induk baru.")
            End If

            Dim rows As DataSetBelanja.KeranjangBelanjaRow()
            '-- Buat transaksi detail barang
            rows = DataSetBelanja.KeranjangBelanja.Select("Kode LIKE " & String.Format("'{0}%'", Pengodean.Tabel.Barang))
            For Each row As DataSetBelanja.KeranjangBelanjaRow In rows
                hasil = 0
                With row
                    Dim rowsDiskon As DataSetBelanja.KeranjangBelanjaRow() = DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = TRUE AND Kode = " & String.Format("'{0}-{1}'", Pengodean.Tabel.ItemBelanjaDiskon, .Kode))
                    If rowsDiskon.Length > 0 Then
                        persenDiskon = rowsDiskon(0).Kuantitas
                    End If

                    hasil = tableAdapterTransDetailBarang.RowInsert(noNota, .Kode, .Harga, .Kuantitas, persenDiskon)
                    If hasil <= 0 Then
                        Throw New DataException("Gagal mengisi data detail transaksi BARANG.")
                    End If
                End With
            Next

            '-- Buat transaksi detail jasa
            rows = DataSetBelanja.KeranjangBelanja.Select("Kode LIKE " & String.Format("'{0}%'", Pengodean.Tabel.Jasa))
            For Each row As DataSetBelanja.KeranjangBelanjaRow In rows
                hasil = 0
                With row
                    Dim rowsDiskon As DataSetBelanja.KeranjangBelanjaRow() = DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = TRUE AND Kode = " & String.Format("'{0}-{1}'", Pengodean.Tabel.ItemBelanjaDiskon, .Kode))
                    If rowsDiskon.Length > 0 Then
                        persenDiskon = rowsDiskon(0).Kuantitas
                    End If

                    Dim tglMulai As DateTime = Nothing, tglSelesai As DateTime = Nothing
                    Dim dataJasa = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataSetBelanja.DetailItemJasaDataTable)(.DataJSON)
                    If dataJasa.Rows.Count > 0 Then
                        With dataJasa.Rows(0)
                            tglMulai = .Item("tgl_mulai")
                            tglSelesai = .Item("tgl_selesai")
                        End With
                    End If

                    hasil = tableAdapterTransDetailJasa.RowInsert(noNota, .Kode, .TotalHarga, tglMulai, tglSelesai, persenDiskon)
                    If hasil <= 0 Then
                        Throw New DataException("Gagal mengisi data detail transaksi JASA.")
                    End If
                End With
            Next
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        End Try

        If hasil > 0 Then
            ShowInformationMessageBox(Me, "Transaksi BERHASIL di simpan")
            Me.Close()
        Else
            ShowErrorMessageBox(Me, "Transaksi GAGAL di simpan")
            SetAvailableSubmitComponents(True)
        End If
    End Sub

    Private Sub IsiKeranjangBelanjaDariNomorNota(noNota As String)
        Try
            Me.DataSetBelanja.KeranjangBelanja.Clear()

            '--Isi barang
            Using dataTable = tableAdapterTransDetailBarang.GetDataByNoNota(noNota)
                For Each row As DataSetBengkel.TRANSAKSI_DETAIL_BARANGRow In dataTable.Rows
                    With row
                        Dim namaItem As String = .kode_brg
                        Using tableAdapter As New DataSetBengkelTableAdapters.BARANGTableAdapter()
                            With tableAdapter.GetDataByKode(.kode_brg)
                                If .Rows.Count > 0 Then
                                    namaItem = .Rows(0).Item("nama")
                                End If
                            End With
                        End Using

                        Dim totalHarga As Decimal = (.jumlah * .harga_brg)
                        Me.DataSetBelanja.KeranjangBelanja.AddKeranjangBelanjaRow(.kode_brg, namaItem, "PCS", .jumlah, .harga_brg, totalHarga, False, String.Empty)

                        If .diskon > 0 Then
                            Using obDlgDisc As DialogTransaksiItemBelanjaDiskon = BuatDialogItemDiskon()
                                '-- update pakai dialog itemdiskon dan apply secara otomatis
                                obDlgDisc.WindowState = FormWindowState.Minimized
                                obDlgDisc.SuspendLayout()
                                obDlgDisc.Size = New Size(0, 0)
                                obDlgDisc.Show()
                                obDlgDisc.tbKunci.Text = .kode_brg
                                obDlgDisc.ProsesFilter()
                                obDlgDisc.numDiscPercentage.Value = .diskon
                                obDlgDisc.OK_Button.PerformClick()
                                GabungDataTabel(obDlgDisc.Output)
                            End Using
                        End If
                    End With
                Next
            End Using

            '--Isi Jasa
            Using dataTable = tableAdapterTransDetailJasa.GetDataByNoNota(noNota)
                For Each row As DataSetBengkel.TRANSAKSI_DETAIL_JASARow In dataTable.Rows
                    With row
                        Dim namaItem As String = .kode_jasa
                        Dim tglMulai As Object = .tgl_mulai
                        Dim tglSelesai As Object = .tgl_selesai
                        Dim totalHarga As Decimal = .harga_jasa

                        If tglMulai IsNot Nothing And tglSelesai IsNot Nothing Then
                            Using tableAdapter As New DataSetBengkelTableAdapters.JASATableAdapter()
                                With tableAdapter.GetDataByKode(.kode_jasa)
                                    If .Rows.Count > 0 Then
                                        namaItem = .Rows(0).Item("nama")
                                    End If
                                End With
                            End Using
                        End If

                        Me.DataSetBelanja.KeranjangBelanja.AddKeranjangBelanjaRow(.kode_jasa, namaItem, String.Empty, 0, totalHarga, totalHarga, False, String.Empty)

                        If .diskon > 0 Then
                            Using obDlgDisc As DialogTransaksiItemBelanjaDiskon = BuatDialogItemDiskon()
                                '-- update pakai dialog itemdiskon dan apply secara otomatis
                                obDlgDisc.WindowState = FormWindowState.Minimized
                                obDlgDisc.SuspendLayout()
                                obDlgDisc.Size = New Size(0, 0)
                                obDlgDisc.Show()
                                obDlgDisc.tbKunci.Text = .kode_jasa
                                obDlgDisc.ProsesFilter()
                                obDlgDisc.numDiscPercentage.Value = .diskon
                                obDlgDisc.OK_Button.PerformClick()
                                GabungDataTabel(obDlgDisc.Output)
                            End Using
                        End If
                    End With
                Next
            End Using
        Catch ex As Exception
            Dim myParent = Me.ParentForm
            Me.Close()
            ShowExceptionMessage(myParent, ex)
            Exit Sub
        End Try
    End Sub

    Private Sub EventFormLoad_Init(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case ModeTrans
            Case TransaksiDetailMode.MODE_INSERT, TransaksiDetailMode.MODE_INSERT_RETURN
                '-- Title form
                Me.Text = "Buat Transaksi Baru"

                '-- Auto generate ID
                GenerateTransID()

                If ModeTrans = TransaksiDetailMode.MODE_INSERT Then
                    '-- Insert Mode
                    SetAvailableInsertComponents(True)
                    SetAvailableReturnComponents(False)

                    '-- Auto generate keterangan
                    If String.IsNullOrWhiteSpace(Keterangan) Then
                        Keterangan = "No. faktur " + tbNoNota.Text + " periode tahun " + System.DateTime.Today.Year.ToString
                    End If

                    '-- Auto buka dialog pelanggan
                    btnPelangganBrowse.PerformClick()
                Else
                    '-- Return Mode
                    SetAvailableInsertComponents(False)
                    SetAvailableReturnComponents(True)

                    '-- Auto generate keterangan
                    If String.IsNullOrWhiteSpace(Keterangan) Then
                        Keterangan = "³RETURN dari no. faktur " + RefFakturReturn
                    End If
                End If

                '-- Auto generate date
                timerRefreshTgl_Tick(timerRefreshTgl, New EventArgs())
                timerRefreshTgl.Start()

                '-- Auto select tabel
                DataGridView1.Select()

            Case TransaksiDetailMode.MODE_EDIT, TransaksiDetailMode.MODE_VIEW
                If ModeTrans = TransaksiDetailMode.MODE_EDIT Then
                    '-- Edit Mode
                    SetAvailableInsertComponents(False)
                    SetAvailableReturnComponents(False)

                    '-- Title form
                    Me.Text = "Ubah Transaksi Lama"
                Else
                    '-- View/Read Only Mode
                    SetAvailableInsertComponents(False)
                    SetAvailableShopCartComponents(False)
                    SetAvailableReturnComponents(False)
                    numBayar.Enabled = False
                    btnEditItem.Visible = False
                    btnProses.Enabled = False

                    '-- Title form
                    Me.Text = "Lihat Detail Transaksi"
                End If

                Dim noNota As String = tbNoNota.Text
                '-- Set creation date
                tbTglBuat.Text = tableAdapterTrans.GetTanggalPembuatan(noNota)

                '-- Set data pelanggan
                tableAdapterPelanggan.FillByKode(_Pelanggan, tableAdapterTrans.GetKodePelanggan(noNota))
                '-- Set data mekanik
                If _Mekanik Is Nothing Then
                    _Mekanik = New DataSetBengkel.MONTIRDataTable()
                End If
                _Mekanik.Clear()
                tableAdapterMekanik.FillByKode(_Mekanik, tableAdapterTrans.GetKodeMekanik(noNota))
                '-- Set data kendaraan
                If _Kendaraan Is Nothing Then
                    _Kendaraan = New DataSetBengkel.KENDARAANDataTable()
                End If
                _Kendaraan.Clear()
                tableAdapterKendaraan.FillByNoPol(_Kendaraan, tableAdapterTrans.GetKodeKendaraan(noNota))

                '-- Set keterangan
                Keterangan = tableAdapterTrans.GetKeterangan(noNota)

                '-- Isi ulang keranjang belanja
                IsiKeranjangBelanjaDariNomorNota(noNota)

                '-- Set jumlah bayar dengan bayar_kurang
                Dim bayar_kurang As Decimal = tableAdapterTrans.GetUtang(noNota),
                jmlBayar = TotalTagihan - Math.Abs(bayar_kurang)
                If jmlBayar < 0 Then
                    Try
                        Throw New FormatException("Jumlah Bayar bernilai negatif")
                    Catch ex As Exception
                        Dim myParent = Me.ParentForm
                        Me.Close()
                        ShowExceptionMessage(myParent, ex)
                        Exit Sub
                    End Try
                End If
                numBayar.Value = jmlBayar

                '-- Set kelunasan trans
                Dim tglLunas As String = NullToEmptyString(tableAdapterTrans.GetTanggalLunas(noNota))
                If String.IsNullOrWhiteSpace(tglLunas) = False Then
                    cbLunas.Checked = True
                    tbLunas.Text = tglLunas
                Else
                    cbLunas.Checked = False
                    tbLunas.Text = "(BELUM LUNAS)"
                End If
        End Select

        '-- Readjusting other components
        DataPelangganBerubah()
        DataMekanikBerubah()
        DataKendaraanBerubah()
        lblJmlByrSymbol.Text = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol
        numBayar.DecimalPlaces = Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalDigits
        HitungTotalTagihan()
    End Sub

    Private Sub btnNotaReset_Click(sender As Object, e As EventArgs) Handles btnNotaReset.Click
        GenerateTransID()
    End Sub
    Private Sub btnPelangganBrowse_Click(sender As Object, e As EventArgs) Handles btnPelangganBrowse.Click
        Dim objDialog As New DialogTransaksiTabelCariPelanggan()

        '--Load data pelanggan sbelom nya jika pelanggan sudah terisi
        If _Pelanggan IsNot Nothing AndAlso _Pelanggan.Rows.Count > 0 Then
            Dim newFilter As String = "kode = '" & _Pelanggan.Rows(0).Item(_Pelanggan.kodeColumn) & "'"

            Dim oldFilter As String = objDialog.bindingSource.Filter
            If String.IsNullOrWhiteSpace(oldFilter) = False Then
                newFilter = oldFilter & " AND " & newFilter
            End If

            objDialog.bindingSource.Filter = newFilter
        End If

        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            _Pelanggan.Clear()

            Try
                _Pelanggan.AddPELANGGANRow(objDialog.Outputs(0) _
                                       , NullToEmptyString(objDialog.Outputs(1)) _
                                       , NullToEmptyString(objDialog.Outputs(2)) _
                                       , NullToEmptyString(objDialog.Outputs(3)) _
                                       , NullToEmptyString(objDialog.Outputs(4)))
            Catch ex As Exception
                ShowErrorMessageBox(Nothing, "GAGAL mengambil data pelanggan !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            DataPelangganBerubah()
        End If
    End Sub

    Private Sub btnMekanikBrowse_Click(sender As Object, e As EventArgs) Handles btnMekanikBrowse.Click
        Dim objDialog As New DialogTransaksiTabelCariMekanik()

        '--Load data montir sbelom nya jika montir sudah terisi
        If _Mekanik IsNot Nothing AndAlso _Mekanik.Rows.Count > 0 Then
            Dim newFilter As String = "kode = '" & _Mekanik.Rows(0).Item(_Mekanik.kodeColumn) & "'"

            Dim oldFilter As String = objDialog.bindingSource.Filter
            If String.IsNullOrWhiteSpace(oldFilter) = False Then
                newFilter = oldFilter & " AND " & newFilter
            End If

            objDialog.bindingSource.Filter = newFilter
        End If

        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            _Mekanik = New DataSetBengkel.MONTIRDataTable()

            Try
                _Mekanik.AddMONTIRRow(objDialog.Outputs(0) _
                                       , objDialog.Outputs(1) _
                                       , NullToEmptyString(objDialog.Outputs(2)) _
                                       , NullToEmptyString(objDialog.Outputs(3)) _
                                       , objDialog.Outputs(4))
            Catch ex As Exception
                ShowErrorMessageBox(Nothing, "GAGAL mengambil data mekanik !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            DataMekanikBerubah()
        End If
    End Sub

    Private Sub btnKendaraanBrowse_Click(sender As Object, e As EventArgs) Handles btnKendaraanBrowse.Click
        Dim objDialog As New DialogTransaksiTabelCariKendaraan()

        '--Load data kendaraan sbelom nya jika kendaraan sudah terisi
        If _Kendaraan IsNot Nothing AndAlso _Kendaraan.Rows.Count > 0 Then
            Dim newFilter As String = "nopol = '" & _Kendaraan.Rows(0).Item(_Kendaraan.nopolColumn) & "'"

            Dim oldFilter As String = objDialog.bindingSource.Filter
            If String.IsNullOrWhiteSpace(oldFilter) = False Then
                newFilter = oldFilter & " AND " & newFilter
            End If

            objDialog.bindingSource.Filter = newFilter
        End If

        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            _Kendaraan = New DataSetBengkel.KENDARAANDataTable()

            Try
                _Kendaraan.AddKENDARAANRow(objDialog.Outputs(0) _
                                       , objDialog.Outputs(1) _
                                       , objDialog.Outputs(2) _
                                       , NullToEmptyString(objDialog.Outputs(3)))
            Catch ex As Exception
                ShowErrorMessageBox(Nothing, "GAGAL mengambil data kendaraan !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            DataKendaraanBerubah()
        End If
    End Sub

    Private Sub btnHapusMekanik_Click(sender As Object, e As EventArgs) Handles btnHapusMekanik.Click
        _Mekanik = Nothing
        DataMekanikBerubah()
    End Sub

    Private Sub btnHapusKendaraan_Click(sender As Object, e As EventArgs) Handles btnHapusKendaraan.Click
        _Kendaraan = Nothing
        DataKendaraanBerubah()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim state As Boolean = (DataGridView1.SelectedRows.Count > 0)

        btnEditItem.Enabled = state
        btnHapusItem.Enabled = state
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        btnEditItem.PerformClick()
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Delete)
                btnHapusItem.PerformClick()
        End Select
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.A
                    If e.Shift Then
                        btnTambahJasa.PerformClick()
                    Else
                        btnTambahBarang.PerformClick()
                        btnAddReturnItem.PerformClick()
                    End If
                Case Keys.E
                    btnEditItem.PerformClick()
                Case Keys.D
                    If e.Shift Then
                        btnTambahDiskon.PerformClick()
                    Else
                        btnHapusItem.PerformClick()
                    End If
            End Select

        Else
            Select Case e.KeyCode
                Case Keys.Delete
                    btnHapusItem.PerformClick()
            End Select
        End If
    End Sub

    Private Sub btnTambahBarang_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click
        MunculkanDialogTambahItemBelanja(New DialogTransaksiItemBelanjaBarang())
    End Sub
    Private Sub btnTambahJasa_Click(sender As Object, e As EventArgs) Handles btnTambahJasa.Click
        MunculkanDialogTambahItemBelanja(New DialogTransaksiItemBelanjaJasa())
    End Sub
    Private Sub btnTambahDiskon_Click(sender As Object, e As EventArgs) Handles btnTambahDiskon.Click
        MunculkanDialogTambahItemBelanja(BuatDialogItemDiskon())
    End Sub
    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If ModeTrans <> TransaksiDetailMode.MODE_VIEW Then
            With DataGridView1.SelectedRows
                If .Count > 0 Then
                    Select Case Pengodean.GetTipeTabel(.Item(0).Cells("Kode").Value)
                        Case Pengodean.Tabel.Berupa.Barang
                            MunculkanDialogEditItemBelanja(New DialogTransaksiItemBelanjaBarang(), .Item(0))
                        Case Pengodean.Tabel.Berupa.Jasa
                            MunculkanDialogEditItemBelanja(New DialogTransaksiItemBelanjaJasa(), .Item(0))
                        Case Pengodean.Tabel.Berupa.ItemBelanjaDiskon
                            MunculkanDialogEditItemBelanja(BuatDialogItemDiskon(), .Item(0))
                    End Select
                End If
            End With
        End If
    End Sub
    Private Sub btnHapusItem_Click(sender As Object, e As EventArgs) Handles btnHapusItem.Click
        If ModeTrans <> TransaksiDetailMode.MODE_VIEW Then
            bsTabel.RemoveCurrent()
            UpdateItemDiskon()
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        HitungTotalTagihan()
    End Sub
    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        HitungTotalTagihan()
    End Sub

    Private Sub numBayar_KeyUp(sender As Object, e As KeyEventArgs) Handles numBayar.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.ActiveControl = Nothing
            numBayar.Select()
        End If
    End Sub

    Private Sub numBayar_ValueChanged(sender As Object, e As EventArgs) Handles numBayar.ValueChanged
        HitungKembalian()
    End Sub

    Private Sub btnKeterangan_Click(sender As Object, e As EventArgs) Handles btnKeterangan.Click
        Dim objDialog As New DialogTransaksiKeterangan(Keterangan)

        If ModeTrans = TransaksiDetailMode.MODE_VIEW Then
            objDialog.SetReadOnly(True)
        End If

        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            If ModeTrans <> TransaksiDetailMode.MODE_VIEW Then
                Keterangan = objDialog.dialogOutput.Rtf
            End If
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Select Case ModeTrans
            Case TransaksiDetailMode.MODE_VIEW
                Me.Close()
            Case TransaksiDetailMode.MODE_INSERT
                TambahTransaksiBaru()
            Case TransaksiDetailMode.MODE_EDIT
        End Select
    End Sub

    Private Sub timerRefreshTgl_Tick(sender As Object, e As EventArgs) Handles timerRefreshTgl.Tick
        '-- Auto generate date
        Dim tgl As Date = System.DateTime.Now
        tbTglBuat.Text = tgl.ToShortDateString & " " & tgl.ToShortTimeString

        CekKelunasan()
    End Sub
End Class
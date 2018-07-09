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




    '## Constructors
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public Sub New(noNota As String, Optional mode As TransaksiDetailMode = TransaksiDetailMode.MODE_EDIT)
        MyBase.New()
        InitializeComponent()
        ModeTrans = mode

        Select Case mode
            Case TransaksiDetailMode.MODE_INSERT_RETURN
                ReturnRefFaktur = noNota

            Case Else
                tbNoNota.Text = noNota
        End Select
    End Sub




    '## Components Availability Setter
    Private Sub SetAvailableMetadataComponents(switch As Boolean)
        btnNotaReset.Visible = switch
        btnPelangganBrowse.Visible = switch
        btnMekanikBrowse.Visible = switch
        btnKendaraanBrowse.Visible = switch
        btnHapusMekanik.Visible = switch
        btnHapusKendaraan.Visible = switch

        tplFooter1.Enabled = switch
    End Sub
    Private Sub SetAvailableShopCartComponents_Edit(switch As Boolean)
        btnEditItem.Enabled = switch
        btnEditItem.Visible = switch
    End Sub
    Private Sub SetAvailableShopCartComponents_Hapus(switch As Boolean)
        btnHapusItem.Enabled = switch
        btnHapusItem.Visible = switch
    End Sub
    Private Sub SetAvailableShopCartComponents(switch As Boolean)
        panelContent.Enabled = switch
    End Sub
    Private Sub SetAvailableSubmitComponents(switch As Boolean)
        btnProses.Enabled = switch
    End Sub




    '## DataGridView Manipulations
    Friend Sub SelectBaris(ByVal indeks As Integer)
        If dgvTabel.Rows.Count <= 0 Then
            Exit Sub
        End If

        If indeks >= dgvTabel.Rows.Count Then
            indeks = dgvTabel.Rows.Count - 1
        End If

        With dgvTabel
            .ClearSelection()

            Dim objekBaris As DataGridViewRow = .Rows(indeks)
            objekBaris.Selected = True
            .CurrentCell = objekBaris.Cells(0)

            .FirstDisplayedScrollingRowIndex = indeks
            .FirstDisplayedScrollingColumnIndex = 0
        End With
    End Sub




    '## DataSet Manipulations
    Private Sub GabungDataTabel(table As DataTable)
        Try
            DataSetBelanja.KeranjangBelanja.Merge(table, False, MissingSchemaAction.Error)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub GenerateNewTransID()
        tbNoNota.Text = tableAdapterTrans.GetKodeBaru()
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




    '## Dialog Creators
    Private Sub MunculkanDialogTambahItemBelanja(objDialog As DialogTransaksiItemBelanja)
        If objDialog.ShowDialog(Me) = DialogResult.OK Then
            Try
                GabungDataTabel(objDialog.Output)

                SelectBaris(Integer.MaxValue)
                dgvTabel.ClearSelection()
            Catch ex As DataException
                ShowErrorMessageBox(Nothing, "GAGAL menambahkan item !" & vbNewLine & "Reason: " & ex.Message)
                ProsesException(ex)
            End Try

            '-- update diskon
            If TryCast(objDialog, DialogTransaksiItemBelanjaDiskon) Is Nothing Then
                UpdateItemDiskon()
                dgvTabel.ClearSelection()
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




    '## Form Init
    Private Sub EventFormLoad_Init(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case ModeTrans
            Case TransaksiDetailMode.MODE_INSERT
                FormLoad_Init_Insert()

            Case TransaksiDetailMode.MODE_INSERT_RETURN
                FormLoad_Init_Insert_Return()

            Case TransaksiDetailMode.MODE_EDIT, TransaksiDetailMode.MODE_VIEW
                If ModeTrans = TransaksiDetailMode.MODE_EDIT Then
                    '-- Edit Mode
                    SetAvailableMetadataComponents(False)

                    '-- Title form
                    Me.Text = "Ubah Transaksi Lama"
                Else
                    '-- View/Read Only Mode
                    SetAvailableMetadataComponents(False)
                    SetAvailableShopCartComponents_Barang(False)
                    SetAvailableShopCartComponents_Jasa(False)
                    SetAvailableShopCartComponents_Diskon(False)
                    SetAvailableShopCartComponents_Return(False)
                    SetAvailableShopCartComponents_Edit(False)
                    SetAvailableShopCartComponents_Hapus(False)
                    SetAvailableSubmitComponents(False)
                    numBayar.Enabled = False

                    '-- Title form
                    Me.Text = "Lihat Detail Transaksi"
                End If

                Dim noNota As String = tbNoNota.Text
                Dim result As DataSetBengkel.TRANSAKSIDataTable = tableAdapterTrans.GetDataByNoNota(noNota)
                If result.Rows.Count > 0 Then
                    With result.Rows(0)

                        '-- Set creation date
                        tbTglBuat.Text = NullToEmptyString(.Item("tgl_buat"))

                        '-- Set data pelanggan
                        tableAdapterPelanggan.FillByKode(_Pelanggan, .Item("kode_plg"))

                        '-- Set data mekanik
                        If _Mekanik Is Nothing Then
                            _Mekanik = New DataSetBengkel.MONTIRDataTable()
                        End If
                        _Mekanik.Clear()
                        tableAdapterMekanik.FillByKode(_Mekanik, NullToEmptyString(.Item("kode_mk")))

                        '-- Set data kendaraan
                        If _Kendaraan Is Nothing Then
                            _Kendaraan = New DataSetBengkel.KENDARAANDataTable()
                        End If
                        _Kendaraan.Clear()
                        tableAdapterKendaraan.FillByNoPol(_Kendaraan, NullToEmptyString(.Item("nopol")))

                        '-- Set keterangan
                        Keterangan = NullToEmptyString(.Item("ket"))

                        '-- Isi ulang keranjang belanja
                        DataSetBelanja.KeranjangBelanja.Clear()
                        IsiItemBarangDariNomorNota(noNota)
                        IsiItemJasaDariNomorNota(noNota)
                        IsiItemReturnBarangDariNomorNota(noNota)
                        SelectBaris(0)

                        '-- Set jumlah bayar dengan bayar_kurang
                        Dim bayar_kurang As Decimal = Math.Abs(NullToZeroDecimal(.Item("bayar_kurang"))), jmlBayar As Decimal

                        If TotalTagihan > 0 Then
                            jmlBayar = TotalTagihan - bayar_kurang
                        End If

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
                        Dim tglLunas As String = NullToEmptyString(.Item("tgl_lunas"))
                        If String.IsNullOrWhiteSpace(tglLunas) = False Then
                            cbLunas.Checked = True
                            tbLunas.Text = tglLunas
                        Else
                            cbLunas.Checked = False
                            tbLunas.Text = "(BELUM LUNAS)"
                        End If

                    End With
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
        GenerateNewTransID()
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

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTabel.SelectionChanged
        Dim state As Boolean = (dgvTabel.SelectedRows.Count > 0)

        btnEditItem.Enabled = state
        btnHapusItem.Enabled = state
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabel.CellDoubleClick
        btnEditItem.PerformClick()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTabel.RowsAdded
        HitungTotalTagihan()
    End Sub
    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTabel.RowsRemoved
        HitungTotalTagihan()
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
    Private Sub btnAddReturnItem_Click(sender As Object, e As EventArgs) Handles btnAddReturnItem.Click
        MunculkanDialogTambahItemBelanja(BuatDialogItemReturnBarang())
    End Sub
    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If ModeTrans = TransaksiDetailMode.MODE_VIEW Then
            Exit Sub
        End If

        With dgvTabel.SelectedRows
            If .Count > 0 Then
                Select Case Pengodean.GetTipeTabel(.Item(0).Cells("Kode").Value)
                    Case Pengodean.Tabel.Berupa.Barang
                        MunculkanDialogEditItemBelanja(New DialogTransaksiItemBelanjaBarang(), .Item(0))
                    Case Pengodean.Tabel.Berupa.Jasa
                        MunculkanDialogEditItemBelanja(New DialogTransaksiItemBelanjaJasa(), .Item(0))
                    Case Pengodean.Tabel.Berupa.ItemBelanjaDiskon
                        MunculkanDialogEditItemBelanja(BuatDialogItemDiskon(), .Item(0))
                    Case Pengodean.Tabel.Berupa.ItemBelanjaReturn
                        MunculkanDialogEditItemBelanja(BuatDialogItemReturnBarang(), .Item(0))
                End Select
            End If
        End With
    End Sub
    Private Sub btnHapusItem_Click(sender As Object, e As EventArgs) Handles btnHapusItem.Click
        If ModeTrans = TransaksiDetailMode.MODE_VIEW Then
            Exit Sub
        End If

        bsTabel.RemoveCurrent()
        UpdateItemDiskon()
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
            Keterangan = objDialog.dialogOutput.Rtf
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Select Case ModeTrans

            Case TransaksiDetailMode.MODE_INSERT, TransaksiDetailMode.MODE_INSERT_RETURN
                Submit_Insert()

            Case TransaksiDetailMode.MODE_EDIT

            Case TransaksiDetailMode.MODE_VIEW
                'Me.Close()

        End Select
    End Sub

    Private Sub timerRefreshTgl_Tick(sender As Object, e As EventArgs) Handles timerRefreshTgl.Tick
        '-- Auto generate date
        Dim tgl As Date = System.DateTime.Now
        tbTglBuat.Text = tgl.ToShortDateString & " " & tgl.ToShortTimeString

        CekKelunasan()
    End Sub

    Private Sub FormTransaksiDetail_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        '-- Ctrl+
        If e.Control = True Then
            Select Case e.KeyCode

                Case Keys.A
                    dgvTabel.Select()
                    If e.Shift Then '-- Ctrl+Shift+A
                        btnTambahJasa.PerformClick()

                    Else '-- Ctrl+A
                        If ModeTrans <> TransaksiDetailMode.MODE_INSERT_RETURN Then
                            btnTambahBarang.PerformClick()
                        Else
                            btnAddReturnItem.PerformClick()
                        End If
                    End If

                Case Keys.E '-- Ctrl+E
                    dgvTabel.Select()
                    btnEditItem.PerformClick()

                Case Keys.D
                    dgvTabel.Select()
                    If e.Shift Then '-- Ctrl+Shift+D
                        btnTambahDiskon.PerformClick()
                    Else '-- Ctrl+D
                        btnHapusItem.PerformClick()
                    End If

            End Select
        End If
    End Sub

    Private Sub FormTransaksiDetail_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        '-- Beberapa tombol gk kebaca oleh KeyPress
        '-- Nah, disinilah tempat nya

        Select Case e.KeyValue

            Case Keys.Delete
                btnHapusItem.PerformClick()

            Case Keys.F9
                btnProses.PerformClick()

            Case Keys.End
                numBayar.Select()

            Case Keys.Q '-- Ctrl+Q
                If e.Control = True Then
                    Me.Close()
                End If
        End Select
    End Sub

End Class
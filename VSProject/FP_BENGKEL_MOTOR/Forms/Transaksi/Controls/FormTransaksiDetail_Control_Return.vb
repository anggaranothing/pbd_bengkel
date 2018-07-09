Partial Public Class FormTransaksiDetail
    <System.ComponentModel.Description("Nomor faktur transaksi asal untuk referensi faktur return.")>
    Public ReadOnly Property ReturnRefFaktur As String = String.Empty

    <System.ComponentModel.Description("DataTable keranjang belanja dari transaksi asal.")>
    Private Property ReturnDataTable As New DataSetBelanja.KeranjangBelanjaDataTable()




    '## Form Init
    Private Sub FormLoad_Init_Insert_Return()
        '-- Title form
        Me.Text = "Buat Transaksi Baru"

        '-- Auto generate ID
        GenerateNewTransID()

        '-- Return Mode
        SetAvailableMetadataComponents(False)
        SetAvailableShopCartComponents_Barang(False)
        SetAvailableShopCartComponents_Jasa(False)
        SetAvailableShopCartComponents_Diskon(False)
        SetAvailableShopCartComponents_Return(True)
        numBayar.Enabled = False

        '-- Auto generate keterangan
        If String.IsNullOrWhiteSpace(Keterangan) Then
            Keterangan = Pengodean.Tabel.Tulisan.ItemBelanjaReturn & " dari no. faktur " & ReturnRefFaktur
        End If

        '-- Auto generate date
        timerRefreshTgl_Tick(timerRefreshTgl, New EventArgs())
        timerRefreshTgl.Start()

        '-- Isi ulang keranjang belanja
        DataSetBelanja.KeranjangBelanja.Clear()
        IsiItemBarangDariNomorNota(ReturnRefFaktur)

        '-- Dan jadikan referensi, kosong kan kembali
        ReturnDataTable.Clear()
        ReturnDataTable.Merge(DataSetBelanja.KeranjangBelanja, False, MissingSchemaAction.Error)
        DataSetBelanja.KeranjangBelanja.Clear()

        '-- Auto select tabel
        dgvTabel.Select()

        '-- Ambil metadata transaksi awal
        Dim result As DataSetBengkel.TRANSAKSIDataTable = tableAdapterTrans.GetDataByNoNota(ReturnRefFaktur)
        If result.Rows.Count > 0 Then
            With result.Rows(0)
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
            End With
        End If
    End Sub



    '## Components Availability Setter
    Private Sub SetAvailableShopCartComponents_Return(switch As Boolean)
        btnAddReturnItem.Enabled = switch
        btnAddReturnItem.Visible = switch
    End Sub




    '## DataSet Manipulations
    Private Sub IsiItemReturnBarangDariNomorNota(noNota As String)
        Try
            '--Isi barang
            Using dataTable = tableAdapterTransDetailBarang.GetDataByNoNota(noNota)
                For Each row As DataSetBengkel.TRANSAKSI_DETAIL_BARANGRow In dataTable.Rows
                    With row
                        '-- Jika kuantitas barang positif maka ini barang dan skip saja
                        If .jumlah >= 0 Then
                            Continue For
                        End If


                        Dim namaItem As String = .kode_brg
                        Using tableAdapter As New DataSetBengkelTableAdapters.BARANGTableAdapter()
                            With tableAdapter.GetDataByKode(.kode_brg)
                                If .Rows.Count > 0 Then
                                    namaItem = .Rows(0).Item("nama")
                                End If
                            End With
                        End Using

                        Dim kuantitas As Decimal = Math.Abs(.jumlah) * -1
                        Dim totalHarga As Decimal = (kuantitas * .harga_brg)
                        Dim json As String
                        Using dtj As New DataSetBelanja.DetailItemReturnDataTable()
                            dtj.AddDetailItemReturnRow(.kode_brg, .jumlah)
                            json = Newtonsoft.Json.JsonConvert.SerializeObject(dtj)
                        End Using

                        Me.DataSetBelanja.KeranjangBelanja.AddKeranjangBelanjaRow(String.Format(Pengodean.Tabel.Tulisan.ItemBelanjaReturn & "-{0}", .kode_brg),
                                                                                  String.Format("(RETURN) {0}", namaItem),
                                                                                  "PCS", kuantitas, .harga_brg, totalHarga, False, json)

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




    '## Dialog Creators
    Private Function BuatDialogItemReturnBarang() As DialogTransaksiItemBelanjaReturnBarang
        Dim objDlg As New DialogTransaksiItemBelanjaReturnBarang With {
            .SourceTable = Me.ReturnDataTable,
            .TableSort = Me.bsTabel.Sort
        }

        Return objDlg
    End Function




    '## Submission Processing
    Private Sub Submit_Insert_Return_Barang(ByRef hasil As Integer, ByRef noNota As String)
        '-- Buat transaksi detail barang (return)
        Dim rows = DataSetBelanja.KeranjangBelanja.Select("Kode LIKE " & String.Format("'{0}%'", Pengodean.Tabel.Tulisan.ItemBelanjaReturn))
        For Each row As DataSetBelanja.KeranjangBelanjaRow In rows
            hasil = 0
            With row
                Dim jumlahReturn As Integer, kodeBarang As String
                Dim dataReturn = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataSetBelanja.DetailItemReturnDataTable)(.DataJSON)
                If dataReturn.Rows.Count > 0 Then
                    With dataReturn.Rows(0)
                        kodeBarang = .Item("Kode")
                        jumlahReturn = .Item("jumlah")
                    End With
                End If

                hasil = tableAdapterTransDetailBarang.RowReturnInsert(noNota, ReturnRefFaktur, kodeBarang, jumlahReturn)
                If hasil <= 0 Then
                    Throw New DataException("Gagal mengisi data detail transaksi RETURN BARANG.")
                End If
            End With
        Next
    End Sub




End Class

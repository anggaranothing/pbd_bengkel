Partial Public Class FormTransaksiDetail
    '## Components Availability Setter
    Private Sub SetAvailableShopCartComponents_Barang(switch As Boolean)
        btnTambahBarang.Enabled = switch
        btnTambahBarang.Visible = switch
    End Sub




    '## DataSet Manipulations
    Private Sub IsiItemBarangDariNomorNota(noNota As String)
        Try
            '--Isi barang
            Using dataTable = tableAdapterTransDetailBarang.GetDataByNoNota(noNota)
                For Each row As DataSetBengkel.TRANSAKSI_DETAIL_BARANGRow In dataTable.Rows
                    With row
                        '-- Jika kuantitas barang negatif maka ini return barang dan skip saja
                        If .jumlah < 0 Then
                            Continue For
                        End If

                        Dim namaItem As String = .kode_brg
                        Dim totalHarga As Decimal = (.jumlah * .harga_brg)
                        Dim dtj As New DataSetBelanja.DetailItemBarangDataTable()
                        dtj.AddDetailItemBarangRow(.jumlah)
                        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(dtj)

                        Using tableAdapter As New DataSetBengkelTableAdapters.BARANGTableAdapter()
                            With tableAdapter.GetDataByKode(.kode_brg)
                                If .Rows.Count > 0 Then
                                    namaItem = .Rows(0).Item("nama")
                                End If
                            End With
                        End Using

                        Me.DataSetBelanja.KeranjangBelanja.AddKeranjangBelanjaRow(.kode_brg, namaItem, "PCS", .jumlah, .harga_brg, totalHarga, False, json)

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
        Catch ex As Exception
            Dim myParent = Me.ParentForm
            Me.Close()
            ShowExceptionMessage(myParent, ex)
            Exit Sub
        End Try
    End Sub




    '## Submission Processing
    Private Sub Submit_Insert_Barang(ByRef hasil As Integer, ByRef noNota As String)
        Dim persenDiskon As Decimal
        '-- Buat transaksi detail barang
        Dim rows = DataSetBelanja.KeranjangBelanja.Select("Kode LIKE " & String.Format("'{0}%'", Pengodean.Tabel.Tulisan.Barang))
        For Each row As DataSetBelanja.KeranjangBelanjaRow In rows
            hasil = 0
            With row
                Dim rowsDiskon As DataSetBelanja.KeranjangBelanjaRow() = DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = TRUE AND Kode = " & String.Format("'{0}-{1}'", Pengodean.Tabel.Tulisan.ItemBelanjaDiskon, .Kode))
                If rowsDiskon.Length > 0 Then
                    persenDiskon = rowsDiskon(0).Kuantitas
                End If

                hasil = tableAdapterTransDetailBarang.RowInsert(noNota, .Kode, .Harga, .Kuantitas, persenDiskon)
                If hasil <= 0 Then
                    Throw New DataException("Gagal mengisi data detail transaksi BARANG.")
                End If
            End With
        Next
    End Sub
End Class

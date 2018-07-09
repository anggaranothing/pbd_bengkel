Partial Public Class FormTransaksiDetail
    '## Components Availability Setter
    Private Sub SetAvailableShopCartComponents_Jasa(switch As Boolean)
        btnTambahJasa.Enabled = switch
        btnTambahJasa.Visible = switch
    End Sub




    '## DataSet Manipulations
    Private Sub IsiItemJasaDariNomorNota(noNota As String)
        Try
            '--Isi Jasa
            Using dataTable = tableAdapterTransDetailJasa.GetDataByNoNota(noNota)
                For Each row As DataRow In dataTable.Rows
                    With row
                        Dim kodeJasa As String = .Item("kode_jasa")
                        Dim namaItem As String = kodeJasa
                        Dim tglMulai As Object = .Item("tgl_mulai")
                        Dim tglSelesai As Object = .Item("tgl_selesai")
                        Dim totalHarga As Decimal = .Item("harga_jasa")
                        Dim diskon As Decimal = .Item("diskon")

                        If IsDBNull(tglMulai) Then
                            tglMulai = Nothing
                        End If
                        If IsDBNull(tglSelesai) Then
                            tglSelesai = Nothing
                        End If

                        Dim dtj As New DataSetBelanja.DetailItemJasaDataTable()
                        dtj.AddDetailItemJasaRow(tglMulai, tglSelesai)
                        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(dtj)

                        Using tableAdapter As New DataSetBengkelTableAdapters.JASATableAdapter()
                            With tableAdapter.GetDataByKode(kodeJasa)
                                If .Rows.Count > 0 Then
                                    namaItem = .Rows(0).Item("nama")
                                End If
                            End With
                        End Using

                        Me.DataSetBelanja.KeranjangBelanja.AddKeranjangBelanjaRow(kodeJasa, namaItem, String.Empty, 0, totalHarga, totalHarga, False, json)

                        If diskon > 0 Then
                            Using obDlgDisc As DialogTransaksiItemBelanjaDiskon = BuatDialogItemDiskon()
                                '-- update pakai dialog itemdiskon dan apply secara otomatis
                                obDlgDisc.WindowState = FormWindowState.Minimized
                                obDlgDisc.SuspendLayout()
                                obDlgDisc.Size = New Size(0, 0)
                                obDlgDisc.Show()
                                obDlgDisc.tbKunci.Text = kodeJasa
                                obDlgDisc.ProsesFilter()
                                obDlgDisc.numDiscPercentage.Value = diskon
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
    Private Sub Submit_Insert_Jasa(ByRef hasil As Integer, ByRef noNota As String)
        Dim persenDiskon As Decimal
        '-- Buat transaksi detail jasa
        Dim rows = DataSetBelanja.KeranjangBelanja.Select("Kode LIKE " & String.Format("'{0}%'", Pengodean.Tabel.Tulisan.Jasa))
        For Each row As DataSetBelanja.KeranjangBelanjaRow In rows
            hasil = 0
            With row
                Dim rowsDiskon As DataSetBelanja.KeranjangBelanjaRow() = DataSetBelanja.KeranjangBelanja.Select("IsDiskonItem = TRUE AND Kode = " & String.Format("'{0}-{1}'", Pengodean.Tabel.Tulisan.ItemBelanjaDiskon, .Kode))
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
    End Sub
End Class

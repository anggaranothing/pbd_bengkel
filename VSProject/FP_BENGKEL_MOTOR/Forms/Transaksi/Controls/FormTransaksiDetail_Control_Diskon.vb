Partial Public Class FormTransaksiDetail
    '## Components Availability Setter
    Private Sub SetAvailableShopCartComponents_Diskon(switch As Boolean)
        btnTambahDiskon.Enabled = switch
        btnTambahDiskon.Visible = switch
    End Sub




    '## DataSet Manipulations
    Private Sub UpdateItemDiskon()
        '-- Update dulu tabel keranjang belanja
        DataSetBelanja.KeranjangBelanja.AcceptChanges()

        '-- Catat posisi baris terakhir yg terselect di datagridview 
        Dim lastSelectedIndex As Integer = -1
        If dgvTabel.SelectedRows.Count > 0 Then
            lastSelectedIndex = dgvTabel.SelectedRows(0).Index
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




    '## Dialog Creators
    Private Function BuatDialogItemDiskon() As DialogTransaksiItemBelanjaDiskon
        Dim objDlg As New DialogTransaksiItemBelanjaDiskon With {
            .SourceTable = Me.DataSetBelanja.KeranjangBelanja,
            .TableSort = Me.bsTabel.Sort
        }

        Return objDlg
    End Function




End Class

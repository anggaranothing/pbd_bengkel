Public Class FormTabelPelanggan
    Protected Overrides Sub TabelInputReset()
        UpdateTextBoxKode()
        inputTBNama.Text = ""
        inputTBAlamat.Text = ""
        inputTBNoTelpon.Text = ""
        inputTBNoId.Text = ""
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel
        '-- Ganti judul kolom tabel
        GantiJudulKolom("kode", "No. ID")
        GantiJudulKolom("nama", "Nama Pelanggan")
        GantiJudulKolom("alamat", "Alamat")
        GantiJudulKolom("telepon", "No. Telp.")
        GantiJudulKolom("no_id", "No. Identitas Pribadi")
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.PELANGGAN) >= 0
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        Dim hasil As Integer
        '-- Insert data baru
        Try
            hasil = tableAdapter.RowInsert(
                inputTBKode.Text,
                inputTBNama.Text,
                inputTBAlamat.Text,
                inputTBNoTelpon.Text,
                inputTBNoId.Text)
            TabelFill()
        Catch ex As Exception
            ShowExceptionMessage(ex)
        Finally
            TabelInputReset()
        End Try

        If hasil > 0 Then
            '-- Auto select baris terakhir
            SelectBarisTerakhir()

            ShowInformationMessageBox(Me, "Data BERHASIL di tambah")
        Else
            ShowErrorMessageBox(Me, "Data GAGAL di tambah")
        End If
    End Sub

    Protected Overrides Sub TabelBarisHapus(posisi As Integer)
        Dim hasil As Integer
        Dim kode As String = GetDataBaris(posisi, "kode").Value

        Dim pesanDialog As String =
            "Anda yakin akan menghapus data sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & kode _
            & vbNewLine & GetDataBaris(posisi, "nama").Value

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Hapus") = System.Windows.Forms.DialogResult.OK Then
            Try
                '-- Jika ada data yg terhapus, maka method ini mengembalikan nilai integer positif
                hasil = tableAdapter.RowDelete(kode)
                TabelFill()
            Catch ex As Exception
                ShowExceptionMessage(ex)
            End Try

            If hasil > 0 Then
                ShowInformationMessageBox(Me, "Data BERHASIL di hapus")
            Else
                ShowErrorMessageBox(Me, "Data GAGAL di hapus")
            End If
        End If
    End Sub

    Protected Overrides Sub TabelBarisEdit(posisi As Integer)
        Dim kode As String = GetDataBaris(posisi, "kode").Value,
        nama As String = GetDataBaris(posisi, "nama").Value,
        alamat As String = NullToEmptyString(GetDataBaris(posisi, "alamat").Value),
        telp As String = NullToEmptyString(GetDataBaris(posisi, "telepon").Value),
        no_id As String = NullToEmptyString(GetDataBaris(posisi, "no_id").Value)

        inputTBKode.Text = kode
        inputTBNama.Text = nama
        inputTBAlamat.Text = alamat
        inputTBNoTelpon.Text = telp
        inputTBNoId.Text = no_id
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim kode As String = inputTBKode.Text,
        nama As String = inputTBNama.Text,
        alamat As String = inputTBAlamat.Text,
        telp As String = inputTBNoTelpon.Text,
        no_id As String = inputTBNoId.Text,
        hasil As Integer

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "Kode Pelanggan:" & vbTab & kode _
            & vbNewLine & "Nama Pelanggan:" & vbTab & nama _
            & vbNewLine & "Alamat: " & If(String.IsNullOrWhiteSpace(alamat), "(KOSONG)", alamat) _
            & vbNewLine & "Telp. " & If(String.IsNullOrWhiteSpace(telp), "(KOSONG)", telp) _
            & vbNewLine & "No. Identitas:" & vbTab & If(String.IsNullOrWhiteSpace(no_id), "(KOSONG)", no_id)

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(kode, nama, alamat, telp, no_id)

                TabelFill()
                viewTabelDb.ClearSelection()
                viewTabelDb.Rows.Item(IndeksEditBaris).Selected = True
                viewTabelDb.FirstDisplayedScrollingRowIndex = IndeksEditBaris
                TabelInputReset()
            Catch ex As Exception
                ShowExceptionMessage(ex)
            End Try

            If hasil > 0 Then
                ApakahModeInsertData = True
                ShowInformationMessageBox(Me, "Data BERHASIL di ubah")
            Else
                ShowErrorMessageBox(Me, "Data GAGAL di ubah")
            End If
        End If
    End Sub

    '-- Method pribadi
    Private Sub UpdateTextBoxKode()
        '-- Update hanya jika dalam mode insert
        If ApakahModeInsertData And IsTableFilled Then
            Dim str As String = Nothing

            Try
                str = tableAdapter.GetKodeBaru()
            Catch ex As Exception
                ShowExceptionMessage(ex)
            Finally
                inputTBKode.Text = str
            End Try
        End If
    End Sub

    '-- Method dari form
    Private Sub EventTabTambahClicked(sender As Object, e As EventArgs) Handles inputTLP.Click
        inputTLP.Select()
    End Sub

    Private Sub inputBtnResetKode_Click(sender As Object, e As EventArgs) Handles inputBtnResetKode.Click
        inputBtnResetKode.Enabled = False
        UpdateTextBoxKode()
        inputBtnResetKode.Enabled = True
    End Sub
End Class

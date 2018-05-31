Public Class FormTabelMontir
    Protected Overrides Sub TabelInputReset()
        UpdateTextBoxKode()
        inputTBNama.Text = ""
        inputTBAlamat.Text = ""
        inputTBNoTelpon.Text = ""
        inputRBTidakAktif.Checked = True
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel
        '-- Ganti judul kolom tabel
        GantiJudulKolom("kode", "No. ID")
        GantiJudulKolom("nama", "Nama Mekanik")
        GantiJudulKolom("alamat", "Alamat")
        GantiJudulKolom("telepon", "No. Telp.")
        GantiJudulKolom("status", "Status Keaktifan")
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.MONTIR) >= 0
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
                inputRBAktif.Checked)
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
            & Environment.NewLine _
            & Environment.NewLine & kode _
            & Environment.NewLine & GetDataBaris(posisi, "nama").Value

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
        status As Boolean = GetDataBaris(posisi, "status").Value

        inputTBKode.Text = kode
        inputTBNama.Text = nama
        inputTBAlamat.Text = alamat
        inputTBNoTelpon.Text = telp
        inputRBAktif.Checked = status
        inputRBTidakAktif.Checked = Not status
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim kode As String = inputTBKode.Text,
        nama As String = inputTBNama.Text,
        alamat As String = inputTBAlamat.Text,
        telp As String = inputTBNoTelpon.Text,
        status As Boolean = inputRBAktif.Checked,
        hasil As Integer

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & Environment.NewLine _
            & Environment.NewLine & "Kode Mekanik:" & vbTab & kode _
            & Environment.NewLine & "Nama Mekanik:" & vbTab & nama _
            & Environment.NewLine & "Alamat: " & If(String.IsNullOrWhiteSpace(alamat), "(KOSONG)", alamat) _
            & Environment.NewLine & "Telp. " & If(String.IsNullOrWhiteSpace(telp), "(KOSONG)", telp) _
            & Environment.NewLine & "Anggota " & If(status, "Aktif", "Tidak Aktif")

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(kode, nama, alamat, telp, status)

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

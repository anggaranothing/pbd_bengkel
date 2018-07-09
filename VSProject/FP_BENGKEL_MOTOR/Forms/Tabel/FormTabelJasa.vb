Public NotInheritable Class FormTabelJasa
    Protected Overrides Sub TabelInputResetPost()
        inputTBNama.Text = ""
        inputNumHarga.Value = inputNumHarga.Minimum
        inputNumWaktu.Value = inputNumWaktu.Minimum
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel

        '-- Ganti judul kolom tabel
        GantiJudulKolom("kode", "No. ID")
        GantiJudulKolom("nama", "Nama Jasa")
        GantiJudulKolom("harga", "Harga")
        GantiJudulKolom("waktu_menit", "Per X Menit")

        '-- Mengoreksi lambang uang
        lblHargaSymbol.Text = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol
        inputNumHarga.DecimalPlaces = Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalDigits
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.JASA) >= 0
    End Sub
    Protected Overrides Sub TabelInitialized()
        '-- Jadikan kolom ini menjadi filler di tabel
        SetFillerColumn("nama")
        '-- Buat kolom kode tidak autosize
        With viewTabelDb.Columns("kode")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom harga tidak autosize
        With viewTabelDb.Columns("harga")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
            .DefaultCellStyle.Format = "C"
        End With
        '-- Buat kolom waktu_menit tidak autosize
        With viewTabelDb.Columns("waktu_menit")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Resizable = DataGridViewTriState.True
        End With
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        Dim hasil As Integer
        '-- Insert data baru
        Try
            hasil = tableAdapter.RowInsert(
                inputTBKode.Text,
                inputTBNama.Text,
                inputNumHarga.Value,
                inputNumWaktu.Value)
            TabelFill()
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
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
                ProsesException(ex)
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
        harga As Decimal = GetDataBaris(posisi, "harga").Value,
        waktu_menit As Decimal = NullToZeroDecimal(GetDataBaris(posisi, "waktu_menit").Value)

        inputTBKode.Text = kode
        inputTBNama.Text = nama
        inputNumHarga.Value = harga
        inputNumWaktu.Value = waktu_menit
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim kode As String = inputTBKode.Text,
        nama As String = inputTBNama.Text,
        harga As Decimal = inputNumHarga.Value,
        waktu_menit As Decimal = inputNumWaktu.Value,
        hasil As Integer

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "Kode Jasa:" & vbTab & kode _
            & vbNewLine & "Nama Jasa:" & vbTab & nama _
            & vbNewLine & "Harga:" & vbTab & vbTab & "Rp. " & harga _
            & vbNewLine & If(waktu_menit > 0, String.Format("Berakumulasi setiap {0} menit.", waktu_menit), "TIDAK ADA BATASAN WAKTU")

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(kode, nama, harga, waktu_menit)

                TabelFill()
                viewTabelDb.ClearSelection()
                viewTabelDb.Rows.Item(IndeksEditBaris).Selected = True
                viewTabelDb.FirstDisplayedScrollingRowIndex = IndeksEditBaris
                TabelInputReset()
            Catch ex As Exception
                ShowExceptionMessage(ex)
                ProsesException(ex)
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
    Private Sub UpdateTextBoxKode(sender As Object, e As EventArgs) Handles Me.UpdateKode
        Dim str As String = Nothing

        Try
            str = tableAdapter.GetKodeBaru()
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        Finally
            inputTBKode.Text = str
        End Try
    End Sub

    '-- Method dari form
    Private Sub EventTabTambahClicked(sender As Object, e As EventArgs) Handles inputTLP.Click
        inputTLP.Select()
    End Sub

    Private Sub EventFormInputModeChanged_AutoFocus(sender As Object, e As EventArgs) Handles Me.ModeManipulasiDataChanged
        inputTLP.VerticalScroll.Value = 0
        inputTLP.HorizontalScroll.Value = 0
        inputTLP.Refresh()
    End Sub

    Protected Overrides Sub inputAnyResetKode_Click(sender As Object, e As EventArgs) Handles inputBtnResetKode.Click
        MyBase.inputAnyResetKode_Click(sender, e)
    End Sub
End Class

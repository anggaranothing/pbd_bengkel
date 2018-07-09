Public NotInheritable Class FormTabelBarang
    Protected Overrides Sub TabelInputResetPost()
        inputTBNama.Text = ""
        inputTBBarcode.Text = ""
        inputNumHarga.Value = inputNumHarga.Minimum
        inputNumStok.Value = inputNumStok.Minimum
        inputRTBKet.Rtf = ""
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel

        '-- Ganti judul kolom tabel
        GantiJudulKolom("kode", "No. ID")
        GantiJudulKolom("kodebar", "Barcode")
        GantiJudulKolom("nama", "Nama Produk")
        GantiJudulKolom("harga", "Harga")
        GantiJudulKolom("stok", "Stok Persediaan")
        GantiJudulKolom("ket", "Ket. (Format RTF)")

        '-- Mengoreksi lambang uang
        lblHargaSymbol.Text = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol
        inputNumHarga.DecimalPlaces = Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalDigits
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.BARANG) >= 0
    End Sub
    Protected Overrides Sub TabelInitialized()
        '-- Jadikan kolom ini menjadi filler di tabel
        SetFillerColumn("nama")
        '-- Buat kolom kode tidak autosize
        With viewTabelDb.Columns("kode")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom kodebar tidak autosize
        With viewTabelDb.Columns("kodebar")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom harga tidak autosize
        With viewTabelDb.Columns("harga")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
            .DefaultCellStyle.Format = "C"
        End With
        '-- Buat kolom stok tidak autosize
        With viewTabelDb.Columns("stok")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom keterangan tidak autosize
        With viewTabelDb.Columns("ket")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Resizable = DataGridViewTriState.True
        End With
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        Dim rtf As String = inputRTBKet.Rtf
        Dim hasil As Integer

        If String.IsNullOrWhiteSpace(inputRTBKet.Text) Then
            rtf = String.Empty
        End If

        '-- Insert data baru
        Try
            hasil = tableAdapter.RowInsert(
                inputTBKode.Text,
                inputTBNama.Text,
                inputNumHarga.Value,
                inputNumStok.Value,
                inputTBBarcode.Text,
                rtf)
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
            & vbNewLine & kode & " (No. Barcode: " & GetDataBaris(posisi, "kodebar").Value & " )" _
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
        kodebar As String = NullToEmptyString(GetDataBaris(posisi, "kodebar").Value),
        nama As String = GetDataBaris(posisi, "nama").Value,
        harga As Decimal = GetDataBaris(posisi, "harga").Value,
        stok As Integer = GetDataBaris(posisi, "stok").Value,
        ket As String = NullToEmptyString(GetDataBaris(posisi, "ket").Value)


        inputTBKode.Text = kode
        inputTBNama.Text = nama
        inputNumHarga.Value = harga
        inputNumStok.Value = stok
        inputTBBarcode.Text = kodebar
        inputRTBKet.Rtf = ket
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim kode As String = inputTBKode.Text,
        kodebar As String = inputTBBarcode.Text,
        nama As String = inputTBNama.Text,
        harga As Decimal = inputNumHarga.Value,
        stok As Integer = inputNumStok.Value,
        ket As String = inputRTBKet.Rtf,
        hasil As Integer

        If String.IsNullOrWhiteSpace(inputRTBKet.Text) Then
            ket = String.Empty
        End If

        Dim ketTeks As String = inputRTBKet.Text.Trim()
        If ketTeks.Length > 32 Then
            ketTeks = ketTeks.Substring(0, 32) & "..."
        ElseIf String.IsNullOrWhiteSpace(ketTeks) Then
            ketTeks = "(KOSONG)"
        End If

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "Kode Barang:" & vbTab & kode _
            & vbNewLine & "Nama Barang:" & vbTab & nama _
            & vbNewLine & "Harga:" & vbTab & vbTab & "Rp. " & harga _
            & vbNewLine & "Stok:" & vbTab & vbTab & stok & " unit" _
            & vbNewLine & "Ket.: " & ketTeks

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(kode, nama, harga, stok, kodebar, ket)

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

    Private Sub RichTextBoxEx1_Load(sender As Object, e As EventArgs) Handles RichTextBoxEx1.Load
        PerbaikiRightClickMenuRTB(inputRTBKet)
    End Sub
End Class

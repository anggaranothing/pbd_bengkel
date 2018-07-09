Public Class FormTabelTransaksi
    Private Property IsLunas As Boolean
    Private Property TanggalLunas As Object
    Private Property KodePelanggan As String

    Protected Overrides Sub TabelInputReset()
        IsLunas = False
        TanggalLunas = Nothing
        KodePelanggan = String.Empty

        tbNoNota.Text = String.Empty
        tbPelanggan.Text = String.Empty
        numBayar.Value = numBayar.Minimum
        inputRTBKet.Rtf = String.Empty
    End Sub
    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel

        '-- Ganti judul kolom tabel
        GantiJudulKolom("no_nota", "No. Nota")
        GantiJudulKolom("kode_plg", "Pelanggan")
        GantiJudulKolom("kode_mk", "Mekanik")
        GantiJudulKolom("nopol", "TNKB Kendaraan Pelanggan")
        GantiJudulKolom("tgl_buat", "Tgl. Pembuatan")
        GantiJudulKolom("tgl_lunas", "Tgl. Pelunasan")
        GantiJudulKolom("bayar_kurang", "Piutang")
        GantiJudulKolom("ket", "Ket. (Format RTF)")

        '-- Mengoreksi lambang uang
        lblBayarSymbol.Text = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol
        numBayar.DecimalPlaces = Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalDigits
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.TRANSAKSI) >= 0
    End Sub
    Protected Overrides Sub TabelInitialized()
        '-- Jadikan kolom ini menjadi filler di tabel
        SetFillerColumn("ket")
        '-- Buat kolom no_nota tidak autosize
        With viewTabelDb.Columns("no_nota")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom kode_plg tidak autosize
        With viewTabelDb.Columns("kode_plg")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom kode_mk tidak autosize
        With viewTabelDb.Columns("kode_mk")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom nopol tidak autosize
        With viewTabelDb.Columns("nopol")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
        '-- Buat kolom bayar_kurang tidak autosize
        With viewTabelDb.Columns("bayar_kurang")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
            .DefaultCellStyle.Format = "C"
        End With

        Dim polaWaktu As String = Globalization.DateTimeFormatInfo.CurrentInfo.ShortDatePattern & " " & Globalization.DateTimeFormatInfo.CurrentInfo.ShortTimePattern
        dtpLunas.CustomFormat = polaWaktu
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        Try
            Dim objDialog As FormTransaksiDetail
            PembuatForm.Transaksi.BuatFormInsert(Me, objDialog, True)
            If objDialog.DialogResult = DialogResult.OK Then
                btnRefillTable.PerformClick()
            End If
        Catch ex As Exception
            ShowExceptionMessage(ex)
        End Try
    End Sub

    Protected Overrides Sub TabelBarisHapus(posisi As Integer)
        Dim hasil As Integer
        Dim noNota As String = GetDataBaris(posisi, "no_nota").Value
        Dim ket As String = NullToEmptyString(GetDataBaris(posisi, "ket").Value)

        Using rtbTemp As New RichTextBox()
            Try
                rtbTemp.Rtf = ket
                ket = rtbTemp.Text
            Catch ex As Exception
            End Try
        End Using

        Dim pesanDialog As String =
            "Anda yakin akan menghapus data sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & noNota _
            & vbNewLine _
            & vbNewLine & ket

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Hapus") = System.Windows.Forms.DialogResult.OK Then
            Try
                '-- Jika ada data yg terhapus, maka method ini mengembalikan nilai integer positif
                hasil = tableAdapter.RowDelete(noNota)
                TabelFill()
            Catch ex As Exception
                ShowExceptionMessage(ex)
                ProsesException(ex)
            End Try

            If hasil > 0 Then
                ShowInformationMessageBox(Me, "Transaksi BERHASIL di hapus")
            Else
                ShowErrorMessageBox(Me, "Transaksi GAGAL di hapus")
            End If
        End If
    End Sub

    Protected Overrides Sub TabelBarisEdit(posisi As Integer)
        KodePelanggan = GetDataBaris(posisi, "kode_plg").Value

        Dim noNota As String = GetDataBaris(posisi, "no_nota").Value,
        bayarKurang As Decimal = NullToZeroDecimal(GetDataBaris(posisi, "bayar_kurang").Value),
        dateLunas As String = NullToEmptyString(GetDataBaris(posisi, "tgl_lunas").Value),
        ket As String = NullToEmptyString(GetDataBaris(posisi, "ket").Value)

        tbNoNota.Text = noNota
        numBayar.Value = bayarKurang

        CekKelunasan()

        Dim dateTemp As DateTime = System.DateTime.Now
        If DateTime.TryParse(dateLunas, dateTemp) Then
            If dateTemp.CompareTo(dtpLunas.MinDate) < 0 Or dateTemp.CompareTo(dtpLunas.MaxDate) > 0 Then
                TanggalLunas = Nothing
                dateTemp = System.DateTime.Now
                'System.Console.Out.WriteLine("NOPE")
            Else
                TanggalLunas = dateTemp
                'System.Console.Out.WriteLine("YAS")
            End If
        Else
            TanggalLunas = Nothing
            dateTemp = System.DateTime.Now
            'System.Console.Out.WriteLine("FAIL")
        End If
        dtpLunas.Value = dateTemp

        Using taPlgTemp As New DataSetBengkelTableAdapters.PELANGGANTableAdapter()
            Try
                tbPelanggan.Text = taPlgTemp.GetDataByKode(KodePelanggan).Rows(0).Item("nama")
            Catch ex As Exception
                tbPelanggan.Text = KodePelanggan
            End Try
        End Using

        Try
            inputRTBKet.Rtf = ket
        Catch ex As Exception
            inputRTBKet.Text = ket
        End Try
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim noNota As String = tbNoNota.Text,
        kodePlg As String = KodePelanggan,
        bayarKurang As Decimal = numBayar.Value,
        dateLunas As DateTime = dtpLunas.Value,
        ket As String = inputRTBKet.Rtf,
        hasil As Integer

        Dim ketTeks As String = inputRTBKet.Text.Trim()
        If ketTeks.Length > 32 Then
            ketTeks = ketTeks.Substring(0, 32) & "..."
        ElseIf String.IsNullOrWhiteSpace(ketTeks) Then
            ketTeks = "(KOSONG)"
        End If

        Dim lunasTeks As String = "(BELUM LUNAS)"
        If IsLunas Then
            lunasTeks = "(SUDAH LUNAS)"
        End If

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "No. Nota:" & vbTab & noNota _
            & vbNewLine & "Pelanggan:" & vbTab & tbPelanggan.Text _
            & vbNewLine & "Status:" & vbTab & vbTab & lunasTeks _
            & vbNewLine & "Ket.: " & ketTeks

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                dateLunas = New DateTime(dateLunas.Year, dateLunas.Month, dateLunas.Day, dateLunas.Hour, dateLunas.Minute, dateLunas.Second)
                hasil = tableAdapter.RowMinimumEdit(noNota, dateLunas, bayarKurang, ket)

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

    Private Sub CekKelunasan()
        If numBayar.Value > 0 Then
            IsLunas = False
            dtpLunas.Checked = False
        Else
            IsLunas = True
            dtpLunas.Checked = True

            If TanggalLunas Is Nothing OrElse TanggalLunas.GetType() IsNot New DateTime().GetType() Then
                dtpLunas.Value = Now
            Else
                dtpLunas.Value = TanggalLunas
            End If
        End If

        dtpLunas.Refresh()
    End Sub

    '-- Method dari form
    Private Sub btnDetailView_Click(sender As Object, e As EventArgs) Handles btnViewDetail.Click
        Dim noNota As String = tbNoNota.Text
        If String.IsNullOrWhiteSpace(noNota) = False Then
            Try
                PembuatForm.Transaksi.BuatFormView(Me, Nothing, noNota, True)
            Catch ex As Exception
                ShowExceptionMessage(ex)
            End Try
        End If
    End Sub

    Private Sub btnNewReturn_Click(sender As Object, e As EventArgs) Handles btnNewReturn.Click
        Dim noNota As String = tbNoNota.Text
        If String.IsNullOrWhiteSpace(noNota) = False Then
            Try
                Dim objDialog As FormTransaksiDetail
                PembuatForm.Transaksi.BuatFormInsertReturn(Me, objDialog, noNota, True)
                If objDialog.DialogResult = DialogResult.OK Then
                    btnRefillTable.PerformClick()
                End If
            Catch ex As Exception
                ShowExceptionMessage(ex)
            End Try
        End If
    End Sub

    Private Sub numBayar_ValueChanged(sender As Object, e As EventArgs) Handles numBayar.ValueChanged
        CekKelunasan()
    End Sub

    Private Sub EventTabTambahClicked(sender As Object, e As EventArgs) Handles inputTLP.Click
        inputTLP.Select()
    End Sub

    Private Sub EventFormInputModeChanged_AutoFocus(sender As Object, e As EventArgs) Handles Me.ModeManipulasiDataChanged
        inputTLP.VerticalScroll.Value = 0
        inputTLP.HorizontalScroll.Value = 0
        inputTLP.Refresh()
    End Sub

    Private Sub RichTextBoxEx1_Load(sender As Object, e As EventArgs) Handles RichTextBoxEx1.Load
        PerbaikiRightClickMenuRTB(inputRTBKet)
    End Sub
End Class

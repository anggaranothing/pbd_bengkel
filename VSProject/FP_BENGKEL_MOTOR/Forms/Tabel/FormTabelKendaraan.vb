Public NotInheritable Class FormTabelKendaraan

    Protected Overrides Sub TabelInputReset()
        inputTBNoPol.Text = ""
        inputTBNama.Text = ""
        inputNumTahun.Value = Date.Today.Year
        inputTBstnk.Text = ""
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.KENDARAAN) >= 0
    End Sub
    Protected Overrides Sub TabelInitialized()
        '-- Ganti judul kolom tabel
        GantiJudulKolom("nopol", "TNKB")
        GantiJudulKolom("nama", "Nama Kendaraan")
        GantiJudulKolom("tahun", "Tahun Pembuatan")
        GantiJudulKolom("stnk", "No. STNK")
        '-- Jadikan kolom ini menjadi filler di tabel
        SetFillerColumn("nama")
        '-- Buat kolom kode tidak autosize
        With viewTabelDb.Columns("nopol")
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Resizable = DataGridViewTriState.True
        End With
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        Dim hasil As Integer

        '-- Insert data baru
        Try
            hasil = tableAdapter.RowInsert(
                inputTBNoPol.Text,
                inputTBNama.Text,
                inputNumTahun.Value,
                inputTBstnk.Text)
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
        Dim nopol As String = GetDataBaris(posisi, "nopol").Value

        Dim pesanDialog As String =
            "Anda yakin akan menghapus data sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "TNKB : " & nopol _
            & vbNewLine & "Nama : " & GetDataBaris(posisi, "nama").Value _
            & vbNewLine & "STNK : " & GetDataBaris(posisi, "stnk").Value

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Hapus") = System.Windows.Forms.DialogResult.OK Then
            Try
                '-- Jika ada data yg terhapus, maka method ini mengembalikan nilai integer positif
                hasil = tableAdapter.RowDelete(nopol)
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
        Dim nopol As String = GetDataBaris(posisi, "nopol").Value,
        nama As String = GetDataBaris(posisi, "nama").Value,
        tahun As Integer = GetDataBaris(posisi, "tahun").Value,
        stnk As String = NullToEmptyString(GetDataBaris(posisi, "stnk").Value)

        inputTBNoPol.Text = nopol
        inputTBNama.Text = nama
        inputNumTahun.Value = Integer.Parse(tahun)
        inputTBstnk.Text = stnk
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        Dim nopol As String = inputTBNoPol.Text,
        nama As String = inputTBNama.Text,
        tahun As Integer = inputNumTahun.Value,
        stnk As String = inputTBstnk.Text,
        hasil As Integer

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "TNKB:" & vbTab & vbTab & nopol _
            & vbNewLine & "Nama Kendaraan:" & vbTab & nama _
            & vbNewLine & "Tahun Pembuatan:" & vbTab & tahun _
            & vbNewLine & "STNK:" & vbTab & stnk

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(nopol, nama, tahun, stnk)

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

    '-- Method dari form
    Private Sub EventControlClick_GainInputTLPFocus(sender As Object, e As EventArgs) Handles inputTLP.Click
        inputTLP.Select()
    End Sub

    Private Sub EventFormInputModeChanged_AutoFocus(sender As Object, e As EventArgs) Handles Me.ModeManipulasiDataChanged
        inputTLP.VerticalScroll.Value = 0
        inputTLP.HorizontalScroll.Value = 0
        inputTLP.Refresh()
    End Sub

End Class

Partial Public Class FormTransaksiDetail
    '## Form Init
    Private Sub FormLoad_Init_Insert()
        '-- Title form
        Me.Text = "Buat Transaksi Baru"

        '-- Auto generate ID
        GenerateNewTransID()

        '-- Insert Mode
        SetAvailableMetadataComponents(True)
        SetAvailableShopCartComponents_Return(False)

        '-- Auto generate keterangan
        If String.IsNullOrWhiteSpace(Keterangan) Then
            Keterangan = "No. faktur " + tbNoNota.Text + " periode tahun " + System.DateTime.Today.Year.ToString
        End If

        '-- Auto buka dialog pelanggan
        btnPelangganBrowse.PerformClick()

        '-- Auto generate date
        timerRefreshTgl_Tick(timerRefreshTgl, New EventArgs())
        timerRefreshTgl.Start()

        '-- Auto select tabel
        dgvTabel.Select()
    End Sub




    '## Submission Processing
    Private Sub Submit_Insert()
        If DataSetBelanja.KeranjangBelanja.Count <= 0 Then
            If ShowConfirmMessageBox(Nothing, "Keranjang belanja masih kosong." & vbNewLine & "Apakah mau menutup form ini ?") = DialogResult.OK Then
                Me.Close()
            End If

            Exit Sub
        End If

        SetAvailableShopCartComponents(False)
        SetAvailableSubmitComponents(False)

        Dim noNota = tbNoNota.Text, kodePlg = String.Empty, kodeMk, noPol
        Dim dateBuat, dateLunas As Object
        Dim bayarKurang As Decimal

        If _TotalKembalian < 0 Then
            bayarKurang = Math.Abs(_TotalKembalian)
        End If

        Dim hasil As Integer
        Try
            If _Pelanggan Is Nothing OrElse _Pelanggan.Rows.Count <= 0 Then
                Throw New ArgumentException("Data pelanggan kosong atau tidak valid.", "_Pelanggan")
            End If
            kodePlg = _Pelanggan.Rows(0).Item("kode")

            If _Mekanik IsNot Nothing AndAlso _Mekanik.Rows.Count > 0 Then
                kodeMk = _Mekanik.Rows(0).Item("kode")
            End If

            If _Kendaraan IsNot Nothing AndAlso _Kendaraan.Rows.Count > 0 Then
                noPol = _Kendaraan.Rows(0).Item("nopol")
            End If

            If DateTime.TryParse(tbTglBuat.Text, dateBuat) = False Then
                Throw New FormatException("Gagal parsing tanggal pembuatan transaksi.")
            End If
            If DateTime.TryParse(tbLunas.Text, dateLunas) = False Then
                dateLunas = Nothing
            End If

            '-- Buat transaksi induk
            hasil = tableAdapterTrans.RowInsert(noNota,
                                                kodePlg,
                                                kodeMk,
                                                noPol,
                                                dateBuat,
                                                dateLunas,
                                                bayarKurang,
                                                Keterangan)
            If hasil <= 0 Then
                Throw New DataException("Gagal membuat data transaksi induk baru.")
            End If

            '-- Buat transaksi detail barang
            Submit_Insert_Barang(hasil, noNota)

            '-- Buat transaksi detail jasa
            Submit_Insert_Jasa(hasil, noNota)

            '-- Buat transaksi detail barang (return)
            Submit_Insert_Return_Barang(hasil, noNota)

        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        End Try

        If hasil > 0 Then
            ShowInformationMessageBox(Me, "Transaksi BERHASIL di simpan")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ShowErrorMessageBox(Me, "Transaksi GAGAL di simpan")
            SetAvailableShopCartComponents(True)
            SetAvailableSubmitComponents(True)
        End If
    End Sub




End Class

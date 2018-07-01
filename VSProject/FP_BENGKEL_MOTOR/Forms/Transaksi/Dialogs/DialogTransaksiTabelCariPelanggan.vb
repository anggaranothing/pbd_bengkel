Public NotInheritable Class DialogTransaksiTabelCariPelanggan
    Protected Overrides Sub FormLoaded()
        '-- Isi kolom
        Me.FillColumns(dataSet.PELANGGAN.Columns)

        '-- Inisialisasi tabel database
        tableAdapter.Fill(dataSet.PELANGGAN)
        bindingSource.DataMember = dataSet.PELANGGAN.TableName

        '-- Konfigurasi kolom tabel
        SetFillerColumn(dataSet.PELANGGAN.namaColumn.ColumnName)
        GantiJudulKolom(dataSet.PELANGGAN.kodeColumn.ColumnName, "Kode Pelanggan")
        GantiJudulKolom(dataSet.PELANGGAN.namaColumn.ColumnName, "Nama Pelanggan")
        GantiJudulKolom(dataSet.PELANGGAN.alamatColumn.ColumnName, "Alamat")
        GantiJudulKolom(dataSet.PELANGGAN.teleponColumn.ColumnName, "Telp.")
        GantiJudulKolom(dataSet.PELANGGAN.no_idColumn.ColumnName, "No. Identitas Diri")

        dgvTabel.Columns(dataSet.PELANGGAN.kodeColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader

        Me.ActiveControl = Me.OK_Button
    End Sub
End Class

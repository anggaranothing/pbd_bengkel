Public NotInheritable Class DialogTransaksiTabelCariMekanik
    Protected Overrides Sub FormLoaded()
        '-- Isi kolom
        Me.FillColumns(dataSet.MONTIR.Columns)

        '-- Inisialisasi tabel database
        tableAdapter.Fill(dataSet.MONTIR)
        bindingSource.DataMember = dataSet.MONTIR.TableName

        '-- Konfigurasi kolom tabel
        SetFillerColumn(dataSet.MONTIR.namaColumn.ColumnName)
        GantiJudulKolom(dataSet.MONTIR.statusColumn.ColumnName, "Status Keaktifan Pegawai")
        GantiJudulKolom(dataSet.MONTIR.kodeColumn.ColumnName, "Kode Pegawai")
        GantiJudulKolom(dataSet.MONTIR.namaColumn.ColumnName, "Nama Pegawai")
        GantiJudulKolom(dataSet.MONTIR.alamatColumn.ColumnName, "Alamat")
        GantiJudulKolom(dataSet.MONTIR.teleponColumn.ColumnName, "Telp.")

        dgvTabel.Columns(dataSet.MONTIR.kodeColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
    End Sub
End Class

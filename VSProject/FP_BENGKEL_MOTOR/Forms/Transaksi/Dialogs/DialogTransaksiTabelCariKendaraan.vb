Public NotInheritable Class DialogTransaksiTabelCariKendaraan
    Protected Overrides Sub FormLoaded()
        '-- Isi kolom
        Me.FillColumns(dataSet.KENDARAAN.Columns)

        '-- Inisialisasi tabel database
        tableAdapter.Fill(dataSet.KENDARAAN)
        bindingSource.DataMember = dataSet.KENDARAAN.TableName

        '-- Konfigurasi kolom tabel
        SetFillerColumn(dataSet.KENDARAAN.namaColumn.ColumnName)
        GantiJudulKolom(dataSet.KENDARAAN.nopolColumn.ColumnName, "No. Polisi (TNKB)")
        GantiJudulKolom(dataSet.KENDARAAN.namaColumn.ColumnName, "Jenis Kendaraan")
        GantiJudulKolom(dataSet.KENDARAAN.tahunColumn.ColumnName, "Tahun Pembuatan")
        GantiJudulKolom(dataSet.KENDARAAN.stnkColumn.ColumnName, "No STNK.")

        dgvTabel.Columns(dataSet.KENDARAAN.nopolColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
    End Sub
End Class

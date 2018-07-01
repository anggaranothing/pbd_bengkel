Public NotInheritable Class DialogTransaksiItemBelanjaBarang
    Private selectedDataTable As New DataSetBengkel.BARANGDataTable()
    Private objDialogKeterangan As DialogTransaksiKeterangan

    Protected Overrides Sub FormLoaded()
        '-- Isi kolom
        Me.FillColumns(dataSet.BARANG.Columns)
        cmbKolom.SelectedIndex = 1

        '-- Inisialisasi tabel database
        tableAdapter.Fill(dataSet.BARANG)
        bindingSource.DataMember = dataSet.BARANG.TableName

        '-- Hapus kolom keterangan
        'dgvTabel.Columns.Remove(dataSet.BARANG.ketColumn.ColumnName)
        dgvTabel.Columns(dataSet.BARANG.ketColumn.ColumnName).Visible = False
        cmbKolom.Items.Remove("ket")

        '-- Konfigurasi kolom tabel
        SetFillerColumn(dataSet.BARANG.namaColumn.ColumnName)
        GantiJudulKolom(dataSet.BARANG.kodeColumn.ColumnName, "Kode Barang")
        GantiJudulKolom(dataSet.BARANG.namaColumn.ColumnName, "Nama Barang")
        GantiJudulKolom(dataSet.BARANG.hargaColumn.ColumnName, "Harga per buah")
        GantiJudulKolom(dataSet.BARANG.stokColumn.ColumnName, "Stok Barang")
        'GantiJudulKolom(dataSet.BARANG.ketColumn.ColumnName, "Keterangan Barang")
        GantiJudulKolom(dataSet.BARANG.kodebarColumn.ColumnName, "Universal Product Code (Barcode)")

        With dgvTabel.Columns(dataSet.BARANG.hargaColumn.ColumnName)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .DefaultCellStyle.Format = "C"
        End With

        dgvTabel.Columns(dataSet.BARANG.kodeColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        dgvTabel.Columns(dataSet.BARANG.kodebarColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvTabel.Columns(dataSet.BARANG.stokColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        If EditMode Then
            panelCari.Enabled = False

            '-- Kode, Nama, JenisSatuan, Kuantitas, Harga, TotalHarga, IsDiskonItem, DataJSON
            Dim parsed As Object() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object())(EditData)

            cmbKolom.SelectedIndex = 0
            tbKunci.Text = parsed(0)
            numKuantitas.Value = parsed(3)
            ProsesFilter()
        End If
    End Sub

    Protected Overrides Sub ItemSelected(row As DataGridViewRow)
        selectedDataTable.Clear()
        With row
            selectedDataTable.AddBARANGRow(.Cells("kode").Value _
                                            , "" _
                                            , .Cells("nama").Value _
                                            , .Cells("harga").Value _
                                            , .Cells("stok").Value _
                                            , "")

            '-- Buat ulang dialog keterangan
            If objDialogKeterangan IsNot Nothing Then
                objDialogKeterangan.Dispose()
            End If
            objDialogKeterangan = New DialogTransaksiKeterangan(NullToEmptyString(.Cells("ket").Value))
            objDialogKeterangan.SetReadOnly(True)
            objDialogKeterangan.Text = "Keterangan Barang/Produk"

            Dim identitas As String = NullToEmptyString(.Cells("kodebar").Value)
            If String.IsNullOrWhiteSpace(identitas) Then
                identitas = .Cells("kode").Value
            End If

            tbTerpilih.Text = String.Format("{0} - {1}", identitas, .Cells("nama").Value)

            numKuantitas.Maximum = .Cells("stok").Value
            Cost = .Cells("harga").Value
        End With
    End Sub

    Private Sub numKuantitas_ValueChanged(sender As Object, e As EventArgs) Handles numKuantitas.ValueChanged
        CalculateTotalCost()
    End Sub

    Protected Friend Overrides Sub CalculateTotalCost()
        TotalCost = Cost * numKuantitas.Value
    End Sub

    Protected Friend Overrides Function BuildDataJSON() As String
        Dim tabelDetail As New DataSetBelanja.DetailItemBarangDataTable()
        tabelDetail.AddDetailItemBarangRow(numKuantitas.Value)

        Return Newtonsoft.Json.JsonConvert.SerializeObject(tabelDetail)
    End Function

    Protected Friend Overrides Sub RepopulateOutputs()
        Output.Clear()

        '-- Jika kosong jgn di add !
        If numKuantitas.Value <= 0 Then
            Exit Sub
        End If

        If selectedDataTable.Rows.Count > 0 Then
            With selectedDataTable.Item(0)
                Output.AddKeranjangBelanjaRow(.Item(0), .Item(2), "PCS", numKuantitas.Value, Cost, TotalCost, False, BuildDataJSON())
            End With
        End If
    End Sub

    Private Sub btnKet_Click(sender As Object, e As EventArgs) Handles btnKet.Click
        If objDialogKeterangan IsNot Nothing Then
            objDialogKeterangan.ShowDialog()
            dgvTabel.Select()
        End If
    End Sub
End Class

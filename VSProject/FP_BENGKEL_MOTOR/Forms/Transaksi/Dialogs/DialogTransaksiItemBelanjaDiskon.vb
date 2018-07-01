Public NotInheritable Class DialogTransaksiItemBelanjaDiskon
    Private selectedDataTable As New DataSetBelanja.KeranjangBelanjaDataTable()

    Private _SourceTable As DataSetBelanja.KeranjangBelanjaDataTable = Nothing
    Friend Property SourceTable As DataSetBelanja.KeranjangBelanjaDataTable
        Get
            Return _SourceTable
        End Get
        Set
            _SourceTable = Value

            Dim rowsBukanDiskon As DataRow() = Value.Select("IsDiskonItem = FALSE")

            dataSetBelanja.KeranjangBelanja.Clear()
            For Each row As DataRow In rowsBukanDiskon
                dataSetBelanja.KeranjangBelanja.ImportRow(row)
            Next
        End Set
    End Property

    Private _TableSort As String = Nothing
    Friend Property TableSort As String
        Get
            Return Me.bindingSource.Sort
        End Get
        Set
            _TableSort = Value

            Try
                bindingSource.Sort = Value
            Catch ex As Exception
            End Try
        End Set
    End Property

    Protected Overrides Sub FormLoaded()
        '-- Hancurkan dataSetBengkel
        dataSet.Dispose()
        dataSet = Nothing

        '-- Isi kolom
        Me.FillColumns(dataSetBelanja.KeranjangBelanja.Columns)

        '-- Inisialisasi tabel database
        bindingSource.DataMember = dataSetBelanja.KeranjangBelanja.TableName
        Try
            bindingSource.Sort = _TableSort
        Catch ex As Exception
        End Try

        '-- Hapus kolom khusus
        With dataSetBelanja.KeranjangBelanja
            dgvTabel.Columns(.IsDiskonItemColumn.ColumnName).Visible = False
            dgvTabel.Columns(.DataJSONColumn.ColumnName).Visible = False
        End With
        cmbKolom.Items.Remove("IsDiskonItem")
        cmbKolom.Items.Remove("DataJSON")

        '-- Konfigurasi kolom tabel
        With dataSetBelanja.KeranjangBelanja
            SetFillerColumn(.NamaColumn.ColumnName)
            GantiJudulKolom(.NamaColumn.ColumnName, "Nama Item")
            GantiJudulKolom(.KodeColumn.ColumnName, "Kode Item")
            GantiJudulKolom(.JenisSatuanColumn.ColumnName, "Satuan")
            GantiJudulKolom(.KuantitasColumn.ColumnName, "Qty.")
            GantiJudulKolom(.HargaColumn.ColumnName, "Harga")
            GantiJudulKolom(.TotalHargaColumn.ColumnName, "TOTAL")
        End With

        With dgvTabel.Columns
            .Item(dataSetBelanja.KeranjangBelanja.KodeColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .Item(dataSetBelanja.KeranjangBelanja.JenisSatuanColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Item(dataSetBelanja.KeranjangBelanja.KuantitasColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            With .Item(dataSetBelanja.KeranjangBelanja.HargaColumn.ColumnName)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Format = "C"
            End With
            With .Item(dataSetBelanja.KeranjangBelanja.TotalHargaColumn.ColumnName)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Format = "C"
            End With
        End With

        If EditMode Then
            panelCari.Enabled = False

            '-- Kode, Nama, JenisSatuan, Kuantitas, Harga, TotalHarga, IsDiskonItem, DataJSON
            Dim parsed As Object() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object())(EditData)
            Dim parsedTable As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(parsed(7))

            cmbKolom.SelectedIndex = 0
            tbKunci.Text = parsedTable.Rows(0).Item("Kode")
            ProsesFilter()

            numDiscPercentage.Value = parsed(3)
        End If
    End Sub

    Protected Overrides Sub ItemSelected(row As DataGridViewRow)
        selectedDataTable.Clear()
        With row
            selectedDataTable.AddKeranjangBelanjaRow(.Cells("Kode").Value _
                                                     , .Cells("Nama").Value _
                                                     , "" _
                                                     , .Cells("Kuantitas").Value _
                                                     , .Cells("Harga").Value _
                                                     , .Cells("TotalHarga").Value _
                                                     , False _
                                                     , "")

            tbTerpilih.Text = String.Format("{0} - {1}", NullToEmptyString(.Cells("Kode").Value), .Cells("Nama").Value)

            Cost = .Cells("TotalHarga").Value
            HitungTotalDiskon()
        End With
    End Sub

    Private Sub numDiscTotal_ValueChanged(sender As Object, e As EventArgs) Handles numDiscTotal.ValueChanged
        Try
            Dim persen As Decimal = (numDiscTotal.Value / Cost) * 100
            If persen > 100 Then
                ShowErrorMessageBox(Nothing, "Total diskon bernilai lebih besar daripada total harga !")
                numDiscTotal.Value = 0
            ElseIf persen < 0 Then
                ShowErrorMessageBox(Nothing, "Total diskon bernilai negatif !")
                numDiscTotal.Value = 0
            End If
        Catch ex As Exception
            numDiscTotal.Value = 0
        End Try

        CalculateTotalCost()
    End Sub

    Private Sub numDiscPercentage_ValueChanged(sender As Object, e As EventArgs) Handles numDiscPercentage.ValueChanged
        HitungTotalDiskon()
    End Sub

    Private Sub HitungTotalDiskon()
        Dim percent As Decimal = (numDiscPercentage.Value / 100)

        numDiscTotal.Value = Cost * percent
    End Sub

    Protected Friend Overrides Sub CalculateTotalCost()
        TotalCost = Cost - numDiscTotal.Value
    End Sub

    Protected Friend Overrides Function BuildDataJSON() As String
        Dim tabelDetail As New DataSetBelanja.DetailItemDiskonDataTable()

        With selectedDataTable.Rows
            If .Count > 0 Then
                tabelDetail.AddDetailItemDiskonRow(.Item(0).Item("Kode"), numDiscPercentage.Value)
            End If
        End With

        Return Newtonsoft.Json.JsonConvert.SerializeObject(tabelDetail)
    End Function

    Protected Friend Overrides Sub RepopulateOutputs()
        Output.Clear()

        If selectedDataTable.Rows.Count > 0 Then
            With selectedDataTable.Item(0)
                Output.AddKeranjangBelanjaRow(String.Format(Pengodean.Tabel.ItemBelanjaDiskon & "-{0}", .Item("Kode")),
                                              String.Format("(DISC. {0}%) {1}", numDiscPercentage.Value, .Item("Nama")),
                                              "%",
                                              numDiscPercentage.Value,
                                              Cost,
                                              -numDiscTotal.Value,
                                              True,
                                              BuildDataJSON())
            End With
        End If
    End Sub
End Class

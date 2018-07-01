Public NotInheritable Class DialogTransaksiItemBelanjaJasa
    Private selectedDataTable As New DataSetBengkel.JASADataTable()

    Private _WaktuPerMenit As Decimal
    Property BatasWaktuPerMenit As Decimal
        Get
            Return _WaktuPerMenit
        End Get
        Private Set
            _WaktuPerMenit = Value
            OnWaktuPerMenitChanged()
        End Set
    End Property
    Private Sub OnWaktuPerMenitChanged()
        If _WaktuPerMenit <= 0 Then
            gbTglJasa.Enabled = False
            lblWaktu.Text = "(Tidak ada batasan waktu)"
        Else
            gbTglJasa.Enabled = True
            lblWaktu.Text = String.Format("per {0:N2} Menit", _WaktuPerMenit)
        End If

        CalculateTotalCost()
    End Sub

    Private _LamaPengerjaanPerMenit As Double
    Property LamaPengerjaanPerMenit As Double
        Get
            Return _LamaPengerjaanPerMenit
        End Get
        Private Set
            If Value < 0 Then
                ShowErrorMessageBox(Nothing, "Rentang waktu pengerjaan bernilai negatif !")
                Value = 0
            End If

            _LamaPengerjaanPerMenit = Math.Ceiling(a:=Value)
            OnLamaPengerjaanPerMenitChanged()
        End Set
    End Property
    Private Sub OnLamaPengerjaanPerMenitChanged()
        lblLamaPengerjaan.Text = String.Format("Selama {0:N2} Menit", LamaPengerjaanPerMenit)

        CalculateTotalCost()
    End Sub

    Private Sub EventDTPValueChanged_CalculateLamaPelaksanaan(sender As Object, e As EventArgs) Handles dtpTglMulai.ValueChanged, dtpTglAkhir.ValueChanged
        Dim selesai, mulai As Date

        With dtpTglAkhir.Value
            selesai = New DateTime(.Year, .Month, .Day, .Hour, .Minute, 0)
        End With

        With dtpTglMulai.Value
            mulai = New DateTime(.Year, .Month, .Day, .Hour, .Minute, 0)
        End With

        If selesai.CompareTo(mulai) < 0 Then
            dtpTglAkhir.Value = mulai
            Exit Sub '-- Keluar dari event karena dtpTglAkhir akan memicu event ini lagipula. :v
        End If

        LamaPengerjaanPerMenit = (selesai - mulai).TotalMinutes
    End Sub

    Protected Overrides Sub FormLoaded()
        '-- Isi kolom
        Me.FillColumns(dataSet.JASA.Columns)

        '-- Inisialisasi tabel database
        tableAdapter.Fill(dataSet.JASA)
        bindingSource.DataMember = dataSet.JASA.TableName

        '-- Konfigurasi kolom tabel
        SetFillerColumn(dataSet.JASA.namaColumn.ColumnName)
        GantiJudulKolom(dataSet.JASA.kodeColumn.ColumnName, "Kode Jasa")
        GantiJudulKolom(dataSet.JASA.namaColumn.ColumnName, "Nama Jasa")
        GantiJudulKolom(dataSet.JASA.hargaColumn.ColumnName, "Harga per Menit")
        GantiJudulKolom(dataSet.JASA.waktu_menitColumn.ColumnName, "Waktu per Menit")

        With dgvTabel.Columns(dataSet.JASA.hargaColumn.ColumnName)
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            .DefaultCellStyle.Format = "C"
        End With

        dgvTabel.Columns(dataSet.JASA.kodeColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        dgvTabel.Columns(dataSet.JASA.hargaColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvTabel.Columns(dataSet.JASA.waktu_menitColumn.ColumnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        '-- Inisialisasi komponen form
        OnWaktuPerMenitChanged()
        OnLamaPengerjaanPerMenitChanged()
        Dim polaWaktu As String = Globalization.DateTimeFormatInfo.CurrentInfo.ShortDatePattern & " " & Globalization.DateTimeFormatInfo.CurrentInfo.ShortTimePattern
        dtpTglMulai.CustomFormat = polaWaktu
        dtpTglAkhir.CustomFormat = polaWaktu

        If EditMode Then
            panelCari.Enabled = False

            '-- Kode, Nama, JenisSatuan, Kuantitas, Harga, TotalHarga, IsDiskonItem, DataJSON
            Dim parsed As Object() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object())(EditData)

            cmbKolom.SelectedIndex = 0
            tbKunci.Text = parsed(0)
            ProsesFilter()

            Dim parsedTable As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(parsed(7))
            dtpTglMulai.Value = parsedTable.Rows(0).Item("tgl_mulai")
            dtpTglAkhir.Value = parsedTable.Rows(0).Item("tgl_selesai")
        End If
    End Sub

    Protected Overrides Sub ItemSelected(row As DataGridViewRow)
        selectedDataTable.Clear()
        With row
            Dim kode As Object = .Cells("kode").Value,
                nama As Object = .Cells("nama").Value,
                harga As Object = .Cells("harga").Value,
                waktu As Object = .Cells("waktu_menit").Value

            If IsNothing(waktu) Or IsDBNull(waktu) OrElse Convert.ToDecimal(waktu) <= 0 Then
                waktu = 0
            End If

            selectedDataTable.AddJASARow(kode _
                                        , nama _
                                        , harga _
                                        , waktu)

            Dim identitas As String = NullToEmptyString(kode)
            tbTerpilih.Text = String.Format("{1} [{0}]", identitas, nama)

            Cost = harga
            BatasWaktuPerMenit = waktu
        End With
    End Sub

    Protected Friend Overrides Sub CalculateTotalCost()
        Dim total As Decimal = Cost
        If BatasWaktuPerMenit > 0 Then
            Dim totalWaktuBayar As Double = Math.Ceiling(a:=LamaPengerjaanPerMenit \ Convert.ToDouble(BatasWaktuPerMenit))
            total *= totalWaktuBayar
        End If

        TotalCost = total
    End Sub

    Protected Friend Overrides Function BuildDataJSON() As String
        Dim selesai, mulai As Date
        With dtpTglAkhir.Value
            selesai = New DateTime(.Year, .Month, .Day, .Hour, .Minute, 0)
        End With

        With dtpTglMulai.Value
            mulai = New DateTime(.Year, .Month, .Day, .Hour, .Minute, 0)
        End With

        Dim tabelDetail As New DataSetBelanja.DetailItemJasaDataTable()
        tabelDetail.AddDetailItemJasaRow(mulai, selesai)

        Return Newtonsoft.Json.JsonConvert.SerializeObject(tabelDetail)
    End Function

    Protected Friend Overrides Sub RepopulateOutputs()
        Output.Clear()

        If selectedDataTable.Rows.Count > 0 Then
            Dim strSatuan As String = String.Format("!Per {0} Menit", BatasWaktuPerMenit)
            If gbTglJasa.Enabled = False Then
                strSatuan = "-"
            End If

            With selectedDataTable.Item(0)
                Output.AddKeranjangBelanjaRow(.Item(0), .Item(1), strSatuan, LamaPengerjaanPerMenit, Cost, TotalCost, False, BuildDataJSON())
            End With
        End If
    End Sub
End Class

'TODO Kalo mau membuat form khusus untuk tabel database, buat nya pake "Inherited Form". Cara nya : Klik menu Project->Add New Item, pilih "Inherited Form", trus pilih "FormTabelGenerik", trus tekan OK
'TODO Perubahan APAPUN yang terjadi pada FormTabelGenerik AKAN MEMPENGARUHI form tabel turunan yang lain nya.
'TODO "FormTabelGenerik" merupakan form turunan (inherited) dari FormGenerik, dengan kata lain form ini sudah menerapkan otentikasi dan otorisasi
'TODO Setiap buat form tabel, pastikan ubah properti sourceTabel.DataMember sesuai dengan nama tabel database yg ingin di pakai
'TODO Setiap buat form tabel, pastikan juga untuk menyetel DataSource viewTabelDB ( viewTabelDb.DataSource = sourceTabel ) di dalam method TabelInit()
'TODO Setiap buat form tabel, buatlah komponen grafis untuk manipulasi data. Contoh nya liat di FormTabelMontir


Public Class FormTabelGenerik
    '-- Event Kustom
    '---------------
    ''' <summary>
    ''' Terjadi ketika properti ApakahModeInsertData berubah nilai nya.
    ''' </summary>
    Public Event ApakahModeInsertDataChanged As EventHandler(Of EventArgs)

    '-- Properti
    '-----------
    Protected _IsTableFilled As Boolean
    Public ReadOnly Property IsTableFilled As Boolean
        Get
            Return _IsTableFilled
        End Get
    End Property

    Private _IsModeInsertData As Boolean = True
    <System.ComponentModel.Description("Bernilai TRUE jika mode manipulasi data berada dalam mode insert/tambah data.")>
    Public Property ApakahModeInsertData() As Boolean
        Get
            Return _IsModeInsertData
        End Get
        Set(ByVal value As Boolean)
            _IsModeInsertData = value
            OnApakahModeInsertDataChanged(New EventArgs())
        End Set
    End Property

    Protected _IndeksEditBaris As Integer
    Public ReadOnly Property IndeksEditBaris As Integer
        Get
            Return _IndeksEditBaris
        End Get
    End Property

    'TODO Setiap buat form tabel, Terapkan/override method-method dibawah ini. Contoh nya liat di FormTabelMontir
    '-----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Dijalankan ketika DataGridView sedang di persiapkan untuk di isi.
    ''' </summary>
    Protected Overridable Sub TabelInit()
        '--- Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika DataGridView akan di isi.
    ''' </summary>
    Protected Overridable Sub TabelFill()
        '--- Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika DataGridView sudah dalam keadaan siap pakai.
    ''' </summary>
    Protected Overridable Sub TabelInitialized()
        '--- Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika perintah tambah data akan di laksanakan.
    ''' </summary>
    Protected Overridable Sub TabelBarisTambah()
        Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika tombol Edit ditekan.
    ''' </summary>
    ''' <param name="posisi">Posisi baris (row) pada DataGridView.</param>
    Protected Overridable Sub TabelBarisEdit(posisi As Integer)
        Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika tombol Submit ditekan dan dalam kondisi Edit Data.
    ''' </summary>
    Protected Overridable Sub TabelBarisEditSubmit()
        Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika perintah hapus data akan di laksanakan.
    ''' </summary>
    ''' <param name="posisi">Posisi baris (row) pada DataGridView.</param>
    Protected Overridable Sub TabelBarisHapus(posisi As Integer)
        Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Dijalankan ketika komponen input akan di bersihkan.
    ''' </summary>
    Protected Overridable Sub TabelInputReset()
        '--- Try : Throw New NotImplementedException() : Catch ex As NotImplementedException : ShowExceptionMessage(ex) : End Try
    End Sub

    ''' <summary>
    ''' Ganti judul (header) kolom.
    ''' </summary>
    ''' <param name="namaKolom">Nama variabel kolom. Biasa nya sama seperti nama kolom di tabel database.</param>
    ''' <param name="judulKolom">Judul kolom.</param>
    Protected Sub GantiJudulKolom(namaKolom As String, judulKolom As String)
        If judulKolom = Nothing Then
            judulKolom = namaKolom
        End If

        Try
            With viewTabelDb.Columns(namaKolom)
                .HeaderText = judulKolom
            End With
        Catch ex As Exception
            ShowExceptionMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Ganti judul (header) kolom.
    ''' </summary>
    ''' <param name="posisiKolom">Posisi kolom pada DataGridView.</param>
    ''' <param name="judulKolom">Judul kolom.</param>
    Protected Sub GantiJudulKolom(posisiKolom As Integer, judulKolom As String)
        GantiJudulKolom(GetNamaVariabelKolom(posisiKolom), judulKolom)
    End Sub

    ''' <summary>
    ''' Memperoleh nama variabel kolom di dalam DataGridView.
    ''' </summary>
    ''' <param name="posisiKolom">Posisi kolom pada DataGridView.</param>
    ''' <returns></returns>
    Protected Function GetNamaVariabelKolom(posisiKolom As Integer) As String
        Try
            Return viewTabelDb.Columns(posisiKolom).HeaderText
        Catch ex As Exception
            ShowExceptionMessage(ex)
        End Try

        Return Nothing
    End Function

    ''' <summary>
    ''' Di gunakan untuk mendapatkan nilai kolom pada suatu baris DataGridView.
    ''' </summary>
    ''' 
    ''' <param name="posisiBaris">
    ''' Posisi baris (row).
    ''' </param>
    ''' 
    ''' <param name="namaKolom">
    ''' Nama kolom sesuai dengan yang ada di database.
    ''' </param>
    ''' 
    ''' <returns>
    ''' Objek DataGridViewCell.
    ''' </returns>
    Friend Function GetDataBaris(posisiBaris As Integer, namaKolom As String) As DataGridViewCell
        Return viewTabelDb.Rows.Item(posisiBaris).Cells.Item(namaKolom)
    End Function

    Friend Sub SelectBarisTerakhir()
        sourceTabel.Sort = String.Empty
        viewTabelDb.ClearSelection()
        Dim objekBaris As DataGridViewRow = viewTabelDb.Rows.Item(viewTabelDb.Rows.GetLastRow(DataGridViewElementStates.Visible))
        objekBaris.Selected = True
        viewTabelDb.FirstDisplayedScrollingRowIndex = objekBaris.Index
        viewTabelDb.FirstDisplayedScrollingColumnIndex = 0
    End Sub
    Private Sub JadikanModeInsertData()
        ckbTampilContainerData.Checked = True
        tabletTabel.SelectTab(tab2Manipulasi)

        If _IsModeInsertData = False Then
            ApakahModeInsertData = True
        End If
    End Sub
    Private Sub LakukanEditBaris()
        '-- Tidak ada baris yang terpilih (selected)
        If viewTabelDb.SelectedCells.Count <= 0 Then
            ShowErrorMessageBox(Me, "Pilih baris terdahulu sebelum melakukan edit!")
            Return
        End If

        ckbTampilContainerData.Checked = True
        viewTabelDb.Enabled = False

        Dim rowIndex As Integer = viewTabelDb.SelectedCells.Item(0).RowIndex
        viewTabelDb.ClearSelection()
        viewTabelDb.Rows.Item(rowIndex).Selected = True

        tabletTabel.SelectTab(tab2Manipulasi)
        ApakahModeInsertData = False
        _IndeksEditBaris = rowIndex
        TabelBarisEdit(rowIndex)

        viewTabelDb.Enabled = True
    End Sub
    Private Sub LakukanHapusBaris()
        '-- Dalam mode Edit Data?
        If ApakahModeInsertData = False Then
            ckbTampilContainerData.Checked = True
            tabletTabel.SelectTab(tab2Manipulasi)
            inputBtnSwitchToInsert.Select()
            ShowErrorMessageBox(Me, "Hapus data tidak dapat di lakukan di dalam mode Edit Data." & vbNewLine & "Silahkan pindah dulu ke mode Tambah Data.")
            Return
        End If

        '-- Tidak ada baris yang terpilih (selected)
        If viewTabelDb.SelectedCells.Count <= 0 Then
            ShowErrorMessageBox(Me, "Pilih baris terdahulu sebelum melakukan hapus!")
            Return
        End If

        viewTabelDb.Enabled = False

        Dim rowIndex As Integer = viewTabelDb.SelectedCells.Item(0).RowIndex
        viewTabelDb.ClearSelection()
        viewTabelDb.Rows.Item(rowIndex).Selected = True

        TabelBarisHapus(rowIndex)

        viewTabelDb.Enabled = True
    End Sub
    Private Sub InsertRumusFilter(ByVal rumus As String)
        Dim posisi As Integer = rtbSearchRumusFilter.SelectionStart + rtbSearchRumusFilter.SelectionLength
        rumus = String.Format("{0} ", rumus)

        rtbSearchRumusFilter.Text = rtbSearchRumusFilter.Text.Insert(posisi, rumus)

        rtbSearchRumusFilter.Select(posisi + rumus.Length, 0)
        rtbSearchRumusFilter.Select()
    End Sub

    '-- Macam-macam event esensial
    '-----------------------
    Private Sub btnRefillTable_Click(sender As Object, e As EventArgs) Handles btnRefillTable.Click
        btnRefillTable.Enabled = False
        Try
            TabelFill()
        Catch ex As Exception
            ShowExceptionMessage(ex)
        Finally
            btnRefillTable.Enabled = True
        End Try
    End Sub
    Private Sub EventButtonClick_SwitchToInsert(sender As Object, e As EventArgs) Handles inputBtnSwitchToInsert.Click
        ApakahModeInsertData = True
    End Sub
    Private Sub EventButtonClick_SubmitRow(sender As Object, e As EventArgs) Handles inputBtnSubmit.Click
        tab2Manipulasi.Enabled = False

        If ApakahModeInsertData Then
            TabelBarisTambah()
        Else
            TabelBarisEditSubmit()
        End If

        tab2Manipulasi.Enabled = True
    End Sub
    Private Sub EventButtonClick_EditRow(sender As Object, e As EventArgs)
        LakukanEditBaris()
    End Sub
    Private Sub EventButtonClick_EraseRow(sender As Object, e As EventArgs)
        LakukanHapusBaris()
    End Sub

    Private Sub EventButtonClick_InsertTextIntoRumusFilter(sender As Object, e As EventArgs) Handles btnSearchFilterAdd.Click, btnSearchFilterDiv.Click, btnSearchFilterMod.Click, btnSearchFilterMulti.Click, btnSearchFilterSubtract.Click, btnSearchFilterOr.Click, btnSearchFilterNotEqual.Click, btnSearchFilterMoreEqual.Click, btnSearchFilterMore.Click, btnSearchFilterLike.Click, btnSearchFilterLessEqual.Click, btnSearchFilterLess.Click, btnSearchFilterIn.Click, btnSearchFilterEqual.Click, btnSearchFilterAnd.Click, btnSearchFilterTrue.Click, btnSearchFilterParent.Click, btnSearchFilterIsNull.Click, btnSearchFilterFalse.Click, btnSearchFilterChild.Click, btnSearchFilterBetween.Click, btnSearchFilterIsNotNull.Click, btnSearchFilterOrKurungBuka.Click, btnSearchFilterKurungTutup.Click
        Dim btn As Button = sender
        InsertRumusFilter(btn.Text)
    End Sub
    Private Sub EventButtonClick_ProcessFilter(sender As Object, e As EventArgs)
        Dim filterString As String = rtbSearchRumusFilter.Text
        filterString.Trim()
        Try
            sourceTabel.Filter = filterString
        Catch ex As Exception
            sourceTabel.RemoveFilter()
            ShowErrorMessageBox(Me, ex.Message)
        End Try
    End Sub
    Private Sub EventButtonClick_ClearFilter(sender As Object, e As EventArgs)
        sourceTabel.RemoveFilter()
        rtbSearchRumusFilter.ResetText()
    End Sub

    '-- Sisa-nya event ecek-ecek
    '---------------------------
    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckbTampilContainerData.Checked = Not My.Settings.PercepatLoadingForm

        viewTabelDb.AutoGenerateColumns = True
        TabelInit()
        bgTabelFill.RunWorkerAsync()
        OnApakahModeInsertDataChanged(New EventArgs())
    End Sub
    Private Sub form_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        timerCekPeranUser.Stop()
        bgTabelFill.CancelAsync()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        JadikanModeInsertData()
    End Sub

    Protected Overridable Sub OnApakahModeInsertDataChanged(e As EventArgs)
        RaiseEvent ApakahModeInsertDataChanged(Me, e)
    End Sub

    Private Sub form_InputModeInsertChanged(sender As Object, e As EventArgs) Handles Me.ApakahModeInsertDataChanged
        Dim Value = _IsModeInsertData

        inputBtnSwitchToInsert.Enabled = Not Value
        scManipulasi.Panel1Collapsed = Value
        inputGB.Text = IIf(Value, "Mode Tambah", "Mode Edit")

        If Value = True Then
            TabelInputReset()
        End If
    End Sub

    Private Sub bgTabelFill_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgTabelFill.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        worker.ReportProgress(0)
        Try
            TabelFill()
        Catch ex As Exception
            ShowExceptionMessage(ex)
        Finally
            worker.ReportProgress(1)
        End Try
    End Sub
    Private Sub bgTabelFill_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgTabelFill.ProgressChanged
        If e.ProgressPercentage <> 1 Then
            Me.UseWaitCursor = True
            statusLabel.Text = "Processing..."
        Else
            statusLabel.Text = "Done"
        End If
    End Sub
    Private Sub bgTabelFill_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgTabelFill.RunWorkerCompleted
        Me.UseWaitCursor = False

        If e.Cancelled = False And e.Error Is Nothing Then
            '-- Binding (menyambungkan) dataset ke komponen DataGridView
            sourceTabel.ResetBindings(True) '-- Bugfix
            TabelInitialized()
            rtbSearchRumusFilter.Text = sourceTabel.Filter
            TabelInputReset()
            viewTabelDb.ClearSelection()

            scManipulasi.Enabled = IsTableFilled
        End If
    End Sub

    Private Sub ResetRowHeader(grid As DataGridView, indeksBaris As Integer)
        If grid IsNot Nothing Then
            Try
                grid.Rows(indeksBaris).HeaderCell.Value = (indeksBaris + 1).ToString()
            Catch ex As Exception
                ex = Nothing
            End Try
        End If
    End Sub
    Private Sub ResetRowHeader(grid As DataGridView)
        If grid IsNot Nothing Then
            For Each baris As DataGridViewRow In grid.Rows
                ResetRowHeader(grid, baris.Index)
            Next
        End If
    End Sub
    Private Sub viewTabel_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles viewTabelDb.RowsAdded
        Dim grid As DataGridView = CType(sender, DataGridView)
        ResetRowHeader(grid, grid.Rows.Count - 1)
    End Sub
    Private Sub viewTabel_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewTabelDb.RowsRemoved
        Dim grid As DataGridView = CType(sender, DataGridView)
        ResetRowHeader(grid)
    End Sub

    Private Sub RefillDaftarCariKolom()
        lbSearchDaftarKolom.Items.Clear()

        For Each kolom As DataGridViewColumn In viewTabelDb.Columns
            lbSearchDaftarKolom.Items.Add(String.Format("{0} ({1})", kolom.DataPropertyName, kolom.HeaderText))
        Next
    End Sub
    Private Sub viewTabel_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles viewTabelDb.ColumnAdded
        RefillDaftarCariKolom()
    End Sub
    Private Sub viewTabel_ColumnRemoved(sender As Object, e As DataGridViewColumnEventArgs) Handles viewTabelDb.ColumnRemoved
        RefillDaftarCariKolom()
    End Sub

    Private Sub lbSearchDaftarKolom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lbSearchDaftarKolom.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            InsertRumusFilter(viewTabelDb.Columns(lbSearchDaftarKolom.SelectedIndex).DataPropertyName)
            lbSearchDaftarKolom.ClearSelected()
        End If
    End Sub
    Private Sub lbSearchDaftarKolom_DoubleClick(sender As Object, e As EventArgs) Handles lbSearchDaftarKolom.DoubleClick
        InsertRumusFilter(viewTabelDb.Columns(lbSearchDaftarKolom.SelectedIndex).DataPropertyName)
        lbSearchDaftarKolom.ClearSelected()
    End Sub

    Private Sub rtbSearchRumusFilter_SelectionChanged(sender As Object, e As EventArgs) Handles rtbSearchRumusFilter.SelectionChanged
        navTabelFilterPosisi.Text = (rtbSearchRumusFilter.SelectionStart + rtbSearchRumusFilter.SelectionLength)
    End Sub

    Private Sub ckbTampilContainerData_CheckedChanged(sender As Object, e As EventArgs) Handles ckbTampilContainerData.CheckedChanged
        Dim obj As CheckBox = sender
        If obj IsNot Nothing Then
            scGenerik.Panel2Collapsed = Not obj.Checked
        End If
    End Sub
End Class
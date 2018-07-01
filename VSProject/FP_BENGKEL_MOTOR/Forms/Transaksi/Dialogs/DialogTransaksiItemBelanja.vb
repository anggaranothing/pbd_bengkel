Imports System.Windows.Forms

Public Class DialogTransaksiItemBelanja
    Private kondisiFilter As String
    Private kolomFilter As String

    Private _Output As New DataSetBelanja.KeranjangBelanjaDataTable()
    <System.ComponentModel.Description("Hasil keluaran/output.")>
    Property Output As DataSetBelanja.KeranjangBelanjaDataTable
        Get
            Return _Output
        End Get
        Protected Set
            _Output = Value
        End Set
    End Property

    Private _EditMode As Boolean
    <System.ComponentModel.Description("TRUE jika form ini dalam mode edit item belanja.")>
    Property EditMode As Boolean
        Get
            Return _EditMode
        End Get
        Protected Set
            _EditMode = Value
        End Set
    End Property

    <System.ComponentModel.Description("Data input JSON untuk mode edit.")>
    Protected Property EditData As String

    Private _Cost As Decimal
    <System.ComponentModel.Description("Besarnya harga item.")>
    Property Cost As Decimal
        Get
            Return _Cost
        End Get
        Set
            _Cost = Value
            lblHarga.Text = String.Format("{0:C}", Value)
            CalculateTotalCost()
        End Set
    End Property

    Private _TotalCost As Decimal
    <System.ComponentModel.Description("Besarnya total harga item.")>
    Property TotalCost As Decimal
        Get
            Return _TotalCost
        End Get
        Protected Set
            _TotalCost = Value
            lblTotal.Text = String.Format("{0:C}", Value)
        End Set
    End Property

    'Protected Friend Sub EditThis(row As DataRowView)s
    '    EditThis(row.Row)
    'End Sub

    Protected Friend Sub EditThis(row As DataRow)
        EditMode = True

        EditData = Newtonsoft.Json.JsonConvert.SerializeObject(row.ItemArray)
        'System.Console.Out.WriteLine(EditData)
    End Sub

    Protected Overridable Sub FormLoaded()
    End Sub
    Protected Overridable Sub OnDataBindingCompleted(sender As Object, e As DataGridViewBindingCompleteEventArgs)
    End Sub
    Protected Friend Overridable Sub RepopulateOutputs()
    End Sub
    Protected Overridable Sub ItemSelected(row As DataGridViewRow)
    End Sub
    Protected Friend Overridable Sub CalculateTotalCost()
    End Sub
    Protected Friend Overridable Function BuildDataJSON() As String
        Return String.Empty
    End Function

    Protected Friend Sub SelectBarisTeratas()
        If bindingSource.Count > 0 Then
            If dgvTabel.Rows.Count > 0 Then
                dgvTabel.Rows(0).Selected = True
                dgvTabel.CurrentCell = dgvTabel.Rows(0).Cells(0)

                dgvTabel.FirstDisplayedScrollingRowIndex = 0
                dgvTabel.FirstDisplayedScrollingColumnIndex = 0
            End If
        End If
    End Sub

    Protected Sub FillColumns(dCC As DataColumnCollection)
        If dCC Is Nothing OrElse dCC.Count <= 0 Then
            Exit Sub
        End If

        '-- Bersihkan isian yg lama
        cmbKolom.Items.Clear()

        '-- Isi yg baru
        For Each col As DataColumn In dCC
            cmbKolom.Items.Add(col.ColumnName)
        Next

        '--Final touch
        cmbKolom.SelectedIndex = 0
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
            With dgvTabel.Columns(namaKolom)
                .HeaderText = judulKolom
            End With
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Menjadikan suatu kolom sebagai pengisi kekosongan tabel, dan mengubah kolom lainnya menjadi NotSet.
    ''' </summary>
    ''' <param name="namaKolom">Nama variabel kolom. Biasa nya sama seperti nama kolom di tabel database.</param>
    Protected Sub SetFillerColumn(namaKolom As String)
        Try
            For Each col As DataGridViewColumn In dgvTabel.Columns
                With col
                    If .DataPropertyName = namaKolom Then
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Else
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                    End If
                End With
            Next
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        End Try
    End Sub

    Protected Friend Sub ResetFilter()
        bindingSource.Filter = Nothing

        SelectBarisTeratas()
    End Sub
    Protected Friend Sub ProsesFilter()
        dgvTabel.ClearSelection()

        If String.IsNullOrWhiteSpace(tbKunci.Text) Then
            bindingSource.Filter = kolomFilter & " IS NULL" & " OR " & kolomFilter & " = ''"
        Else
            bindingSource.Filter = String.Format(kolomFilter & " " & kondisiFilter, tbKunci.Text)
        End If

        '--System.Console.Out.WriteLine(bsTabelUtama.Filter)

        SelectBarisTeratas()
    End Sub

    Private Sub EventFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = tbKunci
        cmbKolom.SelectedIndex = 0
        cmbKondisi.SelectedIndex = 0
        tbTerpilih.Text = "(TIDAK ADA)"
        dgvTabel.AutoGenerateColumns = True

        Me.MinimumSize = Me.Size

        FormLoaded()
    End Sub

    Private Sub cmbKolom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKolom.SelectedIndexChanged
        kolomFilter = String.Format("Convert({0}, 'System.String')", cmbKolom.SelectedItem)
    End Sub

    Private Sub cmbKondisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKondisi.SelectedIndexChanged
        Select Case cmbKondisi.SelectedIndex
            Case 0
                kondisiFilter = " LIKE " & "'%" & "{0}" & "%'"
            Case 1
                kondisiFilter = " = '" & "{0}" & "'"
        End Select
    End Sub

    Private Sub tbKunci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKunci.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCari.PerformClick()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ProsesFilter()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFilter()
    End Sub

    Private Sub dgvTabel_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTabel.SelectionChanged
        If dgvTabel.SelectedRows.Count > 0 Then
            ItemSelected(dgvTabel.SelectedRows(0))
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        RepopulateOutputs()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgvTabel_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTabel.DataBindingComplete
        OnDataBindingCompleted(sender, e)
        SelectBarisTeratas()
    End Sub
End Class

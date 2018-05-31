Imports System.Windows.Forms

Public Class FormTabelGenerik

    '-- Method untuk manipulasi tabel view
    Protected Friend Sub BuatKolomBaru(objectKolom As DataGridViewColumn, namaKolom As String, Optional namaHeader As String = Nothing)
        Dim posisiKolom As Integer = Me.tabelSeparator001.Index

        If namaHeader = Nothing Then
            namaHeader = namaKolom
        End If

        objectKolom.Name = "kolom_" + namaKolom
        objectKolom.HeaderText = namaHeader
        objectKolom.DataPropertyName = namaKolom

        objectKolom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        objectKolom.ReadOnly = True
        objectKolom.SortMode = Nothing

        Me.viewTabel.Columns.Insert(posisiKolom, objectKolom)

    End Sub

    '-- Method yang akan di override
    Protected Overridable Sub InitTabel()
    End Sub

    Protected Overridable Sub EditBaris(posisi As Integer)
        Call ShowExceptionMessage(Me, "EditBaris() belum di-implementasikan")
    End Sub

    Protected Overridable Sub HapusBaris(posisi As Integer)
        Call ShowExceptionMessage(Me, "HapusBaris() belum di-implementasikan")
    End Sub

    Protected Overridable Sub TambahBaris()
        Call ShowExceptionMessage(Me, "TambahBaris() belum di-implementasikan")
    End Sub

    '-- Method dari form
    Protected Overridable Sub EventFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub EventTableCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewTabel.CellContentClick
        If Me.viewTabel.Columns.Item(e.ColumnIndex).GetType().Name = "DataGridViewButtonColumn" Then
            Me.viewTabel.Enabled = False

            Dim rowIndex As Integer = Me.viewTabel.SelectedCells.Item(0).RowIndex
            Me.viewTabel.ClearSelection()
            Me.viewTabel.Rows.Item(rowIndex).Selected = True

            Dim columnIndex = e.ColumnIndex
            If columnIndex = Me.tabelBtnEdit.DisplayIndex Then
                EditBaris(rowIndex)
            ElseIf columnIndex = Me.tabelBtnHapus.DisplayIndex Then
                HapusBaris(rowIndex)
            End If

            Me.viewTabel.Enabled = True
        End If
    End Sub

End Class
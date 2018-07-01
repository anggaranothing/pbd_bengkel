Public Class FormTabelKodeDinamis
    Inherits FormTabelGenerik

    '-- Event Kustom
    '---------------
    <System.ComponentModel.Description("Terjadi ketika form perlu meng-update variabel 'Kode' dalam keadaan mode 'Insert Data' dan tabel terisi.")>
    Public Event UpdateKode As EventHandler(Of EventArgs)

    Private Sub OnUpdateKode(e As EventArgs)
        '-- Update hanya jika dalam mode insert
        If ApakahModeInsertData And IsTableFilled Then
            RaiseEvent UpdateKode(Me, e)
        End If
    End Sub

    ''' <summary>
    ''' Lakukan update variabel 'Kode'.
    ''' </summary>
    Protected Friend Sub DoUpdateKode()
        OnUpdateKode(New EventArgs())
    End Sub

    ''' <summary>
    ''' Dijalankan ketika komponen input akan di bersihkan. Pindah ke method 'TabelInputResetPost' jika ingin override.
    ''' </summary>
    Protected NotOverridable Overrides Sub TabelInputReset()
        DoUpdateKode()
        TabelInputResetPost()
    End Sub

    ''' <summary>
    ''' Dijalankan ketika komponen input akan di bersihkan.
    ''' </summary>
    Protected Overridable Sub TabelInputResetPost()
    End Sub

    ''' <summary>
    ''' Event handler untuk Reset Kode.
    ''' </summary>
    Protected Overridable Sub inputAnyResetKode_Click(sender As Object, e As EventArgs)
        Dim kontrol As Control = sender

        If kontrol IsNot Nothing Then
            kontrol.Enabled = False
            DoUpdateKode()
            kontrol.Enabled = True
        End If
    End Sub
End Class

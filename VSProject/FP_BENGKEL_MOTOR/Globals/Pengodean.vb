Namespace Pengodean
    Namespace Tabel
        Class Tulisan
            Public Const Barang As String = "BR"
            Public Const Jasa As String = "JS"
            Public Const Mekanik As String = "MK"
            Public Const Pelanggan As String = "PL"
            Public Const ItemBelanjaDiskon As String = "·DISCOUNT"
            Public Const ItemBelanjaReturn As String = "³RETURN"
        End Class

        Enum Berupa
            TidakTahu = 0
            Barang
            Jasa
            Mekanik
            Pelanggan
            ItemBelanjaDiskon
            ItemBelanjaReturn
        End Enum
    End Namespace

    Module Modul
        Public Function GetTipeTabel(kodeTabel As String) As Tabel.Berupa
            Select Case kodeTabel.Trim().ToUpper().Split("-").GetValue(0)
                Case Tabel.Tulisan.Barang
                    Return Tabel.Berupa.Barang

                Case Tabel.Tulisan.Jasa
                    Return Tabel.Berupa.Jasa

                Case Tabel.Tulisan.Mekanik
                    Return Tabel.Berupa.Mekanik

                Case Tabel.Tulisan.Pelanggan
                    Return Tabel.Berupa.Pelanggan

                Case Tabel.Tulisan.ItemBelanjaDiskon
                    Return Tabel.Berupa.ItemBelanjaDiskon

                Case Tabel.Tulisan.ItemBelanjaReturn
                    Return Tabel.Berupa.ItemBelanjaReturn

                Case Else
                    Return Tabel.Berupa.TidakTahu
            End Select
        End Function
    End Module
End Namespace
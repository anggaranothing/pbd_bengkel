'TODO Kalo mau buat form pake otentikasi dan otorisasi, buat nya pake "Inherited Form". Cara nya : Klik menu Project->Add New Item, pilih "Inherited Form", trus pilih "FormGenerik", trus tekan OK
'TODO Setiap buat form dipastikan untuk menyesuaikan tipe verifikasi peran si user melalui properti TipeVerifikasiIzin
'TODO Setiap buat form dipastikan untuk menyesuaikan daftar peran melalui properti DaftarIzin

Public Class FormGenerik
    <System.ComponentModel.Description("Tipe verifikasi peran si user terhadap daftar izin.")>
    Property TipeVerifikasiIzin As TipeVerifikasiPeranUser

    <System.ComponentModel.Description("Daftar peran yang akan di verifikasi untuk mengakses form ini.")>
    Property DaftarIzin As TipePeranUser()

    <System.ComponentModel.Description("Lakukan pemeriksaan peran si user. Jika tidak sesuai maka form auto close.")>
    Protected Friend Overridable Function DoCheckUserAuthorization() As Boolean
        Dim lenIjin As Integer = DaftarIzin.Length

        '-- Tidak perlu ijin? Good
        If lenIjin <= 0 Then
            Return True
        End If

        Dim jmlIzinTerpenuhi As UInteger
        For Each i As TipePeranUser In DaftarIzin
            If ApakahUserPunyaPeranIni(i) = True Then
                If TipeVerifikasiPeranUser.ROLE_VERIFY_AT_LEAST_ONE Then
                    '-- Ada yang cocok? Good
                    Return True
                End If

                '-- Ditaroh terakhiran biar gak buang2 CPU
                jmlIzinTerpenuhi += 1
            End If
        Next

        If TipeVerifikasiPeranUser.ROLE_VERIFY_ALL And jmlIzinTerpenuhi = lenIjin Then
            '-- Izin lengkap? Good
            Return True
        End If

        '-- Tidak ada yang cocok? Bad
        Me.Close()
        Me.Dispose()
        Return False
    End Function

    '-- Method resize untuk kurangi lag
    Private Sub form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        SuspendLayout()
    End Sub
    Private Sub form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        ResumeLayout()
    End Sub

    Private Sub timerCekPeranUser_Tick(sender As Object, e As EventArgs) Handles timerCekPeranUser.Tick
        '-- Auto close klo peran user tidak sesuai
        DoCheckUserAuthorization()
    End Sub
End Class
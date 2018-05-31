'TODO Jika mau menambahkan peran user baru, ubah variabel ini
<System.ComponentModel.Description("Daftar jenis peran user dalam bentuk Enumerasi.")>
Public Enum TipePeranUser As Integer
    USER_ROLE_DISABLED = 0
    USER_ROLE_ADMINISTRATOR
    USER_ROLE_MANAJER
    USER_ROLE_KASIR
End Enum

'TODO Jika mau menambahkan tipe verifikasi peran user, ubah variabel ini
<System.ComponentModel.Description("Daftar jenis verifikasi peran user dalam bentuk Enumerasi.")>
Public Enum TipeVerifikasiPeranUser
    <System.ComponentModel.Description("User harus memiliki SEMUA peran dalam daftar izin.")>
    ROLE_VERIFY_ALL = 0

    <System.ComponentModel.Description("User harus memiliki SALAH SATU peran dalam daftar izin.")>
    ROLE_VERIFY_AT_LEAST_ONE
End Enum

Partial Module AutentikasiDanOtorisasi
    <System.ComponentModel.Description("Nama user Super Administrator.")>
    Public Const USERNAME_SUPER_ADMIN As String = "superuser"

    'TODO Dan jangan lupa juga tambahkan nama peran user di sini! Diurutkan berdasarkan urutan TipePeranUser
    <System.ComponentModel.Description("Daftar jenis peran user dalam bentuk String.")>
    Public ReadOnly NamaPeranUser As String() =
    {
        "DISABLED",
        "Administrator",
        "Manajer",
        "Kasir"
    }

    'TODO Masukkan semua jenis peran user untuk user admin di sini
    Private ReadOnly PeranAdmin As TipePeranUser() =
    {
        TipePeranUser.USER_ROLE_ADMINISTRATOR,
        TipePeranUser.USER_ROLE_MANAJER,
        TipePeranUser.USER_ROLE_KASIR
    }
End Module

Imports System.Security.Principal

Module AutentikasiDanOtorisasi
    '-- Properti
    '-----------
    Private _PrincipalSekarang As IPrincipal = GetEmptyPrincipal()

    ''' <summary>
    ''' User yang sudah login saat ini.
    ''' </summary>
    ''' <returns>Current logged user as IPrincipal object.</returns>
    Public Property PrincipalSekarang As IPrincipal
        Get
            Return _PrincipalSekarang
        End Get
        Set
            _PrincipalSekarang = Value
            My.User.CurrentPrincipal = Value
        End Set
    End Property

    ''' <summary>
    ''' Apakah user ini berhasil login ?
    ''' </summary>
    ''' <returns>TRUE jika sudah ter-autentikasi.</returns>
    Public ReadOnly Property ApakahUserSudahAutentikasi As Boolean
        Get
            Return PrincipalSekarang.Identity.IsAuthenticated
        End Get
    End Property

    ''' <summary>
    ''' Nama user yang sudah login saat ini.
    ''' </summary>
    ''' <returns>Nama user sekarang.</returns>
    Public ReadOnly Property NamaUser As String
        Get
            Return PrincipalSekarang.Identity.Name
        End Get
    End Property

    '-- Metode
    '---------
    Private Function GetEmptyPrincipal() As IPrincipal
        Return New GenericPrincipal(New GenericIdentity(""), New String() {})
    End Function

    ''' <summary>
    ''' Determines whether the current principal belongs to the specified role.
    ''' </summary>
    ''' <param name="role">The role ID for which to check membership.</param>
    ''' <returns>true if the current principal is a member of the specified role; otherwise, false.</returns>
    Public Function ApakahUserPunyaPeranIni(role As TipePeranUser) As Boolean
        Return PrincipalSekarang.IsInRole(NamaPeranUser(role))
    End Function

    ''' <summary>
    ''' Cek user sekarang berupa Super Administrator.
    ''' </summary>
    ''' <returns>
    ''' TRUE jika user Super Admin. Selain itu, FALSE.
    ''' </returns>
    Public Function ApakahUserSekarangSuperAdmin() As Boolean
        Return NamaUser.ToLower().Trim() = USERNAME_SUPER_ADMIN
    End Function

    ''' <summary>
    ''' Enkrip password dengan menggunakan algoritma BCrypt dan nilai kekuatan nya di ambil dari opsi HashStrength
    ''' </summary>
    ''' <param name="value">String yang akan di enkrip.</param>
    ''' <returns>
    ''' Password yang sudah dalam bentuk BCrypt hash.
    ''' </returns>
    Public Function EnkripPassword(value As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(value, workFactor:=My.Settings.HashStrength)
    End Function

    ''' <summary>
    ''' Melakukan user login dengan peran tertentu.
    ''' </summary>
    ''' <param name="username">Nama user.</param>
    ''' <param name="roles">Satu atau lebih peran user.</param>
    ''' <returns>Identitas user.</returns>
    Public Function DoUserLogin(username As String, ParamArray roles As TipePeranUser()) As IIdentity
        Dim strs(NamaPeranUser.Length) As String
        For Each role As TipePeranUser In roles
            strs(role) = NamaPeranUser(role)
        Next

        Dim identitas As New GenericIdentity(username, "Autentikasi Kustom")
        PrincipalSekarang = New GenericPrincipal(identitas, strs)

        Return identitas
    End Function

    ''' <summary>
    ''' Melakukan logout user.
    ''' </summary>
    Public Sub DoUserLogout()
        PrincipalSekarang = GetEmptyPrincipal()
    End Sub

    Public Function LoginSebagaiAdmin(username As String) As IIdentity
        Return DoUserLogin(username, PeranAdmin)
    End Function

    Public Function LoginSebagaiKasir(username As String) As IIdentity
        Return DoUserLogin(username, TipePeranUser.USER_ROLE_KASIR)
    End Function
End Module

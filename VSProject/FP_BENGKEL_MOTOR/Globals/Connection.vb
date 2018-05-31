Imports System.Data.OleDb

Module Connection
    Private _connection As New OleDbConnection
    Private _connectionDictionary As New Dictionary(Of String, String)

    Public ReadOnly Property DBConnection As OleDbConnection
        Get
            Return _connection
        End Get
        'Set(value As OleDbConnection)
        '    _connection = value
        'End Set
    End Property

    Public ReadOnly Property ConnDictionary As Dictionary(Of String, String)
        Get
            Return _connectionDictionary
        End Get
        'Set(value As Dictionary(Of String, String))
        '    _connectionDictionary = value
        'End Set
    End Property

    Public Sub SafeDBConnectionStringSetup(connString As String)
        If DBConnection IsNot Nothing AndAlso DBConnection.State <> ConnectionState.Closed Then
            DBConnection.Close()
        End If

        DBConnection.ConnectionString = connString
    End Sub

    Public Sub ResetConnectionDictionary()
        _connectionDictionary.Clear()

        For Each setting As String In My.Settings.ConnectionString.Split(";")
            Dim raw As String() = setting.Split("=")
            Dim kunci As String = raw.GetValue(0)
            kunci.Trim()

            If kunci.Length > 0 Then
                Dim nilai As String = ""
                If raw.Length > 1 Then
                    nilai = raw.GetValue(1)
                End If

                _connectionDictionary.Add(kunci, nilai)
            End If
        Next
    End Sub

    Public Function GetConnectionDictionaryValue(key As String) As String
        Dim value As String = ""

        If _connectionDictionary.ContainsKey(key) Then
            value = _connectionDictionary.Item(key)
        End If

        Return value
    End Function

    Public Sub SetConnectionDictionaryValue(key As String, value As String)
        If _connectionDictionary.ContainsKey(key) Then
            _connectionDictionary.Item(key) = value
        Else
            _connectionDictionary.Add(key, value)
        End If
    End Sub

    Public Function BuildConnectionString(namaDB As String, namaServer As String, namaUser As String, passUser As String) As String
        SetConnectionDictionaryValue("Initial Catalog", namaDB)
        SetConnectionDictionaryValue("Data Source", namaServer)
        SetConnectionDictionaryValue("User ID", namaUser)
        SetConnectionDictionaryValue("Password", passUser)

        Return BuildConnectionString()
    End Function

    Public Function BuildConnectionString() As String
        Dim hasil As String = ""
        For Each pasangan As KeyValuePair(Of String, String) In _connectionDictionary
            hasil &= pasangan.Key & "=" & pasangan.Value & ";"
        Next

        Return hasil
    End Function

    Public Function TestConnection(Optional tampilMsg As Boolean = True) As Boolean
        Dim hasil As Boolean = False
        Try
            _connection.Open()

            If _connection.State = ConnectionState.Open Then
                hasil = True

                If tampilMsg = True Then
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    MsgBox("Koneksi BERHASIL.", MsgBoxStyle.Information, "Success")
                End If
            End If
        Catch ex As Exception
            If tampilMsg = True Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        Finally
            _connection.Close()
        End Try

        Return hasil
    End Function
End Module

Public NotInheritable Class FormTabelUser
    '-- Variabel
    Private currentUserName As String

    Protected Overrides Sub TabelInputReset()
        currentUserName = Nothing
        inputMTBNama.ResetText()
        inputMTBPassLama.ResetText()
        inputMTBPassBaru.ResetText()
        inputMTBPassBaruUlangi.ResetText()
        inputCBPeran.SelectedIndex = IIf(inputCBPeran.Items.Count <= 0, -1, 0)
    End Sub

    Protected Overrides Sub TabelInit()
        '-- Pasang sumber tabel ke dalam DataGridView
        viewTabelDb.DataSource = sourceTabel

        '-- Ganti judul kolom tabel
        GantiJudulKolom("username", "Nama User")
        GantiJudulKolom("role", "Peran User")
        GantiJudulKolom("date_creation", "Tanggal Pembuatan")
        GantiJudulKolom("date_modified", "Tanggal Perubahan")
        '-- Password tetaplah rahasia :v
    End Sub
    Protected Overrides Sub TabelFill()
        '-- Ambil semua data dari dataset
        _IsTableFilled = tableAdapter.Fill(DataSetBengkel.USER) >= 0
    End Sub
    Protected Overrides Sub TabelInitialized()
        RefillComboBoxPeranUser()

        '-- Jadikan kolom ini menjadi filler di tabel
        SetFillerColumn("username")
    End Sub

    Protected Overrides Sub TabelBarisTambah()
        If CekValiditasInputPeranUser() = False OrElse CekKecocokanPasswordBaru() = False Then
            Return
        End If

        Dim hashedPass As String = EnkripPassword(inputMTBPassBaru.Text)
        Dim hasil As Integer

        '-- Insert data baru
        Try
            hasil = tableAdapter.RowInsert(
                inputMTBNama.Text,
                hashedPass,
                inputCBPeran.SelectedIndex)
            TabelFill()
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        Finally
            TabelInputReset()
        End Try

        If hasil > 0 Then
            '-- Auto select baris terakhir
            SelectBarisTerakhir()

            ShowInformationMessageBox(Me, "Data BERHASIL di tambah")
        Else
            ShowErrorMessageBox(Me, "Data GAGAL di tambah")
        End If
    End Sub

    Protected Overrides Sub TabelBarisHapus(posisi As Integer)
        currentUserName = GetDataBaris(posisi, "username").Value

        If CekUserSedangDipakai(currentUserName) Then
            Return
        End If

        If ApakahSuperUser(currentUserName) Then
            ShowErrorMessageBox(Me, "User Super Administrator tidak di perbolehkan di hapus.")
            Return
        End If

        Dim peranInt As Integer = GetDataBaris(posisi, "role").Value
        Dim peranStr As String = peranInt
        If peranInt < NamaPeranUser.Length Then
            peranStr = NamaPeranUser(peranInt)
        End If

        Dim pesanDialog As String =
            "Anda yakin akan menghapus data sebagai berikut:" _
            & vbNewLine & vbNewLine _
            & "Nama User:" & vbTab & currentUserName & vbNewLine _
            & "Grup:     " & vbTab & vbTab & peranStr

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Hapus") = System.Windows.Forms.DialogResult.OK Then
            '-- Bukan admin?
            If ApakahUserPunyaPeranIni(TipePeranUser.USER_ROLE_ADMINISTRATOR) = False Then
                Using objDlg As New DialogAutentikasi()
                    objDlg.inputTBNama.ReadOnly = True
                    objDlg.inputTBNama.Text = currentUserName

                    If objDlg.ShowDialog(Me) <> DialogResult.OK Then
                        Return
                    End If

                    inputMTBPassLama.Text = objDlg.inputTBPassword.Text
                    Dim result As Boolean = CekKecocokanPasswordLama()
                    inputMTBPassLama.ResetText()

                    If result = False Then
                        Return
                    End If
                End Using
            End If

            Dim hasil As Integer
            Try
                '-- Jika ada data yg terhapus, maka method ini mengembalikan nilai integer positif
                hasil = tableAdapter.RowDelete(currentUserName)

                TabelFill()
            Catch ex As Exception
                ShowExceptionMessage(ex)
                ProsesException(ex)
            End Try

            If hasil > 0 Then
                ShowInformationMessageBox(Me, "Data BERHASIL di hapus")
            Else
                ShowErrorMessageBox(Me, "Data GAGAL di hapus")
            End If
        End If
    End Sub

    Protected Overrides Sub TabelBarisEdit(posisi As Integer)
        Dim peran As Integer = GetDataBaris(posisi, "role").Value
        currentUserName = GetDataBaris(posisi, "username").Value

        If inputCBPeran.Items.Count <= 0 Then
            peran = -1
        ElseIf peran >= NamaPeranUser.Length Then
            peran = 0
        End If

        inputMTBNama.Text = currentUserName
        inputCBPeran.SelectedIndex = peran
        inputMTBPassLama.ResetText()
        inputMTBPassBaru.ResetText()
        inputMTBPassBaruUlangi.ResetText()
    End Sub
    Protected Overrides Sub TabelBarisEditSubmit()
        If CekValiditasInputPeranUser() = False Then
            Return
        End If

        Dim isNewPass As Boolean = False
        If String.IsNullOrWhiteSpace(inputMTBPassBaru.Text) = False Then
            If ApakahUserPunyaPeranIni(TipePeranUser.USER_ROLE_ADMINISTRATOR) = False Then
                If CekKecocokanPasswordLama() = False Then
                    Return
                End If
            End If

            If CekKecocokanPasswordBaru() = False Then
                Return
            End If

            isNewPass = True
        End If

        Dim namaAsli As String = currentUserName,
            namaBaru As String = inputMTBNama.Text,
            peran As Integer = inputCBPeran.SelectedIndex,
            rawPwd As String = inputMTBPassBaru.Text,
            hasil As Integer

        Dim pesanDialog As String =
            "Anda yakin akan mengubah data menjadi sebagai berikut:" _
            & vbNewLine _
            & vbNewLine & "Nama User:" & vbTab & namaBaru _
            & vbNewLine & "Peran User:" & vbTab & NamaPeranUser(peran) _
            & vbNewLine & "Ganti Password?" & vbTab & IIf(isNewPass, "IYA", "TIDAK")

        If ShowConfirmMessageBox(Me, pesanDialog, "Konfirmasi Edit") = DialogResult.OK Then
            Try
                hasil = tableAdapter.RowEdit(namaAsli, namaBaru, peran)

                If hasil > 0 And isNewPass Then
                    hasil = tableAdapter.SetUserPass(namaBaru, EnkripPassword(rawPwd))
                End If

                TabelFill()
                viewTabelDb.ClearSelection()
                viewTabelDb.Rows.Item(IndeksEditBaris).Selected = True
                viewTabelDb.FirstDisplayedScrollingRowIndex = IndeksEditBaris
                TabelInputReset()
            Catch ex As Exception
                ShowExceptionMessage(ex)
                ProsesException(ex)
            End Try

            If hasil > 0 Then
                ApakahModeInsertData = True
                ShowInformationMessageBox(Me, "Data BERHASIL di ubah")
            Else
                ShowErrorMessageBox(Me, "Data GAGAL di ubah")
            End If
        End If
    End Sub

    '-- Method pribadi
    Private Sub RefillComboBoxPeranUser()
        inputCBPeran.Items.Clear()

        For Each namaPeran As String In NamaPeranUser
            inputCBPeran.Items.Add(namaPeran)
        Next
    End Sub

    Private Function CekValiditasInputPeranUser() As Boolean
        Dim nilaiIndeks As Integer = inputCBPeran.SelectedIndex

        If nilaiIndeks < 0 Or nilaiIndeks >= NamaPeranUser.Length Then
            ShowErrorMessageBox(Me, "Peran user yang di inputkan TIDAK BENAR !" & vbCrLf & vbCrLf & "Mohon cek input nya lagi.")
            Return False
        End If

        Return True
    End Function

    Private Function CekKecocokanPasswordLama() As Boolean
        Dim hashedPass As String
        Try
            hashedPass = tableAdapter.GetUserPassword(currentUserName)
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
            Return False
        End Try

        If BCrypt.Net.BCrypt.Verify(inputMTBPassLama.Text, hashedPass) = False Then
            ShowErrorMessageBox(Me, "Password lama TIDAK COCOK !" & vbCrLf & vbCrLf & "Mohon ketik ulang password nya." & vbCrLf & "Dan mohon pastikan pula kondisi CAPSLOCK dalam keadaan hidup atau tidak.")
            Return False
        End If

        Return True
    End Function

    Private Function CekKecocokanPasswordBaru() As Boolean
        If inputMTBPassBaruUlangi.Text <> inputMTBPassBaru.Text Then
            ShowErrorMessageBox(Me, "Password baru yang di ketik TIDAK COCOK !" & vbCrLf & vbCrLf & "Mohon ketik ulang password nya." & vbCrLf & "Dan mohon pastikan pula kondisi CAPSLOCK dalam keadaan hidup atau tidak.")
            Return False
        End If

        Return True
    End Function

    Private Function CekUserSedangDipakai(value As String) As Boolean
        If value.ToLower().Trim() = NamaUser.ToLower().Trim() Then
            ShowErrorMessageBox(Me, "User sedang dalam kondisi ter-login." & vbCrLf & vbCrLf & "Silahkan logout terdahulu dan memakai akun Administrator yang lain.")
            Return True
        End If

        Return False
    End Function

    Private Function ApakahSuperUser(value As String) As Boolean
        Return value.ToLower().Trim() = USERNAME_SUPER_ADMIN.ToLower().Trim()
    End Function

    '-- Method dari form
    Private Sub form_InputModeInsertChanged(sender As Object, e As EventArgs) Handles Me.ModeManipulasiDataChanged
        Dim Value = ApakahModeInsertData

        inputMTBPassLama.Enabled = Not Value
        inputMTBPassLama.TabStop = Not Value
        inputBtnCekReHash.Visible = Not Value
    End Sub

    Private Sub EventFormInputModeChanged_AutoFocus(sender As Object, e As EventArgs) Handles Me.ModeManipulasiDataChanged
        inputTLP.VerticalScroll.Value = 0
        inputTLP.HorizontalScroll.Value = 0
        inputTLP.Refresh()
    End Sub

    Private Sub EventControlClick_GainInputTLPFocus(sender As Object, e As EventArgs) Handles inputTLP.Click
        inputTLP.Select()
    End Sub

    Private Sub EventTextBoxTextChanged_WhiteSpacesToUnderScore(sender As Object, e As EventArgs) Handles inputMTBNama.TextChanged
        Dim tb As TextBoxBase = sender

        If tb IsNot Nothing Then
            If tb.Text.Contains(" ") Then
                tb.Text = tb.Text.Replace(" ", "_")
                tb.SelectionStart = tb.Text.Length
            End If
        End If
    End Sub

    Private Sub EventTextBoxTextChanged_NoWhiteSpaces(sender As Object, e As EventArgs) Handles inputMTBPassLama.TextChanged, inputMTBPassBaruUlangi.TextChanged, inputMTBPassBaru.TextChanged
        Dim tb As TextBoxBase = sender

        If tb IsNot Nothing Then
            If tb.Text.Contains(" ") Then
                If ShowConfirmMessageBox(Me, "Tidak boleh mengandung spasi." & vbNewLine & "Apakah ingin menghapus spasi secara otomatis?") <> DialogResult.OK Then
                    tb.ResetText()
                    Return
                End If

                tb.Text = tb.Text.Replace(" ", "")
                tb.SelectionStart = tb.Text.Length
            End If
        End If
    End Sub

    Private Sub EventButtonClick_ReCheckHashStrength(sender As Object, e As EventArgs) Handles inputBtnCekReHash.Click
        Dim hashedPass As String
        Try
            hashedPass = tableAdapter.GetUserPassword(currentUserName)

            Dim hashStrength = My.Settings.HashStrength
            If BCrypt.Net.BCrypt.PasswordNeedsRehash(hashedPass, hashStrength) Then
                ShowWarningMessageBox(Me, "Password user '" & currentUserName & "' perlu di lakukan proses hashing ulang." _
                                          & vbCrLf & vbCrLf _
                                          & "Work Factor" & vbCrLf _
                                          & "Current:" & vbTab & hashedPass.Substring(4, 2) & vbCrLf _
                                          & "Newest:" & vbTab & hashStrength)
            Else
                ShowInformationMessageBox(Me, "Password user '" & currentUserName & "' sudah memenuhi standar minimum 'Hash Strength' yang diterapkan.")
            End If
        Catch ex As Exception
            ShowExceptionMessage(ex)
            ProsesException(ex)
        End Try
    End Sub
End Class

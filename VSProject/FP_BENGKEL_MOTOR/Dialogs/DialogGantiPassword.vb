Public Class DialogGantiPassword
    Protected Friend Overrides Function DoAuth() As Boolean
        If CekKecocokanPasswordLama() = False OrElse CekKecocokanPasswordBaru() = False Then
            Return False
        End If

        Dim username As String = inputTBNama.Text,
            hasil As Integer

        Try
            hasil = USERTableAdapter.SetUserPass(username, EnkripPassword(inputTBPassBaru.Text))
        Catch ex As Exception
            ShowExceptionMessage(ex)
        End Try

        If hasil > 0 Then
            DoUserLogout()
            ShowInformationMessageBox(Nothing, "Password Baru telah di pasang!" & vbNewLine & "Silahkan untuk login kembali.")
            Return True
        End If

        Return False
    End Function

    Private Function CekKecocokanPasswordLama() As Boolean
        Dim hashedPass As String
        Try
            hashedPass = USERTableAdapter.GetUserPassword(inputTBNama.Text)
        Catch ex As Exception
            ShowExceptionMessage(ex)
            Return False
        End Try

        If BCrypt.Net.BCrypt.Verify(inputTBPassword.Text, hashedPass) = False Then
            ShowErrorMessageBox(Nothing, "Password lama TIDAK COCOK !" & vbCrLf & vbCrLf & "Mohon ketik ulang password nya." & vbCrLf & "Dan mohon pastikan pula kondisi CAPSLOCK dalam keadaan hidup atau tidak.")
            Return False
        End If

        Return True
    End Function

    Private Function CekKecocokanPasswordBaru() As Boolean
        If inputTBPassBaruUlangi.Text <> inputTBPassBaru.Text Then
            ShowErrorMessageBox(Nothing, "Password baru yang di ketik TIDAK COCOK !" & vbCrLf & vbCrLf & "Mohon ketik ulang password nya." & vbCrLf & "Dan mohon pastikan pula kondisi CAPSLOCK dalam keadaan hidup atau tidak.")
            Return False
        End If

        Return True
    End Function

    Private Sub EventTextBoxTextChanged_WhiteSpacesToUnderScore(sender As Object, e As EventArgs) Handles inputTBNama.TextChanged
        Dim tb As TextBoxBase = sender

        If tb IsNot Nothing Then
            If tb.Text.Contains(" ") Then
                tb.Text = tb.Text.Replace(" ", "_")
                tb.SelectionStart = tb.Text.Length
            End If
        End If
    End Sub

    Private Sub EventTextBoxTextChanged_NoWhiteSpaces(sender As Object, e As EventArgs) Handles inputTBPassword.TextChanged, inputTBPassBaruUlangi.TextChanged, inputTBPassBaru.TextChanged
        Dim tb As TextBoxBase = sender

        If tb IsNot Nothing Then
            If tb.Text.Contains(" ") Then
                If ShowConfirmMessageBox(Nothing, "Tidak boleh mengandung spasi." & vbNewLine & "Apakah ingin menghapus spasi secara otomatis?") <> DialogResult.OK Then
                    tb.ResetText()
                    Return
                End If

                tb.Text = tb.Text.Replace(" ", "")
                tb.SelectionStart = tb.Text.Length
            End If
        End If
    End Sub

    Private Sub DialogGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputTBNama.Text = NamaUser
    End Sub
End Class

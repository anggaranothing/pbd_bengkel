Public NotInheritable Class DialogLogin

    Private Enum LoginStatus
        STATUS_READY = 0
        STATUS_CONNECTING = 1
        STATUS_AUTHENTICATING = 2
        STATUS_AUTHENTICATED = 3

        '-- Error Code
        STATUS_DB_FAILED = -10
        STATUS_USER_NOTFOUND = -20
        STATUS_USER_DUPLICATES = -21
        STATUS_USER_DISABLED = -22
        STATUS_USER_PASSWRONG = -23
        STATUS_USER_ROLE_UNKNOWN = -24
    End Enum

    Private Sub SetInputAvailability(status As Boolean)
        Cancel.Enabled = status
        UsernameTextBox.ReadOnly = Not status
        PasswordTextBox.ReadOnly = Not status
        OK.Enabled = status
    End Sub

    Private Sub DialogLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        bgLoginThread.CancelAsync()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If bgLoginThread.IsBusy = False Then
            SetInputAvailability(False)
            UsernameTextBox.Text = UsernameTextBox.Text.Trim()
            PasswordTextBox.Text = PasswordTextBox.Text.Trim()
            bgLoginThread.RunWorkerAsync()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub bgLoginThread_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgLoginThread.DoWork
        bgLoginThread.ReportProgress(LoginStatus.STATUS_CONNECTING)

        '-- Reset ulang DB Connection
        ResetConnectionDictionary()
        SafeDBConnectionStringSetup(BuildConnectionString())

        If TestConnection(False) = False Then
            bgLoginThread.ReportProgress(LoginStatus.STATUS_DB_FAILED)
            Return
        End If

        bgLoginThread.ReportProgress(LoginStatus.STATUS_AUTHENTICATING)
        Using dataTable As DataSetBengkel.USERDataTable = USERTableAdapter.GetByName(UsernameTextBox.Text)
            If dataTable.Rows.Count <= 0 Then
                bgLoginThread.ReportProgress(LoginStatus.STATUS_USER_NOTFOUND)
                bgLoginThread.ReportProgress(LoginStatus.STATUS_READY)
                Return
            ElseIf dataTable.Rows.Count > 1 Then
                bgLoginThread.ReportProgress(LoginStatus.STATUS_USER_DUPLICATES)
                Return
            End If

            Dim hashedPass As String = USERTableAdapter.GetUserPassword(UsernameTextBox.Text)
            Dim hasil As Boolean = BCrypt.Net.BCrypt.Verify(NullToEmptyString(PasswordTextBox.Text), hashedPass)

            If hasil = False Then
                bgLoginThread.ReportProgress(LoginStatus.STATUS_USER_PASSWRONG)
                bgLoginThread.ReportProgress(LoginStatus.STATUS_READY)
                Return
            End If

            Dim baris As DataRow = dataTable.Rows(0)
            Dim namaUser As String = baris.Item("username"),
                peranUser As Integer = baris.Item("role")

            Select Case peranUser
                Case TipePeranUser.USER_ROLE_DISABLED
                    bgLoginThread.ReportProgress(LoginStatus.STATUS_USER_DISABLED)
                    bgLoginThread.ReportProgress(LoginStatus.STATUS_READY)
                    Return
                Case TipePeranUser.USER_ROLE_ADMINISTRATOR
                    LoginSebagaiAdmin(namaUser)
                Case Else
                    If peranUser < 0 Or peranUser >= NamaPeranUser.Length Then
                        bgLoginThread.ReportProgress(LoginStatus.STATUS_USER_ROLE_UNKNOWN)
                        Return
                    End If
                    DoUserLogin(namaUser, peranUser)
            End Select
        End Using

        '-- Jika diatas lancar semua, maka user sudah logged in
        bgLoginThread.ReportProgress(LoginStatus.STATUS_AUTHENTICATED)
    End Sub

    Private Sub bgLoginThread_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgLoginThread.ProgressChanged
        Select Case e.ProgressPercentage
            '-- Garis start
            Case LoginStatus.STATUS_READY
                StatusToolStripProgressBar.Visible = False
                StatusToolStripStatusLabel.Text = "Ready"

            '-- Mulai!
            Case LoginStatus.STATUS_CONNECTING
                StatusToolStripProgressBar.Visible = True
                StatusToolStripStatusLabel.Text = "Connecting"

            '-- Terpeleset injak kulit pisang
            Case LoginStatus.STATUS_DB_FAILED
                StatusToolStripProgressBar.Visible = False
                StatusToolStripStatusLabel.Text = "Error occured"
                ShowErrorMessageBox(Nothing, "Koneksi ke database GAGAL" & vbCrLf & vbCrLf & "Mohon periksa kembali setting database pada menu Tools -> Options")

            '-- Sedang memimpin!
            Case LoginStatus.STATUS_AUTHENTICATING
                StatusToolStripStatusLabel.Text = "Authenticating"

            '-- Nyasar coy!
            Case LoginStatus.STATUS_USER_NOTFOUND
                ShowErrorMessageBox(Nothing, "User TIDAK ADA" & vbCrLf & vbCrLf & "Mohon periksa kembali")

           '-- Kembar identik! diskualifikasi
            Case LoginStatus.STATUS_USER_DUPLICATES
                StatusToolStripProgressBar.Visible = False
                StatusToolStripStatusLabel.Text = "Error occured"
                ShowErrorMessageBox(Nothing, "Lebih dari satu user di temukan!" & vbCrLf & vbCrLf & "Mohon hubungi pihak administrator")

            '-- Jiah ketauan pake doping, auto diskualifikasi
            Case LoginStatus.STATUS_USER_PASSWRONG
                ShowErrorMessageBox(Nothing, "User dan/atau password salah!" & vbCrLf & vbCrLf & "Mohon periksa kembali")

            '-- Lu bukan pemain!
            Case LoginStatus.STATUS_USER_DISABLED
                ShowErrorMessageBox(Nothing, "Akun ini dalam kondisi non-aktif" & vbCrLf & vbCrLf & "Mohon hubungi pihak administrator")

            '-- Peran mu opo le!
            Case LoginStatus.STATUS_USER_ROLE_UNKNOWN
                StatusToolStripProgressBar.Visible = False
                StatusToolStripStatusLabel.Text = "Error occured"
                ShowErrorMessageBox(Nothing, "GAGAL mengidentifikasi peran si User!" & vbCrLf & vbCrLf & "Mohon hubungi pihak administrator")

            '-- Akhirnya!
            Case LoginStatus.STATUS_AUTHENTICATED
                ShowInformationMessageBox(Nothing, "Berhasil logging!")
                Me.Close()
        End Select
    End Sub

    Private Sub bgLoginThread_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgLoginThread.RunWorkerCompleted
        SetInputAvailability(True)
    End Sub
End Class

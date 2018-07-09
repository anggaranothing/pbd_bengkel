Public NotInheritable Class Main

    Private bukaKembaliTransaksiBaru As Boolean = False
    '-- Pake variabel biar ketika subform di close, langsung di dispose dengan benar
    Private objekDialogLogin As DialogLogin
    Private objekDialogOpsi As DialogOption
    Private objekDialogGantiPwd As DialogGantiPassword
    Private objekDialogTentang As DialogAbout
    Private objekFormUser As FormTabelUser
    Private objekFormMontir As FormTabelMontir
    Private objekFormJasa As FormTabelJasa
    Private objekFormBarang As FormTabelBarang
    Private objekFormTransaksi As FormTabelTransaksi
    Private objekFormTransaksiDetail As FormTransaksiDetail
    Private objekFormPelanggan As FormTabelPelanggan
    Private objekFormKendaraan As FormTabelKendaraan

    Private Sub UpdateUserLoginStatus()
        If ApakahUserSudahAutentikasi Then
            LoginToolStripMenuItem.Visible = False
            LogOutToolStripMenuItem.Visible = True
            GantiPasswordToolStripMenuItem.Visible = True
            UsernameToolStripTextBox.Text = String.Format("Selamat Datang, {0}", NamaUser)
        Else
            GantiPasswordToolStripMenuItem.Visible = False
            LoginToolStripMenuItem.Visible = True
            LogOutToolStripMenuItem.Visible = False
            UsernameToolStripTextBox.Text = "Belum Login"
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-- Ubah kultur regional aplikasi
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo(My.Settings.CultureInfoID, False)

        UpdateUserLoginStatus()

        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("{0} {1}", ApplicationTitle, My.Application.Info.Version.ToString)
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If ApakahUserSudahAutentikasi() = False Then
            LoginToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        objekDialogLogin = New DialogLogin()
        objekDialogLogin.ShowDialog(Me)

        UpdateUserLoginStatus()

        If ApakahUserSekarangSuperAdmin() = False And ApakahUserPunyaPeranIni(TipePeranUser.USER_ROLE_KASIR) Then
            TransaksiBaruToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If ShowConfirmMessageBox(Me, "Anda yakin ingin melakukan log out ?") = DialogResult.OK Then
            DoUserLogout()
        End If

        UpdateUserLoginStatus()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormUser(Me, objekFormUser)
    End Sub

    Private Sub MekanikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MekanikToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormMekanik(Me, objekFormMontir)
    End Sub

    Private Sub JasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JasaToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormJasa(Me, objekFormJasa)
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormBarang(Me, objekFormBarang)
    End Sub

    Private Sub RiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormTransaksi(Me, objekFormTransaksi)
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        PembuatForm.Transaksi.BuatFormInsert(Me, objekFormTransaksiDetail)
        If objekFormTransaksiDetail IsNot Nothing Then
            objekFormTransaksiDetail.WindowState = FormWindowState.Maximized

            If ApakahUserSekarangSuperAdmin() = False And ApakahUserPunyaPeranIni(TipePeranUser.USER_ROLE_KASIR) Then
                If transInsertReopen.IsBusy = False Then
                    transInsertReopen.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormPelanggan(Me, objekFormPelanggan)
    End Sub

    Private Sub KendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KendaraanToolStripMenuItem.Click
        PembuatForm.Tabel.BuatFormKendaraan(Me, objekFormKendaraan)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        objekDialogOpsi = New DialogOption()
        objekDialogOpsi.ShowDialog(Me)
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        objekDialogGantiPwd = New DialogGantiPassword()
        objekDialogGantiPwd.ShowDialog(Me)

        UpdateUserLoginStatus()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        objekDialogTentang = New DialogAbout()
        objekDialogTentang.ShowDialog(Me)
    End Sub

    Private Sub transInsertReopen_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles transInsertReopen.DoWork
        If objekFormTransaksiDetail IsNot Nothing Then
            While objekFormTransaksiDetail.Visible And objekFormTransaksiDetail.DialogResult <> DialogResult.OK
            End While

            If objekFormTransaksiDetail.DialogResult = DialogResult.OK Then
                bukaKembaliTransaksiBaru = True
            End If
        End If
    End Sub

    Private Sub transInsertReopen_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles transInsertReopen.RunWorkerCompleted
        If bukaKembaliTransaksiBaru Then
            objekFormTransaksiDetail.Dispose()
            TransaksiBaruToolStripMenuItem.PerformClick()
            bukaKembaliTransaksiBaru = False
        End If
    End Sub
End Class

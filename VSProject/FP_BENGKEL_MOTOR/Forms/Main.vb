Public NotInheritable Class Main

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

    Private Sub BuatFormGenerik(ByRef objekForm As FormGenerik, tipeForm As Type)
        If Me.Contains(objekForm) Then
            PindahKeDepan(objekForm)
            Return
        End If

        objekForm = Activator.CreateInstance(tipeForm)
        If objekForm.DoCheckUserAuthorization() = False Then
            ShowErrorMessageBox(Me, "Akses ditolak!")
            Return
        End If

        objekForm.timerCekPeranUser.Start()
        UbahMenjadiSubForm(objekForm)
    End Sub
    Private Sub UbahMenjadiSubForm(ByRef objekForm As System.Windows.Forms.Form)
        ' Make it a child of this MDI form before showing it.
        objekForm.MdiParent = Me
        PindahKeDepan(objekForm)
    End Sub
    Private Sub PindahKeDepan(ByRef objekForm As System.Windows.Forms.Form)
        objekForm.WindowState = FormWindowState.Normal

        '-- Kadangkala gagal/error pakai Show()
        Try
            objekForm.Show()
        Catch ex As Exception
            Try
                objekForm.Visible = True
            Catch ex2 As Exception
                ShowExceptionMessage(ex2)
                ProsesException(ex2)
            End Try
        End Try

        objekForm.BringToFront()
    End Sub

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
        BuatFormGenerik(objekFormUser, GetType(FormTabelUser))
    End Sub

    Private Sub MekanikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MekanikToolStripMenuItem.Click
        BuatFormGenerik(objekFormMontir, GetType(FormTabelMontir))
    End Sub

    Private Sub JasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JasaToolStripMenuItem.Click
        BuatFormGenerik(objekFormJasa, GetType(FormTabelJasa))
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        BuatFormGenerik(objekFormBarang, GetType(FormTabelBarang))
    End Sub

    Private Sub BuatFormTransaksiDetail(Optional noNota As String = Nothing, Optional mode As TransaksiDetailMode = TransaksiDetailMode.MODE_VIEW)
        If Me.Contains(objekFormTransaksiDetail) Then
            PindahKeDepan(objekFormTransaksiDetail)
            Return
        End If

        If noNota Is Nothing Then
            objekFormTransaksiDetail = New FormTransaksiDetail()
        Else
            objekFormTransaksiDetail = New FormTransaksiDetail(noNota, mode)
        End If

        If objekFormTransaksiDetail.DoCheckUserAuthorization() = False Then
            ShowErrorMessageBox(Me, "Akses ditolak!")
            Return
        End If

        objekFormTransaksiDetail.timerCekPeranUser.Start()
        UbahMenjadiSubForm(objekFormTransaksiDetail)
        objekFormTransaksiDetail.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click
        BuatFormGenerik(objekFormTransaksi, GetType(FormTabelTransaksi))
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        BuatFormTransaksiDetail()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        BuatFormGenerik(objekFormPelanggan, GetType(FormTabelPelanggan))
    End Sub

    Private Sub KendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KendaraanToolStripMenuItem.Click
        BuatFormGenerik(objekFormKendaraan, GetType(FormTabelKendaraan))
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
End Class

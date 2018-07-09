<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MekanikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsernameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.transInsertReopen = New System.ComponentModel.BackgroundWorker()
        ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator5
        '
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New System.Drawing.Size(109, 6)
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpToolStripMenuItem, Me.UsernameToolStripTextBox})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(634, 27)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogOutToolStripMenuItem, ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 23)
        Me.FileMenu.Text = "&File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_log_in
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_log_out
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogOutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem, Me.ManajerToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.KasirToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 23)
        Me.ViewMenu.Text = "&View"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_group
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UserToolStripMenuItem.Text = "Pengguna (&User)"
        '
        'ManajerToolStripMenuItem
        '
        Me.ManajerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MekanikToolStripMenuItem, Me.JasaToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.ManajerToolStripMenuItem.Name = "ManajerToolStripMenuItem"
        Me.ManajerToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ManajerToolStripMenuItem.Text = "Manajer"
        '
        'MekanikToolStripMenuItem
        '
        Me.MekanikToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_wrench
        Me.MekanikToolStripMenuItem.Name = "MekanikToolStripMenuItem"
        Me.MekanikToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MekanikToolStripMenuItem.Text = "&Mekanik"
        '
        'JasaToolStripMenuItem
        '
        Me.JasaToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_magicwand
        Me.JasaToolStripMenuItem.Name = "JasaToolStripMenuItem"
        Me.JasaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.JasaToolStripMenuItem.Text = "&Jasa"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_cargo
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.BarangToolStripMenuItem.Text = "&Barang"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PelangganToolStripMenuItem, Me.KendaraanToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_person
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem.Text = "&Pelanggan"
        '
        'KendaraanToolStripMenuItem
        '
        Me.KendaraanToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_motorcycle
        Me.KendaraanToolStripMenuItem.Name = "KendaraanToolStripMenuItem"
        Me.KendaraanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.KendaraanToolStripMenuItem.Text = "Kendaraan"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RiwayatTransaksiToolStripMenuItem, Me.TransaksiBaruToolStripMenuItem})
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'RiwayatTransaksiToolStripMenuItem
        '
        Me.RiwayatTransaksiToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_note
        Me.RiwayatTransaksiToolStripMenuItem.Name = "RiwayatTransaksiToolStripMenuItem"
        Me.RiwayatTransaksiToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RiwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi"
        '
        'TransaksiBaruToolStripMenuItem
        '
        Me.TransaksiBaruToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_calculator
        Me.TransaksiBaruToolStripMenuItem.Name = "TransaksiBaruToolStripMenuItem"
        Me.TransaksiBaruToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TransaksiBaruToolStripMenuItem.Text = "Transaksi &Baru"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.GantiPasswordToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(47, 23)
        Me.ToolsMenu.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_settings
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_keys
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "&Ganti Password"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 23)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_more_windows
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_option_vertical
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_option_horizontal
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_remove_circle
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_question
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'UsernameToolStripTextBox
        '
        Me.UsernameToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UsernameToolStripTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UsernameToolStripTextBox.Name = "UsernameToolStripTextBox"
        Me.UsernameToolStripTextBox.ReadOnly = True
        Me.UsernameToolStripTextBox.ShortcutsEnabled = False
        Me.UsernameToolStripTextBox.Size = New System.Drawing.Size(200, 23)
        Me.UsernameToolStripTextBox.Text = "BELUM LOGIN"
        '
        'transInsertReopen
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.main_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsernameToolStripTextBox As ToolStripTextBox
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MekanikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JasaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatTransaksiToolStripMenuItem As ToolStripMenuItem
    Private WithEvents transInsertReopen As System.ComponentModel.BackgroundWorker
End Class

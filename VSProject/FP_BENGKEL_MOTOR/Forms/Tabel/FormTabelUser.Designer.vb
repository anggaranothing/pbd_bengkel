<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelUser
    Inherits FP_BENGKEL_MOTOR.FormTabelGenerik

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputCBPeran = New System.Windows.Forms.ComboBox()
        Me.inputMTBPassLama = New System.Windows.Forms.MaskedTextBox()
        Me.inputMTBPassBaru = New System.Windows.Forms.MaskedTextBox()
        Me.inputMTBPassBaruUlangi = New System.Windows.Forms.MaskedTextBox()
        Me.inputMTBNama = New System.Windows.Forms.MaskedTextBox()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.USERTableAdapter()
        Me.inputBtnCekReHash = New System.Windows.Forms.ToolStripButton()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabletTabel.SuspendLayout()
        Me.tab1Search.SuspendLayout()
        Me.inputGB.SuspendLayout()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSearch.SuspendLayout()
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scManipulasi.Panel1.SuspendLayout()
        Me.scManipulasi.Panel2.SuspendLayout()
        Me.scManipulasi.SuspendLayout()
        Me.toolStripManipulasiData.SuspendLayout()
        Me.inputTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "USER"
        Me.sourceTabel.Position = -1
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.inputTLP)
        Me.inputGB.Size = New System.Drawing.Size(566, 187)
        Me.inputGB.Text = "Mode Tambah"
        Me.inputGB.Controls.SetChildIndex(Me.inputTLP, 0)
        '
        'scManipulasi
        '
        Me.scManipulasi.Panel1Collapsed = True
        '
        'toolStripManipulasiData
        '
        Me.toolStripManipulasiData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripSeparator1, Me.inputBtnCekReHash})
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(3, 73)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(82, 15)
        Label8.TabIndex = 26
        Label8.Text = "Pass. Lama"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(91, 73)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(11, 15)
        Label11.TabIndex = 34
        Label11.Text = ":"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(91, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(11, 15)
        Label12.TabIndex = 35
        Label12.Text = ":"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 99)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 15)
        Label1.TabIndex = 36
        Label1.Text = "Pass. Baru"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(91, 99)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(11, 15)
        Label2.TabIndex = 37
        Label2.Text = ":"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(3, 125)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(81, 15)
        Label3.TabIndex = 38
        Label3.Text = "Ketik Ulang"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(91, 125)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(11, 15)
        Label4.TabIndex = 39
        Label4.Text = ":"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(3, 26)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(45, 15)
        Label5.TabIndex = 42
        Label5.Text = "Peran"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(91, 26)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(11, 15)
        Label6.TabIndex = 43
        Label6.Text = ":"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(108, 73)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(160, 26)
        Label9.TabIndex = 45
        Label9.Text = "(Jika status anda berupa Admin, di kosongkan saja)"
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label2, 1, 4)
        Me.inputTLP.Controls.Add(Label1, 0, 4)
        Me.inputTLP.Controls.Add(Label7, 0, 0)
        Me.inputTLP.Controls.Add(Label8, 0, 3)
        Me.inputTLP.Controls.Add(Label11, 1, 3)
        Me.inputTLP.Controls.Add(Label12, 1, 0)
        Me.inputTLP.Controls.Add(Label3, 0, 5)
        Me.inputTLP.Controls.Add(Label4, 1, 5)
        Me.inputTLP.Controls.Add(Label5, 0, 1)
        Me.inputTLP.Controls.Add(Label6, 1, 1)
        Me.inputTLP.Controls.Add(Label9, 2, 3)
        Me.inputTLP.Controls.Add(Me.inputCBPeran, 3, 1)
        Me.inputTLP.Controls.Add(Me.inputMTBPassLama, 3, 3)
        Me.inputTLP.Controls.Add(Me.inputMTBPassBaru, 3, 4)
        Me.inputTLP.Controls.Add(Me.inputMTBPassBaruUlangi, 3, 5)
        Me.inputTLP.Controls.Add(Me.inputMTBNama, 3, 0)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 7
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 139)
        Me.inputTLP.TabIndex = 4
        '
        'inputCBPeran
        '
        Me.inputCBPeran.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputCBPeran.Location = New System.Drawing.Point(283, 29)
        Me.inputCBPeran.Name = "inputCBPeran"
        Me.inputCBPeran.Size = New System.Drawing.Size(257, 21)
        Me.inputCBPeran.TabIndex = 44
        Me.inputCBPeran.Text = "PERAN USER"
        '
        'inputMTBPassLama
        '
        Me.inputMTBPassLama.BeepOnError = True
        Me.inputMTBPassLama.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputMTBPassLama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputMTBPassLama.Location = New System.Drawing.Point(283, 76)
        Me.inputMTBPassLama.Name = "inputMTBPassLama"
        Me.inputMTBPassLama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputMTBPassLama.ResetOnPrompt = False
        Me.inputMTBPassLama.ResetOnSpace = False
        Me.inputMTBPassLama.Size = New System.Drawing.Size(257, 20)
        Me.inputMTBPassLama.SkipLiterals = False
        Me.inputMTBPassLama.TabIndex = 46
        Me.inputMTBPassLama.Text = "inputMTBPassLama"
        Me.inputMTBPassLama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inputMTBPassLama.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'inputMTBPassBaru
        '
        Me.inputMTBPassBaru.BeepOnError = True
        Me.inputMTBPassBaru.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputMTBPassBaru.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputMTBPassBaru.Location = New System.Drawing.Point(283, 102)
        Me.inputMTBPassBaru.Name = "inputMTBPassBaru"
        Me.inputMTBPassBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputMTBPassBaru.ResetOnPrompt = False
        Me.inputMTBPassBaru.ResetOnSpace = False
        Me.inputMTBPassBaru.Size = New System.Drawing.Size(257, 20)
        Me.inputMTBPassBaru.SkipLiterals = False
        Me.inputMTBPassBaru.TabIndex = 47
        Me.inputMTBPassBaru.Text = "inputMTBPassBaru"
        Me.inputMTBPassBaru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inputMTBPassBaru.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'inputMTBPassBaruUlangi
        '
        Me.inputMTBPassBaruUlangi.BeepOnError = True
        Me.inputMTBPassBaruUlangi.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputMTBPassBaruUlangi.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputMTBPassBaruUlangi.Location = New System.Drawing.Point(283, 128)
        Me.inputMTBPassBaruUlangi.Name = "inputMTBPassBaruUlangi"
        Me.inputMTBPassBaruUlangi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputMTBPassBaruUlangi.ResetOnPrompt = False
        Me.inputMTBPassBaruUlangi.ResetOnSpace = False
        Me.inputMTBPassBaruUlangi.Size = New System.Drawing.Size(257, 20)
        Me.inputMTBPassBaruUlangi.SkipLiterals = False
        Me.inputMTBPassBaruUlangi.TabIndex = 48
        Me.inputMTBPassBaruUlangi.Text = "inputMTBPassBaruUlangi"
        Me.inputMTBPassBaruUlangi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inputMTBPassBaruUlangi.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'inputMTBNama
        '
        Me.inputMTBNama.BeepOnError = True
        Me.inputMTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputMTBNama.Location = New System.Drawing.Point(283, 3)
        Me.inputMTBNama.Name = "inputMTBNama"
        Me.inputMTBNama.ResetOnPrompt = False
        Me.inputMTBNama.ResetOnSpace = False
        Me.inputMTBNama.Size = New System.Drawing.Size(257, 20)
        Me.inputMTBNama.SkipLiterals = False
        Me.inputMTBNama.TabIndex = 49
        Me.inputMTBNama.Text = "NAMA USER"
        Me.inputMTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'inputBtnCekReHash
        '
        Me.inputBtnCekReHash.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_construction_cone
        Me.inputBtnCekReHash.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.inputBtnCekReHash.Name = "inputBtnCekReHash"
        Me.inputBtnCekReHash.Size = New System.Drawing.Size(206, 22)
        Me.inputBtnCekReHash.Text = "Cek &Ketangguhan Password Lama"
        '
        'FormTabelUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_ADMINISTRATOR}
        Me.Name = "FormTabelUser"
        Me.Text = "Daftar Pengguna (User)"
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabletTabel.ResumeLayout(False)
        Me.tab1Search.ResumeLayout(False)
        Me.inputGB.ResumeLayout(False)
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSearch.ResumeLayout(False)
        Me.scManipulasi.Panel1.ResumeLayout(False)
        Me.scManipulasi.Panel1.PerformLayout()
        Me.scManipulasi.Panel2.ResumeLayout(False)
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scManipulasi.ResumeLayout(False)
        Me.toolStripManipulasiData.ResumeLayout(False)
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents inputTLP As TableLayoutPanel
    Friend WithEvents inputCBPeran As ComboBox
    Friend WithEvents inputMTBPassLama As MaskedTextBox
    Friend WithEvents inputMTBPassBaru As MaskedTextBox
    Friend WithEvents inputMTBPassBaruUlangi As MaskedTextBox
    Friend WithEvents inputMTBNama As MaskedTextBox
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.USERTableAdapter
    Friend WithEvents inputBtnCekReHash As ToolStripButton
End Class

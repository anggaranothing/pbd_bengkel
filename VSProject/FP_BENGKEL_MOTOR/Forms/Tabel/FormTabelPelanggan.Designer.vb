<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelPelanggan
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputTBKode = New System.Windows.Forms.TextBox()
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputTBAlamat = New System.Windows.Forms.TextBox()
        Me.inputTBNoTelpon = New System.Windows.Forms.TextBox()
        Me.inputTBNoId = New System.Windows.Forms.TextBox()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.PELANGGANTableAdapter()
        Me.inputBtnResetKode = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabletTabel.SuspendLayout()
        Me.tab1Search.SuspendLayout()
        Me.inputGB.SuspendLayout()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSearch.SuspendLayout()
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scManipulasi.Panel2.SuspendLayout()
        Me.scManipulasi.SuspendLayout()
        Me.inputTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "PELANGGAN"
        Me.sourceTabel.Position = -1
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.inputTLP)
        Me.inputGB.Size = New System.Drawing.Size(566, 177)
        Me.inputGB.Text = "Mode Tambah"
        Me.inputGB.Controls.SetChildIndex(Me.inputTLP, 0)
        '
        'scManipulasi
        '
        Me.scManipulasi.Panel1Collapsed = True
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(98, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(11, 15)
        Label5.TabIndex = 23
        Label5.Text = ":"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(98, 110)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(11, 15)
        Label6.TabIndex = 24
        Label6.Text = ":"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(3, 29)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(3, 83)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(65, 15)
        Label9.TabIndex = 27
        Label9.Text = "No. Telp."
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(3, 56)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(51, 15)
        Label8.TabIndex = 26
        Label8.Text = "Alamat"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(3, 110)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(89, 15)
        Label10.TabIndex = 28
        Label10.Text = "No. Identitas"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(98, 56)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(11, 15)
        Label11.TabIndex = 34
        Label11.Text = ":"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(98, 29)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(11, 15)
        Label12.TabIndex = 35
        Label12.Text = ":"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(3, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(40, 15)
        Label13.TabIndex = 36
        Label13.Text = "Kode"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(98, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(11, 15)
        Label14.TabIndex = 37
        Label14.Text = ":"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label5, 1, 3)
        Me.inputTLP.Controls.Add(Label6, 1, 4)
        Me.inputTLP.Controls.Add(Label7, 0, 1)
        Me.inputTLP.Controls.Add(Label9, 0, 3)
        Me.inputTLP.Controls.Add(Label8, 0, 2)
        Me.inputTLP.Controls.Add(Label10, 0, 4)
        Me.inputTLP.Controls.Add(Label11, 1, 2)
        Me.inputTLP.Controls.Add(Label12, 1, 1)
        Me.inputTLP.Controls.Add(Label13, 0, 0)
        Me.inputTLP.Controls.Add(Label14, 1, 0)
        Me.inputTLP.Controls.Add(Me.inputTBKode, 3, 0)
        Me.inputTLP.Controls.Add(Me.inputTBNama, 3, 1)
        Me.inputTLP.Controls.Add(Me.inputTBAlamat, 3, 2)
        Me.inputTLP.Controls.Add(Me.inputTBNoTelpon, 3, 3)
        Me.inputTLP.Controls.Add(Me.inputTBNoId, 3, 4)
        Me.inputTLP.Controls.Add(Me.inputBtnResetKode, 2, 0)
        Me.inputTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputTLP.Location = New System.Drawing.Point(3, 16)
        Me.inputTLP.Name = "inputTLP"
        Me.inputTLP.RowCount = 5
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputTLP.Size = New System.Drawing.Size(560, 129)
        Me.inputTLP.TabIndex = 4
        '
        'inputTBKode
        '
        Me.inputTBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.inputTBKode.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBKode.Location = New System.Drawing.Point(294, 3)
        Me.inputTBKode.Name = "inputTBKode"
        Me.inputTBKode.ReadOnly = True
        Me.inputTBKode.Size = New System.Drawing.Size(263, 21)
        Me.inputTBKode.TabIndex = 19
        Me.inputTBKode.Text = "XX-YYYYY"
        Me.inputTBKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNama
        '
        Me.inputTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNama.Location = New System.Drawing.Point(294, 32)
        Me.inputTBNama.MaxLength = 128
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(263, 21)
        Me.inputTBNama.TabIndex = 29
        Me.inputTBNama.Text = "NAMA PELANGGAN"
        Me.inputTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBAlamat
        '
        Me.inputTBAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBAlamat.Location = New System.Drawing.Point(294, 59)
        Me.inputTBAlamat.MaxLength = 128
        Me.inputTBAlamat.Name = "inputTBAlamat"
        Me.inputTBAlamat.Size = New System.Drawing.Size(263, 21)
        Me.inputTBAlamat.TabIndex = 30
        Me.inputTBAlamat.Text = "ALAMAT"
        Me.inputTBAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNoTelpon
        '
        Me.inputTBNoTelpon.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNoTelpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNoTelpon.Location = New System.Drawing.Point(294, 86)
        Me.inputTBNoTelpon.MaxLength = 16
        Me.inputTBNoTelpon.Name = "inputTBNoTelpon"
        Me.inputTBNoTelpon.Size = New System.Drawing.Size(263, 21)
        Me.inputTBNoTelpon.TabIndex = 31
        Me.inputTBNoTelpon.Text = "XX-XXXXXX"
        Me.inputTBNoTelpon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNoId
        '
        Me.inputTBNoId.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNoId.Location = New System.Drawing.Point(294, 113)
        Me.inputTBNoId.MaxLength = 32
        Me.inputTBNoId.Name = "inputTBNoId"
        Me.inputTBNoId.Size = New System.Drawing.Size(263, 21)
        Me.inputTBNoId.TabIndex = 38
        Me.inputTBNoId.Text = "KTP atau yg lain nya"
        Me.inputTBNoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'inputBtnResetKode
        '
        Me.inputBtnResetKode.AutoSize = True
        Me.inputBtnResetKode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inputBtnResetKode.Dock = System.Windows.Forms.DockStyle.Right
        Me.inputBtnResetKode.Location = New System.Drawing.Point(243, 3)
        Me.inputBtnResetKode.Name = "inputBtnResetKode"
        Me.inputBtnResetKode.Size = New System.Drawing.Size(45, 23)
        Me.inputBtnResetKode.TabIndex = 44
        Me.inputBtnResetKode.Text = "Reset"
        Me.inputBtnResetKode.UseVisualStyleBackColor = True
        '
        'FormTabelPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER, FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_KASIR}
        Me.Name = "FormTabelPelanggan"
        Me.Text = "Daftar Pelanggan"
        Me.TipeVerifikasiIzin = FP_BENGKEL_MOTOR.TipeVerifikasiPeranUser.ROLE_VERIFY_AT_LEAST_ONE
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabletTabel.ResumeLayout(False)
        Me.tab1Search.ResumeLayout(False)
        Me.inputGB.ResumeLayout(False)
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSearch.ResumeLayout(False)
        Me.scManipulasi.Panel2.ResumeLayout(False)
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scManipulasi.ResumeLayout(False)
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents inputTLP As TableLayoutPanel
    Friend WithEvents inputTBKode As TextBox
    Friend WithEvents inputTBNama As TextBox
    Friend WithEvents inputTBAlamat As TextBox
    Friend WithEvents inputTBNoTelpon As TextBox
    Friend WithEvents inputTBNoId As TextBox
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.PELANGGANTableAdapter
    Friend WithEvents inputBtnResetKode As Button
End Class

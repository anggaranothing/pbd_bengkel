<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelMontir
    Inherits FP_BENGKEL_MOTOR.FormTabelKodeDinamis

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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.inputRBAktif = New System.Windows.Forms.RadioButton()
        Me.inputRBTidakAktif = New System.Windows.Forms.RadioButton()
        Me.inputTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.inputTBKode = New System.Windows.Forms.TextBox()
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputTBAlamat = New System.Windows.Forms.TextBox()
        Me.inputTBNoTelpon = New System.Windows.Forms.TextBox()
        Me.inputBtnResetKode = New System.Windows.Forms.Button()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.MONTIRTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
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
        TableLayoutPanel2.SuspendLayout()
        Me.inputTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'sourceTabel
        '
        Me.sourceTabel.DataMember = "MONTIR"
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
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(74, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(11, 15)
        Label5.TabIndex = 23
        Label5.Text = ":"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(74, 110)
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
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(3, 110)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(47, 15)
        Label10.TabIndex = 28
        Label10.Text = "Status"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(74, 56)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(11, 15)
        Label11.TabIndex = 34
        Label11.Text = ":"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(74, 29)
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
        Label14.Location = New System.Drawing.Point(74, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(11, 15)
        Label14.TabIndex = 37
        Label14.Text = ":"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanel2.Controls.Add(Me.inputRBAktif, 0, 0)
        TableLayoutPanel2.Controls.Add(Me.inputRBTidakAktif, 1, 0)
        TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        TableLayoutPanel2.Location = New System.Drawing.Point(279, 113)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        TableLayoutPanel2.Size = New System.Drawing.Size(278, 23)
        TableLayoutPanel2.TabIndex = 5
        '
        'inputRBAktif
        '
        Me.inputRBAktif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inputRBAktif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputRBAktif.Location = New System.Drawing.Point(3, 3)
        Me.inputRBAktif.Name = "inputRBAktif"
        Me.inputRBAktif.Size = New System.Drawing.Size(133, 17)
        Me.inputRBAktif.TabIndex = 0
        Me.inputRBAktif.TabStop = True
        Me.inputRBAktif.Text = "Aktif"
        Me.inputRBAktif.UseVisualStyleBackColor = True
        '
        'inputRBTidakAktif
        '
        Me.inputRBTidakAktif.Checked = True
        Me.inputRBTidakAktif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inputRBTidakAktif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputRBTidakAktif.Location = New System.Drawing.Point(142, 3)
        Me.inputRBTidakAktif.Name = "inputRBTidakAktif"
        Me.inputRBTidakAktif.Size = New System.Drawing.Size(133, 17)
        Me.inputRBTidakAktif.TabIndex = 1
        Me.inputRBTidakAktif.TabStop = True
        Me.inputRBTidakAktif.Text = "Tidak Aktif"
        Me.inputRBTidakAktif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(91, 56)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(114, 13)
        Label1.TabIndex = 44
        Label1.Text = "(Boleh di kosongkan)"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(91, 83)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(114, 13)
        Label2.TabIndex = 45
        Label2.Text = "(Boleh di kosongkan)"
        '
        'inputTLP
        '
        Me.inputTLP.AutoScroll = True
        Me.inputTLP.ColumnCount = 4
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.inputTLP.Controls.Add(Label1, 2, 2)
        Me.inputTLP.Controls.Add(Label2, 2, 3)
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
        Me.inputTLP.Controls.Add(Me.inputBtnResetKode, 2, 0)
        Me.inputTLP.Controls.Add(Me.inputTBKode, 3, 0)
        Me.inputTLP.Controls.Add(Me.inputTBNama, 3, 1)
        Me.inputTLP.Controls.Add(Me.inputTBAlamat, 3, 2)
        Me.inputTLP.Controls.Add(Me.inputTBNoTelpon, 3, 3)
        Me.inputTLP.Controls.Add(TableLayoutPanel2, 3, 4)
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
        Me.inputTLP.Size = New System.Drawing.Size(560, 139)
        Me.inputTLP.TabIndex = 3
        '
        'inputTBKode
        '
        Me.inputTBKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.inputTBKode.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBKode.Location = New System.Drawing.Point(279, 3)
        Me.inputTBKode.Name = "inputTBKode"
        Me.inputTBKode.ReadOnly = True
        Me.inputTBKode.Size = New System.Drawing.Size(278, 21)
        Me.inputTBKode.TabIndex = 1
        Me.inputTBKode.TabStop = False
        Me.inputTBKode.Text = "XX-YYYYY"
        Me.inputTBKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNama
        '
        Me.inputTBNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNama.Location = New System.Drawing.Point(279, 32)
        Me.inputTBNama.MaxLength = 128
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(278, 21)
        Me.inputTBNama.TabIndex = 2
        Me.inputTBNama.Text = "NAMA MEKANIK"
        Me.inputTBNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBAlamat
        '
        Me.inputTBAlamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBAlamat.Location = New System.Drawing.Point(279, 59)
        Me.inputTBAlamat.MaxLength = 128
        Me.inputTBAlamat.Name = "inputTBAlamat"
        Me.inputTBAlamat.Size = New System.Drawing.Size(278, 21)
        Me.inputTBAlamat.TabIndex = 3
        Me.inputTBAlamat.Text = "ALAMAT"
        Me.inputTBAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputTBNoTelpon
        '
        Me.inputTBNoTelpon.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputTBNoTelpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTBNoTelpon.Location = New System.Drawing.Point(279, 86)
        Me.inputTBNoTelpon.MaxLength = 16
        Me.inputTBNoTelpon.Name = "inputTBNoTelpon"
        Me.inputTBNoTelpon.Size = New System.Drawing.Size(278, 21)
        Me.inputTBNoTelpon.TabIndex = 4
        Me.inputTBNoTelpon.Text = "XX-XXXXXX"
        Me.inputTBNoTelpon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inputBtnResetKode
        '
        Me.inputBtnResetKode.AutoSize = True
        Me.inputBtnResetKode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inputBtnResetKode.Dock = System.Windows.Forms.DockStyle.Right
        Me.inputBtnResetKode.Location = New System.Drawing.Point(228, 3)
        Me.inputBtnResetKode.Name = "inputBtnResetKode"
        Me.inputBtnResetKode.Size = New System.Drawing.Size(45, 23)
        Me.inputBtnResetKode.TabIndex = 0
        Me.inputBtnResetKode.Text = "Reset"
        Me.inputBtnResetKode.UseVisualStyleBackColor = True
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'FormTabelMontir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.DaftarIzin = New FP_BENGKEL_MOTOR.TipePeranUser() {FP_BENGKEL_MOTOR.TipePeranUser.USER_ROLE_MANAJER}
        Me.Name = "FormTabelMontir"
        Me.Text = "Daftar Mekanik"
        Me.TipeVerifikasiIzin = FP_BENGKEL_MOTOR.TipeVerifikasiPeranUser.ROLE_VERIFY_AT_LEAST_ONE
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
        TableLayoutPanel2.ResumeLayout(False)
        Me.inputTLP.ResumeLayout(False)
        Me.inputTLP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private WithEvents inputTLP As System.Windows.Forms.TableLayoutPanel
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.MONTIRTableAdapter
    Friend WithEvents inputTBNama As TextBox
    Friend WithEvents inputTBAlamat As TextBox
    Friend WithEvents inputTBKode As TextBox
    Friend WithEvents inputTBNoTelpon As TextBox
    Friend WithEvents inputRBAktif As RadioButton
    Friend WithEvents inputRBTidakAktif As RadioButton
    Friend WithEvents inputBtnResetKode As Button
End Class

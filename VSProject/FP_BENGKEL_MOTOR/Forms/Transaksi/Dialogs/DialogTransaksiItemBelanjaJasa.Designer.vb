<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTransaksiItemBelanjaJasa
    Inherits FP_BENGKEL_MOTOR.DialogTransaksiItemBelanja

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.JASATableAdapter()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.gbTglJasa = New System.Windows.Forms.GroupBox()
        Me.lblLamaPengerjaan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpTglMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.panelTotalBayar.SuspendLayout()
        Me.panelHarga.SuspendLayout()
        Me.panelCari.SuspendLayout()
        Me.gbTglJasa.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.gbTglJasa)
        Me.gbItem.Controls.Add(Me.lblWaktu)
        Me.gbItem.Location = New System.Drawing.Point(12, 204)
        Me.gbItem.Size = New System.Drawing.Size(540, 213)
        Me.gbItem.Controls.SetChildIndex(Me.panelTotalBayar, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelHarga, 0)
        Me.gbItem.Controls.SetChildIndex(Me.tbTerpilih, 0)
        Me.gbItem.Controls.SetChildIndex(Me.lblWaktu, 0)
        Me.gbItem.Controls.SetChildIndex(Me.gbTglJasa, 0)
        '
        'panelTabel
        '
        Me.panelTabel.Size = New System.Drawing.Size(540, 104)
        '
        'panelTotalBayar
        '
        Me.panelTotalBayar.Location = New System.Drawing.Point(6, 185)
        '
        'tbTerpilih
        '
        Me.tbTerpilih.Text = "(TIDAK ADA)"
        Me.panelCari.Controls.SetChildIndex(Me.cmbKolom, 0)
        Me.panelCari.Controls.SetChildIndex(Me.tbKunci, 0)
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWaktu.Location = New System.Drawing.Point(78, 62)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(101, 20)
        Me.lblWaktu.TabIndex = 0
        Me.lblWaktu.Text = "per X Menit"
        '
        'gbTglJasa
        '
        Me.gbTglJasa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTglJasa.Controls.Add(Me.lblLamaPengerjaan)
        Me.gbTglJasa.Controls.Add(Me.Label2)
        Me.gbTglJasa.Controls.Add(Me.dtpTglAkhir)
        Me.gbTglJasa.Controls.Add(Me.dtpTglMulai)
        Me.gbTglJasa.Controls.Add(Me.Label1)
        Me.gbTglJasa.Location = New System.Drawing.Point(6, 85)
        Me.gbTglJasa.Name = "gbTglJasa"
        Me.gbTglJasa.Size = New System.Drawing.Size(528, 94)
        Me.gbTglJasa.TabIndex = 0
        Me.gbTglJasa.TabStop = False
        Me.gbTglJasa.Text = "Waktu Pelaksanaan Jasa"
        '
        'lblLamaPengerjaan
        '
        Me.lblLamaPengerjaan.AutoSize = True
        Me.lblLamaPengerjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLamaPengerjaan.Location = New System.Drawing.Point(72, 68)
        Me.lblLamaPengerjaan.Name = "lblLamaPengerjaan"
        Me.lblLamaPengerjaan.Size = New System.Drawing.Size(70, 20)
        Me.lblLamaPengerjaan.TabIndex = 3
        Me.lblLamaPengerjaan.Text = "X Menit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Selesai :"
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTglAkhir.Checked = False
        Me.dtpTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglAkhir.Location = New System.Drawing.Point(76, 45)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(446, 20)
        Me.dtpTglAkhir.TabIndex = 2
        '
        'dtpTglMulai
        '
        Me.dtpTglMulai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTglMulai.Checked = False
        Me.dtpTglMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglMulai.Location = New System.Drawing.Point(76, 19)
        Me.dtpTglMulai.Name = "dtpTglMulai"
        Me.dtpTglMulai.Size = New System.Drawing.Size(446, 20)
        Me.dtpTglMulai.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mulai :"
        '
        'DialogTransaksiItemBelanjaJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.MinimumSize = New System.Drawing.Size(580, 500)
        Me.Name = "DialogTransaksiItemBelanjaJasa"
        Me.Text = "Item Jasa"
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.panelTotalBayar.ResumeLayout(False)
        Me.panelTotalBayar.PerformLayout()
        Me.panelHarga.ResumeLayout(False)
        Me.panelHarga.PerformLayout()
        Me.panelCari.ResumeLayout(False)
        Me.panelCari.PerformLayout()
        Me.gbTglJasa.ResumeLayout(False)
        Me.gbTglJasa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.JASATableAdapter
    Private WithEvents lblWaktu As Label
    Private WithEvents gbTglJasa As GroupBox
    Private WithEvents Label2 As Label
    Private WithEvents dtpTglAkhir As DateTimePicker
    Private WithEvents dtpTglMulai As DateTimePicker
    Private WithEvents Label1 As Label
    Private WithEvents lblLamaPengerjaan As Label
End Class

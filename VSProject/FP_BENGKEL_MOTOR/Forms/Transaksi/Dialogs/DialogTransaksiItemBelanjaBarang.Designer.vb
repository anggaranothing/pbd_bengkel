<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTransaksiItemBelanjaBarang
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Me.btnKet = New System.Windows.Forms.Button()
        Me.numKuantitas = New System.Windows.Forms.NumericUpDown()
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.BARANGTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(Me.numKuantitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(FlowLayoutPanel1)
        Me.gbItem.Controls.Add(Me.numKuantitas)
        Me.gbItem.Controls.Add(Label2)
        Me.gbItem.Controls.Add(Label1)
        Me.gbItem.Controls.SetChildIndex(Label1, 0)
        Me.gbItem.Controls.SetChildIndex(Label2, 0)
        Me.gbItem.Controls.SetChildIndex(Me.numKuantitas, 0)
        Me.gbItem.Controls.SetChildIndex(Me.tbTerpilih, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelTotalBayar, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelHarga, 0)
        Me.gbItem.Controls.SetChildIndex(FlowLayoutPanel1, 0)
        '
        'panelHarga
        '
        Me.panelHarga.Location = New System.Drawing.Point(6, 45)
        '
        'tbTerpilih
        '
        Me.tbTerpilih.Text = "(TIDAK ADA)"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 84)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 13)
        Label1.TabIndex = 14
        Label1.Text = "Kuantitas :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(199, 79)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(42, 20)
        Label2.TabIndex = 15
        Label2.Text = "pcs."
        '
        'FlowLayoutPanel1
        '
        FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FlowLayoutPanel1.Controls.Add(Me.btnKet)
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New System.Drawing.Point(247, 45)
        FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(120, 70)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(287, 70)
        FlowLayoutPanel1.TabIndex = 0
        FlowLayoutPanel1.WrapContents = False
        '
        'btnKet
        '
        Me.btnKet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKet.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_note
        Me.btnKet.Location = New System.Drawing.Point(169, 3)
        Me.btnKet.Name = "btnKet"
        Me.btnKet.Size = New System.Drawing.Size(115, 60)
        Me.btnKet.TabIndex = 17
        Me.btnKet.Text = "Lihat Keterangan Produk"
        Me.btnKet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKet.UseVisualStyleBackColor = True
        '
        'numKuantitas
        '
        Me.numKuantitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numKuantitas.Location = New System.Drawing.Point(82, 77)
        Me.numKuantitas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numKuantitas.Name = "numKuantitas"
        Me.numKuantitas.Size = New System.Drawing.Size(111, 26)
        Me.numKuantitas.TabIndex = 16
        Me.numKuantitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numKuantitas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'DialogTransaksiItemBelanjaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.MinimumSize = New System.Drawing.Size(580, 500)
        Me.Name = "DialogTransaksiItemBelanjaBarang"
        Me.Text = "Item Barang"
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.numKuantitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents numKuantitas As NumericUpDown
    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.BARANGTableAdapter
    Private WithEvents btnKet As Button
End Class

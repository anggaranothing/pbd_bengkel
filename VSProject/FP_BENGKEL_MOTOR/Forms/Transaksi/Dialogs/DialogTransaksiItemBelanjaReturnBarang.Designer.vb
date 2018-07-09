<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogTransaksiItemBelanjaReturnBarang
    Inherits FP_BENGKEL_MOTOR.DialogTransaksiItemBelanja

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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.numKuantitas = New System.Windows.Forms.NumericUpDown()
        Me.dataSetBelanja = New FP_BENGKEL_MOTOR.DataSetBelanja()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.panelTotalBayar.SuspendLayout()
        Me.panelHarga.SuspendLayout()
        Me.panelCari.SuspendLayout()
        CType(Me.numKuantitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSetBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bindingSource
        '
        Me.bindingSource.DataSource = Me.dataSetBelanja
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.numKuantitas)
        Me.gbItem.Controls.Add(Label2)
        Me.gbItem.Controls.Add(Label1)
        Me.gbItem.Controls.SetChildIndex(Label1, 0)
        Me.gbItem.Controls.SetChildIndex(Label2, 0)
        Me.gbItem.Controls.SetChildIndex(Me.numKuantitas, 0)
        Me.gbItem.Controls.SetChildIndex(Me.tbTerpilih, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelTotalBayar, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelHarga, 0)
        '
        'panelHarga
        '
        Me.panelHarga.Location = New System.Drawing.Point(6, 45)
        '
        'tbTerpilih
        '
        Me.tbTerpilih.Text = "(TIDAK ADA)"
        Me.panelCari.Controls.SetChildIndex(Me.cmbKolom, 0)
        Me.panelCari.Controls.SetChildIndex(Me.tbKunci, 0)
        '
        'lblTotalDescriptor
        '
        Me.lblTotalDescriptor.Size = New System.Drawing.Size(37, 13)
        Me.lblTotalDescriptor.Text = "Total :"
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
        'dataSetBelanja
        '
        Me.dataSetBelanja.DataSetName = "DataSetBelanja"
        Me.dataSetBelanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DialogTransaksiItemBelanjaReturnBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.MinimumSize = New System.Drawing.Size(580, 500)
        Me.Name = "DialogTransaksiItemBelanjaReturnBarang"
        Me.Text = "Item Return Barang"
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
        CType(Me.numKuantitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSetBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents numKuantitas As NumericUpDown
    Private WithEvents dataSetBelanja As DataSetBelanja
End Class

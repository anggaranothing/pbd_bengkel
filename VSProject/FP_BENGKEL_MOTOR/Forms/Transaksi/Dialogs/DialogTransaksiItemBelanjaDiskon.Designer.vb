<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTransaksiItemBelanjaDiskon
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
        Me.dataSetBelanja = New FP_BENGKEL_MOTOR.DataSetBelanja()
        Me.gbDiskon = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numDiscTotal = New System.Windows.Forms.NumericUpDown()
        Me.numDiscPercentage = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.panelTotalBayar.SuspendLayout()
        Me.panelHarga.SuspendLayout()
        Me.panelCari.SuspendLayout()
        CType(Me.dataSetBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDiskon.SuspendLayout()
        CType(Me.numDiscTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDiscPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bindingSource
        '
        Me.bindingSource.DataSource = Me.dataSetBelanja
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.gbDiskon)
        Me.gbItem.Location = New System.Drawing.Point(12, 247)
        Me.gbItem.Size = New System.Drawing.Size(540, 170)
        Me.gbItem.Controls.SetChildIndex(Me.gbDiskon, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelTotalBayar, 0)
        Me.gbItem.Controls.SetChildIndex(Me.panelHarga, 0)
        Me.gbItem.Controls.SetChildIndex(Me.tbTerpilih, 0)
        '
        'panelTabel
        '
        Me.panelTabel.Size = New System.Drawing.Size(540, 147)
        '
        'panelTotalBayar
        '
        Me.panelTotalBayar.Location = New System.Drawing.Point(6, 144)
        '
        'tbTerpilih
        '
        Me.tbTerpilih.Text = "(TIDAK ADA)"
        Me.panelCari.Controls.SetChildIndex(Me.cmbKolom, 0)
        Me.panelCari.Controls.SetChildIndex(Me.tbKunci, 0)
        '
        'lblHargaDescriptor
        '
        Me.lblHargaDescriptor.Size = New System.Drawing.Size(37, 13)
        Me.lblHargaDescriptor.Text = "Total :"
        '
        'lblTotalDescriptor
        '
        Me.lblTotalDescriptor.Size = New System.Drawing.Size(56, 13)
        Me.lblTotalDescriptor.Text = "Sub Total:"
        '
        'dataSetBelanja
        '
        Me.dataSetBelanja.DataSetName = "DataSetBelanja"
        Me.dataSetBelanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbDiskon
        '
        Me.gbDiskon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDiskon.Controls.Add(Me.Label2)
        Me.gbDiskon.Controls.Add(Me.numDiscTotal)
        Me.gbDiskon.Controls.Add(Me.numDiscPercentage)
        Me.gbDiskon.Controls.Add(Me.Label1)
        Me.gbDiskon.Location = New System.Drawing.Point(6, 65)
        Me.gbDiskon.Name = "gbDiskon"
        Me.gbDiskon.Size = New System.Drawing.Size(528, 73)
        Me.gbDiskon.TabIndex = 0
        Me.gbDiskon.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Persentase:"
        '
        'numDiscTotal
        '
        Me.numDiscTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numDiscTotal.Enabled = False
        Me.numDiscTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numDiscTotal.Location = New System.Drawing.Point(76, 8)
        Me.numDiscTotal.Maximum = New Decimal(New Integer() {-1, 2147483647, 0, 262144})
        Me.numDiscTotal.Name = "numDiscTotal"
        Me.numDiscTotal.Size = New System.Drawing.Size(446, 26)
        Me.numDiscTotal.TabIndex = 0
        Me.numDiscTotal.ThousandsSeparator = True
        '
        'numDiscPercentage
        '
        Me.numDiscPercentage.DecimalPlaces = 2
        Me.numDiscPercentage.Location = New System.Drawing.Point(76, 47)
        Me.numDiscPercentage.Name = "numDiscPercentage"
        Me.numDiscPercentage.Size = New System.Drawing.Size(60, 20)
        Me.numDiscPercentage.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diskon:"
        '
        'DialogTransaksiItemBelanjaDiskon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.MinimumSize = New System.Drawing.Size(580, 500)
        Me.Name = "DialogTransaksiItemBelanjaDiskon"
        Me.Text = "Item Diskon"
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
        CType(Me.dataSetBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDiskon.ResumeLayout(False)
        Me.gbDiskon.PerformLayout()
        CType(Me.numDiscTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDiscPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dataSetBelanja As DataSetBelanja
    Private WithEvents gbDiskon As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents numDiscTotal As NumericUpDown
    Friend WithEvents numDiscPercentage As NumericUpDown
End Class

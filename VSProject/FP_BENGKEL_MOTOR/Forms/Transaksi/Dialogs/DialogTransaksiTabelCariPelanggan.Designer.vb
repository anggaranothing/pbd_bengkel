<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogTransaksiTabelCariPelanggan
    Inherits FP_BENGKEL_MOTOR.DialogTransaksiTabelCari

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
        Me.tableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.PELANGGANTableAdapter()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableAdapter
        '
        Me.tableAdapter.ClearBeforeFill = True
        '
        'DialogTransaksiTabelCariPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.MinimumSize = New System.Drawing.Size(580, 500)
        Me.Name = "DialogTransaksiTabelCariPelanggan"
        Me.Text = "Cari Pelanggan..."
        Me.Controls.SetChildIndex(Me.btnReset, 0)
        Me.Controls.SetChildIndex(Me.panelTabel, 0)
        Me.Controls.SetChildIndex(Me.tbKunci, 0)
        Me.Controls.SetChildIndex(Me.cmbKolom, 0)
        Me.Controls.SetChildIndex(Me.gbSelected, 0)
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tableAdapter As DataSetBengkelTableAdapters.PELANGGANTableAdapter
End Class

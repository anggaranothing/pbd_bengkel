<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogTransaksiItemBelanja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.lblHargaDescriptor = New System.Windows.Forms.Label()
        Me.lblTotalDescriptor = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cmbKolom = New System.Windows.Forms.ComboBox()
        Me.cmbKondisi = New System.Windows.Forms.ComboBox()
        Me.tbKunci = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvTabel = New System.Windows.Forms.DataGridView()
        Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataSet = New FP_BENGKEL_MOTOR.DataSetBengkel()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.tbTerpilih = New System.Windows.Forms.TextBox()
        Me.panelHarga = New System.Windows.Forms.Panel()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.panelTotalBayar = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.panelTabel = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.panelCari = New System.Windows.Forms.Panel()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.panelHarga.SuspendLayout()
        Me.panelTotalBayar.SuspendLayout()
        Me.panelTabel.SuspendLayout()
        Me.panelCari.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(94, 13)
        Label1.TabIndex = 0
        Label1.Text = "Cari Berdasarkan :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 21)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 0
        Label2.Text = "Terpilih :"
        '
        'lblHargaDescriptor
        '
        Me.lblHargaDescriptor.AutoSize = True
        Me.lblHargaDescriptor.Location = New System.Drawing.Point(3, 5)
        Me.lblHargaDescriptor.Name = "lblHargaDescriptor"
        Me.lblHargaDescriptor.Size = New System.Drawing.Size(42, 13)
        Me.lblHargaDescriptor.TabIndex = 8
        Me.lblHargaDescriptor.Text = "Harga :"
        '
        'lblTotalDescriptor
        '
        Me.lblTotalDescriptor.AutoSize = True
        Me.lblTotalDescriptor.Location = New System.Drawing.Point(3, 5)
        Me.lblTotalDescriptor.Name = "lblTotalDescriptor"
        Me.lblTotalDescriptor.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalDescriptor.TabIndex = 11
        Me.lblTotalDescriptor.Text = "Total Biaya :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(406, 420)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 999999
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 999998
        Me.Cancel_Button.Text = "Cancel"
        '
        'cmbKolom
        '
        Me.cmbKolom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKolom.FormattingEnabled = True
        Me.cmbKolom.Items.AddRange(New Object() {"EMPTY"})
        Me.cmbKolom.Location = New System.Drawing.Point(112, 12)
        Me.cmbKolom.Name = "cmbKolom"
        Me.cmbKolom.Size = New System.Drawing.Size(313, 21)
        Me.cmbKolom.TabIndex = 1
        '
        'cmbKondisi
        '
        Me.cmbKondisi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKondisi.FormattingEnabled = True
        Me.cmbKondisi.Items.AddRange(New Object() {"Mengandung", "Sama persis"})
        Me.cmbKondisi.Location = New System.Drawing.Point(431, 12)
        Me.cmbKondisi.Name = "cmbKondisi"
        Me.cmbKondisi.Size = New System.Drawing.Size(121, 21)
        Me.cmbKondisi.TabIndex = 2
        '
        'tbKunci
        '
        Me.tbKunci.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKunci.Location = New System.Drawing.Point(112, 39)
        Me.tbKunci.Name = "tbKunci"
        Me.tbKunci.Size = New System.Drawing.Size(440, 20)
        Me.tbKunci.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(112, 65)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dgvTabel
        '
        Me.dgvTabel.AllowUserToAddRows = False
        Me.dgvTabel.AllowUserToDeleteRows = False
        Me.dgvTabel.AutoGenerateColumns = False
        Me.dgvTabel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabel.DataSource = Me.bindingSource
        Me.dgvTabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabel.Location = New System.Drawing.Point(0, 0)
        Me.dgvTabel.MultiSelect = False
        Me.dgvTabel.Name = "dgvTabel"
        Me.dgvTabel.ReadOnly = True
        Me.dgvTabel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabel.Size = New System.Drawing.Size(540, 177)
        Me.dgvTabel.StandardTab = True
        Me.dgvTabel.TabIndex = 6
        '
        'bindingSource
        '
        Me.bindingSource.DataSource = Me.dataSet
        Me.bindingSource.Position = 0
        '
        'dataSet
        '
        Me.dataSet.DataSetName = "DataSetBengkel"
        Me.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbItem
        '
        Me.gbItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbItem.Controls.Add(Me.tbTerpilih)
        Me.gbItem.Controls.Add(Me.panelHarga)
        Me.gbItem.Controls.Add(Me.panelTotalBayar)
        Me.gbItem.Controls.Add(Label2)
        Me.gbItem.Location = New System.Drawing.Point(12, 277)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(540, 140)
        Me.gbItem.TabIndex = 7
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Karakteristik Item"
        '
        'tbTerpilih
        '
        Me.tbTerpilih.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTerpilih.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTerpilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbTerpilih.Location = New System.Drawing.Point(82, 16)
        Me.tbTerpilih.Name = "tbTerpilih"
        Me.tbTerpilih.ReadOnly = True
        Me.tbTerpilih.Size = New System.Drawing.Size(452, 19)
        Me.tbTerpilih.TabIndex = 0
        Me.tbTerpilih.TabStop = False
        '
        'panelHarga
        '
        Me.panelHarga.AutoSize = True
        Me.panelHarga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelHarga.Controls.Add(Me.lblHargaDescriptor)
        Me.panelHarga.Controls.Add(Me.lblHarga)
        Me.panelHarga.Location = New System.Drawing.Point(6, 39)
        Me.panelHarga.Name = "panelHarga"
        Me.panelHarga.Size = New System.Drawing.Size(105, 20)
        Me.panelHarga.TabIndex = 15
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(72, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(30, 20)
        Me.lblHarga.TabIndex = 10
        Me.lblHarga.Text = "0.-"
        '
        'panelTotalBayar
        '
        Me.panelTotalBayar.AutoSize = True
        Me.panelTotalBayar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelTotalBayar.Controls.Add(Me.lblTotalDescriptor)
        Me.panelTotalBayar.Controls.Add(Me.lblTotal)
        Me.panelTotalBayar.Location = New System.Drawing.Point(6, 114)
        Me.panelTotalBayar.Name = "panelTotalBayar"
        Me.panelTotalBayar.Size = New System.Drawing.Size(105, 20)
        Me.panelTotalBayar.TabIndex = 14
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(72, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 20)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "0.-"
        '
        'panelTabel
        '
        Me.panelTabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTabel.Controls.Add(Me.dgvTabel)
        Me.panelTabel.Location = New System.Drawing.Point(12, 94)
        Me.panelTabel.Name = "panelTabel"
        Me.panelTabel.Size = New System.Drawing.Size(540, 177)
        Me.panelTabel.TabIndex = 8
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(193, 65)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'panelCari
        '
        Me.panelCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCari.Controls.Add(Label1)
        Me.panelCari.Controls.Add(Me.btnReset)
        Me.panelCari.Controls.Add(Me.btnCari)
        Me.panelCari.Controls.Add(Me.tbKunci)
        Me.panelCari.Controls.Add(Me.cmbKolom)
        Me.panelCari.Controls.Add(Me.cmbKondisi)
        Me.panelCari.Location = New System.Drawing.Point(0, 0)
        Me.panelCari.Name = "panelCari"
        Me.panelCari.Size = New System.Drawing.Size(564, 90)
        Me.panelCari.TabIndex = 9
        '
        'DialogTransaksiItemBelanja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.Controls.Add(Me.panelCari)
        Me.Controls.Add(Me.panelTabel)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogTransaksiItemBelanja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Keranjang Belanja"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.panelHarga.ResumeLayout(False)
        Me.panelHarga.PerformLayout()
        Me.panelTotalBayar.ResumeLayout(False)
        Me.panelTotalBayar.PerformLayout()
        Me.panelTabel.ResumeLayout(False)
        Me.panelCari.ResumeLayout(False)
        Me.panelCari.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cmbKondisi As ComboBox
    Protected Friend WithEvents dgvTabel As DataGridView
    Protected WithEvents bindingSource As BindingSource
    Protected WithEvents dataSet As DataSetBengkel
    Protected Friend WithEvents gbItem As GroupBox
    Protected Friend WithEvents cmbKolom As ComboBox
    Protected Friend WithEvents tbKunci As TextBox
    Protected Friend WithEvents panelTabel As Panel
    Private WithEvents btnCari As Button
    Private WithEvents btnReset As Button
    Private WithEvents lblTotal As Label
    Protected Friend WithEvents panelTotalBayar As Panel
    Protected Friend WithEvents panelHarga As Panel
    Private WithEvents lblHarga As Label
    Protected Friend WithEvents tbTerpilih As TextBox
    Protected Friend WithEvents panelCari As Panel
    Protected WithEvents lblHargaDescriptor As Label
    Protected WithEvents lblTotalDescriptor As Label
End Class

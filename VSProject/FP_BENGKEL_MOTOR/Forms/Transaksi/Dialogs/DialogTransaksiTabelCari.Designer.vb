<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogTransaksiTabelCari
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
        Me.panelTabel = New System.Windows.Forms.Panel()
        Me.gbSelected = New System.Windows.Forms.GroupBox()
        Me.dgvSelected = New System.Windows.Forms.DataGridView()
        Me.ColumnAtribut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNilai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReset = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTabel.SuspendLayout()
        Me.gbSelected.SuspendLayout()
        CType(Me.dgvSelected, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OK_Button.Text = "Pilih"
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
        Me.cmbKolom.Items.AddRange(New Object() {"[EMPTY]"})
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
        Me.dgvTabel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTabel.Location = New System.Drawing.Point(0, 0)
        Me.dgvTabel.MultiSelect = False
        Me.dgvTabel.Name = "dgvTabel"
        Me.dgvTabel.ReadOnly = True
        Me.dgvTabel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabel.Size = New System.Drawing.Size(540, 177)
        Me.dgvTabel.StandardTab = True
        Me.dgvTabel.TabIndex = 5
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
        'gbSelected
        '
        Me.gbSelected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSelected.Controls.Add(Me.dgvSelected)
        Me.gbSelected.Location = New System.Drawing.Point(12, 277)
        Me.gbSelected.Name = "gbSelected"
        Me.gbSelected.Size = New System.Drawing.Size(540, 137)
        Me.gbSelected.TabIndex = 9
        Me.gbSelected.TabStop = False
        Me.gbSelected.Text = "Karakteristik Item yang Terpilih"
        '
        'dgvSelected
        '
        Me.dgvSelected.AllowUserToAddRows = False
        Me.dgvSelected.AllowUserToDeleteRows = False
        Me.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnAtribut, Me.ColumnNilai})
        Me.dgvSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelected.Location = New System.Drawing.Point(3, 16)
        Me.dgvSelected.Name = "dgvSelected"
        Me.dgvSelected.ReadOnly = True
        Me.dgvSelected.Size = New System.Drawing.Size(534, 118)
        Me.dgvSelected.StandardTab = True
        Me.dgvSelected.TabIndex = 0
        Me.dgvSelected.TabStop = False
        '
        'ColumnAtribut
        '
        Me.ColumnAtribut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnAtribut.HeaderText = "Atribut"
        Me.ColumnAtribut.Name = "ColumnAtribut"
        Me.ColumnAtribut.ReadOnly = True
        '
        'ColumnNilai
        '
        Me.ColumnNilai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNilai.HeaderText = "Nilai"
        Me.ColumnNilai.Name = "ColumnNilai"
        Me.ColumnNilai.ReadOnly = True
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
        'DialogTransaksiTabelCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbSelected)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbKolom)
        Me.Controls.Add(Me.cmbKondisi)
        Me.Controls.Add(Me.tbKunci)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.panelTabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogTransaksiTabelCari"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Browse XXX..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTabel.ResumeLayout(False)
        Me.gbSelected.ResumeLayout(False)
        CType(Me.dgvSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cmbKondisi As ComboBox
    Friend WithEvents btnCari As Button
    Protected Friend WithEvents dgvTabel As DataGridView
    Protected WithEvents dataSet As DataSetBengkel
    Protected Friend WithEvents cmbKolom As ComboBox
    Protected Friend WithEvents tbKunci As TextBox
    Protected Friend WithEvents panelTabel As Panel
    Protected Friend WithEvents gbSelected As GroupBox
    Protected Friend WithEvents dgvSelected As DataGridView
    Protected Friend WithEvents btnReset As Button
    Friend WithEvents ColumnAtribut As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNilai As DataGridViewTextBoxColumn
    Protected Friend WithEvents bindingSource As BindingSource
End Class

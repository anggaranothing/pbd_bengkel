<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogGantiPassword
    Inherits FP_BENGKEL_MOTOR.DialogAutentikasi

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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.inputTBPassBaru = New System.Windows.Forms.TextBox()
        Me.inputTBPassBaruUlangi = New System.Windows.Forms.TextBox()
        Me.USERTableAdapter = New FP_BENGKEL_MOTOR.DataSetBengkelTableAdapters.USERTableAdapter()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputTBNama
        '
        Me.inputTBNama.ReadOnly = True
        '
        'inputTBPassword
        '
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(12, 99)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 27)
        Label3.TabIndex = 6
        Label3.Text = "Password Baru"
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(12, 128)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 18)
        Label1.TabIndex = 9
        Label1.Text = "Ketik Ulang"
        '
        'inputTBPassBaru
        '
        Me.inputTBPassBaru.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputTBPassBaru.Location = New System.Drawing.Point(80, 99)
        Me.inputTBPassBaru.Name = "inputTBPassBaru"
        Me.inputTBPassBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputTBPassBaru.Size = New System.Drawing.Size(343, 20)
        Me.inputTBPassBaru.TabIndex = 7
        Me.inputTBPassBaru.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'inputTBPassBaruUlangi
        '
        Me.inputTBPassBaruUlangi.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputTBPassBaruUlangi.Location = New System.Drawing.Point(80, 125)
        Me.inputTBPassBaruUlangi.Name = "inputTBPassBaruUlangi"
        Me.inputTBPassBaruUlangi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputTBPassBaruUlangi.Size = New System.Drawing.Size(343, 20)
        Me.inputTBPassBaruUlangi.TabIndex = 8
        Me.inputTBPassBaruUlangi.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'USERTableAdapter
        '
        Me.USERTableAdapter.ClearBeforeFill = True
        '
        'DialogGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(435, 212)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.inputTBPassBaruUlangi)
        Me.Controls.Add(Me.inputTBPassBaru)
        Me.Controls.Add(Label3)
        Me.Name = "DialogGantiPassword"
        Me.Text = "Ganti Password"
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.inputTBPassword, 0)
        Me.Controls.SetChildIndex(Me.inputTBNama, 0)
        Me.Controls.SetChildIndex(Me.inputTBPassBaru, 0)
        Me.Controls.SetChildIndex(Me.inputTBPassBaruUlangi, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputTBPassBaru As TextBox
    Friend WithEvents inputTBPassBaruUlangi As TextBox
    Friend WithEvents USERTableAdapter As DataSetBengkelTableAdapters.USERTableAdapter
End Class

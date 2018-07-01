<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogAutentikasi
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
        Dim Label1 As System.Windows.Forms.Label
        Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Dim OK_Button As System.Windows.Forms.Button
        Dim Cancel_Button As System.Windows.Forms.Button
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.inputTBNama = New System.Windows.Forms.TextBox()
        Me.inputTBPassword = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        OK_Button = New System.Windows.Forms.Button()
        Cancel_Button = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(179, 13)
        Label1.TabIndex = 1
        Label1.Text = "Masukkan nama user dan pasword :"
        '
        'TableLayoutPanel1
        '
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.Controls.Add(OK_Button, 1, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 2, 0)
        TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        TableLayoutPanel1.Location = New System.Drawing.Point(0, 131)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(435, 36)
        TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        OK_Button.Location = New System.Drawing.Point(271, 6)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New System.Drawing.Size(67, 23)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '
        'Cancel_Button
        '
        Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Cancel_Button.Location = New System.Drawing.Point(358, 6)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 50)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 13)
        Label2.TabIndex = 4
        Label2.Text = "Username :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 76)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 13)
        Label3.TabIndex = 5
        Label3.Text = "Password  :"
        '
        'inputTBNama
        '
        Me.inputTBNama.Location = New System.Drawing.Point(80, 47)
        Me.inputTBNama.Name = "inputTBNama"
        Me.inputTBNama.Size = New System.Drawing.Size(343, 20)
        Me.inputTBNama.TabIndex = 0
        '
        'inputTBPassword
        '
        Me.inputTBPassword.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.inputTBPassword.Location = New System.Drawing.Point(80, 73)
        Me.inputTBPassword.Name = "inputTBPassword"
        Me.inputTBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputTBPassword.Size = New System.Drawing.Size(343, 20)
        Me.inputTBPassword.TabIndex = 1
        Me.inputTBPassword.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'DialogAutentikasi
        '
        Me.AcceptButton = OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 167)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.inputTBNama)
        Me.Controls.Add(Me.inputTBPassword)
        Me.Controls.Add(TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogAutentikasi"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Autentikasi"
        TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents inputTBNama As TextBox
    Protected Friend WithEvents inputTBPassword As TextBox
End Class

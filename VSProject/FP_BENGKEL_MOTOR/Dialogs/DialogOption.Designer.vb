<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogOption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDBConnecting = New System.Windows.Forms.Label()
        Me.pictDbConnecting = New System.Windows.Forms.PictureBox()
        Me.btnTestConn = New System.Windows.Forms.Button()
        Me.tbDBName = New System.Windows.Forms.TextBox()
        Me.tbDBServer = New System.Windows.Forms.TextBox()
        Me.cbSQL = New System.Windows.Forms.CheckBox()
        Me.paneSQL = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDBPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDBUser = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbHashCompleted = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTotalTime = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelTotalIter = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numSecurityPassStrength = New System.Windows.Forms.NumericUpDown()
        Me.btnTestHash = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxFasterLoad = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.bgDBConnectionTest = New System.ComponentModel.BackgroundWorker()
        Me.timerConnTestStatus = New System.Windows.Forms.Timer(Me.components)
        Me.timerHashTest = New System.Windows.Forms.Timer(Me.components)
        Me.bgHashSpeedCalculator = New FP_BENGKEL_MOTOR.AbortableBackgroundWorker()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictDbConnecting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneSQL.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numSecurityPassStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 9)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(396, 521)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDBConnecting)
        Me.GroupBox1.Controls.Add(Me.pictDbConnecting)
        Me.GroupBox1.Controls.Add(Me.btnTestConn)
        Me.GroupBox1.Controls.Add(Me.tbDBName)
        Me.GroupBox1.Controls.Add(Me.tbDBServer)
        Me.GroupBox1.Controls.Add(Me.cbSQL)
        Me.GroupBox1.Controls.Add(Me.paneSQL)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'lblDBConnecting
        '
        Me.lblDBConnecting.AutoSize = True
        Me.lblDBConnecting.Location = New System.Drawing.Point(256, 190)
        Me.lblDBConnecting.Name = "lblDBConnecting"
        Me.lblDBConnecting.Size = New System.Drawing.Size(70, 13)
        Me.lblDBConnecting.TabIndex = 10
        Me.lblDBConnecting.Text = "Connecting..."
        '
        'pictDbConnecting
        '
        Me.pictDbConnecting.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_hourglass
        Me.pictDbConnecting.Location = New System.Drawing.Point(233, 185)
        Me.pictDbConnecting.Name = "pictDbConnecting"
        Me.pictDbConnecting.Size = New System.Drawing.Size(17, 25)
        Me.pictDbConnecting.TabIndex = 9
        Me.pictDbConnecting.TabStop = False
        '
        'btnTestConn
        '
        Me.btnTestConn.Location = New System.Drawing.Point(332, 182)
        Me.btnTestConn.Name = "btnTestConn"
        Me.btnTestConn.Size = New System.Drawing.Size(52, 29)
        Me.btnTestConn.TabIndex = 8
        Me.btnTestConn.Text = "Test"
        Me.btnTestConn.UseVisualStyleBackColor = True
        '
        'tbDBName
        '
        Me.tbDBName.Location = New System.Drawing.Point(158, 19)
        Me.tbDBName.Name = "tbDBName"
        Me.tbDBName.Size = New System.Drawing.Size(226, 20)
        Me.tbDBName.TabIndex = 2
        '
        'tbDBServer
        '
        Me.tbDBServer.Location = New System.Drawing.Point(158, 45)
        Me.tbDBServer.Name = "tbDBServer"
        Me.tbDBServer.Size = New System.Drawing.Size(226, 20)
        Me.tbDBServer.TabIndex = 0
        '
        'cbSQL
        '
        Me.cbSQL.AutoSize = True
        Me.cbSQL.Location = New System.Drawing.Point(6, 92)
        Me.cbSQL.Name = "cbSQL"
        Me.cbSQL.Size = New System.Drawing.Size(182, 17)
        Me.cbSQL.TabIndex = 11
        Me.cbSQL.Text = "Pakai SQL Server Authentication"
        Me.cbSQL.UseVisualStyleBackColor = True
        '
        'paneSQL
        '
        Me.paneSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneSQL.Controls.Add(Me.Label3)
        Me.paneSQL.Controls.Add(Me.tbDBPass)
        Me.paneSQL.Controls.Add(Me.Label4)
        Me.paneSQL.Controls.Add(Me.tbDBUser)
        Me.paneSQL.Enabled = False
        Me.paneSQL.Location = New System.Drawing.Point(0, 115)
        Me.paneSQL.Name = "paneSQL"
        Me.paneSQL.Size = New System.Drawing.Size(390, 61)
        Me.paneSQL.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Username"
        '
        'tbDBPass
        '
        Me.tbDBPass.DataBindings.Add(New System.Windows.Forms.Binding("UseSystemPasswordChar", Global.FP_BENGKEL_MOTOR.My.MySettings.Default, "UseSystemPasswordChar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbDBPass.Location = New System.Drawing.Point(158, 32)
        Me.tbDBPass.Name = "tbDBPass"
        Me.tbDBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbDBPass.Size = New System.Drawing.Size(226, 20)
        Me.tbDBPass.TabIndex = 6
        Me.tbDBPass.UseSystemPasswordChar = Global.FP_BENGKEL_MOTOR.My.MySettings.Default.UseSystemPasswordChar
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'tbDBUser
        '
        Me.tbDBUser.Location = New System.Drawing.Point(158, 6)
        Me.tbDBUser.Name = "tbDBUser"
        Me.tbDBUser.Size = New System.Drawing.Size(226, 20)
        Me.tbDBUser.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbHashCompleted)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbTotalTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.labelTotalIter)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.numSecurityPassStrength)
        Me.GroupBox2.Controls.Add(Me.btnTestHash)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 168)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security"
        '
        'ckbHashCompleted
        '
        Me.ckbHashCompleted.AutoSize = True
        Me.ckbHashCompleted.Enabled = False
        Me.ckbHashCompleted.Location = New System.Drawing.Point(158, 71)
        Me.ckbHashCompleted.Name = "ckbHashCompleted"
        Me.ckbHashCompleted.Size = New System.Drawing.Size(15, 14)
        Me.ckbHashCompleted.TabIndex = 13
        Me.ckbHashCompleted.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "detik"
        '
        'tbTotalTime
        '
        Me.tbTotalTime.Location = New System.Drawing.Point(179, 68)
        Me.tbTotalTime.Name = "tbTotalTime"
        Me.tbTotalTime.ReadOnly = True
        Me.tbTotalTime.Size = New System.Drawing.Size(111, 20)
        Me.tbTotalTime.TabIndex = 11
        Me.tbTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Waktu yg Diperlukan"
        '
        'labelTotalIter
        '
        Me.labelTotalIter.AutoSize = True
        Me.labelTotalIter.Location = New System.Drawing.Point(156, 46)
        Me.labelTotalIter.Name = "labelTotalIter"
        Me.labelTotalIter.Size = New System.Drawing.Size(21, 13)
        Me.labelTotalIter.TabIndex = 7
        Me.labelTotalIter.Text = "{0}"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah Perulangan"
        '
        'Label6
        '
        Me.Label6.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_construction_cone
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(7, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(378, 54)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PERINGATAN!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sumber daya CPU akan digunakan dalam kalkulasi password hashing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se" &
    "suaikan dengan kekuatan CPU yang di miliki." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Rekomendasi) 10"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password Hash Strength"
        '
        'numSecurityPassStrength
        '
        Me.numSecurityPassStrength.Location = New System.Drawing.Point(158, 19)
        Me.numSecurityPassStrength.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numSecurityPassStrength.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numSecurityPassStrength.Name = "numSecurityPassStrength"
        Me.numSecurityPassStrength.Size = New System.Drawing.Size(226, 20)
        Me.numSecurityPassStrength.TabIndex = 0
        Me.numSecurityPassStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSecurityPassStrength.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnTestHash
        '
        Me.btnTestHash.Location = New System.Drawing.Point(332, 46)
        Me.btnTestHash.Name = "btnTestHash"
        Me.btnTestHash.Size = New System.Drawing.Size(53, 42)
        Me.btnTestHash.TabIndex = 10
        Me.btnTestHash.Text = "Test"
        Me.btnTestHash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTestHash.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBoxFasterLoad)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 75)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Performance"
        '
        'CheckBoxFasterLoad
        '
        Me.CheckBoxFasterLoad.AutoSize = True
        Me.CheckBoxFasterLoad.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxFasterLoad.Name = "CheckBoxFasterLoad"
        Me.CheckBoxFasterLoad.Size = New System.Drawing.Size(180, 17)
        Me.CheckBoxFasterLoad.TabIndex = 12
        Me.CheckBoxFasterLoad.Text = "Percepat Proses Loading Form ?"
        Me.CheckBoxFasterLoad.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnApply)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 483)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(390, 30)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(312, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(231, 3)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "&Terapkan"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(150, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'bgDBConnectionTest
        '
        Me.bgDBConnectionTest.WorkerSupportsCancellation = True
        '
        'timerConnTestStatus
        '
        Me.timerConnTestStatus.Interval = 333
        '
        'timerHashTest
        '
        '
        'bgHashSpeedCalculator
        '
        Me.bgHashSpeedCalculator.WorkerSupportsCancellation = True
        '
        'DialogOption
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(414, 539)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogOption"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictDbConnecting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneSQL.ResumeLayout(False)
        Me.paneSQL.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numSecurityPassStrength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents tbDBServer As TextBox
    Friend WithEvents tbDBName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDBUser As TextBox
    Friend WithEvents tbDBPass As TextBox
    Friend WithEvents btnTestConn As Button
    Friend WithEvents bgDBConnectionTest As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblDBConnecting As Label
    Friend WithEvents pictDbConnecting As PictureBox
    Friend WithEvents timerConnTestStatus As Windows.Forms.Timer
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnApply As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cbSQL As CheckBox
    Friend WithEvents paneSQL As Panel
    Friend WithEvents numSecurityPassStrength As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labelTotalIter As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTestHash As Button
    Friend WithEvents bgHashSpeedCalculator As AbortableBackgroundWorker
    Friend WithEvents timerHashTest As Windows.Forms.Timer
    Friend WithEvents tbTotalTime As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ckbHashCompleted As CheckBox
    Private WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBoxFasterLoad As CheckBox
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents GroupBox2 As GroupBox
End Class

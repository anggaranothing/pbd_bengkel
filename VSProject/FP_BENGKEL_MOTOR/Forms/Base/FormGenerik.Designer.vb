<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerik
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
        Dim btnTutup As System.Windows.Forms.ToolStripButton
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Me.tsMenuBar = New System.Windows.Forms.ToolStrip()
        Me.lblJudulForm = New System.Windows.Forms.ToolStripLabel()
        Me.timerCekPeranUser = New System.Windows.Forms.Timer(Me.components)
        btnTutup = New System.Windows.Forms.ToolStripButton()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsMenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        btnTutup.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_exit
        btnTutup.ImageTransparentColor = System.Drawing.Color.Magenta
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New System.Drawing.Size(59, 22)
        btnTutup.Text = "Tutup"
        AddHandler btnTutup.Click, AddressOf Me.btnTutup_Click
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsMenuBar
        '
        Me.tsMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {btnTutup, ToolStripSeparator1, Me.lblJudulForm})
        Me.tsMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuBar.Name = "tsMenuBar"
        Me.tsMenuBar.Size = New System.Drawing.Size(284, 25)
        Me.tsMenuBar.Stretch = True
        Me.tsMenuBar.TabIndex = 0
        '
        'lblJudulForm
        '
        Me.lblJudulForm.Enabled = False
        Me.lblJudulForm.Name = "lblJudulForm"
        Me.lblJudulForm.Size = New System.Drawing.Size(88, 22)
        Me.lblJudulForm.Text = "ToolStripLabel1"
        '
        'timerCekPeranUser
        '
        Me.timerCekPeranUser.Interval = 500
        '
        'FormGenerik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.tsMenuBar)
        Me.DoubleBuffered = True
        Me.Name = "FormGenerik"
        Me.Text = "FormGenerik"
        Me.tsMenuBar.ResumeLayout(False)
        Me.tsMenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents timerCekPeranUser As System.Windows.Forms.Timer
    Private WithEvents lblJudulForm As ToolStripLabel
    Private WithEvents tsMenuBar As ToolStrip
End Class

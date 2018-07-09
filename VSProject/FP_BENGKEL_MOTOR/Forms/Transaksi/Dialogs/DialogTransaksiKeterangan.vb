Imports System.Windows.Forms

Public NotInheritable Class DialogTransaksiKeterangan
    Public Sub New(Optional rtfStr As String = "")
        MyBase.New()
        Me.InitializeComponent()

        Try
            Me.dialogOutput.Rtf = rtfStr
        Catch ex As ArgumentException
            '-- Bukan RTF? berarti ubah jadi teks biasa
            Me.dialogOutput.Text = rtfStr
        End Try
    End Sub

    Friend Sub SetReadOnly(switch As Boolean)
        Me.dialogOutput.ReadOnly = switch
        Me.rtbEditor.Enabled = Not switch
        Me.OK_Button.Enabled = Not switch
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RichTextBoxEx1_Load(sender As Object, e As EventArgs) Handles rtbEditor.Load
        PerbaikiRightClickMenuRTB(dialogOutput)
    End Sub
End Class

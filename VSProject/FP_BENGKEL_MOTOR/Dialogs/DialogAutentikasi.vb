Imports System.Windows.Forms

Public Class DialogAutentikasi

    Protected Friend Overridable Function DoAuth() As Boolean
        Return True
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Enabled = False
        If Me.DoAuth() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
            Return
        End If
        Me.Enabled = True
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class

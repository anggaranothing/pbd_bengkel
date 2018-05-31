Module DialogBuatan
    Public Sub ShowExceptionMessage(ex As Exception)
        ShowExceptionMessage(Nothing, ex)
    End Sub
    Public Sub ShowExceptionMessage(owner As IWin32Window, ex As Exception)
#If DEBUG Then
        System.Console.Out.WriteLine(ex.ToString)
#End If

        Dim msgBoxText As String
        msgBoxText = "(" & ex.GetType().ToString() & ")" & vbCrLf & ex.Message & vbCrLf & ex.TargetSite.Name

        '---Dim tipeError As Type = ex.GetType()
        '---If (tipeError Is GetType(SqlClient.SqlException)) Then
        '-- Buang pesan sensitif dari msgbox
        '---msgBoxText = msgBoxText.Substring(0, msgBoxText.IndexOf("table '"))
        '---End If

        ShowErrorMessageBox(owner, msgBoxText, "Fatal Error")
    End Sub

    Public Sub ShowInformationMessageBox(owner As IWin32Window, pesan As String, Optional judul As String = "Information")
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        MessageBox.Show(owner, pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ShowWarningMessageBox(owner As IWin32Window, pesan As String, Optional judul As String = "Warning")
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        MessageBox.Show(owner, pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Public Sub ShowErrorMessageBox(owner As IWin32Window, pesan As String, Optional judul As String = "Error")
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        MessageBox.Show(owner, pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ShowConfirmMessageBox(owner As IWin32Window, pesan As String, Optional judul As String = "Confirmation") As DialogResult
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Return MessageBox.Show(owner, pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    End Function
End Module

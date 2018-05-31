Public NotInheritable Class DialogAbout
    Private secretFileBytes As Byte()
    Private tempFilePath As String

    Private Sub DialogAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        'Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub DialogAbout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        bgFileDecoder.CancelAsync()

        '-- buang file temp
        If String.IsNullOrWhiteSpace(tempFilePath) = False And System.IO.File.Exists(tempFilePath) Then
            System.IO.File.Delete(tempFilePath)
        End If
    End Sub

    Private Sub DialogAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '-- Pateni lagu ne woy!
        Me.Dispose()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles LogoPictureBox.DoubleClick
        bgFileDecoder.RunWorkerAsync()
        Me.panelSecret.Visible = True
        Me.panelSecret.BringToFront()
    End Sub

    Private Sub secretMusic_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles secretMusic.PlayStateChange
        Select Case e.newState
            Case WMPLib.WMPPlayState.wmppsPlaying
                Me.tbSecret.Text = String.Format("Playing '{0}'", "Two Steps From Hell - Strength of a Thousand Men (Archangel)")
            Case WMPLib.WMPPlayState.wmppsPaused, WMPLib.WMPPlayState.wmppsStopped
                Me.tbSecret.Text = ""
        End Select
    End Sub

    Private Sub bgFileDecoder_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgFileDecoder.DoWork
        bgFileDecoder.ReportProgress(0)
        secretFileBytes = Convert.FromBase64String(My.Resources.base64EncodedFile)

        bgFileDecoder.ReportProgress(40)
        tempFilePath = System.IO.Path.GetTempFileName()
        '-- buang file temp
        If System.IO.File.Exists(tempFilePath) Then
            System.IO.File.Delete(tempFilePath)
        End If
        tempFilePath = tempFilePath.Replace(".tmp", ".mov")

        Using tempFile As New System.IO.FileStream(tempFilePath, IO.FileMode.Create)
            bgFileDecoder.ReportProgress(50)
            Using penulisBiner As New System.IO.BinaryWriter(tempFile)
                penulisBiner.Write(secretFileBytes)
            End Using
            bgFileDecoder.ReportProgress(99)
        End Using

        bgFileDecoder.ReportProgress(100)
    End Sub

    Private Sub bgFileDecoder_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgFileDecoder.RunWorkerCompleted
        If e.Cancelled = False Then
            If e.Error IsNot Nothing Then
                Dim msg As String = "Error playing the music!" & vbCrLf & e.Error.Message
                System.Console.Out.WriteLine(msg)
                MessageBox.Show(Me, msg)
            Else
                secretMusic.URL = tempFilePath
                secretMusic.Ctlcontrols.play()
            End If
        End If
    End Sub

    Private Sub bgFileDecoder_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgFileDecoder.ProgressChanged
        Dim progPercent = e.ProgressPercentage
        Dim tulisan As String = String.Format("({0}%)" & vbTab, progPercent)

        Select Case progPercent
            Case 0
                tulisan &= "Base64 ke Bytes..."
            Case 40
                tulisan &= "Pembuatan file temporer..."
            Case 50
                tulisan &= "Membentuk file temporer..."
            Case 99
                tulisan &= "File sudah jadi! Siap pakai!"
            Case 100
                tulisan &= "Selesai!"
        End Select

        System.Console.Out.WriteLine(tulisan)
        tbSecret.Text = tulisan
    End Sub
End Class

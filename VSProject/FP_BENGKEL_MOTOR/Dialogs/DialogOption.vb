Public NotInheritable Class DialogOption
    Private Sub SimpanSetting()
        '-- Hapus info sensitif jika tidak pake sql
        If cbSQL.Checked = False Then
            tbDBUser.ResetText()
            tbDBPass.ResetText()
        End If

        btnApply.Enabled = False

        My.Settings.Item("ConnectionString") = BuildConnectionString(tbDBName.Text, tbDBServer.Text, tbDBUser.Text, tbDBPass.Text)
        My.Settings.HashStrength = numSecurityPassStrength.Value
        My.Settings.PercepatLoadingForm = CheckBoxFasterLoad.Checked

#If DEBUG Then
        System.Console.Out.WriteLine("------------------")
        System.Console.Out.WriteLine("Setting(s) Applied")

        System.Console.Out.WriteLine("ConnectionString: " & My.Settings.ConnectionString)
        System.Console.Out.WriteLine("HashStrength: " & My.Settings.HashStrength)
        System.Console.Out.WriteLine("PercepatLoadingForm: " & My.Settings.PercepatLoadingForm)

        System.Console.Out.WriteLine("------------------")
#End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        SimpanSetting()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If btnApply.Enabled Then
            btnApply.PerformClick()
        End If

        Me.Close()
    End Sub

    Private Sub DialogOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetConnectionDictionary()

        tbDBName.Text = GetConnectionDictionaryValue("Initial Catalog")
        tbDBServer.Text = GetConnectionDictionaryValue("Data Source")
        tbDBUser.Text = GetConnectionDictionaryValue("User ID")
        tbDBPass.Text = GetConnectionDictionaryValue("Password")

        If GetConnectionDictionaryValue("Integrated Security") Is "" Then
            cbSQL.Checked = True
        End If

        numSecurityPassStrength.Value = My.Settings.HashStrength

        CheckBoxFasterLoad.Checked = My.Settings.PercepatLoadingForm

        SetVisibleConnectionTestStatus(False)
        btnApply.Enabled = False
    End Sub
    Private Sub DialogOption_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Enabled = False

        bgDBConnectionTest.CancelAsync()
        bgHashSpeedCalculator.CancelAsync()
        bgHashSpeedCalculator.Abort()

        timerConnTestStatus.Stop()
        timerHashTest.Stop()
    End Sub

    Private Sub SetVisibleConnectionTestStatus(visible As Boolean)
        pictDbConnecting.Visible = visible
        lblDBConnecting.Visible = visible
    End Sub

    Private Sub EventButtonClick_TestConn(sender As Object, e As EventArgs) Handles btnTestConn.Click
        SetVisibleConnectionTestStatus(True)
        timerConnTestStatus.Start()

        bgDBConnectionTest.CancelAsync()

        If bgDBConnectionTest.IsBusy = False Then
            bgDBConnectionTest.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgDBConnectionTest_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgDBConnectionTest.DoWork
        Me.UseWaitCursor = True
        DBConnection.ConnectionString = BuildConnectionString(tbDBName.Text, tbDBServer.Text, tbDBUser.Text, tbDBPass.Text)
        TestConnection()
    End Sub

    Private Sub bgDBConnectionTest_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgDBConnectionTest.RunWorkerCompleted
        SetVisibleConnectionTestStatus(False)
        timerConnTestStatus.Stop()
        Me.UseWaitCursor = False
    End Sub

    Private Sub timerConnTestStatus_Tick(sender As Object, e As EventArgs) Handles timerConnTestStatus.Tick
        Select Case lblDBConnecting.Text.Length
            Case 10 To 12
                lblDBConnecting.Text &= "."
            Case 13
                lblDBConnecting.Text = "Connecting"
        End Select
    End Sub

    Private Sub tb_TextChanged(sender As Object, e As EventArgs) Handles tbDBName.TextChanged, tbDBServer.TextChanged, tbDBUser.TextChanged, tbDBPass.TextChanged
        OptionsChanged()
    End Sub

    Private Sub cbSQL_CheckedChanged(sender As Object, e As EventArgs) Handles cbSQL.CheckedChanged
        paneSQL.Enabled = cbSQL.Checked

        If cbSQL.Checked Then
            ConnDictionary.Remove("Integrated Security")
        Else
            SetConnectionDictionaryValue("Integrated Security", "SSPI")
        End If

        OptionsChanged()
    End Sub

    Private Sub CheckBoxFasterLoad_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFasterLoad.CheckedChanged
        OptionsChanged()
    End Sub

    Private Sub numSecurityPassStrength_ValueChanged(sender As Object, e As EventArgs) Handles numSecurityPassStrength.ValueChanged
        OptionsChanged()
        labelTotalIter.Text = Math.Pow(2, numSecurityPassStrength.Value)
    End Sub

    Private Sub btnTestHash_Click(sender As Object, e As EventArgs) Handles btnTestHash.Click
        ckbHashCompleted.Checked = False

        If bgHashSpeedCalculator.IsBusy Then
            bgHashSpeedCalculator.Abort()
            timerHashTest.Stop()
            'btnTestHash.Text = "Test"
            'btnTestHash.Image = Nothing
        Else
            btnTestHash.Image = My.Resources.icon_hourglass
            btnTestHash.Text = "Stop"
            tbTotalTime.ResetText()
            timerHashTest.Start()
            bgHashSpeedCalculator.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerHashTest_Tick(sender As Object, e As EventArgs) Handles timerHashTest.Tick
        'Select Case tbTotalTime.Text.Length
        '    Case 11 To 13
        '        tbTotalTime.Text &= "."
        '    Case 0, 14
        '        tbTotalTime.Text = "Calculating"
        'End Select
        tbTotalTime.Text = execStopWatch.Elapsed.TotalSeconds
    End Sub

    Private Sub bgHashSpeedCalculator_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgHashSpeedCalculator.DoWork
        Dim passToTest As String = "'}VyF<@9Zde>2arz"

        execStopWatch.Reset()
        execStopWatch.Start()
        BCrypt.Net.BCrypt.HashPassword(passToTest, workFactor:=numSecurityPassStrength.Value)
        execStopWatch.Stop()
    End Sub

    Private Sub bgHashSpeedCalculator_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgHashSpeedCalculator.RunWorkerCompleted
        timerHashTest.Stop()

        If e.Cancelled Then
            'tbTotalTime.Text = "Cancelled"
        ElseIf e.Error IsNot Nothing Then
            tbTotalTime.Text = "Error"
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            ckbHashCompleted.Checked = True
        End If

        btnTestHash.Text = "Test"
        btnTestHash.Image = Nothing
    End Sub

    Private Sub OptionsChanged()
        btnApply.Enabled = True
    End Sub

    Private execStopWatch As New Stopwatch()
End Class

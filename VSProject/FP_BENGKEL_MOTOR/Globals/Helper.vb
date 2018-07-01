Module Helper
    Public Sub JadikanDoubleBuffered(objKontrol As System.Windows.Forms.Control)
        '-- Taxes: Remote Desktop Connection And painting
        '-- http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
        If System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Return
        End If

        Dim aProp As System.Reflection.PropertyInfo =
            GetType(System.Windows.Forms.Control) _
                .GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic Or
                System.Reflection.BindingFlags.Instance)

        aProp.SetValue(objKontrol, True, Nothing)

        System.Console.Out.WriteLine(objKontrol.Name)
    End Sub

    Public Function NullToEmptyString(objek As Object) As String
        If (objek Is Nothing Or IsDBNull(objek)) Then
            Return ""
        End If

        Return objek
    End Function

    Public Function EmptyStringToNull(ByVal str As String) As Object
        If String.IsNullOrWhiteSpace(str.Trim()) Then
            Return Nothing
        End If

        Return str
    End Function

    Public Function NullToZeroDecimal(ByVal objek As Object) As Decimal
        If (objek Is Nothing Or IsDBNull(objek)) Then
            Return 0
        ElseIf objek.GetType() Is GetType(String) Then
            Return Decimal.Parse(objek)
        End If

        Return objek
    End Function

    Public Function GetResourcesDir() As String
        Dim ResourceFilePath As String
        ' Determine the Resource File Path

        'Published mode
        ResourceFilePath = Application.StartupPath & "\resources\"

        '#If DEBUG Then
        'Debugging mode
        '        ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
        '#End If

        Return ResourceFilePath
    End Function

    Public Sub PerbaikiRightClickMenuRTB(inputRTB As RichTextBox)
        If inputRTB Is Nothing Then
            Exit Sub
        End If

        '-- objek temporer
        Dim tempRTBe As New RichTextBoxEx.RichTextBoxEx()
        Dim oldRTB As RichTextBox = tempRTBe.rtb
        Dim newCMS = tempRTBe.rtb.ContextMenuStrip

        '-- hapus menu bermasalah
        newCMS.Items.RemoveAt(9)    'hyphen
        newCMS.Items.RemoveAt(8)    'pict
        newCMS.Items.RemoveAt(7)    'bullets
        newCMS.Items.RemoveAt(5)    'SpellCheckers
        newCMS.Items.RemoveAt(2)    'align
        newCMS.Items.RemoveAt(1)    'font

        '-- assign menu baru
        inputRTB.ContextMenuStrip = newCMS
        tempRTBe.rtb = inputRTB

        '-- hancurkan rtb dari objek temporer
        oldRTB.Dispose()
    End Sub

    Public Sub ProsesException(ex As Exception)

    End Sub
End Module

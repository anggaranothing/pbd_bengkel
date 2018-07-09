Namespace PembuatForm
    Class Form

        Shared Sub ConvertToMDIChild(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As System.Windows.Forms.Form)
            ' Check whether parent is MDI container.
            If parent.IsMdiContainer = False Then
                Throw New ArgumentException("Parent bukan berupa MDI container.", "parent")
                Exit Sub
            End If

            ' Make it a child of this MDI form before showing it.
            formOutput.MdiParent = parent
            ShowToFront(formOutput)
        End Sub

        Shared Sub ShowToFront(ByRef formOutput As System.Windows.Forms.Form, Optional parent As System.Windows.Forms.Form = Nothing, Optional asDialog As Boolean = False)
            formOutput.WindowState = FormWindowState.Normal

            '-- Kadangkala gagal/error pakai Show()
            Try
                If asDialog Then
                    formOutput.ShowDialog(parent)
                Else
                    formOutput.Show(parent)
                End If
            Catch ex As Exception
                If asDialog Then
                    Throw
                Else
                    formOutput.Visible = True
                End If
            End Try

            formOutput.BringToFront()
        End Sub

    End Class

    Class Generik

        Shared Sub CreateForm(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik, tipeForm As Type)
            Dim isMDIForm As Boolean = parent IsNot Nothing AndAlso parent.IsMdiContainer

            If isMDIForm Then
                If parent.Contains(formOutput) Then
                    Form.ShowToFront(formOutput)
                    Exit Sub
                End If
            End If

            formOutput = Activator.CreateInstance(tipeForm)

            If CheckUserAuthorization(formOutput) = False Then
                Throw New ApplicationException("Akses form ditolak.")
                Exit Sub
            End If

            formOutput.timerCekPeranUser.Start()

            If isMDIForm Then
                Form.ConvertToMDIChild(parent, formOutput)
            End If

            Form.ShowToFront(formOutput)
        End Sub

        Shared Function CheckUserAuthorization(objForm As FormGenerik) As Boolean
            If objForm Is Nothing Then
                Return False
            End If

            Return objForm.DoCheckUserAuthorization()
        End Function

    End Class

    Class Tabel

        Shared Sub BuatFormUser(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelUser))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormMekanik(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelMontir))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormJasa(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelJasa))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormBarang(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelBarang))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormTransaksi(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelTransaksi))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormPelanggan(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelPelanggan))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormKendaraan(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik)
            Try
                PembuatForm.Generik.CreateForm(parent, formOutput, GetType(FormTabelKendaraan))
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

    End Class

    Class Transaksi
        Private Shared Sub CreateForm(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik, Optional mode As TransaksiDetailMode = TransaksiDetailMode.MODE_VIEW, Optional noNota As String = Nothing, Optional asDialog As Boolean = False)
            Dim isMDIForm As Boolean = parent IsNot Nothing AndAlso parent.IsMdiContainer

            If isMDIForm Then
                If parent.Contains(formOutput) Then
                    Form.ShowToFront(formOutput)
                    Exit Sub
                End If
            End If

            If noNota Is Nothing Then
                formOutput = New FormTransaksiDetail()
            Else
                formOutput = New FormTransaksiDetail(noNota, mode)
            End If

            If Generik.CheckUserAuthorization(formOutput) = False Then
                Throw New ApplicationException("Akses form ditolak.")
                Exit Sub
            End If

            formOutput.timerCekPeranUser.Start()

            If isMDIForm Then
                Form.ConvertToMDIChild(parent, formOutput)
            End If

            Form.ShowToFront(formOutput, asDialog:=asDialog)
        End Sub

        Shared Sub BuatFormInsert(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik, Optional asDialog As Boolean = False)
            Try
                CreateForm(parent, formOutput, TransaksiDetailMode.MODE_INSERT, asDialog:=asDialog)
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormInsertReturn(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik, noNota As String, Optional asDialog As Boolean = False)
            Try
                CreateForm(parent, formOutput, TransaksiDetailMode.MODE_INSERT_RETURN, noNota, asDialog)
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub

        Shared Sub BuatFormView(ByRef parent As System.Windows.Forms.Form, ByRef formOutput As FormGenerik, noNota As String, Optional asDialog As Boolean = False)
            Try
                CreateForm(parent, formOutput, TransaksiDetailMode.MODE_VIEW, noNota, asDialog)
            Catch ex As Exception
                ShowErrorMessageBox(parent, ex.Message)
            End Try
        End Sub
    End Class
End Namespace
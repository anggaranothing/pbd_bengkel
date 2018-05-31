'-- https://stackoverflow.com/a/2104662

Imports System.ComponentModel

Public Class AbortableBackgroundWorker
    Inherits System.ComponentModel.BackgroundWorker

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        Abort()
        MyBase.Dispose(disposing)
    End Sub

    Protected Overrides Sub OnRunWorkerCompleted(e As RunWorkerCompletedEventArgs)
        If e IsNot Nothing And isAborted Then
            e = New RunWorkerCompletedEventArgs(e.Result, e.Error, True)
        End If
        MyBase.OnRunWorkerCompleted(e)
    End Sub

    Protected Overrides Sub OnDoWork(e As DoWorkEventArgs)
        workerThread = Thread.CurrentThread

        isAborted = False
        Try
            MyBase.OnDoWork(e)
        Catch ex As ThreadAbortException
            isAborted = True
            'ex.Cancel = True '-- We must Set Cancel Property To true!
            Thread.ResetAbort() '-- Prevents ThreadAbortException propagation
        End Try
    End Sub

    Public Sub Abort()
        If WorkerSupportsCancellation Then
            CancelAsync()
        End If
        If workerThread IsNot Nothing Then
            workerThread.Abort()
            workerThread = Nothing
        End If
    End Sub

    Private workerThread As Thread
    Private isAborted As Boolean
End Class

'汎用バックスレッドワーカ
Imports System.Threading

Public Class BackWorker
    Private thread
    Private core
    Public Sub New(c As Object)
        thread = Nothing
        core = c
    End Sub

    Public Sub start()
        If Not isWorking() Then
            thread = New Thread(New ThreadStart(AddressOf core.work))
            thread.Start()
        End If
    End Sub

    Public Sub abort()
        If isWorking() Then
            thread.Abort()
            thread.Join()
        End If
        thread = Nothing
    End Sub

    Public Function isWorking()
        Return If(Not thread Is Nothing, True, False)
    End Function

End Class

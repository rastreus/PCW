Imports System.Collections

Public Class SingletonQueue
    Private Shared singleInstance As Queue(Of MarketingPromo)
    Private Sub New()
        'In this case, the Sub does nothing
    End Sub
    Public Shared ReadOnly Property Instance() _
        As Queue(Of MarketingPromo)
        Get
            If singleInstance Is Nothing Then
                singleInstance = New Queue(Of MarketingPromo)
            End If
            Return singleInstance
        End Get
    End Property
End Class

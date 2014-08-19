Public Class Lingering_ToolTip
    Inherits ToolTip

    Public Sub Just_Linger(ByVal sender As Object, ByVal e As EventArgs)
        Me.StopTimer()
    End Sub

End Class
Public Class PAE

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancel As Boolean = AskToClose()
        If cancel Then
            Me.Close()
        End If
    End Sub

    Private Function AskToClose()
        Dim cancelMsgString As String = <a>Do you wish to quit the editor now?
Your changes will not be saved if you do.</a>.Value

        Dim result As Integer = CenteredMessagebox.MsgBox.Show(cancelMsgString, "Exit editor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
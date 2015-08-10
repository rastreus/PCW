Public Class PAE

	Private Sub btnCancel_Click(sender As Object, _
								e As EventArgs) _
		Handles btnCancel.Click
		Dim cancel As Boolean = AskToClose()
		If cancel = True Then
			Me.Close()
		End If
	End Sub

	Private Function AskToClose()
		Dim bool As Boolean = False
		Dim cancelMsgString As String = "Do you wish to quit PAE now?" & _
										vbCrLf & "Your changes will not " & _
										"be saved if you do."
		Dim result As Integer = _
			CenteredMessagebox.MsgBox.Show(cancelMsgString, _
										   "Exit editor?", _
											MessageBoxButtons.YesNo, _
											MessageBoxIcon.Question)
		If result = DialogResult.Yes Then
			bool = True
		Else
			bool = False
		End If
		Return bool
	End Function
End Class

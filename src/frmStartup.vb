Imports AutoUpdate

Public Class frmStartup
	Private Sub frmStartup_Load(sender As Object, _
								e As EventArgs) _
		Handles Me.Load
		AutoUpdate.RootPath = "\\domainserver\data\InformationTechnology" & _
							  "\Software Master\Oaklawn\PCW"
		AutoUpdate.ErrorMessage = "THERE WAS AN ERROR IN AUTOUPDATE!"
		If AutoUpdate.UpdateEXE() Then
			GUI_Util.msgBox("PCW auto-updated to latest version!" & vbCrLf & _
							"Please restart PCW after quit.", _
							"AUTO-UPDATE SUCCESS!", _
							"Information")
		Else
			Dim frmMain As PCW = New PCW
			frmMain.Show()
		End If
		Me.Close()
		Me.Dispose()
	End Sub
End Class

Imports AutoUpdate

''' <summary>
''' Startup Form which checks for updates (and applies if needed).
''' </summary>
''' <remarks>
''' On each new release of PCW that needs to be pushed out:
''' 0.) Go to the RootPath.
''' 1.) Create a new folder whose name is the newest version.
'''     EXAMPLE: 00040001
''' 2.) Copy the new release exe into the folder from \bin\Release.
''' 3.) Rename the exe by appending "-" and the newest version.
'''     EXAMPLE: PromotionalCreationWizard-00040001.exe
''' 4.) Update the "UpdateFile" with the newest version.
'''     EXAMPLE: 0.4.0.1
''' 5.) Done! An old, out-of-date copy of PCW will auto-update itself.
''' </remarks>
Public Class frmAutoUpdate
	Private Sub frmStartup_Activate(sender As PCW, _
									e As EventArgs) _
		Handles Me.Activated
		AutoUpdate.RootPath = "\\domainserver\data\InformationTechnology" & _
							  "\Software Master\Oaklawn\PCW"
		AutoUpdate.UpdateFile = "_update.dat"
		AutoUpdate.ErrorMessage = "ERROR IN AUTOUPDATE!"
		If AutoUpdate.UpdateEXE() Then
			GUI_Util.msgBox("PCW auto-updated to latest version!" & vbCrLf & _
							"Please quit and restart PCW.", _
							"AUTO-UPDATE SUCCESS!", _
							"Information")
		End If
		If sender.Visible = False Then
			sender.Visible = True
		End If
		Me.Close()
	End Sub
End Class

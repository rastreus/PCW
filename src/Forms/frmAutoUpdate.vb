#Region "COPYING"
'PromotionalCreationWizard
'Copyright (C) 2014-2016 Russell Dillin
'
'This file is part of PromotionalCreationWizard.

'   PromotionalCreationWizard is free software: you can redistribute it and/or
'   modify it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   PromotionalCreationWizard is distributed in the hope that it will be
'	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with PromotionalCreationWizard.
'	If not, see <http://www.gnu.org/licenses/>.
#End Region

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
	Private Sub frmAutoUpdate_Shown(sender As Object, _
									e As EventArgs) _
		Handles MyClass.Shown
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
		Me.Close()
	End Sub
End Class

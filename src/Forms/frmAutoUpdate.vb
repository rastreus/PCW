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
''' 
''' OBVIOUSLY UPDATE THE VERSION NUMBER BEFORE PUSHING THE UPDATE!
''' PromotionalCreationWizard > Properties > Application > Assembly Information
''' Update the Assembly Version and the File Version.
''' EXAMPLE: As of 08/25/16, the current version is 0.9.0.4.
''' If I were updating, I would simply change the version to 0.9.0.5.
''' 
''' The following steps use examples of updating from 0.9.0.4 to 0.9.0.5:
''' 
''' 0.) Go to the AutoUpdate.RootPath in your Windows file browser.
'''     (Currently: "\\domainserver\data\InformationTechnology\Software Master\Oaklawn\PCW")
''' 1.) Create a new folder whose name is the newest version.
'''     EXAMPLE: 00090005
''' 2.) Copy the new release .exe into the folder from \bin\Release.
''' 3.) Rename the exe by appending "-" and the newest version number.
'''     EXAMPLE: PromotionalCreationWizard-00090005.exe
''' 4.) Update the "UpdateFile" with the newest version.
'''     EXAMPLE: 0.9.0.5
''' 5.) Done! An old, out-of-date copy of PCW will auto-update itself upon first launch.
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

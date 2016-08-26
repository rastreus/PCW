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

''' <summary>
''' Simple Form which opens PCW or PAE.
''' </summary>
''' <remarks>
''' On "Me.Close()" the ""Me" is frmSelect. 
''' Application will not quit here because
''' "Shutdown mode" is set to "When last form closes."
''' </remarks>
Public Class frmSelect
	Private Sub btnOpenPCW_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnOpenPCW.Click
		Dim frmWizard As PCW = New PCW
		frmWizard.Show()
		Me.Close()
	End Sub

	Private Sub btnOpenPAE_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnOpenPAE.Click
		Dim frmEditor As PAE = New PAE
		frmEditor.Show()
		Me.Close()
	End Sub
End Class

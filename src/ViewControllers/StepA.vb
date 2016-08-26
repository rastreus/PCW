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

Imports TSWizards

''' <summary>
''' First Step; welcomes to the PCW.
''' </summary>
''' <remarks>A bunch of words
''' that no one will read.</remarks>
Public Class StepA
    Inherits TSWizards.BaseExteriorStep

#Region "StepA_ShowStep"
	Private Sub StepA_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		Me.lblVERNUM.Text = "v." & _
							My.Application _
							  .Info _
							  .Version _
							  .ToString
	End Sub
#End Region
#Region "StepA_InfoCircle"
	Private Sub StepA_InfoCircle_Click(sender As Object, _
									   e As EventArgs) _
		Handles StepA_InfoCircle.Click
		Dim copyStr As String = "Copyright " & ChrW(169)

		Dim infoStr As String = "Russell Dillin, 2014-2016" & vbCrLf & _
								"Brought to you by the fine folks " & _
								"of the OJC IT Department!"

		Dim str As String = copyStr & " " & infoStr

		GUI_Util.msgBox(str, "Information", "Information")
	End Sub
#End Region
#Region "StepA_btnEditPromo"
	''' <summary>
	''' Creates and opens the PAE
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>User wants to edit an existing promo
	''' instead of creating a new one.</remarks>
	Private Sub btnEditPromo_Click(sender As Object, _
								   e As EventArgs) _
		Handles btnEditPromo.Click
		Dim editor As PAE = New PAE	'Create an instance of the PME class
		editor.ShowDialog()			'Show the new 
		PCW.Close()					'Close PCW
	End Sub
#End Region
End Class

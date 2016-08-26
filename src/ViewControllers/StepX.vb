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
''' Final Step; handles rerunning the PCW.
''' </summary>
''' <remarks>Minimalism at its finest.</remarks>
Public Class StepX
	Inherits TSWizards.BaseExteriorStep

#Region "StepX_InfoCircle"
	Private Sub stepX_InfoCircle_Click(sender As Object, _
									   e As EventArgs) _
		Handles stepX_InfoCircle.Click
		Dim copyStr As String = "Copyright " & ChrW(169)
		Dim infoStr As String = "Russell Dillin, 2014-2015" & vbCrLf & _
								"Brought to you by the fine folks " & _
								"of the OJC IT Department!"

		Dim str As String = copyStr & " " & infoStr

		GUI_Util.msgBox(str, "Information", "Information")
	End Sub
#End Region
#Region "StepX_ShowStep"
	''' <summary>
	''' Stops user from going back.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Too late for the user to
	''' go back and change anything.</remarks>
	Private Sub StepX_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		PCW.BackEnabled = False
		If Me.cbPCWRerun.Checked Then
			Me.cbPCWRerun.Checked = False
		End If
	End Sub
#End Region
#Region "StepX_OnFinish"
	''' <summary>
	''' Resets and reruns the PCW.
	''' </summary>
	''' <remarks>If the user wants, he/she
	''' can do it all over again!</remarks>
	Protected Overrides Sub OnFinish()
		If PCW.Data.Reset Then
			PCW.ResetSteps()
			PCW.BackEnabled = True
			PCW.ControlBox = True
			PCW.CancelEnabled(True)
			PCW.MoveTo(PCW.Data.ResetTo)
		Else
			MyBase.OnFinish()
		End If
	End Sub
#End Region
#Region "StepX_cbPCWRerun_CheckedChanged"
	Private Sub cbPCWRerun_CheckedChanged(sender As Object, _
										  e As EventArgs) _
		Handles cbPCWRerun.CheckedChanged
		PCW.Data.Reset = Me.cbPCWRerun.Checked
	End Sub
#End Region
End Class

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
Imports System.Text
Imports System.ComponentModel

''' <summary>
''' StepI
''' </summary>
''' <remarks>
''' This Step shows the information that will be added to the database.
''' It is the last check for the user to make sure that they did not
''' accidentally make the promo incorrectly.
''' </remarks>
Public Class StepI
	Inherits TSWizards.BaseInteriorStep

#Region "StepI_ShowStep"
	Private boolFlag As Boolean = True
	Private promoSummary As StringBuilder
	Private promoPayoutSummary As StringBuilder

	Private Sub StepI_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.cbCreatePromo.Checked Then
			Me.cbCreatePromo.Checked = False
		End If
		PCW.NextEnabled = False
		PCW.PrepareAllPromoData()
		If boolFlag Then
			Me.boolFlag = False
			Me.promoSummary = PCW.Data.GetPromoSummary()
			Me.lblpromoSummary.Text = Me.promoSummary.ToString
		End If
		If (Not PCW.Data.CurrentPromoCategory = _
			PCW_Data.PromoCategory.entryOnly) Then
			Me.promoPayoutSummary = PCW.Data.GetPromoPayoutSummary()
			Me.lblPromoPayoutSummary.Text = Me.promoPayoutSummary.ToString
			Me.lblPayoutPromo.Text = "Payout | Promo  |"
		Else
			Me.lblPromoPayoutSummary.Visible = False
			Me.lblPayoutPromo.Visible = False
			Me.cbCreatePromo.Location = New System.Drawing.Point(1, -1)
			Me.pnlCreatePromo.Size = New System.Drawing.Size(219, 21)
		End If
	End Sub
#End Region
#Region "StepI_ResetStep"
	Private Sub StepI_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		StepI_ResetControls()
	End Sub

	Private Sub StepI_ResetControls()
		Me.lblPayoutPromo.Text = "****** | ****** |"
		Me.cbCreatePromo.ForeColor = Color.Black
		Me.cbCreatePromo.BackColor = Color.White
		Me.pnlCreatePromo.BackColor = Color.White
	End Sub
#End Region
#Region "StepI_Validation"
	Private warningString As String = "Check that you have read and" _
									& "confirmed the above parameters; " _
									& "otherwise, cancel and attempt the" _
									& "process again later."

	Private Sub StepI_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep

		If Not Me.cbCreatePromo.Checked Then
			e.Cancel = True
			GUI_Util.errPnl(Me.pnlCreatePromo)
			GUI_Util.msgBox(Me.warningString, _
							"Are you sure?")
		Else
			GUI_Util.regPnl(Me.pnlCreatePromo)
		End If

		PCW.Data.SubmitPromosToList()
		'HELPING THE DEBUGGING PROCESS BY
		'MAKING LOCAL VARIABLES;
		'TIS JUST FOR TESTING
		Dim _local_currMultiPartCategory As PCW_Data.MultiPartCategory = _
			PCW.Data.CurrentMultiPartCategory
		Dim _local_numOfDiffs As Short = PCW.Data.NumOfDiffs
		If (_local_currMultiPartCategory = _
			PCW_Data.MultiPartCategory.multiPartDiff) AndAlso _
			(_local_numOfDiffs > 1) Then
			PCW.Data.NumOfDiffs = PCW.Data.NumOfDiffs - 1
			PCW.Data.CurrentPromoCategory = _
				PCW_Data.PromoCategory.payoutOnly
			Me.NextStep = "StepF"
			GUI_Util.msgBox("Now give info for next Payout.")
		Else
			Me.NextStep = "StepJ"
		End If
	End Sub
#End Region
#Region "StepI_cbCreatePromo_CheckedChanged"
	Private Sub cbCreatePromo_CheckedChanged(sender As Object, _
											 e As EventArgs) _
		Handles cbCreatePromo.CheckedChanged
		PCW.NextEnabled = Me.cbCreatePromo.Checked
		If Me.cbCreatePromo.Checked Then
			Me.cbCreatePromo.ForeColor = SystemColors.ControlDarkDark
			Me.cbCreatePromo.BackColor = Color.Lime
			Me.pnlCreatePromo.BackColor = Color.Lime
		Else
			Me.cbCreatePromo.ForeColor = Color.Black
			Me.cbCreatePromo.BackColor = Color.White
			Me.pnlCreatePromo.BackColor = Color.White
		End If
	End Sub
#End Region
End Class

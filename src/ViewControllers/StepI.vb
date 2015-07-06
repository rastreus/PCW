Imports TSWizards
Imports System.ComponentModel

Public Class StepI
	Inherits TSWizards.BaseInteriorStep

#Region "StepI_ShowStep"
	Private promoSummary As System.Text.StringBuilder

	Private Sub StepI_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		PCW.NextEnabled = False
		PCW.PrepareAllPromoData()
		Me.promoSummary = PCW.Data.GetPromoSummary()
		Me.lblpromoSummary.Text = Me.promoSummary.ToString
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
			PCW_Data.MultiPartCategory.multiPartDiff) And _
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
	End Sub
#End Region
End Class

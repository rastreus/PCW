Imports TSWizards

Public Class StepI
	Inherits TSWizards.BaseInteriorStep

#Region "StepI_ShowStep"
	Private promoSummary As System.Text.StringBuilder

	Private Sub StepI_ShowStep(sender As Object, e As ShowStepEventArgs) _
	Handles MyBase.ShowStep
		PCW.NextEnabled = False
		PCW.PrepareAllPromoData()
		Me.promoSummary = PCW.Data.GetPromoSummary()
		Me.lblpromoSummary.Text = Me.promoSummary.ToString
	End Sub
#End Region
#Region "StepI_Validation"
	Private warningString As String = "Check that you have read and confirmed the above parameters; " &
									  "otherwise, cancel and attempt the process again later."

	Private Sub StepI_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		If Not Me.cbCreatePromo.Checked Then
			e.Cancel = True
			GUI_Util.errPnl(Me.pnlCreatePromo)
			GUI_Util.msgBox(Me.warningString, "Are you sure?")
		Else
			GUI_Util.regPnl(Me.pnlCreatePromo)
		End If
	End Sub
#End Region
#Region "StepI_cbCreatePromo_CheckedChanged"
	Private Sub cbCreatePromo_CheckedChanged(sender As Object, e As EventArgs) _
	Handles cbCreatePromo.CheckedChanged
		PCW.NextEnabled = Me.cbCreatePromo.Checked
	End Sub
#End Region
End Class

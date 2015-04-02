Imports TSWizards

''' <summary>
''' Handles payout category and redirects to the next Step.
''' </summary>
''' <remarks></remarks>
Public Class StepF
	Inherits TSWizards.BaseInteriorStep

#Region "StepF_Data"
	''' <summary>
	''' Model for StepF.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepF_data As StepF_Data
	Public ReadOnly Property Data() As StepF_Data
		Get
			Return Me.stepF_data
		End Get
	End Property
#End Region
#Region "StepF_SetData"
	Private Sub StepF_SetData()
		Me.stepF_data.PayoutCatgory = getPromoPayoutCategory()
		Me.stepF_data.CashValue = getCashValue()
		Me.stepF_data.Prize = getPrize()
	End Sub

	Private Function getPrize() As String
		Dim result As String = Nothing
		If Me.Data.PayoutCatgory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.prize Then
			result = Me.txtPrize.Text
		End If
		Return result
	End Function

	Private Function getCashValue() As System.Nullable(Of Decimal)
		Dim result As System.Nullable(Of Decimal) = Nothing
		If Me.Data.PayoutCatgory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.cashValue Then
			result = Decimal.Parse(Me.txtCashValue.Text)
		End If
		Return result
	End Function

	''' <summary>
	''' Finds the Checked RadioButton to determine PromoPayoutCategory.
	''' </summary>
	''' <returns>PromoPayoutCategory.</returns>
	''' <remarks></remarks>
	Private Function getPromoPayoutCategory() As StepF_Data.PromoPayoutCategory
		Dim promoPayoutCategory As StepF_Data.PromoPayoutCategory = New StepF_Data.PromoPayoutCategory
		If Me.rbFreePlayCoupon.Checked Then
			promoPayoutCategory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.freePlayCoupon
		ElseIf Me.rbRandomPrize.Checked Then
			promoPayoutCategory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.randomPrize
		ElseIf Me.rbCashValue.Checked Then
			promoPayoutCategory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.cashValue
		Else
			promoPayoutCategory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.prize
		End If
		Return promoPayoutCategory
	End Function
#End Region
#Region "StepF_Load"
	Private Sub StepF_Load(sender As Object, e As EventArgs) _
	Handles MyBase.Load
		Me.stepF_data = New StepF_Data
	End Sub
#End Region
#Region "StepF_ResetStep"
	Private Sub StepF_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepF_data = New StepF_Data
		Me.NextStep = "StepGeneratePayoutCoupon"
		StepF_ResetControls()
	End Sub

	Private Sub StepF_ResetControls()
		Me.rbFreePlayCoupon.Checked = True
		deactivateTextBox(Me.txtCashValue, BEP_Util.NumStr)
		deactivateTextBox(Me.txtPrize, BEP_Util.PrizeStr)
		GUI_Util.regPnl(Me.pnlCashValue, Color.Gainsboro)
		GUI_Util.regPnl(Me.pnlPrize, Color.Gainsboro)
	End Sub
#End Region
#Region "StepF_Validation"
	Private Sub StepF_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
	Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing

		StepF_SetData()

		If Me.Data.PayoutCatgory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.cashValue Then
			If Me.Data.CashValueInvalid(Me.txtCashValue.Text) Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlCashValue)
				Me.ActiveControl = Me.txtCashValue
			Else
				GUI_Util.regPnl(Me.pnlCashValue, Color.Gainsboro)
			End If
		End If

		If Me.Data.PayoutCatgory = PromotionalCreationWizard.StepF_Data.PromoPayoutCategory.prize And
			Me.Data.PrizeIsBlank Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlPrize)
			Me.ActiveControl = Me.txtPrize
		Else
			GUI_Util.regPnl(Me.pnlPrize, Color.Gainsboro)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
		Else
			Me.NextStep = Me.Data.DetermineStepFlow()
			If Me.NextStep = "StepH" Then
				PCW.GetStep("StepH").PreviousStep = "StepF"
			End If
		End If
	End Sub
#End Region
#Region "StepF_rbCashValue_CheckedChanged"
	'Cash Value Changed
	Private Sub rbCashValue_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCashValue.CheckedChanged
		If Me.rbCashValue.Checked Then
			activateTextBox(Me.txtCashValue)
		Else
			deactivateTextBox(Me.txtCashValue, BEP_Util.NumStr)
		End If
	End Sub
#End Region
#Region "StepF_rbPrize_ChecedChanged"
	'Prize Changed
	Private Sub rbPrize_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbPrize.CheckedChanged
		If Me.rbPrize.Checked Then
			activateTextBox(Me.txtPrize)
		Else
			deactivateTextBox(Me.txtPrize, BEP_Util.PrizeStr)
		End If
	End Sub
#End Region
#Region "_TEXTBOX_"
#If False Then
ASIDE: An exercise in keeping code DRY.
#End If
#Region "activateTextBox"
	Private Sub activateTextBox(ByVal textBox As System.Windows.Forms.TextBox)
		textBox.Enabled = True
		textBox.Text = ""
		Me.ActiveControl = textBox
	End Sub
#End Region
#Region "deactivateTextBox"
	Private Sub deactivateTextBox(ByVal textBox As System.Windows.Forms.TextBox, ByVal text As String)
		textBox.Enabled = False
		textBox.Text = text
	End Sub
#End Region
#End Region
End Class

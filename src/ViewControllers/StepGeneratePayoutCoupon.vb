Imports TSWizards

Public Class StepGeneratePayoutCoupon
	Inherits TSWizards.BaseInteriorStep

#Region "StepGeneratePayoutCoupon_Data"
	''' <summary>
	''' Model for StepGeneratePayoutCoupon.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepGeneratePayoutCoupon_data As StepGeneratePayoutCoupon_Data
	Public ReadOnly Property Data() As StepGeneratePayoutCoupon_Data
		Get
			Return Me.stepGeneratePayoutCoupon_data
		End Get
	End Property
#End Region
#Region "StepGeneratePayoutCoupon_Load"
	Private Sub StepGeneratePayoutCoupon_Load(sender As Object, e As EventArgs) _
	Handles MyBase.Load
		Me.stepGeneratePayoutCoupon_data = New StepGeneratePayoutCoupon_Data
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_Validation"
	''' <summary>
	''' Asks StepGeneratePayoutCoupon_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepGeneratePayoutCoupon_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing

		If Me.Data.CouponAmtPerPatron_Invalid() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlMaxAmtOneCoupon)
			errString = "Max Coupon must be a decimal amount i.e. 500.00."
			Me.ActiveControl = Me.txtMaxAmtOneCoupon
		Else
			GUI_Util.regPnl(Me.pnlMaxAmtOneCoupon)
		End If

		If Me.Data.CouponAmtForEntirePromo_Invalid() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlMaxAmtAllCoupons)
			errString = "Promo Max Coupon must be a decimal amount i.e. 15000.00."
			Me.ActiveControl = Me.txtMaxAmtAllCoupons
		Else
			If Not Me.Data.BadCouponAmts() Then
				GUI_Util.regPnl(Me.pnlMaxAmtAllCoupons)
			End If
		End If

		'Make sure that the TextBoxes for MaxCoupon and PromoMaxCoupon are not empty strings
		If Not BEP_Util.invalidDecimal(Me.txtMaxAmtOneCoupon.Text) And
			Not BEP_Util.invalidDecimal(Me.txtMaxAmtAllCoupons.Text) Then
			If Me.Data.BadCouponAmts() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlMaxAmtAllCoupons)
				errString = "Promo Max Coupon amount is less than the Max Coupon amount."
				Me.ActiveControl = Me.txtMaxAmtAllCoupons
			Else
				If Not Me.Data.CouponAmtForEntirePromo_Invalid() Then
					GUI_Util.regPnl(Me.pnlMaxAmtAllCoupons)
				End If
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
		End If
	End Sub
#End Region
End Class

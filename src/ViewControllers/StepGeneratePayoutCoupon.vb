Imports TSWizards

''' <summary>
''' Handle promo coupon generation.
''' </summary>
''' <remarks>Does what the name would suggest.</remarks>
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
#Region "StepGeneratePayoutCoupon_SetData"
	''' <summary>
	''' Sets the data from StepGeneratePayoutCoupon_Data.
	''' </summary>
	''' <remarks>Complexity meets delegation.</remarks>
	Private Sub StepGeneratePayoutCoupon_SetData()
		Me.stepGeneratePayoutCoupon_data.CouponId = getCouponId()
		Me.stepGeneratePayoutCoupon_data.CouponAmtPerPatron = getCouponAmt(Me.txtMaxAmtOneCoupon.Text)
		Me.stepGeneratePayoutCoupon_data.CouponAmtForEntirePromo = getCouponAmt(Me.txtMaxAmtAllCoupons.Text)
		Me.stepGeneratePayoutCoupon_data.MaxNumOfCouponsPerPatron = getMaxNumOfCouponsPerPatron(Me.rbCouponsPerPatronYES.Checked, _
																								Me.txtCouponsPerPatron.Text)
	End Sub

	Private Function getCouponId() As String
		Dim result As String = Nothing
		Return result
	End Function

	Private Function getCouponAmt(ByVal txtInput As String) As System.Nullable(Of Decimal)
		Dim result As System.Nullable(Of Decimal) = Nothing
		If Not BEP_Util.invalidDecimal(txtInput) Then
			result = Decimal.Parse(txtInput)
		End If
		Return result
	End Function

	Private Function getMaxNumOfCouponsPerPatron(ByVal yesChecked As Boolean, ByVal txtInput As String) As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked And Not BEP_Util.invalidNum(txtInput) Then
			result = Short.Parse(txtInput)
		End If
		Return result
	End Function
#End Region
#Region "StepGeneratePayoutCoupon_Load"
	Private local_stepB As StepB
	Private local_promoName As String

	Private Sub StepGeneratePayoutCoupon_Load(sender As Object, e As EventArgs) _
	Handles MyBase.Load
		Me.local_stepB = PCW.GetStep("StepB")
		Me.local_promoName = local_stepB.Data.Name
		Me.stepGeneratePayoutCoupon_data = New StepGeneratePayoutCoupon_Data
		Me.txtMaxAmtOneCoupon_strCurrency = New String("")
		Me.txtMaxAmtOneCoupon_acceptableKey = False
		Me.txtMaxAmtAllCoupons_strCurrency = New String("")
		Me.txtMaxAmtAllCoupons_acceptableKey = False
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_ResetStep"
	Private Sub StepGeneratePayoutCoupon_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepGeneratePayoutCoupon_data = New StepGeneratePayoutCoupon_Data
		Me.txtMaxAmtOneCoupon_strCurrency = New String("")
		Me.txtMaxAmtOneCoupon_acceptableKey = False
		Me.txtMaxAmtAllCoupons_strCurrency = New String("")
		Me.txtMaxAmtAllCoupons_acceptableKey = False
		StepGeneratePayoutCoupon_ResetControls()
	End Sub

	Private Sub StepGeneratePayoutCoupon_ResetControls()
		Me.btnCouponID.Text = "EXAMPLE1503"
		Me.txtEditCouponID.Text = "EXAMPLE"
		Me.pnlEditCouponID.Enabled = False
		Me.pnlEditCouponID.Visible = False
		Me.rbCouponsPerPatronNO.Checked = True
		Me.txtCouponsPerPatron.Text = "Enter # Here"
		Me.txtMaxAmtOneCoupon.Text = "Enter Amt Here"
		Me.txtMaxAmtAllCoupons.Text = "Enter Amt Here"
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
#Region "_KEY_DOWN_PRESS_"
#Region "StepGeneratePayoutCoupon_txtMaxAmtOneCoupon_KeyDown_KeyPress"
	Private txtMaxAmtOneCoupon_strCurrency As String
	Private txtMaxAmtOneCoupon_acceptableKey As Boolean

	Private Sub txtMaxAmtOneCoupon_KeyDown(ByVal sender As Object, _
										   ByVal e As System.Windows.Forms.KeyEventArgs) _
		Handles txtMaxAmtOneCoupon.KeyDown
		Me.txtMaxAmtOneCoupon_acceptableKey = txt_KeyDown(e)
	End Sub

	Private Sub txtMaxAmtOneCoupon_KeyPress(ByVal sender As Object, _
											ByVal e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtMaxAmtOneCoupon.KeyPress
		e.Handled = txt_KeyPress(e, _
								 Me.txtMaxAmtOneCoupon_acceptableKey, _
								 Me.txtMaxAmtOneCoupon_strCurrency, _
								 Me.txtMaxAmtOneCoupon)
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_txtMaxAmtAllCoupons_KeyDown_KeyPress"
	Private txtMaxAmtAllCoupons_strCurrency As String
	Private txtMaxAmtAllCoupons_acceptableKey As Boolean

	Private Sub txtMaxAmtAllCoupons_KeyDown(ByVal sender As Object, _
											ByVal e As System.Windows.Forms.KeyEventArgs) _
		Handles txtMaxAmtAllCoupons.KeyDown
		Me.txtMaxAmtAllCoupons_acceptableKey = txt_KeyDown(e)
	End Sub

	Private Sub txtMaxAmtAllCoupons_KeyPress(ByVal sender As Object, _
											 ByVal e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtMaxAmtAllCoupons.KeyPress
		e.Handled = txt_KeyPress(e, _
								 Me.txtMaxAmtAllCoupons_acceptableKey, _
								 Me.txtMaxAmtAllCoupons_strCurrency, _
								 Me.txtMaxAmtAllCoupons)
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_txt_KeyDown"
	Private Function txt_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
		Return (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse
			(e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse
			e.KeyCode = Keys.Back
	End Function
#End Region
#Region "StepGeneratePayoutCoupon_txt_KeyPress"
	Private Function txt_KeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs, _
							  ByVal acceptableKeyBool As Boolean, _
							  ByVal strCurreny As String, _
							  ByRef txtBox As System.Windows.Forms.TextBox) As Boolean
		' Check for the flag being set in the KeyDown event.
		If acceptableKeyBool = False Then
			' Stop the character from being entered into the control since it is non-numerical.
			Return True	'Early Return! Ugly, but gets the job done.
		Else
			If e.KeyChar = Convert.ToChar(Keys.Back) Then
				If strCurreny.Length > 0 Then
					strCurreny = strCurreny.Substring(0, strCurreny.Length - 1)
				End If
			Else
				strCurreny = strCurreny & e.KeyChar
			End If

			Select Case strCurreny.Length
				Case 0
					txtBox.Text = ""
				Case 1
					txtBox.Text = "0.0" & strCurreny
				Case 2
					txtBox.Text = "0." & strCurreny
				Case Else
					txtBox.Text = strCurreny.Substring(0, strCurreny.Length - 2) &
						"." & strCurreny.Substring(strCurreny.Length - 2)
			End Select
			txtBox.Select(txtBox.Text.Length, 0)
		End If
		Return True
	End Function
#End Region
#End Region
End Class

Imports TSWizards
Imports System.ComponentModel
Imports System.Windows.Forms

''' <summary>
''' Handles promo coupon generation.
''' </summary>
''' <remarks>Does what the name would suggest.</remarks>
Public Class StepGeneratePayoutCoupon
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepGeneratePayoutCoupon_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepGeneratePayoutCoupon_data = New StepGeneratePayoutCoupon_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepGeneratePayoutCoupon_data
		End Get
	End Property
#End Region
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
		Me.stepGeneratePayoutCoupon_data.CouponID = _
			getCouponID()
		Me.stepGeneratePayoutCoupon_data.CouponAmtPerPatron = _
			getCouponAmt(Me.txtMaxAmtOneCoupon.Text)
		Me.stepGeneratePayoutCoupon_data.CouponAmtForEntirePromo = _
			getCouponAmt(Me.txtMaxAmtAllCoupons.Text)
		Me.stepGeneratePayoutCoupon_data.MaxNumOfCouponsPerPatron = _
			getMaxNumOfCouponsPerPatron(Me.rbCouponsPerPatronYES.Checked, _
										Me.txtCouponsPerPatron.Text)
	End Sub

	Private Function getCouponID() As String
		Return Me.btnCouponID.Text
	End Function

	Private Function getCouponAmt(ByVal txtInput As String) _
								  As System.Nullable(Of Decimal)
		Dim result As System.Nullable(Of Decimal) = Nothing
		If Not BEP_Util.invalidDecimal(txtInput) Then
			result = Decimal.Parse(txtInput)
		End If
		Return result
	End Function

	Private Function getMaxNumOfCouponsPerPatron(ByVal yesChecked As Boolean, _
												 ByVal txtInput As String) _
												 As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked And Not BEP_Util.invalidNum(txtInput) Then
			result = Short.Parse(txtInput)
		End If
		Return result
	End Function
#End Region
#Region "StepGeneratePayoutCoupon_Load"
	Private couponsPerPatronBool As Boolean = False
	Private maxAmtOneCouponBool As Boolean = False
	Private maxAmtAllCouponsBool As Boolean = False

	Private Sub StepGeneratePayoutCoupon_Load(sender As Object, _
											  e As EventArgs) _
	Handles MyBase.Load
		Me.txtMaxAmtOneCoupon_strCurrency = New String("")
		Me.txtMaxAmtOneCoupon_acceptableKey = False
		Me.txtMaxAmtAllCoupons_strCurrency = New String("")
		Me.txtMaxAmtAllCoupons_acceptableKey = False
		Me.editCouponID_IsClosed = True
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_ShowStep"
	Private local_stepB As StepB
	Private local_promoID As String

	''' <summary>
	''' Gets PromoID.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Grabs StepB and shakes it down for the PromoID.</remarks>
	Private Sub StepGeneratePayoutCoupon_ShowStep(sender As Object, _
												  e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
		Me.local_stepB = PCW.GetStep("StepB")
		Me.local_promoID = local_stepB.Data.ID
		Me.btnCouponID.Text = Me.local_promoID & "C"
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_ResetStep"
	Private Sub StepGeneratePayoutCoupon_ResetStep(sender As Object, _
												   e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepGeneratePayoutCoupon_data = New StepGeneratePayoutCoupon_Data
		Me.txtMaxAmtOneCoupon_strCurrency = New String("")
		Me.txtMaxAmtOneCoupon_acceptableKey = False
		Me.txtMaxAmtAllCoupons_strCurrency = New String("")
		Me.txtMaxAmtAllCoupons_acceptableKey = False
		Me.couponsPerPatronBool = False
		Me.maxAmtOneCouponBool = False
		Me.maxAmtAllCouponsBool = False
		StepGeneratePayoutCoupon_ResetControls()
	End Sub

	Private Sub StepGeneratePayoutCoupon_ResetControls()
		Me.btnCouponID.Text = "TEST!1503"
		Me.txtEditCouponID.Text = "TEST!"
		Me.pnlEditCouponID.Enabled = False
		Me.pnlEditCouponID.Visible = False
		Me.rbCouponsPerPatronNO.Checked = True
		Me.txtCouponsPerPatron.Text = BEP_Util.NumStr
		Me.txtMaxAmtOneCoupon.Text = BEP_Util.AmtStr
		Me.txtMaxAmtAllCoupons.Text = BEP_Util.AmtStr
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_Validation"
	''' <summary>
	''' Asks StepGeneratePayoutCoupon_Data to validate
	''' data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when
	''' user presses the "Next> Button."</remarks>
	Private Sub StepGeneratePayoutCoupon_Validation(sender As Object, _
													e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("!") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		StepGeneratePayoutCoupon_SetData()

		If Me.Data.CouponID_Invalid() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlCouponID)
			errString = "ERROR: CouponID is greater " & _
						"than 12 characters!"
			errStrArray.Add(errString)
			Me.ActiveControl = Me.pnlCouponID
		Else
			GUI_Util.regPnl(Me.pnlCouponID)
		End If

		If Me.Data.CouponAmtPerPatron_Invalid() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlMaxAmtOneCoupon)
			errString = "Max Coupon must be a decimal " & _
						"amount i.e. 500.00."
			errStrArray.Add(errString)
			Me.ActiveControl = Me.txtMaxAmtOneCoupon
		Else
			GUI_Util.regPnl(Me.pnlMaxAmtOneCoupon)
		End If

		If Me.Data.CouponAmtForEntirePromo_Invalid() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlMaxAmtAllCoupons)
			errString = "Promo Max Coupon must be a decimal " & _
						"amount i.e. 15000.00."
			errStrArray.Add(errString)
			Me.ActiveControl = Me.txtMaxAmtAllCoupons
		Else
			If Not Me.Data.BadCouponAmts() Then
				GUI_Util.regPnl(Me.pnlMaxAmtAllCoupons)
			End If
		End If

		'Make sure that the TextBoxes for
		'MaxCoupon and PromoMaxCoupon are not empty strings
		If Not BEP_Util.invalidDecimal(Me.txtMaxAmtOneCoupon.Text) And _
			Not BEP_Util.invalidDecimal(Me.txtMaxAmtAllCoupons.Text) Then
			If Me.Data.BadCouponAmts() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlMaxAmtAllCoupons)
				errString = "Promo Max Coupon amount is less " & _
							"than the Max Coupon amount."
				errStrArray.Add(errString)
				Me.ActiveControl = Me.txtMaxAmtAllCoupons
			Else
				If Not Me.Data.CouponAmtForEntirePromo_Invalid() Then
					GUI_Util.regPnl(Me.pnlMaxAmtAllCoupons)
				End If
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		Else
			'Step has been set if no error.
			Me.stepGeneratePayoutCoupon_data.StepNotSet = False
		End If
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_txt_Enter_Leave"
	Private Sub txtCouponsPerPatron_Enter(sender As Object, _
										  e As EventArgs) _
		Handles txtCouponsPerPatron.Enter
		If Me.rbCouponsPerPatronYES.Checked Then
			Me.couponsPerPatronBool = True
		End If
	End Sub
	Private Sub txtMaxAmtOneCoupon_Enter(sender As Object, _
										 e As EventArgs) _
		Handles txtMaxAmtOneCoupon.Enter
		If txtMaxAmtOneCoupon.Text = BEP_Util.AmtStr Then
			txtMaxAmtOneCoupon.Text = ""
		End If
		Me.maxAmtOneCouponBool = True
	End Sub
	Private Sub txtMaxAmtOneCoupon_Leave(sender As Object, _
										 e As EventArgs) _
		Handles txtMaxAmtOneCoupon.Leave
		CheckForNext()
	End Sub
	Private Sub txtMaxAmtAllCoupons_Enter(sender As Object, _
										  e As EventArgs) _
		Handles txtMaxAmtAllCoupons.Enter
		If txtMaxAmtAllCoupons.Text = BEP_Util.AmtStr Then
			txtMaxAmtAllCoupons.Text = ""
		End If
		Me.maxAmtAllCouponsBool = True
	End Sub
	Private Sub txtMaxAmtAllCoupons_Leave(sender As Object, _
										  e As EventArgs) _
		Handles txtMaxAmtAllCoupons.Leave
		CheckForNext()
	End Sub
	Private Sub CheckForNext()
		If Me.maxAmtOneCouponBool And _
			Me.maxAmtAllCouponsBool Then
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_rbCouponsPerPatronYES_CheckedChanged"
	Private Sub rbCouponsPerPatronYES_CheckedChanged(sender As Object, _
													 e As EventArgs) _
		Handles rbCouponsPerPatronYES.CheckedChanged
		If Me.rbCouponsPerPatronYES.Checked Then
			Me.txtCouponsPerPatron.Text = ""
			Me.txtCouponsPerPatron.Enabled = rbCouponsPerPatronYES.Checked
			Me.ActiveControl = Me.txtCouponsPerPatron
		Else
			Me.txtCouponsPerPatron.Enabled = False
			Me.txtCouponsPerPatron.Text = BEP_Util.NumStr
		End If
	End Sub
#End Region
#Region "StepGenaratePayoutCoupon_btnSet"
	''' <summary>
	''' "Submit" the contents of TextBox.
	''' </summary>
	''' <param name="enteredBool"></param>
	''' <remarks>For people that don't use the 'Tab' key.</remarks>
	Private Sub btnSet(ByVal enteredBool As Boolean)
		If enteredBool Then
			Me.ActiveControl = Me.pnlCouponsPerPatron
		End If
	End Sub

	Private Sub btnSetCouponsPerPatron_Click(sender As Object, _
											 e As EventArgs) _
		Handles btnSetCouponsPerPatron.Click
		btnSet(Me.couponsPerPatronBool)
	End Sub
	Private Sub btnSetMaxAmtOneCoupon_Click(sender As Object, _
											e As EventArgs) _
		Handles btnSetMaxAmtOneCoupon.Click
		btnSet(Me.maxAmtOneCouponBool)
	End Sub
	Private Sub btnSetMaxAmtAllCoupons_Click(sender As Object, _
											 e As EventArgs) _
		Handles btnSetMaxAmtAllCoupons.Click
		btnSet(Me.maxAmtAllCouponsBool)
	End Sub
#End Region
#Region "_KEY_DOWN_PRESS_"
#Region "StepGeneratePayoutCoupon_txtMaxAmtOneCoupon_KeyDown_KeyPress"
	Private txtMaxAmtOneCoupon_strCurrency As String
	Private txtMaxAmtOneCoupon_acceptableKey As Boolean

	Private Sub txtMaxAmtOneCoupon_KeyDown(ByVal sender As Object, _
										   ByVal e As KeyEventArgs) _
		Handles txtMaxAmtOneCoupon.KeyDown
		If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse _
			(e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse _
			e.KeyCode = Keys.Back Then
			Me.txtMaxAmtOneCoupon_acceptableKey = True
		Else
			Me.txtMaxAmtOneCoupon_acceptableKey = False
		End If
	End Sub

	Private Sub txtMaxAmtOneCoupon_KeyPress(ByVal sender As Object, _
											ByVal e As KeyPressEventArgs) _
		Handles txtMaxAmtOneCoupon.KeyPress
		' Check for the flag being set in the KeyDown event.
		If txtMaxAmtOneCoupon_acceptableKey = False Then
			' Stop the character from being entered
			'into the control since it is non-numerical.
			e.Handled = True
			Return
		Else
			If e.KeyChar = Convert.ToChar(Keys.Back) Then
				If txtMaxAmtOneCoupon_strCurrency.Length > 0 Then
					txtMaxAmtOneCoupon_strCurrency = _
						txtMaxAmtOneCoupon_strCurrency _
						.Substring(0, _
								   txtMaxAmtOneCoupon_strCurrency.Length - 1)
				End If
			Else
				txtMaxAmtOneCoupon_strCurrency = _
					txtMaxAmtOneCoupon_strCurrency & e.KeyChar
			End If

			If txtMaxAmtOneCoupon_strCurrency.Length = 0 Then
				Me.txtMaxAmtOneCoupon.Text = ""
			ElseIf txtMaxAmtOneCoupon_strCurrency.Length = 1 Then
				Me.txtMaxAmtOneCoupon.Text = "0.0" & _
					txtMaxAmtOneCoupon_strCurrency
			ElseIf txtMaxAmtOneCoupon_strCurrency.Length = 2 Then
				Me.txtMaxAmtOneCoupon.Text = "0." & _
					txtMaxAmtOneCoupon_strCurrency
			ElseIf txtMaxAmtOneCoupon_strCurrency.Length > 2 Then
				Me.txtMaxAmtOneCoupon.Text = _
					txtMaxAmtOneCoupon_strCurrency.Substring(0, _
						txtMaxAmtOneCoupon_strCurrency.Length - 2) & _
						"." & _
						txtMaxAmtOneCoupon_strCurrency _
						.Substring(txtMaxAmtOneCoupon_strCurrency.Length - 2)
			End If
			Me.txtMaxAmtOneCoupon.Select(Me.txtMaxAmtOneCoupon.Text.Length, 0)
		End If
		e.Handled = True
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_txtMaxAmtAllCoupons_KeyDown_KeyPress"
	Private txtMaxAmtAllCoupons_strCurrency As String
	Private txtMaxAmtAllCoupons_acceptableKey As Boolean

	Private Sub txtMaxAmtAllCoupons_KeyDown(ByVal sender As Object, _
											ByVal e As System.Windows.Forms.KeyEventArgs) _
		Handles txtMaxAmtAllCoupons.KeyDown
		If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse
			(e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse
			e.KeyCode = Keys.Back Then
			Me.txtMaxAmtAllCoupons_acceptableKey = True
		Else
			Me.txtMaxAmtAllCoupons_acceptableKey = False
		End If
	End Sub

	Private Sub txtMaxAmtAllCoupons_KeyPress(ByVal sender As Object, _
											 ByVal e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtMaxAmtAllCoupons.KeyPress
		' Check for the flag being set in the KeyDown event.
		If txtMaxAmtAllCoupons_acceptableKey = False Then
			' Stop the character from being entered into the control since it is non-numerical.
			e.Handled = True
			Return
		Else
			If e.KeyChar = Convert.ToChar(Keys.Back) Then
				If txtMaxAmtAllCoupons_strCurrency.Length > 0 Then
					txtMaxAmtAllCoupons_strCurrency = txtMaxAmtAllCoupons_strCurrency.Substring(0, txtMaxAmtAllCoupons_strCurrency.Length - 1)
				End If
			Else
				txtMaxAmtAllCoupons_strCurrency = txtMaxAmtAllCoupons_strCurrency & e.KeyChar
			End If

			If txtMaxAmtAllCoupons_strCurrency.Length = 0 Then
				Me.txtMaxAmtAllCoupons.Text = ""
			ElseIf txtMaxAmtAllCoupons_strCurrency.Length = 1 Then
				Me.txtMaxAmtAllCoupons.Text = "0.0" & txtMaxAmtAllCoupons_strCurrency
			ElseIf txtMaxAmtAllCoupons_strCurrency.Length = 2 Then
				Me.txtMaxAmtAllCoupons.Text = "0." & txtMaxAmtAllCoupons_strCurrency
			ElseIf txtMaxAmtAllCoupons_strCurrency.Length > 2 Then
				Me.txtMaxAmtAllCoupons.Text = txtMaxAmtAllCoupons_strCurrency.Substring(0, txtMaxAmtAllCoupons_strCurrency.Length - 2) & "." & txtMaxAmtAllCoupons_strCurrency.Substring(txtMaxAmtAllCoupons_strCurrency.Length - 2)
			End If
			Me.txtMaxAmtAllCoupons.Select(Me.txtMaxAmtAllCoupons.Text.Length, 0)

		End If
		e.Handled = True
	End Sub
#End Region
#End Region
#Region "_COUPON_ID_PANELS_"
#Region "StepGeneratePayoutCoupon_btnCouponID_Click"
	Private editCouponID_IsClosed As Boolean

	Private Sub btnCouponID_Click(sender As Object, e As EventArgs) _
	Handles btnCouponID.Click
		If Me.editCouponID_IsClosed Then
			Me.txtEditCouponID.Text = Me.local_promoID
			Me.editCouponID_IsClosed = False
			SetEditCouponID(True)
			PCW.NextEnabled = False
		End If
	End Sub

	Private Sub SetEditCouponID(ByVal bool As Boolean)
		Me.pnlEditCouponID.Visible = bool
		Me.pnlEditCouponID.Enabled = bool
	End Sub
#End Region
#Region "StepGeneratePayoutCoupon_btnTxtEditCouponID_Click"
	Private Sub btnTxtEditCouponID_Click(sender As Object, _
										 e As EventArgs) _
	Handles btnTxtEditCouponID.Click
		Me.btnCouponID.Text = SetBtnCouponIDText(Me.txtEditCouponID.Text)
		Me.editCouponID_IsClosed = True
		SetEditCouponID(False)
		GUI_Util.NextEnabled()
	End Sub

	Private Function SetBtnCouponIDText(ByRef txt As String) _
										As String
		Return txt & "C"
	End Function
#End Region
#End Region
End Class

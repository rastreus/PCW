Imports TSWizards
Imports System.Xml
Imports System.Xml.Linq
Imports System.Text.RegularExpressions

Public Class StepGeneratePayoutCoupon
	Inherits TSWizards.BaseInteriorStep

	Private Sub StepGeneratePayoutCoupon_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep

		'If CouponID_Invalid() Then
		'	e.Cancel = True
		'	Me.pnlEditCouponID.BackColor = Color.MistyRose
		'	Me.TextBox1.Text = ""
		'	Me.ActiveControl = Me.TextBox1
		'Else
		'	Me.pnlEditCouponID.BackColor = SystemColors.Control

		'	'If valid, make sure that the characters are uppercase.
		'	'The variables shouldn't be necessary, but VB.NET is weird about Strings.
		'	Dim couponID_Name As String = TextBox1.Text.Substring(0, TextBox1.Text.Length - 4)
		'	Dim couponID_Digits As String = TextBox1.Text.Substring(TextBox1.Text.Length - 4)
		'	Me.TextBox1.Text = couponID_Name.ToUpper & couponID_Digits
		'End If

		If MaxCoupon_Invalid() Then
			e.Cancel = True
			Me.pnlMaxAmtOneCoupon.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Max Coupon value is invalid. Must be a Decimal value i.e. 500.00", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtMaxAmtOneCoupon.Text = ""
			Me.ActiveControl = Me.txtMaxAmtOneCoupon
		Else
			Me.pnlMaxAmtOneCoupon.BackColor = SystemColors.Control
		End If

		If PromoMaxCoupon_Invalid() Then
			e.Cancel = True
			Me.pnlMaxAmtAllCoupons.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Promo Max Coupon value is invalid. Must be a Decimal value i.e. 15000.00", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtMaxAmtAllCoupons.Text = ""
			Me.ActiveControl = Me.txtMaxAmtAllCoupons
		Else
			If Not PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon() Then
				Me.pnlMaxAmtAllCoupons.BackColor = SystemColors.Control
			End If
		End If

		'Make sure that the TextBoxes for MaxCoupon and PromoMaxCoupon are not empty strings
		If Not BEP_Util.invalidDecimal(Me.txtMaxAmtOneCoupon.Text) And Not BEP_Util.invalidDecimal(Me.txtMaxAmtAllCoupons.Text) Then
			If PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon() Then
				e.Cancel = True
				Me.pnlMaxAmtAllCoupons.BackColor = Color.MistyRose
				CenteredMessagebox.MsgBox.Show("Promo Max Coupon value is less than or equal to the Max Coupon value.", "Error",
											   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtMaxAmtAllCoupons.Text = ""
				Me.ActiveControl = Me.txtMaxAmtAllCoupons
			Else
				If Not PromoMaxCoupon_Invalid() Then
					Me.pnlMaxAmtAllCoupons.BackColor = SystemColors.Control
				End If
			End If
		End If

	End Sub

	Private Function PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon()
		Dim invalid As Boolean = False

		If (Decimal.Parse(Me.txtMaxAmtAllCoupons.Text) <= Decimal.Parse(Me.txtMaxAmtOneCoupon.Text)) Then
			invalid = True
		End If

		Return invalid
	End Function

	Private Function PromoMaxCoupon_Invalid()
		Dim invalid As Boolean = False

		If BEP_Util.invalidDecimal(Me.txtMaxAmtAllCoupons.Text) Then
			invalid = True
		End If

		Return invalid
	End Function

	Private Function MaxCoupon_Invalid()
		Dim invalid As Boolean = False

		If BEP_Util.invalidDecimal(Me.txtMaxAmtOneCoupon.Text) Then
			invalid = True
		End If

		Return invalid
	End Function

	'Private Function CouponID_Invalid()
	'	Dim invalid As Boolean = False

	'	If Me.TextBox1.Text = "" Or
	'		Me.TextBox1.Text = "Enter ID Here" Or
	'		Invalid_CouponID(Me.TextBox1.Text) Or
	'		Me.TextBox1.Text.Length > 12 Then
	'		CenteredMessagebox.MsgBox.Show("The CouponID does not follow the standard format i.e. PROMO14XX", "Error",
	'									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	'		invalid = True
	'	ElseIf SQL_Util.Existing_Coupon(Me.TextBox1.Text) Then
	'		CenteredMessagebox.MsgBox.Show("There is an existing coupon with this ID.", "Error",
	'									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	'		invalid = True
	'	End If

	'	Return invalid
	'End Function

	'Private Sub TextBox1_Enter(sender As Object, e As EventArgs)
	'	If Me.TextBox1.Text = "Enter ID Here" Then
	'		Me.TextBox1.Text = ""
	'	End If
	'End Sub
End Class

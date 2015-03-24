Imports TSWizards

Public Class StepF
	Inherits TSWizards.BaseInteriorStep

	Private Sub StepF_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep

		If CashValue_Invalid() Then
			e.Cancel = True
			Me.pnlCashValue.BackColor = Color.MistyRose
			Me.ActiveControl = Me.txtCashValue
		Else
			Me.pnlCashValue.BackColor = SystemColors.Control
		End If

		If Prize_Blank() Then
			e.Cancel = True
			Me.pnlPrize.BackColor = Color.MistyRose
			Me.ActiveControl = Me.txtPrize
		Else
			Me.pnlPrize.BackColor = SystemColors.Control
		End If

		'KEEP AS LAST LINE OF VALIDATION
		'===============================
		Determine_NextStep()
		'===============================
	End Sub

	Private Sub Determine_NextStep()
		Select Case True
			'Case Me.RadioButton1.Checked
			'	PCW.GetStep("StepF").NextStep = "StepG1"
			Case Me.rbFreePlayCoupon.Checked
				PCW.GetStep("StepF").NextStep = "StepG2"
			Case Me.rbRandomPrize.Checked
				PCW.GetStep("StepF").NextStep = "StepG3"
			Case Me.rbCashValue.Checked
				PCW.GetStep("StepF").NextStep = "StepH"
			Case Me.rbPrize.Checked
				PCW.GetStep("StepF").NextStep = "StepH"
		End Select
	End Sub

	'Not entirely sure how to validate Prize other than just
	'making sure that something was entered into the TextBox.
	Private Function Prize_Blank()
		Dim blank As Boolean = False

		If Me.txtPrize.Text = "" Then
			blank = True
		End If

		Return blank
	End Function

	Private Function CashValue_Invalid()
		Dim invalid As Boolean = False

		If Me.rbCashValue.Checked Then
			invalid = BEP_Util.invalidNum(Me.txtCashValue.Text)
		End If

		Return invalid
	End Function

	'Cash Value Changed
	Private Sub rbCashValue_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCashValue.CheckedChanged
		If Me.rbCashValue.Checked Then
			Me.txtCashValue.Text = ""
			Me.txtCashValue.Enabled = True
			Me.ActiveControl = Me.txtCashValue
		Else
			Me.txtCashValue.Enabled = False
			Me.txtCashValue.Text = "Enter Cash Value Here"
		End If
	End Sub

	'Prize Changed
	Private Sub rbPrize_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbPrize.CheckedChanged
		If Me.rbPrize.Checked Then
			Me.txtPrize.Text = ""
			Me.txtPrize.Enabled = True
			Me.ActiveControl = Me.txtPrize
		Else
			Me.txtPrize.Enabled = False
			Me.txtPrize.Text = "Enter Prize Here"
		End If
	End Sub
End Class

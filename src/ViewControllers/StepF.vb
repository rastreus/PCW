Imports TSWizards
Imports System.Text.RegularExpressions

Public Class StepF
	Inherits TSWizards.BaseInteriorStep

	Private Sub StepF_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

		If CashValue_Invalid() Then
			e.Cancel = True
			Me.Panel3.BackColor = Color.MistyRose
			Me.ActiveControl = Me.TextBox3
		Else
			Me.Panel3.BackColor = SystemColors.Control
		End If

		If Prize_Blank() Then
			e.Cancel = True
			Me.Panel2.BackColor = Color.MistyRose
			Me.ActiveControl = Me.TextBox2
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If

		'KEEP AS LAST LINE OF VALIDATION
		'===============================
		Determine_NextStep()
		'===============================
	End Sub

	'If PromoDate_Recurring() Then
	'    e.Cancel = True
	'    PCW.GetStep("Step5").PreviousStep = "Step4"
	'    If Not PromoName_Invalid() And Not Recurring_Period_Invalid() Then
	'        PCW.MoveTo("Step4")
	'    End If
	'Else
	'    PCW.GetStep("Step5").PreviousStep = "Step3"
	'End If
	Private Sub Determine_NextStep()
		Select Case True
			Case Me.RadioButton1.Checked
				PCW.GetStep("StepF").NextStep = "StepG1"
			Case Me.RadioButton5.Checked
				PCW.GetStep("StepF").NextStep = "StepG2"
			Case Me.RadioButton4.Checked
				PCW.GetStep("StepF").NextStep = "StepG3"
			Case Me.RadioButton2.Checked
				PCW.GetStep("StepF").NextStep = "StepH"
			Case Me.RadioButton3.Checked
				PCW.GetStep("StepF").NextStep = "StepH"
		End Select
	End Sub

	'Not entirely sure how to validate Prize other than just
	'making sure that something was entered into the TextBox.
	Private Function Prize_Blank()
		Dim blank As Boolean = False

		If Me.TextBox2.Text = "" Then
			blank = True
		End If

		Return blank
	End Function

	Private Function CashValue_Invalid()
		Dim invalid As Boolean = False

		If Me.RadioButton2.Checked Then
			invalid = Invalid_Number(Me.TextBox3.Text)
		End If

		Return invalid
	End Function

	'Copied utilitarian function that should only be one place.
	'On a refactoring, place this in a single location.
	'Checks to see if the supplied value is not 0
	'or if it is not 1 or more digit
	Private Function Invalid_Number(ByVal inputString As String)
		Dim invalid As Boolean = False
		Dim inputInt As Short
		Dim RegexObj As Regex = New Regex("^\d+$")

		Try
			inputInt = Short.Parse(inputString)
			If (inputInt = 0) Or Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			invalid = True
		End Try

		Return invalid
	End Function

	'Cash Value Changed
	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		If Me.RadioButton2.Checked Then
			Me.TextBox3.Text = ""
			Me.TextBox3.Enabled = True
			Me.ActiveControl = Me.TextBox3
		Else
			Me.TextBox3.Enabled = False
			Me.TextBox3.Text = "Enter Cash Value Here"
		End If
	End Sub

	'Prize Changed
	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
		If Me.RadioButton3.Checked Then
			Me.TextBox2.Text = ""
			Me.TextBox2.Enabled = True
			Me.ActiveControl = Me.TextBox2
		Else
			Me.TextBox2.Enabled = False
			Me.TextBox2.Text = "Enter Prize Here"
		End If
	End Sub
End Class

Imports TSWizards
Imports System.Text.RegularExpressions

Public Class StepE
	Inherits TSWizards.BaseInteriorStep

	'Validate that all the needed information has been entered correctly.
	Private Sub StepE_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
		If PointCutoff_Invalid() Then
			e.Cancel = True
			Me.Panel6.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Point Cutoff Invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Me.Panel6.BackColor = SystemColors.Control
		End If

		If Points_Summation_Invalid() Then
			e.Cancel = True
			Me.Panel1.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Points Summation Invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Me.Panel1.BackColor = SystemColors.Control
		End If

		If Points_Relation_Invalid() Then
			e.Cancel = True
			Me.Panel2.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Points Summation Invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If
	End Sub

	'For readability
	Private Function PointCutoff()
		Return Me.RadioButton16.Checked
	End Function

	Private Function PointCutoff_Invalid()
		Dim invalid As Boolean = False

		If PointCutoff() Then
			invalid = Invalid_Number(Me.TextBox8.Text)
		End If

		Return invalid
	End Function

	'No ComboBox entry was selected.
	Private Function Points_Summation_Invalid()
		Dim invalid As Boolean = False

		If PointCutoff() And Me.ComboBox1.Text = "" Then
			invalid = True
		End If

		Return invalid
	End Function

	'No ComboBox entry was selected.
	Private Function Points_Relation_Invalid()
		Dim invalid As Boolean = False

		If PointCutoff() And Me.ComboBox2.Text = "" Then
			invalid = True
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

	'Enable/Disable is based on RadioButton16
	Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
		If Me.RadioButton16.Checked Then
			Me.TextBox8.Text = ""
			Me.TextBox8.Enabled = True
			Me.ActiveControl = Me.TextBox8
			Me.ComboBox1.Enabled = True
			Me.ComboBox2.Enabled = True
		Else
			Me.ComboBox1.Enabled = False
			Me.ComboBox2.Enabled = False
			Me.TextBox8.Enabled = False
			Me.TextBox8.Text = "Enter Point Cutoff limit here"
		End If
	End Sub
End Class

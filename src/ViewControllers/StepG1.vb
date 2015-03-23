Imports TSWizards
Imports System.Xml
Imports System.Xml.Linq
Imports System.Text.RegularExpressions

Public Class StepG1
	Inherits TSWizards.BaseInteriorStep

#Region "Step5_Validation"
	Private Sub StepG1_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

		If PointsDivisor_Invalid() Then
			e.Cancel = True
			Me.Panel3.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Points Divisor is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.TextBox5.Text = ""
			Me.ActiveControl = Me.TextBox5
		Else
			Me.Panel3.BackColor = SystemColors.Control
		End If

		If SetAmount_Invalid() Then
			e.Cancel = True
			Me.Panel2.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Set Amount of Tickets is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.TextBox4.Text = ""
			Me.ActiveControl = Me.TextBox4
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If

		If TicketsPerPatron_Invalid() Then
			e.Cancel = True
			Me.Panel4.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Limit # of Tickets per patron is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.TextBox6.Text = ""
			Me.ActiveControl = Me.TextBox6
		Else
			Me.Panel4.BackColor = SystemColors.Control
		End If

		If TicketsForEntirePromo_Invalid() Then
			e.Cancel = True
			Me.Panel5.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Limit # of Tickets for entire promo is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.TextBox7.Text = ""
			Me.ActiveControl = Me.TextBox7
		Else
			Me.Panel5.BackColor = SystemColors.Control
		End If

		If TicketsForEntirePromo_EqualTo_TicketsPerPatron() Then
			e.Cancel = AskIfIntended()
			If e.Cancel = True Then
				Me.Panel4.BackColor = Color.MistyRose
				Me.Panel5.BackColor = Color.MistyRose
				Me.TextBox7.Text = ""
				Me.TextBox6.Text = ""
				Me.ActiveControl = Me.TextBox6
			End If
		Else
			If Not TicketsPerPatron_Invalid() And
				Not TicketsForEntirePromo_Invalid() And
				Not TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
				Me.Panel4.BackColor = SystemColors.Control
				Me.Panel5.BackColor = SystemColors.Control
			End If
		End If

		If TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
			e.Cancel = True
			Me.Panel5.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Tickets for entire promo less than Tickets per patron.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.TextBox7.Text = ""
			Me.TextBox7.Text = ""
			Me.ActiveControl = Me.TextBox7
		Else
			If Not TicketsForEntirePromo_Invalid() And
				Not TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
				Me.Panel5.BackColor = SystemColors.Control
			End If
		End If

		'Obviously this is correct. /s
		If EligiblePlayers_Selected() Then
			e.Cancel = True
			Me.Panel5.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Sorry: Feature Not Yet Implemented.", "Oh, this is embarassing...",
										   MessageBoxButtons.OK, MessageBoxIcon.Question)
		End If
	End Sub

	Private Function EligiblePlayers_Selected()
		Dim hasnt_been_completed_yet As Boolean = False

		If Me.RadioButton10.Checked Then
			hasnt_been_completed_yet = True
		End If

		Return hasnt_been_completed_yet
	End Function

	Private Function TicketsForEntirePromo_LessThan_TicketsPerPatron()
		Dim lessThan As Boolean = False

		If Me.RadioButton12.Checked And Me.RadioButton14.Checked Then
			If (Short.Parse(Me.TextBox7.Text) < Short.Parse(Me.TextBox6.Text)) Then
				lessThan = True
			End If
		End If

		Return lessThan
	End Function

	Private Function TicketsForEntirePromo_EqualTo_TicketsPerPatron()
		Dim equivalent As Boolean = False

		If Me.RadioButton12.Checked And Me.RadioButton14.Checked Then
			If (Short.Parse(Me.TextBox6.Text) = Short.Parse(Me.TextBox7.Text)) Then
				equivalent = True
			End If
		End If

		Return equivalent
	End Function

	Private Function AskIfIntended()
		Dim samedayMsgString As String = "Do you want tickets for entire promo to be the same as tickets per person?"

		Dim result As Integer = CenteredMessagebox.MsgBox.Show(samedayMsgString, "Equal?",
															   MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If result = DialogResult.Yes Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Function TicketsForEntirePromo_Invalid()
		Dim invalid As Boolean = False

		If Me.RadioButton14.Checked Then
			invalid = Invalid_Number(Me.TextBox7.Text)
		End If

		Return invalid
	End Function

	Private Function TicketsPerPatron_Invalid()
		Dim invalid As Boolean = False

		If Me.RadioButton12.Checked Then
			invalid = Invalid_Number(Me.TextBox6.Text)
		End If

		Return invalid
	End Function

	Private Function SetAmount_Invalid()
		Dim invalid As Boolean = False

		If Me.RadioButton11.Checked Then
			invalid = Invalid_Number(Me.TextBox5.Text)
		End If

		Return invalid
	End Function

	Private Function PointsDivisor_Invalid()
		Dim invalid As Boolean = False

		If (Me.RadioButton6.Checked Or Me.RadioButton7.Checked) Then
			invalid = Invalid_Number(Me.TextBox5.Text)
		End If

		Return invalid
	End Function

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
#End Region

#Region "RadioButtons On/Off"
	'These are the two RadioButtons for the "Compound/Complex Points Divisor"
	Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
		If RadioButton7.Checked Then
			Me.Panel3.Enabled = True
			Me.ActiveControl = Me.TextBox5
			Me.TextBox5.Text = ""
		Else
			Me.Panel3.Enabled = False
			Me.TextBox5.Text = "Enter # Here"
		End If
	End Sub

	Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
		If RadioButton6.Checked Then
			Me.Panel3.Enabled = True
			Me.ActiveControl = Me.TextBox5
			Me.TextBox5.Text = ""
		Else
			Me.Panel3.Enabled = False
			Me.TextBox5.Text = "Enter # Here"
		End If
	End Sub

	'This is the RadioButton for the "Set Amount of Tickets"
	Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
		If RadioButton11.Checked Then
			Me.TextBox4.Enabled = True
			Me.ActiveControl = Me.TextBox4
			Me.TextBox4.Text = ""
		Else
			Me.TextBox4.Enabled = False
			Me.TextBox4.Text = "Enter # of Tickets"
		End If
	End Sub

	'This is the Yes/No pair of radiobuttons for "Limit # of tickets per patron?"
	Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
		If Not Me.RadioButton13.Checked Then
			Me.TextBox6.Enabled = True
			Me.TextBox6.Text = ""
			Me.ActiveControl = Me.TextBox6
		Else
			Me.TextBox6.Enabled = False
			Me.TextBox6.Text = "Enter # Here"
		End If
	End Sub

	'This is the Yes/No pair of radiobuttons for "Limit # of tickets for entire promo?"
	Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
		If Not Me.RadioButton15.Checked Then
			Me.TextBox7.Enabled = True
			Me.TextBox7.Text = ""
			Me.ActiveControl = Me.TextBox7
		Else
			Me.TextBox7.Enabled = False
			Me.TextBox7.Text = "Enter # Here"
		End If
	End Sub
#End Region

#Region "StepG1_Load"
	Dim toolTip1 As Lingering_ToolTip = New Lingering_ToolTip
	Dim toolTip2 As Lingering_ToolTip = New Lingering_ToolTip
	Dim toolTip3 As Lingering_ToolTip = New Lingering_ToolTip
	Dim toolTip4 As Lingering_ToolTip = New Lingering_ToolTip

	Private Sub StepG1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim countString As String = <a>Counts the number of days between the start date
and the end date in which the account earned points.
The counted number is the amount of rewarded tickets.</a>.Value

		Dim compoundString As String = <a>Sums up all points accured between
the start date and the end date,
divides the total by the points divisor.
This is the amount of rewarded tickets.</a>.Value

		Dim complexString As String = <a>Sums up all points accured between the start date
and the end date, divides the total by the points
divisor and then adds it to a count of the date field.
This is the amount of rewarded tickets.</a>.Value

		Dim eligiblePlayersString As String = <a>Selects the number of tickets
from the EligiblePlayers table.</a>

		'Count
		Me.toolTip1.SetToolTip(Me.RadioButton9, countString)
		'Compound
		Me.toolTip2.SetToolTip(Me.RadioButton7, compoundString)
		'Complex
		Me.toolTip3.SetToolTip(Me.RadioButton6, complexString)
		'EligiblePlayers Table Amount
		Me.toolTip4.SetToolTip(Me.RadioButton10, eligiblePlayersString)

	End Sub

	Protected Sub countButton_ShowTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseEnter
		Me.toolTip1.Just_Linger(sender, e)
	End Sub

	Protected Sub countButton_HideTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseLeave
		Me.toolTip1.Hide(Me.RadioButton9)
	End Sub
#End Region

#Region "Numeric_Textbox_Input"
	'This limits the textboxes to only allow numeric input.
	'For whatever reason, because it just may happen, a user is still able to paste non-numeric input into the textbox.
	'The textbox is validated when the user hits "Next>" to see if there is any invalid characters present.
	Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub TextBox6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub TextBox7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region

#Region "StepG1_InfoCircle"
	'This really needs to become a method in a subclass of TSWizards.BaseInteriorStep.
	'That way there it is not copied into every single Step.
	Private Sub IconButton1_Click(sender As Object, e As EventArgs)
		Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014

Brought to you by the fine folks of the OJC IT Department!</a>.Value

		CenteredMessagebox.MsgBox.Show(infoString, "Information",
									   MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub
#End Region
End Class

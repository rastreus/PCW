Imports TSWizards
Imports System.Text.RegularExpressions

Public Class StepEntryTicketAmt
	Inherits TSWizards.BaseInteriorStep

#Region "StepEntryTicketAmt_Validation"
	Private Sub StepEntryTicketAmt_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep

		If PointsDivisor_Invalid() Then
			e.Cancel = True
			Me.pnlPointsDivisor.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Points Divisor is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtPointsDivisor.Text = ""
			Me.ActiveControl = Me.txtPointsDivisor
		Else
			Me.pnlPointsDivisor.BackColor = SystemColors.Control
		End If

		If SetAmount_Invalid() Then
			e.Cancel = True
			Me.pnlTicketsAmount.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Set Amount of Tickets is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtSetAmt.Text = ""
			Me.ActiveControl = Me.txtSetAmt
		Else
			Me.pnlTicketsAmount.BackColor = SystemColors.Control
		End If

		If TicketsPerPatron_Invalid() Then
			e.Cancel = True
			Me.pnlTicketPerPatron.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Limit # of Tickets per patron is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtTicketsPerPatron.Text = ""
			Me.ActiveControl = Me.txtTicketsPerPatron
		Else
			Me.pnlTicketPerPatron.BackColor = SystemColors.Control
		End If

		If TicketsForEntirePromo_Invalid() Then
			e.Cancel = True
			Me.pnlTicketsEntirePromo.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("The Limit # of Tickets for entire promo is invalid.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtTicketsEntirePromo.Text = ""
			Me.ActiveControl = Me.txtTicketsEntirePromo
		Else
			Me.pnlTicketsEntirePromo.BackColor = SystemColors.Control
		End If

		If TicketsForEntirePromo_EqualTo_TicketsPerPatron() Then
			e.Cancel = AskIfIntended()
			If e.Cancel = True Then
				Me.pnlTicketPerPatron.BackColor = Color.MistyRose
				Me.pnlTicketsEntirePromo.BackColor = Color.MistyRose
				Me.txtTicketsEntirePromo.Text = ""
				Me.txtTicketsPerPatron.Text = ""
				Me.ActiveControl = Me.txtTicketsPerPatron
			End If
		Else
			If Not TicketsPerPatron_Invalid() And
				Not TicketsForEntirePromo_Invalid() And
				Not TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
				Me.pnlTicketPerPatron.BackColor = SystemColors.Control
				Me.pnlTicketsEntirePromo.BackColor = SystemColors.Control
			End If
		End If

		If TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
			e.Cancel = True
			Me.pnlTicketsEntirePromo.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Tickets for entire promo less than Tickets per patron.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.txtTicketsEntirePromo.Text = ""
			Me.txtTicketsEntirePromo.Text = ""
			Me.ActiveControl = Me.txtTicketsEntirePromo
		Else
			If Not TicketsForEntirePromo_Invalid() And
				Not TicketsForEntirePromo_LessThan_TicketsPerPatron() Then
				Me.pnlTicketsEntirePromo.BackColor = SystemColors.Control
			End If
		End If

		''Obviously this is correct. /s
		'If EligiblePlayers_Selected() Then
		'	e.Cancel = True
		'	Me.Panel5.BackColor = Color.MistyRose
		'	CenteredMessagebox.MsgBox.Show("Sorry: Feature Not Yet Implemented.", "Oh, this is embarassing...",
		'								   MessageBoxButtons.OK, MessageBoxIcon.Question)
		'End If
	End Sub

	'Private Function EligiblePlayers_Selected()
	'	Dim hasnt_been_completed_yet As Boolean = False

	'	If Me.RadioButton10.Checked Then
	'		hasnt_been_completed_yet = True
	'	End If

	'	Return hasnt_been_completed_yet
	'End Function

	Private Function TicketsForEntirePromo_LessThan_TicketsPerPatron()
		Dim lessThan As Boolean = False

		If Me.rbTicketPerPatronYES.Checked And Me.rbTicketsEntirePromoYES.Checked Then
			If (Short.Parse(Me.txtTicketsEntirePromo.Text) < Short.Parse(Me.txtTicketsPerPatron.Text)) Then
				lessThan = True
			End If
		End If

		Return lessThan
	End Function

	Private Function TicketsForEntirePromo_EqualTo_TicketsPerPatron()
		Dim equivalent As Boolean = False

		If Me.rbTicketPerPatronYES.Checked And Me.rbTicketsEntirePromoYES.Checked Then
			If (Short.Parse(Me.txtTicketsPerPatron.Text) = Short.Parse(Me.txtTicketsEntirePromo.Text)) Then
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

		If Me.rbTicketsEntirePromoYES.Checked Then
			invalid = Invalid_Number(Me.txtTicketsEntirePromo.Text)
		End If

		Return invalid
	End Function

	Private Function TicketsPerPatron_Invalid()
		Dim invalid As Boolean = False

		If Me.rbTicketPerPatronYES.Checked Then
			invalid = Invalid_Number(Me.txtTicketsPerPatron.Text)
		End If

		Return invalid
	End Function

	Private Function SetAmount_Invalid()
		Dim invalid As Boolean = False

		If Me.rbSetAmt.Checked Then
			invalid = Invalid_Number(Me.txtPointsDivisor.Text)
		End If

		Return invalid
	End Function

	Private Function PointsDivisor_Invalid()
		Dim invalid As Boolean = False

		If (Me.rbCalPlusNumOfVisits.Checked Or Me.rbCalculated.Checked) Then
			invalid = Invalid_Number(Me.txtPointsDivisor.Text)
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
#Region "StepEntryTicketAmt_PointsDivisor"
	'These are the two RadioButtons for the Points Divisor
	Private Sub rbCalculated_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCalculated.CheckedChanged
		SetPointsDivisorPnl(rbCalculated.Checked)
		SetPointsDivisorTxt(rbCalculated.Checked)
	End Sub

	Private Sub rbCalPlusNumOfVisits_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCalPlusNumOfVisits.CheckedChanged
		SetPointsDivisorPnl(rbCalPlusNumOfVisits.Checked)
		SetPointsDivisorTxt(rbCalPlusNumOfVisits.Checked)
	End Sub

	Private Sub SetPointsDivisorPnl(ByVal bool As Boolean)
		Me.pnlPointsDivisor.Enabled = bool
		Me.pnlPointsDivisor.Visible = bool
	End Sub

	Private Sub SetPointsDivisorTxt(ByVal bool As Boolean)
		If bool Then
			Me.txtPointsDivisor.Text = ""
			Me.ActiveControl = Me.txtPointsDivisor
		Else
			Me.txtPointsDivisor.Text = "Enter # Here"
		End If
	End Sub
#End Region
#Region "RadioButtons On/Off"
	'This is the RadioButton for the "Set Amount of Tickets"
	Private Sub rbSetAmt_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbSetAmt.CheckedChanged
		If rbSetAmt.Checked Then
			Me.txtSetAmt.Enabled = True
			Me.ActiveControl = Me.txtSetAmt
			Me.txtSetAmt.Text = ""
		Else
			Me.txtSetAmt.Enabled = False
			Me.txtSetAmt.Text = "Enter # of Tickets"
		End If
	End Sub

	'This is the Yes/No pair of radiobuttons for "Limit # of tickets per patron?"
	Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbTicketsPerPatronNO.CheckedChanged
		If Not Me.rbTicketsPerPatronNO.Checked Then
			Me.txtTicketsPerPatron.Enabled = True
			Me.txtTicketsPerPatron.Text = ""
			Me.ActiveControl = Me.txtTicketsPerPatron
		Else
			Me.txtTicketsPerPatron.Enabled = False
			Me.txtTicketsPerPatron.Text = "Enter # Here"
		End If
	End Sub

	'This is the Yes/No pair of radiobuttons for "Limit # of tickets for entire promo?"
	Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbTicketsEntirePromoNO.CheckedChanged
		If Not Me.rbTicketsEntirePromoNO.Checked Then
			Me.txtTicketsEntirePromo.Enabled = True
			Me.txtTicketsEntirePromo.Text = ""
			Me.ActiveControl = Me.txtTicketsEntirePromo
		Else
			Me.txtTicketsEntirePromo.Enabled = False
			Me.txtTicketsEntirePromo.Text = "Enter # Here"
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_Load"
	Dim defaultStr As String
	Dim oneStr As String
	Dim numOfVisitsStr As String
	Dim calStr As String
	Dim calPlusNumOfVisitsStr As String
	Dim setAmtStr As String

	Private Sub StepEntryTicketAmt_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		defaultStr = New String("Move mouse pointer over amount for description.")
		oneStr = New String("One: a single entry ticket.")
		numOfVisitsStr = New String("Counts the number of visits within the qualifying period " &
									"in which the account earned points. The counted number " &
									"is the amount of entry tickets.")
		calStr = New String("Sums points accured within the qualifying period, " &
							"divides the total by the points divisor.")
		calPlusNumOfVisitsStr = New String("Sums points accured within the qualifying period, " &
										   "divides the total by the points divisor, " &
										   "then adds the result to a count of visits.")
		setAmtStr = New String("A static, set amount of tickets; " &
							   "enter the amount into the box below.")
	End Sub
#End Region

#Region "_MOUSE_ENTER_LEAVE_"
#Region "StepEntryTicketAmt_rb1_Mouse"
	Private Sub rb1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rb1.MouseEnter
		Me.lblDescription.Text = Me.oneStr
	End Sub
	Private Sub rb1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rb1.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbNumOfVisits_Mouse"
	Private Sub rbNumOfVisits_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.numOfVisitsStr
	End Sub
	Private Sub rbNumOfVisits_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalculated_Mouse"
	Private Sub rbCalculated_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalculated.MouseEnter
		Me.lblDescription.Text = Me.calStr
	End Sub
	Private Sub rbCalculated_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalculated.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalPlusNumOfVisits_Mouse"
	Private Sub rbCalPlusNumOfVisits_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.calPlusNumOfVisitsStr
	End Sub
	Private Sub rbCalPlusNumOfVisits_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbSetAmt_Mouse"
	Private Sub rbSetAmt_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbSetAmt.MouseEnter
		Me.lblDescription.Text = Me.setAmtStr
	End Sub
	Private Sub rbSetAmt_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbSetAmt.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#End Region

#Region "Numeric_Textbox_Input"
	'This limits the textboxes to only allow numeric input.
	'A user is still able to paste non-numeric input into the textbox.
	'The textbox is validated when the user hits "Next>" to see if there is any invalid characters present.
	Private Sub txtSetAmt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtSetAmt.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub txtPointsDivisor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtPointsDivisor.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub txtTicketsPerPatron_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtTicketsPerPatron.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub

	Private Sub txtTicketsEntirePromo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
		Handles txtTicketsEntirePromo.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
End Class

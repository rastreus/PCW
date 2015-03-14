Imports TSWizards

''' <summary>
''' Third Step; handles all the date information
''' </summary>
''' <remarks></remarks>
Public Class StepC
	Inherits TSWizards.BaseInteriorStep

#Region "StepC_Load"
	Private startDayInt As Integer
	Private endDayInt As Integer
	Private longDateFormat As String

	Private Sub StepC_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		startDayInt = -7
		endDayInt = -1
		longDateFormat = New String("dddd, MMMM dd, yyyy")
	End Sub
#End Region
#Region "StepC_ShowStep"
	''' <summary>
	''' Shows the Step controls.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>This Step can look slightly different depending on Occuring/Recurring</remarks>
	Private Sub StepC_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Recurring_Promo() Then
			Me.pnlRecurringQualifyingPeriod.Enabled = True
			Me.pnlRecurringQualifyingPeriod.Visible = True
			Me.lblRedemptionDays.Text = "On which day(s) is secondary redemption allowed?"
			Me.pnlOccursDate.Enabled = False
			Me.pnlOccursDate.Visible = False
			Me.pnlOccuringQualifyingPeriod.Enabled = False
			Me.pnlOccuringQualifyingPeriod.Visible = False
		Else 'Occuring Promo
			Me.pnlOccursDate.Enabled = True
			Me.pnlOccursDate.Visible = True
			Me.pnlOccuringQualifyingPeriod.Enabled = True
			Me.pnlOccuringQualifyingPeriod.Visible = True
			Me.lblRedemptionDays.Text = "On which day(s) is redemption allowed?"
			Me.pnlRecurringQualifyingPeriod.Enabled = False
			Me.pnlRecurringQualifyingPeriod.Visible = False
		End If

		SelectAll()

	End Sub

	''' <summary>
	''' Asks StepB's data if this is a Recurring promo.
	''' </summary>
	''' <returns></returns>
	''' <remarks>At least it isn't asking the control directly.</remarks>
	Private Function Recurring_Promo() As Boolean
		Dim stepB As StepB = PCW.GetStep("StepB")
		Return stepB.Data.Recurring
	End Function
#End Region
#Region "StepC_ResetStep"
	''' <summary>
	''' Resets the controls (View) for the Step to be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A lot of controls to get correct.</remarks>
	Private Sub StepC_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.dtpOccursDate.Value = Date.Today
		Me.dtpQualifyingStart.Value = Date.Today
		Me.dtpQualifyingEnd.Value = Date.Today
		Me.lblPromoIs.Text = "Promo is: "
		Me.cbSameDayPromo.Checked = False
		Me.MonthCal.SelectionStart = Date.Today
		Me.MonthCal.SelectionEnd = Date.Today
		Me.MonthCal.TodayDate = Date.Today
		Me.lblQualifyingStart.Text = "Start Date"
		Me.lblQualifyingEnd.Text = "End Date"
	End Sub
#End Region
#Region "StepC_SelectAll"
	''' <summary>
	''' Checks all the Items in clbPointsEarningDays.
	''' </summary>
	''' <remarks></remarks>
	Private Sub SelectAll()
		For item As Integer = 0 To Me.clbPointsEarningDays.Items.Count - 1
			Me.clbPointsEarningDays.SetItemChecked(item, Me.cbSelectAll.Checked)
		Next
	End Sub

	Private Sub cbSelectAll_CheckedChanged(sender As Object, e As EventArgs) _
		Handles cbSelectAll.CheckedChanged
		SelectAll()
	End Sub
#End Region
#Region "StepC_getPrimaryOccuringDayOfWeek"
	Private Function getPrimaryOccuringDayOfWeek() As System.Windows.Forms.CheckBox
		Dim cbDayOfWeek As System.Windows.Forms.CheckBox = New System.Windows.Forms.CheckBox
		Select Case Me.dtpOccursDate.Value.Date.DayOfWeek.ToString()
			Case "Sunday"
				cbDayOfWeek = Me.cbSunday
			Case "Monday"
				cbDayOfWeek = Me.cbMonday
			Case "Tuesday"
				cbDayOfWeek = Me.cbTuesday
			Case "Wednesday"
				cbDayOfWeek = Me.cbWednesday
			Case "Thursday"
				cbDayOfWeek = Me.cbThursday
			Case "Friday"
				cbDayOfWeek = Me.cbFriday
			Case "Saturday"
				cbDayOfWeek = Me.cbSaturday
		End Select
		Return cbDayOfWeek
	End Function
#End Region
#Region "StepC_lockPrimaryOccuringDayOfWeek"
	Private Sub lockPrimaryOccuringDayOfWeek(ByRef cbDayOfWeek As System.Windows.Forms.CheckBox)
		cbDayOfWeek.Checked = True
		cbDayOfWeek.Enabled = False
		cbDayOfWeek.BackColor = Color.Lime
		cbDayOfWeek.Text = cbDayOfWeek.Text & "*"
	End Sub
#End Region
#Region "StepC_dtpOccursDate_CloseUp"
	Private Sub dtpOccursDate_CloseUp(sender As Object, e As EventArgs) _
	Handles dtpOccursDate.CloseUp
		setStartEndQualifyingLabels(Me.dtpOccursDate.Value.Date.AddDays(Me.startDayInt).ToString(Me.longDateFormat), _
									Me.dtpOccursDate.Value.Date.AddDays(Me.endDayInt).ToString(Me.longDateFormat))
		lockPrimaryOccuringDayOfWeek(getPrimaryOccuringDayOfWeek)
		If Me.MonthCal.Visible = False Then
			Me.MonthCal.Visible = True
		End If
	End Sub
#End Region
#Region "StepC_setStartEndQualifyingLabels"
	Private Sub setStartEndQualifyingLabels(ByVal local_startDay As String, ByVal local_endDay As String)
		Me.lblQualifyingStart.Text = local_startDay
		Me.lblQualifyingEnd.Text = local_endDay
		Me.MonthCal.SetSelectionRange(Me.lblQualifyingStart.Text, Me.lblQualifyingEnd.Text)
	End Sub
#End Region
#Region "StepC_cbSameDayPromo_CheckedChanged"
	Private Sub cbSameDayPromo_CheckedChanged(sender As Object, e As EventArgs) _
		Handles cbSameDayPromo.CheckedChanged
		If Not (Me.lblQualifyingStart.Text = "Start Date") And Not (Me.lblQualifyingEnd.Text = "End Date") Then
			If Me.cbSameDayPromo.Checked Then
				Me.startDayInt = -6
				Me.endDayInt = 0
			Else
				Me.startDayInt = -7
				Me.endDayInt = -1
			End If
			setStartEndQualifyingLabels(Me.dtpOccursDate.Value.Date.AddDays(Me.startDayInt).ToString(Me.longDateFormat), _
										Me.dtpOccursDate.Value.Date.AddDays(Me.endDayInt).ToString(Me.longDateFormat))
		End If
	End Sub
#End Region

	Private Sub StepC_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		'Checks if the user pressed Next> before setting any values
		If Nothing_Was_Set() Then
			e.Cancel = True
			Me.pnlRedemptionDays.BackColor = Color.MistyRose
			Me.Panel2.BackColor = Color.MistyRose
			Me.Panel3.BackColor = Color.MistyRose
			Me.Panel4.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Please set the date values", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Me.pnlRedemptionDays.BackColor = SystemColors.Control
			Me.Panel2.BackColor = SystemColors.Control
			Me.Panel3.BackColor = SystemColors.Control
			Me.Panel4.BackColor = SystemColors.Control
		End If

		'Only the Occuring on Days values forgot to be set
		If Recurring_Promo() Then
			If (Not Nothing_Was_Set() And Empty_Occuring_Days()) Then
				e.Cancel = True
				CenteredMessagebox.MsgBox.Show("Please set the occuring day values.", "Error",
											   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.pnlRedemptionDays.BackColor = Color.MistyRose
			Else
				Me.pnlRedemptionDays.BackColor = SystemColors.Control
			End If
		End If

		''Checks to see if the primary day is invalid
		'If Recurring_Promo() Then
		'	If Primary_Day_Invalid() Then
		'		e.Cancel = True
		'		Me.Panel1.BackColor = Color.MistyRose
		'		CenteredMessagebox.MsgBox.Show("Primary Day is invalid.", "Error",
		'									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		'	Else
		'		Me.Panel1.BackColor = SystemColors.Control
		'	End If
		'End If

		'Only the Points Earned On valuse forgot to be set
		If Not Nothing_Was_Set() And Empty_Points_Earned() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the points earned on values.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel2.BackColor = Color.MistyRose
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If

		If Not Nothing_Was_Set() And Promo_Start_Not_Set() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the promo start date.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel3.BackColor = Color.MistyRose
		Else
			Me.Panel3.BackColor = SystemColors.Control
		End If

		If Not Nothing_Was_Set() And Promo_End_Not_Set() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the promo end date.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel4.BackColor = Color.MistyRose
		Else
			Me.Panel4.BackColor = SystemColors.Control
		End If

		'Checks if LastDay is before FirstDay
		If EndDate_Before_BeginDate() Then
			e.Cancel = True
			Me.Panel3.BackColor = Color.MistyRose
			Me.dtpQualifyingStart.Value = DateTime.Today
			Me.Panel4.BackColor = Color.MistyRose
			Me.dtpQualifyingEnd.Value = DateTime.Today
		Else
			If Not Promo_Start_Not_Set() And Not Promo_End_Not_Set() Then
				Me.Panel3.BackColor = SystemColors.Control
				Me.Panel4.BackColor = SystemColors.Control
			End If
		End If

		If OccursDate_Before_EndDate() Then
			e.Cancel = True
			Me.Panel7.BackColor = Color.MistyRose
			Me.DateTimePicker3.Value = DateTime.Today
			Me.Panel4.BackColor = Color.MistyRose
			Me.dtpQualifyingEnd.Value = DateTime.Today
		Else
			If Not Promo_Start_Not_Set() And Not Promo_End_Not_Set() Then
				Me.Panel7.BackColor = SystemColors.Control
				Me.Panel4.BackColor = SystemColors.Control
			End If
		End If

		'Commented out when changing StepC
		''Checks to see if attempting to earn points on the day of the promo when NO is selected
		''If this occurs, we're going to show a dialog to ask directly what the user intended to do
		''and then we will act accordingly from their direct response.
		'If No_Selected_For_SameDay_Points() And SameDays_Are_Selected() Then
		'	e.Cancel = AskForSameDay()
		'	If e.Cancel = True Then
		'		Me.Panel1.BackColor = Color.MistyRose
		'		Me.Panel2.BackColor = Color.MistyRose
		'		Clear_Checklistboxes()
		'	Else
		'		Me.RadioButton2.Checked = False
		'		Me.RadioButton1.Checked = True
		'		If Not Empty_Occuring_Days() And Not Empty_Points_Earned() Then
		'			Me.Panel1.BackColor = SystemColors.Control
		'			Me.Panel2.BackColor = SystemColors.Control
		'		End If
		'	End If
		'End If
	End Sub

	Private Function Nothing_Was_Set()
		Dim invalid As Boolean = False

		If Promo_Start_Not_Set() And Promo_End_Not_Set() And Empty_Occuring_Days() And Empty_Points_Earned() Then
			invalid = True
		End If

		Return invalid
	End Function

	Private Function Promo_Start_Not_Set()
		Dim invalid As Boolean = False
		If Me.dtpQualifyingStart.Value.Date = DateTime.Today Then
			invalid = True
		End If
		Return invalid
	End Function

	Private Function Promo_End_Not_Set()
		Dim invalid As Boolean = False
		If Me.dtpQualifyingEnd.Value.Date = DateTime.Today Then
			invalid = True
		End If
		Return invalid
	End Function

	Private Function Promo_Occuring_Not_Set()
		Dim invalid As Boolean = False
		If Not Recurring_Promo() And (Me.DateTimePicker3.Value.Date = DateTime.Today) Then
			invalid = True
		End If
		Return invalid
	End Function

	'Private Function Primary_Day_Invalid()
	'	Dim invalid As Boolean = True
	'	Dim count As Short = 0

	'	For Each itemChecked As Object In CheckedListBox1.CheckedItems
	'		If itemChecked.ToString = Me.ComboBox1.Text Then
	'			count += 1
	'		End If
	'	Next

	'	If count = 1 Then
	'		invalid = False
	'	End If

	'	Return invalid
	'End Function

	'Checks the previous Step to see if this is a recurring promo.

	Private Function Empty_Points_Earned()
		Dim empty As Boolean = False
		If (Me.clbPointsEarningDays.CheckedIndices.Count = 0) Then
			empty = True
		End If
		Return empty
	End Function

	Private Function Empty_Occuring_Days()
		Dim empty As Boolean = False
		If (Me.CheckedListBox1.CheckedIndices.Count = 0) Then
			empty = True
		End If
		Return empty
	End Function

	'Commented out when changing StepC
	'Private Function No_Selected_For_SameDay_Points()
	'	Return RadioButton2.Checked
	'End Function

	Private Function EndDate_Before_BeginDate()
		Dim invalid As Boolean = False

		Dim beginDate As DateTime = Me.dtpQualifyingStart.Value.Date
		Dim endDate As DateTime = Me.dtpQualifyingEnd.Value.Date
		Dim result As Int16 = DateTime.Compare(beginDate, endDate)
		If (result > 0) Then
			invalid = True
			CenteredMessagebox.MsgBox.Show("The end date of the promo is before the begin date", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If

		Return invalid
	End Function

	Private Function OccursDate_Before_EndDate()
		Dim invalid As Boolean = False

		Dim occursDate As DateTime = Me.DateTimePicker3.Value.Date
		Dim endDate As DateTime = Me.dtpQualifyingEnd.Value.Date
		Dim result As Int16 = DateTime.Compare(endDate, occursDate)
		If (result > 0) Then
			invalid = True
			CenteredMessagebox.MsgBox.Show("The occurs date of the promo is before the end date", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If

		Return invalid
	End Function
End Class

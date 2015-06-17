Imports TSWizards
Imports System.ComponentModel

''' <summary>
''' Third Step; handles all the date information
''' </summary>
''' <remarks></remarks>
Public Class StepC
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepC_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		stepC_data = New StepC_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepC_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepC_data
		End Get
	End Property
#End Region
#Region "StepC_Data"
	''' <summary>
	''' Model for StepC.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepC_data As StepC_Data
	Public ReadOnly Property Data() As StepC_Data
		Get
			Return Me.stepC_data
		End Get
	End Property
#End Region
#Region "StepC_SetData"
	''' <summary>
	''' Sets the data's properties from the controls.
	''' </summary>
	''' <remarks>Values are set differently depending if the promo is recurring or not.</remarks>
	Private Sub StepC_SetData()
		If Recurring_Promo() Then
			Me.stepC_data.OccursDate = Nothing
			Me.stepC_data.StartDate = Me.dtpQualifyingStart.Value.Date
			Me.stepC_data.EndDate = Me.dtpQualifyingEnd.Value.Date
			Me.stepC_data.RecursOnWeekday = getRecursOnWeekday()
			Me.stepC_data.CountCurrentDay = False
			If PCW.Data.DaysBool Then
				PCW.Data.NumOfDays = SetNumOfDays(Me.Data.StartDate, Me.Data.EndDate)
			End If
		Else 'Occurring Promo
			Me.stepC_data.OccursDate = Me.dtpOccursDate.Value.Date
			Me.stepC_data.StartDate = Me.dtpOccursDate.Value.Date.AddDays(Me.startDayInt)
			Me.stepC_data.EndDate = Me.dtpOccursDate.Value.Date.AddDays(Me.endDayInt)
			Me.stepC_data.RecursOnWeekday = Nothing
			Me.stepC_data.CountCurrentDay = Me.cbSameDayPromo.Checked
		End If
		'If All 7 Days are Checked, then record it as a NULL
		'No idea why, Ben just said that that's how it should be.
		If Me.clbPointsEarningDays.CheckedItems.Count = 7 Then
			Me.stepC_data.EarnsOnWeekday = Nothing
		Else
			Me.stepC_data.EarnsOnWeekday = getEarnsOnWeekday()
		End If
	End Sub

	Private Function SetNumOfDays(ByVal startDate As Date, _
								  ByVal endDate As Date) As System.Nullable(Of Short)
		Dim ts As TimeSpan = endDate.Subtract(startDate)
		Dim result As System.Nullable(Of Short) = Nothing
		If Convert.ToInt16(ts.Days) >= 0 Then
			result = Convert.ToInt16(ts.Days) + 1
		Else
			result = Nothing
		End If
		Return result
	End Function

	''' <summary>
	''' Concatenates the Primary and Secondary Days.
	''' </summary>
	''' <returns>The formatted days String for "RecursOnWeekday."</returns>
	''' <remarks>Trim removes the whitespace that may happen if there are no secondary days.</remarks>
	Private Function getRecursOnWeekday() As String
		Dim value As String = getPrimaryDay() & getSecondaryDays()
		Return value.Trim
	End Function

	''' <summary>
	''' Gets the Primary Day for "getRecursOnWeekday."
	''' </summary>
	''' <returns>A single-character String representation of the Primary Day.</returns>
	''' <remarks></remarks>
	Private Function getPrimaryDay() As String
		Return BEP_Util.daysFormat(Me.primaryDayStr)
	End Function

	''' <summary>
	''' Gets the Secondary Days for "getRecursOnWeekday" if they exist.
	''' </summary>
	''' <returns>A String of letters representing days.</returns>
	''' <remarks>Be sure to confirm that it is not the primary day.</remarks>
	Private Function getSecondaryDays() As String
		Dim days As String = New String("")
		For Each ctrl As System.Windows.Forms.CheckBox In Me.pnlCbRedemptionDays.Controls
			If (Not ctrl.Text = Me.primaryDayStr) And ctrl.Checked Then
				days = days & BEP_Util.daysFormat(ctrl.Text)
			End If
		Next
		Return days
	End Function

	''' <summary>
	''' Checks to see which items are checked in the CheckedListBox.
	''' </summary>
	''' <returns>A String of letters representing days.</returns>
	''' <remarks>If none are checked, return Nothing.</remarks>
	Private Function getEarnsOnWeekday() As String
		Dim days As String = New String("")
		For Each item In Me.clbPointsEarningDays.CheckedItems
			days = days & BEP_Util.daysFormat(item.ToString)
		Next
		If days = "" Then
			days = Nothing
		End If
		Return days
	End Function
#End Region
#Region "StepC_Load"
	Private primaryDayStr As String
	Private primaryDayBool As Boolean
	Private recurringFlagBool As System.Nullable(Of Boolean)
	Private occursDateBool As Boolean
	Private startDayBool As Boolean
	Private endDayBool As Boolean
	Private startDayInt As Integer
	Private endDayInt As Integer
	Private longDateFormat As String
	Private firstTimeOccursDateBool As Boolean

	Private Sub StepC_Load(sender As Object, _
						   e As EventArgs) _
		Handles MyBase.Load
		Me.primaryDayStr = New String("ASSIGNED A VALUE")
		Me.primaryDayBool = False
		Me.recurringFlagBool = Nothing
		Me.occursDateBool = False
		Me.startDayBool = False
		Me.endDayBool = False
		Me.startDayInt = -7
		Me.endDayInt = -1
		Me.longDateFormat = New String("dddd, MMMM dd, yyyy")
		Me.firstTimeOccursDateBool = False
	End Sub
#End Region
#Region "StepC_ResetStep"
	''' <summary>
	''' Resets the Step so it can be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A lot of controls to get correct.</remarks>
	Private Sub StepC_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepC_data = New StepC_Data
		StepC_ResetControls()
	End Sub

	''' <summary>
	''' Resets the controls (View) for the Step.
	''' </summary>
	''' <remarks>Just in case user changes between Recurring/Occuring.</remarks>
	Private Sub StepC_ResetControls()
		Me.primaryDayStr = "ASSIGNED A VALUE"
		Me.primaryDayBool = False
		Me.dtpOccursDate.Value = Date.Today
		Me.dtpQualifyingStart.Value = Date.Today
		Me.dtpQualifyingEnd.Value = Date.Today
		Me.cbSameDayPromo.Checked = False
		Me.lblQualifyingStart.Text = "Start Date"
		Me.lblQualifyingEnd.Text = "End Date"
		Me.occursDateBool = False
		Me.recurringFlagBool = Nothing
		Me.startDayBool = False
		Me.endDayBool = False
		Me.startDayInt = -7
		Me.endDayInt = -1
		Me.longDateFormat = New String("dddd, MMMM dd, yyyy")
		Me.firstTimeOccursDateBool = False
		Me.MonthCal.SelectionStart = Date.Today
		Me.MonthCal.SelectionEnd = Date.Today
		Me.MonthCal.TodayDate = Date.Today
		ResetPrimaryDay()
		ResetRedemptionDays()
	End Sub

	''' <summary>
	''' Unlocks what was once locked.
	''' </summary>
	''' <remarks>Separated from ResetControls because logic.</remarks>
	Private Sub ResetPrimaryDay()
		If Not Me.primaryDayStr = "ASSIGNED A VALUE" Then
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = "ASSIGNED A VALUE"
			Me.cbPrimaryDay.Text = ""
		End If
	End Sub

	''' <summary>
	''' Unchecks what was once checked.
	''' </summary>
	''' <remarks>A Panel full (/fool/) of CheckBoxs instead of CheckListBox.</remarks>
	Private Sub ResetRedemptionDays()
		For Each ctrl As System.Windows.Forms.CheckBox In Me.pnlCbRedemptionDays.Controls
			ctrl.Checked = False
		Next
	End Sub
#End Region
#Region "StepC_Validation"
	''' <summary>
	''' Asks StepC_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepC_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		StepC_SetData()

		If Recurring_Promo() Then
			If Me.stepC_data.QualifyingPeriod_NotEstablished(Me.startDayBool, _
															 Me.endDayBool) Then
				cancelContinuingToNextStep = True
				errString = "Qualifying Period Start or End is not established."
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlRecurringQualifyingPeriod)
			Else
				GUI_Util.regPnl(Me.pnlRecurringQualifyingPeriod)
			End If

			If Me.stepC_data.PrimaryDay_NotEstablished(Me.primaryDayBool) Then
				cancelContinuingToNextStep = True
				errString = "Primary Day is not established."
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlPrimaryDay)
			Else
				GUI_Util.regPnl(Me.pnlPrimaryDay)
			End If
		Else 'Occurring Promo
			If Me.stepC_data.OccursDate_NotEstablished(Me.occursDateBool) Then
				cancelContinuingToNextStep = True
				errString = "Occurs Date is not established."
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlOccursDate)
			Else
				GUI_Util.regPnl(Me.pnlOccursDate)
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		Else
			'Step has been set if no error.
			Me.stepC_data.StepNotSet = False
		End If
	End Sub
#End Region
#Region "StepC_ShowStep"
	''' <summary>
	''' Shows the Step controls.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>This Step can look slightly different depending on Occuring/Recurring</remarks>
	Private Sub StepC_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
		If Recurring_Promo() Then
			Me.pnlRecurringQualifyingPeriod.Enabled = True
			Me.pnlRecurringQualifyingPeriod.Visible = True
			Me.pnlPrimaryDay.Enabled = True
			Me.pnlPrimaryDay.Visible = True
			Me.lblRedemptionDays.Text = "On which day(s) is redemption allowed?"
			Me.pnlOccursDate.Enabled = False
			Me.pnlOccursDate.Visible = False
			Me.pnlOccuringQualifyingPeriod.Enabled = False
			Me.pnlOccuringQualifyingPeriod.Visible = False
			Me.MonthCal.MaxSelectionCount = 31
			If Not IsNothing(Me.recurringFlagBool) Then
				If Me.recurringFlagBool = False Then
					StepC_ResetControls()
				End If
			End If
			Me.recurringFlagBool = True
		Else 'Occurring Promo
			Me.pnlOccursDate.Enabled = True
			Me.pnlOccursDate.Visible = True
			Me.pnlOccuringQualifyingPeriod.Enabled = True
			Me.pnlOccuringQualifyingPeriod.Visible = True
			Me.lblRedemptionDays.Text = "On which day(s) is secondary redemption allowed?"
			Me.pnlRecurringQualifyingPeriod.Enabled = False
			Me.pnlRecurringQualifyingPeriod.Visible = False
			Me.pnlPrimaryDay.Enabled = False
			Me.pnlPrimaryDay.Visible = False
			Me.MonthCal.MaxSelectionCount = 7
			If Not IsNothing(Me.recurringFlagBool) Then
				If Me.recurringFlagBool = True Then
					StepC_ResetControls()
				End If
			End If
			Me.recurringFlagBool = False
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

	Private Sub cbSelectAll_CheckedChanged(sender As Object, _
										   e As EventArgs) _
		Handles cbSelectAll.CheckedChanged
		SelectAll()
	End Sub
#End Region
#Region "StepC_getPrimaryDayOfWeek"
	''' <summary>
	''' Given a Day as a String, Returns that Day's CheckBox.
	''' </summary>
	''' <param name="dayToGet"></param>
	''' <returns>The Primary Day's CheckBox.</returns>
	''' <remarks>This is here because a Panel full of CheckBoxes were used for UI/UX purposes.</remarks>
	Private Function getPrimaryDayOfWeek(ByVal dayToGet As String) As System.Windows.Forms.CheckBox
		Dim cbDayOfWeek As System.Windows.Forms.CheckBox = New System.Windows.Forms.CheckBox
		Select Case dayToGet
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
#Region "StepC_lockPrimaryDayOfWeek"
	''' <summary>
	''' Changes properties of a CheckBox to represent the Primary Day.
	''' </summary>
	''' <param name="cbDayOfWeek"></param>
	''' <remarks>UI/UX flair! SUPERSTAR!</remarks>
	Private Sub lockPrimaryDayOfWeek(ByRef cbDayOfWeek As System.Windows.Forms.CheckBox)
		cbDayOfWeek.Checked = True
		cbDayOfWeek.Enabled = False
		cbDayOfWeek.BackColor = Color.Lime
		cbDayOfWeek.Text = cbDayOfWeek.Text & "*"
	End Sub
#End Region
#Region "StepC_unlockPrimaryDayOfWeek"
	''' <summary>
	''' Reverts property changes made by "lockPrimaryDayOfWeek."
	''' </summary>
	''' <param name="cbDayOfWeek"></param>
	''' <remarks>If you're going to lock it, you best be prepared to unlock it.</remarks>
	Private Sub unlockPrimaryDayOfWeek(ByRef cbDayOfWeek As System.Windows.Forms.CheckBox)
		Dim txt As String = New String("ASSIGNED A VALUE")
		cbDayOfWeek.Checked = False
		cbDayOfWeek.Enabled = True
		cbDayOfWeek.BackColor = Color.Transparent
		Select Case cbDayOfWeek.Text
			Case "Sunday*"
				txt = "Sunday"
			Case "Monday*"
				txt = "Monday"
			Case "Tuesday*"
				txt = "Tuesday"
			Case "Wednesday*"
				txt = "Wednesday"
			Case "Thursday*"
				txt = "Thursday"
			Case "Friday*"
				txt = "Friday"
			Case "Saturday*"
				txt = "Saturday"
		End Select
		cbDayOfWeek.Text = txt
	End Sub
#End Region
#Region "_OCCURRING_PROMO_"
#Region "StepC_setStartEndQualifyingLabels"
	Private Sub setStartEndQualifyingLabels(ByVal local_startDay As String, ByVal local_endDay As String)
		Me.lblQualifyingStart.Text = local_startDay
		Me.lblQualifyingEnd.Text = local_endDay
	End Sub
#End Region
#Region "StepC_dtpOccursDate_DropDown"
	Private Sub dtpOccursDate_DropDown(sender As Object, _
									   e As EventArgs) _
		Handles dtpOccursDate.DropDown
		If Not Me.firstTimeOccursDateBool Then
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = "ASSIGNED A VALUE"
		Else
			Me.firstTimeOccursDateBool = True
		End If
	End Sub
#End Region
#Region "StepC_dtpOccursDate_CloseUp"
	''' <summary>
	''' All the things that happen once dtpOccursDate's CloseUp event gets fired!
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>This probably does way too much! Be careful!</remarks>
	Private Sub dtpOccursDate_CloseUp(sender As Object, _
									  e As EventArgs) _
		Handles dtpOccursDate.CloseUp
		'Local vars because of all those dot operators to get to what is needed!
		Dim local_startDay As String = Me.dtpOccursDate _
										 .Value _
										 .Date _
										 .AddDays(Me.startDayInt) _
										 .ToString(Me.longDateFormat)	'Math + Format
		'
		Dim local_endDay As String = Me.dtpOccursDate _
									   .Value _
									   .Date _
									   .AddDays(Me.endDayInt) _
									   .ToString(Me.longDateFormat)		'Math + Format
		'
		Me.primaryDayStr = Me.dtpOccursDate _
							 .Value _
							 .Date _
							 .DayOfWeek _
							 .ToString()	'Assign Primary Day to var
		'
		setStartEndQualifyingLabels(local_startDay, local_endDay)
		Me.MonthCal.SetSelectionRange(local_startDay, local_endDay)
		lockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
		'This Boolean determines if the Occurs Date has ever been set.
		If Me.occursDateBool = False Then
			Me.occursDateBool = True
		End If
		If Me.MonthCal.Visible = False Then
			Me.MonthCal.Visible = True
		End If
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepC_cbSameDayPromo_CheckedChanged"
	''' <summary>
	''' Changes the Qualifying Period to a Same-Day schema.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Only happens if the Qualifying period has been set.</remarks>
	Private Sub cbSameDayPromo_CheckedChanged(sender As Object, _
											  e As EventArgs) _
		Handles cbSameDayPromo.CheckedChanged
		Dim local_startDay As String = New String("")
		Dim local_endDay As String = New String("")
		If Me.occursDateBool Then
			If Me.cbSameDayPromo.Checked Then '"Weird" maths for Qualifying Range
				Me.startDayInt = -6
				Me.endDayInt = 0
			Else
				Me.startDayInt = -7
				Me.endDayInt = -1
			End If
			'
			local_startDay = Me.dtpOccursDate _
							   .Value _
							   .Date _
							   .AddDays(Me.startDayInt) _
							   .ToString(Me.longDateFormat)
			'
			local_endDay = Me.dtpOccursDate _
							 .Value _
							 .Date _
							 .AddDays(Me.endDayInt) _
							 .ToString(Me.longDateFormat)
			'
			setStartEndQualifyingLabels(local_startDay, _
										local_endDay)
			Me.MonthCal.SetSelectionRange(local_startDay, _
										  local_endDay)	'UI/UX flair! (^_^)
		End If
	End Sub
#End Region
#End Region
#Region "_RECURRING_PROMO_"
#Region "StepC_cbPrimaryDay_DropDown"
	''' <summary>
	''' Unlocks and clears the Primary Day.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>What if I fat-finger the Primary Day and have to change it?</remarks>
	Private Sub cbPrimaryDay_DropDown(sender As Object, _
									  e As EventArgs) _
		Handles cbPrimaryDay.DropDown
		If Not IsNothing(cbPrimaryDay.SelectedItem) Then 'Clear it if it's set!
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = "ASSIGNED A VALUE"
		End If
	End Sub
#End Region
#Region "StepC_cbPrimaryDay_DropDownClosed"
	Private Sub cbPrimaryDay_DropDownClosed(sender As Object, _
											e As EventArgs) _
		Handles cbPrimaryDay.DropDownClosed
		If Me.startDayBool And Me.endDayBool Then
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepC_cbPrimaryDay_SelectionChangeCommitted"
	''' <summary>
	''' Gets called when cbPrimaryDay's SelectionChangeCommitted event is fired.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Thankfully VS is Intelligent.</remarks>
	Private Sub cbPrimaryDay_SelectionChangeCommitted(sender As Object, _
													  e As EventArgs) _
		Handles cbPrimaryDay.SelectionChangeCommitted
		If Me.primaryDayBool = False Then '"Break the (bool) seal!"
			Me.primaryDayBool = True
		End If
		Me.primaryDayStr = Me.cbPrimaryDay.SelectedItem.ToString()	'Set
		lockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))	'And Lock
	End Sub
#End Region
#Region "StepC_dtpQualifyingStart_CloseUp"
	Private Sub dtpQualifyingStart_CloseUp(sender As Object, _
										   e As EventArgs) _
	Handles dtpQualifyingStart.CloseUp
		If Me.startDayBool = False Then	'"Break the (bool) seal!"
			Me.startDayBool = True
		End If
		checkRecurringStartEndQualifyingCheckboxes() 'Have both seals been broken?
	End Sub
#End Region
#Region "StepC_dtpQualifyingEnd_CloseUp"
	Private Sub dtpQualifyingEnd_CloseUp(sender As Object, _
										 e As EventArgs) _
	Handles dtpQualifyingEnd.CloseUp
		If Me.endDayBool = False Then '"Break the (bool) seal!"
			Me.endDayBool = True
		End If
		checkRecurringStartEndQualifyingCheckboxes() 'Have both seals been broken?
	End Sub
#End Region
#Region "StepC_checkRecurringStartEndQualifyingCheckboxes"
	''' <summary>
	''' Sets the SelectionRange if both bools are true.
	''' </summary>
	''' <remarks>Make the MonthCal visible too!</remarks>
	Private Sub checkRecurringStartEndQualifyingCheckboxes()
		If Me.startDayBool And Me.endDayBool Then
			Me.MonthCal.SetSelectionRange(Me.dtpQualifyingStart.Value.Date.ToString(Me.longDateFormat), _
										  Me.dtpQualifyingEnd.Value.Date.ToString(Me.longDateFormat))
			If Me.MonthCal.Visible = False Then
				Me.MonthCal.Visible = True
			End If
			If Me.primaryDayBool Then
				GUI_Util.NextEnabled()
			End If
		End If
	End Sub
#End Region
#End Region
End Class

﻿#Region "COPYING"
'PromotionalCreationWizard
'Copyright (C) 2014-2016 Russell Dillin
'
'This file is part of PromotionalCreationWizard.

'   PromotionalCreationWizard is free software: you can redistribute it and/or
'   modify it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   PromotionalCreationWizard is distributed in the hope that it will be
'	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with PromotionalCreationWizard.
'	If not, see <http://www.gnu.org/licenses/>.
#End Region

Imports TSWizards
Imports System.ComponentModel

''' <summary>
''' Third Step; handles all the date information
''' </summary>
''' <remarks></remarks>
Public Class StepC
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepC_Constants"
	Private OCCURS_START = -7
	Private OCCURS_END = -1
#End Region
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
	''' <remarks>Values are set differently depending
	''' if the promo is recurring or not.</remarks>
	Private Sub StepC_SetData()
		If Recurring_Promo() Then
			Me.stepC_data.OccursDate = Nothing
			Me.stepC_data.StartDate = Me.dtpQualifyingStart.Value.Date
			Me.stepC_data.EndDate = Me.dtpQualifyingEnd.Value.Date
			Me.stepC_data.RecursOnWeekday = getRecursOnWeekday()
			Me.stepC_data.CountCurrentDay = False
			If PCW.Data.DaysBool Then
				PCW.Data.NumOfDays = _
					SetNumOfDays(Me.Data.StartDate, Me.Data.EndDate)
			End If
		Else 'Occurring Promo
			Me.stepC_data.OccursDate = _
				Me.dtpOccursDate.Value.Date
			Me.stepC_data.StartDate = _
				Me.dtpOccursDate.Value.Date.AddDays(Me.startDayInt)
			Me.stepC_data.EndDate = _
				Me.dtpOccursDate.Value.Date.AddDays(Me.endDayInt)
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
								  ByVal endDate As Date) _
								  As System.Nullable(Of Short)
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
	''' <returns>The formatted days String
	''' for "RecursOnWeekday."</returns>
	''' <remarks>Trim removes the whitespace that may happen
	''' if there are no secondary days.</remarks>
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
		Dim days As String = New String(String.Empty)
		For Each ctrl As System.Windows.Forms.CheckBox _
			In Me.pnlCbRedemptionDays.Controls
			If (Not ctrl.Text = Me.primaryDayStr) AndAlso ctrl.Checked Then
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
		Dim days As String = New String(String.Empty)
		For Each item In Me.clbPointsEarningDays.CheckedItems
			days = days & BEP_Util.daysFormat(item.ToString)
		Next
		If days = String.Empty Then
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
		Me.primaryDayStr = New String(String.Empty)
		Me.primaryDayBool = False
		Me.recurringFlagBool = Nothing
		Me.occursDateBool = False
		Me.startDayBool = False
		Me.endDayBool = False
		Me.startDayInt = Me.OCCURS_START
		Me.endDayInt = Me.OCCURS_END
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
		ResetPrimaryDay()
		Me.primaryDayBool = False
		Me.dtpOccursDate.Value = Date.Today
		Me.dtpQualifyingStart.Value = Date.Today
		Me.dtpQualifyingEnd.Value = Date.Today
		Me.cbSameDayPromo.Checked = False
		Me.cbSingleDayPromo.Checked = False
		Me.lblQualifyingStart.Text = "Start Date"
		Me.lblQualifyingEnd.Text = "End Date"
		Me.occursDateBool = False
		Me.recurringFlagBool = Nothing
		Me.startDayBool = False
		Me.endDayBool = False
		Me.startDayInt = Me.OCCURS_START
		Me.endDayInt = Me.OCCURS_END
		Me.longDateFormat = New String("dddd, MMMM dd, yyyy")
		Me.firstTimeOccursDateBool = False
		Me.MonthCal.SelectionStart = Date.Today
		Me.MonthCal.SelectionEnd = Date.Today
		Me.MonthCal.TodayDate = Date.Today
		Me.MonthCal.Visible = False
		Me.lblSelectDates.Visible = True
		Me.cbSameDayPromo.Enabled = False
		Me.cbSingleDayPromo.Enabled = False
		ResetRedemptionDays()
		ResetGUIElements()
	End Sub

	''' <summary>
	''' Unlocks what was once locked.
	''' </summary>
	''' <remarks>Separated from ResetControls because logic.</remarks>
	Private Sub ResetPrimaryDay()
		If Not Me.primaryDayStr = String.Empty Then
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = String.Empty
			Me.cbPrimaryDay.Text = String.Empty
		End If
	End Sub

	''' <summary>
	''' Unchecks what was once checked.
	''' </summary>
	''' <remarks>A Panel full (/fool/) of CheckBoxs instead of CheckListBox.</remarks>
	Private Sub ResetRedemptionDays()
		For Each ctrl As System.Windows.Forms.CheckBox _
			In Me.pnlCbRedemptionDays.Controls
			ctrl.Checked = False
		Next
	End Sub

	Private Sub ResetGUIElements()
		GUI_Util.regPnl(Me.pnlOccursDate)
		GUI_Util.regLbl(Me.lblPromoOccursDate, _
						Color.White)
	End Sub
#End Region
#Region "StepC_Validation"
	''' <summary>
	''' Asks StepC_Data to validate data and
	''' then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when
	''' user presses the "Next> Button."</remarks>
	Private Sub StepC_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)
		Dim errStrArray As ArrayList = New ArrayList

		StepC_SetData()

		If Recurring_Promo() Then
			If Me.stepC_data _
				.QualifyingPeriod_NotEstablished(Me.startDayBool, _
												 Me.endDayBool) Then
				cancelContinuingToNextStep = True
				errString = "Qualifying Period Start or " & _
							"End is not established."
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

			If Me.stepC_data.EndDate_Before_StartDate(Me.Data.EndDate, _
													  Me.Data.StartDate) Then
				cancelContinuingToNextStep = True
				errString = "EndDate is before StartDate!"
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlRecurringQualifyingPeriod)
			Else
				GUI_Util.regPnl(Me.pnlRecurringQualifyingPeriod)
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
			Me.lblRedemptionDays.Text = "On which day(s) is " & _
										"redemption allowed?"
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
			Me.lblRedemptionDays.Text = "On which day(s) is " & _
										"secondary redemption allowed?"
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
		For item As Integer = 0 To (Me.clbPointsEarningDays.Items.Count - 1)
			Me.clbPointsEarningDays _
				.SetItemChecked(item, Me.cbSelectAll.Checked)
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
	Private Sub unlockPrimaryDayOfWeek(ByRef cbDayOfWeek _
									   As System.Windows.Forms.CheckBox)
		Dim txt As String = New String(String.Empty)
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
		If Me.firstTimeOccursDateBool = False Then
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = String.Empty
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
		'Local vars b/c of all those dot operators to get to what is needed!
		Dim local_startDay As String = Me.dtpOccursDate _
										 .Value _
										 .Date _
										 .AddDays(Me.startDayInt) _
										 .ToString(Me.longDateFormat)
		'
		Dim local_endDay As String = Me.dtpOccursDate _
									   .Value _
									   .Date _
									   .AddDays(Me.endDayInt) _
									   .ToString(Me.longDateFormat)
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
			Me.cbSameDayPromo.Enabled = True
			Me.cbSingleDayPromo.Enabled = True
			GUI_Util.successLbl(Me.lblPromoOccursDate)
			GUI_Util.successPnl(Me.pnlOccursDate)
		End If
		If Me.MonthCal.Visible = False Then
			Me.lblSelectDates.Visible = False
			Me.MonthCal.Visible = True
		End If
		GUI_Util.NextEnabled()
		Me.ActiveControl = Me.pnlOccursDate
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
		Dim local_startDay As String = New String(String.Empty)
		Dim local_endDay As String = New String(String.Empty)
		If Me.occursDateBool Then
			If Me.cbSameDayPromo.Checked Then
				Me.cbSingleDayPromo.Enabled = False
				If Me.cbSingleDayPromo.Checked Then
					Me.cbSingleDayPromo.Checked = False
				End If
				Me.startDayInt = Me.OCCURS_START + 1
				Me.endDayInt = Me.OCCURS_END + 1
			Else
				If Me.cbSingleDayPromo.Enabled = False Then
					Me.cbSingleDayPromo.Enabled = True
				End If
				Me.startDayInt = Me.OCCURS_START
				Me.endDayInt = Me.OCCURS_END
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
#Region "StepC_cbSingleDayPromo_CheckedChanged"
	Private Sub cbSingleDayPromo_CheckedChanged(sender As Object, _
												e As EventArgs) _
		Handles cbSingleDayPromo.CheckedChanged
		Dim local_startDay As String = New String(String.Empty)
		Dim local_endDay As String = New String(String.Empty)
		If Me.occursDateBool Then
			If Me.cbSingleDayPromo.Checked Then
				Me.cbSameDayPromo.Enabled = False
				If Me.cbSameDayPromo.Checked Then
					Me.cbSameDayPromo.Checked = False
				End If
				Me.startDayInt = 0
				Me.endDayInt = 0
			Else
				If Me.cbSameDayPromo.Enabled = False Then
					Me.cbSameDayPromo.Enabled = True
				End If
				Me.startDayInt = Me.OCCURS_START
				Me.endDayInt = Me.OCCURS_END
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
	''' <remarks>What if I fat-finger the
	''' Primary Day and have to change it?</remarks>
	Private Sub cbPrimaryDay_DropDown(sender As Object, _
									  e As EventArgs) _
		Handles cbPrimaryDay.DropDown
		If Not IsNothing(cbPrimaryDay.SelectedItem) Then 'Clear it if it's set!
			GUI_Util.regCb(Me.cbPrimaryDay)
			unlockPrimaryDayOfWeek(getPrimaryDayOfWeek(Me.primaryDayStr))
			Me.primaryDayStr = String.Empty
		End If
	End Sub
#End Region
#Region "StepC_cbPrimaryDay_DropDownClosed"
	Private Sub cbPrimaryDay_DropDownClosed(sender As Object, _
											e As EventArgs) _
		Handles cbPrimaryDay.DropDownClosed
		GUI_Util.successCb(Me.cbPrimaryDay)
		If Me.startDayBool AndAlso Me.endDayBool Then
			GUI_Util.NextEnabled()
		End If
		Me.ActiveControl = Me.pnlPrimaryDay
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
#Region "StepC_dtpQualifyingStart_DropDown"
	Private Sub dtpQualifyingStart_DropDown(sender As Object, _
											e As EventArgs) _
		Handles dtpQualifyingStart.DropDown
		If Me.startDayBool = True Then
			GUI_Util.regLbl(Me.lblWhenQPStart)
			GUI_Util.regPnl(Me.pnlWhenQPStart, _
							Color.PapayaWhip)
		End If
	End Sub
#End Region
#Region "StepC_dtpQualifyingEnd_DropDown"
	Private Sub dtpQualifyingEnd_DropDown(sender As Object, _
										  e As EventArgs) _
		Handles dtpQualifyingEnd.DropDown
		If Me.endDayBool = True Then
			GUI_Util.regLbl(Me.lblWhenQPEnd)
			GUI_Util.regPnl(Me.pnlWhenQPEnd, _
							Color.PapayaWhip)
		End If
	End Sub
#End Region
#Region "StepC_dtpQualifyingStart_CloseUp"
	Private Sub dtpQualifyingStart_CloseUp(sender As Object, _
										   e As EventArgs) _
	Handles dtpQualifyingStart.CloseUp
		If Me.startDayBool = False Then	'"Break the (bool) seal!"
			Me.startDayBool = True
		End If
		GUI_Util.successPnl(Me.pnlWhenQPStart)
		GUI_Util.successLbl(Me.lblWhenQPStart)
		'Have both seals been broken?
		checkRecurringStartEndQualifyingCheckboxes(Me.lblWhenQPStart, _
												   Me.pnlWhenQPStart)
		Me.ActiveControl = Me.pnlWhenQPStart
	End Sub
#End Region
#Region "StepC_dtpQualifyingEnd_CloseUp"
	Private Sub dtpQualifyingEnd_CloseUp(sender As Object, _
										 e As EventArgs) _
	Handles dtpQualifyingEnd.CloseUp
		If Me.endDayBool = False Then '"Break the (bool) seal!"
			Me.endDayBool = True
		End If
		GUI_Util.successPnl(Me.pnlWhenQPEnd)
		GUI_Util.successLbl(Me.lblWhenQPEnd)
		'Have both seals been broken?
		checkRecurringStartEndQualifyingCheckboxes(Me.lblWhenQPEnd, _
												   Me.pnlWhenQPEnd)
		Me.ActiveControl = Me.pnlWhenQPEnd
	End Sub
#End Region
#Region "StepC_checkRecurringStartEndQualifyingCheckboxes"
	''' <summary>
	''' Sets the SelectionRange if both bools are true.
	''' </summary>
	''' <remarks>Make the MonthCal visible too!</remarks>
	Private Sub checkRecurringStartEndQualifyingCheckboxes( _
														  ByRef lbl As Label, _
														  ByRef pnl As Panel)
		If Me.startDayBool AndAlso Me.endDayBool Then
			Me.MonthCal.SetSelectionRange( _
				Me.dtpQualifyingStart.Value.Date.ToString(Me.longDateFormat), _
				Me.dtpQualifyingEnd.Value.Date.ToString(Me.longDateFormat))
			If Me.MonthCal.Visible = False Then
				Me.lblSelectDates.Visible = False
				Me.MonthCal.Visible = True
			End If
			If Me.primaryDayBool AndAlso _
				(Not Me.stepC_data.EndDate_Before_StartDate( _
					 Me.dtpQualifyingEnd.Value.Date, _
					 Me.dtpQualifyingStart.Value.Date)) Then
				GUI_Util.NextEnabled()
			ElseIf Me.stepC_data.EndDate_Before_StartDate( _
					Me.dtpQualifyingEnd.Value.Date, _
					Me.dtpQualifyingStart.Value.Date) Then
				GUI_Util.errLbl(lbl)
				GUI_Util.errPnl(pnl)
				GUI_Util.msgBox("EndDate Before StartDate!")
			Else
				If GUI_Util.IsSuccess(pnl) Then
					GUI_Util.successLbl(lbl)
					GUI_Util.successPnl(pnl)
				Else
					GUI_Util.regLbl(lbl)
					GUI_Util.regPnl(pnl)
				End If
			End If
		End If
	End Sub
#End Region
#End Region
End Class

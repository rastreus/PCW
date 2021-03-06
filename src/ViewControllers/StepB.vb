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
Imports CustomizedTextBox
Imports System.ComponentModel

''' <summary>
''' Second Step; handles PromoName, Recurring and RecurringFrequency.
''' </summary>
''' <remarks>Ideally each Class should have a single purpose,
''' but this is decent.</remarks>
Public Class StepB
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepB_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepB_data = New StepB_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepB_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepB_data
		End Get
	End Property
#End Region
#Region "StepB_Data"
	''' <summary>
	''' Model for StepB.
	''' </summary>
	''' <remarks>As a loose representation of MVC,
	''' this is the Model.</remarks>
	Private stepB_data As StepB_Data
	Public ReadOnly Property Data() As StepB_Data
		Get
			Return Me.stepB_data
		End Get
	End Property
#End Region
#Region "StepB_SetData"
	''' <summary>
	''' Sets the data's properties from the controls.
	''' </summary>
	''' <remarks>(View->Controller->Model)</remarks>
	Private Sub StepB_SetData()
		Dim frequency As System.Nullable(Of Char) = _
			New System.Nullable(Of Char)
		'Frequency needs to be set in case Promo is Not Recurring.
		'Ideally, this should be Nothing, but not sure if GPM can handles it.
		frequency = "W"	'Nothing
		Me.stepB_data.ID = Me.btnPromoID.Text
		Me.stepB_data.Name = Me.txtPromoName.Text
		If Me.rbRecurringYes.Checked Then
			Me.stepB_data.Recurring = True
			Select Case Me.cbRecurringFrequency.SelectedItem
				Case "Daily"
					frequency = "D"
				Case "Weekly"
					frequency = "W"
				Case "Monthly"
					frequency = "M"
				Case "Quarterly"
					frequency = "Q"
				Case "Yearly"
					frequency = "Y"
				Case Else
					frequency = "W"	'Nothing
			End Select
		Else
			Me.stepB_data.Recurring = False
		End If
		Me.stepB_data.RecurringFrequency = frequency
	End Sub
#End Region
#Region "StepB_Load"
	'Private Sub StepB_Load(sender As Object, e As EventArgs) _
	'	Handles MyBase.Load
	'	'Moved stepB_data initialization to New
	'End Sub
#End Region
#Region "StepB_ShowStep"
	Private promoAcronym As String
	Private promoMonth As String
	Private promoYear As String
	Private promoID As String
	Private promoNameEntered As Boolean
	Private promoNameLeft As Boolean

	''' <summary>
	''' Gets Date information on show.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>This Step uses current Date info on show.</remarks>
	Private Sub StepB_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
			Me.promoAcronym = New String(String.Empty)
			Me.promoMonth = getPromoThisMonth()
			Me.promoYear = getPromoYear()
			Me.promoID = New String(String.Empty)
			Me.promoNameEntered = False
			Me.promoNameLeft = False
		End If
	End Sub

	''' <summary>
	''' Returns formatted String of this (current) month.
	''' </summary>
	''' <returns>Current month as String of two digits.</returns>
	''' <remarks></remarks>
	Private Function getPromoThisMonth() As String
		Dim thisMonthStr As String = Date.Today.Month.ToString
		thisMonthStr = formatMonthStr(thisMonthStr)
		Return thisMonthStr
	End Function

	''' <summary>
	''' Returns formatted String of next month.
	''' </summary>
	''' <returns>Current month + 1 for next month
	''' as String of two digits.</returns>
	''' <remarks></remarks>
	Private Function getPromoNextMonth() As String
		Dim nextMonthStr As String = (Date.Today.Month + 1).ToString
		nextMonthStr = formatMonthStr(nextMonthStr)
		Return nextMonthStr
	End Function

	''' <summary>
	''' Returns formatted String of the picked month.
	''' </summary>
	''' <param name="monthAbbreviation"></param>
	''' <returns>Picked month as String of two digits</returns>
	''' <remarks></remarks>
	Private Function getPromoPickMonth(ByVal monthAbbreviation As String) As String
		Dim monthStr As String = New String("00")
		Select Case monthAbbreviation
			Case "Jan"
				monthStr = "01"
			Case "Feb"
				monthStr = "02"
			Case "Mar"
				monthStr = "03"
			Case "Apr"
				monthStr = "04"
			Case "May"
				monthStr = "05"
			Case "June"
				monthStr = "06"
			Case "July"
				monthStr = "07"
			Case "Aug"
				monthStr = "08"
			Case "Sept"
				monthStr = "09"
			Case "Oct"
				monthStr = "10"
			Case "Nov"
				monthStr = "11"
			Case "Dec"
				monthStr = "12"
		End Select
		Return monthStr
	End Function

	Private Function formatMonthStr(ByVal monthStr As String) As String
		If monthStr.Length < 2 Then
			monthStr = "0" & monthStr
		End If
		Return monthStr
	End Function

	''' <summary>
	''' Return formatted String of Year.
	''' </summary>
	''' <returns>Current year as String of last two digits.</returns>
	''' <remarks></remarks>
	Private Function getPromoYear() As String
		Dim yearStr = Date.Today.Year.ToString
		Dim result As String = New String(String.Empty)
		result = yearStr.Chars(2) & yearStr.Chars(3)
		Return result
	End Function
#End Region
#Region "StepB_Reset"
	''' <summary>
	''' Resets the controls (View) for the Step to be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>If PCW is run for a single-entry and
	''' then gets run again for a single-payout.</remarks>
	Private Sub StepB_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepB_data = New StepB_Data
		StepB_ResetControls()
	End Sub

	Private Sub StepB_ResetControls()
		Me.txtPromoName.Text = String.Empty
		Me.SuccessIcon.Visible = False
		Me.btnPromoID.Text = "TEST!1503"
		Me.rbRecurringNo.Checked = True
		Me.cbRecurringFrequency.Enabled = False
		Me.cbRecurringFrequency.SelectedIndex = -1
	End Sub
#End Region
#Region "StepB_Validation"
	''' <summary>
	''' Asks StepB_Data to validate data and
	''' then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when
	''' user presses the "Next> Button."</remarks>
	Private Sub StepB_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)
		Dim errStrArray As ArrayList = New ArrayList

		StepB_SetData()

		If Me.Data.PromoID_Invalid(Me.Data.ID) Then
			cancelContinuingToNextStep = True
			errString = "PromoID Invalid: " & _
						 Me.Data.Get_PromoID_errString(Me.Data.ID)
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPromoID)
		Else
			GUI_Util.regPnl(Me.pnlPromoID)
		End If

		If Me.Data.PromoName_Invalid(Me.Data.Name) Then
			cancelContinuingToNextStep = True
			errString = "PromoName Invalid: " & _
						 Me.Data.Get_PromoName_errString(Me.Data.Name)
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPromoName)
		Else
			GUI_Util.regPnl(Me.pnlPromoName)
		End If

		If Me.Data.Recurring_Period_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Please select Recurring period option."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlRecurring)
			Me.cbRecurringFrequency.DroppedDown = True
		Else
			GUI_Util.regPnl(Me.pnlRecurring)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		Else
			'Step has been set if no error.
			Me.stepB_data.StepNotSet = False
		End If
	End Sub
#End Region
#Region "StepB_CheckForNext"
	Private Sub CheckForNext()
		If promoNameEntered Then
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepB_rbRecurringYes_CheckedChanged"
	''' <summary>
	''' Handles the GUI reaction for the Yes/No RadioButton.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Intice user to give RecurringFrequency using DroppedDown.</remarks>
	Private Sub rbRecurringYes_CheckedChanged(sender As Object, _
											  e As EventArgs) _
		Handles rbRecurringYes.CheckedChanged
		If rbRecurringYes.Checked Then
			Me.cbRecurringFrequency.Enabled = True
			Me.cbRecurringFrequency.DroppedDown = True
		Else
			Me.cbRecurringFrequency.Enabled = False
		End If
	End Sub
#End Region
#Region "StepB_rbRecurringNo_CheckedChanged"
	Private Sub rbRecurringNo_CheckedChanged(sender As Object, _
											 e As EventArgs) _
		Handles rbRecurringYes.CheckedChanged
		If Me.rbRecurringNo.Checked Then
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepB_cbRecurringFrequency_DropDown"
	Private Sub cbRecurringFrequency_DropDown(sender As Object, _
											  e As EventArgs) _
		Handles cbRecurringFrequency.DropDown
		'If the ComboBox is in a Success state
		If Me.cbRecurringFrequency.BackColor = Color.DarkGreen Then
			GUI_Util.regCb(Me.cbRecurringFrequency)
		End If
		PCW.NextEnabled = False
	End Sub
#End Region
#Region "StepB_cbRecurringFrequency_DropDownClosed"
	Private Sub cbRecurringFrequency_DropDownClosed(sender As Object, _
													e As EventArgs) _
		Handles cbRecurringFrequency.DropDownClosed
		Dim readyForNext As Boolean = False
		If cbRecurringFrequency.SelectedItem = "Daily" Then
			PCW.Data.DaysBool = True
			readyForNext = True
		ElseIf (Not cbRecurringFrequency.SelectedItem = String.Empty) Then
			readyForNext = True
		Else
			PCW.Data.DaysBool = False
		End If
		If readyForNext Then
			GUI_Util.successCb(Me.cbRecurringFrequency)
			GUI_Util.NextEnabled()
			Me.ActiveControl = Me.pnlRecurring
		End If
	End Sub
#End Region
#Region "StepB_txtPromoName_Enter"
	Private Sub txtPromoName_Enter(sender As Object, _
								   e As EventArgs) _
		Handles txtPromoName.Enter
		Me.promoNameEntered = True
		If GUI_Util.IsSuccess(Me.txtPromoName) Then
			GUI_Util.regTxt(Me.txtPromoName)
		End If
		GUI_Util.onSetBtn(Me.btnSetPromoName)
		GUI_Util.offIcon(Me.SuccessIcon)
	End Sub
#End Region
#Region "StepB_txtPromoName_Leave"
	Private Sub txtPromoName_Leave(sender As Object, _
								   e As EventArgs) _
		Handles txtPromoName.Leave
		If Me.promoNameEntered AndAlso _
			(Not Me.Data.PromoName_Invalid(Me.txtPromoName.Text)) Then
			Me.promoAcronym = getPromoAcronym()
			Me.promoID = getPromoID()
			Me.btnPromoID.Text = SetBtnPromoIDText(Me.promoID)
			Me.promoNameLeft = True
			GUI_Util.onIcon(Me.SuccessIcon)
			GUI_Util.successTxt(Me.txtPromoName)
			GUI_Util.regPnl(Me.pnlPromoName)
			If Me.Data.PromoID_Invalid(Me.btnPromoID.Text) Then
				Dim errID As String = New String(String.Empty)
				errID = Me.btnPromoID.Text
				GUI_Util.errPnl(Me.pnlPromoID)
				GUI_Util.msgBox("PromoID Invalid: " & _
								Me.Data.Get_PromoID_errString(errID) & _
								vbCrLf & "Edit the PromoID.")
			Else
				GUI_Util.regPnl(Me.pnlPromoID)
				GUI_Util.NextEnabled()
			End If
		ElseIf Me.Data.PromoName_Invalid(Me.txtPromoName.Text) Then
			GUI_Util.errPnl(Me.pnlPromoName)
			GUI_Util.errIcon(Me.SuccessIcon)
			GUI_Util.regTxt(Me.txtPromoName)
			GUI_Util.msgBox("PromoName Invalid: " & _
							Me.Data.Get_PromoName_errString( _
								Me.txtPromoName.Text))
		Else
			'NEVER GETS HERE?
			GUI_Util.regPnl(Me.pnlPromoName)
		End If
	End Sub

	Private Function getPromoAcronym() As String
		Dim word As String = New String(Me.txtPromoName.Text.Trim)
		Dim words As String() = word.Split(New Char() {" "c})
		Dim acronym As String = New String(String.Empty)
		For Each word In words
			acronym = acronym & word(0)
		Next
		If acronym.Length > 6 Then
			acronym = acronym.Substring(0, 5)
		End If
		Return acronym
	End Function

	Private Function getPromoID() As String
		Return Me.promoAcronym.ToUpper() & _
			   Me.promoYear & _
			   Me.promoMonth
	End Function
#End Region
#Region "StepB_btnSetPromoName_Click"
	Private Sub btnSetPromoName_Click(sender As Object, _
									  e As EventArgs) _
		Handles btnSetPromoName.Click
		If Me.promoNameEntered AndAlso _
			(Not Me.txtPromoName.Text = String.Empty) Then
			Me.ActiveControl = Me.pnlPromoName
		End If
	End Sub
#End Region
#Region "StepB_btnPromoID_Click"
	Private Sub btnPromoID_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnPromoID.Click
		If Me.promoNameLeft Then
			Me.txtEditPromoID.Text = Me.promoAcronym.ToUpper()
			Me.lblEditPromoID.Text = Me.promoYear & Me.promoMonth
			PCW.NextEnabled = False
			SetEditPromoID(True)
		End If
	End Sub

	Private Sub SetEditPromoID(ByVal bool As Boolean)
		Me.pnlEditPromoID.Visible = bool
		Me.pnlEditPromoID.Enabled = bool
	End Sub
#End Region
#Region "StepB_btnTxtEditPromoID_Click"
	Private Sub btnTxtEditPromoID_Click(sender As Object, _
										e As EventArgs) _
		Handles btnTxtEditPromoID.Click
		Dim tempPromoAcronym As String = New String(String.Empty)
		Dim tempPromoID As String = New String(String.Empty)
		Dim errID As String = New String(String.Empty)
		tempPromoAcronym = Me.promoAcronym
		tempPromoID = Me.promoID
		'
		Me.promoAcronym = Me.txtEditPromoID.Text
		Me.promoID = getPromoID()
		Me.btnPromoID.Text = SetBtnPromoIDText(Me.promoID)
		If Me.Data.PromoID_Invalid(Me.btnPromoID.Text) Then
			'SET IT ALL BACK
			errID = Me.btnPromoID.Text
			Me.promoAcronym = tempPromoAcronym
			Me.promoID = tempPromoID
			Me.btnPromoID.Text = SetBtnPromoIDText(Me.promoID)
			GUI_Util.errPnl(Me.pnlPromoID)
			GUI_Util.msgBox("PromoID Invalid: " & _
							Me.Data.Get_PromoID_errString(errID))
		Else
			GUI_Util.regPnl(Me.pnlPromoID)
			SetEditPromoID(False)
			GUI_Util.NextEnabled()
		End If
	End Sub

	'Mostly positive that this was done for DEBUG and not corrected.
	Private Function SetBtnPromoIDText(ByRef txt As String) As String
		Return txt
	End Function
#End Region
#Region "StepB_rbNextMonth_CheckedChanged"
	Private Sub rbNextMonth_CheckedChanged(sender As Object, _
										   e As EventArgs) _
		Handles rbNextMonth.CheckedChanged
		If Me.rbNextMonth.Checked Then
			Me.promoMonth = getPromoNextMonth()
		Else
			Me.promoMonth = getPromoThisMonth()
		End If
		Me.lblEditPromoID.Text = Me.promoYear & Me.promoMonth
	End Sub
#End Region
#Region "StepB_rbPickMonth_CheckedChanged"
	Private Sub rbPickMonth_CheckedChanged(sender As Object, _
										   e As EventArgs) _
		Handles rbPickMonth.CheckedChanged
		If Me.rbPickMonth.Checked AndAlso _
			Me.cbPickMonth.Enabled = False Then
			Me.cbPickMonth.Enabled = True
			Me.cbPickMonth.DroppedDown = True
		Else
			Me.cbPickMonth.Enabled = False
		End If
	End Sub
#End Region
#Region "StepB_cbPickMonth_DropDown"
	Private Sub cbPickMonth_DropDown(sender As Object, _
									 e As EventArgs) _
		Handles cbPickMonth.DropDown
		'If the ComboBox is in a Success state
		If Me.cbPickMonth.BackColor = Color.DarkGreen Then
			GUI_Util.regCb(Me.cbPickMonth)
		End If
		PCW.NextEnabled = False
	End Sub
#End Region
#Region "StepB_cbPickMonth_DropDownClosed"
	Private Sub cbPickMonth_DropDownClosed(sender As Object, _
										   e As EventArgs) _
	Handles cbPickMonth.DropDownClosed
		If (Not cbPickMonth.SelectedItem = String.Empty) Then
			Me.promoMonth = getPromoPickMonth(Me.cbPickMonth.SelectedItem)
			Me.lblEditPromoID.Text = Me.promoYear & Me.promoMonth
			GUI_Util.successCb(Me.cbPickMonth)
			Me.ActiveControl = Me.pnlEditPromoID
		End If
	End Sub
#End Region
End Class

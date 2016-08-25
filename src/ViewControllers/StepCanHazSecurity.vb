#Region "COPYING"
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
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class StepCanHazSecurity
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepCanHazSecurity_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		stepCanHazSecurity_data = New StepCanHazSecurity_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepCanHazSecurity_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepCanHazSecurity_data
		End Get
	End Property
#End Region
#Region "StepCanHazSecurity_Data"
	''' <summary>
	''' Model for StepCanHazSecurity.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepCanHazSecurity_data As StepCanHazSecurity_Data
	Public ReadOnly Property Data() As StepCanHazSecurity_Data
		Get
			Return Me.stepCanHazSecurity_data
		End Get
	End Property
#End Region
#Region "StepCanHazSecurity_SetData"
	''' <summary>
	''' Sets the data's properties from the controls.
	''' </summary>
	''' <remarks>Values are set differently depending
	''' if the promo is recurring or not.</remarks>
	Private Sub StepCanHazSecurity_SetData()
		Me.stepCanHazSecurity_data.OverrideTime = getOverrideTime
		Me.stepCanHazSecurity_data.CutoffTime = getCutoffTime
	End Sub

	''' <summary>
	''' Returns an OverrideTime value.
	''' </summary>
	''' <returns>Either the DateTime or Nothing.</returns>
	''' <remarks>b/c VB.NET If ternary is too weird not to use!</remarks>
	Private Function getOverrideTime() As String
		Dim result As String = If(Me.rbSecurityYES.Checked, _
								  ParseTime(Me.txtOverrideTimeHours.Text, _
											Me.txtOverrideTimeMinutes.Text,
											Me.rbOverrideTimePM.Checked), _
								  Nothing)
		Return result
	End Function

	''' <summary>
	''' Returns a CutoffTime value.
	''' </summary>
	''' <returns>Either the DateTime or Nothing.</returns>
	''' <remarks>b/c VB.NET If ternary is too weird not to use!</remarks>
	Private Function getCutoffTime() As String
		Dim result As String = If(Me.rbSecurityYES.Checked, _
								  ParseTime(Me.txtCutoffTimeHours.Text, _
											Me.txtCutoffTimeMinutes.Text,
											Me.rbCutoffTimePM.Checked), _
								  Nothing)
		Return result
	End Function

	Private Function ParseTime(ByVal hours As String, _
							   ByVal minutes As String, _
							   ByVal pmChecked As Boolean) As String
		Dim result As String = New String(String.Empty)
		Dim ampm As String = If(pmChecked, "P", "A")
		hours = PrependZeroIfOneDigit(hours)
		result = hours & minutes & ampm
		result = result.Trim
		Return result
	End Function

	Private Function PrependZeroIfOneDigit(ByVal timeStr As String) As String
		If timeStr.Length = 1 Then
			timeStr = "0" & timeStr
		End If
		Return timeStr
	End Function
#End Region
#Region "StepCanHazSecurity_Load"
	Private OverrideTimeHoursEntered As Boolean
	Private OverrideTimeMinutesEntered As Boolean
	Private CutoffTimeHoursEntered As Boolean
	Private CutoffTimeMinutesEntered As Boolean

	Private Sub StepC_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		SetBoolsToFalse()
	End Sub

	Private Sub SetBoolsToFalse()
		OverrideTimeHoursEntered = False
		OverrideTimeMinutesEntered = False
		CutoffTimeHoursEntered = False
		CutoffTimeMinutesEntered = False
	End Sub
#End Region
#Region "StepCanHazSecurity_ResetStep"
	''' <summary>
	''' Resets the Step so it can be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A lot of controls to get correct.</remarks>
	Private Sub StepC_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepCanHazSecurity_data = New StepCanHazSecurity_Data
		SetBoolsToFalse()
		StepCanHazSecurity_ResetControls()
	End Sub

	''' <summary>
	''' Resets the controls (View) for the Step.
	''' </summary>
	''' <remarks>Just in case user changes between Recurring/Occuring.</remarks>
	Private Sub StepCanHazSecurity_ResetControls()
		Me.rbSecurityNO.Checked = True
		Me.pnlOverrideTime.Enabled = False
		Me.pnlCutoffTime.Enabled = False
		Me.txtOverrideTimeHours.Text = "HH"
		Me.txtCutoffTimeHours.Text = "HH"
		Me.txtOverrideTimeMinutes.Text = "mm"
		Me.txtCutoffTimeMinutes.Text = "mm"
	End Sub
#End Region
#Region "StepCanHazSecurity_Validation"
	Private Sub StepCanHazSecurity_Validation(sender As Object, _
											  e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)
		Dim errStrArray As ArrayList = New ArrayList

		StepCanHazSecurity_SetData()

		If Me.rbSecurityYES.Checked Then
			If Me.Data.OverrideTime_Invalid() Then
				cancelContinuingToNextStep = True
				errString = "Override Time: " & _
					Me.Data.OverrideTime_errString
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlOverrideTime)
			Else
				GUI_Util.regPnl(Me.pnlOverrideTime)
			End If

			If Me.Data.CutoffTime_Invalid() Then
				cancelContinuingToNextStep = True
				errString = "Cutoff Time: " & _
					Me.Data.CutoffTime_errString
				errStrArray.Add(errString)
				GUI_Util.errPnl(Me.pnlCutoffTime)
			Else
				GUI_Util.regPnl(Me.pnlCutoffTime)
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_Checks"
	Private Sub CheckForNext()
		If OverrideTimeHoursEntered AndAlso _
			OverrideTimeMinutesEntered AndAlso _
			CutoffTimeHoursEntered AndAlso _
			CutoffTimeMinutesEntered Then
			GUI_Util.NextEnabled()
		End If
	End Sub
	Private Sub CheckForOverrideTime()
		If Me.OverrideTimeHoursEntered AndAlso _
			Me.OverrideTimeMinutesEntered Then
			Dim errString As String = New String(String.Empty)
			If Me.Data.Time_Is_Invalid(getOverrideTime(),
									   errString) Then
				Me.OverrideTimeHoursEntered = False
				Me.OverrideTimeMinutesEntered = False
				Me.txtOverrideTimeHours.Text = "HH"
				Me.txtOverrideTimeMinutes.Text = "mm"
				Me.btnSubmitOverrideTime.Enabled = False
				Me.btnSubmitOverrideTime.BackColor = Color.Gainsboro
				GUI_Util.errPnl(Me.pnlOverrideTime)
				PCW.NextEnabled = False
				GUI_Util.msgBox("Override Time: " & _
								errString)
				Me.ActiveControl = Me.pnlOverrideTime
			Else
				Me.OverrideSuccessIcon.ActiveColor = Color.Lime
				Me.OverrideSuccessIcon.InActiveColor = Color.Lime
				Me.OverrideSuccessIcon.Visible = True
				GUI_Util.regPnl(Me.pnlOverrideTime)
				CheckForNext()
			End If
		End If
	End Sub
	Private Sub CheckForCutoffTime()
		If Me.CutoffTimeHoursEntered AndAlso _
			Me.CutoffTimeMinutesEntered Then
			Dim errString As String = New String(String.Empty)
			If Me.Data.Time_Is_Invalid(getCutoffTime(),
									   errString) Then
				Me.CutoffTimeHoursEntered = False
				Me.CutoffTimeMinutesEntered = False
				Me.txtCutoffTimeHours.Text = "HH"
				Me.txtCutoffTimeMinutes.Text = "mm"
				Me.btnSubmitCutoffTime.Enabled = False
				Me.btnSubmitCutoffTime.BackColor = Color.Gainsboro
				GUI_Util.errPnl(Me.pnlCutoffTime)
				PCW.NextEnabled = False
				GUI_Util.msgBox("Cutoff Time: " & _
								errString)
				Me.ActiveControl = Me.pnlCutoffTime
			Else
				Me.CutoffSuccessIcon.ActiveColor = Color.Lime
				Me.CutoffSuccessIcon.InActiveColor = Color.Lime
				Me.CutoffSuccessIcon.Visible = True
				GUI_Util.regPnl(Me.pnlCutoffTime)
				CheckForNext()
			End If
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_rbSecurityYES_CheckedChanged"
	Private Sub rbSecurityYES_CheckedChanged(sender As Object, _
											 e As EventArgs) _
		Handles rbSecurityYES.CheckedChanged
		If rbSecurityYES.Checked Then
			PCW.NextEnabled = False
			Me.pnlOverrideTime.Enabled = True
			Me.pnlCutoffTime.Enabled = True
			Me.lblBefore.Visible = True
		Else
			GUI_Util.NextEnabled()
			Me.pnlOverrideTime.Enabled = False
			Me.pnlCutoffTime.Enabled = False
			Me.lblBefore.Visible = False
		End If
	End Sub
#End Region
#Region "_TEXTBOX_KEYPRESS_"
#If False Then
ASIDE: Limits the textboxes to only allow numeric input.
A user is able to paste non-numeric input into the textbox.
Each TextBox is validated for invalid (non-numeric) characters.
#End If
#Region "StepCanHazSecurity_txtOverrideTimeHours_KeyPress"
	Private Sub txtOverrideTimeHours_KeyPress(sender As Object, _
											  e As KeyPressEventArgs) _
		Handles txtOverrideTimeHours.KeyPress
		If Not Char.IsDigit(e.KeyChar) And
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_txtOverrideTimeMinutes_KeyPress"
	Private Sub txtOverrideTimeMinutes_KeyPress(sender As Object, _
												e As KeyPressEventArgs) _
		Handles txtOverrideTimeMinutes.KeyPress
		If Not Char.IsDigit(e.KeyChar) And
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_txtCutoffTimeHours_KeyPress"
	Private Sub txtCutoffTimeHours_KeyPress(sender As Object, _
											e As KeyPressEventArgs) _
		Handles txtCutoffTimeHours.KeyPress
		If Not Char.IsDigit(e.KeyChar) And
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_txtCutoffTimeMinutes_KeyPress"
	Private Sub txtCutoffTimeMinutes_KeyPress(sender As Object, _
											  e As KeyPressEventArgs) _
		Handles txtCutoffTimeMinutes.KeyPress
		If Not Char.IsDigit(e.KeyChar) And
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#End Region
#Region "_TIME_ENTER_"
	Private Sub txtOverrideTimeHours_Enter(sender As Object, _
										   e As EventArgs) _
		Handles txtOverrideTimeHours.Enter
		ClearSuccessIcon(Me.OverrideSuccessIcon)
		Me.OverrideTimeHoursEntered = True
		Me.txtOverrideTimeHours.Text = ClearHours( _
			Me.txtOverrideTimeHours.Text)
		CheckToEnableTimeSubmit(Me.OverrideTimeHoursEntered, _
								Me.OverrideTimeMinutesEntered, _
								Me.btnSubmitOverrideTime)
	End Sub
	Private Sub txtCutoffTimeHours_Enter(sender As Object, _
										 e As EventArgs) _
		Handles txtCutoffTimeHours.Enter
		ClearSuccessIcon(Me.CutoffSuccessIcon)
		Me.CutoffTimeHoursEntered = True
		Me.txtCutoffTimeHours.Text = ClearHours( _
			Me.txtCutoffTimeHours.Text)
		CheckToEnableTimeSubmit(Me.CutoffTimeHoursEntered, _
								Me.CutoffTimeMinutesEntered, _
								Me.btnSubmitCutoffTime)
	End Sub
	Private Sub txtOverrideTimeMinutes_Enter(sender As Object, _
											 e As EventArgs) _
		Handles txtOverrideTimeMinutes.Enter
		ClearSuccessIcon(Me.OverrideSuccessIcon)
		Me.OverrideTimeMinutesEntered = True
		Me.txtOverrideTimeMinutes.Text = ClearMinutes( _
			Me.txtOverrideTimeMinutes.Text)
		CheckToEnableTimeSubmit(Me.OverrideTimeHoursEntered, _
								Me.OverrideTimeMinutesEntered, _
								Me.btnSubmitOverrideTime)
	End Sub
	Private Sub txtCutoffTimeMinutes_Enter(sender As Object, _
										   e As EventArgs) _
		Handles txtCutoffTimeMinutes.Enter
		ClearSuccessIcon(Me.CutoffSuccessIcon)
		Me.CutoffTimeMinutesEntered = True
		Me.txtCutoffTimeMinutes.Text = ClearMinutes( _
			Me.txtCutoffTimeMinutes.Text)
		CheckToEnableTimeSubmit(Me.CutoffTimeHoursEntered, _
								Me.CutoffTimeMinutesEntered, _
								Me.btnSubmitCutoffTime)
	End Sub
	Private Function ClearHours(ByVal hours As String) As String
		Dim result As String = If(hours = "HH", String.Empty, hours)
		Return result
	End Function
	Private Function ClearMinutes(ByVal minutes As String) As String
		Dim result As String = If(minutes = "mm", String.Empty, minutes)
		Return result
	End Function
	Private Sub ClearSuccessIcon(ByRef successIcon _
								 As FontAwesomeIcons.IconButton)
		If successIcon.Visible = True Then
			successIcon.ActiveColor = SystemColors.ControlLight
			successIcon.InActiveColor = SystemColors.ControlLight
		End If
	End Sub
#End Region
#Region "_TIME_LEAVE_"
	Private Sub txtOverrideTimeHours_Leave(sender As Object, _
										   e As EventArgs) _
		Handles txtOverrideTimeHours.Leave
		CheckForOverrideTime()
	End Sub
	Private Sub txtOverrideTimeMinutes_Leave(sender As Object, _
											 e As EventArgs) _
		Handles txtOverrideTimeMinutes.Leave
		CheckForOverrideTime()
	End Sub
	Private Sub txtCutoffTimeHours_Leave(sender As Object, _
										 e As EventArgs) _
		Handles txtCutoffTimeHours.Leave
		CheckForCutoffTime()
	End Sub
	Private Sub txtCutoffTimeMinutes_Leave(sender As Object, _
										   e As EventArgs) _
		Handles txtCutoffTimeMinutes.Leave
		CheckForCutoffTime()
	End Sub
#End Region
#Region "_TIME_SUBMIT_"
	Private Sub CheckToEnableTimeSubmit(ByVal hoursEntered As Boolean, _
										ByVal minutesEntered As Boolean, _
										ByRef btnSubmit As Button)
		If hoursEntered AndAlso _
			minutesEntered Then
			EnableTimeSubmit(btnSubmit)
		End If
	End Sub

	Private Sub EnableTimeSubmit(ByRef btn As Button)
		btn.BackColor = Color.HotPink
		btn.Enabled = True
	End Sub

	Private Sub btnSubmitOverrideTime_Click(sender As Object, _
											e As EventArgs) _
		Handles btnSubmitOverrideTime.Click
		Me.ActiveControl = Me.pnlOverrideTime
	End Sub
	Private Sub btnSubmitCutoffTime_Click(sender As Object, _
										  e As EventArgs) _
		Handles btnSubmitCutoffTime.Click
		Me.ActiveControl = Me.pnlCutoffTime
	End Sub
#End Region
End Class

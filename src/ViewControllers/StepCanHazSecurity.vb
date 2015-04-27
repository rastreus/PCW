Imports TSWizards

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
	''' <remarks>Values are set differently depending if the promo is recurring or not.</remarks>
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
		Dim result As String = New String("!")
		Dim ampm As String = If(pmChecked, "P", "A")
		result = hours & minutes & ampm
		Return result
	End Function
#End Region
#Region "StepCanHazSecurity_ResetStep"
	''' <summary>
	''' Resets the Step so it can be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A lot of controls to get correct.</remarks>
	Private Sub StepC_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepCanHazSecurity_data = New StepCanHazSecurity_Data
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
	Private Sub StepCanHazSecurity_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		StepCanHazSecurity_SetData()

		'If Me.Data.OverrideTime_Invalid() Then
		'	cancelContinuingToNextStep = True
		'	errString = "Override Time is invalid; not in time range."
		'	errStrArray.Add(errString)
		'	GUI_Util.errPnl(Me.pnlOverrideTime)
		'Else
		'	GUI_Util.regPnl(Me.pnlOverrideTime)
		'End If

		'If Me.Data.CutoffTime_Invalid() Then
		'	cancelContinuingToNextStep = True
		'	errString = "Cutoff Time is invalid; not in time range."
		'	errStrArray.Add(errString)
		'	GUI_Util.errPnl(Me.pnlCutoffTime)
		'Else
		'	GUI_Util.regPnl(Me.pnlCutoffTime)
		'End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		End If
	End Sub
#End Region
#Region "StepCanHazSecurity_rbSecurityYES_CheckedChanged"
	Private Sub rbSecurityYES_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbSecurityYES.CheckedChanged
		If rbSecurityYES.Checked Then
			Me.pnlOverrideTime.Enabled = True
			Me.pnlCutoffTime.Enabled = True
		Else
			Me.pnlOverrideTime.Enabled = False
			Me.pnlCutoffTime.Enabled = False
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
		Me.txtOverrideTimeHours.Text = ClearHours(Me.txtOverrideTimeHours.Text)
	End Sub
	Private Sub txtCutoffTimeHours_Enter(sender As Object, _
											  e As EventArgs) _
		Handles txtCutoffTimeHours.Enter
		Me.txtCutoffTimeHours.Text = ClearHours(Me.txtOverrideTimeHours.Text)
	End Sub
	Private Sub txtOverrideTimeMinutes_Enter(sender As Object, _
												  e As EventArgs) _
		Handles txtOverrideTimeMinutes.Enter
		Me.txtOverrideTimeMinutes.Text = ClearMinutes(Me.txtOverrideTimeMinutes.Text)
	End Sub
	Private Sub txtCutoffTimeMinutes_Enter(sender As Object, _
												e As EventArgs) _
		Handles txtCutoffTimeMinutes.Enter
		Me.txtCutoffTimeMinutes.Text = ClearMinutes(Me.txtCutoffTimeMinutes.Text)
	End Sub
	Private Function ClearHours(ByVal hours As String) As String
		Dim result As String = If(hours = "HH", "", hours)
		Return result
	End Function
	Private Function ClearMinutes(ByVal minutes As String) As String
		Dim result As String = If(minutes = "mm", "", minutes)
		Return result
	End Function
#End Region
End Class

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
	Private Function getOverrideTime() As Nullable(Of DateTime)
		Dim result As Nullable(Of DateTime) = If(Me.rbSecurityYES.Checked, _
												 Me.dtpOverrideTime.Value, _
												 Nothing)
		Return result
	End Function

	''' <summary>
	''' Returns a CutoffTime value.
	''' </summary>
	''' <returns>Either the DateTime or Nothing.</returns>
	''' <remarks>b/c VB.NET If ternary is too weird not to use!</remarks>
	Private Function getCutoffTime() As Nullable(Of DateTime)
		Dim result As Nullable(Of DateTime) = If(Me.rbSecurityYES.Checked, _
												  Me.dtpCutoffTime.Value, _
												  Nothing)
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
		Me.dtpOverrideTime.Value = DateTime.Today.Date
		Me.dtpCutoffTime.Value = DateTime.Today.Date
	End Sub
#End Region
#Region "StepCanHazSecurity_Validation"
	Private Sub StepCanHazSecurity_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		StepCanHazSecurity_SetData()

		If Me.Data.OverrideTime_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Override Time is invalid; not in time range."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlOverrideTime)
		Else
			GUI_Util.regPnl(Me.pnlOverrideTime)
		End If

		If Me.Data.CutoffTime_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Cutoff Time is invalid; not in time range."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlCutoffTime)
		Else
			GUI_Util.regPnl(Me.pnlCutoffTime)
		End If

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
End Class

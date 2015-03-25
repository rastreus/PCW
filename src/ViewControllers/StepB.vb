Imports TSWizards

''' <summary>
''' Second Step; handles PromoName, Recurring and RecurringFrequency.
''' </summary>
''' <remarks>Ideally each Class should have a single purpose, but this is decent.</remarks>
Public Class StepB
	Inherits TSWizards.BaseInteriorStep

#Region "StepB_Data"
	''' <summary>
	''' Model for StepB.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
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
		Dim frequency As String = New String("W")
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
					frequency = "W"
			End Select
		Else
			Me.stepB_data.Recurring = False
		End If
		Me.stepB_data.RecurringFrequency = frequency
	End Sub
#End Region
#Region "StepB_Load"
	Private Sub StepB_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		stepB_data = New StepB_Data
		Me.ActiveControl = Me.txtPromoName
	End Sub
#End Region
#Region "StepB_Reset"
	''' <summary>
	''' Resets the controls (View) for the Step to be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>If PCW is run for a single-entry and then gets run again for a single-payout.</remarks>
	Private Sub StepB_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepB_data = New StepB_Data
		StepB_ResetControls()
	End Sub

	Private Sub StepB_ResetControls()
		Me.txtPromoName.Text = ""
		Me.rbRecurringNo.Checked = True
		Me.cbRecurringFrequency.Enabled = False
		Me.cbRecurringFrequency.SelectedIndex = -1
	End Sub
#End Region
#Region "StepB_Validation"
	''' <summary>
	''' Asks StepB_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepB_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing

		Me.StepB_SetData()

		If Me.stepB_data.PromoName_Invalid() Then
			cancelContinuingToNextStep = True
			errString = Me.stepB_data.PromoName_Invalid_GetErrString()
			GUI_Util.errPnl(Me.pnlPromoName)
			Me.ActiveControl = Me.txtPromoName
		Else
			GUI_Util.regPnl(Me.pnlPromoName)
		End If

		If Me.stepB_data.Recurring_Period_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Please select Recurring period option."
			GUI_Util.errPnl(Me.pnlRecurring)
			Me.ActiveControl = Me.cbRecurringFrequency
			Me.cbRecurringFrequency.DroppedDown = True
		Else
			GUI_Util.regPnl(Me.pnlRecurring)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
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
	Private Sub rbRecurringYes_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbRecurringYes.CheckedChanged
		If rbRecurringYes.Checked Then
			Me.cbRecurringFrequency.Enabled = True
			Me.cbRecurringFrequency.DroppedDown = True
		Else
			Me.cbRecurringFrequency.Enabled = False
		End If
	End Sub
#End Region
End Class

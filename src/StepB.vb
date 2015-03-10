Imports TSWizards
Imports CenteredMessagebox

Public Class StepB
	Inherits TSWizards.BaseInteriorStep

#Region "StepB_Data"
	Private stepB_data As StepB_Data
	Public ReadOnly Property Data() As StepB_Data
		Get
			Return Me.stepB_data
		End Get
	End Property
#End Region
#Region "StepB_SetData"
	'Set the Model's data properties from the collected controls data.
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
			Me.stepB_data.RecurringFrequency = frequency
		Else
			Me.stepB_data.Recurring = False
		End If
	End Sub
#End Region
#Region "StepB_Load"
	Private Sub StepB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		stepB_data = New StepB_Data
		Me.ActiveControl = Me.txtPromoName
	End Sub
#End Region
#Region "StepB_Reset"
	'This "resets" the Step's controls so that the Step can be used once again.
	'For example, if PCW is run once for a single-entry and then it gets run again
	'for a single-payout.
	Private Sub StepB_ResetStep(sender As Object, e As EventArgs) Handles MyBase.ResetStep
		Me.txtPromoName.Text = ""
		Me.rbRecurringNo.Checked = True
		Me.cbRecurringFrequency.Enabled = False
		Me.cbRecurringFrequency.SelectedIndex = -1
	End Sub
#End Region
#Region "StepB_Validation"
	'This occurs when the user presses the Next> Button on StepB
	'We want to check everything and confirm that there will be no issues
	'before moving on to the next Step.
	Private Sub StepB_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE")

		Me.StepB_SetData()

		If Me.stepB_data.PromoName_Invalid() Then
			cancelContinuingToNextStep = True
			errString = Me.stepB_data.PromoName_Invalid_GetErrString()
			errPnl(Me.pnlPromoName)
			Me.ActiveControl = Me.txtPromoName
		Else
			regPnl(Me.pnlPromoName)
		End If

		If Me.stepB_data.Recurring_Period_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Please select Recurring period option."
			errPnl(Me.pnlRecurring)
			Me.ActiveControl = Me.cbRecurringFrequency
			Me.cbRecurringFrequency.DroppedDown = True
		Else
			regPnl(Me.pnlRecurring)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			CenteredMessagebox.MsgBox.Show(errString, "Error",
									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If
	End Sub
#End Region
#Region "StepB_rbRecurringYes"
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
	'=======================
	'Utility Subroutines as well as the InfoCircle
	'need to be refactored into an Interface, etc.
#Region "StepB_InfoCircle"
	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014-2015

Brought to you by the fine folks of the OJC IT Department!</a>.Value

		CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub
#End Region
#Region "Utility Subroutines"
	Private Sub errPnl(ByRef pnl As System.Windows.Forms.Panel)
		pnl.BackColor = Color.MistyRose
	End Sub

	Private Sub regPnl(ByRef pnl As System.Windows.Forms.Panel)
		pnl.BackColor = SystemColors.Control
	End Sub
#End Region
End Class

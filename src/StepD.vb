Imports TSWizards
Imports System.Text.RegularExpressions

Public Class StepD
	Inherits TSWizards.BaseInteriorStep

	Private Delegate Sub DelegateChangeLabelText(ByVal s As String)
	Private m_DelegateChangeLabelText As DelegateChangeLabelText

	Private Sub StepD_Load(sender As Object, e As EventArgs) Handles Me.Load
		m_DelegateChangeLabelText = New DelegateChangeLabelText(AddressOf ChangeLabelText)
	End Sub

	Private Sub ChangeLabelText(ByVal str As String)
		Me.lblDragOffer.Text = str
	End Sub

#Region "StepD_Validation"
	'This just confirms that everything is good before continuing on to the next Step.
	Private Sub StepD_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

		'Standard PCW error reporting for MULTI-PART SEQUENCIAL INSTANCES
		If MPSI_Invalid() Then
			e.Cancel = True
			Me.Panel2.BackColor = Color.MistyRose
			Me.ActiveControl = Me.txtNumOfDaysTiers
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If
	End Sub

	Private Function MPSI_Invalid()
		Dim invalid As Boolean = False

		If Me.rbMultiPartEntryPayout.Checked Then
			invalid = Invalid_Number(Me.txtNumOfDaysTiers.Text)
		End If

		Return invalid
	End Function

	'Copied utilitarian function that should only be one place.
	'On a refactoring, place this in a single location.
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

	'If MULTI-PART SEQUENCIAL INSTANCES is selected, please enable the textbox.
	'Otherwise, put that thing back the way it was.
	Private Sub rbMultiPartEntryPayout_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbMultiPartEntryPayout.CheckedChanged
		If Me.rbMultiPartEntryPayout.Checked Then
			Me.txtNumOfDaysTiers.Text = ""
			Me.txtNumOfDaysTiers.Enabled = True
			Me.ActiveControl = Me.txtNumOfDaysTiers
		Else
			Me.txtNumOfDaysTiers.Enabled = False
			Me.txtNumOfDaysTiers.Text = "How many days/tiers?"
		End If
	End Sub

	Private Sub rbSumQualifyingPoints_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbSumQualifyingPoints.CheckedChanged
		If Not rbEligiblePlayersOfferList.Checked Then
			SetPointCutoffPanel(Me.rbSumQualifyingPoints.Checked)
		End If
	End Sub

	Private Sub rbSumLifetimePoints_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbSumLifetimePoints.CheckedChanged
		If Not rbEligiblePlayersOfferList.Checked Then
			SetPointCutoffPanel(Me.rbSumLifetimePoints.Checked)
		End If
	End Sub

	Private Sub rbAutoQualification_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbAutoQualification.CheckedChanged
		If Not rbEligiblePlayersOfferList.Checked Then
			SetPointCutoffPanel(Me.rbAutoQualification.Checked)
		End If
	End Sub

	Private Sub rbEligiblePlayersOfferList_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbEligiblePlayersOfferList.CheckedChanged
		If rbEligiblePlayersOfferList.Checked Then
			SetDragDropPanel(Me.rbEligiblePlayersOfferList.Checked)
		End If
	End Sub

	Private Sub SetPointCutoffPanel(ByVal bool As Boolean)
		Me.pnlPointCutoffLimit.Visible = bool
	End Sub

	Private Sub SetDragDropPanel(ByVal bool As Boolean)
		Me.pnlDragOffer.Enabled = bool
		Me.pnlDragOffer.Visible = bool
		If Not bool Then
			Me.SuccessIcon.Visible = bool
			ChangeLabelText("(Drag Offer List Here)")
		End If
	End Sub

	Private Sub pnlDragOffer_DragEnter(sender As Object, e As DragEventArgs) _
		Handles pnlDragOffer.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub DragDropSuccessIcon()
		Me.SuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.SuccessIcon.ActiveColor = Color.Lime
		Me.SuccessIcon.InActiveColor = Color.Lime
		Me.SuccessIcon.Visible = True
	End Sub

	Private Sub DragDropFailureIcon()
		Me.SuccessIcon.IconType = FontAwesomeIcons.IconType.CrossCircleSolid
		Me.SuccessIcon.ActiveColor = Color.Red
		Me.SuccessIcon.InActiveColor = Color.Red
		Me.SuccessIcon.Visible = True
	End Sub

	Private Sub pnlDragOffer_DragDrop(sender As Object, e As DragEventArgs) _
		Handles pnlDragOffer.DragDrop
		Try
			Dim a As Array = CType(e.Data.GetData(DataFormats.FileDrop), Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateChangeLabelText, New Object() {s})
				DragDropSuccessIcon()
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in DragDrop Sub: " + ex.Message)
			ChangeLabelText("FAILURE: " + ex.Message)
			DragDropFailureIcon()
		End Try
	End Sub
End Class

﻿Imports TSWizards

''' <summary>
''' Fourth Step; handles promo category and player eligiblity.
''' </summary>
''' <remarks></remarks>
Public Class StepD
	Inherits TSWizards.BaseInteriorStep

#Region "StepD_Data"
	''' <summary>
	''' Model for StepD.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepD_data As StepD_Data
	Public ReadOnly Property Data() As StepD_Data
		Get
			Return Me.stepD_data
		End Get
	End Property
#End Region
#Region "StepD_SetData"
	Private Sub StepD_SetData()
		Dim promoCategory As StepD_Data.PromoCategory = New StepD_Data.PromoCategory

		If Me.rbSingleEntryPayout.Checked Then
			promoCategory = PromotionalCreationWizard.StepD_Data.PromoCategory.entryAndPayout
		ElseIf Me.rbSingleEntryOnly.Checked Then
			promoCategory = PromotionalCreationWizard.StepD_Data.PromoCategory.entryOnly
			Me.stepD_data.SkipPayout = True
		ElseIf Me.rbSinglePayoutOnly.Checked Then
			promoCategory = PromotionalCreationWizard.StepD_Data.PromoCategory.payoutOnly
			Me.stepD_data.SkipEntry = True
		ElseIf Me.rbMultiPartEntryPayout.Checked Then
			promoCategory = PromotionalCreationWizard.StepD_Data.PromoCategory.multPart
			Me.stepD_data.MuliPartDaysTiers = Me.txtNumOfDaysTiers.Text
		Else
			promoCategory = PromotionalCreationWizard.StepD_Data.PromoCategory.acquisition
		End If
		Me.stepD_data.Category = promoCategory
	End Sub
#End Region
#Region "StepD_Delegates"
	Private Delegate Sub DelegateChangeLabelText(ByVal s As String)
	Private m_DelegateChangeLabelText As DelegateChangeLabelText

	Private Sub ChangeLabelText(ByVal str As String)
		Me.lblDragOffer.Text = str
	End Sub
#End Region
#Region "StepD_Load"
	Private Sub StepD_Load(sender As Object, e As EventArgs) _
	Handles MyBase.Load
		m_DelegateChangeLabelText = New DelegateChangeLabelText(AddressOf ChangeLabelText)
		stepD_data = New StepD_Data
	End Sub
#End Region
#Region "StepD_ResetStep"
	Private Sub StepD_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		StepD_ResetControls()
	End Sub

	Private Sub StepD_ResetControls()
		Me.rbSingleEntryPayout.Checked = True
		Me.txtNumOfDaysTiers.Text = "How many days/tiers?"
		Me.rbSumQualifyingPoints.Checked = True
		Me.rbPointCutoffLimitNo.Checked = True
		Me.txtPointCutoffLimit.Text = "Enter Point Cutoff limit here."
		Me.SetPointCutoffPanel(True)
		Me.SetDragDropPanel(False)
	End Sub
#End Region
#Region "StepD_Validation"
	''' <summary>
	''' Asks StepD_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepD_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing

		Me.StepD_SetData()
		Me.Data.CheckForReset()

		If Me.Data.Category = PromotionalCreationWizard.StepD_Data.PromoCategory.multPart Then
			If BEP_Util.invalidNum(Me.Data.MuliPartDaysTiers) Then
				cancelContinuingToNextStep = True
				errString = "MutiPart Days/Tiers Invalid Number."
				GUI_Util.errPnl(Me.pnlPromoType)
				Me.ActiveControl = Me.txtNumOfDaysTiers
			Else
				GUI_Util.regPnl(Me.pnlPromoType)
			End If
		End If

		If Me.rbPointCutoffLimitYes.Checked Then
			If BEP_Util.invalidNum(Me.Data.PointCutoffLimit) Then
				cancelContinuingToNextStep = True
				errString = "Point Cutoff Limit Invalid Number."
				GUI_Util.errPnl(Me.pnlPointCutoffLimit)
			Else
				GUI_Util.regPnl(Me.pnlPointCutoffLimit)
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
		Else
			If Me.Data.SkipEntry Then
				Me.NextStep = "StepF"
			End If
		End If
	End Sub
#End Region
#Region "StepD_SetDragDropPanel"
	Private Sub rbEligiblePlayersOfferList_CheckedChanged(sender As Object, e As EventArgs) _
	Handles rbEligiblePlayersOfferList.CheckedChanged
		If rbEligiblePlayersOfferList.Checked Then
			SetDragDropPanel(Me.rbEligiblePlayersOfferList.Checked)
		End If
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
#End Region
#Region "StepD_SetPointCutoffPanel"
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

	Private Sub SetPointCutoffPanel(ByVal bool As Boolean)
		Me.pnlPointCutoffLimit.Enabled = bool
		Me.pnlPointCutoffLimit.Visible = bool
	End Sub
#End Region
#Region "StepD_rbMultiPartEntryPayout_CheckedChanged"
	''' <summary>
	''' Enables/Disables "txtNumOfDaysTiers."
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>If MULTI-PART SEQUENCIAL INSTANCES is selected, please enable the textbox.
	''' Otherwise, put that thing back the way it was.
	''' </remarks>
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
#End Region
End Class
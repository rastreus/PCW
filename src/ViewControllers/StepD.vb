Imports TSWizards
Imports System.ComponentModel

Imports Category = PromotionalCreationWizard _
				   .PCW_Data _
				   .PromoCategory
Imports MultiPart = PromotionalCreationWizard _
					.PCW_Data _
					.MultiPartCategory
Imports PromotionalCreationWizard.DDEP

''' <summary>
''' Fourth Step; handles promo category and player eligiblity.
''' </summary>
''' <remarks></remarks>
Public Class StepD
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepD_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepD_data = New StepD_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepD_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepD_data
		End Get
	End Property
#End Region
#Region "StepD_Data"
	''' <summary>
	''' Model for StepD.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private successBool As Boolean = False
	Private txtTierBool As Boolean = False
	Private stepD_data As StepD_Data
	Public ReadOnly Property Data() As StepD_Data
		Get
			Return Me.stepD_data
		End Get
	End Property
#End Region
#Region "StepD_SetData"
	Private Sub StepD_SetData()
		Me.stepD_data.Category = getPromoCategory()
		PCW.Data.CurrentPromoCategory = Me.Data.Category
		Select Case Me.Data.Category
			Case Category.entryOnly
				Me.stepD_data.SkipPayout = True
			Case Category.payoutOnly
				Me.stepD_data.SkipEntry = True
			Case Category.multiPart
				If Me.rbDAYS.Checked Then
					Me.stepD_data.MultiPartDaysTiers = Me.lblNumOfDays.Text
				ElseIf Me.rbTIERS.Checked Then
					Me.stepD_data.MultiPartDaysTiers = Me.txtNumOfTiers.Text
				End If
				If (Me.rbDAYS.Checked AndAlso _
					Me.cbPayoutParametersYES.Checked) OrElse _
					(Me.rbTIERS.Checked AndAlso _
					 Me.cbPayoutParametersYES.Checked) Then
					Me.stepD_data.MultiPartCategory = MultiPart.multiPartSame
					PCW.Data.CurrentMultiPartCategory = MultiPart.multiPartSame
				ElseIf Me.rbDAYS.Checked AndAlso _
					(Not Me.cbPayoutParametersYES.Checked) Then
					Me.stepD_data.MultiPartCategory = MultiPart.multiPartDiff
					PCW.Data.CurrentMultiPartCategory = MultiPart.multiPartDiff
					PCW.Data.NumOfDiffs = Short.Parse(Me.lblNumOfDays.Text)
					PCW.Data.PayoutDiffType = "DAYS"
				ElseIf Me.rbTIERS.Checked AndAlso _
					(Not Me.cbPayoutParametersYES.Checked) Then
					Me.stepD_data.MultiPartCategory = MultiPart.multiPartDiff
					PCW.Data.CurrentMultiPartCategory = MultiPart.multiPartDiff
					PCW.Data.NumOfDiffs = Short.Parse(Me.txtNumOfTiers.Text)
					PCW.Data.PayoutDiffType = "TIERS"
				End If
		End Select
		Me.stepD_data.PointCutoffLimit = _
			getPointCutoffLimit(Me.rbPointCutoffLimitYES.Checked, _
								Me.txtPointCutoffLimit.Text)
		If (Me.rbEligiblePlayersList.Checked AndAlso _
			Me.stepD_DDEP.indexAreSet) Then
			setEligiblePlayersCSV()
		Else
			GUI_Util.msgBox("ELIGIBLEPLAYER INDICE NOT SET!")
		End If
	End Sub

	Private Function getPointCutoffLimit(ByVal yesChecked As Boolean, _
										 ByVal txtInput As String) _
										 As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked AndAlso Not BEP_Util.invalidNum(txtInput) Then
			result = Short.Parse(txtInput)
		End If
		Return result
	End Function

	Private Function getPromoCategory() As PCW_Data.PromoCategory
		Dim promoCategory As PCW_Data.PromoCategory
		If Me.rbSingleEntryPayout.Checked Then
			promoCategory = Category.entryAndPayout
		ElseIf Me.rbSingleEntryOnly.Checked Then
			promoCategory = Category.entryOnly
		ElseIf Me.rbSinglePayoutOnly.Checked Then
			promoCategory = Category.payoutOnly
		ElseIf Me.rbMultiPartEntryPayout.Checked Then
			promoCategory = Category.multiPart
		Else
			promoCategory = Category.acquisition
		End If
		Return promoCategory
	End Function

	Private Sub setEligiblePlayersCSV()
		Dim local_StepB As StepB = New StepB
		Dim local_promoID As String = New String(String.Empty)
		Me.UseWaitCursor = True
		Me.Data.EligiblePlayersCSVFilePath = Me.stepD_DDEP.lblFilePath.Text
		local_StepB = PCW.GetStep("StepB")
		local_promoID = local_StepB.Data.ID
		Dim incorrectLength As Integer = _
			Me.Data.CSVtoEligiblePlayersList(local_promoID, _
											 Me.stepD_DDEP.PlayerIDIndex, _
											 Me.stepD_DDEP.NumOfTicketsIndex)
		Me.UseWaitCursor = False
		If incorrectLength > 0 Then
			GUI_Util.msgBox("There were " & incorrectLength.ToString & _
							" rows of incorrect length." & vbCrLf & _
							"Please fix CSV file and try again.", _
							"INCORRECT LENGTH!")
		Else
			'Only Enable once sure the CSV in a DataTable
			Me.Data.TempIntoReal()
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepD_ResetStep"
	Private Sub StepD_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepD_data = New StepD_Data
		Me.successBool = False
		Me.txtTierBool = False
		StepD_ResetControls()
	End Sub

	Private Sub StepD_ResetControls()
		Me.TiersSuccessIcon.Visible = False
		Me.PointCutoffLimitSuccessIcon.Visible = False
		Me.rbSingleEntryPayout.Checked = True
		Me.txtNumOfTiers.Text = BEP_Util.TiersStr
		Me.rbSumQualifyingPoints.Checked = True
		Me.rbPointCutoffLimitNO.Checked = True
		Me.txtPointCutoffLimit.Text = BEP_Util.NumStr
		Me.pnlPayoutParameters.Enabled = False
		Me.cbPayoutParametersYES.Checked = False
		GUI_Util.regPnl(Me.pnlPointCutoffLimit, Color.PapayaWhip)
		Me.SetPointCutoffPanel(True)
		Me.SetpnlLemonChiffon(False)
	End Sub
#End Region
#Region "StepD_Validation"
	''' <summary>
	''' Asks StepD_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepD_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)
		Dim errStrArray As ArrayList = New ArrayList

		Me.StepD_SetData()
		'(07/03/15: Commented out b/c not needed anymore?)
		'THIS CODE CAN BE REMOVED'
		'Me.Data.CheckForReset()

		If Me.Data.Category = Category.multiPart AndAlso
			BEP_Util.invalidNum(Me.Data.MultiPartDaysTiers) Then
			cancelContinuingToNextStep = True
			errString = "MutiPart Days/Tiers Invalid Number."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPromoType)
			Me.ActiveControl = Me.txtNumOfTiers
		Else
			GUI_Util.regPnl(Me.pnlPromoType)
		End If

		If Me.rbPointCutoffLimitYES.Checked AndAlso
			Me.Data.PointCutoffLimit_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Point Cutoff Limit Invalid Number."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPointCutoffLimit)
		Else
			GUI_Util.regPnl(Me.pnlPointCutoffLimit, _
							Color.PapayaWhip)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		Else
			Me.NextStep = Me.Data.DetermineStepFlow()
			If Me.NextStep = "StepF" Then
				PCW.GetStep("StepF").PreviousStep = "StepD"
			End If
		End If
	End Sub
#End Region
#Region "StepD_ShowStep"
	''' <summary>
	''' Shows the Step controls.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub Stepd_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If PCW.Data.DaysBool AndAlso _
			(Not IsNothing(PCW.Data.NumOfDays)) Then
			Me.rbDAYS.Checked = True
			Me.lblNumOfDays.Text = PCW.Data.NumOfDays.ToString
			Me.cbPayoutParametersYES.Checked = True
			Me.cbPayoutParametersYES.ForeColor = SystemColors.ControlText
		Else
			Me.lblNumOfDays.Text = BEP_Util.DaysStr
			Me.cbPayoutParametersYES.Checked = False
		End If
	End Sub
#End Region
#Region "StepD_SetpnlLemonChiffon"
	Private Sub rbEligiblePlayersOfferList_CheckedChanged(sender As Object, _
														  e As EventArgs) _
		Handles rbEligiblePlayersList.CheckedChanged
		If Me.rbEligiblePlayersList.Checked Then
			PCW.NextEnabled = False
		Else
			GUI_Util.NextEnabled()
		End If
		SetpnlLemonChiffon(Me.rbEligiblePlayersList.Checked)
	End Sub

	Private Sub SetpnlLemonChiffon(ByVal bool As Boolean)
		Me.pnlLemonChiffon.Enabled = bool
		Me.pnlLemonChiffon.Visible = bool
		If Not bool Then
			Me.btnOpenPanel.BackColor = Color.MediumPurple
			Me.btnOpenPanel.Enabled = True
		End If
	End Sub
#End Region
#Region "StepD_SetPointCutoffPanel"
	Private Sub rbSumQualifyingPoints_CheckedChanged(sender As Object, _
													 e As EventArgs) _
		Handles rbSumQualifyingPoints.CheckedChanged
		If Not rbEligiblePlayersList.Checked Then
			SetPointCutoffPanel(Me.rbSumQualifyingPoints.Checked)
		End If
	End Sub

	Private Sub rbSumLifetimePoints_CheckedChanged(sender As Object, _
												   e As EventArgs) _
		Handles rbSumLifetimePoints.CheckedChanged
		If Not rbEligiblePlayersList.Checked Then
			SetPointCutoffPanel(Me.rbSumLifetimePoints.Checked)
		End If
	End Sub

	Private Sub rbAutoQualification_CheckedChanged(sender As Object, _
												   e As EventArgs) _
		Handles rbAutoQualification.CheckedChanged
		If Not rbEligiblePlayersList.Checked Then
			SetPointCutoffPanel(Me.rbAutoQualification.Checked)
		End If
	End Sub

	Private Sub SetPointCutoffPanel(ByVal bool As Boolean)
		Me.pnlPointCutoffLimit.Enabled = bool
		Me.pnlPointCutoffLimit.Visible = bool
	End Sub
#End Region
#Region "StepD_rbPointCutoffLimitYES_CheckedChanged"
	Private Sub rbPointCutoffLimitYES_CheckedChanged(sender As Object, _
													 e As EventArgs) _
		Handles rbPointCutoffLimitYES.CheckedChanged
		If Me.rbPointCutoffLimitYES.Checked Then
			Me.txtPointCutoffLimit.Enabled = Me.rbPointCutoffLimitYES.Checked
			Me.txtPointCutoffLimit.Text = String.Empty
			Me.ActiveControl = Me.txtPointCutoffLimit
		Else
			Me.txtPointCutoffLimit.Enabled = False
			Me.txtPointCutoffLimit.Text = BEP_Util.NumStr
		End If
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
	Private Sub rbMultiPartEntryPayout_CheckedChanged(sender As Object, _
													  e As EventArgs) _
		Handles rbMultiPartEntryPayout.CheckedChanged
		If Me.rbMultiPartEntryPayout.Checked Then
			If (Not Me.rbDAYS.Checked) AndAlso _
				(Not Me.rbTIERS.Checked) Then
				PCW.NextEnabled = False
			End If
			Me.pnlDaysTiers.Enabled = True
			Me.pnlPayoutParameters.Enabled = True
		Else
			GUI_Util.NextEnabled()
			Me.pnlDaysTiers.Enabled = False
			Me.pnlPayoutParameters.Enabled = False
		End If
	End Sub
#End Region
#Region "StepD_rbDAYS_CheckedChanged"
	Private Sub rbDAYS_CheckedChanged(sender As Object, _
									  e As EventArgs) _
		Handles rbDAYS.CheckedChanged
		If Me.rbDAYS.Checked AndAlso _
			(Not Me.rbDAYS.ForeColor = SystemColors.ControlText) AndAlso _
			(Not Me.lblNumOfDays.ForeColor = SystemColors.ControlText) Then
			Me.rbDAYS.ForeColor = SystemColors.ControlText
			Me.lblNumOfDays.ForeColor = SystemColors.ControlText
		Else
			Me.rbDAYS.ForeColor = SystemColors.ControlDark
			Me.lblNumOfDays.ForeColor = SystemColors.ControlDark
		End If
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepD_rbTIERS_CheckedChanged"
	Private Sub rbTIERS_CheckedChanged(sender As Object, _
									   e As EventArgs) _
		Handles rbTIERS.CheckedChanged
		If Me.rbTIERS.Checked Then
			If Me.txtTierBool = False Then
				PCW.NextEnabled = False
			End If
			TurnTiersOn()
		Else
			TurnTiersOff()
		End If
	End Sub

	Private Sub TurnTiersOn()
		Me.cbPayoutParametersYES.Checked = False
		Me.cbPayoutParametersYES.ForeColor = SystemColors.ControlDark
		Me.rbTIERS.ForeColor = SystemColors.ControlText
		Me.txtNumOfTiers.ForeColor = SystemColors.ControlText
		Me.txtNumOfTiers.Enabled = True
		Me.btnSetNumOfTiers.Enabled = True
		Me.btnSetNumOfTiers.BackColor = Color.HotPink
	End Sub

	Private Sub TurnTiersOff()
		Me.cbPayoutParametersYES.Checked = True
		Me.cbPayoutParametersYES.ForeColor = SystemColors.ControlText
		Me.rbTIERS.ForeColor = SystemColors.ControlDark
		Me.txtNumOfTiers.ForeColor = SystemColors.ControlDark
		Me.txtNumOfTiers.Enabled = False
		Me.btnSetNumOfTiers.Enabled = False
		Me.btnSetNumOfTiers.BackColor = Color.Gainsboro
		Me.txtNumOfTiers.Text = BEP_Util.TiersStr
	End Sub
#End Region
#Region "StepD_txtNumOfTiers_Enter_Leave"
	Private Sub txtNumOfTiers_Enter(sender As Object, _
									e As EventArgs) _
		Handles txtNumOfTiers.Enter
		Me.txtTierBool = True
		If Me.TiersSuccessIcon.Visible = True Then
			TiersSuccessIcon.ActiveColor = SystemColors.ControlLight
			TiersSuccessIcon.InActiveColor = SystemColors.ControlLight
		End If
	End Sub
	Private Sub txtNumOfTiers_Leave(sender As Object, _
									e As EventArgs) _
		Handles txtNumOfTiers.Leave
		If Me.txtTierBool AndAlso _
			(Not Me.txtNumOfTiers.Text = BEP_Util.TiersStr AndAlso _
			 Not Me.txtNumOfTiers.Text = String.Empty) Then
			TiersSuccessIcon.ActiveColor = Color.Lime
			TiersSuccessIcon.InActiveColor = Color.Lime
			TiersSuccessIcon.Visible = True
			GUI_Util.NextEnabled()
		ElseIf (Me.txtNumOfTiers.Text = BEP_Util.TiersStr OrElse _
				Me.txtNumOfTiers.Text = String.Empty) Then
			PCW.NextEnabled = False
		End If
	End Sub
#End Region
#Region "StepD_cbPayoutParametersYES_CheckedChanged"
	Private Sub cbPayoutParametersYES_CheckedChanged(sender As Object, _
													 e As EventArgs) _
		Handles cbPayoutParametersYES.CheckedChanged
		If (Me.rbMultiPartEntryPayout.Checked = True) AndAlso _
			(Me.cbPayoutParametersYES.Checked = False) Then
			If Me.rbDAYS.Checked Then
				GUI_Util.msgBox("Typically a 'Multi-Part of Days' uses " &
								"the same Payout parameters for each day", _
								"ARE YOU SURE?")
			End If
		Else
			If Me.rbTIERS.Checked Then
				GUI_Util.msgBox("Typically a 'Multi-Part of Tiers' uses " &
								"different Payout parameters for each tier", _
								"ARE YOU SURE?")
			End If
		End If
	End Sub
#End Region
#Region "StepD_txtNumOfTiers_KeyPress"
	''' <summary>
	''' Limits the textbox to only allow numeric input.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A user is able to paste non-numeric input into the textbox.</remarks>
	Private Sub txtNumOfTiers_KeyPress(sender As Object, _
									   e As KeyPressEventArgs) _
		Handles txtNumOfTiers.KeyPress
		If Not Char.IsDigit(e.KeyChar) AndAlso
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepD_btnSetNumOfTiers_Click"
	Private Sub btnSetNumOfTiers_Click(sender As Object, _
									   e As EventArgs) _
		Handles btnSetNumOfTiers.Click
		Me.ActiveControl = Me.pnlDaysTiers
	End Sub
#End Region
#Region "StepD_PointCutoffLimit_UI/UX"
	Private Sub txtPointCutoffLimit_Enter(sender As Object, _
										  e As EventArgs) _
		Handles txtPointCutoffLimit.Enter
		GUI_Util.offIcon(Me.PointCutoffLimitSuccessIcon)
		GUI_Util.onSetBtn(Me.btnSetPointCutoffLimit)
	End Sub
	Private Sub txtPointCutoffLimit_Leave(sender As Object, _
										  e As EventArgs) _
		Handles txtPointCutoffLimit.Leave
		If (Not Me.txtPointCutoffLimit.Text = String.Empty) Then
			GUI_Util.onIcon(Me.PointCutoffLimitSuccessIcon)
		End If
	End Sub
	Private Sub btnSetPointCutoffLimit_Click(sender As Object, _
											 e As EventArgs) _
	Handles btnSetPointCutoffLimit.Click
		Me.ActiveControl = Me.pnlPointCutoffLimit
	End Sub
#End Region
#Region "StepD_btnOpenPanel_Click"
	Private Sub btnOpenPanel_Click(sender As Object, _
								   e As EventArgs) _
		Handles btnOpenPanel.Click
		If Me.rbEligiblePlayersList.Checked Then
			Me.btnOpenPanel.Enabled = False
			PCW.Data.UsesEligiblePlayers = True
			Me.stepD_DDEP.Visible = True
			Me.stepD_DDEP.Enabled = True
			Me.stepD_DDEP.BringToFront()
			Me.btnOpenPanel.Enabled = True
		End If
	End Sub
#End Region
End Class

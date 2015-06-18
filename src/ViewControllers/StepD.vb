Imports TSWizards
Imports System.ComponentModel

Imports Category = PromotionalCreationWizard _
				   .PCW_Data _
				   .PromoCategory

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
					Me.stepD_data.MuliPartDaysTiers = Me.lblNumOfDays.Text
				ElseIf Me.rbTIERS.Checked Then
					Me.stepD_data.MuliPartDaysTiers = Me.txtNumOfTiers.Text
				End If
		End Select
		Me.stepD_data.PointCutoffLimit = getPointCutoffLimit(Me.rbPointCutoffLimitYES.Checked, _
															 Me.txtPointCutoffLimit.Text)
		If Me.rbEligiblePlayersList.Checked And
			Me.successBool Then
			PCW.Data.UsesEligiblePlayers = True
			setEligiblePlayersCSV()
		End If
	End Sub

	Private Function getPointCutoffLimit(ByVal yesChecked As Boolean, _
										 ByVal txtInput As String) As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked And Not BEP_Util.invalidNum(txtInput) Then
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
		Dim local_promoID As String = New String("!")
		PCW.NextEnabled = False
		Me.UseWaitCursor = True
		Me.stepD_data.EligiblePlayersCSVFilePath = Me.lblDragOffer.Text
		local_StepB = PCW.GetStep("StepB")
		local_promoID = local_StepB.Data.ID
		Me.stepD_data.CSVtoEligiblePlayersList(local_promoID, _
											   PCW.Data.EligiblePlayerList)
		'Only Enable once sure the CSV in a DataTable
		Me.UseWaitCursor = False
		GUI_Util.NextEnabled()
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
	Private successBool As Boolean = False
	Private txtTierBool As Boolean = False

	Private Sub StepD_Load(sender As Object, _
						   e As EventArgs) _
		Handles MyBase.Load
		m_DelegateChangeLabelText = New DelegateChangeLabelText(AddressOf ChangeLabelText)
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
		Me.rbSingleEntryPayout.Checked = True
		Me.txtNumOfTiers.Text = BEP_Util.TiersStr
		Me.rbSumQualifyingPoints.Checked = True
		Me.rbPointCutoffLimitNO.Checked = True
		Me.txtPointCutoffLimit.Text = BEP_Util.NumStr
		Me.pnlPayoutParameters.Enabled = False
		Me.cbPayoutParametersYES.Checked = False
		GUI_Util.regPnl(Me.pnlPointCutoffLimit, Color.PapayaWhip)
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
	Private Sub StepD_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		Me.StepD_SetData()
		Me.Data.CheckForReset()

		If Me.Data.Category = Category.multiPart And
			Not BEP_Util.invalidNum(Me.Data.MuliPartDaysTiers) Then
			cancelContinuingToNextStep = True
			errString = "MutiPart Days/Tiers Invalid Number."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPromoType)
			Me.ActiveControl = Me.txtNumOfTiers
		Else
			GUI_Util.regPnl(Me.pnlPromoType)
		End If

		If Me.rbPointCutoffLimitYES.Checked And
			Me.Data.PointCutoffLimit_Invalid() Then
			cancelContinuingToNextStep = True
			errString = "Point Cutoff Limit Invalid Number."
			errStrArray.Add(errString)
			GUI_Util.errPnl(Me.pnlPointCutoffLimit)
		Else
			GUI_Util.regPnl(Me.pnlPointCutoffLimit, Color.PapayaWhip)
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
		If PCW.Data.DaysBool And _
			(Not IsNothing(PCW.Data.NumOfDays)) Then
			Me.rbDAYS.Checked = True
			Me.lblNumOfDays.Text = PCW.Data.NumOfDays.ToString
		Else
			Me.lblNumOfDays.Text = BEP_Util.DaysStr
		End If
	End Sub
#End Region
#Region "StepD_SetDragDropPanel"
	Private Sub rbEligiblePlayersOfferList_CheckedChanged(sender As Object, _
														  e As EventArgs) _
		Handles rbEligiblePlayersList.CheckedChanged
		SetDragDropPanel(Me.rbEligiblePlayersList.Checked)
	End Sub

	Private Sub SetDragDropPanel(ByVal bool As Boolean)
		Me.pnlDragOffer.Enabled = bool
		Me.pnlDragOffer.Visible = bool
		If Not bool Then
			Me.SuccessIcon.Visible = bool
			ChangeLabelText("(Drag EligiblePlayers List .CSV File Here)")
		End If
	End Sub

	Private Sub pnlDragOffer_DragEnter(sender As Object, _
									   e As DragEventArgs) _
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

	Private Sub pnlDragOffer_DragDrop(sender As Object, _
									  e As DragEventArgs) _
		Handles pnlDragOffer.DragDrop
		Try
			Dim a As Array = CType(e.Data.GetData(DataFormats.FileDrop),  _
								   Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateChangeLabelText, _
							   New Object() {s})
				DragDropSuccessIcon()
				Me.successBool = True
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in DragDrop Sub: " _
							+ ex.Message)
			ChangeLabelText("FAILURE: " _
							+ ex.Message)
			DragDropFailureIcon()
			Me.successBool = False
		End Try
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
			Me.txtPointCutoffLimit.Text = ""
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
			If (Not Me.rbDAYS.Checked) And _
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
		If Me.rbDAYS.Checked Then
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
			Me.cbPayoutParametersYES.Checked = True
			Me.rbTIERS.ForeColor = SystemColors.ControlText
			Me.txtNumOfTiers.ForeColor = SystemColors.ControlText
			Me.txtNumOfTiers.Enabled = True
		Else
			Me.cbPayoutParametersYES.Checked = False
			Me.rbTIERS.ForeColor = SystemColors.ControlDark
			Me.txtNumOfTiers.ForeColor = SystemColors.ControlDark
			Me.txtNumOfTiers.Enabled = False
			Me.txtNumOfTiers.Text = BEP_Util.TiersStr
		End If
	End Sub
#End Region
#Region "StepD_txtNumOfTiers_Enter_Leave"
	Private Sub txtNumOfTiers_Enter(sender As Object, _
									e As EventArgs) _
		Handles txtNumOfTiers.Enter
		Me.txtTierBool = True
		Me.txtNumOfTiers.Text = ""
		Me.ActiveControl = Me.txtNumOfTiers
	End Sub
	Private Sub txtNumOfTiers_Leave(sender As Object, _
									e As EventArgs) _
		Handles txtNumOfTiers.Leave
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepD_cbPayoutParametersYES_CheckedChanged"
	Private Sub cbPayoutParametersYES_CheckedChanged(sender As Object, _
													 e As EventArgs) _
		Handles cbPayoutParametersYES.CheckedChanged
		If Me.cbPayoutParametersYES.Checked Then
			Me.cbPayoutParametersYES.ForeColor = SystemColors.ControlText
			If Me.rbDAYS.Checked Then
				GUI_Util.msgBox("Typically a 'Muti-Part of Days' uses " &
								"the same Payout parameters for each day", _
								"ARE YOU SURE?")
			End If
		Else
			Me.cbPayoutParametersYES.ForeColor = SystemColors.ControlDark
			If Me.rbTIERS.Checked Then
				GUI_Util.msgBox("Typically a 'Muti-Part of Tiers' uses " &
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
		If Not Char.IsDigit(e.KeyChar) And
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepD_btnSetNumOfTiers_Click"
	Private Sub btnSetNumOfTiers_Click(sender As Object, _
									   e As EventArgs) _
		Handles btnSetNumOfTiers.Click
		btnSet(Me.txtTierBool)
	End Sub
	Private Sub btnSet(ByVal enteredBool As Boolean)
		If enteredBool Then
			Me.ActiveControl = Me.pnlDaysTiers
		End If
	End Sub
#End Region
End Class

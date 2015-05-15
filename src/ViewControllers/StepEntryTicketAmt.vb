Imports TSWizards

Public Class StepEntryTicketAmt
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepEntryTicketAmt_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepEntryTicketAmt_data = New StepEntryTicketAmt_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepEntryTicketAmt_PromoData"
	Public ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepEntryTicketAmt_data
		End Get
	End Property
#End Region
#Region "StepEntryTicketAmt_Data"
	''' <summary>
	''' Model for StepEntryTicketAmt.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepEntryTicketAmt_data As StepEntryTicketAmt_Data
	Public ReadOnly Property Data() As StepEntryTicketAmt_Data
		Get
			Return Me.stepEntryTicketAmt_data
		End Get
	End Property
#End Region
#Region "StepEntryTicketAmt_SetData"
	''' <summary>
	''' Sets the data from StepEntryTicketAmt_Data.
	''' </summary>
	''' <remarks>Complexity meets delegation.</remarks>
	Private Sub StepEntryTicketAmt_SetData()
		Me.stepEntryTicketAmt_data.TicketAmtCategory = getTicketAmtCategory()
		Me.stepEntryTicketAmt_data.PointsDivisor = getPointsDivisor(Me.Data.TicketAmtCategory)
		Me.stepEntryTicketAmt_data.TicketsPerPatron = getTicketsLimit(Me.rbTicketPerPatronYES.Checked, _
																	  Me.txtTicketsPerPatron.Text)
		Me.stepEntryTicketAmt_data.TicketsForEntirePromo = getTicketsLimit(Me.rbTicketsEntirePromoYES.Checked, _
																		   Me.txtTicketsEntirePromo.Text)
		Me.stepEntryTicketAmt_data.PrintTickets = True
		Me.stepEntryTicketAmt_data.PromoType = getPromoType()
	End Sub

	''' <summary>
	''' Grabs the PromoType from the TextBox control.
	''' </summary>
	''' <returns>Me.txtPromoType.Text</returns>
	''' <remarks>This is simple.</remarks>
	Private Function getPromoType() As String
		Dim result As String = New String("!")
		result = Me.txtPromoType.Text
		Return result
	End Function

	''' <summary>
	''' Used to get TicketsPerPatron and TicketsForEntirePromo.
	''' </summary>
	''' <param name="yesChecked">"YES" RadioButton.Checked</param>
	''' <param name="txtInput">Input of TextBox.</param>
	''' <returns>Ticket Limit.</returns>
	''' <remarks>Remember, kids: Keep code DRY!</remarks>
	Private Function getTicketsLimit(ByVal yesChecked As Boolean, ByVal txtInput As String) As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked And Not BEP_Util.invalidNum(txtInput) Then
			result = Short.Parse(txtInput)
		End If
		Return result
	End Function

	''' <summary>
	''' If (Cal Or Cal+#ofVisits) And (Not invalidNum), get Points Divisor from TextBox.
	''' </summary>
	''' <param name="local_ticketAmtCategory">TicketAmtCategory.</param>
	''' <returns>Get me Points Divisor Or Nothing!</returns>
	''' <remarks>This is sloppy; needs refactoring.</remarks>
	Private Function getPointsDivisor(ByVal local_ticketAmtCategory As StepEntryTicketAmt_Data.PromoTicketAmtCategory) As System.Nullable(Of Short)
		Dim pointsDivisor As System.Nullable(Of Short) = Nothing
		Dim pointsDivisorStr As String = Me.txtPointsDivisor.Text
		If ((local_ticketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calculated) Or
			(local_ticketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calPlusNumOfVisits)) And
			(Not BEP_Util.invalidNum(pointsDivisorStr)) Then
			pointsDivisor = Short.Parse(pointsDivisorStr)
		End If
		Return pointsDivisor
	End Function

	''' <summary>
	''' Finds the Checked RadioButton to determine TicketAmtCategory.
	''' </summary>
	''' <returns>TicketAmtCategory.</returns>
	''' <remarks>At this point, I'm beginning to question myself.</remarks>
	Private Function getTicketAmtCategory() As StepEntryTicketAmt_Data.PromoTicketAmtCategory
		Dim promoTicketAmtCategory As StepEntryTicketAmt_Data.PromoTicketAmtCategory = New StepEntryTicketAmt_Data.PromoTicketAmtCategory
		If Me.rbCalPlusNumOfVisits.Checked Then
			promoTicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calPlusNumOfVisits
		ElseIf Me.rbCalculated.Checked Then
			promoTicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calculated
		ElseIf Me.rbNumOfVisits.Checked Then
			promoTicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.numOfVisits
		Else
			promoTicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.one
		End If
		Return promoTicketAmtCategory
	End Function
#End Region
#Region "StepEntryTicketAmt_Load"
	Dim defaultStr As String
	Dim oneStr As String
	Dim numOfVisitsStr As String
	Dim calStr As String
	Dim calPlusNumOfVisitsStr As String
	Dim setAmtStr As String
	Private promoTypeEntered As Boolean

	Private Sub StepEntryTicketAmt_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		defaultStr = New String("Move mouse pointer over amount for description.")
		oneStr = New String("One: a single entry ticket.")
		numOfVisitsStr = New String("Counts the number of visits within the qualifying period " &
									"in which the account earned points. The counted number " &
									"is the amount of entry tickets.")
		calStr = New String("Sums points accured within the qualifying period, " &
							"divides the total by the points divisor.")
		calPlusNumOfVisitsStr = New String("Sums points accured within the qualifying period, " &
										   "divides the total by the points divisor, " &
										   "then adds the result to a count of visits.")
		setAmtStr = New String("A static, set amount of tickets; " &
							   "enter the amount into the box below.")
		promoTypeEntered = False
	End Sub
#End Region
#Region "StepEntryTicketAmt_ResetStep"
	Private Sub StepEntryTicketAmt_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepEntryTicketAmt_data = New StepEntryTicketAmt_Data
		Me.promoTypeEntered = False
		StepEntryTicketAmt_ResetControls()
	End Sub

	Private Sub StepEntryTicketAmt_ResetControls()
		Me.rb1.Checked = True
		Me.rbTicketsPerPatronNO.Checked = True
		Me.txtTicketsPerPatron.Text = BEP_Util.NumStr
		Me.rbTicketsPerPatronNO.Checked = True
		Me.txtTicketsEntirePromo.Text = BEP_Util.NumStr
		Me.txtPromoType.Text = "EX: 25"
		SetPointsDivisorPnl(False)
		SetPointsDivisorTxt(False)
	End Sub
#End Region
#Region "StepEntryTicketAmt_Validation"
	''' <summary>
	''' Asks StepEntryTicketAmt_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepEntryTicketAmt_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing
		Dim errStrArray As ArrayList = New ArrayList

		Me.StepEntryTicketAmt_SetData()

		If (Me.Data.TicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calculated) Or
			(Me.Data.TicketAmtCategory = PromotionalCreationWizard.StepEntryTicketAmt_Data.PromoTicketAmtCategory.calPlusNumOfVisits) Then
			If Me.Data.PointsDivisor_Invalid() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlPointsDivisor)
				errString = "The Points Divisor is invalid."
				errStrArray.Add(errString)
				Me.txtPointsDivisor.Text = ""
				Me.ActiveControl = Me.txtPointsDivisor
			Else
				GUI_Util.regPnl(Me.pnlPointsDivisor)
			End If
		End If

		If Me.rbTicketPerPatronYES.Checked And Me.rbTicketsEntirePromoYES.Checked Then
			If Me.Data.BadTicketLimits() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlTicketPerPatron)
				GUI_Util.errPnl(Me.pnlTicketsEntirePromo)
				errString = "Tickets For Entire Promo is less than Tickets Per Patron."
				errStrArray.Add(errString)
			Else
				GUI_Util.regPnl(Me.pnlTicketPerPatron)
				GUI_Util.regPnl(Me.pnlTicketsEntirePromo)
			End If
		End If

		If Me.rbTicketPerPatronYES.Checked Then
			If Me.Data.TicketsPerPatron_Invalid() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlTicketPerPatron)
				errString = "The Limit # of Tickets per patron is invalid."
				errStrArray.Add(errString)
				Me.txtTicketsPerPatron.Text = ""
				Me.ActiveControl = Me.txtTicketsPerPatron
			Else
				GUI_Util.regPnl(Me.pnlTicketPerPatron)
			End If
		End If

		If Me.rbTicketsEntirePromoYES.Checked Then
			If Me.Data.TicketsForEntirePromo_Invalid() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlTicketsEntirePromo)
				errString = "The Limit # of Tickets for entire promo is invalid."
				errStrArray.Add(errString)
				Me.txtTicketsEntirePromo.Text = ""
				Me.ActiveControl = Me.txtTicketsEntirePromo
			Else
				GUI_Util.regPnl(Me.pnlTicketsEntirePromo)
			End If
		End If

		If Me.Data.BadPromoType() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlTicketsEntirePromo)
			errString = "The Promo Type is invalid."
			errStrArray.Add(errString)
			Me.txtPromoType.Text = ""
			Me.ActiveControl = Me.txtTicketsEntirePromo
		Else
			GUI_Util.regPnl(Me.pnlTicketsEntirePromo)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			For Each errStr As String In errStrArray
				GUI_Util.msgBox(errStr)
			Next
		Else
			'Step has been set if no error.
			Me.stepEntryTicketAmt_data.StepNotSet = False
			Me.NextStep = Me.Data.DetermineStepFlow()
			If Me.NextStep = "StepH" Then
				PCW.GetStep("StepH").PreviousStep = "StepEntryTicketAmt"
			End If
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_ShowStep"
	''' <summary>
	''' Disables the "Next>" button.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>We MUST have the PromoType, disable "Next>" until we get it.</remarks>
	Private Sub StepEntryTicketAmt_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_PointsDivisor"
	Private Sub rbCalculated_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCalculated.CheckedChanged
		SetPointsDivisorPnl(rbCalculated.Checked)
		SetPointsDivisorTxt(rbCalculated.Checked)
	End Sub

	Private Sub rbCalPlusNumOfVisits_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCalPlusNumOfVisits.CheckedChanged
		SetPointsDivisorPnl(rbCalPlusNumOfVisits.Checked)
		SetPointsDivisorTxt(rbCalPlusNumOfVisits.Checked)
	End Sub

	Private Sub SetPointsDivisorPnl(ByVal bool As Boolean)
		Me.pnlPointsDivisor.Enabled = bool
		Me.pnlPointsDivisor.Visible = bool
	End Sub

	Private Sub SetPointsDivisorTxt(ByVal bool As Boolean)
		If bool Then
			PCW.NextEnabled = False
			Me.txtPointsDivisor.Text = ""
			Me.ActiveControl = Me.txtPointsDivisor
		Else
			GUI_Util.NextEnabled()
			Me.txtPointsDivisor.Text = BEP_Util.NumStr
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbTicketsPerPatronNO_CheckedChanged"
	''' <summary>
	''' Yes/No pair of RadioButtons for "Limit # of tickets per patron?"
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub rbTicketsPerPatronNO_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbTicketsPerPatronNO.CheckedChanged
		If Not Me.rbTicketsPerPatronNO.Checked Then
			Me.txtTicketsPerPatron.Enabled = True
			Me.txtTicketsPerPatron.Text = ""
			Me.ActiveControl = Me.txtTicketsPerPatron
			PCW.NextEnabled = False
		Else
			GUI_Util.NextEnabled()
			Me.txtTicketsPerPatron.Enabled = False
			Me.txtTicketsPerPatron.Text = BEP_Util.NumStr
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbTicketsEntirePromoNO_CheckedChanged"
	''' <summary>
	''' Yes/No pair of RadioButtons for "Limit # of tickets for entire promo?"
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub rbTicketsEntirePromoNO_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbTicketsEntirePromoNO.CheckedChanged
		If Not Me.rbTicketsEntirePromoNO.Checked Then
			Me.txtTicketsEntirePromo.Enabled = True
			Me.txtTicketsEntirePromo.Text = ""
			Me.ActiveControl = Me.txtTicketsEntirePromo
			PCW.NextEnabled = False
		Else
			GUI_Util.NextEnabled()
			Me.txtTicketsEntirePromo.Enabled = False
			Me.txtTicketsEntirePromo.Text = BEP_Util.NumStr
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsPerPatron_Leave"
	Private Sub txtTicketsPerPatron_Leave(sender As Object, e As EventArgs) _
		Handles txtTicketsPerPatron.Leave
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsEntirePromo_Leave"
	Private Sub txtTicketsEntirePromo_Leave(sender As Object, e As EventArgs) _
		Handles txtTicketsEntirePromo.Leave
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPointsDivisor_Leave"
	Private Sub txtPointsDivisor_Leave(sender As Object, e As EventArgs) _
		Handles txtPointsDivisor.Leave
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPromoType_Enter"
	Private Sub txtPromoType_Enter(sender As Object, e As EventArgs) _
		Handles txtPromoType.Enter
		If Me.promoTypeEntered = False Then
			Me.txtPromoType.Text = ""
			Me.promoTypeEntered = True
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPromoType_Leave"
	Private Sub txtPromoType_Leave(sender As Object, e As EventArgs) _
		Handles txtPromoType.Leave
		CheckForNext()
	End Sub

	Private Sub CheckForNext()
		If Me.promoTypeEntered Then
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "_MOUSE_ENTER_LEAVE_"
#If False Then 'VB.NET Multi-Line Comment For The Win!
ASIDE: ToolTips are horrid!
Because of this, MouseEnter and MouseLeave have been
used as UI/UX flair for ticket amount descriptions.
#End If
#Region "StepEntryTicketAmt_rb1_Mouse"
	Private Sub rb1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rb1.MouseEnter
		Me.lblDescription.Text = Me.oneStr
	End Sub
	Private Sub rb1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rb1.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbNumOfVisits_Mouse"
	Private Sub rbNumOfVisits_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.numOfVisitsStr
	End Sub
	Private Sub rbNumOfVisits_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalculated_Mouse"
	Private Sub rbCalculated_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalculated.MouseEnter
		Me.lblDescription.Text = Me.calStr
	End Sub
	Private Sub rbCalculated_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalculated.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalPlusNumOfVisits_Mouse"
	Private Sub rbCalPlusNumOfVisits_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.calPlusNumOfVisitsStr
	End Sub
	Private Sub rbCalPlusNumOfVisits_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbSetAmt_Mouse"
	Private Sub rbSetAmt_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)

		Me.lblDescription.Text = Me.setAmtStr
	End Sub
	Private Sub rbSetAmt_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)

		Me.lblDescription.Text = Me.defaultStr
	End Sub
#End Region
#End Region
#Region "_TEXTBOX_KEYPRESS_"
#If False Then
ASIDE: Limits the textboxes to only allow numeric input.
A user is able to paste non-numeric input into the textbox.
Each TextBox is validated for invalid (non-numeric) characters.
#End If
#Region "StepEntryTicketAmt_txtPointsDivisor_KeyPress"
	Private Sub txtPointsDivisor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
	Handles txtPointsDivisor.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsPerPatron_KeyPress"
	Private Sub txtTicketsPerPatron_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
	Handles txtTicketsPerPatron.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsEntirePromo_KeyPress"
	Private Sub txtTicketsEntirePromo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
	Handles txtTicketsEntirePromo.KeyPress
		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#End Region
End Class

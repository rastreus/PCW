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
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Category = PromotionalCreationWizard _
				   .StepEntryTicketAmt_Data _
				   .PromoTicketAmtCategory

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
		Me.stepEntryTicketAmt_data.TicketAmtCategory = _
			getTicketAmtCategory()
		Me.stepEntryTicketAmt_data.PointsDivisor = _
			getPointsDivisor(Me.Data.TicketAmtCategory)
		Me.stepEntryTicketAmt_data.TicketsPerPatron = _
			getTicketsLimit(Me.rbTicketPerPatronYES.Checked, _
							Me.txtTicketsPerPatron.Text)
		Me.stepEntryTicketAmt_data.TicketsForEntirePromo = _
			getTicketsLimit(Me.rbTicketsEntirePromoYES.Checked, _
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
		Dim result As String = New String(String.Empty)
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
	Private Function getTicketsLimit(ByVal yesChecked As Boolean, _
									 ByVal txtInput As String) _
									 As System.Nullable(Of Short)
		Dim result As System.Nullable(Of Short) = Nothing
		If yesChecked AndAlso _
			(Not BEP_Util.invalidNum(txtInput)) Then
			result = Short.Parse(txtInput)
		End If
		Return result
	End Function

	''' <summary>
	''' If (Cal Or Cal+#ofVisits) And (Not invalidNum),
	''' get Points Divisor from TextBox.
	''' </summary>
	''' <param name="local_ticketAmtCategory">TicketAmtCategory.</param>
	''' <returns>Get me Points Divisor Or Nothing!</returns>
	''' <remarks>This is sloppy; needs refactoring.</remarks>
	Private Function getPointsDivisor(ByVal _ticketAmtCategory As Category) _
									  As System.Nullable(Of Short)
		Dim pointsDivisor As System.Nullable(Of Short) = Nothing
		Dim pointsDivisorStr As String = Me.txtPointsDivisor.Text
		If ((_ticketAmtCategory = Category.calculated) Or
			(_ticketAmtCategory = Category.calPlusNumOfVisits)) AndAlso
			(Not BEP_Util.invalidNum(pointsDivisorStr)) Then
			pointsDivisor = Short.Parse(pointsDivisorStr)
		End If
		Return pointsDivisor
	End Function

	''' <summary>
	''' Finds the Checked RadioButton to determine TicketAmtCategory.
	''' </summary>
	''' <returns>TicketAmtCategory.</returns>
	''' <remarks>At this point,
	''' I'm beginning to question myself.</remarks>
	Private Function getTicketAmtCategory() As Category
		Dim promoTicketAmtCategory As Category = New Category
		If Me.rbCalPlusNumOfVisits.Checked Then
			promoTicketAmtCategory = Category.calPlusNumOfVisits
		ElseIf Me.rbCalculated.Checked Then
			promoTicketAmtCategory = Category.calculated
		ElseIf Me.rbNumOfVisits.Checked Then
			promoTicketAmtCategory = Category.numOfVisits
		Else
			promoTicketAmtCategory = Category.one
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

	Private Sub StepEntryTicketAmt_Load(sender As Object, _
										e As EventArgs) _
		Handles MyBase.Load
		defaultStr = New String("Move mouse pointer over " & _
								"amount for description.")
		oneStr = New String("One: a single entry ticket.")
		numOfVisitsStr = New String("Counts the number of visits within " & _
									"the qualifying period " & _
									"in which the account earned points. " & _
									"The counted number " & _
									"is the amount of entry tickets.")
		calStr = New String("Sums points accured within " & _
							"the qualifying period, " & _
							"divides the total by the points divisor.")
		calPlusNumOfVisitsStr = New String("Sums points accured within " & _
										   "the qualifying period, " & _
										   "divides the total by the " & _
										   "points divisor, " & _
										   "then adds the result to a " & _
										   "count of visits.")
		setAmtStr = New String("A static, set amount of tickets; " & _
							   "enter the amount into the box below.")
		promoTypeEntered = False
	End Sub
#End Region
#Region "StepEntryTicketAmt_ResetStep"
	Private Sub StepEntryTicketAmt_ResetStep(sender As Object, _
											 e As EventArgs) _
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
		Me.txtPromoType.Text = "EX:25"
		Me.btnSetPromoType.BackColor = Color.Gainsboro
		Me.btnSetPromoType.Enabled = False
		Me.btnSetTicketsPerPatron.BackColor = Color.Gainsboro
		Me.btnSetTicketsPerPatron.Enabled = False
		Me.btnSetTicketsEntirePromo.BackColor = Color.Gainsboro
		Me.btnSetTicketsEntirePromo.Enabled = False
		Me.pnlAmtDescription.Enabled = True
		Me.pnlAmtDescription.Visible = True
		Me.pnlTicketsAmount.Enabled = True
		Me.pnlTicketsAmount.Visible = True
		Me.pnlInfoNotNeeded.Visible = False
		Me.pnlInfoNotNeeded.Location = New Point(114, 341)
		SetPointsDivisorPnl(False)
		SetPointsDivisorTxt(False)
	End Sub
#End Region
#Region "StepEntryTicketAmt_Validation"
	''' <summary>
	''' Asks StepEntryTicketAmt_Data to validate data
	''' and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when
	''' user presses the "Next> Button."</remarks>
	Private Sub StepEntryTicketAmt_Validation(sender As Object, _
											  e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)
		Dim errStrArray As ArrayList = New ArrayList

		Me.StepEntryTicketAmt_SetData()

		If (Me.Data.TicketAmtCategory = Category.calculated) OrElse _
			(Me.Data.TicketAmtCategory = Category.calPlusNumOfVisits) Then
			If Me.Data.PointsDivisor_Invalid() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlPointsDivisor)
				errString = "The Points Divisor is invalid."
				errStrArray.Add(errString)
				Me.txtPointsDivisor.Text = String.Empty
				Me.ActiveControl = Me.txtPointsDivisor
			Else
				GUI_Util.regPnl(Me.pnlPointsDivisor)
			End If
		End If

		If Me.rbTicketPerPatronYES.Checked AndAlso _
			Me.rbTicketsEntirePromoYES.Checked Then
			If Me.Data.BadTicketLimits() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlTicketPerPatron)
				GUI_Util.errPnl(Me.pnlTicketsEntirePromo)
				errString = "Tickets For Entire Promo is " & _
							"less than Tickets Per Patron."
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
				errString = "The Limit # of Tickets " & _
							"per patron is invalid."
				errStrArray.Add(errString)
				Me.txtTicketsPerPatron.Text = String.Empty
				Me.ActiveControl = Me.txtTicketsPerPatron
			Else
				GUI_Util.regPnl(Me.pnlTicketPerPatron)
			End If
		End If

		If Me.rbTicketsEntirePromoYES.Checked Then
			If Me.Data.TicketsForEntirePromo_Invalid() Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlTicketsEntirePromo)
				errString = "The Limit # of Tickets for " & _
							"entire promo is invalid."
				errStrArray.Add(errString)
				Me.txtTicketsEntirePromo.Text = String.Empty
				Me.ActiveControl = Me.txtTicketsEntirePromo
			Else
				GUI_Util.regPnl(Me.pnlTicketsEntirePromo)
			End If
		End If

		If Me.Data.BadPromoType() Then
			cancelContinuingToNextStep = True
			GUI_Util.errPnl(Me.pnlPromoTypeForEntry)
			errString = "The Promo Type is invalid."
			errStrArray.Add(errString)
			Me.txtPromoType.Text = String.Empty
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
	''' <remarks>We MUST have the PromoType,
	''' disable "Next>" until we get it.</remarks>
	Private Sub StepEntryTicketAmt_ShowStep(sender As Object, _
											e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_PointsDivisor"
	Private Sub rbCalculated_CheckedChanged(sender As Object, _
											e As EventArgs) _
		Handles rbCalculated.CheckedChanged
		SetPointsDivisorPnl(rbCalculated.Checked)
		SetPointsDivisorTxt(rbCalculated.Checked)
	End Sub

	Private Sub rbCalPlusNumOfVisits_CheckedChanged(sender As Object, _
													e As EventArgs) _
		Handles rbCalPlusNumOfVisits.CheckedChanged
		SetPointsDivisorPnl(rbCalPlusNumOfVisits.Checked)
		SetPointsDivisorTxt(rbCalPlusNumOfVisits.Checked)
	End Sub

	Private Sub SetPointsDivisorPnl(ByVal bool As Boolean)
		Me.pnlPointsDivisor.Enabled = bool
		Me.pnlPointsDivisor.Visible = bool
		Me.btnSetPointsDivisor.Enabled = bool
		If bool = True Then
			Me.btnSetPointsDivisor.BackColor = Color.HotPink
		Else
			Me.btnSetPointsDivisor.BackColor = Color.Gainsboro
		End If
	End Sub

	Private Sub SetPointsDivisorTxt(ByVal bool As Boolean)
		If bool Then
			PCW.NextEnabled = False
			Me.txtPointsDivisor.Text = String.Empty
			Me.ActiveControl = Me.txtPointsDivisor
		Else
			GUI_Util.NextEnabled()
			Me.txtPointsDivisor.Text = BEP_Util.NumStr
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbTicketsPerPatronNO_CheckedChanged"
	''' <summary>
	''' Yes/No pair of RadioButtons for
	''' "Limit # of tickets per patron?"
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub rbTicketsPerPatronNO_CheckedChanged(sender As Object, _
													e As EventArgs) _
		Handles rbTicketsPerPatronNO.CheckedChanged
		If Me.rbTicketPerPatronYES.Checked Then
			Me.txtTicketsPerPatron.Enabled = True
			Me.txtTicketsPerPatron.Text = String.Empty
			Me.ActiveControl = Me.txtTicketsPerPatron
			PCW.NextEnabled = False
		Else
			GUI_Util.NextEnabled()
			Me.txtTicketsPerPatron.Enabled = False
			Me.txtTicketsPerPatron.Text = BEP_Util.NumStr
			Me.btnSetTicketsPerPatron.BackColor = Color.Gainsboro
			Me.btnSetTicketsPerPatron.Enabled = False
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbTicketsEntirePromoNO_CheckedChanged"
	''' <summary>
	''' Yes/No pair of RadioButtons for
	''' "Limit # of tickets for entire promo?"
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub rbTicketsEntirePromoNO_CheckedChanged(sender As Object, _
													  e As EventArgs) _
		Handles rbTicketsEntirePromoNO.CheckedChanged
		If Me.rbTicketsEntirePromoYES.Checked Then
			Me.txtTicketsEntirePromo.Enabled = True
			Me.txtTicketsEntirePromo.Text = String.Empty
			Me.ActiveControl = Me.txtTicketsEntirePromo
			PCW.NextEnabled = False
		Else
			GUI_Util.NextEnabled()
			Me.txtTicketsEntirePromo.Enabled = False
			Me.txtTicketsEntirePromo.Text = BEP_Util.NumStr
			Me.btnSetTicketsEntirePromo.BackColor = Color.Gainsboro
			Me.btnSetTicketsEntirePromo.Enabled = False
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsPerPatron_Enter"
	Private Sub txtTicketsPerPatron_Enter(sender As Object, _
										  e As EventArgs) _
		Handles txtTicketsPerPatron.Enter
		GUI_Util.offIcon(Me.TicketsPerPatronSuccessIcon)
		Me.btnSetTicketsPerPatron.BackColor = Color.HotPink
		Me.btnSetTicketsPerPatron.Enabled = True
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsEntirePromo_Enter"
	Private Sub txtTicketsEntirePromo_Enter(sender As Object, _
											e As EventArgs) _
		Handles txtTicketsEntirePromo.Enter
		GUI_Util.offIcon(Me.TicketsEntirePromoSuccessIcon)
		Me.btnSetTicketsEntirePromo.BackColor = Color.HotPink
		Me.btnSetTicketsEntirePromo.Enabled = True
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsPerPatron_Leave"
	Private Sub txtTicketsPerPatron_Leave(sender As Object, _
										  e As EventArgs) _
		Handles txtTicketsPerPatron.Leave
		If Not Me.txtTicketsPerPatron.Text = String.Empty Then
			GUI_Util.onIcon(Me.TicketsPerPatronSuccessIcon)
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsEntirePromo_Leave"
	Private Sub txtTicketsEntirePromo_Leave(sender As Object, _
											e As EventArgs) _
		Handles txtTicketsEntirePromo.Leave
		GUI_Util.onIcon(Me.TicketsEntirePromoSuccessIcon)
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPointsDivisor_Enter"
	Private Sub txtPointsDivisor_Enter(sender As Object, _
									   e As EventArgs) _
		Handles txtPointsDivisor.Enter
		GUI_Util.offIcon(Me.PointsDivisorSuccessIcon)
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPointsDivisor_Leave"
	Private Sub txtPointsDivisor_Leave(sender As Object, _
									   e As EventArgs) _
		Handles txtPointsDivisor.Leave
		If (Me.rbCalculated.Checked OrElse _
			Me.rbCalPlusNumOfVisits.Checked) AndAlso _
			(Not Me.txtPointsDivisor.Text = String.Empty) Then
			GUI_Util.onIcon(Me.PointsDivisorSuccessIcon)
			GUI_Util.NextEnabled()
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPromoType_Enter"
	Private Sub txtPromoType_Enter(sender As Object, _
								   e As EventArgs) _
		Handles txtPromoType.Enter
		GUI_Util.offIcon(Me.PromoTypeSuccessIcon)
		If Me.promoTypeEntered = False Then
			Me.txtPromoType.Text = String.Empty
			Me.promoTypeEntered = True
			Me.btnSetPromoType.Enabled = True
			Me.btnSetPromoType.BackColor = Color.HotPink
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtPromoType_Leave"
	Private Sub txtPromoType_Leave(sender As Object, _
								   e As EventArgs) _
		Handles txtPromoType.Leave
		GUI_Util.onIcon(Me.PromoTypeSuccessIcon)
		CheckForNext()
		CheckFor20B()
	End Sub

	Private Sub CheckForNext()
		If Me.promoTypeEntered Then
			GUI_Util.NextEnabled()
		End If
	End Sub

	Private Sub CheckFor20B()
		If Me.txtPromoType.Text = "20B" OrElse _
			Me.txtPromoType.Text = "20b" Then
			Me.rbTicketPerPatronYES.Checked = True
			Me.rbTicketsPerPatronNO.Enabled = False
			Me.pnlAmtDescription.Enabled = False
			Me.pnlAmtDescription.Visible = False
			Me.pnlTicketsAmount.Enabled = False
			Me.pnlTicketsAmount.Visible = False
			Me.pnlInfoNotNeeded.Location = New Point(114, 15)
			Me.pnlInfoNotNeeded.BringToFront()
			Me.pnlInfoNotNeeded.Visible = True
		Else
			Me.rbTicketsPerPatronNO.Checked = True
			Me.rbTicketsPerPatronNO.Enabled = True
			Me.pnlAmtDescription.Enabled = True
			Me.pnlAmtDescription.Visible = True
			Me.pnlTicketsAmount.Enabled = True
			Me.pnlTicketsAmount.Visible = True
			Me.pnlInfoNotNeeded.Location = New Point(114, 341)
			Me.pnlInfoNotNeeded.SendToBack()
			Me.pnlInfoNotNeeded.Visible = False
			GUI_Util.offIcon(Me.TicketsPerPatronSuccessIcon)
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
	Private Sub rb1_MouseEnter(ByVal sender As Object, _
							   ByVal e As EventArgs) _
		Handles rb1.MouseEnter
		Me.lblDescription.Text = Me.oneStr
		Me.rb1.BackColor = Color.Yellow
	End Sub
	Private Sub rb1_MouseLeave(ByVal sender As Object, _
							   ByVal e As EventArgs) _
		Handles rb1.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
		Me.rb1.BackColor = Color.Aquamarine
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbNumOfVisits_Mouse"
	Private Sub rbNumOfVisits_MouseEnter(ByVal sender As Object, _
										 ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.numOfVisitsStr
		Me.rbNumOfVisits.BackColor = Color.Yellow
	End Sub
	Private Sub rbNumOfVisits_MouseLeave(ByVal sender As Object, _
										 ByVal e As EventArgs) _
	Handles rbNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
		Me.rbNumOfVisits.BackColor = Color.PaleTurquoise
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalculated_Mouse"
	Private Sub rbCalculated_MouseEnter(ByVal sender As Object, _
										ByVal e As EventArgs) _
		Handles rbCalculated.MouseEnter
		Me.lblDescription.Text = Me.calStr
		Me.rbCalculated.BackColor = Color.Yellow
	End Sub
	Private Sub rbCalculated_MouseLeave(ByVal sender As Object, _
										ByVal e As EventArgs) _
		Handles rbCalculated.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
		Me.rbCalculated.BackColor = Color.PaleTurquoise
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbCalPlusNumOfVisits_Mouse"
	Private Sub rbCalPlusNumOfVisits_MouseEnter(ByVal sender As Object, _
												ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseEnter
		Me.lblDescription.Text = Me.calPlusNumOfVisitsStr
		Me.rbCalPlusNumOfVisits.BackColor = Color.Yellow
	End Sub
	Private Sub rbCalPlusNumOfVisits_MouseLeave(ByVal sender As Object, _
												ByVal e As EventArgs) _
		Handles rbCalPlusNumOfVisits.MouseLeave
		Me.lblDescription.Text = Me.defaultStr
		Me.rbCalPlusNumOfVisits.BackColor = Color.PaleTurquoise
	End Sub
#End Region
#Region "StepEntryTicketAmt_rbSetAmt_Mouse"
	''DOESN'T EXIST ANYMORE'
	'Private Sub rbSetAmt_MouseEnter(ByVal sender As Object, _
	'								ByVal e As EventArgs)
	'	Me.lblDescription.Text = Me.setAmtStr
	'End Sub
	'Private Sub rbSetAmt_MouseLeave(ByVal sender As Object, _
	'								ByVal e As EventArgs)
	'	Me.lblDescription.Text = Me.defaultStr
	'End Sub
#End Region
#End Region
#Region "_TEXTBOX_KEYPRESS_"
#If False Then
ASIDE: Limits the textboxes to only allow numeric input.
A user is able to paste non-numeric input into the textbox.
Each TextBox is validated for invalid (non-numeric) characters.
#End If
#Region "StepEntryTicketAmt_txtPointsDivisor_KeyPress"
	Private Sub txtPointsDivisor_KeyPress(sender As Object, _
										  e As KeyPressEventArgs) _
		Handles txtPointsDivisor.KeyPress
		If Not Char.IsDigit(e.KeyChar) And _
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsPerPatron_KeyPress"
	Private Sub txtTicketsPerPatron_KeyPress(sender As Object, _
											 e As KeyPressEventArgs) _
		Handles txtTicketsPerPatron.KeyPress
		If Not Char.IsDigit(e.KeyChar) And _
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#Region "StepEntryTicketAmt_txtTicketsEntirePromo_KeyPress"
	Private Sub txtTicketsEntirePromo_KeyPress(sender As Object, _
											   e As KeyPressEventArgs) _
		Handles txtTicketsEntirePromo.KeyPress
		If Not Char.IsDigit(e.KeyChar) And _
			Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If
	End Sub
#End Region
#End Region
#Region "_SET_BTN_"
	Private Sub btnSetTicketsPerPatron_Click(sender As Object, _
										 e As EventArgs) _
	Handles btnSetTicketsPerPatron.Click
		Me.ActiveControl = Me.pnlTicketPerPatron
	End Sub
	Private Sub btnSetTicketsEntirePromo_Click(sender As Object, _
											   e As EventArgs) _
		Handles btnSetTicketsEntirePromo.Click
		Me.ActiveControl = Me.pnlTicketsEntirePromo
	End Sub
	Private Sub btnSetPointsDivisor_Click(sender As Object, _
										  e As EventArgs) _
		Handles btnSetPointsDivisor.Click
		Me.ActiveControl = Me.pnlPointsDivisor
	End Sub

	Private Sub btnSetPromoType_Click(sender As Object, _
									  e As EventArgs) _
		Handles btnSetPromoType.Click
		Me.ActiveControl = Me.pnlPromoTypeForEntry
	End Sub
#End Region
End Class

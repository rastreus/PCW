Imports TSWizards
Imports System.ComponentModel

Public Class StepGetCouponOffers
	Inherits TSWizards.BaseInteriorStep

#Region "StepGetCouponOffers_Const"
	Private Const CB_NAME As String = "CouponNumber: "
	Private Const CB_SPACE As Integer = 20
	Private Const NUM_OF_CB As Integer = 7
	Private Const START_LFT As Integer = 5
	Private Const START_LOC As Integer = 2
	Private HLT_FORE As Color = Color.Black
	Private HLT_BACK As Color = Color.Yellow
	Private REG_FORE As Color = Color.White
	Private REG_BACK As Color = Color.Transparent
	Private ALL_SLCT As Boolean = False
#End Region
#Region "StepGetCouponOffers_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepGetCouponOffers_data = New StepGetCouponOffers_Data
	End Sub
#End Region
#Region "StepGetCouponOffers_Data"
	''' <summary>
	''' Model for StepStepGetCouponOffers.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepGetCouponOffers_data As StepGetCouponOffers_Data
	Public ReadOnly Property Data() As StepGetCouponOffers_Data
		Get
			Return Me.stepGetCouponOffers_data
		End Get
	End Property
#End Region
#Region "StepGetCouponOffers_GetData"
	Private Function StepGetCouponOffers_GetData() As CouponOffer
		Dim couponOffer As CouponOffer = New CouponOffer
		couponOffer.OfferID = getOfferID()
		couponOffer.CouponNumber = _
			Me.Data.GetCouponNumber(Me.rbCouponWildcardYES.Checked)
		couponOffer.ValidStart = getValidStart()
		couponOffer.ValidEnd = getValidEnd()
		couponOffer.ExcludeDays = getExcludeDays()
		couponOffer.ExcludeStart = getExcludeStart()
		couponOffer.ExcludeEnd = getExcludeEnd()
		couponOffer.FullValidate = getFullValidate()
		couponOffer.Reprintable = getReprintable()
		couponOffer.ScanToReceipt = getScanToReceipt()
		couponOffer.Note = getNote()
		Return couponOffer
	End Function

	Private Function getOfferID() As String
		Dim local_stepGeneratePayoutCoupon As StepGeneratePayoutCoupon = _
			PCW.GetStep("StepGeneratePayoutCoupon")
		Return local_stepGeneratePayoutCoupon.Data.CouponID
	End Function

	Private Function getValidStart() As Date
		Return Me.dtpValidStart.Value.Date
	End Function

	Private Function getValidEnd() As Date
		Return Me.dtpValidEnd.Value.Date
	End Function

	Private Function getExcludeDays() As String
		Dim result As String = If(Me.rbExcludeDaysYES.Checked, _
								  buildExclueDaysString(),
								  Nothing)
		Return result
	End Function

	Private Function buildExclueDaysString() As String
		Dim days As String = New String(String.Empty)
		For Each item In Me.clbExcludeDays.CheckedItems
			days = days & BEP_Util.daysFormat(item.ToString)
		Next
		Return days
	End Function

	Private Function getExcludeStart() As Date?
		Dim result As System.Nullable(Of Date) = Nothing
		If Me.rbExcludeDaysYES.Checked Then
			result = Me.dtpExcludeStart.Value.Date
		End If
		Return result
	End Function

	Private Function getExcludeEnd() As Date?
		Dim result As System.Nullable(Of Date) = Nothing
		If Me.rbExcludeDaysYES.Checked Then
			result = Me.dtpExcludeEnd.Value.Date
		End If
		Return result
	End Function

	Private Function getFullValidate() As Boolean
		Return Me.rbFullValidateYES.Checked
	End Function

	Private Function getReprintable() As Boolean
		Return Me.rbReprintableYES.Checked
	End Function

	Private Function getScanToReceipt() As Boolean
		Return Me.rbScanToReceiptYES.Checked
	End Function

	Private Function getNote() As String
		Dim result As String = New String(String.Empty)
		If Me.txtNote.Text = "EX: Small Note" Or _
			Me.txtNote.Text = String.Empty Then
			result = Nothing
		Else
			result = Me.txtNote.Text
		End If
		Return result
	End Function
#End Region
#Region "StepGetCouponOffers_Load"
	Private validStartBool As Boolean
	Private validEndBool As Boolean
	Private wildcardMsgBool As Boolean
	Private skipTargetImport As Boolean = False

	Private Sub StepGetCouponOffers_Load(sender As Object, _
										 e As EventArgs) _
		Handles MyBase.Load
		Me.validStartBool = False
		Me.validEndBool = False
		Me.wildcardMsgBool = False
	End Sub
#End Region
#Region "StepGetCouponOffers_ResetStep"
	''' <summary>
	''' Resets the Step so it can be used again.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>A lot of controls to get correct.</remarks>
	Private Sub StepGetCouponOffers_ResetStep(sender As Object, _
											  e As EventArgs) _
		Handles MyBase.ResetStep
		Me.stepGetCouponOffers_data = New StepGetCouponOffers_Data
		StepGetCouponOffers_ResetControls()
	End Sub

	''' <summary>
	''' Resets the controls (View) for the Step.
	''' </summary>
	''' <remarks></remarks>
	Private Sub StepGetCouponOffers_ResetControls()
		Me.validStartBool = False
		Me.validEndBool = False
		Me.wildcardMsgBool = False
		Me.dtpValidStart.Value = DateTime.Today
		Me.dtpValidEnd.Value = DateTime.Today
		Me.dtpExcludeStart.Value = DateTime.Today
		Me.dtpExcludeEnd.Value = DateTime.Today
		Me.rbFullValidateNO.Checked = True
		Me.rbReprintableNO.Checked = True
		Me.rbScanToReceiptNO.Checked = True
		Me.rbCouponWildcardNO.Checked = True
		Me.rbExcludeDaysNO.Checked = True
		Me.pnlExcludeRange.Enabled = False
		Me.pnlExclusionDays.Enabled = False
		Me.txtNote.Text = "EX: Note"
		Me.btnSetNote.BackColor = Color.Gainsboro
		Me.btnSetNote.Enabled = False
		Me.lblCouponOffersDirections.Enabled = True
		Me.lblCouponOffersDirections.Visible = True
		ExcludeDaysCheckState(False)
		Me.clbExcludeDays.ClearSelected()
		Me.cbSelectAllCouponOffers.Checked = False
		Me.cbSelectAllCouponOffers.Visible = False
		Me.cbSelectAllCouponOffers.Enabled = False
		Me.cbSelectAllExcludeDays.Checked = False
		disableSubmit()
		disableDelete()
	End Sub
#End Region
#Region "StepGetCouponOffers_Validation"
	''' <summary>
	''' Asks StepGetCouponOffers_Data to validate data and
	''' then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered
	''' when user presses the "Next> Button."</remarks>
	Private Sub StepGetCouponOffers_Validation(sender As Object, _
											   e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)

		If Me.Data.No_CouponOffers_Created() Then
			cancelContinuingToNextStep = True
			errString = "No Coupon Offers have been created."
			GUI_Util.errPnl(Me.pnlCouponOffers)
		Else
			GUI_Util.regPnl(Me.pnlCouponOffers)
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
		Else
			'ACTUALLY PUT COUPON OFFERS INTO PCW_DATA LIST
			Me.Data.AddCouponOffersToList()
			'Step has been set if no error.
			Me.stepGetCouponOffers_data.StepNotSet = False
			If Me.skipTargetImport Then
				Me.NextStep = "StepH"
				PCW.GetStep("StepH").PreviousStep = "StepGetCouponOffers"
			Else
				Me.NextStep = "StepGetCouponTargets"
				PCW.GetStep("StepH").PreviousStep = "StepGetCouponTargets"
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_ShowStep"
	''' <summary>
	''' Shows the Step controls.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Don't enable the "Next>" button until we're ready!</remarks>
	Private Sub StepGetCouponOffers_ShowStep(sender As Object, _
											 e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
		If Not PCW.Data.UsesCouponTargetsList Then
			Me.skipTargetImport = True
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_SelectAllExcludeDays"
	''' <summary>
	''' Checks all the Items in clbExcludeDays.
	''' </summary>
	''' <remarks></remarks>
	Private Sub ExcludeDaysCheckState(ByVal checkState As Boolean)
		For item As Integer = 0 To Me.clbExcludeDays.Items.Count - 1
			Me.clbExcludeDays.SetItemChecked(item, checkState)
		Next
	End Sub

	Private Sub cbSelectAllExcludeDays_CheckedChanged(sender As Object, _
													  e As EventArgs) _
		Handles cbSelectAllExcludeDays.CheckedChanged
		ExcludeDaysCheckState(Me.cbSelectAllExcludeDays.Checked)
	End Sub
#End Region
#Region "StepGetCouponOffers_dtpValidStart_CloseUp"
	Private Sub dtpValidStart_CloseUp(sender As Object, _
									  e As EventArgs) _
		Handles dtpValidStart.CloseUp
		'"Break the (Bool) seal!"
		If Me.validStartBool = False Then
			Me.validStartBool = True
		End If
		'Have both seals been broken?
		checkStartEndValidBools(Me.lblValidStart, _
								Me.pnlValidStart)
	End Sub
#End Region
#Region "StepGetCouponOffers_dtpValidEnd_CloseUp"
	Private Sub dtpQualifyingEnd_CloseUp(sender As Object, _
										 e As EventArgs) _
		Handles dtpValidEnd.CloseUp
		'"Break the (Bool) seal!"
		If Me.validEndBool = False Then
			Me.validEndBool = True
		End If
		'Have both seals been broken?
		checkStartEndValidBools(Me.lblValidEnd, _
								Me.pnlValidEnd)
	End Sub
#End Region
#Region "StepGetCouponOffers_checkStartEndValidBools"
	''' <summary>
	''' Sets the SelectionRange if both bools are true.
	''' </summary>
	''' <remarks>Make the MonthCal visible too!</remarks>
	Private Sub checkStartEndValidBools(ByRef lbl As Label, _
										ByRef pnl As Panel)
		If (Me.validStartBool = True AndAlso _
			Me.validEndBool = True) And _
			(Not Me.stepGetCouponOffers_data.EndDate_Before_StartDate( _
			 Me.dtpValidEnd.Value.Date, _
			 Me.dtpValidStart.Value.Date)) Then
			checkToEnableSubmit(Me.Data.CouponOffersTplList.Count)
			If GUI_Util.IsSuccess(pnl) Then
				GUI_Util.successLbl(lbl)
				GUI_Util.successPnl(pnl)
			Else
				GUI_Util.regLbl(lbl)
				GUI_Util.regPnl(pnl, Color.PaleGreen)
			End If
		Else
			GUI_Util.errLbl(lbl)
			GUI_Util.errPnl(pnl)
			GUI_Util.msgBox("EndDate Before StartDate!")
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_toggleBUTTONS"
	Private Sub checkToEnableSubmit(ByVal num As Integer)
		If (Me.btnSubmit.Enabled = False And _
			num < NUM_OF_CB) Then
			Me.btnSubmit.Enabled = True
			Me.btnSubmit.BackColor = Color.MediumPurple
			Me.btnSubmit.Text = "Submit"
		End If
	End Sub
	Private Sub enableDelete()
		Me.btnDelete.Enabled = True
		Me.btnDelete.BackColor = Color.Maroon
		Me.btnDelete.Text = "Delete"
	End Sub
	Private Sub disableSubmit()
		If Me.btnSubmit.Enabled = True Then
			Me.btnSubmit.Enabled = False
			Me.btnSubmit.BackColor = Color.Gainsboro
			Me.btnSubmit.Text = String.Empty
		End If
	End Sub
	Private Sub disableDelete()
		If Me.btnDelete.Enabled = True Then
			Me.btnDelete.Enabled = False
			Me.btnDelete.BackColor = Color.Gainsboro
			Me.btnDelete.Text = String.Empty
		End If
	End Sub
	Private Sub checkToEnableSelectAllCouponOffers()
		If Me.cbSelectAllCouponOffers.Enabled = False Then
			Me.cbSelectAllCouponOffers.Enabled = True
			Me.cbSelectAllCouponOffers.Visible = True
		End If
	End Sub
	Private Sub checkToChangeDeleteAndSelectAll(ByVal num As Integer)
		If num = 0 Then
			If Me.btnDelete.Enabled = True Then
				Me.btnDelete.Enabled = False
				Me.btnDelete.BackColor = Color.Gainsboro
				Me.btnDelete.Text = String.Empty
			End If
			If Me.cbSelectAllCouponOffers.Enabled = True Then
				Me.cbSelectAllCouponOffers.Enabled = False
				Me.cbSelectAllCouponOffers.Visible = False
				Me.cbSelectAllCouponOffers.Checked = False
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_rbExcludeDaysYES_CheckedChanged"
	Private Sub rbExcludeDaysYES_CheckedChanged(sender As Object, _
												e As EventArgs) _
		Handles rbExcludeDaysYES.CheckedChanged
		If Me.rbExcludeDaysYES.Checked Then
			Me.pnlExcludeRange.Enabled = True
			Me.pnlExclusionDays.Enabled = True
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_pnlForCheckBox_Handles"
	Private Sub pnlForCheckBox_ControlAdded(sender As Object, _
											e As EventArgs) _
		Handles pnlForCheckBox.ControlAdded
		checkToEnableSelectAllCouponOffers()
	End Sub
	Private Sub pnlForCheckBox_ControlRemoved(sender As Object, _
											  e As EventArgs) _
		Handles pnlForCheckBox.ControlRemoved
		Dim num As Integer = Me.Data.CouponOffersTplList.Count
		If num = 0 Then
			PCW.NextEnabled = False
			Me.lblCouponOffersDirections.Enabled = True
			Me.lblCouponOffersDirections.Visible = True
		End If
		checkToEnableSubmit(num)
		checkToRelocateAndRenumberCheckBox()
		checkToChangeDeleteAndSelectAll(num)
	End Sub
#End Region
#Region "StepGetCouponOffers_cbSelectAllCouponOffers_CheckedChanged"
	Private Sub cbSelectAllCouponOffers_CheckedChanged(sender As Object, _
													   e As EventArgs) _
		Handles cbSelectAllCouponOffers.CheckedChanged
		ALL_SLCT = Me.cbSelectAllCouponOffers.Checked
		For Each cb As CheckBox In Me.pnlForCheckBox.Controls
			cb.Checked = ALL_SLCT
		Next
	End Sub
#End Region
#Region "StepGetCouponOffers_btnSubmit_Click"
	Private Sub btnSubmit_Click(sender As Object, _
								e As EventArgs) _
		Handles btnSubmit.Click
		disableSubmit()
		Me.lblCouponOffersDirections.Enabled = False
		Me.lblCouponOffersDirections.Visible = False
		Dim firstOfferList As Boolean = Me.Data.No_CouponOffers_Created()
		Dim couponOffer As CouponOffer = New CouponOffer()
		couponOffer = StepGetCouponOffers_GetData()
		Dim couponOfferIsValid As Boolean = _
			Me.Data.Is_CouponOffer_Valid(couponOffer, _
										 Me.rbExcludeDaysYES.Checked)
		If couponOfferIsValid Then
			Dim cb As CheckBox = getCheckBox()
			Dim tpl As Tuple(Of CheckBox, CouponOffer) = _
				New Tuple(Of CheckBox, CouponOffer)(cb, couponOffer)
			Me.Data.CouponOffersTplList.Add(tpl)
			Me.pnlForCheckBox.Controls.Add(tpl.Item1)
			Me.StepGetCouponOffers_ResetControls()
			If firstOfferList And Not Me.wildcardMsgBool Then
				GUI_Util.msgBox("Add another Coupon Offer or " & _
								"press Next to continue.", _
								"Coupon Offers Options", _
								"Information")
			End If
			Me.Data.SkipTargetImport = If(Me.rbCouponWildcardYES.Checked, _
										  True, _
										  False)
			GUI_Util.NextEnabled()
			GUI_Util.regPnl(Me.pnlCouponOffers)
		Else
			'CouponOffer Not Valid
			checkToEnableSubmit(Me.Data.CouponOffersTplList.Count)
			Me.lblCouponOffersDirections.Enabled = True
			Me.lblCouponOffersDirections.Visible = True
			GUI_Util.errPnl(Me.pnlCouponOffers)
			GUI_Util.msgBox("Coupon Offer Invalid.")
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_rbCouponWildcardYES_CheckedChanged"
	Private Sub rbCouponWildcardYES_CheckedChanged(sender As Object, _
												   e As EventArgs) _
		Handles rbCouponWildcardYES.CheckedChanged
		If rbCouponWildcardYES.Checked Then
			If Me.wildcardMsgBool = False Then
				Me.wildcardMsgBool = True
				If PCW.Data.UsesCouponTargetsList Then
					GUI_Util.msgBox("Wildcard Offers add Targets at the " & _
									"time of coupon creation. " & _
									"There is no option to import a " & _
									"Target list for a Wildcard Offer.", _
									"NO TARGET IMPORT!", _
									"Information")
				End If
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_txtNote_Enter"
	Private Sub txtNote_Enter(sender As Object, _
							  e As EventArgs) _
	Handles txtNote.Enter
		If Me.txtNote.Text = "EX: Note" Then
			Me.txtNote.Text = String.Empty
		End If
		GUI_Util.offIcon(Me.NoteSuccessIcon)
		GUI_Util.onSetBtn(Me.btnSetNote)
	End Sub
#End Region
#Region "StepGetCouponOffers_txtNote_Leave"
	Private Sub txtNote_Leave(sender As Object, _
							  e As EventArgs) _
		Handles txtNote.Leave
		GUI_Util.onIcon(Me.NoteSuccessIcon)
	End Sub
#End Region
#Region "StepGetCouponOffers_btnSetNote_Click"
	Private Sub btnSetNote_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnSetNote.Click
		Me.ActiveControl = Me.pnlNote
	End Sub
#End Region
#Region "StepGetCouponOffers_getCheckBox"
	Private Sub relocateCheckBox()
		Dim pt As Point
		Dim curr As Integer = 0
		Dim prev As Integer = 0
		Dim diff As Integer = 0
		If Me.Data.CouponOffersTplList.Count >= 2 Then
			For Each cb As CheckBox In Me.pnlForCheckBox.Controls
				curr = cb.Location.Y
				diff = curr - prev
				If diff > CB_SPACE Then
					pt = cb.Location
					pt.Y -= CB_SPACE
					cb.Location = pt
					curr = cb.Location.Y
				End If
				prev = curr
			Next
		Else
			For Each cb As CheckBox In Me.pnlForCheckBox.Controls
				cb.Location = New Point(START_LFT, START_LOC)
			Next
		End If
	End Sub

	Private Sub renumberCheckBox()
		Dim num As Integer = 1
		For Each cb As CheckBox In Me.pnlForCheckBox.Controls
			Dim split() As String = cb.Text.Split(" ")
			If (Not Short.Parse(split(1)) = 0) Then
				cb.Text = CB_NAME & num.ToString
				num += 1
			End If
		Next
	End Sub

	Private Sub checkToRelocateAndRenumberCheckBox()
		If (Me.cbSelectAllCouponOffers.Checked <> True) Or _
		   (Me.cbSelectAllCouponOffers.Checked And _
		   (Me.cbSelectAllCouponOffers.CheckState = _
			   CheckState.Indeterminate)) Then
			relocateCheckBox()
			renumberCheckBox()
			If Me.cbSelectAllCouponOffers.CheckState = _
				CheckState.Indeterminate Then
				Me.cbSelectAllCouponOffers.CheckState = _
					CheckState.Unchecked
			End If
		End If
	End Sub

	Private Sub checkAllSelectAll()
		Dim bool As Boolean = False
		For Each cb As CheckBox In Me.pnlForCheckBox.Controls
			If cb.Checked = False Then
				bool = True
			End If
		Next
		If bool Then
			Me.cbSelectAllCouponOffers.CheckState = _
				CheckState.Indeterminate
		End If
	End Sub

	Private Sub cb_CheckedChanged(sender As CheckBox, _
								  e As EventArgs)
		If sender.Checked Then
			If Me.btnDelete.Enabled = False Then
				enableDelete()
			End If
			sender.ForeColor = HLT_FORE
			sender.BackColor = HLT_BACK
		Else
			sender.ForeColor = REG_FORE
			sender.BackColor = REG_BACK
			If ALL_SLCT Then
				checkAllSelectAll()
			End If
		End If
	End Sub

	Private Function getCheckBox() As CheckBox
		Dim num As Integer = Me.Data. _
			CouponOffersTplList.Count
		Dim cb As CheckBox = New CheckBox()
		cb.AutoSize = True
		cb.Checked = False
		cb.Enabled = True
		If num = 0 Then
			cb.Location = New Point(START_LFT, START_LOC)
			cb.Text = CB_NAME & (num + 1).ToString
		Else
			Dim lastCheckBox As CheckBox = Me.Data. _
				CouponOffersTplList.Last.Item1
			Dim pt As Point = lastCheckBox.Location
			pt.Y += CB_SPACE
			cb.Location = pt
			cb.Text = CB_NAME & Me.Data.GetCouponNumber( _
				Me.rbCouponWildcardYES.Checked).ToString
		End If
		AddHandler cb.CheckedChanged, AddressOf cb_CheckedChanged
		Return cb
	End Function
#End Region
#Region "StepGetCouponOffers_btnDelete_Click"
	Private Sub btnDelete_Click(sender As Object, _
							e As EventArgs) _
	Handles btnDelete.Click
		disableDelete()
		Dim toBeDeleted As List(Of Tuple(Of CheckBox, CouponOffer)) = _
			New List(Of Tuple(Of CheckBox, CouponOffer))
		For Each tpl As Tuple(Of CheckBox, CouponOffer) In _
			Me.Data.CouponOffersTplList
			If tpl.Item1.Checked Then
				toBeDeleted.Add(tpl)
			End If
		Next
		For Each tpl As Tuple(Of CheckBox, CouponOffer) In toBeDeleted
			Me.Data.CouponOffersTplList.Remove(tpl)
			Me.pnlForCheckBox.Controls.Remove(tpl.Item1)
			tpl.Item1.Dispose()
		Next
	End Sub
#End Region
End Class

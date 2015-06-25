Imports TSWizards

Public Class StepGetCouponOffers
	Inherits TSWizards.BaseInteriorStep

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
		couponOffer.CouponNumber = Me.Data.GetCouponNumber(Me.rbCouponWildcardYES.Checked)
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
		Dim local_stepGeneratePayoutCoupon As StepGeneratePayoutCoupon = PCW.GetStep("StepGeneratePayoutCoupon")
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
		Dim days As String = New String("")
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
		Dim result As String = New String("")
		If Me.txtNote.Text = "EX: Small Note" Or
			Me.txtNote.Text = "" Then
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

	Private Sub StepGetCouponOffers_Load(sender As Object, e As EventArgs) _
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
	Private Sub StepGetCouponOffers_ResetStep(sender As Object, e As EventArgs) _
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
		Me.txtNote.Text = "EX: Small Note"
		Me.lblCouponOffersList.Text = "Click 'Submit' below to add Coupon Offers to this Coupon ID."
		ExcludeDaysCheckState(False)
		Me.clbExcludeDays.ClearSelected()
		Me.cbSelectAll.Checked = False
		Me.btnSubmit.Enabled = False
	End Sub
#End Region
#Region "StepGetCouponOffers_Validation"
	''' <summary>
	''' Asks StepGetCouponOffers_Data to validate data and then handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when user presses the "Next> Button."</remarks>
	Private Sub StepGetCouponOffers_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String("ASSINGED A VALUE") 'Not IsNothing

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
		If PCW.NextEnabled = True Then
			PCW.NextEnabled = False
		End If
		If Not PCW.Data.UsesCouponTargetsList Then
			Me.skipTargetImport = True
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_SelectAll"
	''' <summary>
	''' Checks all the Items in clbExcludeDays.
	''' </summary>
	''' <remarks></remarks>
	Private Sub ExcludeDaysCheckState(ByVal checkState As Boolean)
		For item As Integer = 0 To Me.clbExcludeDays.Items.Count - 1
			Me.clbExcludeDays.SetItemChecked(item, checkState)
		Next
	End Sub

	Private Sub cbSelectAll_CheckedChanged(sender As Object, e As EventArgs) _
		Handles cbSelectAll.CheckedChanged
		ExcludeDaysCheckState(Me.cbSelectAll.Checked)
	End Sub
#End Region
#Region "StepGetCouponOffers_dtpValidStart_CloseUp"
	Private Sub dtpValidStart_CloseUp(sender As Object, e As EventArgs) _
		Handles dtpValidStart.CloseUp
		If Me.validStartBool = False Then	'"Break the (Bool) seal!"
			Me.validStartBool = True
		End If
		checkStartEndValidBools()			'Have both seals been broken?
	End Sub
#End Region
#Region "StepGetCouponOffers_dtpValidEnd_CloseUp"
	Private Sub dtpQualifyingEnd_CloseUp(sender As Object, e As EventArgs) _
		Handles dtpValidEnd.CloseUp
		If Me.validEndBool = False Then		'"Break the (Bool) seal!"
			Me.validEndBool = True
		End If
		checkStartEndValidBools()			'Have both seals been broken?
	End Sub
#End Region
#Region "StepGetCouponOffers_checkStartEndValidBools"
	''' <summary>
	''' Sets the SelectionRange if both bools are true.
	''' </summary>
	''' <remarks>Make the MonthCal visible too!</remarks>
	Private Sub checkStartEndValidBools()
		If Me.validStartBool And Me.validEndBool Then
			If Me.btnSubmit.Enabled = False Then
				Me.btnSubmit.Enabled = True
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_rbExcludeDaysYES_CheckedChanged"
	Private Sub rbExcludeDaysYES_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbExcludeDaysYES.CheckedChanged
		If Me.rbExcludeDaysYES.Checked Then
			Me.pnlExcludeRange.Enabled = True
			Me.pnlExclusionDays.Enabled = True
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_btnSubmit_Click"
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) _
		Handles btnSubmit.Click
		Dim firstOfferList As Boolean = Me.Data.No_CouponOffers_Created()
		Dim couponOffer As CouponOffer = New CouponOffer()
		couponOffer = StepGetCouponOffers_GetData()
		Dim couponOfferIsValid As Boolean = Me.Data.Is_CouponOffer_Valid(couponOffer, _
																		 Me.rbExcludeDaysYES.Checked)
		If couponOfferIsValid Then
			Me.stepGetCouponOffers_data.AddCouponOfferToList(couponOffer)
			Me.StepGetCouponOffers_ResetControls()
			Me.lblCouponOffersList.Text = RefreshLabelList()
			If firstOfferList And Not Me.wildcardMsgBool Then
				GUI_Util.msgBox("Add another Coupon Offer or press Next to continue.", _
								"Coupon Offers Options", _
								"Information")
			End If
			Me.Data.SkipTargetImport = If(Me.rbCouponWildcardYES.Checked, _
										  True, _
										  False)
			GUI_Util.NextEnabled()
			GUI_Util.regPnl(Me.pnlCouponOffers)
		Else
			GUI_Util.errPnl(Me.pnlCouponOffers)
			GUI_Util.msgBox("Coupon Offer Invalid.")
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_RefreshLableList"
	Private Function RefreshLabelList()
		Dim result As String = If(Me.Data.No_CouponOffers_Created(), _
								  "Click 'Submit' below to add Coupon Offers to this Coupon ID.", _
								  Me.Data.GetCouponOfferListString())
		Return result
	End Function
#End Region
#Region "StepGetCouponOffers_rbCouponWildcardYES_CheckedChanged"
	Private Sub rbCouponWildcardYES_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbCouponWildcardYES.CheckedChanged
		If rbCouponWildcardYES.Checked Then
			If Me.wildcardMsgBool = False Then
				Me.wildcardMsgBool = True
				GUI_Util.msgBox("Wildcard Offers add Targets at the time of coupon creation. " & _
								"There is no option to import a Target list for a Wildcard Offer.", _
								"NO TARGET IMPORT!", _
								"Information")
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_txtNote_Enter"
	Private Sub txtNote_Enter(sender As Object, e As EventArgs) _
	Handles txtNote.Enter
		If Me.txtNote.Text = "EX: Small Note" Then
			Me.txtNote.Text = ""
		End If
	End Sub
#End Region
End Class

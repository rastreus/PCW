Imports TSWizards

Public Class StepGetCouponOffers
	Inherits TSWizards.BaseInteriorStep

#Region "StepGetCouponOffers_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepGetCouponOffers_data = New StepGetCouponTargets_Data
	End Sub
#End Region
#Region "StepGetCouponOffers_Data"
	''' <summary>
	''' Model for StepStepGetCouponOffers.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepGetCouponOffers_data As StepGetCouponTargets_Data
	Public ReadOnly Property Data() As StepGetCouponTargets_Data
		Get
			Return Me.stepGetCouponOffers_data
		End Get
	End Property
#End Region
#Region "StepGetCouponOffers_SetData"
	Private Sub StepGetCouponOffers_SetData()

	End Sub
#End Region
#Region "StepGetCouponOffers_Load"
	Private validStartBool As Boolean
	Private validEndBool As Boolean

	Private Sub StepGetCouponOffers_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		Me.validStartBool = False
		Me.validEndBool = False
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
		Me.StepGetCouponOffers_data = New StepGetCouponTargets_Data
		StepGetCouponOffers_ResetControls()
	End Sub

	''' <summary>
	''' Resets the controls (View) for the Step.
	''' </summary>
	''' <remarks></remarks>
	Private Sub StepGetCouponOffers_ResetControls()
		Me.validStartBool = False
		Me.validEndBool = False
		Me.dtpValidStart.Value = DateTime.Today
		Me.dtpValidEnd.Value = DateTime.Today
		Me.dtpExcludeStart.Value = DateTime.Today
		Me.dtpExcludeEnd.Value = DateTime.Today
		Me.rbExcludeDaysNO.Checked = True
		Me.pnlExcludeRange.Enabled = False
		Me.pnlExclusionDays.Enabled = False
		Me.lblCouponOffersList.Text = "Click 'Submit' below to add Coupon Offers to this Coupon ID."
		Me.cbSelectAll.Checked = True
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
	Private Sub StepC_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		'Confirm that there is one or more CouponOffer
	End Sub
#End Region
#Region "StepGetCouponOffers_ShowStep"
	''' <summary>
	''' Shows the Step controls.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Don't enable the "Next>" button until we're ready!</remarks>
	Private Sub StepC_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		If PCW.NextEnabled = True Then
			PCW.NextEnabled = False
		End If
	End Sub
#End Region
#Region "StepGetCouponOffers_SelectAll"
	''' <summary>
	''' Checks all the Items in clbExcludeDays.
	''' </summary>
	''' <remarks></remarks>
	Private Sub SelectAll()
		For item As Integer = 0 To Me.clbExcludeDays.Items.Count - 1
			Me.clbExcludeDays.SetItemChecked(item, Me.cbSelectAll.Checked)
		Next
	End Sub

	Private Sub cbSelectAll_CheckedChanged(sender As Object, e As EventArgs) _
		Handles cbSelectAll.CheckedChanged
		SelectAll()
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
		'SetData
		'ValidateData
		'If Not Valid, Cancel and Alert
		'Else
		'Add to CouponOffers ArrayList (StepGetCouponOffers_data)
		'Alert "Create another Coupon Offer or Continue"
		'If PCW.NextEnabled = False Then; PCW.NextEnabled = True; End If
	End Sub
#End Region
End Class

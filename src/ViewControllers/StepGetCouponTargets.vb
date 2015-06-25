Imports TSWizards
Imports System.ComponentModel

Public Class StepGetCouponTargets
	Inherits TSWizards.BaseInteriorStep

#Region "StepGetCouponTargets_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepGetCouponTargets_data = New StepGetCouponTargets_Data
		Me.TargetsList = New ArrayList
	End Sub
#End Region
#Region "StepGetCouponTargets_Data"
	''' <summary>
	''' Model for StepStepGetCouponTargets.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepGetCouponTargets_data As StepGetCouponTargets_Data
	Public ReadOnly Property Data() As StepGetCouponTargets_Data
		Get
			Return Me.stepGetCouponTargets_data
		End Get
	End Property
#End Region
#Region "StepGetCouponTargets_Load"
	Private Delegate Sub DelegateSetPathText(ByVal s As String)
	Private m_DelegateSetPathText As DelegateSetPathText
	Private targetsList As ArrayList

	Private Sub StepGetCouponTarget_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		m_DelegateSetPathText = New DelegateSetPathText(AddressOf Me.SetPathText)
	End Sub
#End Region
#Region "StepGetCouponTargets_ResetStep"
	Private Sub StepGetCouponTarget_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		ResetControls()
	End Sub

	Private Sub ResetControls()
		Me.lblDragHere.Text = "Drag Target List Here"
		Me.btnFileBrowser.Text = "C:\path\to\file\targetList.csv"
		Me.btnSubmit.Enabled = False
		Me.rbWildcard.Checked = True
	End Sub
#End Region
#Region "StepGetCouponTargets_Validation"
	Private Sub StepGetCouponTarget_Validation(sender As Object, _
											   e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim local_stepD As StepD = PCW.GetStep("StepD")
		Dim local_promoCategory As PCW_Data.PromoCategory = local_stepD.Data.Category
		Me.stepGetCouponTargets_data.SameForAllDaysTiers = If(SameForAllDaysTiers(local_promoCategory), _
															  True, _
															  False)
		'Step has been set if no error.
		Me.stepGetCouponTargets_data.StepNotSet = False
	End Sub
#End Region
#Region "StepGetCouponTargets_ShowStep"
	Private Sub StepGetCouponTarget_ShowStep(sender As Object, _
											 e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		SetCouponID()
		AddImportedOffers()
		If Me.Data.StepNotSet Then
			PCW.NextEnabled = False
		End If
	End Sub

	Private Sub SetCouponID()
		Dim local_genpayoff As StepGeneratePayoutCoupon = PCW.GetStep("StepGeneratePayoutCoupon")
		Dim local_couponID As String = local_genpayoff.Data.CouponID
		Me.stepGetCouponTargets_data.CouponID = local_couponID
	End Sub

	Private Sub AddImportedOffers()
		Dim local_offers As StepGetCouponOffers = PCW.GetStep("StepGetCouponOffers")
		Dim couponOffers As ArrayList = local_offers.Data.GetCouponOfferNumbersAsArrayList()
		Me.cbImportedOffers.Items.Clear()
		For Each offer As String In couponOffers
			Me.cbImportedOffers.Items.Add(offer)
		Next
	End Sub
#End Region
#Region "StepGetCouponTargets_SameForAllDaysTiers"
	Private Function SameForAllDaysTiers(ByVal promoCategory As PCW_Data.PromoCategory) As Boolean
		Dim result As Boolean = False
		If promoCategory = PCW_Data.PromoCategory.multiPart Then
			Dim dialogResult As DialogResult = CenteredMessagebox.MsgBox.Show("Do all Days/Tiers use the same" & _
																			  "Coupon Offers & Coupon Targets?", _
																			  "Reuse Offers and Targets?", _
																			  MessageBoxButtons.YesNo, _
																			  MessageBoxIcon.Exclamation)
			result = If(dialogResult = Windows.Forms.DialogResult.Yes, True, False)
		End If
		Return result
	End Function
#End Region
#Region "StepGetCouponTargets_cbPathToTargetList_DragEnter"
	Private Sub SetPathText(ByVal s As String)
		Me.btnFileBrowser.Text = s
		If Me.btnSubmit.Enabled = False Then
			Me.btnSubmit.Enabled = True
		End If
	End Sub

	Private Sub pnlDragTargetList_DragEnter(sender As Object, e As DragEventArgs) _
		Handles pnlDragTargetList.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
			Me.pnlDragTargetList.BackColor = Color.Bisque
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub pnlDragTargetList_DragDrop(sender As Object, e As DragEventArgs) _
		Handles pnlDragTargetList.DragDrop
		Me.pnlDragTargetList.BackColor = Color.SeaShell
		Try
			Dim a As Array = CType(e.Data.GetData(DataFormats.FileDrop), Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateSetPathText, New Object() {s})
				Success()
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in StepGetCouponTargets.pnlDragTargetList_DragDrop: " & ex.Message)
			GUI_Util.errPnl(Me.pnlDragTargetList)
			Me.lblDragHere.Text = "Error!"
		End Try
	End Sub

	Private Sub Success()
		GUI_Util.successPnl(Me.pnlDragTargetList)
		Me.lblDragHere.Text = "Success!"
	End Sub

	Private Sub btnFileBrowser_Click(sender As Object, e As EventArgs) _
		Handles btnFileBrowser.Click
		Dim fileDialog As New OpenFileDialog()
		fileDialog.InitialDirectory = "C:\"
		fileDialog.Filter = "CSV Files(*.csv)|*.csv" & _
							"|All Files(*.*)|*.*"
		fileDialog.FilterIndex = 1
		fileDialog.RestoreDirectory = True
		'seperates message outputs for files found or not found
		If fileDialog.ShowDialog() = DialogResult.OK Then
			If Dir(fileDialog.FileName) <> "" Then
				SetPathText(fileDialog.FileName)
				Success()
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponTargets_rbImportedOffers_CheckedChanged"
	Private Sub rbImportedOffers_CheckedChanged(sender As Object, e As EventArgs) _
		Handles rbImportedOffers.CheckedChanged
		If Me.rbImportedOffers.Checked Then
			Me.cbImportedOffers.Enabled = True
			Me.cbImportedOffers.DroppedDown = True
		Else
			Me.cbImportedOffers.Enabled = False
			If Me.cbImportedOffers.DroppedDown = True Then
				Me.cbImportedOffers.DroppedDown = False
			End If
		End If
	End Sub
#End Region
#Region "StepGetCouponTargets_btnSubmit_Click"
	Private Sub btnSubmit_Click(sender As Object, _
								e As EventArgs) _
		Handles btnSubmit.Click
		Me.btnSubmit.Enabled = False
		Me.stepGetCouponTargets_data.CouponTargetsCSVFilePath = Me.btnFileBrowser.Text
		Me.stepGetCouponTargets_data.CouponTargetsCouponNum = GetCouponNumber()
		Me.targetsList.Add(GetCouponTargetListsLabel())
		Me.lblCouponTargetLists.Text = RefreshLabelList()
		Me.UseWaitCursor = True
		Me.stepGetCouponTargets_data.CSVtoCouponTargetsList()
		GUI_Util.msgBox(PCW.Data.CouponTargetList.Count.ToString)
		'Only Enable once sure the CSV in a DataTable
		Me.UseWaitCursor = False
		GUI_Util.NextEnabled()
		Me.btnSubmit.Enabled = True
	End Sub
#End Region
#Region "StepGetCouponTargets_GetCouponNumber"
	Private Function GetCouponNumber() As Integer
		Dim result As String = New String("!")
		result = If(Me.rbWildcard.Checked, _
					0, _
					Me.cbImportedOffers.SelectedItem)
		Return result
	End Function
#End Region
#Region "StepGetCouponTargets_GetFileNameAsString"
	Private Function GetFileNameAsString() As String
		Dim filePath As String = Me.btnFileBrowser.Text
		Dim parts As String() = filePath.Split(New Char() {"\"c})
		Return parts.Last()
	End Function
#End Region
#Region "StepGetCouponTargets_GetCouponTargetListLabel"
	Private Function GetCouponTargetListsLabel()
		Return GetCouponNumber().ToString() & ": " & GetFileNameAsString()
	End Function
#End Region
#Region "StepGetCouponTargets_RefreshLabelList"
	Private Function RefreshLabelList()
		Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder
		For Each listStr As String In Me.targetsList
			builder.Append(listStr & vbCrLf)
		Next
		Return builder.ToString()
	End Function
#End Region
End Class

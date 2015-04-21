Imports TSWizards

Public Class StepGetCouponTargets
	Inherits TSWizards.BaseInteriorStep

#Region "StepGetCouponTarget_Reset"
	Private Sub StepGetCouponTarget_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		ResetControls()
	End Sub

	Private Sub ResetControls()
		Me.lblDragHere.Text = "Drag Target List Here or Click Button Below"
		Me.btnFileBrowser.Text = "C:\path\to\file\targetList.csv"
		Me.btnSubmit.Enabled = False
		Me.rbWildcard.Checked = True
	End Sub
#End Region
#Region "StepGetCouponTarget_Load"
	Private Delegate Sub DelegateSetPathText(ByVal s As String)
	Private m_DelegateSetPathText As DelegateSetPathText

	Private Sub StepGetCouponTarget_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		m_DelegateSetPathText = New DelegateSetPathText(AddressOf Me.SetPathText)
	End Sub
#End Region
#Region "StepGetCouponTarget_ShowStep"
	Private Sub StepGetCouponTarget_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		Dim local_offers As StepGetCouponOffers = PCW.GetStep("StepGetCouponOffers")
		Dim couponOffers As ArrayList = local_offers.Data.GetCouponOfferNumbersAsArrayList()
		For Each offer As String In couponOffers
			Me.cbImportedOffers.Items.Add(offer)
		Next
		PCW.NextEnabled = False
	End Sub
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
#Region "StepGetCouponTarget_rbImportedOffers_CheckedChanged"
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
#Region "StepGetCouponTarget_btnSubmit_Click"
	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) _
		Handles btnSubmit.Click
		'Parse File Path
		'Add to Label: File Path - Coupon Number
		If (PCW.NextEnabled = False) Then
			PCW.NextEnabled = True
		End If
	End Sub
#End Region
End Class

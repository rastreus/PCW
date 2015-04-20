﻿Imports TSWizards

Public Class StepGetCouponTargets
	Inherits TSWizards.BaseInteriorStep

#Region "StepGetCouponTarget_Reset"
	Private Sub StepGetCouponTarget_ResetStep(sender As Object, e As EventArgs) _
		Handles MyBase.ResetStep
		ResetControls()
	End Sub

	Private Sub ResetControls()
		Me.lblDragHere.Text = "Drag Target List Here or Click Button Below"
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
#Region "StepGetCouponTargets_cbPathToTargetList_DragEnter"
	Private Sub SetPathText(ByVal s As String)
		Me.btnFileBrowser.Text = s
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
End Class
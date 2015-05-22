Imports TSWizards
Imports System
Imports System.Threading
Imports System.Collections
Imports System.Collections.Specialized

Public Class StepJ
	Inherits TSWizards.BaseInteriorStep

#Region "StepJ_Validation"
	Private Sub StepJ_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) _
		Handles Me.ValidateStep
		Dim statusStrArray(3) As String
		statusStrArray = SubmitToDB()
		For Each statusStr As String In statusStrArray
			If Not IsNothing(statusStr) And
				Not (statusStr = "") Then
				GUI_Util.msgBox(statusStr)
			End If
		Next
	End Sub

	Private Function SubmitToDB() As String()
		Dim statusStrArray(3) As String
		statusStrArray(0) = Nothing
		statusStrArray(1) = Nothing
		statusStrArray(2) = Nothing
		Dim local_stepD As StepD = PCW.GetStep("StepD")
		Dim local_promoCategory As PCW_Data.PromoCategory = local_stepD.Data.Category
		PCW.Data.SubmitPromosToList(local_promoCategory)
		Dim promoStatusStr As String = PCW.Data.SubmitListToDB()
		Dim couponTargetStatusStr As String = PCW.Data.SubmitCouponTargtListToDB()
		Dim eligiblePlayerStatusStr As String = PCW.Data.SubmitEligiblePlayersToDB()
		statusStrArray(0) = promoStatusStr
		If Not IsNothing(couponTargetStatusStr) Then
			statusStrArray(1) = couponTargetStatusStr
		End If
		If Not IsNothing(eligiblePlayerStatusStr) Then
			statusStrArray(2) = eligiblePlayerStatusStr
		End If
		Return statusStrArray
	End Function
#End Region
#Region "StepJ_ShowStep"
	'A lot of this progress bar step was taken from the TSWizards example.
	'Please refer to it if you have questions about how it all works.
	Private Sub StepJ_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		'Stop the user from going back once they're at the end because it could cause numerous problems.
		'At this point, it's too late for the user to go back and change anything; there no longer
		'needs functioning navigation buttons while the user waits for the progress bar.
		'CancelEnabled is different from the other two because it is a Public Sub of PCW
		'while the other two are properties of a TSWizard.BaseWizard.
		PCW.ControlBox = False
		PCW.CancelEnabled(False)
		PCW.BackEnabled = False
		PCW.NextEnabled = False
		'The next two lines actually start the progress bar.
		'Nothing would happen on this Step without these two lines.
		Dim mi As MethodInvoker = New MethodInvoker(AddressOf Me.DoWork)
		mi.BeginInvoke(New AsyncCallback(AddressOf Me.DonePreparing), Nothing)
	End Sub

	Private Sub DoWork()
		Dim strCollection As StringCollection = New StringCollection()
		Dim strArray() As String = {"ID", _
									"Name", _
									"Date", _
									"StartDate", _
									"EndDate", _
									"PointCutoff", _
									"PointDivisor", _
									"MaxTickets", _
									"PromoMaxTickets", _
									"CouponID", _
									"Recurring", _
									"Frequency", _
									"RecursOnWeekday", _
									"EarnsOnWeekday", _
									"CountCurrentDay", _
									"PrintTickets", _
									"Comments"}
		strCollection.AddRange(strArray)

		BeginPreparing(strCollection.Count)

		For Each str As String In strCollection
			Preparing(str)
			Thread.Sleep(1000)
			Prepared()
		Next
	End Sub

	Private Sub BeginPreparing(items As Integer)
		If InvokeRequired Then
			Me.Invoke(New IntDelegate(AddressOf Me.BeginPreparing), New Object() {items})
			Return
		End If

		Me.ProgressBar1.Maximum = items * 10
		Me.ProgressBar1.Value = 10
	End Sub

	Private Sub Preparing(item As String)
		If InvokeRequired Then
			Me.Invoke(New StringDelegate(AddressOf Me.Preparing), New Object() {item})
			Return
		End If

		Me.Label2.Text = item
	End Sub

	Private Sub Prepared()
		If InvokeRequired Then
			Me.Invoke(New MethodInvoker(AddressOf Me.Prepared), New Object() {})
			Return
		End If

		Me.ProgressBar1.PerformStep()
	End Sub

	Private Sub DonePreparing(result As IAsyncResult)
		If InvokeRequired Then
			Me.Invoke(New AsyncCallback(AddressOf Me.DonePreparing), New Object() {result})
			Return
		End If
		GUI_Util.NextEnabled()
	End Sub

	Private Delegate Sub IntDelegate(num As Integer)
	Private Delegate Sub StringDelegate(str As String)
#End Region
End Class

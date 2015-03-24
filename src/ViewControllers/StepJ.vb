﻿Imports TSWizards
Imports System
Imports System.Threading
Imports System.Collections
Imports System.Collections.Specialized

Public Class StepJ
	Inherits TSWizards.BaseInteriorStep

#Region "StepJ_ShowStep"
	Private Sub StepJ_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
		'Dim step2 As StepB = PCW.GetStep("Step2")
		'Dim PCWq As Queue(Of MarketingPromo) = SingletonQueue.Instance()
		''By default the count variable will be 1;
		''however, if this is a "Multi-Part Sequencial,"
		''the count will be the supplied number.
		'Dim count As Short = 1
		'If step2.RadioButton6.Checked Then
		'	count = Short.Parse(step2.TextBox2.Text)
		'End If

		'If (step2.RadioButton7.Checked Or step2.RadioButton6.Checked) And (count > 1) Then 'Needs to "Loop" for additional days
		'	SubmitPromoIntoQueue(PCW.PCW_GetPromo)
		'	Me.NextStep = "Step5"
		'	CenteredMessagebox.MsgBox.Show("Now figure the requirements for next entry.", "Entries!",
		'								   MessageBoxButtons.OK, MessageBoxIcon.Hand)
		'	PCW.ResetSteps()
		'	Thread.Sleep(600)
		'	PCW.MoveNext()
		'ElseIf step2.RadioButton7.Checked Or
		'		(step2.RadioButton6.Checked And (count = 1)) Then 'Multi-Part Single Instance Or End of "Loop"
		'	SubmitPromoIntoQueue(PCW.PCW_GetPromo)
		'	Me.NextStep = "StepN"
		'	ProcessPromoQueue(PCWq)
		'	Thread.Sleep(600)
		'	PCW.MoveNext()
		'Else 'ERROR!
		'	'Not entirely sure why we would ever get here, but it's good to have a catch just in case
		'	CenteredMessagebox.MsgBox.Show("StepJ: Loop Logic Error (Error Code 142857)", "ERROR!",
		'								   MessageBoxButtons.OK, MessageBoxIcon.Error)
		'End If
	End Sub

	'A lot of this progress bar step was taken from the TSWizards example.
	'Please refer to it if you have questions about how it all works.
	Private Sub StepJ_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
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
		Dim strArray() As String = {"Name", _
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
		PCW.NextEnabled = True
	End Sub

	Private Sub ProcessPromoQueue(ByVal PCWq As Queue(Of MarketingPromo))
		Dim key_count As Short = PCWq.Count
		Dim proxyLoop As Collection = New Collection
		'Done
		For Each key As Object In PCWq
			proxyLoop.Add(key)
		Next

		For Each key As Object In proxyLoop
			'SubmitPromoIntoTable(PCWq.Dequeue())
			CenteredMessagebox.MsgBox.Show(PCWq.Dequeue().ToString, "DEBUG",
										   MessageBoxButtons.OK, MessageBoxIcon.None)
		Next
	End Sub

	Private Function IsEntries()
		Dim var As Boolean = False
		Dim PCWq As Queue(Of MarketingPromo) = SingletonQueue.Instance()

		If PCWq.Count = 0 Then
			var = True
		End If

		Return var
	End Function

	Private Sub SubmitPromoIntoQueue(ByVal newPromo As MarketingPromo)
		Dim PCWq As Queue(Of MarketingPromo) = SingletonQueue.Instance()
		PCWq.Enqueue(newPromo)
	End Sub

	Private Sub SubmitPromoIntoTable(ByVal newPromo As MarketingPromo)
		'Insert the new promo into MarketingPromos table
		Dim tbl As MarketingPromosDataContext = New MarketingPromosDataContext(Global.PromotionalCreationWizard.My.MySettings.Default.ConfigConnectionString)
		tbl.MarketingPromos.InsertOnSubmit(newPromo)
		Try
			tbl.SubmitChanges()
		Catch ex As Exception
			Dim result As Integer = CenteredMessagebox.MsgBox.Show("Oh no! Promo not added to MarketingPromo table!", "No!",
																   MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

			If result = DialogResult.Retry Then
				tbl.SubmitChanges()
			End If
		End Try
	End Sub

	Private Delegate Sub IntDelegate(num As Integer)
	Private Delegate Sub StringDelegate(str As String)
#End Region
#Region "StepJ_InfoCircle"
	'I decided to comment out the button click of the IconButton on this Step.
	'It also does not change color when the mouse hovers over it (well, it does but it's the same color).
	'The user is forced to sit and wait. They must reflect on the action that they have just commited.
	'They have created a new promotional. Sit there and bask in the glory of the progress bar. Wait.
	Private Sub IconButton1_Click(sender As Object, e As EventArgs)
		'        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014
		'
		'Brought to you by the fine folks of the OJC IT Department!</a>.Value
		'
		'       CenteredMessagebox.MsgBox.Show(infoString, "Information",
		'									  MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub
#End Region
End Class
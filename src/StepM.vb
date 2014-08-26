Imports TSWizards
Imports System
Imports System.Threading
Imports System.Collections
Imports System.Collections.Specialized

Public Class StepM
    Inherits TSWizards.BaseInteriorStep

#Region "StepM_ShowStep"
    'A lot of this progress bar step was taken from the TSWizards example.
    'Please refer to it if you have questions about how it all works.
    Private Sub StepM_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
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

        Me.NextStep = "StepN"
        'SubmitPromoToTable
        Thread.Sleep(600)
        PCW.MoveNext()
    End Sub

    Private Sub SubmitPromoToTable()
        'Insert the new promo into MarketingPromos table
        Dim tbl As New MarketingPromosDataContext
        Dim newPromo As MarketingPromo = New MarketingPromo
        newPromo = PCW.PCW_GetPromo
        tbl.MarketingPromos.InsertOnSubmit(newPromo)
        Try
            tbl.SubmitChanges()
        Catch ex As Exception
            Dim result As Integer = CenteredMessagebox.MsgBox.Show("Oh no! The promo wasn't added to the MarketingPromo table!", "NoooOOOooOOo!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            If result = DialogResult.Retry Then
                tbl.SubmitChanges()
            End If
        End Try
    End Sub

    Private Delegate Sub IntDelegate(num As Integer)
    Private Delegate Sub StringDelegate(str As String)
#End Region
#Region "StepM_InfoCircle"
    'I decided to comment out the button click of the IconButton on this Step.
    'It also does not change color when the mouse hovers over it (well, it does but it's the same color).
    'The user is forced to sit and wait. They must reflect on the action that they have just commited.
    'They have created a new promotional. Sit there and bask in the glory of the progress bar. Wait.
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        '        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014
        '
        'Brought to you by the fine folks of the OJC IT Department!
        '
        'Please direct questions and concerns toward:
        '        Russell Dillin
        '        rdillin@ oaklawn.com
        'x696</a>.Value
        '
        '       CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

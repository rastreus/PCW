Imports TSWizards
Imports CenteredMessagebox
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Linq

Public Class PCW
    Inherits TSWizards.BaseWizard

#Region "PCW_New"
	''' <summary>
	''' Gets run when creating a New PCW
	''' </summary>
	''' <remarks>'Not entirely sure if this is needed, but it  works.</remarks>
	Public Sub New()
		'Required by the Designer code.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.cancel.Visible = True
		Me.back.Visible = True
	End Sub
#End Region
#Region "PCW_Data"
	Private pcw_data As PCW_Data

	Public Property Data() As PCW_Data
		Get
			Return Me.pcw_data
		End Get
		Set(value As PCW_Data)
			Me.pcw_data = value
		End Set
	End Property
#End Region
#Region "PCW_Load"
	Private infoCircle As FontAwesomeIcons.IconButton

	Private Sub PCW_Load(sender As Object, e As EventArgs) _
		Handles MyBase.Load
		Me.pcw_data = New PCW_Data
		Me.infoCircle = New FontAwesomeIcons.IconButton
	End Sub
#End Region
#Region "PCW_LoadSteps"
	''' <summary>
	''' Creates instances of the Step classes.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>THIS IS AN IMPORTANT SUB!</remarks>
	Private Sub PCW_LoadSteps(ByVal sender As System.Object, ByVal e As System.EventArgs) _
		Handles MyBase.LoadSteps
		AddStep("StepA", New StepA)
		AddStep("StepB", New StepB)
		AddStep("StepC", New StepC)
		AddStep("StepD", New StepD)
		AddStep("StepF", New StepF)
		AddStep("StepEntryTicketAmt", New StepEntryTicketAmt)
		AddStep("StepGeneratePayoutCoupon", New StepGeneratePayoutCoupon)
		AddStep("StepH", New StepH)
		AddStep("StepI", New StepI)
		AddStep("StepJ", New StepJ)
		AddStep("StepX", New StepX)
	End Sub
#End Region

	'Public Overloads Function GetStep(ByVal name As String) As IWizardStep
	'	Return MyBase.GetStep(name)
	'End Function

	'Public Function PCW_StepThroughEntriesPayout(ByVal numOfEntries As Short)
	'	Dim entriesQ As System.Collections.Queue = New Queue
	'	Dim step2 As StepB = Me.GetStep("Step2")

	'	AddStep("entriesLoop_step3", New Step3)
	'	AddStep("entriesLoop_step4", New StepC)
	'	AddStep("entriesLoop_step5", New StepG1)
	'	AddStep("entriesLoop_step5X5", New Step5X5)
	'	AddStep("entriesLoop_step6", New StepG2)
	'	AddStep("entriesLoop_stepK", New StepH)

	'	Me.GetStep("entriesLoop_step3").NextStep = "entriesLoop_step5"
	'	Me.GetStep("entriesLoop_step4").NextStep = "entriesLoop_step5"
	'	Me.GetStep("entriesLoop_step5").NextStep = "entriesLoop_step5X5"
	'	Me.GetStep("entriesLoop_step5X5").NextStep = "entriesLoop_step6"
	'	Me.GetStep("entriesLoop_step6").NextStep = "entriesLoop_stepK"

	'	Me.GetStep("entriesLoop_stepK").NextStep = "entriesLoop_step5"

	'	'ENTRIES LOOP
	'	If step2.RadioButton4.Checked Then
	'		'Show Step3
	'	Else
	'		'Show Step4
	'	End If

	'	Return entriesQ
	'End Function

	'	Public Function PCW_GetPromo()
	'		'Initialize the entity
	'		Dim newPromo As MarketingPromo = New MarketingPromo

	'		'Initialize the Steps
	'		Dim stepB As StepB = Me.GetStep("StepB")
	'		Dim stepC As StepC = Me.GetStep("StepC")
	'		Dim stepD As StepD = Me.GetStep("StepD")
	'		Dim stepE As StepE = Me.GetStep("StepE")
	'		Dim stepF As StepF = Me.GetStep("StepF")
	'		Dim stepG1 As StepEntryTicketAmt = Me.GetStep("StepG1")
	'		Dim stepG2 As StepG2 = Me.GetStep("StepG2")
	'		Dim stepH As StepH = Me.GetStep("StepH")

	'		'Make sure that we are who we say we are
	'		'if we're aren't sure who we are, we die
	'		If IsNothing(stepB) Or
	'			IsNothing(stepC) Or
	'			IsNothing(stepD) Or
	'			IsNothing(stepE) Or
	'			IsNothing(stepF) Or
	'			IsNothing(stepG1) Or
	'			IsNothing(stepG2) Or
	'			IsNothing(stepH) Then
	'			Throw New ApplicationException("Oh no! A Step is not the Step that it claims to be!")
	'		End If

	'		'Gather the step results and put into the entity
	'		newPromo.PromoName = DeterminePromoName(stepB, stepD)
	'		'
	'		newPromo.PromoDate = DeterminePromoDate(stepB, stepC)
	'		newPromo.StartDate = DetermineStartDate(stepC)
	'		newPromo.EndDate = DetermineEndDate(stepC)
	'		newPromo.PointCutoff = DeterminePointCutoff(stepE)
	'		'newPromo.PointDivisor = DeterminePointDivisor(stepF, stepG1)
	'		'newPromo.MaxTickets = DetermineTicketsPerPatron(stepF, stepG1)
	'		'newPromo.PromoMaxTickets = DetermineTicketsPerPromo(stepF, stepG1)
	'		newPromo.MaxCoupon = DetermineMaxCoupon(stepF, stepG2)
	'		newPromo.PromoMaxCoupon = DeterminePromoMaxCoupon(stepF, stepG2)
	'		newPromo.CouponID = DetermineCouponID(stepF, stepG2)
	'		newPromo.Recurring = DetermineRecurring(stepB)
	'		newPromo.Frequency = DetermineFrequency(stepB)
	'		newPromo.RecursOnWeekday = DetermineRecursOnWeekday(stepB, stepC)
	'		newPromo.EarnsOnWeekday = DetermineEarnsOnWeekday(stepB, stepC)
	'		'newPromo.CountCurrentDay = DetermineCountCurrentDay(stepC)
	'		'newPromo.PrintTickets = DeterminePrintTickets(stepF)
	'		newPromo.Comments = DetermineComments(stepH)
	'		'
	'		newPromo.PromoType = DeterminePromoType(stepB, stepC, stepD, stepE, stepF, stepG1, stepG2)	'Needs work still
	'		newPromo.Query = DetermineQuery(newPromo.PromoType)
	'		'
	'		Return newPromo
	'	End Function

	'	Private Function DetermineQuery(ByVal promoType As String)
	'		Dim query As Short?

	'		'Get the first two characters.
	'		If Not IsNothing(promoType) Then
	'			query = Short.Parse(promoType.Substring(0, 1))
	'		Else
	'			query = Nothing
	'		End If

	'		Return query
	'	End Function

	'#Region "DeterminePromoType"
	'	'This function routes to other functions,
	'	'just trying to figure out the promotype.
	'	Private Function DeterminePromoType(ByVal stepB As StepB, _
	'										ByVal stepC As StepC, _
	'										ByVal stepD As StepD, _
	'										ByVal stepE As StepE, _
	'										ByVal stepF As StepF, _
	'										ByVal stepG1 As StepEntryTicketAmt, _
	'										ByVal stepG2 As StepG2)
	'		Dim result As String
	'		'If Is_Type_20(stepD, stepE, stepF) Then
	'		'	result = "20"
	'		'	Return result
	'		If Is_Type_20A(stepD, stepE, stepF, stepG1) Then
	'			result = "20A"
	'			Return result
	'		ElseIf Is_Type_21(stepD, stepE, stepF, stepG1) Then
	'			result = "21"
	'			Return result
	'		ElseIf Is_Type_22(stepD, stepE, stepF, stepG1) Then
	'			result = "22"
	'			Return result
	'		ElseIf Is_Type_22A(stepD, stepE, stepF, stepG1) Then
	'			result = "22A"
	'			Return result
	'		ElseIf Is_Type_22B(stepD, stepE, stepF, stepG1) Then
	'			result = "22B"
	'			Return result
	'		ElseIf Is_Type_23(stepD, stepE, stepF, stepG1) Then
	'			result = "23"
	'			Return result
	'		ElseIf Is_Type_24(stepD, stepE, stepF, stepG1) Then
	'			result = "24"
	'			Return result
	'		ElseIf Is_Type_25(stepD, stepE, stepF, stepG1) Then
	'			result = "25"
	'			Return result
	'			'Not sure how to determine a 25A at the moment. :\
	'			'ElseIf Is_Type_25A(step2, step3, step4, step5, step6) Then
	'			'    result = "25A"
	'			'    Return result
	'			'ElseIf Is_Type_26(stepD, stepE, stepF, stepG1) Then
	'			'	result = "26"
	'			'	Return result
	'			'ElseIf Is_Type_27(stepD, stepE, stepF, stepG1) Then
	'			'	result = "27"
	'			'	Return result
	'			'ElseIf Is_Type_28(stepC, stepD, stepE, stepF, stepG1) Then
	'			'	result = "28"
	'			'	Return result
	'			'ElseIf Is_Type_29(stepB, stepG1) Then
	'			'	result = "29"
	'			'	Return result
	'			'ElseIf Is_Type_30(stepB, stepG1, step5X5) Then
	'			'	result = "30"
	'			'	Return result
	'			'ElseIf Is_Type_31(stepB, stepG1) Then
	'			'	result = "31"
	'			'	Return result
	'			'ElseIf Is_Type_31A(stepB, stepG1) Then
	'			'	result = "31A"
	'			'	Return result
	'			'ElseIf Is_Type_31B(stepB, stepG2) Then
	'			'	result = "31B"
	'			'	Return result
	'			'ElseIf Is_Type_31C(stepB, stepG2) Then
	'			'	result = "31C"
	'			'	Return result
	'		ElseIf Is_Type_32(stepD, stepE, stepF, stepG1) Then
	'			result = "32"
	'			Return result
	'			'ElseIf Is_Type_32A(stepD, stepE, stepF, stepG1) Then
	'			'	result = "32A"
	'			'	Return result
	'		ElseIf Is_Type_33(stepD, stepF) Then
	'			result = "33"
	'			Return result
	'		ElseIf Is_Type_34(stepB, stepG2) Then
	'			result = "34"
	'			Return result
	'		Else
	'			result = Nothing
	'			Return result
	'		End If
	'	End Function


	'	'"Gives out 1 ticket regardless of points if player has Players club account."
	'	'Private Function Is_Type_20(ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		(No_PointCutoff(stepE) Or
	'	'		 (Yes_PointCutoff(stepE) And Give_Regardless_Of_Points(stepE))) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	'"Gives out 1 ticket between start and end, per account."
	'	Private Function Is_Type_20A(ByVal stepD As StepD, _
	'								 ByVal stepE As StepE, _
	'								 ByVal stepF As StepF, _
	'								 ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Limit_Tickets_Per_Patron(stepG1) And Limit_Amount_Is_One(stepG1) And
	'			 (No_PointCutoff(stepE) Or
	'			  (Yes_PointCutoff(stepE) And Give_Regardless_Of_Points(stepE))) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table and gives one ticket if lifetime points are greater than or equal to cutoff."
	'	Private Function Is_Type_21(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Lifetime_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table where the date is between start and end date
	'	'and gives one ticket if total points are greater than or equal to cutoff."
	'	Private Function Is_Type_22(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"If points are greater than cutoff, prints one ticket up to "max tickets," but only one per day."
	'	Private Function Is_Type_22A(ByVal stepD As StepD, _
	'								 ByVal stepE As StepE, _
	'								 ByVal stepF As StepF, _
	'								 ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"If points are greater than cutoff, prints one ticket between start and end date if player has
	'	'signed up for new account between start and end. Redemption date cannot be same as enroll date."
	'	Private Function Is_Type_22B(ByVal stepD As StepD, _
	'								 ByVal stepE As StepE, _
	'								 ByVal stepF As StepF, _
	'								 ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If Acquisition_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table and does a count of the date field in the points table
	'	'where the date is between start and end date and returns the count as number of tickets
	'	'if total points are greater than or equal to cutoff."
	'	Private Function Is_Type_23(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			Count_Amount_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table where date is between start and end date, divides that by the point divisor
	'	'and then adds it to a count of the date field to get the number of tickets if total points is greater than cutoff."
	'	Private Function Is_Type_24(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			Complex_Amount_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table where the date is between start and end date and then divides that
	'	'by the point divisor to determine amount of tickets if the total points is greater than or equal to cutoff."
	'	Private Function Is_Type_25(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			Compound_Amount_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'			 Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Sums up total points from points table where the date falls on current week. Then divides that by the point divisor to
	'	'determine amount of tickets if total points are greater than or equal to cutoff."
	'	'Private Function Is_Type_25A(ByVal step2 As Step2, _
	'	'                            ByVal step3 As Step3, _
	'	'                            ByVal step4 As Step4, _
	'	'                            ByVal step5 As Step5, _
	'	'                            ByVal step5X5 As Step5X5, _
	'	'                            ByVal step6 As Step6) As Boolean
	'	'    Dim it_is As Boolean = False
	'	'    If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		 One_Ticket_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'	'		  Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'	'        it_is = True
	'	'    End If
	'	'    Return it_is
	'	'End Function

	'	''"Selects the number of tickets from the Eligible Players Table."
	'	''/This will need to be updated once Eligible Players Table is fully implimented through StepG3./
	'	'Private Function Is_Type_26(ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF, _
	'	'							ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		EligiblePlayers_Amount_Rewarded(stepG1) And
	'	'		 (No_PointCutoff(stepE) Or
	'	'		  (Yes_PointCutoff(stepE) And Give_Regardless_Of_Points(stepE))) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Sums up total points from points table where date is between start and end date and then selects
	'	''the number of tickets from the eligible players table if total points are greater than or equal to cutoff."
	'	'Private Function Is_Type_27(ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF, _
	'	'							ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		EligiblePlayers_Amount_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'	'		 Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	'Commented out when changing StepC
	'	''"Will do a count of the date field in the points table where handle is greater than or equal to cutoff
	'	''and where the date is one of the days listed in the earns on field and return that as the number of tickets.
	'	''Not compatible with Same-Day Points."
	'	'Private Function Is_Type_28(ByVal stepC As StepC, _
	'	'							ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF, _
	'	'							ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		Same_Day_Points_Not_Compatible(stepC) And
	'	'		 Count_Amount_Rewarded(stepG1) And Yes_PointCutoff(stepE) And
	'	'		  Sums_Start_End_Points(stepE) And Greater_Than_Or_Equal_To(stepE) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Will prompt to select a prize from a dropdown box and then print one ticket for that prize for that day."
	'	'Private Function Is_Type_29(ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF, _
	'	'							ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And step5.RadioButton4.Checked And
	'	'		step5.RadioButton12.Checked And step5.CheckBox1.Checked Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Will prompt for number of tickets to print and then print them without checking
	'	''if the player has already got tickets for that day."
	'	'Private Function Is_Type_30(ByVal stepD As StepD, _
	'	'							ByVal stepE As StepE, _
	'	'							ByVal stepF As StepF, _
	'	'							ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		step5.RadioButton11.Checked And step5.RadioButton17.Checked And
	'	'		 Give_Regardless_Of_Points(stepE) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Will prompt to select a prize from a dropdown box and then print one ticket for that prize
	'	''and will allow multiple prints for the same day."
	'	'Private Function Is_Type_31(ByVal step2 As StepB, ByVal step5 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And step5.RadioButton4.Checked And step5.RadioButton13.Checked Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Similar to 31, other than it is a prompt with free form entry of cash value."
	'	'Private Function Is_Type_31A(ByVal step2 As StepB, ByVal step5 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And step5.RadioButton3.Checked Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Similar to 31A, other than it is a prompt with free form entry of cash value
	'	''and prints on receipt and creates validated free play offer."
	'	'Private Function Is_Type_31B(ByVal step2 As StepB, ByVal step6 As StepG2) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If step2.RadioButton1.Checked And step6.RadioButton1.Checked Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	''"Similar to 31B, but no prompt. Value of receipt is always value of MaxCoupon."
	'	'Private Function Is_Type_31C(ByVal step2 As StepB, ByVal step6 As StepG2) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If step2.RadioButton1.Checked And step6.RadioButton2.Checked Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	'"Allows one ticket to be printed weekly, monthly, quarterly, or yearly if account is in eligible players table."
	'	Private Function Is_Type_32(ByVal stepD As StepD, _
	'								ByVal stepE As StepE, _
	'								ByVal stepF As StepF, _
	'								ByVal stepG1 As StepEntryTicketAmt) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'			One_Ticket_Rewarded(stepG1) And Uses_EligiblePlayers_For_Points(stepE) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	''"Allows one ticket to be printed daily, weekly, monthly, quarterly, or yearly if account is in eligible players table.
	'	''Uses EligiblePlayers table to determine who and how many to print."
	'	'Private Function Is_Type_32A(ByVal stepD As StepD, _
	'	'							 ByVal stepE As StepE, _
	'	'							 ByVal stepF As StepF, _
	'	'							 ByVal stepG1 As StepG1) As Boolean
	'	'	Dim it_is As Boolean = False
	'	'	If General_Promo(stepD) And Tickets_Rewarded(stepF) And
	'	'		EligiblePlayers_Amount_Rewarded(stepG1) And Uses_EligiblePlayers_For_Points(stepE) Then
	'	'		it_is = True
	'	'	End If
	'	'	Return it_is
	'	'End Function

	'	'"Generates a random number and then selects a prize from the random prizes table based on that number."
	'	Private Function Is_Type_33(ByVal stepD As StepD, _
	'								ByVal stepF As StepF) As Boolean
	'		Dim it_is As Boolean = False
	'		If General_Promo(stepD) And Random_Prize_Rewarded(stepF) Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function

	'	'"Allows one ticket to be printed if the current month is the user's Birthday month and
	'	'the user has not had one printed this year. Ticket value is MaxCoupon value."
	'	Private Function Is_Type_34(ByVal step2 As StepB, ByVal step6 As StepG2) As Boolean
	'		Dim it_is As Boolean = False
	'		If step2.rbRecurringYes.Checked And step6.RadioButton2.Checked Then
	'			it_is = True
	'		End If
	'		Return it_is
	'	End Function
	'#End Region

	'#Region "Uses StepB And StepD"
	'	Private Function DeterminePromoName(ByVal stepB As StepB, ByVal stepD As StepD)
	'		'Grab and trim the text that is already there
	'		Dim promoName As String = stepB.txtPromoName.Text.Trim
	'		'Grab an instance of the singleton queue
	'		Dim PCWq As Queue(Of MarketingPromo) = SingletonQueue.Instance()

	'		'Deploy some logic to see if anything needs to be appended
	'		'This specifically handles "Multi-Part Single Instance"
	'		If (stepD.rbMultiPartEntryPayout.Checked And PCWq.Count = 0) Or
	'			(stepD.rbSingleEntryPayout.Checked And PCWq.Count = 0) Then
	'			promoName = "Entries - " & promoName.ToString
	'		Else
	'			promoName = "Payout - " & promoName.ToString
	'		End If

	'		Return promoName
	'	End Function
	'#End Region

	'#Region "Uses StepB And/Or StepC"
	'	Private Function DeterminePromoDate(ByVal stepB As StepB, ByVal stepC As StepC)
	'		Dim promoDate As DateTime?

	'		If Not Recurring(stepB) Then
	'			promoDate = stepC.DateTimePicker3.Value.Date
	'		Else
	'			promoDate = Nothing
	'		End If

	'		Return promoDate
	'	End Function

	'	Private Function DetermineStartDate(ByVal stepC As StepC)
	'		Return stepC.dtpQualifyingStart.Value.Date
	'	End Function

	'	Private Function DetermineEndDate(ByVal stepC As StepC)
	'		Return stepC.dtpQualifyingEnd.Value.Date
	'	End Function

	'	Private Function DetermineFrequency(ByVal stepB As StepB)
	'		Dim frequency As Char = "W"

	'		If Recurring(stepB) Then
	'			Select Case stepB.cbRecurringFrequency.Text
	'				Case "Daily"
	'					frequency = "D"
	'				Case "Weekly"
	'					frequency = "W"
	'				Case "Monthly"
	'					frequency = "M"
	'				Case "Quarterly"
	'					frequency = "Q"
	'				Case "Yearly"
	'					frequency = "Y"
	'				Case Else
	'					frequency = "W"
	'			End Select
	'		End If

	'		Return frequency
	'	End Function

	'	Private Function DetermineRecurring(ByVal stepB As StepB)
	'		Return Recurring(stepB)
	'	End Function

	'	Private Function DetermineRecursOnWeekday(ByVal stepB As StepB, ByVal stepC As StepC)
	'		Dim recursOnWeekday As String

	'		If Not Recurring(stepB) Then
	'			recursOnWeekday = Nothing
	'		Else
	'			recursOnWeekday = ""
	'			For Each itemChecked As Object In stepC.CheckedListBox1.CheckedItems
	'				Select Case itemChecked.ToString
	'					Case "Sunday"
	'						recursOnWeekday = recursOnWeekday & "N"
	'					Case "Monday"
	'						recursOnWeekday = recursOnWeekday & "M"
	'					Case "Tuesday"
	'						recursOnWeekday = recursOnWeekday & "T"
	'					Case "Wednesday"
	'						recursOnWeekday = recursOnWeekday & "W"
	'					Case "Thursday"
	'						recursOnWeekday = recursOnWeekday & "R"
	'					Case "Friday"
	'						recursOnWeekday = recursOnWeekday & "F"
	'					Case "Saturday"
	'						recursOnWeekday = recursOnWeekday & "S"
	'					Case Else
	'						recursOnWeekday = Nothing
	'				End Select
	'			Next
	'		End If

	'		Return recursOnWeekday
	'	End Function

	'	Private Function DetermineEarnsOnWeekday(ByVal stepB As StepB, ByVal stepC As StepC)
	'		Dim earnsOnWeekday As String

	'		If Not Recurring(stepB) Then
	'			earnsOnWeekday = Nothing
	'		Else
	'			earnsOnWeekday = ""
	'			For Each itemChecked As Object In stepC.clbPointsEarningDays.CheckedItems
	'				Select Case itemChecked.ToString
	'					Case "Sunday"
	'						earnsOnWeekday = earnsOnWeekday & "N"
	'					Case "Monday"
	'						earnsOnWeekday = earnsOnWeekday & "M"
	'					Case "Tuesday"
	'						earnsOnWeekday = earnsOnWeekday & "T"
	'					Case "Wednesday"
	'						earnsOnWeekday = earnsOnWeekday & "W"
	'					Case "Thursday"
	'						earnsOnWeekday = earnsOnWeekday & "R"
	'					Case "Friday"
	'						earnsOnWeekday = earnsOnWeekday & "F"
	'					Case "Saturday"
	'						earnsOnWeekday = earnsOnWeekday & "S"
	'					Case Else
	'						earnsOnWeekday = Nothing
	'				End Select
	'			Next
	'		End If

	'		Return earnsOnWeekday
	'	End Function

	'	'Private Function DetermineCountCurrentDay(ByVal stepC As StepC)
	'	'	Return stepC.RadioButton1.Checked
	'	'End Function
	'#End Region

	'#Region "Uses StepE"
	'	Private Function DeterminePointCutoff(ByVal stepE As StepE)
	'		Dim pointCutoff As Short?

	'		'If Yes -- there is a Point Cutoff
	'		If stepE.RadioButton16.Checked Then
	'			pointCutoff = Short.Parse(stepE.TextBox8.Text)
	'		Else
	'			pointCutoff = Nothing
	'		End If

	'		Return pointCutoff
	'	End Function
	'#End Region

	'#Region "Uses StepG1"
	'	'Private Function DetermineTicketsPerPromo(ByVal stepF As StepF, ByVal stepG1 As StepEntryTicketAmt)
	'	'	Dim ticketsPerPromo As Short?

	'	'	'If reward of promo is "# of Tickets" And Yes -- there is a Ticket Per Promo limit
	'	'	If stepF.RadioButton1.Checked And stepG1.rbTicketsEntirePromoYES.Checked Then
	'	'		ticketsPerPromo = Short.Parse(stepG1.txtTicketsEntirePromo.Text)
	'	'	Else
	'	'		ticketsPerPromo = Nothing
	'	'	End If

	'	'	Return ticketsPerPromo
	'	'End Function

	'	'Private Function DetermineTicketsPerPatron(ByVal stepF As StepF, ByVal stepG1 As StepEntryTicketAmt)
	'	'	Dim ticketsPerPatron As Short?

	'	'	'If reward of promo is "# of Tickets" And Yes -- there is a Ticket Per Patron limit
	'	'	If stepF.RadioButton1.Checked And stepG1.rbTicketPerPatronYES.Checked Then
	'	'		ticketsPerPatron = Short.Parse(stepG1.txtTicketsPerPatron.Text)
	'	'	Else
	'	'		ticketsPerPatron = Nothing
	'	'	End If

	'	'	Return ticketsPerPatron
	'	'End Function

	'	'Private Function DeterminePointDivisor(ByVal stepF As StepF, ByVal stepG1 As StepEntryTicketAmt)
	'	'	Dim pointDivisor As Short?

	'	'	'If reward of promo is "# of Tickets" And ticket amount is "Compound Amount" Or "Complex Amount"
	'	'	If stepF.RadioButton1.Checked And (stepG1.rbCalPlusNumOfVisits.Checked Or stepG1.rbCalculated.Checked) Then
	'	'		pointDivisor = Short.Parse(stepG1.txtPointsDivisor.Text)
	'	'	Else
	'	'		pointDivisor = Nothing
	'	'	End If

	'	'	Return pointDivisor
	'	'End Function
	'#End Region

	'#Region "Uses StepG2"
	'	Private Function DetermineCouponID(ByVal stepF As StepF, ByVal stepG2 As StepG2)
	'		Dim couponID As String

	'		'If reward of promo is "FreePlay Coupon"
	'		If stepF.RadioButton5.Checked Then
	'			couponID = stepG2.TextBox1.Text
	'		Else
	'			couponID = Nothing
	'		End If

	'		Return couponID
	'	End Function

	'	Private Function DeterminePromoMaxCoupon(ByVal stepF As StepF, ByVal stepG2 As StepG2)
	'		Dim promoMaxCoupon As Decimal?

	'		'If reward of promo is "FreePlay Coupon"
	'		If stepF.RadioButton5.Checked Then
	'			promoMaxCoupon = Decimal.Parse(stepG2.TextBox3.Text)
	'		Else
	'			promoMaxCoupon = Nothing
	'		End If

	'		Return promoMaxCoupon
	'	End Function

	'	Private Function DetermineMaxCoupon(ByVal stepF As StepF, ByVal stepG2 As StepG2)
	'		Dim maxCoupon As Decimal?

	'		'If reward of promo is "FreePlay Coupon" And value not prompted
	'		If stepF.RadioButton5.Checked And stepG2.RadioButton2.Checked Then
	'			maxCoupon = Decimal.Parse(stepG2.TextBox2.Text)
	'		Else
	'			maxCoupon = Nothing
	'		End If

	'		Return maxCoupon
	'	End Function
	'#End Region

	'#Region "Uses StepF"
	'	'Private Function DeterminePrintTickets(ByVal stepF As StepF)
	'	'	'True if reward of promo is "# of Tickets"
	'	'	Return stepF.RadioButton1.Checked
	'	'End Function
	'#End Region

	'#Region "Uses StepH"
	'	Private Function DetermineComments(ByVal stepH As StepH)
	'		Dim comments As String

	'		'If Yes -- We want to comment
	'		If stepH.RadioButton1.Checked Then
	'			'Trim for safety! You can never be too careful.
	'			comments = stepH.RichTextBox1.Text.Trim
	'			'Appends with a space first,
	'			'otherwise just make the creator string the comment.
	'			comments = comments & " (" & DateTime.Today.ToShortDateString & " * " & Environment.UserName.ToString & ")"
	'		Else
	'			comments = "(" & DateTime.Today.ToShortDateString & " * " & Environment.UserName.ToString & ")"
	'		End If

	'		Return comments
	'	End Function
	'#End Region

	'#Region "Utility Functions"
	'	'Sometimes it's just easier to use Utility Functions
	'	'Increases readability and decreases duplicate code (DRY)
	'	Private Function Recurring(ByVal stepB As StepB)
	'		Return stepB.rbRecurringYes.Checked
	'	End Function

	'	Private Function General_Promo(ByVal stepD As StepD)
	'		Return stepD.rbSingleEntryOnly.Checked
	'	End Function

	'	Private Function Acquisition_Promo(ByVal stepD As StepD)
	'		Return stepD.rbAcquisition.Checked
	'	End Function

	'	'Commented out when changing StepC
	'	'Private Function Same_Day_Points_Not_Compatible(ByVal stepC As StepC)
	'	'	Return stepC.RadioButton2.Checked
	'	'End Function

	'	Private Function Give_Regardless_Of_Points(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox1.Text = "Give reward regardless of points", True, False)
	'	End Function

	'	Private Function Sums_Lifetime_Points(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox1.Text = "Sums lifetime points", True, False)
	'	End Function

	'	Private Function Sums_Start_End_Points(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox1.Text = "Sums points between start and end dates", True, False)
	'	End Function

	'	Private Function Uses_EligiblePlayers_For_Points(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox1.Text = "Uses EligiblePlayers table to determine points", True, False)
	'	End Function

	'	Private Function Greater_Than(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox2.Text = "PT > (greater than) PC", True, False)
	'	End Function

	'	Private Function Greater_Than_Or_Equal_To(ByVal stepE As StepE)
	'		Return If(stepE.ComboBox2.Text = "PT >= (greater than or equal to) PC", True, False)
	'	End Function

	'	Private Function Yes_PointCutoff(ByVal stepE As StepE)
	'		Return stepE.RadioButton16.Checked
	'	End Function

	'	Private Function No_PointCutoff(ByVal stepE As StepE)
	'		Return stepE.RadioButton17.Checked
	'	End Function

	'	'Private Function Tickets_Rewarded(ByVal stepF As StepF)
	'	'	Return stepF.RadioButton1.Checked
	'	'End Function

	'	Private Function Random_Prize_Rewarded(ByVal stepF As StepF)
	'		Return stepF.RadioButton4.Checked
	'	End Function

	'	Private Function One_Ticket_Rewarded(ByVal stepG1 As StepEntryTicketAmt)
	'		Return stepG1.rb1.Checked
	'	End Function

	'	Private Function Count_Amount_Rewarded(ByVal stepG1 As StepEntryTicketAmt)
	'		Return stepG1.rbNumOfVisits.Checked
	'	End Function

	'	Private Function Compound_Amount_Rewarded(ByVal stepG1 As StepEntryTicketAmt)
	'		Return stepG1.rbCalculated.Checked
	'	End Function

	'	Private Function Complex_Amount_Rewarded(ByVal stepG1 As StepEntryTicketAmt)
	'		Return stepG1.rbCalPlusNumOfVisits.Checked
	'	End Function

	'	'Private Function EligiblePlayers_Amount_Rewarded(ByVal stepG1 As StepG1)
	'	'	Return stepG1.RadioButton10.Checked
	'	'End Function

	'	Private Function Limit_Tickets_Per_Patron(ByVal stepG1 As StepEntryTicketAmt)
	'		Return stepG1.rbTicketPerPatronYES.Checked
	'	End Function

	'	Private Function Limit_Amount_Is_One(ByVal stepG1 As StepEntryTicketAmt)
	'		Return If(stepG1.txtTicketsPerPatron.Text = "1", True, False)
	'	End Function
	'#End Region

	'Disable the Cancel Button at the end
	Public Sub CancelEnabled(state As Boolean)
		Me.cancel.Enabled = state
	End Sub
#Region "OnClosing"
	'It really bothered me that the dialog boxes did not center on their parent window.
	'The Sub and Function that follows are a direct override of TSWizard.BaseWizard.OnClosing.
	'The only difference here is that the dialog now centers on the parent window. SUCCESS!
	Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
		If DialogResult = DialogResult.Cancel Then
			e.Cancel = Not AskToClose()
		End If
	End Sub

	Private Function AskToClose()
		Dim cancelMsgString As String = <a>Do you wish to quit the wizard now?
Your changes will not be saved if you do.</a>.Value

		Dim result As Integer = CenteredMessagebox.MsgBox.Show(cancelMsgString, "Exit wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If result = DialogResult.Yes Then
			Return True
		Else
			Return False
		End If
	End Function
#End Region
End Class

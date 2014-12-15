Imports TSWizards
Imports CenteredMessagebox
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Linq

Public Class PCW
    Inherits TSWizards.BaseWizard

    Private infoCircle As FontAwesomeIcons.IconButton = New FontAwesomeIcons.IconButton

#Region "New"
    'Not entirely sure if this was needed,
    'but it got added and works
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cancel.Visible = True
        Me.back.Visible = True
    End Sub
#End Region

#Region "PCW_LoadSteps"
    'This is an important subroutine.
    'This creates instances of the Step classes,
    'names them and associates them to the Wizard (PCW).
    'A Step can be generated dynamically during runtime,
    'but the better option is just to create a Step and add it here.
    Private Sub PCW_LoadSteps(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles MyBase.LoadSteps

        AddStep("StepA", New StepA)
        AddStep("StepB", New StepB)
        AddStep("StepC", New StepC)
        AddStep("StepD", New StepD)

        AddStep("Step5", New Step5)
        AddStep("Step5X5", New Step5X5)
        AddStep("Step6", New Step6)
        AddStep("StepK", New StepK)
        AddStep("StepL", New StepL)
        AddStep("StepM", New StepM)
        AddStep("StepN", New StepN)
    End Sub
#End Region

    Public Function PCW_StepThroughEntriesPayout(ByVal numOfEntries As Short)
        Dim entriesQ As System.Collections.Queue = New Queue
        Dim step2 As StepB = Me.GetStep("Step2")

        AddStep("entriesLoop_step3", New Step3)
		AddStep("entriesLoop_step4", New StepC)
		AddStep("entriesLoop_step5", New Step5)
		AddStep("entriesLoop_step5X5", New Step5X5)
		AddStep("entriesLoop_step6", New Step6)
		AddStep("entriesLoop_stepK", New StepK)

		Me.GetStep("entriesLoop_step3").NextStep = "entriesLoop_step5"
		Me.GetStep("entriesLoop_step4").NextStep = "entriesLoop_step5"
		Me.GetStep("entriesLoop_step5").NextStep = "entriesLoop_step5X5"
		Me.GetStep("entriesLoop_step5X5").NextStep = "entriesLoop_step6"
		Me.GetStep("entriesLoop_step6").NextStep = "entriesLoop_stepK"

		Me.GetStep("entriesLoop_stepK").NextStep = "entriesLoop_step5"

		'ENTRIES LOOP
		If step2.RadioButton4.Checked Then
			'Show Step3
		Else
			'Show Step4
		End If

		Return entriesQ
	End Function

	Public Function PCW_GetPromo()
		'Initialize the entity
		Dim newPromo As MarketingPromo = New MarketingPromo

		'Initialize the Steps
		Dim step2 As StepB = Me.GetStep("Step2")
		Dim step3 As Step3 = Me.GetStep("Step3")
		Dim step4 As StepC = Me.GetStep("Step4")
		Dim step5 As Step5 = Me.GetStep("Step5")
		Dim step5X5 As Step5X5 = Me.GetStep("Step5X5")
		Dim step6 As Step6 = Me.GetStep("Step6")
		Dim stepK As StepK = Me.GetStep("StepK")

		'Make sure that we are who we say we are
		If IsNothing(step2) Or IsNothing(step3) Or IsNothing(step4) Or IsNothing(step5) Or IsNothing(step6) Or IsNothing(stepK) Then
			Throw New ApplicationException("Oh no! A Step is not the Step that it claims to be!")
		End If

		'Gather the step results and put into the entity
		newPromo.PromoName = DeterminePromoName(step2)
		newPromo.PromoDate = DeterminePromoDate(step2, step3, step4)
		newPromo.StartDate = DetermineStartDate(step2, step3, step4)
		newPromo.EndDate = DetermineEndDate(step2, step3, step4)
		newPromo.PointCutoff = DeterminePointCutoff(step5)
		newPromo.PointDivisor = DeterminePointDivisor(step5)
		newPromo.MaxTickets = DetermineMaxTickets(step5)
		newPromo.PromoMaxTickets = DeterminePromoMaxTickets(step5)
		newPromo.MaxCoupon = DetermineMaxCoupon(step2, step6)
		newPromo.PromoMaxCoupon = DeterminePromoMaxCoupon(step2, step6)
		newPromo.CouponID = DetermineCouponID(step2, step6)
		newPromo.Recurring = DetermineRecurring(step2)
		newPromo.Frequency = DetermineFrequency(step2)
		newPromo.RecursOnWeekday = DetermineRecursOnWeekday(step2, step4)
		newPromo.EarnsOnWeekday = DetermineEarnsOnWeekday(step2, step4)
		newPromo.CountCurrentDay = DetermineCountCurrentDay(step2, step3, step4)
		newPromo.PrintTickets = DeterminePrintTickets(step5)
		newPromo.Comments = DetermineComments(stepK)
		newPromo.PromoType = DeterminePromoType(step2, step3, step4, step5, step5X5, step6)
		newPromo.Query = DetermineQuery(newPromo.PromoType)
		Return newPromo
	End Function

	Private Function DeterminePromoName(ByVal step2 As StepB)
		'Grab and trim the text that is already there
		Dim promoName As String = step2.TextBox1.Text.Trim
		'Grab an instance of the singleton queue
		Dim PCWq As Queue(Of MarketingPromo) = SingletonQueue.Instance()

		'Deploy some logic to see if anything needs to be appended
		'This specifically handles "Multi-Part Single Instance"
		If step2.RadioButton7.Checked And PCWq.Count = 0 Then
			promoName = "Entries - " & promoName.ToString
		Else
			promoName = "Payout - " & promoName.ToString
		End If

		Return promoName
	End Function

	Private Function DetermineQuery(ByVal promoType As String)
		Dim query As Short?

		'Get the first two characters.
		If Not IsNothing(promoType) Then
			query = Short.Parse(promoType.Substring(0, 1))
		Else
			query = Nothing
		End If

		Return query
	End Function

#Region "DeterminePromoType"
	'This is this function routes to other functions,
	'just trying to figure out the promotype.
	'And yes, I know that this is not a very efficient method.
	Private Function DeterminePromoType(ByVal step2 As StepB, _
										ByVal step3 As Step3, _
										ByVal step4 As StepC, _
										ByVal step5 As Step5, _
										ByVal step5X5 As Step5X5, _
										ByVal step6 As Step6)
		Dim result As String
		If Is_Type_20(step2, step5, step5X5) Then
			result = "20"
			Return result
		ElseIf Is_Type_20A(step2, step5, step5X5) Then
			result = "20A"
			Return result
		ElseIf Is_Type_21(step2, step5) Then
			result = "21"
			Return result
		ElseIf Is_Type_22(step2, step5, step5X5) Then
			result = "22"
			Return result
		ElseIf Is_Type_22A(step2, step5, step5X5) Then
			result = "22A"
			Return result
		ElseIf Is_Type_22B(step2, step5, step5X5) Then
			result = "22B"
			Return result
		ElseIf Is_Type_23(step2, step5, step5X5) Then
			result = "23"
			Return result
		ElseIf Is_Type_24(step2, step5, step5X5) Then
			result = "24"
			Return result
		ElseIf Is_Type_25(step2, step5, step5X5) Then
			result = "25"
			Return result
			'Not sure how to determine a 25A at the moment. :\
			'ElseIf Is_Type_25A(step2, step3, step4, step5, step6) Then
			'    result = "25A"
			'    Return result
		ElseIf Is_Type_26(step2, step5, step5X5) Then
			result = "26"
			Return result
		ElseIf Is_Type_27(step2, step5, step5X5) Then
			result = "27"
			Return result
		ElseIf Is_Type_28(step2, step4, step5, step5X5) Then
			result = "28"
			Return result
		ElseIf Is_Type_29(step2, step5) Then
			result = "29"
			Return result
		ElseIf Is_Type_30(step2, step5, step5X5) Then
			result = "30"
			Return result
		ElseIf Is_Type_31(step2, step5) Then
			result = "31"
			Return result
		ElseIf Is_Type_31A(step2, step5) Then
			result = "31A"
			Return result
		ElseIf Is_Type_31B(step2, step6) Then
			result = "31B"
			Return result
		ElseIf Is_Type_31C(step2, step6) Then
			result = "31C"
			Return result
		ElseIf Is_Type_32(step2, step5, step5X5) Then
			result = "32"
			Return result
		ElseIf Is_Type_32A(step2, step5, step5X5) Then
			result = "32A"
			Return result
		ElseIf Is_Type_33(step2, step5) Then
			result = "33"
			Return result
		ElseIf Is_Type_34(step2, step6) Then
			result = "34"
			Return result
		Else
			result = Nothing
			Return result
		End If
	End Function

	'"Gives out 1 ticket regardless of points if player has Players club account."
	Private Function Is_Type_20(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton13.Checked And step5X5.ComboBox1.Text = "Gives reward regardless of points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Gives out 1 ticket between start and end, per account."
	Private Function Is_Type_20A(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton12.Checked And step5.TextBox6.Text = "1" And step5X5.ComboBox1.Text = "Gives reward regardless of points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table and gives one ticket if lifetime points are greater than or equal to cutoff."
	Private Function Is_Type_21(ByVal step2 As StepB, _
								ByVal step5 As Step5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table where the date is between start and end date and gives one ticket if total points are greater than or equal to cutoff."
	Private Function Is_Type_22(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"If points are greater than cutoff, prints one ticket up to "max tickets," but only one per day."
	Private Function Is_Type_22A(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than" And step5.RadioButton12.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"If points are greater than cutoff, prints one ticket between start and end date if player has signed up for new account between start and end.
	'Redemption date cannot be same as enroll date."
	Private Function Is_Type_22B(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton3.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table and does a count of the date field in the points table where the date is between start and end date and returns the count as number of tickets
	'if total points are greater than or equal to cutoff."
	Private Function Is_Type_23(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton9.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table where date is between start and end date, divides that by the point divisor and then
	'adds it to a count of the date field to get the number of tickets if total points is greater than cutoff."
	Private Function Is_Type_24(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton6.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than" And (step5.TextBox5.Text <> "" Or step5.TextBox5.Text <> "Enter # Here") Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table where the date is between start and end date and then divides that by the point divisor
	'to determine amount of tickets if the total points is greater than or equal to cutoff."
	Private Function Is_Type_25(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton7.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" And (step5.TextBox5.Text <> "" Or step5.TextBox5.Text <> "Enter # Here") Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table where the date falls on current week. Then divides that by the point divisor to
	'determine amount of tickets if total points are greater than or equal to cutoff."
	'Private Function Is_Type_25A(ByVal step2 As Step2, _
	'                            ByVal step3 As Step3, _
	'                            ByVal step4 As Step4, _
	'                            ByVal step5 As Step5, _
	'                            ByVal step5X5 As Step5X5, _
	'                            ByVal step6 As Step6) As Boolean
	'    Dim it_is As Boolean = False
	'    If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" Then
	'        it_is = True
	'    End If
	'    Return it_is
	'End Function

	'"Selects the number of tickets from the Eligible Players Table."
	Private Function Is_Type_26(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton10.Checked And step5.RadioButton17.Checked And step5X5.ComboBox1.Text = "Gives reward regardless of points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Sums up total points from points table where date is between start and end date and then selects the number of tickets from
	'the eligible players table if total points are greater than or equal to cutoff."
	Private Function Is_Type_27(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton10.Checked And step5.RadioButton16.Checked And (step5.TextBox5.Text <> "" Or step5.TextBox5.Text <> "Enter # Here") And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Will do a count of the date field in the points table where handle is greater than or equal to cutoff and where the date is
	'one of the days listed in the earns on field and return that as the number of tickets. Not compatible with Same-Day Points."
	Private Function Is_Type_28(ByVal step2 As StepB, _
								ByVal step4 As StepC, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step2.RadioButton4.Checked And step4.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton9.Checked And step5.RadioButton16.Checked And step5X5.ComboBox1.Text = "Sums points between start and end dates" And step5X5.ComboBox2.Text = "greater than or equal to" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Will prompt to select a prize from a dropdown box and then print one ticket for that prize for that day."
	Private Function Is_Type_29(ByVal step2 As StepB, ByVal step5 As Step5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton4.Checked And step5.RadioButton12.Checked And step5.CheckBox1.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Will prompt for number of tickets to print and then print them without checking if the player has already got tickets for that day."
	Private Function Is_Type_30(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton11.Checked And step5.RadioButton17.Checked And step5X5.ComboBox1.Text = "Gives reward regardless of points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Will prompt to select a prize from a dropdown box and then print one ticket for that prize and will allow multiple prints for the same day."
	Private Function Is_Type_31(ByVal step2 As StepB, ByVal step5 As Step5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton4.Checked And step5.RadioButton13.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Similar to 31, other than it is a prompt with free form entry of cash value."
	Private Function Is_Type_31A(ByVal step2 As StepB, ByVal step5 As Step5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton3.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Similar to 31A, other than it is a prompt with free form entry of cash value and prints on receipt and creates validated free play offer."
	Private Function Is_Type_31B(ByVal step2 As StepB, ByVal step6 As Step6) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton1.Checked And step6.RadioButton1.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Similar to 31B, but no prompt. Value of receipt is always value of MaxCoupon."
	Private Function Is_Type_31C(ByVal step2 As StepB, ByVal step6 As Step6) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton1.Checked And step6.RadioButton2.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Allows one ticket to be printed weekly, monthly, quarterly, or yearly if account is in eligible players table."
	Private Function Is_Type_32(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton8.Checked And step5X5.ComboBox1.Text = "Uses EligiblePlayers table to determine points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Allows one ticket to be printed daily, weekly, monthly, quarterly, or yearly if account is in eligible players table. Uses EligiblePlayers table to determine who and how many to print."
	Private Function Is_Type_32A(ByVal step2 As StepB, _
								ByVal step5 As Step5, _
								ByVal step5X5 As Step5X5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton1.Checked And step5.RadioButton10.Checked And step5X5.ComboBox1.Text = "Uses EligiblePlayers table to determine points" Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Generates a random number and then selects a prize from the random prizes table based on that number."
	Private Function Is_Type_33(ByVal step2 As StepB, ByVal step5 As Step5) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton2.Checked And step5.RadioButton5.Checked Then
			it_is = True
		End If
		Return it_is
	End Function

	'"Allows one ticket to be printed if the current month is the user's Birthday month and the user has not had one printed this year.
	'Ticket value is MaxCoupon value."
	Private Function Is_Type_34(ByVal step2 As StepB, ByVal step6 As Step6) As Boolean
		Dim it_is As Boolean = False
		If step2.RadioButton4.Checked And step6.RadioButton2.Checked Then
			it_is = True
		End If
		Return it_is
	End Function
#End Region

	Private Function DetermineCouponID(ByVal step2 As StepB, ByVal step6 As Step6)
		Dim couponID As String

		If step2.RadioButton1.Checked Or step2.RadioButton6.Checked Or step2.RadioButton7.Checked Then
			couponID = step6.TextBox1.Text
		Else
			couponID = Nothing
		End If

		Return couponID
	End Function

	Private Function DeterminePromoMaxCoupon(ByVal step2 As StepB, ByVal step6 As Step6)
		Dim promoMaxCoupon As Decimal?

		If step2.RadioButton1.Checked Or step2.RadioButton6.Checked Or step2.RadioButton7.Checked Then
			promoMaxCoupon = Decimal.Parse(step6.TextBox3.Text)
		Else
			promoMaxCoupon = Nothing
		End If

		Return promoMaxCoupon
	End Function

	Private Function DetermineMaxCoupon(ByVal step2 As StepB, ByVal step6 As Step6)
		Dim maxCoupon As Decimal?

		If step2.RadioButton1.Checked Or step2.RadioButton6.Checked Or step2.RadioButton7.Checked Then
			maxCoupon = Decimal.Parse(step6.TextBox2.Text)
		Else
			maxCoupon = Nothing
		End If

		Return maxCoupon
	End Function

	Private Function DeterminePointCutoff(ByVal step5 As Step5)
		Dim pointCutoff As Short?

		If step5.RadioButton16.Checked Then
			pointCutoff = Short.Parse(step5.TextBox8.Text)
		Else
			pointCutoff = Nothing
		End If

		Return pointCutoff
	End Function

	Private Function DetermineEarnsOnWeekday(ByVal step2 As StepB, ByVal step4 As StepC)
		Dim earnsOnWeekday As String

		If step2.RadioButton5.Checked Then
			earnsOnWeekday = Nothing
		Else
			earnsOnWeekday = ""
			For Each itemChecked As Object In step4.CheckedListBox2.CheckedItems
				Select Case itemChecked.ToString
					Case "Sunday"
						earnsOnWeekday = earnsOnWeekday & "N"
					Case "Monday"
						earnsOnWeekday = earnsOnWeekday & "M"
					Case "Tuesday"
						earnsOnWeekday = earnsOnWeekday & "T"
					Case "Wednesday"
						earnsOnWeekday = earnsOnWeekday & "W"
					Case "Thursday"
						earnsOnWeekday = earnsOnWeekday & "R"
					Case "Friday"
						earnsOnWeekday = earnsOnWeekday & "F"
					Case "Saturday"
						earnsOnWeekday = earnsOnWeekday & "S"
					Case Else
						earnsOnWeekday = Nothing
				End Select
			Next
		End If

		Return earnsOnWeekday
	End Function

	Private Function DetermineRecursOnWeekday(ByVal step2 As StepB, ByVal step4 As StepC)
		Dim recursOnWeekday As String

		If step2.RadioButton5.Checked Then
			recursOnWeekday = Nothing
		Else
			recursOnWeekday = ""
			For Each itemChecked As Object In step4.CheckedListBox1.CheckedItems
				Select Case itemChecked.ToString
					Case "Sunday"
						recursOnWeekday = recursOnWeekday & "N"
					Case "Monday"
						recursOnWeekday = recursOnWeekday & "M"
					Case "Tuesday"
						recursOnWeekday = recursOnWeekday & "T"
					Case "Wednesday"
						recursOnWeekday = recursOnWeekday & "W"
					Case "Thursday"
						recursOnWeekday = recursOnWeekday & "R"
					Case "Friday"
						recursOnWeekday = recursOnWeekday & "F"
					Case "Saturday"
						recursOnWeekday = recursOnWeekday & "S"
					Case Else
						recursOnWeekday = Nothing
				End Select
			Next
		End If

		Return recursOnWeekday
	End Function

	Private Function DeterminePrintTickets(ByVal step5 As Step5)
		Dim printTickets As Boolean = False

		If step5.RadioButton1.Checked Then
			printTickets = True
		End If

		Return printTickets
	End Function

	Private Function DetermineCountCurrentDay(ByVal step2 As StepB, ByVal step3 As Step3, ByVal step4 As StepC)
		Dim countCurrentDay As Boolean = False

		If step2.RadioButton4.Checked Then
			If step4.RadioButton1.Checked Then
				countCurrentDay = True
			ElseIf DateTime.Compare(step3.DateTimePicker3.Value.Date, step3.DateTimePicker1.Value.Date) = 0 Then
				countCurrentDay = True
			End If
		End If

		Return countCurrentDay
	End Function

	Private Function DetermineFrequency(ByVal step2 As StepB)
		Dim frequency As Char = "W"

		If step2.RadioButton4.Checked Then
			Select Case step2.ComboBox2.Text
				Case "Daily"
					frequency = "D"
				Case "Weekly"
					frequency = "W"
				Case "Monthly"
					frequency = "M"
				Case "Yearly"
					frequency = "Y"
				Case Else
					frequency = "W"
			End Select
		End If

		Return frequency
	End Function

	Private Function DetermineRecurring(ByVal step2 As StepB)
		Dim recurring As Boolean = False

		If step2.RadioButton4.Checked Then
			recurring = True
		End If

		Return recurring
	End Function

	Private Function DetermineComments(ByVal stepK As StepK)
		Dim comments As String

		If stepK.RadioButton1.Checked Then
			'Trimmed because you never know.
			comments = stepK.RichTextBox1.Text.Trim
			'Seems a little redundant, but if there is a comment, it appends with a space first,
			'otherwise it just makes the creator string the comment.
			comments = comments & " (" & DateTime.Today.ToShortDateString & " * " & Environment.UserName.ToString & ")"
		Else
			comments = "(" & DateTime.Today.ToShortDateString & " * " & Environment.UserName.ToString & ")"
		End If

		Return comments
	End Function

	Private Function DeterminePromoMaxTickets(ByVal step5 As Step5)
		Dim promoMaxTickets As Short?

		If step5.RadioButton1.Checked And step5.RadioButton14.Checked Then
			promoMaxTickets = Short.Parse(step5.TextBox7.Text)
		Else
			promoMaxTickets = Nothing
		End If

		Return promoMaxTickets
	End Function

	Private Function DetermineMaxTickets(ByVal step5 As Step5)
		Dim maxTickets As Short?

		If step5.RadioButton1.Checked And step5.RadioButton12.Checked Then
			maxTickets = Short.Parse(step5.TextBox6.Text)
		Else
			maxTickets = Nothing
		End If

		Return maxTickets
	End Function

	Private Function DeterminePointDivisor(ByVal step5 As Step5)
		Dim pointDivisor As Short?

		If step5.RadioButton1.Checked And (step5.RadioButton6.Checked Or step5.RadioButton7.Checked) Then
			pointDivisor = Short.Parse(step5.TextBox5.Text)
		Else
			pointDivisor = Nothing
		End If

		Return pointDivisor
	End Function

	Private Function DeterminePromoDate(ByVal step2 As StepB, ByVal step3 As Step3, ByVal step4 As StepC)
		Dim promoDate As DateTime?

		'Check the recurring button that determines everything
		If Recurring(step2) Then
			promoDate = step3.DateTimePicker1.Value.Date
		Else
			promoDate = Nothing
		End If

		Return promoDate
	End Function

	Private Function DetermineStartDate(ByVal step2 As StepB, ByVal step3 As Step3, ByVal step4 As StepC)
		Dim startDate As DateTime

		If Recurring(step2) Then
			startDate = step3.DateTimePicker2.Value.Date
		Else
			startDate = step4.DateTimePicker1.Value.Date
		End If

		Return startDate
	End Function

	Private Function DetermineEndDate(ByVal step2 As StepB, ByVal step3 As Step3, ByVal step4 As StepC)
		Dim endDate As DateTime

		If Recurring(step2) Then
			endDate = step3.DateTimePicker3.Value.Date
		Else
			endDate = step4.DateTimePicker2.Value.Date
		End If

		Return endDate
	End Function

    'Not exactly necessary but it makes the code read well
    Private Function Recurring(ByVal step2 As StepB)
        Return step2.RadioButton5.Checked
    End Function

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

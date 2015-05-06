Imports System.Collections
Imports Key = PromotionalCreationWizard.PCW_Data.PromoFields

Public Class PCW_Data
#Region "Fields (Key)"
	Public Enum PromoFields
		ID
		Name
		Type
		OccursDate
		StartDate
		EndDate
		PointCutoffLimit
		PointsDivisor
		TicketsPerPatron
		TicketsForEntirePromo
		CouponAmtPerPatron
		CouponAmtForEntirePromo
		MaxNumOfCouponsPerPatron
		CouponID
		Recurring
		RecurringFrequency
		RecursOnWeekday
		EarnsOnWeekday
		CountCurrentDay
		OverrideTime
		CutoffTime
		PrintTickets
		Comment
	End Enum
#End Region
#Region "Categories"
	Public Enum PromoCategory
		entryAndPayout
		entryOnly
		payoutOnly
		multPart
		acquisition
	End Enum
#End Region
#Region "Properties"
	Private _pcwMarketingPromosDBRowsList As ArrayList = New ArrayList()
	Private _pcwPromoDataHash As Hashtable = New Hashtable()
	Private _pcwPromoStepList As ArrayList = New ArrayList()
	Private _pcwReset As Boolean = False
	Private _pcwResetTo As String = New String("StepA")

	Public Property MarketingPromosDBRowsList As ArrayList
		Get
			Return _pcwMarketingPromosDBRowsList
		End Get
		Set(value As ArrayList)
			_pcwMarketingPromosDBRowsList = value
		End Set
	End Property
	Public Property PromoDataHash As Hashtable
		Get
			Return _pcwPromoDataHash
		End Get
		Set(value As Hashtable)
			_pcwPromoDataHash = value
		End Set
	End Property
	Public Property PromoStepList As ArrayList
		Get
			Return _pcwPromoStepList
		End Get
		Set(value As ArrayList)
			_pcwPromoStepList = value
		End Set
	End Property
	Public Property Reset As Boolean
		Get
			Return _pcwReset
		End Get
		Set(ByVal value As Boolean)
			_pcwReset = value
		End Set
	End Property
	Public Property ResetTo As String
		Get
			Return _pcwResetTo
		End Get
		Set(value As String)
			_pcwResetTo = value
		End Set
	End Property
#End Region
#Region "AddPromoToList"
	Public Sub AddPromoToList()
		MarketingPromosDBRowsList.Add(GetMarketingPromo())
	End Sub
#End Region
#Region "GetMarketingPromo"
	Private Function GetMarketingPromo() As MarketingPromo
		Dim newPromo As MarketingPromo = New MarketingPromo
		newPromo.PromoID = PromoDataHash.Item(Key.ID)
		newPromo.PromoName = PromoDataHash.Item(Key.Name)
		newPromo.PromoType = PromoDataHash.Item(Key.Type)
		newPromo.PromoDate = PromoDataHash.Item(Key.OccursDate)
		newPromo.StartDate = PromoDataHash.Item(Key.StartDate)
		newPromo.EndDate = PromoDataHash.Item(Key.EndDate)
		newPromo.PointCutoff = PromoDataHash.Item(Key.PointCutoffLimit)
		newPromo.PointDivisor = PromoDataHash.Item(Key.PointsDivisor)
		newPromo.MaxTickets = PromoDataHash.Item(Key.TicketsPerPatron)
		newPromo.PromoMaxTickets = PromoDataHash.Item(Key.TicketsForEntirePromo)
		newPromo.MaxCoupon = PromoDataHash.Item(Key.CouponAmtPerPatron)
		newPromo.PromoMaxCoupon = PromoDataHash.Item(Key.CouponAmtForEntirePromo)
		newPromo.CouponID = PromoDataHash.Item(Key.CouponID)
		newPromo.Recurring = PromoDataHash.Item(Key.Recurring)
		newPromo.Frequency = PromoDataHash.Item(Key.RecurringFrequency)
		newPromo.RecursOnWeekday = PromoDataHash.Item(Key.RecursOnWeekday)
		newPromo.EarnsOnWeekday = PromoDataHash.Item(Key.EarnsOnWeekday)
		newPromo.CountCurrentDay = PromoDataHash.Item(Key.CountCurrentDay)
		newPromo.OverrideTime = PromoDataHash.Item(Key.OverrideTime)
		newPromo.CutoffTime = PromoDataHash.Item(Key.CutoffTime)
		newPromo.PrintTickets = PromoDataHash.Item(Key.PrintTickets)
		newPromo.Comments = PromoDataHash.Item(Key.Comment)
		Return newPromo
	End Function
#End Region
#Region "GetPromoSummary"
	Public Function GetPromoSummary() As System.Text.StringBuilder
		Dim dateFormatStr As String = New String("{0:MM/dd/yyyy}")
		Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder

		'PromoDataHash.Add(Key.MaxNumOfCouponsPerPatron, MaxNumOfCouponsPerPatron)

		'Now that the NULL formalities are out of the way,
		'we can actually build the string that the user will read.
		'builder.Append("      PromoType: " & promoType & vbCrLf)
		builder.Append("             ID: " & nullIfNothing(Key.ID) & vbCrLf)
		builder.Append("           Name: " & nullIfNothing(Key.Name) & vbCrLf)
		builder.Append("           Date: " & nullIfNothing(Key.OccursDate, dateFormatStr) & vbCrLf)
		builder.Append("      StartDate: " & nullIfNothing(Key.StartDate, dateFormatStr) & vbCrLf)
		builder.Append("        EndDate: " & nullIfNothing(Key.EndDate, dateFormatStr) & vbCrLf)
		builder.Append("    PointCutoff: " & nullIfNothing(Key.PointCutoffLimit) & vbCrLf)
		builder.Append("  PointsDivisor: " & nullIfNothing(Key.PointsDivisor) & vbCrLf)
		builder.Append("     MaxTickets: " & nullIfNothing(Key.TicketsPerPatron) & vbCrLf)
		builder.Append("PromoMaxTickets: " & nullIfNothing(Key.TicketsForEntirePromo) & vbCrLf)
		builder.Append("      MaxCoupon: " & nullIfNothing(Key.CouponAmtPerPatron) & vbCrLf)
		builder.Append(" PromoMaxCoupon: " & nullIfNothing(Key.CouponAmtForEntirePromo) & vbCrLf)
		builder.Append("       CouponID: " & nullIfNothing(Key.CouponID) & vbCrLf)
		builder.Append("      Recurring: " & nullIfNothing(Key.Recurring) & vbCrLf)
		builder.Append("      Frequency: " & nullIfNothing(Key.RecurringFrequency) & vbCrLf)
		builder.Append("RecursOnWeekday: " & nullIfNothing(Key.RecursOnWeekday) & vbCrLf)
		builder.Append(" EarnsOnWeekday: " & nullIfNothing(Key.EarnsOnWeekday) & vbCrLf)
		builder.Append("CountCurrentDay: " & nullIfNothing(Key.CountCurrentDay) & vbCrLf)
		builder.Append("   PrintTickets: " & nullIfNothing(Key.PrintTickets) & vbCrLf)
		builder.Append("        Comment: " & nullIfNothing(Key.Comment) & vbCrLf)
		Return builder
	End Function

	Private Function nullIfNothing(ByVal key As PromoFields) As String
		Dim result As String = New String("")
		If IsNothing(PromoDataHash.Item(key)) Then
			result = "NULL"
		Else
			result = PromoDataHash.Item(key).ToString
		End If
		Return result
	End Function

	Private Function nullIfNothing(ByVal key As PromoFields, ByVal dateFormatStr As String) As String
		Dim result As String = New String("")
		If IsNothing(PromoDataHash.Item(key)) Then
			result = "NULL"
		Else
			result = String.Format(dateFormatStr, PromoDataHash.Item(key))
		End If
		Return result
	End Function
#End Region
#Region "SubmitPromoDBRowsToMarketingPromosTable"
	Public Sub SubmitPromoDBRowsToMarketingPromosTable()
		Dim tbl As PCWLINQ2SQLDataContext = New PCWLINQ2SQLDataContext(Global _
																	  .PromotionalCreationWizard _
																	  .My _
																	  .MySettings _
																	  .Default _
																	  .GamingConnectionString)
		For Each dbRow As MarketingPromo In MarketingPromosDBRowsList
			tbl.MarketingPromos.InsertOnSubmit(dbRow)
			Try
				tbl.SubmitChanges()
			Catch ex As Exception
				Dim result As Integer = CenteredMessagebox.MsgBox.Show("Promo not added to MarketingPromos table!", "Error!",
																	   MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

				If result = DialogResult.Retry Then
					tbl.SubmitChanges()
				End If
			End Try
		Next
	End Sub
#End Region
End Class

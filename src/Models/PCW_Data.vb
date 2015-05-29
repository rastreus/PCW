﻿Imports Key = PromotionalCreationWizard.PCW_Data.PromoFields

Public Class PCW_Data
	Implements IDisposable

#Region "IDisposable Support"
	Private disposedValue As Boolean ' To detect redundant calls

	' IDisposable
	Protected Overridable Sub Dispose(disposing As Boolean)
		If Not Me.disposedValue Then
			If disposing Then
				' TODO: dispose managed state (managed objects).
				Me._pcwDataContext.Dispose()
			End If

			' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
			' TODO: set large fields to null.
		End If
		Me.disposedValue = True
	End Sub

	' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
	'Protected Overrides Sub Finalize()
	'    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
	'    Dispose(False)
	'    MyBase.Finalize()
	'End Sub

	' This code added by Visual Basic to correctly implement the disposable pattern.
	Public Sub Dispose() Implements IDisposable.Dispose
		' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
#End Region
#Region "Fields (Key)"
	Public Enum PromoFields
		ID
		Name
		EntryPromoType
		PayoutPromoType
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
		multiPart
		acquisition
	End Enum
#End Region
#Region "Properties"
	Private _pcwDataContext As PCWLINQ2SQLDataContext = New PCWLINQ2SQLDataContext(Global _
																				  .PromotionalCreationWizard _
																				  .My _
																				  .MySettings _
																				  .Default _
																				  .GamingConnectionString)
	Private _pcwPromoDataHash As Hashtable = New Hashtable()
	Private _pcwPromoStepList As ArrayList = New ArrayList()
	Private _pcwReset As Boolean = False
	Private _pcwResetTo As String = New String("StepA")
	Private _pcwCurrentPromoCategory As PromoCategory
	Private _pcwUsesEligiblePlayers As Boolean = False
	Private _pcwCouponID As String = New String("!")
	Private _pcwMarketingPromosList As List(Of MarketingPromo) = New List(Of MarketingPromo)
	Private _pcwEligiblePlayerList As List(Of MarketingPromoEligiblePlayer) = New List(Of MarketingPromoEligiblePlayer)
	Private _pcwCouponTargetList As List(Of CouponTarget) = New List(Of CouponTarget)
	Private _pcwCouponOffersList As List(Of CouponOffer) = New List(Of CouponOffer)

	Private ReadOnly Property DataContext As PCWLINQ2SQLDataContext
		Get
			Return _pcwDataContext
		End Get
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
	Public Property CurrentPromoCategory As PromoCategory
		Get
			Return _pcwCurrentPromoCategory
		End Get
		Set(value As PromoCategory)
			_pcwCurrentPromoCategory = value
		End Set
	End Property
	Public Property UsesEligiblePlayers As Boolean
		Get
			Return _pcwUsesEligiblePlayers
		End Get
		Set(value As Boolean)
			_pcwUsesEligiblePlayers = value
		End Set
	End Property
	Public Property CouponID As String
		Get
			Return _pcwCouponID
		End Get
		Set(value As String)
			_pcwCouponID = value
		End Set
	End Property
	Public Property MarketingPromosList As List(Of MarketingPromo)
		Get
			Return _pcwMarketingPromosList
		End Get
		Set(value As List(Of MarketingPromo))
			_pcwMarketingPromosList = value
		End Set
	End Property
	Public Property EligiblePlayerList As List(Of MarketingPromoEligiblePlayer)
		Get
			Return _pcwEligiblePlayerList
		End Get
		Set(value As List(Of MarketingPromoEligiblePlayer))
			_pcwEligiblePlayerList = value
		End Set
	End Property
	Public Property CouponTargetList As List(Of CouponTarget)
		Get
			Return _pcwCouponTargetList
		End Get
		Set(value As List(Of CouponTarget))
			_pcwCouponTargetList = value
		End Set
	End Property
	Public Property CouponOffersList As List(Of CouponOffer)
		Get
			Return _pcwCouponOffersList
		End Get
		Set(value As List(Of CouponOffer))
			_pcwCouponOffersList = value
		End Set
	End Property
#End Region
#Region "GetMarketingPromo"
	Private Function GetMarketingPromo() As MarketingPromo
		Dim newPromo As MarketingPromo = New MarketingPromo
		newPromo.PromoName = PromoDataHash.Item(Key.Name)
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
		newPromo.PrintTickets = True 'GetPrintTickets()
		newPromo.Comments = GetPromoComment()
		Return newPromo
	End Function

	Private Function GetPrintTickets() As Boolean
		'PrintTickets cannot be NULL
		Return PromoDataHash.Item(Key.PrintTickets)
	End Function

	''' <summary>
	''' Returns the comment with PCW stamping.
	''' </summary>
	''' <returns>"PCW;05132015;rdillin"</returns>
	''' <remarks>A security feature which tags each promo created by PCW with date and username.</remarks>
	Private Function GetPromoComment() As String
		Dim dateFormatStr As String = New String("{0:MMddyyyy}")
		Dim comment As String = PromoDataHash.Item(Key.Comment)
		comment = comment & _
				  ";PCW;" & _
				  String.Format(dateFormatStr, Date.Today.ToString) & ";" & _
				  Environment.UserName.ToString
		Return comment
	End Function
#End Region
#Region "GetMarketingPromoEntry"
	''' <summary>
	''' Returns an Entry Promo.
	''' </summary>
	''' <returns>Promo of the "Entry" Category.</returns>
	''' <remarks>I'm not sure why those fields wouldn't be Nothing already, but now it is certian.</remarks>
	Private Function GetMarketingPromoEntry() As MarketingPromo
		Dim entryPromo As MarketingPromo = GetMarketingPromo()
		entryPromo.PromoID = GetEntryPromoID()
		entryPromo.PromoName = "Entries - " & entryPromo.PromoName
		entryPromo.PromoType = GetEntryPromoType()
		entryPromo.MaxCoupon = Nothing
		entryPromo.PromoMaxCoupon = Nothing
		entryPromo.CouponID = Nothing
		Return entryPromo
	End Function

	Private Function GetEntryPromoID() As String
		Dim result As String = New String("!")
		result = PromoDataHash.Item(Key.ID) & "E"
		Return result
	End Function

	Private Function GetEntryPromoType() As String
		Return PromoDataHash.Item(Key.EntryPromoType)
	End Function
#End Region
#Region "GetMarketingPromoPayout"
	''' <summary>
	''' Returns a Payout Promo.
	''' </summary>
	''' <returns>Promo of the "Payout" Category.</returns>
	''' <remarks>Likewise, not sure why these fields wouldn't be Nothing, but now it is certain.</remarks>
	Private Function GetMarketingPromoPayout() As MarketingPromo
		Dim payoutPromo As MarketingPromo = GetMarketingPromo()
		payoutPromo.PromoID = GetPayoutPromoID()
		payoutPromo.PromoName = "Payouts - " & payoutPromo.PromoName
		payoutPromo.PromoType = GetPayoutPromoType()
		payoutPromo.PointCutoff = Nothing
		payoutPromo.PointDivisor = Nothing
		payoutPromo.MaxTickets = Nothing
		Return payoutPromo
	End Function

	Private Function GetPayoutPromoID() As String
		Dim result As String = New String("!")
		result = PromoDataHash.Item(Key.ID) & "P"
		Return result
	End Function

	Private Function GetPayoutPromoType() As String
		Return PromoDataHash.Item(Key.PayoutPromoType)
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
#Region "SubmitPromosToList"
	Private Sub SubmitPromosToList()
		Dim entryPromo As MarketingPromo
		Dim payoutPromo As MarketingPromo
		Select Case CurrentPromoCategory
			Case PromoCategory.entryAndPayout
				entryPromo = GetMarketingPromoEntry()
				payoutPromo = GetMarketingPromoPayout()
				Me.MarketingPromosList.Add(entryPromo)
				Me.MarketingPromosList.Add(payoutPromo)
			Case PromoCategory.entryOnly
				entryPromo = GetMarketingPromoEntry()
				payoutPromo = Nothing
				Me.MarketingPromosList.Add(entryPromo)
			Case PromoCategory.payoutOnly
				entryPromo = Nothing
				payoutPromo = GetMarketingPromoPayout()
				Me.MarketingPromosList.Add(payoutPromo)
			Case PromoCategory.multiPart
				'If out what all needs to be done
			Case PromoCategory.acquisition
				'Needs to be implemented (As of: 05/13/15)
		End Select
	End Sub
#End Region
#Region "SubmitListsToDB"
	Public Sub SubmitListsToDB()
		SubmitPromosToList()
		DataContext.MarketingPromos.InsertAllOnSubmit(MarketingPromosList)
		If SubmitEligiblePlayersToDB() Then
			DataContext.MarketingPromoEligiblePlayers.InsertAllOnSubmit(EligiblePlayerList)
		End If
		If SubmitCouponListsToDB() Then
			DataContext.CouponOffers.InsertAllOnSubmit(CouponOffersList)
			DataContext.CouponTargets.InsertAllOnSubmit(CouponTargetList)
		End If
		DataContext.SubmitChanges()
	End Sub
#End Region
#Region "SubmitEligiblePlayersToDB"
	Private Function SubmitEligiblePlayersToDB() As Boolean
		Dim result As Boolean = False
		If UsesEligiblePlayers Then
			result = True
		End If
		Return result
	End Function
#End Region
#Region "SubmitCouponListsToDB"
	Private Function SubmitCouponListsToDB() As Boolean
		Dim result As Boolean = False
		If CurrentPromoCategory = Not PromoCategory.entryOnly Then
			result = True
		End If
		Return result
	End Function
#End Region
End Class

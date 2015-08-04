Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields
Imports System.Data.SqlClient
Imports System.Text

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

			' TODO: free unmanaged resources (unmanaged objects)
			'and override Finalize() below.
			' TODO: set large fields to null.
		End If
		Me.disposedValue = True
	End Sub

	' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean)
	'above has code to free unmanaged resources.
	'Protected Overrides Sub Finalize()
	'    ' Do not change this code.
	'	   Put cleanup code in Dispose(ByVal disposing As Boolean) above.
	'    Dispose(False)
	'    MyBase.Finalize()
	'End Sub

	' This code added by Visual Basic to
	'correctly implement the disposable pattern.
	Public Sub Dispose() Implements IDisposable.Dispose
		' Do not change this code.
		' Put cleanup code in Dispose(disposing As Boolean) above.
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
#Region "PromoCategory"
	Public Enum PromoCategory
		entryAndPayout
		entryOnly
		payoutOnly
		multiPart
		acquisition
	End Enum
#End Region
#Region "MultiPartCategory"
	Public Enum MultiPartCategory
		multiPartSame 'Regular Days, Irregular Tiers
		multiPartDiff 'Irregular Days, Regular Tiers
	End Enum
#End Region
#Region "Properties"
	Private _pcwDataContext As PCWLINQ2SQLDataContext = _
		New PCWLINQ2SQLDataContext(Global _
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
	Private _pcwUsesCouponTargetsList As Boolean = False
	Private _pcwMultiPartCategory As MultiPartCategory
	Private _pcwMarketingPromosList As List(Of MarketingPromo) = _
								   New List(Of MarketingPromo)
	Private _pcwEligiblePlayerList As List(Of MarketingPromoEligiblePlayer) = _
								  New List(Of MarketingPromoEligiblePlayer)
	Private _pcwCouponTargetList As List(Of CouponTarget) = _
								New List(Of CouponTarget)
	Private _pcwCouponOffersList As List(Of CouponOffer) = _
								New List(Of CouponOffer)
	Private _pcwTEMPCOList As List(Of CouponOffer) = _
						  New List(Of CouponOffer)
	Private _pcwDaysBool As Boolean = False
	Private _pcwNumOfDays As System.Nullable(Of Short) = Nothing
	Private _pcwNumOfDiffs As Short
	Private _pcwPayoutDiffNum As Short = 1
	Private _pcwPayoutDiffType As String = New String(String.Empty)

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
	Public Property UsesCouponTargetsList As Boolean
		Get
			Return _pcwUsesCouponTargetsList
		End Get
		Set(value As Boolean)
			_pcwUsesCouponTargetsList = value
		End Set
	End Property
	Public Property CurrentMultiPartCategory As MultiPartCategory
		Get
			Return _pcwMultiPartCategory
		End Get
		Set(value As MultiPartCategory)
			_pcwMultiPartCategory = value
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
	Private Property TEMPCOList As List(Of CouponOffer)
		Get
			Return _pcwTEMPCOList
		End Get
		Set(value As List(Of CouponOffer))
			_pcwTEMPCOList = value
		End Set
	End Property
	Public Property DaysBool As Boolean
		Get
			Return _pcwDaysBool
		End Get
		Set(value As Boolean)
			_pcwDaysBool = value
		End Set
	End Property
	Public Property NumOfDays As System.Nullable(Of Short)
		Get
			Return _pcwNumOfDays
		End Get
		Set(value As System.Nullable(Of Short))
			_pcwNumOfDays = value
		End Set
	End Property
	Public Property NumOfDiffs As Short
		Get
			Return _pcwNumOfDiffs
		End Get
		Set(value As Short)
			_pcwNumOfDiffs = value
		End Set
	End Property
	Public Property PayoutDiffNum As Short
		Get
			Return _pcwPayoutDiffNum
		End Get
		Set(value As Short)
			_pcwPayoutDiffNum = value
		End Set
	End Property
	Public Property PayoutDiffType As String
		Get
			Return _pcwPayoutDiffType
		End Get
		Set(value As String)
			_pcwPayoutDiffType = value
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
		newPromo.PromoMaxTickets = _
			PromoDataHash.Item(Key.TicketsForEntirePromo)
		newPromo.MaxCoupon = PromoDataHash.Item(Key.CouponAmtPerPatron)
		newPromo.PromoMaxCoupon = _
			PromoDataHash.Item(Key.CouponAmtForEntirePromo)
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
		Dim dateFormatStr As String = New String("{0:MM/dd/yy H:mm:ss}")
		Dim comment As String = PromoDataHash.Item(Key.Comment)
		comment = comment & _
				  ";PCW;" & _
				  String.Format(dateFormatStr, _
								Date.Now.ToString) & ";" & _
				  Environment.UserName.ToString
		Return comment
	End Function
	''' <summary>
	''' Checks the length of the PromoID and processes accordingly.
	''' </summary>
	''' <param name="letterType">"E" or "P"</param>
	''' <returns>The PromoID of correct length with appended letterType.</returns>
	''' <remarks>DRYs up GetEntryPromoID and GetPayoutPromoID.</remarks>
	Private Function ProcessPromoID(ByVal letterType As String) As String
		Dim result As String = New String(String.Empty)
		If PromoDataHash.Item(Key.ID).ToString.Length <= 15 Then
			result = PromoDataHash.Item(Key.ID) & letterType
		ElseIf PromoDataHash.Item(Key.ID).ToString.Length >= 16 Then
			result = _
				PromoDataHash.Item(Key.ID) _
				.ToString _
				.Substring(0, 14) & _
				letterType
		End If
		Return result
	End Function
#End Region
#Region "GetMarketingPromoEntry"
	''' <summary>
	''' Returns an Entry Promo.
	''' </summary>
	''' <returns>Promo of the "Entry" Category.</returns>
	''' <remarks>I'm not sure why those fields wouldn't be Nothing already,
	''' but now it is certian.</remarks>
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
		Dim result As String = New String(String.Empty)
		result = ProcessPromoID("E")
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
	''' <remarks>Likewise, not sure why these fields wouldn't be Nothing,
	''' but now it is certain.</remarks>
	Private Function GetMarketingPromoPayout() As MarketingPromo
		Dim payoutPromo As MarketingPromo = GetMarketingPromo()
		payoutPromo.PromoID = GetPayoutPromoID()
		payoutPromo.PromoName = "Payouts - " & payoutPromo.PromoName
		payoutPromo.PromoType = GetPayoutPromoType()
		payoutPromo.PointCutoff = Nothing
		payoutPromo.PointDivisor = Nothing
		payoutPromo.MaxTickets = Nothing
		payoutPromo.PromoMaxTickets = _
			GetPayoutMaxNumOfCouponsPerPatron()
		Return payoutPromo
	End Function
	Private Function GetPayoutPromoID() As String
		Dim result As String = New String(String.Empty)
		result = ProcessPromoID("P")
		Return result
	End Function
	Private Function GetPayoutPromoType() As String
		Return PromoDataHash.Item(Key.PayoutPromoType)
	End Function
	Private Function GetPayoutMaxNumOfCouponsPerPatron()
		Return PromoDataHash.Item(Key.MaxNumOfCouponsPerPatron)
	End Function
#End Region
#Region "GetPromoSummary"

	Private ID As String = _
												"             ID: "
	Private Name As String = _
												"           Name: "
	Private Type As String = _
												"           Type: "
	Private _Date As String = _
												"           Date: "
	Private StartDate As String = _
												"      StartDate: "
	Private EndDate As String = _
												"        EndDate: "
	Private PointCutoff As String = _
												"    PointCutoff: "
	Private PointsDivisor As String = _
												"  PointsDivisor: "
	Private MaxTickets As String = _
												"     MaxTickets: "
	Private TicketsForEntirePromo As String = _
												"PromoMaxTickets: "
	Private MaxCoupon As String = _
												"      MaxCoupon: "
	Private PromoMaxCoupon As String = _
												" PromoMaxCoupon: "
	Private CouponID As String = _
												"       CouponID: "
	Private Recurring As String = _
												"      Recurring: "
	Private Frequency As String = _
												"      Frequency: "
	Private RecursOnWeekday As String = _
												"RecursOnWeekday: "
	Private EarnsOnWeekday As String = _
												" EarnsOnWeekday: "
	Private CountCurrentDay As String = _
												"CountCurrentDay: "
	Private PrintTickets As String = _
												"   PrintTickets: "

	Public Function GetPromoSummary() As StringBuilder
		Dim dateFormatStr As String = New String("{0:MM/dd/yyyy}")
		Dim builder As StringBuilder = New StringBuilder

		builder.Append(ID & nullIfNothing(Key.ID) & "E" & vbCrLf)
		builder.Append(Name & nullIfNothing(Key.Name) & vbCrLf)
		builder.Append(Type & nullIfNothing(Key.EntryPromoType) & vbCrLf)
		builder.Append(_Date & nullIfNothing(Key.OccursDate, _
											 dateFormatStr) & vbCrLf)
		builder.Append(StartDate & nullIfNothing(Key.StartDate, _
												 dateFormatStr) & vbCrLf)
		builder.Append(EndDate & nullIfNothing(Key.EndDate, _
											   dateFormatStr) & vbCrLf)
		builder.Append(PointCutoff & nullIfNothing(Key.PointCutoffLimit) & _
					   vbCrLf)
		builder.Append(PointsDivisor & nullIfNothing(Key.PointsDivisor) & _
					   vbCrLf)
		builder.Append(MaxTickets & nullIfNothing(Key.TicketsPerPatron) & _
					   vbCrLf)
		builder.Append(TicketsForEntirePromo & _
					   nullIfNothing(Key.TicketsForEntirePromo) & vbCrLf)
		builder.Append(MaxCoupon & "NULL" & vbCrLf)
		builder.Append(PromoMaxCoupon & "NULL" & vbCrLf)
		builder.Append(CouponID & "NULL" & vbCrLf)
		builder.Append(Recurring & nullIfNothing(Key.Recurring) & vbCrLf)
		builder.Append(Frequency & nullIfNothing(Key.RecurringFrequency) & _
					   vbCrLf)
		builder.Append(RecursOnWeekday & nullIfNothing(Key.RecursOnWeekday) & _
					   vbCrLf)
		builder.Append(EarnsOnWeekday & nullIfNothing(Key.EarnsOnWeekday) & _
					   vbCrLf)
		builder.Append(CountCurrentDay & nullIfNothing(Key.CountCurrentDay) & _
					   vbCrLf)
		builder.Append(PrintTickets & nullIfNothing(Key.PrintTickets) & vbCrLf)
		Return builder
	End Function
	Public Function GetPromoPayoutSummary() As System.Text.StringBuilder
		Dim dateFormatStr As String = New String("{0:MM/dd/yyyy}")
		Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder

		builder.Append("                  ID: " & nullIfNothing(Key.ID) & "P" & vbCrLf)
		builder.Append("                Name: " & nullIfNothing(Key.Name) & vbCrLf)
		builder.Append("                Type: " & nullIfNothing(Key.PayoutPromoType) & vbCrLf)
		builder.Append("                Date: " & nullIfNothing(Key.OccursDate, dateFormatStr) & vbCrLf)
		builder.Append("           StartDate: " & nullIfNothing(Key.StartDate, dateFormatStr) & vbCrLf)
		builder.Append("             EndDate: " & nullIfNothing(Key.EndDate, dateFormatStr) & vbCrLf)
		builder.Append("         PointCutoff: " & "NULL" & vbCrLf)
		builder.Append("       PointsDivisor: " & "NULL" & vbCrLf)
		builder.Append("          MaxTickets: " & "NULL" & vbCrLf)
		builder.Append("Max#CouponsPerPatron: " & nullIfNothing(Key.MaxNumOfCouponsPerPatron) & vbCrLf)
		builder.Append("           MaxCoupon: " & nullIfNothing(Key.CouponAmtPerPatron) & vbCrLf)
		builder.Append("      PromoMaxCoupon: " & nullIfNothing(Key.CouponAmtForEntirePromo) & vbCrLf)
		builder.Append("            CouponID: " & nullIfNothing(Key.CouponID) & vbCrLf)
		builder.Append("           Recurring: " & nullIfNothing(Key.Recurring) & vbCrLf)
		builder.Append("           Frequency: " & nullIfNothing(Key.RecurringFrequency) & vbCrLf)
		builder.Append("     RecursOnWeekday: " & nullIfNothing(Key.RecursOnWeekday) & vbCrLf)
		builder.Append("      EarnsOnWeekday: " & nullIfNothing(Key.EarnsOnWeekday) & vbCrLf)
		builder.Append("     CountCurrentDay: " & nullIfNothing(Key.CountCurrentDay) & vbCrLf)
		builder.Append("        PrintTickets: " & nullIfNothing(Key.PrintTickets) & vbCrLf)
		Return builder
	End Function
	Private Function nullIfNothing(ByVal key As PromoFields) As String
		Dim result As String = New String(String.Empty)
		If IsNothing(PromoDataHash.Item(key)) Then
			result = "NULL"
		Else
			result = PromoDataHash.Item(key).ToString
		End If
		Return result
	End Function
	Private Function nullIfNothing(ByVal key As PromoFields, _
								   ByVal dateFormatStr As String) As String
		Dim result As String = New String(String.Empty)
		If IsNothing(PromoDataHash.Item(key)) Then
			result = "NULL"
		Else
			result = String.Format(dateFormatStr, _
								   PromoDataHash.Item(key))
		End If
		Return result
	End Function
#End Region
#Region "SubmitPromosToList"
	Public Sub SubmitPromosToList()
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
				If Not IsNothing(CurrentMultiPartCategory) Then
					If CurrentMultiPartCategory = _
						MultiPartCategory.multiPartDiff Then
						ProcessAllMultiPartPayoutsDiff(payoutPromo)
					End If
				Else
					Me.MarketingPromosList.Add(payoutPromo)
				End If
			Case PromoCategory.multiPart
				'If out what all needs to be done
				entryPromo = GetMarketingPromoEntry()
				payoutPromo = GetMarketingPromoPayout()
				If CurrentMultiPartCategory = _
					MultiPartCategory.multiPartSame Then
					ProcessAllMultiPartPayoutsSame(payoutPromo)
				Else
					ProcessAllMultiPartPayoutsDiff(payoutPromo)
				End If
				Me.MarketingPromosList.Add(entryPromo)
			Case PromoCategory.acquisition
				'Needs to be implemented (As of: 05/13/15)
				'Hasn't been implemented (As of: 06/23/15)
		End Select
	End Sub
#End Region
#Region "ProcessAllMultiPartPayouts"
	Private Sub ProcessAllMultiPartPayoutsSame(ByVal payoutPromo _
											   As MarketingPromo)
		'This only works for Days; refactor for Tiers.
		Dim coTempList As List(Of CouponOffer) = New List(Of CouponOffer)
		Dim coAccList As List(Of CouponOffer) = New List(Of CouponOffer)
		Dim ctTempList As List(Of CouponTarget) = New List(Of CouponTarget)
		Dim ctAccList As List(Of CouponTarget) = New List(Of CouponTarget)
		Dim startDate As DateTime = payoutPromo.StartDate
		Dim endDate As DateTime = payoutPromo.EndDate
		Dim currDate As DateTime = startDate
		Dim payoutNumber As Short = 1
		Dim usesTargetList As Boolean = SubmitCouponTargetsToDB()

		While (currDate <= endDate)
			Me.MarketingPromosList.Add( _
				ProcessMultiPartPayout(currDate, _
									   payoutNumber))
			If payoutNumber = 1 Then
				ProcessMultiPartCouponOfferInPlace(currDate, _
												   payoutNumber)
				If usesTargetList Then
					ProcessMultiPartCouponTargetInPlace(payoutNumber)
				End If
			ElseIf payoutNumber > 1 Then
				coTempList = ProcessMultiPartCouponOfferAppend(currDate, _
															   payoutNumber)
				For Each coupOff As CouponOffer In coTempList
					coAccList.Add(coupOff)
				Next
				If usesTargetList Then
					ctTempList = _
						ProcessMultiPartCouponTargetAppend(payoutNumber)
					For Each coupTarg As CouponTarget In ctTempList
						ctAccList.Add(coupTarg)
					Next
				End If
			End If
			currDate = currDate.AddDays(1)
			payoutNumber = payoutNumber + 1
		End While
		For Each co As CouponOffer In coAccList
			Me.CouponOffersList.Add(co)
		Next
		If usesTargetList Then
			For Each ct As CouponTarget In ctAccList
				Me.CouponTargetList.Add(ct)
			Next
		End If
	End Sub
	Private Sub ProcessAllMultiPartPayoutsDiff(ByVal payoutPromo _
											   As MarketingPromo)
		Dim usesTargetList As Boolean = _
			SubmitCouponTargetsToDB()
		Dim payoutNumber As Short = New Short
		Dim payoutDate As DateTime = payoutPromo.StartDate
		payoutNumber = Me.PayoutDiffNum
		If payoutNumber > 1 Then
			payoutDate = payoutDate.AddDays(payoutNumber - 1)
		End If
		Me.MarketingPromosList.Add( _
			ProcessMultiPartPayout(payoutDate, _
								   payoutNumber))
		ProcessMultiPartCouponOfferInPlace(payoutDate, _
										   payoutNumber)
		For Each co As CouponOffer In CouponOffersList
			TEMPCOList.Add(co)
		Next
		CouponOffersList.Clear()
		If NumOfDiffs <= 1 Then
			For Each co As CouponOffer In TEMPCOList
				CouponOffersList.Add(co)
			Next
		End If
		If usesTargetList Then
			ProcessMultiPartCouponTargetInPlace(payoutNumber)
		End If
		Me.PayoutDiffNum = Me.PayoutDiffNum + 1
	End Sub
#Region "ProcessMultiPartPayout"
	Private Function ProcessMultiPartPayout(ByVal payoutDate As DateTime, _
											ByVal payoutNumber As Short) _
											As MarketingPromo
		Dim anotherPayoutPromo As MarketingPromo = New MarketingPromo
		anotherPayoutPromo = GetMarketingPromoPayout()
		Dim num As String = payoutNumber.ToString
		anotherPayoutPromo.PromoID = GetPayoutPromoID() & num
		anotherPayoutPromo.PromoName = "Payouts " _
									 & num _
									 & " - " _
									 & PromoDataHash.Item(Key.Name)
		anotherPayoutPromo.PromoType = GetPayoutPromoType()
		anotherPayoutPromo.PointCutoff = Nothing
		anotherPayoutPromo.PointDivisor = Nothing
		anotherPayoutPromo.MaxTickets = Nothing
		anotherPayoutPromo.PromoMaxTickets = _
			GetPayoutMaxNumOfCouponsPerPatron()
		anotherPayoutPromo.CouponID = anotherPayoutPromo.CouponID & num
		If (Not (CurrentMultiPartCategory = _
				MultiPartCategory.multiPartDiff) And _
				(PayoutDiffType = "TIERS")) Then
			anotherPayoutPromo.StartDate = payoutDate
			anotherPayoutPromo.EndDate = payoutDate
			anotherPayoutPromo.Recurring = False
			anotherPayoutPromo.Frequency = "W"
			anotherPayoutPromo.RecursOnWeekday = Nothing
			anotherPayoutPromo.EarnsOnWeekday = Nothing
		End If
		Return anotherPayoutPromo
	End Function
#End Region
#Region "ProcessMultiPartCouponOffer"
	Private Sub ProcessMultiPartCouponOfferInPlace(ByVal payoutDate _
												   As DateTime, _
												   ByVal payoutNumber _
												   As Short)
		For Each couponOfferDBRow As CouponOffer In CouponOffersList
			couponOfferDBRow.OfferID = couponOfferDBRow.OfferID & _
									   payoutNumber.ToString
			If (Not (CurrentMultiPartCategory = _
					 MultiPartCategory.multiPartDiff) And _
					 (PayoutDiffType = "TIERS")) Then
				couponOfferDBRow.ValidStart = payoutDate
				couponOfferDBRow.ValidEnd = payoutDate
				couponOfferDBRow.ExcludeDays = Nothing
				couponOfferDBRow.ExcludeStart = Nothing
				couponOfferDBRow.ExcludeEnd = Nothing
			End If
		Next
	End Sub
	Private Function ProcessMultiPartCouponOfferAppend(ByVal payoutDate _
													   As DateTime, _
													   ByVal payoutNumber _
													   As Short) _
													   As List(Of CouponOffer)
		Dim YACO As CouponOffer	'Yet Another CouponOffer
		Dim tempList As List(Of CouponOffer) = New List(Of CouponOffer)
		For Each couponOfferDBRow As CouponOffer In CouponOffersList
			YACO = New CouponOffer
			YACO.OfferID = couponOfferDBRow.OfferID
			YACO.OfferID = YACO.OfferID _
				.Substring(0, (YACO.OfferID.Length - 1)) & _
				payoutNumber.ToString
			YACO.CouponNumber = couponOfferDBRow.CouponNumber
			If (Not (CurrentMultiPartCategory = _
					 MultiPartCategory.multiPartDiff) And _
					 (PayoutDiffType = "TIERS")) Then
				YACO.ValidStart = payoutDate
				YACO.ValidEnd = payoutDate
				YACO.ExcludeDays = Nothing
				YACO.ExcludeStart = Nothing
				YACO.ExcludeEnd = Nothing
			End If
			YACO.FullValidate = couponOfferDBRow.FullValidate
			YACO.Reprintable = couponOfferDBRow.Reprintable
			YACO.Note = couponOfferDBRow.Note
			YACO.ScanToReceipt = couponOfferDBRow.ScanToReceipt
			tempList.Add(YACO)
		Next
		Return tempList
	End Function
#End Region
#Region "ProcessMultiPartCouponTarget"
	Private Sub ProcessMultiPartCouponTargetInPlace(ByVal payoutNumber _
													As Short)
		For Each couponTargetDBRow As CouponTarget In CouponTargetList
			couponTargetDBRow.OfferID = couponTargetDBRow.OfferID & _
										payoutNumber.ToString
		Next
	End Sub
	Private Function ProcessMultiPartCouponTargetAppend(ByVal payoutNumber _
														As Short) _
													As List(Of CouponTarget)
		Dim YACT As CouponTarget 'Yet Another CouponTarget
		Dim tempList As List(Of CouponTarget) = New List(Of CouponTarget)
		For Each couponTargetDBRow As CouponTarget In CouponTargetList
			YACT = New CouponTarget
			YACT.OfferID = couponTargetDBRow.OfferID
			YACT.OfferID = YACT.OfferID _
				.Substring(0, (YACT.OfferID.Length - 1)) & _
				payoutNumber.ToString
			YACT.Coupon = couponTargetDBRow.Coupon
			YACT.Account = couponTargetDBRow.Account
			YACT.Zip = couponTargetDBRow.Zip
			YACT.AvgTheo = couponTargetDBRow.AvgTheo
			YACT.Latency = couponTargetDBRow.Latency
			YACT.BaseCoupon = couponTargetDBRow.BaseCoupon
			YACT.ZoneAddon = couponTargetDBRow.ZoneAddon
			YACT.OtherAddon = couponTargetDBRow.OtherAddon
			YACT.TotalCoupon = couponTargetDBRow.TotalCoupon
			YACT.TestCoupon = couponTargetDBRow.TestCoupon
			YACT.CreateDate = couponTargetDBRow.CreateDate
			tempList.Add(YACT)
		Next
		Return tempList
	End Function
#End Region
#End Region
#Region "SubmitListsToDB"
	Public Sub SubmitListsToDB()
		'SubmitPromosToList() 'THIS HAS TO HAPPEN INDEPENDENTLY
		DataContext _
			.MarketingPromos _
			.InsertAllOnSubmit(MarketingPromosList)
		If SubmitEligiblePlayersToDB() Then
			DataContext _
				.MarketingPromoEligiblePlayers _
				.InsertAllOnSubmit(EligiblePlayerList)
		End If
		If SubmitCouponOffersToDB() Then
			DataContext _
				.CouponOffers _
				.InsertAllOnSubmit(CouponOffersList)
		End If
		If SubmitCouponTargetsToDB() Then
			DataContext _
				.CouponTargets _
				.InsertAllOnSubmit(CouponTargetList)
		End If
		Try
			DataContext.SubmitChanges()
		Catch ex As SqlException
			GUI_Util.msgBox(ex.Message)
		End Try
	End Sub
#End Region
#Region "ClearListsAfterSubmit"
	Public Sub ClearListsAfterSubmit()
		Me.MarketingPromosList.Clear()
		If SubmitEligiblePlayersToDB() Then
			Me.EligiblePlayerList.Clear()
		End If
		If SubmitCouponOffersToDB() Then
			Me.CouponOffersList.Clear()
		End If
		If SubmitCouponTargetsToDB() Then
			Me.CouponTargetList.Clear()
		End If
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
	Private Function SubmitCouponOffersToDB() As Boolean
		Dim result As Boolean = False
		If (CurrentPromoCategory = PromoCategory.entryAndPayout) Or _
		   (CurrentPromoCategory = PromoCategory.payoutOnly) Or _
		   (CurrentPromoCategory = PromoCategory.multiPart) Or _
		   (CurrentPromoCategory = PromoCategory.acquisition) Then
			result = True
		End If
		Return result
	End Function
#End Region
#Region "SubmitCouponTargetsToDB"
	Private Function SubmitCouponTargetsToDB() As Boolean
		Dim result As Boolean = True
		Dim payoutType As String = New String(String.Empty)
		payoutType = GetPayoutPromoType()
		If (payoutType = "31B") Or _
		   (payoutType = "31C") Or _
		   (payoutType = "34") Then
			result = False
		End If
		Return result
	End Function
#End Region
End Class

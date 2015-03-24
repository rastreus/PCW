''' <summary>
''' Contains data and validity checks for StepEntryTicketAmt.
''' </summary>
''' <remarks>This is the Model for StepEntryTicketAmt (Controller).</remarks>
Public Class StepEntryTicketAmt_Data
#Region "Properties"
	Private _promoTicketAmtCategory As PromoTicketAmtCategory
	Private _promoPointsDivisor As System.Nullable(Of Short)
	Private _promoTicketsPerPatron As System.Nullable(Of Short)			'MaxTickets
	Private _promoTicketsForEntirePromo As System.Nullable(Of Short)	'PromoMaxTickets
	Private _promoPrintTickets As System.Nullable(Of Boolean)

	Public Enum PromoTicketAmtCategory
		one
		numOfVisits
		calculated
		calPlusNumOfVisits
	End Enum

	Public Property TicketAmtCategory As PromoTicketAmtCategory
		Get
			Return _promoTicketAmtCategory
		End Get
		Set(value As PromoTicketAmtCategory)
			_promoTicketAmtCategory = value
		End Set
	End Property
	Public Property PointsDivisor As System.Nullable(Of Short)
		Get
			Return _promoPointsDivisor
		End Get
		Set(value As System.Nullable(Of Short))
			_promoPointsDivisor = value
		End Set
	End Property
	Public Property TicketsPerPatron As System.Nullable(Of Short)
		Get
			Return _promoTicketsPerPatron
		End Get
		Set(value As System.Nullable(Of Short))
			_promoTicketsPerPatron = value
		End Set
	End Property
	Public Property TicketsForEntirePromo As System.Nullable(Of Short)
		Get
			Return _promoTicketsForEntirePromo
		End Get
		Set(value As System.Nullable(Of Short))
			_promoTicketsForEntirePromo = value
		End Set
	End Property
	Public Property PrintTickets As System.Nullable(Of Boolean)
		Get
			Return _promoPrintTickets
		End Get
		Set(value As System.Nullable(Of Boolean))
			_promoPrintTickets = value
		End Set
	End Property
#End Region
#Region "Validity_Checks"
	Public Function PointsDivisor_Invalid() As Boolean
		Return IsNothing(PointsDivisor)
	End Function
	Public Function TicketsPerPatron_Invalid() As Boolean
		Return IsNothing(TicketsPerPatron)
	End Function
	Public Function TicketsForEntirePromo_Invalid() As Boolean
		Return IsNothing(TicketsForEntirePromo)
	End Function
	Public Function BadTicketLimits() As Boolean
		Return (TicketsForEntirePromo < TicketsPerPatron)
	End Function
#End Region
End Class

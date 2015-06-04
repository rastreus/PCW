Imports Key = PromotionalCreationWizard.PCW_Data.PromoFields

''' <summary>
''' Contains data and validity checks for StepEntryTicketAmt.
''' </summary>
''' <remarks>This is the Model for StepEntryTicketAmt (Controller).</remarks>
Public Class StepEntryTicketAmt_Data
	Implements IPromoData

#Region "ToPromoStepList"
	Public Sub ToPromoStepList(ByVal stepName As TSWizards.BaseInteriorStep, _
							   ByRef promoStepList As ArrayList) _
		Implements IPromoData.ToPromoStepList
		promoStepList.Add(stepName.Name)
	End Sub
#End Region
#Region "PrepareData"
	Public Sub PrepareData(ByRef promoDataHash As Hashtable) _
		Implements IPromoData.PrepareData
		'Set the Item if already in the Hashtable
		If DataAddedToHash Then
			promoDataHash.Item(Key.EntryPromoType) = PromoType
			promoDataHash.Item(Key.PointsDivisor) = PointsDivisor
			promoDataHash.Item(Key.TicketsPerPatron) = TicketsPerPatron
			promoDataHash.Item(Key.TicketsForEntirePromo) = TicketsForEntirePromo
			promoDataHash.Item(Key.PrintTickets) = PrintTickets
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.EntryPromoType, PromoType)
			promoDataHash.Add(Key.PointsDivisor, PointsDivisor)
			promoDataHash.Add(Key.TicketsPerPatron, TicketsPerPatron)
			promoDataHash.Add(Key.TicketsForEntirePromo, TicketsForEntirePromo)
			promoDataHash.Add(Key.PrintTickets, PrintTickets)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
	Private _promoTicketAmtCategory As PromoTicketAmtCategory
	Private _promoPointsDivisor As System.Nullable(Of Short)
	Private _promoTicketsPerPatron As System.Nullable(Of Short)			'MaxTickets
	Private _promoTicketsForEntirePromo As System.Nullable(Of Short)	'PromoMaxTickets
	Private _promoPrintTickets As System.Nullable(Of Boolean)
	Private _pcwPromoType As String

	Public Enum PromoTicketAmtCategory
		one
		numOfVisits
		calculated
		calPlusNumOfVisits
	End Enum

	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property StepNotSet As Boolean
		Get
			Return _stepNotSet
		End Get
		Set(value As Boolean)
			_stepNotSet = value
		End Set
	End Property
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
	Public Property PromoType As String
		Get
			Return _pcwPromoType
		End Get
		Set(value As String)
			_pcwPromoType = value
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
	Public Function BadPromoType() As Boolean
		Dim result As Boolean = False
		If (PromoType = "") Or _
			(PromoType = "EX: 25") Or _
			(PromoType.Length > 3) Then
			result = True
		End If
		Return result
	End Function
#End Region
#Region "DetermineStepFlow"
	''' <summary>
	''' Queries to PromoCategory to determine where to go.
	''' </summary>
	''' <returns>NextStep.</returns>
	''' <remarks>Trying to keep this as clean as possible.</remarks>
	Public Function DetermineStepFlow() As String
		Dim result As String = New String("")
		Dim local_stepD As StepD = PCW.GetStep("StepD")
		Dim promoCategory As PCW_Data.PromoCategory = local_stepD.Data.Category
		Select Case promoCategory
			Case PCW_Data.PromoCategory.entryOnly
				result = "StepH"
			Case Else
				result = "StepF"
		End Select
		Return result
	End Function
#End Region
End Class

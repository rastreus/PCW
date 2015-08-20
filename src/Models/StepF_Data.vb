Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields

''' <summary>
''' Contains data and validity checks for StepF.
''' </summary>
''' <remarks>This is the Model for StepF (Controller).</remarks>
Public Class StepF_Data
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
			promoDataHash.Item(Key.PayoutPromoType) = PromoType
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.PayoutPromoType, PromoType)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
	Private _promoPayoutCategory As PromoPayoutCategory
	Private _promoCashValue As System.Nullable(Of Decimal) = Nothing
	Private _promoPrize As String
	Private _pcwPromoType As String

	Public Enum PromoPayoutCategory
		freePlayCoupon
		randomPrize
		cashValue
		prize
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
	Public Property PayoutCatgory As PromoPayoutCategory
		Get
			Return _promoPayoutCategory
		End Get
		Set(value As PromoPayoutCategory)
			_promoPayoutCategory = value
		End Set
	End Property
	Public Property CashValue As System.Nullable(Of Decimal)
		Get
			Return _promoCashValue
		End Get
		Set(value As System.Nullable(Of Decimal))
			_promoCashValue = value
		End Set
	End Property
	Public Property Prize As String
		Get
			Return _promoPrize
		End Get
		Set(value As String)
			_promoPrize = value
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
#Region "Validity Checks"
	Public Function CashValueInvalid(ByVal cashValueStr As String) As Boolean
		Return BEP_Util.invalidNum(cashValueStr)
	End Function
	Public Function PrizeIsBlank() As Boolean
		Return (Prize = String.Empty)
	End Function
	Public Function BadPromoType() As Boolean
		Dim result As Boolean = False
		If (PromoType = String.Empty) OrElse _
			(PromoType = "EX: 31B") OrElse _
			(PromoType.Length > 3) Then
			result = True
		End If
		Return result
	End Function
#End Region
#Region "DetermineNextStep"
	''' <summary>
	''' Queries to PayoutCategory to determine where to go next.
	''' </summary>
	''' <returns>NextStep.</returns>
	''' <remarks>Trying to keep this as clean as possible.</remarks>
	Public Function DetermineNextStep() As String
		Dim result As String = New String(String.Empty)
		Select Case PayoutCatgory
			Case PromoPayoutCategory.freePlayCoupon
				result = "StepGeneratePayoutCoupon"
			Case PromoPayoutCategory.randomPrize
				'RANDOM PRIZE IS NOT IMPLIMENTED
				result = "StepG3"
			Case Else
				result = "StepH"
		End Select
		Return result
	End Function
#End Region
#Region "WillUseCouponTargetsList"
	Public Function WillUseCouponTargetsList() As Boolean
		Dim result As Boolean = True
		If (PromoType = "31B") OrElse _
			(PromoType = "31C") OrElse _
			(PromoType = "34") Then
			result = False
		End If
		Return result
	End Function
#End Region
End Class

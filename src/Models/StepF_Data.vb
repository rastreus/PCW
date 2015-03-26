''' <summary>
''' Contains data and validity checks for StepF.
''' </summary>
''' <remarks>This is the Model for StepF (Controller).</remarks>
Public Class StepF_Data
#Region "Properties"
	Private _promoPayoutCategory As PromoPayoutCategory
	Private _promoCashValue As Integer
	Private _promoPrize As String

	Public Enum PromoPayoutCategory
		freePlayCoupon
		randomPrize
		cashValue
		prize
	End Enum

	Public Property PayoutCatgory As PromoPayoutCategory
		Get
			Return _promoPayoutCategory
		End Get
		Set(value As PromoPayoutCategory)
			_promoPayoutCategory = value
		End Set
	End Property
	Public Property CashValue As Decimal
		Get
			Return _promoCashValue
		End Get
		Set(value As Decimal)
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
#End Region
#Region "Validity Checks"
	Public Function CashValueInvalid(ByVal cashValueStr As String) As Boolean
		Return BEP_Util.invalidNum(cashValueStr)
	End Function
	Public Function PrizeIsBlank() As Boolean
		Return (Prize = "")
	End Function
#End Region
#Region "DetermineStepFlow"
	''' <summary>
	''' Queries to PayoutCategory to determine where to go.
	''' </summary>
	''' <returns>NextStep.</returns>
	''' <remarks>Trying to keep this as clean as possible.</remarks>
	Public Function DetermineStepFlow() As String
		Dim result As String = New String("")
		Select Case PayoutCatgory
			Case PromoPayoutCategory.freePlayCoupon
				result = "StepGeneratePayoutCoupon"
			Case PromoPayoutCategory.randomPrize	'Not implimented
				result = "StepG3"
			Case Else
				result = "StepH"
		End Select
		Return result
	End Function
#End Region
End Class

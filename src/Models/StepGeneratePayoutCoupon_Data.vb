''' <summary>
''' Contains data and validity checks for StepGeneratePayoutCoupon.
''' </summary>
''' <remarks>This is the Model for StepGeneratePayoutCoupon (Controller).</remarks>
Public Class StepGeneratePayoutCoupon_Data
	Implements IPromoData
#Region "PrepareData"
	Public Sub PrepareData(ByRef promoDataHash As Hashtable) _
		Implements IPromoData.PrepareData
		promoDataHash.Add("CouponID", CouponID)
		promoDataHash.Add("CouponAmtPerPatron", CouponAmtPerPatron)
		promoDataHash.Add("CouponAmtForEntirePromo", CouponAmtForEntirePromo)
		promoDataHash.Add("MaxNumOfCouponsPerPatron", MaxNumOfCouponsPerPatron)
	End Sub
#End Region
#Region "Properties"
	Private _promoCouponID As String = Nothing
	Private _promoCouponAmtPerPatron As System.Nullable(Of Decimal) = Nothing
	Private _promoCouponAmtForEntirePromo As System.Nullable(Of Decimal) = Nothing
	Private _promoMaxNumOfCouponsPerPatron As System.Nullable(Of Short) = Nothing

	Public Property CouponID As String
		Get
			Return _promoCouponID
		End Get
		Set(value As String)
			_promoCouponID = value
		End Set
	End Property
	Public Property CouponAmtPerPatron As System.Nullable(Of Decimal)
		Get
			Return _promoCouponAmtPerPatron
		End Get
		Set(value As System.Nullable(Of Decimal))
			_promoCouponAmtPerPatron = value
		End Set
	End Property
	Public Property CouponAmtForEntirePromo As System.Nullable(Of Decimal)
		Get
			Return _promoCouponAmtForEntirePromo
		End Get
		Set(value As System.Nullable(Of Decimal))
			_promoCouponAmtForEntirePromo = value
		End Set
	End Property
	Public Property MaxNumOfCouponsPerPatron As System.Nullable(Of Short)
		Get
			Return _promoMaxNumOfCouponsPerPatron
		End Get
		Set(value As System.Nullable(Of Short))
			_promoMaxNumOfCouponsPerPatron = value
		End Set
	End Property
#End Region
#Region "SetCouponId"
	Private Function setCouponId() As String
		Dim concatStr As String = New String("!")
		Return concatStr
	End Function
#End Region
#Region "Validity Checks"
	Public Function CouponAmtPerPatron_Invalid() As Boolean
		Return IsNothing(CouponAmtPerPatron)
	End Function
	Public Function CouponAmtForEntirePromo_Invalid() As Boolean
		Return IsNothing(CouponAmtForEntirePromo)
	End Function
	Public Function MaxNumOfCouponsPerPatron_Invalid() As Boolean
		Return IsNothing(MaxNumOfCouponsPerPatron)
	End Function
	Public Function BadCouponAmts() As Boolean
		Return (CouponAmtForEntirePromo < CouponAmtPerPatron)
	End Function
#End Region
End Class

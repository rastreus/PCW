''' <summary>
''' Contains data and validity checks for StepEntryTicketAmt.
''' </summary>
''' <remarks>This is the Model for StepEntryTicketAmt (Controller).</remarks>
Public Class StepGeneratePayoutCoupon_Data
#Region "Properties"
	Private _promoCouponId As String = Nothing
	Private _promoCouponAmtPerPatron As System.Nullable(Of Decimal) = Nothing
	Private _promoCouponAmtForEntirePromo As System.Nullable(Of Decimal) = Nothing
	Private _promoMaxNumOfCouponsPerPatron As System.Nullable(Of Short) = Nothing

	Public ReadOnly Property CouponId As String
		Get
			Return _promoCouponId
		End Get
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
End Class

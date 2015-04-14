Public Class StepGetCouponOffers_Data

#Region "New"
	Public Sub New()
		_dataCouponOffersHash = New Hashtable
		_dataCouponOffersStruct = New CouponOffersStruct
	End Sub
#End Region
#Region "Structures"
	Structure CouponOffersStruct
		Public _offerID As String
		Public _couponNum As Integer
		Public _validStart As DateTime
		Public _validEnd As DateTime
		Public _excludeDays As String
		Public _excludeStart As System.Nullable(Of DateTime)
		Public _excludeEnd As System.Nullable(Of DateTime)
		Public _fullValidate As Boolean
		Public _reprintable As Boolean
		Public _scanToReceipt As Boolean
		Public _note As String
	End Structure
#End Region
#Region "Properties"
	Private _dataCouponOffersHash As Hashtable
	Private _dataCouponOffersStruct As CouponOffersStruct

	Private Property CouponOffersHash As Hashtable
		Get
			Return _dataCouponOffersHash
		End Get
		Set(value As Hashtable)
			_dataCouponOffersHash = value
		End Set
	End Property
	Public Property CouponOffers As CouponOffersStruct
		Get
			Return _dataCouponOffersStruct
		End Get
		Set(value As CouponOffersStruct)
			_dataCouponOffersStruct = value
		End Set
	End Property
#End Region
#Region "AddCouponOfferToHash"
	Public Sub AddCouponOfferToList(ByRef couponOffer As CouponOffersStruct)
		Try
			CouponOffersHash.Add(couponOffer._couponNum.ToString, _
								 couponOffer)
		Catch ex As Exception
			'Possibly trying to add a Coupon which already has a key
		End Try
	End Sub
#End Region
End Class

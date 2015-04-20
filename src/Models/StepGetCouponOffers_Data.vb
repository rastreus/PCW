Public Class StepGetCouponOffers_Data

#Region "New"
	Public Sub New()
		_dataCouponOffersHash = New Hashtable
		_dataCouponOffersStruct = New CouponOffersStruct
		_promoSkipTargetImport = False
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
	Private _promoSkipTargetImport As Boolean

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
#Region "SkipTargetImport"
	''' <summary>
	''' Getter/Setter for _promoSkipTargetImport Boolean.
	''' </summary>
	''' <value>Pass True/False to Setter.</value>
	''' <returns>True/False.</returns>
	''' <remarks>
	''' StepGetCouponTargets MUST BE SKIPPED IF WILDCARD COUPON OFFER.
	''' </remarks>
	Public Property SkipTargetImport As Boolean
		Get
			Return _promoSkipTargetImport
		End Get
		Set(value As Boolean)
			_promoSkipTargetImport = value
		End Set
	End Property
#End Region
#End Region
#Region "Validity Checks"
	Public Function No_CouponOffers_Created() As Boolean
		Dim result As Boolean = If(CouponOffersHash.Count = 0, _
								   True, _
								   False)
		Return result
	End Function
#Region "Is_CouponOffer_Valid"
	Public Function Is_CouponOffer_Valid(ByRef couponOffer As CouponOffersStruct) As Boolean
		Dim result As Boolean = True
		If ValidEnd_Before_ValidStart(couponOffer._validEnd, _
									  couponOffer._validStart) Or
			ExcludeRange_Not_Within_ValidPeriod(couponOffer._validEnd, _
												couponOffer._validStart, _
												couponOffer._excludeEnd, _
												couponOffer._excludeStart) Then
			result = False 'No, The Coupon Offer is not valid.
		End If
		Return result
	End Function
	Private Function ValidEnd_Before_ValidStart(ByVal validEnd As DateTime, _
												ByVal validStart As DateTime) As Boolean
		Dim result As Boolean = False
		Dim compare As Integer = Date.Compare(validEnd, validStart)
		If compare < 0 Then
			result = True 'Yes, ValidEnd is earlier than ValidStart.
		End If
		Return result
	End Function
	Private Function ExcludeRange_Not_Within_ValidPeriod(ByVal validEnd As DateTime, _
														 ByVal validStart As DateTime, _
														 ByVal excludeEnd As DateTime, _
														 ByVal excludeStart As DateTime) As Boolean
		Dim result As Boolean = False
		Dim compareStarts As Integer = Date.Compare(excludeStart, validStart)
		Dim compareEnds As Integer = Date.Compare(excludeEnd, validEnd)
		If compareStarts < 0 Or
			compareEnds < 0 Then
			result = True 'Yes, Exclude Range is not within the Valid Period.
		End If
		Return result
	End Function
#End Region
#End Region
#Region "GetCouponNumber"
	Public Function GetCouponNumber(ByVal wildcardBool As Boolean) As Integer
		Dim result As Integer = 0
		If wildcardBool Then
			result = 0
		Else
			result = CouponOffersHash.Count + 1
		End If
		Return result
	End Function
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
#Region "GetCouponOfferListString"
	Public Function GetCouponOfferListString() As String
		Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder
		For Each key As String In CouponOffersHash.Keys
			builder.Append("Coupon Number: " & key & vbCrLf)
		Next
		Return builder.ToString()
	End Function
#End Region
End Class

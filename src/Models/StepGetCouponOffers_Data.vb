Public Class StepGetCouponOffers_Data

#Region "New"
	Public Sub New()
		_dataCouponOffersTplList = _
			New List(Of Tuple(Of CheckBox, CouponOffer))
		_dataCouponOffer = New CouponOffer
		_promoSkipTargetImport = False
	End Sub
#End Region
#Region "Properties"
	Private _stepNotSet As Boolean = True
	Private _dataCouponOffersTplList _
		As List(Of Tuple(Of CheckBox, CouponOffer))
	Private _dataCouponOffer As CouponOffer
	Private _promoSkipTargetImport As Boolean

	Public Property StepNotSet As Boolean
		Get
			Return _stepNotSet
		End Get
		Set(value As Boolean)
			_stepNotSet = value
		End Set
	End Property
	Public Property CouponOffersTplList _
		As List(Of Tuple(Of CheckBox, CouponOffer))
		Get
			Return _dataCouponOffersTplList
		End Get
		Set(value As List(Of Tuple(Of CheckBox, CouponOffer)))
			_dataCouponOffersTplList = value
		End Set
	End Property
	Public Property CouponOffers As CouponOffer
		Get
			Return _dataCouponOffer
		End Get
		Set(value As CouponOffer)
			_dataCouponOffer = value
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
#Region "No_CouponOffers_Created"
	Public Function No_CouponOffers_Created() As Boolean
		Dim result As Boolean = If(CouponOffersTplList.Count = 0, _
								   True, _
								   False)
		Return result
	End Function
#End Region
#Region "DetermineNextStep"
	Public Function DetermineNextStep(ByVal bool As Boolean) As String
		Dim result As String = New String(String.Empty)
		If bool Then
			result = "StepGetCouponTargets"
		Else
			result = "StepH"
		End If
		Return result
	End Function
#End Region
#Region "Is_CouponOffer_Valid"
	Public Function Is_CouponOffer_Valid(ByRef couponOffer As CouponOffer, _
										 ByRef willExcludeDays As Boolean) _
										 As Boolean
		Dim result As Boolean = True
		Dim _validStart As DateTime = couponOffer.ValidStart
		Dim _validEnd As DateTime = couponOffer.ValidEnd
		Dim _excludeStart As System.Nullable(Of DateTime) = _
			couponOffer.ExcludeStart
		Dim _excludeEnd As System.Nullable(Of DateTime) = _
			couponOffer.ExcludeEnd
		If EndDate_Before_StartDate(_validEnd, _validStart) Then
			result = False 'No, The Coupon Offer is not valid.
		End If
		If willExcludeDays Then
			If (ExcludeRange_Not_Within_ValidPeriod(_validEnd, _
												   _validStart, _
												   _excludeEnd, _
												   _excludeStart) Or _
				EndDate_Before_StartDate(_excludeEnd, _excludeStart)) Then
				result = False 'No, The Coupon Offer is not valid.
			End If
		End If
		Return result
	End Function
	Public Function EndDate_Before_StartDate(ByVal endDate As DateTime, _
											 ByVal startDate As DateTime) _
											 As Boolean
		Dim result As Boolean = False
		Dim compare As Integer = Date.Compare(endDate, startDate)
		If compare < 0 Then
			result = True 'Yes, ValidEnd is earlier than ValidStart.
		End If
		Return result
	End Function
	Private Function ExcludeRange_Not_Within_ValidPeriod( _
											ByVal validEnd As DateTime, _
											ByVal validStart As DateTime, _
											ByVal excludeEnd As DateTime, _
											ByVal excludeStart As DateTime) _
											As Boolean
		Dim result As Boolean = False
		Dim compareStarts As Integer = Date.Compare(excludeStart, validStart)
		Dim compareEnds As Integer = Date.Compare(excludeEnd, validEnd)
		If (compareStarts < 0) Or
			(compareEnds > 0) Then
			result = True 'Yes, Exclude Range is not within the Valid Period.
		End If
		Return result
	End Function
#End Region
#End Region
#Region "GetCouponNumber"
	Public Function GetCouponNumber(ByVal wildcardBool As Boolean) As Integer
		Dim result As Integer = 0
		If wildcardBool = True Then
			result = 0
		Else
			result = (CouponOffersTplList.Count + 1)
		End If
		Return result
	End Function
#End Region
#Region "AddCouponOffersToList"
	Public Sub AddCouponOffersToList()
		For Each tpl As Tuple(Of CheckBox, CouponOffer) In CouponOffersTplList
			PCW.Data.CouponOffersList.Add(tpl.Item2)
		Next
	End Sub
#End Region
#Region "GetCouponOfferNumbersAsArrayList"
	Public Function GetCouponOfferNumbersAsArrayList() As ArrayList
		Dim result As ArrayList = New ArrayList
		Dim split() As String
		For Each tpl As Tuple(Of CheckBox, CouponOffer) In CouponOffersTplList
			split = tpl.Item1.Text.Split(" ")
			result.Add(split(1))
		Next
		Return result
	End Function
#End Region
End Class

﻿#Region "COPYING"
'PromotionalCreationWizard
'Copyright (C) 2014-2016 Russell Dillin
'
'This file is part of PromotionalCreationWizard.

'   PromotionalCreationWizard is free software: you can redistribute it and/or
'   modify it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   PromotionalCreationWizard is distributed in the hope that it will be
'	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with PromotionalCreationWizard.
'	If not, see <http://www.gnu.org/licenses/>.
#End Region

Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields

''' <summary>
''' Contains data and validity checks for StepGeneratePayoutCoupon.
''' </summary>
''' <remarks>This is the Model for StepGeneratePayoutCoupon (Controller).</remarks>
Public Class StepGeneratePayoutCoupon_Data
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
			promoDataHash.Item(Key.CouponID) = _
				CouponID
			promoDataHash.Item(Key.CouponAmtPerPatron) = _
				CouponAmtPerPatron
			promoDataHash.Item(Key.CouponAmtForEntirePromo) = _
				CouponAmtForEntirePromo
			promoDataHash.Item(Key.MaxNumOfCouponsPerPatron) = _
				MaxNumOfCouponsPerPatron
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.CouponID, _
							  CouponID)
			promoDataHash.Add(Key.CouponAmtPerPatron, _
							  CouponAmtPerPatron)
			promoDataHash.Add(Key.CouponAmtForEntirePromo, _
							  CouponAmtForEntirePromo)
			promoDataHash.Add(Key.MaxNumOfCouponsPerPatron, _
							  MaxNumOfCouponsPerPatron)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
	Private _promoCouponID As String = Nothing
	Private _promoCouponAmtPerPatron _
		As System.Nullable(Of Decimal) = Nothing
	Private _promoCouponAmtForEntirePromo _
		As System.Nullable(Of Decimal) = Nothing
	Private _promoMaxNumOfCouponsPerPatron _
		As System.Nullable(Of Short) = Nothing

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
		Dim concatStr As String = New String(String.Empty)
		Return concatStr
	End Function
#End Region
#Region "Validity Checks"
	Private Function CouponAmtTooMuch(ByVal couponAmt As Decimal) As Boolean
		Dim result As Boolean = False
		If couponAmt > 99999.99 Then
			result = True
		End If
		Return result
	End Function
	Private Function CouponAmt_Invalid(ByVal couponAmt As Decimal) As Boolean
		Dim result As Boolean = False
		If IsNothing(couponAmt) Then
			result = True
		ElseIf CouponAmtTooMuch(couponAmt) Then
			result = True
		Else
			result = False
		End If
		Return result
	End Function
	Public Function CouponID_Invalid() As Boolean
		Dim result As Boolean = False
		If (CouponID.Length > 10) Then
			result = True
		End If
		Return result
	End Function
	Public Function CouponAmtPerPatron_Invalid() As Boolean
		Dim result As Boolean = CouponAmt_Invalid(CouponAmtPerPatron)
		Return result
	End Function
	Public Function CouponAmtForEntirePromo_Invalid() As Boolean
		Dim result As Boolean = CouponAmt_Invalid(CouponAmtForEntirePromo)
		Return result
	End Function
	Public Function MaxNumOfCouponsPerPatron_Invalid() As Boolean
		Return IsNothing(MaxNumOfCouponsPerPatron)
	End Function
	Public Function BadCouponAmts() As Boolean
		Return (CouponAmtForEntirePromo < CouponAmtPerPatron)
	End Function
#End Region
End Class

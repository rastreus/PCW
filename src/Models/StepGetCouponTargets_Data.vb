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

Public Class StepGetCouponTargets_Data

#Region "Properties"
	Private _stepNotSet As Boolean = True
	Private _dataCouponTargetsCSVFilePath As String = New String(String.Empty)
	Private _dataCouponTargetsCouponNum As Integer = New Integer
	Private _promoSameForAllDaysTiers As Boolean
	Private _dataCouponID As String

	Public Property StepNotSet As Boolean
		Get
			Return _stepNotSet
		End Get
		Set(value As Boolean)
			_stepNotSet = value
		End Set
	End Property
	Public Property CouponTargetsCSVFilePath As String
		Get
			Return _dataCouponTargetsCSVFilePath
		End Get
		Set(value As String)
			_dataCouponTargetsCSVFilePath = value
		End Set
	End Property
	Public Property CouponTargetsCouponNum As Byte
		Get
			Return _dataCouponTargetsCouponNum
		End Get
		Set(value As Byte)
			_dataCouponTargetsCouponNum = value
		End Set
	End Property
	Public Property SameForAllDaysTiers As Boolean
		Get
			Return _promoSameForAllDaysTiers
		End Get
		Set(value As Boolean)
			_promoSameForAllDaysTiers = value
		End Set
	End Property
	Public Property CouponID As String
		Get
			Return _dataCouponID
		End Get
		Set(value As String)
			_dataCouponID = value
		End Set
	End Property
#End Region
#Region "CSVtoCouponTargetsList"
	Public Sub CSVtoCouponTargetsList()
		Dim couponTargetListDBRow As CouponTarget
		Dim parser As New FileIO.TextFieldParser(CouponTargetsCSVFilePath)
		'Fields are separated by comma
		parser.Delimiters = New String() {","}
		'Each of the values are not enclosed w/ quotes
		parser.HasFieldsEnclosedInQuotes = False
		parser.TrimWhiteSpace = True

		'First line is skipped, its the headers
		parser.ReadLine()

		'Create a String Array
		Dim currentRow(17) As String
		Do Until parser.EndOfData = True
			Try
				currentRow = parser.ReadFields()
				couponTargetListDBRow = New CouponTarget
				couponTargetListDBRow = ParseIntoList(currentRow)
				PCW.Data.CouponTargetList.Add(couponTargetListDBRow)
			Catch ex As Exception
				GUI_Util.msgBox("ERROR: CSVtoCT, " & vbCrLf & _
								"Please contact IT. " & vbCrLf & _
								ex.Message)
			End Try
		Loop
	End Sub
#End Region
#Region "ParseIntoList"
	Private Function ParseIntoList(ByRef currentRow As String()) _
								   As CouponTarget
		Dim couponTarget As CouponTarget = New CouponTarget()
		couponTarget.OfferID = CouponID
		couponTarget.Coupon = CouponTargetsCouponNum
		couponTarget.Account = currentRow(1)
		couponTarget.Zip = getZip(currentRow(7))
		couponTarget.AvgTheo = removeDollarReturnDecimal(currentRow(12))
		couponTarget.Latency = getTruncatedDecimal(currentRow(11))
		couponTarget.BaseCoupon = removeDollarReturnDecimal(currentRow(13))
		couponTarget.ZoneAddon = removeDollarReturnDecimal(currentRow(16))
		couponTarget.OtherAddon = Nothing
		couponTarget.TotalCoupon = removeDollarReturnDecimal(currentRow(17))
		couponTarget.TestCoupon = IsTestCoupon()
		couponTarget.CreateDate = DateTime.Now
		couponTarget.Voided = Nothing
		Return couponTarget
	End Function

	Private Function getZip(ByVal input As String) As UInt64
		Dim zip As UInt64
		If input.Length > 10 Then
			zip = UInt64.Parse(input.Substring(0, 5))
		Else
			zip = UInt64.Parse(input)
		End If
		Return zip
	End Function
	Private Function getTruncatedDecimal(ByVal input As Decimal) _
										 As Decimal
		Dim truncation As Decimal = Math.Truncate(input)
		Return truncation
	End Function
	Private Function removeDollarReturnDecimal(ByVal input As String) _
											   As Decimal
		Dim tempStr As String
		Dim returningDecimal As Decimal = New Decimal
		Dim dollarSign As String = "$"
		If input.Substring(0, 1) = dollarSign Then
			tempStr = input.Replace(dollarSign, String.Empty)
			tempStr = tempStr.Trim
			returningDecimal = Decimal.Parse(tempStr)
		Else
			tempStr = input.Trim
			Try
				returningDecimal = Decimal.Parse(tempStr)
			Catch ex As Exception
				'Handle Exception
				'WHY FAIL SILENTLY?
				'WHAT'S THE POINT OF USING TRY-CATCH?
			End Try
		End If
		Return returningDecimal
	End Function
	Private Function IsTestCoupon() As Boolean
		Dim result As Boolean = False
#If DEBUG Then
		result = True
#End If
		Return result
	End Function
#End Region
End Class

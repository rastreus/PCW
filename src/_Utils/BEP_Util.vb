#Region "COPYING"
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

Imports System.Text.RegularExpressions

''' <summary>
''' Global Back End Processor class which handles common, utility tasks.
''' </summary>
''' <remarks></remarks>
Public Class BEP_Util
#Region "Properties"
	Private Shared _promoAmtStr As String = "Enter Amt Here"
	Private Shared _promoNumStr As String = "Enter # Here"
	Private Shared _promoDaysStr As String = "# of Days"
	Private Shared _promoTiersStr As String = "#"
	Private Shared _promoPrizeStr As String = "Enter Prize Here"

	Public Shared ReadOnly Property AmtStr As String
		Get
			Return _promoAmtStr
		End Get
	End Property
	Public Shared ReadOnly Property NumStr As String
		Get
			Return _promoNumStr
		End Get
	End Property
	Public Shared ReadOnly Property DaysStr As String
		Get
			Return _promoDaysStr
		End Get
	End Property
	Public Shared ReadOnly Property TiersStr As String
		Get
			Return _promoTiersStr
		End Get
	End Property
	Public Shared ReadOnly Property PrizeStr As String
		Get
			Return _promoPrizeStr
		End Get
	End Property
#End Region
#Region "Utility Subroutines"
	''' <summary>
	''' Formats days to what the database expects.
	''' </summary>
	''' <param name="inputDay"></param>
	''' <returns>A single-character String representing the inputDay.</returns>
	''' <remarks>Used by StepC and StepGetCouponOffers.</remarks>
	Public Shared Function daysFormat(ByVal inputDay As String) _
									  As String
		Dim returnDay As String = New String(String.Empty)
		Select Case inputDay
			Case "Sunday"
				returnDay = "N"
			Case "Monday"
				returnDay = "M"
			Case "Tuesday"
				returnDay = "T"
			Case "Wednesday"
				returnDay = "W"
			Case "Thursday"
				returnDay = "R"
			Case "Friday"
				returnDay = "F"
			Case "Saturday"
				returnDay = "S"
		End Select
		Return returnDay
	End Function
	''' <summary>
	''' Invalid if "0" or Not 1 or more digit.
	''' </summary>
	''' <param name="inputString"></param>
	''' <returns>The validity of the input String.</returns>
	''' <remarks>Don't like that it does the Short Parse.</remarks>
	Public Shared Function invalidNum(ByVal inputString As String) _
									  As Boolean
		Dim invalid As Boolean = False
		Dim inputInt As Short
		Dim RegexObj As Regex = New Regex("^\d+$")

		Try
			inputInt = Short.Parse(inputString)
			If (inputInt = 0) OrElse Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			'Will catch an OverflowException if input
			'is greater than Int16.MaxValue (32767).
			invalid = True
		End Try

		Return invalid
	End Function
	''' <summary>
	''' Invalid if "0" or Not 1 or more digit.
	''' </summary>
	''' <param name="inputString"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Shared Function invalidDecimal(ByVal inputString As String) _
										  As Boolean
		Dim invalid As Boolean = False
		Dim invalid_decimal As Decimal = 0.01
		Dim RegexObj As Regex = New Regex("^\d+\.\d{2}$")

		Try
			Dim input_decimal As Decimal = Decimal.Parse(inputString)
			If (input_decimal < invalid_decimal) OrElse _
				Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			invalid = True
		End Try

		Return invalid
	End Function
	''' <summary>
	''' Checks to see if the supplied ID (Promo or Coupon)
	''' matches the required pattern.
	''' </summary>
	''' <param name="inputStr"></param>
	''' <param name="limitNum"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function Invalid_CouponID(ByVal inputStr As String, _
									  ByVal limitNum As Short) _
									  As Boolean
		Dim invalid As Boolean = False
		Dim limitStr As String = limitNum.ToString
		Dim RegexObj As Regex = New Regex("^[a-zA-Z]{1," & _
										  limitStr & _
										  "}\d{4}$")

		If Not RegexObj.IsMatch(inputStr) Then
			invalid = True
		End If

		Return invalid
	End Function
#End Region
End Class

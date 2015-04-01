Imports System.Text.RegularExpressions

''' <summary>
''' Global Back End Processor class which handles common, utility tasks.
''' </summary>
''' <remarks></remarks>
Public Class BEP_Util
#Region "Utility Subroutines"
	''' <summary>
	''' Invalid if "0" or Not 1 or more digit.
	''' </summary>
	''' <param name="inputString"></param>
	''' <returns>The validity of the input String.</returns>
	''' <remarks>Don't like that it does the Short Parse.</remarks>
	Public Shared Function invalidNum(ByVal inputString As String) As Boolean
		Dim invalid As Boolean = False
		Dim inputInt As Short
		Dim RegexObj As Regex = New Regex("^\d+$")

		Try
			inputInt = Short.Parse(inputString)
			If (inputInt = 0) Or Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
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
	Public Shared Function invalidDecimal(ByVal inputString As String) As Boolean
		Dim invalid As Boolean = False
		Dim invalid_decimal As Decimal = 0.01
		Dim RegexObj As Regex = New Regex("^\d+\.\d{2}$")

		Try
			Dim input_decimal As Decimal = Decimal.Parse(inputString)
			If (input_decimal < invalid_decimal) Or Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			invalid = True
		End Try

		Return invalid
	End Function
	''' <summary>
	''' Checks to see if the supplied ID (Promo or Coupon) matches the required pattern.
	''' </summary>
	''' <param name="inputStr"></param>
	''' <param name="limitNum"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function Invalid_CouponID(ByVal inputStr As String, ByVal limitNum As Short) As Boolean
		Dim invalid As Boolean = False
		Dim limitStr As String = limitNum.ToString
		Dim RegexObj As Regex = New Regex("^[a-zA-Z]{1," & limitStr & "}\d{4}$")

		If Not RegexObj.IsMatch(inputStr) Then
			invalid = True
		End If

		Return invalid
	End Function
#End Region
End Class

Imports System.Text.RegularExpressions

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
#Region "Validity Checks"
	''' <summary>
	''' Checks to see if the supplied CouponID matches the required pattern.
	''' </summary>
	''' <param name="inputString"></param>
	''' <returns></returns>
	''' <remarks>Hard-limit of 10 character abbreviation (possibly problematic).</remarks>
	Private Function Invalid_CouponID(ByVal inputString As String) As Boolean
		Dim invalid As Boolean = False
		Dim RegexObj As Regex = New Regex("^[a-zA-Z]{1,10}\d{4}$")

		If Not RegexObj.IsMatch(inputString) Then
			invalid = True
		End If

		Return invalid
	End Function
#End Region
End Class

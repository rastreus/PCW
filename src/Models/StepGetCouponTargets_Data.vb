Public Class StepGetCouponTargets_Data

#Region "Properties"
	Private _dataCouponTargetsCSVFilePath As String = New String("")
	Private _dataCouponTargetsCouponNum As Integer = New Integer
	Private _promoSameForAllDaysTiers As Boolean

	Public Property CouponTargetsCSVFilePath As String
		Get
			Return _dataCouponTargetsCSVFilePath
		End Get
		Set(value As String)
			_dataCouponTargetsCSVFilePath = value
		End Set
	End Property
	Public Property CouponTargetsCouponNum As Integer
		Get
			Return _dataCouponTargetsCouponNum
		End Get
		Set(value As Integer)
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
#End Region
#Region "CSVtoCouponTargetsList"
	Public Sub CSVtoCouponTargetsList(ByRef list As List(Of CouponTarget))
		Dim parser As New FileIO.TextFieldParser(CouponTargetsCSVFilePath)
		parser.Delimiters = New String() {","}		'Fields are separated by comma
		parser.HasFieldsEnclosedInQuotes = False	'Each of the values are not enclosed w/ quotes
		parser.TrimWhiteSpace = True

		parser.ReadLine()							'First line is skipped, its the headers

		Dim currentRow(17) As String				'Create a String Array
		Do Until parser.EndOfData = True
			Try
				currentRow = parser.ReadFields()
				ParseIntoList(currentRow, list)
			Catch ex As Exception
				'Handle Exception
			End Try
		Loop
	End Sub
#End Region
#Region "ParseIntoList"
	Private Sub ParseIntoList(ByRef currentRow As String(), _
							  ByRef list As List(Of CouponTarget))
		Dim couponTarget As CouponTarget = New CouponTarget()
		couponTarget.OfferID = currentRow(0)
		couponTarget.Coupon = CouponTargetsCouponNum
		couponTarget.Account = currentRow(1)
		couponTarget.Zip = getZip(currentRow(7))
		couponTarget.AvgTheo = removeDollarReturnDecimal(currentRow(12))
		couponTarget.Latency = getInt(currentRow(11))
		couponTarget.BaseCoupon = removeDollarReturnDecimal(currentRow(13))
		couponTarget.ZoneAddon = removeDollarReturnDecimal(currentRow(16))
		couponTarget.OtherAddon = Nothing
		couponTarget.TotalCoupon = removeDollarReturnDecimal(currentRow(17))
		couponTarget.TestCoupon = 0
		couponTarget.CreateDate = Date.Today.Date
		list.Add(couponTarget)
	End Sub
#End Region
#Region "CSVtoDataTable_Util"
	Private Function getZip(ByVal input As String) As UInt64
		Dim zip As UInt64
		If input.Length > 5 Then
			zip = UInt64.Parse(input.Substring(0, 5))
		Else
			zip = UInt64.Parse(input)
		End If
		Return zip
	End Function
	Private Function getInt(ByVal input As Decimal) As Integer
		Dim truncation As Integer = Math.Truncate(input)
		Return truncation
	End Function
	Private Function removeDollarReturnDecimal(ByVal input As String) As Decimal
		Dim tempStr As String
		Dim returningDecimal As Decimal = New Decimal
		Dim dollarSign As String = "$"
		If input.Substring(0, 1) = dollarSign Then
			tempStr = input.Replace(dollarSign, "")
			tempStr = tempStr.Trim
			returningDecimal = Decimal.Parse(tempStr)
		Else
			tempStr = input.Trim
			Try
				returningDecimal = Decimal.Parse(tempStr)
			Catch ex As Exception
				'
			End Try
		End If
		Return returningDecimal
	End Function
#End Region
#Region "Validity Checks"
	'
	'Not sure what this was being used for?
	'Commented out for the time-being.
	'As of: 05/22/2015; GRD
	'
	'Public Function No_CouponTargets_Created() As Boolean
	'	Dim result As Boolean = If(_dataCouponTargetsList.Count = 0, _
	'							   True, _
	'							   False)
	'	Return result
	'End Function
#End Region
End Class

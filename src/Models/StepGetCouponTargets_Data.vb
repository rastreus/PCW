Public Class StepGetCouponTargets_Data
	Implements IDisposable

#Region "IDisposable Support"
	Private disposedValue As Boolean ' To detect redundant calls

	' IDisposable
	Protected Overridable Sub Dispose(disposing As Boolean)
		If Not Me.disposedValue Then
			If disposing Then
				' TODO: dispose managed state (managed objects).
				Me._dataCouponTargetsDataTable.Dispose()
			End If

			' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
			' TODO: set large fields to null.
		End If
		Me.disposedValue = True
	End Sub

	' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
	'Protected Overrides Sub Finalize()
	'    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
	'    Dispose(False)
	'    MyBase.Finalize()
	'End Sub

	' This code added by Visual Basic to correctly implement the disposable pattern.
	Public Sub Dispose() Implements IDisposable.Dispose
		' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
#End Region
#Region "New"
	Public Sub New()
		MakeCouponTargetsDataTable()
	End Sub

	Private Sub MakeCouponTargetsDataTable()
		Me._dataCouponTargetsDataTable = New DataTable("CouponTargets")
		CouponTargetsDataTable.Columns.Add("OfferID", GetType(String))
		CouponTargetsDataTable.Columns.Add("Coupon", GetType(Short))
		CouponTargetsDataTable.Columns.Add("Account", GetType(UInt64))
		CouponTargetsDataTable.Columns.Add("Zip", GetType(UInt64))
		CouponTargetsDataTable.Columns.Add("AvgTheo", GetType(Decimal))
		CouponTargetsDataTable.Columns.Add("Latency", GetType(Integer))
		CouponTargetsDataTable.Columns.Add("BaseCoupon", GetType(Decimal))
		CouponTargetsDataTable.Columns.Add("ZoneAddon", GetType(Decimal))
		CouponTargetsDataTable.Columns.Add("OtherAddon", GetType(Decimal))
		CouponTargetsDataTable.Columns.Add("TotalCoupon", GetType(Decimal))
		CouponTargetsDataTable.Columns.Add("TestCoupon", GetType(Boolean))
		CouponTargetsDataTable.Columns.Add("CreateDate", GetType(Date))
	End Sub
#End Region
#Region "Properties"
	Private _dataCouponTargetsList As ArrayList = New ArrayList
	Private _dataCouponTargetsCSVFilePath As String = New String("")
	Private _dataCouponTargetsCouponNum As Integer = New Integer
	Private _dataCouponTargetsDataTable As DataTable
	Private _promoSameForAllDaysTiers As Boolean

	Public Property CouponTargetsList As ArrayList
		Get
			Return _dataCouponTargetsList
		End Get
		Set(value As ArrayList)
			_dataCouponTargetsList = value
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
	Public Property CouponTargetsCouponNum As Integer
		Get
			Return _dataCouponTargetsCouponNum
		End Get
		Set(value As Integer)
			_dataCouponTargetsCouponNum = value
		End Set
	End Property
	Public Property CouponTargetsDataTable As DataTable
		Get
			Return _dataCouponTargetsDataTable
		End Get
		Set(value As DataTable)
			_dataCouponTargetsDataTable = value
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
#Region "CSVtoCouponTargetsDataTable"
	Public Sub CSVtoCouponTargetsDataTable()
		Dim parser As New FileIO.TextFieldParser(CouponTargetsCSVFilePath)
		parser.Delimiters = New String() {","}		'Fields are separated by comma
		parser.HasFieldsEnclosedInQuotes = False	'Each of the values are not enclosed w/ quotes
		parser.TrimWhiteSpace = True

		parser.ReadLine()							'First line is skipped, its the headers

		Dim currentRow(17) As String				'Create a String Array
		Do Until parser.EndOfData = True
			Try
				currentRow = parser.ReadFields()
				CouponTargetsDataTable.Rows.Add(currentRow(0), _
												CouponTargetsCouponNum, _
												currentRow(1), _
												getZip(currentRow(7)), _
												removeDollarReturnDecimal(currentRow(12)), _
												getInt(currentRow(11)), _
												removeDollarReturnDecimal(currentRow(13)), _
												removeDollarReturnDecimal(currentRow(16)), _
												Nothing, _
												removeDollarReturnDecimal(currentRow(17)), _
												0,
												Date.Today.Date)

			Catch ex As Exception
				'
			End Try
		Loop
		AddDataTableToCouponTargetsList()
	End Sub

	Private Sub AddDataTableToCouponTargetsList()
		_dataCouponTargetsList.Add(CouponTargetsDataTable)
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
	Public Function No_CouponTargets_Created() As Boolean
		Dim result As Boolean = If(_dataCouponTargetsList.Count = 0, _
								   True, _
								   False)
		Return result
	End Function
#End Region
End Class

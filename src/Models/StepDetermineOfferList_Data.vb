Public Class StepDetermineOfferList_Data
	Implements IDisposable

#Region "IDisposable Support"
	Private disposedValue As Boolean ' To detect redundant calls

	' IDisposable
	Protected Overridable Sub Dispose(disposing As Boolean)
		If Not Me.disposedValue Then
			If disposing Then
				' TODO: dispose managed state (managed objects).
				Me._dataEligiblePlayersDataTable.Dispose()
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
		MakeEligiblePlayersDataTable()
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

	Private Sub MakeEligiblePlayersDataTable()
		Me._dataEligiblePlayersDataTable = New DataTable("EligiblePlayers")
		EligiblePlayersDataTable.Columns.Add("PromoID", GetType(String))
		EligiblePlayersDataTable.Columns.Add("PlayerID", GetType(UInt64))
		EligiblePlayersDataTable.Columns.Add("NumOfTickets", GetType(Integer))
		EligiblePlayersDataTable.Columns.Add("TicketAmount", GetType(Decimal))
	End Sub
#End Region
#Region "Properties"
	Private _dataEligiblePlayersCSVFilePath As String = New String("")
	Private _dataCouponTargetsCSVFilePath As String = New String("")
	Private _dataEligiblePlayersCouponNum As Integer = New Integer
	Private _dataCouponTargetsCouponNum As Integer = New Integer
	Private _dataEligiblePlayersDataTable As DataTable
	Private _dataCouponTargetsDataTable As DataTable

	Public Property EligiblePlayersCSVFilePath As String
		Get
			Return _dataEligiblePlayersCSVFilePath
		End Get
		Set(value As String)
			_dataEligiblePlayersCSVFilePath = value
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
	Public Property EligiblePlayersCouponNum As Integer
		Get
			Return _dataEligiblePlayersCouponNum
		End Get
		Set(value As Integer)
			_dataEligiblePlayersCouponNum = value
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
	Public Property EligiblePlayersDataTable As DataTable
		Get
			Return _dataEligiblePlayersDataTable
		End Get
		Set(value As DataTable)
			_dataEligiblePlayersDataTable = value
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
#End Region
#Region "CSVtoCouponTargets"
	Private Sub CSVtoCouponTargetsDataTable(ByVal couponNum As Integer)
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
												couponNum, _
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
	End Sub
#End Region
#Region "CSVtoEligiblePlayers"
	Private Sub CSVtoEligiblePlayersDataTable(ByVal promoID As String)
		Dim parser As New FileIO.TextFieldParser(EligiblePlayersCSVFilePath)
		parser.Delimiters = New String() {","}		'Fields are separated by comma
		parser.HasFieldsEnclosedInQuotes = False	'Each of the values are not enclosed w/ quotes
		parser.TrimWhiteSpace = True

		parser.ReadLine()							'First line is skipped, its the headers

		Dim currentRow(13) As String				'Create a String Array
		Do Until parser.EndOfData = True
			Try
				currentRow = parser.ReadFields()
				EligiblePlayersDataTable.Rows.Add(promoID, _
												  currentRow(0), _
												  currentRow(13), _
												  Nothing)

			Catch ex As Exception
				'
			End Try
		Loop
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
End Class

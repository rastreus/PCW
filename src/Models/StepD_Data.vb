Imports Key = PromotionalCreationWizard.PCW_Data.PromoFields

''' <summary>
''' Contains data and validity checks for StepD.
''' </summary>
''' <remarks>This is the Model for StepD (Controller).</remarks>
Public Class StepD_Data
	Implements IPromoData
	Implements IDisposable

#Region "IDisposable Support"
	Private disposedValue As Boolean ' To detect redundant calls

	' IDisposable
	Protected Overridable Sub Dispose(disposing As Boolean)
		If Not Me.disposedValue Then
			If disposing Then
				' TODO: dispose managed state (managed objects).
				Me._dataEligiblePlayersDataTable.Dispose()
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
		MakeEligiblePlayersDataTable()
	End Sub

	Private Sub MakeEligiblePlayersDataTable()
		Me._dataEligiblePlayersDataTable = New DataTable("EligiblePlayers")
		EligiblePlayersDataTable.Columns.Add("PromoID", GetType(String))
		EligiblePlayersDataTable.Columns.Add("PlayerID", GetType(UInt64))
		EligiblePlayersDataTable.Columns.Add("NumOfTickets", GetType(Integer))
		EligiblePlayersDataTable.Columns.Add("TicketAmount", GetType(Decimal))
	End Sub
#End Region
#Region "ToPromoStepList"
	Public Sub ToPromoStepList(ByVal stepName As TSWizards.BaseInteriorStep, ByRef promoStepList As ArrayList) _
		Implements IPromoData.ToPromoStepList
		promoStepList.Add(stepName.Name)
	End Sub
#End Region
#Region "PrepareData"
	Public Sub PrepareData(ByRef promoDataHash As Hashtable) _
		Implements IPromoData.PrepareData
		'Set the Item if already in the Hashtable
		If DataAddedToHash Then
			promoDataHash.Item(Key.PointCutoffLimit) = PointCutoffLimit
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.PointCutoffLimit, PointCutoffLimit)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _promoCategory As PCW_Data.PromoCategory
	Private _promoMutiPartDaysTiers As String = Nothing
	Private _promoPointCutoffLimit As System.Nullable(Of Short)
	Private _promoPathToFile As String
	Private _promoSkipEntry As Boolean = False
	Private _promoSkipPayout As Boolean = False
	Private _dataEligiblePlayersCSVFilePath As String = New String("")
	Private _dataEligiblePlayersDataTable As DataTable

	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property Category As PCW_Data.PromoCategory
		Get
			Return _promoCategory
		End Get
		Set(value As PCW_Data.PromoCategory)
			_promoCategory = value
		End Set
	End Property
	Public Property MuliPartDaysTiers As String
		Get
			Return _promoMutiPartDaysTiers
		End Get
		Set(value As String)
			_promoMutiPartDaysTiers = value
		End Set
	End Property
	Public Property PointCutoffLimit As System.Nullable(Of Short)
		Get
			Return _promoPointCutoffLimit
		End Get
		Set(value As System.Nullable(Of Short))
			_promoPointCutoffLimit = value
		End Set
	End Property
	Public Property PathToFile As String
		Get
			Return _promoPathToFile
		End Get
		Set(value As String)
			_promoPathToFile = value
		End Set
	End Property
	Public Property SkipEntry As Boolean
		Get
			Return _promoSkipEntry
		End Get
		Set(value As Boolean)
			_promoSkipEntry = value
		End Set
	End Property
	Public Property SkipPayout As Boolean
		Get
			Return _promoSkipPayout
		End Get
		Set(value As Boolean)
			_promoSkipPayout = value
		End Set
	End Property
	Public Property EligiblePlayersCSVFilePath As String
		Get
			Return _dataEligiblePlayersCSVFilePath
		End Get
		Set(value As String)
			_dataEligiblePlayersCSVFilePath = value
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
#End Region
#Region "CSVtoEligiblePlayers"
	Public Sub CSVtoEligiblePlayersDataTable(ByVal promoID As String)
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
#Region "Validity Checks"
	Public Function PointCutoffLimit_Invalid() As Boolean
		Return IsNothing(PointCutoffLimit)
	End Function
#End Region
#Region "CheckForReset"
	Public Sub CheckForReset()
		If Me.Category = PCW_Data.PromoCategory.multiPart Then
			PCW.Data.Reset = True
			'Single Entry w/ multiple Payouts
			PCW.Data.ResetTo = "StepF"
		End If
	End Sub
#End Region
#Region "DetermineStepFlow"
	''' <summary>
	''' Queries to PromoCategory to determine where to go.
	''' </summary>
	''' <returns>NextStep.</returns>
	''' <remarks>Trying to keep this as clean as possible.</remarks>
	Public Function DetermineStepFlow() As String
		Dim result As String = New String("")
		Select Case Category
			Case PCW_Data.PromoCategory.payoutOnly
				result = "StepF"
			Case Else
				result = "StepEntryTicketAmt"
		End Select
		Return result
	End Function
#End Region
End Class

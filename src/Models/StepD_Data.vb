Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields

''' <summary>
''' Contains data and validity checks for StepD.
''' </summary>
''' <remarks>This is the Model for StepD (Controller).</remarks>
Public Class StepD_Data
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
	Private _promoMultiPartDaysTiers As String = Nothing
	Private _promoPointCutoffLimit As System.Nullable(Of Short)
	Private _promoPathToFile As String
	Private _promoSkipEntry As Boolean = False
	Private _promoSkipPayout As Boolean = False
	Private _dataEligiblePlayersCSVFilePath As String = New String(String.Empty)
	Private _promoMultiPartCategory As PCW_Data.MultiPartCategory

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
	Public Property MultiPartCategory As PCW_Data.MultiPartCategory
		Get
			Return _promoMultiPartCategory
		End Get
		Set(value As PCW_Data.MultiPartCategory)
			_promoMultiPartCategory = value
		End Set
	End Property
	Public Property MultiPartDaysTiers As String
		Get
			Return _promoMultiPartDaysTiers
		End Get
		Set(value As String)
			_promoMultiPartDaysTiers = value
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
#End Region
#Region "CSVtoEligiblePlayersList"
	Public Sub CSVtoEligiblePlayersList(ByVal promoID As String)
		Dim playerID As Integer
		Dim numOfTickets As Short
		Dim marketingPromoEligiblePlayerDBRow As MarketingPromoEligiblePlayer
		Dim parser As New FileIO.TextFieldParser(EligiblePlayersCSVFilePath)
		parser.Delimiters = New String() {","}		'Fields are separated by comma
		parser.HasFieldsEnclosedInQuotes = False	'Each of the values are not enclosed w/ quotes
		parser.TrimWhiteSpace = True

		parser.ReadLine()							'First line is skipped, its the headers

		Dim currentRow(13) As String				'Create a String Array
		Do Until parser.EndOfData = True
			Try
				currentRow = parser.ReadFields()
				playerID = currentRow(0)
				numOfTickets = currentRow(13)
				marketingPromoEligiblePlayerDBRow = New MarketingPromoEligiblePlayer
				marketingPromoEligiblePlayerDBRow = ParseIntoList(promoID, playerID, numOfTickets)
				PCW.Data.EligiblePlayerList.Add(marketingPromoEligiblePlayerDBRow)
			Catch ex As Exception
				GUI_Util.msgBox("ERROR: CSVtoEP, " & vbCrLf & _
								"Please contact IT " & vbCrLf & _
								ex.Message)
			End Try
		Loop
	End Sub
#End Region
#Region "ParseIntoList"
	Private Function ParseIntoList(ByRef promoID As String, _
								   ByRef playerID As Integer, _
								   ByRef numOfTickets As Short) _
								   As MarketingPromoEligiblePlayer
		Dim eligiblePlayers As MarketingPromoEligiblePlayer = _
			New MarketingPromoEligiblePlayer()
		eligiblePlayers.PromoID = promoID
		eligiblePlayers.PlayerID = playerID
		eligiblePlayers.NumOfTickets = numOfTickets
		eligiblePlayers.TicketAmount = Nothing
		Return eligiblePlayers
	End Function
#End Region
#Region "Validity Checks"
	Public Function PointCutoffLimit_Invalid() As Boolean
		Return IsNothing(PointCutoffLimit)
	End Function
#End Region
#Region "CheckForReset"
	''' <summary>
	''' "Loops" for another go.
	''' </summary>
	''' <remarks>I'm not sure this is
	''' even needed anymore?</remarks>
	Public Sub CheckForReset()
		If (Me.Category = PCW_Data _
						  .PromoCategory _
						  .multiPart) And _
			(Me.MultiPartCategory = PCW_Data _
									.MultiPartCategory _
									.multiPartDiff) Then
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
		Dim result As String = New String(String.Empty)
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

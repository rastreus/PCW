Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields
Imports PromotionalCreationWizard.SelectorButton

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
	Private _dataEligiblePlayersCSVFilePath As String = _
		New String(String.Empty)
	Private _promoMultiPartCategory As PCW_Data.MultiPartCategory
	Private _dataTempEligiblePlayersList As  _
		List(Of MarketingPromoEligiblePlayer) = _
		New List(Of MarketingPromoEligiblePlayer)

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
	Private Property TempList As List(Of MarketingPromoEligiblePlayer)
		Get
			Return _dataTempEligiblePlayersList
		End Get
		Set(value As List(Of MarketingPromoEligiblePlayer))
			_dataTempEligiblePlayersList = value
		End Set
	End Property
#End Region
#Region "CSVtoEligiblePlayersList"
	Public Function CSVtoEligiblePlayersList(ByVal promoID As String, _
											 ByVal playerIDIndex As Integer, _
											 ByVal numOfTicketsIndex As Integer) As Integer
		Dim MAX_LEN As Integer = -1
		Dim numOfCols As Integer = 0
		Dim playerID As Integer
		Dim numOfTickets As System.Nullable(Of Short)
		Dim marketingPromoEligiblePlayerDBRow As MarketingPromoEligiblePlayer
		Dim parser As New FileIO.TextFieldParser(EligiblePlayersCSVFilePath)
		If TempList.Count > 0 Then
			TempList.Clear()
		End If
		'Fields are separated by comma
		parser.Delimiters = New String() {","}
		'Each of the values are not enclosed w/ quotes
		parser.HasFieldsEnclosedInQuotes = False
		parser.TrimWhiteSpace = True

		'First line of headers is counted
		For Each header As String In parser.ReadFields()
			numOfCols += 1
		Next
		MAX_LEN = numOfCols

		'Create a String Array
		Dim currentRow(MAX_LEN) As String
		Dim incorrectLength As Integer = 0
		Do Until parser.EndOfData = True
			Try
				Dim index As Short = 0
				For Each field As String In parser.ReadFields()
					currentRow(index) = field
					If index < MAX_LEN Then
						index += 1
					End If
				Next
				If index = MAX_LEN Then
					playerID = currentRow(playerIDIndex)
					'If numOfTickets is NULL,
					'GPM will prompt for 1 or 2
					'tickets to be printed.
					If currentRow(numOfTicketsIndex) = String.Empty Then
						numOfTickets = Nothing
					Else
						numOfTickets = currentRow(numOfTicketsIndex)
					End If
					marketingPromoEligiblePlayerDBRow = _
						New MarketingPromoEligiblePlayer
					marketingPromoEligiblePlayerDBRow = _
						ParseIntoList(promoID, playerID, numOfTickets)
					TempList.Add(marketingPromoEligiblePlayerDBRow)
				Else
					incorrectLength += 1
				End If
			Catch ex As Exception
				GUI_Util.msgBox("ERROR: CSVtoEP, " & vbCrLf & _
								"Please contact IT " & vbCrLf & _
								ex.Message)
			End Try
		Loop
		parser.Close()
		Return incorrectLength
	End Function
#End Region
#Region "ParseIntoList"
	Private Function ParseIntoList(ByRef promoID As String, _
								   ByRef playerID As Integer, _
								   ByRef numOfTickets _
								   As System.Nullable(Of Short)) _
								   As MarketingPromoEligiblePlayer
		Dim eligiblePlayers As MarketingPromoEligiblePlayer = _
			New MarketingPromoEligiblePlayer()
		eligiblePlayers.PromoID = promoID & "E"
		eligiblePlayers.PlayerID = playerID
		eligiblePlayers.NumOfTickets = numOfTickets
		eligiblePlayers.TicketAmount = Nothing
		Return eligiblePlayers
	End Function
#End Region
#Region "TempIntoReal"
	Public Sub TempIntoReal()
		For Each ep As MarketingPromoEligiblePlayer In TempList
			PCW.Data.EligiblePlayerList.Add(ep)
		Next
	End Sub
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
						  .multiPart) AndAlso _
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

''' <summary>
''' Contains data and validity checks for StepD.
''' </summary>
''' <remarks>This is the Model for StepD (Controller).</remarks>
Public Class StepD_Data
	Implements IPromoData

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
			promoDataHash.Item("PointCutoffLimit") = PointCutoffLimit
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add("PointCutoffLimit", PointCutoffLimit)
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
#End Region
#Region "Validity Checks"
	Public Function PointCutoffLimit_Invalid() As Boolean
		Return IsNothing(PointCutoffLimit)
	End Function
#End Region
#Region "CheckForReset"
	Public Sub CheckForReset()
		If (Me.Category = PCW_Data.PromoCategory.entryAndPayout) Or
			(Me.Category = PCW_Data.PromoCategory.multPart) Then
			PCW.Data.Reset = True
			PCW.Data.ResetTo = "StepD"
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

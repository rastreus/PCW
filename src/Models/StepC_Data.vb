''' <summary>
''' Contains data and validity checks for StepC. 
''' </summary>
''' <remarks>This is the Model for StepC (Controller).</remarks>
Public Class StepC_Data
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
			promoDataHash.Item("OccursDate") = OccursDate
			promoDataHash.Item("StartDate") = StartDate
			promoDataHash.Item("EndDate") = EndDate
			promoDataHash.Item("RecursOnWeekday") = RecursOnWeekday
			promoDataHash.Item("EarnsOnWeekday") = EarnsOnWeekday
			promoDataHash.Item("CountCurrentDay") = CountCurrentDay
		Else 'Othewise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add("OccursDate", OccursDate)
			promoDataHash.Add("StartDate", StartDate)
			promoDataHash.Add("EndDate", EndDate)
			promoDataHash.Add("RecursOnWeekday", RecursOnWeekday)
			promoDataHash.Add("EarnsOnWeekday", EarnsOnWeekday)
			promoDataHash.Add("CountCurrentDay", CountCurrentDay)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _promoOccursDate As System.Nullable(Of Date)
	Private _promoStartDate As System.Nullable(Of Date)
	Private _promoEndDate As System.Nullable(Of Date)
	Private _promoRecursOnWeekday As String
	Private _promoEarnsOnWeekday As String
	Private _promoCountCurrentDay As Boolean

	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property OccursDate As System.Nullable(Of Date)
		Get
			Return _promoOccursDate
		End Get
		Set(value As System.Nullable(Of Date))
			_promoOccursDate = value
		End Set
	End Property
	Public Property StartDate As System.Nullable(Of Date)
		Get
			Return _promoStartDate
		End Get
		Set(value As System.Nullable(Of Date))
			_promoStartDate = value
		End Set
	End Property
	Public Property EndDate As System.Nullable(Of Date)
		Get
			Return _promoEndDate
		End Get
		Set(value As System.Nullable(Of Date))
			_promoEndDate = value
		End Set
	End Property
	Public Property RecursOnWeekday As String
		Get
			Return _promoRecursOnWeekday
		End Get
		Set(value As String)
			_promoRecursOnWeekday = value
		End Set
	End Property
	Public Property EarnsOnWeekday As String
		Get
			Return _promoEarnsOnWeekday
		End Get
		Set(value As String)
			_promoEarnsOnWeekday = value
		End Set
	End Property
	Public Property CountCurrentDay As Boolean
		Get
			Return _promoCountCurrentDay
		End Get
		Set(value As Boolean)
			_promoCountCurrentDay = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function QualifyingPeriod_NotEstablished(ByRef startDayBool As Boolean, ByRef endDayBool As Boolean) As Boolean
		Dim invalid As Boolean = False

		If (startDayBool = False) Or (endDayBool = False) Then
			invalid = True
		End If

		Return invalid
	End Function

	Public Function PrimaryDay_NotEstablished(ByRef primaryDayBool As Boolean) As Boolean
		Dim invalid As Boolean = False

		If primaryDayBool = False Then
			invalid = True
		End If

		Return invalid
	End Function

	Public Function OccursDate_NotEstablished(ByRef occursDateBool As Boolean) As Boolean
		Dim invalid As Boolean = False

		If occursDateBool = False Then
			invalid = True
		End If

		Return invalid
	End Function
#End Region
End Class

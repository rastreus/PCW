Public Class StepCanHazSecurity_Data
	Implements IPromoData

#Region "ToPromoStepList"
	Public Sub ToPromoStepList(stepName As TSWizards.BaseInteriorStep, ByRef promoStepList As ArrayList) _
		Implements IPromoData.ToPromoStepList
		promoStepList.Add(stepName.Name)
	End Sub
#End Region
#Region "PrepareData"
	Public Sub PrepareData(ByRef promoDataHash As Hashtable) _
		Implements IPromoData.PrepareData
		'Set the Item if already in the Hashtable
		If DataAddedToHash Then
			promoDataHash.Item("OverrideTime") = OverrideTime
			promoDataHash.Item("CutoffTime") = CutoffTime
		Else 'Othewise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add("OverrideTime", OverrideTime)
			promoDataHash.Add("CutoffTime", CutoffTime)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _promoOverrideTime As DateTime
	Private _promoCutoffTime As DateTime

	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property OverrideTime As DateTime
		Get
			Return _promoOverrideTime
		End Get
		Set(value As DateTime)
			_promoOverrideTime = value
		End Set
	End Property
	Public Property CutoffTime As DateTime
		Get
			Return _promoCutoffTime
		End Get
		Set(value As DateTime)
			_promoCutoffTime = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function OverrideTime_Invalid() As Boolean
		Return Are_Times_Invalid(OverrideTime)
	End Function

	Public Function CutoffTime_Invalid() As Boolean
		Return Are_Times_Invalid(CutoffTime)
	End Function

	Private Function Are_Times_Invalid(ByVal dateToCompare As Date) As Boolean
		Dim local_stepC As StepC = PCW.GetStep("StepC")
		Dim compare As Integer = Date.Compare(dateToCompare, local_stepC.Data.EndDate)
		Dim result As Boolean = False
		If (compare > 0) Then
			result = True
		End If
		Return result
	End Function
#End Region
End Class
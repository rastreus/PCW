Imports Key = PromotionalCreationWizard.PCW_Data.PromoFields

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
			promoDataHash.Item(Key.OverrideTime) = OverrideTime
			promoDataHash.Item(Key.CutoffTime) = CutoffTime
		Else 'Othewise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.OverrideTime, OverrideTime)
			promoDataHash.Add(Key.CutoffTime, CutoffTime)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _promoOverrideTime As String
	Private _promoCutoffTime As String

	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property OverrideTime As String
		Get
			Return _promoOverrideTime
		End Get
		Set(value As String)
			_promoOverrideTime = value
		End Set
	End Property
	Public Property CutoffTime As String
		Get
			Return _promoCutoffTime
		End Get
		Set(value As String)
			_promoCutoffTime = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function OverrideTime_Invalid() As Boolean
		Return Time_Is_Invalid(OverrideTime)
	End Function

	Public Function CutoffTime_Invalid() As Boolean
		Return Time_Is_Invalid(CutoffTime)
	End Function

	Private Function Time_Is_Invalid(ByVal timeStr As String) As Boolean
		Dim result As Boolean = False
		If Not_Five_Chars(timeStr) Or
			Time_Not_Set(timeStr) Or
			Hours_Are_Invalid(timeStr) Or
			Minutes_Are_Invalid(timeStr) Then
			result = True
		End If
		Return result
	End Function

	Private Function Not_Five_Chars(ByVal timeStr As String) As Boolean
		Dim result As Boolean = If(timeStr.Length < 5,
								   True,
								   False)
		Return result
	End Function

	Private Function Time_Not_Set(ByVal timeStr As String) As Boolean
		Dim result As Boolean = If((timeStr = "A" Or timeStr = "P"),
								   True,
								   False)
		Return result
	End Function

	Private Function Hours_Are_Invalid(ByVal timeStr As String) As Boolean
		Dim result As Boolean = False
		Dim hoursStr As String = New String("!")
		Dim hours As Short = 0
		Try
			hoursStr = timeStr.Substring(0, 2)
			hours = Short.Parse(hoursStr)
		Catch ex As Exception
			'Handle Exception
		End Try
		If hours < 1 Or
			hours > 12 Then
			result = True
		End If
		Return result
	End Function

	Private Function Minutes_Are_Invalid(ByVal timeStr As String) As Boolean
		Dim result As Boolean = False
		Dim minutesStr As String = New String("!")
		Dim minutes As Short = 0
		Try
			minutesStr = timeStr.Substring(2, 2)
			minutes = Short.Parse(minutesStr)
		Catch ex As Exception
			'Handle Exception
		End Try
		If minutes < 0 Or
			minutes > 59 Then
			result = True
		End If
		Return result
	End Function
#End Region
End Class
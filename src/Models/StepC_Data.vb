''' <summary>
''' Contains data and validity checks for StepC. 
''' </summary>
''' <remarks>This is the Model for StepC (Controller).</remarks>
Public Class StepC_Data
#Region "Properties"
	Private _promoOccursDate As System.Nullable(Of Date)
	Private _promoStartDate As System.Nullable(Of Date)
	Private _promoEndDate As System.Nullable(Of Date)
	Private _promoRecursOnWeekday As String
	Private _promoEarnsOnWeekday As String
	Private _promoCountCurrentDay As Boolean

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

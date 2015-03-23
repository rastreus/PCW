''' <summary>
''' Contains data and validity checks for StepD.
''' </summary>
''' <remarks>This is the Model for StepD (Controller).</remarks>
Public Class StepD_Data
#Region "Properties"
	Private _promoCategory As PromoCategory
	Private _promoMutiPartDaysTiers As String = Nothing
	Private _promoPointCutoffLimit As Integer
	Private _promoPathToFile As String
	Private _promoSkipEntry As Boolean
	Private _promoSkipPayout As Boolean

	Public Enum PromoCategory
		entryAndPayout
		entryOnly
		payoutOnly
		multPart
		acquisition
	End Enum

	Public Property Category As PromoCategory
		Get
			Return _promoCategory
		End Get
		Set(value As PromoCategory)
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
	Public Property PointCutoffLimit As Integer
		Get
			Return _promoPointCutoffLimit
		End Get
		Set(value As Integer)
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
	Public Sub CheckForReset()
		If (Me.Category = PromoCategory.entryAndPayout) Or
			(Me.Category = PromoCategory.multPart) Then
			PCW.Data.Reset = True
			PCW.Data.ResetTo = "StepD"
		End If
	End Sub
#End Region
End Class

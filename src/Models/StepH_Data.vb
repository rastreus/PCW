''' <summary>
''' Contains data and validity checks for StepH.
''' </summary>
''' <remarks>This is the Model for StepH (Controller).</remarks>
Public Class StepH_Data
	Implements IPromoData
#Region "PrepareData"
	Public Sub PrepareData(ByRef promoDataHash As Hashtable) _
		Implements IPromoData.PrepareData
		promoDataHash.Add("Comment", Comment)
	End Sub
#End Region
#Region "Properties"
	Private _promoComment As String

	Public Property Comment As String
		Get
			Return _promoComment
		End Get
		Set(value As String)
			_promoComment = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function CommentIsBlank() As Boolean
		Return (Comment = "")
	End Function
#End Region
End Class

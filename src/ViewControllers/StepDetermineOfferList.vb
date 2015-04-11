Imports TSWizards

Public Class StepDetermineOfferList
	Inherits TSWizards.BaseInteriorStep

#Region "StepStepDetermineOfferList_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.stepDetermineOfferList_data = New StepDetermineOfferList_Data
	End Sub
#End Region
#Region "StepStepDetermineOfferList_Data"
	''' <summary>
	''' Model for StepStepDetermineOfferList.
	''' </summary>
	''' <remarks>As a loose representation of MVC, this is the Model.</remarks>
	Private stepDetermineOfferList_data As StepDetermineOfferList_Data
	Public ReadOnly Property Data() As StepDetermineOfferList_Data
		Get
			Return Me.stepDetermineOfferList_data
		End Get
	End Property
#End Region
End Class

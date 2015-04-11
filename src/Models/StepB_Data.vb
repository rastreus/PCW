﻿''' <summary>
''' Contains data and validity checks for StepB. 
''' </summary>
''' <remarks>This is the Model for StepB (Controller).</remarks>
Public Class StepB_Data
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
			promoDataHash.Item("ID") = ID
			promoDataHash.Item("Name") = Name
			promoDataHash.Item("Recurring") = Recurring
			promoDataHash.Item("RecurringFrequency") = RecurringFrequency
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add("ID", ID)
			promoDataHash.Add("Name", Name)
			promoDataHash.Add("Recurring", Recurring)
			promoDataHash.Add("RecurringFrequency", RecurringFrequency)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
	Private _promoType As String
	Private _promoID As String
	Private _promoName As String
	Private _promoRecurring As System.Nullable(Of Boolean)
	Private _promoRecurringFrequency As System.Nullable(Of Char)
	'ASIDE: It's possible that the below Property definitions are implicitly declared.
	'That is probably both good and true; however, I enjoy explicit definitions.
	'That is why the boilerplate below currently exists and will exist in all Models.
	'Let this be a lesson in programming style: Choose to be explicit over implicit.
	Private Property DataAddedToHash As Boolean _
		Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
	Public Property StepNotSet As Boolean
		Get
			Return _stepNotSet
		End Get
		Set(value As Boolean)
			_stepNotSet = value
		End Set
	End Property
	Public Property PromoType As String
		Get
			Return _promoType
		End Get
		Set(value As String)
			_promoType = value
		End Set
	End Property
	Public Property ID As String
		Get
			Return _promoID
		End Get
		Set(value As String)
			_promoID = value
		End Set
	End Property
	Public Property Name As String
		Get
			Return _promoName
		End Get
		Set(ByVal value As String)
			_promoName = value
		End Set
	End Property
	Public Property Recurring As Boolean
		Get
			Return _promoRecurring
		End Get
		Set(ByVal value As Boolean)
			_promoRecurring = value
		End Set
	End Property
	Public Property RecurringFrequency As String
		Get
			Return _promoRecurringFrequency
		End Get
		Set(ByVal value As String)
			_promoRecurringFrequency = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function Recurring_Period_Invalid() As Boolean
		Dim invalid As Boolean = False

		If Me.Recurring And Me.RecurringFrequency = "" Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function PromoType_Invalid() As Boolean
		Dim invalid As Boolean = False

		If PromoType = "EX: 31B" Or PromoType = "" Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function PromoID_Invalid() As Boolean
		Dim invalid As Boolean = False

		If ID = "EXAMPLE1503" Or ID = "" Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function PromoName_Invalid() As Boolean
		Dim invalid As Boolean = False

		If (Me.Name = "") Or _
			(Me.Name.Length > 50) Or _
			(SQL_Util.Existing_Promo(Me.Name)) Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function PromoName_Invalid_GetErrString() As String
		'Assign a value to a declared variable to avoid NULL errors.
		Dim errString As String = New String("ASSIGNED A VALUE")

		If Me.Name = "" Then
			errString = "Promo must have a name."
		ElseIf Me.Name.Length > 50 Then
			errString = "Promo name cannot be more than 50 characters."
		ElseIf SQL_Util.Existing_Promo(Me.Name) Then
			errString = "There is an existing promo with this name."
		Else
			errString = "ERROR IN: PromoName_Invalid_GetErrString"
		End If

		Return errString
	End Function
#End Region
End Class

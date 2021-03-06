﻿#Region "COPYING"
'PromotionalCreationWizard
'Copyright (C) 2014-2016 Russell Dillin
'
'This file is part of PromotionalCreationWizard.

'   PromotionalCreationWizard is free software: you can redistribute it and/or
'   modify it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   PromotionalCreationWizard is distributed in the hope that it will be
'	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with PromotionalCreationWizard.
'	If not, see <http://www.gnu.org/licenses/>.
#End Region

Imports Key = PromotionalCreationWizard _
			  .PCW_Data _
			  .PromoFields

''' <summary>
''' Contains data and validity checks for StepB. 
''' </summary>
''' <remarks>This is the Model for StepB (Controller).</remarks>
Public Class StepB_Data
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
			promoDataHash.Item(Key.ID) = ID
			promoDataHash.Item(Key.Name) = Name
			promoDataHash.Item(Key.Recurring) = Recurring
			promoDataHash.Item(Key.RecurringFrequency) = RecurringFrequency
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.ID, ID)
			promoDataHash.Add(Key.Name, Name)
			promoDataHash.Add(Key.Recurring, Recurring)
			promoDataHash.Add(Key.RecurringFrequency, RecurringFrequency)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
	Private _promoID As String
	Private _promoName As String
	Private _promoRecurring As System.Nullable(Of Boolean)
	Private _promoRecurringFrequency As System.Nullable(Of Char)
	'ASIDE: It's possible that the below Property definitions are
	'implicitly declared. That is probably both good and true; however,
	'I enjoy explicit definitions. That is why the boilerplate below
	'currently exists and will exist in all Models. Let this be a lesson
	'in programming style: Choose to be explicit over implicit.
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
	Public Property RecurringFrequency As System.Nullable(Of Char)
		Get
			Return _promoRecurringFrequency
		End Get
		Set(ByVal value As System.Nullable(Of Char))
			_promoRecurringFrequency = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function Recurring_Period_Invalid() As Boolean
		Dim invalid As Boolean = False

		If Me.Recurring AndAlso _
			Me.RecurringFrequency = String.Empty Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function PromoID_Invalid(ByVal id As String) As Boolean
		Dim invalid As Boolean = False

		If (id = "TEST!1503") OrElse _
			(id = String.Empty) OrElse _
			(id.Length > 9) OrElse _
			(SQL_Util.Existing_PromoID(id)) Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function Get_PromoID_errString(ByVal id As String) As String
		Dim errString As String = New String(String.Empty)
		If (id = "TEST!1503") OrElse _
			(id = String.Empty) Then
			errString = "ID not set"
		ElseIf (SQL_Util.Existing_PromoID(id)) Then
			errString = "ID already exists."
		End If
		Return errString
	End Function
	Public Function PromoName_Invalid(ByVal name As String) As Boolean
		Dim invalid As Boolean = False

		If (name = String.Empty) OrElse _
			(name.Length > 37) OrElse _
			(SQL_Util.Existing_Promo(name)) Then
			invalid = True
		End If

		Return invalid
	End Function
	Public Function Get_PromoName_errString(ByVal name As String) As String
		Dim errString As String = New String(String.Empty)

		If name = String.Empty Then
			errString = "Name not set"
		ElseIf name.Length > 37 Then
			errString = "Cannot be more than 37 chars"
		ElseIf SQL_Util.Existing_Promo(name) Then
			errString = "Name already exists"
		Else
			errString = "ERROR IN: Get_PromoName_errString"
		End If

		Return errString
	End Function
#End Region
End Class

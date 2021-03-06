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
''' Contains data and validity checks for StepC. 
''' </summary>
''' <remarks>This is the Model for StepC (Controller).</remarks>
Public Class StepC_Data
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
			promoDataHash.Item(Key.OccursDate) = OccursDate
			promoDataHash.Item(Key.StartDate) = StartDate
			promoDataHash.Item(Key.EndDate) = EndDate
			promoDataHash.Item(Key.RecursOnWeekday) = RecursOnWeekday
			promoDataHash.Item(Key.EarnsOnWeekday) = EarnsOnWeekday
			promoDataHash.Item(Key.CountCurrentDay) = CountCurrentDay
		Else 'Othewise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.OccursDate, OccursDate)
			promoDataHash.Add(Key.StartDate, StartDate)
			promoDataHash.Add(Key.EndDate, EndDate)
			promoDataHash.Add(Key.RecursOnWeekday, RecursOnWeekday)
			promoDataHash.Add(Key.EarnsOnWeekday, EarnsOnWeekday)
			promoDataHash.Add(Key.CountCurrentDay, CountCurrentDay)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _stepNotSet As Boolean = True
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
	Public Property StepNotSet As Boolean
		Get
			Return _stepNotSet
		End Get
		Set(value As Boolean)
			_stepNotSet = value
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
	Public Function QualifyingPeriod_NotEstablished(ByRef startDayBool _
													As Boolean, _
													ByRef endDayBool _
													As Boolean) _
													As Boolean
		Dim invalid As Boolean = False
		If (startDayBool = False) OrElse (endDayBool = False) Then
			invalid = True
		End If
		Return invalid
	End Function

	Public Function PrimaryDay_NotEstablished(ByRef primaryDayBool _
											  As Boolean) _
											  As Boolean
		Dim invalid As Boolean = False
		If primaryDayBool = False Then
			invalid = True
		End If
		Return invalid
	End Function

	Public Function OccursDate_NotEstablished(ByRef occursDateBool _
											  As Boolean) _
											  As Boolean
		Dim invalid As Boolean = False
		If occursDateBool = False Then
			invalid = True
		End If
		Return invalid
	End Function
	Public Function EndDate_Before_StartDate(ByVal endDate As DateTime, _
											 ByVal startDate As DateTime) _
											 As Boolean
		Dim result As Boolean = False
		Dim compare As Integer = Date.Compare(endDate, startDate)
		If compare < 0 Then
			result = True 'Yes, EndDate is earlier than StartDate.
		End If
		Return result
	End Function
#End Region
End Class

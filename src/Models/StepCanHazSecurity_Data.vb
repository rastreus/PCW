#Region "COPYING"
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

Public Class StepCanHazSecurity_Data
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
	Private _pcwOverrideTime_errString As String
	Private _pcwCutoffTime_errString As String

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
	Public Property OverrideTime_errString As String
		Get
			Return _pcwOverrideTime_errString
		End Get
		Set(value As String)
			_pcwOverrideTime_errString = value
		End Set
	End Property
	Public Property CutoffTime_errString As String
		Get
			Return _pcwCutoffTime_errString
		End Get
		Set(value As String)
			_pcwCutoffTime_errString = value
		End Set
	End Property
#End Region
#Region "Validity Checks"
	Public Function OverrideTime_Invalid() As Boolean
		Return Time_Is_Invalid(OverrideTime, _
							   OverrideTime_errString)
	End Function

	Public Function CutoffTime_Invalid() As Boolean
		Return Time_Is_Invalid(CutoffTime, _
							   CutoffTime_errString)
	End Function

	Public Function Time_Is_Invalid(ByVal timeStr As String, _
									ByRef errString As String) _
									As Boolean
		Dim result As Boolean = False
		If Not_Five_Chars(timeStr) Then
			result = True
			errString = "Not proper format"
		ElseIf Time_Not_Set(timeStr) Then
			result = True
			errString = "Time not set"
		ElseIf Hours_Are_Invalid(timeStr) Then
			result = True
			errString = "Hours are invalid (< 1 Or > 12)"
		ElseIf Minutes_Are_Invalid(timeStr) Then
			result = True
			errString = "Minutes are invalid (> 59)"
		End If
		Return result
	End Function

	Private Function Not_Five_Chars(ByVal timeStr As String) _
									As Boolean
		Dim result As Boolean = If(timeStr.Length < 5, _
								   True, _
								   False)
		Return result
	End Function

	Private Function Time_Not_Set(ByVal timeStr As String) _
								  As Boolean
		Dim result As Boolean = If((timeStr = "A" OrElse _
									timeStr = "P"), _
								   True, _
								   False)
		Return result
	End Function

	Private Function Hours_Are_Invalid(ByVal timeStr As String) _
									   As Boolean
		Dim result As Boolean = False
		Dim hoursStr As String = New String(String.Empty)
		Dim hours As Short = 0
		Try
			hoursStr = timeStr.Substring(0, 2)
			hours = Short.Parse(hoursStr)
		Catch ex As Exception
			'Handle Exception
		End Try
		If hours < 1 OrElse _
			hours > 12 Then
			result = True
		End If
		Return result
	End Function

	Private Function Minutes_Are_Invalid(ByVal timeStr As String) _
										 As Boolean
		Dim result As Boolean = False
		Dim minutesStr As String = New String(String.Empty)
		Dim minutes As Short = 0
		Try
			minutesStr = timeStr.Substring(2, 2)
			minutes = Short.Parse(minutesStr)
		Catch ex As Exception
			'Handle Exception
		End Try
		If minutes < 0 OrElse _
			minutes > 59 Then
			result = True
		End If
		Return result
	End Function
#End Region
End Class

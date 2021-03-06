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
''' Contains data and validity checks for StepH.
''' </summary>
''' <remarks>This is the Model for StepH (Controller).</remarks>
Public Class StepH_Data
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
			promoDataHash.Item(Key.Comment) = Comment
		Else 'Otherwise, Add the key-value pair to the Hashtable
			'And tell DataAddedToHash that it has now been Added.
			promoDataHash.Add(Key.Comment, Comment)
			DataAddedToHash = True
		End If
	End Sub
#End Region
#Region "Properties"
	Private _dataAddedToHash As Boolean = False
	Private _promoComment As String

	Private Property DataAddedToHash As Boolean _
	Implements IPromoData.DataAddedToHash
		Get
			Return _dataAddedToHash
		End Get
		Set(value As Boolean)
			_dataAddedToHash = value
		End Set
	End Property
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
		Dim result As Boolean = False
		If (Comment = String.Empty) Then
			result = True
		End If
		Return result
	End Function
	Public Function CommentIsTooLong() As Boolean
		Dim result As Boolean = False
		If (Comment.Length > 200) Then 'Room for appended content
			result = True
		End If
		Return result
	End Function
#End Region
End Class

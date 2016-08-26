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

Public Class SelectorButton
	Inherits Button

	Private SAFE_COLOR As Color = Color.LightCyan
	Private SLCT_COLOR As Color = Color.Cyan
	Private _BOOL As Boolean = False

	Public Sub New()
		Me.AutoSize = True
		Me.Enabled = True
		Me.Visible = True
		Me.BackColor = SAFE_COLOR
		Me.Location = New Point(0, 0)
		Me.ForeColor = Color.Black
		Me.Text = String.Empty
	End Sub

	Public Sub Disable()
		Me.BackColor = SAFE_COLOR
	End Sub

	Protected Overrides Sub OnBackColorChanged(e As EventArgs)
		If _BOOL = True AndAlso _
			Me.BackColor = SLCT_COLOR Then
			For Each btn As SelectorButton In Parent.Controls
				If btn.BackColor = SAFE_COLOR Then
					btn.Enabled = False
				End If
			Next
		ElseIf _BOOL = True AndAlso _
			Me.BackColor = SAFE_COLOR Then
			For Each btn As SelectorButton In Parent.Controls
				btn.Enabled = True
			Next
		End If
	End Sub

	Protected Overrides Sub OnClick(e As EventArgs)
		If _BOOL = False Then
			_BOOL = True
		End If
		If Me.BackColor = SAFE_COLOR Then
			Me.BackColor = SLCT_COLOR
		Else
			Me.BackColor = SAFE_COLOR
		End If
		MyBase.OnClick(e)
	End Sub
End Class

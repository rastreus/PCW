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

'GPTS is an acronym for "Guided PromoType Selector"
'Instead of only having an open-ended textbox for PromoType entry,
'this will "guide" the user towards the correct choice through the
'use of RadioButtons and names for what each PromoType is commonly
'used for.
Public Class GPTS
#Region "Properties"
	Private _promoType As String

	Public Property PromoType As String
		Get
			Return _promoType
		End Get
		Set(value As String)
			_promoType = value
		End Set
	End Property
#End Region

	Private Sub Me_VisibleChanged() _
		Handles Me.VisibleChanged
		If Me.Visible = True AndAlso _
			Me.btnSet.Enabled = True Then
			Me.btnSet.Enabled = False
			Me.btnSet.Visible = False
			Me.btnSet.Text = String.Empty
		End If
		If Me.Visible = True AndAlso _
			rbCurrentlyChecked() Then
			For Each rb As RadioButton In pnlMain.Controls
				If rb.Checked = True Then
					rb.Checked = False
				End If
			Next
		End If
	End Sub

	Private Function rbCurrentlyChecked() As Boolean
		Dim result As Boolean = False
		For Each rb As RadioButton In pnlMain.Controls
			If rb.Checked = True Then
				result = True
			End If
		Next
		Return result
	End Function

	Private Sub rbChecked() _
		Handles rb20.CheckedChanged, _
				rb22.CheckedChanged, _
				rb24.CheckedChanged, _
				rb25.CheckedChanged, _
				rb26.CheckedChanged, _
				rb30.CheckedChanged, _
				rbOther.CheckedChanged
		If Me.btnSet.Enabled = False Then
			Dim checked As Boolean = False
			For Each rb As RadioButton In pnlMain.Controls
				If rb.Checked = True Then
					checked = True
				End If
			Next
			If checked = True Then
				Me.btnSet.Text = "Set PromoType"
				Me.btnSet.BackColor = Color.MediumSlateBlue
				Me.btnSet.Enabled = True
			End If
		End If
	End Sub

	Private Function DeterminePromoType() As String
		Dim result As String = String.Empty
		If Me.rb20.Checked Then
			result = "20"
		ElseIf Me.rb22.Checked Then
			result = "22"
		ElseIf Me.rb24.Checked Then
			result = "24"
		ElseIf Me.rb25.Checked Then
			result = "25"
		ElseIf Me.rb26.Checked Then
			result = "26"
		ElseIf Me.rb30.Checked Then
			result = "30"
		Else
			result = Me.txtOther.Text.Trim
		End If
		Return result
	End Function

	Private Sub rbOther_CheckedChanged(sender As Object, _
									   e As EventArgs) _
		Handles rbOther.CheckedChanged
		If Me.rbOther.Checked = True Then
			Me.txtOther.Enabled = True
			Me.txtOther.Visible = True
		Else
			Me.txtOther.Enabled = False
			Me.txtOther.Visible = False
		End If
	End Sub

	Private Sub btnSet_Click(sender As Object, _
							 e As EventArgs) _
		Handles btnSet.Click
		Me.btnSet.Enabled = False
		PromoType = DeterminePromoType()
		If Me.Enabled Then
			Me.Enabled = False
			Me.Visible = False
			Me.SendToBack()
		End If
	End Sub
End Class

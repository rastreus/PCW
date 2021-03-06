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

Imports TSWizards
Imports System.ComponentModel

''' <summary>
''' The "Comment" Step; naturally, handles the comment.
''' </summary>
''' <remarks>This Class has a single purpose.</remarks>
Public Class StepH
	Inherits TSWizards.BaseInteriorStep
	Implements IWizardStep

#Region "StepH_New"
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		stepH_data = New StepH_Data
		Me.Data.ToPromoStepList(Me, PCW.Data.PromoStepList)
	End Sub
#End Region
#Region "StepH_Data"
	Private ReadOnly Property PromoData As IPromoData _
		Implements IWizardStep.PromoData
		Get
			Return Me.stepH_data
		End Get
	End Property

	''' <summary>
	''' Model for StepH.
	''' </summary>
	''' <remarks>As a loose representation of
	''' MVC, this is the Model.</remarks>
	Private stepH_data As StepH_Data
	Public ReadOnly Property Data() As StepH_Data
		Get
			Return Me.stepH_data
		End Get
	End Property
#End Region
#Region "StepH_SetData"
	Private Sub StepH_SetData()
		Dim commentStr As String = New String(String.Empty)
		If Me.rbNO.Checked Then
			commentStr = "N/A"
		Else
			commentStr = Me.txtCommentBox.Text
		End If
		Me.stepH_data.Comment = commentStr
	End Sub
#End Region
#Region "StepH_ResetStep"
	Private Sub StepH_ResetStep(sender As Object, _
								e As EventArgs) _
		Handles MyBase.ResetStep
		stepH_data = New StepH_Data
		StepH_ResetControls()
	End Sub

	Private Sub StepH_ResetControls()
		Me.rbNO.Checked = True
		Me.txtCommentBox.Enabled = False
		Me.pnlCommentBox.Enabled = False
		Me.txtCommentBox.Text = "Insert Comment of 140 characters " & _
								"or less into this TextBox."
		Me.lblNumerator.Text = "140"
		Me.lblDenominator.Text = "/  140"
		Me.IconTick.IconType = FontAwesomeIcons.IconType.Tick
		Me.IconTick.ActiveColor = SystemColors.ControlDark
		Me.IconTick.InActiveColor = SystemColors.ControlDark
		If Me.pnlCommentBox.BackColor = Color.MistyRose Then
			Me.pnlCommentBox.BackColor = SystemColors.Control
		End If
		If Me.lblNumerator.ForeColor = Color.Firebrick Then
			Me.lblNumerator.ForeColor = Color.White
		End If
		If Me.pnl140Characters.BackColor = Color.MistyRose Then
			Me.pnl140Characters.BackColor = SystemColors.ControlDarkDark
		End If
	End Sub
#End Region
#Region "StepH_Validation"
	''' <summary>
	''' Asks StepH_Data to validate data and then
	''' handles GUI reactions accordingly.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Validation event is triggered when
	''' user presses the "Next> Button."</remarks>
	Private Sub StepH_Validation(sender As Object, _
								 e As CancelEventArgs) _
		Handles Me.ValidateStep
		Dim cancelContinuingToNextStep As Boolean = False
		Dim errString As String = New String(String.Empty)

		StepH_SetData()

		If Me.rbYES.Checked Then
			If Me.Data.CommentIsBlank Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlCommentBox)
				errString = "BLANK: Insert a Comment."
			Else
				GUI_Util.regPnl(Me.pnlCommentBox)
			End If

			If Me.Data.CommentIsTooLong Then
				cancelContinuingToNextStep = True
				GUI_Util.errPnl(Me.pnlCommentBox)
				errString = "ERROR: Comment is too long."
			Else
				GUI_Util.regPnl(Me.pnlCommentBox)
			End If
		End If

		e.Cancel = cancelContinuingToNextStep
		If cancelContinuingToNextStep Then
			GUI_Util.msgBox(errString)
		End If
	End Sub
#End Region
#Region "StepH_rbNo_CheckedChanged"
	Private Sub rbNo_CheckedChanged(sender As Object, _
									e As EventArgs) _
		Handles rbNO.CheckedChanged
		If Me.rbYES.Checked Then
			Me.IconTick.ActiveColor = Color.Lime
			Me.IconTick.InActiveColor = Color.Lime
			Me.pnlCommentBox.Enabled = True
			Me.txtCommentBox.Enabled = True
			Me.txtCommentBox.Text = String.Empty
			Me.ActiveControl = Me.txtCommentBox
		Else
			StepH_ResetControls()
		End If
	End Sub
#End Region
#Region "StepH_txtCommentBox_TextChanged"
	Private Sub txtCommentBox_TextChanged(sender As Object, _
										  e As EventArgs) _
		Handles txtCommentBox.TextChanged
		If Me.txtCommentBox.Enabled Then
			If (140 - Me.txtCommentBox.Text.Length) < 0 Then
				PCW.NextEnabled = False
				Me.IconTick.IconType = FontAwesomeIcons.IconType.Cross
				Me.IconTick.ActiveColor = Color.Firebrick
				Me.IconTick.InActiveColor = Color.Firebrick
				Me.lblNumerator.ForeColor = Color.Firebrick
				Me.pnl140Characters.BackColor = Color.MistyRose
			Else
				Me.IconTick.IconType = FontAwesomeIcons.IconType.Tick
				Me.IconTick.ActiveColor = Color.Lime
				Me.IconTick.InActiveColor = Color.Lime
				Me.lblNumerator.ForeColor = Color.White
				Me.pnl140Characters.BackColor = SystemColors.ControlDarkDark
				GUI_Util.NextEnabled()
			End If
			Me.lblNumerator.Text = _
				(140 - Me.txtCommentBox.Text.Length).ToString
		End If
	End Sub
#End Region
End Class

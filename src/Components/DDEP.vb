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

Imports PromotionalCreationWizard.SelectorButton

'DDEP is an acronym for "Drag-and-Drop Eligible Players"
Public Class DDEP
#Region "Properties"
	Private _playerIDIndex As Integer = -1
	Private _numOfTicketsIndex As Integer = -1
	Private _areIndexSet As Boolean = False

	Public Property PlayerIDIndex As Integer
		Get
			Return _playerIDIndex
		End Get
		Set(value As Integer)
			_playerIDIndex = value
		End Set
	End Property

	Public Property NumOfTicketsIndex As Integer
		Get
			Return _numOfTicketsIndex
		End Get
		Set(value As Integer)
			_numOfTicketsIndex = value
		End Set
	End Property
#End Region
#Region "DragDrop"
	Private Delegate Sub DelegateChangeLabel(ByVal s As String)
	Private m_DelegateChangeLabel As DelegateChangeLabel

	Private Delegate Sub DelegateCSVtoComboBox(ByVal s As String)
	Private m_DelegateCSVtoComboBox As DelegateCSVtoComboBox

	Private Sub DDEP_Load(sender As Object, _
						  e As EventArgs) _
		Handles Me.Load
		m_DelegateChangeLabel = _
			New DelegateChangeLabel(AddressOf Me.ChangeLabel)
		m_DelegateCSVtoComboBox = _
			New DelegateCSVtoComboBox(AddressOf Me.CSVtoComboBox)
	End Sub

	Private Sub pnlDrag_DragEnter(sender As Object, _
								  e As DragEventArgs) _
		Handles pnlDragDropCSV.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub pnlDrag_DragDrop(sender As Object, _
								 e As DragEventArgs) _
		Handles pnlDragDropCSV.DragDrop
		Try
			Dim a As Array = _
				CType(e.Data.GetData(DataFormats.FileDrop), Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateChangeLabel, New Object() {s})
				Me.BeginInvoke(m_DelegateCSVtoComboBox, New Object() {s})
				Success()
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in DragDrop: " & ex.Message)
			Me.lblDrag.Text = "Error in DragDrop: " & ex.Message
			Me.pnlDragDropCSV.BackColor = Color.Red
		End Try
	End Sub

	Private Sub ChangeLabel(ByVal s As String)
		Me.lblFilePath.Text = s
	End Sub
#End Region
#Region "CSVtoComboBox"
	Private Sub CSVtoComboBox(ByVal filePath As String)
		Dim parser As New FileIO.TextFieldParser(filePath)
		parser.Delimiters = New String() {","}
		parser.HasFieldsEnclosedInQuotes = False
		parser.TrimWhiteSpace = True

		For Each header As String In parser.ReadFields()
			Me.cbPlayerID.Items.Add(header)
			Me.cbNumOfTickets.Items.Add(header)
		Next
	End Sub
#End Region
#Region "UI/UX"
	Private Sub toggleComboBox(ByRef cb As ComboBox)
		If cb.Enabled = False Then
			cb.Enabled = True
			cb.DroppedDown = True
		Else
			cb.Enabled = False
			cb.DroppedDown = False
		End If
	End Sub

	Private Sub enableSpB(ByRef sb As SelectorButton, _
						  ByVal txt As String)
		sb.Enabled = True
		sb.BackColor = Color.LightCyan
		sb.Text = txt
	End Sub

	Private Sub disableSpB(ByRef spb As SelectorButton)
		spb.Disable()
	End Sub

	Private Sub sbPlayerID_Click(sender As Object, _
								 e As EventArgs) _
		Handles sbPlayerID.Click
		toggleComboBox(Me.cbPlayerID)
	End Sub

	Private Sub sbNumOfTickets_Click(sender As Object, _
									 e As EventArgs) _
		Handles sbNumOfTickets.Click
		toggleComboBox(Me.cbNumOfTickets)
	End Sub

	Private Sub cbPlayerID_DropDownClosed(sender As Object, _
										  e As EventArgs) _
		Handles cbPlayerID.DropDownClosed
		disableSpB(Me.sbPlayerID)
		toggleComboBox(Me.cbPlayerID)
		Me.PlayerIDIndex = Me.cbPlayerID.SelectedIndex
		checkToEnableSet()
		Me.ActiveControl = Me.pnlDragDropCSV
	End Sub

	Private Sub cbNumOfTickets_DropDownClosed(sender As Object, _
											  e As EventArgs) _
		Handles cbNumOfTickets.DropDownClosed
		disableSpB(Me.sbNumOfTickets)
		toggleComboBox(Me.cbNumOfTickets)
		Me.NumOfTicketsIndex = Me.cbNumOfTickets.SelectedIndex
		checkToEnableSet()
		Me.ActiveControl = Me.pnlDragDropCSV
	End Sub

	Private Sub checkToEnableSet()
		If Me.NumOfTicketsIndex >= 0 AndAlso _
			Me.PlayerIDIndex >= 0 Then
			Me.btnSet.BackColor = Color.MediumPurple
			Me.btnSet.Text = "Set"
			Me.btnSet.Enabled = True
		End If
	End Sub

	Private Sub enableLabel(ByRef lbl As Label)
		lbl.Enabled = True
		lbl.Visible = True
	End Sub

	Public Function indexAreSet() As Boolean
		Return Me._areIndexSet
	End Function

	Private Sub btnSet_Click(sender As Object, _
							 e As EventArgs) _
		Handles btnSet.Click
		Me._areIndexSet = True
		Me.Enabled = False
		Me.Visible = False
		Me.SendToBack()
		GUI_Util.NextEnabled()
	End Sub
#End Region
#Region "File Finder"
	Private Sub Success()
		Me.lblDrag.Text = "Success!"
		Me.pnlDragDropCSV.BackColor = Color.PaleGreen
		enableSpB(Me.sbPlayerID, "PlayerID")
		enableSpB(Me.sbNumOfTickets, "NumOfTickets")
	End Sub
	Private Sub SetPathText(ByVal s As String)
		Me.lblFilePath.Text = s
	End Sub
	Private Sub btnFileFinder_Click(sender As Object, _
									e As EventArgs) _
		Handles btnFileFinder.Click
		Dim fileDialog As New OpenFileDialog()
		fileDialog.InitialDirectory = "C:\"
		fileDialog.Filter = "CSV Files(*.csv)|*.csv" & _
							"|All Files(*.*)|*.*"
		fileDialog.FilterIndex = 1
		fileDialog.RestoreDirectory = True
		'seperates message outputs for files found or not found
		If fileDialog.ShowDialog() = DialogResult.OK Then
			If Dir(fileDialog.FileName) <> String.Empty Then
				SetPathText(fileDialog.FileName)
				Success()
			End If
		End If
	End Sub
#End Region
End Class

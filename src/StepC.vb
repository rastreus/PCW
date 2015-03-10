Imports TSWizards

Public Class StepC
	Inherits TSWizards.BaseInteriorStep

	Private Sub StepC_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
		'If it is not recurring, then we need to get the occuring promo date.
		'Otherwise, the promo date will be entered as NULL.
		If Not Recurring_Promo() Then
			'Bottom Panel becomes visible
			Me.Panel7.Visible = True
			Me.Label6.Visible = True
			Me.DateTimePicker3.Enabled = True
			'Middle Panel not needed
			Me.Panel1.Visible = False
		Else
			'Middile Panel becomes visible
			Me.Panel1.Visible = True
			'Bottom Panel not needed
			Me.DateTimePicker3.Enabled = False
			Me.Label6.Visible = False
			Me.Panel7.Visible = False
		End If

		All_Or_Nothing_Checked()

	End Sub

	Private Sub StepC_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
		'Checks if the user pressed Next> before setting any values
		If Nothing_Was_Set() Then
			e.Cancel = True
			Me.Panel1.BackColor = Color.MistyRose
			Me.Panel2.BackColor = Color.MistyRose
			Me.Panel3.BackColor = Color.MistyRose
			Me.Panel4.BackColor = Color.MistyRose
			CenteredMessagebox.MsgBox.Show("Please set the date values", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			Me.Panel1.BackColor = SystemColors.Control
			Me.Panel2.BackColor = SystemColors.Control
			Me.Panel3.BackColor = SystemColors.Control
			Me.Panel4.BackColor = SystemColors.Control
		End If

		'Only the Occuring on Days values forgot to be set
		If Recurring_Promo() Then
			If (Not Nothing_Was_Set() And Empty_Occuring_Days()) Then
				e.Cancel = True
				CenteredMessagebox.MsgBox.Show("Please set the occuring day values.", "Error",
											   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.Panel1.BackColor = Color.MistyRose
			Else
				Me.Panel1.BackColor = SystemColors.Control
			End If
		End If

		'Checks to see if the primary day is invalid
		If Recurring_Promo() Then
			If Primary_Day_Invalid() Then
				e.Cancel = True
				Me.Panel1.BackColor = Color.MistyRose
				CenteredMessagebox.MsgBox.Show("Primary Day is invalid.", "Error",
											   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Else
				Me.Panel1.BackColor = SystemColors.Control
			End If
		End If

		'Only the Points Earned On valuse forgot to be set
		If Not Nothing_Was_Set() And Empty_Points_Earned() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the points earned on values.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel2.BackColor = Color.MistyRose
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If

		If Not Nothing_Was_Set() And Promo_Start_Not_Set() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the promo start date.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel3.BackColor = Color.MistyRose
		Else
			Me.Panel3.BackColor = SystemColors.Control
		End If

		If Not Nothing_Was_Set() And Promo_End_Not_Set() Then
			e.Cancel = True
			CenteredMessagebox.MsgBox.Show("Please set the promo end date.", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Me.Panel4.BackColor = Color.MistyRose
		Else
			Me.Panel4.BackColor = SystemColors.Control
		End If

		'Checks if LastDay is before FirstDay
		If EndDate_Before_BeginDate() Then
			e.Cancel = True
			Me.Panel3.BackColor = Color.MistyRose
			Me.DateTimePicker1.Value = DateTime.Today
			Me.Panel4.BackColor = Color.MistyRose
			Me.DateTimePicker2.Value = DateTime.Today
		Else
			If Not Promo_Start_Not_Set() And Not Promo_End_Not_Set() Then
				Me.Panel3.BackColor = SystemColors.Control
				Me.Panel4.BackColor = SystemColors.Control
			End If
		End If

		If OccursDate_Before_EndDate() Then
			e.Cancel = True
			Me.Panel7.BackColor = Color.MistyRose
			Me.DateTimePicker3.Value = DateTime.Today
			Me.Panel4.BackColor = Color.MistyRose
			Me.DateTimePicker2.Value = DateTime.Today
		Else
			If Not Promo_Start_Not_Set() And Not Promo_End_Not_Set() Then
				Me.Panel7.BackColor = SystemColors.Control
				Me.Panel4.BackColor = SystemColors.Control
			End If
		End If

		'Checks to see if attempting to earn points on the day of the promo when NO is selected
		'If this occurs, we're going to show a dialog to ask directly what the user intended to do
		'and then we will act accordingly from their direct response.
		If No_Selected_For_SameDay_Points() And SameDays_Are_Selected() Then
			e.Cancel = AskForSameDay()
			If e.Cancel = True Then
				Me.Panel1.BackColor = Color.MistyRose
				Me.Panel2.BackColor = Color.MistyRose
				Clear_Checklistboxes()
			Else
				Me.RadioButton2.Checked = False
				Me.RadioButton1.Checked = True
				If Not Empty_Occuring_Days() And Not Empty_Points_Earned() Then
					Me.Panel1.BackColor = SystemColors.Control
					Me.Panel2.BackColor = SystemColors.Control
				End If
			End If
		End If
	End Sub

	'Check all the "Earned on Days"
	Private Sub All_Or_Nothing_Checked()
		For i As Integer = 0 To Me.CheckedListBox2.Items.Count - 1
			Me.CheckedListBox2.SetItemChecked(i, Me.CheckBox1.Checked)
		Next
	End Sub

	Private Function Nothing_Was_Set()
		Dim invalid As Boolean = False

		If Promo_Start_Not_Set() And Promo_End_Not_Set() And Empty_Occuring_Days() And Empty_Points_Earned() Then
			invalid = True
		End If

		Return invalid
	End Function

	Private Function Promo_Start_Not_Set()
		Dim invalid As Boolean = False
		If Me.DateTimePicker1.Value.Date = DateTime.Today Then
			invalid = True
		End If
		Return invalid
	End Function

	Private Function Promo_End_Not_Set()
		Dim invalid As Boolean = False
		If Me.DateTimePicker2.Value.Date = DateTime.Today Then
			invalid = True
		End If
		Return invalid
	End Function

	Private Function Promo_Occuring_Not_Set()
		Dim invalid As Boolean = False
		If Not Recurring_Promo() And (Me.DateTimePicker3.Value.Date = DateTime.Today) Then
			invalid = True
		End If
		Return invalid
	End Function

	Private Function Primary_Day_Invalid()
		Dim invalid As Boolean = True
		Dim count As Short = 0

		For Each itemChecked As Object In CheckedListBox1.CheckedItems
			If itemChecked.ToString = Me.ComboBox1.Text Then
				count += 1
			End If
		Next

		If count = 1 Then
			invalid = False
		End If

		Return invalid
	End Function

	'Checks the previous Step to see if this is a recurring promo.
	Private Function Recurring_Promo()
		Dim recurring As Boolean = False
		Dim stepB As StepB = PCW.GetStep("StepB")
		If stepB.rbRecurringYes.Checked Then
			recurring = True
		End If
		Return recurring
	End Function

	Private Function Empty_Points_Earned()
		Dim empty As Boolean = False
		If (Me.CheckedListBox2.CheckedIndices.Count = 0) Then
			empty = True
		End If
		Return empty
	End Function

	Private Function Empty_Occuring_Days()
		Dim empty As Boolean = False
		If (Me.CheckedListBox1.CheckedIndices.Count = 0) Then
			empty = True
		End If
		Return empty
	End Function

	Private Function AskForSameDay()
		Dim samedayMsgString As String = <a>It is currently selected to not allow SameDay points.
Do you want points to be earned on the day of the promo?</a>.Value

		Dim result As Integer = CenteredMessagebox.MsgBox.Show(samedayMsgString, "SameDay Points?",
															   MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If result = DialogResult.Yes Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub Clear_PromoDays()
		For Each indexChecked As Integer In Me.CheckedListBox1.CheckedIndices
			If Me.CheckedListBox1.GetItemChecked(indexChecked) = True Then
				Me.CheckedListBox1.SetItemChecked(indexChecked, False)
			End If
		Next
	End Sub

	Private Sub Clear_PointsDays()
		For Each indexChecked As Integer In Me.CheckedListBox2.CheckedIndices
			If Me.CheckedListBox2.GetItemChecked(indexChecked) = True Then
				Me.CheckedListBox2.SetItemChecked(indexChecked, False)
			End If
		Next
	End Sub

	Private Sub Clear_Checklistboxes()
		Clear_PromoDays()
		Clear_PointsDays()
	End Sub

	Private Function SameDays_Are_Selected()
		Dim invalid As Boolean = False

		For Each indexChecked As Integer In Me.CheckedListBox1.CheckedIndices
			If Me.CheckedListBox1.GetItemCheckState(indexChecked) = Me.CheckedListBox2.GetItemCheckState(indexChecked) Then
				invalid = True
			End If
		Next

		Return invalid
	End Function

	Private Function No_Selected_For_SameDay_Points()
		Return RadioButton2.Checked
	End Function

	Private Function EndDate_Before_BeginDate()
		Dim invalid As Boolean = False

		Dim beginDate As DateTime = Me.DateTimePicker1.Value.Date
		Dim endDate As DateTime = Me.DateTimePicker2.Value.Date
		Dim result As Int16 = DateTime.Compare(beginDate, endDate)
		If (result > 0) Then
			invalid = True
			CenteredMessagebox.MsgBox.Show("The end date of the promo is before the begin date", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If

		Return invalid
	End Function

	Private Function OccursDate_Before_EndDate()
		Dim invalid As Boolean = False

		Dim occursDate As DateTime = Me.DateTimePicker3.Value.Date
		Dim endDate As DateTime = Me.DateTimePicker2.Value.Date
		Dim result As Int16 = DateTime.Compare(endDate, occursDate)
		If (result > 0) Then
			invalid = True
			CenteredMessagebox.MsgBox.Show("The occurs date of the promo is before the end date", "Error",
										   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If

		Return invalid
	End Function

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		All_Or_Nothing_Checked()
	End Sub
End Class

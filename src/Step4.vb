Imports TSWizards

'Step4 is used when setting the date information for a recurring promo
Public Class Step4
    Inherits TSWizards.BaseInteriorStep

    Private Sub Step4_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
        'Checks if the user pressed Next> before setting any values
        If Nothing_Was_Set() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            Me.Panel2.BackColor = Color.MistyRose
            Me.Panel3.BackColor = Color.MistyRose
            Me.Panel4.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("Please set the date values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Panel1.BackColor = SystemColors.Control
            Me.Panel2.BackColor = SystemColors.Control
            Me.Panel3.BackColor = SystemColors.Control
            Me.Panel4.BackColor = SystemColors.Control
        End If

        'Only the Occuring on Days values forgot to be set
        If Not Nothing_Was_Set() And Empty_Occuring_Days() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please set the occuring day values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel1.BackColor = Color.MistyRose
        Else
            Me.Panel1.BackColor = SystemColors.Control
        End If

        'Only the Points Earned On valuse forgot to be set
        If Not Nothing_Was_Set() And Empty_Points_Earned() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please set the points earned on values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel2.BackColor = Color.MistyRose
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If

        If Not Nothing_Was_Set() And Promo_Start_Not_Set() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please set the promo start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel3.BackColor = Color.MistyRose
        Else
            Me.Panel3.BackColor = SystemColors.Control
        End If

        If Not Nothing_Was_Set() And Promo_End_Not_Set() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please set the promo end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        'Checks to see if attempting to earn points on the day of the promo when NO is selected
        'If this occurs, we're going to show a dialog to ask directly what the user intended to do
        'and then we will act accordingly from their direct response.
        If No_Selected_For_SameDay_Points And SameDays_Are_Selected Then
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

        'Checks to see if the date exception is actually a day of the week that was checked
        If Day_Exception_Selected() And Invalid_Date_Exception() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            Me.Panel6.BackColor = Color.MistyRose

            Dim invalidDateString As String = <a>Invalid Date Exception:
</a>.Value

            CenteredMessagebox.MsgBox.Show(invalidDateString & Me.DateTimePicker3.Value.DayOfWeek.ToString & " is not a selected day of the week for the promo to occur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DateTimePicker3.Value = DateTime.Today
            Clear_PromoDays()
        Else
            If Not Empty_Occuring_Days() Then
                Me.Panel1.BackColor = SystemColors.Control
                Me.Panel6.BackColor = SystemColors.Control
            End If
        End If

        'Checks to see if the point exception is actually a day of the week that was ckecked
        If Points_Exception_Selected() And Invalid_Points_Exception() Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            Me.Panel7.BackColor = Color.MistyRose

            Dim invalidPointsString As String = <a>Invalid Points Exception:
</a>.Value

            CenteredMessagebox.MsgBox.Show(invalidPointsString & Me.DateTimePicker4.Value.DayOfWeek.ToString & " is not a selected day of the week to earn points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DateTimePicker4.Value = DateTime.Today
            Clear_PointsDays()
        Else
            If Not Empty_Points_Earned() Then
                Me.Panel2.BackColor = SystemColors.Control
                Me.Panel7.BackColor = SystemColors.Control
            End If
        End If

        'Checks if the Day Exception CheckBox is checked;
        'if so, go through and make sure that all the exceptions are within the range
        If Day_Exception_Selected() And Invalid_Exception() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("A day exception falls outside the range of the first and last day of the promo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel6.BackColor = Color.MistyRose
        Else
            If Not Invalid_Date_Exception() And Not Nothing_Was_Set() Then
                Me.Panel6.BackColor = SystemColors.Control
            End If
        End If

        'Checks if the Points Exception CheckBox is checked;
        'if so, go through and make sure that all the exceptions are within the range
        If Points_Exception_Selected() And Invalid_Exception() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("A points exception falls outside the range of the first and last day of the promo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel7.BackColor = Color.MistyRose
        Else
            If Not Invalid_Points_Exception() And Not Nothing_Was_Set() Then
                Me.Panel7.BackColor = SystemColors.Control
            End If
        End If
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

        Dim result As Integer = CenteredMessagebox.MsgBox.Show(samedayMsgString, "SameDay Points?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Function Invalid_Date_Exception()
        Dim invalid As Boolean = True

        Dim dateExString As String = Me.DateTimePicker3.Value.DayOfWeek.ToString

        For Each itemChecked As Object In CheckedListBox1.CheckedItems
            If itemChecked.ToString = dateExString Then
                invalid = False
            End If
        Next

        Return invalid
    End Function

    Private Function Invalid_Points_Exception()
        Dim invalid As Boolean = True

        Dim dateExString As String = Me.DateTimePicker4.Value.DayOfWeek.ToString

        For Each itemChecked As Object In CheckedListBox2.CheckedItems
            If itemChecked.ToString = dateExString Then
                invalid = False
            End If
        Next

        Return invalid
    End Function

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

    Private Function Day_Exception_Selected()
        Return Me.CheckBox1.Checked
    End Function

    Private Function Points_Exception_Selected()
        Return Me.CheckBox2.Checked
    End Function

    Private Function EndDate_Before_BeginDate()
        Dim invalid As Boolean = False

        Dim beginDate As DateTime = Me.DateTimePicker1.Value.Date
        Dim endDate As DateTime = Me.DateTimePicker2.Value.Date
        Dim result As Int16 = DateTime.Compare(beginDate, endDate)
        If (result > 0) Then
            invalid = True
            CenteredMessagebox.MsgBox.Show("The end date of the promo is before the begin date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return invalid
    End Function

    Private Function Invalid_Exception()
        Dim invalid As Boolean = False
        Dim startDate As DateTime = Me.DateTimePicker2.Value.Date
        Dim endDate As DateTime = Me.DateTimePicker3.Value.Date

        If CheckBox1.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker3.Value.Date)
        End If

        If CheckBox2.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker4.Value.Date)
        End If

        Return invalid
    End Function

    Private Function Is_Invalid_Exception(ByVal exDate As Date)
        Dim invalid As Boolean = False
        Dim startDate As DateTime = Me.DateTimePicker1.Value.Date
        Dim endDate As DateTime = Me.DateTimePicker2.Value.Date

        If (DateTime.Compare(exDate, startDate) < 0) Or (DateTime.Compare(exDate, endDate) > 0) Then
            invalid = True
        End If

        Return invalid
    End Function

    'Day Exception
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.Label6.Enabled = True
            Me.DateTimePicker3.Enabled = True
        Else
            Me.Label6.Enabled = False
            Me.DateTimePicker3.Enabled = False
            Me.DateTimePicker3.Value = DateTime.Today
            If Me.Panel6.BackColor = Color.MistyRose Then
                Me.Panel6.BackColor = SystemColors.Control
            End If
        End If
    End Sub

    'Points Exception
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Me.Label7.Enabled = True
            Me.DateTimePicker4.Enabled = True
        Else
            Me.Label7.Enabled = False
            Me.DateTimePicker4.Enabled = False
            Me.DateTimePicker4.Value = DateTime.Today
            If Me.Panel7.BackColor = Color.MistyRose Then
                Me.Panel7.BackColor = SystemColors.Control
            End If
        End If
    End Sub

#Region "Step4_InfoCircle"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014

Brought to you by the fine folks of the OJC IT Department!

Please direct questions and concerns toward:
Russell Dillin
rdillin@oaklawn.com
x696</a>.Value

        CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

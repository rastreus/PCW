Imports TSWizards
Imports CenteredMessagebox

Public Class Step3
    Inherits TSWizards.BaseInteriorStep

#Region "Step3_Validation"
    Private Sub Step3_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
        'Checks if the user pressed Next> before setting any values
        If Nothing_Was_Set() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please set the date values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel1.BackColor = Color.MistyRose
            Me.Panel2.BackColor = Color.MistyRose
            Me.Panel3.BackColor = Color.MistyRose
        Else
            Me.Panel1.BackColor = SystemColors.Control
            Me.Panel2.BackColor = SystemColors.Control
            Me.Panel3.BackColor = SystemColors.Control
        End If

        'Checks if FirstDay is before PromoDate
        If FirstDay_Before_PromoDate() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            Me.Panel2.BackColor = Color.MistyRose
        Else
            Me.Panel1.BackColor = SystemColors.Control
            Me.Panel2.BackColor = SystemColors.Control
        End If

        'Checks if LastDay is before FirstDay
        If LastDay_Before_FirstDay() Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            Me.Panel3.BackColor = Color.MistyRose
        Else
            Me.Panel2.BackColor = SystemColors.Control
            Me.Panel3.BackColor = SystemColors.Control
        End If

        'Checks if LastDay is the same as PromoDate
        If SameDay_Points_Selected() Then
            If e.Cancel = Not AskForSameDay() Then
                e.Cancel = True
                Me.Panel1.BackColor = Color.MistyRose
                Me.Panel3.BackColor = Color.MistyRose
            Else
                Me.Panel1.BackColor = SystemColors.Control
                Me.Panel3.BackColor = SystemColors.Control
            End If
        End If

        'Checks if the Points Exception CheckBox is checked;
        'if so, go through and make sure that all the exceptions are within the range
        If Points_Exceptions_Selected() And Invalid_Exception() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("A points exception falls outside the range of the first and last day to earn points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel4.BackColor = Color.MistyRose
        Else
            Me.Panel4.BackColor = SystemColors.Control
        End If
    End Sub

    Private Function Points_Exceptions_Selected()
        Return Me.CheckBox1.Checked
    End Function

    Private Function Invalid_Exception()
        Dim invalid As Boolean = False
        Dim startDate As DateTime = Me.DateTimePicker2.Value.Date
        Dim endDate As DateTime = Me.DateTimePicker3.Value.Date

        If CheckBox2.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker4.Value.Date)
        End If

        If CheckBox3.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker5.Value.Date)
        End If

        If CheckBox4.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker6.Value.Date)
        End If

        If CheckBox5.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker7.Value.Date)
        End If

        If CheckBox6.Checked Then
            invalid = Is_Invalid_Exception(DateTimePicker8.Value.Date)
        End If

        Return invalid
    End Function

    Private Function Is_Invalid_Exception(ByVal exDate As Date)
        Dim invalid As Boolean = False
        Dim startDate As DateTime = Me.DateTimePicker2.Value.Date
        Dim endDate As DateTime = Me.DateTimePicker3.Value.Date

        If (DateTime.Compare(exDate, startDate) < 0) Or (DateTime.Compare(exDate, endDate) > 0) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function Nothing_Was_Set()
        Dim invalid As Boolean = False

        If Me.DateTimePicker1.Value.Date = DateTime.Today And Me.DateTimePicker2.Value.Date = DateTime.Today And Me.DateTimePicker3.Value.Date = DateTime.Today Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function LastDay_Before_FirstDay()
        Dim invalid As Boolean = False

        Dim firstDay As DateTime = Me.DateTimePicker2.Value.Date
        Dim lastDay As DateTime = Me.DateTimePicker3.Value.Date
        Dim result As Int16 = DateTime.Compare(firstDay, lastDay)
        If (result > 0) Then
            invalid = True
            CenteredMessagebox.MsgBox.Show("The last date to earn points is before the first date to earn points", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return invalid
    End Function

    Private Function FirstDay_Before_PromoDate()
        Dim invalid As Boolean = False

        Dim firstDay As DateTime = Me.DateTimePicker2.Value.Date
        Dim promoDate As DateTime = Me.DateTimePicker1.Value.Date
        Dim result As Int16 = DateTime.Compare(firstDay, promoDate)
        If (result > 0) Then
            invalid = True
            CenteredMessagebox.MsgBox.Show("The first date to earn points is after the promo date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (result = 0) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function AskForSameDay()
        Dim samedayMsgString As String = "Do you want points to be earned on the day of the promo?"

        Dim result As Integer = CenteredMessagebox.MsgBox.Show(samedayMsgString, "SameDay Points?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function SameDay_Points_Selected()
        Dim invalid As Boolean = False

        Dim lastDay As DateTime = Me.DateTimePicker3.Value.Date
        Dim promoDate As DateTime = Me.DateTimePicker1.Value.Date
        Dim result As Int16 = DateTime.Compare(lastDay, promoDate)
        If (result = 0) And Not Nothing_Was_Set() Then
            invalid = True
        End If

        Return invalid
    End Function
#End Region

#Region "Step3_Reset"
    'Public Sub Step3_ResetStep(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResetStep
    '   If Not IsNothing(Me.Controls) Then
    '      For Each chkbx As CheckBox In Me.Controls
    '          chkbx.Checked = False
    '     Next chkbx
    '
    '     For Each dtp As DateTimePicker In Me.Controls
    '          dtp.Value = DateTime.Today
    '      Next dtp
    '   End If
    'End Sub
#End Region

#Region "Exception_CheckBoxs"
    'The interactive elements which happen whenever the Exception CheckBox(s) is CheckedChanged.
    'Basically it just turns things on and off. There's probably a better way of doing this,
    'I'm just not sure what that way is at the moment. This works for now

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label4.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        Else
            Label4.Enabled = False
            CheckBox2.Enabled = False
            CheckBox2.Checked = False

            CheckBox3.Enabled = False
            CheckBox3.Checked = False

            CheckBox4.Enabled = False
            CheckBox4.Checked = False

            CheckBox5.Enabled = False
            CheckBox5.Checked = False

            CheckBox6.Enabled = False
            CheckBox6.Checked = False

            If Panel4.BackColor = Color.MistyRose Then
                Panel4.BackColor = SystemColors.Control
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            DateTimePicker4.Enabled = True
        Else
            DateTimePicker4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            DateTimePicker5.Enabled = True
        Else
            DateTimePicker5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            DateTimePicker6.Enabled = True
        Else
            DateTimePicker6.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            DateTimePicker7.Enabled = True
        Else
            DateTimePicker7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            DateTimePicker8.Enabled = True
        Else
            DateTimePicker8.Enabled = False
        End If
    End Sub

#End Region

#Region "Step3_InfoCircle"
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

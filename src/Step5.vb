Imports TSWizards
Imports System.Xml
Imports System.Xml.Linq
Imports System.Text.RegularExpressions

Public Class Step5
    Inherits TSWizards.BaseInteriorStep

    Private Sub Step5_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep


        If MaxCoupon_Invalid() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Max Coupon value is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox1.Text = ""
            Me.ActiveControl = Me.TextBox1
        Else
            If Not CashValue_Invalid() And Not Prize_Invalid() Then
                Me.Panel1.BackColor = SystemColors.Control
            End If
        End If

        If CashValue_Invalid() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Cash Value is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox2.Text = ""
            Me.ActiveControl = Me.TextBox2
        Else
            If Not MaxCoupon_Invalid() And Not Prize_Invalid() Then
                Me.Panel1.BackColor = SystemColors.Control
            End If
        End If

        If Prize_Invalid() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Prize field is blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ActiveControl = Me.TextBox3
        Else
            If Not MaxCoupon_Invalid() And Not CashValue_Invalid() Then
                Me.Panel1.BackColor = SystemColors.Control
            End If
        End If

        If PointsDivisor_Invalid() Then
            e.Cancel = True
            Me.Panel3.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Points Divisor is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox5.Text = ""
            Me.ActiveControl = Me.TextBox5
        Else
            Me.Panel3.BackColor = SystemColors.Control
        End If

        If SetAmount_Invalid() Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Set Amount of Tickets is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox4.Text = ""
            Me.ActiveControl = Me.TextBox4
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If

        If TicketsPerPatron_Invalid() Then
            e.Cancel = True
            Me.Panel4.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Limit # of Tickets per patron is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox6.Text = ""
            Me.ActiveControl = Me.TextBox6
        Else
            Me.Panel4.BackColor = SystemColors.Control
        End If

        If TicketsForEntirePromo_Invalid() Then
            e.Cancel = True
            Me.Panel5.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Limit # of Tickets for entire promo is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox7.Text = ""
            Me.ActiveControl = Me.TextBox7
        Else
            Me.Panel5.BackColor = SystemColors.Control
        End If

    End Sub

    Private Function TicketsForEntirePromo_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton1.Checked And Me.RadioButton14.Checked Then
            invalid = Invalid_Number(Me.TextBox7.Text)
        End If

        Return invalid
    End Function

    Private Function TicketsPerPatron_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton1.Checked And Me.RadioButton12.Checked Then
            invalid = Invalid_Number(Me.TextBox6.Text)
        End If

        Return invalid
    End Function

    Private Function SetAmount_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton1.Checked And Me.RadioButton11.Checked Then
            invalid = Invalid_Number(Me.TextBox5.Text)
        End If

        Return invalid
    End Function

    Private Function PointsDivisor_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton1.Checked And (Me.RadioButton6.Checked Or Me.RadioButton7.Checked) Then
            invalid = Invalid_Number(Me.TextBox5.Text)
        End If

        Return invalid
    End Function

    Private Function MaxCoupon_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton2.Checked Then
            invalid = Invalid_Number(Me.TextBox1.Text)
        End If

        Return invalid
    End Function

    Private Function CashValue_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton3.Checked Then
            invalid = Invalid_Number(Me.TextBox2.Text)
        End If

        Return invalid
    End Function

    Private Function Prize_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton4.Checked And Me.TextBox3.Text = "" Then
            invalid = True
        End If

        Return invalid
    End Function

    'Checks to see if the supplied value is not 0
    'or if it is not 1 or more digit
    Private Function Invalid_Number(ByVal inputString As String)
        Dim invalid As Boolean = False
        Dim inputInt As Short
        Dim RegexObj As Regex = New Regex("^\d+$")

        Try
            inputInt = Short.Parse(inputString)
            If (inputInt = 0) Or Not RegexObj.IsMatch(inputString) Then
                invalid = True
            End If
        Catch ex As Exception
            invalid = True
        End Try
        
        Return invalid
    End Function

#Region "Step5_Load"
    Dim toolTip1 As Lingering_ToolTip = New Lingering_ToolTip
    Dim toolTip2 As Lingering_ToolTip = New Lingering_ToolTip
    Dim toolTip3 As Lingering_ToolTip = New Lingering_ToolTip
    Dim toolTip4 As Lingering_ToolTip = New Lingering_ToolTip

    Private Sub Step5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim countString As String = <a>Counts the number of days between the start date
and the end date in which the account earned points.
The counted number is the amount of rewarded tickets.</a>.Value

        Dim compoundString As String = <a>Sums up all points accured between
the start date and the end date,
divides the total by the points divisor.
This is the amount of rewarded tickets.</a>.Value

        Dim complexString As String = <a>Sums up all points accured between the start date
and the end date, divides the total by the points
divisor and then adds it to a count of the date field.
This is the amount of rewarded tickets.</a>.Value

        Dim eligiblePlayersString As String = <a>Selects the number of tickets
from the EligiblePlayers table.</a>

        'Count
        Me.toolTip1.SetToolTip(Me.RadioButton9, countString)
        'Compound
        Me.toolTip2.SetToolTip(Me.RadioButton7, compoundString)
        'Complex
        Me.toolTip3.SetToolTip(Me.RadioButton6, complexString)
        'EligiblePlayers Table Amount
        Me.toolTip4.SetToolTip(Me.RadioButton10, eligiblePlayersString)

    End Sub

    Protected Sub countButton_ShowTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseEnter
        Me.toolTip1.Just_Linger(sender, e)
    End Sub

    Protected Sub countButton_HideTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseLeave
        Me.toolTip1.Hide(Me.RadioButton9)
    End Sub

    'This turns off the ticket option panels if the reward is not tickets
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Me.Panel2.Enabled = True
            Me.Panel4.Enabled = True
            Me.Panel5.Enabled = True
        Else
            Me.Panel2.Enabled = False
            Me.Panel4.Enabled = False
            Me.Panel5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Me.TextBox1.Enabled = True
            Me.ActiveControl = Me.TextBox1
            Me.TextBox1.Text = ""
        Else
            Me.TextBox1.Enabled = False
            Me.TextBox1.Text = "Enter # Here"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Me.TextBox2.Enabled = True
            Me.ActiveControl = Me.TextBox2
            Me.TextBox2.Text = ""
        Else
            Me.TextBox2.Enabled = False
            Me.TextBox2.Text = "Enter Amount Here"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Me.TextBox3.Enabled = True
            Me.ActiveControl = Me.TextBox3
            Me.TextBox3.Text = ""
        Else
            Me.TextBox3.Enabled = False
            Me.TextBox3.Text = "Enter Prize Here"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Me.Panel3.Enabled = True
            Me.ActiveControl = Me.TextBox5
            Me.TextBox5.Text = ""
        Else
            Me.Panel3.Enabled = False
            Me.TextBox5.Text = "Enter # Here"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Me.Panel3.Enabled = True
            Me.ActiveControl = Me.TextBox5
            Me.TextBox5.Text = ""
        Else
            Me.Panel3.Enabled = False
            Me.TextBox5.Text = "Enter # Here"
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            Me.TextBox4.Enabled = True
            Me.ActiveControl = Me.TextBox4
            Me.TextBox4.Text = ""
        Else
            Me.TextBox4.Enabled = False
            Me.TextBox4.Text = "Enter # of Tickets"
        End If
    End Sub
#End Region

#Region "Step5_InfoCircle"
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

    'This is the Yes/No pair of radiobuttons for "Limit # of tickets per patron?"
    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If Not Me.RadioButton13.Checked Then
            Me.TextBox6.Enabled = True
            Me.TextBox6.Text = ""
            Me.ActiveControl = Me.TextBox6
        Else
            Me.TextBox6.Enabled = False
            Me.TextBox6.Text = "Enter # Here"
        End If
    End Sub

    'This is the Yes/No pair of radiobuttons for "Limit # of tickets for entire promo?"
    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If Not Me.RadioButton15.Checked Then
            Me.TextBox7.Enabled = True
            Me.TextBox7.Text = ""
            Me.ActiveControl = Me.TextBox7
        Else
            Me.TextBox7.Enabled = False
            Me.TextBox7.Text = "Enter # Here"
        End If
    End Sub

#Region "Numeric_Textbox_Input"
    'This limits the textboxes to only allow numeric input.
    'For whatever reason, because it just may happen, a user is still able to paste non-numeric input into the textbox.
    'The textbox is validated when the user hits "Next>" to see if there is any invalid characters present.
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class

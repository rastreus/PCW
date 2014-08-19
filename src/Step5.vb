Imports TSWizards
Imports System.Xml
Imports System.Xml.Linq

Public Class Step5
    Inherits TSWizards.BaseInteriorStep

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
        toolTip1.SetToolTip(Me.RadioButton9, countString)
        'Compound
        toolTip2.SetToolTip(Me.RadioButton7, compoundString)
        'Complex
        toolTip3.SetToolTip(Me.RadioButton6, complexString)
        'EligiblePlayers Table Amount
        toolTip4.SetToolTip(Me.RadioButton10, eligiblePlayersString)

    End Sub

    Protected Sub countButton_ShowTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseEnter
        Me.toolTip1.Just_Linger(sender, e)
    End Sub

    Protected Sub countButton_HideTip(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton9.MouseLeave
        Me.toolTip1.Hide(Me.RadioButton9)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Panel2.Enabled = True
        Else
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.Enabled = True
            Me.ActiveControl = Me.TextBox1
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox2.Enabled = True
            Me.ActiveControl = Me.TextBox2
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox3.Enabled = True
            Me.ActiveControl = Me.TextBox3
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Panel3.Enabled = True
            Me.ActiveControl = Me.TextBox5
        Else
            Panel3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Panel3.Enabled = True
            Me.ActiveControl = Me.TextBox5
        Else
            Panel3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            TextBox4.Enabled = True
            Me.ActiveControl = Me.TextBox4
        Else
            TextBox4.Enabled = False
        End If
    End Sub

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
End Class

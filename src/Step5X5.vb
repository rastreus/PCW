Imports TSWizards

'I need more information to determine the PromoType.
'I need to determine what makes the patron eligible for the promo.
Public Class Step5X5
    Inherits TSWizards.BaseInteriorStep

    Private Sub Step5X5_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

        If Invalid_Points_Qualifier() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("Please select a Points Qualifier option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ActiveControl = Me.ComboBox1
            Me.ComboBox1.DroppedDown = True
        Else
            Me.Panel1.BackColor = SystemColors.Control
        End If

        If Invalid_Points_Comparison() Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("Please select a Points Qualifier option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ActiveControl = Me.ComboBox2
            Me.ComboBox2.DroppedDown = True
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If
    End Sub

    Private Function Invalid_Points_Comparison()
        Dim invalid As Boolean = False

        If Me.ComboBox1.Text <> "Gives reward regardless of points" And Me.ComboBox1.Text <> "" And Me.ComboBox2.Text = "" Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function Invalid_Points_Qualifier()
        Dim invalid As Boolean = False

        If Me.ComboBox1.Text = "" Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Sub StepL_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
        Dim step5 As Step5 = PCW.GetStep("Step5")
        If step5.RadioButton16.Checked Then
            Me.Label5.Text = step5.TextBox8.Text
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim step5 As Step5 = PCW.GetStep("Step5")
        If Me.ComboBox1.Text <> "Gives reward regardless of points" And step5.RadioButton16.Checked Then
            Me.Panel2.Enabled = True
        Else
            Me.Panel2.Enabled = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

#Region "Step5X5_InfoCircle"
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

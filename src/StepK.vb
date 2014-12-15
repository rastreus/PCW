Imports TSWizards

Public Class StepK
    Inherits TSWizards.BaseInteriorStep

    Private Sub StepK_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.ValidateStep
        If Me.RadioButton1.Checked And Me.RichTextBox1.Text = "" Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Textbox is blank. Please insert a Comment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton1.Checked Then
            Me.IconButton1.ActiveColor = Color.ForestGreen
            Me.IconButton1.InActiveColor = Color.ForestGreen
            Me.Panel2.Enabled = True
            Me.RichTextBox1.Enabled = True
            Me.RichTextBox1.Text = ""
            Me.ActiveControl = Me.RichTextBox1
        Else
            Me.RichTextBox1.Enabled = False
            Me.Panel2.Enabled = False
            Me.IconButton1.ActiveColor = SystemColors.ControlDark
            Me.IconButton1.InActiveColor = SystemColors.ControlDark
            Me.RichTextBox1.Text = "Insert Comment of 140 characters or less into this TextBox."
            If Me.Panel2.BackColor = Color.MistyRose Then
                Me.Panel2.BackColor = SystemColors.Control
            End If
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If Me.RichTextBox1.Enabled Then
            If (140 - Me.RichTextBox1.Text.Length) < 0 Then
                PCW.NextEnabled = False
                Me.IconButton1.IconType = FontAwesomeIcons.IconType.Cross
                Me.IconButton1.ActiveColor = Color.Firebrick
                Me.IconButton1.InActiveColor = Color.Firebrick
                Me.Label3.ForeColor = Color.Firebrick
                Me.Panel3.BackColor = Color.MistyRose
            Else
                Me.IconButton1.IconType = FontAwesomeIcons.IconType.Tick
                Me.IconButton1.ActiveColor = Color.ForestGreen
                Me.IconButton1.InActiveColor = Color.ForestGreen
                Me.Label3.ForeColor = SystemColors.ControlText
                Me.Panel3.BackColor = SystemColors.Control
                PCW.NextEnabled = True
            End If
            Me.Label3.Text = (140 - Me.RichTextBox1.Text.Length).ToString
        End If
    End Sub

#Region "StepK_IconButton"
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014

Brought to you by the fine folks of the OJC IT Department!</a>.Value

        CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

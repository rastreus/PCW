Imports TSWizards


Public Class Step2X1
    Inherits TSWizards.BaseInteriorStep

    Protected Overrides Sub OnNext()
        'Dim numOfEntries As Short = 1

        'If Me.RadioButton1.Checked Then
        '    numOfEntries = Short.Parse(Me.TextBox1.Text)
        'End If

        'PCW.PCW_StepThroughEntriesPayout(numOfEntries)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked Then
            Me.CheckBox1.Enabled = True
        Else
            Me.CheckBox1.Enabled = False
            Me.CheckBox1.Checked = False
        End If
    End Sub
End Class

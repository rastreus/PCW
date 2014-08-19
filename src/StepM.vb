Imports TSWizards

Public Class StepM
    Inherits TSWizards.BaseInteriorStep


    'Stop the user from going back once they're at the end because it could cause numerous problems.
    'At this point, it's too late for the user to go back and change anything; there no longer
    'needs to be a functioning back button.
    Private Sub StepM_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
        PCW.BackEnabled = False
    End Sub

#Region "StepM_InfoCircle"
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

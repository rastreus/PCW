Imports TSWizards

Public Class Step1
    Inherits TSWizards.BaseExteriorStep

#Region "Step1_InfoCircle"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Create an instance of the PME class and show it
        Dim editor As PAE = New PAE
        editor.ShowDialog()
        'We can close the opener PCW now that wizard is being shown
        PCW.Close()
    End Sub
End Class

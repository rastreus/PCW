Imports TSWizards

Public Class StepL
    Inherits TSWizards.BaseInteriorStep

    Private Sub StepL_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
        If Not Me.CheckBox1.Checked Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose

            Dim warningString As String = <a>, do you take responsibility for creating this promo?
Check that you have read and confirmed the above parameters.
Otherwise, cancel and attempt the process later.</a>.Value

            CenteredMessagebox.MsgBox.Show(Environment.UserName & warningString, "OBEY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub StepL_ShowStep(sender As Object, e As ShowStepEventArgs) Handles MyBase.ShowStep
        GetPromoString()
    End Sub

    Private Sub GetPromoString()
        Dim newPromo As MarketingPromo = PCW.PCW_GetPromo()
        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder

        builder.Append("           Name: " & newPromo.PromoName & vbCrLf)
        builder.Append("           Date: " & newPromo.PromoDate.ToString & vbCrLf)
        builder.Append("      StartDate: " & newPromo.StartDate.ToString & vbCrLf)
        builder.Append("        EndDate: " & newPromo.EndDate.ToString & vbCrLf)
        builder.Append("    PointCutoff: " & newPromo.PointCutoff.ToString & vbCrLf)
        builder.Append("   PointDivisor: " & newPromo.PointDivisor.ToString & vbCrLf)
        builder.Append("     MaxTickets: " & newPromo.MaxTickets.ToString & vbCrLf)
        builder.Append("PromoMaxTickets: " & newPromo.PromoMaxTickets.ToString & vbCrLf)
        builder.Append("      Recurring: " & newPromo.Recurring.ToString & vbCrLf)
        builder.Append("      Frequency: " & newPromo.Frequency.ToString & vbCrLf)
        builder.Append("RecursOnWeekday: " & newPromo.RecursOnWeekday & vbCrLf)
        builder.Append(" EarnsOnWeekday: " & newPromo.EarnsOnWeekday & vbCrLf)
        builder.Append("CountCurrentDay: " & newPromo.CountCurrentDay.ToString & vbCrLf)
        builder.Append("   PrintTickets: " & newPromo.PrintTickets.ToString & vbCrLf)
        builder.Append("       Comments: " & newPromo.Comments & vbCrLf)
        Me.Label1.Text = builder.ToString
    End Sub

#Region "StepL_InfoCircle"
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

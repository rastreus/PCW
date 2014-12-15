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

        'It bothered me that the DateTime wasn't formatted properly.
        'Creating more local variables seems to be one of the only solutions.
        Dim promoDate As Nullable(Of DateTime) = newPromo.PromoDate
        Dim startDate As Nullable(Of DateTime) = newPromo.StartDate
        Dim endDate As Nullable(Of DateTime) = newPromo.EndDate
        Dim pointCutoff As String
        Dim pointDivisor As String
        Dim maxTickets As String
        Dim promoMaxTickets As String
        Dim promoDateStr As String
        Dim startDateStr As String
        Dim EndDateStr As String
        Dim maxCoupon As String
        Dim promoMaxCoupon As String
        Dim couponID As String
        Dim recursOnWeekday As String
        Dim earnsOnWeekday As String
        Dim promoType As String

        'The following simply converts the Nothings into a more readable NULL.
        If IsNothing(newPromo.PointCutoff) Then
            pointCutoff = "NULL"
        Else
            pointCutoff = newPromo.PointCutoff.ToString
        End If

        If IsNothing(newPromo.PointDivisor) Then
            pointDivisor = "NULL"
        Else
            pointDivisor = newPromo.PointDivisor.ToString
        End If

        If IsNothing(newPromo.MaxTickets) Then
            maxTickets = "NULL"
        Else
            maxTickets = newPromo.MaxTickets.ToString
        End If

        If IsNothing(newPromo.PromoMaxTickets) Then
            promoMaxTickets = "NULL"
        Else
            promoMaxTickets = newPromo.PromoMaxTickets.ToString
        End If

        If IsNothing(newPromo.PromoDate) Then
            promoDateStr = "NULL"
        Else
            promoDateStr = String.Format("{0:MM/dd/yyyy}", promoDate)
        End If

        If IsNothing(newPromo.StartDate) Then
            startDateStr = "NULL"
        Else
            startDateStr = String.Format("{0:MM/dd/yyyy}", startDate)
        End If

        If IsNothing(newPromo.EndDate) Then
            EndDateStr = "NULL"
        Else
            'EndDateStr = endDate.ToString("MM/dd/yyyy")
            EndDateStr = String.Format("{0:MM/dd/yyyy}", endDate)
        End If

        If IsNothing(newPromo.MaxCoupon) Then
            maxCoupon = "NULL"
        Else
            maxCoupon = newPromo.MaxCoupon.ToString
        End If

        If IsNothing(newPromo.PromoMaxCoupon) Then
            promoMaxCoupon = "NULL"
        Else
            promoMaxCoupon = newPromo.PromoMaxCoupon.ToString
        End If

        If IsNothing(newPromo.CouponID) Then
            couponID = "NULL"
        Else
            couponID = newPromo.CouponID
        End If

        If IsNothing(newPromo.RecursOnWeekday) Then
            recursOnWeekday = "NULL"
        Else
            recursOnWeekday = newPromo.RecursOnWeekday
        End If

        If IsNothing(newPromo.EarnsOnWeekday) Then
            earnsOnWeekday = "NULL"
        Else
            earnsOnWeekday = newPromo.EarnsOnWeekday
        End If

        If IsNothing(newPromo.PromoType) Then
            promoType = "NULL"
        Else
            promoType = newPromo.PromoType
        End If

        'Now that the NULL formalities are out of the way,
        'we can actually build the string that the user will read.
        builder.Append("      PromoType: " & promoType & vbCrLf)
        builder.Append("           Name: " & newPromo.PromoName & vbCrLf)
        builder.Append("           Date: " & promoDateStr & vbCrLf)
        builder.Append("      StartDate: " & startDateStr & vbCrLf)
        builder.Append("        EndDate: " & EndDateStr & vbCrLf)
        builder.Append("    PointCutoff: " & pointCutoff & vbCrLf)
        builder.Append("   PointDivisor: " & pointDivisor & vbCrLf)
        builder.Append("     MaxTickets: " & maxTickets & vbCrLf)
        builder.Append("PromoMaxTickets: " & promoMaxTickets & vbCrLf)
        builder.Append("      MaxCoupon: " & maxCoupon & vbCrLf)
        builder.Append(" PromoMaxCoupon: " & promoMaxCoupon & vbCrLf)
        builder.Append("       CouponID: " & couponID & vbCrLf)
        builder.Append("      Recurring: " & newPromo.Recurring.ToString & vbCrLf)
        builder.Append("      Frequency: " & newPromo.Frequency.ToString & vbCrLf)
        builder.Append("RecursOnWeekday: " & recursOnWeekday & vbCrLf)
        builder.Append(" EarnsOnWeekday: " & earnsOnWeekday & vbCrLf)
        builder.Append("CountCurrentDay: " & newPromo.CountCurrentDay.ToString & vbCrLf)
        builder.Append("   PrintTickets: " & newPromo.PrintTickets.ToString & vbCrLf)
        builder.Append("       Comments: " & newPromo.Comments & vbCrLf)
        Me.Label1.Text = builder.ToString
    End Sub

#Region "StepL_InfoCircle"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014

Brought to you by the fine folks of the OJC IT Department!</a>.Value

        CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

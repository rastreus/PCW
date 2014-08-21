Imports TSWizards
Imports CenteredMessagebox
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Linq

Public Class PCW
    Inherits TSWizards.BaseWizard

    Private infoCircle As FontAwesomeIcons.IconButton = New FontAwesomeIcons.IconButton

#Region "New"
    'Not entirely sure if this was needed,
    'but it got added and works
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cancel.Visible = True
        Me.back.Visible = True
    End Sub
#End Region

#Region "PCW_LoadSteps"
    'This is an important subroutine.
    'This creates instances of the Step classes,
    'names them and associates them to the Wizard (PCW).
    'A Step can be generated dynamically during runtime,
    'but the better option is just to create a Step and add it here.
    Private Sub PCW_LoadSteps(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles MyBase.LoadSteps

        AddStep("Step1", New Step1)
        AddStep("Step2", New Step2)
        AddStep("Step3", New Step3)
        AddStep("Step4", New Step4)
        AddStep("Step5", New Step5)
        AddStep("StepK", New StepK)
        AddStep("StepL", New StepL)
        AddStep("StepM", New StepM)
        AddStep("StepN", New StepN)
    End Sub
#End Region

    Private Sub PCW_InsertPromo()
        'Initialize the entity
        Dim newPromo As MarketingPromo = New MarketingPromo

        'Initialize the Steps
        Dim step2 As Step2 = Me.GetStep("Step2")
        Dim step3 As Step3 = Me.GetStep("Step3")
        Dim step4 As Step4 = Me.GetStep("Step4")
        Dim step5 As Step5 = Me.GetStep("Step5")
        Dim stepK As StepK = Me.GetStep("StepK")

        'Make sure that we are who we say we are
        If IsNothing(step2) Or IsNothing(step3) Or IsNothing(step4) Or IsNothing(step5) Then
            Throw New ApplicationException("A Step is not the Step that it claims to be!")
        End If

        'Gather the step results and put into the entity
        newPromo.PromoName = step2.TextBox1.Text
        ''
        'This is going to be a bear.
        'This will be one of the last things that gets worked out.
        'newPromo.PromoType = DeterminePromoType()
        ''
        newPromo.PromoDate = DeterminePromoDate(step2, step3, step4)
        newPromo.StartDate = DetermineStartDate(step2, step3, step4)
        newPromo.EndDate = DetermineEndDate(step2, step3, step4)
        ''
        'Still need to create a Step to determine when the Patron Qualifies for the Promo
        'newPromo.PointCutoff
        ''
        newPromo.PointDivisor = DeterminePointDivisor(step5)
        newPromo.MaxTickets = DetermineMaxTickets(step5)
        newPromo.PromoMaxTickets = DeterminePromoMaxTickets(step5)
        ''
        'Still need to create a Step to determine the Coupon reward info if it is a FreePlay Coupon type promo
        'newPromo.MaxCoupon
        'newPromo.PromoMaxCoupon
        'newPromo.CouponID
        ''
        newPromo.Comments = DetermineComments(stepK)


    End Sub

    Private Function DetermineComments(ByVal stepK As StepK)
        Dim comments As String

        If stepK.RadioButton1.Checked Then
            comments = stepK.RichTextBox1.Text
        Else
            comments = Nothing
        End If

        Return comments
    End Function

    Private Function DeterminePromoMaxTickets(ByVal step5 As Step5)
        Dim promoMaxTickets As Short

        If step5.RadioButton1.Checked And step5.RadioButton14.Checked Then
            promoMaxTickets = Short.Parse(step5.TextBox7.Text)
        Else
            promoMaxTickets = Nothing
        End If

        Return promoMaxTickets
    End Function

    Private Function DetermineMaxTickets(ByVal step5 As Step5)
        Dim maxTickets As Short

        If step5.RadioButton1.Checked And step5.RadioButton12.Checked Then
            maxTickets = Short.Parse(step5.TextBox6.Text)
        Else
            maxTickets = Nothing
        End If

        Return maxTickets
    End Function

    Private Function DeterminePointDivisor(ByVal step5 As Step5)
        Dim pointDivisor As Short

        If step5.RadioButton1.Checked And (step5.RadioButton6.Checked Or step5.RadioButton7.Checked) Then
            pointDivisor = Short.Parse(step5.TextBox5.Text)
        Else
            pointDivisor = Nothing
        End If

        Return pointDivisor
    End Function

    Private Function DeterminePromoDate(ByVal step2 As Step2, ByVal step3 As Step3, ByVal step4 As Step4)
        Dim promoDate As DateTime

        'Check the recurring button that determines everything
        If Recurring(step2) Then
            promoDate = step3.DateTimePicker1.Value.Date
        Else
            promoDate = Nothing
        End If

        Return promoDate
    End Function

    Private Function DetermineStartDate(ByVal step2 As Step2, ByVal step3 As Step3, ByVal step4 As Step4)
        Dim startDate As DateTime

        If Recurring(step2) Then
            startDate = step3.DateTimePicker2.Value.Date
        Else
            startDate = step4.DateTimePicker1.Value.Date
        End If

        Return startDate
    End Function

    Private Function DetermineEndDate(ByVal step2 As Step2, ByVal step3 As Step3, ByVal step4 As Step4)
        Dim endDate As DateTime

        If Recurring(step2) Then
            endDate = step3.DateTimePicker3.Value.Date
        Else
            endDate = step4.DateTimePicker2.Value.Date
        End If

        Return endDate
    End Function

    'Not exactly necessary but it makes the code read well
    Private Function Recurring(ByVal step2 As Step2)
        Return step2.RadioButton5.Checked
    End Function

#Region "OnClosing"
    'It really bothered me that the dialog boxes did not center on their parent window.
    'The Sub and Function that follows are a direct override of TSWizard.BaseWizard.OnClosing.
    'The only difference here is that the dialog now centers on the parent window. SUCCESS!
    Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
        If DialogResult = DialogResult.Cancel Then
            e.Cancel = Not AskToClose()
        End If
    End Sub

    Private Function AskToClose()
        Dim cancelMsgString As String = <a>Do you wish to quit the wizard now?
Your changes will not be saved if you do.</a>.Value

        Dim result As Integer = CenteredMessagebox.MsgBox.Show(cancelMsgString, "Exit wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
End Class

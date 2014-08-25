Imports TSWizards
Imports CenteredMessagebox

Public Class Step2
    Inherits TSWizards.BaseInteriorStep

    Private Sub Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.TextBox1
    End Sub

#Region "Step2_Validation"
    'This occurs when the user presses the Next> Button on Step2
    'We want to check everything and confirm that there will be no issues
    'before moving on to the next Step. Additionally, this is also where the
    'logic is to determine what qualifies as the next Step. By default, the
    'next Step is set to Step3; however, that takes us to single-date setup.
    'If we are setting up a recurring promo, then we will be taken to Step4 instead.
    Private Sub Step2_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep
        If PromoName_Invalid() Then
            e.Cancel = True
            Panel1.BackColor = Color.MistyRose
            Me.ActiveControl = Me.TextBox1
        Else
            Panel1.BackColor = SystemColors.Control
        End If

        If FreePlay_Invalid() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please select Free Play coupon delivery option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel2.BackColor = Color.MistyRose
            Me.ActiveControl = Me.ComboBox1
            Me.ComboBox1.DroppedDown = True
        Else
            Panel2.BackColor = SystemColors.Control
        End If

        If Recurring_Period_Invalid() Then
            e.Cancel = True
            CenteredMessagebox.MsgBox.Show("Please select Recurring period option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Panel3.BackColor = Color.MistyRose
            Me.ActiveControl = Me.ComboBox2
            Me.ComboBox2.DroppedDown = True
        Else
            Me.Panel3.BackColor = SystemColors.Control
        End If

        'If the PromoType is a FreePlay, then it is known that the reward is going to be a FreePlay Coupon.
        'Instead of going to Step5 for General Promo reward information, user will be taken to Step6.
        'This gets tricky because the promo may still be single-instance of recurring.
        'The appropriate Steps are informed and updated as to the flow of "<Back" and "Next>"
        If PromoType_FreePlay() Then
            If PromoDate_Recurring() Then
                PCW.GetStep("Step4").NextStep = "Step6"
                PCW.GetStep("Step6").PreviousStep = "Step4"
            Else
                PCW.GetStep("Step3").NextStep = "Step6"
                PCW.GetStep("Step6").PreviousStep = "Step3"
            End If
            PCW.GetStep("StepK").PreviousStep = "Step6"
        Else
            PCW.GetStep("StepK").PreviousStep = "Step5"
        End If

        'Determine which Radiobutton (Yes or No) is checked for "Will the new promo be recurring?"
        'If the promo is recurring, MoveTo Step4 instead of Step3.
        'Inform Step5 that its PreviousStep is now Step4 instead of Step3.
        'This needs to be the final check in the Step2Validation since a MoveTo is involved.
        If PromoDate_Recurring() Then
            e.Cancel = True
            PCW.GetStep("Step5").PreviousStep = "Step4"
            If Not PromoName_Invalid() And Not FreePlay_Invalid() And Not Recurring_Period_Invalid() Then
                PCW.MoveTo("Step4")
            End If
        Else
            PCW.GetStep("Step5").PreviousStep = "Step3"
        End If

    End Sub

    Private Function PromoType_FreePlay()
        Dim freePlay As Boolean = False

        If Me.RadioButton1.Checked Then
            freePlay = True
        End If

        Return freePlay
    End Function

    Private Function FreePlay_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton1.Checked And Me.ComboBox1.Text = "Coupon delivery?" Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function Recurring_Period_Invalid()
        Dim invalid As Boolean = False

        If Me.RadioButton4.Checked And Me.ComboBox2.Text = "Recurring Period?" Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function PromoName_Invalid()
        Dim invalid As Boolean = False

        If Me.TextBox1.Text = "" Then
            CenteredMessagebox.MsgBox.Show("Promo must have a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            invalid = True
        ElseIf Sql_Query.Existing_Promo(Me.TextBox1.Text) Then
            CenteredMessagebox.MsgBox.Show("There is an existing promo with this name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TextBox1.Text = ""
            invalid = True
        End If

        Return invalid
    End Function

    Private Function PromoDate_Recurring()
        Dim recurring As Boolean = False

        If RadioButton4.Checked Then
            recurring = True
        End If

        Return recurring
    End Function
#End Region

#Region "Free Play RadioButton"
    'Free Play RadioButton
    'This is an interactive feature for the Step.
    'This expands the Free Play box if its RadioButton gets checked.
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.ComboBox1.DroppedDown = True
        Else
            Me.ComboBox1.Enabled = False
        End If
    End Sub
#End Region

#Region "Recurring RadioButton"
    'There is the potential that things could go astray if the user
    'goes all the way through the wizard process and then decides to go
    'all the way back in order to change recurring quality of the promo.
    'Hopefully resetting Step3 and Step4 will minimize anything that may go wrong.
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'PCW.GetStep("Step3").StepTitle = "Promotionals Are Exciting!"
        'PCW.ResetSteps()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Me.ComboBox2.Enabled = True
            Me.ComboBox2.DroppedDown = True
        Else
            Me.ComboBox2.Enabled = False
        End If
    End Sub
#End Region

#Region "Step2_InfoCircle"
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

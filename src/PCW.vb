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
        AddStep("StepL", New StepL)
        AddStep("StepM", New StepM)
        AddStep("StepN", New StepN)
    End Sub
#End Region

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

Imports TSWizards

''' <summary>
''' Final Step; handles rerunning the PCW.
''' </summary>
''' <remarks>Minimalism at its finest.</remarks>
Public Class StepX
	Inherits TSWizards.BaseExteriorStep

#Region "OnFinish"
	''' <summary>
	''' Resets and reruns the PCW.
	''' </summary>
	''' <remarks>If the user wants, he/she can do it all over again!</remarks>
	Protected Overrides Sub OnFinish()
		If Me.cbPCWRerun.Checked Then
			PCW.ResetSteps()
			PCW.MoveTo("StepA")
		Else
			MyBase.OnFinish()
		End If
	End Sub
#End Region
#Region "StepX_InfoCircle"
	Private Sub stepX_InfoCircle_Click(sender As Object, e As EventArgs) _
		Handles stepX_InfoCircle.Click
		Dim copyStr As String = "Copyright " & ChrW(169)
		Dim infoStr As String = <a>Oaklawn Jockey Club, 2014-2015

Brought to you by the fine folks of the OJC IT Department!</a>.Value
		Dim str As String = copyStr & " " & infoStr

		GUI_Util.msgBox(str, "Information", "Information")
	End Sub
#End Region
#Region "StepX_ShowStep"
	''' <summary>
	''' Stops user from going back.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>Too late for the user to go back and change anything.</remarks>
	Private Sub StepX_ShowStep(sender As Object, e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		PCW.BackEnabled = False
	End Sub
#End Region
End Class

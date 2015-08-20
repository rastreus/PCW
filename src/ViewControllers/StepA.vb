Imports TSWizards

''' <summary>
''' First Step; welcomes to the PCW.
''' </summary>
''' <remarks>A bunch of words
''' that no one will read.</remarks>
Public Class StepA
    Inherits TSWizards.BaseExteriorStep

#Region "StepA_ShowStep"
	Private Sub StepA_ShowStep(sender As Object, _
							   e As ShowStepEventArgs) _
		Handles MyBase.ShowStep
		Me.lblVERNUM.Text = "v." & _
							My.Application _
							  .Info _
							  .Version _
							  .ToString
	End Sub
#End Region
#Region "StepA_InfoCircle"
	Private Sub StepA_InfoCircle_Click(sender As Object, _
									   e As EventArgs) _
		Handles StepA_InfoCircle.Click
		Dim copyStr As String = "Copyright " & ChrW(169)

		Dim infoStr As String = "Oaklawn Jockey Club, 2014-2015" & vbCrLf & _
								"Brought to you by the fine folks " & _
								"of the OJC IT Department!"

		Dim str As String = copyStr & " " & infoStr

		GUI_Util.msgBox(str, "Information", "Information")
	End Sub
#End Region
#Region "StepA_btnEditPromo"
	''' <summary>
	''' Creates and opens the PAE
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>User wants to edit an existing promo
	''' instead of creating a new one.</remarks>
	Private Sub btnEditPromo_Click(sender As Object, _
								   e As EventArgs) _
		Handles btnEditPromo.Click
		Dim editor As PAE = New PAE	'Create an instance of the PME class
		editor.ShowDialog()			'Show the new 
		PCW.Close()					'Close PCW
	End Sub
#End Region
End Class

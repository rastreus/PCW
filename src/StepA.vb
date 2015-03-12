Imports TSWizards

''' <summary>
''' First Step; welcomes to the PCW.
''' </summary>
''' <remarks>A bunch of words that no one will read.</remarks>
Public Class StepA
    Inherits TSWizards.BaseExteriorStep

#Region "StepA_InfoCircle"
	Private Sub StepA_InfoCircle_Click(sender As Object, e As EventArgs) _
		Handles StepA_InfoCircle.Click
		Dim copyStr As String = "Copyright " & ChrW(169)
		Dim infoStr As String = <a>Oaklawn Jockey Club, 2014-2015

Brought to you by the fine folks of the OJC IT Department!</a>.Value
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
	''' <remarks>User wants to edit an existing promo instead of creating a new one.</remarks>
	Private Sub btnEditPromo_Click(sender As Object, e As EventArgs) _
		Handles btnEditPromo.Click
		Dim editor As PAE = New PAE	'Create an instance of the PME class
		editor.ShowDialog()			'Show the new 
		PCW.Close()					'Close PCW
	End Sub
#End Region
End Class

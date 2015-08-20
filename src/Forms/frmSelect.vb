''' <summary>
''' Simple Form which opens PCW or PAE.
''' </summary>
''' <remarks>
''' On "Me.Close()" the ""Me" is frmSelect. 
''' Application will not quit here because
''' "Shutdown mode" is set to "When last form closes."
''' </remarks>
Public Class frmSelect
	Private Sub btnOpenPCW_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnOpenPCW.Click
		Dim frmWizard As PCW = New PCW
		frmWizard.Show()
		Me.Close()
	End Sub

	Private Sub btnOpenPAE_Click(sender As Object, _
								 e As EventArgs) _
		Handles btnOpenPAE.Click
		Dim frmEditor As PAE = New PAE
		frmEditor.Show()
		Me.Close()
	End Sub
End Class

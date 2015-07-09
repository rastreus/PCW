Imports TSWizards
Imports System.Net.Mail

''' <summary>
''' First Step; welcomes to the PCW.
''' </summary>
''' <remarks>A bunch of words that no one will read.</remarks>
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
	Private Sub btnEditPromo_Click(sender As Object, _
								   e As EventArgs) _
		Handles btnEditPromo.Click
		Dim editor As PAE = New PAE	'Create an instance of the PME class
		editor.ShowDialog()			'Show the new 
		PCW.Close()					'Close PCW
	End Sub
#End Region

	Private Sub btnTestEmail_Click(sender As Object, _
								   e As EventArgs) _
		Handles btnTestEmail.Click
		Try
			Dim SmtpServer As New SmtpClient()
			Dim mail As New MailMessage()
			SmtpServer.Credentials = New  _
				Net.NetworkCredential( _
					"promotionalcreationwizard@gmail.com", _
					"VQX8;cz8x^yD3!-eG9b48v625%sd.963" & _
					"P4W3.3G!8;365akKA:78jW9bU3p3|G2V")
			SmtpServer.Port = 465
			SmtpServer.EnableSsl = True
			SmtpServer.Host = "smtp.gmail.com"
			mail = New MailMessage()
			mail.From = New MailAddress( _
				"promotionalcreationwizard@gmail.com")
			mail.To.Add("rdillin@oaklawn.com")
			mail.Subject = "PCW-MAIL"
			mail.Body = "This is a test."
			SmtpServer.Send(mail)
		Catch ex As Exception
			'FAIL SILENTLY B/C IT'S JUST EMAIL
		End Try
	End Sub
End Class

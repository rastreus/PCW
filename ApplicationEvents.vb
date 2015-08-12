Namespace My
	' The following events are available for MyApplication:
	' 
	' Startup: Raised when the application starts,
	'          before the startup form is created.
	' Shutdown: Raised after all application forms are closed. This event
	'           is not raised if the application terminates abnormally.
	' UnhandledException: Raised if the application encounters
	'                     an unhandled exception.
	' StartupNextInstance: Raised when launching a single-instance application
	'                      and the application is already active.
	' NetworkAvailabilityChanged: Raised when the network connection is
	'                             connected or disconnected.
	Partial Friend Class MyApplication
		''' <summary>
		''' Alerts of an unhandled exception; Closes PCW.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		''' <remarks></remarks>
		Private Sub My_UnhandledException(ByVal sender As Exception, _
										  ByVal e As EventArgs) _
			Handles MyBase.UnhandledException
			GUI_Util.msgBox("PCW HAS ENCOUNTERED AN EXCEPTION: " & vbCrLf & _
							sender.Message)
			'Me.MainForm.Close()
		End Sub
		''' <summary>
		''' Educates users that PCW is a Single Instance Application.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		''' <remarks>Not needed; cool all the same.</remarks>
		Private Sub My_StartupNextInstance(ByVal sender As Object, _
										   ByVal e As EventArgs) _
			Handles MyBase.StartupNextInstance
			GUI_Util.msgBox("PCW IS ALREADY RUNNING.")
			Me.MainForm.Show()
			Me.MainForm.BringToFront()
		End Sub
		''' <summary>
		''' Alerts of a loss of network connection; Closes PCW.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		''' <remarks>PCW cannot contact the DB so it closes.</remarks>
		Private Sub My_NetworkAvailabilityChanged(ByVal sender As Object, _
												  ByVal e As EventArgs) _
			Handles MyBase.NetworkAvailabilityChanged
			GUI_Util.msgBox("NETWORK AVAILABILITY CHANGED! " & vbCrLf & _
							"PCW CANNOT ACCESS THE DATABASE. " & vbCrLf & _
							"CHECK YOUR NETWORK CONNECTION " & vbCrLf & _
							"AND TRY AGAIN LATER! THANK YOU!")
			Me.MainForm.Close()
		End Sub
	End Class
End Namespace

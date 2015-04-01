Namespace My

	' The following events are available for MyApplication:
	' 
	' Startup: Raised when the application starts, before the startup form is created.
	' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	' UnhandledException: Raised if the application encounters an unhandled exception.
	' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	Partial Friend Class MyApplication
		''' <summary>
		''' Educates users that PCW is a Single Instance Application.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		''' <remarks>Not needed; cool all the same.</remarks>
		Private Sub My_StartupNextInstance(ByVal sender As Object, ByVal e As EventArgs) _
			Handles MyBase.StartupNextInstance
			Me.MainForm.Show()
			Me.MainForm.BringToFront()
		End Sub
	End Class


End Namespace


Imports CenteredMessagebox

''' <summary>
''' Global Graphical User Interface class which handles common, utility tasks.
''' </summary>
''' <remarks>Delegation typically is not ideal; however, something needed to be done quickly.</remarks>
Public Class GUI_Util
#Region "Utility Subroutines"
	''' <summary>
	''' Enables the "Next>" button if it's currently disabled.
	''' </summary>
	''' <remarks></remarks>
	Public Shared Sub NextEnabled()
		If PCW.NextEnabled = False Then
			PCW.NextEnabled = True
		End If
	End Sub

	''' <summary>
	''' Changes "BackColor" of Panel to represent success.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub successPnl(ByRef pnl As System.Windows.Forms.Panel)
		pnl.BackColor = System.Drawing.Color.Lime
	End Sub

	''' <summary>
	''' Changes "BackColor" of Panel to represent an error.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub errPnl(ByRef pnl As System.Windows.Forms.Panel)
		pnl.BackColor = System.Drawing.Color.Crimson
	End Sub

	''' <summary>
	''' Changes "BackColor" of Panel back to regular color.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub regPnl(ByRef pnl As System.Windows.Forms.Panel)
		pnl.BackColor = System.Drawing.SystemColors.ControlDarkDark
	End Sub

	Public Shared Sub regPnl(ByRef pnl As System.Windows.Forms.Panel, _
							 ByVal color As System.Drawing.Color)
		pnl.BackColor = color
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation.
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <remarks>Possibly unnecessary delegation; however, removes "Imports."</remarks>
	Public Shared Sub msgBox(ByRef str As String)
		CenteredMessagebox.MsgBox.Show(str, "Error",
									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation (Overloaded).
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <param name="title">The text to be shown as the title of the msgBox.</param>
	''' <remarks>Overloaded to increase usefulness.</remarks>
	Public Shared Sub msgBox(ByRef str As String, ByRef title As String)
		CenteredMessagebox.MsgBox.Show(str, title,
									   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation (Overloaded).
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <param name="title">The text to be shown as the title of the msgBox.</param>
	''' <param name="info">"Information" must be the value.</param>
	''' <remarks></remarks>
	Public Shared Sub msgBox(ByRef str As String, ByRef title As String, ByRef info As String)
		If info = "Information" Then
			CenteredMessagebox.MsgBox.Show(str, title,
									   MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			msgBox(str, title)
		End If
	End Sub
#End Region
End Class

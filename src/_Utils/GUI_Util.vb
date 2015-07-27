Imports CenteredMessagebox
Imports System.Windows.Forms
Imports FontAwesomeIcons

''' <summary>
''' Global Graphical User Interface class which
''' handles common, utility tasks.
''' </summary>
''' <remarks>Delegation typically is not ideal;
''' however, something needed to be done quickly.</remarks>
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

	Public Shared Sub onSetBtn(ByRef btn As Button)
		btn.Enabled = True
		btn.BackColor = Color.HotPink
	End Sub

	Public Shared Sub offIcon(ByRef icon As IconButton)
		If icon.Visible = True Then
			icon.ActiveColor = SystemColors.ControlLight
			icon.InActiveColor = SystemColors.ControlLight
		End If
	End Sub

	Public Shared Sub onIcon(ByRef icon As IconButton)
		icon.IconType = IconType.Tick
		icon.ActiveColor = Color.Lime
		icon.InActiveColor = Color.Lime
		icon.Visible = True
	End Sub

	Public Shared Sub errIcon(ByRef icon As IconButton)
		icon.IconType = IconType.CrossCircleSolid
		icon.ActiveColor = Color.White
		icon.InActiveColor = Color.White
		icon.Visible = True
	End Sub

	Public Shared Sub successLbl(ByRef lbl As Label)
		lbl.BackColor = Color.DarkGreen
		lbl.ForeColor = Color.Lime
	End Sub

	Public Shared Sub regLbl(ByRef lbl As Label)
		lbl.BackColor = Color.Transparent
		lbl.ForeColor = SystemColors.ControlText
	End Sub

	Public Shared Sub successCb(ByRef cb As ComboBox)
		cb.BackColor = Color.DarkGreen
		cb.ForeColor = Color.Lime
	End Sub

	Public Shared Sub regCb(ByRef cb As ComboBox)
		cb.BackColor = Color.White
		cb.ForeColor = Color.Black
	End Sub

	Public Shared Sub successTxt(ByRef txt As TextBox)
		txt.BackColor = Color.DarkGreen
		txt.ForeColor = Color.Lime
	End Sub

	Public Shared Sub regTxt(ByRef txt As TextBox)
		txt.BackColor = SystemColors.Window
		txt.ForeColor = SystemColors.WindowText
	End Sub

	Public Shared Function IsSuccess(ByRef ctl As Control) As Boolean
		Return If(ctl.BackColor = Color.DarkGreen, True, False)
	End Function

	''' <summary>
	''' Changes "BackColor" of Panel to represent success.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub successPnl(ByRef pnl As Panel)
		pnl.BackColor = Color.DarkGreen
	End Sub

	Public Shared Sub errLbl(ByRef lbl As Label)
		lbl.ForeColor = Color.White
		lbl.BackColor = Color.Transparent
	End Sub

	''' <summary>
	''' Changes "BackColor" of Panel to represent an error.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub errPnl(ByRef pnl As Panel)
		pnl.BackColor = Color.Crimson
	End Sub

	''' <summary>
	''' Changes "BackColor" of Panel back to regular color.
	''' </summary>
	''' <param name="pnl">The panel whose BackColor will be changed.</param>
	''' <remarks>More delegation to clean code.</remarks>
	Public Shared Sub regPnl(ByRef pnl As Panel)
		pnl.BackColor = SystemColors.ControlDarkDark
	End Sub

	Public Shared Sub regPnl(ByRef pnl As Panel, _
							 ByVal color As Color)
		pnl.BackColor = color
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation.
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <remarks>Possibly unnecessary delegation; however, removes "Imports."</remarks>
	Public Shared Sub msgBox(ByRef str As String)
		CenteredMessagebox.MsgBox.Show(str, _
									   "Error", _
									   MessageBoxButtons.OK, _
									   MessageBoxIcon.Exclamation)
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation (Overloaded).
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <param name="title">The text to be shown as the title of the msgBox.</param>
	''' <remarks>Overloaded to increase usefulness.</remarks>
	Public Shared Sub msgBox(ByRef str As String, _
							 ByRef title As String)
		CenteredMessagebox.MsgBox.Show(str, _
									   title, _
									   MessageBoxButtons.OK, _
									   MessageBoxIcon.Exclamation)
	End Sub

	''' <summary>
	''' Delegates CenteredMessagebox creation (Overloaded).
	''' </summary>
	''' <param name="str">The text to be shown in the msgBox.</param>
	''' <param name="title">The text to be shown as the title of the msgBox.</param>
	''' <param name="info">"Information" must be the value.</param>
	''' <remarks></remarks>
	Public Shared Sub msgBox(ByRef str As String, _
							 ByRef title As String, _
							 ByRef info As String)
		If info = "Information" Then
			CenteredMessagebox.MsgBox.Show(str, _
										   title, _
										   MessageBoxButtons.OK, _
										   MessageBoxIcon.Information)
		Else
			msgBox(str, title)
		End If
	End Sub
#End Region
End Class

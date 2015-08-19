Public Class SelectorButton
	Inherits Button

	Private SAFE_COLOR As Color = Color.LightCyan
	Private SLCT_COLOR As Color = Color.Cyan
	Private _BOOL As Boolean = False

	Public Sub New()
		Me.AutoSize = True
		Me.Enabled = True
		Me.Visible = True
		Me.BackColor = SAFE_COLOR
		Me.Location = New Point(0, 0)
		Me.ForeColor = Color.Black
		Me.Text = String.Empty
	End Sub

	Public Sub Disable()
		Me.BackColor = SAFE_COLOR
	End Sub

	Protected Overrides Sub OnBackColorChanged(e As EventArgs)
		If _BOOL = True AndAlso _
			Me.BackColor = SLCT_COLOR Then
			For Each btn As SelectorButton In Parent.Controls
				If btn.BackColor = SAFE_COLOR Then
					btn.Enabled = False
				End If
			Next
		ElseIf _BOOL = True AndAlso _
			Me.BackColor = SAFE_COLOR Then
			For Each btn As SelectorButton In Parent.Controls
				btn.Enabled = True
			Next
		End If
	End Sub

	Protected Overrides Sub OnClick(e As EventArgs)
		If _BOOL = False Then
			_BOOL = True
		End If
		If Me.BackColor = SAFE_COLOR Then
			Me.BackColor = SLCT_COLOR
		Else
			Me.BackColor = SAFE_COLOR
		End If
		MyBase.OnClick(e)
	End Sub
End Class

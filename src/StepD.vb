Imports TSWizards
Imports System.Text.RegularExpressions

Public Class StepD
	Inherits TSWizards.BaseInteriorStep

	Private Delegate Sub DelegateChangeLabelText(ByVal s As String)
	Private m_DelegateChangeLabelText As DelegateChangeLabelText

	Private Sub StepD_Load(sender As Object, e As EventArgs) Handles Me.Load
		m_DelegateChangeLabelText = New DelegateChangeLabelText(AddressOf ChangeLabelText)
	End Sub

	Private Sub ChangeLabelText(ByVal s As String)
		Me.Label3.Text = s
	End Sub

#Region "StepD_Validation"
	'This just confirms that everything is good before continuing on to the next Step.
	Private Sub StepD_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

		'Standard PCW error reporting for MULTI-PART SEQUENCIAL INSTANCES
		If MPSI_Invalid() Then
			e.Cancel = True
			Me.Panel2.BackColor = Color.MistyRose
			Me.ActiveControl = Me.TextBox2
		Else
			Me.Panel2.BackColor = SystemColors.Control
		End If
	End Sub

	Private Function MPSI_Invalid()
		Dim invalid As Boolean = False

		If Me.RadioButton6.Checked Then
			invalid = Invalid_Number(Me.TextBox2.Text)
		End If

		Return invalid
	End Function

	'Copied utilitarian function that should only be one place.
	'On a refactoring, place this in a single location.
	'Checks to see if the supplied value is not 0
	'or if it is not 1 or more digit
	Private Function Invalid_Number(ByVal inputString As String)
		Dim invalid As Boolean = False
		Dim inputInt As Short
		Dim RegexObj As Regex = New Regex("^\d+$")

		Try
			inputInt = Short.Parse(inputString)
			If (inputInt = 0) Or Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			invalid = True
		End Try

		Return invalid
	End Function
#End Region

	'If MULTI-PART SEQUENCIAL INSTANCES is selected, please enable the textbox.
	'Otherwise, put that thing back the way it was.
	Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
		If Me.RadioButton6.Checked Then
			Me.TextBox2.Text = ""
			Me.TextBox2.Enabled = True
			Me.ActiveControl = Me.TextBox2
		Else
			Me.TextBox2.Enabled = False
			Me.TextBox2.Text = "How many days/tiers?"
		End If
	End Sub

	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
		If Not RadioButton5.Checked Then
			SetPointCutoffPanel(Me.RadioButton4.Checked)
		End If
	End Sub

	Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
		If Not RadioButton4.Checked Then
			SetPointCutoffPanel(Me.RadioButton5.Checked)
		End If
	End Sub

	Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
		SetDragDropPanel(Me.RadioButton9.Checked)
	End Sub

	Private Sub SetPointCutoffPanel(ByVal bool As Boolean)
		Me.Panel7.Visible = bool
	End Sub

	Private Sub SetDragDropPanel(ByVal bool As Boolean)
		Me.Panel6.Enabled = bool
		Me.Panel6.Visible = bool
		If Not bool Then
			Me.IconButton1.Visible = bool
			ChangeLabelText("(Drag Offer List Here)")
		End If
	End Sub

	Private Sub Panel6_DragEnter(sender As Object, e As DragEventArgs) Handles Panel6.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub DragDropSuccessIcon()
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.Tick
		Me.IconButton1.ActiveColor = Color.Lime
		Me.IconButton1.InActiveColor = Color.Lime
		Me.IconButton1.Visible = True
	End Sub

	Private Sub DragDropFailureIcon()
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.CrossCircleSolid
		Me.IconButton1.ActiveColor = Color.Red
		Me.IconButton1.InActiveColor = Color.Red
		Me.IconButton1.Visible = True
	End Sub

	Private Sub Panel6_DragDrop(sender As Object, e As DragEventArgs) Handles Panel6.DragDrop
		Try
			Dim a As Array = CType(e.Data.GetData(DataFormats.FileDrop), Array)
			If Not IsNothing(a) Then
				Dim s As String = a.GetValue(0).ToString
				Me.BeginInvoke(m_DelegateChangeLabelText, New Object() {s})
				DragDropSuccessIcon()
			End If
		Catch ex As Exception
			Trace.WriteLine("Error in DragDrop Sub: " + ex.Message)
			ChangeLabelText("FAILURE: " + ex.Message)
			DragDropFailureIcon()
		End Try
	End Sub
End Class

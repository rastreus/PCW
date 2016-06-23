Imports TSWizards
Imports CenteredMessagebox
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Linq
Imports System.ComponentModel

Public Class PCW
    Inherits TSWizards.BaseWizard

#Region "PCW_New"
	''' <summary>
	''' Gets run when creating a New PCW
	''' </summary>
	''' <remarks>'Not entirely sure if
	''' this is needed, but it  works.</remarks>
	Public Sub New()
		'Required by the Designer code.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Me.pcw_data = New PCW_Data
		Me.updater = New frmAutoUpdate
		Me.infoCircle = New FontAwesomeIcons.IconButton
		Me.cancel.Visible = True
		Me.back.Visible = True
	End Sub
#End Region
#Region "PCW_Data"
	Private pcw_data As PCW_Data
	Private updater As frmAutoUpdate
	Private infoCircle As FontAwesomeIcons.IconButton

	Public Property Data() As PCW_Data
		Get
			Return Me.pcw_data
		End Get
		Set(value As PCW_Data)
			Me.pcw_data = value
		End Set
	End Property
#End Region
#Region "PCW_Shown"
	Private Sub PCW_Shown(sender As Object, _
						  e As EventArgs) _
		Handles Me.Shown
		Me.updater.Show()
	End Sub
#End Region
#Region "PCW_LoadSteps"
	''' <summary>
	''' Creates instances of the Step classes.
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks>THIS IS AN IMPORTANT SUB!</remarks>
	Private Sub PCW_LoadSteps(ByVal sender As System.Object, _
							  ByVal e As System.EventArgs) _
		Handles Me.LoadSteps
		AddStep("StepA", New StepA)
		AddStep("StepB", New StepB)
		AddStep("StepC", New StepC)
		AddStep("StepCanHazSecurity", New StepCanHazSecurity)
		AddStep("StepD", New StepD)
		AddStep("StepF", New StepF)
		AddStep("StepEntryTicketAmt", New StepEntryTicketAmt)
		AddStep("StepGeneratePayoutCoupon", New StepGeneratePayoutCoupon)
		AddStep("StepGetCouponOffers", New StepGetCouponOffers)
		AddStep("StepGetCouponTargets", New StepGetCouponTargets)
		AddStep("StepH", New StepH)
		AddStep("StepI", New StepI)
		AddStep("StepJ", New StepJ)
		AddStep("StepX", New StepX)
	End Sub
#End Region
#Region "PCW_GetIWizardStep"
	Public Function GetIWizardStep(ByVal name As String) As IWizardStep
		Return MyBase.GetStep(name)
	End Function
#End Region
#Region "PCW_PrepareAllPromoData"
	Public Sub PrepareAllPromoData()
		For Each stepName As String In Me.Data.PromoStepList
			Me.GetIWizardStep(stepName) _
				.PromoData _
				.PrepareData(Me.Data.PromoDataHash)
		Next
	End Sub
#End Region
#Region "PCW_CancelEnabled"
	'Disable the Cancel Button at the end
	Public Sub CancelEnabled(state As Boolean)
		Me.cancel.Enabled = state
	End Sub
#End Region
#Region "PCW_OnClosing"
	'It really bothered me that the dialog boxes did not center on
	'their parent window. The Sub and Function that follows are a
	'direct override of TSWizard.BaseWizard.OnClosing. The only
	'difference here is that the dialog now centers on the parent
	'window. SUCCESS!
	Protected Overrides Sub OnClosing(e As CancelEventArgs)
		If DialogResult = DialogResult.Cancel Then
			e.Cancel = Not AskToClose()
		End If
	End Sub

	Private Function AskToClose()
		Dim cancelMsgString As String = "Do you wish to quit " & _
										"the wizard now?" & vbCrLf & _
										"Your changes will not " & _
										"be saved if you quit."
		Dim result As Integer = _
			CenteredMessagebox.MsgBox.Show(cancelMsgString, _
										   "Quit wizard?", _
										   MessageBoxButtons.YesNo, _
										   MessageBoxIcon.Question)

		If result = DialogResult.Yes Then
			Return True
		Else
			Return False
		End If
	End Function
#End Region
End Class

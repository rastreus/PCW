﻿Public Class PCW_Data
#Region "Properties"
	Private _pcwReset As Boolean
	Private _pcwResetTo As String = New String("StepA")

	Public Property Reset As Boolean
		Get
			Return _pcwReset
		End Get
		Set(ByVal value As Boolean)
			_pcwReset = value
		End Set
	End Property
	Public Property ResetTo As String
		Get
			Return _pcwResetTo
		End Get
		Set(value As String)
			_pcwResetTo = value
		End Set
	End Property
#End Region
End Class

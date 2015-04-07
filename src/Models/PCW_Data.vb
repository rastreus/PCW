Public Class PCW_Data
#Region "Properties"
	Private _pcwPromoDataHash As Hashtable = New Hashtable()
	Private _pcwPromoStepList As ArrayList = New ArrayList()
	Private _pcwReset As Boolean = False
	Private _pcwResetTo As String = New String("StepA")

	Public Property PromoDataHash As Hashtable
		Get
			Return _pcwPromoDataHash
		End Get
		Set(value As Hashtable)
			_pcwPromoDataHash = value
		End Set
	End Property
	Public Property PromoStepList As ArrayList
		Get
			Return _pcwPromoStepList
		End Get
		Set(value As ArrayList)
			_pcwPromoStepList = value
		End Set
	End Property
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
#Region "GetPromoSummary"
	Public Function GetPromoSummary() As System.Text.StringBuilder
		Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder

		'PromoDataHash.Add("MaxNumOfCouponsPerPatron", MaxNumOfCouponsPerPatron)

		'Now that the NULL formalities are out of the way,
		'we can actually build the string that the user will read.
		'builder.Append("      PromoType: " & promoType & vbCrLf)
		builder.Append("             ID: " & nullIfNothing("ID") & vbCrLf)
		builder.Append("           Name: " & nullIfNothing("Name") & vbCrLf)
		builder.Append("           Date: " & formatDateString("OccursDate") & vbCrLf)
		builder.Append("      StartDate: " & formatDateString("StartDate") & vbCrLf)
		builder.Append("        EndDate: " & formatDateString("EndDate") & vbCrLf)
		builder.Append("    PointCutoff: " & nullIfNothing("PointCutoffLimit") & vbCrLf)
		builder.Append("  PointsDivisor: " & nullIfNothing("PointsDivisor") & vbCrLf)
		builder.Append("     MaxTickets: " & nullIfNothing("TicketsPerPatron") & vbCrLf)
		builder.Append("PromoMaxTickets: " & nullIfNothing("TicketsForEntirePromo") & vbCrLf)
		builder.Append("      MaxCoupon: " & nullIfNothing("CouponAmtPerPatron") & vbCrLf)
		builder.Append(" PromoMaxCoupon: " & nullIfNothing("CouponAmtForEntirePromo") & vbCrLf)
		builder.Append("       CouponID: " & nullIfNothing("CouponID") & vbCrLf)
		builder.Append("      Recurring: " & nullIfNothing("Recurring") & vbCrLf)
		builder.Append("      Frequency: " & nullIfNothing("RecurringFrequency") & vbCrLf)
		builder.Append("RecursOnWeekday: " & nullIfNothing("RecursOnWeekday") & vbCrLf)
		builder.Append(" EarnsOnWeekday: " & nullIfNothing("EarnsOnWeekday") & vbCrLf)
		builder.Append("CountCurrentDay: " & nullIfNothing("CountCurrentDay") & vbCrLf)
		builder.Append("   PrintTickets: " & nullIfNothing("PrintTickets") & vbCrLf)
		builder.Append("        Comment: " & nullIfNothing("Comment") & vbCrLf)
		Return builder
	End Function

	Private Function nullIfNothing(ByVal promoData As String) As String
		Dim result As String = New String("")
		If IsNothing(PromoDataHash.Item(promoData)) Then
			result = "NULL"
		Else
			result = PromoDataHash.Item(promoData).ToString
		End If
		Return result
	End Function

	Private Function formatDateString(ByVal promoData As String) As String
		Dim result As String = New String("")
		If IsNothing(PromoDataHash(promoData)) Then
			result = "NULL"
		Else
			result = String.Format("{0:MM/dd/yyyy}", promoData)
		End If
		Return result
	End Function
#End Region
End Class

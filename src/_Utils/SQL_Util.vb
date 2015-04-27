''' <summary>
''' Global SQL class which handles queries.
''' </summary>
''' <remarks>SELECT ONLY!</remarks>
Public Class SQL_Util

#Region "Existing_Promo"
	''' <summary>
	''' Queries the name field to see if there is an existing promo with the same name.
	''' </summary>
	''' <param name="new_promoName">The name of the promo to query.</param>
	''' <returns>The existance of the promo name.</returns>
	''' <remarks>Why would anyone want to make a promotional which has already been made?</remarks>
	Public Shared Function Existing_Promo(ByVal new_promoName As String) As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As PCWLINQ2SQLDataContext = New PCWLINQ2SQLDataContext(Global _
																	  .PromotionalCreationWizard _
																	  .My _
																	  .MySettings _
																	  .Default _
																	  .GamingConnectionString)

		Dim trimmed_new_promoName As String = new_promoName.Trim

		Dim existing_promoName = (From name In tbl.MarketingPromos
								  Where name.PromoName = trimmed_new_promoName
								  Select name.PromoName).FirstOrDefault

		'Will be NULL (VB value of Nothing) if they are not the same;
		'however, if existing_promoName is not NULL, check to be sure.
		'No need to assume incorrectly.
		If Not String.IsNullOrEmpty(existing_promoName) Then
			If trimmed_new_promoName.ToLower = existing_promoName.ToLower Then
				returningBool = True
			End If
		End If

		Return returningBool
	End Function
#End Region
#Region "Return_Existing_Promo"
	''' <summary>
	''' Returns an existing promo.
	''' </summary>
	''' <param name="existing_promoName"></param>
	''' <returns>The existing promo.</returns>
	''' <remarks>THIS IS ONLY USED BY THE PAE.</remarks>
	Public Shared Function Return_Existing_Promo(ByVal existing_promoName As String) As MarketingPromo
		Dim tbl As PCWLINQ2SQLDataContext = New PCWLINQ2SQLDataContext(Global _
																	  .PromotionalCreationWizard _
																	  .My _
																	  .MySettings _
																	  .Default _
																	  .GamingConnectionString)
		Dim existing_promo As New MarketingPromo
		Dim trimmed_existing_promoName As String = existing_promoName.Trim

		existing_promo = (From promo In tbl.MarketingPromos
						  Where promo.PromoName = trimmed_existing_promoName
						  Select promo)

		Return existing_promo
	End Function
#End Region
#Region "Existing_Coupon"
	''' <summary>
	''' Queries the ID filed to see if there is an existing coupon with the same ID.
	''' </summary>
	''' <param name="new_couponID"></param>
	''' <returns>The existance of the coupon ID.</returns>
	''' <remarks>This function is very similar to Existing_Promo.</remarks>
	Public Shared Function Existing_Coupon(ByVal new_couponID As String) As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As PCWLINQ2SQLDataContext = New PCWLINQ2SQLDataContext(Global _
																	  .PromotionalCreationWizard _
																	  .My _
																	  .MySettings _
																	  .Default _
																	  .GamingConnectionString)

		Dim trimmed_new_couponID As String = new_couponID.Trim

		Dim existing_couponID = (From couponID In tbl.MarketingPromos
								 Where couponID.CouponID = trimmed_new_couponID
								 Select couponID.CouponID).FirstOrDefault

		If Not String.IsNullOrEmpty(existing_couponID) Then
			returningBool = True
		End If

		Return returningBool
	End Function
#End Region
End Class

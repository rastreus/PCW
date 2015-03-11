Public Class Sql_Query

#Region "Existing_Promo"
    'Why would anyone want to make a promotional which has already been made?
    'Common sense would say that they wouldn't. This only queries the name field,
    'but the point is to see if there is a promotional which is already existing
    'that has the same name as the promotional which is attempting to be created.
	Public Shared Function Existing_Promo(ByVal new_promoName As String) As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As New MarketingPromosDataContext

		Dim trimmed_new_promoName As String = new_promoName.Trim

		Dim existing_promoName = (From name In tbl.MarketingPromos
								  Where name.PromoName = trimmed_new_promoName
								  Select name.PromoName).FirstOrDefault

		'Will be null (VB value of Nothing) if they are not the same;
		'however, if existing_promoName is not null, let's still check
		'just to be sure. No need to assume incorrectly.
		If Not String.IsNullOrEmpty(existing_promoName) Then
			If trimmed_new_promoName.ToLower = existing_promoName.ToLower Then
				returningBool = True
			End If
		End If

		Return returningBool
	End Function
#End Region

#Region "Return_Existing_Promo"
    'This is the function that is used by the PAE form to grab the existing promo.
    'This is only used by PAE, not PCW.
    Public Shared Function Return_Existing_Promo(ByVal existing_promoName As String)
        Dim tbl As New MarketingPromosDataContext
        Dim existing_promo As New MarketingPromo
        Dim trimmed_existing_promoName As String = existing_promoName.Trim

        existing_promo = (From promo In tbl.MarketingPromos
                          Where promo.PromoName = trimmed_existing_promoName
                          Select promo)

        Return existing_promo
    End Function
#End Region

#Region "Existing_Coupon"
    'In the same way that we checked to see if there is an existing promo by checking its name,
    'we will check to see if there is an existing coupon by checking its couponID.
    Public Shared Function Existing_Coupon(ByVal new_couponID As String)
        Dim returningBool As Boolean = False
        Dim tbl As New MarketingPromosDataContext

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

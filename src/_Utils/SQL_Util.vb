#Region "COPYING"
'PromotionalCreationWizard
'Copyright (C) 2014-2016 Russell Dillin
'
'This file is part of PromotionalCreationWizard.

'   PromotionalCreationWizard is free software: you can redistribute it and/or
'   modify it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   PromotionalCreationWizard is distributed in the hope that it will be
'	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with PromotionalCreationWizard.
'	If not, see <http://www.gnu.org/licenses/>.
#End Region

''' <summary>
''' Global SQL class which handles queries.
''' </summary>
''' <remarks>SELECT ONLY!</remarks>
Public Class SQL_Util

#Region "Existing_Promo"
	''' <summary>
	''' Queries the name field to see if there is
	''' an existing promo with the same name.
	''' </summary>
	''' <param name="new_promoName">The name of the promo to query.</param>
	''' <returns>The existance of the promo name.</returns>
	''' <remarks>Why would anyone want to make a
	''' promotional which has already been made?</remarks>
	Public Shared Function Existing_Promo(ByVal new_promoName _
										  As String) _
										  As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As PCWLINQ2SQLDataContext = _
			New PCWLINQ2SQLDataContext(Global _
									   .PromotionalCreationWizard _
									   .My _
									   .MySettings _
									   .Default _
									   .GamingConnectionString)

		Dim trimmed_new_promoName As String = new_promoName.Trim
		Dim trimmed_new_promoName_entry As String = _
			"Entries - " & trimmed_new_promoName
		Dim trimmed_new_promoName_payout As String = _
			"Payouts - " & trimmed_new_promoName

		Dim existing_promoName_entry = ( _
			From name In tbl.MarketingPromos
			Where name.PromoName = trimmed_new_promoName_entry
			Select name.PromoName).FirstOrDefault
		Dim existing_promoName_payout = ( _
			From name In tbl.MarketingPromos
			Where name.PromoName = trimmed_new_promoName_payout
			Select name.PromoName).FirstOrDefault

		'Will be NULL (VB value of Nothing) if they are not the same;
		'however, if existing_promoName is not NULL, check to be sure.
		'No need to assume incorrectly.
		If (Not String.IsNullOrEmpty(existing_promoName_entry) OrElse _
			Not String.IsNullOrEmpty(existing_promoName_payout)) Then
			returningBool = True
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
	Public Shared Function Return_Existing_Promo(ByVal existing_promoName _
												 As String) _
												 As MarketingPromo
		Dim tbl As PCWLINQ2SQLDataContext = _
			New PCWLINQ2SQLDataContext(Global _
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
#Region "Existing_PromoID"
	''' <summary>
	''' Queries the ID field to see if there
	''' is an existing promo with the same ID.
	''' </summary>
	''' <param name="new_promoID"></param>
	''' <returns>The existance of the coupon ID.</returns>
	''' <remarks>This function is very similar to Existing_Promo.</remarks>
	Public Shared Function Existing_PromoID(ByVal new_promoID _
											As String) _
											As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As PCWLINQ2SQLDataContext = _
			New PCWLINQ2SQLDataContext(Global _
									   .PromotionalCreationWizard _
									   .My _
									   .MySettings _
									   .Default _
									   .GamingConnectionString)

		Dim trimmed_new_promoID As String = new_promoID.Trim
		Dim trimmed_new_promoID_entry As String = trimmed_new_promoID & "E"
		Dim trimmed_new_promoID_payout As String = trimmed_new_promoID & "P"

		Dim existing_promoID_entry = ( _
			From promoID In tbl.MarketingPromos
			Where promoID.PromoID = trimmed_new_promoID_entry
			Select promoID.PromoID).FirstOrDefault
		Dim existing_promoID_payout = ( _
			From promoID In tbl.MarketingPromos
			Where promoID.PromoID = trimmed_new_promoID_payout
			Select promoID.PromoID).FirstOrDefault

		If Not String.IsNullOrEmpty(existing_promoID_entry) Or
			Not String.IsNullOrEmpty(existing_promoID_payout) Then
			returningBool = True
		End If

		Return returningBool
	End Function
#End Region
#Region "Existing_Coupon"
	''' <summary>
	''' Queries the ID field to see if there
	''' is an existing coupon with the same ID.
	''' </summary>
	''' <param name="new_couponID"></param>
	''' <returns>The existance of the coupon ID.</returns>
	''' <remarks>This function is very
	''' similar to Existing_Promo.</remarks>
	Public Shared Function Existing_Coupon(ByVal new_couponID _
										   As String) _
										   As Boolean
		Dim returningBool As Boolean = False
		Dim tbl As PCWLINQ2SQLDataContext = _
			New PCWLINQ2SQLDataContext(Global _
									   .PromotionalCreationWizard _
									   .My _
									   .MySettings _
									   .Default _
									   .GamingConnectionString)

		Dim trimmed_new_couponID As String = new_couponID.Trim

		Dim existing_couponID = ( _
			From couponID In tbl.MarketingPromos
			Where couponID.CouponID = trimmed_new_couponID
			Select couponID.CouponID).FirstOrDefault

		If Not String.IsNullOrEmpty(existing_couponID) Then
			returningBool = True
		End If

		Return returningBool
	End Function
#End Region
End Class

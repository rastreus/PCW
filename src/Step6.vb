Imports TSWizards
Imports System.Xml
Imports System.Xml.Linq
Imports System.Text.RegularExpressions

Public Class Step6
    Inherits TSWizards.BaseInteriorStep

    Private Sub Step5_Validation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.ValidateStep

        If CouponID_Invalid() Then
            e.Cancel = True
            Me.Panel1.BackColor = Color.MistyRose
            Me.TextBox1.Text = ""
            Me.ActiveControl = Me.TextBox1
        Else
            Me.Panel1.BackColor = SystemColors.Control

            'If valid, make sure that the characters are uppercase.
            'The variables shouldn't be necessary, but VB.NET is weird about Strings.
            Dim couponID_Name As String = TextBox1.Text.Substring(0, TextBox1.Text.Length - 4)
            Dim couponID_Digits As String = TextBox1.Text.Substring(TextBox1.Text.Length - 4)
            Me.TextBox1.Text = couponID_Name.ToUpper & couponID_Digits
        End If

        If MaxCoupon_Invalid() Then
            e.Cancel = True
            Me.Panel2.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Max Coupon value is invalid. Must be a Decimal value i.e. 500.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox2.Text = ""
            Me.ActiveControl = Me.TextBox2
        Else
            Me.Panel2.BackColor = SystemColors.Control
        End If

        If PromoMaxCoupon_Invalid() Then
            e.Cancel = True
            Me.Panel3.BackColor = Color.MistyRose
            CenteredMessagebox.MsgBox.Show("The Promo Max Coupon value is invalid. Must be a Decimal value i.e. 15000.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox3.Text = ""
            Me.ActiveControl = Me.TextBox3
        Else
            If Not PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon() Then
                Me.Panel3.BackColor = SystemColors.Control
            End If
        End If

        'Make sure that the TextBoxes for MaxCoupon and PromoMaxCoupon are not empty strings
        If Not Invalid_Decimal(Me.TextBox2.Text) And Not Invalid_Decimal(Me.TextBox3.Text) Then
            If PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon() Then
                e.Cancel = True
                Me.Panel3.BackColor = Color.MistyRose
                CenteredMessagebox.MsgBox.Show("The Promo Max Coupon value is less than or equal to the Max Coupon value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TextBox3.Text = ""
                Me.ActiveControl = Me.TextBox3
            Else
                If Not PromoMaxCoupon_Invalid() Then
                    Me.Panel3.BackColor = SystemColors.Control
                End If
            End If
        End If

    End Sub

    Private Function PromoMaxCoupon_LessThan_Or_EqualTo_MaxCoupon()
        Dim invalid As Boolean = False

        If (Decimal.Parse(Me.TextBox3.Text) <= Decimal.Parse(Me.TextBox2.Text)) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function PromoMaxCoupon_Invalid()
        Dim invalid As Boolean = False

        If Invalid_Decimal(Me.TextBox3.Text) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function MaxCoupon_Invalid()
        Dim invalid As Boolean = False

        If Invalid_Decimal(Me.TextBox2.Text) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function CouponID_Invalid()
        Dim invalid As Boolean = False

        If Me.TextBox1.Text = "" Or Me.TextBox1.Text = "Enter ID Here" Or Invalid_CouponID(Me.TextBox1.Text) Or Me.TextBox1.Text.Length > 12 Then
            CenteredMessagebox.MsgBox.Show("The CouponID does not follow the standard format i.e. PROMO14XX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            invalid = True
        ElseIf Sql_Query.Existing_Coupon(Me.TextBox1.Text) Then
            CenteredMessagebox.MsgBox.Show("There is an existing coupon with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            invalid = True
        End If

        Return invalid
    End Function

    'Checks to see if the supplied CouponID matches the required pattern.
    'At the moment, it is a hard-limit of a 10 character abbreviation (possibly problematic).
    Private Function Invalid_CouponID(ByVal inputString As String)
        Dim invalid As Boolean = False
        Dim RegexObj As Regex = New Regex("^[a-zA-Z]{1,10}\d{4}$")

        If Not RegexObj.IsMatch(inputString) Then
            invalid = True
        End If

        Return invalid
    End Function

    'Checks to see if the supplied value is not 0
    'or if it is not 1 or more digit
    Private Function Invalid_Decimal(ByVal inputString As String)
        Dim invalid As Boolean = False
        Dim RegexObj As Regex = New Regex("^\d+\.\d{2}$")

        Try
            Dim inputDecimal As Decimal = Decimal.Parse(inputString)
            If (inputDecimal = 0.0) Or Not RegexObj.IsMatch(inputString) Then
                invalid = True
            End If
        Catch ex As Exception
            invalid = True
        End Try

        Return invalid
    End Function

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If Me.TextBox1.Text = "Enter ID Here" Then
            Me.TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If Me.TextBox2.Text = "Enter Decimal value Here" Then
            Me.TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        If Me.TextBox3.Text = "Enter Decimal value Here" Then
            Me.TextBox3.Text = ""
        End If
    End Sub

#Region "Step6_InfoCircle"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim infoString As String = <a>Copyright(c) Oaklawn Jockey Club, 2014

Brought to you by the fine folks of the OJC IT Department!</a>.Value

        CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

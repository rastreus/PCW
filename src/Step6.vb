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
            CenteredMessagebox.MsgBox.Show("The CouponID does not follow the standard format i.e. PROMO14XX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.TextBox1.Text = ""
            Me.ActiveControl = Me.TextBox1
        Else
            Me.Panel1.BackColor = SystemColors.Control
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
            Me.Panel3.BackColor = SystemColors.Control
        End If


    End Sub

    Private Function PromoMaxCoupon_Invalid()
        Dim invalid = False

        If Invalid_Decimal(Me.TextBox3.Text) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function MaxCoupon_Invalid()
        Dim invalid = False

        If Invalid_Decimal(Me.TextBox2.Text) Then
            invalid = True
        End If

        Return invalid
    End Function

    Private Function CouponID_Invalid()
        Dim invalid = False

        If Me.TextBox1.Text = "" Or Me.TextBox1.Text = "Enter ID Here" Or Invalid_CouponID(Me.TextBox1.Text) Then
            invalid = True
        End If

        Return invalid
    End Function

    'Checks to see if the supplied CouponID matches the required pattern.
    'At the moment, it is a hard-limit of a 10 character abbreviation (possibly problematic).
    Private Function Invalid_CouponID(ByVal inputString As String)
        Dim invalid As Boolean = False
        Dim RegexObj As Regex = New Regex("^\w{1,10}\d{4}$")

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

Brought to you by the fine folks of the OJC IT Department!

Please direct questions and concerns toward:
Russell Dillin
rdillin@oaklawn.com
x696</a>.Value

        CenteredMessagebox.MsgBox.Show(infoString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepF
	Inherits TSWizards.BaseInteriorStep

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.pnlPayout = New System.Windows.Forms.Panel()
		Me.pnlDEBUG = New System.Windows.Forms.Panel()
		Me.lblDEBUG = New System.Windows.Forms.Label()
		Me.pnlCashValue = New System.Windows.Forms.Panel()
		Me.txtCashValue = New System.Windows.Forms.TextBox()
		Me.lblMoney1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlPrize = New System.Windows.Forms.Panel()
		Me.txtPrize = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.rbFreePlayCoupon = New System.Windows.Forms.RadioButton()
		Me.rbRandomPrize = New System.Windows.Forms.RadioButton()
		Me.rbPrize = New System.Windows.Forms.RadioButton()
		Me.rbCashValue = New System.Windows.Forms.RadioButton()
		Me.pnlLavender = New System.Windows.Forms.Panel()
		Me.pnlPromoTypeForPayout = New System.Windows.Forms.Panel()
		Me.btnSetPromoType = New System.Windows.Forms.Button()
		Me.lblPromoTypeQuestion = New System.Windows.Forms.Label()
		Me.txtPromoType = New System.Windows.Forms.TextBox()
		Me.lblPromoType = New System.Windows.Forms.Label()
		Me.PromoTypeSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.pnlPayout.SuspendLayout()
		Me.pnlDEBUG.SuspendLayout()
		Me.pnlCashValue.SuspendLayout()
		Me.pnlPrize.SuspendLayout()
		Me.pnlPromoTypeForPayout.SuspendLayout()
		CType(Me.PromoTypeSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "This is where the category of the promo payout will be determined."
		'
		'pnlPayout
		'
		Me.pnlPayout.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPayout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPayout.Controls.Add(Me.pnlDEBUG)
		Me.pnlPayout.Controls.Add(Me.pnlCashValue)
		Me.pnlPayout.Controls.Add(Me.Label3)
		Me.pnlPayout.Controls.Add(Me.Label1)
		Me.pnlPayout.Controls.Add(Me.pnlPrize)
		Me.pnlPayout.Controls.Add(Me.Label2)
		Me.pnlPayout.Controls.Add(Me.rbFreePlayCoupon)
		Me.pnlPayout.Controls.Add(Me.rbRandomPrize)
		Me.pnlPayout.Controls.Add(Me.rbPrize)
		Me.pnlPayout.Controls.Add(Me.rbCashValue)
		Me.pnlPayout.Controls.Add(Me.pnlLavender)
		Me.pnlPayout.Location = New System.Drawing.Point(167, 63)
		Me.pnlPayout.Name = "pnlPayout"
		Me.pnlPayout.Size = New System.Drawing.Size(313, 197)
		Me.pnlPayout.TabIndex = 2
		'
		'pnlDEBUG
		'
		Me.pnlDEBUG.BackColor = System.Drawing.Color.Transparent
		Me.pnlDEBUG.Controls.Add(Me.lblDEBUG)
		Me.pnlDEBUG.Location = New System.Drawing.Point(14, 62)
		Me.pnlDEBUG.Name = "pnlDEBUG"
		Me.pnlDEBUG.Size = New System.Drawing.Size(279, 128)
		Me.pnlDEBUG.TabIndex = 16
		'
		'lblDEBUG
		'
		Me.lblDEBUG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDEBUG.ForeColor = System.Drawing.Color.Lavender
		Me.lblDEBUG.Location = New System.Drawing.Point(3, 51)
		Me.lblDEBUG.Name = "lblDEBUG"
		Me.lblDEBUG.Size = New System.Drawing.Size(273, 77)
		Me.lblDEBUG.TabIndex = 0
		Me.lblDEBUG.Text = "(More Options In Development)"
		Me.lblDEBUG.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlCashValue
		'
		Me.pnlCashValue.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlCashValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCashValue.Controls.Add(Me.txtCashValue)
		Me.pnlCashValue.Controls.Add(Me.lblMoney1)
		Me.pnlCashValue.Location = New System.Drawing.Point(149, 92)
		Me.pnlCashValue.Name = "pnlCashValue"
		Me.pnlCashValue.Size = New System.Drawing.Size(131, 36)
		Me.pnlCashValue.TabIndex = 9
		'
		'txtCashValue
		'
		Me.txtCashValue.Enabled = False
		Me.txtCashValue.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCashValue.Location = New System.Drawing.Point(18, 7)
		Me.txtCashValue.MaxLength = 6
		Me.txtCashValue.Name = "txtCashValue"
		Me.txtCashValue.Size = New System.Drawing.Size(106, 20)
		Me.txtCashValue.TabIndex = 7
		Me.txtCashValue.Text = "Enter Amt Here"
		'
		'lblMoney1
		'
		Me.lblMoney1.AutoSize = True
		Me.lblMoney1.BackColor = System.Drawing.Color.Transparent
		Me.lblMoney1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMoney1.Location = New System.Drawing.Point(4, 5)
		Me.lblMoney1.Name = "lblMoney1"
		Me.lblMoney1.Size = New System.Drawing.Size(18, 19)
		Me.lblMoney1.TabIndex = 11
		Me.lblMoney1.Text = "$"
		Me.lblMoney1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Lavender
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(104, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "...........|"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(311, 19)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "What form of Payout does the promo give?"
		'
		'pnlPrize
		'
		Me.pnlPrize.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlPrize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPrize.Controls.Add(Me.txtPrize)
		Me.pnlPrize.Location = New System.Drawing.Point(149, 134)
		Me.pnlPrize.Name = "pnlPrize"
		Me.pnlPrize.Size = New System.Drawing.Size(131, 36)
		Me.pnlPrize.TabIndex = 8
		'
		'txtPrize
		'
		Me.txtPrize.Enabled = False
		Me.txtPrize.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPrize.Location = New System.Drawing.Point(2, 6)
		Me.txtPrize.MaxLength = 23
		Me.txtPrize.Name = "txtPrize"
		Me.txtPrize.Size = New System.Drawing.Size(122, 20)
		Me.txtPrize.TabIndex = 7
		Me.txtPrize.Text = "Enter Prize Here"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Lavender
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(72, 144)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "......................|"
		'
		'rbFreePlayCoupon
		'
		Me.rbFreePlayCoupon.AutoSize = True
		Me.rbFreePlayCoupon.BackColor = System.Drawing.Color.Lavender
		Me.rbFreePlayCoupon.Checked = True
		Me.rbFreePlayCoupon.Location = New System.Drawing.Point(29, 34)
		Me.rbFreePlayCoupon.Name = "rbFreePlayCoupon"
		Me.rbFreePlayCoupon.Size = New System.Drawing.Size(106, 17)
		Me.rbFreePlayCoupon.TabIndex = 5
		Me.rbFreePlayCoupon.TabStop = True
		Me.rbFreePlayCoupon.Text = "FreePlay Coupon"
		Me.rbFreePlayCoupon.UseVisualStyleBackColor = False
		'
		'rbRandomPrize
		'
		Me.rbRandomPrize.AutoSize = True
		Me.rbRandomPrize.BackColor = System.Drawing.Color.Lavender
		Me.rbRandomPrize.Enabled = False
		Me.rbRandomPrize.Location = New System.Drawing.Point(29, 66)
		Me.rbRandomPrize.Name = "rbRandomPrize"
		Me.rbRandomPrize.Size = New System.Drawing.Size(91, 17)
		Me.rbRandomPrize.TabIndex = 4
		Me.rbRandomPrize.Text = "Random Prize"
		Me.rbRandomPrize.UseVisualStyleBackColor = False
		'
		'rbPrize
		'
		Me.rbPrize.AutoSize = True
		Me.rbPrize.BackColor = System.Drawing.Color.Lavender
		Me.rbPrize.Enabled = False
		Me.rbPrize.Location = New System.Drawing.Point(29, 143)
		Me.rbPrize.Name = "rbPrize"
		Me.rbPrize.Size = New System.Drawing.Size(48, 17)
		Me.rbPrize.TabIndex = 3
		Me.rbPrize.Text = "Prize"
		Me.rbPrize.UseVisualStyleBackColor = False
		'
		'rbCashValue
		'
		Me.rbCashValue.AutoSize = True
		Me.rbCashValue.BackColor = System.Drawing.Color.Lavender
		Me.rbCashValue.Enabled = False
		Me.rbCashValue.Location = New System.Drawing.Point(29, 103)
		Me.rbCashValue.Name = "rbCashValue"
		Me.rbCashValue.Size = New System.Drawing.Size(70, 17)
		Me.rbCashValue.TabIndex = 2
		Me.rbCashValue.Text = "Cash Amt"
		Me.rbCashValue.UseVisualStyleBackColor = False
		'
		'pnlLavender
		'
		Me.pnlLavender.BackColor = System.Drawing.Color.Lavender
		Me.pnlLavender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlLavender.Location = New System.Drawing.Point(14, 22)
		Me.pnlLavender.Name = "pnlLavender"
		Me.pnlLavender.Size = New System.Drawing.Size(279, 159)
		Me.pnlLavender.TabIndex = 11
		'
		'pnlPromoTypeForPayout
		'
		Me.pnlPromoTypeForPayout.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoTypeForPayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPromoTypeForPayout.Controls.Add(Me.PromoTypeSuccessIcon)
		Me.pnlPromoTypeForPayout.Controls.Add(Me.btnSetPromoType)
		Me.pnlPromoTypeForPayout.Controls.Add(Me.lblPromoTypeQuestion)
		Me.pnlPromoTypeForPayout.Controls.Add(Me.txtPromoType)
		Me.pnlPromoTypeForPayout.Controls.Add(Me.lblPromoType)
		Me.pnlPromoTypeForPayout.Location = New System.Drawing.Point(81, 63)
		Me.pnlPromoTypeForPayout.Name = "pnlPromoTypeForPayout"
		Me.pnlPromoTypeForPayout.Size = New System.Drawing.Size(80, 142)
		Me.pnlPromoTypeForPayout.TabIndex = 15
		'
		'btnSetPromoType
		'
		Me.btnSetPromoType.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetPromoType.Enabled = False
		Me.btnSetPromoType.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetPromoType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetPromoType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetPromoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetPromoType.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetPromoType.ForeColor = System.Drawing.Color.White
		Me.btnSetPromoType.Location = New System.Drawing.Point(3, 116)
		Me.btnSetPromoType.Name = "btnSetPromoType"
		Me.btnSetPromoType.Size = New System.Drawing.Size(44, 20)
		Me.btnSetPromoType.TabIndex = 34
		Me.btnSetPromoType.Text = "Set"
		Me.btnSetPromoType.UseVisualStyleBackColor = False
		'
		'lblPromoTypeQuestion
		'
		Me.lblPromoTypeQuestion.BackColor = System.Drawing.Color.Transparent
		Me.lblPromoTypeQuestion.ForeColor = System.Drawing.Color.White
		Me.lblPromoTypeQuestion.Location = New System.Drawing.Point(6, 41)
		Me.lblPromoTypeQuestion.Name = "lblPromoTypeQuestion"
		Me.lblPromoTypeQuestion.Size = New System.Drawing.Size(67, 41)
		Me.lblPromoTypeQuestion.TabIndex = 17
		Me.lblPromoTypeQuestion.Text = "What is the Payout's Type?"
		'
		'txtPromoType
		'
		Me.txtPromoType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPromoType.Location = New System.Drawing.Point(3, 87)
		Me.txtPromoType.MaxLength = 3
		Me.txtPromoType.Name = "txtPromoType"
		Me.txtPromoType.Size = New System.Drawing.Size(70, 23)
		Me.txtPromoType.TabIndex = 16
		Me.txtPromoType.Text = "EX: 31B"
		'
		'lblPromoType
		'
		Me.lblPromoType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoType.ForeColor = System.Drawing.Color.White
		Me.lblPromoType.Location = New System.Drawing.Point(3, 3)
		Me.lblPromoType.Name = "lblPromoType"
		Me.lblPromoType.Size = New System.Drawing.Size(70, 35)
		Me.lblPromoType.TabIndex = 15
		Me.lblPromoType.Text = "Promo Type:"
		'
		'PromoTypeSuccessIcon
		'
		Me.PromoTypeSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.PromoTypeSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.PromoTypeSuccessIcon.Enabled = False
		Me.PromoTypeSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.PromoTypeSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.PromoTypeSuccessIcon.Location = New System.Drawing.Point(53, 116)
		Me.PromoTypeSuccessIcon.Name = "PromoTypeSuccessIcon"
		Me.PromoTypeSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.PromoTypeSuccessIcon.TabIndex = 35
		Me.PromoTypeSuccessIcon.TabStop = False
		Me.PromoTypeSuccessIcon.ToolTipText = Nothing
		Me.PromoTypeSuccessIcon.Visible = False
		'
		'StepF
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlPromoTypeForPayout)
		Me.Controls.Add(Me.pnlPayout)
		Me.Name = "StepF"
		Me.NextStep = "StepGeneratePayoutCoupon"
		Me.PreviousStep = "StepEntryTicketAmt"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This is where the category of the promo payout will be determined."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlPayout, 0)
		Me.Controls.SetChildIndex(Me.pnlPromoTypeForPayout, 0)
		Me.pnlPayout.ResumeLayout(False)
		Me.pnlPayout.PerformLayout()
		Me.pnlDEBUG.ResumeLayout(False)
		Me.pnlCashValue.ResumeLayout(False)
		Me.pnlCashValue.PerformLayout()
		Me.pnlPrize.ResumeLayout(False)
		Me.pnlPrize.PerformLayout()
		Me.pnlPromoTypeForPayout.ResumeLayout(False)
		Me.pnlPromoTypeForPayout.PerformLayout()
		CType(Me.PromoTypeSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlPayout As System.Windows.Forms.Panel
	Friend WithEvents txtPrize As System.Windows.Forms.TextBox
	Friend WithEvents rbFreePlayCoupon As System.Windows.Forms.RadioButton
	Friend WithEvents rbRandomPrize As System.Windows.Forms.RadioButton
	Friend WithEvents rbPrize As System.Windows.Forms.RadioButton
	Friend WithEvents rbCashValue As System.Windows.Forms.RadioButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents pnlCashValue As System.Windows.Forms.Panel
	Friend WithEvents txtCashValue As System.Windows.Forms.TextBox
	Friend WithEvents pnlPrize As System.Windows.Forms.Panel
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents pnlLavender As System.Windows.Forms.Panel
	Friend WithEvents lblMoney1 As System.Windows.Forms.Label
	Friend WithEvents pnlPromoTypeForPayout As System.Windows.Forms.Panel
	Friend WithEvents lblPromoTypeQuestion As System.Windows.Forms.Label
	Friend WithEvents txtPromoType As System.Windows.Forms.TextBox
	Friend WithEvents lblPromoType As System.Windows.Forms.Label
	Private WithEvents btnSetPromoType As System.Windows.Forms.Button
	Friend WithEvents pnlDEBUG As System.Windows.Forms.Panel
	Friend WithEvents lblDEBUG As System.Windows.Forms.Label
	Private WithEvents PromoTypeSuccessIcon As FontAwesomeIcons.IconButton

End Class

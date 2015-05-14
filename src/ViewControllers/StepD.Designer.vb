<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepD
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
		Me.pnlPromoType = New System.Windows.Forms.Panel()
		Me.rbSinglePayoutOnly = New System.Windows.Forms.RadioButton()
		Me.rbSingleEntryPayout = New System.Windows.Forms.RadioButton()
		Me.rbMultiPartEntryPayout = New System.Windows.Forms.RadioButton()
		Me.rbAcquisition = New System.Windows.Forms.RadioButton()
		Me.rbSingleEntryOnly = New System.Windows.Forms.RadioButton()
		Me.lblPromoType = New System.Windows.Forms.Label()
		Me.pnlSingleEvent = New System.Windows.Forms.Panel()
		Me.pnlMultiPart = New System.Windows.Forms.Panel()
		Me.txtNumOfDaysTiers = New System.Windows.Forms.TextBox()
		Me.pnlAcquisition = New System.Windows.Forms.Panel()
		Me.pnlPlayerEligibility = New System.Windows.Forms.Panel()
		Me.pnlSumMethod = New System.Windows.Forms.Panel()
		Me.rbEligiblePlayersOfferList = New System.Windows.Forms.RadioButton()
		Me.rbSumQualifyingPoints = New System.Windows.Forms.RadioButton()
		Me.rbSumLifetimePoints = New System.Windows.Forms.RadioButton()
		Me.rbAutoQualification = New System.Windows.Forms.RadioButton()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.lblPlayerEligibility = New System.Windows.Forms.Label()
		Me.pnlDragOffer = New System.Windows.Forms.Panel()
		Me.SuccessIcon = New FontAwesomeIcons.IconButton()
		Me.lblDragOffer = New System.Windows.Forms.Label()
		Me.pnlPointCutoffLimit = New System.Windows.Forms.Panel()
		Me.txtPointCutoffLimit = New System.Windows.Forms.TextBox()
		Me.rbPointCutoffLimitNO = New System.Windows.Forms.RadioButton()
		Me.rbPointCutoffLimitYES = New System.Windows.Forms.RadioButton()
		Me.lblPointCutoffLimit = New System.Windows.Forms.Label()
		Me.pnlPromoType.SuspendLayout()
		Me.pnlMultiPart.SuspendLayout()
		Me.pnlPlayerEligibility.SuspendLayout()
		Me.pnlSumMethod.SuspendLayout()
		Me.pnlDragOffer.SuspendLayout()
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlPointCutoffLimit.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Of the five available types, which will this promo be?"
		'
		'pnlPromoType
		'
		Me.pnlPromoType.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPromoType.Controls.Add(Me.rbSinglePayoutOnly)
		Me.pnlPromoType.Controls.Add(Me.rbSingleEntryPayout)
		Me.pnlPromoType.Controls.Add(Me.rbMultiPartEntryPayout)
		Me.pnlPromoType.Controls.Add(Me.rbAcquisition)
		Me.pnlPromoType.Controls.Add(Me.rbSingleEntryOnly)
		Me.pnlPromoType.Controls.Add(Me.lblPromoType)
		Me.pnlPromoType.Controls.Add(Me.pnlSingleEvent)
		Me.pnlPromoType.Controls.Add(Me.pnlMultiPart)
		Me.pnlPromoType.Controls.Add(Me.pnlAcquisition)
		Me.pnlPromoType.Location = New System.Drawing.Point(24, 34)
		Me.pnlPromoType.Name = "pnlPromoType"
		Me.pnlPromoType.Size = New System.Drawing.Size(259, 238)
		Me.pnlPromoType.TabIndex = 3
		'
		'rbSinglePayoutOnly
		'
		Me.rbSinglePayoutOnly.AutoSize = True
		Me.rbSinglePayoutOnly.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSinglePayoutOnly.Location = New System.Drawing.Point(7, 77)
		Me.rbSinglePayoutOnly.Name = "rbSinglePayoutOnly"
		Me.rbSinglePayoutOnly.Size = New System.Drawing.Size(148, 17)
		Me.rbSinglePayoutOnly.TabIndex = 11
		Me.rbSinglePayoutOnly.Text = "Single Event: Payout Only"
		Me.rbSinglePayoutOnly.UseVisualStyleBackColor = False
		'
		'rbSingleEntryPayout
		'
		Me.rbSingleEntryPayout.AutoSize = True
		Me.rbSingleEntryPayout.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSingleEntryPayout.Checked = True
		Me.rbSingleEntryPayout.Location = New System.Drawing.Point(7, 31)
		Me.rbSingleEntryPayout.Name = "rbSingleEntryPayout"
		Me.rbSingleEntryPayout.Size = New System.Drawing.Size(172, 17)
		Me.rbSingleEntryPayout.TabIndex = 10
		Me.rbSingleEntryPayout.TabStop = True
		Me.rbSingleEntryPayout.Text = "Single Event: Entry and Payout"
		Me.rbSingleEntryPayout.UseVisualStyleBackColor = False
		'
		'rbMultiPartEntryPayout
		'
		Me.rbMultiPartEntryPayout.AutoSize = True
		Me.rbMultiPartEntryPayout.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbMultiPartEntryPayout.Location = New System.Drawing.Point(7, 112)
		Me.rbMultiPartEntryPayout.Name = "rbMultiPartEntryPayout"
		Me.rbMultiPartEntryPayout.Size = New System.Drawing.Size(240, 17)
		Me.rbMultiPartEntryPayout.TabIndex = 8
		Me.rbMultiPartEntryPayout.Text = "Multi-Part Sequential Event: Entry and Payout"
		Me.rbMultiPartEntryPayout.UseVisualStyleBackColor = False
		'
		'rbAcquisition
		'
		Me.rbAcquisition.AutoSize = True
		Me.rbAcquisition.BackColor = System.Drawing.Color.Lavender
		Me.rbAcquisition.Enabled = False
		Me.rbAcquisition.Location = New System.Drawing.Point(7, 184)
		Me.rbAcquisition.Name = "rbAcquisition"
		Me.rbAcquisition.Size = New System.Drawing.Size(76, 17)
		Me.rbAcquisition.TabIndex = 6
		Me.rbAcquisition.Text = "Acquisition"
		Me.rbAcquisition.UseVisualStyleBackColor = False
		'
		'rbSingleEntryOnly
		'
		Me.rbSingleEntryOnly.AutoSize = True
		Me.rbSingleEntryOnly.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSingleEntryOnly.Location = New System.Drawing.Point(7, 54)
		Me.rbSingleEntryOnly.Name = "rbSingleEntryOnly"
		Me.rbSingleEntryOnly.Size = New System.Drawing.Size(139, 17)
		Me.rbSingleEntryOnly.TabIndex = 5
		Me.rbSingleEntryOnly.Text = "Single Event: Entry Only"
		Me.rbSingleEntryOnly.UseVisualStyleBackColor = False
		'
		'lblPromoType
		'
		Me.lblPromoType.AutoSize = True
		Me.lblPromoType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoType.ForeColor = System.Drawing.Color.White
		Me.lblPromoType.Location = New System.Drawing.Point(0, 0)
		Me.lblPromoType.Name = "lblPromoType"
		Me.lblPromoType.Size = New System.Drawing.Size(205, 16)
		Me.lblPromoType.TabIndex = 3
		Me.lblPromoType.Text = "What category is the promo?"
		'
		'pnlSingleEvent
		'
		Me.pnlSingleEvent.BackColor = System.Drawing.Color.Aquamarine
		Me.pnlSingleEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlSingleEvent.Location = New System.Drawing.Point(3, 23)
		Me.pnlSingleEvent.Name = "pnlSingleEvent"
		Me.pnlSingleEvent.Size = New System.Drawing.Size(251, 78)
		Me.pnlSingleEvent.TabIndex = 12
		'
		'pnlMultiPart
		'
		Me.pnlMultiPart.BackColor = System.Drawing.Color.PaleTurquoise
		Me.pnlMultiPart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMultiPart.Controls.Add(Me.txtNumOfDaysTiers)
		Me.pnlMultiPart.Location = New System.Drawing.Point(3, 107)
		Me.pnlMultiPart.Name = "pnlMultiPart"
		Me.pnlMultiPart.Size = New System.Drawing.Size(251, 57)
		Me.pnlMultiPart.TabIndex = 13
		'
		'txtNumOfDaysTiers
		'
		Me.txtNumOfDaysTiers.BackColor = System.Drawing.SystemColors.HighlightText
		Me.txtNumOfDaysTiers.Enabled = False
		Me.txtNumOfDaysTiers.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumOfDaysTiers.Location = New System.Drawing.Point(26, 26)
		Me.txtNumOfDaysTiers.MaxLength = 2
		Me.txtNumOfDaysTiers.Name = "txtNumOfDaysTiers"
		Me.txtNumOfDaysTiers.Size = New System.Drawing.Size(115, 20)
		Me.txtNumOfDaysTiers.TabIndex = 9
		Me.txtNumOfDaysTiers.Text = "# of days/tiers?"
		'
		'pnlAcquisition
		'
		Me.pnlAcquisition.BackColor = System.Drawing.Color.Lavender
		Me.pnlAcquisition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlAcquisition.Location = New System.Drawing.Point(3, 170)
		Me.pnlAcquisition.Name = "pnlAcquisition"
		Me.pnlAcquisition.Size = New System.Drawing.Size(251, 43)
		Me.pnlAcquisition.TabIndex = 14
		'
		'pnlPlayerEligibility
		'
		Me.pnlPlayerEligibility.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPlayerEligibility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlSumMethod)
		Me.pnlPlayerEligibility.Controls.Add(Me.lblPlayerEligibility)
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlDragOffer)
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlPointCutoffLimit)
		Me.pnlPlayerEligibility.Location = New System.Drawing.Point(290, 34)
		Me.pnlPlayerEligibility.Name = "pnlPlayerEligibility"
		Me.pnlPlayerEligibility.Size = New System.Drawing.Size(265, 238)
		Me.pnlPlayerEligibility.TabIndex = 4
		'
		'pnlSumMethod
		'
		Me.pnlSumMethod.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlSumMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlSumMethod.Controls.Add(Me.rbEligiblePlayersOfferList)
		Me.pnlSumMethod.Controls.Add(Me.rbSumQualifyingPoints)
		Me.pnlSumMethod.Controls.Add(Me.rbSumLifetimePoints)
		Me.pnlSumMethod.Controls.Add(Me.rbAutoQualification)
		Me.pnlSumMethod.Controls.Add(Me.Panel7)
		Me.pnlSumMethod.Location = New System.Drawing.Point(3, 22)
		Me.pnlSumMethod.Name = "pnlSumMethod"
		Me.pnlSumMethod.Size = New System.Drawing.Size(255, 120)
		Me.pnlSumMethod.TabIndex = 10
		'
		'rbEligiblePlayersOfferList
		'
		Me.rbEligiblePlayersOfferList.AutoSize = True
		Me.rbEligiblePlayersOfferList.BackColor = System.Drawing.Color.LemonChiffon
		Me.rbEligiblePlayersOfferList.Location = New System.Drawing.Point(3, 93)
		Me.rbEligiblePlayersOfferList.Name = "rbEligiblePlayersOfferList"
		Me.rbEligiblePlayersOfferList.Size = New System.Drawing.Size(192, 17)
		Me.rbEligiblePlayersOfferList.TabIndex = 8
		Me.rbEligiblePlayersOfferList.Text = "Target List Determines Qualification"
		Me.rbEligiblePlayersOfferList.UseVisualStyleBackColor = False
		'
		'rbSumQualifyingPoints
		'
		Me.rbSumQualifyingPoints.AutoSize = True
		Me.rbSumQualifyingPoints.Checked = True
		Me.rbSumQualifyingPoints.Location = New System.Drawing.Point(3, 9)
		Me.rbSumQualifyingPoints.Name = "rbSumQualifyingPoints"
		Me.rbSumQualifyingPoints.Size = New System.Drawing.Size(193, 17)
		Me.rbSumQualifyingPoints.TabIndex = 5
		Me.rbSumQualifyingPoints.TabStop = True
		Me.rbSumQualifyingPoints.Text = "Sum Points Within Qualifying Peroid"
		Me.rbSumQualifyingPoints.UseVisualStyleBackColor = True
		'
		'rbSumLifetimePoints
		'
		Me.rbSumLifetimePoints.AutoSize = True
		Me.rbSumLifetimePoints.Location = New System.Drawing.Point(3, 32)
		Me.rbSumLifetimePoints.Name = "rbSumLifetimePoints"
		Me.rbSumLifetimePoints.Size = New System.Drawing.Size(117, 17)
		Me.rbSumLifetimePoints.TabIndex = 6
		Me.rbSumLifetimePoints.Text = "Sum Lifetime Points"
		Me.rbSumLifetimePoints.UseVisualStyleBackColor = True
		'
		'rbAutoQualification
		'
		Me.rbAutoQualification.AutoSize = True
		Me.rbAutoQualification.Location = New System.Drawing.Point(3, 55)
		Me.rbAutoQualification.Name = "rbAutoQualification"
		Me.rbAutoQualification.Size = New System.Drawing.Size(233, 17)
		Me.rbAutoQualification.TabIndex = 7
		Me.rbAutoQualification.Text = "Automatic Qualification Regardless of Points"
		Me.rbAutoQualification.UseVisualStyleBackColor = True
		'
		'Panel7
		'
		Me.Panel7.BackColor = System.Drawing.Color.LemonChiffon
		Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel7.Location = New System.Drawing.Point(-2, 83)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(255, 35)
		Me.Panel7.TabIndex = 11
		'
		'lblPlayerEligibility
		'
		Me.lblPlayerEligibility.AutoSize = True
		Me.lblPlayerEligibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlayerEligibility.ForeColor = System.Drawing.Color.White
		Me.lblPlayerEligibility.Location = New System.Drawing.Point(0, 0)
		Me.lblPlayerEligibility.Name = "lblPlayerEligibility"
		Me.lblPlayerEligibility.Size = New System.Drawing.Size(259, 16)
		Me.lblPlayerEligibility.TabIndex = 4
		Me.lblPlayerEligibility.Text = "How is player eligibility determined?"
		'
		'pnlDragOffer
		'
		Me.pnlDragOffer.AllowDrop = True
		Me.pnlDragOffer.BackColor = System.Drawing.Color.LemonChiffon
		Me.pnlDragOffer.Controls.Add(Me.SuccessIcon)
		Me.pnlDragOffer.Controls.Add(Me.lblDragOffer)
		Me.pnlDragOffer.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pnlDragOffer.Enabled = False
		Me.pnlDragOffer.Location = New System.Drawing.Point(18, 148)
		Me.pnlDragOffer.Name = "pnlDragOffer"
		Me.pnlDragOffer.Size = New System.Drawing.Size(224, 80)
		Me.pnlDragOffer.TabIndex = 9
		Me.pnlDragOffer.Visible = False
		'
		'SuccessIcon
		'
		Me.SuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.SuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.SuccessIcon.Enabled = False
		Me.SuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.SuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.SuccessIcon.Location = New System.Drawing.Point(187, 4)
		Me.SuccessIcon.Name = "SuccessIcon"
		Me.SuccessIcon.Size = New System.Drawing.Size(24, 24)
		Me.SuccessIcon.TabIndex = 5
		Me.SuccessIcon.TabStop = False
		Me.SuccessIcon.ToolTipText = Nothing
		Me.SuccessIcon.Visible = False
		'
		'lblDragOffer
		'
		Me.lblDragOffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDragOffer.Location = New System.Drawing.Point(7, 4)
		Me.lblDragOffer.Name = "lblDragOffer"
		Me.lblDragOffer.Size = New System.Drawing.Size(173, 21)
		Me.lblDragOffer.TabIndex = 0
		Me.lblDragOffer.Text = "(Drag Offer List .CSV File Here)"
		Me.lblDragOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlPointCutoffLimit
		'
		Me.pnlPointCutoffLimit.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlPointCutoffLimit.Controls.Add(Me.txtPointCutoffLimit)
		Me.pnlPointCutoffLimit.Controls.Add(Me.rbPointCutoffLimitNO)
		Me.pnlPointCutoffLimit.Controls.Add(Me.rbPointCutoffLimitYES)
		Me.pnlPointCutoffLimit.Controls.Add(Me.lblPointCutoffLimit)
		Me.pnlPointCutoffLimit.Location = New System.Drawing.Point(18, 148)
		Me.pnlPointCutoffLimit.Name = "pnlPointCutoffLimit"
		Me.pnlPointCutoffLimit.Size = New System.Drawing.Size(224, 80)
		Me.pnlPointCutoffLimit.TabIndex = 9
		'
		'txtPointCutoffLimit
		'
		Me.txtPointCutoffLimit.Enabled = False
		Me.txtPointCutoffLimit.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPointCutoffLimit.Location = New System.Drawing.Point(53, 40)
		Me.txtPointCutoffLimit.MaxLength = 10
		Me.txtPointCutoffLimit.Name = "txtPointCutoffLimit"
		Me.txtPointCutoffLimit.Size = New System.Drawing.Size(143, 23)
		Me.txtPointCutoffLimit.TabIndex = 10
		Me.txtPointCutoffLimit.Text = "Enter # Here"
		'
		'rbPointCutoffLimitNO
		'
		Me.rbPointCutoffLimitNO.AutoSize = True
		Me.rbPointCutoffLimitNO.Checked = True
		Me.rbPointCutoffLimitNO.Location = New System.Drawing.Point(4, 61)
		Me.rbPointCutoffLimitNO.Name = "rbPointCutoffLimitNO"
		Me.rbPointCutoffLimitNO.Size = New System.Drawing.Size(39, 17)
		Me.rbPointCutoffLimitNO.TabIndex = 9
		Me.rbPointCutoffLimitNO.TabStop = True
		Me.rbPointCutoffLimitNO.Text = "No"
		Me.rbPointCutoffLimitNO.UseVisualStyleBackColor = True
		'
		'rbPointCutoffLimitYES
		'
		Me.rbPointCutoffLimitYES.AutoSize = True
		Me.rbPointCutoffLimitYES.Location = New System.Drawing.Point(4, 41)
		Me.rbPointCutoffLimitYES.Name = "rbPointCutoffLimitYES"
		Me.rbPointCutoffLimitYES.Size = New System.Drawing.Size(43, 17)
		Me.rbPointCutoffLimitYES.TabIndex = 8
		Me.rbPointCutoffLimitYES.Text = "Yes"
		Me.rbPointCutoffLimitYES.UseVisualStyleBackColor = True
		'
		'lblPointCutoffLimit
		'
		Me.lblPointCutoffLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPointCutoffLimit.Location = New System.Drawing.Point(4, 0)
		Me.lblPointCutoffLimit.Name = "lblPointCutoffLimit"
		Me.lblPointCutoffLimit.Size = New System.Drawing.Size(235, 37)
		Me.lblPointCutoffLimit.TabIndex = 7
		Me.lblPointCutoffLimit.Text = "Is there a Point Cutoff limit in order to qualify for the promo?"
		'
		'StepD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlPlayerEligibility)
		Me.Controls.Add(Me.pnlPromoType)
		Me.Name = "StepD"
		Me.NextStep = "StepEntryTicketAmt"
		Me.PreviousStep = "StepCanHazSecurity"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Of the five available types, which will this promo be?"
		Me.Controls.SetChildIndex(Me.pnlPromoType, 0)
		Me.Controls.SetChildIndex(Me.pnlPlayerEligibility, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.pnlPromoType.ResumeLayout(False)
		Me.pnlPromoType.PerformLayout()
		Me.pnlMultiPart.ResumeLayout(False)
		Me.pnlMultiPart.PerformLayout()
		Me.pnlPlayerEligibility.ResumeLayout(False)
		Me.pnlPlayerEligibility.PerformLayout()
		Me.pnlSumMethod.ResumeLayout(False)
		Me.pnlSumMethod.PerformLayout()
		Me.pnlDragOffer.ResumeLayout(False)
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlPointCutoffLimit.ResumeLayout(False)
		Me.pnlPointCutoffLimit.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlPromoType As System.Windows.Forms.Panel
	Friend WithEvents rbSingleEntryPayout As System.Windows.Forms.RadioButton
	Friend WithEvents txtNumOfDaysTiers As System.Windows.Forms.TextBox
	Friend WithEvents rbMultiPartEntryPayout As System.Windows.Forms.RadioButton
	Friend WithEvents rbAcquisition As System.Windows.Forms.RadioButton
	Friend WithEvents rbSingleEntryOnly As System.Windows.Forms.RadioButton
	Friend WithEvents lblPromoType As System.Windows.Forms.Label
	Friend WithEvents rbSinglePayoutOnly As System.Windows.Forms.RadioButton
	Friend WithEvents pnlSingleEvent As System.Windows.Forms.Panel
	Friend WithEvents pnlMultiPart As System.Windows.Forms.Panel
	Friend WithEvents pnlAcquisition As System.Windows.Forms.Panel
	Friend WithEvents pnlPlayerEligibility As System.Windows.Forms.Panel
	Friend WithEvents lblPlayerEligibility As System.Windows.Forms.Label
	Friend WithEvents rbEligiblePlayersOfferList As System.Windows.Forms.RadioButton
	Friend WithEvents rbAutoQualification As System.Windows.Forms.RadioButton
	Friend WithEvents rbSumLifetimePoints As System.Windows.Forms.RadioButton
	Friend WithEvents rbSumQualifyingPoints As System.Windows.Forms.RadioButton
	Friend WithEvents pnlDragOffer As System.Windows.Forms.Panel
	Friend WithEvents lblDragOffer As System.Windows.Forms.Label
	Friend WithEvents SuccessIcon As FontAwesomeIcons.IconButton
	Friend WithEvents pnlPointCutoffLimit As System.Windows.Forms.Panel
	Friend WithEvents txtPointCutoffLimit As System.Windows.Forms.TextBox
	Friend WithEvents rbPointCutoffLimitNO As System.Windows.Forms.RadioButton
	Friend WithEvents rbPointCutoffLimitYES As System.Windows.Forms.RadioButton
	Friend WithEvents lblPointCutoffLimit As System.Windows.Forms.Label
	Friend WithEvents pnlSumMethod As System.Windows.Forms.Panel
	Friend WithEvents Panel7 As System.Windows.Forms.Panel

End Class

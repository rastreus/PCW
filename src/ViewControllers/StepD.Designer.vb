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
		Me.pnlDaysTiers = New System.Windows.Forms.Panel()
		Me.TiersSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetNumOfTiers = New System.Windows.Forms.Button()
		Me.lblNumOfDays = New System.Windows.Forms.Label()
		Me.rbTIERS = New System.Windows.Forms.RadioButton()
		Me.rbDAYS = New System.Windows.Forms.RadioButton()
		Me.txtNumOfTiers = New System.Windows.Forms.TextBox()
		Me.pnlPayoutParameters = New System.Windows.Forms.Panel()
		Me.cbPayoutParametersYES = New System.Windows.Forms.CheckBox()
		Me.lblPaymentParameters = New System.Windows.Forms.Label()
		Me.pnlAcquisition = New System.Windows.Forms.Panel()
		Me.lblSTILLINDEVELOPMENT = New System.Windows.Forms.Label()
		Me.pnlPlayerEligibility = New System.Windows.Forms.Panel()
		Me.pnlSumMethod = New System.Windows.Forms.Panel()
		Me.rbEligiblePlayersList = New System.Windows.Forms.RadioButton()
		Me.rbSumQualifyingPoints = New System.Windows.Forms.RadioButton()
		Me.rbSumLifetimePoints = New System.Windows.Forms.RadioButton()
		Me.rbAutoQualification = New System.Windows.Forms.RadioButton()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.lblPlayerEligibility = New System.Windows.Forms.Label()
		Me.pnlPointCutoffLimit = New System.Windows.Forms.Panel()
		Me.PointCutoffLimitSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetPointCutoffLimit = New System.Windows.Forms.Button()
		Me.txtPointCutoffLimit = New System.Windows.Forms.TextBox()
		Me.rbPointCutoffLimitNO = New System.Windows.Forms.RadioButton()
		Me.rbPointCutoffLimitYES = New System.Windows.Forms.RadioButton()
		Me.lblPointCutoffLimit = New System.Windows.Forms.Label()
		Me.pnlLemonChiffon = New System.Windows.Forms.Panel()
		Me.btnOpenPanel = New System.Windows.Forms.Button()
		Me.stepD_DDEP = New PromotionalCreationWizard.DDEP()
		Me.pnlPromoType.SuspendLayout()
		Me.pnlMultiPart.SuspendLayout()
		Me.pnlDaysTiers.SuspendLayout()
		CType(Me.TiersSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlPayoutParameters.SuspendLayout()
		Me.pnlAcquisition.SuspendLayout()
		Me.pnlPlayerEligibility.SuspendLayout()
		Me.pnlSumMethod.SuspendLayout()
		Me.pnlPointCutoffLimit.SuspendLayout()
		CType(Me.PointCutoffLimitSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLemonChiffon.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Of the five available categories, which will this promo be?"
		'
		'pnlPromoType
		'
		Me.pnlPromoType.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPromoType.CausesValidation = False
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
		Me.pnlPromoType.TabIndex = 0
		'
		'rbSinglePayoutOnly
		'
		Me.rbSinglePayoutOnly.AutoSize = True
		Me.rbSinglePayoutOnly.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSinglePayoutOnly.CausesValidation = False
		Me.rbSinglePayoutOnly.Location = New System.Drawing.Point(7, 77)
		Me.rbSinglePayoutOnly.Name = "rbSinglePayoutOnly"
		Me.rbSinglePayoutOnly.Size = New System.Drawing.Size(148, 17)
		Me.rbSinglePayoutOnly.TabIndex = 3
		Me.rbSinglePayoutOnly.TabStop = True
		Me.rbSinglePayoutOnly.Text = "Single Event: Payout Only"
		Me.rbSinglePayoutOnly.UseMnemonic = False
		Me.rbSinglePayoutOnly.UseVisualStyleBackColor = False
		'
		'rbSingleEntryPayout
		'
		Me.rbSingleEntryPayout.AutoSize = True
		Me.rbSingleEntryPayout.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSingleEntryPayout.CausesValidation = False
		Me.rbSingleEntryPayout.Checked = True
		Me.rbSingleEntryPayout.Location = New System.Drawing.Point(7, 31)
		Me.rbSingleEntryPayout.Name = "rbSingleEntryPayout"
		Me.rbSingleEntryPayout.Size = New System.Drawing.Size(172, 17)
		Me.rbSingleEntryPayout.TabIndex = 1
		Me.rbSingleEntryPayout.TabStop = True
		Me.rbSingleEntryPayout.Text = "Single Event: Entry and Payout"
		Me.rbSingleEntryPayout.UseMnemonic = False
		Me.rbSingleEntryPayout.UseVisualStyleBackColor = False
		'
		'rbMultiPartEntryPayout
		'
		Me.rbMultiPartEntryPayout.AutoSize = True
		Me.rbMultiPartEntryPayout.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbMultiPartEntryPayout.CausesValidation = False
		Me.rbMultiPartEntryPayout.Location = New System.Drawing.Point(7, 112)
		Me.rbMultiPartEntryPayout.Name = "rbMultiPartEntryPayout"
		Me.rbMultiPartEntryPayout.Size = New System.Drawing.Size(245, 17)
		Me.rbMultiPartEntryPayout.TabIndex = 4
		Me.rbMultiPartEntryPayout.TabStop = True
		Me.rbMultiPartEntryPayout.Text = "Multi-Part Sequential Event: Entry and Payouts"
		Me.rbMultiPartEntryPayout.UseMnemonic = False
		Me.rbMultiPartEntryPayout.UseVisualStyleBackColor = False
		'
		'rbAcquisition
		'
		Me.rbAcquisition.AutoSize = True
		Me.rbAcquisition.BackColor = System.Drawing.Color.Lavender
		Me.rbAcquisition.CausesValidation = False
		Me.rbAcquisition.Enabled = False
		Me.rbAcquisition.Location = New System.Drawing.Point(7, 205)
		Me.rbAcquisition.Name = "rbAcquisition"
		Me.rbAcquisition.Size = New System.Drawing.Size(76, 17)
		Me.rbAcquisition.TabIndex = 5
		Me.rbAcquisition.TabStop = True
		Me.rbAcquisition.Text = "Acquisition"
		Me.rbAcquisition.UseMnemonic = False
		Me.rbAcquisition.UseVisualStyleBackColor = False
		'
		'rbSingleEntryOnly
		'
		Me.rbSingleEntryOnly.AutoSize = True
		Me.rbSingleEntryOnly.BackColor = System.Drawing.Color.Aquamarine
		Me.rbSingleEntryOnly.CausesValidation = False
		Me.rbSingleEntryOnly.Location = New System.Drawing.Point(7, 54)
		Me.rbSingleEntryOnly.Name = "rbSingleEntryOnly"
		Me.rbSingleEntryOnly.Size = New System.Drawing.Size(139, 17)
		Me.rbSingleEntryOnly.TabIndex = 2
		Me.rbSingleEntryOnly.TabStop = True
		Me.rbSingleEntryOnly.Text = "Single Event: Entry Only"
		Me.rbSingleEntryOnly.UseMnemonic = False
		Me.rbSingleEntryOnly.UseVisualStyleBackColor = False
		'
		'lblPromoType
		'
		Me.lblPromoType.AutoSize = True
		Me.lblPromoType.CausesValidation = False
		Me.lblPromoType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoType.ForeColor = System.Drawing.Color.White
		Me.lblPromoType.Location = New System.Drawing.Point(0, 0)
		Me.lblPromoType.Name = "lblPromoType"
		Me.lblPromoType.Size = New System.Drawing.Size(205, 16)
		Me.lblPromoType.TabIndex = 0
		Me.lblPromoType.Text = "What category is the promo?"
		Me.lblPromoType.UseMnemonic = False
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
		Me.pnlMultiPart.Controls.Add(Me.pnlDaysTiers)
		Me.pnlMultiPart.Controls.Add(Me.pnlPayoutParameters)
		Me.pnlMultiPart.Location = New System.Drawing.Point(3, 107)
		Me.pnlMultiPart.Name = "pnlMultiPart"
		Me.pnlMultiPart.Size = New System.Drawing.Size(251, 78)
		Me.pnlMultiPart.TabIndex = 13
		'
		'pnlDaysTiers
		'
		Me.pnlDaysTiers.BackColor = System.Drawing.Color.LightBlue
		Me.pnlDaysTiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDaysTiers.CausesValidation = False
		Me.pnlDaysTiers.Controls.Add(Me.TiersSuccessIcon)
		Me.pnlDaysTiers.Controls.Add(Me.btnSetNumOfTiers)
		Me.pnlDaysTiers.Controls.Add(Me.lblNumOfDays)
		Me.pnlDaysTiers.Controls.Add(Me.rbTIERS)
		Me.pnlDaysTiers.Controls.Add(Me.rbDAYS)
		Me.pnlDaysTiers.Controls.Add(Me.txtNumOfTiers)
		Me.pnlDaysTiers.Enabled = False
		Me.pnlDaysTiers.Location = New System.Drawing.Point(6, 26)
		Me.pnlDaysTiers.Name = "pnlDaysTiers"
		Me.pnlDaysTiers.Size = New System.Drawing.Size(171, 45)
		Me.pnlDaysTiers.TabIndex = 0
		'
		'TiersSuccessIcon
		'
		Me.TiersSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.TiersSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.TiersSuccessIcon.Enabled = False
		Me.TiersSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.TiersSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.TiersSuccessIcon.Location = New System.Drawing.Point(146, 20)
		Me.TiersSuccessIcon.Name = "TiersSuccessIcon"
		Me.TiersSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.TiersSuccessIcon.TabIndex = 37
		Me.TiersSuccessIcon.TabStop = False
		Me.TiersSuccessIcon.ToolTipText = Nothing
		Me.TiersSuccessIcon.Visible = False
		'
		'btnSetNumOfTiers
		'
		Me.btnSetNumOfTiers.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetNumOfTiers.CausesValidation = False
		Me.btnSetNumOfTiers.Enabled = False
		Me.btnSetNumOfTiers.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetNumOfTiers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetNumOfTiers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetNumOfTiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetNumOfTiers.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetNumOfTiers.ForeColor = System.Drawing.Color.White
		Me.btnSetNumOfTiers.Location = New System.Drawing.Point(104, 20)
		Me.btnSetNumOfTiers.Name = "btnSetNumOfTiers"
		Me.btnSetNumOfTiers.Size = New System.Drawing.Size(36, 20)
		Me.btnSetNumOfTiers.TabIndex = 0
		Me.btnSetNumOfTiers.TabStop = False
		Me.btnSetNumOfTiers.Text = "Set"
		Me.btnSetNumOfTiers.UseMnemonic = False
		Me.btnSetNumOfTiers.UseVisualStyleBackColor = False
		'
		'lblNumOfDays
		'
		Me.lblNumOfDays.AutoSize = True
		Me.lblNumOfDays.BackColor = System.Drawing.Color.Transparent
		Me.lblNumOfDays.CausesValidation = False
		Me.lblNumOfDays.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumOfDays.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.lblNumOfDays.Location = New System.Drawing.Point(56, 5)
		Me.lblNumOfDays.Name = "lblNumOfDays"
		Me.lblNumOfDays.Size = New System.Drawing.Size(61, 13)
		Me.lblNumOfDays.TabIndex = 0
		Me.lblNumOfDays.Text = "# of Days"
		Me.lblNumOfDays.UseMnemonic = False
		'
		'rbTIERS
		'
		Me.rbTIERS.AutoSize = True
		Me.rbTIERS.BackColor = System.Drawing.Color.Transparent
		Me.rbTIERS.CausesValidation = False
		Me.rbTIERS.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.rbTIERS.Location = New System.Drawing.Point(2, 20)
		Me.rbTIERS.Name = "rbTIERS"
		Me.rbTIERS.Size = New System.Drawing.Size(48, 17)
		Me.rbTIERS.TabIndex = 0
		Me.rbTIERS.Text = "Tiers"
		Me.rbTIERS.UseMnemonic = False
		Me.rbTIERS.UseVisualStyleBackColor = False
		'
		'rbDAYS
		'
		Me.rbDAYS.AutoSize = True
		Me.rbDAYS.BackColor = System.Drawing.Color.Transparent
		Me.rbDAYS.CausesValidation = False
		Me.rbDAYS.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.rbDAYS.Location = New System.Drawing.Point(2, 2)
		Me.rbDAYS.Name = "rbDAYS"
		Me.rbDAYS.Size = New System.Drawing.Size(49, 17)
		Me.rbDAYS.TabIndex = 0
		Me.rbDAYS.Text = "Days"
		Me.rbDAYS.UseMnemonic = False
		Me.rbDAYS.UseVisualStyleBackColor = False
		'
		'txtNumOfTiers
		'
		Me.txtNumOfTiers.BackColor = System.Drawing.SystemColors.HighlightText
		Me.txtNumOfTiers.CausesValidation = False
		Me.txtNumOfTiers.Enabled = False
		Me.txtNumOfTiers.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNumOfTiers.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.txtNumOfTiers.Location = New System.Drawing.Point(55, 20)
		Me.txtNumOfTiers.MaxLength = 2
		Me.txtNumOfTiers.Name = "txtNumOfTiers"
		Me.txtNumOfTiers.Size = New System.Drawing.Size(43, 20)
		Me.txtNumOfTiers.TabIndex = 0
		Me.txtNumOfTiers.TabStop = False
		Me.txtNumOfTiers.Text = "#"
		'
		'pnlPayoutParameters
		'
		Me.pnlPayoutParameters.BackColor = System.Drawing.Color.PowderBlue
		Me.pnlPayoutParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPayoutParameters.CausesValidation = False
		Me.pnlPayoutParameters.Controls.Add(Me.cbPayoutParametersYES)
		Me.pnlPayoutParameters.Controls.Add(Me.lblPaymentParameters)
		Me.pnlPayoutParameters.Enabled = False
		Me.pnlPayoutParameters.Location = New System.Drawing.Point(183, 26)
		Me.pnlPayoutParameters.Name = "pnlPayoutParameters"
		Me.pnlPayoutParameters.Size = New System.Drawing.Size(64, 45)
		Me.pnlPayoutParameters.TabIndex = 0
		'
		'cbPayoutParametersYES
		'
		Me.cbPayoutParametersYES.AutoSize = True
		Me.cbPayoutParametersYES.BackColor = System.Drawing.Color.Transparent
		Me.cbPayoutParametersYES.CausesValidation = False
		Me.cbPayoutParametersYES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPayoutParametersYES.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.cbPayoutParametersYES.Location = New System.Drawing.Point(9, 27)
		Me.cbPayoutParametersYES.Name = "cbPayoutParametersYES"
		Me.cbPayoutParametersYES.Size = New System.Drawing.Size(47, 17)
		Me.cbPayoutParametersYES.TabIndex = 0
		Me.cbPayoutParametersYES.TabStop = False
		Me.cbPayoutParametersYES.Text = "Yes"
		Me.cbPayoutParametersYES.UseMnemonic = False
		Me.cbPayoutParametersYES.UseVisualStyleBackColor = False
		'
		'lblPaymentParameters
		'
		Me.lblPaymentParameters.BackColor = System.Drawing.Color.Transparent
		Me.lblPaymentParameters.CausesValidation = False
		Me.lblPaymentParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPaymentParameters.Location = New System.Drawing.Point(-1, 0)
		Me.lblPaymentParameters.Name = "lblPaymentParameters"
		Me.lblPaymentParameters.Size = New System.Drawing.Size(64, 29)
		Me.lblPaymentParameters.TabIndex = 0
		Me.lblPaymentParameters.Text = "Are Payouts equal?"
		Me.lblPaymentParameters.UseMnemonic = False
		'
		'pnlAcquisition
		'
		Me.pnlAcquisition.BackColor = System.Drawing.Color.Lavender
		Me.pnlAcquisition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlAcquisition.CausesValidation = False
		Me.pnlAcquisition.Controls.Add(Me.lblSTILLINDEVELOPMENT)
		Me.pnlAcquisition.Location = New System.Drawing.Point(3, 191)
		Me.pnlAcquisition.Name = "pnlAcquisition"
		Me.pnlAcquisition.Size = New System.Drawing.Size(251, 43)
		Me.pnlAcquisition.TabIndex = 0
		'
		'lblSTILLINDEVELOPMENT
		'
		Me.lblSTILLINDEVELOPMENT.AutoSize = True
		Me.lblSTILLINDEVELOPMENT.CausesValidation = False
		Me.lblSTILLINDEVELOPMENT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSTILLINDEVELOPMENT.ForeColor = System.Drawing.Color.SlateBlue
		Me.lblSTILLINDEVELOPMENT.Location = New System.Drawing.Point(84, 14)
		Me.lblSTILLINDEVELOPMENT.Name = "lblSTILLINDEVELOPMENT"
		Me.lblSTILLINDEVELOPMENT.Size = New System.Drawing.Size(158, 14)
		Me.lblSTILLINDEVELOPMENT.TabIndex = 0
		Me.lblSTILLINDEVELOPMENT.Text = "(Not Enabled: In Development)"
		Me.lblSTILLINDEVELOPMENT.UseMnemonic = False
		'
		'pnlPlayerEligibility
		'
		Me.pnlPlayerEligibility.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPlayerEligibility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPlayerEligibility.CausesValidation = False
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlSumMethod)
		Me.pnlPlayerEligibility.Controls.Add(Me.lblPlayerEligibility)
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlLemonChiffon)
		Me.pnlPlayerEligibility.Controls.Add(Me.pnlPointCutoffLimit)
		Me.pnlPlayerEligibility.Location = New System.Drawing.Point(290, 34)
		Me.pnlPlayerEligibility.Name = "pnlPlayerEligibility"
		Me.pnlPlayerEligibility.Size = New System.Drawing.Size(265, 238)
		Me.pnlPlayerEligibility.TabIndex = 0
		'
		'pnlSumMethod
		'
		Me.pnlSumMethod.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlSumMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlSumMethod.CausesValidation = False
		Me.pnlSumMethod.Controls.Add(Me.rbEligiblePlayersList)
		Me.pnlSumMethod.Controls.Add(Me.rbSumQualifyingPoints)
		Me.pnlSumMethod.Controls.Add(Me.rbSumLifetimePoints)
		Me.pnlSumMethod.Controls.Add(Me.rbAutoQualification)
		Me.pnlSumMethod.Controls.Add(Me.Panel7)
		Me.pnlSumMethod.Location = New System.Drawing.Point(3, 22)
		Me.pnlSumMethod.Name = "pnlSumMethod"
		Me.pnlSumMethod.Size = New System.Drawing.Size(255, 120)
		Me.pnlSumMethod.TabIndex = 0
		'
		'rbEligiblePlayersList
		'
		Me.rbEligiblePlayersList.AutoSize = True
		Me.rbEligiblePlayersList.BackColor = System.Drawing.Color.LemonChiffon
		Me.rbEligiblePlayersList.CausesValidation = False
		Me.rbEligiblePlayersList.Location = New System.Drawing.Point(3, 93)
		Me.rbEligiblePlayersList.Name = "rbEligiblePlayersList"
		Me.rbEligiblePlayersList.Size = New System.Drawing.Size(228, 17)
		Me.rbEligiblePlayersList.TabIndex = 9
		Me.rbEligiblePlayersList.TabStop = True
		Me.rbEligiblePlayersList.Text = "EligiblePlayers List Determines Qualification"
		Me.rbEligiblePlayersList.UseMnemonic = False
		Me.rbEligiblePlayersList.UseVisualStyleBackColor = False
		'
		'rbSumQualifyingPoints
		'
		Me.rbSumQualifyingPoints.AutoSize = True
		Me.rbSumQualifyingPoints.CausesValidation = False
		Me.rbSumQualifyingPoints.Checked = True
		Me.rbSumQualifyingPoints.Location = New System.Drawing.Point(3, 9)
		Me.rbSumQualifyingPoints.Name = "rbSumQualifyingPoints"
		Me.rbSumQualifyingPoints.Size = New System.Drawing.Size(193, 17)
		Me.rbSumQualifyingPoints.TabIndex = 6
		Me.rbSumQualifyingPoints.TabStop = True
		Me.rbSumQualifyingPoints.Text = "Sum Points Within Qualifying Peroid"
		Me.rbSumQualifyingPoints.UseMnemonic = False
		Me.rbSumQualifyingPoints.UseVisualStyleBackColor = True
		'
		'rbSumLifetimePoints
		'
		Me.rbSumLifetimePoints.AutoSize = True
		Me.rbSumLifetimePoints.CausesValidation = False
		Me.rbSumLifetimePoints.Location = New System.Drawing.Point(3, 32)
		Me.rbSumLifetimePoints.Name = "rbSumLifetimePoints"
		Me.rbSumLifetimePoints.Size = New System.Drawing.Size(117, 17)
		Me.rbSumLifetimePoints.TabIndex = 7
		Me.rbSumLifetimePoints.TabStop = True
		Me.rbSumLifetimePoints.Text = "Sum Lifetime Points"
		Me.rbSumLifetimePoints.UseMnemonic = False
		Me.rbSumLifetimePoints.UseVisualStyleBackColor = True
		'
		'rbAutoQualification
		'
		Me.rbAutoQualification.AutoSize = True
		Me.rbAutoQualification.CausesValidation = False
		Me.rbAutoQualification.Location = New System.Drawing.Point(3, 55)
		Me.rbAutoQualification.Name = "rbAutoQualification"
		Me.rbAutoQualification.Size = New System.Drawing.Size(233, 17)
		Me.rbAutoQualification.TabIndex = 8
		Me.rbAutoQualification.TabStop = True
		Me.rbAutoQualification.Text = "Automatic Qualification Regardless of Points"
		Me.rbAutoQualification.UseMnemonic = False
		Me.rbAutoQualification.UseVisualStyleBackColor = True
		'
		'Panel7
		'
		Me.Panel7.BackColor = System.Drawing.Color.LemonChiffon
		Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel7.CausesValidation = False
		Me.Panel7.Location = New System.Drawing.Point(-2, 83)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(255, 35)
		Me.Panel7.TabIndex = 0
		'
		'lblPlayerEligibility
		'
		Me.lblPlayerEligibility.AutoSize = True
		Me.lblPlayerEligibility.CausesValidation = False
		Me.lblPlayerEligibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlayerEligibility.ForeColor = System.Drawing.Color.White
		Me.lblPlayerEligibility.Location = New System.Drawing.Point(0, 0)
		Me.lblPlayerEligibility.Name = "lblPlayerEligibility"
		Me.lblPlayerEligibility.Size = New System.Drawing.Size(259, 16)
		Me.lblPlayerEligibility.TabIndex = 0
		Me.lblPlayerEligibility.Text = "How is player eligibility determined?"
		Me.lblPlayerEligibility.UseMnemonic = False
		'
		'pnlPointCutoffLimit
		'
		Me.pnlPointCutoffLimit.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlPointCutoffLimit.CausesValidation = False
		Me.pnlPointCutoffLimit.Controls.Add(Me.PointCutoffLimitSuccessIcon)
		Me.pnlPointCutoffLimit.Controls.Add(Me.btnSetPointCutoffLimit)
		Me.pnlPointCutoffLimit.Controls.Add(Me.txtPointCutoffLimit)
		Me.pnlPointCutoffLimit.Controls.Add(Me.rbPointCutoffLimitNO)
		Me.pnlPointCutoffLimit.Controls.Add(Me.rbPointCutoffLimitYES)
		Me.pnlPointCutoffLimit.Controls.Add(Me.lblPointCutoffLimit)
		Me.pnlPointCutoffLimit.Location = New System.Drawing.Point(18, 148)
		Me.pnlPointCutoffLimit.Name = "pnlPointCutoffLimit"
		Me.pnlPointCutoffLimit.Size = New System.Drawing.Size(224, 80)
		Me.pnlPointCutoffLimit.TabIndex = 0
		'
		'PointCutoffLimitSuccessIcon
		'
		Me.PointCutoffLimitSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.PointCutoffLimitSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.PointCutoffLimitSuccessIcon.Enabled = False
		Me.PointCutoffLimitSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.PointCutoffLimitSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.PointCutoffLimitSuccessIcon.Location = New System.Drawing.Point(182, 40)
		Me.PointCutoffLimitSuccessIcon.Name = "PointCutoffLimitSuccessIcon"
		Me.PointCutoffLimitSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.PointCutoffLimitSuccessIcon.TabIndex = 36
		Me.PointCutoffLimitSuccessIcon.TabStop = False
		Me.PointCutoffLimitSuccessIcon.ToolTipText = Nothing
		Me.PointCutoffLimitSuccessIcon.Visible = False
		'
		'btnSetPointCutoffLimit
		'
		Me.btnSetPointCutoffLimit.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetPointCutoffLimit.CausesValidation = False
		Me.btnSetPointCutoffLimit.Enabled = False
		Me.btnSetPointCutoffLimit.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetPointCutoffLimit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetPointCutoffLimit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetPointCutoffLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetPointCutoffLimit.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetPointCutoffLimit.ForeColor = System.Drawing.Color.White
		Me.btnSetPointCutoffLimit.Location = New System.Drawing.Point(140, 39)
		Me.btnSetPointCutoffLimit.Name = "btnSetPointCutoffLimit"
		Me.btnSetPointCutoffLimit.Size = New System.Drawing.Size(36, 20)
		Me.btnSetPointCutoffLimit.TabIndex = 0
		Me.btnSetPointCutoffLimit.TabStop = False
		Me.btnSetPointCutoffLimit.Text = "Set"
		Me.btnSetPointCutoffLimit.UseMnemonic = False
		Me.btnSetPointCutoffLimit.UseVisualStyleBackColor = False
		'
		'txtPointCutoffLimit
		'
		Me.txtPointCutoffLimit.CausesValidation = False
		Me.txtPointCutoffLimit.Enabled = False
		Me.txtPointCutoffLimit.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPointCutoffLimit.Location = New System.Drawing.Point(53, 40)
		Me.txtPointCutoffLimit.MaxLength = 5
		Me.txtPointCutoffLimit.Name = "txtPointCutoffLimit"
		Me.txtPointCutoffLimit.Size = New System.Drawing.Size(81, 20)
		Me.txtPointCutoffLimit.TabIndex = 0
		Me.txtPointCutoffLimit.TabStop = False
		Me.txtPointCutoffLimit.Text = "Enter # Here"
		'
		'rbPointCutoffLimitNO
		'
		Me.rbPointCutoffLimitNO.AutoSize = True
		Me.rbPointCutoffLimitNO.CausesValidation = False
		Me.rbPointCutoffLimitNO.Checked = True
		Me.rbPointCutoffLimitNO.Location = New System.Drawing.Point(4, 61)
		Me.rbPointCutoffLimitNO.Name = "rbPointCutoffLimitNO"
		Me.rbPointCutoffLimitNO.Size = New System.Drawing.Size(39, 17)
		Me.rbPointCutoffLimitNO.TabIndex = 0
		Me.rbPointCutoffLimitNO.TabStop = True
		Me.rbPointCutoffLimitNO.Text = "No"
		Me.rbPointCutoffLimitNO.UseMnemonic = False
		Me.rbPointCutoffLimitNO.UseVisualStyleBackColor = True
		'
		'rbPointCutoffLimitYES
		'
		Me.rbPointCutoffLimitYES.AutoSize = True
		Me.rbPointCutoffLimitYES.CausesValidation = False
		Me.rbPointCutoffLimitYES.Location = New System.Drawing.Point(4, 41)
		Me.rbPointCutoffLimitYES.Name = "rbPointCutoffLimitYES"
		Me.rbPointCutoffLimitYES.Size = New System.Drawing.Size(43, 17)
		Me.rbPointCutoffLimitYES.TabIndex = 0
		Me.rbPointCutoffLimitYES.Text = "Yes"
		Me.rbPointCutoffLimitYES.UseMnemonic = False
		Me.rbPointCutoffLimitYES.UseVisualStyleBackColor = True
		'
		'lblPointCutoffLimit
		'
		Me.lblPointCutoffLimit.CausesValidation = False
		Me.lblPointCutoffLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPointCutoffLimit.Location = New System.Drawing.Point(4, 0)
		Me.lblPointCutoffLimit.Name = "lblPointCutoffLimit"
		Me.lblPointCutoffLimit.Size = New System.Drawing.Size(235, 37)
		Me.lblPointCutoffLimit.TabIndex = 0
		Me.lblPointCutoffLimit.Text = "Is there a Point Cutoff limit in order to qualify for the promo?"
		Me.lblPointCutoffLimit.UseMnemonic = False
		'
		'pnlLemonChiffon
		'
		Me.pnlLemonChiffon.BackColor = System.Drawing.Color.LemonChiffon
		Me.pnlLemonChiffon.Controls.Add(Me.btnOpenPanel)
		Me.pnlLemonChiffon.Cursor = System.Windows.Forms.Cursors.Default
		Me.pnlLemonChiffon.Enabled = False
		Me.pnlLemonChiffon.Location = New System.Drawing.Point(18, 148)
		Me.pnlLemonChiffon.Name = "pnlLemonChiffon"
		Me.pnlLemonChiffon.Size = New System.Drawing.Size(224, 80)
		Me.pnlLemonChiffon.TabIndex = 0
		Me.pnlLemonChiffon.Visible = False
		'
		'btnOpenPanel
		'
		Me.btnOpenPanel.BackColor = System.Drawing.Color.Gainsboro
		Me.btnOpenPanel.Enabled = False
		Me.btnOpenPanel.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnOpenPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnOpenPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue
		Me.btnOpenPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOpenPanel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOpenPanel.ForeColor = System.Drawing.Color.White
		Me.btnOpenPanel.Location = New System.Drawing.Point(43, 29)
		Me.btnOpenPanel.Name = "btnOpenPanel"
		Me.btnOpenPanel.Size = New System.Drawing.Size(140, 26)
		Me.btnOpenPanel.TabIndex = 32
		Me.btnOpenPanel.Text = "Open Panel"
		Me.btnOpenPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnOpenPanel.UseVisualStyleBackColor = False
		'
		'stepD_DDEP
		'
		Me.stepD_DDEP.BackColor = System.Drawing.Color.LemonChiffon
		Me.stepD_DDEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.stepD_DDEP.CausesValidation = False
		Me.stepD_DDEP.Enabled = False
		Me.stepD_DDEP.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.stepD_DDEP.Location = New System.Drawing.Point(24, 34)
		Me.stepD_DDEP.Name = "stepD_DDEP"
		Me.stepD_DDEP.NumOfTicketsIndex = -1
		Me.stepD_DDEP.PlayerIDIndex = -1
		Me.stepD_DDEP.Size = New System.Drawing.Size(531, 238)
		Me.stepD_DDEP.TabIndex = 0
		Me.stepD_DDEP.TabStop = False
		Me.stepD_DDEP.Visible = False
		'
		'StepD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlPlayerEligibility)
		Me.Controls.Add(Me.pnlPromoType)
		Me.Controls.Add(Me.stepD_DDEP)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Name = "StepD"
		Me.NextStep = "StepEntryTicketAmt"
		Me.PreviousStep = "StepCanHazSecurity"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Of the five available categories, which will this promo be?"
		Me.Controls.SetChildIndex(Me.stepD_DDEP, 0)
		Me.Controls.SetChildIndex(Me.pnlPromoType, 0)
		Me.Controls.SetChildIndex(Me.pnlPlayerEligibility, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.pnlPromoType.ResumeLayout(False)
		Me.pnlPromoType.PerformLayout()
		Me.pnlMultiPart.ResumeLayout(False)
		Me.pnlDaysTiers.ResumeLayout(False)
		Me.pnlDaysTiers.PerformLayout()
		CType(Me.TiersSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlPayoutParameters.ResumeLayout(False)
		Me.pnlPayoutParameters.PerformLayout()
		Me.pnlAcquisition.ResumeLayout(False)
		Me.pnlAcquisition.PerformLayout()
		Me.pnlPlayerEligibility.ResumeLayout(False)
		Me.pnlPlayerEligibility.PerformLayout()
		Me.pnlSumMethod.ResumeLayout(False)
		Me.pnlSumMethod.PerformLayout()
		Me.pnlPointCutoffLimit.ResumeLayout(False)
		Me.pnlPointCutoffLimit.PerformLayout()
		CType(Me.PointCutoffLimitSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLemonChiffon.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents btnSetPointCutoffLimit As System.Windows.Forms.Button
	Private WithEvents btnSetNumOfTiers As System.Windows.Forms.Button
	Private WithEvents PointCutoffLimitSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents TiersSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents btnOpenPanel As System.Windows.Forms.Button
	Private WithEvents pnlLemonChiffon As System.Windows.Forms.Panel
	Friend WithEvents stepD_DDEP As PromotionalCreationWizard.DDEP
	Private WithEvents rbEligiblePlayersList As System.Windows.Forms.RadioButton
	Private WithEvents rbAutoQualification As System.Windows.Forms.RadioButton
	Private WithEvents rbSumLifetimePoints As System.Windows.Forms.RadioButton
	Private WithEvents rbSumQualifyingPoints As System.Windows.Forms.RadioButton
	Private WithEvents pnlSumMethod As System.Windows.Forms.Panel
	Private WithEvents Panel7 As System.Windows.Forms.Panel
	Private WithEvents pnlPromoType As System.Windows.Forms.Panel
	Private WithEvents rbSingleEntryPayout As System.Windows.Forms.RadioButton
	Private WithEvents rbMultiPartEntryPayout As System.Windows.Forms.RadioButton
	Private WithEvents rbAcquisition As System.Windows.Forms.RadioButton
	Private WithEvents rbSingleEntryOnly As System.Windows.Forms.RadioButton
	Private WithEvents lblPromoType As System.Windows.Forms.Label
	Private WithEvents pnlAcquisition As System.Windows.Forms.Panel
	Private WithEvents pnlPlayerEligibility As System.Windows.Forms.Panel
	Private WithEvents lblPlayerEligibility As System.Windows.Forms.Label
	Private WithEvents txtNumOfTiers As System.Windows.Forms.TextBox
	Private WithEvents pnlPayoutParameters As System.Windows.Forms.Panel
	Private WithEvents cbPayoutParametersYES As System.Windows.Forms.CheckBox
	Private WithEvents lblPaymentParameters As System.Windows.Forms.Label
	Private WithEvents pnlDaysTiers As System.Windows.Forms.Panel
	Private WithEvents lblNumOfDays As System.Windows.Forms.Label
	Private WithEvents rbTIERS As System.Windows.Forms.RadioButton
	Private WithEvents rbDAYS As System.Windows.Forms.RadioButton
	Private WithEvents lblSTILLINDEVELOPMENT As System.Windows.Forms.Label
	Private WithEvents pnlPointCutoffLimit As System.Windows.Forms.Panel
	Private WithEvents txtPointCutoffLimit As System.Windows.Forms.TextBox
	Private WithEvents rbPointCutoffLimitNO As System.Windows.Forms.RadioButton
	Private WithEvents rbPointCutoffLimitYES As System.Windows.Forms.RadioButton
	Private WithEvents lblPointCutoffLimit As System.Windows.Forms.Label
	Private WithEvents rbSinglePayoutOnly As System.Windows.Forms.RadioButton
	Private WithEvents pnlSingleEvent As System.Windows.Forms.Panel
	Private WithEvents pnlMultiPart As System.Windows.Forms.Panel

End Class

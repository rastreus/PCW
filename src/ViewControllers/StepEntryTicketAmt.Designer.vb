<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepEntryTicketAmt
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
		Me.pnlTicketsAmount = New System.Windows.Forms.Panel()
		Me.rbNumOfVisits = New System.Windows.Forms.RadioButton()
		Me.rbCalPlusNumOfVisits = New System.Windows.Forms.RadioButton()
		Me.rbCalculated = New System.Windows.Forms.RadioButton()
		Me.rb1 = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pnl1 = New System.Windows.Forms.Panel()
		Me.pnlCountAndCal = New System.Windows.Forms.Panel()
		Me.pnlPointsDivisor = New System.Windows.Forms.Panel()
		Me.PointsDivisorSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetPointsDivisor = New System.Windows.Forms.Button()
		Me.txtPointsDivisor = New System.Windows.Forms.TextBox()
		Me.lblPointsDivisor = New System.Windows.Forms.Label()
		Me.pnlTicketPerPatron = New System.Windows.Forms.Panel()
		Me.txtTicketsPerPatron = New System.Windows.Forms.TextBox()
		Me.rbTicketsPerPatronNO = New System.Windows.Forms.RadioButton()
		Me.rbTicketPerPatronYES = New System.Windows.Forms.RadioButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TicketsPerPatronSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetTicketsPerPatron = New System.Windows.Forms.Button()
		Me.lblTicketsPerPatron = New System.Windows.Forms.Label()
		Me.pnlTicketsEntirePromo = New System.Windows.Forms.Panel()
		Me.rbTicketsEntirePromoNO = New System.Windows.Forms.RadioButton()
		Me.rbTicketsEntirePromoYES = New System.Windows.Forms.RadioButton()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TicketsEntirePromoSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.txtTicketsEntirePromo = New System.Windows.Forms.TextBox()
		Me.btnSetTicketsEntirePromo = New System.Windows.Forms.Button()
		Me.lblTicketsEntirePromo = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.pnlAmtDescription = New System.Windows.Forms.Panel()
		Me.lblAmtDesc = New System.Windows.Forms.Label()
		Me.pnlPromoTypeForEntry = New System.Windows.Forms.Panel()
		Me.PromoTypeSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetPromoType = New System.Windows.Forms.Button()
		Me.lblPromoTypeQuestion = New System.Windows.Forms.Label()
		Me.txtPromoType = New System.Windows.Forms.TextBox()
		Me.lblPromoType = New System.Windows.Forms.Label()
		Me.pnlInfoNotNeeded = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.pnlTicketsAmount.SuspendLayout()
		Me.pnlPointsDivisor.SuspendLayout()
		CType(Me.PointsDivisorSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlTicketPerPatron.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.TicketsPerPatronSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlTicketsEntirePromo.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.TicketsEntirePromoSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlAmtDescription.SuspendLayout()
		Me.pnlPromoTypeForEntry.SuspendLayout()
		CType(Me.PromoTypeSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlInfoNotNeeded.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "This is where ticket options are determined."
		'
		'pnlTicketsAmount
		'
		Me.pnlTicketsAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlTicketsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTicketsAmount.Controls.Add(Me.rbNumOfVisits)
		Me.pnlTicketsAmount.Controls.Add(Me.rbCalPlusNumOfVisits)
		Me.pnlTicketsAmount.Controls.Add(Me.rbCalculated)
		Me.pnlTicketsAmount.Controls.Add(Me.rb1)
		Me.pnlTicketsAmount.Controls.Add(Me.Label2)
		Me.pnlTicketsAmount.Controls.Add(Me.pnl1)
		Me.pnlTicketsAmount.Controls.Add(Me.pnlCountAndCal)
		Me.pnlTicketsAmount.Location = New System.Drawing.Point(297, 15)
		Me.pnlTicketsAmount.Name = "pnlTicketsAmount"
		Me.pnlTicketsAmount.Size = New System.Drawing.Size(160, 172)
		Me.pnlTicketsAmount.TabIndex = 2
		'
		'rbNumOfVisits
		'
		Me.rbNumOfVisits.AutoSize = True
		Me.rbNumOfVisits.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbNumOfVisits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbNumOfVisits.ForeColor = System.Drawing.SystemColors.ControlText
		Me.rbNumOfVisits.Location = New System.Drawing.Point(13, 84)
		Me.rbNumOfVisits.Name = "rbNumOfVisits"
		Me.rbNumOfVisits.Size = New System.Drawing.Size(71, 17)
		Me.rbNumOfVisits.TabIndex = 6
		Me.rbNumOfVisits.TabStop = True
		Me.rbNumOfVisits.Text = "# of Visits"
		Me.rbNumOfVisits.UseVisualStyleBackColor = False
		'
		'rbCalPlusNumOfVisits
		'
		Me.rbCalPlusNumOfVisits.AutoSize = True
		Me.rbCalPlusNumOfVisits.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbCalPlusNumOfVisits.Location = New System.Drawing.Point(13, 130)
		Me.rbCalPlusNumOfVisits.Name = "rbCalPlusNumOfVisits"
		Me.rbCalPlusNumOfVisits.Size = New System.Drawing.Size(133, 17)
		Me.rbCalPlusNumOfVisits.TabIndex = 5
		Me.rbCalPlusNumOfVisits.Text = "Calculated + # of Visits"
		Me.rbCalPlusNumOfVisits.UseVisualStyleBackColor = False
		'
		'rbCalculated
		'
		Me.rbCalculated.AutoSize = True
		Me.rbCalculated.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbCalculated.Location = New System.Drawing.Point(13, 107)
		Me.rbCalculated.Name = "rbCalculated"
		Me.rbCalculated.Size = New System.Drawing.Size(75, 17)
		Me.rbCalculated.TabIndex = 4
		Me.rbCalculated.Text = "Calculated"
		Me.rbCalculated.UseVisualStyleBackColor = False
		'
		'rb1
		'
		Me.rb1.AutoSize = True
		Me.rb1.BackColor = System.Drawing.Color.Aquamarine
		Me.rb1.Checked = True
		Me.rb1.Location = New System.Drawing.Point(13, 38)
		Me.rb1.Name = "rb1"
		Me.rb1.Size = New System.Drawing.Size(31, 17)
		Me.rb1.TabIndex = 3
		Me.rb1.TabStop = True
		Me.rb1.Text = "1"
		Me.rb1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(4, 4)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(158, 16)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "How many entries?"
		'
		'pnl1
		'
		Me.pnl1.BackColor = System.Drawing.Color.Aquamarine
		Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl1.Location = New System.Drawing.Point(7, 30)
		Me.pnl1.Name = "pnl1"
		Me.pnl1.Size = New System.Drawing.Size(142, 32)
		Me.pnl1.TabIndex = 13
		'
		'pnlCountAndCal
		'
		Me.pnlCountAndCal.BackColor = System.Drawing.Color.PaleTurquoise
		Me.pnlCountAndCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCountAndCal.Location = New System.Drawing.Point(7, 68)
		Me.pnlCountAndCal.Name = "pnlCountAndCal"
		Me.pnlCountAndCal.Size = New System.Drawing.Size(142, 91)
		Me.pnlCountAndCal.TabIndex = 14
		'
		'pnlPointsDivisor
		'
		Me.pnlPointsDivisor.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPointsDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPointsDivisor.Controls.Add(Me.PointsDivisorSuccessIcon)
		Me.pnlPointsDivisor.Controls.Add(Me.btnSetPointsDivisor)
		Me.pnlPointsDivisor.Controls.Add(Me.txtPointsDivisor)
		Me.pnlPointsDivisor.Controls.Add(Me.lblPointsDivisor)
		Me.pnlPointsDivisor.Enabled = False
		Me.pnlPointsDivisor.Location = New System.Drawing.Point(463, 103)
		Me.pnlPointsDivisor.Name = "pnlPointsDivisor"
		Me.pnlPointsDivisor.Size = New System.Drawing.Size(103, 73)
		Me.pnlPointsDivisor.TabIndex = 11
		Me.pnlPointsDivisor.Visible = False
		'
		'PointsDivisorSuccessIcon
		'
		Me.PointsDivisorSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.PointsDivisorSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.PointsDivisorSuccessIcon.Enabled = False
		Me.PointsDivisorSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.PointsDivisorSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.PointsDivisorSuccessIcon.Location = New System.Drawing.Point(63, 47)
		Me.PointsDivisorSuccessIcon.Name = "PointsDivisorSuccessIcon"
		Me.PointsDivisorSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.PointsDivisorSuccessIcon.TabIndex = 36
		Me.PointsDivisorSuccessIcon.TabStop = False
		Me.PointsDivisorSuccessIcon.ToolTipText = Nothing
		Me.PointsDivisorSuccessIcon.Visible = False
		'
		'btnSetPointsDivisor
		'
		Me.btnSetPointsDivisor.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetPointsDivisor.Enabled = False
		Me.btnSetPointsDivisor.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetPointsDivisor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetPointsDivisor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetPointsDivisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetPointsDivisor.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetPointsDivisor.ForeColor = System.Drawing.Color.White
		Me.btnSetPointsDivisor.Location = New System.Drawing.Point(3, 47)
		Me.btnSetPointsDivisor.Name = "btnSetPointsDivisor"
		Me.btnSetPointsDivisor.Size = New System.Drawing.Size(54, 20)
		Me.btnSetPointsDivisor.TabIndex = 34
		Me.btnSetPointsDivisor.Text = "Set"
		Me.btnSetPointsDivisor.UseVisualStyleBackColor = False
		'
		'txtPointsDivisor
		'
		Me.txtPointsDivisor.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPointsDivisor.Location = New System.Drawing.Point(2, 21)
		Me.txtPointsDivisor.MaxLength = 5
		Me.txtPointsDivisor.Name = "txtPointsDivisor"
		Me.txtPointsDivisor.Size = New System.Drawing.Size(81, 20)
		Me.txtPointsDivisor.TabIndex = 1
		Me.txtPointsDivisor.Text = "Enter # Here"
		'
		'lblPointsDivisor
		'
		Me.lblPointsDivisor.BackColor = System.Drawing.Color.Transparent
		Me.lblPointsDivisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPointsDivisor.ForeColor = System.Drawing.Color.White
		Me.lblPointsDivisor.Location = New System.Drawing.Point(-1, 2)
		Me.lblPointsDivisor.Name = "lblPointsDivisor"
		Me.lblPointsDivisor.Size = New System.Drawing.Size(103, 16)
		Me.lblPointsDivisor.TabIndex = 0
		Me.lblPointsDivisor.Text = "Points Divisor"
		'
		'pnlTicketPerPatron
		'
		Me.pnlTicketPerPatron.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlTicketPerPatron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlTicketPerPatron.Controls.Add(Me.txtTicketsPerPatron)
		Me.pnlTicketPerPatron.Controls.Add(Me.rbTicketsPerPatronNO)
		Me.pnlTicketPerPatron.Controls.Add(Me.rbTicketPerPatronYES)
		Me.pnlTicketPerPatron.Controls.Add(Me.Panel1)
		Me.pnlTicketPerPatron.Controls.Add(Me.lblTicketsPerPatron)
		Me.pnlTicketPerPatron.Location = New System.Drawing.Point(139, 193)
		Me.pnlTicketPerPatron.Name = "pnlTicketPerPatron"
		Me.pnlTicketPerPatron.Size = New System.Drawing.Size(152, 98)
		Me.pnlTicketPerPatron.TabIndex = 4
		'
		'txtTicketsPerPatron
		'
		Me.txtTicketsPerPatron.Enabled = False
		Me.txtTicketsPerPatron.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTicketsPerPatron.Location = New System.Drawing.Point(57, 37)
		Me.txtTicketsPerPatron.MaxLength = 5
		Me.txtTicketsPerPatron.Name = "txtTicketsPerPatron"
		Me.txtTicketsPerPatron.Size = New System.Drawing.Size(81, 20)
		Me.txtTicketsPerPatron.TabIndex = 9
		Me.txtTicketsPerPatron.Text = "Enter # Here"
		'
		'rbTicketsPerPatronNO
		'
		Me.rbTicketsPerPatronNO.AutoSize = True
		Me.rbTicketsPerPatronNO.BackColor = System.Drawing.Color.PapayaWhip
		Me.rbTicketsPerPatronNO.Checked = True
		Me.rbTicketsPerPatronNO.Location = New System.Drawing.Point(7, 57)
		Me.rbTicketsPerPatronNO.Name = "rbTicketsPerPatronNO"
		Me.rbTicketsPerPatronNO.Size = New System.Drawing.Size(39, 17)
		Me.rbTicketsPerPatronNO.TabIndex = 8
		Me.rbTicketsPerPatronNO.TabStop = True
		Me.rbTicketsPerPatronNO.Text = "No"
		Me.rbTicketsPerPatronNO.UseVisualStyleBackColor = False
		'
		'rbTicketPerPatronYES
		'
		Me.rbTicketPerPatronYES.AutoSize = True
		Me.rbTicketPerPatronYES.BackColor = System.Drawing.Color.PapayaWhip
		Me.rbTicketPerPatronYES.Location = New System.Drawing.Point(7, 37)
		Me.rbTicketPerPatronYES.Name = "rbTicketPerPatronYES"
		Me.rbTicketPerPatronYES.Size = New System.Drawing.Size(43, 17)
		Me.rbTicketPerPatronYES.TabIndex = 7
		Me.rbTicketPerPatronYES.TabStop = True
		Me.rbTicketPerPatronYES.Text = "Yes"
		Me.rbTicketPerPatronYES.UseVisualStyleBackColor = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.TicketsPerPatronSuccessIcon)
		Me.Panel1.Controls.Add(Me.btnSetTicketsPerPatron)
		Me.Panel1.Location = New System.Drawing.Point(1, 31)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(143, 58)
		Me.Panel1.TabIndex = 10
		'
		'TicketsPerPatronSuccessIcon
		'
		Me.TicketsPerPatronSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.TicketsPerPatronSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.TicketsPerPatronSuccessIcon.Enabled = False
		Me.TicketsPerPatronSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.TicketsPerPatronSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.TicketsPerPatronSuccessIcon.Location = New System.Drawing.Point(116, 31)
		Me.TicketsPerPatronSuccessIcon.Name = "TicketsPerPatronSuccessIcon"
		Me.TicketsPerPatronSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.TicketsPerPatronSuccessIcon.TabIndex = 35
		Me.TicketsPerPatronSuccessIcon.TabStop = False
		Me.TicketsPerPatronSuccessIcon.ToolTipText = Nothing
		Me.TicketsPerPatronSuccessIcon.Visible = False
		'
		'btnSetTicketsPerPatron
		'
		Me.btnSetTicketsPerPatron.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetTicketsPerPatron.Enabled = False
		Me.btnSetTicketsPerPatron.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetTicketsPerPatron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetTicketsPerPatron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetTicketsPerPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetTicketsPerPatron.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetTicketsPerPatron.ForeColor = System.Drawing.Color.White
		Me.btnSetTicketsPerPatron.Location = New System.Drawing.Point(55, 31)
		Me.btnSetTicketsPerPatron.Name = "btnSetTicketsPerPatron"
		Me.btnSetTicketsPerPatron.Size = New System.Drawing.Size(55, 20)
		Me.btnSetTicketsPerPatron.TabIndex = 34
		Me.btnSetTicketsPerPatron.Text = "Set"
		Me.btnSetTicketsPerPatron.UseVisualStyleBackColor = False
		'
		'lblTicketsPerPatron
		'
		Me.lblTicketsPerPatron.BackColor = System.Drawing.Color.Transparent
		Me.lblTicketsPerPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTicketsPerPatron.ForeColor = System.Drawing.Color.White
		Me.lblTicketsPerPatron.Location = New System.Drawing.Point(-2, 0)
		Me.lblTicketsPerPatron.Name = "lblTicketsPerPatron"
		Me.lblTicketsPerPatron.Size = New System.Drawing.Size(114, 38)
		Me.lblTicketsPerPatron.TabIndex = 6
		Me.lblTicketsPerPatron.Text = "Limit # of tickets per patron?"
		'
		'pnlTicketsEntirePromo
		'
		Me.pnlTicketsEntirePromo.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlTicketsEntirePromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlTicketsEntirePromo.Controls.Add(Me.rbTicketsEntirePromoNO)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.rbTicketsEntirePromoYES)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.Panel2)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.lblTicketsEntirePromo)
		Me.pnlTicketsEntirePromo.Location = New System.Drawing.Point(297, 193)
		Me.pnlTicketsEntirePromo.Name = "pnlTicketsEntirePromo"
		Me.pnlTicketsEntirePromo.Size = New System.Drawing.Size(152, 98)
		Me.pnlTicketsEntirePromo.TabIndex = 5
		'
		'rbTicketsEntirePromoNO
		'
		Me.rbTicketsEntirePromoNO.AutoSize = True
		Me.rbTicketsEntirePromoNO.BackColor = System.Drawing.Color.PapayaWhip
		Me.rbTicketsEntirePromoNO.Checked = True
		Me.rbTicketsEntirePromoNO.Location = New System.Drawing.Point(7, 57)
		Me.rbTicketsEntirePromoNO.Name = "rbTicketsEntirePromoNO"
		Me.rbTicketsEntirePromoNO.Size = New System.Drawing.Size(39, 17)
		Me.rbTicketsEntirePromoNO.TabIndex = 9
		Me.rbTicketsEntirePromoNO.TabStop = True
		Me.rbTicketsEntirePromoNO.Text = "No"
		Me.rbTicketsEntirePromoNO.UseVisualStyleBackColor = False
		'
		'rbTicketsEntirePromoYES
		'
		Me.rbTicketsEntirePromoYES.AutoSize = True
		Me.rbTicketsEntirePromoYES.BackColor = System.Drawing.Color.PapayaWhip
		Me.rbTicketsEntirePromoYES.Location = New System.Drawing.Point(7, 37)
		Me.rbTicketsEntirePromoYES.Name = "rbTicketsEntirePromoYES"
		Me.rbTicketsEntirePromoYES.Size = New System.Drawing.Size(43, 17)
		Me.rbTicketsEntirePromoYES.TabIndex = 8
		Me.rbTicketsEntirePromoYES.Text = "Yes"
		Me.rbTicketsEntirePromoYES.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.PapayaWhip
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.TicketsEntirePromoSuccessIcon)
		Me.Panel2.Controls.Add(Me.txtTicketsEntirePromo)
		Me.Panel2.Controls.Add(Me.btnSetTicketsEntirePromo)
		Me.Panel2.Location = New System.Drawing.Point(1, 31)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(143, 58)
		Me.Panel2.TabIndex = 11
		'
		'TicketsEntirePromoSuccessIcon
		'
		Me.TicketsEntirePromoSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.TicketsEntirePromoSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.TicketsEntirePromoSuccessIcon.Enabled = False
		Me.TicketsEntirePromoSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.TicketsEntirePromoSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.TicketsEntirePromoSuccessIcon.Location = New System.Drawing.Point(115, 31)
		Me.TicketsEntirePromoSuccessIcon.Name = "TicketsEntirePromoSuccessIcon"
		Me.TicketsEntirePromoSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.TicketsEntirePromoSuccessIcon.TabIndex = 36
		Me.TicketsEntirePromoSuccessIcon.TabStop = False
		Me.TicketsEntirePromoSuccessIcon.ToolTipText = Nothing
		Me.TicketsEntirePromoSuccessIcon.Visible = False
		'
		'txtTicketsEntirePromo
		'
		Me.txtTicketsEntirePromo.Enabled = False
		Me.txtTicketsEntirePromo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTicketsEntirePromo.Location = New System.Drawing.Point(54, 5)
		Me.txtTicketsEntirePromo.MaxLength = 5
		Me.txtTicketsEntirePromo.Name = "txtTicketsEntirePromo"
		Me.txtTicketsEntirePromo.Size = New System.Drawing.Size(81, 20)
		Me.txtTicketsEntirePromo.TabIndex = 10
		Me.txtTicketsEntirePromo.Text = "Enter # Here"
		'
		'btnSetTicketsEntirePromo
		'
		Me.btnSetTicketsEntirePromo.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetTicketsEntirePromo.Enabled = False
		Me.btnSetTicketsEntirePromo.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetTicketsEntirePromo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetTicketsEntirePromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetTicketsEntirePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetTicketsEntirePromo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetTicketsEntirePromo.ForeColor = System.Drawing.Color.White
		Me.btnSetTicketsEntirePromo.Location = New System.Drawing.Point(54, 30)
		Me.btnSetTicketsEntirePromo.Name = "btnSetTicketsEntirePromo"
		Me.btnSetTicketsEntirePromo.Size = New System.Drawing.Size(55, 20)
		Me.btnSetTicketsEntirePromo.TabIndex = 35
		Me.btnSetTicketsEntirePromo.Text = "Set"
		Me.btnSetTicketsEntirePromo.UseVisualStyleBackColor = False
		'
		'lblTicketsEntirePromo
		'
		Me.lblTicketsEntirePromo.BackColor = System.Drawing.Color.Transparent
		Me.lblTicketsEntirePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTicketsEntirePromo.ForeColor = System.Drawing.Color.White
		Me.lblTicketsEntirePromo.Location = New System.Drawing.Point(-1, 0)
		Me.lblTicketsEntirePromo.Name = "lblTicketsEntirePromo"
		Me.lblTicketsEntirePromo.Size = New System.Drawing.Size(119, 37)
		Me.lblTicketsEntirePromo.TabIndex = 7
		Me.lblTicketsEntirePromo.Text = "Limit # of tickets for entire promo?"
		'
		'lblDescription
		'
		Me.lblDescription.BackColor = System.Drawing.Color.PapayaWhip
		Me.lblDescription.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDescription.Location = New System.Drawing.Point(5, 30)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(167, 129)
		Me.lblDescription.TabIndex = 12
		Me.lblDescription.Text = "Move mouse pointer over Amount for description."
		Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pnlAmtDescription
		'
		Me.pnlAmtDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlAmtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlAmtDescription.Controls.Add(Me.lblDescription)
		Me.pnlAmtDescription.Controls.Add(Me.lblAmtDesc)
		Me.pnlAmtDescription.Location = New System.Drawing.Point(114, 15)
		Me.pnlAmtDescription.Name = "pnlAmtDescription"
		Me.pnlAmtDescription.Size = New System.Drawing.Size(177, 172)
		Me.pnlAmtDescription.TabIndex = 13
		'
		'lblAmtDesc
		'
		Me.lblAmtDesc.AutoSize = True
		Me.lblAmtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAmtDesc.ForeColor = System.Drawing.Color.White
		Me.lblAmtDesc.Location = New System.Drawing.Point(3, 4)
		Me.lblAmtDesc.Name = "lblAmtDesc"
		Me.lblAmtDesc.Size = New System.Drawing.Size(146, 16)
		Me.lblAmtDesc.TabIndex = 14
		Me.lblAmtDesc.Text = "Amount Description:"
		'
		'pnlPromoTypeForEntry
		'
		Me.pnlPromoTypeForEntry.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoTypeForEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPromoTypeForEntry.Controls.Add(Me.PromoTypeSuccessIcon)
		Me.pnlPromoTypeForEntry.Controls.Add(Me.btnSetPromoType)
		Me.pnlPromoTypeForEntry.Controls.Add(Me.lblPromoTypeQuestion)
		Me.pnlPromoTypeForEntry.Controls.Add(Me.txtPromoType)
		Me.pnlPromoTypeForEntry.Controls.Add(Me.lblPromoType)
		Me.pnlPromoTypeForEntry.Location = New System.Drawing.Point(28, 15)
		Me.pnlPromoTypeForEntry.Name = "pnlPromoTypeForEntry"
		Me.pnlPromoTypeForEntry.Size = New System.Drawing.Size(80, 130)
		Me.pnlPromoTypeForEntry.TabIndex = 14
		'
		'PromoTypeSuccessIcon
		'
		Me.PromoTypeSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.PromoTypeSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.PromoTypeSuccessIcon.Enabled = False
		Me.PromoTypeSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.PromoTypeSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.PromoTypeSuccessIcon.Location = New System.Drawing.Point(53, 102)
		Me.PromoTypeSuccessIcon.Name = "PromoTypeSuccessIcon"
		Me.PromoTypeSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.PromoTypeSuccessIcon.TabIndex = 34
		Me.PromoTypeSuccessIcon.TabStop = False
		Me.PromoTypeSuccessIcon.ToolTipText = Nothing
		Me.PromoTypeSuccessIcon.Visible = False
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
		Me.btnSetPromoType.Location = New System.Drawing.Point(3, 102)
		Me.btnSetPromoType.Name = "btnSetPromoType"
		Me.btnSetPromoType.Size = New System.Drawing.Size(44, 20)
		Me.btnSetPromoType.TabIndex = 33
		Me.btnSetPromoType.Text = "Set"
		Me.btnSetPromoType.UseVisualStyleBackColor = False
		'
		'lblPromoTypeQuestion
		'
		Me.lblPromoTypeQuestion.BackColor = System.Drawing.Color.Transparent
		Me.lblPromoTypeQuestion.ForeColor = System.Drawing.Color.White
		Me.lblPromoTypeQuestion.Location = New System.Drawing.Point(-1, 40)
		Me.lblPromoTypeQuestion.Name = "lblPromoTypeQuestion"
		Me.lblPromoTypeQuestion.Size = New System.Drawing.Size(74, 30)
		Me.lblPromoTypeQuestion.TabIndex = 17
		Me.lblPromoTypeQuestion.Text = "What is the Entry's Type?"
		'
		'txtPromoType
		'
		Me.txtPromoType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPromoType.Location = New System.Drawing.Point(3, 73)
		Me.txtPromoType.MaxLength = 3
		Me.txtPromoType.Name = "txtPromoType"
		Me.txtPromoType.Size = New System.Drawing.Size(44, 23)
		Me.txtPromoType.TabIndex = 16
		Me.txtPromoType.Text = "EX:25"
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
		'pnlInfoNotNeeded
		'
		Me.pnlInfoNotNeeded.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlInfoNotNeeded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlInfoNotNeeded.Controls.Add(Me.Label3)
		Me.pnlInfoNotNeeded.Location = New System.Drawing.Point(114, 341)
		Me.pnlInfoNotNeeded.Name = "pnlInfoNotNeeded"
		Me.pnlInfoNotNeeded.Size = New System.Drawing.Size(343, 172)
		Me.pnlInfoNotNeeded.TabIndex = 0
		Me.pnlInfoNotNeeded.Visible = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(21, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(307, 16)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "Information not needed for PromoType 20B."
		'
		'StepEntryTicketAmt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlInfoNotNeeded)
		Me.Controls.Add(Me.pnlPromoTypeForEntry)
		Me.Controls.Add(Me.pnlPointsDivisor)
		Me.Controls.Add(Me.pnlTicketsEntirePromo)
		Me.Controls.Add(Me.pnlTicketPerPatron)
		Me.Controls.Add(Me.pnlTicketsAmount)
		Me.Controls.Add(Me.pnlAmtDescription)
		Me.Name = "StepEntryTicketAmt"
		Me.NextStep = "StepF"
		Me.PreviousStep = "StepD"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This is where ticket options are determined."
		Me.Controls.SetChildIndex(Me.pnlAmtDescription, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketsAmount, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketPerPatron, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketsEntirePromo, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlPointsDivisor, 0)
		Me.Controls.SetChildIndex(Me.pnlPromoTypeForEntry, 0)
		Me.Controls.SetChildIndex(Me.pnlInfoNotNeeded, 0)
		Me.pnlTicketsAmount.ResumeLayout(False)
		Me.pnlTicketsAmount.PerformLayout()
		Me.pnlPointsDivisor.ResumeLayout(False)
		Me.pnlPointsDivisor.PerformLayout()
		CType(Me.PointsDivisorSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlTicketPerPatron.ResumeLayout(False)
		Me.pnlTicketPerPatron.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		CType(Me.TicketsPerPatronSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlTicketsEntirePromo.ResumeLayout(False)
		Me.pnlTicketsEntirePromo.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.TicketsEntirePromoSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlAmtDescription.ResumeLayout(False)
		Me.pnlAmtDescription.PerformLayout()
		Me.pnlPromoTypeForEntry.ResumeLayout(False)
		Me.pnlPromoTypeForEntry.PerformLayout()
		CType(Me.PromoTypeSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlInfoNotNeeded.ResumeLayout(False)
		Me.pnlInfoNotNeeded.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlTicketsAmount As System.Windows.Forms.Panel
	Friend WithEvents rbCalPlusNumOfVisits As System.Windows.Forms.RadioButton
	Friend WithEvents rbCalculated As System.Windows.Forms.RadioButton
	Friend WithEvents rb1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents rbNumOfVisits As System.Windows.Forms.RadioButton
	Friend WithEvents pnlPointsDivisor As System.Windows.Forms.Panel
	Friend WithEvents txtPointsDivisor As System.Windows.Forms.TextBox
	Friend WithEvents lblPointsDivisor As System.Windows.Forms.Label
	Friend WithEvents pnlTicketPerPatron As System.Windows.Forms.Panel
	Friend WithEvents rbTicketsPerPatronNO As System.Windows.Forms.RadioButton
	Friend WithEvents rbTicketPerPatronYES As System.Windows.Forms.RadioButton
	Friend WithEvents lblTicketsPerPatron As System.Windows.Forms.Label
	Friend WithEvents pnlTicketsEntirePromo As System.Windows.Forms.Panel
	Friend WithEvents rbTicketsEntirePromoNO As System.Windows.Forms.RadioButton
	Friend WithEvents rbTicketsEntirePromoYES As System.Windows.Forms.RadioButton
	Friend WithEvents lblTicketsEntirePromo As System.Windows.Forms.Label
	Friend WithEvents txtTicketsPerPatron As System.Windows.Forms.TextBox
	Friend WithEvents txtTicketsEntirePromo As System.Windows.Forms.TextBox
	Friend WithEvents pnl1 As System.Windows.Forms.Panel
	Friend WithEvents pnlCountAndCal As System.Windows.Forms.Panel
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents pnlAmtDescription As System.Windows.Forms.Panel
	Friend WithEvents lblAmtDesc As System.Windows.Forms.Label
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents pnlPromoTypeForEntry As System.Windows.Forms.Panel
	Friend WithEvents lblPromoTypeQuestion As System.Windows.Forms.Label
	Friend WithEvents txtPromoType As System.Windows.Forms.TextBox
	Friend WithEvents lblPromoType As System.Windows.Forms.Label
	Private WithEvents btnSetPointsDivisor As System.Windows.Forms.Button
	Private WithEvents btnSetTicketsPerPatron As System.Windows.Forms.Button
	Private WithEvents btnSetPromoType As System.Windows.Forms.Button
	Private WithEvents btnSetTicketsEntirePromo As System.Windows.Forms.Button
	Private WithEvents PromoTypeSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents TicketsPerPatronSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents TicketsEntirePromoSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents PointsDivisorSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents pnlInfoNotNeeded As System.Windows.Forms.Panel
	Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

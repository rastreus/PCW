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
		Me.txtPointsDivisor = New System.Windows.Forms.TextBox()
		Me.lblPointsDivisor = New System.Windows.Forms.Label()
		Me.pnlTicketPerPatron = New System.Windows.Forms.Panel()
		Me.txtTicketsPerPatron = New System.Windows.Forms.TextBox()
		Me.rbTicketsPerPatronNO = New System.Windows.Forms.RadioButton()
		Me.rbTicketPerPatronYES = New System.Windows.Forms.RadioButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblTicketsPerPatron = New System.Windows.Forms.Label()
		Me.pnlTicketsEntirePromo = New System.Windows.Forms.Panel()
		Me.txtTicketsEntirePromo = New System.Windows.Forms.TextBox()
		Me.rbTicketsEntirePromoNO = New System.Windows.Forms.RadioButton()
		Me.rbTicketsEntirePromoYES = New System.Windows.Forms.RadioButton()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lblTicketsEntirePromo = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.pnlAmtDescription = New System.Windows.Forms.Panel()
		Me.lblAmtDesc = New System.Windows.Forms.Label()
		Me.pnlTicketsAmount.SuspendLayout()
		Me.pnlPointsDivisor.SuspendLayout()
		Me.pnlTicketPerPatron.SuspendLayout()
		Me.pnlTicketsEntirePromo.SuspendLayout()
		Me.pnlAmtDescription.SuspendLayout()
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
		Me.pnlTicketsAmount.Location = New System.Drawing.Point(224, 43)
		Me.pnlTicketsAmount.Name = "pnlTicketsAmount"
		Me.pnlTicketsAmount.Size = New System.Drawing.Size(160, 172)
		Me.pnlTicketsAmount.TabIndex = 2
		'
		'rbNumOfVisits
		'
		Me.rbNumOfVisits.AutoSize = True
		Me.rbNumOfVisits.BackColor = System.Drawing.Color.PaleTurquoise
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
		Me.pnlPointsDivisor.Controls.Add(Me.txtPointsDivisor)
		Me.pnlPointsDivisor.Controls.Add(Me.lblPointsDivisor)
		Me.pnlPointsDivisor.Enabled = False
		Me.pnlPointsDivisor.Location = New System.Drawing.Point(278, 221)
		Me.pnlPointsDivisor.Name = "pnlPointsDivisor"
		Me.pnlPointsDivisor.Size = New System.Drawing.Size(106, 49)
		Me.pnlPointsDivisor.TabIndex = 11
		Me.pnlPointsDivisor.Visible = False
		'
		'txtPointsDivisor
		'
		Me.txtPointsDivisor.Location = New System.Drawing.Point(2, 21)
		Me.txtPointsDivisor.MaxLength = 6
		Me.txtPointsDivisor.Name = "txtPointsDivisor"
		Me.txtPointsDivisor.Size = New System.Drawing.Size(100, 20)
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
		Me.pnlTicketPerPatron.Location = New System.Drawing.Point(390, 43)
		Me.pnlTicketPerPatron.Name = "pnlTicketPerPatron"
		Me.pnlTicketPerPatron.Size = New System.Drawing.Size(154, 83)
		Me.pnlTicketPerPatron.TabIndex = 4
		'
		'txtTicketsPerPatron
		'
		Me.txtTicketsPerPatron.Enabled = False
		Me.txtTicketsPerPatron.Location = New System.Drawing.Point(57, 37)
		Me.txtTicketsPerPatron.MaxLength = 6
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
		Me.Panel1.Location = New System.Drawing.Point(1, 31)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(148, 47)
		Me.Panel1.TabIndex = 10
		'
		'lblTicketsPerPatron
		'
		Me.lblTicketsPerPatron.BackColor = System.Drawing.Color.Transparent
		Me.lblTicketsPerPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTicketsPerPatron.ForeColor = System.Drawing.Color.White
		Me.lblTicketsPerPatron.Location = New System.Drawing.Point(-1, 0)
		Me.lblTicketsPerPatron.Name = "lblTicketsPerPatron"
		Me.lblTicketsPerPatron.Size = New System.Drawing.Size(139, 38)
		Me.lblTicketsPerPatron.TabIndex = 6
		Me.lblTicketsPerPatron.Text = "Limit # of tickets per patron?"
		'
		'pnlTicketsEntirePromo
		'
		Me.pnlTicketsEntirePromo.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlTicketsEntirePromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlTicketsEntirePromo.Controls.Add(Me.txtTicketsEntirePromo)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.rbTicketsEntirePromoNO)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.rbTicketsEntirePromoYES)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.Panel2)
		Me.pnlTicketsEntirePromo.Controls.Add(Me.lblTicketsEntirePromo)
		Me.pnlTicketsEntirePromo.Location = New System.Drawing.Point(390, 132)
		Me.pnlTicketsEntirePromo.Name = "pnlTicketsEntirePromo"
		Me.pnlTicketsEntirePromo.Size = New System.Drawing.Size(154, 83)
		Me.pnlTicketsEntirePromo.TabIndex = 5
		'
		'txtTicketsEntirePromo
		'
		Me.txtTicketsEntirePromo.Enabled = False
		Me.txtTicketsEntirePromo.Location = New System.Drawing.Point(56, 36)
		Me.txtTicketsEntirePromo.MaxLength = 6
		Me.txtTicketsEntirePromo.Name = "txtTicketsEntirePromo"
		Me.txtTicketsEntirePromo.Size = New System.Drawing.Size(81, 20)
		Me.txtTicketsEntirePromo.TabIndex = 10
		Me.txtTicketsEntirePromo.Text = "Enter # Here"
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
		Me.Panel2.Location = New System.Drawing.Point(1, 31)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(148, 47)
		Me.Panel2.TabIndex = 11
		'
		'lblTicketsEntirePromo
		'
		Me.lblTicketsEntirePromo.BackColor = System.Drawing.Color.Transparent
		Me.lblTicketsEntirePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTicketsEntirePromo.ForeColor = System.Drawing.Color.White
		Me.lblTicketsEntirePromo.Location = New System.Drawing.Point(-1, 0)
		Me.lblTicketsEntirePromo.Name = "lblTicketsEntirePromo"
		Me.lblTicketsEntirePromo.Size = New System.Drawing.Size(139, 37)
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
		Me.pnlAmtDescription.Location = New System.Drawing.Point(41, 43)
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
		Me.lblAmtDesc.Size = New System.Drawing.Size(150, 16)
		Me.lblAmtDesc.TabIndex = 14
		Me.lblAmtDesc.Text = "Amount Description:"
		'
		'StepEntryTicketAmt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlPointsDivisor)
		Me.Controls.Add(Me.pnlTicketsEntirePromo)
		Me.Controls.Add(Me.pnlTicketPerPatron)
		Me.Controls.Add(Me.pnlTicketsAmount)
		Me.Controls.Add(Me.pnlAmtDescription)
		Me.Name = "StepEntryTicketAmt"
		Me.NextStep = "StepH"
		Me.PreviousStep = "StepF"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This is where ticket options are determined."
		Me.Controls.SetChildIndex(Me.pnlAmtDescription, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketsAmount, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketPerPatron, 0)
		Me.Controls.SetChildIndex(Me.pnlTicketsEntirePromo, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlPointsDivisor, 0)
		Me.pnlTicketsAmount.ResumeLayout(False)
		Me.pnlTicketsAmount.PerformLayout()
		Me.pnlPointsDivisor.ResumeLayout(False)
		Me.pnlPointsDivisor.PerformLayout()
		Me.pnlTicketPerPatron.ResumeLayout(False)
		Me.pnlTicketPerPatron.PerformLayout()
		Me.pnlTicketsEntirePromo.ResumeLayout(False)
		Me.pnlTicketsEntirePromo.PerformLayout()
		Me.pnlAmtDescription.ResumeLayout(False)
		Me.pnlAmtDescription.PerformLayout()
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

End Class

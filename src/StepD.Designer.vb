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
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton7 = New System.Windows.Forms.RadioButton()
		Me.rbMultiPartEntryPayout = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.txtNumOfDaysTiers = New System.Windows.Forms.TextBox()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.pnlPointCutoffLimit = New System.Windows.Forms.Panel()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.RadioButton17 = New System.Windows.Forms.RadioButton()
		Me.RadioButton16 = New System.Windows.Forms.RadioButton()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.pnlDragOffer = New System.Windows.Forms.Panel()
		Me.SuccessIcon = New FontAwesomeIcons.IconButton()
		Me.lblDragOffer = New System.Windows.Forms.Label()
		Me.rbEligiblePlayersOfferList = New System.Windows.Forms.RadioButton()
		Me.rbAutoQualification = New System.Windows.Forms.RadioButton()
		Me.rbSumLifetimePoints = New System.Windows.Forms.RadioButton()
		Me.rbSumQualifyingPoints = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.pnlPointCutoffLimit.SuspendLayout()
		Me.pnlDragOffer.SuspendLayout()
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel6.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Of the four available types, which will this promo be?"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.RadioButton1)
		Me.Panel2.Controls.Add(Me.RadioButton7)
		Me.Panel2.Controls.Add(Me.rbMultiPartEntryPayout)
		Me.Panel2.Controls.Add(Me.RadioButton3)
		Me.Panel2.Controls.Add(Me.RadioButton2)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Controls.Add(Me.Panel1)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Controls.Add(Me.Panel4)
		Me.Panel2.Location = New System.Drawing.Point(24, 34)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(259, 238)
		Me.Panel2.TabIndex = 3
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.BackColor = System.Drawing.Color.Aquamarine
		Me.RadioButton1.Location = New System.Drawing.Point(7, 77)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(148, 17)
		Me.RadioButton1.TabIndex = 11
		Me.RadioButton1.Text = "Single Event: Payout Only"
		Me.RadioButton1.UseVisualStyleBackColor = False
		'
		'RadioButton7
		'
		Me.RadioButton7.AutoSize = True
		Me.RadioButton7.BackColor = System.Drawing.Color.Aquamarine
		Me.RadioButton7.Checked = True
		Me.RadioButton7.Location = New System.Drawing.Point(7, 31)
		Me.RadioButton7.Name = "RadioButton7"
		Me.RadioButton7.Size = New System.Drawing.Size(172, 17)
		Me.RadioButton7.TabIndex = 10
		Me.RadioButton7.TabStop = True
		Me.RadioButton7.Text = "Single Event: Entry and Payout"
		Me.RadioButton7.UseVisualStyleBackColor = False
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
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.BackColor = System.Drawing.Color.Lavender
		Me.RadioButton3.Location = New System.Drawing.Point(7, 184)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(76, 17)
		Me.RadioButton3.TabIndex = 6
		Me.RadioButton3.Text = "Acquisition"
		Me.RadioButton3.UseVisualStyleBackColor = False
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.BackColor = System.Drawing.Color.Aquamarine
		Me.RadioButton2.Location = New System.Drawing.Point(7, 54)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(139, 17)
		Me.RadioButton2.TabIndex = 5
		Me.RadioButton2.Text = "Single Event: Entry Only"
		Me.RadioButton2.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(247, 16)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "What is the type of the new promo?"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Aquamarine
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Location = New System.Drawing.Point(3, 23)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(251, 78)
		Me.Panel1.TabIndex = 12
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel3.Controls.Add(Me.txtNumOfDaysTiers)
		Me.Panel3.Location = New System.Drawing.Point(3, 107)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(251, 57)
		Me.Panel3.TabIndex = 13
		'
		'txtNumOfDaysTiers
		'
		Me.txtNumOfDaysTiers.BackColor = System.Drawing.SystemColors.HighlightText
		Me.txtNumOfDaysTiers.Enabled = False
		Me.txtNumOfDaysTiers.Location = New System.Drawing.Point(26, 26)
		Me.txtNumOfDaysTiers.Name = "txtNumOfDaysTiers"
		Me.txtNumOfDaysTiers.Size = New System.Drawing.Size(115, 20)
		Me.txtNumOfDaysTiers.TabIndex = 9
		Me.txtNumOfDaysTiers.Text = "How many days/tiers?"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Lavender
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel4.Location = New System.Drawing.Point(3, 170)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(251, 43)
		Me.Panel4.TabIndex = 14
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel5.Controls.Add(Me.Panel6)
		Me.Panel5.Controls.Add(Me.pnlPointCutoffLimit)
		Me.Panel5.Controls.Add(Me.pnlDragOffer)
		Me.Panel5.Controls.Add(Me.Label1)
		Me.Panel5.Location = New System.Drawing.Point(290, 34)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(265, 238)
		Me.Panel5.TabIndex = 4
		'
		'pnlPointCutoffLimit
		'
		Me.pnlPointCutoffLimit.BackColor = System.Drawing.Color.Moccasin
		Me.pnlPointCutoffLimit.Controls.Add(Me.TextBox8)
		Me.pnlPointCutoffLimit.Controls.Add(Me.RadioButton17)
		Me.pnlPointCutoffLimit.Controls.Add(Me.RadioButton16)
		Me.pnlPointCutoffLimit.Controls.Add(Me.Label9)
		Me.pnlPointCutoffLimit.Location = New System.Drawing.Point(18, 148)
		Me.pnlPointCutoffLimit.Name = "pnlPointCutoffLimit"
		Me.pnlPointCutoffLimit.Size = New System.Drawing.Size(224, 80)
		Me.pnlPointCutoffLimit.TabIndex = 9
		'
		'TextBox8
		'
		Me.TextBox8.Enabled = False
		Me.TextBox8.Location = New System.Drawing.Point(53, 40)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.Size = New System.Drawing.Size(143, 20)
		Me.TextBox8.TabIndex = 10
		Me.TextBox8.Text = "Enter Point Cutoff limit here"
		'
		'RadioButton17
		'
		Me.RadioButton17.AutoSize = True
		Me.RadioButton17.Checked = True
		Me.RadioButton17.Location = New System.Drawing.Point(4, 61)
		Me.RadioButton17.Name = "RadioButton17"
		Me.RadioButton17.Size = New System.Drawing.Size(39, 17)
		Me.RadioButton17.TabIndex = 9
		Me.RadioButton17.TabStop = True
		Me.RadioButton17.Text = "No"
		Me.RadioButton17.UseVisualStyleBackColor = True
		'
		'RadioButton16
		'
		Me.RadioButton16.AutoSize = True
		Me.RadioButton16.Location = New System.Drawing.Point(4, 41)
		Me.RadioButton16.Name = "RadioButton16"
		Me.RadioButton16.Size = New System.Drawing.Size(43, 17)
		Me.RadioButton16.TabIndex = 8
		Me.RadioButton16.Text = "Yes"
		Me.RadioButton16.UseVisualStyleBackColor = True
		'
		'Label9
		'
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(235, 37)
		Me.Label9.TabIndex = 7
		Me.Label9.Text = "Is there a Point Cutoff limit in order to qualify for the promo?"
		'
		'pnlDragOffer
		'
		Me.pnlDragOffer.AllowDrop = True
		Me.pnlDragOffer.BackColor = System.Drawing.Color.LemonChiffon
		Me.pnlDragOffer.Controls.Add(Me.SuccessIcon)
		Me.pnlDragOffer.Controls.Add(Me.lblDragOffer)
		Me.pnlDragOffer.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pnlDragOffer.Enabled = False
		Me.pnlDragOffer.Location = New System.Drawing.Point(18, 154)
		Me.pnlDragOffer.Name = "pnlDragOffer"
		Me.pnlDragOffer.Size = New System.Drawing.Size(214, 74)
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
		Me.lblDragOffer.Location = New System.Drawing.Point(3, 13)
		Me.lblDragOffer.Name = "lblDragOffer"
		Me.lblDragOffer.Size = New System.Drawing.Size(208, 61)
		Me.lblDragOffer.TabIndex = 0
		Me.lblDragOffer.Text = "(Drag Offer List .CSV File Here)"
		Me.lblDragOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'rbEligiblePlayersOfferList
		'
		Me.rbEligiblePlayersOfferList.AutoSize = True
		Me.rbEligiblePlayersOfferList.BackColor = System.Drawing.Color.LemonChiffon
		Me.rbEligiblePlayersOfferList.Location = New System.Drawing.Point(3, 93)
		Me.rbEligiblePlayersOfferList.Name = "rbEligiblePlayersOfferList"
		Me.rbEligiblePlayersOfferList.Size = New System.Drawing.Size(248, 17)
		Me.rbEligiblePlayersOfferList.TabIndex = 8
		Me.rbEligiblePlayersOfferList.Text = "EligiblePlayers offer list Determines Qualification"
		Me.rbEligiblePlayersOfferList.UseVisualStyleBackColor = False
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
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(259, 16)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "How is player eligibility determined?"
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.Moccasin
		Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel6.Controls.Add(Me.rbEligiblePlayersOfferList)
		Me.Panel6.Controls.Add(Me.rbSumQualifyingPoints)
		Me.Panel6.Controls.Add(Me.rbSumLifetimePoints)
		Me.Panel6.Controls.Add(Me.rbAutoQualification)
		Me.Panel6.Controls.Add(Me.Panel7)
		Me.Panel6.Location = New System.Drawing.Point(3, 22)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(255, 120)
		Me.Panel6.TabIndex = 10
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
		'StepD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel2)
		Me.Name = "StepD"
		Me.NextStep = "StepE"
		Me.PreviousStep = "StepC"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Of the four available types, which will this promo be?"
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Controls.SetChildIndex(Me.Panel5, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.pnlPointCutoffLimit.ResumeLayout(False)
		Me.pnlPointCutoffLimit.PerformLayout()
		Me.pnlDragOffer.ResumeLayout(False)
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
	Friend WithEvents txtNumOfDaysTiers As System.Windows.Forms.TextBox
	Friend WithEvents rbMultiPartEntryPayout As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents Panel4 As System.Windows.Forms.Panel
	Friend WithEvents Panel5 As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents rbEligiblePlayersOfferList As System.Windows.Forms.RadioButton
	Friend WithEvents rbAutoQualification As System.Windows.Forms.RadioButton
	Friend WithEvents rbSumLifetimePoints As System.Windows.Forms.RadioButton
	Friend WithEvents rbSumQualifyingPoints As System.Windows.Forms.RadioButton
	Friend WithEvents pnlDragOffer As System.Windows.Forms.Panel
	Friend WithEvents lblDragOffer As System.Windows.Forms.Label
	Friend WithEvents SuccessIcon As FontAwesomeIcons.IconButton
	Friend WithEvents pnlPointCutoffLimit As System.Windows.Forms.Panel
	Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
	Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Panel6 As System.Windows.Forms.Panel
	Friend WithEvents Panel7 As System.Windows.Forms.Panel

End Class

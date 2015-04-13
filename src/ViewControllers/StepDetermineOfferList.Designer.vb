<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepDetermineOfferList
	Inherits TSWizards.BaseInteriorStep

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
			If disposing AndAlso components IsNot Nothing Then
				Me.stepDetermineOfferList_data.Dispose()
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
		Me.pnlMonthCal = New System.Windows.Forms.Panel()
		Me.MonthCal = New System.Windows.Forms.MonthCalendar()
		Me.pnlExclusionDays = New System.Windows.Forms.Panel()
		Me.cbSelectAll = New System.Windows.Forms.CheckBox()
		Me.lblExcludedDays = New System.Windows.Forms.Label()
		Me.clbExcludedDays = New System.Windows.Forms.CheckedListBox()
		Me.pnlExcludePeriod = New System.Windows.Forms.Panel()
		Me.pnlExcludeStart = New System.Windows.Forms.Panel()
		Me.dtpExcludeStart = New System.Windows.Forms.DateTimePicker()
		Me.lblExcludeStart = New System.Windows.Forms.Label()
		Me.pnlExcludeEnd = New System.Windows.Forms.Panel()
		Me.dtpExcludeEnd = New System.Windows.Forms.DateTimePicker()
		Me.lblExcludeEnd = New System.Windows.Forms.Label()
		Me.pnlValidPeriod = New System.Windows.Forms.Panel()
		Me.pnlValidStart = New System.Windows.Forms.Panel()
		Me.dtpValidStart = New System.Windows.Forms.DateTimePicker()
		Me.lblValidStart = New System.Windows.Forms.Label()
		Me.pnlValidEnd = New System.Windows.Forms.Panel()
		Me.dtpValidEnd = New System.Windows.Forms.DateTimePicker()
		Me.lblValidEnd = New System.Windows.Forms.Label()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.lblCouponOffers = New System.Windows.Forms.Label()
		Me.pnlCouponOffers = New System.Windows.Forms.Panel()
		Me.lblCouponOffersList = New System.Windows.Forms.Label()
		Me.pnlMonthCal.SuspendLayout()
		Me.pnlExclusionDays.SuspendLayout()
		Me.pnlExcludePeriod.SuspendLayout()
		Me.pnlExcludeStart.SuspendLayout()
		Me.pnlExcludeEnd.SuspendLayout()
		Me.pnlValidPeriod.SuspendLayout()
		Me.pnlValidStart.SuspendLayout()
		Me.pnlValidEnd.SuspendLayout()
		Me.pnlCouponOffers.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Drag and drop Offer Lists here."
		'
		'pnlMonthCal
		'
		Me.pnlMonthCal.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlMonthCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMonthCal.Controls.Add(Me.MonthCal)
		Me.pnlMonthCal.Location = New System.Drawing.Point(3, 100)
		Me.pnlMonthCal.Name = "pnlMonthCal"
		Me.pnlMonthCal.Size = New System.Drawing.Size(220, 192)
		Me.pnlMonthCal.TabIndex = 28
		'
		'MonthCal
		'
		Me.MonthCal.BackColor = System.Drawing.Color.White
		Me.MonthCal.Cursor = System.Windows.Forms.Cursors.No
		Me.MonthCal.Enabled = False
		Me.MonthCal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MonthCal.Location = New System.Drawing.Point(6, 11)
		Me.MonthCal.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
		Me.MonthCal.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
		Me.MonthCal.Name = "MonthCal"
		Me.MonthCal.ShowToday = False
		Me.MonthCal.ShowTodayCircle = False
		Me.MonthCal.TabIndex = 15
		Me.MonthCal.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.MonthCal.TitleForeColor = System.Drawing.Color.Gold
		Me.MonthCal.TrailingForeColor = System.Drawing.Color.Gray
		Me.MonthCal.Visible = False
		'
		'pnlExclusionDays
		'
		Me.pnlExclusionDays.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlExclusionDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlExclusionDays.Controls.Add(Me.cbSelectAll)
		Me.pnlExclusionDays.Controls.Add(Me.lblExcludedDays)
		Me.pnlExclusionDays.Controls.Add(Me.clbExcludedDays)
		Me.pnlExclusionDays.Location = New System.Drawing.Point(229, 100)
		Me.pnlExclusionDays.Name = "pnlExclusionDays"
		Me.pnlExclusionDays.Size = New System.Drawing.Size(172, 192)
		Me.pnlExclusionDays.TabIndex = 27
		'
		'cbSelectAll
		'
		Me.cbSelectAll.AutoSize = True
		Me.cbSelectAll.Checked = True
		Me.cbSelectAll.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSelectAll.ForeColor = System.Drawing.Color.Lime
		Me.cbSelectAll.Location = New System.Drawing.Point(21, 163)
		Me.cbSelectAll.Name = "cbSelectAll"
		Me.cbSelectAll.Size = New System.Drawing.Size(80, 17)
		Me.cbSelectAll.TabIndex = 7
		Me.cbSelectAll.Text = "Select All"
		Me.cbSelectAll.UseVisualStyleBackColor = True
		'
		'lblExcludedDays
		'
		Me.lblExcludedDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludedDays.ForeColor = System.Drawing.Color.White
		Me.lblExcludedDays.Location = New System.Drawing.Point(3, 0)
		Me.lblExcludedDays.Name = "lblExcludedDays"
		Me.lblExcludedDays.Size = New System.Drawing.Size(165, 49)
		Me.lblExcludedDays.TabIndex = 0
		Me.lblExcludedDays.Text = "On which day(s), within the exclusion period, will offer be excluded?"
		'
		'clbExcludedDays
		'
		Me.clbExcludedDays.BackColor = System.Drawing.Color.PaleTurquoise
		Me.clbExcludedDays.CheckOnClick = True
		Me.clbExcludedDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.clbExcludedDays.FormattingEnabled = True
		Me.clbExcludedDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.clbExcludedDays.Location = New System.Drawing.Point(19, 52)
		Me.clbExcludedDays.Name = "clbExcludedDays"
		Me.clbExcludedDays.Size = New System.Drawing.Size(103, 109)
		Me.clbExcludedDays.TabIndex = 6
		Me.clbExcludedDays.ThreeDCheckBoxes = True
		'
		'pnlExcludePeriod
		'
		Me.pnlExcludePeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlExcludePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlExcludePeriod.Controls.Add(Me.pnlExcludeStart)
		Me.pnlExcludePeriod.Controls.Add(Me.pnlExcludeEnd)
		Me.pnlExcludePeriod.Location = New System.Drawing.Point(229, 5)
		Me.pnlExcludePeriod.Name = "pnlExcludePeriod"
		Me.pnlExcludePeriod.Size = New System.Drawing.Size(220, 89)
		Me.pnlExcludePeriod.TabIndex = 29
		'
		'pnlExcludeStart
		'
		Me.pnlExcludeStart.BackColor = System.Drawing.Color.Pink
		Me.pnlExcludeStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlExcludeStart.Controls.Add(Me.dtpExcludeStart)
		Me.pnlExcludeStart.Controls.Add(Me.lblExcludeStart)
		Me.pnlExcludeStart.Location = New System.Drawing.Point(0, 3)
		Me.pnlExcludeStart.Name = "pnlExcludeStart"
		Me.pnlExcludeStart.Size = New System.Drawing.Size(107, 80)
		Me.pnlExcludeStart.TabIndex = 0
		'
		'dtpExcludeStart
		'
		Me.dtpExcludeStart.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpExcludeStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpExcludeStart.Location = New System.Drawing.Point(3, 53)
		Me.dtpExcludeStart.Name = "dtpExcludeStart"
		Me.dtpExcludeStart.Size = New System.Drawing.Size(95, 20)
		Me.dtpExcludeStart.TabIndex = 1
		'
		'lblExcludeStart
		'
		Me.lblExcludeStart.BackColor = System.Drawing.Color.Transparent
		Me.lblExcludeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludeStart.Location = New System.Drawing.Point(0, 0)
		Me.lblExcludeStart.Name = "lblExcludeStart"
		Me.lblExcludeStart.Size = New System.Drawing.Size(106, 48)
		Me.lblExcludeStart.TabIndex = 0
		Me.lblExcludeStart.Text = "When does the exclusion period start?"
		'
		'pnlExcludeEnd
		'
		Me.pnlExcludeEnd.BackColor = System.Drawing.Color.Pink
		Me.pnlExcludeEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlExcludeEnd.Controls.Add(Me.dtpExcludeEnd)
		Me.pnlExcludeEnd.Controls.Add(Me.lblExcludeEnd)
		Me.pnlExcludeEnd.Location = New System.Drawing.Point(113, 3)
		Me.pnlExcludeEnd.Name = "pnlExcludeEnd"
		Me.pnlExcludeEnd.Size = New System.Drawing.Size(107, 80)
		Me.pnlExcludeEnd.TabIndex = 0
		'
		'dtpExcludeEnd
		'
		Me.dtpExcludeEnd.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpExcludeEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpExcludeEnd.Location = New System.Drawing.Point(3, 53)
		Me.dtpExcludeEnd.Name = "dtpExcludeEnd"
		Me.dtpExcludeEnd.Size = New System.Drawing.Size(95, 20)
		Me.dtpExcludeEnd.TabIndex = 2
		'
		'lblExcludeEnd
		'
		Me.lblExcludeEnd.BackColor = System.Drawing.Color.Transparent
		Me.lblExcludeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludeEnd.Location = New System.Drawing.Point(0, 0)
		Me.lblExcludeEnd.Name = "lblExcludeEnd"
		Me.lblExcludeEnd.Size = New System.Drawing.Size(105, 48)
		Me.lblExcludeEnd.TabIndex = 0
		Me.lblExcludeEnd.Text = "When does the exclusion period end?"
		'
		'pnlValidPeriod
		'
		Me.pnlValidPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlValidPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlValidPeriod.Controls.Add(Me.pnlValidStart)
		Me.pnlValidPeriod.Controls.Add(Me.pnlValidEnd)
		Me.pnlValidPeriod.Location = New System.Drawing.Point(3, 5)
		Me.pnlValidPeriod.Name = "pnlValidPeriod"
		Me.pnlValidPeriod.Size = New System.Drawing.Size(220, 89)
		Me.pnlValidPeriod.TabIndex = 30
		'
		'pnlValidStart
		'
		Me.pnlValidStart.BackColor = System.Drawing.Color.PaleGreen
		Me.pnlValidStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlValidStart.Controls.Add(Me.dtpValidStart)
		Me.pnlValidStart.Controls.Add(Me.lblValidStart)
		Me.pnlValidStart.Location = New System.Drawing.Point(0, 3)
		Me.pnlValidStart.Name = "pnlValidStart"
		Me.pnlValidStart.Size = New System.Drawing.Size(107, 80)
		Me.pnlValidStart.TabIndex = 0
		'
		'dtpValidStart
		'
		Me.dtpValidStart.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpValidStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpValidStart.Location = New System.Drawing.Point(3, 53)
		Me.dtpValidStart.Name = "dtpValidStart"
		Me.dtpValidStart.Size = New System.Drawing.Size(95, 20)
		Me.dtpValidStart.TabIndex = 1
		'
		'lblValidStart
		'
		Me.lblValidStart.BackColor = System.Drawing.Color.Transparent
		Me.lblValidStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValidStart.Location = New System.Drawing.Point(0, 0)
		Me.lblValidStart.Name = "lblValidStart"
		Me.lblValidStart.Size = New System.Drawing.Size(106, 48)
		Me.lblValidStart.TabIndex = 0
		Me.lblValidStart.Text = "When does the valid period start?"
		'
		'pnlValidEnd
		'
		Me.pnlValidEnd.BackColor = System.Drawing.Color.PaleGreen
		Me.pnlValidEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlValidEnd.Controls.Add(Me.dtpValidEnd)
		Me.pnlValidEnd.Controls.Add(Me.lblValidEnd)
		Me.pnlValidEnd.Location = New System.Drawing.Point(113, 3)
		Me.pnlValidEnd.Name = "pnlValidEnd"
		Me.pnlValidEnd.Size = New System.Drawing.Size(107, 80)
		Me.pnlValidEnd.TabIndex = 0
		'
		'dtpValidEnd
		'
		Me.dtpValidEnd.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpValidEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpValidEnd.Location = New System.Drawing.Point(3, 53)
		Me.dtpValidEnd.Name = "dtpValidEnd"
		Me.dtpValidEnd.Size = New System.Drawing.Size(95, 20)
		Me.dtpValidEnd.TabIndex = 2
		'
		'lblValidEnd
		'
		Me.lblValidEnd.BackColor = System.Drawing.Color.Transparent
		Me.lblValidEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValidEnd.Location = New System.Drawing.Point(0, 0)
		Me.lblValidEnd.Name = "lblValidEnd"
		Me.lblValidEnd.Size = New System.Drawing.Size(106, 48)
		Me.lblValidEnd.TabIndex = 0
		Me.lblValidEnd.Text = "When does the valid period end?"
		'
		'btnSubmit
		'
		Me.btnSubmit.BackColor = System.Drawing.Color.MediumPurple
		Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
		Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue
		Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmit.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmit.ForeColor = System.Drawing.Color.White
		Me.btnSubmit.Location = New System.Drawing.Point(6, 158)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(132, 26)
		Me.btnSubmit.TabIndex = 31
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSubmit.UseVisualStyleBackColor = False
		'
		'lblCouponOffers
		'
		Me.lblCouponOffers.BackColor = System.Drawing.Color.Transparent
		Me.lblCouponOffers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponOffers.ForeColor = System.Drawing.Color.White
		Me.lblCouponOffers.Location = New System.Drawing.Point(3, 0)
		Me.lblCouponOffers.Name = "lblCouponOffers"
		Me.lblCouponOffers.Size = New System.Drawing.Size(143, 23)
		Me.lblCouponOffers.TabIndex = 32
		Me.lblCouponOffers.Text = "Coupon Offers List:"
		'
		'pnlCouponOffers
		'
		Me.pnlCouponOffers.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCouponOffers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCouponOffers.Controls.Add(Me.lblCouponOffersList)
		Me.pnlCouponOffers.Controls.Add(Me.lblCouponOffers)
		Me.pnlCouponOffers.Controls.Add(Me.btnSubmit)
		Me.pnlCouponOffers.Location = New System.Drawing.Point(407, 100)
		Me.pnlCouponOffers.Name = "pnlCouponOffers"
		Me.pnlCouponOffers.Size = New System.Drawing.Size(148, 192)
		Me.pnlCouponOffers.TabIndex = 33
		'
		'lblCouponOffersList
		'
		Me.lblCouponOffersList.BackColor = System.Drawing.Color.Gainsboro
		Me.lblCouponOffersList.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponOffersList.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblCouponOffersList.Location = New System.Drawing.Point(6, 23)
		Me.lblCouponOffersList.Name = "lblCouponOffersList"
		Me.lblCouponOffersList.Size = New System.Drawing.Size(132, 132)
		Me.lblCouponOffersList.TabIndex = 33
		Me.lblCouponOffersList.Text = "Click 'Submit' below to add Coupon Offers to this Coupon ID."
		Me.lblCouponOffersList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'StepDetermineOfferList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlCouponOffers)
		Me.Controls.Add(Me.pnlValidPeriod)
		Me.Controls.Add(Me.pnlExcludePeriod)
		Me.Controls.Add(Me.pnlMonthCal)
		Me.Controls.Add(Me.pnlExclusionDays)
		Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Name = "StepDetermineOfferList"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Drag and drop Offer Lists here."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlExclusionDays, 0)
		Me.Controls.SetChildIndex(Me.pnlMonthCal, 0)
		Me.Controls.SetChildIndex(Me.pnlExcludePeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlValidPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlCouponOffers, 0)
		Me.pnlMonthCal.ResumeLayout(False)
		Me.pnlExclusionDays.ResumeLayout(False)
		Me.pnlExclusionDays.PerformLayout()
		Me.pnlExcludePeriod.ResumeLayout(False)
		Me.pnlExcludeStart.ResumeLayout(False)
		Me.pnlExcludeEnd.ResumeLayout(False)
		Me.pnlValidPeriod.ResumeLayout(False)
		Me.pnlValidStart.ResumeLayout(False)
		Me.pnlValidEnd.ResumeLayout(False)
		Me.pnlCouponOffers.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlMonthCal As System.Windows.Forms.Panel
	Friend WithEvents MonthCal As System.Windows.Forms.MonthCalendar
	Friend WithEvents pnlExclusionDays As System.Windows.Forms.Panel
	Friend WithEvents cbSelectAll As System.Windows.Forms.CheckBox
	Friend WithEvents lblExcludedDays As System.Windows.Forms.Label
	Friend WithEvents clbExcludedDays As System.Windows.Forms.CheckedListBox
	Friend WithEvents pnlExcludePeriod As System.Windows.Forms.Panel
	Friend WithEvents pnlExcludeStart As System.Windows.Forms.Panel
	Friend WithEvents dtpExcludeStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblExcludeStart As System.Windows.Forms.Label
	Friend WithEvents pnlExcludeEnd As System.Windows.Forms.Panel
	Friend WithEvents dtpExcludeEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblExcludeEnd As System.Windows.Forms.Label
	Friend WithEvents pnlValidPeriod As System.Windows.Forms.Panel
	Friend WithEvents pnlValidStart As System.Windows.Forms.Panel
	Friend WithEvents dtpValidStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblValidStart As System.Windows.Forms.Label
	Friend WithEvents pnlValidEnd As System.Windows.Forms.Panel
	Friend WithEvents dtpValidEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblValidEnd As System.Windows.Forms.Label
	Friend WithEvents btnSubmit As System.Windows.Forms.Button
	Friend WithEvents lblCouponOffers As System.Windows.Forms.Label
	Friend WithEvents pnlCouponOffers As System.Windows.Forms.Panel
	Friend WithEvents lblCouponOffersList As System.Windows.Forms.Label

End Class

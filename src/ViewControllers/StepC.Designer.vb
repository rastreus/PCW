<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepC
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
		Me.pnlRedemptionDays = New System.Windows.Forms.Panel()
		Me.pnlCbRedemptionDays = New System.Windows.Forms.Panel()
		Me.cbSaturday = New System.Windows.Forms.CheckBox()
		Me.cbFriday = New System.Windows.Forms.CheckBox()
		Me.cbThursday = New System.Windows.Forms.CheckBox()
		Me.cbWednesday = New System.Windows.Forms.CheckBox()
		Me.cbTuesday = New System.Windows.Forms.CheckBox()
		Me.cbMonday = New System.Windows.Forms.CheckBox()
		Me.cbSunday = New System.Windows.Forms.CheckBox()
		Me.lblPrimaryDay = New System.Windows.Forms.Label()
		Me.lblRedemptionDays = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.cbSelectAll = New System.Windows.Forms.CheckBox()
		Me.lblPointsEarningDays = New System.Windows.Forms.Label()
		Me.clbPointsEarningDays = New System.Windows.Forms.CheckedListBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.dtpQualifyingStart = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.dtpQualifyingEnd = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lblQualifyingEnd = New System.Windows.Forms.Label()
		Me.lblQualifyingStart = New System.Windows.Forms.Label()
		Me.cbSameDayPromo = New System.Windows.Forms.CheckBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.dtpOccursDate = New System.Windows.Forms.DateTimePicker()
		Me.MonthCal = New System.Windows.Forms.MonthCalendar()
		Me.pnlOccuringQualifyingPeriod = New System.Windows.Forms.Panel()
		Me.pnlOccursDate = New System.Windows.Forms.Panel()
		Me.pnlMonthCal = New System.Windows.Forms.Panel()
		Me.pnlRecurringQualifyingPeriod = New System.Windows.Forms.Panel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.pnlPrimaryDay = New System.Windows.Forms.Panel()
		Me.cbPrimaryDay = New System.Windows.Forms.ComboBox()
		Me.yetAnotherLabel = New System.Windows.Forms.Label()
		Me.pnlRedemptionDays.SuspendLayout()
		Me.pnlCbRedemptionDays.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.pnlOccuringQualifyingPeriod.SuspendLayout()
		Me.pnlOccursDate.SuspendLayout()
		Me.pnlMonthCal.SuspendLayout()
		Me.pnlRecurringQualifyingPeriod.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.pnlPrimaryDay.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Set the date information for the promotional."
		'
		'pnlRedemptionDays
		'
		Me.pnlRedemptionDays.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlRedemptionDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlRedemptionDays.Controls.Add(Me.pnlCbRedemptionDays)
		Me.pnlRedemptionDays.Controls.Add(Me.lblPrimaryDay)
		Me.pnlRedemptionDays.Controls.Add(Me.lblRedemptionDays)
		Me.pnlRedemptionDays.Location = New System.Drawing.Point(229, 10)
		Me.pnlRedemptionDays.Name = "pnlRedemptionDays"
		Me.pnlRedemptionDays.Size = New System.Drawing.Size(174, 192)
		Me.pnlRedemptionDays.TabIndex = 0
		'
		'pnlCbRedemptionDays
		'
		Me.pnlCbRedemptionDays.BackColor = System.Drawing.Color.Lavender
		Me.pnlCbRedemptionDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbSaturday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbFriday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbThursday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbWednesday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbTuesday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbMonday)
		Me.pnlCbRedemptionDays.Controls.Add(Me.cbSunday)
		Me.pnlCbRedemptionDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlCbRedemptionDays.Location = New System.Drawing.Point(19, 52)
		Me.pnlCbRedemptionDays.Name = "pnlCbRedemptionDays"
		Me.pnlCbRedemptionDays.Size = New System.Drawing.Size(103, 109)
		Me.pnlCbRedemptionDays.TabIndex = 27
		'
		'cbSaturday
		'
		Me.cbSaturday.AutoSize = True
		Me.cbSaturday.Location = New System.Drawing.Point(1, 90)
		Me.cbSaturday.Name = "cbSaturday"
		Me.cbSaturday.Size = New System.Drawing.Size(68, 17)
		Me.cbSaturday.TabIndex = 34
		Me.cbSaturday.Text = "Saturday"
		Me.cbSaturday.UseVisualStyleBackColor = True
		'
		'cbFriday
		'
		Me.cbFriday.AutoSize = True
		Me.cbFriday.Location = New System.Drawing.Point(1, 75)
		Me.cbFriday.Name = "cbFriday"
		Me.cbFriday.Size = New System.Drawing.Size(54, 17)
		Me.cbFriday.TabIndex = 33
		Me.cbFriday.Text = "Friday"
		Me.cbFriday.UseVisualStyleBackColor = True
		'
		'cbThursday
		'
		Me.cbThursday.AutoSize = True
		Me.cbThursday.Location = New System.Drawing.Point(1, 60)
		Me.cbThursday.Name = "cbThursday"
		Me.cbThursday.Size = New System.Drawing.Size(70, 17)
		Me.cbThursday.TabIndex = 32
		Me.cbThursday.Text = "Thursday"
		Me.cbThursday.UseVisualStyleBackColor = True
		'
		'cbWednesday
		'
		Me.cbWednesday.BackColor = System.Drawing.Color.Transparent
		Me.cbWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbWednesday.ForeColor = System.Drawing.Color.Black
		Me.cbWednesday.Location = New System.Drawing.Point(1, 44)
		Me.cbWednesday.Name = "cbWednesday"
		Me.cbWednesday.Size = New System.Drawing.Size(100, 19)
		Me.cbWednesday.TabIndex = 31
		Me.cbWednesday.Text = "Wednesday"
		Me.cbWednesday.UseVisualStyleBackColor = False
		'
		'cbTuesday
		'
		Me.cbTuesday.AutoSize = True
		Me.cbTuesday.Location = New System.Drawing.Point(1, 30)
		Me.cbTuesday.Name = "cbTuesday"
		Me.cbTuesday.Size = New System.Drawing.Size(67, 17)
		Me.cbTuesday.TabIndex = 30
		Me.cbTuesday.Text = "Tuesday"
		Me.cbTuesday.UseVisualStyleBackColor = True
		'
		'cbMonday
		'
		Me.cbMonday.AutoSize = True
		Me.cbMonday.Location = New System.Drawing.Point(1, 15)
		Me.cbMonday.Name = "cbMonday"
		Me.cbMonday.Size = New System.Drawing.Size(64, 17)
		Me.cbMonday.TabIndex = 29
		Me.cbMonday.Text = "Monday"
		Me.cbMonday.UseVisualStyleBackColor = True
		'
		'cbSunday
		'
		Me.cbSunday.AutoSize = True
		Me.cbSunday.Location = New System.Drawing.Point(1, 0)
		Me.cbSunday.Name = "cbSunday"
		Me.cbSunday.Size = New System.Drawing.Size(62, 17)
		Me.cbSunday.TabIndex = 28
		Me.cbSunday.Text = "Sunday"
		Me.cbSunday.UseVisualStyleBackColor = True
		'
		'lblPrimaryDay
		'
		Me.lblPrimaryDay.AutoSize = True
		Me.lblPrimaryDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrimaryDay.ForeColor = System.Drawing.Color.Lime
		Me.lblPrimaryDay.Location = New System.Drawing.Point(39, 164)
		Me.lblPrimaryDay.Name = "lblPrimaryDay"
		Me.lblPrimaryDay.Size = New System.Drawing.Size(83, 13)
		Me.lblPrimaryDay.TabIndex = 5
		Me.lblPrimaryDay.Text = "* Primary Day"
		Me.lblPrimaryDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblRedemptionDays
		'
		Me.lblRedemptionDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRedemptionDays.ForeColor = System.Drawing.Color.White
		Me.lblRedemptionDays.Location = New System.Drawing.Point(3, 0)
		Me.lblRedemptionDays.Name = "lblRedemptionDays"
		Me.lblRedemptionDays.Size = New System.Drawing.Size(165, 49)
		Me.lblRedemptionDays.TabIndex = 0
		Me.lblRedemptionDays.Text = "On which day(s) is secondary redemption allowed?"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.cbSelectAll)
		Me.Panel2.Controls.Add(Me.lblPointsEarningDays)
		Me.Panel2.Controls.Add(Me.clbPointsEarningDays)
		Me.Panel2.Location = New System.Drawing.Point(409, 10)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(172, 192)
		Me.Panel2.TabIndex = 0
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
		'lblPointsEarningDays
		'
		Me.lblPointsEarningDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPointsEarningDays.ForeColor = System.Drawing.Color.White
		Me.lblPointsEarningDays.Location = New System.Drawing.Point(3, 0)
		Me.lblPointsEarningDays.Name = "lblPointsEarningDays"
		Me.lblPointsEarningDays.Size = New System.Drawing.Size(165, 49)
		Me.lblPointsEarningDays.TabIndex = 0
		Me.lblPointsEarningDays.Text = "On which day(s), within the qualifying period, will points be earned?"
		'
		'clbPointsEarningDays
		'
		Me.clbPointsEarningDays.BackColor = System.Drawing.Color.PaleTurquoise
		Me.clbPointsEarningDays.CheckOnClick = True
		Me.clbPointsEarningDays.FormattingEnabled = True
		Me.clbPointsEarningDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.clbPointsEarningDays.Location = New System.Drawing.Point(19, 52)
		Me.clbPointsEarningDays.Name = "clbPointsEarningDays"
		Me.clbPointsEarningDays.Size = New System.Drawing.Size(103, 109)
		Me.clbPointsEarningDays.TabIndex = 6
		Me.clbPointsEarningDays.ThreeDCheckBoxes = True
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.PapayaWhip
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel3.Controls.Add(Me.dtpQualifyingStart)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(0, 3)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(107, 80)
		Me.Panel3.TabIndex = 0
		'
		'dtpQualifyingStart
		'
		Me.dtpQualifyingStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpQualifyingStart.Location = New System.Drawing.Point(3, 53)
		Me.dtpQualifyingStart.Name = "dtpQualifyingStart"
		Me.dtpQualifyingStart.Size = New System.Drawing.Size(95, 20)
		Me.dtpQualifyingStart.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(106, 48)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "When does the qualifying period start?"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.PapayaWhip
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel4.Controls.Add(Me.dtpQualifyingEnd)
		Me.Panel4.Controls.Add(Me.Label3)
		Me.Panel4.Location = New System.Drawing.Point(113, 3)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(107, 80)
		Me.Panel4.TabIndex = 0
		'
		'dtpQualifyingEnd
		'
		Me.dtpQualifyingEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpQualifyingEnd.Location = New System.Drawing.Point(3, 53)
		Me.dtpQualifyingEnd.Name = "dtpQualifyingEnd"
		Me.dtpQualifyingEnd.Size = New System.Drawing.Size(95, 20)
		Me.dtpQualifyingEnd.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(106, 48)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "When does the qualifying period end?"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
		Me.Label9.Location = New System.Drawing.Point(9, 38)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(33, 13)
		Me.Label9.TabIndex = 23
		Me.Label9.Text = "End:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
		Me.Label10.Location = New System.Drawing.Point(4, 21)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(38, 13)
		Me.Label10.TabIndex = 22
		Me.Label10.Text = "Start:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblQualifyingEnd
		'
		Me.lblQualifyingEnd.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblQualifyingEnd.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQualifyingEnd.ForeColor = System.Drawing.Color.White
		Me.lblQualifyingEnd.Location = New System.Drawing.Point(37, 34)
		Me.lblQualifyingEnd.Name = "lblQualifyingEnd"
		Me.lblQualifyingEnd.Size = New System.Drawing.Size(198, 23)
		Me.lblQualifyingEnd.TabIndex = 20
		Me.lblQualifyingEnd.Text = "End Date"
		Me.lblQualifyingEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblQualifyingStart
		'
		Me.lblQualifyingStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblQualifyingStart.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQualifyingStart.ForeColor = System.Drawing.Color.White
		Me.lblQualifyingStart.Location = New System.Drawing.Point(38, 17)
		Me.lblQualifyingStart.Name = "lblQualifyingStart"
		Me.lblQualifyingStart.Size = New System.Drawing.Size(198, 23)
		Me.lblQualifyingStart.TabIndex = 21
		Me.lblQualifyingStart.Text = "Start Date"
		Me.lblQualifyingStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cbSameDayPromo
		'
		Me.cbSameDayPromo.AutoSize = True
		Me.cbSameDayPromo.BackColor = System.Drawing.Color.Transparent
		Me.cbSameDayPromo.Font = New System.Drawing.Font("Consolas", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSameDayPromo.Location = New System.Drawing.Point(6, 56)
		Me.cbSameDayPromo.Name = "cbSameDayPromo"
		Me.cbSameDayPromo.Size = New System.Drawing.Size(124, 19)
		Me.cbSameDayPromo.TabIndex = 19
		Me.cbSameDayPromo.Text = "Same-Day Promo"
		Me.cbSameDayPromo.UseVisualStyleBackColor = False
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
		Me.Label13.Location = New System.Drawing.Point(0, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(140, 13)
		Me.Label13.TabIndex = 18
		Me.Label13.Text = "Qualifying Period Dates"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.BackColor = System.Drawing.Color.Transparent
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(3, 10)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(142, 16)
		Me.Label14.TabIndex = 17
		Me.Label14.Text = "Promo Occurs Date"
		'
		'dtpOccursDate
		'
		Me.dtpOccursDate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpOccursDate.Location = New System.Drawing.Point(6, 29)
		Me.dtpOccursDate.Name = "dtpOccursDate"
		Me.dtpOccursDate.Size = New System.Drawing.Size(199, 20)
		Me.dtpOccursDate.TabIndex = 16
		'
		'MonthCal
		'
		Me.MonthCal.BackColor = System.Drawing.Color.White
		Me.MonthCal.Cursor = System.Windows.Forms.Cursors.No
		Me.MonthCal.Enabled = False
		Me.MonthCal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MonthCal.Location = New System.Drawing.Point(6, 4)
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
		'pnlOccuringQualifyingPeriod
		'
		Me.pnlOccuringQualifyingPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlOccuringQualifyingPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.Label13)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.Label10)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.lblQualifyingEnd)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.lblQualifyingStart)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.Label9)
		Me.pnlOccuringQualifyingPeriod.Location = New System.Drawing.Point(229, 208)
		Me.pnlOccuringQualifyingPeriod.Name = "pnlOccuringQualifyingPeriod"
		Me.pnlOccuringQualifyingPeriod.Size = New System.Drawing.Size(247, 57)
		Me.pnlOccuringQualifyingPeriod.TabIndex = 24
		'
		'pnlOccursDate
		'
		Me.pnlOccursDate.BackColor = System.Drawing.Color.Moccasin
		Me.pnlOccursDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOccursDate.Controls.Add(Me.Label14)
		Me.pnlOccursDate.Controls.Add(Me.dtpOccursDate)
		Me.pnlOccursDate.Controls.Add(Me.cbSameDayPromo)
		Me.pnlOccursDate.Location = New System.Drawing.Point(3, 189)
		Me.pnlOccursDate.Name = "pnlOccursDate"
		Me.pnlOccursDate.Size = New System.Drawing.Size(220, 89)
		Me.pnlOccursDate.TabIndex = 25
		'
		'pnlMonthCal
		'
		Me.pnlMonthCal.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlMonthCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMonthCal.Controls.Add(Me.MonthCal)
		Me.pnlMonthCal.Location = New System.Drawing.Point(3, 10)
		Me.pnlMonthCal.Name = "pnlMonthCal"
		Me.pnlMonthCal.Size = New System.Drawing.Size(220, 175)
		Me.pnlMonthCal.TabIndex = 26
		'
		'pnlRecurringQualifyingPeriod
		'
		Me.pnlRecurringQualifyingPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlRecurringQualifyingPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlRecurringQualifyingPeriod.Controls.Add(Me.Panel3)
		Me.pnlRecurringQualifyingPeriod.Controls.Add(Me.Panel4)
		Me.pnlRecurringQualifyingPeriod.Location = New System.Drawing.Point(3, 189)
		Me.pnlRecurringQualifyingPeriod.Name = "pnlRecurringQualifyingPeriod"
		Me.pnlRecurringQualifyingPeriod.Size = New System.Drawing.Size(220, 89)
		Me.pnlRecurringQualifyingPeriod.TabIndex = 27
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(-1, 5)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(140, 35)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "When is the promo occurance date?"
		Me.Label6.Visible = False
		'
		'DateTimePicker3
		'
		Me.DateTimePicker3.Enabled = False
		Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker3.Location = New System.Drawing.Point(2, 43)
		Me.DateTimePicker3.Name = "DateTimePicker3"
		Me.DateTimePicker3.Size = New System.Drawing.Size(95, 20)
		Me.DateTimePicker3.TabIndex = 0
		Me.DateTimePicker3.TabStop = False
		'
		'Panel7
		'
		Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel7.Controls.Add(Me.DateTimePicker3)
		Me.Panel7.Controls.Add(Me.Label6)
		Me.Panel7.Enabled = False
		Me.Panel7.Location = New System.Drawing.Point(273, 442)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(144, 81)
		Me.Panel7.TabIndex = 0
		Me.Panel7.Visible = False
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.BackColor = System.Drawing.Color.MediumSpringGreen
		Me.CheckedListBox1.CheckOnClick = True
		Me.CheckedListBox1.Enabled = False
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.CheckedListBox1.Location = New System.Drawing.Point(164, 442)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckedListBox1.Size = New System.Drawing.Size(103, 109)
		Me.CheckedListBox1.TabIndex = 4
		Me.CheckedListBox1.ThreeDCheckBoxes = True
		Me.CheckedListBox1.UseCompatibleTextRendering = True
		Me.CheckedListBox1.Visible = False
		'
		'pnlPrimaryDay
		'
		Me.pnlPrimaryDay.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPrimaryDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPrimaryDay.Controls.Add(Me.cbPrimaryDay)
		Me.pnlPrimaryDay.Controls.Add(Me.yetAnotherLabel)
		Me.pnlPrimaryDay.Enabled = False
		Me.pnlPrimaryDay.Location = New System.Drawing.Point(229, 208)
		Me.pnlPrimaryDay.Name = "pnlPrimaryDay"
		Me.pnlPrimaryDay.Size = New System.Drawing.Size(124, 57)
		Me.pnlPrimaryDay.TabIndex = 28
		Me.pnlPrimaryDay.Visible = False
		'
		'cbPrimaryDay
		'
		Me.cbPrimaryDay.FormattingEnabled = True
		Me.cbPrimaryDay.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.cbPrimaryDay.Location = New System.Drawing.Point(7, 24)
		Me.cbPrimaryDay.Name = "cbPrimaryDay"
		Me.cbPrimaryDay.Size = New System.Drawing.Size(103, 21)
		Me.cbPrimaryDay.TabIndex = 30
		'
		'yetAnotherLabel
		'
		Me.yetAnotherLabel.AutoSize = True
		Me.yetAnotherLabel.BackColor = System.Drawing.Color.Transparent
		Me.yetAnotherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.yetAnotherLabel.ForeColor = System.Drawing.Color.Gainsboro
		Me.yetAnotherLabel.Location = New System.Drawing.Point(0, 0)
		Me.yetAnotherLabel.Name = "yetAnotherLabel"
		Me.yetAnotherLabel.Size = New System.Drawing.Size(74, 13)
		Me.yetAnotherLabel.TabIndex = 29
		Me.yetAnotherLabel.Text = "Primary Day"
		Me.yetAnotherLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'StepC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Controls.Add(Me.pnlMonthCal)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.pnlRedemptionDays)
		Me.Controls.Add(Me.pnlPrimaryDay)
		Me.Controls.Add(Me.pnlOccuringQualifyingPeriod)
		Me.Controls.Add(Me.pnlRecurringQualifyingPeriod)
		Me.Controls.Add(Me.pnlOccursDate)
		Me.Name = "StepC"
		Me.NextStep = "StepD"
		Me.PreviousStep = "StepB"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Set the date information for the promotional."
		Me.Controls.SetChildIndex(Me.pnlOccursDate, 0)
		Me.Controls.SetChildIndex(Me.pnlRecurringQualifyingPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlOccuringQualifyingPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlPrimaryDay, 0)
		Me.Controls.SetChildIndex(Me.pnlRedemptionDays, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Controls.SetChildIndex(Me.Panel7, 0)
		Me.Controls.SetChildIndex(Me.pnlMonthCal, 0)
		Me.Controls.SetChildIndex(Me.CheckedListBox1, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.pnlRedemptionDays.ResumeLayout(False)
		Me.pnlRedemptionDays.PerformLayout()
		Me.pnlCbRedemptionDays.ResumeLayout(False)
		Me.pnlCbRedemptionDays.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.pnlOccuringQualifyingPeriod.ResumeLayout(False)
		Me.pnlOccuringQualifyingPeriod.PerformLayout()
		Me.pnlOccursDate.ResumeLayout(False)
		Me.pnlOccursDate.PerformLayout()
		Me.pnlMonthCal.ResumeLayout(False)
		Me.pnlRecurringQualifyingPeriod.ResumeLayout(False)
		Me.Panel7.ResumeLayout(False)
		Me.pnlPrimaryDay.ResumeLayout(False)
		Me.pnlPrimaryDay.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlRedemptionDays As System.Windows.Forms.Panel
	Friend WithEvents lblRedemptionDays As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents dtpQualifyingStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Panel4 As System.Windows.Forms.Panel
	Friend WithEvents dtpQualifyingEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents clbPointsEarningDays As System.Windows.Forms.CheckedListBox
	Friend WithEvents lblPointsEarningDays As System.Windows.Forms.Label
	Friend WithEvents cbSelectAll As System.Windows.Forms.CheckBox
	Friend WithEvents lblPrimaryDay As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents lblQualifyingEnd As System.Windows.Forms.Label
	Friend WithEvents lblQualifyingStart As System.Windows.Forms.Label
	Friend WithEvents cbSameDayPromo As System.Windows.Forms.CheckBox
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents dtpOccursDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents MonthCal As System.Windows.Forms.MonthCalendar
	Friend WithEvents pnlOccuringQualifyingPeriod As System.Windows.Forms.Panel
	Friend WithEvents pnlOccursDate As System.Windows.Forms.Panel
	Friend WithEvents pnlMonthCal As System.Windows.Forms.Panel
	Friend WithEvents pnlCbRedemptionDays As System.Windows.Forms.Panel
	Friend WithEvents cbSaturday As System.Windows.Forms.CheckBox
	Friend WithEvents cbFriday As System.Windows.Forms.CheckBox
	Friend WithEvents cbThursday As System.Windows.Forms.CheckBox
	Friend WithEvents cbWednesday As System.Windows.Forms.CheckBox
	Friend WithEvents cbTuesday As System.Windows.Forms.CheckBox
	Friend WithEvents cbMonday As System.Windows.Forms.CheckBox
	Friend WithEvents cbSunday As System.Windows.Forms.CheckBox
	Friend WithEvents pnlRecurringQualifyingPeriod As System.Windows.Forms.Panel
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
	Friend WithEvents Panel7 As System.Windows.Forms.Panel
	Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
	Friend WithEvents pnlPrimaryDay As System.Windows.Forms.Panel
	Friend WithEvents cbPrimaryDay As System.Windows.Forms.ComboBox
	Friend WithEvents yetAnotherLabel As System.Windows.Forms.Label

End Class

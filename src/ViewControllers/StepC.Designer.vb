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
		Me.pnlEarningDays = New System.Windows.Forms.Panel()
		Me.cbSelectAll = New System.Windows.Forms.CheckBox()
		Me.lblPointsEarningDays = New System.Windows.Forms.Label()
		Me.clbPointsEarningDays = New System.Windows.Forms.CheckedListBox()
		Me.pnlWhenQPStart = New System.Windows.Forms.Panel()
		Me.dtpQualifyingStart = New System.Windows.Forms.DateTimePicker()
		Me.lblWhenQPStart = New System.Windows.Forms.Label()
		Me.pnlWhenQPEnd = New System.Windows.Forms.Panel()
		Me.dtpQualifyingEnd = New System.Windows.Forms.DateTimePicker()
		Me.lblWhenQPEnd = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lblQualifyingEnd = New System.Windows.Forms.Label()
		Me.lblQualifyingStart = New System.Windows.Forms.Label()
		Me.cbSameDayPromo = New System.Windows.Forms.CheckBox()
		Me.lblYALBL = New System.Windows.Forms.Label()
		Me.lblPromoOccursDate = New System.Windows.Forms.Label()
		Me.dtpOccursDate = New System.Windows.Forms.DateTimePicker()
		Me.MonthCal = New System.Windows.Forms.MonthCalendar()
		Me.pnlOccuringQualifyingPeriod = New System.Windows.Forms.Panel()
		Me.pnlOccursDate = New System.Windows.Forms.Panel()
		Me.pnlMoccasin = New System.Windows.Forms.Panel()
		Me.cbSingleDayPromo = New System.Windows.Forms.CheckBox()
		Me.pnlMonthCal = New System.Windows.Forms.Panel()
		Me.lblSelectDates = New System.Windows.Forms.Label()
		Me.pnlRecurringQualifyingPeriod = New System.Windows.Forms.Panel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.pnlPrimaryDay = New System.Windows.Forms.Panel()
		Me.cbPrimaryDay = New System.Windows.Forms.ComboBox()
		Me.yetAnotherLabel = New System.Windows.Forms.Label()
		Me.lblQualifyingPeriod = New System.Windows.Forms.Label()
		Me.pnlRedemptionDays.SuspendLayout()
		Me.pnlCbRedemptionDays.SuspendLayout()
		Me.pnlEarningDays.SuspendLayout()
		Me.pnlWhenQPStart.SuspendLayout()
		Me.pnlWhenQPEnd.SuspendLayout()
		Me.pnlOccuringQualifyingPeriod.SuspendLayout()
		Me.pnlOccursDate.SuspendLayout()
		Me.pnlMoccasin.SuspendLayout()
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
		Me.pnlRedemptionDays.CausesValidation = False
		Me.pnlRedemptionDays.Controls.Add(Me.pnlCbRedemptionDays)
		Me.pnlRedemptionDays.Controls.Add(Me.lblPrimaryDay)
		Me.pnlRedemptionDays.Controls.Add(Me.lblRedemptionDays)
		Me.pnlRedemptionDays.Location = New System.Drawing.Point(229, 21)
		Me.pnlRedemptionDays.Name = "pnlRedemptionDays"
		Me.pnlRedemptionDays.Size = New System.Drawing.Size(174, 192)
		Me.pnlRedemptionDays.TabIndex = 0
		'
		'pnlCbRedemptionDays
		'
		Me.pnlCbRedemptionDays.BackColor = System.Drawing.Color.Lavender
		Me.pnlCbRedemptionDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCbRedemptionDays.CausesValidation = False
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
		Me.pnlCbRedemptionDays.TabIndex = 0
		'
		'cbSaturday
		'
		Me.cbSaturday.AutoSize = True
		Me.cbSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.cbFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.cbThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.cbTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.cbMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.cbSunday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lblPrimaryDay.CausesValidation = False
		Me.lblPrimaryDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrimaryDay.ForeColor = System.Drawing.Color.Lime
		Me.lblPrimaryDay.Location = New System.Drawing.Point(39, 164)
		Me.lblPrimaryDay.Name = "lblPrimaryDay"
		Me.lblPrimaryDay.Size = New System.Drawing.Size(83, 13)
		Me.lblPrimaryDay.TabIndex = 0
		Me.lblPrimaryDay.Text = "* Primary Day"
		Me.lblPrimaryDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblPrimaryDay.UseMnemonic = False
		'
		'lblRedemptionDays
		'
		Me.lblRedemptionDays.CausesValidation = False
		Me.lblRedemptionDays.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRedemptionDays.ForeColor = System.Drawing.Color.White
		Me.lblRedemptionDays.Location = New System.Drawing.Point(3, 0)
		Me.lblRedemptionDays.Name = "lblRedemptionDays"
		Me.lblRedemptionDays.Size = New System.Drawing.Size(165, 49)
		Me.lblRedemptionDays.TabIndex = 0
		Me.lblRedemptionDays.Text = "On which day(s) is secondary redemption allowed?"
		Me.lblRedemptionDays.UseMnemonic = False
		'
		'pnlEarningDays
		'
		Me.pnlEarningDays.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlEarningDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlEarningDays.CausesValidation = False
		Me.pnlEarningDays.Controls.Add(Me.cbSelectAll)
		Me.pnlEarningDays.Controls.Add(Me.lblPointsEarningDays)
		Me.pnlEarningDays.Controls.Add(Me.clbPointsEarningDays)
		Me.pnlEarningDays.Location = New System.Drawing.Point(409, 21)
		Me.pnlEarningDays.Name = "pnlEarningDays"
		Me.pnlEarningDays.Size = New System.Drawing.Size(172, 192)
		Me.pnlEarningDays.TabIndex = 0
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
		Me.lblPointsEarningDays.CausesValidation = False
		Me.lblPointsEarningDays.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPointsEarningDays.ForeColor = System.Drawing.Color.White
		Me.lblPointsEarningDays.Location = New System.Drawing.Point(3, 0)
		Me.lblPointsEarningDays.Name = "lblPointsEarningDays"
		Me.lblPointsEarningDays.Size = New System.Drawing.Size(165, 49)
		Me.lblPointsEarningDays.TabIndex = 0
		Me.lblPointsEarningDays.Text = "On which day(s), within the qualifying period, will points be earned?"
		Me.lblPointsEarningDays.UseMnemonic = False
		'
		'clbPointsEarningDays
		'
		Me.clbPointsEarningDays.BackColor = System.Drawing.Color.PaleTurquoise
		Me.clbPointsEarningDays.CausesValidation = False
		Me.clbPointsEarningDays.CheckOnClick = True
		Me.clbPointsEarningDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.clbPointsEarningDays.FormattingEnabled = True
		Me.clbPointsEarningDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.clbPointsEarningDays.Location = New System.Drawing.Point(19, 52)
		Me.clbPointsEarningDays.Name = "clbPointsEarningDays"
		Me.clbPointsEarningDays.Size = New System.Drawing.Size(103, 109)
		Me.clbPointsEarningDays.TabIndex = 0
		Me.clbPointsEarningDays.TabStop = False
		Me.clbPointsEarningDays.ThreeDCheckBoxes = True
		'
		'pnlWhenQPStart
		'
		Me.pnlWhenQPStart.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlWhenQPStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlWhenQPStart.CausesValidation = False
		Me.pnlWhenQPStart.Controls.Add(Me.dtpQualifyingStart)
		Me.pnlWhenQPStart.Controls.Add(Me.lblWhenQPStart)
		Me.pnlWhenQPStart.Location = New System.Drawing.Point(0, 3)
		Me.pnlWhenQPStart.Name = "pnlWhenQPStart"
		Me.pnlWhenQPStart.Size = New System.Drawing.Size(107, 80)
		Me.pnlWhenQPStart.TabIndex = 0
		'
		'dtpQualifyingStart
		'
		Me.dtpQualifyingStart.CausesValidation = False
		Me.dtpQualifyingStart.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpQualifyingStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpQualifyingStart.Location = New System.Drawing.Point(3, 53)
		Me.dtpQualifyingStart.Name = "dtpQualifyingStart"
		Me.dtpQualifyingStart.Size = New System.Drawing.Size(95, 20)
		Me.dtpQualifyingStart.TabIndex = 0
		Me.dtpQualifyingStart.TabStop = False
		'
		'lblWhenQPStart
		'
		Me.lblWhenQPStart.BackColor = System.Drawing.Color.Transparent
		Me.lblWhenQPStart.CausesValidation = False
		Me.lblWhenQPStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhenQPStart.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhenQPStart.Location = New System.Drawing.Point(0, 0)
		Me.lblWhenQPStart.Name = "lblWhenQPStart"
		Me.lblWhenQPStart.Size = New System.Drawing.Size(106, 48)
		Me.lblWhenQPStart.TabIndex = 0
		Me.lblWhenQPStart.Text = "When does the qualifying period start?"
		Me.lblWhenQPStart.UseMnemonic = False
		'
		'pnlWhenQPEnd
		'
		Me.pnlWhenQPEnd.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlWhenQPEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlWhenQPEnd.CausesValidation = False
		Me.pnlWhenQPEnd.Controls.Add(Me.dtpQualifyingEnd)
		Me.pnlWhenQPEnd.Controls.Add(Me.lblWhenQPEnd)
		Me.pnlWhenQPEnd.Location = New System.Drawing.Point(113, 3)
		Me.pnlWhenQPEnd.Name = "pnlWhenQPEnd"
		Me.pnlWhenQPEnd.Size = New System.Drawing.Size(107, 80)
		Me.pnlWhenQPEnd.TabIndex = 0
		'
		'dtpQualifyingEnd
		'
		Me.dtpQualifyingEnd.CausesValidation = False
		Me.dtpQualifyingEnd.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpQualifyingEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpQualifyingEnd.Location = New System.Drawing.Point(3, 53)
		Me.dtpQualifyingEnd.Name = "dtpQualifyingEnd"
		Me.dtpQualifyingEnd.Size = New System.Drawing.Size(95, 20)
		Me.dtpQualifyingEnd.TabIndex = 0
		Me.dtpQualifyingEnd.TabStop = False
		'
		'lblWhenQPEnd
		'
		Me.lblWhenQPEnd.BackColor = System.Drawing.Color.Transparent
		Me.lblWhenQPEnd.CausesValidation = False
		Me.lblWhenQPEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhenQPEnd.Location = New System.Drawing.Point(0, 0)
		Me.lblWhenQPEnd.Name = "lblWhenQPEnd"
		Me.lblWhenQPEnd.Size = New System.Drawing.Size(106, 48)
		Me.lblWhenQPEnd.TabIndex = 0
		Me.lblWhenQPEnd.Text = "When does the qualifying period end?"
		Me.lblWhenQPEnd.UseMnemonic = False
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
		Me.lblQualifyingEnd.CausesValidation = False
		Me.lblQualifyingEnd.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQualifyingEnd.ForeColor = System.Drawing.Color.White
		Me.lblQualifyingEnd.Location = New System.Drawing.Point(37, 34)
		Me.lblQualifyingEnd.Name = "lblQualifyingEnd"
		Me.lblQualifyingEnd.Size = New System.Drawing.Size(198, 23)
		Me.lblQualifyingEnd.TabIndex = 0
		Me.lblQualifyingEnd.Text = "End Date"
		Me.lblQualifyingEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblQualifyingEnd.UseMnemonic = False
		'
		'lblQualifyingStart
		'
		Me.lblQualifyingStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblQualifyingStart.CausesValidation = False
		Me.lblQualifyingStart.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQualifyingStart.ForeColor = System.Drawing.Color.White
		Me.lblQualifyingStart.Location = New System.Drawing.Point(38, 17)
		Me.lblQualifyingStart.Name = "lblQualifyingStart"
		Me.lblQualifyingStart.Size = New System.Drawing.Size(198, 23)
		Me.lblQualifyingStart.TabIndex = 0
		Me.lblQualifyingStart.Text = "Start Date"
		Me.lblQualifyingStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblQualifyingStart.UseMnemonic = False
		'
		'cbSameDayPromo
		'
		Me.cbSameDayPromo.AutoSize = True
		Me.cbSameDayPromo.BackColor = System.Drawing.Color.Transparent
		Me.cbSameDayPromo.CausesValidation = False
		Me.cbSameDayPromo.Enabled = False
		Me.cbSameDayPromo.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSameDayPromo.Location = New System.Drawing.Point(3, 3)
		Me.cbSameDayPromo.Name = "cbSameDayPromo"
		Me.cbSameDayPromo.Size = New System.Drawing.Size(110, 17)
		Me.cbSameDayPromo.TabIndex = 0
		Me.cbSameDayPromo.TabStop = False
		Me.cbSameDayPromo.Text = "Same-Day Promo"
		Me.cbSameDayPromo.UseVisualStyleBackColor = False
		'
		'lblYALBL
		'
		Me.lblYALBL.AutoSize = True
		Me.lblYALBL.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblYALBL.CausesValidation = False
		Me.lblYALBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblYALBL.ForeColor = System.Drawing.Color.Gainsboro
		Me.lblYALBL.Location = New System.Drawing.Point(0, 0)
		Me.lblYALBL.Name = "lblYALBL"
		Me.lblYALBL.Size = New System.Drawing.Size(140, 13)
		Me.lblYALBL.TabIndex = 0
		Me.lblYALBL.Text = "Qualifying Period Dates"
		Me.lblYALBL.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblYALBL.UseMnemonic = False
		'
		'lblPromoOccursDate
		'
		Me.lblPromoOccursDate.AutoSize = True
		Me.lblPromoOccursDate.BackColor = System.Drawing.Color.Transparent
		Me.lblPromoOccursDate.Font = New System.Drawing.Font("Consolas", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoOccursDate.ForeColor = System.Drawing.Color.White
		Me.lblPromoOccursDate.Location = New System.Drawing.Point(3, 1)
		Me.lblPromoOccursDate.Name = "lblPromoOccursDate"
		Me.lblPromoOccursDate.Size = New System.Drawing.Size(126, 15)
		Me.lblPromoOccursDate.TabIndex = 0
		Me.lblPromoOccursDate.Text = "Promo Occurs Date"
		Me.lblPromoOccursDate.UseMnemonic = False
		'
		'dtpOccursDate
		'
		Me.dtpOccursDate.CausesValidation = False
		Me.dtpOccursDate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpOccursDate.Location = New System.Drawing.Point(6, 17)
		Me.dtpOccursDate.Name = "dtpOccursDate"
		Me.dtpOccursDate.Size = New System.Drawing.Size(199, 20)
		Me.dtpOccursDate.TabIndex = 0
		Me.dtpOccursDate.TabStop = False
		'
		'MonthCal
		'
		Me.MonthCal.BackColor = System.Drawing.Color.White
		Me.MonthCal.CausesValidation = False
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
		Me.MonthCal.TabStop = False
		Me.MonthCal.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.MonthCal.TitleForeColor = System.Drawing.Color.Gold
		Me.MonthCal.TrailingForeColor = System.Drawing.Color.Gray
		Me.MonthCal.Visible = False
		'
		'pnlOccuringQualifyingPeriod
		'
		Me.pnlOccuringQualifyingPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlOccuringQualifyingPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOccuringQualifyingPeriod.CausesValidation = False
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.lblYALBL)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.Label10)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.lblQualifyingEnd)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.lblQualifyingStart)
		Me.pnlOccuringQualifyingPeriod.Controls.Add(Me.Label9)
		Me.pnlOccuringQualifyingPeriod.Location = New System.Drawing.Point(229, 219)
		Me.pnlOccuringQualifyingPeriod.Name = "pnlOccuringQualifyingPeriod"
		Me.pnlOccuringQualifyingPeriod.Size = New System.Drawing.Size(247, 57)
		Me.pnlOccuringQualifyingPeriod.TabIndex = 24
		'
		'pnlOccursDate
		'
		Me.pnlOccursDate.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlOccursDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOccursDate.CausesValidation = False
		Me.pnlOccursDate.Controls.Add(Me.lblPromoOccursDate)
		Me.pnlOccursDate.Controls.Add(Me.dtpOccursDate)
		Me.pnlOccursDate.Controls.Add(Me.pnlMoccasin)
		Me.pnlOccursDate.Location = New System.Drawing.Point(3, 200)
		Me.pnlOccursDate.Name = "pnlOccursDate"
		Me.pnlOccursDate.Size = New System.Drawing.Size(220, 89)
		Me.pnlOccursDate.TabIndex = 0
		'
		'pnlMoccasin
		'
		Me.pnlMoccasin.BackColor = System.Drawing.Color.Moccasin
		Me.pnlMoccasin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMoccasin.CausesValidation = False
		Me.pnlMoccasin.Controls.Add(Me.cbSingleDayPromo)
		Me.pnlMoccasin.Controls.Add(Me.cbSameDayPromo)
		Me.pnlMoccasin.Location = New System.Drawing.Point(4, 40)
		Me.pnlMoccasin.Name = "pnlMoccasin"
		Me.pnlMoccasin.Size = New System.Drawing.Size(201, 42)
		Me.pnlMoccasin.TabIndex = 0
		'
		'cbSingleDayPromo
		'
		Me.cbSingleDayPromo.AutoSize = True
		Me.cbSingleDayPromo.BackColor = System.Drawing.Color.Transparent
		Me.cbSingleDayPromo.CausesValidation = False
		Me.cbSingleDayPromo.Enabled = False
		Me.cbSingleDayPromo.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSingleDayPromo.Location = New System.Drawing.Point(3, 21)
		Me.cbSingleDayPromo.Name = "cbSingleDayPromo"
		Me.cbSingleDayPromo.Size = New System.Drawing.Size(182, 17)
		Me.cbSingleDayPromo.TabIndex = 0
		Me.cbSingleDayPromo.TabStop = False
		Me.cbSingleDayPromo.Text = "Single-Day Promo (Ex. VIP)"
		Me.cbSingleDayPromo.UseVisualStyleBackColor = False
		'
		'pnlMonthCal
		'
		Me.pnlMonthCal.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlMonthCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlMonthCal.CausesValidation = False
		Me.pnlMonthCal.Controls.Add(Me.MonthCal)
		Me.pnlMonthCal.Controls.Add(Me.lblSelectDates)
		Me.pnlMonthCal.Location = New System.Drawing.Point(3, 21)
		Me.pnlMonthCal.Name = "pnlMonthCal"
		Me.pnlMonthCal.Size = New System.Drawing.Size(220, 175)
		Me.pnlMonthCal.TabIndex = 0
		'
		'lblSelectDates
		'
		Me.lblSelectDates.BackColor = System.Drawing.Color.Transparent
		Me.lblSelectDates.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSelectDates.ForeColor = System.Drawing.Color.White
		Me.lblSelectDates.Location = New System.Drawing.Point(3, 4)
		Me.lblSelectDates.Name = "lblSelectDates"
		Me.lblSelectDates.Size = New System.Drawing.Size(206, 163)
		Me.lblSelectDates.TabIndex = 16
		Me.lblSelectDates.Text = "Select date(s) to display the qualifying period."
		Me.lblSelectDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlRecurringQualifyingPeriod
		'
		Me.pnlRecurringQualifyingPeriod.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlRecurringQualifyingPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlRecurringQualifyingPeriod.CausesValidation = False
		Me.pnlRecurringQualifyingPeriod.Controls.Add(Me.pnlWhenQPStart)
		Me.pnlRecurringQualifyingPeriod.Controls.Add(Me.pnlWhenQPEnd)
		Me.pnlRecurringQualifyingPeriod.Location = New System.Drawing.Point(3, 200)
		Me.pnlRecurringQualifyingPeriod.Name = "pnlRecurringQualifyingPeriod"
		Me.pnlRecurringQualifyingPeriod.Size = New System.Drawing.Size(220, 89)
		Me.pnlRecurringQualifyingPeriod.TabIndex = 0
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
		Me.pnlPrimaryDay.CausesValidation = False
		Me.pnlPrimaryDay.Controls.Add(Me.cbPrimaryDay)
		Me.pnlPrimaryDay.Controls.Add(Me.yetAnotherLabel)
		Me.pnlPrimaryDay.Enabled = False
		Me.pnlPrimaryDay.Location = New System.Drawing.Point(229, 219)
		Me.pnlPrimaryDay.Name = "pnlPrimaryDay"
		Me.pnlPrimaryDay.Size = New System.Drawing.Size(124, 57)
		Me.pnlPrimaryDay.TabIndex = 0
		Me.pnlPrimaryDay.Visible = False
		'
		'cbPrimaryDay
		'
		Me.cbPrimaryDay.CausesValidation = False
		Me.cbPrimaryDay.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbPrimaryDay.FormattingEnabled = True
		Me.cbPrimaryDay.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.cbPrimaryDay.Location = New System.Drawing.Point(7, 24)
		Me.cbPrimaryDay.Name = "cbPrimaryDay"
		Me.cbPrimaryDay.Size = New System.Drawing.Size(103, 21)
		Me.cbPrimaryDay.TabIndex = 0
		Me.cbPrimaryDay.TabStop = False
		'
		'yetAnotherLabel
		'
		Me.yetAnotherLabel.AutoSize = True
		Me.yetAnotherLabel.BackColor = System.Drawing.Color.Transparent
		Me.yetAnotherLabel.CausesValidation = False
		Me.yetAnotherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.yetAnotherLabel.ForeColor = System.Drawing.Color.Gainsboro
		Me.yetAnotherLabel.Location = New System.Drawing.Point(0, 0)
		Me.yetAnotherLabel.Name = "yetAnotherLabel"
		Me.yetAnotherLabel.Size = New System.Drawing.Size(74, 13)
		Me.yetAnotherLabel.TabIndex = 0
		Me.yetAnotherLabel.Text = "Primary Day"
		Me.yetAnotherLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.yetAnotherLabel.UseMnemonic = False
		'
		'lblQualifyingPeriod
		'
		Me.lblQualifyingPeriod.AutoSize = True
		Me.lblQualifyingPeriod.BackColor = System.Drawing.Color.Transparent
		Me.lblQualifyingPeriod.CausesValidation = False
		Me.lblQualifyingPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQualifyingPeriod.Location = New System.Drawing.Point(8, 7)
		Me.lblQualifyingPeriod.Name = "lblQualifyingPeriod"
		Me.lblQualifyingPeriod.Size = New System.Drawing.Size(206, 13)
		Me.lblQualifyingPeriod.TabIndex = 0
		Me.lblQualifyingPeriod.Text = "Calendar displays Qualifying Period"
		Me.lblQualifyingPeriod.UseMnemonic = False
		'
		'StepC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lblQualifyingPeriod)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Controls.Add(Me.pnlMonthCal)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.pnlEarningDays)
		Me.Controls.Add(Me.pnlRedemptionDays)
		Me.Controls.Add(Me.pnlPrimaryDay)
		Me.Controls.Add(Me.pnlOccuringQualifyingPeriod)
		Me.Controls.Add(Me.pnlRecurringQualifyingPeriod)
		Me.Controls.Add(Me.pnlOccursDate)
		Me.Name = "StepC"
		Me.NextStep = "StepCanHazSecurity"
		Me.PreviousStep = "StepB"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Set the date information for the promotional."
		Me.Controls.SetChildIndex(Me.pnlOccursDate, 0)
		Me.Controls.SetChildIndex(Me.pnlRecurringQualifyingPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlOccuringQualifyingPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlPrimaryDay, 0)
		Me.Controls.SetChildIndex(Me.pnlRedemptionDays, 0)
		Me.Controls.SetChildIndex(Me.pnlEarningDays, 0)
		Me.Controls.SetChildIndex(Me.Panel7, 0)
		Me.Controls.SetChildIndex(Me.pnlMonthCal, 0)
		Me.Controls.SetChildIndex(Me.CheckedListBox1, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.lblQualifyingPeriod, 0)
		Me.pnlRedemptionDays.ResumeLayout(False)
		Me.pnlRedemptionDays.PerformLayout()
		Me.pnlCbRedemptionDays.ResumeLayout(False)
		Me.pnlCbRedemptionDays.PerformLayout()
		Me.pnlEarningDays.ResumeLayout(False)
		Me.pnlEarningDays.PerformLayout()
		Me.pnlWhenQPStart.ResumeLayout(False)
		Me.pnlWhenQPEnd.ResumeLayout(False)
		Me.pnlOccuringQualifyingPeriod.ResumeLayout(False)
		Me.pnlOccuringQualifyingPeriod.PerformLayout()
		Me.pnlOccursDate.ResumeLayout(False)
		Me.pnlOccursDate.PerformLayout()
		Me.pnlMoccasin.ResumeLayout(False)
		Me.pnlMoccasin.PerformLayout()
		Me.pnlMonthCal.ResumeLayout(False)
		Me.pnlRecurringQualifyingPeriod.ResumeLayout(False)
		Me.Panel7.ResumeLayout(False)
		Me.pnlPrimaryDay.ResumeLayout(False)
		Me.pnlPrimaryDay.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
	Friend WithEvents Panel7 As System.Windows.Forms.Panel
	Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
	Private WithEvents pnlRedemptionDays As System.Windows.Forms.Panel
	Private WithEvents lblRedemptionDays As System.Windows.Forms.Label
	Private WithEvents pnlEarningDays As System.Windows.Forms.Panel
	Private WithEvents pnlWhenQPStart As System.Windows.Forms.Panel
	Private WithEvents dtpQualifyingStart As System.Windows.Forms.DateTimePicker
	Private WithEvents lblWhenQPStart As System.Windows.Forms.Label
	Private WithEvents pnlWhenQPEnd As System.Windows.Forms.Panel
	Private WithEvents dtpQualifyingEnd As System.Windows.Forms.DateTimePicker
	Private WithEvents lblWhenQPEnd As System.Windows.Forms.Label
	Private WithEvents clbPointsEarningDays As System.Windows.Forms.CheckedListBox
	Private WithEvents lblPointsEarningDays As System.Windows.Forms.Label
	Private WithEvents cbSelectAll As System.Windows.Forms.CheckBox
	Private WithEvents lblPrimaryDay As System.Windows.Forms.Label
	Private WithEvents lblQualifyingEnd As System.Windows.Forms.Label
	Private WithEvents lblQualifyingStart As System.Windows.Forms.Label
	Private WithEvents lblYALBL As System.Windows.Forms.Label
	Private WithEvents MonthCal As System.Windows.Forms.MonthCalendar
	Private WithEvents pnlOccuringQualifyingPeriod As System.Windows.Forms.Panel
	Private WithEvents pnlMonthCal As System.Windows.Forms.Panel
	Private WithEvents pnlCbRedemptionDays As System.Windows.Forms.Panel
	Private WithEvents cbSaturday As System.Windows.Forms.CheckBox
	Private WithEvents cbFriday As System.Windows.Forms.CheckBox
	Private WithEvents cbThursday As System.Windows.Forms.CheckBox
	Private WithEvents cbWednesday As System.Windows.Forms.CheckBox
	Private WithEvents cbTuesday As System.Windows.Forms.CheckBox
	Private WithEvents cbMonday As System.Windows.Forms.CheckBox
	Private WithEvents cbSunday As System.Windows.Forms.CheckBox
	Private WithEvents pnlRecurringQualifyingPeriod As System.Windows.Forms.Panel
	Private WithEvents pnlPrimaryDay As System.Windows.Forms.Panel
	Private WithEvents cbPrimaryDay As System.Windows.Forms.ComboBox
	Private WithEvents yetAnotherLabel As System.Windows.Forms.Label
	Private WithEvents Label9 As System.Windows.Forms.Label
	Private WithEvents Label10 As System.Windows.Forms.Label
	Private WithEvents cbSameDayPromo As System.Windows.Forms.CheckBox
	Private WithEvents lblPromoOccursDate As System.Windows.Forms.Label
	Private WithEvents dtpOccursDate As System.Windows.Forms.DateTimePicker
	Private WithEvents pnlOccursDate As System.Windows.Forms.Panel
	Private WithEvents lblQualifyingPeriod As System.Windows.Forms.Label
	Private WithEvents lblSelectDates As System.Windows.Forms.Label
	Private WithEvents cbSingleDayPromo As System.Windows.Forms.CheckBox
	Private WithEvents pnlMoccasin As System.Windows.Forms.Panel

End Class

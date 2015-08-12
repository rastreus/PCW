<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepGetCouponOffers
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
		Me.pnlExclusionDays = New System.Windows.Forms.Panel()
		Me.cbSelectAllExcludeDays = New System.Windows.Forms.CheckBox()
		Me.lblExcludedDays = New System.Windows.Forms.Label()
		Me.clbExcludeDays = New System.Windows.Forms.CheckedListBox()
		Me.pnlExcludeRange = New System.Windows.Forms.Panel()
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
		Me.cbSelectAllCouponOffers = New System.Windows.Forms.CheckBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.pnlForCheckBox = New System.Windows.Forms.Panel()
		Me.lblCouponOffersDirections = New System.Windows.Forms.Label()
		Me.pnlAskExclude = New System.Windows.Forms.Panel()
		Me.pnlPapayaWhip = New System.Windows.Forms.Panel()
		Me.rbExcludeDaysNO = New System.Windows.Forms.RadioButton()
		Me.rbExcludeDaysYES = New System.Windows.Forms.RadioButton()
		Me.lblAskExclude = New System.Windows.Forms.Label()
		Me.pnlFullValidate = New System.Windows.Forms.Panel()
		Me.rbFullValidateNO = New System.Windows.Forms.RadioButton()
		Me.lblFullValidate = New System.Windows.Forms.Label()
		Me.rbFullValidateYES = New System.Windows.Forms.RadioButton()
		Me.pnlReprintable = New System.Windows.Forms.Panel()
		Me.rbReprintableNO = New System.Windows.Forms.RadioButton()
		Me.rbReprintableYES = New System.Windows.Forms.RadioButton()
		Me.lblReprintable = New System.Windows.Forms.Label()
		Me.pnlScanToReceipt = New System.Windows.Forms.Panel()
		Me.rbScanToReceiptNO = New System.Windows.Forms.RadioButton()
		Me.lblScanToReceipt = New System.Windows.Forms.Label()
		Me.rbScanToReceiptYES = New System.Windows.Forms.RadioButton()
		Me.pnlNote = New System.Windows.Forms.Panel()
		Me.NoteSuccessIcon = New FontAwesomeIcons.IconButton()
		Me.btnSetNote = New System.Windows.Forms.Button()
		Me.txtNote = New System.Windows.Forms.TextBox()
		Me.lblNote = New System.Windows.Forms.Label()
		Me.pnlCouponWildcard = New System.Windows.Forms.Panel()
		Me.rbCouponWildcardNO = New System.Windows.Forms.RadioButton()
		Me.rbCouponWildcardYES = New System.Windows.Forms.RadioButton()
		Me.lblCouponWildcard = New System.Windows.Forms.Label()
		Me.pnlExclusionDays.SuspendLayout()
		Me.pnlExcludeRange.SuspendLayout()
		Me.pnlExcludeStart.SuspendLayout()
		Me.pnlExcludeEnd.SuspendLayout()
		Me.pnlValidPeriod.SuspendLayout()
		Me.pnlValidStart.SuspendLayout()
		Me.pnlValidEnd.SuspendLayout()
		Me.pnlCouponOffers.SuspendLayout()
		Me.pnlAskExclude.SuspendLayout()
		Me.pnlPapayaWhip.SuspendLayout()
		Me.pnlFullValidate.SuspendLayout()
		Me.pnlReprintable.SuspendLayout()
		Me.pnlScanToReceipt.SuspendLayout()
		Me.pnlNote.SuspendLayout()
		CType(Me.NoteSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlCouponWildcard.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Create Coupon Offer(s) for the Payout."
		'
		'pnlExclusionDays
		'
		Me.pnlExclusionDays.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlExclusionDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlExclusionDays.Controls.Add(Me.cbSelectAllExcludeDays)
		Me.pnlExclusionDays.Controls.Add(Me.lblExcludedDays)
		Me.pnlExclusionDays.Controls.Add(Me.clbExcludeDays)
		Me.pnlExclusionDays.Enabled = False
		Me.pnlExclusionDays.Location = New System.Drawing.Point(426, 100)
		Me.pnlExclusionDays.Name = "pnlExclusionDays"
		Me.pnlExclusionDays.Size = New System.Drawing.Size(132, 192)
		Me.pnlExclusionDays.TabIndex = 27
		'
		'cbSelectAllExcludeDays
		'
		Me.cbSelectAllExcludeDays.AutoSize = True
		Me.cbSelectAllExcludeDays.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSelectAllExcludeDays.ForeColor = System.Drawing.Color.Lime
		Me.cbSelectAllExcludeDays.Location = New System.Drawing.Point(15, 168)
		Me.cbSelectAllExcludeDays.Name = "cbSelectAllExcludeDays"
		Me.cbSelectAllExcludeDays.Size = New System.Drawing.Size(86, 17)
		Me.cbSelectAllExcludeDays.TabIndex = 0
		Me.cbSelectAllExcludeDays.TabStop = False
		Me.cbSelectAllExcludeDays.Text = "Select All"
		Me.cbSelectAllExcludeDays.UseVisualStyleBackColor = True
		'
		'lblExcludedDays
		'
		Me.lblExcludedDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludedDays.ForeColor = System.Drawing.Color.White
		Me.lblExcludedDays.Location = New System.Drawing.Point(3, 0)
		Me.lblExcludedDays.Name = "lblExcludedDays"
		Me.lblExcludedDays.Size = New System.Drawing.Size(122, 54)
		Me.lblExcludedDays.TabIndex = 0
		Me.lblExcludedDays.Text = "On which day(s), in exclusion range, will offer be excluded?"
		Me.lblExcludedDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'clbExcludeDays
		'
		Me.clbExcludeDays.BackColor = System.Drawing.Color.PaleTurquoise
		Me.clbExcludeDays.CausesValidation = False
		Me.clbExcludeDays.CheckOnClick = True
		Me.clbExcludeDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.clbExcludeDays.FormattingEnabled = True
		Me.clbExcludeDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.clbExcludeDays.Location = New System.Drawing.Point(12, 53)
		Me.clbExcludeDays.Name = "clbExcludeDays"
		Me.clbExcludeDays.Size = New System.Drawing.Size(103, 109)
		Me.clbExcludeDays.TabIndex = 0
		Me.clbExcludeDays.TabStop = False
		Me.clbExcludeDays.ThreeDCheckBoxes = True
		Me.clbExcludeDays.UseTabStops = False
		'
		'pnlExcludeRange
		'
		Me.pnlExcludeRange.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlExcludeRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlExcludeRange.Controls.Add(Me.pnlExcludeStart)
		Me.pnlExcludeRange.Controls.Add(Me.pnlExcludeEnd)
		Me.pnlExcludeRange.Enabled = False
		Me.pnlExcludeRange.Location = New System.Drawing.Point(338, 5)
		Me.pnlExcludeRange.Name = "pnlExcludeRange"
		Me.pnlExcludeRange.Size = New System.Drawing.Size(220, 89)
		Me.pnlExcludeRange.TabIndex = 29
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
		Me.dtpExcludeStart.TabIndex = 0
		Me.dtpExcludeStart.TabStop = False
		'
		'lblExcludeStart
		'
		Me.lblExcludeStart.BackColor = System.Drawing.Color.Transparent
		Me.lblExcludeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludeStart.ForeColor = System.Drawing.Color.Black
		Me.lblExcludeStart.Location = New System.Drawing.Point(0, 0)
		Me.lblExcludeStart.Name = "lblExcludeStart"
		Me.lblExcludeStart.Size = New System.Drawing.Size(106, 48)
		Me.lblExcludeStart.TabIndex = 0
		Me.lblExcludeStart.Text = "When does the exclusion range start?"
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
		Me.dtpExcludeEnd.TabIndex = 0
		Me.dtpExcludeEnd.TabStop = False
		'
		'lblExcludeEnd
		'
		Me.lblExcludeEnd.BackColor = System.Drawing.Color.Transparent
		Me.lblExcludeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcludeEnd.ForeColor = System.Drawing.Color.Black
		Me.lblExcludeEnd.Location = New System.Drawing.Point(0, 0)
		Me.lblExcludeEnd.Name = "lblExcludeEnd"
		Me.lblExcludeEnd.Size = New System.Drawing.Size(105, 48)
		Me.lblExcludeEnd.TabIndex = 0
		Me.lblExcludeEnd.Text = "When does the exclusion range end?"
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
		Me.dtpValidStart.TabIndex = 0
		Me.dtpValidStart.TabStop = False
		'
		'lblValidStart
		'
		Me.lblValidStart.BackColor = System.Drawing.Color.Transparent
		Me.lblValidStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValidStart.ForeColor = System.Drawing.Color.Black
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
		Me.dtpValidEnd.TabIndex = 0
		Me.dtpValidEnd.TabStop = False
		'
		'lblValidEnd
		'
		Me.lblValidEnd.BackColor = System.Drawing.Color.Transparent
		Me.lblValidEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValidEnd.ForeColor = System.Drawing.Color.Black
		Me.lblValidEnd.Location = New System.Drawing.Point(0, 0)
		Me.lblValidEnd.Name = "lblValidEnd"
		Me.lblValidEnd.Size = New System.Drawing.Size(106, 48)
		Me.lblValidEnd.TabIndex = 0
		Me.lblValidEnd.Text = "When does the valid period end?"
		'
		'btnSubmit
		'
		Me.btnSubmit.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSubmit.Enabled = False
		Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSubmit.FlatAppearance.BorderSize = 2
		Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
		Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmit.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmit.ForeColor = System.Drawing.Color.White
		Me.btnSubmit.Location = New System.Drawing.Point(9, 162)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(100, 23)
		Me.btnSubmit.TabIndex = 31
		Me.btnSubmit.UseVisualStyleBackColor = False
		'
		'lblCouponOffers
		'
		Me.lblCouponOffers.BackColor = System.Drawing.Color.Transparent
		Me.lblCouponOffers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponOffers.ForeColor = System.Drawing.Color.White
		Me.lblCouponOffers.Location = New System.Drawing.Point(-2, -5)
		Me.lblCouponOffers.Name = "lblCouponOffers"
		Me.lblCouponOffers.Size = New System.Drawing.Size(189, 22)
		Me.lblCouponOffers.TabIndex = 32
		Me.lblCouponOffers.Text = "Coupon Offers List:"
		Me.lblCouponOffers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlCouponOffers
		'
		Me.pnlCouponOffers.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCouponOffers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCouponOffers.Controls.Add(Me.cbSelectAllCouponOffers)
		Me.pnlCouponOffers.Controls.Add(Me.btnDelete)
		Me.pnlCouponOffers.Controls.Add(Me.lblCouponOffers)
		Me.pnlCouponOffers.Controls.Add(Me.btnSubmit)
		Me.pnlCouponOffers.Controls.Add(Me.pnlForCheckBox)
		Me.pnlCouponOffers.Location = New System.Drawing.Point(231, 100)
		Me.pnlCouponOffers.Name = "pnlCouponOffers"
		Me.pnlCouponOffers.Size = New System.Drawing.Size(189, 192)
		Me.pnlCouponOffers.TabIndex = 33
		'
		'cbSelectAllCouponOffers
		'
		Me.cbSelectAllCouponOffers.AutoSize = True
		Me.cbSelectAllCouponOffers.Enabled = False
		Me.cbSelectAllCouponOffers.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbSelectAllCouponOffers.ForeColor = System.Drawing.Color.Lime
		Me.cbSelectAllCouponOffers.Location = New System.Drawing.Point(14, 144)
		Me.cbSelectAllCouponOffers.Name = "cbSelectAllCouponOffers"
		Me.cbSelectAllCouponOffers.Size = New System.Drawing.Size(86, 17)
		Me.cbSelectAllCouponOffers.TabIndex = 34
		Me.cbSelectAllCouponOffers.TabStop = False
		Me.cbSelectAllCouponOffers.Text = "Select All"
		Me.cbSelectAllCouponOffers.UseMnemonic = False
		Me.cbSelectAllCouponOffers.UseVisualStyleBackColor = True
		Me.cbSelectAllCouponOffers.Visible = False
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Gainsboro
		Me.btnDelete.CausesValidation = False
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnDelete.FlatAppearance.BorderSize = 2
		Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink
		Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.HotPink
		Me.btnDelete.Location = New System.Drawing.Point(115, 162)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(58, 23)
		Me.btnDelete.TabIndex = 0
		Me.btnDelete.TabStop = False
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'pnlForCheckBox
		'
		Me.pnlForCheckBox.BackColor = System.Drawing.SystemColors.ControlDark
		Me.pnlForCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlForCheckBox.CausesValidation = False
		Me.pnlForCheckBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlForCheckBox.ForeColor = System.Drawing.Color.White
		Me.pnlForCheckBox.Location = New System.Drawing.Point(9, 17)
		Me.pnlForCheckBox.Name = "pnlForCheckBox"
		Me.pnlForCheckBox.Size = New System.Drawing.Size(164, 125)
		Me.pnlForCheckBox.TabIndex = 0
		'
		'lblCouponOffersDirections
		'
		Me.lblCouponOffersDirections.BackColor = System.Drawing.Color.Transparent
		Me.lblCouponOffersDirections.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponOffersDirections.ForeColor = System.Drawing.Color.Black
		Me.lblCouponOffersDirections.Location = New System.Drawing.Point(19, 258)
		Me.lblCouponOffersDirections.Name = "lblCouponOffersDirections"
		Me.lblCouponOffersDirections.Size = New System.Drawing.Size(204, 35)
		Me.lblCouponOffersDirections.TabIndex = 0
		Me.lblCouponOffersDirections.Text = "Click 'Submit' below to add Coupon Offers to this Coupon ID."
		Me.lblCouponOffersDirections.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblCouponOffersDirections.UseMnemonic = False
		'
		'pnlAskExclude
		'
		Me.pnlAskExclude.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlAskExclude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlAskExclude.Controls.Add(Me.pnlPapayaWhip)
		Me.pnlAskExclude.Controls.Add(Me.lblAskExclude)
		Me.pnlAskExclude.Location = New System.Drawing.Point(231, 5)
		Me.pnlAskExclude.Name = "pnlAskExclude"
		Me.pnlAskExclude.Size = New System.Drawing.Size(100, 89)
		Me.pnlAskExclude.TabIndex = 34
		'
		'pnlPapayaWhip
		'
		Me.pnlPapayaWhip.BackColor = System.Drawing.Color.Pink
		Me.pnlPapayaWhip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPapayaWhip.Controls.Add(Me.rbExcludeDaysNO)
		Me.pnlPapayaWhip.Controls.Add(Me.rbExcludeDaysYES)
		Me.pnlPapayaWhip.Location = New System.Drawing.Point(6, 21)
		Me.pnlPapayaWhip.Name = "pnlPapayaWhip"
		Me.pnlPapayaWhip.Size = New System.Drawing.Size(82, 56)
		Me.pnlPapayaWhip.TabIndex = 1
		'
		'rbExcludeDaysNO
		'
		Me.rbExcludeDaysNO.AutoSize = True
		Me.rbExcludeDaysNO.Checked = True
		Me.rbExcludeDaysNO.ForeColor = System.Drawing.Color.Black
		Me.rbExcludeDaysNO.Location = New System.Drawing.Point(16, 31)
		Me.rbExcludeDaysNO.Name = "rbExcludeDaysNO"
		Me.rbExcludeDaysNO.Size = New System.Drawing.Size(39, 17)
		Me.rbExcludeDaysNO.TabIndex = 0
		Me.rbExcludeDaysNO.TabStop = True
		Me.rbExcludeDaysNO.Text = "No"
		Me.rbExcludeDaysNO.UseVisualStyleBackColor = True
		'
		'rbExcludeDaysYES
		'
		Me.rbExcludeDaysYES.AutoSize = True
		Me.rbExcludeDaysYES.ForeColor = System.Drawing.Color.Black
		Me.rbExcludeDaysYES.Location = New System.Drawing.Point(16, 8)
		Me.rbExcludeDaysYES.Name = "rbExcludeDaysYES"
		Me.rbExcludeDaysYES.Size = New System.Drawing.Size(43, 17)
		Me.rbExcludeDaysYES.TabIndex = 0
		Me.rbExcludeDaysYES.Text = "Yes"
		Me.rbExcludeDaysYES.UseVisualStyleBackColor = True
		'
		'lblAskExclude
		'
		Me.lblAskExclude.BackColor = System.Drawing.Color.Transparent
		Me.lblAskExclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAskExclude.ForeColor = System.Drawing.Color.White
		Me.lblAskExclude.Location = New System.Drawing.Point(3, 0)
		Me.lblAskExclude.Name = "lblAskExclude"
		Me.lblAskExclude.Size = New System.Drawing.Size(91, 13)
		Me.lblAskExclude.TabIndex = 0
		Me.lblAskExclude.Text = "Exclude Days?"
		Me.lblAskExclude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlFullValidate
		'
		Me.pnlFullValidate.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlFullValidate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlFullValidate.Controls.Add(Me.rbFullValidateNO)
		Me.pnlFullValidate.Controls.Add(Me.lblFullValidate)
		Me.pnlFullValidate.Controls.Add(Me.rbFullValidateYES)
		Me.pnlFullValidate.Location = New System.Drawing.Point(2, 134)
		Me.pnlFullValidate.Name = "pnlFullValidate"
		Me.pnlFullValidate.Size = New System.Drawing.Size(222, 25)
		Me.pnlFullValidate.TabIndex = 35
		'
		'rbFullValidateNO
		'
		Me.rbFullValidateNO.AutoSize = True
		Me.rbFullValidateNO.BackColor = System.Drawing.Color.Transparent
		Me.rbFullValidateNO.Checked = True
		Me.rbFullValidateNO.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbFullValidateNO.ForeColor = System.Drawing.Color.White
		Me.rbFullValidateNO.Location = New System.Drawing.Point(175, 2)
		Me.rbFullValidateNO.Name = "rbFullValidateNO"
		Me.rbFullValidateNO.Size = New System.Drawing.Size(37, 17)
		Me.rbFullValidateNO.TabIndex = 0
		Me.rbFullValidateNO.TabStop = True
		Me.rbFullValidateNO.Text = "No"
		Me.rbFullValidateNO.UseVisualStyleBackColor = False
		'
		'lblFullValidate
		'
		Me.lblFullValidate.BackColor = System.Drawing.Color.Transparent
		Me.lblFullValidate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFullValidate.ForeColor = System.Drawing.Color.White
		Me.lblFullValidate.Location = New System.Drawing.Point(0, 1)
		Me.lblFullValidate.Name = "lblFullValidate"
		Me.lblFullValidate.Size = New System.Drawing.Size(120, 19)
		Me.lblFullValidate.TabIndex = 0
		Me.lblFullValidate.Text = "Full Validate?"
		Me.lblFullValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'rbFullValidateYES
		'
		Me.rbFullValidateYES.AutoSize = True
		Me.rbFullValidateYES.BackColor = System.Drawing.Color.Transparent
		Me.rbFullValidateYES.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbFullValidateYES.ForeColor = System.Drawing.Color.White
		Me.rbFullValidateYES.Location = New System.Drawing.Point(126, 2)
		Me.rbFullValidateYES.Name = "rbFullValidateYES"
		Me.rbFullValidateYES.Size = New System.Drawing.Size(43, 17)
		Me.rbFullValidateYES.TabIndex = 0
		Me.rbFullValidateYES.Text = "Yes"
		Me.rbFullValidateYES.UseVisualStyleBackColor = False
		'
		'pnlReprintable
		'
		Me.pnlReprintable.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlReprintable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlReprintable.Controls.Add(Me.rbReprintableNO)
		Me.pnlReprintable.Controls.Add(Me.rbReprintableYES)
		Me.pnlReprintable.Controls.Add(Me.lblReprintable)
		Me.pnlReprintable.Location = New System.Drawing.Point(2, 157)
		Me.pnlReprintable.Name = "pnlReprintable"
		Me.pnlReprintable.Size = New System.Drawing.Size(222, 25)
		Me.pnlReprintable.TabIndex = 36
		'
		'rbReprintableNO
		'
		Me.rbReprintableNO.AutoSize = True
		Me.rbReprintableNO.Checked = True
		Me.rbReprintableNO.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbReprintableNO.ForeColor = System.Drawing.Color.White
		Me.rbReprintableNO.Location = New System.Drawing.Point(175, 2)
		Me.rbReprintableNO.Name = "rbReprintableNO"
		Me.rbReprintableNO.Size = New System.Drawing.Size(37, 17)
		Me.rbReprintableNO.TabIndex = 0
		Me.rbReprintableNO.TabStop = True
		Me.rbReprintableNO.Text = "No"
		Me.rbReprintableNO.UseVisualStyleBackColor = True
		'
		'rbReprintableYES
		'
		Me.rbReprintableYES.AutoSize = True
		Me.rbReprintableYES.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbReprintableYES.ForeColor = System.Drawing.Color.White
		Me.rbReprintableYES.Location = New System.Drawing.Point(126, 2)
		Me.rbReprintableYES.Name = "rbReprintableYES"
		Me.rbReprintableYES.Size = New System.Drawing.Size(43, 17)
		Me.rbReprintableYES.TabIndex = 0
		Me.rbReprintableYES.Text = "Yes"
		Me.rbReprintableYES.UseVisualStyleBackColor = True
		'
		'lblReprintable
		'
		Me.lblReprintable.BackColor = System.Drawing.Color.Transparent
		Me.lblReprintable.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblReprintable.ForeColor = System.Drawing.Color.White
		Me.lblReprintable.Location = New System.Drawing.Point(0, 1)
		Me.lblReprintable.Name = "lblReprintable"
		Me.lblReprintable.Size = New System.Drawing.Size(120, 18)
		Me.lblReprintable.TabIndex = 0
		Me.lblReprintable.Text = "Reprintable?"
		Me.lblReprintable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'pnlScanToReceipt
		'
		Me.pnlScanToReceipt.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlScanToReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlScanToReceipt.Controls.Add(Me.rbScanToReceiptNO)
		Me.pnlScanToReceipt.Controls.Add(Me.lblScanToReceipt)
		Me.pnlScanToReceipt.Controls.Add(Me.rbScanToReceiptYES)
		Me.pnlScanToReceipt.Location = New System.Drawing.Point(2, 180)
		Me.pnlScanToReceipt.Name = "pnlScanToReceipt"
		Me.pnlScanToReceipt.Size = New System.Drawing.Size(222, 25)
		Me.pnlScanToReceipt.TabIndex = 37
		'
		'rbScanToReceiptNO
		'
		Me.rbScanToReceiptNO.AutoSize = True
		Me.rbScanToReceiptNO.BackColor = System.Drawing.Color.Transparent
		Me.rbScanToReceiptNO.Checked = True
		Me.rbScanToReceiptNO.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbScanToReceiptNO.ForeColor = System.Drawing.Color.White
		Me.rbScanToReceiptNO.Location = New System.Drawing.Point(175, 1)
		Me.rbScanToReceiptNO.Name = "rbScanToReceiptNO"
		Me.rbScanToReceiptNO.Size = New System.Drawing.Size(37, 17)
		Me.rbScanToReceiptNO.TabIndex = 0
		Me.rbScanToReceiptNO.TabStop = True
		Me.rbScanToReceiptNO.Text = "No"
		Me.rbScanToReceiptNO.UseVisualStyleBackColor = False
		'
		'lblScanToReceipt
		'
		Me.lblScanToReceipt.BackColor = System.Drawing.Color.Transparent
		Me.lblScanToReceipt.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScanToReceipt.ForeColor = System.Drawing.Color.White
		Me.lblScanToReceipt.Location = New System.Drawing.Point(0, -1)
		Me.lblScanToReceipt.Name = "lblScanToReceipt"
		Me.lblScanToReceipt.Size = New System.Drawing.Size(120, 23)
		Me.lblScanToReceipt.TabIndex = 0
		Me.lblScanToReceipt.Text = "Scan to Receipt?"
		Me.lblScanToReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'rbScanToReceiptYES
		'
		Me.rbScanToReceiptYES.AutoSize = True
		Me.rbScanToReceiptYES.BackColor = System.Drawing.Color.Transparent
		Me.rbScanToReceiptYES.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbScanToReceiptYES.ForeColor = System.Drawing.Color.White
		Me.rbScanToReceiptYES.Location = New System.Drawing.Point(126, 1)
		Me.rbScanToReceiptYES.Name = "rbScanToReceiptYES"
		Me.rbScanToReceiptYES.Size = New System.Drawing.Size(43, 17)
		Me.rbScanToReceiptYES.TabIndex = 0
		Me.rbScanToReceiptYES.Text = "Yes"
		Me.rbScanToReceiptYES.UseVisualStyleBackColor = False
		'
		'pnlNote
		'
		Me.pnlNote.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlNote.Controls.Add(Me.NoteSuccessIcon)
		Me.pnlNote.Controls.Add(Me.btnSetNote)
		Me.pnlNote.Controls.Add(Me.txtNote)
		Me.pnlNote.Controls.Add(Me.lblNote)
		Me.pnlNote.Location = New System.Drawing.Point(2, 203)
		Me.pnlNote.Name = "pnlNote"
		Me.pnlNote.Size = New System.Drawing.Size(222, 55)
		Me.pnlNote.TabIndex = 38
		'
		'NoteSuccessIcon
		'
		Me.NoteSuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.NoteSuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.NoteSuccessIcon.Enabled = False
		Me.NoteSuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.NoteSuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.NoteSuccessIcon.Location = New System.Drawing.Point(195, 27)
		Me.NoteSuccessIcon.Name = "NoteSuccessIcon"
		Me.NoteSuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.NoteSuccessIcon.TabIndex = 35
		Me.NoteSuccessIcon.TabStop = False
		Me.NoteSuccessIcon.ToolTipText = Nothing
		Me.NoteSuccessIcon.Visible = False
		'
		'btnSetNote
		'
		Me.btnSetNote.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSetNote.Enabled = False
		Me.btnSetNote.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSetNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSetNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSetNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSetNote.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetNote.ForeColor = System.Drawing.Color.White
		Me.btnSetNote.Location = New System.Drawing.Point(126, 27)
		Me.btnSetNote.Name = "btnSetNote"
		Me.btnSetNote.Size = New System.Drawing.Size(63, 20)
		Me.btnSetNote.TabIndex = 34
		Me.btnSetNote.Text = "Set"
		Me.btnSetNote.UseVisualStyleBackColor = False
		'
		'txtNote
		'
		Me.txtNote.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNote.Location = New System.Drawing.Point(126, 1)
		Me.txtNote.MaxLength = 14
		Me.txtNote.Name = "txtNote"
		Me.txtNote.Size = New System.Drawing.Size(89, 20)
		Me.txtNote.TabIndex = 1
		Me.txtNote.Text = "EX: Note"
		'
		'lblNote
		'
		Me.lblNote.BackColor = System.Drawing.Color.Transparent
		Me.lblNote.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNote.ForeColor = System.Drawing.Color.White
		Me.lblNote.Location = New System.Drawing.Point(0, 1)
		Me.lblNote.Name = "lblNote"
		Me.lblNote.Size = New System.Drawing.Size(120, 19)
		Me.lblNote.TabIndex = 0
		Me.lblNote.Text = "Note?"
		Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'pnlCouponWildcard
		'
		Me.pnlCouponWildcard.BackColor = System.Drawing.Color.Yellow
		Me.pnlCouponWildcard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCouponWildcard.Controls.Add(Me.rbCouponWildcardNO)
		Me.pnlCouponWildcard.Controls.Add(Me.rbCouponWildcardYES)
		Me.pnlCouponWildcard.Controls.Add(Me.lblCouponWildcard)
		Me.pnlCouponWildcard.Location = New System.Drawing.Point(2, 100)
		Me.pnlCouponWildcard.Name = "pnlCouponWildcard"
		Me.pnlCouponWildcard.Size = New System.Drawing.Size(222, 38)
		Me.pnlCouponWildcard.TabIndex = 39
		'
		'rbCouponWildcardNO
		'
		Me.rbCouponWildcardNO.AutoSize = True
		Me.rbCouponWildcardNO.BackColor = System.Drawing.Color.Transparent
		Me.rbCouponWildcardNO.Checked = True
		Me.rbCouponWildcardNO.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbCouponWildcardNO.ForeColor = System.Drawing.Color.Black
		Me.rbCouponWildcardNO.Location = New System.Drawing.Point(175, 12)
		Me.rbCouponWildcardNO.Name = "rbCouponWildcardNO"
		Me.rbCouponWildcardNO.Size = New System.Drawing.Size(37, 17)
		Me.rbCouponWildcardNO.TabIndex = 0
		Me.rbCouponWildcardNO.TabStop = True
		Me.rbCouponWildcardNO.Text = "No"
		Me.rbCouponWildcardNO.UseVisualStyleBackColor = False
		'
		'rbCouponWildcardYES
		'
		Me.rbCouponWildcardYES.AutoSize = True
		Me.rbCouponWildcardYES.BackColor = System.Drawing.Color.Transparent
		Me.rbCouponWildcardYES.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbCouponWildcardYES.ForeColor = System.Drawing.Color.Black
		Me.rbCouponWildcardYES.Location = New System.Drawing.Point(126, 12)
		Me.rbCouponWildcardYES.Name = "rbCouponWildcardYES"
		Me.rbCouponWildcardYES.Size = New System.Drawing.Size(43, 17)
		Me.rbCouponWildcardYES.TabIndex = 0
		Me.rbCouponWildcardYES.Text = "Yes"
		Me.rbCouponWildcardYES.UseVisualStyleBackColor = False
		'
		'lblCouponWildcard
		'
		Me.lblCouponWildcard.BackColor = System.Drawing.Color.Transparent
		Me.lblCouponWildcard.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponWildcard.ForeColor = System.Drawing.Color.Black
		Me.lblCouponWildcard.Location = New System.Drawing.Point(3, 0)
		Me.lblCouponWildcard.Name = "lblCouponWildcard"
		Me.lblCouponWildcard.Size = New System.Drawing.Size(117, 29)
		Me.lblCouponWildcard.TabIndex = 1
		Me.lblCouponWildcard.Text = "Can the Patron Win more than Once?"
		Me.lblCouponWildcard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'StepGetCouponOffers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lblCouponOffersDirections)
		Me.Controls.Add(Me.pnlNote)
		Me.Controls.Add(Me.pnlScanToReceipt)
		Me.Controls.Add(Me.pnlReprintable)
		Me.Controls.Add(Me.pnlFullValidate)
		Me.Controls.Add(Me.pnlCouponWildcard)
		Me.Controls.Add(Me.pnlAskExclude)
		Me.Controls.Add(Me.pnlCouponOffers)
		Me.Controls.Add(Me.pnlValidPeriod)
		Me.Controls.Add(Me.pnlExcludeRange)
		Me.Controls.Add(Me.pnlExclusionDays)
		Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Name = "StepGetCouponOffers"
		Me.NextStep = "StepGetCouponTargets"
		Me.PreviousStep = "StepGeneratePayoutCoupon"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Create Coupon Offer(s) for the Payout."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlExclusionDays, 0)
		Me.Controls.SetChildIndex(Me.pnlExcludeRange, 0)
		Me.Controls.SetChildIndex(Me.pnlValidPeriod, 0)
		Me.Controls.SetChildIndex(Me.pnlCouponOffers, 0)
		Me.Controls.SetChildIndex(Me.pnlAskExclude, 0)
		Me.Controls.SetChildIndex(Me.pnlCouponWildcard, 0)
		Me.Controls.SetChildIndex(Me.pnlFullValidate, 0)
		Me.Controls.SetChildIndex(Me.pnlReprintable, 0)
		Me.Controls.SetChildIndex(Me.pnlScanToReceipt, 0)
		Me.Controls.SetChildIndex(Me.pnlNote, 0)
		Me.Controls.SetChildIndex(Me.lblCouponOffersDirections, 0)
		Me.pnlExclusionDays.ResumeLayout(False)
		Me.pnlExclusionDays.PerformLayout()
		Me.pnlExcludeRange.ResumeLayout(False)
		Me.pnlExcludeStart.ResumeLayout(False)
		Me.pnlExcludeEnd.ResumeLayout(False)
		Me.pnlValidPeriod.ResumeLayout(False)
		Me.pnlValidStart.ResumeLayout(False)
		Me.pnlValidEnd.ResumeLayout(False)
		Me.pnlCouponOffers.ResumeLayout(False)
		Me.pnlCouponOffers.PerformLayout()
		Me.pnlAskExclude.ResumeLayout(False)
		Me.pnlPapayaWhip.ResumeLayout(False)
		Me.pnlPapayaWhip.PerformLayout()
		Me.pnlFullValidate.ResumeLayout(False)
		Me.pnlFullValidate.PerformLayout()
		Me.pnlReprintable.ResumeLayout(False)
		Me.pnlReprintable.PerformLayout()
		Me.pnlScanToReceipt.ResumeLayout(False)
		Me.pnlScanToReceipt.PerformLayout()
		Me.pnlNote.ResumeLayout(False)
		Me.pnlNote.PerformLayout()
		CType(Me.NoteSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlCouponWildcard.ResumeLayout(False)
		Me.pnlCouponWildcard.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents pnlFullValidate As System.Windows.Forms.Panel
	Private WithEvents rbFullValidateNO As System.Windows.Forms.RadioButton
	Private WithEvents rbFullValidateYES As System.Windows.Forms.RadioButton
	Private WithEvents lblFullValidate As System.Windows.Forms.Label
	Private WithEvents pnlReprintable As System.Windows.Forms.Panel
	Private WithEvents rbReprintableNO As System.Windows.Forms.RadioButton
	Private WithEvents rbReprintableYES As System.Windows.Forms.RadioButton
	Private WithEvents lblReprintable As System.Windows.Forms.Label
	Private WithEvents pnlScanToReceipt As System.Windows.Forms.Panel
	Private WithEvents rbScanToReceiptNO As System.Windows.Forms.RadioButton
	Private WithEvents rbScanToReceiptYES As System.Windows.Forms.RadioButton
	Private WithEvents lblScanToReceipt As System.Windows.Forms.Label
	Private WithEvents pnlNote As System.Windows.Forms.Panel
	Private WithEvents txtNote As System.Windows.Forms.TextBox
	Private WithEvents lblNote As System.Windows.Forms.Label
	Private WithEvents pnlExclusionDays As System.Windows.Forms.Panel
	Private WithEvents cbSelectAllExcludeDays As System.Windows.Forms.CheckBox
	Private WithEvents lblExcludedDays As System.Windows.Forms.Label
	Private WithEvents clbExcludeDays As System.Windows.Forms.CheckedListBox
	Private WithEvents pnlExcludeRange As System.Windows.Forms.Panel
	Private WithEvents pnlExcludeStart As System.Windows.Forms.Panel
	Private WithEvents dtpExcludeStart As System.Windows.Forms.DateTimePicker
	Private WithEvents lblExcludeStart As System.Windows.Forms.Label
	Private WithEvents pnlExcludeEnd As System.Windows.Forms.Panel
	Private WithEvents dtpExcludeEnd As System.Windows.Forms.DateTimePicker
	Private WithEvents lblExcludeEnd As System.Windows.Forms.Label
	Private WithEvents pnlValidPeriod As System.Windows.Forms.Panel
	Private WithEvents pnlValidStart As System.Windows.Forms.Panel
	Private WithEvents dtpValidStart As System.Windows.Forms.DateTimePicker
	Private WithEvents lblValidStart As System.Windows.Forms.Label
	Private WithEvents pnlValidEnd As System.Windows.Forms.Panel
	Private WithEvents dtpValidEnd As System.Windows.Forms.DateTimePicker
	Private WithEvents lblValidEnd As System.Windows.Forms.Label
	Private WithEvents btnSubmit As System.Windows.Forms.Button
	Private WithEvents lblCouponOffers As System.Windows.Forms.Label
	Private WithEvents pnlCouponOffers As System.Windows.Forms.Panel
	Private WithEvents pnlAskExclude As System.Windows.Forms.Panel
	Private WithEvents pnlPapayaWhip As System.Windows.Forms.Panel
	Private WithEvents rbExcludeDaysNO As System.Windows.Forms.RadioButton
	Private WithEvents rbExcludeDaysYES As System.Windows.Forms.RadioButton
	Private WithEvents lblAskExclude As System.Windows.Forms.Label
	Private WithEvents lblCouponWildcard As System.Windows.Forms.Label
	Private WithEvents btnSetNote As System.Windows.Forms.Button
	Private WithEvents NoteSuccessIcon As FontAwesomeIcons.IconButton
	Private WithEvents pnlCouponWildcard As System.Windows.Forms.Panel
	Private WithEvents rbCouponWildcardNO As System.Windows.Forms.RadioButton
	Private WithEvents rbCouponWildcardYES As System.Windows.Forms.RadioButton
	Private WithEvents btnDelete As System.Windows.Forms.Button
	Private WithEvents pnlForCheckBox As System.Windows.Forms.Panel
	Private WithEvents cbSelectAllCouponOffers As System.Windows.Forms.CheckBox
	Private WithEvents lblCouponOffersDirections As System.Windows.Forms.Label

End Class

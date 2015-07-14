<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepCanHazSecurity
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
		Me.pnlSecurity = New System.Windows.Forms.Panel()
		Me.pnlPapayaWhip = New System.Windows.Forms.Panel()
		Me.rbSecurityNO = New System.Windows.Forms.RadioButton()
		Me.rbSecurityYES = New System.Windows.Forms.RadioButton()
		Me.lblSecurity = New System.Windows.Forms.Label()
		Me.pnlOverrideTime = New System.Windows.Forms.Panel()
		Me.btnSubmitOverrideTime = New System.Windows.Forms.Button()
		Me.pnlPaleTurquoise = New System.Windows.Forms.Panel()
		Me.rbOverrideTimePM = New System.Windows.Forms.RadioButton()
		Me.rbOverrideTimeAM = New System.Windows.Forms.RadioButton()
		Me.txtOverrideTimeMinutes = New System.Windows.Forms.TextBox()
		Me.lblTimeColon1 = New System.Windows.Forms.Label()
		Me.txtOverrideTimeHours = New System.Windows.Forms.TextBox()
		Me.lblOverrideTime = New System.Windows.Forms.Label()
		Me.pnlCutoffTime = New System.Windows.Forms.Panel()
		Me.btnSubmitCutoffTime = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.rbCutoffTimePM = New System.Windows.Forms.RadioButton()
		Me.rbCutoffTimeAM = New System.Windows.Forms.RadioButton()
		Me.txtCutoffTimeMinutes = New System.Windows.Forms.TextBox()
		Me.lblTimeColon2 = New System.Windows.Forms.Label()
		Me.txtCutoffTimeHours = New System.Windows.Forms.TextBox()
		Me.lblCutoffTime = New System.Windows.Forms.Label()
		Me.pnlExplanations = New System.Windows.Forms.Panel()
		Me.lblOverrideExplanation = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblBefore = New System.Windows.Forms.Label()
		Me.lblSecDesc = New System.Windows.Forms.Label()
		Me.pnlSecurity.SuspendLayout()
		Me.pnlPapayaWhip.SuspendLayout()
		Me.pnlOverrideTime.SuspendLayout()
		Me.pnlPaleTurquoise.SuspendLayout()
		Me.pnlCutoffTime.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.pnlExplanations.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Add security features here."
		'
		'pnlSecurity
		'
		Me.pnlSecurity.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlSecurity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlSecurity.Controls.Add(Me.pnlPapayaWhip)
		Me.pnlSecurity.Controls.Add(Me.lblSecurity)
		Me.pnlSecurity.Location = New System.Drawing.Point(68, 83)
		Me.pnlSecurity.Name = "pnlSecurity"
		Me.pnlSecurity.Size = New System.Drawing.Size(160, 140)
		Me.pnlSecurity.TabIndex = 0
		'
		'pnlPapayaWhip
		'
		Me.pnlPapayaWhip.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlPapayaWhip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPapayaWhip.CausesValidation = False
		Me.pnlPapayaWhip.Controls.Add(Me.rbSecurityNO)
		Me.pnlPapayaWhip.Controls.Add(Me.rbSecurityYES)
		Me.pnlPapayaWhip.Location = New System.Drawing.Point(8, 73)
		Me.pnlPapayaWhip.Name = "pnlPapayaWhip"
		Me.pnlPapayaWhip.Size = New System.Drawing.Size(135, 50)
		Me.pnlPapayaWhip.TabIndex = 0
		'
		'rbSecurityNO
		'
		Me.rbSecurityNO.AutoSize = True
		Me.rbSecurityNO.Checked = True
		Me.rbSecurityNO.Location = New System.Drawing.Point(40, 27)
		Me.rbSecurityNO.Name = "rbSecurityNO"
		Me.rbSecurityNO.Size = New System.Drawing.Size(39, 17)
		Me.rbSecurityNO.TabIndex = 2
		Me.rbSecurityNO.TabStop = True
		Me.rbSecurityNO.Text = "No"
		Me.rbSecurityNO.UseVisualStyleBackColor = True
		'
		'rbSecurityYES
		'
		Me.rbSecurityYES.AutoSize = True
		Me.rbSecurityYES.Location = New System.Drawing.Point(40, 4)
		Me.rbSecurityYES.Name = "rbSecurityYES"
		Me.rbSecurityYES.Size = New System.Drawing.Size(43, 17)
		Me.rbSecurityYES.TabIndex = 1
		Me.rbSecurityYES.TabStop = True
		Me.rbSecurityYES.Text = "Yes"
		Me.rbSecurityYES.UseVisualStyleBackColor = True
		'
		'lblSecurity
		'
		Me.lblSecurity.BackColor = System.Drawing.Color.Transparent
		Me.lblSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSecurity.ForeColor = System.Drawing.Color.White
		Me.lblSecurity.Location = New System.Drawing.Point(0, 0)
		Me.lblSecurity.Name = "lblSecurity"
		Me.lblSecurity.Size = New System.Drawing.Size(158, 75)
		Me.lblSecurity.TabIndex = 0
		Me.lblSecurity.Text = "Would you like to add Override Time and Cutoff Time as security features?"
		'
		'pnlOverrideTime
		'
		Me.pnlOverrideTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlOverrideTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOverrideTime.Controls.Add(Me.btnSubmitOverrideTime)
		Me.pnlOverrideTime.Controls.Add(Me.pnlPaleTurquoise)
		Me.pnlOverrideTime.Controls.Add(Me.txtOverrideTimeMinutes)
		Me.pnlOverrideTime.Controls.Add(Me.lblTimeColon1)
		Me.pnlOverrideTime.Controls.Add(Me.txtOverrideTimeHours)
		Me.pnlOverrideTime.Controls.Add(Me.lblOverrideTime)
		Me.pnlOverrideTime.Enabled = False
		Me.pnlOverrideTime.Location = New System.Drawing.Point(380, 83)
		Me.pnlOverrideTime.Name = "pnlOverrideTime"
		Me.pnlOverrideTime.Size = New System.Drawing.Size(140, 75)
		Me.pnlOverrideTime.TabIndex = 0
		'
		'btnSubmitOverrideTime
		'
		Me.btnSubmitOverrideTime.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSubmitOverrideTime.Enabled = False
		Me.btnSubmitOverrideTime.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.btnSubmitOverrideTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSubmitOverrideTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSubmitOverrideTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmitOverrideTime.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmitOverrideTime.ForeColor = System.Drawing.Color.White
		Me.btnSubmitOverrideTime.Location = New System.Drawing.Point(3, 48)
		Me.btnSubmitOverrideTime.Name = "btnSubmitOverrideTime"
		Me.btnSubmitOverrideTime.Size = New System.Drawing.Size(74, 20)
		Me.btnSubmitOverrideTime.TabIndex = 0
		Me.btnSubmitOverrideTime.TabStop = False
		Me.btnSubmitOverrideTime.Text = "Set"
		Me.btnSubmitOverrideTime.UseVisualStyleBackColor = False
		'
		'pnlPaleTurquoise
		'
		Me.pnlPaleTurquoise.BackColor = System.Drawing.Color.PaleTurquoise
		Me.pnlPaleTurquoise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPaleTurquoise.Controls.Add(Me.rbOverrideTimePM)
		Me.pnlPaleTurquoise.Controls.Add(Me.rbOverrideTimeAM)
		Me.pnlPaleTurquoise.Location = New System.Drawing.Point(83, 16)
		Me.pnlPaleTurquoise.Name = "pnlPaleTurquoise"
		Me.pnlPaleTurquoise.Size = New System.Drawing.Size(49, 39)
		Me.pnlPaleTurquoise.TabIndex = 0
		'
		'rbOverrideTimePM
		'
		Me.rbOverrideTimePM.AutoSize = True
		Me.rbOverrideTimePM.Checked = True
		Me.rbOverrideTimePM.Location = New System.Drawing.Point(3, 19)
		Me.rbOverrideTimePM.Name = "rbOverrideTimePM"
		Me.rbOverrideTimePM.Size = New System.Drawing.Size(41, 17)
		Me.rbOverrideTimePM.TabIndex = 6
		Me.rbOverrideTimePM.TabStop = True
		Me.rbOverrideTimePM.Text = "PM"
		Me.rbOverrideTimePM.UseVisualStyleBackColor = True
		'
		'rbOverrideTimeAM
		'
		Me.rbOverrideTimeAM.AutoSize = True
		Me.rbOverrideTimeAM.Location = New System.Drawing.Point(3, 2)
		Me.rbOverrideTimeAM.Name = "rbOverrideTimeAM"
		Me.rbOverrideTimeAM.Size = New System.Drawing.Size(41, 17)
		Me.rbOverrideTimeAM.TabIndex = 5
		Me.rbOverrideTimeAM.TabStop = True
		Me.rbOverrideTimeAM.Text = "AM"
		Me.rbOverrideTimeAM.UseVisualStyleBackColor = True
		'
		'txtOverrideTimeMinutes
		'
		Me.txtOverrideTimeMinutes.BackColor = System.Drawing.Color.WhiteSmoke
		Me.txtOverrideTimeMinutes.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOverrideTimeMinutes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtOverrideTimeMinutes.Location = New System.Drawing.Point(51, 16)
		Me.txtOverrideTimeMinutes.MaxLength = 2
		Me.txtOverrideTimeMinutes.Name = "txtOverrideTimeMinutes"
		Me.txtOverrideTimeMinutes.Size = New System.Drawing.Size(26, 26)
		Me.txtOverrideTimeMinutes.TabIndex = 4
		Me.txtOverrideTimeMinutes.Text = "mm"
		'
		'lblTimeColon1
		'
		Me.lblTimeColon1.BackColor = System.Drawing.Color.Transparent
		Me.lblTimeColon1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTimeColon1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblTimeColon1.Location = New System.Drawing.Point(35, 19)
		Me.lblTimeColon1.Name = "lblTimeColon1"
		Me.lblTimeColon1.Size = New System.Drawing.Size(10, 26)
		Me.lblTimeColon1.TabIndex = 0
		Me.lblTimeColon1.Text = ":"
		Me.lblTimeColon1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'txtOverrideTimeHours
		'
		Me.txtOverrideTimeHours.BackColor = System.Drawing.Color.WhiteSmoke
		Me.txtOverrideTimeHours.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOverrideTimeHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtOverrideTimeHours.Location = New System.Drawing.Point(3, 16)
		Me.txtOverrideTimeHours.MaxLength = 2
		Me.txtOverrideTimeHours.Name = "txtOverrideTimeHours"
		Me.txtOverrideTimeHours.Size = New System.Drawing.Size(26, 26)
		Me.txtOverrideTimeHours.TabIndex = 3
		Me.txtOverrideTimeHours.Text = "HH"
		Me.txtOverrideTimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblOverrideTime
		'
		Me.lblOverrideTime.AutoSize = True
		Me.lblOverrideTime.BackColor = System.Drawing.Color.Transparent
		Me.lblOverrideTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOverrideTime.ForeColor = System.Drawing.Color.Gainsboro
		Me.lblOverrideTime.Location = New System.Drawing.Point(0, 0)
		Me.lblOverrideTime.Name = "lblOverrideTime"
		Me.lblOverrideTime.Size = New System.Drawing.Size(86, 13)
		Me.lblOverrideTime.TabIndex = 0
		Me.lblOverrideTime.Text = "Override Time"
		Me.lblOverrideTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlCutoffTime
		'
		Me.pnlCutoffTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCutoffTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCutoffTime.Controls.Add(Me.btnSubmitCutoffTime)
		Me.pnlCutoffTime.Controls.Add(Me.Panel2)
		Me.pnlCutoffTime.Controls.Add(Me.txtCutoffTimeMinutes)
		Me.pnlCutoffTime.Controls.Add(Me.lblTimeColon2)
		Me.pnlCutoffTime.Controls.Add(Me.txtCutoffTimeHours)
		Me.pnlCutoffTime.Controls.Add(Me.lblCutoffTime)
		Me.pnlCutoffTime.Enabled = False
		Me.pnlCutoffTime.Location = New System.Drawing.Point(380, 164)
		Me.pnlCutoffTime.Name = "pnlCutoffTime"
		Me.pnlCutoffTime.Size = New System.Drawing.Size(140, 75)
		Me.pnlCutoffTime.TabIndex = 0
		'
		'btnSubmitCutoffTime
		'
		Me.btnSubmitCutoffTime.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSubmitCutoffTime.Enabled = False
		Me.btnSubmitCutoffTime.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.btnSubmitCutoffTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnSubmitCutoffTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnSubmitCutoffTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmitCutoffTime.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmitCutoffTime.ForeColor = System.Drawing.Color.White
		Me.btnSubmitCutoffTime.Location = New System.Drawing.Point(3, 48)
		Me.btnSubmitCutoffTime.Name = "btnSubmitCutoffTime"
		Me.btnSubmitCutoffTime.Size = New System.Drawing.Size(74, 20)
		Me.btnSubmitCutoffTime.TabIndex = 0
		Me.btnSubmitCutoffTime.TabStop = False
		Me.btnSubmitCutoffTime.Text = "Set"
		Me.btnSubmitCutoffTime.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Lavender
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.rbCutoffTimePM)
		Me.Panel2.Controls.Add(Me.rbCutoffTimeAM)
		Me.Panel2.Location = New System.Drawing.Point(83, 16)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(49, 39)
		Me.Panel2.TabIndex = 0
		'
		'rbCutoffTimePM
		'
		Me.rbCutoffTimePM.AutoSize = True
		Me.rbCutoffTimePM.Checked = True
		Me.rbCutoffTimePM.Location = New System.Drawing.Point(3, 19)
		Me.rbCutoffTimePM.Name = "rbCutoffTimePM"
		Me.rbCutoffTimePM.Size = New System.Drawing.Size(41, 17)
		Me.rbCutoffTimePM.TabIndex = 10
		Me.rbCutoffTimePM.TabStop = True
		Me.rbCutoffTimePM.Text = "PM"
		Me.rbCutoffTimePM.UseVisualStyleBackColor = True
		'
		'rbCutoffTimeAM
		'
		Me.rbCutoffTimeAM.AutoSize = True
		Me.rbCutoffTimeAM.Location = New System.Drawing.Point(3, 2)
		Me.rbCutoffTimeAM.Name = "rbCutoffTimeAM"
		Me.rbCutoffTimeAM.Size = New System.Drawing.Size(41, 17)
		Me.rbCutoffTimeAM.TabIndex = 9
		Me.rbCutoffTimeAM.TabStop = True
		Me.rbCutoffTimeAM.Text = "AM"
		Me.rbCutoffTimeAM.UseVisualStyleBackColor = True
		'
		'txtCutoffTimeMinutes
		'
		Me.txtCutoffTimeMinutes.BackColor = System.Drawing.Color.WhiteSmoke
		Me.txtCutoffTimeMinutes.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCutoffTimeMinutes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtCutoffTimeMinutes.Location = New System.Drawing.Point(51, 16)
		Me.txtCutoffTimeMinutes.MaxLength = 2
		Me.txtCutoffTimeMinutes.Name = "txtCutoffTimeMinutes"
		Me.txtCutoffTimeMinutes.Size = New System.Drawing.Size(26, 26)
		Me.txtCutoffTimeMinutes.TabIndex = 8
		Me.txtCutoffTimeMinutes.Text = "mm"
		'
		'lblTimeColon2
		'
		Me.lblTimeColon2.BackColor = System.Drawing.Color.Transparent
		Me.lblTimeColon2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTimeColon2.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblTimeColon2.Location = New System.Drawing.Point(35, 19)
		Me.lblTimeColon2.Name = "lblTimeColon2"
		Me.lblTimeColon2.Size = New System.Drawing.Size(10, 26)
		Me.lblTimeColon2.TabIndex = 0
		Me.lblTimeColon2.Text = ":"
		Me.lblTimeColon2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'txtCutoffTimeHours
		'
		Me.txtCutoffTimeHours.BackColor = System.Drawing.Color.WhiteSmoke
		Me.txtCutoffTimeHours.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCutoffTimeHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtCutoffTimeHours.Location = New System.Drawing.Point(3, 16)
		Me.txtCutoffTimeHours.MaxLength = 2
		Me.txtCutoffTimeHours.Name = "txtCutoffTimeHours"
		Me.txtCutoffTimeHours.Size = New System.Drawing.Size(26, 26)
		Me.txtCutoffTimeHours.TabIndex = 7
		Me.txtCutoffTimeHours.Text = "HH"
		Me.txtCutoffTimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblCutoffTime
		'
		Me.lblCutoffTime.AutoSize = True
		Me.lblCutoffTime.BackColor = System.Drawing.Color.Transparent
		Me.lblCutoffTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCutoffTime.ForeColor = System.Drawing.Color.Gainsboro
		Me.lblCutoffTime.Location = New System.Drawing.Point(0, 0)
		Me.lblCutoffTime.Name = "lblCutoffTime"
		Me.lblCutoffTime.Size = New System.Drawing.Size(72, 13)
		Me.lblCutoffTime.TabIndex = 0
		Me.lblCutoffTime.Text = "Cutoff Time"
		Me.lblCutoffTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlExplanations
		'
		Me.pnlExplanations.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlExplanations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlExplanations.Controls.Add(Me.lblSecDesc)
		Me.pnlExplanations.Controls.Add(Me.Label1)
		Me.pnlExplanations.Controls.Add(Me.lblOverrideExplanation)
		Me.pnlExplanations.Location = New System.Drawing.Point(234, 83)
		Me.pnlExplanations.Name = "pnlExplanations"
		Me.pnlExplanations.Size = New System.Drawing.Size(140, 156)
		Me.pnlExplanations.TabIndex = 1
		'
		'lblOverrideExplanation
		'
		Me.lblOverrideExplanation.BackColor = System.Drawing.Color.Transparent
		Me.lblOverrideExplanation.ForeColor = System.Drawing.Color.White
		Me.lblOverrideExplanation.Location = New System.Drawing.Point(0, 22)
		Me.lblOverrideExplanation.Name = "lblOverrideExplanation"
		Me.lblOverrideExplanation.Size = New System.Drawing.Size(133, 67)
		Me.lblOverrideExplanation.TabIndex = 0
		Me.lblOverrideExplanation.Text = "Override Time is the time at which all further promo attempts will require a supe" & _
	"rvisor/manager override."
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(0, 95)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 56)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Cutoff Time is the time at which all further promo attempts are cutoff and no one" & _
	" can override."
		'
		'lblBefore
		'
		Me.lblBefore.BackColor = System.Drawing.Color.Yellow
		Me.lblBefore.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBefore.ForeColor = System.Drawing.Color.Black
		Me.lblBefore.Location = New System.Drawing.Point(382, 32)
		Me.lblBefore.Name = "lblBefore"
		Me.lblBefore.Size = New System.Drawing.Size(132, 48)
		Me.lblBefore.TabIndex = 2
		Me.lblBefore.Text = "The Override Time must be before the Cutoff time."
		Me.lblBefore.Visible = False
		'
		'lblSecDesc
		'
		Me.lblSecDesc.AutoSize = True
		Me.lblSecDesc.BackColor = System.Drawing.Color.Transparent
		Me.lblSecDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSecDesc.ForeColor = System.Drawing.Color.White
		Me.lblSecDesc.Location = New System.Drawing.Point(0, 0)
		Me.lblSecDesc.Name = "lblSecDesc"
		Me.lblSecDesc.Size = New System.Drawing.Size(99, 16)
		Me.lblSecDesc.TabIndex = 2
		Me.lblSecDesc.Text = "Descriptions:"
		'
		'StepCanHazSecurity
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lblBefore)
		Me.Controls.Add(Me.pnlExplanations)
		Me.Controls.Add(Me.pnlCutoffTime)
		Me.Controls.Add(Me.pnlOverrideTime)
		Me.Controls.Add(Me.pnlSecurity)
		Me.Name = "StepCanHazSecurity"
		Me.NextStep = "StepD"
		Me.PreviousStep = "StepC"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Add security features here."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlSecurity, 0)
		Me.Controls.SetChildIndex(Me.pnlOverrideTime, 0)
		Me.Controls.SetChildIndex(Me.pnlCutoffTime, 0)
		Me.Controls.SetChildIndex(Me.pnlExplanations, 0)
		Me.Controls.SetChildIndex(Me.lblBefore, 0)
		Me.pnlSecurity.ResumeLayout(False)
		Me.pnlPapayaWhip.ResumeLayout(False)
		Me.pnlPapayaWhip.PerformLayout()
		Me.pnlOverrideTime.ResumeLayout(False)
		Me.pnlOverrideTime.PerformLayout()
		Me.pnlPaleTurquoise.ResumeLayout(False)
		Me.pnlPaleTurquoise.PerformLayout()
		Me.pnlCutoffTime.ResumeLayout(False)
		Me.pnlCutoffTime.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.pnlExplanations.ResumeLayout(False)
		Me.pnlExplanations.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents lblTimeColon1 As System.Windows.Forms.Label
	Private WithEvents lblTimeColon2 As System.Windows.Forms.Label
	Private WithEvents btnSubmitCutoffTime As System.Windows.Forms.Button
	Private WithEvents btnSubmitOverrideTime As System.Windows.Forms.Button
	Private WithEvents pnlSecurity As System.Windows.Forms.Panel
	Private WithEvents lblSecurity As System.Windows.Forms.Label
	Private WithEvents rbSecurityNO As System.Windows.Forms.RadioButton
	Private WithEvents rbSecurityYES As System.Windows.Forms.RadioButton
	Private WithEvents pnlOverrideTime As System.Windows.Forms.Panel
	Private WithEvents lblOverrideTime As System.Windows.Forms.Label
	Private WithEvents rbOverrideTimePM As System.Windows.Forms.RadioButton
	Private WithEvents rbOverrideTimeAM As System.Windows.Forms.RadioButton
	Private WithEvents txtOverrideTimeMinutes As System.Windows.Forms.TextBox
	Private WithEvents txtOverrideTimeHours As System.Windows.Forms.TextBox
	Private WithEvents pnlCutoffTime As System.Windows.Forms.Panel
	Private WithEvents rbCutoffTimePM As System.Windows.Forms.RadioButton
	Private WithEvents rbCutoffTimeAM As System.Windows.Forms.RadioButton
	Private WithEvents txtCutoffTimeMinutes As System.Windows.Forms.TextBox
	Private WithEvents txtCutoffTimeHours As System.Windows.Forms.TextBox
	Private WithEvents lblCutoffTime As System.Windows.Forms.Label
	Private WithEvents pnlPapayaWhip As System.Windows.Forms.Panel
	Private WithEvents pnlPaleTurquoise As System.Windows.Forms.Panel
	Private WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents pnlExplanations As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblOverrideExplanation As System.Windows.Forms.Label
	Friend WithEvents lblBefore As System.Windows.Forms.Label
	Friend WithEvents lblSecDesc As System.Windows.Forms.Label

End Class

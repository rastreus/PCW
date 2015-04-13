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
		Me.dtpOverrideTime = New System.Windows.Forms.DateTimePicker()
		Me.lblOverrideTime = New System.Windows.Forms.Label()
		Me.pnlCutoffTime = New System.Windows.Forms.Panel()
		Me.dtpCutoffTime = New System.Windows.Forms.DateTimePicker()
		Me.lblCutoffTime = New System.Windows.Forms.Label()
		Me.pnlSecurity.SuspendLayout()
		Me.pnlPapayaWhip.SuspendLayout()
		Me.pnlOverrideTime.SuspendLayout()
		Me.pnlCutoffTime.SuspendLayout()
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
		Me.pnlSecurity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlSecurity.Controls.Add(Me.pnlPapayaWhip)
		Me.pnlSecurity.Controls.Add(Me.lblSecurity)
		Me.pnlSecurity.Location = New System.Drawing.Point(123, 99)
		Me.pnlSecurity.Name = "pnlSecurity"
		Me.pnlSecurity.Size = New System.Drawing.Size(160, 99)
		Me.pnlSecurity.TabIndex = 1
		'
		'pnlPapayaWhip
		'
		Me.pnlPapayaWhip.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlPapayaWhip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPapayaWhip.CausesValidation = False
		Me.pnlPapayaWhip.Controls.Add(Me.rbSecurityNO)
		Me.pnlPapayaWhip.Controls.Add(Me.rbSecurityYES)
		Me.pnlPapayaWhip.Location = New System.Drawing.Point(11, 40)
		Me.pnlPapayaWhip.Name = "pnlPapayaWhip"
		Me.pnlPapayaWhip.Size = New System.Drawing.Size(135, 50)
		Me.pnlPapayaWhip.TabIndex = 1
		'
		'rbSecurityNO
		'
		Me.rbSecurityNO.AutoSize = True
		Me.rbSecurityNO.Checked = True
		Me.rbSecurityNO.Location = New System.Drawing.Point(40, 27)
		Me.rbSecurityNO.Name = "rbSecurityNO"
		Me.rbSecurityNO.Size = New System.Drawing.Size(39, 17)
		Me.rbSecurityNO.TabIndex = 1
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
		Me.rbSecurityYES.TabIndex = 0
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
		Me.lblSecurity.Size = New System.Drawing.Size(158, 52)
		Me.lblSecurity.TabIndex = 0
		Me.lblSecurity.Text = "Would you like to add security features?"
		'
		'pnlOverrideTime
		'
		Me.pnlOverrideTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlOverrideTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlOverrideTime.Controls.Add(Me.dtpOverrideTime)
		Me.pnlOverrideTime.Controls.Add(Me.lblOverrideTime)
		Me.pnlOverrideTime.Enabled = False
		Me.pnlOverrideTime.Location = New System.Drawing.Point(289, 99)
		Me.pnlOverrideTime.Name = "pnlOverrideTime"
		Me.pnlOverrideTime.Size = New System.Drawing.Size(164, 47)
		Me.pnlOverrideTime.TabIndex = 29
		'
		'dtpOverrideTime
		'
		Me.dtpOverrideTime.CustomFormat = "MM/dd/yyyy HH:mm:ss"
		Me.dtpOverrideTime.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpOverrideTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpOverrideTime.Location = New System.Drawing.Point(3, 16)
		Me.dtpOverrideTime.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
		Me.dtpOverrideTime.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
		Me.dtpOverrideTime.Name = "dtpOverrideTime"
		Me.dtpOverrideTime.ShowUpDown = True
		Me.dtpOverrideTime.Size = New System.Drawing.Size(148, 20)
		Me.dtpOverrideTime.TabIndex = 30
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
		Me.lblOverrideTime.TabIndex = 29
		Me.lblOverrideTime.Text = "Override Time"
		Me.lblOverrideTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlCutoffTime
		'
		Me.pnlCutoffTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCutoffTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCutoffTime.Controls.Add(Me.dtpCutoffTime)
		Me.pnlCutoffTime.Controls.Add(Me.lblCutoffTime)
		Me.pnlCutoffTime.Enabled = False
		Me.pnlCutoffTime.Location = New System.Drawing.Point(289, 151)
		Me.pnlCutoffTime.Name = "pnlCutoffTime"
		Me.pnlCutoffTime.Size = New System.Drawing.Size(164, 47)
		Me.pnlCutoffTime.TabIndex = 30
		'
		'dtpCutoffTime
		'
		Me.dtpCutoffTime.CustomFormat = "MM/dd/yyyy HH:mm:ss"
		Me.dtpCutoffTime.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpCutoffTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpCutoffTime.Location = New System.Drawing.Point(3, 16)
		Me.dtpCutoffTime.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
		Me.dtpCutoffTime.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
		Me.dtpCutoffTime.Name = "dtpCutoffTime"
		Me.dtpCutoffTime.ShowUpDown = True
		Me.dtpCutoffTime.Size = New System.Drawing.Size(148, 20)
		Me.dtpCutoffTime.TabIndex = 30
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
		Me.lblCutoffTime.TabIndex = 29
		Me.lblCutoffTime.Text = "Cutoff Time"
		Me.lblCutoffTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'StepCanHazSecurity
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.pnlSecurity.ResumeLayout(False)
		Me.pnlPapayaWhip.ResumeLayout(False)
		Me.pnlPapayaWhip.PerformLayout()
		Me.pnlOverrideTime.ResumeLayout(False)
		Me.pnlOverrideTime.PerformLayout()
		Me.pnlCutoffTime.ResumeLayout(False)
		Me.pnlCutoffTime.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlSecurity As System.Windows.Forms.Panel
	Friend WithEvents lblSecurity As System.Windows.Forms.Label
	Friend WithEvents pnlPapayaWhip As System.Windows.Forms.Panel
	Friend WithEvents rbSecurityNO As System.Windows.Forms.RadioButton
	Friend WithEvents rbSecurityYES As System.Windows.Forms.RadioButton
	Friend WithEvents pnlOverrideTime As System.Windows.Forms.Panel
	Friend WithEvents dtpOverrideTime As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblOverrideTime As System.Windows.Forms.Label
	Friend WithEvents pnlCutoffTime As System.Windows.Forms.Panel
	Friend WithEvents dtpCutoffTime As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblCutoffTime As System.Windows.Forms.Label

End Class

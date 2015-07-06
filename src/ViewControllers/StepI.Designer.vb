<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepI
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblpromoSummary = New System.Windows.Forms.Label()
		Me.cbCreatePromo = New System.Windows.Forms.CheckBox()
		Me.pnlCreatePromo = New System.Windows.Forms.Panel()
		Me.lblEntryPromo = New System.Windows.Forms.Label()
		Me.lblPromoSummary2 = New System.Windows.Forms.Label()
		Me.lblPayoutPromo = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.pnlCreatePromo.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Text = "Please be responsible when creating promotionals."
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.lblPayoutPromo)
		Me.Panel1.Controls.Add(Me.lblPromoSummary2)
		Me.Panel1.Controls.Add(Me.lblEntryPromo)
		Me.Panel1.Controls.Add(Me.pnlCreatePromo)
		Me.Panel1.Controls.Add(Me.lblpromoSummary)
		Me.Panel1.Location = New System.Drawing.Point(-8, -10)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(609, 312)
		Me.Panel1.TabIndex = 1
		'
		'lblpromoSummary
		'
		Me.lblpromoSummary.BackColor = System.Drawing.Color.Black
		Me.lblpromoSummary.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblpromoSummary.ForeColor = System.Drawing.Color.Cyan
		Me.lblpromoSummary.Location = New System.Drawing.Point(103, 11)
		Me.lblpromoSummary.Name = "lblpromoSummary"
		Me.lblpromoSummary.Size = New System.Drawing.Size(192, 262)
		Me.lblpromoSummary.TabIndex = 0
		'
		'cbCreatePromo
		'
		Me.cbCreatePromo.BackColor = System.Drawing.Color.White
		Me.cbCreatePromo.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCreatePromo.ForeColor = System.Drawing.Color.Black
		Me.cbCreatePromo.Location = New System.Drawing.Point(76, -1)
		Me.cbCreatePromo.Name = "cbCreatePromo"
		Me.cbCreatePromo.Size = New System.Drawing.Size(226, 20)
		Me.cbCreatePromo.TabIndex = 3
		Me.cbCreatePromo.Text = "Create the above Promo"
		Me.cbCreatePromo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.cbCreatePromo.UseVisualStyleBackColor = False
		'
		'pnlCreatePromo
		'
		Me.pnlCreatePromo.BackColor = System.Drawing.Color.White
		Me.pnlCreatePromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCreatePromo.Controls.Add(Me.cbCreatePromo)
		Me.pnlCreatePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlCreatePromo.ForeColor = System.Drawing.Color.White
		Me.pnlCreatePromo.Location = New System.Drawing.Point(103, 276)
		Me.pnlCreatePromo.Name = "pnlCreatePromo"
		Me.pnlCreatePromo.Size = New System.Drawing.Size(388, 21)
		Me.pnlCreatePromo.TabIndex = 4
		'
		'lblEntryPromo
		'
		Me.lblEntryPromo.BackColor = System.Drawing.Color.Black
		Me.lblEntryPromo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEntryPromo.ForeColor = System.Drawing.Color.DarkOrange
		Me.lblEntryPromo.Location = New System.Drawing.Point(103, 11)
		Me.lblEntryPromo.Name = "lblEntryPromo"
		Me.lblEntryPromo.Size = New System.Drawing.Size(55, 26)
		Me.lblEntryPromo.TabIndex = 5
		Me.lblEntryPromo.Text = "Entry | Promo |"
		'
		'lblPromoSummary2
		'
		Me.lblPromoSummary2.BackColor = System.Drawing.Color.Black
		Me.lblPromoSummary2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoSummary2.ForeColor = System.Drawing.Color.Cyan
		Me.lblPromoSummary2.Location = New System.Drawing.Point(298, 11)
		Me.lblPromoSummary2.Name = "lblPromoSummary2"
		Me.lblPromoSummary2.Size = New System.Drawing.Size(192, 262)
		Me.lblPromoSummary2.TabIndex = 6
		'
		'lblPayoutPromo
		'
		Me.lblPayoutPromo.BackColor = System.Drawing.Color.Black
		Me.lblPayoutPromo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayoutPromo.ForeColor = System.Drawing.Color.DarkOrange
		Me.lblPayoutPromo.Location = New System.Drawing.Point(301, 11)
		Me.lblPayoutPromo.Name = "lblPayoutPromo"
		Me.lblPayoutPromo.Size = New System.Drawing.Size(55, 26)
		Me.lblPayoutPromo.TabIndex = 7
		Me.lblPayoutPromo.Text = "****** | ****** |"
		'
		'StepI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepI"
		Me.NextStep = "StepJ"
		Me.PreviousStep = "StepH"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Please be responsible when creating promotionals."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Panel1.ResumeLayout(False)
		Me.pnlCreatePromo.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents cbCreatePromo As System.Windows.Forms.CheckBox
	Friend WithEvents pnlCreatePromo As System.Windows.Forms.Panel
	Friend WithEvents lblpromoSummary As System.Windows.Forms.Label
	Friend WithEvents lblEntryPromo As System.Windows.Forms.Label
	Friend WithEvents lblPayoutPromo As System.Windows.Forms.Label
	Friend WithEvents lblPromoSummary2 As System.Windows.Forms.Label

End Class

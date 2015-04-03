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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbCreatePromo = New System.Windows.Forms.CheckBox()
		Me.pnlCreatePromo = New System.Windows.Forms.Panel()
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
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(3, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(568, 265)
		Me.Panel1.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label1.Location = New System.Drawing.Point(3, 2)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(558, 262)
		Me.Label1.TabIndex = 0
		'
		'cbCreatePromo
		'
		Me.cbCreatePromo.AutoSize = True
		Me.cbCreatePromo.Location = New System.Drawing.Point(3, -1)
		Me.cbCreatePromo.Name = "cbCreatePromo"
		Me.cbCreatePromo.Size = New System.Drawing.Size(199, 20)
		Me.cbCreatePromo.TabIndex = 3
		Me.cbCreatePromo.Text = "Create the above Promo."
		Me.cbCreatePromo.UseVisualStyleBackColor = True
		'
		'pnlCreatePromo
		'
		Me.pnlCreatePromo.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCreatePromo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCreatePromo.Controls.Add(Me.cbCreatePromo)
		Me.pnlCreatePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlCreatePromo.ForeColor = System.Drawing.Color.White
		Me.pnlCreatePromo.Location = New System.Drawing.Point(369, 269)
		Me.pnlCreatePromo.Name = "pnlCreatePromo"
		Me.pnlCreatePromo.Size = New System.Drawing.Size(202, 21)
		Me.pnlCreatePromo.TabIndex = 4
		'
		'StepI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlCreatePromo)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepI"
		Me.NextStep = "StepJ"
		Me.PreviousStep = "StepH"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Please be responsible when creating promotionals."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.pnlCreatePromo, 0)
		Me.Panel1.ResumeLayout(False)
		Me.pnlCreatePromo.ResumeLayout(False)
		Me.pnlCreatePromo.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents cbCreatePromo As System.Windows.Forms.CheckBox
	Friend WithEvents pnlCreatePromo As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

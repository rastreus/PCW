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
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
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
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(3, -1)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(199, 20)
		Me.CheckBox1.TabIndex = 3
		Me.CheckBox1.Text = "Create the above Promo."
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.CheckBox1)
		Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel2.ForeColor = System.Drawing.Color.White
		Me.Panel2.Location = New System.Drawing.Point(369, 269)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(202, 21)
		Me.Panel2.TabIndex = 4
		'
		'StepI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepI"
		Me.NextStep = "StepJ"
		Me.PreviousStep = "StepH"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Please be responsible when creating promotionals."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

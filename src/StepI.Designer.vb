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
		Me.IconButton1 = New FontAwesomeIcons.IconButton()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'IconButton1
		'
		Me.IconButton1.ActiveColor = System.Drawing.Color.CornflowerBlue
		Me.IconButton1.BackColor = System.Drawing.Color.Transparent
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.InfoCircle
		Me.IconButton1.InActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconButton1.Location = New System.Drawing.Point(3, 269)
		Me.IconButton1.Name = "IconButton1"
		Me.IconButton1.Size = New System.Drawing.Size(24, 24)
		Me.IconButton1.TabIndex = 2
		Me.IconButton1.TabStop = False
		Me.IconButton1.ToolTipText = Nothing
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(5, 2)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(503, 17)
		Me.CheckBox1.TabIndex = 3
		Me.CheckBox1.Text = "I understand the above statements and confirm that this is indeed the promotional" & _
	" that I want created."
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.CheckBox1)
		Me.Panel2.Location = New System.Drawing.Point(64, 269)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(507, 21)
		Me.Panel2.TabIndex = 4
		'
		'StepI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.IconButton1)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepI"
		Me.NextStep = "StepJ"
		Me.PreviousStep = "StepH"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Please be responsible when creating promotionals."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.IconButton1, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Panel1.ResumeLayout(False)
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

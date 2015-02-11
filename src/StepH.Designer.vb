<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepH
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
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.IconButton1 = New FontAwesomeIcons.IconButton()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.IconButton2 = New FontAwesomeIcons.IconButton()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.IconButton2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "This comment will be inserted into the database row."
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.RadioButton2)
		Me.Panel1.Controls.Add(Me.RadioButton1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(121, 29)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(341, 104)
		Me.Panel1.TabIndex = 1
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Checked = True
		Me.RadioButton2.Location = New System.Drawing.Point(4, 72)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(260, 17)
		Me.RadioButton2.TabIndex = 2
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "No, I would not like to add a comment at this time."
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(4, 49)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(314, 17)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.Text = "Yes, I would like to insert a helpful comment about the promo."
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(1, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(339, 41)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Would you like to insert a short description of the promo? It would be greatly ap" & _
	"preciated."
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.IconButton1)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Controls.Add(Me.RichTextBox1)
		Me.Panel2.Location = New System.Drawing.Point(121, 139)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(341, 103)
		Me.Panel2.TabIndex = 2
		'
		'IconButton1
		'
		Me.IconButton1.ActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconButton1.BackColor = System.Drawing.Color.Transparent
		Me.IconButton1.Enabled = False
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.Tick
		Me.IconButton1.InActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconButton1.Location = New System.Drawing.Point(226, 70)
		Me.IconButton1.Name = "IconButton1"
		Me.IconButton1.Size = New System.Drawing.Size(24, 24)
		Me.IconButton1.TabIndex = 3
		Me.IconButton1.TabStop = False
		Me.IconButton1.ToolTipText = Nothing
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Controls.Add(Me.Label2)
		Me.Panel3.Location = New System.Drawing.Point(245, 70)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(73, 24)
		Me.Panel3.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(6, 5)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(25, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "140"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(31, 5)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(36, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "/  140"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Enabled = False
		Me.RichTextBox1.Location = New System.Drawing.Point(4, 4)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
		Me.RichTextBox1.Size = New System.Drawing.Size(332, 60)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = "Insert Comment of 140 characters or less into this TextBox."
		'
		'IconButton2
		'
		Me.IconButton2.ActiveColor = System.Drawing.Color.CornflowerBlue
		Me.IconButton2.BackColor = System.Drawing.Color.Transparent
		Me.IconButton2.IconType = FontAwesomeIcons.IconType.InfoCircle
		Me.IconButton2.InActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconButton2.Location = New System.Drawing.Point(3, 269)
		Me.IconButton2.Name = "IconButton2"
		Me.IconButton2.Size = New System.Drawing.Size(24, 24)
		Me.IconButton2.TabIndex = 3
		Me.IconButton2.TabStop = False
		Me.IconButton2.ToolTipText = Nothing
		'
		'StepH
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.IconButton2)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepH"
		Me.NextStep = "StepI"
		Me.PreviousStep = "StepG1"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This comment will be inserted into the database row."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Controls.SetChildIndex(Me.IconButton2, 0)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.IconButton2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
	Friend WithEvents IconButton2 As FontAwesomeIcons.IconButton

End Class

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
		Me.pnlInsertComment = New System.Windows.Forms.Panel()
		Me.rbNO = New System.Windows.Forms.RadioButton()
		Me.rbYES = New System.Windows.Forms.RadioButton()
		Me.lblInsertComment = New System.Windows.Forms.Label()
		Me.pnlPaleTurquoise = New System.Windows.Forms.Panel()
		Me.pnlCommentBox = New System.Windows.Forms.Panel()
		Me.IconTick = New FontAwesomeIcons.IconButton()
		Me.pnl140Characters = New System.Windows.Forms.Panel()
		Me.lblNumerator = New System.Windows.Forms.Label()
		Me.lblDenominator = New System.Windows.Forms.Label()
		Me.txtCommentBox = New System.Windows.Forms.RichTextBox()
		Me.pnlInsertComment.SuspendLayout()
		Me.pnlCommentBox.SuspendLayout()
		CType(Me.IconTick, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnl140Characters.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "This comment will be inserted into the database row."
		'
		'pnlInsertComment
		'
		Me.pnlInsertComment.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlInsertComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlInsertComment.Controls.Add(Me.rbNO)
		Me.pnlInsertComment.Controls.Add(Me.rbYES)
		Me.pnlInsertComment.Controls.Add(Me.lblInsertComment)
		Me.pnlInsertComment.Controls.Add(Me.pnlPaleTurquoise)
		Me.pnlInsertComment.Location = New System.Drawing.Point(103, 88)
		Me.pnlInsertComment.Name = "pnlInsertComment"
		Me.pnlInsertComment.Size = New System.Drawing.Size(139, 102)
		Me.pnlInsertComment.TabIndex = 1
		'
		'rbNO
		'
		Me.rbNO.AutoSize = True
		Me.rbNO.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbNO.Checked = True
		Me.rbNO.Location = New System.Drawing.Point(46, 70)
		Me.rbNO.Name = "rbNO"
		Me.rbNO.Size = New System.Drawing.Size(39, 17)
		Me.rbNO.TabIndex = 2
		Me.rbNO.TabStop = True
		Me.rbNO.Text = "No"
		Me.rbNO.UseVisualStyleBackColor = False
		'
		'rbYES
		'
		Me.rbYES.AutoSize = True
		Me.rbYES.BackColor = System.Drawing.Color.PaleTurquoise
		Me.rbYES.Location = New System.Drawing.Point(46, 47)
		Me.rbYES.Name = "rbYES"
		Me.rbYES.Size = New System.Drawing.Size(43, 17)
		Me.rbYES.TabIndex = 1
		Me.rbYES.Text = "Yes"
		Me.rbYES.UseVisualStyleBackColor = False
		'
		'lblInsertComment
		'
		Me.lblInsertComment.BackColor = System.Drawing.Color.Transparent
		Me.lblInsertComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInsertComment.ForeColor = System.Drawing.Color.White
		Me.lblInsertComment.Location = New System.Drawing.Point(0, 0)
		Me.lblInsertComment.Name = "lblInsertComment"
		Me.lblInsertComment.Size = New System.Drawing.Size(138, 36)
		Me.lblInsertComment.TabIndex = 0
		Me.lblInsertComment.Text = "Would you like to insert a comment?"
		'
		'pnlPaleTurquoise
		'
		Me.pnlPaleTurquoise.BackColor = System.Drawing.Color.PaleTurquoise
		Me.pnlPaleTurquoise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPaleTurquoise.Location = New System.Drawing.Point(17, 39)
		Me.pnlPaleTurquoise.Name = "pnlPaleTurquoise"
		Me.pnlPaleTurquoise.Size = New System.Drawing.Size(104, 54)
		Me.pnlPaleTurquoise.TabIndex = 3
		'
		'pnlCommentBox
		'
		Me.pnlCommentBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCommentBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCommentBox.Controls.Add(Me.IconTick)
		Me.pnlCommentBox.Controls.Add(Me.pnl140Characters)
		Me.pnlCommentBox.Controls.Add(Me.txtCommentBox)
		Me.pnlCommentBox.Location = New System.Drawing.Point(248, 88)
		Me.pnlCommentBox.Name = "pnlCommentBox"
		Me.pnlCommentBox.Size = New System.Drawing.Size(250, 102)
		Me.pnlCommentBox.TabIndex = 2
		'
		'IconTick
		'
		Me.IconTick.ActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconTick.BackColor = System.Drawing.Color.Transparent
		Me.IconTick.Enabled = False
		Me.IconTick.IconType = FontAwesomeIcons.IconType.Tick
		Me.IconTick.InActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconTick.Location = New System.Drawing.Point(126, 70)
		Me.IconTick.Name = "IconTick"
		Me.IconTick.Size = New System.Drawing.Size(24, 24)
		Me.IconTick.TabIndex = 3
		Me.IconTick.TabStop = False
		Me.IconTick.ToolTipText = Nothing
		'
		'pnl140Characters
		'
		Me.pnl140Characters.Controls.Add(Me.lblNumerator)
		Me.pnl140Characters.Controls.Add(Me.lblDenominator)
		Me.pnl140Characters.Location = New System.Drawing.Point(145, 70)
		Me.pnl140Characters.Name = "pnl140Characters"
		Me.pnl140Characters.Size = New System.Drawing.Size(73, 24)
		Me.pnl140Characters.TabIndex = 3
		'
		'lblNumerator
		'
		Me.lblNumerator.AutoSize = True
		Me.lblNumerator.ForeColor = System.Drawing.Color.White
		Me.lblNumerator.Location = New System.Drawing.Point(6, 5)
		Me.lblNumerator.Name = "lblNumerator"
		Me.lblNumerator.Size = New System.Drawing.Size(25, 13)
		Me.lblNumerator.TabIndex = 2
		Me.lblNumerator.Text = "140"
		Me.lblNumerator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblDenominator
		'
		Me.lblDenominator.AutoSize = True
		Me.lblDenominator.ForeColor = System.Drawing.Color.White
		Me.lblDenominator.Location = New System.Drawing.Point(31, 5)
		Me.lblDenominator.Name = "lblDenominator"
		Me.lblDenominator.Size = New System.Drawing.Size(36, 13)
		Me.lblDenominator.TabIndex = 1
		Me.lblDenominator.Text = "/  140"
		Me.lblDenominator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtCommentBox
		'
		Me.txtCommentBox.Enabled = False
		Me.txtCommentBox.Location = New System.Drawing.Point(3, 4)
		Me.txtCommentBox.MaxLength = 300
		Me.txtCommentBox.Name = "txtCommentBox"
		Me.txtCommentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
		Me.txtCommentBox.Size = New System.Drawing.Size(242, 60)
		Me.txtCommentBox.TabIndex = 0
		Me.txtCommentBox.Text = "Insert Comment of 140 characters or less into this TextBox."
		'
		'StepH
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlCommentBox)
		Me.Controls.Add(Me.pnlInsertComment)
		Me.Name = "StepH"
		Me.NextStep = "StepI"
		Me.PreviousStep = "StepGeneratePayoutCoupon"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This comment will be inserted into the database row."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlInsertComment, 0)
		Me.Controls.SetChildIndex(Me.pnlCommentBox, 0)
		Me.pnlInsertComment.ResumeLayout(False)
		Me.pnlInsertComment.PerformLayout()
		Me.pnlCommentBox.ResumeLayout(False)
		CType(Me.IconTick, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnl140Characters.ResumeLayout(False)
		Me.pnl140Characters.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlInsertComment As System.Windows.Forms.Panel
	Friend WithEvents rbNO As System.Windows.Forms.RadioButton
	Friend WithEvents rbYES As System.Windows.Forms.RadioButton
	Friend WithEvents lblInsertComment As System.Windows.Forms.Label
	Friend WithEvents pnlCommentBox As System.Windows.Forms.Panel
	Friend WithEvents txtCommentBox As System.Windows.Forms.RichTextBox
	Friend WithEvents lblNumerator As System.Windows.Forms.Label
	Friend WithEvents lblDenominator As System.Windows.Forms.Label
	Friend WithEvents pnl140Characters As System.Windows.Forms.Panel
	Friend WithEvents IconTick As FontAwesomeIcons.IconButton
	Friend WithEvents pnlPaleTurquoise As System.Windows.Forms.Panel

End Class

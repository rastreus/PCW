﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepX
	Inherits TSWizards.BaseExteriorStep

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
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.IconButton1 = New FontAwesomeIcons.IconButton()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Description.Location = New System.Drawing.Point(1, 21)
		Me.Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Description.Size = New System.Drawing.Size(416, 40)
		Me.Description.Text = "Thanks for using the PCW!"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(27, 90)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(92, 13)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Have a great day!"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(5, 262)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(0, 13)
		Me.Label6.TabIndex = 6
		'
		'IconButton1
		'
		Me.IconButton1.ActiveColor = System.Drawing.Color.CornflowerBlue
		Me.IconButton1.BackColor = System.Drawing.Color.Transparent
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.InfoCircle
		Me.IconButton1.InActiveColor = System.Drawing.SystemColors.ControlDark
		Me.IconButton1.Location = New System.Drawing.Point(3, 337)
		Me.IconButton1.Name = "IconButton1"
		Me.IconButton1.Size = New System.Drawing.Size(24, 24)
		Me.IconButton1.TabIndex = 7
		Me.IconButton1.TabStop = False
		Me.IconButton1.ToolTipText = Nothing
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckBox1.ForeColor = System.Drawing.Color.White
		Me.CheckBox1.Location = New System.Drawing.Point(5, 5)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(193, 20)
		Me.CheckBox1.TabIndex = 8
		Me.CheckBox1.Text = "Check to run PCW again"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.CheckBox1)
		Me.Panel1.Location = New System.Drawing.Point(103, 268)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(204, 35)
		Me.Panel1.TabIndex = 9
		'
		'StepX
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.IconButton1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.IsFinished = True
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "StepX"
		Me.NextStep = "FINISHED"
		Me.PreviousStep = "StepJ"
		Me.Size = New System.Drawing.Size(424, 370)
		Me.StepDescription = "Thanks for using the PCW!"
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Label5, 0)
		Me.Controls.SetChildIndex(Me.Label6, 0)
		Me.Controls.SetChildIndex(Me.IconButton1, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
	Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

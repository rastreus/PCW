<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepF
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
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "This is where the reward of the promotional will be determined."
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.RadioButton5)
		Me.Panel1.Controls.Add(Me.RadioButton4)
		Me.Panel1.Controls.Add(Me.RadioButton3)
		Me.Panel1.Controls.Add(Me.RadioButton2)
		Me.Panel1.Controls.Add(Me.RadioButton1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(151, 56)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(302, 202)
		Me.Panel1.TabIndex = 2
		'
		'Panel3
		'
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.TextBox3)
		Me.Panel3.Location = New System.Drawing.Point(139, 121)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(131, 36)
		Me.Panel3.TabIndex = 9
		'
		'TextBox3
		'
		Me.TextBox3.Enabled = False
		Me.TextBox3.Location = New System.Drawing.Point(2, 8)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(122, 20)
		Me.TextBox3.TabIndex = 7
		Me.TextBox3.Text = "Enter Cash Value Here"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(94, 133)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "...........|"
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.TextBox2)
		Me.Panel2.Location = New System.Drawing.Point(139, 163)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(131, 36)
		Me.Panel2.TabIndex = 8
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Location = New System.Drawing.Point(2, 8)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(122, 20)
		Me.TextBox2.TabIndex = 7
		Me.TextBox2.Text = "Enter Prize Here"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(62, 173)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "......................|"
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(19, 63)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(106, 17)
		Me.RadioButton5.TabIndex = 5
		Me.RadioButton5.Text = "FreePlay Coupon"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(19, 95)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(91, 17)
		Me.RadioButton4.TabIndex = 4
		Me.RadioButton4.Text = "Random Prize"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(19, 172)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(48, 17)
		Me.RadioButton3.TabIndex = 3
		Me.RadioButton3.Text = "Prize"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(19, 132)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
		Me.RadioButton2.TabIndex = 2
		Me.RadioButton2.Text = "Cash Value"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(19, 31)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "# of Tickets"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(300, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "What form of Payout does the promo give?"
		'
		'StepF
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepF"
		Me.NextStep = "StepG1"
		Me.PreviousStep = "StepE"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "This is where the reward of the promotional will be determined."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepD
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
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.RadioButton7 = New System.Windows.Forms.RadioButton()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.RadioButton6 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Of the four available types, which will this promo be?"
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.RadioButton7)
		Me.Panel2.Controls.Add(Me.TextBox2)
		Me.Panel2.Controls.Add(Me.RadioButton6)
		Me.Panel2.Controls.Add(Me.RadioButton3)
		Me.Panel2.Controls.Add(Me.RadioButton2)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(41, 56)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(514, 177)
		Me.Panel2.TabIndex = 3
		'
		'RadioButton7
		'
		Me.RadioButton7.AutoSize = True
		Me.RadioButton7.Location = New System.Drawing.Point(3, 97)
		Me.RadioButton7.Name = "RadioButton7"
		Me.RadioButton7.Size = New System.Drawing.Size(143, 17)
		Me.RadioButton7.TabIndex = 10
		Me.RadioButton7.TabStop = True
		Me.RadioButton7.Text = "Mult-Part Single Instance"
		Me.RadioButton7.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Location = New System.Drawing.Point(181, 127)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(115, 20)
		Me.TextBox2.TabIndex = 9
		Me.TextBox2.Text = "How many days/tiers?"
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Location = New System.Drawing.Point(3, 127)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(171, 17)
		Me.RadioButton6.TabIndex = 8
		Me.RadioButton6.TabStop = True
		Me.RadioButton6.Text = "Multi-Part Sequential Instances"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(3, 66)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(76, 17)
		Me.RadioButton3.TabIndex = 6
		Me.RadioButton3.Text = "Acquisition"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Checked = True
		Me.RadioButton2.Location = New System.Drawing.Point(3, 36)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
		Me.RadioButton2.TabIndex = 5
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "General"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(247, 16)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "What is the type of the new promo?"
		'
		'StepD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel2)
		Me.Name = "StepD"
		Me.NextStep = "StepE"
		Me.PreviousStep = "StepC"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Of the four available types, which will this promo be?"
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

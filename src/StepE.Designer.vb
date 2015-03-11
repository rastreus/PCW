<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepE
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
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.RadioButton17 = New System.Windows.Forms.RadioButton()
		Me.RadioButton16 = New System.Windows.Forms.RadioButton()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel6.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Let's think through the Limits now."
		'
		'Panel6
		'
		Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel6.Controls.Add(Me.TextBox8)
		Me.Panel6.Controls.Add(Me.RadioButton17)
		Me.Panel6.Controls.Add(Me.RadioButton16)
		Me.Panel6.Controls.Add(Me.Label7)
		Me.Panel6.Location = New System.Drawing.Point(149, 34)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(240, 80)
		Me.Panel6.TabIndex = 7
		'
		'TextBox8
		'
		Me.TextBox8.Enabled = False
		Me.TextBox8.Location = New System.Drawing.Point(53, 40)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.Size = New System.Drawing.Size(143, 20)
		Me.TextBox8.TabIndex = 10
		Me.TextBox8.Text = "Enter Point Cutoff limit here"
		'
		'RadioButton17
		'
		Me.RadioButton17.AutoSize = True
		Me.RadioButton17.Checked = True
		Me.RadioButton17.Location = New System.Drawing.Point(4, 61)
		Me.RadioButton17.Name = "RadioButton17"
		Me.RadioButton17.Size = New System.Drawing.Size(39, 17)
		Me.RadioButton17.TabIndex = 9
		Me.RadioButton17.TabStop = True
		Me.RadioButton17.Text = "No"
		Me.RadioButton17.UseVisualStyleBackColor = True
		'
		'RadioButton16
		'
		Me.RadioButton16.AutoSize = True
		Me.RadioButton16.Location = New System.Drawing.Point(4, 41)
		Me.RadioButton16.Name = "RadioButton16"
		Me.RadioButton16.Size = New System.Drawing.Size(43, 17)
		Me.RadioButton16.TabIndex = 8
		Me.RadioButton16.Text = "Yes"
		Me.RadioButton16.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(235, 37)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "Is there a Point Cutoff limit in order to qualify for the promo?"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(30, 166)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(516, 16)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "The below information is not needed (and not enabled) if there is not a Point Cut" & _
	"off limit."
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 1)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(260, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "How are the points totaled to qualify for the promo?"
		'
		'ComboBox1
		'
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Enabled = False
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Give reward regardless of points", "Sums lifetime points", "Sums points between start and end dates", "Uses EligiblePlayers table to determine points"})
		Me.ComboBox1.Location = New System.Drawing.Point(3, 36)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.ComboBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(26, 193)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(268, 80)
		Me.Panel1.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 1)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(260, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "What is the relation of the Points Total to the Points Cutoff?"
		'
		'ComboBox2
		'
		Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox2.Enabled = False
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Items.AddRange(New Object() {"PT > (greater than) PC", "PT >= (greater than or equal to) PC"})
		Me.ComboBox2.Location = New System.Drawing.Point(3, 36)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(257, 21)
		Me.ComboBox2.TabIndex = 1
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.ComboBox2)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(300, 193)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(268, 80)
		Me.Panel2.TabIndex = 9
		'
		'StepE
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel6)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "StepE"
		Me.NextStep = "StepF"
		Me.PreviousStep = "StepD"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Let's think through the Limits now."
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.Panel6, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
	Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class

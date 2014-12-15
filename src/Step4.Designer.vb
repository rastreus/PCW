<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step4
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
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.IconButton1 = New FontAwesomeIcons.IconButton()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel6.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Location = New System.Drawing.Point(4, 4)
		Me.Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Description.Size = New System.Drawing.Size(586, 37)
		Me.Description.Text = "Set the dates and exceptions for a new recurring promotional."
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Panel6)
		Me.Panel1.Controls.Add(Me.CheckedListBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(191, 16)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(174, 255)
		Me.Panel1.TabIndex = 1
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Control
		Me.CheckedListBox1.CheckOnClick = True
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.CheckedListBox1.Location = New System.Drawing.Point(5, 43)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(159, 109)
		Me.CheckedListBox1.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(5, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(159, 36)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "On which day(s) will the promo occur?"
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Controls.Add(Me.Panel5)
		Me.Panel2.Controls.Add(Me.CheckedListBox2)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(371, 16)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(174, 255)
		Me.Panel2.TabIndex = 2
		'
		'Panel5
		'
		Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel5.Controls.Add(Me.RadioButton2)
		Me.Panel5.Controls.Add(Me.Label5)
		Me.Panel5.Controls.Add(Me.RadioButton1)
		Me.Panel5.Location = New System.Drawing.Point(7, 160)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(157, 81)
		Me.Panel5.TabIndex = 5
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Checked = True
		Me.RadioButton2.Location = New System.Drawing.Point(3, 53)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
		Me.RadioButton2.TabIndex = 4
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "No"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(0, 1)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(152, 31)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Can points be earned on the day of the promo?"
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(3, 35)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(43, 17)
		Me.RadioButton1.TabIndex = 3
		Me.RadioButton1.Text = "Yes"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'CheckedListBox2
		'
		Me.CheckedListBox2.BackColor = System.Drawing.SystemColors.Control
		Me.CheckedListBox2.CheckOnClick = True
		Me.CheckedListBox2.FormattingEnabled = True
		Me.CheckedListBox2.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.CheckedListBox2.Location = New System.Drawing.Point(5, 43)
		Me.CheckedListBox2.Name = "CheckedListBox2"
		Me.CheckedListBox2.Size = New System.Drawing.Size(159, 109)
		Me.CheckedListBox2.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(5, 4)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(159, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "On which day(s) will points be earned?"
		'
		'Panel3
		'
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.DateTimePicker1)
		Me.Panel3.Controls.Add(Me.Label3)
		Me.Panel3.Location = New System.Drawing.Point(41, 16)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(144, 81)
		Me.Panel3.TabIndex = 3
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(2, 43)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
		Me.DateTimePicker1.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(-1, 5)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(140, 35)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "When is the promo start date?"
		'
		'Panel4
		'
		Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel4.Controls.Add(Me.DateTimePicker2)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Location = New System.Drawing.Point(41, 103)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(144, 81)
		Me.Panel4.TabIndex = 4
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker2.Location = New System.Drawing.Point(3, 45)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
		Me.DateTimePicker2.TabIndex = 1
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(2, 5)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(137, 33)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "When is the promo end date?"
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
		Me.IconButton1.TabIndex = 7
		Me.IconButton1.TabStop = False
		Me.IconButton1.ToolTipText = Nothing
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
		Me.ComboBox1.Location = New System.Drawing.Point(3, 48)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
		Me.ComboBox1.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(3, 1)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(154, 31)
		Me.Label6.TabIndex = 3
		Me.Label6.Text = "Of the selected day(s), which is the primary day?"
		'
		'Panel6
		'
		Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel6.Controls.Add(Me.Label6)
		Me.Panel6.Controls.Add(Me.ComboBox1)
		Me.Panel6.Location = New System.Drawing.Point(4, 160)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(162, 81)
		Me.Panel6.TabIndex = 8
		'
		'Panel7
		'
		Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel7.Controls.Add(Me.DateTimePicker3)
		Me.Panel7.Controls.Add(Me.Label7)
		Me.Panel7.Location = New System.Drawing.Point(41, 190)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(144, 81)
		Me.Panel7.TabIndex = 8
		Me.Panel7.Visible = False
		'
		'DateTimePicker3
		'
		Me.DateTimePicker3.Enabled = False
		Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker3.Location = New System.Drawing.Point(3, 45)
		Me.DateTimePicker3.Name = "DateTimePicker3"
		Me.DateTimePicker3.Size = New System.Drawing.Size(95, 20)
		Me.DateTimePicker3.TabIndex = 1
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(2, 5)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(137, 33)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "When is the promo occurance date?"
		Me.Label7.Visible = False
		'
		'Step4
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.IconButton1)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Step4"
		Me.NextStep = "StepD"
		Me.PreviousStep = "StepB"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Set the dates and exceptions for a new recurring promotional."
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.Panel2, 0)
		Me.Controls.SetChildIndex(Me.Panel3, 0)
		Me.Controls.SetChildIndex(Me.Panel4, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.IconButton1, 0)
		Me.Controls.SetChildIndex(Me.Panel7, 0)
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel6.ResumeLayout(False)
		Me.Panel7.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
	Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
	Friend WithEvents Panel6 As System.Windows.Forms.Panel
	Friend WithEvents Panel7 As System.Windows.Forms.Panel
	Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label7 As System.Windows.Forms.Label

End Class

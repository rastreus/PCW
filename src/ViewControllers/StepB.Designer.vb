<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepB
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
		Me.pnlPromoName = New System.Windows.Forms.Panel()
		Me.txtPromoName = New CustomizedTextBox.CustomizedTextBox()
		Me.lblPromoName = New System.Windows.Forms.Label()
		Me.pnlRecurring = New System.Windows.Forms.Panel()
		Me.lblRecurring = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.cbRecurringFrequency = New System.Windows.Forms.ComboBox()
		Me.rbRecurringYes = New System.Windows.Forms.RadioButton()
		Me.rbRecurringNo = New System.Windows.Forms.RadioButton()
		Me.pnlPromoID = New System.Windows.Forms.Panel()
		Me.lblPromoIDtop = New System.Windows.Forms.Label()
		Me.pnlPapayaWhip = New System.Windows.Forms.Panel()
		Me.lblPromoIDEdit = New System.Windows.Forms.Label()
		Me.pnlEditPromoID = New System.Windows.Forms.Panel()
		Me.btnTxtEditPromoID = New System.Windows.Forms.Button()
		Me.lblEditPromoID = New System.Windows.Forms.Label()
		Me.txtEditPromoID = New System.Windows.Forms.TextBox()
		Me.lblPromoID = New System.Windows.Forms.Label()
		Me.pnlPromoName.SuspendLayout()
		Me.pnlRecurring.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.pnlPromoID.SuspendLayout()
		Me.pnlPapayaWhip.SuspendLayout()
		Me.pnlEditPromoID.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Location = New System.Drawing.Point(4, 4)
		Me.Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Description.Size = New System.Drawing.Size(586, 37)
		Me.Description.Text = "Let's start with a couple simple questions!"
		'
		'pnlPromoName
		'
		Me.pnlPromoName.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlPromoName.CausesValidation = False
		Me.pnlPromoName.Controls.Add(Me.txtPromoName)
		Me.pnlPromoName.Controls.Add(Me.lblPromoName)
		Me.pnlPromoName.Location = New System.Drawing.Point(88, 47)
		Me.pnlPromoName.Name = "pnlPromoName"
		Me.pnlPromoName.Size = New System.Drawing.Size(292, 66)
		Me.pnlPromoName.TabIndex = 0
		'
		'txtPromoName
		'
		Me.txtPromoName.CausesValidation = False
		Me.txtPromoName.Location = New System.Drawing.Point(3, 33)
		Me.txtPromoName.MaxLength = 50
		Me.txtPromoName.Name = "txtPromoName"
		Me.txtPromoName.Size = New System.Drawing.Size(284, 20)
		Me.txtPromoName.TabIndex = 1
		'
		'lblPromoName
		'
		Me.lblPromoName.AutoSize = True
		Me.lblPromoName.CausesValidation = False
		Me.lblPromoName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoName.ForeColor = System.Drawing.Color.White
		Me.lblPromoName.Location = New System.Drawing.Point(0, 0)
		Me.lblPromoName.Name = "lblPromoName"
		Me.lblPromoName.Size = New System.Drawing.Size(255, 16)
		Me.lblPromoName.TabIndex = 0
		Me.lblPromoName.Text = "What is the name of the new promo?"
		'
		'pnlRecurring
		'
		Me.pnlRecurring.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlRecurring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlRecurring.CausesValidation = False
		Me.pnlRecurring.Controls.Add(Me.lblRecurring)
		Me.pnlRecurring.Controls.Add(Me.Panel1)
		Me.pnlRecurring.Location = New System.Drawing.Point(88, 117)
		Me.pnlRecurring.Name = "pnlRecurring"
		Me.pnlRecurring.Size = New System.Drawing.Size(292, 132)
		Me.pnlRecurring.TabIndex = 2
		'
		'lblRecurring
		'
		Me.lblRecurring.AutoSize = True
		Me.lblRecurring.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblRecurring.CausesValidation = False
		Me.lblRecurring.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecurring.ForeColor = System.Drawing.Color.White
		Me.lblRecurring.Location = New System.Drawing.Point(0, 0)
		Me.lblRecurring.Name = "lblRecurring"
		Me.lblRecurring.Size = New System.Drawing.Size(233, 16)
		Me.lblRecurring.TabIndex = 0
		Me.lblRecurring.Text = "Will the new promo be recurring?"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.cbRecurringFrequency)
		Me.Panel1.Controls.Add(Me.rbRecurringYes)
		Me.Panel1.Controls.Add(Me.rbRecurringNo)
		Me.Panel1.Location = New System.Drawing.Point(53, 25)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(180, 91)
		Me.Panel1.TabIndex = 0
		'
		'cbRecurringFrequency
		'
		Me.cbRecurringFrequency.CausesValidation = False
		Me.cbRecurringFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbRecurringFrequency.Enabled = False
		Me.cbRecurringFrequency.FormattingEnabled = True
		Me.cbRecurringFrequency.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Quarterly", "Yearly"})
		Me.cbRecurringFrequency.Location = New System.Drawing.Point(52, 2)
		Me.cbRecurringFrequency.Name = "cbRecurringFrequency"
		Me.cbRecurringFrequency.Size = New System.Drawing.Size(121, 21)
		Me.cbRecurringFrequency.TabIndex = 3
		'
		'rbRecurringYes
		'
		Me.rbRecurringYes.AutoSize = True
		Me.rbRecurringYes.CausesValidation = False
		Me.rbRecurringYes.Location = New System.Drawing.Point(3, 3)
		Me.rbRecurringYes.Name = "rbRecurringYes"
		Me.rbRecurringYes.Size = New System.Drawing.Size(43, 17)
		Me.rbRecurringYes.TabIndex = 2
		Me.rbRecurringYes.TabStop = True
		Me.rbRecurringYes.Text = "Yes"
		Me.rbRecurringYes.UseVisualStyleBackColor = True
		'
		'rbRecurringNo
		'
		Me.rbRecurringNo.AutoSize = True
		Me.rbRecurringNo.CausesValidation = False
		Me.rbRecurringNo.Checked = True
		Me.rbRecurringNo.Location = New System.Drawing.Point(3, 26)
		Me.rbRecurringNo.Name = "rbRecurringNo"
		Me.rbRecurringNo.Size = New System.Drawing.Size(39, 17)
		Me.rbRecurringNo.TabIndex = 4
		Me.rbRecurringNo.TabStop = True
		Me.rbRecurringNo.Text = "No"
		Me.rbRecurringNo.UseVisualStyleBackColor = True
		'
		'pnlPromoID
		'
		Me.pnlPromoID.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlPromoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPromoID.CausesValidation = False
		Me.pnlPromoID.Controls.Add(Me.lblPromoIDtop)
		Me.pnlPromoID.Controls.Add(Me.pnlPapayaWhip)
		Me.pnlPromoID.Location = New System.Drawing.Point(386, 47)
		Me.pnlPromoID.Name = "pnlPromoID"
		Me.pnlPromoID.Size = New System.Drawing.Size(123, 81)
		Me.pnlPromoID.TabIndex = 8
		'
		'lblPromoIDtop
		'
		Me.lblPromoIDtop.AutoSize = True
		Me.lblPromoIDtop.BackColor = System.Drawing.Color.Transparent
		Me.lblPromoIDtop.CausesValidation = False
		Me.lblPromoIDtop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoIDtop.ForeColor = System.Drawing.Color.White
		Me.lblPromoIDtop.Location = New System.Drawing.Point(0, 0)
		Me.lblPromoIDtop.Name = "lblPromoIDtop"
		Me.lblPromoIDtop.Size = New System.Drawing.Size(76, 16)
		Me.lblPromoIDtop.TabIndex = 0
		Me.lblPromoIDtop.Text = "PromoID: "
		'
		'pnlPapayaWhip
		'
		Me.pnlPapayaWhip.BackColor = System.Drawing.Color.PapayaWhip
		Me.pnlPapayaWhip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPapayaWhip.CausesValidation = False
		Me.pnlPapayaWhip.Controls.Add(Me.lblPromoID)
		Me.pnlPapayaWhip.Controls.Add(Me.lblPromoIDEdit)
		Me.pnlPapayaWhip.Location = New System.Drawing.Point(3, 19)
		Me.pnlPapayaWhip.Name = "pnlPapayaWhip"
		Me.pnlPapayaWhip.Size = New System.Drawing.Size(111, 49)
		Me.pnlPapayaWhip.TabIndex = 0
		'
		'lblPromoIDEdit
		'
		Me.lblPromoIDEdit.BackColor = System.Drawing.Color.PapayaWhip
		Me.lblPromoIDEdit.CausesValidation = False
		Me.lblPromoIDEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoIDEdit.ForeColor = System.Drawing.Color.Black
		Me.lblPromoIDEdit.Location = New System.Drawing.Point(3, 29)
		Me.lblPromoIDEdit.Name = "lblPromoIDEdit"
		Me.lblPromoIDEdit.Size = New System.Drawing.Size(101, 17)
		Me.lblPromoIDEdit.TabIndex = 0
		Me.lblPromoIDEdit.Text = "(Click to edit)"
		Me.lblPromoIDEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlEditPromoID
		'
		Me.pnlEditPromoID.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlEditPromoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlEditPromoID.Controls.Add(Me.btnTxtEditPromoID)
		Me.pnlEditPromoID.Controls.Add(Me.lblEditPromoID)
		Me.pnlEditPromoID.Controls.Add(Me.txtEditPromoID)
		Me.pnlEditPromoID.Enabled = False
		Me.pnlEditPromoID.Location = New System.Drawing.Point(386, 134)
		Me.pnlEditPromoID.Name = "pnlEditPromoID"
		Me.pnlEditPromoID.Size = New System.Drawing.Size(123, 63)
		Me.pnlEditPromoID.TabIndex = 0
		Me.pnlEditPromoID.Visible = False
		'
		'btnTxtEditPromoID
		'
		Me.btnTxtEditPromoID.BackColor = System.Drawing.Color.HotPink
		Me.btnTxtEditPromoID.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
		Me.btnTxtEditPromoID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnTxtEditPromoID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed
		Me.btnTxtEditPromoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTxtEditPromoID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTxtEditPromoID.ForeColor = System.Drawing.Color.White
		Me.btnTxtEditPromoID.Location = New System.Drawing.Point(3, 32)
		Me.btnTxtEditPromoID.Name = "btnTxtEditPromoID"
		Me.btnTxtEditPromoID.Size = New System.Drawing.Size(111, 23)
		Me.btnTxtEditPromoID.TabIndex = 2
		Me.btnTxtEditPromoID.Text = "Set ID"
		Me.btnTxtEditPromoID.UseVisualStyleBackColor = False
		'
		'lblEditPromoID
		'
		Me.lblEditPromoID.BackColor = System.Drawing.Color.Transparent
		Me.lblEditPromoID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEditPromoID.ForeColor = System.Drawing.Color.White
		Me.lblEditPromoID.Location = New System.Drawing.Point(82, 3)
		Me.lblEditPromoID.Name = "lblEditPromoID"
		Me.lblEditPromoID.Size = New System.Drawing.Size(37, 23)
		Me.lblEditPromoID.TabIndex = 0
		Me.lblEditPromoID.Text = "1503"
		Me.lblEditPromoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtEditPromoID
		'
		Me.txtEditPromoID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEditPromoID.Location = New System.Drawing.Point(3, 3)
		Me.txtEditPromoID.MaxLength = 10
		Me.txtEditPromoID.Name = "txtEditPromoID"
		Me.txtEditPromoID.Size = New System.Drawing.Size(77, 23)
		Me.txtEditPromoID.TabIndex = 0
		Me.txtEditPromoID.TabStop = False
		Me.txtEditPromoID.Text = "EXAMPLE"
		Me.txtEditPromoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblPromoID
		'
		Me.lblPromoID.BackColor = System.Drawing.Color.Gainsboro
		Me.lblPromoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPromoID.CausesValidation = False
		Me.lblPromoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lblPromoID.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPromoID.Location = New System.Drawing.Point(3, 4)
		Me.lblPromoID.Name = "lblPromoID"
		Me.lblPromoID.Size = New System.Drawing.Size(101, 23)
		Me.lblPromoID.TabIndex = 2
		Me.lblPromoID.Text = "EXAMPLE1503"
		Me.lblPromoID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'StepB
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlPromoID)
		Me.Controls.Add(Me.pnlEditPromoID)
		Me.Controls.Add(Me.pnlRecurring)
		Me.Controls.Add(Me.pnlPromoName)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "StepB"
		Me.NextStep = "StepC"
		Me.PreviousStep = "StepA"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Let's start with a couple simple questions!"
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlPromoName, 0)
		Me.Controls.SetChildIndex(Me.pnlRecurring, 0)
		Me.Controls.SetChildIndex(Me.pnlEditPromoID, 0)
		Me.Controls.SetChildIndex(Me.pnlPromoID, 0)
		Me.pnlPromoName.ResumeLayout(False)
		Me.pnlPromoName.PerformLayout()
		Me.pnlRecurring.ResumeLayout(False)
		Me.pnlRecurring.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.pnlPromoID.ResumeLayout(False)
		Me.pnlPromoID.PerformLayout()
		Me.pnlPapayaWhip.ResumeLayout(False)
		Me.pnlEditPromoID.ResumeLayout(False)
		Me.pnlEditPromoID.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblPromoName As System.Windows.Forms.Label
	Friend WithEvents lblRecurring As System.Windows.Forms.Label
	Private WithEvents pnlPromoName As System.Windows.Forms.Panel
	Private WithEvents pnlRecurring As System.Windows.Forms.Panel
	Friend WithEvents rbRecurringYes As System.Windows.Forms.RadioButton
	Friend WithEvents rbRecurringNo As System.Windows.Forms.RadioButton
	Friend WithEvents cbRecurringFrequency As System.Windows.Forms.ComboBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents pnlPromoID As System.Windows.Forms.Panel
	Friend WithEvents lblPromoIDtop As System.Windows.Forms.Label
	Friend WithEvents pnlPapayaWhip As System.Windows.Forms.Panel
	Friend WithEvents lblPromoIDEdit As System.Windows.Forms.Label
	Friend WithEvents pnlEditPromoID As System.Windows.Forms.Panel
	Friend WithEvents btnTxtEditPromoID As System.Windows.Forms.Button
	Friend WithEvents lblEditPromoID As System.Windows.Forms.Label
	Friend WithEvents txtEditPromoID As System.Windows.Forms.TextBox
	Friend WithEvents txtPromoName As CustomizedTextBox.CustomizedTextBox
	Friend WithEvents lblPromoID As System.Windows.Forms.Label

End Class

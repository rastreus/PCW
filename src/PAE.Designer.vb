<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAE))
		Me.lblPAE = New System.Windows.Forms.Label()
		Me.lblDescription = New System.Windows.Forms.Label()
		Me.pnlControl = New System.Windows.Forms.Panel()
		Me.pnlControlDarkDark = New System.Windows.Forms.Panel()
		Me.cbResponsibility = New System.Windows.Forms.CheckBox()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.pnlSaddleBrown = New System.Windows.Forms.Panel()
		Me.pnlControl.SuspendLayout()
		Me.pnlControlDarkDark.SuspendLayout()
		Me.pnlSaddleBrown.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblPAE
		'
		Me.lblPAE.AutoSize = True
		Me.lblPAE.BackColor = System.Drawing.Color.Transparent
		Me.lblPAE.CausesValidation = False
		Me.lblPAE.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPAE.ForeColor = System.Drawing.Color.Tomato
		Me.lblPAE.Location = New System.Drawing.Point(41, 19)
		Me.lblPAE.Name = "lblPAE"
		Me.lblPAE.Size = New System.Drawing.Size(503, 37)
		Me.lblPAE.TabIndex = 0
		Me.lblPAE.Text = "PromotionalAlterationEditor"
		Me.lblPAE.UseMnemonic = False
		'
		'lblDescription
		'
		Me.lblDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblDescription.CausesValidation = False
		Me.lblDescription.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.ForeColor = System.Drawing.Color.White
		Me.lblDescription.Location = New System.Drawing.Point(16, 76)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(568, 64)
		Me.lblDescription.TabIndex = 0
		Me.lblDescription.Text = "The purpose of this tool is to allow minor changes to existing promos. If a lot o" & _
	"f modifications are needed, then you are advised to cancel this operation and st" & _
	"art PCW to create a new promo instead."
		Me.lblDescription.UseMnemonic = False
		'
		'pnlControl
		'
		Me.pnlControl.BackColor = System.Drawing.SystemColors.Control
		Me.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlControl.CausesValidation = False
		Me.pnlControl.Controls.Add(Me.pnlControlDarkDark)
		Me.pnlControl.Controls.Add(Me.btnSubmit)
		Me.pnlControl.Controls.Add(Me.btnCancel)
		Me.pnlControl.Location = New System.Drawing.Point(-5, 798)
		Me.pnlControl.Name = "pnlControl"
		Me.pnlControl.Size = New System.Drawing.Size(601, 40)
		Me.pnlControl.TabIndex = 2
		'
		'pnlControlDarkDark
		'
		Me.pnlControlDarkDark.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlControlDarkDark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlControlDarkDark.CausesValidation = False
		Me.pnlControlDarkDark.Controls.Add(Me.cbResponsibility)
		Me.pnlControlDarkDark.ForeColor = System.Drawing.Color.White
		Me.pnlControlDarkDark.Location = New System.Drawing.Point(97, 3)
		Me.pnlControlDarkDark.Name = "pnlControlDarkDark"
		Me.pnlControlDarkDark.Size = New System.Drawing.Size(408, 32)
		Me.pnlControlDarkDark.TabIndex = 0
		'
		'cbResponsibility
		'
		Me.cbResponsibility.CausesValidation = False
		Me.cbResponsibility.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbResponsibility.Location = New System.Drawing.Point(3, -2)
		Me.cbResponsibility.Name = "cbResponsibility"
		Me.cbResponsibility.Size = New System.Drawing.Size(398, 32)
		Me.cbResponsibility.TabIndex = 0
		Me.cbResponsibility.TabStop = False
		Me.cbResponsibility.Text = "I take responsibility for the changes to the above promo."
		Me.cbResponsibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cbResponsibility.UseMnemonic = False
		Me.cbResponsibility.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.CausesValidation = False
		Me.btnSubmit.Location = New System.Drawing.Point(511, 7)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
		Me.btnSubmit.TabIndex = 0
		Me.btnSubmit.TabStop = False
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseMnemonic = False
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.CausesValidation = False
		Me.btnCancel.Location = New System.Drawing.Point(16, 7)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 0
		Me.btnCancel.TabStop = False
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseMnemonic = False
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'pnlSaddleBrown
		'
		Me.pnlSaddleBrown.BackColor = System.Drawing.Color.SaddleBrown
		Me.pnlSaddleBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlSaddleBrown.CausesValidation = False
		Me.pnlSaddleBrown.Controls.Add(Me.lblPAE)
		Me.pnlSaddleBrown.Controls.Add(Me.lblDescription)
		Me.pnlSaddleBrown.Location = New System.Drawing.Point(-5, -1)
		Me.pnlSaddleBrown.Name = "pnlSaddleBrown"
		Me.pnlSaddleBrown.Size = New System.Drawing.Size(601, 160)
		Me.pnlSaddleBrown.TabIndex = 0
		'
		'PAE
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Peru
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(592, 837)
		Me.Controls.Add(Me.pnlSaddleBrown)
		Me.Controls.Add(Me.pnlControl)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "PAE"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "PAE (PromotionalAlternationEditor)"
		Me.pnlControl.ResumeLayout(False)
		Me.pnlControlDarkDark.ResumeLayout(False)
		Me.pnlSaddleBrown.ResumeLayout(False)
		Me.pnlSaddleBrown.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents pnlControl As System.Windows.Forms.Panel
	Private WithEvents btnCancel As System.Windows.Forms.Button
	Private WithEvents btnSubmit As System.Windows.Forms.Button
	Private WithEvents cbResponsibility As System.Windows.Forms.CheckBox
	Private WithEvents pnlControlDarkDark As System.Windows.Forms.Panel
	Private WithEvents pnlSaddleBrown As System.Windows.Forms.Panel
	Private WithEvents lblPAE As System.Windows.Forms.Label
	Private WithEvents lblDescription As System.Windows.Forms.Label
End Class

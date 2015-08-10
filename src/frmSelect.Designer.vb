<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelect))
		Me.pnlDarkSlateBlue = New System.Windows.Forms.Panel()
		Me.btnOpenPCW = New System.Windows.Forms.Button()
		Me.pnlDarkGoldenrod = New System.Windows.Forms.Panel()
		Me.btnOpenPAE = New System.Windows.Forms.Button()
		Me.pnlDarkSlateBlue.SuspendLayout()
		Me.pnlDarkGoldenrod.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlDarkSlateBlue
		'
		Me.pnlDarkSlateBlue.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.pnlDarkSlateBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDarkSlateBlue.CausesValidation = False
		Me.pnlDarkSlateBlue.Controls.Add(Me.btnOpenPCW)
		Me.pnlDarkSlateBlue.Location = New System.Drawing.Point(-5, -1)
		Me.pnlDarkSlateBlue.Name = "pnlDarkSlateBlue"
		Me.pnlDarkSlateBlue.Size = New System.Drawing.Size(604, 60)
		Me.pnlDarkSlateBlue.TabIndex = 0
		'
		'btnOpenPCW
		'
		Me.btnOpenPCW.BackColor = System.Drawing.Color.MediumPurple
		Me.btnOpenPCW.CausesValidation = False
		Me.btnOpenPCW.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnOpenPCW.FlatAppearance.BorderSize = 2
		Me.btnOpenPCW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnOpenPCW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
		Me.btnOpenPCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOpenPCW.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOpenPCW.ForeColor = System.Drawing.Color.White
		Me.btnOpenPCW.Location = New System.Drawing.Point(218, 12)
		Me.btnOpenPCW.Name = "btnOpenPCW"
		Me.btnOpenPCW.Size = New System.Drawing.Size(189, 37)
		Me.btnOpenPCW.TabIndex = 0
		Me.btnOpenPCW.TabStop = False
		Me.btnOpenPCW.Text = "CREATE UNIQUE PROMO"
		Me.btnOpenPCW.UseMnemonic = False
		Me.btnOpenPCW.UseVisualStyleBackColor = False
		'
		'pnlDarkGoldenrod
		'
		Me.pnlDarkGoldenrod.BackColor = System.Drawing.Color.SaddleBrown
		Me.pnlDarkGoldenrod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDarkGoldenrod.CausesValidation = False
		Me.pnlDarkGoldenrod.Controls.Add(Me.btnOpenPAE)
		Me.pnlDarkGoldenrod.Location = New System.Drawing.Point(-5, 58)
		Me.pnlDarkGoldenrod.Name = "pnlDarkGoldenrod"
		Me.pnlDarkGoldenrod.Size = New System.Drawing.Size(604, 60)
		Me.pnlDarkGoldenrod.TabIndex = 0
		'
		'btnOpenPAE
		'
		Me.btnOpenPAE.BackColor = System.Drawing.Color.Peru
		Me.btnOpenPAE.CausesValidation = False
		Me.btnOpenPAE.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnOpenPAE.FlatAppearance.BorderSize = 2
		Me.btnOpenPAE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnOpenPAE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
		Me.btnOpenPAE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnOpenPAE.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOpenPAE.ForeColor = System.Drawing.Color.White
		Me.btnOpenPAE.Location = New System.Drawing.Point(218, 10)
		Me.btnOpenPAE.Name = "btnOpenPAE"
		Me.btnOpenPAE.Size = New System.Drawing.Size(189, 37)
		Me.btnOpenPAE.TabIndex = 0
		Me.btnOpenPAE.TabStop = False
		Me.btnOpenPAE.Text = "MODIFY EXTANT PROMO"
		Me.btnOpenPAE.UseMnemonic = False
		Me.btnOpenPAE.UseVisualStyleBackColor = False
		'
		'frmSelect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(594, 117)
		Me.Controls.Add(Me.pnlDarkGoldenrod)
		Me.Controls.Add(Me.pnlDarkSlateBlue)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MaximizeBox = False
		Me.Name = "frmSelect"
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SELECT AN OPTION"
		Me.pnlDarkSlateBlue.ResumeLayout(False)
		Me.pnlDarkGoldenrod.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents pnlDarkSlateBlue As System.Windows.Forms.Panel
	Private WithEvents btnOpenPCW As System.Windows.Forms.Button
	Private WithEvents pnlDarkGoldenrod As System.Windows.Forms.Panel
	Private WithEvents btnOpenPAE As System.Windows.Forms.Button
End Class

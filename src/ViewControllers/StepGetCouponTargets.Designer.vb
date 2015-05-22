<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepGetCouponTargets
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
		Me.pnlTargtListImport = New System.Windows.Forms.Panel()
		Me.lblClickButtonBelow = New System.Windows.Forms.Label()
		Me.btnFileBrowser = New System.Windows.Forms.Button()
		Me.pnlDragTargetList = New System.Windows.Forms.Panel()
		Me.lblDragHere = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlCouponNumberForTargetList = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pnlAquamarine = New System.Windows.Forms.Panel()
		Me.cbImportedOffers = New System.Windows.Forms.ComboBox()
		Me.rbImportedOffers = New System.Windows.Forms.RadioButton()
		Me.rbWildcard = New System.Windows.Forms.RadioButton()
		Me.pnlCouponOffers = New System.Windows.Forms.Panel()
		Me.lblCouponTargetLists = New System.Windows.Forms.Label()
		Me.lblCouponOffers = New System.Windows.Forms.Label()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.pnlTargtListImport.SuspendLayout()
		Me.pnlDragTargetList.SuspendLayout()
		Me.pnlCouponNumberForTargetList.SuspendLayout()
		Me.pnlAquamarine.SuspendLayout()
		Me.pnlCouponOffers.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.Size = New System.Drawing.Size(578, 72)
		Me.Description.Text = "Submit your Coupon Target Lists here."
		'
		'pnlTargtListImport
		'
		Me.pnlTargtListImport.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlTargtListImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlTargtListImport.Controls.Add(Me.lblClickButtonBelow)
		Me.pnlTargtListImport.Controls.Add(Me.btnFileBrowser)
		Me.pnlTargtListImport.Controls.Add(Me.pnlDragTargetList)
		Me.pnlTargtListImport.Controls.Add(Me.Label1)
		Me.pnlTargtListImport.Location = New System.Drawing.Point(74, 33)
		Me.pnlTargtListImport.Name = "pnlTargtListImport"
		Me.pnlTargtListImport.Size = New System.Drawing.Size(278, 118)
		Me.pnlTargtListImport.TabIndex = 1
		'
		'lblClickButtonBelow
		'
		Me.lblClickButtonBelow.BackColor = System.Drawing.Color.Transparent
		Me.lblClickButtonBelow.ForeColor = System.Drawing.Color.White
		Me.lblClickButtonBelow.Location = New System.Drawing.Point(3, 74)
		Me.lblClickButtonBelow.Name = "lblClickButtonBelow"
		Me.lblClickButtonBelow.Size = New System.Drawing.Size(268, 12)
		Me.lblClickButtonBelow.TabIndex = 36
		Me.lblClickButtonBelow.Text = "(Or Click Button Below)"
		Me.lblClickButtonBelow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnFileBrowser
		'
		Me.btnFileBrowser.BackColor = System.Drawing.Color.PapayaWhip
		Me.btnFileBrowser.FlatAppearance.BorderColor = System.Drawing.Color.Orange
		Me.btnFileBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
		Me.btnFileBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki
		Me.btnFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFileBrowser.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnFileBrowser.Location = New System.Drawing.Point(3, 89)
		Me.btnFileBrowser.Name = "btnFileBrowser"
		Me.btnFileBrowser.Size = New System.Drawing.Size(268, 23)
		Me.btnFileBrowser.TabIndex = 35
		Me.btnFileBrowser.Text = "C:\path\to\file\targetList.csv"
		Me.btnFileBrowser.UseVisualStyleBackColor = False
		'
		'pnlDragTargetList
		'
		Me.pnlDragTargetList.AllowDrop = True
		Me.pnlDragTargetList.BackColor = System.Drawing.Color.LemonChiffon
		Me.pnlDragTargetList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlDragTargetList.Controls.Add(Me.lblDragHere)
		Me.pnlDragTargetList.Location = New System.Drawing.Point(3, 23)
		Me.pnlDragTargetList.Name = "pnlDragTargetList"
		Me.pnlDragTargetList.Size = New System.Drawing.Size(268, 48)
		Me.pnlDragTargetList.TabIndex = 0
		'
		'lblDragHere
		'
		Me.lblDragHere.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDragHere.Location = New System.Drawing.Point(60, 13)
		Me.lblDragHere.Name = "lblDragHere"
		Me.lblDragHere.Size = New System.Drawing.Size(155, 20)
		Me.lblDragHere.TabIndex = 0
		Me.lblDragHere.Text = "Drag Target List Here"
		Me.lblDragHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(268, 23)
		Me.Label1.TabIndex = 33
		Me.Label1.Text = "Import Target List:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlCouponNumberForTargetList
		'
		Me.pnlCouponNumberForTargetList.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCouponNumberForTargetList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCouponNumberForTargetList.Controls.Add(Me.Label2)
		Me.pnlCouponNumberForTargetList.Controls.Add(Me.pnlAquamarine)
		Me.pnlCouponNumberForTargetList.Location = New System.Drawing.Point(74, 157)
		Me.pnlCouponNumberForTargetList.Name = "pnlCouponNumberForTargetList"
		Me.pnlCouponNumberForTargetList.Size = New System.Drawing.Size(278, 110)
		Me.pnlCouponNumberForTargetList.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(268, 23)
		Me.Label2.TabIndex = 34
		Me.Label2.Text = "Select Coupon Number for Target:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlAquamarine
		'
		Me.pnlAquamarine.BackColor = System.Drawing.Color.Aquamarine
		Me.pnlAquamarine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlAquamarine.Controls.Add(Me.cbImportedOffers)
		Me.pnlAquamarine.Controls.Add(Me.rbImportedOffers)
		Me.pnlAquamarine.Controls.Add(Me.rbWildcard)
		Me.pnlAquamarine.Location = New System.Drawing.Point(3, 23)
		Me.pnlAquamarine.Name = "pnlAquamarine"
		Me.pnlAquamarine.Size = New System.Drawing.Size(268, 81)
		Me.pnlAquamarine.TabIndex = 0
		'
		'cbImportedOffers
		'
		Me.cbImportedOffers.BackColor = System.Drawing.Color.WhiteSmoke
		Me.cbImportedOffers.Enabled = False
		Me.cbImportedOffers.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbImportedOffers.ForeColor = System.Drawing.Color.Black
		Me.cbImportedOffers.FormattingEnabled = True
		Me.cbImportedOffers.Location = New System.Drawing.Point(82, 49)
		Me.cbImportedOffers.Name = "cbImportedOffers"
		Me.cbImportedOffers.Size = New System.Drawing.Size(121, 23)
		Me.cbImportedOffers.TabIndex = 2
		'
		'rbImportedOffers
		'
		Me.rbImportedOffers.AutoSize = True
		Me.rbImportedOffers.Location = New System.Drawing.Point(62, 26)
		Me.rbImportedOffers.Name = "rbImportedOffers"
		Me.rbImportedOffers.Size = New System.Drawing.Size(173, 17)
		Me.rbImportedOffers.TabIndex = 1
		Me.rbImportedOffers.Text = "Specify Imported Coupon Offer:"
		Me.rbImportedOffers.UseVisualStyleBackColor = True
		'
		'rbWildcard
		'
		Me.rbWildcard.AutoSize = True
		Me.rbWildcard.Checked = True
		Me.rbWildcard.Location = New System.Drawing.Point(62, 3)
		Me.rbWildcard.Name = "rbWildcard"
		Me.rbWildcard.Size = New System.Drawing.Size(82, 17)
		Me.rbWildcard.TabIndex = 0
		Me.rbWildcard.TabStop = True
		Me.rbWildcard.Text = "Wildcard (0)"
		Me.rbWildcard.UseVisualStyleBackColor = True
		'
		'pnlCouponOffers
		'
		Me.pnlCouponOffers.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlCouponOffers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlCouponOffers.Controls.Add(Me.lblCouponTargetLists)
		Me.pnlCouponOffers.Controls.Add(Me.lblCouponOffers)
		Me.pnlCouponOffers.Controls.Add(Me.btnSubmit)
		Me.pnlCouponOffers.Location = New System.Drawing.Point(358, 33)
		Me.pnlCouponOffers.Name = "pnlCouponOffers"
		Me.pnlCouponOffers.Size = New System.Drawing.Size(164, 234)
		Me.pnlCouponOffers.TabIndex = 34
		'
		'lblCouponTargetLists
		'
		Me.lblCouponTargetLists.BackColor = System.Drawing.Color.Gainsboro
		Me.lblCouponTargetLists.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponTargetLists.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblCouponTargetLists.Location = New System.Drawing.Point(9, 23)
		Me.lblCouponTargetLists.Name = "lblCouponTargetLists"
		Me.lblCouponTargetLists.Size = New System.Drawing.Size(140, 175)
		Me.lblCouponTargetLists.TabIndex = 33
		Me.lblCouponTargetLists.Text = "Click 'Submit' below to add Coupon Targets."
		Me.lblCouponTargetLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblCouponOffers
		'
		Me.lblCouponOffers.BackColor = System.Drawing.Color.Transparent
		Me.lblCouponOffers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCouponOffers.ForeColor = System.Drawing.Color.White
		Me.lblCouponOffers.Location = New System.Drawing.Point(-2, 0)
		Me.lblCouponOffers.Name = "lblCouponOffers"
		Me.lblCouponOffers.Size = New System.Drawing.Size(164, 23)
		Me.lblCouponOffers.TabIndex = 32
		Me.lblCouponOffers.Text = "Coupon Target Lists:"
		Me.lblCouponOffers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSubmit
		'
		Me.btnSubmit.BackColor = System.Drawing.Color.MediumPurple
		Me.btnSubmit.Enabled = False
		Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
		Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue
		Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSubmit.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmit.ForeColor = System.Drawing.Color.White
		Me.btnSubmit.Location = New System.Drawing.Point(9, 201)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(140, 26)
		Me.btnSubmit.TabIndex = 31
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSubmit.UseVisualStyleBackColor = False
		'
		'StepGetCouponTargets
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pnlCouponOffers)
		Me.Controls.Add(Me.pnlCouponNumberForTargetList)
		Me.Controls.Add(Me.pnlTargtListImport)
		Me.Name = "StepGetCouponTargets"
		Me.NextStep = "StepH"
		Me.PreviousStep = "StepGetCouponOffers"
		Me.Size = New System.Drawing.Size(594, 293)
		Me.StepDescription = "Submit your Coupon Target Lists here."
		Me.Controls.SetChildIndex(Me.Description, 0)
		Me.Controls.SetChildIndex(Me.pnlTargtListImport, 0)
		Me.Controls.SetChildIndex(Me.pnlCouponNumberForTargetList, 0)
		Me.Controls.SetChildIndex(Me.pnlCouponOffers, 0)
		Me.pnlTargtListImport.ResumeLayout(False)
		Me.pnlDragTargetList.ResumeLayout(False)
		Me.pnlCouponNumberForTargetList.ResumeLayout(False)
		Me.pnlAquamarine.ResumeLayout(False)
		Me.pnlAquamarine.PerformLayout()
		Me.pnlCouponOffers.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlTargtListImport As System.Windows.Forms.Panel
	Friend WithEvents pnlCouponNumberForTargetList As System.Windows.Forms.Panel
	Private WithEvents pnlCouponOffers As System.Windows.Forms.Panel
	Private WithEvents lblCouponTargetLists As System.Windows.Forms.Label
	Private WithEvents lblCouponOffers As System.Windows.Forms.Label
	Private WithEvents btnSubmit As System.Windows.Forms.Button
	Friend WithEvents pnlDragTargetList As System.Windows.Forms.Panel
	Private WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents pnlAquamarine As System.Windows.Forms.Panel
	Private WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents rbImportedOffers As System.Windows.Forms.RadioButton
	Friend WithEvents rbWildcard As System.Windows.Forms.RadioButton
	Friend WithEvents cbImportedOffers As System.Windows.Forms.ComboBox
	Friend WithEvents lblDragHere As System.Windows.Forms.Label
	Friend WithEvents btnFileBrowser As System.Windows.Forms.Button
	Friend WithEvents lblClickButtonBelow As System.Windows.Forms.Label

End Class

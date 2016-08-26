<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DDEP
    Inherits System.Windows.Forms.UserControl

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
		Me.pnlDragDropCSV = New System.Windows.Forms.Panel()
		Me.SuccessIcon = New FontAwesomeIcons.IconButton()
		Me.lblDrag = New System.Windows.Forms.Label()
		Me.pnlForSelectorButtons = New System.Windows.Forms.Panel()
		Me.sbNumOfTickets = New PromotionalCreationWizard.SelectorButton()
		Me.sbPlayerID = New PromotionalCreationWizard.SelectorButton()
		Me.cbPlayerID = New System.Windows.Forms.ComboBox()
		Me.cbNumOfTickets = New System.Windows.Forms.ComboBox()
		Me.btnSet = New System.Windows.Forms.Button()
		Me.btnFileFinder = New System.Windows.Forms.Button()
		Me.lblPath = New System.Windows.Forms.Label()
		Me.lblFilePath = New System.Windows.Forms.Label()
		Me.pnlFilePath = New System.Windows.Forms.Panel()
		Me.pnlControlDarkDark = New System.Windows.Forms.Panel()
		Me.lblImportCSV = New System.Windows.Forms.Label()
		Me.pnlControlDarkDark2 = New System.Windows.Forms.Panel()
		Me.lblDirections = New System.Windows.Forms.Label()
		Me.pnlDragDropCSV.SuspendLayout()
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlForSelectorButtons.SuspendLayout()
		Me.pnlFilePath.SuspendLayout()
		Me.pnlControlDarkDark.SuspendLayout()
		Me.pnlControlDarkDark2.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlDragDropCSV
		'
		Me.pnlDragDropCSV.AllowDrop = True
		Me.pnlDragDropCSV.BackColor = System.Drawing.Color.OldLace
		Me.pnlDragDropCSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDragDropCSV.CausesValidation = False
		Me.pnlDragDropCSV.Controls.Add(Me.SuccessIcon)
		Me.pnlDragDropCSV.Controls.Add(Me.lblDrag)
		Me.pnlDragDropCSV.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pnlDragDropCSV.Location = New System.Drawing.Point(7, 24)
		Me.pnlDragDropCSV.Name = "pnlDragDropCSV"
		Me.pnlDragDropCSV.Size = New System.Drawing.Size(134, 120)
		Me.pnlDragDropCSV.TabIndex = 0
		'
		'SuccessIcon
		'
		Me.SuccessIcon.ActiveColor = System.Drawing.Color.Lime
		Me.SuccessIcon.BackColor = System.Drawing.Color.Transparent
		Me.SuccessIcon.Enabled = False
		Me.SuccessIcon.IconType = FontAwesomeIcons.IconType.Tick
		Me.SuccessIcon.InActiveColor = System.Drawing.Color.Lime
		Me.SuccessIcon.Location = New System.Drawing.Point(189, 54)
		Me.SuccessIcon.Name = "SuccessIcon"
		Me.SuccessIcon.Size = New System.Drawing.Size(20, 20)
		Me.SuccessIcon.TabIndex = 5
		Me.SuccessIcon.TabStop = False
		Me.SuccessIcon.ToolTipText = Nothing
		Me.SuccessIcon.Visible = False
		'
		'lblDrag
		'
		Me.lblDrag.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDrag.Location = New System.Drawing.Point(3, 54)
		Me.lblDrag.Name = "lblDrag"
		Me.lblDrag.Size = New System.Drawing.Size(126, 20)
		Me.lblDrag.TabIndex = 0
		Me.lblDrag.Text = "Drag .CSV File Here"
		Me.lblDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlForSelectorButtons
		'
		Me.pnlForSelectorButtons.BackColor = System.Drawing.Color.Transparent
		Me.pnlForSelectorButtons.CausesValidation = False
		Me.pnlForSelectorButtons.Controls.Add(Me.sbNumOfTickets)
		Me.pnlForSelectorButtons.Controls.Add(Me.sbPlayerID)
		Me.pnlForSelectorButtons.Location = New System.Drawing.Point(3, 24)
		Me.pnlForSelectorButtons.Name = "pnlForSelectorButtons"
		Me.pnlForSelectorButtons.Size = New System.Drawing.Size(101, 58)
		Me.pnlForSelectorButtons.TabIndex = 0
		'
		'sbNumOfTickets
		'
		Me.sbNumOfTickets.AutoSize = True
		Me.sbNumOfTickets.BackColor = System.Drawing.Color.Gainsboro
		Me.sbNumOfTickets.CausesValidation = False
		Me.sbNumOfTickets.Enabled = False
		Me.sbNumOfTickets.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.sbNumOfTickets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.sbNumOfTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
		Me.sbNumOfTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sbNumOfTickets.ForeColor = System.Drawing.Color.Black
		Me.sbNumOfTickets.Location = New System.Drawing.Point(4, 31)
		Me.sbNumOfTickets.Name = "sbNumOfTickets"
		Me.sbNumOfTickets.Size = New System.Drawing.Size(93, 21)
		Me.sbNumOfTickets.TabIndex = 0
		Me.sbNumOfTickets.TabStop = False
		Me.sbNumOfTickets.UseMnemonic = False
		Me.sbNumOfTickets.UseVisualStyleBackColor = False
		'
		'sbPlayerID
		'
		Me.sbPlayerID.AutoSize = True
		Me.sbPlayerID.BackColor = System.Drawing.Color.Gainsboro
		Me.sbPlayerID.CausesValidation = False
		Me.sbPlayerID.Enabled = False
		Me.sbPlayerID.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.sbPlayerID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.sbPlayerID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
		Me.sbPlayerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sbPlayerID.ForeColor = System.Drawing.Color.Black
		Me.sbPlayerID.Location = New System.Drawing.Point(4, 4)
		Me.sbPlayerID.Name = "sbPlayerID"
		Me.sbPlayerID.Size = New System.Drawing.Size(93, 21)
		Me.sbPlayerID.TabIndex = 0
		Me.sbPlayerID.TabStop = False
		Me.sbPlayerID.UseMnemonic = False
		Me.sbPlayerID.UseVisualStyleBackColor = False
		'
		'cbPlayerID
		'
		Me.cbPlayerID.BackColor = System.Drawing.Color.Gainsboro
		Me.cbPlayerID.CausesValidation = False
		Me.cbPlayerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbPlayerID.Enabled = False
		Me.cbPlayerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbPlayerID.ForeColor = System.Drawing.Color.Black
		Me.cbPlayerID.FormattingEnabled = True
		Me.cbPlayerID.Location = New System.Drawing.Point(110, 28)
		Me.cbPlayerID.MaxDropDownItems = 30
		Me.cbPlayerID.Name = "cbPlayerID"
		Me.cbPlayerID.Size = New System.Drawing.Size(121, 21)
		Me.cbPlayerID.TabIndex = 0
		Me.cbPlayerID.TabStop = False
		'
		'cbNumOfTickets
		'
		Me.cbNumOfTickets.BackColor = System.Drawing.Color.Gainsboro
		Me.cbNumOfTickets.CausesValidation = False
		Me.cbNumOfTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbNumOfTickets.Enabled = False
		Me.cbNumOfTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbNumOfTickets.ForeColor = System.Drawing.Color.Black
		Me.cbNumOfTickets.FormattingEnabled = True
		Me.cbNumOfTickets.Location = New System.Drawing.Point(110, 55)
		Me.cbNumOfTickets.MaxDropDownItems = 30
		Me.cbNumOfTickets.Name = "cbNumOfTickets"
		Me.cbNumOfTickets.Size = New System.Drawing.Size(121, 21)
		Me.cbNumOfTickets.TabIndex = 0
		Me.cbNumOfTickets.TabStop = False
		'
		'btnSet
		'
		Me.btnSet.BackColor = System.Drawing.Color.Gainsboro
		Me.btnSet.Enabled = False
		Me.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
		Me.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue
		Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSet.ForeColor = System.Drawing.Color.White
		Me.btnSet.Location = New System.Drawing.Point(7, 88)
		Me.btnSet.Name = "btnSet"
		Me.btnSet.Size = New System.Drawing.Size(224, 20)
		Me.btnSet.TabIndex = 0
		Me.btnSet.TabStop = False
		Me.btnSet.UseMnemonic = False
		Me.btnSet.UseVisualStyleBackColor = False
		'
		'btnFileFinder
		'
		Me.btnFileFinder.BackColor = System.Drawing.Color.OldLace
		Me.btnFileFinder.CausesValidation = False
		Me.btnFileFinder.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnFileFinder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
		Me.btnFileFinder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
		Me.btnFileFinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFileFinder.Location = New System.Drawing.Point(7, 150)
		Me.btnFileFinder.Name = "btnFileFinder"
		Me.btnFileFinder.Size = New System.Drawing.Size(134, 23)
		Me.btnFileFinder.TabIndex = 0
		Me.btnFileFinder.TabStop = False
		Me.btnFileFinder.Text = "File Finder"
		Me.btnFileFinder.UseMnemonic = False
		Me.btnFileFinder.UseVisualStyleBackColor = False
		'
		'lblPath
		'
		Me.lblPath.AutoSize = True
		Me.lblPath.BackColor = System.Drawing.Color.Transparent
		Me.lblPath.Location = New System.Drawing.Point(4, 5)
		Me.lblPath.Name = "lblPath"
		Me.lblPath.Size = New System.Drawing.Size(67, 13)
		Me.lblPath.TabIndex = 0
		Me.lblPath.Text = "File Path:"
		Me.lblPath.UseMnemonic = False
		'
		'lblFilePath
		'
		Me.lblFilePath.BackColor = System.Drawing.Color.Transparent
		Me.lblFilePath.CausesValidation = False
		Me.lblFilePath.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFilePath.Location = New System.Drawing.Point(77, 5)
		Me.lblFilePath.Name = "lblFilePath"
		Me.lblFilePath.Size = New System.Drawing.Size(200, 43)
		Me.lblFilePath.TabIndex = 0
		Me.lblFilePath.Text = "\path\to\csv\file"
		Me.lblFilePath.UseMnemonic = False
		'
		'pnlFilePath
		'
		Me.pnlFilePath.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlFilePath.CausesValidation = False
		Me.pnlFilePath.Controls.Add(Me.lblPath)
		Me.pnlFilePath.Controls.Add(Me.lblFilePath)
		Me.pnlFilePath.Location = New System.Drawing.Point(216, 155)
		Me.pnlFilePath.Name = "pnlFilePath"
		Me.pnlFilePath.Size = New System.Drawing.Size(285, 52)
		Me.pnlFilePath.TabIndex = 1
		'
		'pnlControlDarkDark
		'
		Me.pnlControlDarkDark.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlControlDarkDark.CausesValidation = False
		Me.pnlControlDarkDark.Controls.Add(Me.lblImportCSV)
		Me.pnlControlDarkDark.Controls.Add(Me.pnlDragDropCSV)
		Me.pnlControlDarkDark.Controls.Add(Me.btnFileFinder)
		Me.pnlControlDarkDark.Location = New System.Drawing.Point(61, 27)
		Me.pnlControlDarkDark.Name = "pnlControlDarkDark"
		Me.pnlControlDarkDark.Size = New System.Drawing.Size(149, 180)
		Me.pnlControlDarkDark.TabIndex = 0
		'
		'lblImportCSV
		'
		Me.lblImportCSV.BackColor = System.Drawing.Color.Transparent
		Me.lblImportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lblImportCSV.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblImportCSV.ForeColor = System.Drawing.Color.White
		Me.lblImportCSV.Location = New System.Drawing.Point(4, 2)
		Me.lblImportCSV.Name = "lblImportCSV"
		Me.lblImportCSV.Size = New System.Drawing.Size(137, 21)
		Me.lblImportCSV.TabIndex = 2
		Me.lblImportCSV.Text = "Import CSV"
		Me.lblImportCSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlControlDarkDark2
		'
		Me.pnlControlDarkDark2.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.pnlControlDarkDark2.CausesValidation = False
		Me.pnlControlDarkDark2.Controls.Add(Me.lblDirections)
		Me.pnlControlDarkDark2.Controls.Add(Me.pnlForSelectorButtons)
		Me.pnlControlDarkDark2.Controls.Add(Me.cbPlayerID)
		Me.pnlControlDarkDark2.Controls.Add(Me.cbNumOfTickets)
		Me.pnlControlDarkDark2.Controls.Add(Me.btnSet)
		Me.pnlControlDarkDark2.Location = New System.Drawing.Point(216, 27)
		Me.pnlControlDarkDark2.Name = "pnlControlDarkDark2"
		Me.pnlControlDarkDark2.Size = New System.Drawing.Size(242, 122)
		Me.pnlControlDarkDark2.TabIndex = 0
		'
		'lblDirections
		'
		Me.lblDirections.BackColor = System.Drawing.Color.Transparent
		Me.lblDirections.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDirections.ForeColor = System.Drawing.Color.White
		Me.lblDirections.Location = New System.Drawing.Point(3, 3)
		Me.lblDirections.Name = "lblDirections"
		Me.lblDirections.Size = New System.Drawing.Size(228, 21)
		Me.lblDirections.TabIndex = 0
		Me.lblDirections.Text = "Pair CSV column to Database column"
		Me.lblDirections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DDEP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LemonChiffon
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CausesValidation = False
		Me.Controls.Add(Me.pnlControlDarkDark2)
		Me.Controls.Add(Me.pnlControlDarkDark)
		Me.Controls.Add(Me.pnlFilePath)
		Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "DDEP"
		Me.Size = New System.Drawing.Size(531, 238)
		Me.pnlDragDropCSV.ResumeLayout(False)
		CType(Me.SuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlForSelectorButtons.ResumeLayout(False)
		Me.pnlForSelectorButtons.PerformLayout()
		Me.pnlFilePath.ResumeLayout(False)
		Me.pnlFilePath.PerformLayout()
		Me.pnlControlDarkDark.ResumeLayout(False)
		Me.pnlControlDarkDark2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents pnlDragDropCSV As System.Windows.Forms.Panel
	Friend WithEvents SuccessIcon As FontAwesomeIcons.IconButton
	Friend WithEvents lblDrag As System.Windows.Forms.Label
	Private WithEvents pnlForSelectorButtons As System.Windows.Forms.Panel
	Private WithEvents sbNumOfTickets As PromotionalCreationWizard.SelectorButton
	Private WithEvents sbPlayerID As PromotionalCreationWizard.SelectorButton
	Private WithEvents cbPlayerID As System.Windows.Forms.ComboBox
	Private WithEvents cbNumOfTickets As System.Windows.Forms.ComboBox
	Private WithEvents btnSet As System.Windows.Forms.Button
	Private WithEvents btnFileFinder As System.Windows.Forms.Button
	Private WithEvents lblPath As System.Windows.Forms.Label
	Friend WithEvents pnlFilePath As System.Windows.Forms.Panel
	Private WithEvents pnlControlDarkDark As System.Windows.Forms.Panel
	Private WithEvents lblImportCSV As System.Windows.Forms.Label
	Private WithEvents pnlControlDarkDark2 As System.Windows.Forms.Panel
	Private WithEvents lblDirections As System.Windows.Forms.Label
	Public WithEvents lblFilePath As System.Windows.Forms.Label

End Class

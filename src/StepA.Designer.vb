<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepA
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.IconButton1 = New FontAwesomeIcons.IconButton()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Description
		'
		Me.Description.BackColor = System.Drawing.Color.MediumPurple
		Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Description.ForeColor = System.Drawing.Color.White
		Me.Description.Location = New System.Drawing.Point(11, 22)
		Me.Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Description.Size = New System.Drawing.Size(393, 40)
		Me.Description.Text = "Welcome to the PCW!"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(6, 69)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(369, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "The PCW is a safe guide throughout the process of generating a new promo."
		'
		'Label2
		'
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(6, 97)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(402, 31)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Multiple questions in order to fully realize what type of promo is needed to be g" & _
	"enerated."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(6, 138)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(376, 13)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "The back button below can be used to change promotional details as needed."
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(6, 164)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(257, 13)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "The process is not finalized until there is confirmation."
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(6, 195)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(252, 13)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "The cancel button can be used to stop the process."
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(6, 220)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(271, 13)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Nothing will be created if PCW is canceled and aborted."
		'
		'IconButton1
		'
		Me.IconButton1.ActiveColor = System.Drawing.Color.Gold
		Me.IconButton1.BackColor = System.Drawing.Color.Transparent
		Me.IconButton1.IconType = FontAwesomeIcons.IconType.InfoCircle
		Me.IconButton1.InActiveColor = System.Drawing.Color.LavenderBlush
		Me.IconButton1.Location = New System.Drawing.Point(3, 332)
		Me.IconButton1.Name = "IconButton1"
		Me.IconButton1.Size = New System.Drawing.Size(24, 24)
		Me.IconButton1.TabIndex = 7
		Me.IconButton1.TabStop = False
		Me.IconButton1.ToolTipText = Nothing
		'
		'Button2
		'
		Me.Button2.Enabled = False
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.LavenderBlush
		Me.Button2.Location = New System.Drawing.Point(9, 268)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(387, 35)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "Click Here to Edit an Existing Promo! (Disabled WIP)"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.IconButton1)
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Location = New System.Drawing.Point(6, 4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(415, 363)
		Me.Panel1.TabIndex = 9
		'
		'StepA
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "StepA"
		Me.NextStep = "StepB"
		Me.Size = New System.Drawing.Size(424, 370)
		Me.StepDescription = "Welcome to the PCW!"
		Me.Controls.SetChildIndex(Me.Panel1, 0)
		Me.Controls.SetChildIndex(Me.Description, 0)
		CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

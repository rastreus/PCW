<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepN
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
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.Location = New System.Drawing.Point(1, 21)
        Me.Description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Description.Size = New System.Drawing.Size(416, 40)
        Me.Description.Text = "Thanks for using the PCW!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hopefully your experience using the PCW was pleasant."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Work on the PCW will continue as the need arises."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(416, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "With that having been said, please feel free to reach out with questions or sugge" & _
    "stions."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact information can be found by clicking the 'Info' button on the bottom bar." & _
    ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Have a great day!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 6
        '
        'IconButton1
        '
        Me.IconButton1.ActiveColor = System.Drawing.Color.CornflowerBlue
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconType = FontAwesomeIcons.IconType.InfoCircle
        Me.IconButton1.InActiveColor = System.Drawing.SystemColors.ControlDark
        Me.IconButton1.Location = New System.Drawing.Point(3, 337)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(24, 24)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.TabStop = False
        Me.IconButton1.ToolTipText = Nothing
        '
        'StepN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsFinished = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StepN"
        Me.NextStep = "FINISHED"
        Me.PreviousStep = "Step5"
        Me.Size = New System.Drawing.Size(424, 370)
        Me.StepDescription = "Thanks for using the PCW!"
        Me.Controls.SetChildIndex(Me.Description, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.IconButton1, 0)
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton

End Class

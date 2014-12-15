<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepM
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
        Me.IconButton1 = New FontAwesomeIcons.IconButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Size = New System.Drawing.Size(578, 72)
        Me.Description.Text = "Finally, the moment that you have been waiting for is here! It's a progress bar!"
        Me.Description.UseWaitCursor = True
        '
        'IconButton1
        '
        Me.IconButton1.ActiveColor = System.Drawing.SystemColors.ControlDark
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconType = FontAwesomeIcons.IconType.InfoCircle
        Me.IconButton1.InActiveColor = System.Drawing.SystemColors.ControlDark
        Me.IconButton1.Location = New System.Drawing.Point(3, 269)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(24, 24)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.TabStop = False
        Me.IconButton1.ToolTipText = Nothing
        Me.IconButton1.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 134)
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 43)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Now saving:"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(64, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(443, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please wait while your promotional is being created."
        Me.Label3.UseWaitCursor = True
        '
        'StepM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "StepM"
        Me.NextStep = "StepN"
        Me.Size = New System.Drawing.Size(594, 293)
        Me.StepDescription = "Finally, the moment that you have been waiting for is here! It's a progress bar!"
        Me.UseWaitCursor = True
        Me.Controls.SetChildIndex(Me.Description, 0)
        Me.Controls.SetChildIndex(Me.IconButton1, 0)
        Me.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

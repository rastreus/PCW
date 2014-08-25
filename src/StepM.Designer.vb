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
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Size = New System.Drawing.Size(578, 72)
        Me.Description.Text = "Finally, the moment that you have been waiting for is here! It's a progress bar!"
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
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.TabStop = False
        Me.IconButton1.ToolTipText = Nothing
        '
        'StepM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "StepM"
        Me.NextStep = "StepN"
        Me.Size = New System.Drawing.Size(594, 293)
        Me.StepDescription = "Finally, the moment that you have been waiting for is here! It's a progress bar!"
        Me.Controls.SetChildIndex(Me.Description, 0)
        Me.Controls.SetChildIndex(Me.IconButton1, 0)
        CType(Me.IconButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconButton1 As FontAwesomeIcons.IconButton

End Class

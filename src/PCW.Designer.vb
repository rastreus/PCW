<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCW
    Inherits TSWizards.BaseWizard

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
        Me.SuspendLayout
        '
        'wizardTop
        '
        Me.wizardTop.Margin = New System.Windows.Forms.Padding(2)
        Me.wizardTop.Size = New System.Drawing.Size(594, 33)
        '
        'cancel
        '
        Me.cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cancel.AutoSize = true
        Me.cancel.Location = New System.Drawing.Point(9, 8)
        Me.cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        '
        'back
        '
        Me.back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.back.AutoSize = true
        Me.back.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.back.Location = New System.Drawing.Point(415, 8)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Size = New System.Drawing.Size(75, 23)
        '
        'panelStep
        '
        Me.panelStep.AutoSize = true
        Me.panelStep.BackColor = System.Drawing.SystemColors.Control
        Me.panelStep.Location = New System.Drawing.Point(0, 35)
        Me.panelStep.Margin = New System.Windows.Forms.Padding(2)
        Me.panelStep.Padding = New System.Windows.Forms.Padding(4)
        Me.panelStep.Size = New System.Drawing.Size(594, 339)
        '
        'PCW
        '
        Me.AcceptButton = Nothing
        Me.AllowClose = TSWizards.AllowClose.Ask
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.CancelButton = Me.back
        Me.ClientSize = New System.Drawing.Size(594, 414)
        Me.FirstStepName = "Step1"
        Me.KeyPreview = true
        Me.Logo = Global.PromotionalCreationWizard.My.Resources.Resources.PCW_Logo
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(160, 139)
        Me.Name = "PCW"
        Me.SideBarImage = Global.PromotionalCreationWizard.My.Resources.Resources.PCW_SideBarImage_373
        Me.SideBarLogo = Global.PromotionalCreationWizard.My.Resources.Resources.PCW_Logo
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromotionalCreationWizard (PCW)"
        Me.Title = "PWC"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

End Class

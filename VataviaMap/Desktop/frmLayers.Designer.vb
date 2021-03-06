<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayers
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
        Me.components = New System.ComponentModel.Container
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.lblWidth = New System.Windows.Forms.Label
        Me.lblOpacity = New System.Windows.Forms.Label
        Me.txtOpacity = New System.Windows.Forms.TextBox
        Me.lblArrowSize = New System.Windows.Forms.Label
        Me.txtArrowSize = New System.Windows.Forms.TextBox
        Me.lstLayers = New System.Windows.Forms.ListView
        Me.ColumnFilename = New System.Windows.Forms.ColumnHeader
        Me.ColumnDate = New System.Windows.Forms.ColumnHeader
        Me.ColumnDuration = New System.Windows.Forms.ColumnHeader
        Me.chkAllVisible = New System.Windows.Forms.CheckBox
        Me.grpColor = New System.Windows.Forms.GroupBox
        Me.btnColorSame = New System.Windows.Forms.Button
        Me.btnColorRamp = New System.Windows.Forms.Button
        Me.btnColorRandom = New System.Windows.Forms.Button
        Me.btnColor = New System.Windows.Forms.Button
        Me.LayerGridRightContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZoomToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpLabel = New System.Windows.Forms.GroupBox
        Me.cboLayerZoom = New System.Windows.Forms.ComboBox
        Me.lblLabelMinZoom = New System.Windows.Forms.Label
        Me.lblLabelFont = New System.Windows.Forms.Label
        Me.txtLabelFont = New System.Windows.Forms.TextBox
        Me.cboLabelField = New System.Windows.Forms.ComboBox
        Me.lblLabelField = New System.Windows.Forms.Label
        Me.cboGroupField = New System.Windows.Forms.ComboBox
        Me.lblGroup = New System.Windows.Forms.Label
        Me.ZoomToStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ZoomToEndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpColor.SuspendLayout()
        Me.LayerGridRightContextMenuStrip.SuspendLayout()
        Me.grpLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWidth
        '
        Me.txtWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWidth.Location = New System.Drawing.Point(80, 604)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(28, 20)
        Me.txtWidth.TabIndex = 2
        '
        'lblWidth
        '
        Me.lblWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(10, 607)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "Width"
        '
        'lblOpacity
        '
        Me.lblOpacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOpacity.AutoSize = True
        Me.lblOpacity.Location = New System.Drawing.Point(15, 111)
        Me.lblOpacity.Name = "lblOpacity"
        Me.lblOpacity.Size = New System.Drawing.Size(43, 13)
        Me.lblOpacity.TabIndex = 5
        Me.lblOpacity.Text = "Opacity"
        '
        'txtOpacity
        '
        Me.txtOpacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOpacity.Location = New System.Drawing.Point(77, 108)
        Me.txtOpacity.Name = "txtOpacity"
        Me.txtOpacity.Size = New System.Drawing.Size(41, 20)
        Me.txtOpacity.TabIndex = 4
        '
        'lblArrowSize
        '
        Me.lblArrowSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArrowSize.AutoSize = True
        Me.lblArrowSize.Location = New System.Drawing.Point(10, 633)
        Me.lblArrowSize.Name = "lblArrowSize"
        Me.lblArrowSize.Size = New System.Drawing.Size(57, 13)
        Me.lblArrowSize.TabIndex = 7
        Me.lblArrowSize.Text = "Arrow Size"
        '
        'txtArrowSize
        '
        Me.txtArrowSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtArrowSize.Location = New System.Drawing.Point(80, 630)
        Me.txtArrowSize.Name = "txtArrowSize"
        Me.txtArrowSize.Size = New System.Drawing.Size(28, 20)
        Me.txtArrowSize.TabIndex = 6
        '
        'lstLayers
        '
        Me.lstLayers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLayers.CheckBoxes = True
        Me.lstLayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnFilename, Me.ColumnDate, Me.ColumnDuration})
        Me.lstLayers.Location = New System.Drawing.Point(0, 0)
        Me.lstLayers.Name = "lstLayers"
        Me.lstLayers.Size = New System.Drawing.Size(631, 516)
        Me.lstLayers.TabIndex = 8
        Me.lstLayers.UseCompatibleStateImageBehavior = False
        Me.lstLayers.View = System.Windows.Forms.View.Details
        '
        'ColumnFilename
        '
        Me.ColumnFilename.Text = "File Name"
        Me.ColumnFilename.Width = 506
        '
        'ColumnDate
        '
        Me.ColumnDate.Text = "Date"
        '
        'ColumnDuration
        '
        Me.ColumnDuration.Text = "Duration"
        '
        'chkAllVisible
        '
        Me.chkAllVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkAllVisible.AutoSize = True
        Me.chkAllVisible.Checked = True
        Me.chkAllVisible.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkAllVisible.Location = New System.Drawing.Point(9, 522)
        Me.chkAllVisible.Name = "chkAllVisible"
        Me.chkAllVisible.Size = New System.Drawing.Size(70, 17)
        Me.chkAllVisible.TabIndex = 12
        Me.chkAllVisible.Text = "All Visible"
        Me.chkAllVisible.UseVisualStyleBackColor = True
        '
        'grpColor
        '
        Me.grpColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpColor.Controls.Add(Me.btnColorSame)
        Me.grpColor.Controls.Add(Me.btnColorRamp)
        Me.grpColor.Controls.Add(Me.btnColorRandom)
        Me.grpColor.Controls.Add(Me.btnColor)
        Me.grpColor.Controls.Add(Me.txtOpacity)
        Me.grpColor.Controls.Add(Me.lblOpacity)
        Me.grpColor.Location = New System.Drawing.Point(125, 522)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(127, 135)
        Me.grpColor.TabIndex = 13
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'btnColorSame
        '
        Me.btnColorSame.Location = New System.Drawing.Point(6, 77)
        Me.btnColorSame.Name = "btnColorSame"
        Me.btnColorSame.Size = New System.Drawing.Size(65, 23)
        Me.btnColorSame.TabIndex = 16
        Me.btnColorSame.Text = "Same"
        Me.btnColorSame.UseVisualStyleBackColor = True
        '
        'btnColorRamp
        '
        Me.btnColorRamp.Location = New System.Drawing.Point(6, 48)
        Me.btnColorRamp.Name = "btnColorRamp"
        Me.btnColorRamp.Size = New System.Drawing.Size(65, 23)
        Me.btnColorRamp.TabIndex = 15
        Me.btnColorRamp.Text = "Ramp"
        Me.btnColorRamp.UseVisualStyleBackColor = True
        '
        'btnColorRandom
        '
        Me.btnColorRandom.Location = New System.Drawing.Point(6, 19)
        Me.btnColorRandom.Name = "btnColorRandom"
        Me.btnColorRandom.Size = New System.Drawing.Size(65, 23)
        Me.btnColorRandom.TabIndex = 14
        Me.btnColorRandom.Text = "Random"
        Me.btnColorRandom.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Cyan
        Me.btnColor.Location = New System.Drawing.Point(77, 19)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(41, 81)
        Me.btnColor.TabIndex = 13
        Me.btnColor.Text = "Set"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'LayerGridRightContextMenuStrip
        '
        Me.LayerGridRightContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToToolStripMenuItem, Me.ZoomToStartToolStripMenuItem, Me.ZoomToEndToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.LayerGridRightContextMenuStrip.Name = "LayerGridRightContextMenuStrip"
        Me.LayerGridRightContextMenuStrip.Size = New System.Drawing.Size(198, 122)
        '
        'ZoomToToolStripMenuItem
        '
        Me.ZoomToToolStripMenuItem.Name = "ZoomToToolStripMenuItem"
        Me.ZoomToToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ZoomToToolStripMenuItem.Text = "Zoom To"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'grpLabel
        '
        Me.grpLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLabel.Controls.Add(Me.cboLayerZoom)
        Me.grpLabel.Controls.Add(Me.lblLabelMinZoom)
        Me.grpLabel.Controls.Add(Me.lblLabelFont)
        Me.grpLabel.Controls.Add(Me.txtLabelFont)
        Me.grpLabel.Controls.Add(Me.cboLabelField)
        Me.grpLabel.Controls.Add(Me.lblLabelField)
        Me.grpLabel.Location = New System.Drawing.Point(258, 522)
        Me.grpLabel.Name = "grpLabel"
        Me.grpLabel.Size = New System.Drawing.Size(200, 102)
        Me.grpLabel.TabIndex = 14
        Me.grpLabel.TabStop = False
        Me.grpLabel.Text = "Label"
        '
        'cboLayerZoom
        '
        Me.cboLayerZoom.FormattingEnabled = True
        Me.cboLayerZoom.Location = New System.Drawing.Point(46, 77)
        Me.cboLayerZoom.Name = "cboLayerZoom"
        Me.cboLayerZoom.Size = New System.Drawing.Size(68, 21)
        Me.cboLayerZoom.TabIndex = 14
        '
        'lblLabelMinZoom
        '
        Me.lblLabelMinZoom.AutoSize = True
        Me.lblLabelMinZoom.Location = New System.Drawing.Point(6, 82)
        Me.lblLabelMinZoom.Name = "lblLabelMinZoom"
        Me.lblLabelMinZoom.Size = New System.Drawing.Size(34, 13)
        Me.lblLabelMinZoom.TabIndex = 13
        Me.lblLabelMinZoom.Text = "Zoom"
        '
        'lblLabelFont
        '
        Me.lblLabelFont.AutoSize = True
        Me.lblLabelFont.Location = New System.Drawing.Point(6, 54)
        Me.lblLabelFont.Name = "lblLabelFont"
        Me.lblLabelFont.Size = New System.Drawing.Size(28, 13)
        Me.lblLabelFont.TabIndex = 12
        Me.lblLabelFont.Text = "Font"
        '
        'txtLabelFont
        '
        Me.txtLabelFont.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLabelFont.Location = New System.Drawing.Point(46, 51)
        Me.txtLabelFont.Name = "txtLabelFont"
        Me.txtLabelFont.Size = New System.Drawing.Size(148, 20)
        Me.txtLabelFont.TabIndex = 11
        '
        'cboLabelField
        '
        Me.cboLabelField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLabelField.FormattingEnabled = True
        Me.cboLabelField.Location = New System.Drawing.Point(46, 19)
        Me.cboLabelField.Name = "cboLabelField"
        Me.cboLabelField.Size = New System.Drawing.Size(148, 21)
        Me.cboLabelField.TabIndex = 10
        '
        'lblLabelField
        '
        Me.lblLabelField.AutoSize = True
        Me.lblLabelField.Location = New System.Drawing.Point(6, 24)
        Me.lblLabelField.Name = "lblLabelField"
        Me.lblLabelField.Size = New System.Drawing.Size(29, 13)
        Me.lblLabelField.TabIndex = 9
        Me.lblLabelField.Text = "Field"
        '
        'cboGroupField
        '
        Me.cboGroupField.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboGroupField.FormattingEnabled = True
        Me.cboGroupField.Location = New System.Drawing.Point(304, 630)
        Me.cboGroupField.Name = "cboGroupField"
        Me.cboGroupField.Size = New System.Drawing.Size(148, 21)
        Me.cboGroupField.TabIndex = 16
        '
        'lblGroup
        '
        Me.lblGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(257, 633)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(36, 13)
        Me.lblGroup.TabIndex = 15
        Me.lblGroup.Text = "Group"
        '
        'ZoomToStartToolStripMenuItem
        '
        Me.ZoomToStartToolStripMenuItem.Name = "ZoomToStartToolStripMenuItem"
        Me.ZoomToStartToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ZoomToStartToolStripMenuItem.Text = "Zoom To Start"
        '
        'ZoomToEndToolStripMenuItem
        '
        Me.ZoomToEndToolStripMenuItem.Name = "ZoomToEndToolStripMenuItem"
        Me.ZoomToEndToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ZoomToEndToolStripMenuItem.Text = "Zoom To End"
        '
        'frmLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 669)
        Me.Controls.Add(Me.cboGroupField)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.grpLabel)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.chkAllVisible)
        Me.Controls.Add(Me.lblArrowSize)
        Me.Controls.Add(Me.txtArrowSize)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lstLayers)
        Me.Name = "frmLayers"
        Me.Text = "Layers"
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.LayerGridRightContextMenuStrip.ResumeLayout(False)
        Me.grpLabel.ResumeLayout(False)
        Me.grpLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblOpacity As System.Windows.Forms.Label
    Friend WithEvents txtOpacity As System.Windows.Forms.TextBox
    Friend WithEvents lblArrowSize As System.Windows.Forms.Label
    Friend WithEvents txtArrowSize As System.Windows.Forms.TextBox
    Friend WithEvents lstLayers As System.Windows.Forms.ListView
    Friend WithEvents ColumnFilename As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkAllVisible As System.Windows.Forms.CheckBox
    Friend WithEvents grpColor As System.Windows.Forms.GroupBox
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnColorSame As System.Windows.Forms.Button
    Friend WithEvents btnColorRamp As System.Windows.Forms.Button
    Friend WithEvents btnColorRandom As System.Windows.Forms.Button
    Friend WithEvents ColumnDuration As System.Windows.Forms.ColumnHeader
    Friend WithEvents LayerGridRightContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ZoomToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpLabel As System.Windows.Forms.GroupBox
    Friend WithEvents cboLabelField As System.Windows.Forms.ComboBox
    Friend WithEvents lblLabelField As System.Windows.Forms.Label
    Friend WithEvents lblLabelFont As System.Windows.Forms.Label
    Friend WithEvents txtLabelFont As System.Windows.Forms.TextBox
    Friend WithEvents cboLayerZoom As System.Windows.Forms.ComboBox
    Friend WithEvents lblLabelMinZoom As System.Windows.Forms.Label
    Friend WithEvents cboGroupField As System.Windows.Forms.ComboBox
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents ColumnDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ZoomToStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToEndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

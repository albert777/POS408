<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppliance
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblKwhCost = New System.Windows.Forms.Label()
        Me.txtKwhCost = New System.Windows.Forms.TextBox()
        Me.cmsCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblKwh = New System.Windows.Forms.Label()
        Me.lblHoursUsed = New System.Windows.Forms.Label()
        Me.txtKwh = New System.Windows.Forms.TextBox()
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lstAppliance = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblGallonCost = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtGallonCost = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lblDailyCost = New System.Windows.Forms.Label()
        Me.cmsCopy.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(101, 9)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(87, 13)
        Me.lblAppliance.TabIndex = 0
        Me.lblAppliance.Text = "Select Appliance"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 594)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(213, 594)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblKwhCost
        '
        Me.lblKwhCost.AutoSize = True
        Me.lblKwhCost.Location = New System.Drawing.Point(12, 153)
        Me.lblKwhCost.Name = "lblKwhCost"
        Me.lblKwhCost.Size = New System.Drawing.Size(139, 13)
        Me.lblKwhCost.TabIndex = 11
        Me.lblKwhCost.Text = "Enter Cost Per Kilowatt-hour"
        '
        'txtKwhCost
        '
        Me.txtKwhCost.ContextMenuStrip = Me.cmsCopy
        Me.txtKwhCost.Location = New System.Drawing.Point(213, 150)
        Me.txtKwhCost.MaxLength = 5
        Me.txtKwhCost.Name = "txtKwhCost"
        Me.txtKwhCost.Size = New System.Drawing.Size(100, 20)
        Me.txtKwhCost.TabIndex = 2
        Me.txtKwhCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmsCopy
        '
        Me.cmsCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
        Me.cmsCopy.Name = "ContextMenuStrip1"
        Me.cmsCopy.Size = New System.Drawing.Size(103, 26)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'lblKwh
        '
        Me.lblKwh.AutoSize = True
        Me.lblKwh.Location = New System.Drawing.Point(12, 200)
        Me.lblKwh.Name = "lblKwh"
        Me.lblKwh.Size = New System.Drawing.Size(155, 13)
        Me.lblKwh.TabIndex = 12
        Me.lblKwh.Text = "Enter Kwh Rating for Appliance"
        '
        'lblHoursUsed
        '
        Me.lblHoursUsed.AutoSize = True
        Me.lblHoursUsed.Location = New System.Drawing.Point(12, 250)
        Me.lblHoursUsed.Name = "lblHoursUsed"
        Me.lblHoursUsed.Size = New System.Drawing.Size(138, 13)
        Me.lblHoursUsed.TabIndex = 13
        Me.lblHoursUsed.Text = "Enter Hours Used That Day"
        '
        'txtKwh
        '
        Me.txtKwh.ContextMenuStrip = Me.cmsCopy
        Me.txtKwh.Location = New System.Drawing.Point(213, 197)
        Me.txtKwh.MaxLength = 5
        Me.txtKwh.Name = "txtKwh"
        Me.txtKwh.Size = New System.Drawing.Size(100, 20)
        Me.txtKwh.TabIndex = 3
        Me.txtKwh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.ContextMenuStrip = Me.cmsCopy
        Me.txtHoursUsed.Location = New System.Drawing.Point(213, 247)
        Me.txtHoursUsed.MaxLength = 5
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursUsed.TabIndex = 4
        Me.txtHoursUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(12, 507)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalCost.TabIndex = 16
        Me.lblTotalCost.Text = "Total Cost"
        '
        'lstAppliance
        '
        Me.lstAppliance.FormattingEnabled = True
        Me.lstAppliance.Items.AddRange(New Object() {"Refrigerator", "TV           ", "Space Heater", "Fan          ", "Dryer       ", "Oven       ", "Washer   "})
        Me.lstAppliance.Location = New System.Drawing.Point(88, 34)
        Me.lstAppliance.Name = "lstAppliance"
        Me.lstAppliance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstAppliance.Size = New System.Drawing.Size(120, 95)
        Me.lstAppliance.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(113, 594)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(12, 299)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(114, 13)
        Me.lblGallons.TabIndex = 14
        Me.lblGallons.Text = "Gallons of Water Used"
        '
        'lblGallonCost
        '
        Me.lblGallonCost.AutoSize = True
        Me.lblGallonCost.Location = New System.Drawing.Point(15, 336)
        Me.lblGallonCost.Name = "lblGallonCost"
        Me.lblGallonCost.Size = New System.Drawing.Size(83, 13)
        Me.lblGallonCost.TabIndex = 15
        Me.lblGallonCost.Text = "Price Per Gallon"
        '
        'txtGallons
        '
        Me.txtGallons.ContextMenuStrip = Me.cmsCopy
        Me.txtGallons.Location = New System.Drawing.Point(213, 296)
        Me.txtGallons.MaxLength = 5
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 5
        Me.txtGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGallonCost
        '
        Me.txtGallonCost.ContextMenuStrip = Me.cmsCopy
        Me.txtGallonCost.Location = New System.Drawing.Point(213, 333)
        Me.txtGallonCost.MaxLength = 5
        Me.txtGallonCost.Name = "txtGallonCost"
        Me.txtGallonCost.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonCost.TabIndex = 6
        Me.txtGallonCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstOutput
        '
        Me.lstOutput.ContextMenuStrip = Me.cmsCopy
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(3, 386)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstOutput.Size = New System.Drawing.Size(317, 108)
        Me.lstOutput.TabIndex = 17
        '
        'lblDailyCost
        '
        Me.lblDailyCost.AutoSize = True
        Me.lblDailyCost.Location = New System.Drawing.Point(11, 543)
        Me.lblDailyCost.Name = "lblDailyCost"
        Me.lblDailyCost.Size = New System.Drawing.Size(54, 13)
        Me.lblDailyCost.TabIndex = 18
        Me.lblDailyCost.Text = "Daily Cost"
        '
        'frmAppliance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(321, 644)
        Me.Controls.Add(Me.lblDailyCost)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtGallonCost)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblGallonCost)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstAppliance)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtHoursUsed)
        Me.Controls.Add(Me.txtKwh)
        Me.Controls.Add(Me.lblHoursUsed)
        Me.Controls.Add(Me.lblKwh)
        Me.Controls.Add(Me.txtKwhCost)
        Me.Controls.Add(Me.lblKwhCost)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAppliance)
        Me.Name = "frmAppliance"
        Me.Text = "Appliance Calculator"
        Me.cmsCopy.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblKwhCost As System.Windows.Forms.Label
    Friend WithEvents txtKwhCost As System.Windows.Forms.TextBox
    Friend WithEvents lblKwh As System.Windows.Forms.Label
    Friend WithEvents lblHoursUsed As System.Windows.Forms.Label
    Friend WithEvents txtKwh As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lstAppliance As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents lblGallonCost As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtGallonCost As System.Windows.Forms.TextBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents lblDailyCost As System.Windows.Forms.Label
    Friend WithEvents cmsCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

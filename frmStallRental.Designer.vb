<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStallRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStallRental))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picStallRental = New System.Windows.Forms.PictureBox()
        Me.lblCostPerDay = New System.Windows.Forms.Label()
        Me.lblNumberOfRentalDays = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblTotalCostOfRental = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picStallRental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.lblHeading)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 65)
        Me.Panel1.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DimGray
        Me.lblHeading.Location = New System.Drawing.Point(265, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(234, 45)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Stall Rental"
        '
        'picStallRental
        '
        Me.picStallRental.Image = Global.Stall_Rental.My.Resources.Resources.jeet_dhanoa_v2rAOFSvR9M_unsplash
        Me.picStallRental.Location = New System.Drawing.Point(0, 65)
        Me.picStallRental.Name = "picStallRental"
        Me.picStallRental.Size = New System.Drawing.Size(345, 405)
        Me.picStallRental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStallRental.TabIndex = 1
        Me.picStallRental.TabStop = False
        '
        'lblCostPerDay
        '
        Me.lblCostPerDay.AutoSize = True
        Me.lblCostPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerDay.Location = New System.Drawing.Point(504, 78)
        Me.lblCostPerDay.Name = "lblCostPerDay"
        Me.lblCostPerDay.Size = New System.Drawing.Size(157, 25)
        Me.lblCostPerDay.TabIndex = 2
        Me.lblCostPerDay.Text = "$XX.XX per Day"
        '
        'lblNumberOfRentalDays
        '
        Me.lblNumberOfRentalDays.AutoSize = True
        Me.lblNumberOfRentalDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfRentalDays.Location = New System.Drawing.Point(367, 135)
        Me.lblNumberOfRentalDays.Name = "lblNumberOfRentalDays"
        Me.lblNumberOfRentalDays.Size = New System.Drawing.Size(237, 23)
        Me.lblNumberOfRentalDays.TabIndex = 3
        Me.lblNumberOfRentalDays.Text = "Number of Rental Days"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(631, 135)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(100, 32)
        Me.txtNumberOfDays.TabIndex = 4
        '
        'lblTotalCostOfRental
        '
        Me.lblTotalCostOfRental.AutoSize = True
        Me.lblTotalCostOfRental.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOfRental.Location = New System.Drawing.Point(367, 204)
        Me.lblTotalCostOfRental.Name = "lblTotalCostOfRental"
        Me.lblTotalCostOfRental.Size = New System.Drawing.Size(248, 23)
        Me.lblTotalCostOfRental.TabIndex = 5
        Me.lblTotalCostOfRental.Text = "Total Cost of Stall Rental"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(627, 204)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(81, 23)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$888.00"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Gold
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(391, 286)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(139, 61)
        Me.btnCost.TabIndex = 7
        Me.btnCost.Text = "Find Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Gold
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(592, 286)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(139, 61)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gold
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(494, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 61)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmStallRental
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(765, 468)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostOfRental)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfRentalDays)
        Me.Controls.Add(Me.lblCostPerDay)
        Me.Controls.Add(Me.picStallRental)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStallRental"
        Me.Text = "Stall Rental"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picStallRental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents picStallRental As PictureBox
    Friend WithEvents lblCostPerDay As Label
    Friend WithEvents lblNumberOfRentalDays As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblTotalCostOfRental As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents btnExit As Button
End Class

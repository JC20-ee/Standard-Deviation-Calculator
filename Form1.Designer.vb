<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblstd = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInput)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter a number:"
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(38, 49)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(118, 32)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "&Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(6, 21)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(188, 22)
        Me.txtInput.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnChange)
        Me.GroupBox2.Controls.Add(Me.btnCompute)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 134)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls:"
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(38, 95)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 31)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Location = New System.Drawing.Point(38, 58)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(118, 31)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "C&hange"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Enabled = False
        Me.btnCompute.Location = New System.Drawing.Point(38, 21)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(118, 31)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblstd)
        Me.GroupBox3.Controls.Add(Me.lblMean)
        Me.GroupBox3.Controls.Add(Me.txtDisplay)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 208)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Display:"
        '
        'lblstd
        '
        Me.lblstd.AutoSize = True
        Me.lblstd.Location = New System.Drawing.Point(194, 89)
        Me.lblstd.Name = "lblstd"
        Me.lblstd.Size = New System.Drawing.Size(82, 16)
        Me.lblstd.TabIndex = 2
        Me.lblstd.Text = "Std dev: N/A"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(194, 24)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(70, 16)
        Me.lblMean.TabIndex = 1
        Me.lblMean.Text = "Mean: N/A"
        '
        'txtDisplay
        '
        Me.txtDisplay.Enabled = False
        Me.txtDisplay.Location = New System.Drawing.Point(6, 21)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(182, 178)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.Text = "index      value"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 26)
        Me.ToolStripMenuItem2.Text = "&About"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnInput
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(631, 269)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInput As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblstd As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class

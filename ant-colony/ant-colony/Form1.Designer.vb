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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.antLocX = New System.Windows.Forms.ListBox()
        Me.antLocY = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnIterate = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.cmdPath = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CumulativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(80, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 364)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(479, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(393, 364)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(80, 64)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRun.TabIndex = 2
        Me.cmdRun.Text = "run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(80, 35)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoad.TabIndex = 3
        Me.cmdLoad.Text = "load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'antLocX
        '
        Me.antLocX.FormattingEnabled = True
        Me.antLocX.ItemHeight = 16
        Me.antLocX.Location = New System.Drawing.Point(1002, 64)
        Me.antLocX.Name = "antLocX"
        Me.antLocX.Size = New System.Drawing.Size(63, 468)
        Me.antLocX.TabIndex = 4
        '
        'antLocY
        '
        Me.antLocY.FormattingEnabled = True
        Me.antLocY.ItemHeight = 16
        Me.antLocY.Location = New System.Drawing.Point(1071, 64)
        Me.antLocY.Name = "antLocY"
        Me.antLocY.Size = New System.Drawing.Size(63, 468)
        Me.antLocY.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1140, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(115, 468)
        Me.ListBox1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(1261, 64)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(115, 468)
        Me.ListBox2.TabIndex = 7
        '
        'btnIterate
        '
        Me.btnIterate.Location = New System.Drawing.Point(80, 94)
        Me.btnIterate.Name = "btnIterate"
        Me.btnIterate.Size = New System.Drawing.Size(75, 23)
        Me.btnIterate.TabIndex = 8
        Me.btnIterate.Text = "iterate"
        Me.btnIterate.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(881, 64)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(115, 468)
        Me.ListBox3.TabIndex = 9
        '
        'cmdPath
        '
        Me.cmdPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPath.Location = New System.Drawing.Point(202, 64)
        Me.cmdPath.Name = "cmdPath"
        Me.cmdPath.Size = New System.Drawing.Size(113, 23)
        Me.cmdPath.TabIndex = 10
        Me.cmdPath.Text = "show path"
        Me.cmdPath.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(202, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 22)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(881, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 22)
        Me.TextBox2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(793, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "path length"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.MoveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1519, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleToolStripMenuItem, Me.CumulativeToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'SimpleToolStripMenuItem
        '
        Me.SimpleToolStripMenuItem.Name = "SimpleToolStripMenuItem"
        Me.SimpleToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SimpleToolStripMenuItem.Text = "Simple"
        '
        'CumulativeToolStripMenuItem
        '
        Me.CumulativeToolStripMenuItem.Name = "CumulativeToolStripMenuItem"
        Me.CumulativeToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CumulativeToolStripMenuItem.Text = "Cumulative"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepositionToolStripMenuItem, Me.ProgessToolStripMenuItem})
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'RepositionToolStripMenuItem
        '
        Me.RepositionToolStripMenuItem.Name = "RepositionToolStripMenuItem"
        Me.RepositionToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RepositionToolStripMenuItem.Text = "Reposition"
        '
        'ProgessToolStripMenuItem
        '
        Me.ProgessToolStripMenuItem.Name = "ProgessToolStripMenuItem"
        Me.ProgessToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ProgessToolStripMenuItem.Text = "Progress"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdPath)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.btnIterate)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.antLocY)
        Me.Controls.Add(Me.antLocX)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents antLocX As System.Windows.Forms.ListBox
    Friend WithEvents antLocY As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnIterate As System.Windows.Forms.Button
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents cmdPath As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CumulativeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

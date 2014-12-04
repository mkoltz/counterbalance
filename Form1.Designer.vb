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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FactorNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DefineFactorButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.downButton = New System.Windows.Forms.Button()
        Me.upButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.numBlocks = New System.Windows.Forms.NumericUpDown()
        Me.NumSubjects = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.repeatSelector = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numConditions = New System.Windows.Forms.Label()
        Me.numTrialsLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.expFileBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.saveEXPfile = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBox1_increment = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numBlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeatSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 115)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(157, 160)
        Me.ListBox1.TabIndex = 1
        '
        'FactorNameTextBox
        '
        Me.FactorNameTextBox.Location = New System.Drawing.Point(16, 44)
        Me.FactorNameTextBox.Name = "FactorNameTextBox"
        Me.FactorNameTextBox.Size = New System.Drawing.Size(157, 20)
        Me.FactorNameTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Factor Name"
        '
        'DefineFactorButton
        '
        Me.DefineFactorButton.Location = New System.Drawing.Point(192, 42)
        Me.DefineFactorButton.Name = "DefineFactorButton"
        Me.DefineFactorButton.Size = New System.Drawing.Size(75, 23)
        Me.DefineFactorButton.TabIndex = 4
        Me.DefineFactorButton.Text = "Define"
        Me.DefineFactorButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Factors"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(311, 281)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Text = "Remove"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(229, 141)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(157, 134)
        Me.ListBox2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Levels"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1_increment)
        Me.GroupBox1.Controls.Add(Me.downButton)
        Me.GroupBox1.Controls.Add(Me.upButton)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.DefineFactorButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.FactorNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 315)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Factors"
        '
        'downButton
        '
        Me.downButton.Image = CType(resources.GetObject("downButton.Image"), System.Drawing.Image)
        Me.downButton.Location = New System.Drawing.Point(179, 190)
        Me.downButton.Name = "downButton"
        Me.downButton.Size = New System.Drawing.Size(25, 34)
        Me.downButton.TabIndex = 8
        Me.downButton.UseVisualStyleBackColor = True
        '
        'upButton
        '
        Me.upButton.Image = CType(resources.GetObject("upButton.Image"), System.Drawing.Image)
        Me.upButton.Location = New System.Drawing.Point(179, 141)
        Me.upButton.Name = "upButton"
        Me.upButton.Size = New System.Drawing.Size(25, 36)
        Me.upButton.TabIndex = 8
        Me.upButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(98, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(229, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(311, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.numBlocks)
        Me.GroupBox2.Controls.Add(Me.NumSubjects)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 500)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 156)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Input Files"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Base Filename"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(306, 20)
        Me.TextBox1.TabIndex = 1
        '
        'numBlocks
        '
        Me.numBlocks.Location = New System.Drawing.Point(175, 42)
        Me.numBlocks.Name = "numBlocks"
        Me.numBlocks.Size = New System.Drawing.Size(53, 20)
        Me.numBlocks.TabIndex = 11
        Me.numBlocks.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumSubjects
        '
        Me.NumSubjects.Location = New System.Drawing.Point(28, 42)
        Me.NumSubjects.Name = "NumSubjects"
        Me.NumSubjects.Size = New System.Drawing.Size(53, 20)
        Me.NumSubjects.TabIndex = 11
        Me.NumSubjects.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(140, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Number of Blocks / subject"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Number of subjects"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of unique conditions:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Select the number of times to present each unique condition:"
        '
        'repeatSelector
        '
        Me.repeatSelector.Location = New System.Drawing.Point(37, 409)
        Me.repeatSelector.Name = "repeatSelector"
        Me.repeatSelector.Size = New System.Drawing.Size(65, 20)
        Me.repeatSelector.TabIndex = 11
        Me.repeatSelector.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 450)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total number of trials:"
        '
        'numConditions
        '
        Me.numConditions.AutoSize = True
        Me.numConditions.Location = New System.Drawing.Point(37, 368)
        Me.numConditions.Name = "numConditions"
        Me.numConditions.Size = New System.Drawing.Size(13, 13)
        Me.numConditions.TabIndex = 13
        Me.numConditions.Text = "0"
        '
        'numTrialsLabel
        '
        Me.numTrialsLabel.AutoSize = True
        Me.numTrialsLabel.Location = New System.Drawing.Point(37, 467)
        Me.numTrialsLabel.Name = "numTrialsLabel"
        Me.numTrialsLabel.Size = New System.Drawing.Size(13, 13)
        Me.numTrialsLabel.TabIndex = 13
        Me.numTrialsLabel.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ImportToolStripMenuItem.Text = "Import..."
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ExportToolStripMenuItem.Text = "Export..."
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'CheckBox1_increment
        '
        Me.CheckBox1_increment.AutoSize = True
        Me.CheckBox1_increment.Location = New System.Drawing.Point(231, 284)
        Me.CheckBox1_increment.Name = "CheckBox1_increment"
        Me.CheckBox1_increment.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1_increment.TabIndex = 9
        Me.CheckBox1_increment.Text = "increment"
        Me.CheckBox1_increment.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 677)
        Me.Controls.Add(Me.numTrialsLabel)
        Me.Controls.Add(Me.numConditions)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.repeatSelector)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Experiment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numBlocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeatSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents FactorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefineFactorButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents NumSubjects As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents repeatSelector As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numConditions As System.Windows.Forms.Label
    Friend WithEvents numTrialsLabel As System.Windows.Forms.Label
    Friend WithEvents numBlocks As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents expFileBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveEXPfile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents downButton As System.Windows.Forms.Button
    Friend WithEvents upButton As System.Windows.Forms.Button
    Friend WithEvents CheckBox1_increment As System.Windows.Forms.CheckBox

End Class

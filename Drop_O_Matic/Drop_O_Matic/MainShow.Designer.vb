<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainShow
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JackPotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.TestSoftwareToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminControlToolStripMenuItem, Me.BetaToolStripMenuItem, Me.POSToolStripMenuItem, Me.JackPotToolStripMenuItem, Me.WebOnlyToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AdminControlToolStripMenuItem
        '
        Me.AdminControlToolStripMenuItem.Name = "AdminControlToolStripMenuItem"
        Me.AdminControlToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AdminControlToolStripMenuItem.Text = "Admin Control"
        '
        'BetaToolStripMenuItem
        '
        Me.BetaToolStripMenuItem.Name = "BetaToolStripMenuItem"
        Me.BetaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BetaToolStripMenuItem.Text = "Games"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.POSToolStripMenuItem.Text = "POS"
        '
        'JackPotToolStripMenuItem
        '
        Me.JackPotToolStripMenuItem.Name = "JackPotToolStripMenuItem"
        Me.JackPotToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.JackPotToolStripMenuItem.Text = "JackPot"
        '
        'WebOnlyToolStripMenuItem
        '
        Me.WebOnlyToolStripMenuItem.Name = "WebOnlyToolStripMenuItem"
        Me.WebOnlyToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.WebOnlyToolStripMenuItem.Text = "WebOnly"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteSupportToolStripMenuItem, Me.AboutMeToolStripMenuItem, Me.DataBaseToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RemoteSupportToolStripMenuItem
        '
        Me.RemoteSupportToolStripMenuItem.Name = "RemoteSupportToolStripMenuItem"
        Me.RemoteSupportToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoteSupportToolStripMenuItem.Text = "Remote Support"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AboutMeToolStripMenuItem.Text = "About Me"
        '
        'DataBaseToolStripMenuItem
        '
        Me.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem"
        Me.DataBaseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataBaseToolStripMenuItem.Text = "DataBase"
        '
        'TestSoftwareToolStripMenuItem
        '
        Me.TestSoftwareToolStripMenuItem.Name = "TestSoftwareToolStripMenuItem"
        Me.TestSoftwareToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.TestSoftwareToolStripMenuItem.Text = "Test_Software"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(631, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JackPotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestSoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents WebOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

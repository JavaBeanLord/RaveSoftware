﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Me.CustomerName = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AddAmount = New System.Windows.Forms.TextBox()
        Me.CustomerNumber = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearAddAmount = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CashOut = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Entry = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(15, 112)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(223, 47)
        Me.CustomerName.TabIndex = 0
        Me.CustomerName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "License Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "$1.00"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 60)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "$5.00"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(455, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 60)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "$10.00"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(263, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 60)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "$20.00"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(359, 190)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 60)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "$50.00"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(455, 190)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 60)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "$100.00"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AddAmount
        '
        Me.AddAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddAmount.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AddAmount.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAmount.Location = New System.Drawing.Point(263, 46)
        Me.AddAmount.Multiline = True
        Me.AddAmount.Name = "AddAmount"
        Me.AddAmount.Size = New System.Drawing.Size(282, 47)
        Me.AddAmount.TabIndex = 11
        Me.AddAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomerNumber
        '
        Me.CustomerNumber.Location = New System.Drawing.Point(18, 178)
        Me.CustomerNumber.Multiline = True
        Me.CustomerNumber.Name = "CustomerNumber"
        Me.CustomerNumber.Size = New System.Drawing.Size(220, 47)
        Me.CustomerNumber.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(394, 256)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 51)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Submit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Name"
        '
        'EmployeeName
        '
        Me.EmployeeName.Enabled = False
        Me.EmployeeName.Location = New System.Drawing.Point(15, 46)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Size = New System.Drawing.Size(223, 47)
        Me.EmployeeName.TabIndex = 14
        Me.EmployeeName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Add Cash Amount"
        '
        'ClearAddAmount
        '
        Me.ClearAddAmount.Location = New System.Drawing.Point(263, 256)
        Me.ClearAddAmount.Name = "ClearAddAmount"
        Me.ClearAddAmount.Size = New System.Drawing.Size(125, 51)
        Me.ClearAddAmount.TabIndex = 17
        Me.ClearAddAmount.Text = "Clear"
        Me.ClearAddAmount.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(18, 256)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 51)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CashOut
        '
        Me.CashOut.Location = New System.Drawing.Point(133, 256)
        Me.CashOut.Name = "CashOut"
        Me.CashOut.Size = New System.Drawing.Size(105, 51)
        Me.CashOut.TabIndex = 19
        Me.CashOut.Text = "Out"
        Me.CashOut.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip2.TabIndex = 20
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FileToolStripMenuItem.Text = "   POS File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ReportsToolStripMenuItem.Text = "    POS Reports"
        '
        'Entry
        '
        Me.Entry.Location = New System.Drawing.Point(305, 99)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(240, 20)
        Me.Entry.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Entries"
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(560, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Entry)
        Me.Controls.Add(Me.CashOut)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ClearAddAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EmployeeName)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.CustomerNumber)
        Me.Controls.Add(Me.AddAmount)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip2
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerName As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents AddAmount As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmployeeName As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClearAddAmount As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents CashOut As System.Windows.Forms.Button
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Entry As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

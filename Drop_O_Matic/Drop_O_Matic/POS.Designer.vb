<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(12, 91)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(223, 47)
        Me.CustomerName.TabIndex = 0
        Me.CustomerName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "License Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 60)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "$1.00"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 60)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "$5.00"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(452, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 60)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "$10.00"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(260, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 60)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "$20.00"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(356, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 60)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "$50.00"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(452, 169)
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
        Me.AddAmount.Location = New System.Drawing.Point(260, 25)
        Me.AddAmount.Multiline = True
        Me.AddAmount.Name = "AddAmount"
        Me.AddAmount.Size = New System.Drawing.Size(282, 47)
        Me.AddAmount.TabIndex = 11
        Me.AddAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomerNumber
        '
        Me.CustomerNumber.Location = New System.Drawing.Point(15, 157)
        Me.CustomerNumber.Multiline = True
        Me.CustomerNumber.Name = "CustomerNumber"
        Me.CustomerNumber.Size = New System.Drawing.Size(220, 47)
        Me.CustomerNumber.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(391, 235)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 51)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Submit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Name"
        '
        'EmployeeName
        '
        Me.EmployeeName.Enabled = False
        Me.EmployeeName.Location = New System.Drawing.Point(12, 25)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Size = New System.Drawing.Size(223, 47)
        Me.EmployeeName.TabIndex = 14
        Me.EmployeeName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Add Cash Amount"
        '
        'ClearAddAmount
        '
        Me.ClearAddAmount.Location = New System.Drawing.Point(260, 235)
        Me.ClearAddAmount.Name = "ClearAddAmount"
        Me.ClearAddAmount.Size = New System.Drawing.Size(125, 51)
        Me.ClearAddAmount.TabIndex = 17
        Me.ClearAddAmount.Text = "Clear"
        Me.ClearAddAmount.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(15, 235)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 51)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(130, 235)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(105, 51)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(588, 319)
        Me.Controls.Add(Me.Button9)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
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
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class

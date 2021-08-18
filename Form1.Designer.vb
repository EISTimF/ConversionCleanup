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
        Me.txt_orig = New System.Windows.Forms.TextBox()
        Me.txt_cleaned = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_orig
        '
        Me.txt_orig.AcceptsReturn = True
        Me.txt_orig.AcceptsTab = True
        Me.txt_orig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_orig.BackColor = System.Drawing.Color.White
        Me.txt_orig.Location = New System.Drawing.Point(12, 36)
        Me.txt_orig.MaxLength = 0
        Me.txt_orig.Multiline = True
        Me.txt_orig.Name = "txt_orig"
        Me.txt_orig.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_orig.Size = New System.Drawing.Size(889, 741)
        Me.txt_orig.TabIndex = 0
        '
        'txt_cleaned
        '
        Me.txt_cleaned.AcceptsReturn = True
        Me.txt_cleaned.AcceptsTab = True
        Me.txt_cleaned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cleaned.BackColor = System.Drawing.Color.White
        Me.txt_cleaned.Location = New System.Drawing.Point(901, 36)
        Me.txt_cleaned.MaxLength = 0
        Me.txt_cleaned.Multiline = True
        Me.txt_cleaned.Name = "txt_cleaned"
        Me.txt_cleaned.ReadOnly = True
        Me.txt_cleaned.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cleaned.Size = New System.Drawing.Size(889, 741)
        Me.txt_cleaned.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 500
        Me.Label1.Text = "Paste code here"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(780, 786)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cleanup Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(921, 786)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Copy Cleaned Up Code"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1802, 821)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cleaned)
        Me.Controls.Add(Me.txt_orig)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConversionCleanup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_orig As TextBox
    Friend WithEvents txt_cleaned As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

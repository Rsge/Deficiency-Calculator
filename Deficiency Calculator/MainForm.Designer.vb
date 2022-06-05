<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.MeasuredInputLabel = New System.Windows.Forms.Label()
        Me.ReferenceInputLabel = New System.Windows.Forms.Label()
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.ReferenceInputTxt = New System.Windows.Forms.TextBox()
        Me.MeasuredInputTxt = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(12, 65)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(295, 37)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Calculate"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'MeasuredInputLabel
        '
        Me.MeasuredInputLabel.AutoSize = True
        Me.MeasuredInputLabel.Location = New System.Drawing.Point(3, -3)
        Me.MeasuredInputLabel.Name = "MeasuredInputLabel"
        Me.MeasuredInputLabel.Size = New System.Drawing.Size(114, 20)
        Me.MeasuredInputLabel.TabIndex = 1
        Me.MeasuredInputLabel.Text = "Measured Value"
        '
        'ReferenceInputLabel
        '
        Me.ReferenceInputLabel.AutoSize = True
        Me.ReferenceInputLabel.Location = New System.Drawing.Point(3, -3)
        Me.ReferenceInputLabel.Name = "ReferenceInputLabel"
        Me.ReferenceInputLabel.Size = New System.Drawing.Size(115, 20)
        Me.ReferenceInputLabel.TabIndex = 2
        Me.ReferenceInputLabel.Text = "Reference Value"
        '
        'OutputTxt
        '
        Me.OutputTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutputTxt.Location = New System.Drawing.Point(12, 108)
        Me.OutputTxt.Multiline = True
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.ReadOnly = True
        Me.OutputTxt.Size = New System.Drawing.Size(295, 111)
        Me.OutputTxt.TabIndex = 4
        Me.OutputTxt.Text = "This program calculates the error of a measured value with a reference value usin" &
    "g the following formula:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Absolute(x/y - 1) + Absolute(y/x - 1)) / 2"
        '
        'ReferenceInputTxt
        '
        Me.ReferenceInputTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReferenceInputTxt.Location = New System.Drawing.Point(0, 20)
        Me.ReferenceInputTxt.Name = "ReferenceInputTxt"
        Me.ReferenceInputTxt.Size = New System.Drawing.Size(148, 27)
        Me.ReferenceInputTxt.TabIndex = 2
        '
        'MeasuredInputTxt
        '
        Me.MeasuredInputTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MeasuredInputTxt.Location = New System.Drawing.Point(0, 20)
        Me.MeasuredInputTxt.Name = "MeasuredInputTxt"
        Me.MeasuredInputTxt.Size = New System.Drawing.Size(143, 27)
        Me.MeasuredInputTxt.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MeasuredInputTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MeasuredInputLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReferenceInputTxt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReferenceInputLabel)
        Me.SplitContainer1.Size = New System.Drawing.Size(295, 47)
        Me.SplitContainer1.SplitterDistance = 143
        Me.SplitContainer1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 231)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.OutputTxt)
        Me.Controls.Add(Me.StartButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Deficiency Calculator"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents MeasuredInputLabel As Label
    Friend WithEvents ReferenceInputLabel As Label
    Friend WithEvents OutputTxt As TextBox
    Friend WithEvents ReferenceInputTxt As TextBox
    Friend WithEvents MeasuredInputTxt As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
End Class

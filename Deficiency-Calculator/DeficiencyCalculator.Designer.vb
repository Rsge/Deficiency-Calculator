<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deficiencycalculator
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_deficiencycalculator))
        Me.lbl_in1 = New System.Windows.Forms.Label()
        Me.lbl_in2 = New System.Windows.Forms.Label()
        Me.txt_in1 = New System.Windows.Forms.TextBox()
        Me.txt_in2 = New System.Windows.Forms.TextBox()
        Me.txt_out = New System.Windows.Forms.TextBox()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_in1
        '
        resources.ApplyResources(Me.lbl_in1, "lbl_in1")
        Me.lbl_in1.Name = "lbl_in1"
        '
        'lbl_in2
        '
        resources.ApplyResources(Me.lbl_in2, "lbl_in2")
        Me.lbl_in2.Name = "lbl_in2"
        '
        'txt_in1
        '
        resources.ApplyResources(Me.txt_in1, "txt_in1")
        Me.txt_in1.Name = "txt_in1"
        '
        'txt_in2
        '
        resources.ApplyResources(Me.txt_in2, "txt_in2")
        Me.txt_in2.Name = "txt_in2"
        '
        'txt_out
        '
        Me.txt_out.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_out, "txt_out")
        Me.txt_out.Name = "txt_out"
        Me.txt_out.ReadOnly = True
        '
        'cmd_start
        '
        resources.ApplyResources(Me.cmd_start, "cmd_start")
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.UseVisualStyleBackColor = True
        '
        'frm_deficiencycalculator
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.txt_out)
        Me.Controls.Add(Me.txt_in2)
        Me.Controls.Add(Me.txt_in1)
        Me.Controls.Add(Me.lbl_in2)
        Me.Controls.Add(Me.lbl_in1)
        Me.Name = "frm_deficiencycalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_in1 As System.Windows.Forms.Label
    Friend WithEvents lbl_in2 As System.Windows.Forms.Label
    Friend WithEvents txt_in1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_in2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_out As System.Windows.Forms.TextBox
    Friend WithEvents cmd_start As System.Windows.Forms.Button

End Class

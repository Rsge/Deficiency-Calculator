<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeficiencyCalculatorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeficiencyCalculatorForm))
        Me.Input1Label = New System.Windows.Forms.Label()
        Me.Input2Label = New System.Windows.Forms.Label()
        Me.Input1Txt = New System.Windows.Forms.TextBox()
        Me.Input2Txt = New System.Windows.Forms.TextBox()
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input1Label
        '
        resources.ApplyResources(Me.Input1Label, "Input1Label")
        Me.Input1Label.Name = "Input1Label"
        '
        'Input2Label
        '
        resources.ApplyResources(Me.Input2Label, "Input2Label")
        Me.Input2Label.Name = "Input2Label"
        '
        'Input1Txt
        '
        resources.ApplyResources(Me.Input1Txt, "Input1Txt")
        Me.Input1Txt.Name = "Input1Txt"
        '
        'Input2Txt
        '
        resources.ApplyResources(Me.Input2Txt, "Input2Txt")
        Me.Input2Txt.Name = "Input2Txt"
        '
        'OutputTxt
        '
        Me.OutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.OutputTxt, "OutputTxt")
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.ReadOnly = True
        '
        'StartButton
        '
        resources.ApplyResources(Me.StartButton, "StartButton")
        Me.StartButton.Name = "StartButton"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'DeficiencyCalculatorForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.OutputTxt)
        Me.Controls.Add(Me.Input2Txt)
        Me.Controls.Add(Me.Input1Txt)
        Me.Controls.Add(Me.Input2Label)
        Me.Controls.Add(Me.Input1Label)
        Me.Name = "DeficiencyCalculatorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Input1Label As System.Windows.Forms.Label
    Friend WithEvents Input2Label As System.Windows.Forms.Label
    Friend WithEvents Input1Txt As System.Windows.Forms.TextBox
    Friend WithEvents Input2Txt As System.Windows.Forms.TextBox
    Friend WithEvents OutputTxt As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button

End Class

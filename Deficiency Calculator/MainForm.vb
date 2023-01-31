Imports System.Math

''' <summary>
''' Provides value inputs and outputs the calculation results.
''' </summary>
Public Class MainForm
    ''' <summary>
    ''' Error when nothing is input.
    ''' </summary>
    Private Shared ReadOnly _noOutputExc As String = "Without input nothing can be calculated."

    ''' <summary>
    ''' On clicking te start button, calculate deficiency.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ' Define variables.
        Dim measuredValue As Double
        Dim referencedValue As Double
        Dim out As Double
        Dim percOut As Double

        ' Get input.
        Try
            If MeasuredInputTxt.TextLength = 0 Or ReferenceInputTxt.TextLength = 0 Then
                Throw New NoNullAllowedException(_noOutputExc)
            End If

            measuredValue = CDbl(MeasuredInputTxt.Text)
            referencedValue = CDbl(ReferenceInputTxt.Text)
        Catch ex As SystemException
            OutputTxt.Text = Environment.NewLine & ex.Message
            Exit Sub
        End Try

        ' Calculate deficiency.
        out = (Abs((measuredValue / referencedValue) - 1) + Abs((referencedValue / measuredValue) - 1)) / 2
        percOut = Round(out * 100, 2)

        ' Output.
        OutputTxt.Text = $"{out}

≈

{percOut} %"
    End Sub
End Class

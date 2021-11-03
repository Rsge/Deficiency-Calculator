Imports System.Data
Imports System.Math

Public Class DeficiencyCalculatorForm
    Private Shared ReadOnly NoOutputExc As String = "Without input nothing can be calculated.;Ohne Eingabe kann nichts berechnet werden."
    Private Shared ReadOnly InvalidFormatExc As String = "Invalid conversion of string {} in type Double.;Ungültige Konvertierung von der Zeichenfolge {} in Typ Double."

    Private Sub StartButton_Click(sender As System.Object, e As System.EventArgs) Handles StartButton.Click
        Dim In1 As Double
        Dim In2 As Double
        Dim Out As Double
        Dim PercOut As Double
        Dim Txt As String()

        Try
            If (Input1Txt.Text = "") Or (Input2Txt.Text = "") Then
                Throw New NoNullAllowedException(NoOutputExc)
            End If

            If (Not IsNumeric(Input1Txt.Text) OrElse Not IsNumeric(Input2Txt.Text)) OrElse (Input1Txt.Text.Contains(".")) Then
                Throw New InvalidCastException(InvalidFormatExc.Replace("{}", Input1Txt.Text))
            ElseIf (Input2Txt.Text.Contains(".")) Then
                Throw New InvalidCastException(InvalidFormatExc.Replace("{}", Input2Txt.Text))
            End If

            In1 = Input1Txt.Text
            In2 = Input2Txt.Text
            Out = (Abs((In1 / In2) - 1) + Abs((In2 / In1) - 1)) / 2
            PercOut = Round(Out * 100, 2)

            OutputTxt.Text = vbCrLf & Out.ToString & vbCrLf & vbCrLf & "≈" & vbCrLf & vbCrLf & PercOut.ToString & " %"
        Catch ex As SystemException
            Txt = ex.Message.Split(";")
            OutputTxt.Text = vbCrLf & Txt(0) & vbCrLf & "Please use a comma for decimal numbers." & vbCrLf & vbCrLf & Txt(1) & vbCrLf & "Bitte nur mit Komma getrennte Dezimalzahlen verwenden."
        End Try
    End Sub
End Class

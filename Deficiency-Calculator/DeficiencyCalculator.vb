Imports System.Math

Public Class frm_deficiencycalculator

    Private Sub cmd_start_Click(sender As System.Object, e As System.EventArgs) Handles cmd_start.Click
        Dim in1 As Double
        Dim in2 As Double
        Dim out As Double
        Dim percout As Double

        Try
            If (txt_in1.Text = "") Or (txt_in2.Text = "") Then
                Throw New NoNullAllowedException("Without input nothing can be calculated." + vbCrLf + "Ohne Eingabe kann nichts berechnet werden.")
            End If

            If (txt_in1.Text.Contains(".")) Then
                Throw New InvalidCastException("Invalid conversion of string" + txt_in1.Text + "in type Double" + vbCrLf + "Ungültige Konvertierung von der Zeichenfolge " + txt_in1.Text + " in Typ Double")
            ElseIf (txt_in2.Text.Contains(".")) Then
                Throw New InvalidCastException("Invalid conversion of string" + txt_in2.Text + "in type Double" + vbCrLf + "Ungültige Konvertierung von der Zeichenfolge " + txt_in2.Text + " in Typ Double")
            End If

            in1 = txt_in1.Text
            in2 = txt_in2.Text
            out = (Abs((in1 / in2) - 1) + Abs((in2 / in1) - 1)) / 2
            percout = out * 100

            txt_out.Text = vbCrLf + out.ToString + vbCrLf + vbCrLf + "≈" + vbCrLf + vbCrLf + Round(percout, 2).ToString + " %"
        Catch ex As Exception
            txt_out.Text = vbCrLf + ex.Message + vbCrLf + vbCrLf + "Please only use a comma for decimal numbers" + vbCrLf + "Bitte nur mit Komma getrennte Dezimalzahlen verwenden."
        End Try
    End Sub
End Class

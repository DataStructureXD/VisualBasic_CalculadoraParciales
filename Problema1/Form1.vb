Public Class Form1

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End



    End Sub

    Private Sub iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim average As Single
        Dim exam As Integer
        Dim note1, note2, note3 As Byte

        Try
            note1 = Convert.ToInt16(txtP1.Text)
            note2 = Convert.ToInt16(txtP2.Text)
            note3 = Convert.ToInt16(txtP3.Text)

            average = (note1 + note2 + note3) / 3
            If average >= 55 Then
                MsgBox("Es posible obtener una A, B, C, D! Felicidades")
            Else
                MsgBox("Es imposible obtener una A, B, C, D!! Te quedaste")

            End If

        Catch ex As Exception
            MsgBox("Error Fatal!!!" & ex.Message)

        Finally
            txtP1.Clear()
            txtP2.Clear()
            txtP3.Clear()
            txtP1.Focus()
        End Try


    End Sub
End Class

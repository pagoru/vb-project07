Public Class Form_vb02

    Dim textBoxs() As TextBox

    Private Sub button_order_MouseUp(sender As Object, e As MouseEventArgs) Handles button_order.MouseUp
        textBoxs = {
            TextBox1, TextBox2, TextBox3, TextBox4,
            TextBox5, TextBox6, TextBox7, TextBox8
        }

        Dim orderedNumbers(8) As Double
        Dim canOrder As Boolean = True
        Dim counter As Integer = 0

        For index As Integer = 0 To 7

            Dim textBox As TextBox = textBoxs(index)
            Dim number As Integer

            textBox.BackColor = Color.White

            If Double.TryParse(textBox.Text, number) Then

                orderedNumbers(counter) = number
                counter += 1

            Else
                If textBox.Text IsNot "" Then

                    textBox.Focus()
                    textBox.BackColor = Color.Red
                    canOrder = False
                    Exit For
                End If
            End If
        Next
        counter -= 1

        If canOrder Then

            Dim newNumbers(counter) As Double
            For index As Integer = 0 To counter
                newNumbers(index) = orderedNumbers(index)
            Next

            For index As Integer = 0 To 7
                Dim textBox As TextBox = textBoxs(index)
                textBox.Text = ""
            Next

            Array.Sort(newNumbers)
            If RadioButton_ASC.Checked Then

                For index As Integer = 0 To counter
                    Dim textBox As TextBox = textBoxs(index)
                    textBox.Text = newNumbers(index)
                Next
            Else
                Array.Reverse(newNumbers)

                Dim index2 As Integer = 0
                For index As Integer = 7 - counter To 7
                    Dim textBox As TextBox = textBoxs(index)
                    textBox.Text = newNumbers(index2)
                    index2 += 1
                Next

            End If
        End If
    End Sub


    Private Sub button_div_MouseUp(sender As Object, e As MouseEventArgs) Handles button_div.MouseUp
        textBoxs = {
            TextBox1, TextBox2, TextBox3, TextBox4,
            TextBox5, TextBox6, TextBox7, TextBox8,
            TextBox9
        }

        Dim orderedNumbers(8) As Double
        Dim canOrder As Boolean = True
        Dim counter As Integer = 0

        For index As Integer = 0 To 7

            Dim textBox As TextBox = textBoxs(index)
            Dim number As Integer

            textBox.BackColor = Color.White

            If Double.TryParse(textBox.Text, number) Then

                orderedNumbers(counter) = number
                counter += 1

            Else
                If textBox.Text IsNot "" Then

                    textBox.Focus()
                    textBox.BackColor = Color.Red
                    canOrder = False
                    Exit For
                End If
            End If
        Next
        counter -= 1

        Dim number9 As Integer
        textBoxs(8).BackColor = Color.White
        If Not Double.TryParse(textBoxs(8).Text, number9) Then

            textBoxs(8).Focus()
            textBoxs(8).BackColor = Color.Red
            canOrder = False
        End If

        If canOrder Then

            Dim div_numbers As Integer = 0
            Dim newNumbers(counter) As Double
            For index As Integer = 0 To counter
                newNumbers(index) = orderedNumbers(index)
            Next

            For index As Integer = 0 To counter
                Dim textBox As TextBox = textBoxs(index)
                If (newNumbers(index) / number9) = Int(newNumbers(index) / number9) Then
                    div_numbers += 1
                End If
            Next

            lbl_div_numbers.Text = "Divisibles:" + CStr(div_numbers)

        End If

    End Sub

    Private Sub button_LastDay_MouseUp(sender As Object, e As MouseEventArgs) Handles button_LastDay.MouseUp

        Dim year As Integer
        Dim month As Integer

        TextBox_Month.BackColor = Color.White
        TextBox_Year.BackColor = Color.White

        If Double.TryParse(TextBox_Month.Text, month) Then
            If month <= 0 Or month > 12 Then
                TextBox_Month.Focus()
                TextBox_Month.BackColor = Color.Red
                Exit Sub
            End If
        Else
            TextBox_Month.Focus()
            TextBox_Month.BackColor = Color.Red
            Exit Sub
        End If

        If Double.TryParse(TextBox_Year.Text, year) Then
            If year <= 0 Then
                TextBox_Year.Focus()
                TextBox_Year.BackColor = Color.Red
                Exit Sub
            End If
        Else

            TextBox_Year.Focus()
            TextBox_Year.BackColor = Color.Red
            Exit Sub
        End If

        lbl_lastDay.Text = "Últim dia del mes..." + CStr(System.DateTime.DaysInMonth(year, month))

    End Sub
End Class

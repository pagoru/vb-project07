Public Class Form_vb03
    'Quan el botó de MessageBox es pres, permet introduir una variable,
    'sempre que no estigui buida, ja que detectarà un error.
    Private Sub Button_MessageBox_Click(sender As Object, e As EventArgs) Handles Button_MessageBox.Click
        Dim inputValue As String = InputBox("Introdueix un valor númeric")

        If inputValue Is "" Then
            Return
        ElseIf Not IsNumeric(inputValue) Then
            MsgBox("No es poden introduir valors no numerics", MsgBoxStyle.Critical)
            Return
        End If

        TextBox.Text = inputValue
    End Sub

    'Cada vegada que s'introdueix una tecla en el textbox es mira quina key s'introdueix i només
    'deixa utilitzar les tecles númeriques i la tecla d'eliminar.
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Si el botó de insertar variable es pres, comprobará que no estigui buit i comprobará la 
    'opció seleccionada en el combobox i la introduirá en la llista.
    Private Sub Button_InsertValue_Click(sender As Object, e As EventArgs) Handles Button_InsertValue.Click

        If TextBox.Text Is "" Then
            Return
        End If

        If ComboBox.Text = "Principi" Then
            ListBox.Items.Insert(0, TextBox.Text)
        ElseIf ComboBox.Text = "Final" Then
            ListBox.Items.Add(TextBox.Text)
        ElseIf ComboBox.Text = "Ordenació númerica" Then
            ListBox.Items.Add(TextBox.Text)
            order(False)
        End If

    End Sub

    'Quan el botó d'eliminar es premi, s'eliminaran tots els valors seleccionats en la llista
    Private Sub Button_DeleteSelection_Click(sender As Object, e As EventArgs) Handles Button_DeleteSelection.Click
        Dim i As Integer
        For i = 0 To ListBox.SelectedIndices.Count - 1
            ListBox.Items.RemoveAt(ListBox.SelectedIndex)
        Next

    End Sub

    'Quan el botó es premi, s'rdenará tota la llista en funció de les opcions dels dos combobox
    Private Sub Button_Order_Click(sender As Object, e As EventArgs) Handles Button_Order.Click

        If ComboBox_ASC.Text = "Ascendent" Then
            If ComboBox_ASCII.Text = "Númerica" Then
                order(False)
            Else
                ListBox.Sorted = False
            End If

        Else
            If ComboBox_ASCII.Text = "Númerica" Then
                order(True)
            Else
                ListBox.Sorted = True
            End If
        End If


    End Sub

    'Funció que permet ordenar la llista en funció de la numeració
    Private Sub order(asc As Boolean)
        Dim intList As New List(Of Integer)
        For Each item As String In ListBox.Items
            intList.Add(Integer.Parse(item))
        Next

        intList.Sort()
        If asc Then
            intList.Reverse()
        End If
        ListBox.Items.Clear()

        For Each item As Integer In intList
            ListBox.Items.Add(CStr(item))
        Next
    End Sub

    'Al premer el botó de mes informació, ens mostrará una MsgBox amb el valor mes gran de la llista,
    'el mes petit i la mitjà de tots aquests.
    Private Sub Button_Extra_Click(sender As Object, e As EventArgs) Handles Button_Extra.Click
        If ListBox.Items.Count = 0 Then
            Return
        End If

        Dim i As Integer
        Dim maxI As Integer = ListBox.Items.Count - 1

        Dim Max As Integer = 0
        Dim Min As Integer = Integer.Parse(ListBox.Items.Item(i))
        Dim Mid As Double = 0

        For i = 0 To maxI
            Dim currentInt As Integer = Integer.Parse(ListBox.Items.Item(i))
            If Max < currentInt Then
                Max = currentInt
            End If
        Next

        For i = 0 To maxI
            Dim currentInt As Integer = Integer.Parse(ListBox.Items.Item(i))
            If Min > currentInt Then
                Min = currentInt
            End If
        Next

        For i = 0 To maxI
            Mid += Integer.Parse(ListBox.Items.Item(i))
        Next
        Mid /= ListBox.Items.Count

        MsgBox("El valor mínim es: " + CStr(Min) + ", el valor máxim es: " + CStr(Max) + " i el valor mitjà es: " + CStr(Mid))
    End Sub
End Class

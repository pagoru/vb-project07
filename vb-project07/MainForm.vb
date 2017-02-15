Public Class MainFrame

    'Array que integra les vegades
    'que sha obert cada opcio
    Private times_open() As Integer = {0, 0, 0, 0, 0, 0}

    'Array que conte les dates
    'de obertura de cada
    'forumlaris
    Private dates_open() As Date = {Date.Now, Date.Now, Date.Now, Date.Now, Date.Now, Date.Now}

    'Array que conte les dates
    'de tancament de cada
    'forumlaris
    Private dates_close() As Date = {Date.Now, Date.Now, Date.Now, Date.Now, Date.Now, Date.Now}

    'Mitjana de temps que 
    'lusuari esta en cada formulari
    Private dates_average() As Integer = {0, 0, 0, 0, 0, 0}

    'Funcio que gestiona la
    'mitjana de temps que lusuari 
    'es pasa en cada formulari
    Private Sub average_time(pos As Integer, label As Label)
        dates_average(pos) = (dates_average(pos) + (((dates_close(pos) - dates_open(pos)).TotalSeconds)) / times_open(pos))
        label.Text = CStr(dates_average(pos)) + " segons de mitja"
    End Sub

    'Funcio que incrementa les
    'vegades que sobre cada
    'formulari
    Private Sub IncrementTimesOpen(pos As Integer, label As Label)
        times_open(pos) += 1
        label.Text = CStr(times_open(pos)) + " vegades obert"
    End Sub

    'Funcio que Estableix 
    'lultima hora que sha 
    'obert o tancat
    Private Sub LasTimeClosedOrOpened(pos As Integer, obert As Boolean, label As Label)
        If (obert) Then
            dates_open(pos) = Date.Now
            label.Text = "Última vegada obert" + Date.Now
            Return
        End If
        dates_close(pos) = Date.Now
        label.Text = "Última vegada tancat" + Date.Now
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb01.vb
    Private Sub Button_vb01_Click(sender As Object, e As EventArgs) Handles Button_vb01.Click
        IncrementTimesOpen(0, lbl_times_vb01)
        LasTimeClosedOrOpened(0, True, lbl_close_vb01)
        Form_vb01.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb01)
        average_time(0, lbl_average_vb01)
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb02.vb
    Private Sub Button_vb02_Click(sender As Object, e As EventArgs) Handles Button_vb02.Click
        IncrementTimesOpen(1, lbl_times_vb02)
        LasTimeClosedOrOpened(0, True, lbl_close_vb02)
        Form_vb02.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb02)
        average_time(0, lbl_average_vb02)
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb03.vb
    Private Sub Button_vb03_Click(sender As Object, e As EventArgs) Handles Button_vb03.Click
        IncrementTimesOpen(2, lbl_times_vb03)
        LasTimeClosedOrOpened(0, True, lbl_close_vb03)
        Form_vb03.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb03)
        average_time(0, lbl_average_vb03)
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb04.vb
    Private Sub Button_vb04_Click(sender As Object, e As EventArgs) Handles Button_vb04.Click
        IncrementTimesOpen(3, lbl_times_vb04)
        LasTimeClosedOrOpened(0, True, lbl_close_vb04)
        Form_vb04.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb04)
        average_time(0, lbl_average_vb04)
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb05.vb
    Private Sub Button_vb05_Click(sender As Object, e As EventArgs) Handles Button_vb05.Click
        IncrementTimesOpen(4, lbl_times_vb05)
        LasTimeClosedOrOpened(0, True, lbl_close_vb05)
        Form_vb05.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb05)
        average_time(0, lbl_average_vb05)
    End Sub

    'Botó que obre
    'el forumlari
    'Form_vb06.vb
    Private Sub Button_vb06_Click(sender As Object, e As EventArgs) Handles Button_vb06.Click
        IncrementTimesOpen(5, lbl_times_vb06)
        LasTimeClosedOrOpened(0, True, lbl_close_vb06)
        Form_vb06.ShowDialog()
        LasTimeClosedOrOpened(0, False, lbl_last_vb06)
        average_time(0, lbl_average_vb06)
    End Sub
End Class

Public Class Form3
    Sub rate()
        If TrackBar1.Value = 0 Then
            Form1.AxWindowsMediaPlayer1.settings.rate = 0.25
        ElseIf TrackBar1.Value = 1 Then
            Form1.AxWindowsMediaPlayer1.settings.rate = 0.5
        ElseIf TrackBar1.Value = 2 Then
            Form1.AxWindowsMediaPlayer1.settings.rate = 1
        ElseIf TrackBar1.Value = 3 Then
            Form1.AxWindowsMediaPlayer1.settings.rate = 2
        ElseIf TrackBar1.Value = 4 Then
            Form1.AxWindowsMediaPlayer1.settings.rate = 4
        End If
    End Sub
    Private Sub FLSCRNbtn_Click(sender As Object, e As EventArgs) Handles FLSCRNbtn.Click
        rate()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
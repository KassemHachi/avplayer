
Public Class Form1
    Dim v As String = "pause"
    Public u As Boolean = False
    Sub txt()
        Label4.Visible = True
        VLMpic.Visible = True
        Timer4.Start()
    End Sub
    Sub StopV()
        If u = True Then
            Timer1.Stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            TrackBar1.Maximum = 1
            TrackBar1.Value = 0
            PLAYbtn.Enabled = False
            PAUSEbtn.Enabled = False
            PictureBox1.Visible = True
            Label4.Text = "Stop"
            VLMpic.Image = ImageList1.Images.Item(12)
            txt()
        End If

    End Sub
    Sub PlayV()

        If u = True Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Timer1.Start()
            PictureBox1.Visible = False
            v = "play"
            PAUSEbtn.Enabled = True
            PLAYbtn.Enabled = False
            Form3.rate()
            Label4.Text = "Play"
            VLMpic.Image = ImageList1.Images.Item(10)
            txt()
        End If

    End Sub
    Sub PauseV()
        If u = True Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            v = "Pause"
            PAUSEbtn.Enabled = False
            PLAYbtn.Enabled = True
            Label4.Text = "Pause"
            VLMpic.Image = ImageList1.Images.Item(11)

            txt()
        End If

    End Sub
    Sub videoup()
        If u = True Then
            TrackBar1.Value += 5
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5
            Label4.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            VLMpic.Image = ImageList1.Images.Item(13)
            txt()
        End If
    End Sub

    Sub videodown()
        If u = True Then
            TrackBar1.Value -= 5
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5
            VLMpic.Image = ImageList1.Images.Item(13)
            Label4.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            txt()
        End If

    End Sub

    Sub volumeup()
        Try
            TrackBar2.Value += 5
            AxWindowsMediaPlayer1.settings.volume += 5
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
            volume()
        Catch ex As Exception

        End Try

    End Sub
    Sub volumedown()
        Try
            TrackBar2.Value -= 5
            AxWindowsMediaPlayer1.settings.volume -= 5
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
            volume()
        Catch ex As Exception

        End Try

    End Sub
    Sub volumemute()
        TrackBar2.Value = 0
        VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(4)
        AxWindowsMediaPlayer1.settings.volume = 0
        Label4.Text = "Mute"
        volume()
    End Sub
    Sub volume()
        If TrackBar2.Value = 0 Then
            VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(4)
            VLMpic.Image = ImageList1.Images.Item(9)
            Label4.Text = "Mute"
        ElseIf TrackBar2.Value > 0 And TrackBar2.Value < 16 Then
            VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(3)
            VLMpic.Image = ImageList1.Images.Item(8)
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
        ElseIf TrackBar2.Value > 15 And TrackBar2.Value < 46 Then
            VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(2)
            VLMpic.Image = ImageList1.Images.Item(7)
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
        ElseIf TrackBar2.Value > 45 And TrackBar2.Value < 76 Then
            VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(1)
            VLMpic.Image = ImageList1.Images.Item(6)
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
        ElseIf TrackBar2.Value > 75 Then
            VOLUMEbtn.BackgroundImage = ImageList1.Images.Item(0)
            VLMpic.Image = ImageList1.Images.Item(5)
            Label4.Text = AxWindowsMediaPlayer1.settings.volume.ToString & "%"
        End If

        VLMpic.Visible = True
        txt()
    End Sub

    Sub replay()
        If CheckBox1.Checked = True Then
            ReplayToolStripMenuItem.Checked = True
            CheckBox1.Checked = True
            Label4.Text = "Replay Active"
            VLMpic.Image = ImageList1.Images.Item(15)
            txt()
        ElseIf CheckBox1.Checked = False Then
            CheckBox1.Checked = False
            ReplayToolStripMenuItem.Checked = False
            Label4.Text = "Replay Disactive"
            VLMpic.Image = ImageList1.Images.Item(14)
            txt()
        End If
    End Sub

    Sub fullscreen()
        If Me.WindowState = FormWindowState.Normal Or GroupBox1.Visible = True Then
            Me.WindowState = FormWindowState.Maximized
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            GroupBox1.Visible = False
            AxWindowsMediaPlayer1.Size = New Size(AxWindowsMediaPlayer1.Size.Width, AxWindowsMediaPlayer1.Size.Height + 95)
            AxWindowsMediaPlayer1.Location = New Point(AxWindowsMediaPlayer1.Location.X, AxWindowsMediaPlayer1.Location.Y - 27)
            MenuStrip1.Visible = False
        ElseIf Me.WindowState = FormWindowState.Maximized And GroupBox1.Visible = False Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            GroupBox1.Visible = True
            AxWindowsMediaPlayer1.Size = New Size(AxWindowsMediaPlayer1.Size.Width, AxWindowsMediaPlayer1.Size.Height - 95)
            AxWindowsMediaPlayer1.Location = New Point(AxWindowsMediaPlayer1.Location.X, AxWindowsMediaPlayer1.Location.Y + 27)
            MenuStrip1.Visible = True

        End If

    End Sub

    Sub pauseplay()
        If v = "pause" Then
            PlayV()
            v = "play"
        ElseIf v = "play" Then
            PauseV()
            v = "pause"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StopV()
        Label4.Text = ""
        VLMpic.Visible = False
        Timer2.Start()
        Timer3.Start()
        TrackBar2.Value = My.Settings.Volume
        Form3.TrackBar1.Value = My.Settings.rate
        CheckBox1.Checked = My.Settings.replay
    End Sub

    Private Sub OPENbtn_Click(sender As Object, e As EventArgs) Handles OPENbtn.Click
        OFD.Filter = "Video and Music Files (*.asf, *.wma, *.wmv, *.wm, *.asx, *.wax, *.wvx, *.wmx, *.wpl, *.dvr-ms, *.wmd, *.avi, *.mpg, *.mpeg, *.m1v, *.mp2, *.mp3, *.mpa, *.mpe, *.m3u, *.mid, *.midi, *.rmi. *.aif, *.aifc, *.aiff, *.au, *.snd, *.wav, *.cda, *.ivf, *.wmz, *.wms, *.mov, *.m4a, *.mp4, *.m4v, *.mp4v, *.3g2, *.3gp2, *.3gp, *.3gpp, *.aac, *.adt, *.adts, *.m2ts)|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.wmz;*.wms;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts|All Files (*.*)|*.*"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            u = True
            Try
                AxWindowsMediaPlayer1.URL = OFD.FileName

            Catch ex As Exception
                MsgBox("Error opening video")
            End Try

            PlayV()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            TrackBar1.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
            TrackBar1.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PLAYbtn_Click(sender As Object, e As EventArgs) Handles PLAYbtn.Click
        PlayV()

    End Sub

    Private Sub PAUSEbtn_Click(sender As Object, e As EventArgs) Handles PAUSEbtn.Click
        PauseV()
    End Sub

    Private Sub STOPbtn_Click(sender As Object, e As EventArgs) Handles STOPbtn.Click
        If u = True Then
            StopV()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CheckBox1.Checked = True And TrackBar1.Value = TrackBar1.Maximum Then
            TrackBar1.Value = 0
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value

        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If u = True Then
            Timer1.Stop()
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value
            Label4.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            VLMpic.Image = ImageList1.Images.Item(13)
            txt()
            Timer1.Start()
        Else
            TrackBar1.Value = 0
        End If
    End Sub



    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        volume()
        AxWindowsMediaPlayer1.settings.volume = TrackBar2.Value

    End Sub

    Private Sub VOLUMEbtn_Click(sender As Object, e As EventArgs) Handles VOLUMEbtn.Click
        volumemute()
    End Sub

    Private Sub NEXTbtn_Click(sender As Object, e As EventArgs) Handles NEXTbtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.next()
        Label4.Text = "Next"
        txt()
    End Sub

    Private Sub BACKbtn_Click(sender As Object, e As EventArgs) Handles BACKbtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.previous()
        Label4.Text = "Back"
        txt()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs)
        Form2.WF()
        Diagnostics.Process.Start("https://kos-for-u.blogspot.com")
    End Sub

    Private Sub FAVORITEbtn_Click(sender As Object, e As EventArgs) Handles FAVORITEbtn.Click
        Form2.Hide()
        Form2.CheckedListBox1.Visible = True
        Form2.CheckedListBox2.Visible = False
        Form2.Text = "Favorite"
        Form2.Show()
    End Sub

    Private Sub LISTbtn_Click(sender As Object, e As EventArgs) Handles LISTbtn.Click
        With Form2
            .Hide()
            .CheckedListBox2.Visible = True
            .CheckedListBox1.Visible = False
            .Text = "List play"
            .LinkLabel1.Visible = True
            .Show()
        End With

    End Sub


    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        fullscreen()
    End Sub

    Private Sub AxWindowsMediaPlayer1_DoubleClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles AxWindowsMediaPlayer1.DoubleClickEvent
        fullscreen()
    End Sub
    Dim currentPositionString As String
    Dim durationString As String
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        AxWindowsMediaPlayer1.fullScreen = False
        AxWindowsMediaPlayer1.enableContextMenu = False
        Try

            currentPositionString = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            durationString = AxWindowsMediaPlayer1.currentMedia.durationString
            Label1.Text = currentPositionString & " / " & durationString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FLSCRNbtn_Click(sender As Object, e As EventArgs) Handles FLSCRNbtn.Click
        fullscreen()
    End Sub

    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        pauseplay()
    End Sub

    Private Sub AxWindowsMediaPlayer1_KeyDownEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_KeyDownEvent) Handles AxWindowsMediaPlayer1.KeyDownEvent
        If e.nKeyCode = Keys.Space Then
            pauseplay()
        ElseIf e.nKeyCode = Keys.Enter Then
            pauseplay()
        ElseIf e.nKeyCode = Keys.Escape And Me.WindowState = FormWindowState.Maximized Then
            fullscreen()
            PauseV()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            pauseplay()
        ElseIf e.KeyCode = Keys.Enter Then
            pauseplay()
        ElseIf e.KeyCode = Keys.Escape And Me.WindowState = FormWindowState.Maximized Then
            fullscreen()
            PauseV()
        End If
    End Sub

    Private Sub OpenMediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMediaToolStripMenuItem.Click
        OFD.Filter = "Video and Music Files (*.asf, *.wma, *.wmv, *.wm, *.asx, *.wax, *.wvx, *.wmx, *.wpl, *.dvr-ms, *.wmd, *.avi, *.mpg, *.mpeg, *.m1v, *.mp2, *.mp3, *.mpa, *.mpe, *.m3u, *.mid, *.midi, *.rmi. *.aif, *.aifc, *.aiff, *.au, *.snd, *.wav, *.cda, *.ivf, *.wmz, *.wms, *.mov, *.m4a, *.mp4, *.m4v, *.mp4v, *.3g2, *.3gp2, *.3gp, *.3gpp, *.aac, *.adt, *.adts, *.m2ts)|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.wmz;*.wms;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts|All Files (*.*)|*.*"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            u = True
            AxWindowsMediaPlayer1.URL = OFD.FileName
            PlayV()

        End If
    End Sub

    Private Sub ListPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPlayToolStripMenuItem.Click
        Form2.Show()
        Form2.CheckedListBox2.Visible = True
        Form2.CheckedListBox1.Visible = False
        Form2.Text = "List play"
        Form2.LinkLabel1.Visible = True
    End Sub

    Private Sub FavoriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FavoriteToolStripMenuItem.Click
        Form2.Show()
        Form2.CheckedListBox1.Visible = True
        Form2.CheckedListBox2.Visible = False
        Form2.Text = "Favorite"
        Form2.LinkLabel1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub PausePlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PausePlayToolStripMenuItem.Click
        pauseplay()
    End Sub

    Private Sub UpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpToolStripMenuItem.Click
        volumeup()
    End Sub

    Private Sub DownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownToolStripMenuItem.Click
        volumedown()
    End Sub

    Private Sub MuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuteToolStripMenuItem.Click
        volumemute()
    End Sub

    Private Sub ReplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplayToolStripMenuItem.Click
        replay()

    End Sub


    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        replay()
    End Sub

    Private Sub RateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RateToolStripMenuItem.Click
        Form3.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub UpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpToolStripMenuItem1.Click
        videoup()
    End Sub

    Private Sub DownToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DownToolStripMenuItem1.Click
        videodown()
    End Sub

    Private Sub Form1_FormClosed_1(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Volume = TrackBar2.Value
        My.Settings.replay = CheckBox1.Checked
        My.Settings.rate = Form3.TrackBar1.Value
        My.Settings.Save()
        'Diagnostics.Process.Start("https://goo.gl/g2xzLH")
        'Diagnostics.Process.Start("https://kos-for-u.blogspot.com")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label4.Visible = False
        VLMpic.Visible = False
        Timer4.Stop()
    End Sub
    Private Sub Form1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Me.AllowDrop = True

        Try
            AxWindowsMediaPlayer1.URL = (CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
        Catch ex As Exception
            MsgBox("Error Doing Drag/Drop")
        End Try

    End Sub
    Private Sub Form1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        Me.AllowDrop = True
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class

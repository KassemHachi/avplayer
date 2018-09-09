Public Class Form2
    Dim pth As String = My.Application.Info.DirectoryPath
    Dim s As String

    Sub WF()
        Dim w As New IO.StreamWriter(pth & "\favorite.txt")
        For i = 0 To CheckedListBox1.Items.Count - 1
            w.WriteLine(CheckedListBox1.Items.Item(i))
        Next
        w.Close()
    End Sub

    Sub RF()
        Try
            Dim lines1() As String = IO.File.ReadAllLines(pth + "\favorite.txt")
            CheckedListBox1.Items.AddRange(lines1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ADDbtn_Click(sender As Object, e As EventArgs) Handles ADDbtn.Click

        OFD.Filter = "(*.mp4 )|*.mp4" & "|(*.mp3 )|*.mp3" & "|(*.avi )|*.avi" & "|(*.m4v )|*.m4v" & "|(*.3GP )|*.3gp" & "|(*.3GPP )|*.3GPP" & "|(*.mpg )|*.mpg" & "|(*.flv )|*.flv" & "|(*.wmv )|*.wmv"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            If CheckedListBox1.Visible = True Then
                CheckedListBox1.Items.Add(OFD.FileName)
            ElseIf CheckedListBox2.Visible = True Then
                CheckedListBox2.Items.Add(OFD.FileName)
            End If

        End If
    End Sub

    Private Sub DELETbtn_Click(sender As Object, e As EventArgs) Handles DELETbtn.Click
        Try
            If Me.Text = "Favorite" Then
                For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                    CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(0))
                Next

            ElseIf Me.Text = "List play" Then
                For i = 0 To CheckedListBox2.CheckedItems.Count - 1
                    CheckedListBox2.Items.Remove(CheckedListBox2.CheckedItems(0))

                Next
            End If

        Catch ex As Exception
            MsgBox("Select a list video before delete")
        End Try

    End Sub
    Public newPlayList As WMPLib.IWMPPlaylist = Form1.AxWindowsMediaPlayer1.playlistCollection.newPlaylist("list play")

    Private Sub PLAYbtn_Click(sender As Object, e As EventArgs) Handles PLAYbtn.Click

        If CheckedListBox1.Visible = True And CheckedListBox1.CheckedItems.Count <> 0 Then
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                CheckedListBox2.Items.Add(CheckedListBox1.CheckedItems.Item(i).ToString)
                newPlayList.appendItem(Form1.AxWindowsMediaPlayer1.newMedia(CheckedListBox1.Items.Item(i).ToString))
            Next
            Form1.u = True
            Form1.AxWindowsMediaPlayer1.currentPlaylist = newPlayList
            Form1.PlayV()
            Me.Hide()
            Form1.BACKbtn.Enabled = True
            Form1.NEXTbtn.Enabled = True
        ElseIf CheckedListBox2.Visible = True And CheckedListBox2.Items.Count <> 0 Then
            For i = 0 To CheckedListBox2.Items.Count - 1

                newPlayList.appendItem(Form1.AxWindowsMediaPlayer1.newMedia(CheckedListBox2.Items.Item(i).ToString))

            Next
            Form1.u = True
            Form1.AxWindowsMediaPlayer1.currentPlaylist = newPlayList
            Form1.ReplayToolStripMenuItem.Enabled = False
            Form1.CheckBox1.Enabled = False
            Form1.PlayV()
            Me.Hide()
            Form1.BACKbtn.Enabled = True
            Form1.NEXTbtn.Enabled = True
        Else
            MsgBox("select a list video befor play")
        End If

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CheckedListBox2.Items.Clear()
        WF()

    End Sub

    Private Sub CheckedListBox1_DoubleClick(sender As Object, e As EventArgs) Handles CheckedListBox1.DoubleClick
        Try
            Form1.AxWindowsMediaPlayer1.URL = CheckedListBox1.SelectedItem
            Form1.u = True
            Form1.PlayV()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RF()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.StopV()
        newPlayList.clear()
        Form1.CheckBox1.Enabled = True
        Form1.ReplayToolStripMenuItem.Enabled = True
    End Sub
End Class
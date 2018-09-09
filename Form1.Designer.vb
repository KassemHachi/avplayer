<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.PLAYbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FLSCRNbtn = New System.Windows.Forms.Button()
        Me.NEXTbtn = New System.Windows.Forms.Button()
        Me.BACKbtn = New System.Windows.Forms.Button()
        Me.VOLUMEbtn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OPENbtn = New System.Windows.Forms.Button()
        Me.FAVORITEbtn = New System.Windows.Forms.Button()
        Me.LISTbtn = New System.Windows.Forms.Button()
        Me.STOPbtn = New System.Windows.Forms.Button()
        Me.PAUSEbtn = New System.Windows.Forms.Button()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PausePlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoScorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VLMpic = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.VLMpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.CausesValidation = False
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 27)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(641, 393)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(68, 0)
        Me.TrackBar1.Maximum = 0
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(570, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TabStop = False
        Me.TrackBar1.TickFrequency = 0
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'PLAYbtn
        '
        Me.PLAYbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PLAYbtn.BackgroundImage = CType(resources.GetObject("PLAYbtn.BackgroundImage"), System.Drawing.Image)
        Me.PLAYbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PLAYbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PLAYbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.PLAYbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.PLAYbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.PLAYbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PLAYbtn.Location = New System.Drawing.Point(6, 36)
        Me.PLAYbtn.Name = "PLAYbtn"
        Me.PLAYbtn.Size = New System.Drawing.Size(53, 46)
        Me.PLAYbtn.TabIndex = 0
        Me.PLAYbtn.TabStop = False
        Me.PLAYbtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.FLSCRNbtn)
        Me.GroupBox1.Controls.Add(Me.NEXTbtn)
        Me.GroupBox1.Controls.Add(Me.BACKbtn)
        Me.GroupBox1.Controls.Add(Me.VOLUMEbtn)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.OPENbtn)
        Me.GroupBox1.Controls.Add(Me.FAVORITEbtn)
        Me.GroupBox1.Controls.Add(Me.LISTbtn)
        Me.GroupBox1.Controls.Add(Me.STOPbtn)
        Me.GroupBox1.Controls.Add(Me.PAUSEbtn)
        Me.GroupBox1.Controls.Add(Me.PLAYbtn)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.TrackBar2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'FLSCRNbtn
        '
        Me.FLSCRNbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FLSCRNbtn.BackgroundImage = CType(resources.GetObject("FLSCRNbtn.BackgroundImage"), System.Drawing.Image)
        Me.FLSCRNbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FLSCRNbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FLSCRNbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.FLSCRNbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.FLSCRNbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.FLSCRNbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FLSCRNbtn.Location = New System.Drawing.Point(534, 36)
        Me.FLSCRNbtn.Name = "FLSCRNbtn"
        Me.FLSCRNbtn.Size = New System.Drawing.Size(53, 46)
        Me.FLSCRNbtn.TabIndex = 0
        Me.FLSCRNbtn.TabStop = False
        Me.FLSCRNbtn.UseVisualStyleBackColor = False
        '
        'NEXTbtn
        '
        Me.NEXTbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NEXTbtn.BackgroundImage = CType(resources.GetObject("NEXTbtn.BackgroundImage"), System.Drawing.Image)
        Me.NEXTbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NEXTbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NEXTbtn.Enabled = False
        Me.NEXTbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.NEXTbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.NEXTbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.NEXTbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NEXTbtn.Location = New System.Drawing.Point(238, 36)
        Me.NEXTbtn.Name = "NEXTbtn"
        Me.NEXTbtn.Size = New System.Drawing.Size(53, 46)
        Me.NEXTbtn.TabIndex = 0
        Me.NEXTbtn.TabStop = False
        Me.NEXTbtn.UseVisualStyleBackColor = False
        '
        'BACKbtn
        '
        Me.BACKbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BACKbtn.BackgroundImage = CType(resources.GetObject("BACKbtn.BackgroundImage"), System.Drawing.Image)
        Me.BACKbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BACKbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BACKbtn.Enabled = False
        Me.BACKbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BACKbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BACKbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BACKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BACKbtn.Location = New System.Drawing.Point(179, 36)
        Me.BACKbtn.Name = "BACKbtn"
        Me.BACKbtn.Size = New System.Drawing.Size(53, 46)
        Me.BACKbtn.TabIndex = 0
        Me.BACKbtn.TabStop = False
        Me.BACKbtn.UseVisualStyleBackColor = False
        '
        'VOLUMEbtn
        '
        Me.VOLUMEbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VOLUMEbtn.BackgroundImage = CType(resources.GetObject("VOLUMEbtn.BackgroundImage"), System.Drawing.Image)
        Me.VOLUMEbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VOLUMEbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VOLUMEbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.VOLUMEbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.VOLUMEbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.VOLUMEbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VOLUMEbtn.Location = New System.Drawing.Point(424, 43)
        Me.VOLUMEbtn.Name = "VOLUMEbtn"
        Me.VOLUMEbtn.Size = New System.Drawing.Size(31, 31)
        Me.VOLUMEbtn.TabIndex = 0
        Me.VOLUMEbtn.TabStop = False
        Me.VOLUMEbtn.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(461, 52)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Replay"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OPENbtn
        '
        Me.OPENbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OPENbtn.BackgroundImage = CType(resources.GetObject("OPENbtn.BackgroundImage"), System.Drawing.Image)
        Me.OPENbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OPENbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OPENbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.OPENbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.OPENbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.OPENbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OPENbtn.Location = New System.Drawing.Point(588, 36)
        Me.OPENbtn.Name = "OPENbtn"
        Me.OPENbtn.Size = New System.Drawing.Size(53, 46)
        Me.OPENbtn.TabIndex = 0
        Me.OPENbtn.TabStop = False
        Me.OPENbtn.UseVisualStyleBackColor = False
        '
        'FAVORITEbtn
        '
        Me.FAVORITEbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FAVORITEbtn.BackgroundImage = CType(resources.GetObject("FAVORITEbtn.BackgroundImage"), System.Drawing.Image)
        Me.FAVORITEbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FAVORITEbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FAVORITEbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.FAVORITEbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.FAVORITEbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.FAVORITEbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FAVORITEbtn.Location = New System.Drawing.Point(356, 36)
        Me.FAVORITEbtn.Name = "FAVORITEbtn"
        Me.FAVORITEbtn.Size = New System.Drawing.Size(53, 46)
        Me.FAVORITEbtn.TabIndex = 0
        Me.FAVORITEbtn.TabStop = False
        Me.FAVORITEbtn.UseVisualStyleBackColor = False
        '
        'LISTbtn
        '
        Me.LISTbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LISTbtn.BackgroundImage = CType(resources.GetObject("LISTbtn.BackgroundImage"), System.Drawing.Image)
        Me.LISTbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LISTbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LISTbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.LISTbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.LISTbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.LISTbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LISTbtn.Location = New System.Drawing.Point(297, 36)
        Me.LISTbtn.Name = "LISTbtn"
        Me.LISTbtn.Size = New System.Drawing.Size(53, 46)
        Me.LISTbtn.TabIndex = 0
        Me.LISTbtn.TabStop = False
        Me.LISTbtn.UseVisualStyleBackColor = False
        '
        'STOPbtn
        '
        Me.STOPbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.STOPbtn.BackgroundImage = CType(resources.GetObject("STOPbtn.BackgroundImage"), System.Drawing.Image)
        Me.STOPbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.STOPbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.STOPbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.STOPbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.STOPbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.STOPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.STOPbtn.Location = New System.Drawing.Point(120, 36)
        Me.STOPbtn.Name = "STOPbtn"
        Me.STOPbtn.Size = New System.Drawing.Size(53, 46)
        Me.STOPbtn.TabIndex = 0
        Me.STOPbtn.TabStop = False
        Me.STOPbtn.UseVisualStyleBackColor = False
        '
        'PAUSEbtn
        '
        Me.PAUSEbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PAUSEbtn.BackgroundImage = CType(resources.GetObject("PAUSEbtn.BackgroundImage"), System.Drawing.Image)
        Me.PAUSEbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PAUSEbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PAUSEbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.PAUSEbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.PAUSEbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.PAUSEbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PAUSEbtn.Location = New System.Drawing.Point(61, 36)
        Me.PAUSEbtn.Name = "PAUSEbtn"
        Me.PAUSEbtn.Size = New System.Drawing.Size(53, 46)
        Me.PAUSEbtn.TabIndex = 0
        Me.PAUSEbtn.TabStop = False
        Me.PAUSEbtn.UseVisualStyleBackColor = False
        '
        'TrackBar2
        '
        Me.TrackBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.Location = New System.Drawing.Point(437, 69)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(83, 19)
        Me.TrackBar2.TabIndex = 0
        Me.TrackBar2.TabStop = False
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar2.Value = 50
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "|"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 11)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00 / 00.00"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "58743-speaker-volume.png")
        Me.ImageList1.Images.SetKeyName(1, "58744-speaker-volume.png")
        Me.ImageList1.Images.SetKeyName(2, "58745-speaker-volume.png")
        Me.ImageList1.Images.SetKeyName(3, "58746-speaker-volume.png")
        Me.ImageList1.Images.SetKeyName(4, "58747-speaker-volume.png")
        Me.ImageList1.Images.SetKeyName(5, "58743-speaker-volume-1.png")
        Me.ImageList1.Images.SetKeyName(6, "58744-speaker-volume-1.png")
        Me.ImageList1.Images.SetKeyName(7, "58745-speaker-volume-1.png")
        Me.ImageList1.Images.SetKeyName(8, "58746-speaker-volume-1.png")
        Me.ImageList1.Images.SetKeyName(9, "58747-speaker-volume-1.png")
        Me.ImageList1.Images.SetKeyName(10, "2017-07-04_11-35-54 (2)1.png")
        Me.ImageList1.Images.SetKeyName(11, "pause-icon1.png")
        Me.ImageList1.Images.SetKeyName(12, "stop-icon1.png")
        Me.ImageList1.Images.SetKeyName(13, "2017-07-04_11-35.png")
        Me.ImageList1.Images.SetKeyName(14, "2017-07-04ljsdm1.png")
        Me.ImageList1.Images.SetKeyName(15, "ld1.png")
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        Me.Timer4.Interval = 2000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMediaToolStripMenuItem, Me.ListPlayToolStripMenuItem, Me.FavoriteToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenMediaToolStripMenuItem
        '
        Me.OpenMediaToolStripMenuItem.Name = "OpenMediaToolStripMenuItem"
        Me.OpenMediaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenMediaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OpenMediaToolStripMenuItem.Text = "Open Media"
        '
        'ListPlayToolStripMenuItem
        '
        Me.ListPlayToolStripMenuItem.Name = "ListPlayToolStripMenuItem"
        Me.ListPlayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ListPlayToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ListPlayToolStripMenuItem.Text = "List play"
        '
        'FavoriteToolStripMenuItem
        '
        Me.FavoriteToolStripMenuItem.Name = "FavoriteToolStripMenuItem"
        Me.FavoriteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FavoriteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FavoriteToolStripMenuItem.Text = "Favorite"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PausePlayToolStripMenuItem, Me.VolumeToolStripMenuItem, Me.RateToolStripMenuItem, Me.ReplayToolStripMenuItem, Me.VideoScorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'PausePlayToolStripMenuItem
        '
        Me.PausePlayToolStripMenuItem.Name = "PausePlayToolStripMenuItem"
        Me.PausePlayToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PausePlayToolStripMenuItem.Text = "Pause / Play"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem, Me.DownToolStripMenuItem, Me.MuteToolStripMenuItem})
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.VolumeToolStripMenuItem.Text = "Volume"
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UpToolStripMenuItem.Text = "Up"
        '
        'DownToolStripMenuItem
        '
        Me.DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        Me.DownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.DownToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DownToolStripMenuItem.Text = "Down"
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'RateToolStripMenuItem
        '
        Me.RateToolStripMenuItem.Name = "RateToolStripMenuItem"
        Me.RateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RateToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.RateToolStripMenuItem.Text = "Rate"
        '
        'ReplayToolStripMenuItem
        '
        Me.ReplayToolStripMenuItem.Name = "ReplayToolStripMenuItem"
        Me.ReplayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReplayToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ReplayToolStripMenuItem.Text = "Replay"
        '
        'VideoScorToolStripMenuItem
        '
        Me.VideoScorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem1, Me.DownToolStripMenuItem1})
        Me.VideoScorToolStripMenuItem.Name = "VideoScorToolStripMenuItem"
        Me.VideoScorToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.VideoScorToolStripMenuItem.Text = "video scroll"
        '
        'UpToolStripMenuItem1
        '
        Me.UpToolStripMenuItem1.Name = "UpToolStripMenuItem1"
        Me.UpToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.UpToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.UpToolStripMenuItem1.Text = "Up"
        '
        'DownToolStripMenuItem1
        '
        Me.DownToolStripMenuItem1.Name = "DownToolStripMenuItem1"
        Me.DownToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.DownToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.DownToolStripMenuItem1.Text = "Down"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SlateGray
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(57, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = " "
        Me.Label4.Visible = False
        '
        'VLMpic
        '
        Me.VLMpic.BackColor = System.Drawing.Color.SlateGray
        Me.VLMpic.Location = New System.Drawing.Point(12, 38)
        Me.VLMpic.Name = "VLMpic"
        Me.VLMpic.Size = New System.Drawing.Size(45, 45)
        Me.VLMpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VLMpic.TabIndex = 27
        Me.VLMpic.TabStop = False
        Me.VLMpic.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 420)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.VLMpic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(657, 437)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AV Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.VLMpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PLAYbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FAVORITEbtn As System.Windows.Forms.Button
    Friend WithEvents LISTbtn As System.Windows.Forms.Button
    Friend WithEvents STOPbtn As System.Windows.Forms.Button
    Friend WithEvents PAUSEbtn As System.Windows.Forms.Button
    Friend WithEvents OPENbtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents VOLUMEbtn As System.Windows.Forms.Button
    Friend WithEvents NEXTbtn As System.Windows.Forms.Button
    Friend WithEvents BACKbtn As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents FLSCRNbtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FavoriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PausePlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoScorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VLMpic As System.Windows.Forms.PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DELETbtn = New System.Windows.Forms.Button()
        Me.ADDbtn = New System.Windows.Forms.Button()
        Me.PLAYbtn = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'DELETbtn
        '
        Me.DELETbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DELETbtn.BackgroundImage = CType(resources.GetObject("DELETbtn.BackgroundImage"), System.Drawing.Image)
        Me.DELETbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DELETbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DELETbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.DELETbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.DELETbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.DELETbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DELETbtn.Location = New System.Drawing.Point(9, 402)
        Me.DELETbtn.Name = "DELETbtn"
        Me.DELETbtn.Size = New System.Drawing.Size(42, 36)
        Me.DELETbtn.TabIndex = 15
        Me.DELETbtn.UseVisualStyleBackColor = False
        '
        'ADDbtn
        '
        Me.ADDbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ADDbtn.BackgroundImage = CType(resources.GetObject("ADDbtn.BackgroundImage"), System.Drawing.Image)
        Me.ADDbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ADDbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ADDbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.ADDbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ADDbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ADDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADDbtn.Location = New System.Drawing.Point(105, 402)
        Me.ADDbtn.Name = "ADDbtn"
        Me.ADDbtn.Size = New System.Drawing.Size(42, 36)
        Me.ADDbtn.TabIndex = 16
        Me.ADDbtn.UseVisualStyleBackColor = False
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
        Me.PLAYbtn.Location = New System.Drawing.Point(57, 402)
        Me.PLAYbtn.Name = "PLAYbtn"
        Me.PLAYbtn.Size = New System.Drawing.Size(42, 36)
        Me.PLAYbtn.TabIndex = 17
        Me.PLAYbtn.UseVisualStyleBackColor = False
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 13)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(345, 379)
        Me.CheckedListBox1.TabIndex = 20
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(12, 13)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(345, 379)
        Me.CheckedListBox2.TabIndex = 21
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(295, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "stop list play"
        Me.LinkLabel1.Visible = False
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(366, 439)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.PLAYbtn)
        Me.Controls.Add(Me.ADDbtn)
        Me.Controls.Add(Me.DELETbtn)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.MaximumSize = New System.Drawing.Size(528, 521)
        Me.MinimumSize = New System.Drawing.Size(233, 336)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DELETbtn As System.Windows.Forms.Button
    Friend WithEvents ADDbtn As System.Windows.Forms.Button
    Friend WithEvents PLAYbtn As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class

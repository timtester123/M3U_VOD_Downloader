<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button_Download = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_choose_Download_path = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Download_Path = New System.Windows.Forms.TextBox()
        Me.Button_reload = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_M3U_URL = New System.Windows.Forms.TextBox()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_to_queue = New System.Windows.Forms.Button()
        Me.Button_Play = New System.Windows.Forms.Button()
        Me.CheckedListBox_Backup = New System.Windows.Forms.CheckedListBox()
        Me.Button_uncheck = New System.Windows.Forms.Button()
        Me.Button_check_all = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog_DownloadPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Download
        '
        Me.Button_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Download.Location = New System.Drawing.Point(217, 51)
        Me.Button_Download.Name = "Button_Download"
        Me.Button_Download.Size = New System.Drawing.Size(206, 30)
        Me.Button_Download.TabIndex = 1
        Me.Button_Download.Text = "Download"
        Me.Button_Download.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_choose_Download_path)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Download_Path)
        Me.GroupBox1.Controls.Add(Me.Button_reload)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_M3U_URL)
        Me.GroupBox1.Controls.Add(Me.Label_status)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 193)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button_choose_Download_path
        '
        Me.Button_choose_Download_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_choose_Download_path.Location = New System.Drawing.Point(135, 114)
        Me.Button_choose_Download_path.Name = "Button_choose_Download_path"
        Me.Button_choose_Download_path.Size = New System.Drawing.Size(537, 26)
        Me.Button_choose_Download_path.TabIndex = 15
        Me.Button_choose_Download_path.Text = "choose"
        Me.Button_choose_Download_path.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Download Path:"
        '
        'TextBox_Download_Path
        '
        Me.TextBox_Download_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_Download_Path.Location = New System.Drawing.Point(135, 82)
        Me.TextBox_Download_Path.Name = "TextBox_Download_Path"
        Me.TextBox_Download_Path.Size = New System.Drawing.Size(537, 26)
        Me.TextBox_Download_Path.TabIndex = 13
        '
        'Button_reload
        '
        Me.Button_reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_reload.Location = New System.Drawing.Point(135, 51)
        Me.Button_reload.Name = "Button_reload"
        Me.Button_reload.Size = New System.Drawing.Size(537, 28)
        Me.Button_reload.TabIndex = 10
        Me.Button_reload.Text = "load / reload"
        Me.Button_reload.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "M3U URL:"
        '
        'TextBox_M3U_URL
        '
        Me.TextBox_M3U_URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_M3U_URL.Location = New System.Drawing.Point(135, 19)
        Me.TextBox_M3U_URL.Name = "TextBox_M3U_URL"
        Me.TextBox_M3U_URL.Size = New System.Drawing.Size(537, 26)
        Me.TextBox_M3U_URL.TabIndex = 6
        '
        'Label_status
        '
        Me.Label_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_status.AutoSize = True
        Me.Label_status.BackColor = System.Drawing.Color.Transparent
        Me.Label_status.Location = New System.Drawing.Point(10, 172)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(24, 13)
        Me.Label_status.TabIndex = 4
        Me.Label_status.Text = "0 %"
        Me.Label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 146)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(660, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_to_queue)
        Me.GroupBox2.Controls.Add(Me.Button_Play)
        Me.GroupBox2.Controls.Add(Me.CheckedListBox_Backup)
        Me.GroupBox2.Controls.Add(Me.Button_uncheck)
        Me.GroupBox2.Controls.Add(Me.Button_check_all)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox_Filter)
        Me.GroupBox2.Controls.Add(Me.CheckedListBox)
        Me.GroupBox2.Controls.Add(Me.Button_Download)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 487)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Button_to_queue
        '
        Me.Button_to_queue.Enabled = False
        Me.Button_to_queue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_to_queue.Location = New System.Drawing.Point(429, 51)
        Me.Button_to_queue.Name = "Button_to_queue"
        Me.Button_to_queue.Size = New System.Drawing.Size(131, 30)
        Me.Button_to_queue.TabIndex = 10
        Me.Button_to_queue.Text = "add to queue"
        Me.Button_to_queue.UseVisualStyleBackColor = True
        '
        'Button_Play
        '
        Me.Button_Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_Play.Location = New System.Drawing.Point(566, 51)
        Me.Button_Play.Name = "Button_Play"
        Me.Button_Play.Size = New System.Drawing.Size(112, 30)
        Me.Button_Play.TabIndex = 9
        Me.Button_Play.Text = "Play / VLC"
        Me.Button_Play.UseVisualStyleBackColor = True
        '
        'CheckedListBox_Backup
        '
        Me.CheckedListBox_Backup.FormattingEnabled = True
        Me.CheckedListBox_Backup.Location = New System.Drawing.Point(773, 459)
        Me.CheckedListBox_Backup.Name = "CheckedListBox_Backup"
        Me.CheckedListBox_Backup.Size = New System.Drawing.Size(239, 49)
        Me.CheckedListBox_Backup.TabIndex = 8
        Me.CheckedListBox_Backup.Visible = False
        '
        'Button_uncheck
        '
        Me.Button_uncheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_uncheck.Location = New System.Drawing.Point(108, 51)
        Me.Button_uncheck.Name = "Button_uncheck"
        Me.Button_uncheck.Size = New System.Drawing.Size(103, 30)
        Me.Button_uncheck.TabIndex = 7
        Me.Button_uncheck.Text = "uncheck all"
        Me.Button_uncheck.UseVisualStyleBackColor = True
        '
        'Button_check_all
        '
        Me.Button_check_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button_check_all.Location = New System.Drawing.Point(10, 51)
        Me.Button_check_all.Name = "Button_check_all"
        Me.Button_check_all.Size = New System.Drawing.Size(92, 30)
        Me.Button_check_all.TabIndex = 6
        Me.Button_check_all.Text = "check all"
        Me.Button_check_all.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search:"
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox_Filter.Location = New System.Drawing.Point(79, 19)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(599, 26)
        Me.TextBox_Filter.TabIndex = 1
        '
        'CheckedListBox
        '
        Me.CheckedListBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Location = New System.Drawing.Point(3, 90)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(678, 394)
        Me.CheckedListBox.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem, Me.CheckForUpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(169, 20)
        Me.CheckForUpdateToolStripMenuItem.Text = "Check for Update on GitHub"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 711)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(700, 750)
        Me.MinimumSize = New System.Drawing.Size(700, 750)
        Me.Name = "Form1"
        Me.Text = "M3U VOD Downloader ©TimTester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button_Download As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label_status As Label
    Friend WithEvents TextBox_Filter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_check_all As Button
    Friend WithEvents Button_uncheck As Button
    Friend WithEvents CheckedListBox_Backup As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_M3U_URL As TextBox
    Friend WithEvents Button_Play As Button
    Friend WithEvents Button_reload As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_choose_Download_path As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Download_Path As TextBox
    Friend WithEvents FolderBrowserDialog_DownloadPath As FolderBrowserDialog
    Friend WithEvents Button_to_queue As Button
End Class

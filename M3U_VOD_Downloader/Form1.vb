Imports System.IO
Imports System.Net


Public Class Form1


    Public local_M3U As String = Path.GetTempPath() & "\M3U.m3u"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = Me.Text & " - v." & Application.ProductVersion


        'check for update
        check_for_update(True)

        'load settings
        load_settings()
        '

    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing

        save_settings()


    End Sub

    Private Sub save_settings()
        My.Settings.M3U_URL = TextBox_M3U_URL.Text
        My.Settings.DownloadPath = TextBox_Download_Path.Text

        My.Settings.Save()
    End Sub
    Private Sub load_settings()
        Dim M3U_URL As String = My.Settings.M3U_URL
        TextBox_M3U_URL.Text = M3U_URL
        Dim DownloadPath As String = My.Settings.DownloadPath

        If DownloadPath = "" Then
            TextBox_Download_Path.Text = Application.StartupPath()
        Else
            TextBox_Download_Path.Text = DownloadPath
        End If

        load_m3u()

    End Sub

    Private Sub Button_reload_Click(sender As Object, e As EventArgs) Handles Button_reload.Click
        load_m3u()
    End Sub

    Private Sub load_m3u()

        CheckedListBox.Items.Clear()
        CheckedListBox_Backup.Items.Clear()

        If TextBox_M3U_URL.Text <> "" Then
            M3U_URL_Download(TextBox_M3U_URL.Text)
        End If

    End Sub


    Private Sub M3U_URL_Download(ByVal M3U_URL As String)
        If M3U_URL <> "" Then
            M3U_URL = M3U_URL
            'If (M3U_URL.ToLower.Contains("m3u_plus") = False) Then
            '    MsgBox("Please use the m3u_plus file!")
            '    Exit Sub
            'End If
            M3U_downloader = New WebClient
            M3U_downloader.DownloadFileAsync(New Uri(M3U_URL), local_M3U, Stopwatch.StartNew)
        End If
    End Sub


    Public WithEvents M3U_downloader As WebClient
    Private Sub M3U_downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles M3U_downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label_status.Text = "Downloading M3U    " & e.ProgressPercentage & " %" & "    " & Math.Round(e.BytesReceived / 1000000, 2) & " MB / " & Math.Round(e.TotalBytesToReceive / 1000000, 2) & " MB" & "    " & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000) / (1024 * 1024)).ToString("0.000 MB/s")
    End Sub
    Private Sub M3U_downloader_client_DownloadCompleted() Handles M3U_downloader.DownloadFileCompleted
        fill_ListBox()
        Label_status.Text = "Downloading M3U complete"
    End Sub




    Dim URLs As New List(Of String)
    Dim Namen As New List(Of String)
    Private Sub fill_ListBox()


        If (My.Computer.FileSystem.FileExists(local_M3U)) Then

            Dim FileText As String = My.Computer.FileSystem.ReadAllText(local_M3U).Replace(vbCr, "")
            If FileText.ToLower.Contains("tvg-id=""") = False Then 'check if M3U Plus
                MsgBox("Please use the m3u_plus file!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim FileText_lines As String() = FileText.Split(vbLf)
            For index = 1 To FileText_lines.Length - 1
                Dim line1 As String = FileText_lines(index)
                If line1.ToLower.StartsWith("#extinf:") Then

                    Dim line2 As String = FileText_lines(index + 1)

                    Dim NAME As String = ""
                    Dim URL As String = ""

                    'Name
                    NAME = get_Field(line1, "tvg-name=")
                    'URL
                    URL = line2.Replace(vbCrLf, "").Replace(vbCr, "")

                    'Illegale Charakter entfernen
                    NAME = RemoveIllegalFileNameChars(NAME).Trim()

                    'Nur filme und serien
                    If URL.ToLower.Contains("/serie") Or URL.ToLower.Contains("/movie") Then

                        URLs.Add(URL)
                        Namen.Add(NAME)
                        CheckedListBox.Items.Add(NAME)
                        CheckedListBox_Backup.Items.Add(NAME)
                    End If
                Else
                    Continue For
                End If
            Next
        Else
            MsgBox("The file doesn't exists!")
        End If

    End Sub
    'Filter
    Private Sub TextBox_Filter_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Filter.TextChanged

        Dim items = From it In CheckedListBox_Backup.Items.Cast(Of Object)()
                    Where it.ToString().IndexOf(TextBox_Filter.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
        Dim matchingItemList As List(Of Object) = items.ToList()
        CheckedListBox.BeginUpdate()
        CheckedListBox.Items.Clear()
        For Each item In matchingItemList
            CheckedListBox.Items.Add(item)
        Next
        CheckedListBox.EndUpdate()
    End Sub

    Dim Downloads_URLS As New List(Of String)
    Dim Downloads_DownloadFiles As New List(Of String)
    Dim total_files As Integer
    Dim left_files As Integer
    Dim akt_file As String
    Private Sub Button_Download_Click(sender As Object, e As EventArgs) Handles Button_Download.Click



        If Button_Download.Text = "Download" Then
            'Start download
            Download(False)
        Else
            For i = 0 To Downloads_URLS.Count - 1
                Downloads_URLS.RemoveAt(0)
            Next
            For i = 0 To Downloads_DownloadFiles.Count - 1
                Downloads_DownloadFiles.RemoveAt(0)
            Next
            downloader.CancelAsync()
            downloader.Dispose()
            Button_Download.Text = "Download"
            Button_to_queue.Enabled = False

        End If

    End Sub


    Private Sub Download(ByVal add As Boolean)
        If My.Computer.FileSystem.DirectoryExists(TextBox_Download_Path.Text) = False Then
            MsgBox("Please check the download path: " & TextBox_Download_Path.Text)
            Exit Sub
        End If

        If (CheckedListBox.CheckedItems.Count > 0) Then
            Button_Download.Text = "Cancel"

            Dim new_files As Integer = 0
            For i = 0 To CheckedListBox.CheckedItems.Count - 1 'Selektierte Downloads 
                Dim name As String = CheckedListBox.CheckedItems(i).ToString()
                For x = 0 To Namen.Count - 1
                    If Namen(x) = name Then
                        Dim url As String = URLs(x)
                        Dim folder As String = TextBox_Download_Path.Text & "\" & name
                        My.Computer.FileSystem.CreateDirectory(folder)
                        Dim DownloadFile As String = folder + "\" + RemoveIllegalFileNameChars(name, "") + Path.GetExtension(url)
                        Downloads_URLS.Add(url)
                        Downloads_DownloadFiles.Add(DownloadFile)
                        new_files = new_files + 1
                        Exit For
                    End If
                Next
            Next

            If add = False Then 'only if new download
                downloader = New WebClient
                downloader.DownloadFileAsync(New Uri(Downloads_URLS(0)), Downloads_DownloadFiles(0), Stopwatch.StartNew)
                akt_file = Path.GetFileName(Downloads_DownloadFiles(0))
            End If

            total_files = Downloads_URLS.Count
            left_files = 0 + new_files




            'Uncheck all
            uncheck()

        End If
    End Sub

    Private Sub Button_to_queue_Click(sender As Object, e As EventArgs) Handles Button_to_queue.Click
        'Start download
        Download(True)
    End Sub



    Public WithEvents downloader As WebClient


    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label_status.Text = left_files & "/" & total_files & "    " & akt_file & "    " & e.ProgressPercentage & " %" & "    " & Math.Round(e.BytesReceived / 1000000, 2) & " MB / " & Math.Round(e.TotalBytesToReceive / 1000000, 2) & " MB" & "    " & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000) / (1024 * 1024)).ToString("0.000 MB/s")

    End Sub
    Private Sub client_DownloadCompleted() Handles downloader.DownloadFileCompleted
        left_files = left_files + 1
        If Downloads_URLS.Count > 0 Then
            Downloads_URLS.RemoveAt(0)
            Downloads_DownloadFiles.RemoveAt(0)
            If Downloads_URLS.Count > 0 Then
                akt_file = Path.GetFileName(Downloads_DownloadFiles(0))
                downloader.DownloadFileAsync(New Uri(Downloads_URLS(0)), Downloads_DownloadFiles(0), Stopwatch.StartNew)
            End If
        End If

        If Downloads_URLS.Count = 0 Then
            Label_status.Text = "Download complete"
            Button_Download.Text = "Download"
            Button_to_queue.Enabled = False
        End If
    End Sub



    Private Sub Button_check_all_Click(sender As Object, e As EventArgs) Handles Button_check_all.Click
        For i = 0 To CheckedListBox.Items.Count - 1 'Selektierte Downloads 
            CheckedListBox.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub Button_uncheck_Click(sender As Object, e As EventArgs) Handles Button_uncheck.Click
        uncheck()
    End Sub

    Private Sub uncheck()
        For i = 0 To CheckedListBox.Items.Count - 1 'Selektierte Downloads 
            CheckedListBox.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub Button_Play_Click(sender As Object, e As EventArgs) Handles Button_Play.Click




        If (CheckedListBox.CheckedItems.Count > 0) Then

            For i = 0 To CheckedListBox.CheckedItems.Count - 1 'Selektierte VODs 
                Dim name As String = CheckedListBox.CheckedItems(i).ToString()
                For x = 0 To Namen.Count - 1
                    If Namen(x) = name Then
                        Dim url As String = URLs(x)
                        play_VLC(url)
                        If CheckedListBox.CheckedItems.Count > 1 Then
                            MsgBox("Only the first selected VOD will be played")
                            Exit Sub
                        End If
                        Exit For
                    End If
                Next

            Next
        End If

    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Process.Start("https://timtester.in/donate/")
    End Sub



    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        check_for_update(False)
    End Sub
    Private Sub Button_choose_Download_path_Click(sender As Object, e As EventArgs) Handles Button_choose_Download_path.Click
        FolderBrowserDialog_DownloadPath.ShowDialog()
        Dim DownloadPath As String = FolderBrowserDialog_DownloadPath.SelectedPath
        TextBox_Download_Path.Text = DownloadPath
    End Sub

    Private Sub CheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox.ItemCheck
        Me.BeginInvoke(CType(Sub() ItemChecked(), MethodInvoker))
    End Sub


    Private Sub ItemChecked()

        Dim check As Boolean = False
        If Button_Download.Text = "Cancel" Then 'Download runs
            If CheckedListBox.CheckedItems.Count > 0 Then
                check = True 'enable add to queue
            End If 'If a Item is checked
        End If
        Button_to_queue.Enabled = check

    End Sub

End Class

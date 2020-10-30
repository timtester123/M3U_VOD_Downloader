Imports Microsoft.Win32

Module vlc


    Public Sub play_VLC(ByVal url As String)
        Dim VLC_PATH As String = get_VLC_PATH()
        If VLC_PATH <> "" Then
            Process.Start(VLC_PATH, url)
        End If
    End Sub

    'Get Value PATH
    Public Function get_VLC_PATH() As String

               'get VLC path

        Dim VLC_PATH As String = ""

        If My.Computer.FileSystem.FileExists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
            VLC_PATH = "C:\Program Files\VideoLAN\VLC\vlc.exe"
        End If
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe") Then
            VLC_PATH = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
        End If


        'Haken 32Bit bevorzugen in den kompilierungseinstellungen entfernen
        If VLC_PATH = "" Then
            'Read Reg Key
            Try  'Fails if not installed
                Using Key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\VideoLAN\VLC")
                    VLC_PATH = DirectCast(Key.GetValue("InstallDir"), String)
                End Using
            Catch ex As Exception
                'Fails if not installed
            End Try
        End If

        If VLC_PATH = "" Then
            MsgBox("Please install the VLC Player")
        End If


        Return (VLC_PATH)

    End Function




End Module

Imports System.IO
Imports System.Net

Module update

    Dim prog As String = "M3U_VOD_Downloader"
    Dim GitHub_version As String = ""

    Public Sub check_for_update(ByVal start As Boolean)

        Try

            Dim URL As String = "https://api.github.com/repos/timtester123/" & prog & "/releases/latest"

            'Get JSON and read latest Version
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create(URL), HttpWebRequest)
            request.UserAgent = prog
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim js As New System.Web.Script.Serialization.JavaScriptSerializer()
            Dim res = js.Deserialize(Of Dictionary(Of String, Object))(rawresp)

            'GitHub Version

            res.TryGetValue("tag_name", GitHub_version)
            If GitHub_version <> "" Then
                Dim local_version As String = Application.ProductVersion
                Dim GitHub_version_check As Integer = GitHub_version.Replace(".", "")
                Dim local_version_check As Integer = local_version.Replace(".", "")
                If GitHub_version_check > local_version_check Then 'new Version
                    If MessageBox.Show("An Update is available would you like to update to version: " & GitHub_version & " ?", "Update?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        download_update()
                    Else
                        Exit Sub
                    End If
                Else
                    If start = False Then
                        MsgBox("You are up to date :)")
                    End If
                End If
            Else
                If start = False Then
                    MsgBox("Unable to get GitHub Version")
                End If
            End If
        Catch ex As Exception
            MsgBox("Unable to check for update " & ex.Message)
        End Try

    End Sub



    Public Sub download_update()
        Dim newApp As String = Application.StartupPath & "\" & prog & "_v" & GitHub_version & ".exe"
        'download
        Dim client As New System.Net.WebClient
        client.DownloadFile("https://github.com/timtester123/" & prog & "/releases/download/" & GitHub_version & "/" & prog & ".exe", newApp)
        'start
        Process.Start(newApp)
        'end program
        MsgBox("Update to version : " & GitHub_version & " completed")
        End
    End Sub

End Module

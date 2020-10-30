Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Module functions


    'Get Value of Field
    Public Function get_Field(ByVal text As String, ByVal field As String) As String


        field = field.ToLower
        Dim ret As String
        Dim start As Integer = text.ToLower.IndexOf(field) + field.Length + 1
        Dim ende As Integer = text.ToLower.IndexOf("""", start)
        ret = text.Substring(start, ende - start)

        Return ret

    End Function



    Public Function RemoveIllegalFileNameChars(input As String, Optional replacement As String = "") As String
        'remove illegal chars
        Dim regexSearch = New String(Path.GetInvalidFileNameChars()) & New String(Path.GetInvalidPathChars())
        Dim r = New Regex(String.Format("[{0}]", Regex.Escape(regexSearch)))
        Return r.Replace(input, replacement)
    End Function



End Module

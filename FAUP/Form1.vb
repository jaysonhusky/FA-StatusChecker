Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function IsURLValid(urlinput As String)
        Dim url As New System.Uri(urlinput)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return "Online"
        Catch ex As Exception
            req = Nothing
            'Return False
            'MsgBox("Website not found. Check the url and internet connection")
            Return "Offline"
        End Try
    End Function

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        MetroLabel10.Text = IsURLValid("https://www.furaffinity.net")
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        MetroLabel9.Text = IsURLValid("http://forums.furaffinity.net")
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        MetroLabel8.Text = IsURLValid("https://a.facdn.net/dragoneer.gif")
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        MetroLabel7.Text = IsURLValid("http://d.facdn.net")
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        MetroLabel6.Text = IsURLValid("https://t.facdn.net/19140341@200-1455854296.jpg")
    End Sub
End Class

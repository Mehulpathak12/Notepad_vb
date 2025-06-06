Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class Form2
    Async Function AskOllama(prompt As String, Optional model As String = "llama3.2:latest") As Task
        Dim client As New HttpClient()
        Dim url As String = "http://localhost:11434/api/generate"
        Dim json As String = $"{{""model"":""{model}"",""prompt"":""{prompt}""}}"
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim finalResponse As New StringBuilder()
        Try

            Dim request As New HttpRequestMessage(HttpMethod.Post, url)
            request.Content = content

            ' Send with response header read option (for streaming)
            Dim response As HttpResponseMessage = Await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
            Dim stream = Await response.Content.ReadAsStreamAsync()
            Using reader As New IO.StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = Await reader.ReadLineAsync()
                    If String.IsNullOrWhiteSpace(line) Then Continue While

                    ' Parse response line-by-line
                    Dim jsonObj As JObject = JObject.Parse(line)
                    If jsonObj.ContainsKey("response") Then
                        finalResponse.Append(jsonObj("response").ToString())
                    End If
                End While
            End Using

            RichTextBox1.Text = RichTextBox1.Text & vbNewLine & "AI_Bot -> " & finalResponse.ToString().Trim() & vbNewLine
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        RichTextBox2.Visible = True
        Label2.Text = "Chat Now!"
    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RichTextBox1.Text = "" Then
            RichTextBox1.Visible = False
        End If
        Label2.Text = "Chat Now!"
        Button1.Text = "Send"
        Button2.Text = "Clear Chat"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox2.Text = "" Then
            MsgBox("Enter a Prompt Please!")
            Return
        End If
        If RichTextBox1.Visible = False Then
            RichTextBox1.Visible = True
        End If
        Dim prompt As String = RichTextBox2.Text
        RichTextBox1.Text = RichTextBox1.Text & vbNewLine & "User -> " & RichTextBox2.Text & vbNewLine
        RichTextBox2.Text = ""
        RichTextBox2.Visible = False
        Label2.Text = "Processing...!"
        AskOllama(prompt)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text = ""
    End Sub
End Class
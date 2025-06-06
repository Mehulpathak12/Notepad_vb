Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json.Linq
Public Class Form1
    Dim currentFile As String = ""
    Dim wordWrap As Boolean = False
    Public Async Function AskOllamaRT(prompt As String, Optional model As String = "llama3.2:latest") As Task
        Dim client As New HttpClient()
        Dim url As String = "http://localhost:11434/api/generate"

        ' Safely encode prompt and add "stream": true
        Dim safePrompt As String = prompt.Replace("""", "\""")
        Dim json As String = $"{{""model"":""{model}"",""prompt"":""{safePrompt}"",""stream"": true}}"
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim finalResponse As New StringBuilder()

        Try
            Dim request As New HttpRequestMessage(HttpMethod.Post, url)
            request.Content = content

            ' Send and stream the response
            Dim response As HttpResponseMessage = Await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
            Dim stream = Await response.Content.ReadAsStreamAsync()

            Using reader As New IO.StreamReader(stream)
                While Not reader.EndOfStream
                    Dim line As String = Await reader.ReadLineAsync()
                    If String.IsNullOrWhiteSpace(line) Then Continue While

                    Console.WriteLine("Line from Ollama: " & line) ' Optional debug

                    Dim jsonObj As JObject = JObject.Parse(line)
                    If jsonObj.ContainsKey("response") Then
                        finalResponse.Append(jsonObj("response").ToString())
                    End If
                End While
            End Using

            RichTextBox1.SelectedText = finalResponse.ToString().Trim()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        End Try
    End Function

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        RichTextBox1.Visible = True
        If Not RichTextBox1.Text = "" Then
            If MsgBox("Save your Current File, Before Creating New!", MsgBoxStyle.YesNo, "Save or Not!") = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                RichTextBox1.Text = ""
            Else
                RichTextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If currentFile = "" Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                currentFile = SaveFileDialog1.FileName
            Else
                Exit Sub
            End If
        End If

        Dim saveFile As New StreamWriter(currentFile)
        saveFile.Write(RichTextBox1.Text)
        saveFile.Close()
    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        RichTextBox1.Visible = False
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem1.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub BackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.WordWrap = True
        lblLineCount.Text = "Lines: "
        lblWordCount.Text = "Words: "
        lblCursorPos.Text = "Ln: 0, Col: 0"
        WordWrapToolStripMenuItem1.ForeColor = Color.Green
    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim filePath As String = SaveFileDialog1.FileName
        Dim extension As String = Path.GetExtension(filePath).ToLower()

        Try
            Select Case extension
                Case ".txt", ".doc"
                    ' Save as plain text
                    Dim saveFile As New StreamWriter(filePath)
                    saveFile.Write(RichTextBox1.Text)
                    saveFile.Close()

                Case ".rtf"
                    ' Save in RichText Format
                    RichTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText)

                Case Else
                    ' Default: save as plain text
                    Dim saveFile As New StreamWriter(filePath)
                    saveFile.Write(RichTextBox1.Text)
                    saveFile.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show("Error saving file: " & ex.Message)
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim openFile As New StreamReader(OpenFileDialog1.FileName)
        RichTextBox1.Text = openFile.ReadToEnd()
        openFile.Close()
        currentFile = OpenFileDialog1.FileName
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim saveFile As New StreamWriter(SaveFileDialog1.FileName)
            saveFile.Write(RichTextBox1.Text)
            saveFile.Close()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        UpdateStatus()
    End Sub
    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        UpdateStatus()
    End Sub
    Private Sub UpdateStatus()
        ' Line and Word Count
        Dim lines = RichTextBox1.Lines.Length
        Dim words = RichTextBox1.Text.Split(New Char() {" "c, vbLf, vbCr}, StringSplitOptions.RemoveEmptyEntries).Length
        lblLineCount.Text = "Lines: " & lines
        lblWordCount.Text = "Words: " & words

        ' Cursor Position
        Dim line = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        Dim col = RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine()
        lblCursorPos.Text = $"Ln: {line + 1}, Col: {col + 1}"
    End Sub

    Private Sub WordWrapToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem1.Click
        If wordWrap = True Then
            wordWrap = False
            WordWrapToolStripMenuItem1.ForeColor = Color.Red
        Else
            wordWrap = True
            WordWrapToolStripMenuItem1.ForeColor = Color.Green
        End If
        RichTextBox1.WordWrap = wordWrap

    End Sub

    Private Sub AISupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AISupportToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub RichTextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            If RichTextBox1.SelectionLength > 0 Then
                ContextMenuStrip1.Show(RichTextBox1, e.Location)
            End If
        End If
    End Sub

    Private Async Sub FixGrammarErrorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixGrammarErrorsToolStripMenuItem.Click
        Dim prompt As String = "You are a highly skilled editor with expertise in English grammar, punctuation, and syntax. I will provide you with a random excerpt from a book. Your task is toIdentify and correct all grammar, punctuation, and sentence structure errors without altering the original meaning or tonePreserve the original literary style and do not paraphrase unless necessary for grammatical accuracyProvide the corrected version of the text only—do not explain the corrections unless I ask for Here is the text for grammar checking:" & RichTextBox1.SelectedText
        RichTextBox1.Enabled = False
        Await AskOllamaRT(prompt)
        RichTextBox1.Enabled = True
    End Sub

    Private Async Sub SummarizeThisSelectedTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummarizeThisSelectedTextToolStripMenuItem.Click
        Dim prompt As String = "Summarize the following text in a clear and concise manner, preserving the key points and main ideas. Avoid including unnecessary details or examples. Text to summarize: " & RichTextBox1.SelectedText
        RichTextBox1.Enabled = False
        Await AskOllamaRT(prompt)
        RichTextBox1.Enabled = True
    End Sub
End Class

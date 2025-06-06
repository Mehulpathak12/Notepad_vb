Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String = "About NotePad"
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        LabelProductName.Text = "Notepad"
        LabelVersion.Text = LabelVersion.Text + "   1.01"
        LabelCopyright.Text = LabelCopyright.Text + "   Notepad Inc."
        LabelCompanyName.Text = LabelCompanyName.Text + "    NotePad Inc."
        TextBoxDescription.Text = "This App is Made in Dezyne Ecole College With ❤️"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub


End Class

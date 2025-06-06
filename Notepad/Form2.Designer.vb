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
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Button1 = New Button()
        RichTextBox2 = New RichTextBox()
        Label2 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 39)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(660, 666)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(253, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 23)
        Label1.TabIndex = 1
        Label1.Text = "Notepad ChatBot"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(578, 734)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 74)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(12, 734)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(560, 74)
        RichTextBox2.TabIndex = 4
        RichTextBox2.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 708)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 5
        Label2.Text = "Label2"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(452, 703)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 30)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 820)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(RichTextBox2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(RichTextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class

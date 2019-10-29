Public Class frmTextEditor
    'Program: Text Editor
    'Programmer: Christy Mims
    'Date: 4/26/17
    'Description: This program allows the user to add, save, and close files in a text editor.  The user is also 
    'able to make changes the open file.  The user is able To Do this through the use of a tool strip menu, an
    'open dialog box, and a text box.

    Dim file_name As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program.
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Opens a dialog box to let user to select a file to open.
        OpenFileDialog1.ShowDialog()
        file_name = OpenFileDialog1.FileName
        Me.Text = file_name

        Dim text_file() As String = IO.File.ReadAllLines(file_name)
        For index As Integer = 0 To text_file.Count - 1

            txtOutput.AppendText(text_file(index) & Environment.NewLine)
        Next

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Clears and closes the file that is opened without closing the program.
        txtOutput.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Saves entered information for the user.
        Dim myText As String = txtOutput.Text
        IO.File.WriteAllText(file_name, myText)
    End Sub

End Class

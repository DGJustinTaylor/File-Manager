'Programmer: Justin Taylor
'Date: 10/20/2018
'Date-last-edited: 10/23/2018
'Purpose: Started as a project to help with the endless clutter of .txt files, is turning into much more.
'Note: Usable only on Windows OS

Option Strict On
Option Explicit On

Public Class frmFileOrg
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Simply give my information and set defaults
        Dim defaultPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\desktop"
        Dim defaultType As String = "txt"

        txtDirectory.Text = defaultPath
        txtFileType.Text = defaultType

        slblProgInfo.Text = "Programmer: " & "Justin Taylor " & " | " & "Date: " & Today
    End Sub

    Private Sub btnFillList_Click(sender As Object, e As EventArgs) Handles btnFillList.Click
        'Fill list with desired file type from given path
        Dim filePath As String
        Dim fileType As String

        Try
            cmbFileList.Items.Clear()

            If txtDirectory.Text = "" Then
                MessageBox.Show("Directory input required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtFileType.Text = "" Then
                MessageBox.Show("File type input required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                filePath = txtDirectory.Text
                fileType = txtFileType.Text

                fileType = "." & fileType.ToLower

                GetFiles(filePath, fileType)
            End If
        Catch ex As Exception
            MessageBox.Show("Unexpected Error has occurred.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Call the read file function when clicked
        If cmbFileList.SelectedItem Is Nothing Then
            MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ReadFile(cmbFileList.SelectedItem.ToString())
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Call the editor function and open notepad
        If cmbFileList.SelectedItem Is Nothing Then
            MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            EditFile(cmbFileList.SelectedItem.ToString())
        End If

        'Code to open image files, will add to function
        'ElseIf theExtension = ".jpg" Or theExtension = ".jpeg" Or theExtension = ".png" Then
        'System.Diagnostics.Process.Start("MSPaint.exe", path)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Call the delete function and delete the selected file
        If cmbFileList.SelectedItem Is Nothing Then
            MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DeleteFile(cmbFileList.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GetFiles(ByVal path As String, ByVal fileType As String)
        'find all files of a certain type and put them in the drop down list
        Dim di As New System.IO.DirectoryInfo(path)
        Dim fi As System.IO.FileInfo

        For Each fi In di.GetFiles
            If fi.Extension = fileType Then
                cmbFileList.Items.Add(fi.FullName)
            End If
        Next

        If cmbFileList.Items.Count <> 0 Then
            cmbFileList.SelectedIndex = 0
        Else
            MessageBox.Show("No files of that type in this directory", "Zero(0) found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ReadFile(ByVal path As String)
        'Read the file
        Dim theText As String
        Dim theExtension As String

        theExtension = "." & txtFileType.Text.ToLower

        If theExtension <> ".txt" Then
            MessageBox.Show("A text file is required to read from files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            theText = My.Computer.FileSystem.ReadAllText(path)
            If theText = "" Then
                MessageBox.Show("Nothing to show", "No text", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(theText, "Text in file", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub EditFile(ByVal path As String)
        'Open the selected file using the appropriate program
        'TODO: add this functionality for all filetypes
        'Possibly use OpenFileDialog()?
        Dim theExtension As String

        theExtension = "." & txtFileType.Text.ToLower
        If theExtension <> ".txt" Then
            MessageBox.Show("Functionality for filetypes other than .txt has not yet been added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            System.Diagnostics.Process.Start("notepad.exe", path)
        End If
    End Sub

    Private Sub DeleteFile(ByVal path As String)
        Dim sure As DialogResult

        sure = MessageBox.Show("Are you sure you want to delete the selected file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If sure = DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(path)

            cmbFileList.Items.RemoveAt(cmbFileList.SelectedIndex)

            If cmbFileList.Items.Count <> 0 Then
                cmbFileList.SelectedIndex = 0
            End If

            MessageBox.Show("File deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
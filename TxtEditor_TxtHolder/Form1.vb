'Programmer: Justin Taylor
'Date: 10/20/2018
'Purpose: Started as a project to help with the endless clutter of .txt files, is turning into much more.

Option Strict On
Option Explicit On

Public Class frmFileOrg
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Simply give my information
        slblProgInfo.Text = "Programmer: " & "Justin Taylor " & " | " & "Date: " & Today
    End Sub

    Private Sub btnFillList_Click(sender As Object, e As EventArgs) Handles btnFillList.Click
        'Fill list with desired file type from given path
        Dim filePath As String
        Dim fileType As String

        cmbFileList.Items.Clear()

        If txtDirectory.Text = "" Then
            MessageBox.Show("Directory input required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtFileType.Text = "" Then
            MessageBox.Show("File type input required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            filePath = txtDirectory.Text
            fileType = txtFileType.Text

            GetFiles(filePath, fileType)
        End If
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Call the read file function when clicked
        ReadFile()
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

        cmbFileList.SelectedIndex = 0
    End Sub

    Private Sub ReadFile()
        'Read the file
        'TODO: add validation for only reading if the file type is .txt
        Dim thePath As String = cmbFileList.SelectedItem.ToString()
        Dim theText As String

        theText = My.Computer.FileSystem.ReadAllText(thePath)
        MessageBox.Show(theText, "Text in file", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

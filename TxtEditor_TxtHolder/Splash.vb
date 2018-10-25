'Programmer: Justin Taylor
'Date: 10/25/2018
'Purpose: To provide the user with information and a way to access the program

Option Strict On
Option Explicit On

Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the project information to the splash form
        lblVersion.Text = My.Application.Info.Version.ToString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Make it look like something is loading
        prgProgBar.Value += 1

        If prgProgBar.Value <= 20 Then
            lblProgress.Text = "Initializing"
        ElseIf prgProgBar.Value <= 50 Then
            lblProgress.Text = "Loading Components"
        ElseIf prgProgBar.Value <= 70 Then
            lblProgress.Text = "Please Wait"
        ElseIf prgProgBar.Value = 100 Then
            lblProgress.Text = "Thank you, press continue"
            Timer1.Dispose()
            btnContinue.Enabled = True
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Continue to the main form
        Me.Hide()
        frmMain.ShowDialog()
        Me.Close()
    End Sub


End Class
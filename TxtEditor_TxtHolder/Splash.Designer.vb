<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.prgProgBar = New System.Windows.Forms.ProgressBar()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblWarningCont = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(15, 58)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(238, 29)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version_Placeholder"
        '
        'prgProgBar
        '
        Me.prgProgBar.Location = New System.Drawing.Point(3, 391)
        Me.prgProgBar.Name = "prgProgBar"
        Me.prgProgBar.Size = New System.Drawing.Size(542, 23)
        Me.prgProgBar.TabIndex = 2
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.Location = New System.Drawing.Point(16, 97)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(276, 20)
        Me.lblWarning.TabIndex = 3
        Me.lblWarning.Text = "Warning: Improper use of product can"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWarningCont)
        Me.GroupBox1.Controls.Add(Me.lblVersion)
        Me.GroupBox1.Controls.Add(Me.lblWarning)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(341, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 190)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Manager"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(336, 346)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(140, 31)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "Placeholder"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(551, 391)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(122, 23)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblWarningCont
        '
        Me.lblWarningCont.AutoSize = True
        Me.lblWarningCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarningCont.Location = New System.Drawing.Point(16, 117)
        Me.lblWarningCont.Name = "lblWarningCont"
        Me.lblWarningCont.Size = New System.Drawing.Size(282, 20)
        Me.lblWarningCont.TabIndex = 4
        Me.lblWarningCont.Text = "cause irreparable damage to computer"
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(685, 426)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.prgProgBar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVersion As Label
    Friend WithEvents prgProgBar As ProgressBar
    Friend WithEvents lblWarning As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblProgress As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblWarningCont As Label
End Class

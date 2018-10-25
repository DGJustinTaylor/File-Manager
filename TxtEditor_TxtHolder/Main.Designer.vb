<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileOrg
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
        Me.cmbFileList = New System.Windows.Forms.ComboBox()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFillList = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.slblProgInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbFileList
        '
        Me.cmbFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileList.FormattingEnabled = True
        Me.cmbFileList.Location = New System.Drawing.Point(12, 64)
        Me.cmbFileList.Name = "cmbFileList"
        Me.cmbFileList.Size = New System.Drawing.Size(260, 21)
        Me.cmbFileList.TabIndex = 0
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(92, 12)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(180, 20)
        Me.txtDirectory.TabIndex = 1
        '
        'txtFileType
        '
        Me.txtFileType.Location = New System.Drawing.Point(92, 38)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(180, 20)
        Me.txtFileType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Directory:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File Extension:"
        '
        'btnFillList
        '
        Me.btnFillList.Location = New System.Drawing.Point(12, 91)
        Me.btnFillList.Name = "btnFillList"
        Me.btnFillList.Size = New System.Drawing.Size(120, 35)
        Me.btnFillList.TabIndex = 5
        Me.btnFillList.Text = "Fill List"
        Me.btnFillList.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblProgInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 219)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'slblProgInfo
        '
        Me.slblProgInfo.Name = "slblProgInfo"
        Me.slblProgInfo.Size = New System.Drawing.Size(120, 17)
        Me.slblProgInfo.Text = "ToolStripStatusLabel1"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(152, 91)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(120, 35)
        Me.btnRead.TabIndex = 7
        Me.btnRead.Text = "Read File"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 132)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 35)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Editor"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 173)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(260, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(152, 132)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 35)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmFileOrg
        '
        Me.AcceptButton = Me.btnFillList
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 241)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnFillList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileType)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.cmbFileList)
        Me.Name = "frmFileOrg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text File Organizer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFileList As ComboBox
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFillList As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents slblProgInfo As ToolStripStatusLabel
    Friend WithEvents btnRead As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
End Class

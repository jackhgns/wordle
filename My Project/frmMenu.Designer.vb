<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI Semibold", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(480, 449)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(157, 62)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(531, 231)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(230, 43)
        Me.txtPlayerName.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(425, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 66)
        Me.lblTitle.TabIndex = 2
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(335, 231)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(167, 37)
        Me.lblPlayerName.TabIndex = 3
        Me.lblPlayerName.Text = "Player Name"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(88, 310)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 37)
        Me.lblError.TabIndex = 4
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(213, 53)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(674, 82)
        Me.picLogo.TabIndex = 5
        Me.picLogo.TabStop = False
        '
        'frmMenu
        '
        Me.AcceptButton = Me.btnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1103, 569)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "frmMenu"
        Me.Text = "Menu | Wordle"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblError As Label
    Friend WithEvents picLogo As PictureBox
End Class

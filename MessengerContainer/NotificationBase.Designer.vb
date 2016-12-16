<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationBase
    Inherits System.Windows.Forms.Form

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotificationBase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThreadUsers = New System.Windows.Forms.Label()
        Me.CloseNotification = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You have a new Message"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 73)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ThreadUsers
        '
        Me.ThreadUsers.AutoSize = True
        Me.ThreadUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreadUsers.Location = New System.Drawing.Point(101, 32)
        Me.ThreadUsers.Name = "ThreadUsers"
        Me.ThreadUsers.Size = New System.Drawing.Size(101, 15)
        Me.ThreadUsers.TabIndex = 2
        Me.ThreadUsers.Text = "Your thread with :"
        '
        'CloseNotification
        '
        Me.CloseNotification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CloseNotification.BackColor = System.Drawing.Color.Transparent
        Me.CloseNotification.FlatAppearance.BorderSize = 0
        Me.CloseNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseNotification.Location = New System.Drawing.Point(341, 4)
        Me.CloseNotification.Name = "CloseNotification"
        Me.CloseNotification.Size = New System.Drawing.Size(31, 25)
        Me.CloseNotification.TabIndex = 3
        Me.CloseNotification.Text = "X"
        Me.CloseNotification.UseVisualStyleBackColor = False
        '
        'NotificationBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 109)
        Me.Controls.Add(Me.CloseNotification)
        Me.Controls.Add(Me.ThreadUsers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NotificationBase"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ThreadUsers As Label
    Friend WithEvents CloseNotification As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Messenger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Messenger))
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.WebControl2 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.NotificationCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'WebControl1
        '
        Me.WebControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl1.Location = New System.Drawing.Point(0, 0)
        Me.WebControl1.Size = New System.Drawing.Size(1264, 681)
        Me.WebControl1.Source = New System.Uri("http://apps.ad.whitehinge.com/memes2/Default", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 0
        '
        'WebControl2
        '
        Me.WebControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl2.Location = New System.Drawing.Point(0, 0)
        Me.WebControl2.Size = New System.Drawing.Size(1245, 613)
        Me.WebControl2.Source = New System.Uri("http://apps.ad.whitehinge.com/memes2/Default", System.UriKind.Absolute)
        Me.WebControl2.TabIndex = 0
        '
        'NotificationCheck
        '
        Me.NotificationCheck.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Messenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 613)
        Me.Controls.Add(Me.WebControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Messenger"
        Me.Text = "Messenger"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Private WithEvents WebControl2 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents NotificationCheck As Timer
    Friend WithEvents Timer1 As Timer
End Class

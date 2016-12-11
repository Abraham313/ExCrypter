<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.XVisualTheme1 = New Metro_Crypt.xVisualTheme()
        Me.XVisualButton1 = New Metro_Crypt.xVisualButton()
        Me.XVisualTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XVisualTheme1
        '
        Me.XVisualTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.XVisualTheme1.Controls.Add(Me.XVisualButton1)
        Me.XVisualTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XVisualTheme1.Location = New System.Drawing.Point(0, 0)
        Me.XVisualTheme1.Name = "XVisualTheme1"
        Me.XVisualTheme1.Size = New System.Drawing.Size(447, 348)
        Me.XVisualTheme1.TabIndex = 0
        Me.XVisualTheme1.Text = "About"
        '
        'XVisualButton1
        '
        Me.XVisualButton1.BackColor = System.Drawing.Color.Transparent
        Me.XVisualButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.XVisualButton1.Location = New System.Drawing.Point(370, 3)
        Me.XVisualButton1.Name = "XVisualButton1"
        Me.XVisualButton1.Shade = Metro_Crypt.xVisualButton.InnerShade.Dark
        Me.XVisualButton1.Size = New System.Drawing.Size(65, 32)
        Me.XVisualButton1.TabIndex = 0
        Me.XVisualButton1.Text = "Close"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 348)
        Me.Controls.Add(Me.XVisualTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "About"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.XVisualTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XVisualTheme1 As xVisualTheme
    Friend WithEvents XVisualButton1 As xVisualButton
End Class

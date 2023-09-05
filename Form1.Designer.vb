<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Greatbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Greatbtn
        '
        Me.Greatbtn.Location = New System.Drawing.Point(301, 350)
        Me.Greatbtn.Name = "Greatbtn"
        Me.Greatbtn.Size = New System.Drawing.Size(176, 70)
        Me.Greatbtn.TabIndex = 0
        Me.Greatbtn.Text = "Greatings"
        Me.Greatbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(301, 132)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 22)
        Me.txtFirstName.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(301, 192)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 22)
        Me.txtSurname.TabIndex = 5
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(301, 239)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 22)
        Me.txtGender.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Greatbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Greatbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtGender As TextBox
End Class

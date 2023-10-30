<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Panel1 = New Panel()
        cb_sex = New ComboBox()
        Button1 = New Button()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cb_sex)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txt_password)
        Panel1.Controls.Add(txt_username)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(847, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(426, 714)
        Panel1.TabIndex = 3
        ' 
        ' cb_sex
        ' 
        cb_sex.Font = New Font("Phetsarath OT", 18F, FontStyle.Regular, GraphicsUnit.Point)
        cb_sex.FormattingEnabled = True
        cb_sex.Items.AddRange(New Object() {"Male", "Female"})
        cb_sex.Location = New Point(36, 444)
        cb_sex.Name = "cb_sex"
        cb_sex.Size = New Size(354, 43)
        cb_sex.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(36, 516)
        Button1.Name = "Button1"
        Button1.Size = New Size(354, 53)
        Button1.TabIndex = 4
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Phetsarath OT", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.Location = New Point(36, 362)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(354, 43)
        txt_password.TabIndex = 3
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Phetsarath OT", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(36, 271)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(354, 43)
        txt_username.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Cursor = Cursors.Hand
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(102, 647)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 23)
        Label6.TabIndex = 2
        Label6.Text = "Account"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(166, 647)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 23)
        Label7.TabIndex = 2
        Label7.Text = "already?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 418)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 23)
        Label2.TabIndex = 2
        Label2.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 647)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 23)
        Label5.TabIndex = 2
        Label5.Text = "Have an "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 23)
        Label4.TabIndex = 2
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 23)
        Label3.TabIndex = 2
        Label3.Text = "UserName"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(129, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 45)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1273, 714)
        Panel2.TabIndex = 4
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1273, 714)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_sex As ComboBox
End Class

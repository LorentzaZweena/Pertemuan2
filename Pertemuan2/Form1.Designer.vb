<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        CheckBox2 = New CheckBox()
        CheckBox4 = New CheckBox()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 25)
        Label2.TabIndex = 1
        Label2.Text = "Jenis kelamin:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 2
        Label3.Text = "Hobi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(213, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 31)
        TextBox1.TabIndex = 3
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(213, 155)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(98, 29)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(337, 155)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(126, 29)
        RadioButton2.TabIndex = 6
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(213, 209)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(99, 29)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "Menulis"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(337, 208)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(110, 29)
        CheckBox4.TabIndex = 9
        CheckBox4.Text = "Olahraga"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 25)
        Label4.TabIndex = 10
        Label4.Text = "Kota asal"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Jakarta", "Bandung", "Surabaya", "Medan"})
        ComboBox1.Location = New Point(213, 93)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(306, 33)
        ComboBox1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(40, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(479, 34)
        Button1.TabIndex = 12
        Button1.Text = "Daftar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(567, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 451)
        Panel1.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Javanese Text", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(31, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(337, 45)
        Label6.TabIndex = 1
        Label6.Text = "Silakan isi form data terlebih dahulu"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(59, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(272, 43)
        Label5.TabIndex = 0
        Label5.Text = "Selamat datang"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(952, 450)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox2)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class

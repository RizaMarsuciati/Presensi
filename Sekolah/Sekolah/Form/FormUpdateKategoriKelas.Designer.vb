<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateKategoriKelas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateKategoriKelas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbKelas = New System.Windows.Forms.ComboBox()
        Me.TxtKategoriKelas = New System.Windows.Forms.TextBox()
        Me.TxtIDKategoriKelas = New System.Windows.Forms.TextBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnBersihkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbKelas)
        Me.GroupBox1.Controls.Add(Me.TxtKategoriKelas)
        Me.GroupBox1.Controls.Add(Me.TxtIDKategoriKelas)
        Me.GroupBox1.Controls.Add(Me.BtnUbah)
        Me.GroupBox1.Controls.Add(Me.BtnBersihkan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategori Kelas"
        '
        'CmbKelas
        '
        Me.CmbKelas.FormattingEnabled = True
        Me.CmbKelas.Location = New System.Drawing.Point(122, 91)
        Me.CmbKelas.Name = "CmbKelas"
        Me.CmbKelas.Size = New System.Drawing.Size(100, 21)
        Me.CmbKelas.TabIndex = 7
        '
        'TxtKategoriKelas
        '
        Me.TxtKategoriKelas.Location = New System.Drawing.Point(122, 61)
        Me.TxtKategoriKelas.Name = "TxtKategoriKelas"
        Me.TxtKategoriKelas.Size = New System.Drawing.Size(100, 20)
        Me.TxtKategoriKelas.TabIndex = 6
        '
        'TxtIDKategoriKelas
        '
        Me.TxtIDKategoriKelas.Location = New System.Drawing.Point(122, 35)
        Me.TxtIDKategoriKelas.Name = "TxtIDKategoriKelas"
        Me.TxtIDKategoriKelas.Size = New System.Drawing.Size(100, 20)
        Me.TxtIDKategoriKelas.TabIndex = 5
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Yellow
        Me.BtnUbah.Location = New System.Drawing.Point(132, 163)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 22)
        Me.BtnUbah.TabIndex = 4
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnBersihkan
        '
        Me.BtnBersihkan.BackColor = System.Drawing.Color.Orange
        Me.BtnBersihkan.Location = New System.Drawing.Point(41, 163)
        Me.BtnBersihkan.Name = "BtnBersihkan"
        Me.BtnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.BtnBersihkan.TabIndex = 3
        Me.BtnBersihkan.Text = "Bersihkan"
        Me.BtnBersihkan.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kategori Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kategori Kelas"
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Red
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(526, 359)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 1
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'FormUpdateKategoriKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(639, 407)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUpdateKategoriKelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateKategoriKelas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtKategoriKelas As TextBox
    Friend WithEvents TxtIDKategoriKelas As TextBox
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents CmbKelas As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggaranBaru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggaranBaru))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPoinPelanggaran = New System.Windows.Forms.TextBox()
        Me.CmbJenisPelanggaran = New System.Windows.Forms.ComboBox()
        Me.RtbKasus = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBersihkan = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIS = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtPoinPelanggaran)
        Me.GroupBox1.Controls.Add(Me.CmbJenisPelanggaran)
        Me.GroupBox1.Controls.Add(Me.RtbKasus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnBersihkan)
        Me.GroupBox1.Controls.Add(Me.BtnKembali)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtNIS)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 382)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtPoinPelanggaran
        '
        Me.TxtPoinPelanggaran.Location = New System.Drawing.Point(183, 250)
        Me.TxtPoinPelanggaran.Name = "TxtPoinPelanggaran"
        Me.TxtPoinPelanggaran.Size = New System.Drawing.Size(100, 20)
        Me.TxtPoinPelanggaran.TabIndex = 14
        '
        'CmbJenisPelanggaran
        '
        Me.CmbJenisPelanggaran.FormattingEnabled = True
        Me.CmbJenisPelanggaran.Location = New System.Drawing.Point(183, 209)
        Me.CmbJenisPelanggaran.Name = "CmbJenisPelanggaran"
        Me.CmbJenisPelanggaran.Size = New System.Drawing.Size(227, 21)
        Me.CmbJenisPelanggaran.TabIndex = 13
        '
        'RtbKasus
        '
        Me.RtbKasus.Location = New System.Drawing.Point(180, 119)
        Me.RtbKasus.Name = "RtbKasus"
        Me.RtbKasus.Size = New System.Drawing.Size(230, 73)
        Me.RtbKasus.TabIndex = 12
        Me.RtbKasus.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kasus Pelanggaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Poin Pelanggaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jenis Pelanggaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NIS"
        '
        'BtnBersihkan
        '
        Me.BtnBersihkan.BackColor = System.Drawing.Color.Green
        Me.BtnBersihkan.ForeColor = System.Drawing.Color.White
        Me.BtnBersihkan.Location = New System.Drawing.Point(195, 308)
        Me.BtnBersihkan.Name = "BtnBersihkan"
        Me.BtnBersihkan.Size = New System.Drawing.Size(88, 27)
        Me.BtnBersihkan.TabIndex = 6
        Me.BtnBersihkan.Text = "BERSIHKAN"
        Me.BtnBersihkan.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Crimson
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(101, 308)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(88, 27)
        Me.BtnKembali.TabIndex = 5
        Me.BtnKembali.Text = "KEMBALI"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Yellow
        Me.BtnSimpan.Location = New System.Drawing.Point(289, 308)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(88, 27)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(180, 82)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(230, 20)
        Me.TxtNama.TabIndex = 1
        '
        'TxtNIS
        '
        Me.TxtNIS.Location = New System.Drawing.Point(180, 45)
        Me.TxtNIS.Name = "TxtNIS"
        Me.TxtNIS.Size = New System.Drawing.Size(230, 20)
        Me.TxtNIS.TabIndex = 0
        '
        'FormPelanggaranBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPelanggaranBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPelanggaranBaru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPoinPelanggaran As TextBox
    Friend WithEvents CmbJenisPelanggaran As ComboBox
    Friend WithEvents RtbKasus As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNIS As TextBox
End Class

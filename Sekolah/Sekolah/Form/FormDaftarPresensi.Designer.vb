<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDaftarPresensi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftarPresensi))
        Me.GroupPresensi = New System.Windows.Forms.GroupBox()
        Me.RdbTanpaKet = New System.Windows.Forms.RadioButton()
        Me.RdbIzin = New System.Windows.Forms.RadioButton()
        Me.RdbSakit = New System.Windows.Forms.RadioButton()
        Me.RdbHadir = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.RtbKeterangan = New System.Windows.Forms.RichTextBox()
        Me.BtnBeranda = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGDaftarPresensi = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblKelas = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.GroupPresensi.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGDaftarPresensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPresensi
        '
        Me.GroupPresensi.BackColor = System.Drawing.Color.Transparent
        Me.GroupPresensi.Controls.Add(Me.RdbTanpaKet)
        Me.GroupPresensi.Controls.Add(Me.RdbIzin)
        Me.GroupPresensi.Controls.Add(Me.RdbSakit)
        Me.GroupPresensi.Controls.Add(Me.RdbHadir)
        Me.GroupPresensi.Controls.Add(Me.Label1)
        Me.GroupPresensi.Controls.Add(Me.BtnSimpan)
        Me.GroupPresensi.Controls.Add(Me.RtbKeterangan)
        Me.GroupPresensi.Location = New System.Drawing.Point(646, 169)
        Me.GroupPresensi.Name = "GroupPresensi"
        Me.GroupPresensi.Size = New System.Drawing.Size(206, 276)
        Me.GroupPresensi.TabIndex = 13
        Me.GroupPresensi.TabStop = False
        Me.GroupPresensi.Text = "Status Kehadiran"
        '
        'RdbTanpaKet
        '
        Me.RdbTanpaKet.AutoSize = True
        Me.RdbTanpaKet.Location = New System.Drawing.Point(105, 39)
        Me.RdbTanpaKet.Name = "RdbTanpaKet"
        Me.RdbTanpaKet.Size = New System.Drawing.Size(85, 17)
        Me.RdbTanpaKet.TabIndex = 11
        Me.RdbTanpaKet.TabStop = True
        Me.RdbTanpaKet.Text = "TANPA KET"
        Me.RdbTanpaKet.UseVisualStyleBackColor = True
        '
        'RdbIzin
        '
        Me.RdbIzin.AutoSize = True
        Me.RdbIzin.Location = New System.Drawing.Point(105, 16)
        Me.RdbIzin.Name = "RdbIzin"
        Me.RdbIzin.Size = New System.Drawing.Size(46, 17)
        Me.RdbIzin.TabIndex = 10
        Me.RdbIzin.TabStop = True
        Me.RdbIzin.Text = "IZIN"
        Me.RdbIzin.UseVisualStyleBackColor = True
        '
        'RdbSakit
        '
        Me.RdbSakit.AutoSize = True
        Me.RdbSakit.Location = New System.Drawing.Point(19, 40)
        Me.RdbSakit.Name = "RdbSakit"
        Me.RdbSakit.Size = New System.Drawing.Size(56, 17)
        Me.RdbSakit.TabIndex = 9
        Me.RdbSakit.TabStop = True
        Me.RdbSakit.Text = "SAKIT"
        Me.RdbSakit.UseVisualStyleBackColor = True
        '
        'RdbHadir
        '
        Me.RdbHadir.AutoSize = True
        Me.RdbHadir.Location = New System.Drawing.Point(19, 16)
        Me.RdbHadir.Name = "RdbHadir"
        Me.RdbHadir.Size = New System.Drawing.Size(59, 17)
        Me.RdbHadir.TabIndex = 8
        Me.RdbHadir.TabStop = True
        Me.RdbHadir.Text = "HADIR"
        Me.RdbHadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Keterangan"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Yellow
        Me.BtnSimpan.Location = New System.Drawing.Point(6, 243)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 2
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'RtbKeterangan
        '
        Me.RtbKeterangan.Location = New System.Drawing.Point(6, 97)
        Me.RtbKeterangan.Name = "RtbKeterangan"
        Me.RtbKeterangan.Size = New System.Drawing.Size(194, 140)
        Me.RtbKeterangan.TabIndex = 1
        Me.RtbKeterangan.Text = ""
        '
        'BtnBeranda
        '
        Me.BtnBeranda.BackColor = System.Drawing.Color.Green
        Me.BtnBeranda.ForeColor = System.Drawing.Color.White
        Me.BtnBeranda.Location = New System.Drawing.Point(716, 456)
        Me.BtnBeranda.Name = "BtnBeranda"
        Me.BtnBeranda.Size = New System.Drawing.Size(75, 23)
        Me.BtnBeranda.TabIndex = 8
        Me.BtnBeranda.Text = "BERANDA"
        Me.BtnBeranda.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DGDaftarPresensi)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 338)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Presensi"
        '
        'DGDaftarPresensi
        '
        Me.DGDaftarPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDaftarPresensi.Location = New System.Drawing.Point(6, 19)
        Me.DGDaftarPresensi.Name = "DGDaftarPresensi"
        Me.DGDaftarPresensi.Size = New System.Drawing.Size(576, 302)
        Me.DGDaftarPresensi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(45, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kelas      :"
        '
        'LblKelas
        '
        Me.LblKelas.AutoSize = True
        Me.LblKelas.BackColor = System.Drawing.Color.Transparent
        Me.LblKelas.Location = New System.Drawing.Point(101, 111)
        Me.LblKelas.Name = "LblKelas"
        Me.LblKelas.Size = New System.Drawing.Size(11, 13)
        Me.LblKelas.TabIndex = 11
        Me.LblKelas.Text = "*"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(18, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(853, 69)
        Me.Panel4.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(377, 48)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "          DAFTAR PRESENSI SISWA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SMP NEGERI 1 JOGONALAN, KLATEN"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggal.Location = New System.Drawing.Point(643, 146)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(46, 13)
        Me.LblTanggal.TabIndex = 15
        Me.LblTanggal.Text = "Tanggal"
        '
        'FormDaftarPresensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 505)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.BtnBeranda)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupPresensi)
        Me.Controls.Add(Me.LblKelas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDaftarPresensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DaftarPresensi"
        Me.GroupPresensi.ResumeLayout(False)
        Me.GroupPresensi.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGDaftarPresensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPresensi As GroupBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents RtbKeterangan As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblKelas As Label
    Friend WithEvents BtnBeranda As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RdbTanpaKet As RadioButton
    Friend WithEvents RdbIzin As RadioButton
    Friend WithEvents RdbSakit As RadioButton
    Friend WithEvents RdbHadir As RadioButton
    Friend WithEvents DGDaftarPresensi As DataGridView
    Friend WithEvents LblTanggal As Label
End Class

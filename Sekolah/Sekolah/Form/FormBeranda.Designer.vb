<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBeranda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBeranda))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnPelanggaran = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnPresensi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRemisi = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.BtnPelanggaran)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(347, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 241)
        Me.Panel2.TabIndex = 19
        '
        'BtnPelanggaran
        '
        Me.BtnPelanggaran.BackColor = System.Drawing.Color.Yellow
        Me.BtnPelanggaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPelanggaran.Location = New System.Drawing.Point(0, 202)
        Me.BtnPelanggaran.Name = "BtnPelanggaran"
        Me.BtnPelanggaran.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPelanggaran.Size = New System.Drawing.Size(193, 39)
        Me.BtnPelanggaran.TabIndex = 1
        Me.BtnPelanggaran.Text = "MASUK"
        Me.BtnPelanggaran.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PELANGGARAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.BtnPresensi)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(93, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 241)
        Me.Panel1.TabIndex = 18
        '
        'BtnPresensi
        '
        Me.BtnPresensi.BackColor = System.Drawing.Color.Yellow
        Me.BtnPresensi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPresensi.Location = New System.Drawing.Point(0, 202)
        Me.BtnPresensi.Name = "BtnPresensi"
        Me.BtnPresensi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPresensi.Size = New System.Drawing.Size(193, 39)
        Me.BtnPresensi.TabIndex = 1
        Me.BtnPresensi.Text = "MASUK"
        Me.BtnPresensi.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PRESENSI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "        BERANDA PRESENSI SISWA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SMP NEGERI 1 JOGONALAN, KLATEN"
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Crimson
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(787, 438)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 20
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(19, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(853, 69)
        Me.Panel4.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BtnRemisi)
        Me.Panel3.Location = New System.Drawing.Point(596, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 239)
        Me.Panel3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "REMISI"
        '
        'BtnRemisi
        '
        Me.BtnRemisi.BackColor = System.Drawing.Color.Yellow
        Me.BtnRemisi.Location = New System.Drawing.Point(0, 201)
        Me.BtnRemisi.Name = "BtnRemisi"
        Me.BtnRemisi.Size = New System.Drawing.Size(194, 39)
        Me.BtnRemisi.TabIndex = 0
        Me.BtnRemisi.Text = "MASUK"
        Me.BtnRemisi.UseVisualStyleBackColor = False
        '
        'BtnCari
        '
        Me.BtnCari.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnCari.ForeColor = System.Drawing.Color.Black
        Me.BtnCari.Location = New System.Drawing.Point(347, 418)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(193, 43)
        Me.BtnCari.TabIndex = 22
        Me.BtnCari.Text = "CARI SISWA"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'FormBeranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 477)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBeranda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahSiswa"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnPelanggaran As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnPresensi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnRemisi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCari As Button
End Class

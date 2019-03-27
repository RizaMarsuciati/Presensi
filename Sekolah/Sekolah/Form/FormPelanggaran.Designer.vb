<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggaran))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnPeraturan = New System.Windows.Forms.Button()
        Me.BtnInputPelanggaran = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.BtnDataPelanggar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(94, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 48)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Demi kenyamanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(59, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Taati peraturan"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnDataPelanggar)
        Me.GroupBox3.Controls.Add(Me.BtnPeraturan)
        Me.GroupBox3.Controls.Add(Me.BtnInputPelanggaran)
        Me.GroupBox3.Location = New System.Drawing.Point(524, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 253)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'BtnPeraturan
        '
        Me.BtnPeraturan.BackColor = System.Drawing.Color.Lime
        Me.BtnPeraturan.Location = New System.Drawing.Point(33, 71)
        Me.BtnPeraturan.Name = "BtnPeraturan"
        Me.BtnPeraturan.Size = New System.Drawing.Size(154, 23)
        Me.BtnPeraturan.TabIndex = 2
        Me.BtnPeraturan.Text = "PERATURAN"
        Me.BtnPeraturan.UseVisualStyleBackColor = False
        '
        'BtnInputPelanggaran
        '
        Me.BtnInputPelanggaran.BackColor = System.Drawing.Color.Yellow
        Me.BtnInputPelanggaran.Location = New System.Drawing.Point(33, 30)
        Me.BtnInputPelanggaran.Name = "BtnInputPelanggaran"
        Me.BtnInputPelanggaran.Size = New System.Drawing.Size(154, 23)
        Me.BtnInputPelanggaran.TabIndex = 1
        Me.BtnInputPelanggaran.Text = "INPUT PELANGGARAN"
        Me.BtnInputPelanggaran.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(19, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(853, 69)
        Me.Panel4.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "                   PELANGGARAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SMP NEGERI 1 JOGONALAN, KLATEN"
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Red
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(773, 438)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtnKembali.TabIndex = 15
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'BtnDataPelanggar
        '
        Me.BtnDataPelanggar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDataPelanggar.Location = New System.Drawing.Point(33, 152)
        Me.BtnDataPelanggar.Name = "BtnDataPelanggar"
        Me.BtnDataPelanggar.Size = New System.Drawing.Size(154, 81)
        Me.BtnDataPelanggar.TabIndex = 3
        Me.BtnDataPelanggar.Text = "DATA PELANGGAR"
        Me.BtnDataPelanggar.UseVisualStyleBackColor = False
        '
        'FormPelanggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 474)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPelanggaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPelanggaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPeraturan As Button
    Friend WithEvents BtnInputPelanggaran As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnDataPelanggar As Button
End Class

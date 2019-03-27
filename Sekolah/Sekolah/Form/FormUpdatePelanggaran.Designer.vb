<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdatePelanggaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdatePelanggaran))
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.Pelanggaran = New System.Windows.Forms.GroupBox()
        Me.TxtPointPelanggaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtJenisPelanggaran = New System.Windows.Forms.TextBox()
        Me.TxtIdJenisPelanggaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBersihkan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.Pelanggaran.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Red
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(547, 367)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 0
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Pelanggaran
        '
        Me.Pelanggaran.Controls.Add(Me.TxtPointPelanggaran)
        Me.Pelanggaran.Controls.Add(Me.Label3)
        Me.Pelanggaran.Controls.Add(Me.TxtJenisPelanggaran)
        Me.Pelanggaran.Controls.Add(Me.TxtIdJenisPelanggaran)
        Me.Pelanggaran.Controls.Add(Me.Label2)
        Me.Pelanggaran.Controls.Add(Me.Label1)
        Me.Pelanggaran.Controls.Add(Me.BtnBersihkan)
        Me.Pelanggaran.Controls.Add(Me.BtnUbah)
        Me.Pelanggaran.Location = New System.Drawing.Point(190, 102)
        Me.Pelanggaran.Name = "Pelanggaran"
        Me.Pelanggaran.Size = New System.Drawing.Size(260, 227)
        Me.Pelanggaran.TabIndex = 1
        Me.Pelanggaran.TabStop = False
        Me.Pelanggaran.Text = "Pelanggaran"
        '
        'TxtPointPelanggaran
        '
        Me.TxtPointPelanggaran.Location = New System.Drawing.Point(25, 146)
        Me.TxtPointPelanggaran.Name = "TxtPointPelanggaran"
        Me.TxtPointPelanggaran.Size = New System.Drawing.Size(209, 20)
        Me.TxtPointPelanggaran.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Point Pelanggaran"
        '
        'TxtJenisPelanggaran
        '
        Me.TxtJenisPelanggaran.Location = New System.Drawing.Point(25, 98)
        Me.TxtJenisPelanggaran.Name = "TxtJenisPelanggaran"
        Me.TxtJenisPelanggaran.Size = New System.Drawing.Size(209, 20)
        Me.TxtJenisPelanggaran.TabIndex = 5
        '
        'TxtIdJenisPelanggaran
        '
        Me.TxtIdJenisPelanggaran.Location = New System.Drawing.Point(25, 50)
        Me.TxtIdJenisPelanggaran.Name = "TxtIdJenisPelanggaran"
        Me.TxtIdJenisPelanggaran.Size = New System.Drawing.Size(209, 20)
        Me.TxtIdJenisPelanggaran.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Pelanggaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Jenis Pelanggaran"
        '
        'BtnBersihkan
        '
        Me.BtnBersihkan.BackColor = System.Drawing.Color.Orange
        Me.BtnBersihkan.ForeColor = System.Drawing.Color.Black
        Me.BtnBersihkan.Location = New System.Drawing.Point(55, 188)
        Me.BtnBersihkan.Name = "BtnBersihkan"
        Me.BtnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.BtnBersihkan.TabIndex = 1
        Me.BtnBersihkan.Text = "Bersihkan"
        Me.BtnBersihkan.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Yellow
        Me.BtnUbah.Location = New System.Drawing.Point(136, 188)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 0
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'FormUpdatePelanggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 402)
        Me.Controls.Add(Me.Pelanggaran)
        Me.Controls.Add(Me.BtnTutup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUpdatePelanggaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdatePelanggaran"
        Me.Pelanggaran.ResumeLayout(False)
        Me.Pelanggaran.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents Pelanggaran As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents TxtJenisPelanggaran As TextBox
    Friend WithEvents TxtIdJenisPelanggaran As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPointPelanggaran As TextBox
End Class

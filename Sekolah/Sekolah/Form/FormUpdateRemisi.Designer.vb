<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateRemisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateRemisi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnBersihkan = New System.Windows.Forms.Button()
        Me.TxtPointRemisi = New System.Windows.Forms.TextBox()
        Me.TxtJenisRemisi = New System.Windows.Forms.TextBox()
        Me.TxtIdRemisi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnUbah)
        Me.GroupBox1.Controls.Add(Me.BtnBersihkan)
        Me.GroupBox1.Controls.Add(Me.TxtPointRemisi)
        Me.GroupBox1.Controls.Add(Me.TxtJenisRemisi)
        Me.GroupBox1.Controls.Add(Me.TxtIdRemisi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(161, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remisi"
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Yellow
        Me.BtnUbah.Location = New System.Drawing.Point(140, 183)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 9
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnBersihkan
        '
        Me.BtnBersihkan.BackColor = System.Drawing.Color.Orange
        Me.BtnBersihkan.Location = New System.Drawing.Point(50, 183)
        Me.BtnBersihkan.Name = "BtnBersihkan"
        Me.BtnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.BtnBersihkan.TabIndex = 8
        Me.BtnBersihkan.Text = "Bersihkan"
        Me.BtnBersihkan.UseVisualStyleBackColor = False
        '
        'TxtPointRemisi
        '
        Me.TxtPointRemisi.Location = New System.Drawing.Point(140, 123)
        Me.TxtPointRemisi.Name = "TxtPointRemisi"
        Me.TxtPointRemisi.Size = New System.Drawing.Size(100, 20)
        Me.TxtPointRemisi.TabIndex = 7
        '
        'TxtJenisRemisi
        '
        Me.TxtJenisRemisi.Location = New System.Drawing.Point(140, 79)
        Me.TxtJenisRemisi.Name = "TxtJenisRemisi"
        Me.TxtJenisRemisi.Size = New System.Drawing.Size(100, 20)
        Me.TxtJenisRemisi.TabIndex = 6
        '
        'TxtIdRemisi
        '
        Me.TxtIdRemisi.Location = New System.Drawing.Point(140, 40)
        Me.TxtIdRemisi.Name = "TxtIdRemisi"
        Me.TxtIdRemisi.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdRemisi.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Point Remisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Remisi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Remisi"
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Red
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(515, 358)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 1
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'FormUpdateRemisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(631, 407)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUpdateRemisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateRemisi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents TxtPointRemisi As TextBox
    Friend WithEvents TxtJenisRemisi As TextBox
    Friend WithEvents TxtIdRemisi As TextBox
    Friend WithEvents BtnTutup As Button
End Class

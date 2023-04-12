<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class landingpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(landingpage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAnime = New System.Windows.Forms.Button()
        Me.btnDirector = New System.Windows.Forms.Button()
        Me.btnGenre = New System.Windows.Forms.Button()
        Me.btnStudio = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnWriters = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(161, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(464, 171)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Maroon
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(664, 36)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(91, 39)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAnime
        '
        Me.btnAnime.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAnime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnime.Location = New System.Drawing.Point(281, 248)
        Me.btnAnime.Name = "btnAnime"
        Me.btnAnime.Size = New System.Drawing.Size(104, 37)
        Me.btnAnime.TabIndex = 4
        Me.btnAnime.Text = "Anime"
        Me.btnAnime.UseVisualStyleBackColor = False
        '
        'btnDirector
        '
        Me.btnDirector.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirector.Location = New System.Drawing.Point(391, 248)
        Me.btnDirector.Name = "btnDirector"
        Me.btnDirector.Size = New System.Drawing.Size(104, 37)
        Me.btnDirector.TabIndex = 5
        Me.btnDirector.Text = "Director"
        Me.btnDirector.UseVisualStyleBackColor = False
        '
        'btnGenre
        '
        Me.btnGenre.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenre.Location = New System.Drawing.Point(281, 291)
        Me.btnGenre.Name = "btnGenre"
        Me.btnGenre.Size = New System.Drawing.Size(104, 37)
        Me.btnGenre.TabIndex = 6
        Me.btnGenre.Text = "Genre"
        Me.btnGenre.UseVisualStyleBackColor = False
        '
        'btnStudio
        '
        Me.btnStudio.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudio.Location = New System.Drawing.Point(391, 291)
        Me.btnStudio.Name = "btnStudio"
        Me.btnStudio.Size = New System.Drawing.Size(104, 37)
        Me.btnStudio.TabIndex = 7
        Me.btnStudio.Text = "Studio"
        Me.btnStudio.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Location = New System.Drawing.Point(281, 334)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(104, 37)
        Me.btnUsers.TabIndex = 8
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnWriters
        '
        Me.btnWriters.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnWriters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriters.Location = New System.Drawing.Point(391, 334)
        Me.btnWriters.Name = "btnWriters"
        Me.btnWriters.Size = New System.Drawing.Size(104, 37)
        Me.btnWriters.TabIndex = 9
        Me.btnWriters.Text = "Writers"
        Me.btnWriters.UseVisualStyleBackColor = False
        '
        'landingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWriters)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnStudio)
        Me.Controls.Add(Me.btnGenre)
        Me.Controls.Add(Me.btnDirector)
        Me.Controls.Add(Me.btnAnime)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "landingpage"
        Me.Text = "landingpage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAnime As Button
    Friend WithEvents btnDirector As Button
    Friend WithEvents btnGenre As Button
    Friend WithEvents btnStudio As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnWriters As Button
End Class

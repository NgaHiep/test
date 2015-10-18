<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOADON
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
        Me.Label1_MaHD = New System.Windows.Forms.Label()
        Me.Label2_NgayXHD = New System.Windows.Forms.Label()
        Me.Label3_MaKH = New System.Windows.Forms.Label()
        Me.TextBox1_MAHD = New System.Windows.Forms.TextBox()
        Me.TextBox2_NgayXHD = New System.Windows.Forms.TextBox()
        Me.TextBox3_MaKH = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_CanCel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_MaHD
        '
        Me.Label1_MaHD.AutoSize = True
        Me.Label1_MaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_MaHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1_MaHD.Location = New System.Drawing.Point(40, 48)
        Me.Label1_MaHD.Name = "Label1_MaHD"
        Me.Label1_MaHD.Size = New System.Drawing.Size(42, 13)
        Me.Label1_MaHD.TabIndex = 0
        Me.Label1_MaHD.Text = "MaHD"
        '
        'Label2_NgayXHD
        '
        Me.Label2_NgayXHD.AutoSize = True
        Me.Label2_NgayXHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_NgayXHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2_NgayXHD.Location = New System.Drawing.Point(40, 102)
        Me.Label2_NgayXHD.Name = "Label2_NgayXHD"
        Me.Label2_NgayXHD.Size = New System.Drawing.Size(62, 13)
        Me.Label2_NgayXHD.TabIndex = 0
        Me.Label2_NgayXHD.Text = "NgayXHD"
        '
        'Label3_MaKH
        '
        Me.Label3_MaKH.AutoSize = True
        Me.Label3_MaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3_MaKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3_MaKH.Location = New System.Drawing.Point(40, 158)
        Me.Label3_MaKH.Name = "Label3_MaKH"
        Me.Label3_MaKH.Size = New System.Drawing.Size(41, 13)
        Me.Label3_MaKH.TabIndex = 0
        Me.Label3_MaKH.Text = "MaKH"
        '
        'TextBox1_MAHD
        '
        Me.TextBox1_MAHD.Location = New System.Drawing.Point(143, 48)
        Me.TextBox1_MAHD.Name = "TextBox1_MAHD"
        Me.TextBox1_MAHD.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1_MAHD.TabIndex = 1
        '
        'TextBox2_NgayXHD
        '
        Me.TextBox2_NgayXHD.Location = New System.Drawing.Point(143, 99)
        Me.TextBox2_NgayXHD.Name = "TextBox2_NgayXHD"
        Me.TextBox2_NgayXHD.Size = New System.Drawing.Size(173, 20)
        Me.TextBox2_NgayXHD.TabIndex = 1
        '
        'TextBox3_MaKH
        '
        Me.TextBox3_MaKH.Location = New System.Drawing.Point(143, 151)
        Me.TextBox3_MaKH.Name = "TextBox3_MaKH"
        Me.TextBox3_MaKH.Size = New System.Drawing.Size(173, 20)
        Me.TextBox3_MaKH.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.Location = New System.Drawing.Point(179, 220)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_CanCel
        '
        Me.btn_CanCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CanCel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_CanCel.Location = New System.Drawing.Point(287, 220)
        Me.btn_CanCel.Name = "btn_CanCel"
        Me.btn_CanCel.Size = New System.Drawing.Size(75, 23)
        Me.btn_CanCel.TabIndex = 2
        Me.btn_CanCel.Text = "CanCel"
        Me.btn_CanCel.UseVisualStyleBackColor = True
        '
        'HOADON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 261)
        Me.Controls.Add(Me.btn_CanCel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.TextBox3_MaKH)
        Me.Controls.Add(Me.TextBox2_NgayXHD)
        Me.Controls.Add(Me.TextBox1_MAHD)
        Me.Controls.Add(Me.Label3_MaKH)
        Me.Controls.Add(Me.Label2_NgayXHD)
        Me.Controls.Add(Me.Label1_MaHD)
        Me.Name = "HOADON"
        Me.Text = "HOADON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_MaHD As Label
    Friend WithEvents Label2_NgayXHD As Label
    Friend WithEvents Label3_MaKH As Label
    Friend WithEvents TextBox1_MAHD As TextBox
    Friend WithEvents TextBox2_NgayXHD As TextBox
    Friend WithEvents TextBox3_MaKH As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_CanCel As Button
End Class

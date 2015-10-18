<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiTietHoaDon
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
        Me.Label1_MaHD = New System.Windows.Forms.Label()
        Me.Label2_MaSP = New System.Windows.Forms.Label()
        Me.TextBox1_MaHD = New System.Windows.Forms.TextBox()
        Me.TextBox2_MaSP = New System.Windows.Forms.TextBox()
        Me.Button1_ok = New System.Windows.Forms.Button()
        Me.Button2_CanCel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_MaHD
        '
        Me.Label1_MaHD.AutoSize = True
        Me.Label1_MaHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_MaHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1_MaHD.Location = New System.Drawing.Point(36, 42)
        Me.Label1_MaHD.Name = "Label1_MaHD"
        Me.Label1_MaHD.Size = New System.Drawing.Size(42, 13)
        Me.Label1_MaHD.TabIndex = 0
        Me.Label1_MaHD.Text = "MaHD"
        '
        'Label2_MaSP
        '
        Me.Label2_MaSP.AutoSize = True
        Me.Label2_MaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_MaSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2_MaSP.Location = New System.Drawing.Point(36, 78)
        Me.Label2_MaSP.Name = "Label2_MaSP"
        Me.Label2_MaSP.Size = New System.Drawing.Size(40, 13)
        Me.Label2_MaSP.TabIndex = 0
        Me.Label2_MaSP.Text = "MaSP"
        '
        'TextBox1_MaHD
        '
        Me.TextBox1_MaHD.Location = New System.Drawing.Point(120, 42)
        Me.TextBox1_MaHD.Name = "TextBox1_MaHD"
        Me.TextBox1_MaHD.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1_MaHD.TabIndex = 1
        '
        'TextBox2_MaSP
        '
        Me.TextBox2_MaSP.Location = New System.Drawing.Point(120, 78)
        Me.TextBox2_MaSP.Name = "TextBox2_MaSP"
        Me.TextBox2_MaSP.Size = New System.Drawing.Size(139, 20)
        Me.TextBox2_MaSP.TabIndex = 1
        '
        'Button1_ok
        '
        Me.Button1_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1_ok.Location = New System.Drawing.Point(70, 157)
        Me.Button1_ok.Name = "Button1_ok"
        Me.Button1_ok.Size = New System.Drawing.Size(75, 23)
        Me.Button1_ok.TabIndex = 2
        Me.Button1_ok.Text = "OK"
        Me.Button1_ok.UseVisualStyleBackColor = True
        '
        'Button2_CanCel
        '
        Me.Button2_CanCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2_CanCel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2_CanCel.Location = New System.Drawing.Point(184, 157)
        Me.Button2_CanCel.Name = "Button2_CanCel"
        Me.Button2_CanCel.Size = New System.Drawing.Size(75, 23)
        Me.Button2_CanCel.TabIndex = 2
        Me.Button2_CanCel.Text = "CanCel"
        Me.Button2_CanCel.UseVisualStyleBackColor = True
        '
        'ChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2_CanCel)
        Me.Controls.Add(Me.Button1_ok)
        Me.Controls.Add(Me.TextBox2_MaSP)
        Me.Controls.Add(Me.TextBox1_MaHD)
        Me.Controls.Add(Me.Label2_MaSP)
        Me.Controls.Add(Me.Label1_MaHD)
        Me.Name = "ChiTietHoaDon"
        Me.Text = "ChiTietHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_MaHD As Label
    Friend WithEvents Label2_MaSP As Label
    Friend WithEvents TextBox1_MaHD As TextBox
    Friend WithEvents TextBox2_MaSP As TextBox
    Friend WithEvents Button1_ok As Button
    Friend WithEvents Button2_CanCel As Button

    Friend Function Label1_MaLSP() As Object
        Throw New NotImplementedException()
    End Function
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHACHHANG
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1_makh = New System.Windows.Forms.Label()
        Me.Label2_tenkh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtSodthd = New System.Windows.Forms.TextBox()
        Me.Label3_sdt = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label_diachi = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1_makh
        '
        Me.Label1_makh.AutoSize = True
        Me.Label1_makh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_makh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1_makh.Location = New System.Drawing.Point(96, 32)
        Me.Label1_makh.Name = "Label1_makh"
        Me.Label1_makh.Size = New System.Drawing.Size(41, 13)
        Me.Label1_makh.TabIndex = 0
        Me.Label1_makh.Text = "MaKH"
        '
        'Label2_tenkh
        '
        Me.Label2_tenkh.AutoSize = True
        Me.Label2_tenkh.BackColor = System.Drawing.Color.White
        Me.Label2_tenkh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_tenkh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2_tenkh.Location = New System.Drawing.Point(97, 87)
        Me.Label2_tenkh.Name = "Label2_tenkh"
        Me.Label2_tenkh.Size = New System.Drawing.Size(46, 13)
        Me.Label2_tenkh.TabIndex = 2
        Me.Label2_tenkh.Text = "TenKH"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(190, 32)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(133, 20)
        Me.txtmakh.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(190, 84)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(133, 20)
        Me.txttenkh.TabIndex = 5
        '
        'txtSodthd
        '
        Me.txtSodthd.Location = New System.Drawing.Point(190, 132)
        Me.txtSodthd.Name = "txtSodthd"
        Me.txtSodthd.Size = New System.Drawing.Size(133, 20)
        Me.txtSodthd.TabIndex = 6
        '
        'Label3_sdt
        '
        Me.Label3_sdt.AutoSize = True
        Me.Label3_sdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3_sdt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3_sdt.Location = New System.Drawing.Point(96, 139)
        Me.Label3_sdt.Name = "Label3_sdt"
        Me.Label3_sdt.Size = New System.Drawing.Size(32, 13)
        Me.Label3_sdt.TabIndex = 7
        Me.Label3_sdt.Text = "SDT"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(220, 244)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(331, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label_diachi
        '
        Me.Label_diachi.AutoSize = True
        Me.Label_diachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_diachi.Location = New System.Drawing.Point(96, 181)
        Me.Label_diachi.Name = "Label_diachi"
        Me.Label_diachi.Size = New System.Drawing.Size(48, 13)
        Me.Label_diachi.TabIndex = 10
        Me.Label_diachi.Text = "Dia Chi"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(190, 181)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(133, 20)
        Me.txtdiachi.TabIndex = 11
        '
        'btn_Delete
        '
        Me.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(112, 244)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_Delete.TabIndex = 12
        Me.btn_Delete.Text = "DELETE"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(12, 244)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Edit.TabIndex = 13
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'KHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 279)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.Label_diachi)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3_sdt)
        Me.Controls.Add(Me.txtSodthd)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.Label2_tenkh)
        Me.Controls.Add(Me.Label1_makh)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "KHACHHANG"
        Me.Text = "KHACHHANG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1_makh As Label
    Friend WithEvents Label2_tenkh As Label
    Friend WithEvents txtmakh As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txttenkh As TextBox
    Friend WithEvents txtSodthd As TextBox
    Friend WithEvents Label3_sdt As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label_diachi As Label
    Friend WithEvents txtdiachi As TextBox
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Edit As Button
End Class

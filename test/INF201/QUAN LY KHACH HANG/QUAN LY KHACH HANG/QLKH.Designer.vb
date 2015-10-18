<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLKH
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
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnk_Delete = New System.Windows.Forms.Button()
        Me.cmnSearch = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.rdoHoaDon = New System.Windows.Forms.RadioButton()
        Me.rod_ChiTietHoaDon = New System.Windows.Forms.RadioButton()
        Me.rodSanPham = New System.Windows.Forms.RadioButton()
        Me.rod_LoaiSP = New System.Windows.Forms.RadioButton()
        Me.RadioKhachHang = New System.Windows.Forms.RadioButton()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(12, 60)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(564, 330)
        Me.dataGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd2.Location = New System.Drawing.Point(786, 93)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(167, 23)
        Me.btnAdd2.TabIndex = 3
        Me.btnAdd2.Text = "ADD"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Blue
        Me.btnEdit.Location = New System.Drawing.Point(786, 136)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(167, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnk_Delete
        '
        Me.btnk_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnk_Delete.ForeColor = System.Drawing.Color.Blue
        Me.btnk_Delete.Location = New System.Drawing.Point(786, 177)
        Me.btnk_Delete.Name = "btnk_Delete"
        Me.btnk_Delete.Size = New System.Drawing.Size(167, 23)
        Me.btnk_Delete.TabIndex = 5
        Me.btnk_Delete.Text = "DELETE"
        Me.btnk_Delete.UseVisualStyleBackColor = True
        '
        'cmnSearch
        '
        Me.cmnSearch.Location = New System.Drawing.Point(65, 34)
        Me.cmnSearch.Name = "cmnSearch"
        Me.cmnSearch.Size = New System.Drawing.Size(511, 20)
        Me.cmnSearch.TabIndex = 6
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'rdoHoaDon
        '
        Me.rdoHoaDon.AutoSize = True
        Me.rdoHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHoaDon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdoHoaDon.Location = New System.Drawing.Point(638, 93)
        Me.rdoHoaDon.Name = "rdoHoaDon"
        Me.rdoHoaDon.Size = New System.Drawing.Size(75, 17)
        Me.rdoHoaDon.TabIndex = 9
        Me.rdoHoaDon.TabStop = True
        Me.rdoHoaDon.Text = "Hoa Don"
        Me.rdoHoaDon.UseVisualStyleBackColor = True
        '
        'rod_ChiTietHoaDon
        '
        Me.rod_ChiTietHoaDon.AutoSize = True
        Me.rod_ChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rod_ChiTietHoaDon.Location = New System.Drawing.Point(638, 116)
        Me.rod_ChiTietHoaDon.Name = "rod_ChiTietHoaDon"
        Me.rod_ChiTietHoaDon.Size = New System.Drawing.Size(123, 17)
        Me.rod_ChiTietHoaDon.TabIndex = 10
        Me.rod_ChiTietHoaDon.TabStop = True
        Me.rod_ChiTietHoaDon.Text = "Chi Tiet Hoa Don"
        Me.rod_ChiTietHoaDon.UseVisualStyleBackColor = True
        '
        'rodSanPham
        '
        Me.rodSanPham.AutoSize = True
        Me.rodSanPham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rodSanPham.Location = New System.Drawing.Point(638, 139)
        Me.rodSanPham.Name = "rodSanPham"
        Me.rodSanPham.Size = New System.Drawing.Size(82, 17)
        Me.rodSanPham.TabIndex = 11
        Me.rodSanPham.TabStop = True
        Me.rodSanPham.Text = "San Pham"
        Me.rodSanPham.UseVisualStyleBackColor = True
        '
        'rod_LoaiSP
        '
        Me.rod_LoaiSP.AutoSize = True
        Me.rod_LoaiSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rod_LoaiSP.Location = New System.Drawing.Point(638, 162)
        Me.rod_LoaiSP.Name = "rod_LoaiSP"
        Me.rod_LoaiSP.Size = New System.Drawing.Size(110, 17)
        Me.rod_LoaiSP.TabIndex = 12
        Me.rod_LoaiSP.TabStop = True
        Me.rod_LoaiSP.Text = "Loai San Pham"
        Me.rod_LoaiSP.UseVisualStyleBackColor = True
        '
        'RadioKhachHang
        '
        Me.RadioKhachHang.AccessibleDescription = "0"
        Me.RadioKhachHang.AutoSize = True
        Me.RadioKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioKhachHang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioKhachHang.Location = New System.Drawing.Point(638, 70)
        Me.RadioKhachHang.Name = "RadioKhachHang"
        Me.RadioKhachHang.Size = New System.Drawing.Size(95, 17)
        Me.RadioKhachHang.TabIndex = 9
        Me.RadioKhachHang.TabStop = True
        Me.RadioKhachHang.Text = "Khach Hang"
        Me.RadioKhachHang.UseVisualStyleBackColor = True
        '
        'QLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 396)
        Me.Controls.Add(Me.rod_LoaiSP)
        Me.Controls.Add(Me.rodSanPham)
        Me.Controls.Add(Me.rod_ChiTietHoaDon)
        Me.Controls.Add(Me.RadioKhachHang)
        Me.Controls.Add(Me.rdoHoaDon)
        Me.Controls.Add(Me.cmnSearch)
        Me.Controls.Add(Me.btnk_Delete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "QLKH"
        Me.Text = "QUAN LY KHACH HANG"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnk_Delete As Button
    Friend WithEvents cmnSearch As TextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents rod_LoaiSP As RadioButton
    Friend WithEvents rodSanPham As RadioButton
    Friend WithEvents rod_ChiTietHoaDon As RadioButton
    Friend WithEvents rdoHoaDon As RadioButton
    Friend WithEvents rdoKhachHang As RadioButton
    Friend WithEvents RadioKhachHang As RadioButton
End Class

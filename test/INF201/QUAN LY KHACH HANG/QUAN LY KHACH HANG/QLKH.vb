Public Class QLKH
    Private _DBAccess As New DataBaseAccess
    Private isloading As Boolean = False


    Private Sub LoadDataOnGridView(MaLoaiSP As String)
        Dim sqlQuery As String = String.Format("SELECT  [MaSP],[TenSP],[Mota],[MaLSP] FROM [QLKH].[dbo].[SanPham] Where [MaLSP] = '{0}'", MaLoaiSP)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Mota"
            .Columns(3).HeaderText = "MaLSP"
        End With
    End Sub

    Public Sub LoadDataFromKhachHang()
        Dim sqlQuery As String = "Select * from dbo.KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "Dia Chi"

        End With
    End Sub

    Private Sub LoadDataFromLoaiSP()
        Dim sqlQuery As String = "Select * from dbo.LoaiSanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaLSP"
            .Columns(1).HeaderText = "TenLSP"
            .Columns(2).HeaderText = "Soluong"
        End With
    End Sub

    Private Sub LoadDataFromSanPham()
        Dim sqlQuery As String = "Select * from dbo.SanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "MaLSP"
            .Columns(4).HeaderText = "Mota"

        End With
    End Sub

    Private Sub LoadDataFromHoaDon()
        Dim sqlQuery As String = "Select * from dbo.HoaDon"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "NgayXHD"
            .Columns(2).HeaderText = "MaKH"
        End With
    End Sub
    Private Sub LoadDataFromChiTietHoaDon()
        Dim sqlQuery As String = "Select * from dbo.ChiTietHoaDon"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "MaSP"
        End With
    End Sub

    Private Sub frmQLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub rodSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles rodSanPham.CheckedChanged
        isloading = True
        LoadDataFromSanPham()

        isloading = False
    End Sub

    Private Sub rdoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHoaDon.CheckedChanged, RadioKhachHang.CheckedChanged
        LoadDataFromKhachHang()
    End Sub

    Private Sub rodLoaiSP_CheckedChanged(sender As Object, e As EventArgs) Handles rod_LoaiSP.CheckedChanged
        LoadDataFromLoaiSP()
    End Sub

    Private Sub rdoHoaDon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHoaDon.CheckedChanged
        LoadDataFromHoaDon()
    End Sub

    Private Sub Radiocthd_CheckedChanged(sender As Object, e As EventArgs) Handles rod_ChiTietHoaDon.CheckedChanged
        LoadDataFromChiTietHoaDon()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cmnSearch.TextChanged
        Dim txtSearch As String = "%" + Me.cmnSearch.Text + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.KhachHang where [MaKH] Like '{0}' Or [TenKH] Like '{0}' Or [SDT] Like '{0}' Or [DiaChi] Like '{0}'", txtSearch)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Mota"
            .Columns(3).HeaderText = "MaLSP"
        End With
    End Sub

    Private Sub dataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellContentClick

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        If rdoHoaDon.Checked Then
            Dim frm As New HOADON
            frm.Show()
            frm.Label1_MaHD.Text = "MaHD"
            frm.Label2_NgayXHD.Text = "NgayXHD"
            frm.Label3_MaKH.Text = "MaKH"
        ElseIf rodSanPham.Checked Then
            Dim frm As New San_Pham
            frm.Show()
            frm.Label1_MaSP.Text = "MaSP"
            frm.Label2_TenSP.Text = "TenSP"
            frm.Label3_Soluong.Text = "Soluong"
            frm.Label4_MaLSP.Text = "MaLSP"
            frm.Label4_MaLSP.Text = "Mota"
        ElseIf rod_ChiTietHoaDon.Checked Then
            Dim frm As New ChiTietHoaDon
            frm.Show()
            frm.Label1_MaHD.Text = "MaHD"
            frm.Label2_MaSP.Text = "MaSP"

        ElseIf rod_LoaiSP.Checked Then
            Dim frm As New LoaiSanPham
            frm.Show()
            frm.nh1_MaLSP.Text = "MaLSP"
            frm.nh2_TenLSP.Text = "TenSP"
            frm.nh3_Soluong.Text = "Soluong"
        Else

            Dim frm As New KHACHHANG
            frm.Show()
            frm.Label1_makh.Text = "MaKH"
            frm.Label2_tenkh.Text = "TenKH"
            frm.Label_diachi.Text = "SDT"
            frm.Label3_sdt.Text = "Dia Chi"
            LoadDataFromKhachHang()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadDataFromKhachHang()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If btnEdit.Created Then
            Dim frm As New KHACHHANG
            frm.Show()
            frm.Label1_makh.Text = "MaKH"
            frm.Label2_tenkh.Text = "TenKH"
            frm.Label_diachi.Text = "SDT"
            frm.Label3_sdt.Text = "Dia Chi"
            frm.txtmakh.ReadOnly = True
            With Me.dataGridView
                frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
                frm.txtSodthd.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
                frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            End With
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnk_Delete.Click
        If btnk_Delete.Created Then
            Dim frm As New KHACHHANG
            frm.Show()
            frm.Label1_makh.Text = "MaKH"
            frm.Label2_tenkh.Text = "TenKH"
            frm.Label_diachi.Text = "SDT"
            frm.Label3_sdt.Text = "Dia Chi"
            frm.txtmakh.ReadOnly = True
            frm.txttenkh.ReadOnly = True
            frm.txtSodthd.ReadOnly = True
            frm.txtdiachi.ReadOnly = True
            With Me.dataGridView
                frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
                frm.txtSodthd.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
                frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            End With
        End If


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class KHACHHANG
    Private _DBAccess As New DataBaseAccess
    Dim check As Boolean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtmakh.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2_tenkh.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1_makh.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3_sdt.Click

    End Sub

    Private Sub KHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ThemData_Khach_Hang(id As String, hoten As String, sdt As String, diachi As String)
        Dim sqlString As String = String.Format("insert into dbo.KhachHang (MaKH, TenKH, SDT, DiaChi) values ('" + id + "','" + hoten + "','" + sdt + "','" + diachi + "')")
        check = _DBAccess.ExecuteNoneQuery(sqlString)


    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ThemData_Khach_Hang(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtSodthd.Text)
        If check Then
            MessageBox.Show("Them thanh cong!")
        Else
            MessageBox.Show(Label1_makh.Text + "--" + Label2_tenkh.Text + "--" + Label3_sdt.Text + "---" + Label_diachi.Text)
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        QLKH.LoadDataFromKhachHang()
    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label_diachi.Click

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim sqlQuery As String = String.Format("Update dbo.KhachHang SET [TenKH] = '{0}', [SDT] = '{1}', [DiaChi] = '{2}' where [MaKH] = '{3}'", Me.txttenkh.Text, Me.txtSodthd.Text, Me.txtdiachi.Text, Me.txtmakh.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Sua du lieu thanh cong")
            Me.Close()
            QLKH.LoadDataFromKhachHang()
        Else
            MessageBox.Show("Loi roi kia")
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim sqlQuery As String = String.Format("Delete From dbo.KhachHang where [MaKH] = '{0}'", Me.txtmakh.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xoa du lieu thanh cong")
            Me.Close()
            QLKH.LoadDataFromKhachHang()
        Else
            MessageBox.Show("Loi roi kia")
        End If
    End Sub
End Class
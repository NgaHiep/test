Public Class HOADON
    Private _DBAccess As New DataBaseAccess
    Dim check As Boolean
    Private Sub HOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ThemData_HOA_DON(mahd As String, ngayxhd As String, makh As String)
        Dim sqlString As String = String.Format("insert into dbo.HoaDon (MaHD, NgayXHD, MaKH) values ('" + mahd + "','" + ngayxhd + "','" + makh + "')")
        check = _DBAccess.ExecuteNoneQuery(sqlString)


    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        ThemData_HOADON(TextBox1_MAHD.Text, TextBox2_NgayXHD.Text, TextBox3_MaKH.Text)
        If check Then
            MessageBox.Show("Them thanh cong!")
        Else
            MessageBox.Show(Label1_MaHD.Text + "--" + Label2_NgayXHD.Text + "--" + Label3_MaKH.Text)
        End If
    End Sub

    Private Sub ThemData_HOADON(text1 As String, text2 As String, text3 As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub btn_CanCel_Click(sender As Object, e As EventArgs) Handles btn_CanCel.Click
        Close()
    End Sub
End Class
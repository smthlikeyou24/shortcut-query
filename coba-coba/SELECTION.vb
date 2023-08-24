Public Class SELECTION
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SELECTION_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim sl As New selects

        sl.selectAll(table_name:="TBL_BARANG")
        If Rd.HasRows Then
            Rd.Read()
            Label1.Text = Rd.Item("nama_barang")
        End If


        sl.selectAll(table_name:="TBL_USER")
        If Rd.HasRows Then
            Rd.Read()
            Label2.Text = Rd.Item("username")
        End If


        sl.selectWhere(table_name:="TBL_BARANG", where:="harga='2000'")
        If Rd.HasRows Then
            Rd.Read()
            Label3.Text = Rd.Item("nama_barang")
        End If

    End Sub
End Class
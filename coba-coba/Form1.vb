Public Class Form1


    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim dg As New datagrid
        dg.selectAll(table_name:="TBL_BARANG")
        DataGridView1.DataSource = Ds.Tables("TBL_BARANG")

        dg.selectAllWhere(table_name:="TBL_BARANG", where:="nama_barang='mie'")
        DataGridView2.DataSource = Ds.Tables("TBL_BARANG")


    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Me.Hide()
        SELECT_COLUMN.Show()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Me.Hide()
        SELECTION.Show()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Me.Hide()
        INSERT.Show()
    End Sub
End Class

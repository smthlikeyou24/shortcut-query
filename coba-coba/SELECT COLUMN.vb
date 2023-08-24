Imports System.Data.SqlClient

Public Class SELECT_COLUMN
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SELECT_COLUMN_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim dg As New datagrid

        dg.selectColumn(column_name:="nama_barang, harga, stok", table_name:="TBL_BARANG")
        DataGridView1.DataSource = Ds.Tables("TBL_BARANG")

        dg.selectColumnWhere(column_name:="nama_barang, harga, stok", table_name:="TBL_BARANG", where:="nama_barang='Aqua'")
        DataGridView2.DataSource = Ds.Tables("TBL_BARANG")

    End Sub
End Class
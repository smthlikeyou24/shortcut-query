Public Class INSERT
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Sub kondisiAwal()
        Dim dg As New datagrid
        dg.selectAll(table_name:="TBL_USER")
        DataGridView1.DataSource = Ds.Tables("TBL_USER")
    End Sub

    Private Sub INSERT_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kondisiAwal()
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        Dim ins As New inserts

        ins.insertParams(table_name:="TBL_USER", keyword:="username, email, password", values:="@username, @email, @password")
        Cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@email", TextBox2.Text)
        Cmd.Parameters.AddWithValue("@password", TextBox3.Text)
        Cmd.ExecuteNonQuery()

        MsgBox("Data berhasil terinsert")
        kondisiAwal()
    End Sub
    Dim username As String
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedIndex As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            username = selectedIndex.Cells("username").Value.ToString

            Dim sl As New selects
            sl.selectWhere(table_name:="TBL_USER", where:="username='" & username & "'")
            If Rd.HasRows Then
                Rd.Read()
                TextBox1.Text = Rd.Item("username")
                TextBox2.Text = Rd.Item("email")
                TextBox3.Text = Rd.Item("password")
            Else
                MsgBox("Pilih user")
            End If

        Else
            MsgBox("Pilih user")
        End If
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Dim dl As New delete

        dl.deleteWhere(table_name:="TBL_USER", where:="username='" & username & "'")

        MsgBox("User berhasil dihapus")

        kondisiAwal()
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        Dim upd As New update

        upd.updateWhere(table_name:="TBL_USER", sets:="username=@username, email=@email, password=@password", where:="username='" & username & "'")
        Cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@email", TextBox2.Text)
        Cmd.Parameters.AddWithValue("@password", TextBox3.Text)
        Cmd.ExecuteNonQuery()

        MsgBox("User di update")
        kondisiAwal()
    End Sub
End Class
Imports System.Data.SqlClient

Module ModuleConn

    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Conn As SqlConnection

    Public MyDB As String

    Sub Koneksi()
        MyDB = "data source= LAPTOP-2J88KB4O\SQLEXPRESS01; initial catalog=lks1_desktop; integrated security= true;"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Public Class datagrid
        Sub selectAll(table_name As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT * FROM  " & table_name & " ", Conn)
            Da = New SqlDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, table_name)
        End Sub

        Sub selectAllWhere(table_name As String, where As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT * FROM " & table_name & " WHERE " & where & " ", Conn)
            Da = New SqlDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, table_name)
        End Sub

        Sub selectColumn(table_name As String, column_name As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT " & column_name & " FROM " & table_name & " ", Conn)
            Da = New SqlDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, table_name)
        End Sub

        Sub selectColumnWhere(table_name As String, column_name As String, where As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT " & column_name & " FROM " & table_name & " WHERE " & where & " ", Conn)
            Da = New SqlDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, "TBL_BARANG")
        End Sub
    End Class

    Public Class selects
        Sub selectAll(table_name As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT * FROM " & table_name & " ", Conn)
            Rd = Cmd.ExecuteReader
        End Sub

        Sub selectWhere(table_name As String, where As String)
            Call Koneksi()
            Cmd = New SqlCommand("SELECT * FROM " & table_name & " WHERE " & where & " ", Conn)
            Rd = Cmd.ExecuteReader
        End Sub
    End Class

    Public Class inserts
        Sub insertParams(table_name As String, keyword As String, values As String)
            Call Koneksi()
            Cmd = New SqlCommand("INSERT INTO " & table_name & " (" & keyword & ") VALUES (" & values & ") ", Conn)
        End Sub
    End Class

    Public Class delete
        Sub deleteWhere(table_name As String, where As String)
            Call Koneksi()
            Cmd = New SqlCommand("DELETE " & table_name & " WHERE " & where & " ", Conn)
            Cmd.ExecuteNonQuery()
        End Sub
    End Class

    Public Class update
        Sub updateWhere(table_name As String, sets As String, where As String)
            Call Koneksi()
            Cmd = New SqlCommand("UPDATE " & table_name & " SET " & sets & " WHERE " & where & " ", Conn)
        End Sub
    End Class
End Module

Imports MySql.Data.MySqlClient
Public Class FrmPrecioProducto
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sCadena As String = "server=localhost;database=precios;user id=root;password=ABC123abc;port=3306;"
        Dim conn As New MySqlConnection(sCadena)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        conn.Close()

    End Sub
End Class

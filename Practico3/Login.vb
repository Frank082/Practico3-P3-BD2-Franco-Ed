Public Class frmLogin




    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = TextUsuario.Text
        contraseña = TextContraseña.Text
        If (usuario = "franco") And (contraseña = "123") Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Error en Usuario o Contraseña")

        End If
        TextUsuario.Text = ""
        TextContraseña.Text = ""
    End Sub

    Private Sub btn_CerrLog_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub TextContraseña_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
End Class
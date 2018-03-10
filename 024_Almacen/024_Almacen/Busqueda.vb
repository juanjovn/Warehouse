Public Class frmBusq
    Public codBus As Integer
    Public MODO As Integer = 1 '1 para busqueda, 2 para bajas
    Private Sub txtBus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBus.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAcepBusq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcepBusq.Click
        'Comprubea si existe el archivoo
        If My.Computer.FileSystem.FileExists(Almacen.rutaAlmacen) Then
            If txtCodBus.Text = "" Then
                MsgBox("Debe introducir un codigo", vbInformation, "Busqueda")
                txtCodBus.Focus()
            ElseIf CInt(txtCodBus.Text) = 0 Then
                MsgBox("El codigo debe ser mayor que cero", vbInformation, "Busqueda")
                txtCodBus.Focus()
            Else
                codBus = CInt(txtCodBus.Text)
                FrmAlta.OPCION_VISUALIZACION = 2
                MODO = 1
                FrmAlta.ShowDialog()
                txtCodBus.Focus()
                txtCodBus.SelectAll()
            End If
        Else
            MsgBox("No existe archivo de almcen. Consulte a su proveedor de software para mas informacion.", vbInformation, "Busqueda")
        End If

    End Sub

    Private Sub frmBusq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Shown
        MODO = 1
        txtCodBus.Clear()
        txtCodBus.Focus()
    End Sub

    Private Sub btnDarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarBaja.Click
        If txtCodBus.Text = "" Then
            MsgBox("Debe introducir un codigo", vbInformation, "Bajas")
            txtCodBus.Focus()
        ElseIf CInt(txtCodBus.Text) = 0 Then
            MsgBox("El codigo debe ser mayor que cero", vbInformation, "Bajas")
            txtCodBus.Focus()
        Else
            codBus = CInt(txtCodBus.Text)
            MODO = 2
            FrmAlta.OPCION_VISUALIZACION = 2
            FrmAlta.ShowDialog()
            txtCodBus.Focus()
            txtCodBus.SelectAll()
        End If
    End Sub

    Private Sub btnVolvBusq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolvBusq.Click
        Me.Close()
    End Sub
End Class
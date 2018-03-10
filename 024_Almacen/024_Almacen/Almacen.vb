'Altas
'Desplazadores
'Busquedas
'Bajas
'Edicion
'Exportacion

Public Class Almacen
    Public rutaAlmacen As String = "..\..\Datos\almacen.dat" 'archivo donde guardaremos los articulos de nuestro almacen
    Dim ficAlm As Integer
    Dim art As Articulo 'objeto articulo
    Private Sub Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        If Not My.Computer.FileSystem.FileExists(rutaAlmacen) Then 'Comprueba si no existe el archivo y desactiva controles
            'Desactivar botonoes si no hay archivo
            btnBaja.Enabled = False
            btnBuscar.Enabled = False
            btnLis.Enabled = False
            btnExp.Enabled = False
        ElseIf (FileLen(rutaAlmacen)) < 80 Then
            'si existe el archivo pero no hay registros tambien desactivamos botones
            btnBaja.Enabled = False
            btnBuscar.Enabled = False
            btnLis.Enabled = False
            btnExp.Enabled = False
        Else
            'Activacion de todos los botones del menu
            btnBaja.Enabled = True
            btnBuscar.Enabled = True
            btnLis.Enabled = True
            btnExp.Enabled = True
        End If
    End Sub

    'Detecta cuando se cierra el formulario y gestiona el comportamiento
    Private Sub Almacen_Cierre(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Seguro que desea salir?", vbYesNo, "Salir") = vbYes Then
            e.Cancel = False 'sale del programa
        Else
            e.Cancel = True 'regresa a la ventana
        End If
    End Sub

    'Lanza formulario para dar de alta un articulo
    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        'Comprubea si existe el archivo y si no lo crea avisando al usuario
        If Not My.Computer.FileSystem.FileExists(rutaAlmacen) Then
            MsgBox("No existe archivo de almcen, se creará uno nuevo. Consulte a su proveedor de software para mas informacion", vbInformation, "Alta")
            ficAlm = FreeFile()
            FileOpen(ficAlm, rutaAlmacen, OpenMode.Random)
            FileClose(ficAlm)
        End If
        FrmAlta.OPCION_VISUALIZACION = 1 'Abrir en modo altas
        FrmAlta.ShowDialog()
    End Sub

    'Lanza el formulario de busqueda y configura los botones
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        frmBusq.Text = "Busqueda"
        frmBusq.btnAcepBusq.Visible = True
        frmBusq.btnDarBaja.Visible = False
        frmBusq.ShowDialog()
    End Sub

    'Lanza el formulario de listado. Si este boton esta visible quiere decir que ya se ha comprobado que existe el archivo
    Private Sub btnLis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLis.Click
        'Abrimos archivo
        ficAlm = FreeFile()
        FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , 80)

        For i As Integer = 1 To (FileLen(rutaAlmacen) / Len(art)) ' recorremos el archivo buscando el primer elemento
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, i)
            If art.codArt <> 0 Then
                frmBusq.codBus = art.codArt 'Almacenamos el valor del codigo a visualizar
                Exit For
            End If
        Next
        'Cierre de archivo
        FileClose(ficAlm)
        'Lanzamos visualizacion del formulario del articulo
        FrmAlta.OPCION_VISUALIZACION = 2
        FrmAlta.ShowDialog()
    End Sub

    'Salir del programa
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Lanza el formulario de busqueda con pequeñas modificaciones para pedir codigo de articulo a dar de baja
    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        frmBusq.Text = "Baja"
        frmBusq.btnAcepBusq.Visible = False
        frmBusq.btnDarBaja.Visible = True
        frmBusq.ShowDialog()
    End Sub

    'Lanza el formulario de exportacion
    Private Sub btnExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp.Click
        FrmExportar.ShowDialog()
    End Sub
End Class

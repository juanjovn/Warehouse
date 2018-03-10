Public Class FrmAlta
    Dim rutaProve As String = "..\..\Datos\proveedores.dat" 'archivo de codigos de proveedores y nombres
    Dim rutaAlmacen As String = "..\..\Datos\almacen.dat" 'archivo donde guardaremos los articulos de nuestro almacen
    Dim ficAlm As Integer
    Dim art As Articulo 'Instacia un objeto de tipo articulo definido en una structure
    'Booleana para detectar cuando cerrar el formulario manualment por codigo, para distinguir dentro del evento de cierre
    'Si cierre el usuario o el programador por codigo
    Dim CIERRE_MANUAL As Boolean = False
    Public OPCION_VISUALIZACION As Integer = 1 'Controla el tipo de visualizacion del formulario. Se usara una select case para controlar los elementos del formulario segun el valor de esta
    Public PRIM_POS = 1 'Almacena el codigo de la primera posicion con registro

    'Instrucciones cuando se carga el formulario
    Private Sub FrmAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        Select Case OPCION_VISUALIZACION
            Case 1 'Pantalla de alta
                limpForm()
                CIERRE_MANUAL = False
                btnCanceAlta.Visible = True
                btnAcepAlta.Visible = True
                btnEditar.Visible = False
                btnSalir.Visible = False
                Me.Text = "Alta" 'Cambia el titulo
                grpArt.Enabled = True
                txtCod.Enabled = True
                btnInicio.Visible = False
                btnAnterior.Visible = False
                btnSiguiente.Visible = False
                btnFinal.Visible = False
            Case 2 'Pantalla de resultado de busqueda y edicion
                actPriPos()
                btnCanceAlta.Visible = False
                btnAcepAlta.Visible = False
                btnEditar.Visible = True
                btnSalir.Visible = True
                Me.Text = "Articulos" 'Cambia el titulo
                btnInicio.Visible = True
                btnAnterior.Visible = True
                btnSiguiente.Visible = True
                btnFinal.Visible = True
                grpArt.Enabled = False
                txtCod.Enabled = False
                busqueda()

        End Select
    End Sub

    'Detecta cuando se cierra el formulario y gestiona el comportamiento
    Private Sub Alta_Cierre(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not CIERRE_MANUAL Then
            If MsgBox("Seguro que desea salir?", vbYesNo, "Cancelar") = vbYes Then
                e.Cancel = False 'sale del formulario de altas
            Else
                e.Cancel = True 'regresa a la ventana
            End If
        End If
    End Sub

    'Hace que solo se puedan meter numeros en el campo articulo y proveedor
    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress, txtProve.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub

    'Hace que solo se puedan meter numeros, puntos y signo menos en el campo stock  
    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If InStr("0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub
    'Hace que solo se puedan meter numeros y puntos menos en el campo stock minimo, precio de compra y pvp
    Private Sub txtStockMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockMin.KeyPress, txtPrecComp.KeyPress, txtPVP.KeyPress
        If InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub
    'Gestiona el comportamiento del click en boton cancelar
    Private Sub btnCanceAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanceAlta.Click
        If OPCION_VISUALIZACION = 1 Then 'ALTAS
            Me.Close() 'cerrar formulario
        ElseIf OPCION_VISUALIZACION = 2 Then 'EDICION
            grpArt.Enabled = False
            btnEditar.Visible = True
            btnSalir.Visible = True
            btnAcepAlta.Visible = False
            btnCanceAlta.Visible = False
            btnInicio.Visible = True
            btnAnterior.Visible = True
            btnSiguiente.Visible = True
            btnFinal.Visible = True
            rellenaDatos()
        End If
    End Sub
    'Gestiona el click en el boton aceptar y hace las comprobaciones correspondientes a cada campo del registro a guardar
    Private Sub btnAcepAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcepAlta.Click
        If validaFormulario() Then
            'Almacena los valores del formulario en un objeto
            cargaDatos()
            'Preparamos el archivo para grabar datos
            Dim pos As Integer = art.codArt
            ficAlm = FreeFile()
            FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , Len(art))
            FilePut(ficAlm, art, pos)
            FileClose(ficAlm)
            actPriPos()
            If OPCION_VISUALIZACION = 1 Then 'pantalla de altas
                If MsgBox("Articulo guardado con exito. ¿Desea introducir un nuevo articulo?", vbYesNo, "Alta") = vbYes Then
                    limpForm()
                Else
                    CIERRE_MANUAL = True
                    Me.Close()
                End If

            ElseIf OPCION_VISUALIZACION = 2 Then 'Pantalla edicion
                MsgBox("Articulo modificado con exito", vbInformation, "Aceptar")
                grpArt.Enabled = False
                btnEditar.Visible = True
                btnSalir.Visible = True
                btnAcepAlta.Visible = False
                btnCanceAlta.Visible = False
                btnInicio.Visible = True
                btnAnterior.Visible = True
                btnSiguiente.Visible = True
                btnFinal.Visible = True
            Else
                CIERRE_MANUAL = True
                Me.Close()
            End If

        End If

    End Sub

    'Funcion que devuelve un boolean segun el codigo de articulo este en el archivo o no
    Public Function codigoRepetido(ByVal cod As Integer) As Boolean
        Dim rep As Boolean = False 'Variable boolean que sera la que devuelva la funcion
        'Comparamos el codigo con el resultado de dividir la longitud total de archivo entre el tamaño del registro. Si es mayor es seguro que no existe
        If cod > (FileLen(rutaAlmacen) / Len(art)) Then
            rep = False
        Else
            'Necesitamos abrir archivo y comprobar si el registro con ese codigo es distinto de cero
            ficAlm = FreeFile()
            FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , Len(art))
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, cod)

            If art.codArt = 0 Then
                'Registro libre, se puede escribir
                rep = False
            ElseIf btnEditar.Visible = False And OPCION_VISUALIZACION = 2 Then 'si estamos EDITANDO el boton editar es invisible
                rep = False
            Else
                'Registro ocupado, no se puede escribir
                rep = True
            End If
            FileClose(ficAlm)
        End If

        'Valor que devuelve la funcion
        Return rep

    End Function

    'Funcion que comprueba si el codigo de proveedor está en el archivo de proveedores y devuelve un string con su nombre
    Public Function existeProve(ByRef prove As Integer) As String
        If My.Computer.FileSystem.FileExists(rutaProve) Then 'Comprueba si existe el archivo
            'Declaracion de variables para almacenar valores del archivo
            Dim ficProve As Integer
            Dim codProve As Integer
            Dim nomProve As String = ""
            ficProve = FreeFile()
            FileOpen(ficProve, rutaProve, OpenMode.Input)
            'Buscamos codigo mientras no lleguemos al final de archivo
            While Not EOF(ficProve)
                Input(ficProve, codProve)
                Input(ficProve, nomProve)
                If codProve = prove Then
                    'Si tenemos coincidencia cerramos archivo, retornamos valor y salimos del while
                    FileClose(ficProve)
                    Return nomProve
                    Exit While
                End If
                If EOF(ficProve) Then
                    'Si llega al final de archivo es que no está el proveedor con ese codigo
                    FileClose(ficProve)
                    Return "NO EXISTE"
                End If
            End While
        Else
            MsgBox("No existe archivo de proveedores, consulte con su administrador.", vbExclamation, "Aceptar")
            Me.Close()
        End If
    End Function

    'Metodo para cuando se sale el foco de la textbox de proveedor compruebe si existe ese proveedor y visualice el nombre
    Private Sub txtProve_FocoFuera(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProve.TextChanged
        'comprobar en el archivo el proveedor y actualizar la textbox de nombre
        If txtProve.Text <> "" Then
            txtNomProve.Text = existeProve(txtProve.Text)
        Else
            txtNomProve.Clear()
        End If
    End Sub

    'Funcion que realiza comprobaciones en los distintos campos para asegurarse de introducir un registro de articulo
    'correcto en el archivo segun los requerimientos del proyecto. Devuelve un boolean
    Function validaFormulario() As Boolean
        Dim val As Boolean = False 'Variable de control que sera la que devuelva la funcion
        If txtCod.Text = "" Then
            MsgBox("Debe introducirse un codigo", vbExclamation, "Aceptar")
            txtCod.Focus()
        ElseIf CInt(txtCod.Text) = 0 Then
            MsgBox("El codigo no puede ser cero", vbExclamation, "Aceptar")
            txtCod.Focus()
            txtCod.SelectAll()
        ElseIf codigoRepetido(CInt(txtCod.Text)) Then 'busca en el archivo si existe ese articulo con ese codigo
            MsgBox("El codigo ya existe", vbExclamation, "Aceptar")
            txtCod.Focus()
            txtCod.SelectAll()
        ElseIf txtDesc.Text = "" Then
            MsgBox("Debe introducirse una descripcion", vbExclamation, "Aceptar")
            txtDesc.Focus()
        ElseIf txtProve.Text = "" Then
            MsgBox("Debe introducirse un proveedor", vbExclamation, "Aceptar")
            txtProve.Focus()
        ElseIf existeProve(txtProve.Text) = "NO EXISTE" Then 'Busca en el archivo de proveedores si existe ese codigo
            MsgBox("No existe proveedor con ese codigo", vbExclamation, "Aceptar")
            txtProve.Focus()
            txtProve.SelectAll()
        ElseIf txtPVP.Text = "" Or txtStock.Text = "" Or txtStockMin.Text = "" Or txtPrecComp.Text = "" Then
            'si el usuario deja algun campo vacio damos opcion a que se guarden con valor cero, facilitando la comodidad de introduccion
            If MsgBox("En los campos que se han dejado vacios se guardara 0 por defecto. ¿Desea confirmar?", vbYesNo, "Aceptar") = vbNo Then
                'Si no quiere confirmar buscamos un vacio para lanzar el foco
                If txtStock.Text = "" Then
                    txtStock.Focus()
                    txtStock.SelectAll()
                ElseIf txtStockMin.Text = "" Then
                    txtStockMin.Focus()
                    txtStockMin.SelectAll()
                ElseIf txtPrecComp.Text = "" Then
                    txtPrecComp.Focus()
                    txtPrecComp.SelectAll()
                ElseIf txtPVP.Text = "" Then
                    txtPVP.Focus()
                    txtPVP.SelectAll()
                End If
            Else
                'Si quiere confirmar ponemos a cero los que encontremos vacios      
                If txtStock.Text = "" Then
                    txtStock.Text = 0
                End If
                If txtStockMin.Text = "" Then
                    txtStockMin.Text = 0
                End If
                If txtPrecComp.Text = "" Then
                    txtPrecComp.Text = 0
                End If
                If txtPVP.Text = "" Then
                    txtPVP.Text = 0
                End If
                val = True
            End If
            'Controlamos los limites en los valores de stocks y precios
        ElseIf CSng(txtStock.Text) < -9999.99 Then
            MsgBox("Stock no puede ser menor a -9999.99", vbExclamation, "Aceptar")
            txtStock.Focus()
            txtStock.SelectAll()
        ElseIf CSng(txtStock.Text) > 9999.99 Then
            MsgBox("Stock no puede ser mayor a 9999.99", vbExclamation, "Aceptar")
            txtStock.Focus()
            txtStock.SelectAll()
        ElseIf CSng(txtStockMin.Text) > 9999.99 Then
            MsgBox("Stock minimo no puede ser mayor a 9999.99", vbExclamation, "Aceptar")
            txtStockMin.Focus()
            txtStockMin.SelectAll()
        ElseIf CDec(txtPrecComp.Text) > 9999.99 Then
            MsgBox("El precio de compra no puede ser mayor a 9999.99", vbExclamation, "Aceptar")
            txtPrecComp.Focus()
            txtPrecComp.SelectAll()
        ElseIf CDec(txtPVP.Text) > 99999.99 Then
            MsgBox("El PVP no puede ser mayor a 99999.99", vbExclamation, "Aceptar")
            txtPVP.Focus()
            txtPVP.SelectAll()
        Else
            val = True 'si llega hasta aqui todos los datos son correctos para guardar en el archivo

        End If

        Return val

    End Function

    'Subrutina para almacenar los valores del formulario en un objeto articulo.
    'Esta subrutina solo se debe usar cuando los valores del formularios estan validados
    Sub cargaDatos()
        art.codArt = CInt(txtCod.Text)
        art.desc = txtDesc.Text
        art.prove = CInt(txtProve.Text)
        art.stock = CSng(txtStock.Text)
        art.stock_min = CSng(txtStockMin.Text)
        art.pcomp = CDec(txtPrecComp.Text)
        art.pvp = CDec(txtPVP.Text)
        If checkBaja.Checked Then
            art.cb = True
        Else
            art.cb = False
        End If

    End Sub

    'Pasa los datos del objeto art al formulario
    Sub rellenaDatos()
        txtCod.Text = art.codArt
        txtDesc.Text = Trim(art.desc)
        txtProve.Text = art.prove
        txtStock.Text = art.stock
        txtStockMin.Text = art.stock_min
        txtPrecComp.Text = art.pcomp
        txtPVP.Text = art.pvp
        txtNomProve.Text = existeProve(txtProve.Text)
        checkBaja.Checked = art.cb
        If checkBaja.Checked Then
            grpArt.BackColor = Color.Tomato
        Else
            grpArt.BackColor = Color.Transparent
        End If
    End Sub

    'Subrutina para limpiar el formulario
    Sub limpForm()
        txtCod.Clear()
        txtDesc.Clear()
        txtProve.Clear()
        txtNomProve.Clear()
        txtStock.Clear()
        txtStockMin.Clear()
        txtPrecComp.Clear()
        txtPVP.Clear()
        txtCod.Focus()
        checkBaja.Checked = False
    End Sub

    'Proceso para poner automaticamente el doble del precio de compra en pvp
    Private Sub txtPrecComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecComp.LostFocus
        If txtPrecComp.Text <> "" Then
            If txtPVP.Text = "" Then
                txtPVP.Text = 2 * CDec(txtPrecComp.Text)
            End If
        End If
    End Sub

    Sub busqueda()
        If codigoRepetido(frmBusq.codBus) Then
            rellenaDatos()
            If frmBusq.MODO = 2 Then
                darBaja()
            End If
        Else
            Me.Visible = False
            MsgBox("No existe articulo con ese codigo", vbExclamation, "Buscar")
            CIERRE_MANUAL = True
            Me.Close()
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        grpArt.Enabled = True
        btnEditar.Visible = False
        btnAcepAlta.Visible = True
        btnCanceAlta.Visible = True
        btnSalir.Visible = False
        btnInicio.Visible = False
        btnAnterior.Visible = False
        btnSiguiente.Visible = False
        btnFinal.Visible = False
        txtDesc.Focus()
        txtDesc.SelectAll()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub checkBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBaja.CheckedChanged
        If checkBaja.Checked Then
            grpArt.BackColor = Color.Tomato
        Else
            grpArt.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub btnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinal.Click
        frmBusq.codBus = (FileLen(rutaAlmacen) / Len(art))
        busqueda()
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        ficAlm = FreeFile()
        FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , 80)

        For i As Integer = 1 To (FileLen(rutaAlmacen) / Len(art))
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, i)
            If art.codArt <> 0 Then
                frmBusq.codBus = art.codArt
                Exit For
            End If
        Next
        FileClose(ficAlm)
        busqueda()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If CInt(txtCod.Text) < (FileLen(rutaAlmacen) / Len(art)) Then
            ficAlm = FreeFile()
            FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , 80)

            For i As Integer = CInt(txtCod.Text) + 1 To (FileLen(rutaAlmacen) / Len(art))
                'almacena el valor de la posicion cod en el objeto art
                FileGet(ficAlm, art, i)
                If art.codArt <> 0 Then
                    frmBusq.codBus = art.codArt
                    Exit For
                End If
            Next
            FileClose(ficAlm)
            busqueda()
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If CInt(txtCod.Text) > PRIM_POS Then
            ficAlm = FreeFile()
            FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , 80)

            For i As Integer = CInt(txtCod.Text) - 1 To PRIM_POS Step -1
                FileGet(ficAlm, art, i)
                If art.codArt <> 0 Then
                    frmBusq.codBus = art.codArt
                    Exit For
                End If
            Next
            FileClose(ficAlm)
            busqueda()
        End If
    End Sub

    'Sub que comprueba cual es el primer registro con contenido y actualiza la variable entera PRIM_POS
    Private Sub actPriPos()
        ficAlm = FreeFile()
        FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , 80)

        For i As Integer = 1 To (FileLen(rutaAlmacen) / Len(art))
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, i)
            If art.codArt <> 0 Then
                PRIM_POS = i
                Exit For
            End If
        Next
        FileClose(ficAlm)
    End Sub

    'Sub para dar de baja el articulo que está presentado en el formulario
    Sub darBaja()
        Me.Left = 860
        If checkBaja.Checked = False Then
            If MsgBox("Desea dar de baja este articulo?", vbYesNo, "Bajas") = vbYes Then
                Me.CenterToScreen()
                checkBaja.Checked = True
                cargaDatos()
                'Preparamos el archivo para grabar datos
                Dim pos As Integer = art.codArt
                ficAlm = FreeFile()
                FileOpen(ficAlm, rutaAlmacen, OpenMode.Random, , , Len(art))
                FilePut(ficAlm, art, pos)
                FileClose(ficAlm)
                frmBusq.MODO = 1

            Else
                Me.CenterToScreen()
                CIERRE_MANUAL = True
                Me.Close()
            End If
        Else
            MsgBox("Articulo ya de baja!", MsgBoxStyle.Exclamation, "Bajas")
            Me.CenterToScreen()
            CIERRE_MANUAL = True
            Me.Close()
        End If
    End Sub
End Class
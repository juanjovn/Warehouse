Public Class FrmExportar
    Dim rutCsv As String = "..\..\Datos\almacen.csv"
    Dim rutTxt As String = "..\..\Datos\almacen.txt"
    Dim rutTemp As String = "..\..\Datos\almacen.tmp"
    Dim rutaCalc As String = "C:\Program Files (x86)\OpenOffice 4\program\scalc.exe "
    Dim ficAlm As Integer
    Dim ficTxt As Integer
    Dim ficTemp As Integer
    Dim art As Articulo
    Dim nomProve As String
    Dim nomBaja As String
    Private Sub btnVolvExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolvExp.Click
        Me.Close()
        Almacen.Visible = True
    End Sub

    Private Sub FrmExportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Almacen.Visible = False
    End Sub

    Private Sub btnCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSV.Click
        Dim archivo As System.IO.StreamWriter
        
        If My.Computer.FileSystem.FileExists(rutCsv) Then
            Kill(rutCsv)
            Me.Close()
        End If
        archivo = My.Computer.FileSystem.OpenTextFileWriter(rutCsv, True)

        ficAlm = FreeFile()
        FileOpen(ficAlm, Almacen.rutaAlmacen, OpenMode.Random, , , 80)

        For i As Integer = 1 To (FileLen(Almacen.rutaAlmacen) / Len(art))
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, i)

            If art.codArt <> 0 Then
                If art.cb Then
                    nomBaja = "Si"
                Else
                    nomBaja = "No"
                End If
                nomProve = FrmAlta.existeProve(art.prove)
                archivo.WriteLine(art.codArt & ";" & art.desc & ";" & art.prove & ";" & nomProve & ";" & art.stock & ";" & art.stock_min & ";" & art.pcomp & ";" & art.pvp & ";" & nomBaja)

            End If
        Next
        archivo.Close()
        FileClose(ficAlm)
        Me.Close()
        Almacen.Visible = True
        Shell(rutaCalc & rutCsv, AppWinStyle.MaximizedFocus)


    End Sub

    Private Sub btnTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTxt.Click
        If My.Computer.FileSystem.FileExists(rutTxt) Then
            Kill(rutTxt)
            Me.Close()
        End If
        'Creamos el archivo txt
        ficTxt = FreeFile()
        FileOpen(ficTxt, rutTxt, OpenMode.Output)
        ficAlm = FreeFile()
        FileOpen(ficAlm, Almacen.rutaAlmacen, OpenMode.Random, , , 80)

        For i As Integer = 1 To (FileLen(Almacen.rutaAlmacen) / Len(art))
            'almacena el valor de la posicion cod en el objeto art
            FileGet(ficAlm, art, i)

            If art.codArt <> 0 Then
                If art.cb Then
                    nomBaja = "Si"
                Else
                    nomBaja = "No"
                End If
                nomProve = FrmAlta.existeProve(art.prove)
                WriteLine(ficTxt, Format(art.codArt, "000000"), SPC(1), Trim(art.desc), SPC(25 - Len(Trim(art.desc))), Format(art.prove, "000"), SPC(1), nomProve, SPC(67 - Len(nomProve)), SPC(1), Format(art.stock, "0000.00"), SPC(1), Format(art.stock_min, "0000.00"), SPC(1), Format(art.pcomp, "0000.00"), SPC(1), Format(art.pvp, "0000.00"), SPC(1), nomBaja)

            End If
        Next
        FileClose(ficAlm)
        FileClose(ficTxt)



        MsgBox("Arquivo creado con exito en " & rutTxt, vbInformation, "Exportar")
        Me.Close()
        Almacen.Visible = True
        Shell("notepad " & rutTxt, AppWinStyle.NormalFocus)
    End Sub
End Class
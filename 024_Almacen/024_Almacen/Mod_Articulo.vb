'Structure de articulo donde definimos los campos
'Codigo articulo int 999999
'La descripcion no puede quedar sin contenido
'Proveedor entre 1 y 999. Validar que existe mirando en un archivo secuencial
'Stock entre -9999.99 e +9999.99
'Stock minimo no puede ser negativo
'Precio 9999.99
'PVP 99999.99

Module stru
    Structure Articulo
        Dim codArt As Integer 'codigo articulo 4 bytes
        <VBFixedString(30)> Dim desc As String 'descripcion 30 bytes
        Dim prove As Integer 'proveedor 4 bytes
        Dim stock As Single 'stock 4 bytes
        Dim stock_min As Single 'stock minimo 4 bytes
        Dim pcomp As Decimal ' precio de compra 16 bytes
        Dim pvp As Decimal 'pvp, por defecto el doble de pcomp 16 bytes
        Dim cb As Boolean 'campo baja
    End Structure
End Module

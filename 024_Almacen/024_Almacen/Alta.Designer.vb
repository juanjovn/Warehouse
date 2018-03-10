<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtProve = New System.Windows.Forms.TextBox()
        Me.lblProve = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStockMin = New System.Windows.Forms.Label()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.lblPrecComp = New System.Windows.Forms.Label()
        Me.txtPrecComp = New System.Windows.Forms.TextBox()
        Me.lblPVP = New System.Windows.Forms.Label()
        Me.txtPVP = New System.Windows.Forms.TextBox()
        Me.btnAcepAlta = New System.Windows.Forms.Button()
        Me.btnCanceAlta = New System.Windows.Forms.Button()
        Me.txtNomProve = New System.Windows.Forms.TextBox()
        Me.lblNomProve = New System.Windows.Forms.Label()
        Me.grpArt = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.checkBaja = New System.Windows.Forms.CheckBox()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.grpArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(270, 62)
        Me.txtCod.MaxLength = 6
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 29)
        Me.txtCod.TabIndex = 0
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(153, 65)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(75, 25)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Codigo"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(88, 47)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(114, 25)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Descripcion"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(244, 42)
        Me.txtDesc.MaxLength = 30
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(235, 67)
        Me.txtDesc.TabIndex = 3
        '
        'txtProve
        '
        Me.txtProve.Location = New System.Drawing.Point(244, 138)
        Me.txtProve.MaxLength = 3
        Me.txtProve.Name = "txtProve"
        Me.txtProve.Size = New System.Drawing.Size(78, 29)
        Me.txtProve.TabIndex = 4
        Me.txtProve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProve
        '
        Me.lblProve.AutoSize = True
        Me.lblProve.Location = New System.Drawing.Point(100, 141)
        Me.lblProve.Name = "lblProve"
        Me.lblProve.Size = New System.Drawing.Size(102, 25)
        Me.lblProve.TabIndex = 5
        Me.lblProve.Text = "Proveedor"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(140, 339)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(62, 25)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(244, 336)
        Me.txtStock.MaxLength = 8
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 29)
        Me.txtStock.TabIndex = 7
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockMin
        '
        Me.lblStockMin.AutoSize = True
        Me.lblStockMin.Location = New System.Drawing.Point(72, 392)
        Me.lblStockMin.Name = "lblStockMin"
        Me.lblStockMin.Size = New System.Drawing.Size(130, 25)
        Me.lblStockMin.TabIndex = 8
        Me.lblStockMin.Text = "Stock Minimo"
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(244, 389)
        Me.txtStockMin.MaxLength = 7
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(100, 29)
        Me.txtStockMin.TabIndex = 9
        Me.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPrecComp
        '
        Me.lblPrecComp.AutoSize = True
        Me.lblPrecComp.Location = New System.Drawing.Point(65, 443)
        Me.lblPrecComp.Name = "lblPrecComp"
        Me.lblPrecComp.Size = New System.Drawing.Size(137, 25)
        Me.lblPrecComp.TabIndex = 10
        Me.lblPrecComp.Text = "Precio compra"
        '
        'txtPrecComp
        '
        Me.txtPrecComp.Location = New System.Drawing.Point(244, 440)
        Me.txtPrecComp.MaxLength = 7
        Me.txtPrecComp.Name = "txtPrecComp"
        Me.txtPrecComp.Size = New System.Drawing.Size(100, 29)
        Me.txtPrecComp.TabIndex = 11
        Me.txtPrecComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPVP
        '
        Me.lblPVP.AutoSize = True
        Me.lblPVP.Location = New System.Drawing.Point(150, 493)
        Me.lblPVP.Name = "lblPVP"
        Me.lblPVP.Size = New System.Drawing.Size(52, 25)
        Me.lblPVP.TabIndex = 12
        Me.lblPVP.Text = "PVP"
        '
        'txtPVP
        '
        Me.txtPVP.Location = New System.Drawing.Point(244, 493)
        Me.txtPVP.MaxLength = 7
        Me.txtPVP.Name = "txtPVP"
        Me.txtPVP.Size = New System.Drawing.Size(100, 29)
        Me.txtPVP.TabIndex = 13
        Me.txtPVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAcepAlta
        '
        Me.btnAcepAlta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAcepAlta.Location = New System.Drawing.Point(463, 763)
        Me.btnAcepAlta.Name = "btnAcepAlta"
        Me.btnAcepAlta.Size = New System.Drawing.Size(110, 45)
        Me.btnAcepAlta.TabIndex = 14
        Me.btnAcepAlta.Text = "Aceptar"
        Me.btnAcepAlta.UseVisualStyleBackColor = False
        '
        'btnCanceAlta
        '
        Me.btnCanceAlta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCanceAlta.Location = New System.Drawing.Point(463, 814)
        Me.btnCanceAlta.Name = "btnCanceAlta"
        Me.btnCanceAlta.Size = New System.Drawing.Size(110, 45)
        Me.btnCanceAlta.TabIndex = 15
        Me.btnCanceAlta.Text = "Cancelar"
        Me.btnCanceAlta.UseVisualStyleBackColor = False
        '
        'txtNomProve
        '
        Me.txtNomProve.Enabled = False
        Me.txtNomProve.Location = New System.Drawing.Point(244, 198)
        Me.txtNomProve.Multiline = True
        Me.txtNomProve.Name = "txtNomProve"
        Me.txtNomProve.Size = New System.Drawing.Size(235, 110)
        Me.txtNomProve.TabIndex = 16
        '
        'lblNomProve
        '
        Me.lblNomProve.AutoSize = True
        Me.lblNomProve.Location = New System.Drawing.Point(28, 201)
        Me.lblNomProve.Name = "lblNomProve"
        Me.lblNomProve.Size = New System.Drawing.Size(174, 25)
        Me.lblNomProve.TabIndex = 17
        Me.lblNomProve.Text = "Nombre proveedor"
        '
        'grpArt
        '
        Me.grpArt.Controls.Add(Me.checkBaja)
        Me.grpArt.Controls.Add(Me.txtDesc)
        Me.grpArt.Controls.Add(Me.lblNomProve)
        Me.grpArt.Controls.Add(Me.lblDesc)
        Me.grpArt.Controls.Add(Me.txtNomProve)
        Me.grpArt.Controls.Add(Me.txtProve)
        Me.grpArt.Controls.Add(Me.lblProve)
        Me.grpArt.Controls.Add(Me.lblStock)
        Me.grpArt.Controls.Add(Me.txtPVP)
        Me.grpArt.Controls.Add(Me.txtStock)
        Me.grpArt.Controls.Add(Me.lblPVP)
        Me.grpArt.Controls.Add(Me.lblStockMin)
        Me.grpArt.Controls.Add(Me.txtPrecComp)
        Me.grpArt.Controls.Add(Me.txtStockMin)
        Me.grpArt.Controls.Add(Me.lblPrecComp)
        Me.grpArt.Location = New System.Drawing.Point(26, 123)
        Me.grpArt.Name = "grpArt"
        Me.grpArt.Size = New System.Drawing.Size(547, 621)
        Me.grpArt.TabIndex = 18
        Me.grpArt.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSalir.Location = New System.Drawing.Point(463, 814)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 45)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar.Location = New System.Drawing.Point(463, 763)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(110, 45)
        Me.btnEditar.TabIndex = 19
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'checkBaja
        '
        Me.checkBaja.AutoSize = True
        Me.checkBaja.Location = New System.Drawing.Point(155, 563)
        Me.checkBaja.Name = "checkBaja"
        Me.checkBaja.Size = New System.Drawing.Size(172, 29)
        Me.checkBaja.TabIndex = 21
        Me.checkBaja.Text = "Articulo de baja"
        Me.checkBaja.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinal.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinal.ForeColor = System.Drawing.Color.Black
        Me.btnFinal.Location = New System.Drawing.Point(363, 763)
        Me.btnFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(80, 80)
        Me.btnFinal.TabIndex = 25
        Me.btnFinal.Text = ">|"
        Me.btnFinal.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnSiguiente.Location = New System.Drawing.Point(243, 763)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(80, 80)
        Me.btnSiguiente.TabIndex = 24
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.ForeColor = System.Drawing.Color.Black
        Me.btnAnterior.Location = New System.Drawing.Point(148, 763)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(80, 80)
        Me.btnAnterior.TabIndex = 23
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.Black
        Me.btnInicio.Location = New System.Drawing.Point(26, 763)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(80, 80)
        Me.btnInicio.TabIndex = 22
        Me.btnInicio.Text = "|<"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'FrmAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(629, 1254)
        Me.Controls.Add(Me.btnFinal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.grpArt)
        Me.Controls.Add(Me.btnCanceAlta)
        Me.Controls.Add(Me.btnAcepAlta)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta"
        Me.grpArt.ResumeLayout(False)
        Me.grpArt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtProve As System.Windows.Forms.TextBox
    Friend WithEvents lblProve As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMin As System.Windows.Forms.Label
    Friend WithEvents txtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecComp As System.Windows.Forms.Label
    Friend WithEvents txtPrecComp As System.Windows.Forms.TextBox
    Friend WithEvents lblPVP As System.Windows.Forms.Label
    Friend WithEvents txtPVP As System.Windows.Forms.TextBox
    Friend WithEvents btnAcepAlta As System.Windows.Forms.Button
    Friend WithEvents btnCanceAlta As System.Windows.Forms.Button
    Friend WithEvents txtNomProve As System.Windows.Forms.TextBox
    Friend WithEvents lblNomProve As System.Windows.Forms.Label
    Friend WithEvents grpArt As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents checkBaja As System.Windows.Forms.CheckBox
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
End Class

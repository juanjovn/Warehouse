<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnLis = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlta
        '
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Location = New System.Drawing.Point(12, 12)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(450, 100)
        Me.btnAlta.TabIndex = 0
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(12, 224)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(224, 100)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Location = New System.Drawing.Point(12, 118)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(450, 100)
        Me.btnBaja.TabIndex = 2
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnLis
        '
        Me.btnLis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLis.Location = New System.Drawing.Point(238, 224)
        Me.btnLis.Name = "btnLis"
        Me.btnLis.Size = New System.Drawing.Size(224, 100)
        Me.btnLis.TabIndex = 3
        Me.btnLis.Text = "Listado"
        Me.btnLis.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExp.Location = New System.Drawing.Point(12, 330)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(224, 100)
        Me.btnExp.TabIndex = 4
        Me.btnExp.Text = "Exportar"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(238, 330)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(224, 100)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(480, 448)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnLis)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAlta)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Arial", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnLis As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusq
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
        Me.txtCodBus = New System.Windows.Forms.TextBox()
        Me.lblCodBus = New System.Windows.Forms.Label()
        Me.btnAcepBusq = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnVolvBusq = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCodBus
        '
        Me.txtCodBus.Location = New System.Drawing.Point(236, 124)
        Me.txtCodBus.MaxLength = 6
        Me.txtCodBus.Name = "txtCodBus"
        Me.txtCodBus.Size = New System.Drawing.Size(100, 40)
        Me.txtCodBus.TabIndex = 0
        Me.txtCodBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodBus
        '
        Me.lblCodBus.AutoSize = True
        Me.lblCodBus.Location = New System.Drawing.Point(120, 127)
        Me.lblCodBus.Name = "lblCodBus"
        Me.lblCodBus.Size = New System.Drawing.Size(111, 33)
        Me.lblCodBus.TabIndex = 1
        Me.lblCodBus.Text = "Codigo"
        '
        'btnAcepBusq
        '
        Me.btnAcepBusq.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcepBusq.Location = New System.Drawing.Point(146, 206)
        Me.btnAcepBusq.Name = "btnAcepBusq"
        Me.btnAcepBusq.Size = New System.Drawing.Size(186, 71)
        Me.btnAcepBusq.TabIndex = 2
        Me.btnAcepBusq.Text = "Buscar"
        Me.btnAcepBusq.UseVisualStyleBackColor = True
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.Location = New System.Drawing.Point(146, 206)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(186, 71)
        Me.btnDarBaja.TabIndex = 3
        Me.btnDarBaja.Text = "Dar de baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'btnVolvBusq
        '
        Me.btnVolvBusq.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolvBusq.Location = New System.Drawing.Point(146, 297)
        Me.btnVolvBusq.Name = "btnVolvBusq"
        Me.btnVolvBusq.Size = New System.Drawing.Size(186, 71)
        Me.btnVolvBusq.TabIndex = 4
        Me.btnVolvBusq.Text = "Regresar"
        Me.btnVolvBusq.UseVisualStyleBackColor = True
        '
        'frmBusq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(494, 454)
        Me.Controls.Add(Me.btnVolvBusq)
        Me.Controls.Add(Me.btnDarBaja)
        Me.Controls.Add(Me.btnAcepBusq)
        Me.Controls.Add(Me.lblCodBus)
        Me.Controls.Add(Me.txtCodBus)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBusq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodBus As System.Windows.Forms.TextBox
    Friend WithEvents lblCodBus As System.Windows.Forms.Label
    Friend WithEvents btnAcepBusq As System.Windows.Forms.Button
    Friend WithEvents btnDarBaja As System.Windows.Forms.Button
    Friend WithEvents btnVolvBusq As System.Windows.Forms.Button
End Class

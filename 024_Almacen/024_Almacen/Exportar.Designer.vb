<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportar
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
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.btnVolvExp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCSV
        '
        Me.btnCSV.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCSV.Location = New System.Drawing.Point(124, 32)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(186, 71)
        Me.btnCSV.TabIndex = 4
        Me.btnCSV.Text = "CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnTxt
        '
        Me.btnTxt.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTxt.Location = New System.Drawing.Point(124, 127)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(186, 71)
        Me.btnTxt.TabIndex = 5
        Me.btnTxt.Text = "TXT"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'btnVolvExp
        '
        Me.btnVolvExp.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolvExp.Location = New System.Drawing.Point(124, 259)
        Me.btnVolvExp.Name = "btnVolvExp"
        Me.btnVolvExp.Size = New System.Drawing.Size(186, 71)
        Me.btnVolvExp.TabIndex = 6
        Me.btnVolvExp.Text = "Volver"
        Me.btnVolvExp.UseVisualStyleBackColor = True
        '
        'FrmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 378)
        Me.Controls.Add(Me.btnVolvExp)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.btnCSV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmExportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCSV As System.Windows.Forms.Button
    Friend WithEvents btnTxt As System.Windows.Forms.Button
    Friend WithEvents btnVolvExp As System.Windows.Forms.Button
End Class

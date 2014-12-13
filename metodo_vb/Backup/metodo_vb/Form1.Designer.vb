<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSuma = New System.Windows.Forms.TextBox
        Me.label7 = New System.Windows.Forms.Label
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLlave = New System.Windows.Forms.TextBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtNIT = New System.Windows.Forms.TextBox
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.txtNoAutorizacion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtSuma
        '
        Me.txtSuma.Enabled = False
        Me.txtSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuma.Location = New System.Drawing.Point(130, 242)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(110, 23)
        Me.txtSuma.TabIndex = 48
        Me.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(12, 242)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(121, 17)
        Me.label7.TabIndex = 47
        Me.label7.Text = "Codigo de Control"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(71, 201)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 25)
        Me.btnCalcular.TabIndex = 46
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Llave de Dosificacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Monto Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Fecha Transaccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "NIT / CI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "No Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "No Autorizacion"
        '
        'txtLlave
        '
        Me.txtLlave.Location = New System.Drawing.Point(130, 175)
        Me.txtLlave.Name = "txtLlave"
        Me.txtLlave.Size = New System.Drawing.Size(110, 20)
        Me.txtLlave.TabIndex = 39
        Me.txtLlave.Text = "SeSaMo"
        Me.txtLlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(130, 149)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(110, 20)
        Me.txtMonto.TabIndex = 38
        Me.txtMonto.Text = "4968"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(130, 123)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(110, 20)
        Me.txtFecha.TabIndex = 37
        Me.txtFecha.Text = "20070610"
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNIT
        '
        Me.txtNIT.Location = New System.Drawing.Point(130, 97)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(110, 20)
        Me.txtNIT.TabIndex = 36
        Me.txtNIT.Text = "3734314017"
        Me.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(130, 71)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(110, 20)
        Me.txtNoFactura.TabIndex = 35
        Me.txtNoFactura.Text = "1503"
        Me.txtNoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoAutorizacion
        '
        Me.txtNoAutorizacion.Location = New System.Drawing.Point(130, 45)
        Me.txtNoAutorizacion.Name = "txtNoAutorizacion"
        Me.txtNoAutorizacion.Size = New System.Drawing.Size(110, 20)
        Me.txtNoAutorizacion.TabIndex = 34
        Me.txtNoAutorizacion.Text = "2901091557"
        Me.txtNoAutorizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 26)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Codigo de Control"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 273)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLlave)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.txtNoAutorizacion)
        Me.Name = "Form1"
        Me.Text = "Codigo de Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtSuma As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLlave As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNIT As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtNoAutorizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class

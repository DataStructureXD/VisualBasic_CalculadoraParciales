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
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NotaExamen = New System.Windows.Forms.TextBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.iniciar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtP1
        '
        Me.txtP1.Location = New System.Drawing.Point(53, 109)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(100, 22)
        Me.txtP1.TabIndex = 0
        '
        'txtP2
        '
        Me.txtP2.Location = New System.Drawing.Point(53, 173)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(100, 22)
        Me.txtP2.TabIndex = 1
        '
        'txtP3
        '
        Me.txtP3.Location = New System.Drawing.Point(53, 241)
        Me.txtP3.Name = "txtP3"
        Me.txtP3.Size = New System.Drawing.Size(100, 22)
        Me.txtP3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nota del Primer Parcial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nota del Segundo Parcial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nota del Tercer Parcial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nota de Examen:"
        '
        'NotaExamen
        '
        Me.NotaExamen.Location = New System.Drawing.Point(266, 109)
        Me.NotaExamen.Name = "NotaExamen"
        Me.NotaExamen.Size = New System.Drawing.Size(100, 22)
        Me.NotaExamen.TabIndex = 9
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(196, 350)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'iniciar
        '
        Me.iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iniciar.Location = New System.Drawing.Point(252, 152)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(206, 143)
        Me.iniciar.TabIndex = 12
        Me.iniciar.Text = "Comprobrar"
        Me.iniciar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(450, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Realice Su calculo para saber su nota minima"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 414)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.iniciar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.NotaExamen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtP3)
        Me.Controls.Add(Me.txtP2)
        Me.Controls.Add(Me.txtP1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtP3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NotaExamen As System.Windows.Forms.TextBox
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents iniciar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class

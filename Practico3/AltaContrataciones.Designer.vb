<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaContrataciones
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
        Me.LabIdPersona = New System.Windows.Forms.Label()
        Me.TextBoxIDPer = New System.Windows.Forms.TextBox()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.LabIdServ = New System.Windows.Forms.Label()
        Me.LabFecCont = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFinCon = New System.Windows.Forms.TextBox()
        Me.TextBoxFecCon = New System.Windows.Forms.TextBox()
        Me.TextBoxIDSer = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabIdPersona
        '
        Me.LabIdPersona.AutoSize = True
        Me.LabIdPersona.Location = New System.Drawing.Point(81, 32)
        Me.LabIdPersona.Name = "LabIdPersona"
        Me.LabIdPersona.Size = New System.Drawing.Size(63, 13)
        Me.LabIdPersona.TabIndex = 0
        Me.LabIdPersona.Text = "ID Persona:"
        '
        'TextBoxIDPer
        '
        Me.TextBoxIDPer.Location = New System.Drawing.Point(148, 29)
        Me.TextBoxIDPer.Name = "TextBoxIDPer"
        Me.TextBoxIDPer.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxIDPer.TabIndex = 2
        '
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(318, 243)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtAgregar.TabIndex = 7
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'LabIdServ
        '
        Me.LabIdServ.AutoSize = True
        Me.LabIdServ.Location = New System.Drawing.Point(81, 70)
        Me.LabIdServ.Name = "LabIdServ"
        Me.LabIdServ.Size = New System.Drawing.Size(62, 13)
        Me.LabIdServ.TabIndex = 8
        Me.LabIdServ.Text = "ID Servicio:"
        '
        'LabFecCont
        '
        Me.LabFecCont.AutoSize = True
        Me.LabFecCont.Location = New System.Drawing.Point(39, 111)
        Me.LabFecCont.Name = "LabFecCont"
        Me.LabFecCont.Size = New System.Drawing.Size(103, 13)
        Me.LabFecCont.TabIndex = 10
        Me.LabFecCont.Text = "Fecha Contratación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha Fin Contratación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxFinCon)
        Me.GroupBox1.Controls.Add(Me.TextBoxFecCon)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDSer)
        Me.GroupBox1.Controls.Add(Me.LabIdServ)
        Me.GroupBox1.Controls.Add(Me.LabFecCont)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDPer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabIdPersona)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 198)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TextBoxFinCon
        '
        Me.TextBoxFinCon.Location = New System.Drawing.Point(148, 144)
        Me.TextBoxFinCon.Name = "TextBoxFinCon"
        Me.TextBoxFinCon.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxFinCon.TabIndex = 15
        '
        'TextBoxFecCon
        '
        Me.TextBoxFecCon.Location = New System.Drawing.Point(148, 108)
        Me.TextBoxFecCon.Name = "TextBoxFecCon"
        Me.TextBoxFecCon.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxFecCon.TabIndex = 14
        '
        'TextBoxIDSer
        '
        Me.TextBoxIDSer.Location = New System.Drawing.Point(148, 67)
        Me.TextBoxIDSer.Name = "TextBoxIDSer"
        Me.TextBoxIDSer.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxIDSer.TabIndex = 12
        '
        'AltaContrataciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtAgregar)
        Me.Name = "AltaContrataciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alta Contrataciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabIdPersona As Label
    Friend WithEvents TextBoxIDPer As TextBox
    Friend WithEvents BtAgregar As Button
    Friend WithEvents LabIdServ As Label
    Friend WithEvents LabFecCont As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxFinCon As TextBox
    Friend WithEvents TextBoxFecCon As TextBox
    Friend WithEvents TextBoxIDSer As TextBox
End Class

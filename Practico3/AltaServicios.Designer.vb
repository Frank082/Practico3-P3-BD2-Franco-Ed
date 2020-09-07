<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaServicios
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
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.ComBoxTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxActivo = New System.Windows.Forms.TextBox()
        Me.TexBoxFHCreacion = New System.Windows.Forms.TextBox()
        Me.TextBoxCosMen = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabActivo = New System.Windows.Forms.Label()
        Me.LabMail = New System.Windows.Forms.Label()
        Me.LabCosMen = New System.Windows.Forms.Label()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.LabID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(326, 309)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtAgregar.TabIndex = 1
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'ComBoxTipo
        '
        Me.ComBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxTipo.FormattingEnabled = True
        Me.ComBoxTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciónes", "Informática"})
        Me.ComBoxTipo.Location = New System.Drawing.Point(132, 145)
        Me.ComBoxTipo.Name = "ComBoxTipo"
        Me.ComBoxTipo.Size = New System.Drawing.Size(222, 21)
        Me.ComBoxTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo:"
        '
        'TextBoxActivo
        '
        Me.TextBoxActivo.Location = New System.Drawing.Point(132, 229)
        Me.TextBoxActivo.Name = "TextBoxActivo"
        Me.TextBoxActivo.Size = New System.Drawing.Size(23, 20)
        Me.TextBoxActivo.TabIndex = 31
        '
        'TexBoxFHCreacion
        '
        Me.TexBoxFHCreacion.Location = New System.Drawing.Point(132, 187)
        Me.TexBoxFHCreacion.Name = "TexBoxFHCreacion"
        Me.TexBoxFHCreacion.Size = New System.Drawing.Size(222, 20)
        Me.TexBoxFHCreacion.TabIndex = 29
        '
        'TextBoxCosMen
        '
        Me.TextBoxCosMen.Location = New System.Drawing.Point(132, 103)
        Me.TextBoxCosMen.Name = "TextBoxCosMen"
        Me.TextBoxCosMen.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxCosMen.TabIndex = 27
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(132, 61)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxNom.TabIndex = 26
        '
        'LabActivo
        '
        Me.LabActivo.AutoSize = True
        Me.LabActivo.Location = New System.Drawing.Point(86, 232)
        Me.LabActivo.Name = "LabActivo"
        Me.LabActivo.Size = New System.Drawing.Size(40, 13)
        Me.LabActivo.TabIndex = 25
        Me.LabActivo.Text = "Activo:"
        '
        'LabMail
        '
        Me.LabMail.AutoSize = True
        Me.LabMail.Location = New System.Drawing.Point(15, 190)
        Me.LabMail.Name = "LabMail"
        Me.LabMail.Size = New System.Drawing.Size(111, 13)
        Me.LabMail.TabIndex = 23
        Me.LabMail.Text = "Fecha Hora Creación:"
        '
        'LabCosMen
        '
        Me.LabCosMen.AutoSize = True
        Me.LabCosMen.Location = New System.Drawing.Point(46, 106)
        Me.LabCosMen.Name = "LabCosMen"
        Me.LabCosMen.Size = New System.Drawing.Size(80, 13)
        Me.LabCosMen.TabIndex = 21
        Me.LabCosMen.Text = "Costo Mensual:"
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(79, 64)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(47, 13)
        Me.LabNom.TabIndex = 20
        Me.LabNom.Text = "Nombre:"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(132, 19)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxId.TabIndex = 19
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(67, 22)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(59, 13)
        Me.LabID.TabIndex = 18
        Me.LabID.Text = "IDServicio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.TextBoxActivo)
        Me.GroupBox1.Controls.Add(Me.ComBoxTipo)
        Me.GroupBox1.Controls.Add(Me.TexBoxFHCreacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxCosMen)
        Me.GroupBox1.Controls.Add(Me.LabID)
        Me.GroupBox1.Controls.Add(Me.TextBoxNom)
        Me.GroupBox1.Controls.Add(Me.LabNom)
        Me.GroupBox1.Controls.Add(Me.LabActivo)
        Me.GroupBox1.Controls.Add(Me.LabCosMen)
        Me.GroupBox1.Controls.Add(Me.LabMail)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 268)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'AltaServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtAgregar)
        Me.Name = "AltaServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alta Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtAgregar As Button
    Friend WithEvents ComBoxTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxActivo As TextBox
    Friend WithEvents TexBoxFHCreacion As TextBox
    Friend WithEvents TextBoxCosMen As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabActivo As Label
    Friend WithEvents LabMail As Label
    Friend WithEvents LabCosMen As Label
    Friend WithEvents LabNom As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents LabID As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

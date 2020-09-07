<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarServicios
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
        Me.BtModificarSer = New System.Windows.Forms.Button()
        Me.TBoxId = New System.Windows.Forms.TextBox()
        Me.TBoxActivo = New System.Windows.Forms.TextBox()
        Me.CBoxTipoSer = New System.Windows.Forms.ComboBox()
        Me.TBoxFHCreacionSer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBoxCosMen = New System.Windows.Forms.TextBox()
        Me.LabID = New System.Windows.Forms.Label()
        Me.TBoxNom = New System.Windows.Forms.TextBox()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.LabActivo = New System.Windows.Forms.Label()
        Me.LabCosMen = New System.Windows.Forms.Label()
        Me.LabMail = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtModificarSer
        '
        Me.BtModificarSer.Location = New System.Drawing.Point(326, 308)
        Me.BtModificarSer.Name = "BtModificarSer"
        Me.BtModificarSer.Size = New System.Drawing.Size(75, 23)
        Me.BtModificarSer.TabIndex = 5
        Me.BtModificarSer.Text = "Guardar"
        Me.BtModificarSer.UseVisualStyleBackColor = True
        '
        'TBoxId
        '
        Me.TBoxId.Location = New System.Drawing.Point(130, 19)
        Me.TBoxId.Name = "TBoxId"
        Me.TBoxId.Size = New System.Drawing.Size(205, 20)
        Me.TBoxId.TabIndex = 35
        '
        'TBoxActivo
        '
        Me.TBoxActivo.Location = New System.Drawing.Point(130, 229)
        Me.TBoxActivo.Name = "TBoxActivo"
        Me.TBoxActivo.Size = New System.Drawing.Size(23, 20)
        Me.TBoxActivo.TabIndex = 43
        '
        'CBoxTipoSer
        '
        Me.CBoxTipoSer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxTipoSer.FormattingEnabled = True
        Me.CBoxTipoSer.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciónes", "Informática"})
        Me.CBoxTipoSer.Location = New System.Drawing.Point(130, 145)
        Me.CBoxTipoSer.Name = "CBoxTipoSer"
        Me.CBoxTipoSer.Size = New System.Drawing.Size(222, 21)
        Me.CBoxTipoSer.TabIndex = 32
        '
        'TBoxFHCreacionSer
        '
        Me.TBoxFHCreacionSer.Location = New System.Drawing.Point(130, 187)
        Me.TBoxFHCreacionSer.Name = "TBoxFHCreacionSer"
        Me.TBoxFHCreacionSer.Size = New System.Drawing.Size(222, 20)
        Me.TBoxFHCreacionSer.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tipo:"
        '
        'TBoxCosMen
        '
        Me.TBoxCosMen.Location = New System.Drawing.Point(130, 103)
        Me.TBoxCosMen.Name = "TBoxCosMen"
        Me.TBoxCosMen.Size = New System.Drawing.Size(205, 20)
        Me.TBoxCosMen.TabIndex = 41
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(103, 22)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(21, 13)
        Me.LabID.TabIndex = 34
        Me.LabID.Text = "ID:"
        '
        'TBoxNom
        '
        Me.TBoxNom.Location = New System.Drawing.Point(130, 61)
        Me.TBoxNom.Name = "TBoxNom"
        Me.TBoxNom.Size = New System.Drawing.Size(205, 20)
        Me.TBoxNom.TabIndex = 40
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(77, 64)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(47, 13)
        Me.LabNom.TabIndex = 36
        Me.LabNom.Text = "Nombre:"
        '
        'LabActivo
        '
        Me.LabActivo.AutoSize = True
        Me.LabActivo.Location = New System.Drawing.Point(84, 232)
        Me.LabActivo.Name = "LabActivo"
        Me.LabActivo.Size = New System.Drawing.Size(40, 13)
        Me.LabActivo.TabIndex = 39
        Me.LabActivo.Text = "Activo:"
        '
        'LabCosMen
        '
        Me.LabCosMen.AutoSize = True
        Me.LabCosMen.Location = New System.Drawing.Point(44, 106)
        Me.LabCosMen.Name = "LabCosMen"
        Me.LabCosMen.Size = New System.Drawing.Size(80, 13)
        Me.LabCosMen.TabIndex = 37
        Me.LabCosMen.Text = "Costo Mensual:"
        '
        'LabMail
        '
        Me.LabMail.AutoSize = True
        Me.LabMail.Location = New System.Drawing.Point(13, 190)
        Me.LabMail.Name = "LabMail"
        Me.LabMail.Size = New System.Drawing.Size(111, 13)
        Me.LabMail.TabIndex = 38
        Me.LabMail.Text = "Fecha Hora Creación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBoxId)
        Me.GroupBox1.Controls.Add(Me.LabMail)
        Me.GroupBox1.Controls.Add(Me.TBoxActivo)
        Me.GroupBox1.Controls.Add(Me.LabCosMen)
        Me.GroupBox1.Controls.Add(Me.CBoxTipoSer)
        Me.GroupBox1.Controls.Add(Me.LabActivo)
        Me.GroupBox1.Controls.Add(Me.TBoxFHCreacionSer)
        Me.GroupBox1.Controls.Add(Me.LabNom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBoxNom)
        Me.GroupBox1.Controls.Add(Me.TBoxCosMen)
        Me.GroupBox1.Controls.Add(Me.LabID)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 267)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'ModificarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtModificarSer)
        Me.Name = "ModificarServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtModificarSer As Button
    Friend WithEvents TBoxId As TextBox
    Friend WithEvents TBoxActivo As TextBox
    Friend WithEvents CBoxTipoSer As ComboBox
    Friend WithEvents TBoxFHCreacionSer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBoxCosMen As TextBox
    Friend WithEvents LabID As Label
    Friend WithEvents TBoxNom As TextBox
    Friend WithEvents LabNom As Label
    Friend WithEvents LabActivo As Label
    Friend WithEvents LabCosMen As Label
    Friend WithEvents LabMail As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

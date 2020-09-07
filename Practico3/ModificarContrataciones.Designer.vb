<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarContrataciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbFeFinCon = New System.Windows.Forms.TextBox()
        Me.TextBoxFCon = New System.Windows.Forms.TextBox()
        Me.TextBoxFCrea = New System.Windows.Forms.TextBox()
        Me.TextBoxIDSer = New System.Windows.Forms.TextBox()
        Me.LabIdServ = New System.Windows.Forms.Label()
        Me.LabFecCont = New System.Windows.Forms.Label()
        Me.TextBoxIDPer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabIdPersona = New System.Windows.Forms.Label()
        Me.LabFecCrea = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbFeFinCon)
        Me.GroupBox1.Controls.Add(Me.TextBoxFCon)
        Me.GroupBox1.Controls.Add(Me.TextBoxFCrea)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDSer)
        Me.GroupBox1.Controls.Add(Me.LabIdServ)
        Me.GroupBox1.Controls.Add(Me.LabFecCont)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDPer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabIdPersona)
        Me.GroupBox1.Controls.Add(Me.LabFecCrea)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 239)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TbFeFinCon
        '
        Me.TbFeFinCon.Location = New System.Drawing.Point(145, 189)
        Me.TbFeFinCon.Name = "TbFeFinCon"
        Me.TbFeFinCon.Size = New System.Drawing.Size(179, 20)
        Me.TbFeFinCon.TabIndex = 25
        '
        'TextBoxFCon
        '
        Me.TextBoxFCon.Location = New System.Drawing.Point(145, 150)
        Me.TextBoxFCon.Name = "TextBoxFCon"
        Me.TextBoxFCon.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxFCon.TabIndex = 24
        '
        'TextBoxFCrea
        '
        Me.TextBoxFCrea.Location = New System.Drawing.Point(145, 109)
        Me.TextBoxFCrea.Name = "TextBoxFCrea"
        Me.TextBoxFCrea.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxFCrea.TabIndex = 23
        '
        'TextBoxIDSer
        '
        Me.TextBoxIDSer.Location = New System.Drawing.Point(145, 67)
        Me.TextBoxIDSer.Name = "TextBoxIDSer"
        Me.TextBoxIDSer.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxIDSer.TabIndex = 22
        '
        'LabIdServ
        '
        Me.LabIdServ.AutoSize = True
        Me.LabIdServ.Location = New System.Drawing.Point(78, 70)
        Me.LabIdServ.Name = "LabIdServ"
        Me.LabIdServ.Size = New System.Drawing.Size(62, 13)
        Me.LabIdServ.TabIndex = 18
        Me.LabIdServ.Text = "ID Servicio:"
        '
        'LabFecCont
        '
        Me.LabFecCont.AutoSize = True
        Me.LabFecCont.Location = New System.Drawing.Point(37, 153)
        Me.LabFecCont.Name = "LabFecCont"
        Me.LabFecCont.Size = New System.Drawing.Size(103, 13)
        Me.LabFecCont.TabIndex = 20
        Me.LabFecCont.Text = "Fecha Contratación:"
        '
        'TextBoxIDPer
        '
        Me.TextBoxIDPer.Location = New System.Drawing.Point(145, 29)
        Me.TextBoxIDPer.Name = "TextBoxIDPer"
        Me.TextBoxIDPer.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxIDPer.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fecha Fin Contratación:"
        '
        'LabIdPersona
        '
        Me.LabIdPersona.AutoSize = True
        Me.LabIdPersona.Location = New System.Drawing.Point(78, 32)
        Me.LabIdPersona.Name = "LabIdPersona"
        Me.LabIdPersona.Size = New System.Drawing.Size(63, 13)
        Me.LabIdPersona.TabIndex = 16
        Me.LabIdPersona.Text = "ID Persona:"
        '
        'LabFecCrea
        '
        Me.LabFecCrea.AutoSize = True
        Me.LabFecCrea.Location = New System.Drawing.Point(55, 112)
        Me.LabFecCrea.Name = "LabFecCrea"
        Me.LabFecCrea.Size = New System.Drawing.Size(85, 13)
        Me.LabFecCrea.TabIndex = 19
        Me.LabFecCrea.Text = "Fecha Creación:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(318, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ModificarContrataciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 328)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ModificarContrataciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Contrataciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TbFeFinCon As TextBox
    Friend WithEvents TextBoxFCon As TextBox
    Friend WithEvents TextBoxFCrea As TextBox
    Friend WithEvents TextBoxIDSer As TextBox
    Friend WithEvents LabIdServ As Label
    Friend WithEvents LabFecCont As Label
    Friend WithEvents TextBoxIDPer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabIdPersona As Label
    Friend WithEvents LabFecCrea As Label
End Class

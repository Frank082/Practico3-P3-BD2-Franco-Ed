<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxActivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFHCrea = New System.Windows.Forms.TextBox()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.LabApe = New System.Windows.Forms.Label()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.LabTel = New System.Windows.Forms.Label()
        Me.TextBoxAp = New System.Windows.Forms.TextBox()
        Me.LabMail = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabFHC = New System.Windows.Forms.Label()
        Me.LabActivo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(137, 19)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxId.TabIndex = 19
        '
        'TextBoxActivo
        '
        Me.TextBoxActivo.Location = New System.Drawing.Point(137, 269)
        Me.TextBoxActivo.Name = "TextBoxActivo"
        Me.TextBoxActivo.Size = New System.Drawing.Size(23, 20)
        Me.TextBoxActivo.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ID:"
        '
        'TextBoxFHCrea
        '
        Me.TextBoxFHCrea.Location = New System.Drawing.Point(137, 230)
        Me.TextBoxFHCrea.Name = "TextBoxFHCrea"
        Me.TextBoxFHCrea.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxFHCrea.TabIndex = 30
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(84, 61)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(47, 13)
        Me.LabNom.TabIndex = 20
        Me.LabNom.Text = "Nombre:"
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Location = New System.Drawing.Point(137, 187)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxMail.TabIndex = 29
        '
        'LabApe
        '
        Me.LabApe.AutoSize = True
        Me.LabApe.Location = New System.Drawing.Point(84, 106)
        Me.LabApe.Name = "LabApe"
        Me.LabApe.Size = New System.Drawing.Size(47, 13)
        Me.LabApe.TabIndex = 21
        Me.LabApe.Text = "Apellido:"
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Location = New System.Drawing.Point(137, 146)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxTel.TabIndex = 28
        '
        'LabTel
        '
        Me.LabTel.AutoSize = True
        Me.LabTel.Location = New System.Drawing.Point(79, 153)
        Me.LabTel.Name = "LabTel"
        Me.LabTel.Size = New System.Drawing.Size(52, 13)
        Me.LabTel.TabIndex = 22
        Me.LabTel.Text = "Teléfono:"
        '
        'TextBoxAp
        '
        Me.TextBoxAp.Location = New System.Drawing.Point(137, 103)
        Me.TextBoxAp.Name = "TextBoxAp"
        Me.TextBoxAp.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxAp.TabIndex = 27
        '
        'LabMail
        '
        Me.LabMail.AutoSize = True
        Me.LabMail.Location = New System.Drawing.Point(102, 190)
        Me.LabMail.Name = "LabMail"
        Me.LabMail.Size = New System.Drawing.Size(29, 13)
        Me.LabMail.TabIndex = 23
        Me.LabMail.Text = "Mail:"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(137, 58)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxNom.TabIndex = 26
        '
        'LabFHC
        '
        Me.LabFHC.AutoSize = True
        Me.LabFHC.Location = New System.Drawing.Point(26, 233)
        Me.LabFHC.Name = "LabFHC"
        Me.LabFHC.Size = New System.Drawing.Size(105, 13)
        Me.LabFHC.TabIndex = 24
        Me.LabFHC.Text = "FechaHoraCreación:"
        '
        'LabActivo
        '
        Me.LabActivo.AutoSize = True
        Me.LabActivo.Location = New System.Drawing.Point(91, 272)
        Me.LabActivo.Name = "LabActivo"
        Me.LabActivo.Size = New System.Drawing.Size(40, 13)
        Me.LabActivo.TabIndex = 25
        Me.LabActivo.Text = "Activo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.LabActivo)
        Me.GroupBox1.Controls.Add(Me.TextBoxActivo)
        Me.GroupBox1.Controls.Add(Me.LabFHC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNom)
        Me.GroupBox1.Controls.Add(Me.TextBoxFHCrea)
        Me.GroupBox1.Controls.Add(Me.LabMail)
        Me.GroupBox1.Controls.Add(Me.LabNom)
        Me.GroupBox1.Controls.Add(Me.TextBoxAp)
        Me.GroupBox1.Controls.Add(Me.TextBoxMail)
        Me.GroupBox1.Controls.Add(Me.LabTel)
        Me.GroupBox1.Controls.Add(Me.LabApe)
        Me.GroupBox1.Controls.Add(Me.TextBoxTel)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 303)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "ModificarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Persona"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxActivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFHCrea As TextBox
    Friend WithEvents LabNom As Label
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents LabApe As Label
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents LabTel As Label
    Friend WithEvents TextBoxAp As TextBox
    Friend WithEvents LabMail As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabFHC As Label
    Friend WithEvents LabActivo As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPersona
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.LabApe = New System.Windows.Forms.Label()
        Me.LabTel = New System.Windows.Forms.Label()
        Me.LabMail = New System.Windows.Forms.Label()
        Me.LabFHC = New System.Windows.Forms.Label()
        Me.LabActivo = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxAp = New System.Windows.Forms.TextBox()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.TextBoxFHCrea = New System.Windows.Forms.TextBox()
        Me.TextBoxActivo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(132, 19)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxId.TabIndex = 4
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(377, 353)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(79, 61)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(47, 13)
        Me.LabNom.TabIndex = 6
        Me.LabNom.Text = "Nombre:"
        '
        'LabApe
        '
        Me.LabApe.AutoSize = True
        Me.LabApe.Location = New System.Drawing.Point(79, 106)
        Me.LabApe.Name = "LabApe"
        Me.LabApe.Size = New System.Drawing.Size(47, 13)
        Me.LabApe.TabIndex = 7
        Me.LabApe.Text = "Apellido:"
        '
        'LabTel
        '
        Me.LabTel.AutoSize = True
        Me.LabTel.Location = New System.Drawing.Point(74, 153)
        Me.LabTel.Name = "LabTel"
        Me.LabTel.Size = New System.Drawing.Size(52, 13)
        Me.LabTel.TabIndex = 8
        Me.LabTel.Text = "Teléfono:"
        '
        'LabMail
        '
        Me.LabMail.AutoSize = True
        Me.LabMail.Location = New System.Drawing.Point(97, 190)
        Me.LabMail.Name = "LabMail"
        Me.LabMail.Size = New System.Drawing.Size(29, 13)
        Me.LabMail.TabIndex = 9
        Me.LabMail.Text = "Mail:"
        '
        'LabFHC
        '
        Me.LabFHC.AutoSize = True
        Me.LabFHC.Location = New System.Drawing.Point(21, 233)
        Me.LabFHC.Name = "LabFHC"
        Me.LabFHC.Size = New System.Drawing.Size(105, 13)
        Me.LabFHC.TabIndex = 10
        Me.LabFHC.Text = "FechaHoraCreación:"
        '
        'LabActivo
        '
        Me.LabActivo.AutoSize = True
        Me.LabActivo.Location = New System.Drawing.Point(86, 272)
        Me.LabActivo.Name = "LabActivo"
        Me.LabActivo.Size = New System.Drawing.Size(40, 13)
        Me.LabActivo.TabIndex = 11
        Me.LabActivo.Text = "Activo:"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(132, 58)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxNom.TabIndex = 12
        '
        'TextBoxAp
        '
        Me.TextBoxAp.Location = New System.Drawing.Point(132, 103)
        Me.TextBoxAp.Name = "TextBoxAp"
        Me.TextBoxAp.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxAp.TabIndex = 13
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Location = New System.Drawing.Point(132, 146)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxTel.TabIndex = 14
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Location = New System.Drawing.Point(132, 187)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxMail.TabIndex = 15
        '
        'TextBoxFHCrea
        '
        Me.TextBoxFHCrea.Location = New System.Drawing.Point(132, 230)
        Me.TextBoxFHCrea.Name = "TextBoxFHCrea"
        Me.TextBoxFHCrea.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxFHCrea.TabIndex = 16
        '
        'TextBoxActivo
        '
        Me.TextBoxActivo.Location = New System.Drawing.Point(132, 269)
        Me.TextBoxActivo.Name = "TextBoxActivo"
        Me.TextBoxActivo.Size = New System.Drawing.Size(23, 20)
        Me.TextBoxActivo.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.TextBoxActivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxFHCrea)
        Me.GroupBox1.Controls.Add(Me.LabNom)
        Me.GroupBox1.Controls.Add(Me.TextBoxMail)
        Me.GroupBox1.Controls.Add(Me.LabApe)
        Me.GroupBox1.Controls.Add(Me.TextBoxTel)
        Me.GroupBox1.Controls.Add(Me.LabTel)
        Me.GroupBox1.Controls.Add(Me.TextBoxAp)
        Me.GroupBox1.Controls.Add(Me.LabMail)
        Me.GroupBox1.Controls.Add(Me.TextBoxNom)
        Me.GroupBox1.Controls.Add(Me.LabFHC)
        Me.GroupBox1.Controls.Add(Me.LabActivo)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 305)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'AltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Name = "AltaPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alta Persona"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents LabNom As Label
    Friend WithEvents LabApe As Label
    Friend WithEvents LabTel As Label
    Friend WithEvents LabMail As Label
    Friend WithEvents LabFHC As Label
    Friend WithEvents LabActivo As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxAp As TextBox
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents TextBoxFHCrea As TextBox
    Friend WithEvents TextBoxActivo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

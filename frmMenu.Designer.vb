<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnAgendamentos = New System.Windows.Forms.Button()
        Me.btnGaleria = New System.Windows.Forms.Button()
        Me.btnIA = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(120, 130)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 55)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnAgendamentos
        '
        Me.btnAgendamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAgendamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendamentos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendamentos.ForeColor = System.Drawing.Color.White
        Me.btnAgendamentos.Location = New System.Drawing.Point(335, 130)
        Me.btnAgendamentos.Name = "btnAgendamentos"
        Me.btnAgendamentos.Size = New System.Drawing.Size(149, 55)
        Me.btnAgendamentos.TabIndex = 1
        Me.btnAgendamentos.Text = "AGENDAMENTOS"
        Me.btnAgendamentos.UseVisualStyleBackColor = False
        '
        'btnGaleria
        '
        Me.btnGaleria.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnGaleria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGaleria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGaleria.ForeColor = System.Drawing.Color.White
        Me.btnGaleria.Location = New System.Drawing.Point(120, 232)
        Me.btnGaleria.Name = "btnGaleria"
        Me.btnGaleria.Size = New System.Drawing.Size(149, 55)
        Me.btnGaleria.TabIndex = 2
        Me.btnGaleria.Text = "GALERIA"
        Me.btnGaleria.UseVisualStyleBackColor = False
        '
        'btnIA
        '
        Me.btnIA.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnIA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIA.ForeColor = System.Drawing.Color.White
        Me.btnIA.Location = New System.Drawing.Point(335, 232)
        Me.btnIA.Name = "btnIA"
        Me.btnIA.Size = New System.Drawing.Size(149, 55)
        Me.btnIA.TabIndex = 3
        Me.btnIA.Text = "SUGESTÃO IA"
        Me.btnIA.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(205, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 45)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TATTOO.IO"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 357)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIA)
        Me.Controls.Add(Me.btnGaleria)
        Me.Controls.Add(Me.btnAgendamentos)
        Me.Controls.Add(Me.btnClientes)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tattoo.io"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClientes As Button
    Friend WithEvents btnAgendamentos As Button
    Friend WithEvents btnGaleria As Button
    Friend WithEvents btnIA As Button
    Friend WithEvents Label2 As Label
End Class

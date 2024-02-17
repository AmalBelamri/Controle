<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.add = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.an = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtds = New System.Windows.Forms.TextBox()
        Me.l = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo
        '
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(203, 53)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(272, 24)
        Me.combo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtds)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.save)
        Me.GroupBox1.Controls.Add(Me.an)
        Me.GroupBox1.Location = New System.Drawing.Point(763, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 384)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(23, 207)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(696, 376)
        Me.dgv.TabIndex = 0
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(802, 53)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(199, 40)
        Me.add.TabIndex = 0
        Me.add.Text = "Ajouter un prduit"
        Me.add.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(62, 304)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(199, 40)
        Me.save.TabIndex = 2
        Me.save.Text = "Ajouter"
        Me.save.UseVisualStyleBackColor = True
        '
        'an
        '
        Me.an.Location = New System.Drawing.Point(296, 304)
        Me.an.Name = "an"
        Me.an.Size = New System.Drawing.Size(199, 40)
        Me.an.TabIndex = 3
        Me.an.Text = "Annuler"
        Me.an.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(220, 109)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 22)
        Me.txtCode.TabIndex = 4
        '
        'txtds
        '
        Me.txtds.Location = New System.Drawing.Point(220, 168)
        Me.txtds.Name = "txtds"
        Me.txtds.Size = New System.Drawing.Size(275, 22)
        Me.txtds.TabIndex = 5
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(29, 53)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(168, 17)
        Me.l.TabIndex = 2
        Me.l.Text = "Choisissez une Catégorie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Désignation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 674)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.combo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtds As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents save As Button
    Friend WithEvents an As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents add As Button
    Friend WithEvents l As Label
End Class

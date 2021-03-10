<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Secundario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Secundario))
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        Me.Grp_ContaCorrente = New System.Windows.Forms.GroupBox()
        Me.Txt_ContaCorrente = New System.Windows.Forms.TextBox()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Btn_Criar = New System.Windows.Forms.Button()
        Me.Lbl_ContaCorrenteCriada = New System.Windows.Forms.Label()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_ContaCorrente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Image = CType(resources.GetObject("Pic_Logo.Image"), System.Drawing.Image)
        Me.Pic_Logo.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(100, 67)
        Me.Pic_Logo.TabIndex = 0
        Me.Pic_Logo.TabStop = False
        '
        'Grp_ContaCorrente
        '
        Me.Grp_ContaCorrente.Controls.Add(Me.Btn_Criar)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_ContaCorrente)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_Agencia)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_Agencia)
        Me.Grp_ContaCorrente.Location = New System.Drawing.Point(159, 12)
        Me.Grp_ContaCorrente.Name = "Grp_ContaCorrente"
        Me.Grp_ContaCorrente.Size = New System.Drawing.Size(231, 150)
        Me.Grp_ContaCorrente.TabIndex = 1
        Me.Grp_ContaCorrente.TabStop = False
        Me.Grp_ContaCorrente.Text = "GroupBox1"
        '
        'Txt_ContaCorrente
        '
        Me.Txt_ContaCorrente.Location = New System.Drawing.Point(10, 94)
        Me.Txt_ContaCorrente.Name = "Txt_ContaCorrente"
        Me.Txt_ContaCorrente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_ContaCorrente.TabIndex = 3
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(10, 37)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Agencia.TabIndex = 2
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(7, 78)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente.TabIndex = 1
        Me.Lbl_ContaCorrente.Text = "Label1"
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Location = New System.Drawing.Point(7, 20)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Agencia.TabIndex = 0
        Me.Lbl_Agencia.Text = "Label1"
        '
        'Btn_Criar
        '
        Me.Btn_Criar.Location = New System.Drawing.Point(150, 110)
        Me.Btn_Criar.Name = "Btn_Criar"
        Me.Btn_Criar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Criar.TabIndex = 4
        Me.Btn_Criar.Text = "Button1"
        Me.Btn_Criar.UseVisualStyleBackColor = True
        '
        'Lbl_ContaCorrenteCriada
        '
        Me.Lbl_ContaCorrenteCriada.AutoSize = True
        Me.Lbl_ContaCorrenteCriada.Location = New System.Drawing.Point(159, 169)
        Me.Lbl_ContaCorrenteCriada.Name = "Lbl_ContaCorrenteCriada"
        Me.Lbl_ContaCorrenteCriada.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrenteCriada.TabIndex = 2
        Me.Lbl_ContaCorrenteCriada.Text = "Label1"
        '
        'Frm_Secundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 298)
        Me.Controls.Add(Me.Lbl_ContaCorrenteCriada)
        Me.Controls.Add(Me.Grp_ContaCorrente)
        Me.Controls.Add(Me.Pic_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Secundario"
        Me.Text = "Frm_Secundario"
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_ContaCorrente.ResumeLayout(False)
        Me.Grp_ContaCorrente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Grp_ContaCorrente As GroupBox
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Txt_ContaCorrente As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Btn_Criar As Button
    Friend WithEvents Lbl_ContaCorrenteCriada As Label
End Class

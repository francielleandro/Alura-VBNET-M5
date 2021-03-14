Imports ByteBank.Bibliotecas.Classes.Externos
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Public Class Frm_Login

    Dim vNomeRepresentante As String = "Representante X"
    Dim vNomeGerente As String = "Gerente Y"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Login Sistema Interno"
        Grp_Login.Text = ""
        Lbl_Login.Text = "Login"
        Lbl_Senha.Text = "Senha"
        Rb_Gerente.Text = "Gerente"
        Rb_Representante.Text = "Representante"
        Btn_Logar.Text = "Logar"
        Txt_Login.ReadOnly = True
        Rb_Gerente.Checked = True
        Rb_Representante.Checked = False
    End Sub

    Private Sub Rb_Gerente_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Gerente.CheckedChanged
        If Rb_Gerente.Checked Then
            Txt_Login.Text = vNomeGerente
        End If
    End Sub

    Private Sub Rb_Representante_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Representante.CheckedChanged
        If Rb_Representante.Checked Then
            Txt_Login.Text = vNomeRepresentante
        End If
    End Sub

    Private Sub Btn_Logar_Click(sender As Object, e As EventArgs) Handles Btn_Logar.Click
        Dim Representante As New Representante
        Representante.senha = "rrrrrrrrrr"

        Dim Gerente As New Gerente(1234567890)

        Gerente.senha = "ggg"
        Dim vRetorno As Boolean = False
        If Rb_Gerente.Checked Then
            vRetorno = Gerente.Autenticar(Txt_Senha.Text)
        Else
            vRetorno = Representante.Autenticar(Txt_Senha.Text)
        End If

        If vRetorno = True Then
            MsgBox("Usuário efetuou login no sistema interno", MsgBoxStyle.Information)
        Else
            MsgBox("Login ou senha invalidos", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
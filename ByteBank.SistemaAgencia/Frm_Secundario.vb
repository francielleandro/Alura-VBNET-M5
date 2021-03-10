Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Secundario
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulário Secundario"

        Grp_ContaCorrente.Text = "Conta Corrente"

        Lbl_Agencia.Text = "Agencia"

        Lbl_ContaCorrente.Text = "Conta Corrente"

        Lbl_ContaCorrenteCriada.Text = ""

        Btn_Criar.Text = "Criar"

    End Sub

    Private Sub Btn_Criar_Click(sender As Object, e As EventArgs) Handles Btn_Criar.Click
        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vContaCorrente As Integer = Val(Txt_ContaCorrente.Text)

        Dim Conta As New ContaCorrente(vAgencia, vContaCorrente)

        Lbl_ContaCorrenteCriada.Text = "Agencia:" + vAgencia.ToString +
            " - Conta: " + vContaCorrente.ToString
    End Sub
End Class
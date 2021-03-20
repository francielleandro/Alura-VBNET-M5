Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_CartaoCredito
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Vencimento Cartão de Crédito"

        Grp_ContaCorrente.Text = "Conta Corrente"

        Lbl_Agencia.Text = "Agencia"

        Lbl_ContaCorrente.Text = "Conta Corrente"

        Lbl_ContaCorrenteCriada.Text = ""

        Btn_Criar.Text = "Criar"

        Lbl_Vencimento.Text = "Vencimento"

    End Sub

    Private Sub Btn_Criar_Click(sender As Object, e As EventArgs) Handles Btn_Criar.Click
        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vContaCorrente As Integer = Val(Txt_ContaCorrente.Text)

        Dim Conta As ContaCorrente = New ContaCorrente(vAgencia, vContaCorrente)

        Dim vDataVencimento As DateTime = DTP_Vencimento.Value

        Lbl_ContaCorrenteCriada.Text = "Agencia:" + vAgencia.ToString +
            " - Conta: " + vContaCorrente.ToString + " Data do vencimento é " + vDataVencimento.ToString

    End Sub
End Class
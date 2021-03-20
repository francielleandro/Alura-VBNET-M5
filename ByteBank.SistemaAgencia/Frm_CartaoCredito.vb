Imports ByteBank.Bibliotecas.Classes.Clientes
Imports Humanizer

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

        Lbl_Mensagem.Text = ""

        Lbl_Msg2.Text = ""

    End Sub

    Private Sub Btn_Criar_Click(sender As Object, e As EventArgs) Handles Btn_Criar.Click
        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vContaCorrente As Integer = Val(Txt_ContaCorrente.Text)

        Dim Conta As ContaCorrente = New ContaCorrente(vAgencia, vContaCorrente)

        Dim vDataVencimento As DateTime = DTP_Vencimento.Value

        Dim vDataHoje As DateTime = Now

        Dim vTempoVencimento As TimeSpan = vDataVencimento - vDataHoje

        Dim vNumeroDias As Integer = vTempoVencimento.Days

        Lbl_ContaCorrenteCriada.Text = "Agencia:" + vAgencia.ToString +
            " - Conta: " + vContaCorrente.ToString + " Data do vencimento é " + Mid(vDataVencimento.ToString, 1, 10)

        Lbl_Mensagem.Text = "Data de hoje é " + Mid(vDataHoje.ToString, 1, 10)

        Lbl_Msg2.Text = TimeSpanHumanizeExtensions.Humanize(vTempoVencimento)

    End Sub

End Class
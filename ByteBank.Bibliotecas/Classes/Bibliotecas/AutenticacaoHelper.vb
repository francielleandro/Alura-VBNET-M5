Namespace Classes.Bibliotecas
    Friend Class AutenticacaoHelper

        Public Function Autenticar(senhaTentativa As String, senha As String) As Boolean
            If senha = senhaTentativa Then
                Return True
            End If
            Return False
        End Function
    End Class
End Namespace

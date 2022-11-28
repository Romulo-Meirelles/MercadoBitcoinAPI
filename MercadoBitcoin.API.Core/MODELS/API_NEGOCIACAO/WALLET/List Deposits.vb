Imports Newtonsoft.Json

Namespace Core
    ''' <summary>
    ''' *** MADE FOR GITHUB ***
    ''' WRITTEN BY ROMULO MEIRELLES.
    ''' UPWORK: https://www.upwork.com/freelancers/~01fcbc5039ac5766b4
    ''' CONTACT WHATSAPP: https://wa.me/message/KWIS3BYO6K24N1
    ''' CONTACT TELEGRAM: https://t.me/Romulo_Meirelles
    ''' GITHUB: https://github.com/Romulo-Meirelles
    ''' DISCORD: đąяķňέs§¢øďε#2786
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ListDeposits
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result

            <JsonProperty("address")>
            Public Property Endereco As String

            <JsonProperty("address_tag")>
            Public Property Endereco_Marcacao As String

            <JsonProperty("amount")>
            Public Property Quantidade As String

            <JsonProperty("coin")>
            Public Property Moeda As String

            <JsonProperty("confirmTimes")>
            Public Property Confirmacao_Horario As String

            <JsonProperty("createdAt")>
            Public Property Criado_Tempo_Deposito As String

            <JsonProperty("network")>
            Public Property Rede_Deposito As String

            <JsonProperty("origin")>
            Public Property Origem As List(Of String)

            <JsonProperty("status")>
            Public Property Status As String

            <JsonProperty("transaction_id")>
            Public Property Identificacao_Transacao As String

            <JsonProperty("transferType")>
            Public Property Tipo_de_Transferencia As String

        End Class



        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Endereço: " & Root(i).Endereco & vbCrLf &
                "Endereço de Marcação: " & Root(i).Endereco_Marcacao & vbCrLf &
                "Quantidade: " & Root(i).Quantidade & vbCrLf &
                "Moeda: " & Root(i).Moeda & vbCrLf &
                "Confirmação de Horário: " & Root(i).Confirmacao_Horario & vbCrLf &
                "Criado no Tempo de Depósito: " & UnixToTime(Root(i).Criado_Tempo_Deposito) & vbCrLf &
                "Rede de Depósito: " & Root(i).Rede_Deposito & vbCrLf &
                "Identificação da Transação: " & Root(i).Identificacao_Transacao & vbCrLf &
                "Tipo de Transferência: " & Root(i).Tipo_de_Transferencia & vbCrLf &
                "Origem: "
                For b = 0 To Root(i).Origem.Count - 1
                    A += Root(i).Origem(b) & ", "
                Next
                A += vbCrLf & vbCrLf
            Next
            Return A

        End Function
    End Class
End Namespace
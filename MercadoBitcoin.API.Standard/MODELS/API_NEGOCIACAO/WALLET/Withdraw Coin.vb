Imports Newtonsoft.Json

Namespace Standard
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
    Public Class WithdrawCoin
        Inherits MercadoBitcoinResponse

        <JsonProperty("account")>
        Public Property Conta As String

        <JsonProperty("address")>
        Public Property Endereco As String

        <JsonProperty("coin")>
        Public Property Moeda As String

        <JsonProperty("created_at")>
        Public Property Criado_Em As String

        <JsonProperty("description")>
        Public Property Descricao As String

        <JsonProperty("destination_tag")>
        Public Property Marcacao_Destino As String

        <JsonProperty("fee")>
        Public Property Taxa As String

        <JsonProperty("id")>
        Public Property Identificacao As Integer

        <JsonProperty("net_quantity")>
        Public Property Quantidade_Para_Saque As String

        <JsonProperty("network")>
        Public Property Rede_de_Retirada As String

        <JsonProperty("quantity")>
        Public Property Quantidade As String

        <JsonProperty("status")>
        Public Property Status As Integer

        <JsonProperty("tx")>
        Public Property Taxa_de_Moeda As String

        <JsonProperty("updated_at")>
        Public Property Atualizado_Ate As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A += "Conta: " & Conta & vbCrLf &
                "Endereço: " & Endereco & vbCrLf &
                "Moeda: " & Moeda & vbCrLf &
                "Criado Em: " & UnixToTime(Criado_Em) & vbCrLf &
                "Descrição: " & Descricao & vbCrLf &
                "Marcação de Destino: " & Marcacao_Destino & vbCrLf &
                "Taxa: " & Taxa & vbCrLf &
                "Identificação: " & Identificacao & vbCrLf &
                "Quantidade Para Saque: " & Quantidade_Para_Saque & vbCrLf &
                "Rede de Retirada: " & Rede_de_Retirada & vbCrLf &
                "Quantidade: " & Quantidade & vbCrLf &
                "Status: " & Status & vbCrLf &
                "Taxa de Moeda: " & Taxa_de_Moeda & vbCrLf &
                "Atualizado até: " & UnixToTime(Atualizado_Ate) & vbCrLf
            Return A

        End Function
    End Class
End Namespace
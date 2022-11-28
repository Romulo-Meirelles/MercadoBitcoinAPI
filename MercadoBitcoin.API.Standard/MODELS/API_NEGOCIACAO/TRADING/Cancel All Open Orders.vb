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
    Public Class CancelAllOpenOrders
        Inherits MercadoBitcoinResponse

        <JsonProperty("crypto")>
        Public Property Cripto_Simbolo As String

        <JsonProperty("fiat")>
        Public Property Moeda_Fiat As String

        <JsonProperty("order_id")>
        Public Property Identificacao_Ordem As String

        <JsonProperty("order_type")>
        Public Property Tipo_Ordem As String

        <JsonProperty("side")>
        Public Property Lado_Direcao As String

        <JsonProperty("status")>
        Public Property Status As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A += "Cripto Símbolo: " + Cripto_Simbolo & vbCrLf &
                 "Moeda Fiat: " + Moeda_Fiat & vbCrLf &
                 "Identificação da Ordem: " + Identificacao_Ordem & vbCrLf &
                 "Tipo de Ordem: " + Tipo_Ordem & vbCrLf &
                 "Lado Direção: " + Lado_Direcao & vbCrLf &
                 "Status: " + Status & vbCrLf & vbCrLf
            Return A
        End Function
    End Class
End Namespace
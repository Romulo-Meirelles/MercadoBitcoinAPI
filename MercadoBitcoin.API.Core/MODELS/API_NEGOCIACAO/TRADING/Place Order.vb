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
    Public Class PlaceOrder
        Inherits MercadoBitcoinResponse

        <JsonProperty("orderId")>
        Public Property Identificacao_Ordem As String

        Public Overrides Function ToString() As String
            Return "Identificação da Ordem: " & Identificacao_Ordem
        End Function
    End Class
End Namespace
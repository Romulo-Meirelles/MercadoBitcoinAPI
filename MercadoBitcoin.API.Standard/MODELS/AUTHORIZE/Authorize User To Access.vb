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
    Public Class Authorization
        Inherits MercadoBitcoinResponse

        <JsonProperty("access_token")>
        Public Property AcessToken As String

        <JsonProperty("expiration")>
        Public Property Expiration As String

        Public Overrides Function ToString() As String

            Return "Acess Token: " & AcessToken & vbCrLf &
                    "Expiration: " & UnixToTime(Expiration)
        End Function
    End Class
End Namespace
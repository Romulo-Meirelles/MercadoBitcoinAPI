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
    Public Class GetFeesFromAsset
        Inherits MercadoBitcoinResponse

        <JsonProperty("asset")>
        Public Property Ativo As String

        <JsonProperty("deposit_minimum")>
        Public Property Deposito_Minimo As String

        <JsonProperty("withdraw_minimum")>
        Public Property Saque_Minimo As String

        <JsonProperty("withdrawal_fee")>
        Public Property Taxa_de_Saque As String

        Public Overrides Function ToString() As String
            Return "Ativo: " & Ativo & vbCrLf &
                    "Depósito Mínimo: " & Deposito_Minimo & vbCrLf &
                    "Saque Mínimo: " & Saque_Minimo & vbCrLf &
                    "Taxa de Saque: " & Taxa_de_Saque
        End Function
    End Class
End Namespace
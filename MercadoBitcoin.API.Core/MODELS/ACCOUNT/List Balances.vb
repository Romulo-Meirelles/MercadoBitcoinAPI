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
    Public Class ListBalances
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result

            <JsonProperty("available")>
            Public Property Disponivel As String

            <JsonProperty("on_hold")>
            Public Property Em_Espera As String

            <JsonProperty("symbol")>
            Public Property Simbolo As String

            <JsonProperty("total")>
            Public Property Total As String

        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Disponível: " & Root(i).Disponivel & vbCrLf &
                "Em Espera: " & Root(i).Em_Espera & vbCrLf &
                "Símbolo: " & Root(i).Simbolo & vbCrLf &
                "Total: " & Root(i).Total & vbCrLf & vbCrLf
            Next
            Return A

        End Function
    End Class
End Namespace
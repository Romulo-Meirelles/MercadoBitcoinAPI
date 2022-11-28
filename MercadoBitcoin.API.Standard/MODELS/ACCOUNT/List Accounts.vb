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
    Public Class ListAccounts
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result

            <JsonProperty("currency")>
            Public Property Moeda As String

            <JsonProperty("currencySign")>
            Public Property Simbolo_Moeda As String

            <JsonProperty("id")>
            Public Property Identificacao As String

            <JsonProperty("name")>
            Public Property Nome As String

            <JsonProperty("type")>
            Public Property Tipo As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Moeda: " & Root(i).Moeda & vbCrLf &
                "Símbolo Moeda: " & Root(i).Simbolo_Moeda & vbCrLf &
                "Identificação: " & Root(i).Identificacao & vbCrLf &
                "Nome: " & Root(i).Nome & vbCrLf &
                "Tipo: " & Root(i).Tipo & vbCrLf & vbCrLf
            Next
            Return A

        End Function
    End Class
End Namespace
Imports Newtonsoft.Json

Namespace Framework
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
    Public Class ListTrades
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result
            <JsonProperty("amount")>
            Public Property Quantidade As String

            <JsonProperty("date")>
            Public Property Data As String

            <JsonProperty("price")>
            Public Property Preco As String

            <JsonProperty("tid")>
            Public Property TID As String

            <JsonProperty("type")>
            Public Property Tipo As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Quantidade: " + Root(i).Quantidade & vbCrLf &
                    "Data: " + Root(i).Data & vbCrLf &
                    "Preço: " + Root(i).Preco & vbCrLf &
                    "Trade Indentificação: " + Root(i).TID & vbCrLf &
                    "Tipo Trade: " + Root(i).Tipo & vbCrLf & vbCrLf
            Next

            Return A
        End Function
    End Class
End Namespace
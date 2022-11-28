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
    Public Class ListTickers
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result
            <JsonProperty("buy")>
            Public Property Compra As String

            <JsonProperty("date")>
            Public Property Data As String

            <JsonProperty("high")>
            Public Property Alta As String

            <JsonProperty("last")>
            Public Property Ultima As String

            <JsonProperty("low")>
            Public Property Baixa As String

            <JsonProperty("open")>
            Public Property Abertura As String

            <JsonProperty("pair")>
            Public Property Par As String

            <JsonProperty("sell")>
            Public Property Venda As String

            <JsonProperty("vol")>
            Public Property Volume As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Preço de Compra: " + Root(i).Compra & vbCrLf &
                    "Preço de Venda: " + Root(i).Venda & vbCrLf &
                    "Preço de Abertura: " + Root(i).Abertura & vbCrLf &
                    "Alta: " + Root(i).Alta & vbCrLf &
                    "Baixa: " + Root(i).Baixa & vbCrLf &
                    "Última: " + Root(i).Ultima & vbCrLf &
                    "Par: " + Root(i).Par & vbCrLf &
                    "Volume: " + Root(i).Volume & vbCrLf &
                    "Data: " + Root(i).Data & vbCrLf & vbCrLf
            Next

            Return A
        End Function
    End Class
End Namespace
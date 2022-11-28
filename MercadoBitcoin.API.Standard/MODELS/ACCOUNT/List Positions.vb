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
    Public Class ListPositions
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result

            <JsonProperty("avgPrice")>
            Public Property Preco_Medio_Negociacao As String

            <JsonProperty("category")>
            Public Property Categoria As String

            <JsonProperty("id")>
            Public Property Identificacao As String

            <JsonProperty("instrument")>
            Public Property Simbolo As String

            <JsonProperty("qty")>
            Public Property Quantidade_Ordem As String

            <JsonProperty("side")>
            Public Property Lado_da_Ordem As String

        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Preço Médio: " & Root(i).Preco_Medio_Negociacao & vbCrLf &
                "Categoria: " & Root(i).Categoria & vbCrLf &
                "Identificação: " & Root(i).Identificacao & vbCrLf &
                "Símbolo: " & Root(i).Simbolo & vbCrLf &
                "Quantidade da Ordem: " & Root(i).Quantidade_Ordem & vbCrLf &
                "Lado da Ordem: " & Root(i).Lado_da_Ordem & vbCrLf & vbCrLf
            Next
            Return A

        End Function
    End Class
End Namespace
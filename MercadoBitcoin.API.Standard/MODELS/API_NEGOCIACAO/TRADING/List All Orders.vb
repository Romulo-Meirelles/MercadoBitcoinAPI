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
    Public Class ListAllOrders
        Inherits MercadoBitcoinResponse

        <JsonProperty("items")>
        Public Property Itens As List(Of Orders)

        Class Orders

            <JsonProperty("created_at")>
            Public Property Criado_Em As String

            <JsonProperty("filledQty")>
            Public Property Quantidade_Preenchida As String

            <JsonProperty("id")>
            Public Property Identificacao As String

            <JsonProperty("instrument")>
            Public Property Simbolo As String

            <JsonProperty("limitPrice")>
            Public Property Preco_Limite As String

            <JsonProperty("qty")>
            Public Property Volume_Quantidade As String

            <JsonProperty("side")>
            Public Property Lado_Direcao As String

            <JsonProperty("status")>
            Public Property Status As String

            <JsonProperty("stopPrice")>
            Public Property Gatilho_Stop_Preco As String

            <JsonProperty("triggerOrderId")>
            Public Property Identificacao_Ordem_Limite As String

            <JsonProperty("type")>
            Public Property Tipo_da_Ordem As String

            <JsonProperty("updated_at")>
            Public Property Atualizado_Em As String
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Itens.Count - 1
                A += "Criado Em: " + Itens(i).Criado_Em & vbCrLf &
                    "Quantidade Preenchida: " + Itens(i).Quantidade_Preenchida & vbCrLf &
                    "Identificação: " + Itens(i).Identificacao & vbCrLf &
                    "Símbolo: " + Itens(i).Simbolo & vbCrLf &
                    "Preço Limite: " + Itens(i).Preco_Limite & vbCrLf &
                    "Volume Quantidade: " + Itens(i).Volume_Quantidade & vbCrLf &
                    "Lado Direção: " + Itens(i).Lado_Direcao & vbCrLf &
                    "Status: " + Itens(i).Status & vbCrLf &
                    "Gatilho Stop: " + Itens(i).Gatilho_Stop_Preco & vbCrLf &
                    "Identificação Ordem Limite: " + Itens(i).Identificacao_Ordem_Limite & vbCrLf &
                    "Tipo da Ordem: " + Itens(i).Tipo_da_Ordem & vbCrLf &
                    "Atualizado Em: " + Itens(i).Atualizado_Em & vbCrLf & vbCrLf
            Next
            Return A
        End Function
    End Class
End Namespace
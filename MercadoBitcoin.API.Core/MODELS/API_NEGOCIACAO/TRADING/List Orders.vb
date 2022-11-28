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
    Public Class ListOrder
        Inherits MercadoBitcoinResponse

        <JsonProperty("root")>
        Public Property Root As List(Of Result)

        Class Result
            <JsonProperty("avgPrice")>
            Public Property Preco_Medio As String

            <JsonProperty("created_at")>
            Public Property Criado_Em As String

            <JsonProperty("executions")>
            Public Property Execucoes As List(Of Executions)

            <JsonProperty("externalId")>
            Public Property Identificacao_Externa As String

            <JsonProperty("fee")>
            Public Property Taxa As String

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

            Class Executions
                <JsonProperty("executed_at")>
                Public Property Executado_Em As String

                <JsonProperty("fee_rate")>
                Public Property Taxa As String

                <JsonProperty("id")>
                Public Property Identificacao As String

                <JsonProperty("instrument")>
                Public Property Simbolo As String

                <JsonProperty("price")>
                Public Property Preco_Executado As String

                <JsonProperty("qty")>
                Public Property Quantidade_Volume As String

                <JsonProperty("side")>
                Public Property Lado_Direcao As String
            End Class
        End Class

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Root.Count - 1
                A += "Preço Médio: " + Root(i).Preco_Medio & vbCrLf &
                    "Criado Em: " + Root(i).Criado_Em & vbCrLf &
                    "Identificação Externa: " + Root(i).Identificacao_Externa & vbCrLf &
                    "Taxa: " + Root(i).Taxa & vbCrLf &
                    "Quantidade Preenchida: " + Root(i).Quantidade_Preenchida & vbCrLf &
                    "Identificação: " + Root(i).Identificacao & vbCrLf &
                    "Símbolo: " + Root(i).Simbolo & vbCrLf &
                    "Preço Limite: " + Root(i).Preco_Limite & vbCrLf &
                    "Volume Quantidade: " + Root(i).Volume_Quantidade & vbCrLf &
                    "Lado Direção: " + Root(i).Lado_Direcao & vbCrLf &
                    "Status: " + Root(i).Status & vbCrLf &
                    "Gatilho Stop: " + Root(i).Gatilho_Stop_Preco & vbCrLf &
                    "Identificação Ordem Limite: " + Root(i).Identificacao_Ordem_Limite & vbCrLf &
                    "Tipo da Ordem: " + Root(i).Tipo_da_Ordem & vbCrLf &
                    "Atualizado Em: " + Root(i).Atualizado_Em & vbCrLf &
                    "Execuções: (" & vbCrLf

                For b = 0 To Root(i).Execucoes.Count - 1
                    A += "Executado Em: " & Root(i).Execucoes(b).Executado_Em & vbCrLf &
                        "Taxa de Transação: " & Root(i).Execucoes(b).Taxa & vbCrLf &
                        "Identificação: " & Root(i).Execucoes(b).Identificacao & vbCrLf &
                        "Símbolo: " & Root(i).Execucoes(b).Simbolo & vbCrLf &
                        "Preço Executado: " & Root(i).Execucoes(b).Preco_Executado & vbCrLf &
                        "Volume Executado: " & Root(i).Execucoes(b).Quantidade_Volume & vbCrLf &
                        "Lado Direção: " & Root(i).Execucoes(b).Lado_Direcao & ")" & vbCrLf & vbCrLf

                Next
            Next

            Return A
        End Function
    End Class
End Namespace
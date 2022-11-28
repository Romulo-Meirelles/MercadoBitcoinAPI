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
    Public Class GetOrder
        Inherits MercadoBitcoinResponse


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


        Public Overrides Function ToString() As String
            Dim A As String = String.Empty


            A += "Preço Médio: " + Preco_Medio & vbCrLf &
                    "Criado Em: " + UnixToTime(Criado_Em) & vbCrLf &
                    "Identificação Externa: " + Identificacao_Externa & vbCrLf &
                    "Taxa: " + Taxa & vbCrLf &
                    "Quantidade Preenchida: " + Quantidade_Preenchida & vbCrLf &
                    "Identificação: " + Identificacao & vbCrLf &
                    "Símbolo: " + Simbolo & vbCrLf &
                    "Preço Limite: " + Preco_Limite & vbCrLf &
                    "Volume Quantidade: " + Volume_Quantidade & vbCrLf &
                    "Lado Direção: " + Lado_Direcao & vbCrLf &
                    "Status: " + Status & vbCrLf &
                    "Gatilho Stop: " + Gatilho_Stop_Preco & vbCrLf &
                    "Identificação Ordem Limite: " + Identificacao_Ordem_Limite & vbCrLf &
                    "Tipo da Ordem: " + Tipo_da_Ordem & vbCrLf &
                    "Atualizado Em: " + UnixToTime(Atualizado_Em) & vbCrLf &
                    "Execuções: (" & vbCrLf

            For b = 0 To Execucoes.Count - 1
                A += "Executado Em: " & UnixToTime(Execucoes(b).Executado_Em) & vbCrLf &
                        "Taxa de Transação: " & Execucoes(b).Taxa & vbCrLf &
                        "Identificação: " & Execucoes(b).Identificacao & vbCrLf &
                        "Símbolo: " & Execucoes(b).Simbolo & vbCrLf &
                        "Preço Executado: " & Execucoes(b).Preco_Executado & vbCrLf &
                        "Volume Executado: " & Execucoes(b).Quantidade_Volume & vbCrLf &
                        "Lado Direção: " & Execucoes(b).Lado_Direcao & ")" & vbCrLf & vbCrLf
            Next


            Return A
        End Function
    End Class
End Namespace
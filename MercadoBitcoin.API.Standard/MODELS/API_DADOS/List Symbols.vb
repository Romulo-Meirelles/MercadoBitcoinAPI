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
    Public Class ListSymbols
        Inherits MercadoBitcoinResponse

        <JsonProperty("base-currency")>
        Public Property Moeda_Base As List(Of String)

        <JsonProperty("currency")>
        Public Property Moeda As List(Of String)

        <JsonProperty("deposit-minimum")>
        Public Property Deposito_Mínimo As List(Of String)

        <JsonProperty("description")>
        Public Property Descricao As List(Of String)

        <JsonProperty("exchange-listed")>
        Public Property Exchange_Listada As List(Of String)

        <JsonProperty("exchange-traded")>
        Public Property Exchange_Negociada As List(Of String)

        <JsonProperty("minmovement")>
        Public Property Movimento_Mínimo As List(Of String)

        <JsonProperty("pricescale")>
        Public Property Escala_de_Preco As List(Of String)

        <JsonProperty("session-regular")>
        Public Property Sessao_Regular As List(Of String)

        <JsonProperty("symbol")>
        Public Property Simbolo As List(Of String)

        <JsonProperty("timezone")>
        Public Property Fuso_Horario As List(Of String)

        <JsonProperty("type")>
        Public Property Tipo As List(Of String)

        <JsonProperty("withdraw-minimum")>
        Public Property Saque_Minimo As List(Of String)

        <JsonProperty("withdrawal-fee")>
        Public Property Taxa_de_Saque As List(Of String)

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            For i = 0 To Moeda_Base.Count - 1
                A += "Moeda Base: " & Moeda_Base(i).ToString & vbCrLf &
                     "Moeda: " & Moeda(i).ToString & vbCrLf &
                     "Depósito Mínimo: " & Deposito_Mínimo(i).ToString & vbCrLf &
                     "Descrição: " & Descricao(i).ToString & vbCrLf &
                     "Exchange Listada: " & Exchange_Listada(i).ToString & vbCrLf &
                     "Exchange Negociada: " & Exchange_Negociada(i).ToString & vbCrLf &
                     "Movimento Mínimo: " & Movimento_Mínimo(i).ToString & vbCrLf &
                     "Escala de Preço: " & Escala_de_Preco(i).ToString & vbCrLf &
                     "Sessão Regular: " & Sessao_Regular(i).ToString & vbCrLf &
                     "Símbolo: " & Simbolo(i).ToString & vbCrLf &
                     "Fuso Horário: " & Fuso_Horario(i).ToString & vbCrLf &
                     "Tipo: " & Tipo(i).ToString & vbCrLf &
                     "Saque Mínimo: " & Saque_Minimo(i).ToString & vbCrLf &
                     "Taxa de Saque: " & Taxa_de_Saque(i).ToString & vbCrLf & vbCrLf
            Next

            Return A
        End Function
    End Class
End Namespace